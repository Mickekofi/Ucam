Public Class DepartmentalAdminDashboard

    ' Function to load a UserControl into the Main Panel called pnlMainContent 
    Private Sub LoadControl(control As UserControl)
        If pnlMainContent Is Nothing OrElse control Is Nothing Then Exit Sub
        pnlMainContent.Controls.Clear()
        control.Dock = DockStyle.Fill
        pnlMainContent.Controls.Add(control)
    End Sub

    ' Function For Radius Button (Control[Name], size)
    Public Sub RadiusButton(btn As Button, circleness As Single)
        If btn Is Nothing OrElse circleness <= 0 Then Exit Sub
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

    ' Function to Circle a Shape with two Parameters (Control[Name], size)
    Public Sub CircleShape(ctrl As Control, circleness As Single)
        If ctrl Is Nothing OrElse circleness <= 0 Then Exit Sub
        Dim radius As Integer
        Dim diameter As Integer = Math.Min(ctrl.Width, ctrl.Height)
        If circleness >= 1 Then
            radius = diameter \ 2
        Else
            radius = CInt((diameter \ 2) * circleness)
        End If
        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(0, 0, radius * 2, radius * 2, 180, 90)
        path.AddArc(ctrl.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90)
        path.AddArc(ctrl.Width - (radius * 2), ctrl.Height - (radius * 2), radius * 2, radius * 2, 0, 90)
        path.AddArc(0, ctrl.Height - (radius * 2), radius * 2, radius * 2, 90, 90)
        path.CloseFigure()
        ctrl.Region = New Region(path)
    End Sub

    ' Unified Function to Initialize Dashboard with Button Clicks and Hover Effects
    Private buttonList As List(Of Button)
    Private activeButton As Button

    Private Sub InitializeDashboard(activeBtn As Button)
        If buttonList Is Nothing Then
            ' Add all dashboard buttons here
            buttonList = New List(Of Button) From {
                btnAdmissions, btnAutoAdmissions
            }
            For Each btn In buttonList
                RemoveHandler btn.Click, AddressOf DashboardButton_Click
                AddHandler btn.Click, AddressOf DashboardButton_Click
                RemoveHandler btn.MouseEnter, AddressOf Button_MouseEnter
                AddHandler btn.MouseEnter, AddressOf Button_MouseEnter
                RemoveHandler btn.MouseLeave, AddressOf Button_MouseLeave
                AddHandler btn.MouseLeave, AddressOf Button_MouseLeave
                RemoveHandler btn.MouseDown, AddressOf Button_MouseDown
                AddHandler btn.MouseDown, AddressOf Button_MouseDown
            Next
        End If

        activeButton = activeBtn

        For Each btn In buttonList
            btn.BackColor = Color.White
            btn.ForeColor = Color.Black
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.Cursor = Cursors.Hand
        Next

        With activeButton
            .BackColor = Color.Black
            .ForeColor = Color.White
            .FlatAppearance.BorderSize = 3
            .FlatAppearance.BorderColor = Color.White
        End With
    End Sub

    ' Unified click handler for dashboard buttons
    Private Sub DashboardButton_Click(sender As Object, e As EventArgs)
        Dim btn = CType(sender, Button)
        InitializeDashboard(btn)
        If btn Is btnAdmissions Then
            Dim admissionsControl As New UC_Admissions
            LoadControl(admissionsControl)

        ElseIf btn Is btnAutoAdmissions Then
            Dim autoAdmissionsControl As New UC_AutoAdmissions
            LoadControl(autoAdmissionsControl)
        End If
    End Sub

    ' Hover effect
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        Dim btn = CType(sender, Button)
        If btn IsNot activeButton Then
            btn.BackColor = Color.Black
            btn.ForeColor = Color.WhiteSmoke
        End If
    End Sub

    ' Hover leave
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        Dim btn = CType(sender, Button)
        If btn IsNot activeButton Then
            btn.BackColor = Color.White
            btn.ForeColor = Color.Black
        End If
    End Sub

    ' Press visual
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs)
        Dim btn = CType(sender, Button)
        btn.BackColor = Color.Indigo
    End Sub

    Private Function GetDepartmentName(deptId As Integer) As String
        ' For Demo Purposes: Return a hardcoded department name instead of querying the database
        Select Case deptId
            Case 1
                Return "Computer Science"
            Case 2
                Return "Engineering"
            Case 3
                Return "Business Administration"
            Case Else
                Return "Demo Department"
        End Select
    End Function

    ' On MAIN LOAD
    Private Sub DepartmentAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        ' Error handling for LoggedInUser mapping during demo standalone runs
        Try
            '  If LoggedInUser IsNot Nothing Then
            'lblDepartment.Text = GetDepartmentName(LoggedInUser.DepartmentId)
            'Else
            'lblDepartment.Text = GetDepartmentName(1) ' Default for demo
            'End If
        Catch ex As Exception
            lblDepartment.Text = "Demo Department"
        End Try

        If PictureBox1 IsNot Nothing Then CircleShape(PictureBox1, 300)
        RadiusButton(btnAdmissions, 0.5F)
        RadiusButton(btnAutoAdmissions, 0.5F)

        ' Load GIF image from embedded resource
        Dim asm = System.Reflection.Assembly.GetExecutingAssembly()
        Dim stream = asm.GetManifestResourceStream("College_Admission_Management.noActivityGif.gif")
        If stream IsNot Nothing AndAlso PictureBox2 IsNot Nothing Then
            PictureBox2.Image = Image.FromStream(stream)
        End If

        InitializeDashboard(btnAdmissions)
    End Sub

    Private Sub btnAutoAdmissions_Click(sender As Object, e As EventArgs) Handles btnAutoAdmissions.Click
        InitializeDashboard(btnAutoAdmissions)
    End Sub

    Private Sub btnAdmissions_Click(sender As Object, e As EventArgs) Handles btnAdmissions.Click
        InitializeDashboard(btnAdmissions)
    End Sub

    Private Sub pnlMainContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlMainContent.Paint

    End Sub

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        login.Show()
    End Sub
End Class