Public Class UC_Reports

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
            buttonList = New List(Of Button) From {btnReportControl, btnRefresh, btnExportExcel}
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




        ' Show/hide panels(INPUT & Data Grind View) based on active button.................................
        If activeButton Is btnReportControl Then
            PanelInputBundle.Visible = True
            PanelRedDesign.Visible = True

            PanelWithDgv.Dock = DockStyle.None
            PanelWithDgv.Visible = False

        Else
            PanelInputBundle.Visible = False
            PanelRedDesign.Visible = False

            PanelWithDgv.Visible = True

            'PanelWithDgv.Dock = DockStyle.Bottom
            'PanelWithDgv.Size = New Size(1136, 1000)

        End If
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
    Private Sub UC_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the dashboard with the default active button
        InitializeDashboard(btnReportControl)
        ' Apply radius to buttons
        RadiusButton(btnReportControl, 0.5F)
        RadiusButton(btnRefresh, 0.5F)
        RadiusButton(btnExportExcel, 0.5F)


        MessageBox.Show(
 "This Logical Feature is Currently Under Huge Construction. Thank you ",
 "Feature in Progress",
 MessageBoxButtons.OK,
 MessageBoxIcon.Information
)
    End Sub

    Private Sub btnReportControl_Click(sender As Object, e As EventArgs) Handles btnReportControl.Click
        InitializeDashboard(btnReportControl)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ' Refresh logic here
        InitializeDashboard(btnRefresh)
        MessageBox.Show("Reports refreshed!")
    End Sub

    Private Async Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ' Simulate export logic
        InitializeDashboard(btnExportExcel)
        Await Task.Delay(1000) ' Simulate delay for export
        MessageBox.Show("Reports exported to Excel successfully!")
    End Sub


End Class
