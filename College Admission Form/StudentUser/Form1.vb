Imports System.IO
Imports System.Text.RegularExpressions
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json
Imports System.Drawing.Drawing2D

Public Class Form1

    ' Declare ErrorProvider at the class level
    Private ep As New ErrorProvider()

    ' =========================================================================
    ' UI RENDERING & ROUNDING STYLING
    ' =========================================================================
    Private Sub RoundControl(ctrl As Control, radius As Integer, Optional borderColor As Color = Nothing, Optional borderWidth As Integer = 5)
        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(New RectangleF(0, 0, radius, radius), 180, 90)
        path.AddArc(New RectangleF(ctrl.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New RectangleF(ctrl.Width - radius, ctrl.Height - radius, radius, radius), 0, 90)
        path.AddArc(New RectangleF(0, ctrl.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()
        ctrl.Region = New Region(path)

        RemoveHandler ctrl.Paint, AddressOf RoundedBorderPaint
        AddHandler ctrl.Paint, AddressOf RoundedBorderPaint

        ctrl.Tag = New Tuple(Of Integer, Color, Integer)(radius, If(borderColor = Nothing, Color.DarkSeaGreen, borderColor), borderWidth)
    End Sub

    Private Sub RoundedBorderPaint(sender As Object, e As PaintEventArgs)
        Dim ctrl = DirectCast(sender, Control)
        If ctrl.Tag IsNot Nothing AndAlso TypeOf ctrl.Tag Is Tuple(Of Integer, Color, Integer) Then
            Dim style = DirectCast(ctrl.Tag, Tuple(Of Integer, Color, Integer))
            Dim radius = style.Item1
            Dim borderColor = style.Item2
            Dim borderWidth = style.Item3

            Dim rect As New Rectangle(0, 0, ctrl.Width - 1, ctrl.Height - 1)
            Using path As New Drawing2D.GraphicsPath()
                path.StartFigure()
                path.AddArc(New RectangleF(rect.Left, rect.Top, radius, radius), 180, 90)
                path.AddArc(New RectangleF(rect.Right - radius, rect.Top, radius, radius), 270, 90)
                path.AddArc(New RectangleF(rect.Right - radius, rect.Bottom - radius, radius, radius), 0, 90)
                path.AddArc(New RectangleF(rect.Left, rect.Bottom - radius, radius, radius), 90, 90)
                path.CloseFigure()
                Using pen As New Pen(borderColor, borderWidth)
                    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                    e.Graphics.DrawPath(pen, path)
                End Using
            End Using
        End If
    End Sub

    ' =========================================================================
    ' ON LOAD
    ' =========================================================================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        ' Rounding Controls
        RoundControl(Panel2, 20, Color.Black, 2)
        RoundControl(cmbE1Grade, 10)
        RoundControl(cmbE2Grade, 10)
        RoundControl(cmbE3Grade, 10)
        RoundControl(cmbE4Grade, 10)
        RoundControl(cmbElective1, 10)
        RoundControl(cmbElective2, 10)
        RoundControl(cmbElective3, 10)
        RoundControl(cmbElective4, 10)
        RoundControl(cmbEnglish, 10)
        RoundControl(cmbMath, 10)
        RoundControl(cmbScience, 10)
        RoundControl(cmbSocial, 10)

        RoundControl(btnSubmit, 20, Color.MediumSeaGreen, 3)
        RoundControl(btnReload, 20, Color.MediumSeaGreen, 3)
        RoundControl(btnUploadPhoto, 20, Color.Red, 3)

        Panel1.Invalidate()

        ' Setup ComboBox AutoComplete Behaviors
        Dim electives = {cmbElective1, cmbElective2, cmbElective3, cmbElective4}
        For Each cmb In electives
            cmb.DropDownStyle = ComboBoxStyle.DropDown
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cmb.AutoCompleteSource = AutoCompleteSource.ListItems
            cmb.SelectedIndex = -1
        Next

        ' Load active programs using centralized Database connection pool
        Try
            Using conn = Database.GetOpenConnection()
                Dim programSql As String = "SELECT program_id, name FROM programs WHERE active = 1 ORDER BY name"
                Using adapter As New MySqlDataAdapter(programSql, conn)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        cmbChoice1.DataSource = table.Copy()
                        cmbChoice1.DisplayMember = "name"
                        cmbChoice1.ValueMember = "program_id"
                        cmbChoice1.SelectedIndex = -1

                        cmbChoice2.DataSource = table.Copy()
                        cmbChoice2.DisplayMember = "name"
                        cmbChoice2.ValueMember = "program_id"
                        cmbChoice2.SelectedIndex = -1

                        cmbChoice3.DataSource = table.Copy()
                        cmbChoice3.DisplayMember = "name"
                        cmbChoice3.ValueMember = "program_id"
                        cmbChoice3.SelectedIndex = -1
                    Else
                        MessageBox.Show("No active programs found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading program choices: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================================================================
    ' LIVE INPUT VALIDATIONS
    ' =========================================================================
    Private Sub txtFullName_TextChanged(sender As Object, e As EventArgs) Handles txtFullName.TextChanged
        Dim pattern = "^[A-Za-z\s]+$"
        If Not Regex.IsMatch(txtFullName.Text.Trim, pattern) Then
            ep.SetError(txtFullName, "Full name must contain only letters and spaces.")
        Else
            ep.SetError(txtFullName, "")
        End If
    End Sub

    Private Sub txtFullName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFullName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtEmail.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Dim pattern = "^[\w\.-]+@[\w\.-]+\.\w+$"
        If Not Regex.IsMatch(txtEmail.Text.Trim, pattern) Then
            ep.SetError(txtEmail, "Enter a valid email address.")
        Else
            ep.SetError(txtEmail, "")
        End If
    End Sub

    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPhone.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        Dim pattern = "^(02|05)\d{8}$"
        If Not Regex.IsMatch(txtPhone.Text.Trim, pattern) Then
            ep.SetError(txtPhone, "Phone must be 10 digits and start with 02 or 05.")
        Else
            ep.SetError(txtPhone, "")
        End If
    End Sub

    Private Sub txtPhone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPhone.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtIndexNumber.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtIndexNumber_TextChanged(sender As Object, e As EventArgs) Handles txtIndexNumber.TextChanged
        Dim pattern = "^\d{10}$"
        If Not Regex.IsMatch(txtIndexNumber.Text.Trim, pattern) Then
            ep.SetError(txtIndexNumber, "Index number must be exactly 10 digits.")
        Else
            ep.SetError(txtIndexNumber, "")
        End If
    End Sub

    Private Sub txtIndexNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIndexNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpDOB.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        Dim minAge = 12
        Dim age As Integer = DateDiff(DateInterval.Year, dtpDOB.Value, Date.Now)
        If age < minAge Then
            ep.SetError(dtpDOB, "Age must be at least 12 years.")
        Else
            ep.SetError(dtpDOB, "")
        End If
    End Sub

    Private Sub cmbGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEnglish.SelectedIndexChanged, cmbMath.SelectedIndexChanged, cmbScience.SelectedIndexChanged, cmbSocial.SelectedIndexChanged, cmbElective1.SelectedIndexChanged, cmbElective2.SelectedIndexChanged, cmbElective3.SelectedIndexChanged, cmbElective4.SelectedIndexChanged, cmbE1Grade.SelectedIndexChanged, cmbE2Grade.SelectedIndexChanged, cmbE3Grade.SelectedIndexChanged, cmbE4Grade.SelectedIndexChanged
        Dim comboBox = DirectCast(sender, ComboBox)
        If comboBox.SelectedItem IsNot Nothing Then
            ep.SetError(comboBox, "")
        End If
    End Sub

    Private Sub cmbChoice1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChoice1.SelectedIndexChanged
        If cmbChoice1.SelectedItem IsNot Nothing Then ep.SetError(cmbChoice1, "")
    End Sub

    Private Sub cmbChoice2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChoice2.SelectedIndexChanged
        If cmbChoice2.SelectedItem IsNot Nothing Then ep.SetError(cmbChoice2, "")
    End Sub

    Private Sub cmbChoice3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChoice3.SelectedIndexChanged
        If cmbChoice3.SelectedItem IsNot Nothing Then ep.SetError(cmbChoice3, "")
    End Sub

    Private Sub cmbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGender.SelectedIndexChanged
        If cmbGender.SelectedItem IsNot Nothing Then ep.SetError(cmbGender, "")
    End Sub

    ' =========================================================================
    ' PASSPORT PHOTO UPLOAD & VALIDATION
    ' =========================================================================
    Private Function IsPassportBackgroundRedOrWhite(img As System.Drawing.Image) As Boolean
        Dim bmp As New System.Drawing.Bitmap(img)
        Dim redCount As Integer = 0
        Dim whiteCount As Integer = 0
        Dim totalCount As Long = 0

        Dim samplePoints = {
            New Point(0, 0),
            New Point(bmp.Width - 1, 0),
            New Point(0, bmp.Height - 1),
            New Point(bmp.Width - 1, bmp.Height - 1),
            New Point(bmp.Width \ 2, 0),
            New Point(bmp.Width \ 2, bmp.Height - 1),
            New Point(0, bmp.Height \ 2),
            New Point(bmp.Width - 1, bmp.Height \ 2)
        }

        For Each pt In samplePoints
            If pt.X >= 0 AndAlso pt.X < bmp.Width AndAlso pt.Y >= 0 AndAlso pt.Y < bmp.Height Then
                Dim c As Color = bmp.GetPixel(pt.X, pt.Y)
                totalCount += 1
                If IsColorRed(c) Then redCount += 1
                If IsColorWhite(c) Then whiteCount += 1
            End If
        Next

        Dim threshold As Long = CInt(totalCount * 0.75)
        Return (redCount + whiteCount) >= threshold
    End Function

    Private Function IsColorRed(c As Color) As Boolean
        Return c.R > 180 AndAlso c.G < 100 AndAlso c.B < 100
    End Function

    Private Function IsColorWhite(c As Color) As Boolean
        Return c.R > 200 AndAlso c.G > 200 AndAlso c.B > 200
    End Function

    Private Sub btnUploadPhoto_Click(sender As Object, e As EventArgs) Handles btnUploadPhoto.Click
        Dim ofd As New OpenFileDialog
        ofd.Title = "Select Passport Photo"
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If ofd.ShowDialog = DialogResult.OK Then
            Try
                Dim img = Drawing.Image.FromFile(ofd.FileName)
                'Dim requiredWidth As Integer = 414
                'Dim requiredHeight As Integer = 531



                If Not IsPassportBackgroundRedOrWhite(img) Then
                    MessageBox.Show("Passport photo must have a red or white background.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    img.Dispose()
                    Exit Sub
                End If

                Dim passportFolder = Path.Combine(Application.StartupPath, "PassportPhotos")
                If Not Directory.Exists(passportFolder) Then Directory.CreateDirectory(passportFolder)

                Dim uniqueName = $"{txtIndexNumber.Text.Trim}_passport.jpg"
                Dim passportPath = Path.Combine(passportFolder, uniqueName)
                img.Save(passportPath, Imaging.ImageFormat.Jpeg)

                If Controls.Find("lblPhotoPath", True).Length > 0 Then
                    Dim lbl = TryCast(Controls.Find("lblPhotoPath", True)(0), Label)
                    If lbl IsNot Nothing Then lbl.Text = "Passport Photo Path: " & passportPath
                End If

                If Controls.Find("picPassport", True).Length > 0 Then
                    Dim pic = TryCast(Controls.Find("picPassport", True)(0), PictureBox)
                    If pic IsNot Nothing Then pic.Image = img
                End If
            Catch ex As Exception
                MessageBox.Show("Error uploading photo: " & ex.Message, "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' =========================================================================
    ' PDF RECEIPT GENERATOR
    ' =========================================================================
    Private Sub GeneratePDFReceipt(studentId As Integer, name As String, email As String, index As String, phone As String,
                                   dob As String, gender As String, waecJson As String, choice1 As String, choice2 As String, choice3 As String,
                                   passportPhotoPath As String)
        Try
            Dim sfd As New SaveFileDialog()
            sfd.Title = "Save Admission Receipt"
            sfd.Filter = "PDF Files (*.pdf)|*.pdf"
            sfd.FileName = $"Admission_Receipt_{studentId}.pdf"
            If sfd.ShowDialog() <> DialogResult.OK Then Return

            Dim outputPath = sfd.FileName
            Dim doc As New Document(PageSize.A4, 40, 40, 40, 40)

            Using fs As New FileStream(outputPath, FileMode.Create)
                PdfWriter.GetInstance(doc, fs)
                doc.Open()

                Dim logoPath = Path.Combine(Application.StartupPath, "logo.jpg")
                If File.Exists(logoPath) Then
                    Try
                        Dim logo = iTextSharp.text.Image.GetInstance(logoPath)
                        logo.ScaleToFit(100, 100)
                        logo.Alignment = Element.ALIGN_CENTER
                        doc.Add(logo)
                    Catch ex As Exception
                    End Try
                End If

                Dim titleFont = FontFactory.GetFont("Arial", 18, Font.Bold, BaseColor.BLUE)
                Dim title = New Paragraph("UNIVERSITY OF EDUCATION APPLICANT FORM", titleFont)
                title.Alignment = Element.ALIGN_CENTER
                doc.Add(title)
                doc.Add(New Paragraph(" "))
                doc.Add(New LineSeparator())
                doc.Add(New Paragraph(" "))

                If File.Exists(passportPhotoPath) Then
                    Dim passportImg = iTextSharp.text.Image.GetInstance(passportPhotoPath)
                    passportImg.ScaleAbsolute(100, 100)
                    Dim x = doc.PageSize.Width - doc.RightMargin - passportImg.ScaledWidth
                    publisherY(doc, passportImg, x)
                End If

                Dim headerTable As New PdfPTable(1)
                headerTable.WidthPercentage = 100
                Dim headerCell As New PdfPCell(New Phrase("Student Information", FontFactory.GetFont("Arial", 15, Font.Bold, BaseColor.WHITE)))
                headerCell.BackgroundColor = BaseColor.DARK_GRAY
                headerCell.HorizontalAlignment = Element.ALIGN_CENTER
                headerCell.Padding = 10
                headerCell.Border = Rectangle.NO_BORDER
                headerTable.AddCell(headerCell)
                doc.Add(headerTable)
                doc.Add(New Paragraph(" "))

                Dim infoTable As New PdfPTable(2)
                infoTable.WidthPercentage = 100
                Dim labelFont = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY)
                Dim valueFont = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

                Dim infoLabels = {"Full Name:", "Email:", "Phone:", "Index Number:", "Date of Birth:", "Gender:"}
                Dim infoValues = {name, email, phone, index, dob, gender}

                For i As Integer = 0 To infoLabels.Length - 1
                    Dim lCell As New PdfPCell(New Phrase(infoLabels(i), labelFont))
                    lCell.BackgroundColor = New BaseColor(240, 248, 255)
                    lCell.Padding = 7
                    infoTable.AddCell(lCell)

                    Dim vCell As New PdfPCell(New Phrase(infoValues(i), valueFont))
                    vCell.Padding = 7
                    infoTable.AddCell(vCell)
                Next
                doc.Add(infoTable)

                doc.Add(New Paragraph(" "))
                doc.Add(New Paragraph("WAEC Results", FontFactory.GetFont("Arial", 13, iTextSharp.text.Font.BOLD)))
                doc.Add(New Paragraph(" "))

                Dim waecTable As New PdfPTable(2)
                waecTable.WidthPercentage = 100
                Dim h1 As New PdfPCell(New Phrase("Subject", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
                h1.BackgroundColor = BaseColor.RED
                h1.Padding = 5
                waecTable.AddCell(h1)

                Dim h2 As New PdfPCell(New Phrase("Grade", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
                h2.BackgroundColor = BaseColor.RED
                h2.Padding = 5
                waecTable.AddCell(h2)

                Dim results = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(waecJson)
                For Each pair In results
                    waecTable.AddCell(New PdfPCell(New Phrase(pair.Key)) With {.Padding = 5})
                    waecTable.AddCell(New PdfPCell(New Phrase(pair.Value)) With {.Padding = 5})
                Next
                doc.Add(waecTable)

                doc.Add(New Paragraph(" "))
                doc.Add(New Paragraph("Program Choices", FontFactory.GetFont("Arial", 13, Font.Bold, BaseColor.BLACK)))
                doc.Add(New Paragraph(" "))

                Dim choiceTable As New PdfPTable(2)
                choiceTable.WidthPercentage = 100
                Dim cellLabels = {"1st Choice:", "2nd Choice:", "3rd Choice:"}
                Dim cellValues = {choice1, choice2, choice3}

                For i As Integer = 0 To 2
                    Dim lCell = New PdfPCell(New Phrase(cellLabels(i), FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD)))
                    lCell.BackgroundColor = New BaseColor(230, 230, 250)
                    lCell.Padding = 5
                    choiceTable.AddCell(lCell)

                    Dim vCell As New PdfPCell(New Phrase(cellValues(i), FontFactory.GetFont("Arial", 12)))
                    vCell.Padding = 5
                    choiceTable.AddCell(vCell)
                Next


                doc.Add(choiceTable)

                doc.Add(New Paragraph(" "))
                doc.Add(New Paragraph($"Application Date: {Date.Now:dd MMMM yyyy}", FontFactory.GetFont("Arial", 12)))
                doc.Close()
            End Using

            MessageBox.Show("PDF Receipt Generated and saved successfully ✔️", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generating PDF: " & ex.Message, "PDF Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub publisherY(doc As Document, img As iTextSharp.text.Image, x As Single)
        Dim y = doc.PageSize.Height - doc.TopMargin - img.ScaledHeight - 150
        img.SetAbsolutePosition(x, y)
        doc.Add(img)
    End Sub

    ' =========================================================================
    ' SUBMISSION LOGIC & DATABASE WRITING
    ' =========================================================================
    Private Function HasValidationErrors() As Boolean
        Return ep.GetError(txtFullName) <> "" OrElse
               ep.GetError(txtEmail) <> "" OrElse
               ep.GetError(txtPhone) <> "" OrElse
               ep.GetError(txtIndexNumber) <> "" OrElse
               ep.GetError(dtpDOB) <> ""
    End Function

    Private Sub ShowProgressBar()
        ProgressBar1.Visible = True
        ProgressBar1.Style = ProgressBarStyle.Marquee
    End Sub

    Private Sub HideProgressBar()
        ProgressBar1.Visible = False
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If HasValidationErrors() Then
            MessageBox.Show("Please correct all highlighted errors before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Once you submit, you cannot go back or edit your information. Proceed?", "Final Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        ShowProgressBar()
        Application.DoEvents()

        Try
            Using conn = Database.GetOpenConnection()
                Dim name = txtFullName.Text.Trim()
                Dim email = txtEmail.Text.Trim()
                Dim phone = txtPhone.Text.Trim()
                Dim index = txtIndexNumber.Text.Trim()
                Dim dob = dtpDOB.Value.ToString("yyyy-MM-dd")
                Dim gender = cmbGender.SelectedItem?.ToString()
                Dim year = Date.Now.Year

                ' Check Duplicates
                Dim emailCheckCmd As New MySqlCommand("SELECT COUNT(*) FROM students WHERE email = @mail", conn)
                emailCheckCmd.Parameters.AddWithValue("@mail", email)
                If CInt(emailCheckCmd.ExecuteScalar()) > 0 Then
                    HideProgressBar()
                    MessageBox.Show("This email address is already registered.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM students WHERE index_number = @index", conn)
                checkCmd.Parameters.AddWithValue("@index", index)
                If CInt(checkCmd.ExecuteScalar()) > 0 Then
                    HideProgressBar()
                    MessageBox.Show("This index number already exists in the system.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim passportPhotoPath = ""
                If Controls.Find("lblPhotoPath", True).Length > 0 Then
                    Dim lbl = TryCast(Controls.Find("lblPhotoPath", True)(0), Label)
                    If lbl IsNot Nothing AndAlso lbl.Text.Contains(":") Then
                        passportPhotoPath = lbl.Text.Split(":"c).Last.Trim()
                    End If
                End If

                If String.IsNullOrWhiteSpace(passportPhotoPath) OrElse Not File.Exists(passportPhotoPath) Then
                    HideProgressBar()
                    MessageBox.Show("Please upload a valid passport photo before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Build WAEC Results JSON
                Dim waecResults As New Dictionary(Of String, String)
                waecResults("English") = cmbEnglish.SelectedItem?.ToString()
                waecResults("Mathematics") = cmbMath.SelectedItem?.ToString()
                waecResults("Integrated Science") = cmbScience.SelectedItem?.ToString()
                waecResults("Social Studies") = cmbSocial.SelectedItem?.ToString()

                If cmbElective1.SelectedItem IsNot Nothing Then waecResults(cmbElective1.SelectedItem.ToString()) = cmbE1Grade.SelectedItem?.ToString()
                If cmbElective2.SelectedItem IsNot Nothing Then waecResults(cmbElective2.SelectedItem.ToString()) = cmbE2Grade.SelectedItem?.ToString()
                If cmbElective3.SelectedItem IsNot Nothing Then waecResults(cmbElective3.SelectedItem.ToString()) = cmbE3Grade.SelectedItem?.ToString()
                If cmbElective4.SelectedItem IsNot Nothing Then waecResults(cmbElective4.SelectedItem.ToString()) = cmbE4Grade.SelectedItem?.ToString()

                Dim waecJson = JsonConvert.SerializeObject(waecResults)

                ' Insert Student Record
                Dim insertSql = "INSERT INTO students (full_name, email, phone_number, index_number, dob, gender, waec_results_json, application_year, status, passport_photo_path) " &
                                "VALUES (@name, @mail, @phone, @index, @dob, @gender, @waec, @year, 'Pending', @photoPath)"

                Using cmd As New MySqlCommand(insertSql, conn)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@mail", email)
                    cmd.Parameters.AddWithValue("@phone", phone)
                    cmd.Parameters.AddWithValue("@index", index)
                    cmd.Parameters.AddWithValue("@dob", dob)
                    cmd.Parameters.AddWithValue("@gender", gender)
                    cmd.Parameters.AddWithValue("@waec", waecJson)
                    cmd.Parameters.AddWithValue("@year", year)
                    cmd.Parameters.AddWithValue("@photoPath", passportPhotoPath)
                    cmd.ExecuteNonQuery()
                End Using

                Dim studentId As Integer = Convert.ToInt32(New MySqlCommand("SELECT LAST_INSERT_ID()", conn).ExecuteScalar())

                ' Insert Program Choices (FIXED: Properly mapping Choice 1, 2, and 3)
                Dim choiceSql = "INSERT INTO program_choices (student_id, program_id, choice_rank, result) VALUES (@sid, @pid, @rank, 'Pending')"
                Using cmd2 As New MySqlCommand(choiceSql, conn)
                    cmd2.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentId
                    cmd2.Parameters.Add("@pid", MySqlDbType.Int32)
                    cmd2.Parameters.Add("@rank", MySqlDbType.Int32)

                    If cmbChoice1.SelectedValue IsNot Nothing Then
                        cmd2.Parameters("@pid").Value = CInt(cmbChoice1.SelectedValue)
                        cmd2.Parameters("@rank").Value = 1
                        cmd2.ExecuteNonQuery()
                    End If

                    If cmbChoice2.SelectedValue IsNot Nothing Then
                        cmd2.Parameters("@pid").Value = CInt(cmbChoice2.SelectedValue)
                        cmd2.Parameters("@rank").Value = 2
                        cmd2.ExecuteNonQuery()
                    End If

                    If cmbChoice3.SelectedValue IsNot Nothing Then
                        cmd2.Parameters("@pid").Value = CInt(cmbChoice3.SelectedValue)
                        cmd2.Parameters("@rank").Value = 3
                        cmd2.ExecuteNonQuery()
                    End If
                End Using

                HideProgressBar()
                MessageBox.Show("🎉 Admission form submitted successfully! Proceeding to receipt generation.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                GeneratePDFReceipt(
                    studentId, name, email, index, phone, dob, gender, waecJson,
                    If(cmbChoice1.SelectedIndex >= 0, cmbChoice1.Text, ""),
                    If(cmbChoice2.SelectedIndex >= 0, cmbChoice2.Text, ""),
                    If(cmbChoice3.SelectedIndex >= 0, cmbChoice3.Text, ""),
                    passportPhotoPath
                )
            End Using

        Catch ex As Exception
            HideProgressBar()
            MessageBox.Show("❌ Error: " & ex.Message, "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        If MessageBox.Show("Are you sure you want to reload? All unsaved data will be lost.", "Confirm Reload", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        ResetControls(Me)
        ep.Clear()
        Form1_Load(sender, e)
        MessageBox.Show("Page reloaded successfully.", "Reload", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ResetControls(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then ctrl.Text = ""
            If TypeOf ctrl Is ComboBox Then DirectCast(ctrl, ComboBox).SelectedIndex = -1
            If TypeOf ctrl Is DateTimePicker Then DirectCast(ctrl, DateTimePicker).Value = Date.Now
            If TypeOf ctrl Is CheckBox Then DirectCast(ctrl, CheckBox).Checked = False
            If TypeOf ctrl Is RadioButton Then DirectCast(ctrl, RadioButton).Checked = False
            If TypeOf ctrl Is PictureBox Then DirectCast(ctrl, PictureBox).Image = Nothing
            If TypeOf ctrl Is Label AndAlso ctrl.Name = "lblPhotoPath" Then ctrl.Text = "Passport Photo Path:"
            If ctrl.HasChildren Then ResetControls(ctrl)
        Next
    End Sub

    Private Sub linklblCheckAdmission_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklblCheckAdmission.LinkClicked
        AdmissionLists.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class