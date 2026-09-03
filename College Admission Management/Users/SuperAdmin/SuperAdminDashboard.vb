Public Class SuperAdminDashboard


    ' a function to load a user control into the main content panel 
    ' Function to load a UserControl into the Main Panel called pnlMainContent 
    Private Sub LoadControl(control As UserControl)
        pnlMainContent.Controls.Clear()
        control.Dock = DockStyle.Fill
        pnlMainContent.Controls.Add(control)
    End Sub

    'Function For Radius Button (Control[Name], size)
    Public Sub RadiusButton(btn As Button, circleness As Single)
        If circleness <= 0 Then Exit Sub
        Dim radius As Integer
        Dim diameter As Integer = Math.Min(btn.Width, btn.Height)
        ' Calculate rounding
        If circleness >= 1 Then
            radius = diameter \ 2
        Else
            radius = CInt((diameter \ 2) * circleness)
        End If
        ' Create rounded region
        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(0, 0, radius * 2, radius * 2, 180, 90)
        path.AddArc(btn.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90)
        path.AddArc(btn.Width - (radius * 2), btn.Height - (radius * 2), radius * 2, radius * 2, 0, 90)
        path.AddArc(0, btn.Height - (radius * 2), radius * 2, radius * 2, 90, 90)
        path.CloseFigure()
        btn.Region = New Region(path)
    End Sub

    'Ended the Radius Function....................................................................................................



    'Function to Circle a Shape with two Parameters (Control[Name], size)
    Public Sub CircleShape(ctrl As Control, circleness As Single)
        If circleness <= 0 Then Exit Sub

        Dim radius As Integer
        Dim diameter As Integer = Math.Min(ctrl.Width, ctrl.Height)

        ' Calculate rounding
        If circleness >= 1 Then
            radius = diameter \ 2
        Else
            radius = CInt((diameter \ 2) * circleness)
        End If

        ' Create rounded region
        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(0, 0, radius * 2, radius * 2, 180, 90)
        path.AddArc(ctrl.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90)
        path.AddArc(ctrl.Width - (radius * 2), ctrl.Height - (radius * 2), radius * 2, radius * 2, 0, 90)
        path.AddArc(0, ctrl.Height - (radius * 2), radius * 2, radius * 2, 90, 90)
        path.CloseFigure()

        ctrl.Region = New Region(path)
    End Sub

    'Ended the Circle Function....................................................................................................



    'One Unified Function to Initialize Dashboard with Button Clicks and Hover Effects
    Private buttonList As List(Of Button)
    Private activeButton As Button


    Private Sub InitializeDashboard(activeBtn As Button)
        ' Lazy-load the button list and wire events only once
        If buttonList Is Nothing Then

            'Just Update or Add Your Target Buttons Here
            buttonList = New List(Of Button) From {
            btnDepartments, btnPrograms, btnAdmins, btnReports}

            ' Assign event handlers to each button
            For Each btn In buttonList
                AddHandler btn.Click, Sub(s, e)
                                          InitializeDashboard(CType(s, Button))
                                      End Sub
                AddHandler btn.MouseEnter, AddressOf Button_MouseEnter
                AddHandler btn.MouseLeave, AddressOf Button_MouseLeave
                AddHandler btn.MouseDown, AddressOf Button_MouseDown
            Next
        End If

        ' Set active button
        activeButton = activeBtn

        ' Style reset for all buttons
        For Each btn In buttonList
            With btn
                '.BackColor = Color.White
                '.ForeColor = Color.Red | Both replaced with Color.Black rather

                btn.BackColor = Color.White
                btn.ForeColor = Color.Black
                .FlatStyle = FlatStyle.Flat
                .FlatAppearance.BorderSize = 0
                .Cursor = Cursors.Hand
            End With
        Next

        ' Highlight selected
        With activeButton
            .BackColor = Color.Black
            .ForeColor = Color.White
            .FlatAppearance.BorderSize = 3
            .FlatAppearance.BorderColor = Color.White
        End With
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

    'Ended the  Unified Function Function....................................................................................................






    'On MAIN LOAD
    Private Sub SuperAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Window State to Maximized
        Me.WindowState = FormWindowState.Maximized


        CircleShape(PictureBox1, 300)
        RadiusButton(btnDepartments, 0.5F)
        RadiusButton(btnPrograms, 0.5F)
        RadiusButton(btnAdmins, 0.5F)
        RadiusButton(btnReports, 0.5F)


        'LOADING THE GIF IMAGE FROM THE EMBEDDED RESOURCE
        ' Step 1: Gets a handle on the current running app
        Dim asm = System.Reflection.Assembly.GetExecutingAssembly()
        ' Step 2: Retrieves the embedded GIF file as a stream
        Dim stream = asm.GetManifestResourceStream("College_Admission_Management.noActivityGif.gif")
        ' Then Step 3: Converts that stream into an image and loads it into a PictureBox
        PictureBox2.Image = Image.FromStream(stream)

        InitializeDashboard(btnAdmins)


    End Sub





    Private Sub btnDepartments_Click(sender As Object, e As EventArgs) Handles btnDepartments.Click
        InitializeDashboard(btnDepartments)
        ' Load Departments content here

        Dim uc As New UC_Departments()
        LoadControl(uc)

    End Sub

    Private Sub btnPrograms_Click(sender As Object, e As EventArgs) Handles btnPrograms.Click
        InitializeDashboard(btnPrograms)
        ' Load Programs content here

        Dim uc_prog As New UC_Programs()
        LoadControl(uc_prog)

    End Sub

    Private Sub btnAdmins_Click(sender As Object, e As EventArgs) Handles btnAdmins.Click
        InitializeDashboard(btnAdmins)
        ' Load Admins content here
        Dim uc_users As New UC_Users()
        LoadControl(uc_users)

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        InitializeDashboard(btnReports)

        Dim uc_reports As New UC_Reports
        LoadControl(uc_reports)

    End Sub







    Private Sub btnLogs_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnLogs_Click_1(sender As Object, e As EventArgs)
        ' Load Logs content here
        Dim uc_logs As New UC_Logs
        LoadControl(uc_logs)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub pnlMainContent_Paint_1(sender As Object, e As PaintEventArgs) Handles pnlMainContent.Paint

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        login.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub panelLeft_Paint(sender As Object, e As PaintEventArgs) Handles panelLeft.Paint

    End Sub
End Class

