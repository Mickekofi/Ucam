Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fill gender dropdown
        cmbGender.Items.AddRange(New String() {"Male", "Female"})

        ' WAEC Grades
        Dim grades = New String() {"A1", "B2", "B3", "C4", "C5", "C6", "D7", "E8", "F9"}
        cmbEnglish.Items.AddRange(grades)
        cmbMath.Items.AddRange(grades)
        cmbScience.Items.AddRange(grades)
        cmbSocial.Items.AddRange(grades)
        cmbE1Grade.Items.AddRange(grades)
        cmbE2Grade.Items.AddRange(grades)
        cmbE3Grade.Items.AddRange(grades)
        cmbE4Grade.Items.AddRange(grades)

        ' Elective subjects
        Dim electives = New String() {"Economics", "Elective ICT", "Geography", "Elective Biology", "Elective Chemistry", "Elective Physics", "Elective Math", "Christian Religious Studies", "Computer Science", "French"}
        cmbElective1.Items.AddRange(electives)
        cmbElective2.Items.AddRange(electives)
        cmbElective3.Items.AddRange(electives)
        cmbElective4.Items.AddRange(electives)
    End Sub
End Class
