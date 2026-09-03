Imports System.Drawing.Text
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class UC_Programs

    ' State management
    Private _currentUpdateId As Integer = 0 ' 0 = INSERT, >0 = UPDATE
    Private ReadOnly nameRegex As New Regex("^[A-Za-z\s]+$")
    Dim errProvider As New ErrorProvider()

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
            buttonList = New List(Of Button) From {btnAddProgram, btnUpdateProgram, btnDeleteProgram, btnSearch}
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
        If activeButton Is btnAddProgram Or activeButton Is btnUpdateProgram Then
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
        btn.BackColor = Color.Indigo
    End Sub

    ' =========================================================================
    ' ON LOAD
    ' =========================================================================
    Private Sub UC_Programs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Strict Authorization
        If Not SessionManager.IsSuperAdmin() Then
            MessageBox.Show("Unauthorized access detected. This screen is for SuperAdmins only.", "Security Violation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Enabled = False
            Return
        End If

        RadiusButton(btnAddProgram, 0.5F)
        RadiusButton(btnDeleteProgram, 0.5F)
        RadiusButton(btnUpdateProgram, 0.5F)
        RadiusButton(btnSearch, 0.5F)

        ' Setup Numeric constraints
        numUpDownMinAggregate.Minimum = 0
        numUpDownMinAggregate.Maximum = 100
        numUpDownMinAggregate.Value = 0

        ' Initialize DataGridView
        dgvPrograms.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPrograms.Size = New Size(Me.Width - 40, Me.Height - 180)
        dgvPrograms.ReadOnly = True
        dgvPrograms.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPrograms.MultiSelect = False
        dgvPrograms.AllowUserToAddRows = False
        dgvPrograms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPrograms.DefaultCellStyle.ForeColor = Color.Black
        dgvPrograms.DefaultCellStyle.BackColor = Color.White
        dgvPrograms.DefaultCellStyle.SelectionBackColor = Color.LightBlue
        dgvPrograms.DefaultCellStyle.SelectionForeColor = Color.Black

        AdjustDataGridViewRowHeight(dgvPrograms, 80) ' Set to a reasonable height, 100 is usually too large for standard rows

        InitializeDashboard(btnSearch)
        LoadDepartmentsDropdown()
        LoadPrograms()
    End Sub

    Private Sub AdjustDataGridViewRowHeight(dgv As DataGridView, height As Integer)
        dgv.RowTemplate.Height = height
    End Sub

    ' =========================================================================
    ' DATA BINDING (MySQL)
    ' =========================================================================
    Private Sub LoadDepartmentsDropdown()
        Try
            Using conn = Database.GetOpenConnection()
                Dim query As String = "SELECT department_id, name FROM departments WHERE active_year IS NOT NULL ORDER BY name ASC"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        cmbDepartment.DataSource = dt
                        cmbDepartment.DisplayMember = "name"
                        cmbDepartment.ValueMember = "department_id"
                        cmbDepartment.SelectedIndex = -1
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading departments: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadPrograms(Optional search As String = "")
        Try
            Using conn = Database.GetOpenConnection()
                ' Using a JOIN to pull the parent department name cleanly
                Dim query As String = "SELECT p.program_id, p.name AS ProgramName, p.department_id, d.name AS DepartmentName, p.min_aggregate, p.active " &
                                      "FROM programs p " &
                                      "LEFT JOIN departments d ON p.department_id = d.department_id"

                If Not String.IsNullOrWhiteSpace(search) Then
                    query &= " WHERE p.name LIKE @search OR d.name LIKE @search"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrWhiteSpace(search) Then
                        cmd.Parameters.AddWithValue("@search", "%" & search & "%")
                    End If

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        dgvPrograms.DataSource = dt

                        ' Format Columns
                        If dgvPrograms.Columns.Contains("program_id") Then dgvPrograms.Columns("program_id").Visible = False
                        If dgvPrograms.Columns.Contains("department_id") Then dgvPrograms.Columns("department_id").Visible = False

                        If dgvPrograms.Columns.Contains("ProgramName") Then dgvPrograms.Columns("ProgramName").HeaderText = "Program"
                        If dgvPrograms.Columns.Contains("DepartmentName") Then dgvPrograms.Columns("DepartmentName").HeaderText = "Department"
                        If dgvPrograms.Columns.Contains("min_aggregate") Then dgvPrograms.Columns("min_aggregate").HeaderText = "Min Aggregate"
                        If dgvPrograms.Columns.Contains("active") Then dgvPrograms.Columns("active").HeaderText = "Active"
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading programs: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadPrograms(txtSearch.Text.Trim())
    End Sub

    ' =========================================================================
    ' VALIDATION & LOGIC
    ' =========================================================================
    Private Sub txtProgramName_TextChanged(sender As Object, e As EventArgs) Handles txtProgramName.TextChanged
        Dim input As String = txtProgramName.Text
        If Not Regex.IsMatch(input, "^[A-Za-z\s]*$") Then
            Dim selStart As Integer = txtProgramName.SelectionStart
            Dim originalLength As Integer = txtProgramName.Text.Length

            txtProgramName.Text = Regex.Replace(input, "[^A-Za-z\s]", "")
            Dim newLength As Integer = txtProgramName.Text.Length
            txtProgramName.SelectionStart = Math.Max(0, selStart - (originalLength - newLength))
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        errProvider.Clear()
        Dim ok As Boolean = True

        Dim name As String = txtProgramName.Text.Trim()
        If String.IsNullOrEmpty(name) Then
            errProvider.SetError(txtProgramName, "Program name is required.")
            ok = False
        ElseIf Not nameRegex.IsMatch(name) Then
            errProvider.SetError(txtProgramName, "Program name must contain only letters and spaces.")
            ok = False
        End If

        If cmbDepartment.SelectedIndex = -1 OrElse cmbDepartment.SelectedValue Is Nothing Then
            errProvider.SetError(cmbDepartment, "Please select a department.")
            ok = False
        End If

        Return ok
    End Function

    Private Sub ClearForm()
        _currentUpdateId = 0
        txtProgramName.Clear()
        cmbDepartment.SelectedIndex = -1
        numUpDownMinAggregate.Value = numUpDownMinAggregate.Minimum
        chkIsActive.Checked = True
        errProvider.Clear()
        dgvPrograms.ClearSelection()
        txtProgramName.Focus()
    End Sub

    Private Sub chkIsActive_CheckedChanged(sender As Object, e As EventArgs) Handles chkIsActive.CheckedChanged
        If chkIsActive.Checked Then Return

        Dim res1 = MessageBox.Show("You are about to DEACTIVATE this program. Are you sure?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res1 <> DialogResult.Yes Then
            chkIsActive.Checked = True
            Return
        End If

        Dim res2 = MessageBox.Show("Are you REALLY sure? Deactivating will make the program inactive for applicants.", "Confirm Deactivation (Final)", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res2 <> DialogResult.Yes Then
            chkIsActive.Checked = True
            Return
        End If
    End Sub

    ' =========================================================================
    ' DATABASE CRUD OPERATIONS
    ' =========================================================================

    ' Add / Submit Logic
    Private Sub btnAddProgram_Click(sender As Object, e As EventArgs) Handles btnAddProgram.Click
        ' If in Grid View, just switch to Input View
        If Not PanelInputBundle.Visible Then
            ClearForm()
            InitializeDashboard(btnAddProgram)
            Return
        End If

        If Not SessionManager.IsSuperAdmin() Then Return
        If Not ValidateForm() Then Return

        Try
            Using conn = Database.GetOpenConnection()
                ' Duplicate Check
                Dim checkQuery As String = "SELECT COUNT(*) FROM programs WHERE name = @name AND department_id = @deptId AND program_id != @id"
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@name", txtProgramName.Text.Trim())
                    checkCmd.Parameters.AddWithValue("@deptId", Convert.ToInt32(cmbDepartment.SelectedValue))
                    checkCmd.Parameters.AddWithValue("@id", _currentUpdateId)
                    If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                        MessageBox.Show("This program already exists under the selected department.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                If _currentUpdateId = 0 Then
                    Dim insertQuery As String = "INSERT INTO programs (name, department_id, min_aggregate, active) VALUES (@name, @deptId, @minAgg, @active)"
                    Using cmd As New MySqlCommand(insertQuery, conn)
                        cmd.Parameters.AddWithValue("@name", txtProgramName.Text.Trim())
                        cmd.Parameters.AddWithValue("@deptId", Convert.ToInt32(cmbDepartment.SelectedValue))
                        cmd.Parameters.AddWithValue("@minAgg", Convert.ToInt32(numUpDownMinAggregate.Value))
                        cmd.Parameters.AddWithValue("@active", chkIsActive.Checked)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("✅ Program added successfully.")
                Else
                    Dim updateQuery As String = "UPDATE programs SET name = @name, department_id = @deptId, min_aggregate = @minAgg, active = @active WHERE program_id = @id"
                    Using cmd As New MySqlCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("@id", _currentUpdateId)
                        cmd.Parameters.AddWithValue("@name", txtProgramName.Text.Trim())
                        cmd.Parameters.AddWithValue("@deptId", Convert.ToInt32(cmbDepartment.SelectedValue))
                        cmd.Parameters.AddWithValue("@minAgg", Convert.ToInt32(numUpDownMinAggregate.Value))
                        cmd.Parameters.AddWithValue("@active", chkIsActive.Checked)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("✅ Program updated successfully.")
                End If
            End Using

            ClearForm()
            LoadPrograms()
            InitializeDashboard(btnSearch)

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Edit Request Logic
    Private Sub btnUpdateProgram_Click(sender As Object, e As EventArgs) Handles btnUpdateProgram.Click
        If Not SessionManager.IsSuperAdmin() Then Return

        If dgvPrograms.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a program from the grid to update.", "Select Program", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            InitializeDashboard(btnSearch)
            Return
        End If

        Dim row = dgvPrograms.SelectedRows(0)
        _currentUpdateId = Convert.ToInt32(row.Cells("program_id").Value)

        txtProgramName.Text = row.Cells("ProgramName").Value.ToString()
        numUpDownMinAggregate.Value = Convert.ToDecimal(row.Cells("min_aggregate").Value)
        chkIsActive.Checked = Convert.ToBoolean(row.Cells("active").Value)

        ' Set the combobox to the correct department ID
        Dim deptId As Integer = Convert.ToInt32(row.Cells("department_id").Value)
        cmbDepartment.SelectedValue = deptId

        InitializeDashboard(btnUpdateProgram)
        MessageBox.Show("Data loaded. Modify the fields and click 'Add Program' to save changes.", "Update Mode", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Delete Logic
    Private Sub btnDeleteProgram_Click(sender As Object, e As EventArgs) Handles btnDeleteProgram.Click
        If Not SessionManager.IsSuperAdmin() Then Return

        If dgvPrograms.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a program to delete.", "Select Program", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            InitializeDashboard(btnSearch)
            Return
        End If

        Dim row = dgvPrograms.SelectedRows(0)
        Dim id As Integer = Convert.ToInt32(row.Cells("program_id").Value)
        Dim progName As String = row.Cells("ProgramName").Value.ToString()

        If MessageBox.Show($"Are you sure you want to DELETE '{progName}'? This action will cascade and destroy any admission records linked to it.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then
            Return
        End If

        Try
            Using conn = Database.GetOpenConnection()
                Dim deleteQuery As String = "DELETE FROM programs WHERE program_id = @id"
                Using cmd As New MySqlCommand(deleteQuery, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Program deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadPrograms()
            InitializeDashboard(btnSearch)

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvPrograms_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrograms.CellContentClick

    End Sub
End Class