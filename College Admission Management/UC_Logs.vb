Public Class UC_Logs


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





    'One Unified Function to Initialize Dashboard with Button Clicks and Hover Effects
    Private buttonList As List(Of Button)
    Private activeButton As Button

    Private Sub InitializeDashboard(activeBtn As Button)
        ' Lazy-load the button list and wire events only once
        If buttonList Is Nothing Then
            buttonList = New List(Of Button) From {btnLoadLogs, btnSearch, btnSearch2}
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
                .BackColor = Color.White
                .ForeColor = Color.Red
                .FlatStyle = FlatStyle.Flat
                .FlatAppearance.BorderSize = 0
                .Cursor = Cursors.Hand
            End With
        Next

        ' Highlight selected
        With activeButton
            .BackColor = Color.Green
            .ForeColor = Color.White
            .FlatAppearance.BorderSize = 3
            .FlatAppearance.BorderColor = Color.White
        End With



        'If activeButton Is btnLoadLogs Then
        'Show/Hide Panels(PanelWithDgv & PanelWithDgv2) based on ComboBox(cmbLogType) selection either at Admission Monitoring or Admin Monitoring strings
        '    If cmbLogType.SelectedItem IsNot Nothing Then
        '        Dim selectedLogType As String = cmbLogType.SelectedItem.ToString()
        '        If selectedLogType = "Admission Monitoring" Then
        '            PanelWithDgv.Visible = True
        '        ElseIf selectedLogType = "Admin Monitoring" Then
        '            PanelWithDgv.Visible = False
        '            PanelWithDgv2.Visible = True
        '        Else
        '            PanelWithDgv.Visible = False
        '            PanelWithDgv2.Visible = False
        '        End If
        '    End If


        'Else
        '    PanelWithDgv.Visible = False
        '    PanelWithDgv2.Visible = False



        'End If






    End Sub
    'End SHOW/HIDE Panels Based on Active Button...........................................................

    ' Hover effect
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        Dim btn = CType(sender, Button)
        If btn IsNot activeButton Then
            btn.BackColor = Color.SlateBlue
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

    'End of Unified Function to Initialize Dashboard with Button Clicks and Hover Effects...........................................................


    'On Load Event of User Control
    Private Sub UC_Logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the dashboard with the default active button

        'LOADING THE GIF IMAGE FROM THE EMBEDDED RESOURCE
        ' Step 1: Gets a handle on the current running app
        Dim asm = System.Reflection.Assembly.GetExecutingAssembly()
        ' Step 2: Retrieves the embedded GIF file as a stream
        Dim stream = asm.GetManifestResourceStream("College_Admission_Management.logsGif.gif")
        ' Then Step 3: Converts that stream into an image and loads it into a PictureBox
        PictureBox1.Image = Image.FromStream(stream)


        InitializeDashboard(btnSearch)
        PanelWithDgv.Visible = False
        PanelWithDgv2.Visible = False
        ' Set up the radius for buttons
        RadiusButton(btnLoadLogs, 0.5F)
        RadiusButton(btnSearch, 0.5F)
        RadiusButton(btnSearch2, 0.5F)

        MessageBox.Show(
 "This Logical Feature is Currently Under Huge Construction. Thank you ",
 "Feature in Progress",
 MessageBoxButtons.OK,
 MessageBoxIcon.Information
)
    End Sub



    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        InitializeDashboard(btnSearch)
    End Sub

    Private Sub btnSearch2_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        InitializeDashboard(btnSearch2)
    End Sub

    Private Sub btnLoadLogs_Click(sender As Object, e As EventArgs) Handles btnLoadLogs.Click
        ' Load logs logic here
        InitializeDashboard(btnLoadLogs)
        If cmbLogType.SelectedItem IsNot Nothing Then
            Dim selectedLogType As String = cmbLogType.SelectedItem.ToString()
            If selectedLogType = "Admission Monitoring" Then


                PanelWithDgv2.Visible = False
                PanelWithDgv.Visible = True
                MessageBox.Show("Admission loaded successfully!")
            ElseIf selectedLogType = "Admin Monitoring" Then
                PanelWithDgv2.Visible = True

                PanelWithDgv.Visible = True
                MessageBox.Show("Admin loaded successfully!")



            End If
        End If


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


End Class
