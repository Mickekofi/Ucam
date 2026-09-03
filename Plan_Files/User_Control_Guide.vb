'After Adding a User Control to the project, you can use this code to load it dynamically, Maybe you are loding it to a panel or any other container control as part of your Dashbord
'Put this Code in your form class codes
    Private Sub LoadControl(control As UserControl)
    'Replace pnlMainContent with the name of the panel or container where you want to load the UserControl
        pnlMainContent.Controls.Clear()
        control.Dock = DockStyle.Fill
        pnlMainContent.Controls.Add(control)
    End Sub

' Example usage:
'Now if a button from the Dashbord is clicked, you can load the UserControl like this:
Private Sub btnDepartments_Click(sender As Object, e As EventArgs) Handles btnDepartments.Click
    
    LoadControl(New UC_Departments())'Assuming UC_Departments is your UserControl .vb you created

End Sub

