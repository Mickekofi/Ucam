Imports MySql.Data.MySqlClient

Public Class login

    ' Tooltip instance for the form
    Private uiTooltip As New ToolTip()

    'Function For Radius Button (Control[Name], size)
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

    'Focus on the username field when the form loads
    Private Sub login_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtUserName.Focus()
    End Sub

    'ON LOAD
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Text = "System Authentication"

        RadiusButton(btnLogin, 1.0F)
        Me.Opacity = 0
        fadeTimer2.Start()
        AddHandler fadeTimer2.Tick, AddressOf FadeIn

        ' Setup Tooltips
        uiTooltip.SetToolTip(txtUserName, "Enter your assigned system username.")
        uiTooltip.SetToolTip(txtPassword, "Enter your password. (Case-sensitive)")
        uiTooltip.SetToolTip(btnLogin, "Authenticate and access your assigned dashboard.")

        ' Clear the textboxes for a clean state
        txtUserName.Clear()
        txtPassword.Clear()

        ' Ensure password masking is strictly enforced
        txtPassword.UseSystemPasswordChar = True

        Try
            Dim asm = System.Reflection.Assembly.GetExecutingAssembly()
            Dim stream = asm.GetManifestResourceStream("College_Admission_Management.profile_paint_anime.gif")
            If stream IsNot Nothing Then
                PictureBox1.Image = Image.FromStream(stream)
            End If
        Catch ex As Exception
            ' Silently fail image load rather than crashing the login screen
            Console.WriteLine("Could not load embedded resource: " & ex.Message)
        End Try
    End Sub

    Private Sub FadeIn(sender As Object, e As EventArgs)
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        Else
            fadeTimer2.Stop()
            RemoveHandler fadeTimer2.Tick, AddressOf FadeIn
        End If
    End Sub

    ' KEYDOWN EVENTS
    Private Sub txtUserName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    ' =========================================================================
    ' CORE AUTHENTICATION LOGIC
    ' =========================================================================
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim enteredUser As String = txtUserName.Text.Trim()
        Dim enteredPass As String = txtPassword.Text.Trim()

        ' 1. Basic Validation
        If String.IsNullOrEmpty(enteredUser) OrElse String.IsNullOrEmpty(enteredPass) Then
            MessageBox.Show("Please enter both username and password.", "Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUserName.Focus()
            Return
        End If

        ' Disable button to prevent spam clicking while database queries
        btnLogin.Enabled = False
        btnLogin.Text = "Authenticating..."

        Try
            ' 2. Database Verification
            Using conn = Database.GetOpenConnection()
                ' Note: We are comparing plain text for now. You MUST change this to use BCrypt/Argon2 later.
                Dim query As String = "SELECT user_id, username, role, department_id FROM users WHERE username = @user AND password_hash = @pass"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user", enteredUser)
                    cmd.Parameters.AddWithValue("@pass", enteredPass)

                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' 3. Extract User Data
                            Dim userId As Integer = Convert.ToInt32(reader("user_id"))
                            Dim dbUsername As String = reader("username").ToString()
                            Dim role As String = reader("role").ToString()

                            Dim deptId As Nullable(Of Integer) = Nothing
                            If Not IsDBNull(reader("department_id")) Then
                                deptId = Convert.ToInt32(reader("department_id"))
                            End If

                            ' Close reader immediately so we can run the update query on the same connection
                            reader.Close()

                            ' 4. Update Last Login Timestamp
                            Dim updateQuery As String = "UPDATE users SET last_login = CURRENT_TIMESTAMP WHERE user_id = @id"
                            Using updateCmd As New MySqlCommand(updateQuery, conn)
                                updateCmd.Parameters.AddWithValue("@id", userId)
                                updateCmd.ExecuteNonQuery()
                            End Using

                            ' 5. LOCK IN THE SESSION
                            SessionManager.StartSession(userId, dbUsername, role, deptId)

                            ' 6. Routing
                            If SessionManager.IsSuperAdmin() Then
                                Dim SDashboard As New SuperAdminDashboard()
                                SDashboard.Show()
                            ElseIf SessionManager.IsDepartmentAdmin() Then
                                Dim dp As New DepartmentalAdminDashboard()
                                dp.Show()
                            Else
                                MessageBox.Show("Your account role is invalid or you are missing a department assignment. Contact the system administrator.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                SessionManager.EndSession()
                                btnLogin.Enabled = True
                                btnLogin.Text = "Login"
                                Return
                            End If

                            Me.Hide()
                        Else
                            ' Authentication Failed
                            MessageBox.Show("Invalid username or password. Access denied.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtPassword.Clear()
                            txtPassword.Focus()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("System Error during authentication: " & ex.Message, "Critical Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Always restore button state
            btnLogin.Enabled = True
            btnLogin.Text = "Login"
        End Try
    End Sub

    ' App Exit
    Private Sub login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class