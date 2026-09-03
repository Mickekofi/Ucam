Imports System.Drawing.Text
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports MySql.Data.MySqlClient

Public Class UC_Departments

    ' State management
    Private _currentUpdateId As Integer = 0 ' 0 = INSERT, >0 = UPDATE
    Dim ep As New ErrorProvider()
    Private buttonList As List(Of Button)
    Private activeButton As Button

    ' =========================================================================
    ' UI RENDERING & DASHBOARD INITIALIZATION
    ' =========================================================================
    Public Sub RadiusButton(btn As Button, circleness As Single)
        If circleness <= 0 Then Exit Sub
        Dim radius As Integer
        Dim diameter As Integer = Math.Min(btn.Width, btn.Height)
        If circleness >= 1 Then
            radius = diameter \ 2
        Else
            radius = CInt((diameter \ 2) * circleness)
        End If
        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(0, 0, radius * 2, radius * 2, 180, 90)
        path.AddArc(btn.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90)
        path.AddArc(btn.Width - (radius * 2), btn.Height - (radius * 2), radius * 2, radius * 2, 0, 90)
        path.AddArc(0, btn.Height - (radius * 2), radius * 2, radius * 2, 90, 90)
        path.CloseFigure()
        btn.Region = New Region(path)
    End Sub

    Private Sub InitializeDashboard(activeBtn As Button)
        If buttonList Is Nothing Then
            buttonList = New List(Of Button) From {btnAddDepartment, btnDeleteDepartment, btnUpdateDepartment, btnSearch}
            For Each btn In buttonList
                AddHandler btn.MouseEnter, AddressOf Button_MouseEnter
                AddHandler btn.MouseLeave, AddressOf Button_MouseLeave
                AddHandler btn.MouseDown, AddressOf Button_MouseDown
            Next
        End If

        activeButton = activeBtn

        For Each btn In buttonList
            With btn
                .BackColor = Color.White
                .ForeColor = Color.Red
                .FlatStyle = FlatStyle.Flat
                .FlatAppearance.BorderSize = 0
                .Cursor = Cursors.Hand
            End With
        Next

        With activeButton
            .BackColor = Color.Black
            .ForeColor = Color.White
            .FlatAppearance.BorderSize = 3
            .FlatAppearance.BorderColor = Color.White
        End With

        ' View Routing
        If activeButton Is btnAddDepartment Or activeButton Is btnUpdateDepartment Then
            PanelInputBundle.Visible = True
            PanelRedDesign.Visible = True
            PanelWithDgv.Dock = DockStyle.None
            PanelWithDgv.Visible = False
        Else
            PanelInputBundle.Visible = False
            PanelRedDesign.Visible = False
            PanelWithDgv.Visible = True
        End If
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        Dim btn = CType(sender, Button)
        If btn IsNot activeButton Then
            btn.BackColor = Color.Black
            btn.ForeColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        Dim btn = CType(sender, Button)
        If btn IsNot activeButton Then
            btn.BackColor = Color.White
            btn.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs)
        Dim btn = CType(sender, Button)
        btn.BackColor = Color.Red
    End Sub

    ' =========================================================================
    ' LOAD EVENT
    ' =========================================================================
    Private Sub UC_Departments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not SessionManager.IsSuperAdmin() Then
            MessageBox.Show("Unauthorized access detected. This screen is for SuperAdmins only.", "Security Violation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Enabled = False
            Return
        End If

        RadiusButton(btnAddDepartment, 0.5F)
        RadiusButton(btnDeleteDepartment, 0.5F)
        RadiusButton(btnUpdateDepartment, 0.5F)
        RadiusButton(btnSearch, 0.5F)

        InitializeDashboard(btnSearch)
        LoadDepartments()

        dgvDepartments.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDepartments.Size = New Size(Me.Width - 40, Me.Height - 180)
        dgvDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDepartments.MultiSelect = False
        dgvDepartments.ReadOnly = True
        dgvDepartments.AllowUserToAddRows = False
        dgvDepartments.DefaultCellStyle.ForeColor = Color.Black
        dgvDepartments.DefaultCellStyle.BackColor = Color.White
        dgvDepartments.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        AdjustDataGridViewRowHeight(dgvDepartments, 100)
    End Sub

    Private Sub AdjustDataGridViewRowHeight(dgv As DataGridView, height As Integer)
        dgv.RowTemplate.Height = height
    End Sub

    ' =========================================================================
    ' LIVE TEXTCHANGE VALIDATIONS (REGEX & ERROR PROVIDER)
    ' =========================================================================
    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If Not Regex.IsMatch(txtName.Text.Trim(), "^[A-Za-z\s]+$") Then
            ep.SetError(txtName, "Department name must contain only letters.")
        Else
            ep.SetError(txtName, "")
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If Not Regex.IsMatch(txtEmail.Text.Trim(), "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") Then
            ep.SetError(txtEmail, "Invalid email format.")
        Else
            ep.SetError(txtEmail, "")
        End If
    End Sub

    Private Sub txtQuota_TextChanged(sender As Object, e As EventArgs) Handles txtQuota.TextChanged
        If Not Regex.IsMatch(txtQuota.Text.Trim(), "^\d+$") Then
            ep.SetError(txtQuota, "Quota must be a positive number.")
        Else
            ep.SetError(txtQuota, "")
        End If
    End Sub

    Private Sub dtpYear_ValueChanged(sender As Object, e As EventArgs) Handles dtpYear.ValueChanged
        If dtpYear.Value > DateTime.Now Then
            ep.SetError(dtpYear, "Active year cannot be set in the future.")
        Else
            ep.SetError(dtpYear, "")
        End If
    End Sub

    ' Live JSON Validation - Parses in real time
    Private Sub txtJson_TextChanged(sender As Object, e As EventArgs) Handles txtJson.TextChanged
        If String.IsNullOrWhiteSpace(txtJson.Text) Then
            ep.SetError(txtJson, "Criteria JSON cannot be empty.")
            Return
        End If

        Try
            JToken.Parse(txtJson.Text.Trim())
            ep.SetError(txtJson, "") ' It is valid JSON, clear the error
        Catch ex As Exception
            ep.SetError(txtJson, "Invalid JSON structure. Missing comma, bracket, or quote.")
        End Try
    End Sub

    Private Function IsFormValid() As Boolean
        Return ep.GetError(txtName) = "" AndAlso
               ep.GetError(txtEmail) = "" AndAlso
               ep.GetError(txtQuota) = "" AndAlso
               ep.GetError(dtpYear) = "" AndAlso
               ep.GetError(txtJson) = "" AndAlso
               Not String.IsNullOrWhiteSpace(txtName.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtJson.Text)
    End Function

    ' =========================================================================
    ' JSON TEMPLATE GENERATOR (No more blocking popups)
    ' =========================================================================
    ' =========================================================================
    ' JSON TEMPLATE GENERATOR (InputBox Loop Mode)
    ' =========================================================================
    Private Sub btnGenerateJson_Click(sender As Object, e As EventArgs) Handles btnGenerateJson.Click
        Try
            ' 1. Basic configuration
            Dim electivesStr = InputBox("Enter number of electives required:", "Criteria Builder", "2")
            If String.IsNullOrWhiteSpace(electivesStr) Then Exit Sub
            Dim electivesRequired As Integer = Val(electivesStr)

            Dim aggregateMaxStr = InputBox("Enter aggregate maximum (e.g., 24 for WAEC):", "Criteria Builder", "24")
            If String.IsNullOrWhiteSpace(aggregateMaxStr) Then Exit Sub
            Dim aggregateMax As Integer = Val(aggregateMaxStr)

            Dim minAggregateStr = InputBox("Enter minimum acceptable aggregate:", "Criteria Builder", "12")
            If String.IsNullOrWhiteSpace(minAggregateStr) Then Exit Sub
            Dim minAggregate As Integer = Val(minAggregateStr)

            ' 2. Core Subjects (Fixed standard map)
            Dim coreSubjects As New List(Of String)({"English", "Mathematics", "Integrated Science", "Social Studies"})
            Dim gradeMap As New Dictionary(Of String, Integer) From {
                {"A1", 1}, {"B2", 2}, {"B3", 3}, {"C4", 4}, {"C5", 5}, {"C6", 6}, {"D7", 7}, {"E8", 8}, {"F9", 9}
            }

            ' 3. Subject Requirements Loop
            Dim subjectReqs As New List(Of Object)()
            Do
                Dim subj As String = InputBox("Enter a subject requirement (leave blank to stop adding subjects):", "Subject Requirements", "Mathematics")
                If String.IsNullOrWhiteSpace(subj) Then Exit Do

                Dim maxGrade As String = InputBox("Enter maximum allowed grade for " & subj & " (e.g., C6):", "Subject Requirements", "C6")
                subjectReqs.Add(New With {.subject = subj, .max_grade = maxGrade})

                If MessageBox.Show("Add another subject requirement?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Do
            Loop

            ' 4. Subject Weights Loop
            Dim weights As New Dictionary(Of String, Decimal)()
            Do
                Dim subj As String = InputBox("Enter subject to weight (leave blank to stop adding weights):", "Subject Weights", "Mathematics")
                If String.IsNullOrWhiteSpace(subj) Then Exit Do

                Dim wtStr As String = InputBox("Enter weight multiplier for " & subj & " (e.g., 1.5):", "Subject Weights", "1.5")
                weights.Add(subj, Val(wtStr))

                If MessageBox.Show("Add another subject weight?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Do
            Loop

            ' 5. Tie Breakers (Hardcoded defaults for consistency)
            Dim tieBreakers As New List(Of String)({"aggregate_asc", "math_grade_asc", "dob_older_first"})

            ' 6. Compile JSON Object
            Dim criteria As Object = New With {
                .aggregate_formula = New With {
                    .core_subjects = coreSubjects,
                    .electives_required = electivesRequired,
                    .grade_map = gradeMap,
                    .aggregate_max = aggregateMax,
                    .min_aggregate = minAggregate
                },
                .subject_requirements = subjectReqs,
                .weights = weights,
                .tie_breakers = tieBreakers
            }

            ' 7. Inject into Textbox (This triggers the txtJson_TextChanged event to instantly validate it)
            txtJson.Text = JsonConvert.SerializeObject(criteria, Formatting.Indented)

        Catch ex As Exception
            MessageBox.Show("Criteria Builder interrupted or encountered an error: " & ex.Message, "Builder Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


    ' =========================================================================
    ' CLEAR AND RESET
    ' =========================================================================
    Private Sub ClearInputs()
        txtName.Clear()
        txtEmail.Clear()
        txtQuota.Clear()
        txtJson.Clear()
        dtpYear.Value = DateTime.Now
        ep.Clear() ' Wipe all validation errors
        _currentUpdateId = 0
        txtName.Focus()
    End Sub

    ' =========================================================================
    ' DATABASE CRUD OPERATIONS
    ' =========================================================================
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadDepartments(txtSearch.Text.Trim())
    End Sub

    Private Sub LoadDepartments(Optional search As String = "")
        Try
            Using conn = Database.GetOpenConnection()
                Dim query As String
                If String.IsNullOrWhiteSpace(search) Then
                    query = "SELECT department_id, name, email, quota, criteria_json, active_year, created_at FROM departments"
                Else
                    query = "SELECT department_id, name, email, quota, criteria_json, active_year, created_at FROM departments WHERE name LIKE @search"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrWhiteSpace(search) Then
                        cmd.Parameters.AddWithValue("@search", "%" & search & "%")
                    End If

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        dgvDepartments.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data from database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' The Add / Submit Button
    Private Sub btnAddDepartment_Click(sender As Object, e As EventArgs) Handles btnAddDepartment.Click
        ' View toggle logic
        If Not PanelInputBundle.Visible Then
            ClearInputs()
            InitializeDashboard(btnAddDepartment)
            Return
        End If

        If Not SessionManager.IsSuperAdmin() Then Return

        ' Strict validation check
        If Not IsFormValid() Then
            MessageBox.Show("Please fix the validation errors marked with the red icon before submitting.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim quotaValue As Integer = Convert.ToInt32(txtQuota.Text.Trim())

        Try
            Using conn = Database.GetOpenConnection()
                ' Prevent duplicates
                Dim checkQuery As String = "SELECT COUNT(*) FROM departments WHERE (name = @name OR email = @email) AND department_id != @id"
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                    checkCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                    checkCmd.Parameters.AddWithValue("@id", _currentUpdateId)
                    If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                        MessageBox.Show("A department with this name or email already exists.", "Duplicate Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                If _currentUpdateId = 0 Then
                    Dim insertQuery As String = "INSERT INTO departments (name, email, quota, criteria_json, active_year) VALUES (@name, @email, @quota, @json, @year)"
                    Using cmd As New MySqlCommand(insertQuery, conn)
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                        cmd.Parameters.AddWithValue("@quota", quotaValue)
                        cmd.Parameters.AddWithValue("@json", txtJson.Text.Trim())
                        cmd.Parameters.AddWithValue("@year", dtpYear.Value.Year)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("✅ Department added successfully!")
                Else
                    Dim updateQuery As String = "UPDATE departments SET name=@name, email=@email, quota=@quota, criteria_json=@json, active_year=@year WHERE department_id=@id"
                    Using cmd As New MySqlCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("@id", _currentUpdateId)
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                        cmd.Parameters.AddWithValue("@quota", quotaValue)
                        cmd.Parameters.AddWithValue("@json", txtJson.Text.Trim())
                        cmd.Parameters.AddWithValue("@year", dtpYear.Value.Year)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("✅ Department updated successfully!")
                End If
            End Using

            ClearInputs()
            LoadDepartments()
            InitializeDashboard(btnSearch)

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateDepartment_Click(sender As Object, e As EventArgs) Handles btnUpdateDepartment.Click
        If Not SessionManager.IsSuperAdmin() Then Return

        If dgvDepartments.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a department from the grid first.")
            InitializeDashboard(btnSearch)
            Exit Sub
        End If

        Dim row = dgvDepartments.SelectedRows(0)
        _currentUpdateId = Convert.ToInt32(row.Cells("department_id").Value)

        ' Loading values triggers the TextChanged validations automatically
        txtName.Text = row.Cells("name").Value.ToString()
        txtEmail.Text = row.Cells("email").Value.ToString()
        txtQuota.Text = row.Cells("quota").Value.ToString()

        Dim yearVal As Integer
        If Integer.TryParse(row.Cells("active_year").Value.ToString(), yearVal) Then
            dtpYear.Value = New DateTime(yearVal, 1, 1)
        End If

        txtJson.Text = If(row.Cells("criteria_json").Value IsNot Nothing, row.Cells("criteria_json").Value.ToString(), "")

        InitializeDashboard(btnUpdateDepartment)
        MessageBox.Show("Data loaded. Modify the fields on the left and click 'Add Department' to save your changes.", "Update Mode", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDeleteDepartment_Click(sender As Object, e As EventArgs) Handles btnDeleteDepartment.Click
        If Not SessionManager.IsSuperAdmin() Then Return

        If dgvDepartments.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a department to delete.")
            InitializeDashboard(btnSearch)
            Exit Sub
        End If

        Dim row = dgvDepartments.SelectedRows(0)
        Dim id As Integer = Convert.ToInt32(row.Cells("department_id").Value)
        Dim deptName As String = row.Cells("name").Value.ToString()

        If MessageBox.Show($"Are you sure you want to delete {deptName}?", "CRITICAL WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Exit Sub

        Try
            Using conn = Database.GetOpenConnection()
                Dim deleteQuery As String = "DELETE FROM departments WHERE department_id = @id"
                Using cmd As New MySqlCommand(deleteQuery, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            LoadDepartments()
            InitializeDashboard(btnSearch)
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvDepartments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartments.CellContentClick

    End Sub
End Class