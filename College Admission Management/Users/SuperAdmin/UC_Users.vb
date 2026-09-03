Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class UC_Users

    ' State management
    Private _currentUpdateId As Integer = 0 ' 0 = INSERT, >0 = UPDATE
    Private ReadOnly userRegex As New Regex("^[A-Za-z0-9_]+$") ' Alphanumeric and underscores for robust usernames
    Private errProvider As New ErrorProvider()

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
            buttonList = New List(Of Button) From {btnAddDepartmentalAdmin, btnUpdateDepartmentalAdmin, btnDeleteDepartmentalAdmin, btnSearch}
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
        If activeButton Is btnAddDepartmentalAdmin Or activeButton Is btnUpdateDepartmentalAdmin Then
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
            btn.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs)
        Dim btn = CType(sender, Button)
        btn.BackColor = Color.Red
    End Sub

    ' =========================================================================
    ' ON LOAD
    ' =========================================================================
    Private Sub UC_Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Strict Authorization Guard
        If Not SessionManager.IsSuperAdmin() Then
            MessageBox.Show("Unauthorized access detected. This screen is for SuperAdmins only.", "Security Violation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Enabled = False
            Return
        End If

        InitializeDashboard(btnSearch)

        RadiusButton(btnAddDepartmentalAdmin, 0.5F)
        RadiusButton(btnUpdateDepartmentalAdmin, 0.5F)
        RadiusButton(btnDeleteDepartmentalAdmin, 0.5F)
        RadiusButton(btnSearch, 0.5F)

        ' GridView Styling & Configuration
        With dgvUsers
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.SelectionBackColor = Color.LightBlue
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AllowUserToAddRows = False
        End With

        ApplyBeautifulStyle(dgvUsers)
        AdjustDataGridViewRowHeight(dgvUsers, 50)

        LoadDepartmentsDropdown()
        LoadUsers()
    End Sub

    Private Sub ApplyBeautifulStyle(dgv As DataGridView)
        ' Safe wrapper if module method exists
    End Sub

    Private Sub AdjustDataGridViewRowHeight(dgv As DataGridView, height As Integer)
        dgv.RowTemplate.Height = height
    End Sub

    ' =========================================================================
    ' DATABASE BINDING (MySQL)
    ' =========================================================================
    Private Sub LoadDepartmentsDropdown()
        Try
            Using conn = Database.GetOpenConnection()
                Dim query As String = "SELECT department_id, name FROM departments ORDER BY name ASC"
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
            MessageBox.Show("Error loading departments dropdown: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadUsers(Optional search As String = "")
        Try
            Using conn = Database.GetOpenConnection()
                Dim query As String = "SELECT u.user_id, u.username, u.role, u.department_id, d.name AS DepartmentName, u.last_login " &
                                      "FROM users u " &
                                      "LEFT JOIN departments d ON u.department_id = d.department_id " &
                                      "WHERE u.role = 'department_admin'"

                If Not String.IsNullOrWhiteSpace(search) Then
                    query &= " AND (u.username LIKE @search OR d.name LIKE @search)"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrWhiteSpace(search) Then
                        cmd.Parameters.AddWithValue("@search", "%" & search & "%")
                    End If

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        dgvUsers.DataSource = dt

                        ' Format Columns
                        If dgvUsers.Columns.Contains("user_id") Then dgvUsers.Columns("user_id").Visible = False
                        If dgvUsers.Columns.Contains("department_id") Then dgvUsers.Columns("department_id").Visible = False
                        If dgvUsers.Columns.Contains("role") Then dgvUsers.Columns("role").Visible = False

                        If dgvUsers.Columns.Contains("username") Then dgvUsers.Columns("username").HeaderText = "Admin Username"
                        If dgvUsers.Columns.Contains("DepartmentName") Then dgvUsers.Columns("DepartmentName").HeaderText = "Assigned Department"
                        If dgvUsers.Columns.Contains("last_login") Then dgvUsers.Columns("last_login").HeaderText = "Last Login"
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadUsers(txtSearch.Text.Trim())
    End Sub

    ' =========================================================================
    ' REAL-TIME VALIDATIONS
    ' =========================================================================
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            errProvider.SetError(txtUsername, "Username is required.")
        ElseIf Not userRegex.IsMatch(txtUsername.Text.Trim()) Then
            errProvider.SetError(txtUsername, "Only letters, numbers, and underscores allowed.")
        Else
            errProvider.SetError(txtUsername, "")
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If String.IsNullOrWhiteSpace(txtPassword.Text) AndAlso _currentUpdateId = 0 Then
            errProvider.SetError(txtPassword, "Password is required.")
        ElseIf Not String.IsNullOrWhiteSpace(txtPassword.Text) AndAlso txtPassword.Text.Length < 4 Then
            errProvider.SetError(txtPassword, "Password must be at least 4 characters.")
        Else
            errProvider.SetError(txtPassword, "")
        End If
    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged
        If cmbDepartment.SelectedIndex = -1 Then
            errProvider.SetError(cmbDepartment, "Please select a department.")
        Else
            errProvider.SetError(cmbDepartment, "")
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        errProvider.Clear()
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse Not userRegex.IsMatch(txtUsername.Text.Trim()) Then
            errProvider.SetError(txtUsername, "Valid alphanumeric username is required.")
            isValid = False
        End If

        ' Password is required on insert, optional on update if keeping old password
        If _currentUpdateId = 0 AndAlso (String.IsNullOrWhiteSpace(txtPassword.Text) OrElse txtPassword.Text.Length < 4) Then
            errProvider.SetError(txtPassword, "Password must be at least 4 characters long.")
            isValid = False
        End If

        If cmbDepartment.SelectedIndex = -1 OrElse cmbDepartment.SelectedValue Is Nothing Then
            errProvider.SetError(cmbDepartment, "Please select a valid target department.")
            isValid = False
        End If

        Return isValid
    End Function

    Private Sub ClearForm()
        _currentUpdateId = 0
        txtUsername.Clear()
        txtPassword.Clear()
        cmbDepartment.SelectedIndex = -1
        errProvider.Clear()
        dgvUsers.ClearSelection()
        txtUsername.Focus()
    End Sub

    ' =========================================================================
    ' BUTTON ACTIONS (FULLY WIRED TO WORKFLOW & DATABASE)
    ' =========================================================================

    ' 1. ADD / SUBMIT BUTTON ACTION
    Private Sub btnAddDepartmentalAdmin_Click(sender As Object, e As EventArgs) Handles btnAddDepartmentalAdmin.Click
        ' If we are currently viewing the grid, switch to input mode for a fresh creation
        If Not PanelInputBundle.Visible Then
            ClearForm()
            InitializeDashboard(btnAddDepartmentalAdmin)
            Return
        End If

        ' If we are already on the input view, this click acts as the SUBMIT/SAVE action
        SaveUserAccount()
    End Sub

    ' 2. UPDATE SELECTION BUTTON ACTION
    Private Sub btnUpdateDepartmentalAdmin_Click(sender As Object, e As EventArgs) Handles btnUpdateDepartmentalAdmin.Click
        ' If we are looking at the grid view, load the selected row into the form for editing
        If Not PanelInputBundle.Visible Then
            If dgvUsers.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a Department Admin from the grid first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                InitializeDashboard(btnSearch)
                Return
            End If

            Dim row = dgvUsers.SelectedRows(0)
            _currentUpdateId = Convert.ToInt32(row.Cells("user_id").Value)
            txtUsername.Text = row.Cells("username").Value.ToString()

            Dim deptId As Integer = Convert.ToInt32(row.Cells("department_id").Value)
            cmbDepartment.SelectedValue = deptId
            txtPassword.Clear()
            errProvider.SetError(txtPassword, "Leave blank to keep current password, or type a new one to update.")

            InitializeDashboard(btnUpdateDepartmentalAdmin)
            MessageBox.Show("Data loaded. Modify the fields and click 'Add/Save' to commit changes.", "Update Mode", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' If we are already in the input view, clicking this commits the update
            SaveUserAccount()
        End If
    End Sub

    ' 3. DELETE BUTTON ACTION
    Private Sub btnDeleteDepartmentalAdmin_Click(sender As Object, e As EventArgs) Handles btnDeleteDepartmentalAdmin.Click
        InitializeDashboard(btnDeleteDepartmentalAdmin)

        If dgvUsers.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a Department Admin from the grid to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            InitializeDashboard(btnSearch)
            Return
        End If

        Dim row = dgvUsers.SelectedRows(0)
        Dim userId As Integer = Convert.ToInt32(row.Cells("user_id").Value)
        Dim targetUsername As String = row.Cells("username").Value.ToString()

        If MessageBox.Show($"Are you sure you want to PERMANENTLY delete the admin account '{targetUsername}'?", "CRITICAL WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then
            InitializeDashboard(btnSearch)
            Return
        End If

        Try
            Using conn = Database.GetOpenConnection()
                Dim deleteQuery As String = "DELETE FROM users WHERE user_id = @id AND role = 'department_admin'"
                Using cmd As New MySqlCommand(deleteQuery, conn)
                    cmd.Parameters.AddWithValue("@id", userId)
                    Dim rowsAffected = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("✅ Department Admin account deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Delete failed. Record may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

            ClearForm()
            LoadUsers()
            InitializeDashboard(btnSearch)

        Catch ex As Exception
            MessageBox.Show("Database Error during deletion: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================================================================
    ' CORE DATABASE SAVE ROUTINE (INSERT / UPDATE)
    ' =========================================================================
    Public Sub SaveUserAccount()
        If Not SessionManager.IsSuperAdmin() Then Return
        If Not ValidateForm() Then Return

        Try
            Using conn = Database.GetOpenConnection()
                ' Check for duplicate usernames
                Dim checkQuery As String = "SELECT COUNT(*) FROM users WHERE username = @user AND user_id != @id"
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())
                    checkCmd.Parameters.AddWithValue("@id", _currentUpdateId)
                    If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                        MessageBox.Show("This username is already taken by another account.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                If _currentUpdateId = 0 Then
                    ' INSERT NEW DEPARTMENT ADMIN
                    Dim insertQuery As String = "INSERT INTO users (username, password_hash, role, department_id) VALUES (@user, @pass, 'department_admin', @deptId)"
                    Using cmd As New MySqlCommand(insertQuery, conn)
                        cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim())
                        cmd.Parameters.AddWithValue("@deptId", Convert.ToInt32(cmbDepartment.SelectedValue))
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("✅ Department Admin account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' UPDATE EXISTING DEPARTMENT ADMIN (Handle optional password update)
                    Dim updateQuery As String
                    If String.IsNullOrWhiteSpace(txtPassword.Text) Then
                        updateQuery = "UPDATE users SET username = @user, department_id = @deptId WHERE user_id = @id"
                    Else
                        updateQuery = "UPDATE users SET username = @user, password_hash = @pass, department_id = @deptId WHERE user_id = @id"
                    End If

                    Using cmd As New MySqlCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("@id", _currentUpdateId)
                        cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())
                        If Not String.IsNullOrWhiteSpace(txtPassword.Text) Then
                            cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim())
                        End If
                        cmd.Parameters.AddWithValue("@deptId", Convert.ToInt32(cmbDepartment.SelectedValue))
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("✅ Department Admin account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

            ClearForm()
            LoadUsers()
            InitializeDashboard(btnSearch)

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================================================================
    ' SHORTCUTS & UTILITIES
    ' =========================================================================
    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbDepartment.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick
        ' Optional grid cell interaction handling
    End Sub

End Class