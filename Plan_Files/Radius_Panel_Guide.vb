 'Function to Add beautiful Rounded(Radius) to my Panel
 Public Sub RadiusPanel(panel As Panel, circleness As Single)
     If circleness <= 0 Then Exit Sub
     Dim radius As Integer
     Dim diameter As Integer = Math.Min(panel.Width, panel.Height)
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
     path.AddArc(panel.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90)
     path.AddArc(panel.Width - (radius * 2), panel.Height - (radius * 2), radius * 2, radius * 2, 0, 90)
     path.AddArc(0, panel.Height - (radius * 2), radius * 2, radius * 2, 90, 90)
     path.CloseFigure()
     panel.Region = New Region(path)
 End Sub

' 'Ended the Radius Function.................................................................................................
' 'Example usage:
' 'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase
' '    RadiusPanel(Panel, 0.5F) ' 50% rounded corners
' '    RadiusPanel(Panel, 1.0F) ' Fully rounded (circle)
' 'End Sub