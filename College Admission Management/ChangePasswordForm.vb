Public Class ChangePasswordForm


    'Error Provider Initialization
    Private ErrorProvider1 As New ErrorProvider()


    'ON lOAD event
    Private Sub ChangePasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Set the form title
        Me.Text = "Change Password"
        'maximize the form
        Me.WindowState = FormWindowState.Maximized




    End Sub




    'Text On Change Validation For txtOldPassword using the TextChanged event,Error Provider, Regular Expression to allow only Aphabetic Characters
    Private Sub txtOldPassword_TextChanged(sender As Object, e As EventArgs) Handles txtOldPassword.TextChanged
        ' Regular expression to allow only alphabetic characters
        Dim regex As New System.Text.RegularExpressions.Regex("^[a-zA-Z]+$")
        If Not regex.IsMatch(txtOldPassword.Text) Then
            ' Show error message using ErrorProvider
            ErrorProvider1.SetError(txtOldPassword, "Only alphabetic characters are allowed.")
        Else
            ' Clear the error if the input is valid
            ErrorProvider1.SetError(txtOldPassword, "")
        End If
    End Sub







End Class