<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnUploadPhoto = New Button()
        linklblCheckAdmission = New LinkLabel()
        btnReload = New Button()
        lblPhotoPath = New Label()
        Panel4 = New Panel()
        picPassport = New PictureBox()
        Label6 = New Label()
        ProgressBar1 = New ProgressBar()
        cmbChoice1 = New ComboBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblCollegeProgram = New Label()
        cmbChoice3 = New ComboBox()
        cmbChoice2 = New ComboBox()
        cmbE4Grade = New ComboBox()
        cmbE3Grade = New ComboBox()
        cmbE2Grade = New ComboBox()
        lbE4Grade = New Label()
        lbE3Grade = New Label()
        lbElective2Grade = New Label()
        lbElective1Grade = New Label()
        cmbE1Grade = New ComboBox()
        cmbGender = New ComboBox()
        btnSubmit = New Button()
        cmbElective3 = New ComboBox()
        lbElective2 = New Label()
        cmbElective2 = New ComboBox()
        lbElective3 = New Label()
        cmbElective4 = New ComboBox()
        lbElective4 = New Label()
        cmbElective1 = New ComboBox()
        lbElective1 = New Label()
        cmbSocial = New ComboBox()
        cmbScience = New ComboBox()
        cmbMath = New ComboBox()
        cmbEnglish = New ComboBox()
        dtpDOB = New DateTimePicker()
        lbMaths = New Label()
        lbScience = New Label()
        lbSocial = New Label()
        lbEnglish = New Label()
        lbGender = New Label()
        lbDOB = New Label()
        txtIndexNumber = New TextBox()
        lbIndexNumber = New Label()
        txtPhone = New TextBox()
        lbPhone = New Label()
        txtEmail = New TextBox()
        lbEmail = New Label()
        lbFullName = New Label()
        lbAdmission = New Label()
        txtFullName = New TextBox()
        Panel5 = New Panel()
        Panel3 = New Panel()
        Panel6 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(picPassport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = SystemColors.ButtonFace
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel6)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1320, 849)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.Controls.Add(btnUploadPhoto)
        Panel2.Controls.Add(linklblCheckAdmission)
        Panel2.Controls.Add(btnReload)
        Panel2.Controls.Add(lblPhotoPath)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(ProgressBar1)
        Panel2.Controls.Add(cmbChoice1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(lblCollegeProgram)
        Panel2.Controls.Add(cmbChoice3)
        Panel2.Controls.Add(cmbChoice2)
        Panel2.Controls.Add(cmbE4Grade)
        Panel2.Controls.Add(cmbE3Grade)
        Panel2.Controls.Add(cmbE2Grade)
        Panel2.Controls.Add(lbE4Grade)
        Panel2.Controls.Add(lbE3Grade)
        Panel2.Controls.Add(lbElective2Grade)
        Panel2.Controls.Add(lbElective1Grade)
        Panel2.Controls.Add(cmbE1Grade)
        Panel2.Controls.Add(cmbGender)
        Panel2.Controls.Add(btnSubmit)
        Panel2.Controls.Add(cmbElective3)
        Panel2.Controls.Add(lbElective2)
        Panel2.Controls.Add(cmbElective2)
        Panel2.Controls.Add(lbElective3)
        Panel2.Controls.Add(cmbElective4)
        Panel2.Controls.Add(lbElective4)
        Panel2.Controls.Add(cmbElective1)
        Panel2.Controls.Add(lbElective1)
        Panel2.Controls.Add(cmbSocial)
        Panel2.Controls.Add(cmbScience)
        Panel2.Controls.Add(cmbMath)
        Panel2.Controls.Add(cmbEnglish)
        Panel2.Controls.Add(dtpDOB)
        Panel2.Controls.Add(lbMaths)
        Panel2.Controls.Add(lbScience)
        Panel2.Controls.Add(lbSocial)
        Panel2.Controls.Add(lbEnglish)
        Panel2.Controls.Add(lbGender)
        Panel2.Controls.Add(lbDOB)
        Panel2.Controls.Add(txtIndexNumber)
        Panel2.Controls.Add(lbIndexNumber)
        Panel2.Controls.Add(txtPhone)
        Panel2.Controls.Add(lbPhone)
        Panel2.Controls.Add(txtEmail)
        Panel2.Controls.Add(lbEmail)
        Panel2.Controls.Add(lbFullName)
        Panel2.Controls.Add(lbAdmission)
        Panel2.Controls.Add(txtFullName)
        Panel2.Controls.Add(Panel5)
        Panel2.Location = New Point(295, 45)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1001, 3195)
        Panel2.TabIndex = 0
        ' 
        ' btnUploadPhoto
        ' 
        btnUploadPhoto.BackColor = Color.Red
        btnUploadPhoto.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUploadPhoto.ForeColor = Color.White
        btnUploadPhoto.Location = New Point(605, 295)
        btnUploadPhoto.Margin = New Padding(3, 4, 3, 4)
        btnUploadPhoto.Name = "btnUploadPhoto"
        btnUploadPhoto.Size = New Size(158, 39)
        btnUploadPhoto.TabIndex = 35
        btnUploadPhoto.Text = "Upload Passport"
        btnUploadPhoto.UseVisualStyleBackColor = False
        ' 
        ' linklblCheckAdmission
        ' 
        linklblCheckAdmission.ActiveLinkColor = Color.Blue
        linklblCheckAdmission.AutoSize = True
        linklblCheckAdmission.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        linklblCheckAdmission.LinkColor = Color.Red
        linklblCheckAdmission.Location = New Point(430, 3146)
        linklblCheckAdmission.Name = "linklblCheckAdmission"
        linklblCheckAdmission.Size = New Size(326, 28)
        linklblCheckAdmission.TabIndex = 65
        linklblCheckAdmission.TabStop = True
        linklblCheckAdmission.Text = "Check Your Admission Status Here"
        ' 
        ' btnReload
        ' 
        btnReload.BackColor = Color.MediumSeaGreen
        btnReload.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReload.ForeColor = Color.White
        btnReload.Location = New Point(739, 4)
        btnReload.Margin = New Padding(3, 4, 3, 4)
        btnReload.Name = "btnReload"
        btnReload.Size = New Size(125, 39)
        btnReload.TabIndex = 36
        btnReload.Text = "Refresh Page"
        btnReload.UseVisualStyleBackColor = False
        ' 
        ' lblPhotoPath
        ' 
        lblPhotoPath.AutoSize = True
        lblPhotoPath.Font = New Font("Segoe UI", 5F)
        lblPhotoPath.Location = New Point(528, 340)
        lblPhotoPath.Name = "lblPhotoPath"
        lblPhotoPath.Size = New Size(61, 12)
        lblPhotoPath.TabIndex = 63
        lblPhotoPath.Text = "path To Image"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(picPassport)
        Panel4.Location = New Point(775, 99)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(209, 220)
        Panel4.TabIndex = 61
        ' 
        ' picPassport
        ' 
        picPassport.BackColor = Color.White
        picPassport.Location = New Point(21, 17)
        picPassport.Margin = New Padding(3, 4, 3, 4)
        picPassport.Name = "picPassport"
        picPassport.Size = New Size(173, 184)
        picPassport.SizeMode = PictureBoxSizeMode.StretchImage
        picPassport.TabIndex = 0
        picPassport.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.SeaGreen
        Label6.Location = New Point(23, 272)
        Label6.Name = "Label6"
        Label6.Size = New Size(342, 28)
        Label6.TabIndex = 60
        Label6.Text = "SECTION 1: DEMOGRAPHIC"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(23, 2977)
        ProgressBar1.Margin = New Padding(3, 4, 3, 4)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(236, 31)
        ProgressBar1.TabIndex = 59
        ProgressBar1.Visible = False
        ' 
        ' cmbChoice1
        ' 
        cmbChoice1.Font = New Font("Garamond", 14.25F, FontStyle.Bold)
        cmbChoice1.ForeColor = Color.DarkGreen
        cmbChoice1.FormattingEnabled = True
        cmbChoice1.Items.AddRange(New Object() {"Bsc Information and Communication Technology", "Bsc Biology Education", "Bsc Chemistry Education", "Bsc French Education", "Bsc English Education", "BBA Accounting", "Bsc Procurement"})
        cmbChoice1.Location = New Point(34, 2640)
        cmbChoice1.Margin = New Padding(3, 4, 3, 4)
        cmbChoice1.Name = "cmbChoice1"
        cmbChoice1.Size = New Size(923, 35)
        cmbChoice1.TabIndex = 58
        cmbChoice1.Text = "--select program--"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(23, 951)
        Label5.Name = "Label5"
        Label5.Size = New Size(454, 34)
        Label5.TabIndex = 57
        Label5.Text = "SECTION 2: CORE SUBJECTS"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(32, 1483)
        Label4.Name = "Label4"
        Label4.Size = New Size(515, 34)
        Label4.TabIndex = 56
        Label4.Text = "SECTION 3: ELECTIVE SUBJECTS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Garamond", 14.25F)
        Label3.Location = New Point(33, 2825)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 27)
        Label3.TabIndex = 55
        Label3.Text = "3RD Choice"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Garamond", 14.25F)
        Label2.Location = New Point(33, 2712)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 27)
        Label2.TabIndex = 54
        Label2.Text = "2ND Choice"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Garamond", 14.25F)
        Label1.Location = New Point(33, 2599)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 27)
        Label1.TabIndex = 53
        Label1.Text = "1ST Choice"
        ' 
        ' lblCollegeProgram
        ' 
        lblCollegeProgram.AutoSize = True
        lblCollegeProgram.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCollegeProgram.ForeColor = Color.Red
        lblCollegeProgram.Location = New Point(32, 2527)
        lblCollegeProgram.Name = "lblCollegeProgram"
        lblCollegeProgram.Size = New Size(849, 34)
        lblCollegeProgram.TabIndex = 52
        lblCollegeProgram.Text = "SECTION 4: UNIVERSITY/COLLEGE PROGRAM CHOICES"
        ' 
        ' cmbChoice3
        ' 
        cmbChoice3.Font = New Font("Garamond", 14.25F, FontStyle.Bold)
        cmbChoice3.ForeColor = Color.DarkGreen
        cmbChoice3.FormattingEnabled = True
        cmbChoice3.Items.AddRange(New Object() {"Bsc Information and Communication Technology", "Bsc Biology Education", "Bsc Chemistry Education", "Bsc French Education", "Bsc English Education", "BBA Accounting", "Bsc Procurement"})
        cmbChoice3.Location = New Point(33, 2863)
        cmbChoice3.Margin = New Padding(3, 4, 3, 4)
        cmbChoice3.Name = "cmbChoice3"
        cmbChoice3.Size = New Size(923, 35)
        cmbChoice3.TabIndex = 51
        cmbChoice3.Text = "--select program--"
        ' 
        ' cmbChoice2
        ' 
        cmbChoice2.Font = New Font("Garamond", 14.25F, FontStyle.Bold)
        cmbChoice2.ForeColor = Color.DarkGreen
        cmbChoice2.FormattingEnabled = True
        cmbChoice2.Items.AddRange(New Object() {"Bsc Information and Communication Technology", "Bsc Biology Education", "Bsc Chemistry Education", "Bsc French Education", "Bsc English Education", "BBA Accounting", "Bsc Procurement"})
        cmbChoice2.Location = New Point(33, 2755)
        cmbChoice2.Margin = New Padding(3, 4, 3, 4)
        cmbChoice2.Name = "cmbChoice2"
        cmbChoice2.Size = New Size(923, 35)
        cmbChoice2.TabIndex = 51
        cmbChoice2.Text = "--select program--"
        ' 
        ' cmbE4Grade
        ' 
        cmbE4Grade.DropDownStyle = ComboBoxStyle.DropDownList
        cmbE4Grade.Font = New Font("Garamond", 14.25F)
        cmbE4Grade.FormattingEnabled = True
        cmbE4Grade.Items.AddRange(New Object() {"A1", "B2", "B3", "C4", "C5", "C6", "D7", "E8", "F9"})
        cmbE4Grade.Location = New Point(34, 2383)
        cmbE4Grade.Margin = New Padding(3, 4, 3, 4)
        cmbE4Grade.Name = "cmbE4Grade"
        cmbE4Grade.Size = New Size(922, 35)
        cmbE4Grade.TabIndex = 48
        ' 
        ' cmbE3Grade
        ' 
        cmbE3Grade.DropDownStyle = ComboBoxStyle.DropDownList
        cmbE3Grade.Font = New Font("Garamond", 14.25F)
        cmbE3Grade.FormattingEnabled = True
        cmbE3Grade.Items.AddRange(New Object() {"A1", "B2", "B3", "C4", "C5", "C6", "D7", "E8", "F9"})
        cmbE3Grade.Location = New Point(34, 2131)
        cmbE3Grade.Margin = New Padding(3, 4, 3, 4)
        cmbE3Grade.Name = "cmbE3Grade"
        cmbE3Grade.Size = New Size(922, 35)
        cmbE3Grade.TabIndex = 47
        ' 
        ' cmbE2Grade
        ' 
        cmbE2Grade.DropDownStyle = ComboBoxStyle.DropDownList
        cmbE2Grade.Font = New Font("Garamond", 14.25F)
        cmbE2Grade.FormattingEnabled = True
        cmbE2Grade.Items.AddRange(New Object() {"A1", "B2", "B3", "C4", "C5", "C6", "D7", "E8", "F9"})
        cmbE2Grade.Location = New Point(35, 1900)
        cmbE2Grade.Margin = New Padding(3, 4, 3, 4)
        cmbE2Grade.Name = "cmbE2Grade"
        cmbE2Grade.Size = New Size(921, 35)
        cmbE2Grade.TabIndex = 46
        ' 
        ' lbE4Grade
        ' 
        lbE4Grade.AutoSize = True
        lbE4Grade.Font = New Font("Garamond", 14.25F)
        lbE4Grade.Location = New Point(34, 2348)
        lbE4Grade.Name = "lbE4Grade"
        lbE4Grade.RightToLeft = RightToLeft.Yes
        lbE4Grade.Size = New Size(71, 27)
        lbE4Grade.TabIndex = 44
        lbE4Grade.Text = "Grade"
        ' 
        ' lbE3Grade
        ' 
        lbE3Grade.AutoSize = True
        lbE3Grade.Font = New Font("Garamond", 14.25F)
        lbE3Grade.Location = New Point(34, 2093)
        lbE3Grade.Name = "lbE3Grade"
        lbE3Grade.RightToLeft = RightToLeft.Yes
        lbE3Grade.Size = New Size(71, 27)
        lbE3Grade.TabIndex = 42
        lbE3Grade.Text = "Grade"
        ' 
        ' lbElective2Grade
        ' 
        lbElective2Grade.AutoSize = True
        lbElective2Grade.Font = New Font("Garamond", 14.25F)
        lbElective2Grade.Location = New Point(34, 1864)
        lbElective2Grade.Name = "lbElective2Grade"
        lbElective2Grade.RightToLeft = RightToLeft.Yes
        lbElective2Grade.Size = New Size(77, 27)
        lbElective2Grade.TabIndex = 40
        lbElective2Grade.Text = " Grade"
        ' 
        ' lbElective1Grade
        ' 
        lbElective1Grade.AutoSize = True
        lbElective1Grade.Font = New Font("Garamond", 14.25F)
        lbElective1Grade.Location = New Point(34, 1648)
        lbElective1Grade.Name = "lbElective1Grade"
        lbElective1Grade.RightToLeft = RightToLeft.Yes
        lbElective1Grade.Size = New Size(71, 27)
        lbElective1Grade.TabIndex = 39
        lbElective1Grade.Text = "Grade"
        ' 
        ' cmbE1Grade
        ' 
        cmbE1Grade.DropDownStyle = ComboBoxStyle.DropDownList
        cmbE1Grade.Font = New Font("Garamond", 14.25F)
        cmbE1Grade.FormattingEnabled = True
        cmbE1Grade.Items.AddRange(New Object() {"A1", "B2", "B3", "C4", "C5", "C6", "D7", "E8", "F9"})
        cmbE1Grade.Location = New Point(33, 1677)
        cmbE1Grade.Margin = New Padding(3, 4, 3, 4)
        cmbE1Grade.Name = "cmbE1Grade"
        cmbE1Grade.Size = New Size(921, 35)
        cmbE1Grade.TabIndex = 38
        ' 
        ' cmbGender
        ' 
        cmbGender.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGender.Font = New Font("Garamond", 14.25F)
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        cmbGender.Location = New Point(34, 864)
        cmbGender.Margin = New Padding(3, 4, 3, 4)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(923, 35)
        cmbGender.TabIndex = 37
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.Red
        btnSubmit.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(23, 3015)
        btnSubmit.Margin = New Padding(3, 4, 3, 4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(233, 56)
        btnSubmit.TabIndex = 34
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' cmbElective3
        ' 
        cmbElective3.DropDownStyle = ComboBoxStyle.DropDownList
        cmbElective3.Font = New Font("Garamond", 14.25F)
        cmbElective3.FormattingEnabled = True
        cmbElective3.Items.AddRange(New Object() {"English", "Mathematics", "Integrated Science", "Social Studies", "Business Management", "Financial Accounting", "Economics", "Cost Accounting", "Elective Mathematics", "Elective ICT", "French", "Clerical Office Duties", "ICT", "General Knowledge in Art", "Textile", "Picture Making", "Ceramics and Sculpture", "Graphic Design", "Leather Work", "Basketry", "French", "Food and Nutrition", "Clothing and Textiles", "Management in Living", "Elective Biology", "Elective Chemistry", "Literature in English", "Christian Religious Studies", "Government", "Fante", "Ga", "Ewe", "Arabic", "Dagaare", "Dagbani", "Gonja", "Kasem", "Nzema", "Akuapem Twi", "Asante Twi", "Music", "History", "Elective Physics", "Geography", "Animal Husbandry", "General Agricultural Science", "Crop Husbandry and Horticulture", "Fisheries", "Forestry", "Ceramics", "Auto Mechanics", "Woodwork", "Metal Work", "Applied Electricity", "Jewellery", "West African Traditional Religion", "Islamic Studies", "Typewriting", "Auto Mechanics", "Building construction", "Technical Drawing", "Crop Husbandry And Horticulture"})
        cmbElective3.Location = New Point(34, 2035)
        cmbElective3.Margin = New Padding(3, 4, 3, 4)
        cmbElective3.Name = "cmbElective3"
        cmbElective3.Size = New Size(921, 35)
        cmbElective3.TabIndex = 33
        ' 
        ' lbElective2
        ' 
        lbElective2.AutoSize = True
        lbElective2.Font = New Font("Garamond", 14.25F, FontStyle.Bold)
        lbElective2.Location = New Point(35, 1768)
        lbElective2.Name = "lbElective2"
        lbElective2.RightToLeft = RightToLeft.Yes
        lbElective2.Size = New Size(203, 27)
        lbElective2.TabIndex = 32
        lbElective2.Text = "*Elective Subject 2"
        ' 
        ' cmbElective2
        ' 
        cmbElective2.DropDownStyle = ComboBoxStyle.DropDownList
        cmbElective2.Font = New Font("Garamond", 14.25F)
        cmbElective2.FormattingEnabled = True
        cmbElective2.Items.AddRange(New Object() {"English", "Mathematics", "Integrated Science", "Social Studies", "Business Management", "Financial Accounting", "Economics", "Cost Accounting", "Elective Mathematics", "Elective ICT", "French", "Clerical Office Duties", "ICT", "General Knowledge in Art", "Textile", "Picture Making", "Ceramics and Sculpture", "Graphic Design", "Leather Work", "Basketry", "French", "Food and Nutrition", "Clothing and Textiles", "Management in Living", "Elective Biology", "Elective Chemistry", "Literature in English", "Christian Religious Studies", "Government", "Fante", "Ga", "Ewe", "Arabic", "Dagaare", "Dagbani", "Gonja", "Kasem", "Nzema", "Akuapem Twi", "Asante Twi", "Music", "History", "Elective Physics", "Geography", "Animal Husbandry", "General Agricultural Science", "Crop Husbandry and Horticulture", "Fisheries", "Forestry", "Ceramics", "Auto Mechanics", "Woodwork", "Metal Work", "Applied Electricity", "Jewellery", "West African Traditional Religion", "Islamic Studies", "Typewriting", "Auto Mechanics", "Building construction", "Technical Drawing", "Crop Husbandry And Horticulture"})
        cmbElective2.Location = New Point(34, 1808)
        cmbElective2.Margin = New Padding(3, 4, 3, 4)
        cmbElective2.Name = "cmbElective2"
        cmbElective2.Size = New Size(921, 35)
        cmbElective2.TabIndex = 31
        ' 
        ' lbElective3
        ' 
        lbElective3.AutoSize = True
        lbElective3.Font = New Font("Garamond", 14.25F, FontStyle.Bold)
        lbElective3.Location = New Point(33, 2000)
        lbElective3.Name = "lbElective3"
        lbElective3.RightToLeft = RightToLeft.Yes
        lbElective3.Size = New Size(203, 27)
        lbElective3.TabIndex = 30
        lbElective3.Text = "*Elective Subject 3"
        ' 
        ' cmbElective4
        ' 
        cmbElective4.DropDownStyle = ComboBoxStyle.DropDownList
        cmbElective4.Font = New Font("Garamond", 14.25F)
        cmbElective4.FormattingEnabled = True
        cmbElective4.Items.AddRange(New Object() {"English", "Mathematics", "Integrated Science", "Social Studies", "Business Management", "Financial Accounting", "Economics", "Cost Accounting", "Elective Mathematics", "Elective ICT", "French", "Clerical Office Duties", "ICT", "General Knowledge in Art", "Textile", "Picture Making", "Ceramics and Sculpture", "Graphic Design", "Leather Work", "Basketry", "French", "Food and Nutrition", "Clothing and Textiles", "Management in Living", "Elective Biology", "Elective Chemistry", "Literature in English", "Christian Religious Studies", "Government", "Fante", "Ga", "Ewe", "Arabic", "Dagaare", "Dagbani", "Gonja", "Kasem", "Nzema", "Akuapem Twi", "Asante Twi", "Music", "History", "Elective Physics", "Geography", "Animal Husbandry", "General Agricultural Science", "Crop Husbandry and Horticulture", "Fisheries", "Forestry", "Ceramics", "Auto Mechanics", "Woodwork", "Metal Work", "Applied Electricity", "Jewellery", "West African Traditional Religion", "Islamic Studies", "Typewriting", "Auto Mechanics", "Building construction", "Technical Drawing", "Crop Husbandry And Horticulture", ""})
        cmbElective4.Location = New Point(34, 2293)
        cmbElective4.Margin = New Padding(3, 4, 3, 4)
        cmbElective4.Name = "cmbElective4"
        cmbElective4.Size = New Size(922, 35)
        cmbElective4.TabIndex = 29
        ' 
        ' lbElective4
        ' 
        lbElective4.AutoSize = True
        lbElective4.Font = New Font("Garamond", 14.25F, FontStyle.Bold)
        lbElective4.Location = New Point(33, 2256)
        lbElective4.Name = "lbElective4"
        lbElective4.RightToLeft = RightToLeft.Yes
        lbElective4.Size = New Size(203, 27)
        lbElective4.TabIndex = 28
        lbElective4.Text = "*Elective Subject 4"
        ' 
        ' cmbElective1
        ' 
        cmbElective1.DropDownStyle = ComboBoxStyle.DropDownList
        cmbElective1.Font = New Font("Garamond", 14.25F)
        cmbElective1.FormattingEnabled = True
        cmbElective1.Items.AddRange(New Object() {"English", "Mathematics", "Integrated Science", "Social Studies", "Business Management", "Financial Accounting", "Economics", "Cost Accounting", "Elective Mathematics", "Elective ICT", "French", "Clerical Office Duties", "ICT", "General Knowledge in Art", "Textile", "Picture Making", "Ceramics and Sculpture", "Graphic Design", "Leather Work", "Basketry", "French", "Food and Nutrition", "Clothing and Textiles", "Management in Living", "Elective Biology", "Elective Chemistry", "Literature in English", "Christian Religious Studies", "Government", "Fante", "Ga", "Ewe", "Arabic", "Dagaare", "Dagbani", "Gonja", "Kasem", "Nzema", "Akuapem Twi", "Asante Twi", "Music", "History", "Elective Physics", "Geography", "Animal Husbandry", "General Agricultural Science", "Crop Husbandry and Horticulture", "Fisheries", "Forestry", "Ceramics", "Auto Mechanics", "Woodwork", "Metal Work", "Applied Electricity", "Jewellery", "West African Traditional Religion", "Islamic Studies", "Typewriting", "Auto Mechanics", "Building construction", "Technical Drawing", "Crop Husbandry And Horticulture", ""})
        cmbElective1.Location = New Point(33, 1589)
        cmbElective1.Margin = New Padding(3, 4, 3, 4)
        cmbElective1.Name = "cmbElective1"
        cmbElective1.Size = New Size(921, 35)
        cmbElective1.TabIndex = 27
        ' 
        ' lbElective1
        ' 
        lbElective1.AutoSize = True
        lbElective1.Font = New Font("Garamond", 14.25F, FontStyle.Bold)
        lbElective1.Location = New Point(33, 1549)
        lbElective1.Name = "lbElective1"
        lbElective1.RightToLeft = RightToLeft.Yes
        lbElective1.Size = New Size(202, 27)
        lbElective1.TabIndex = 26
        lbElective1.Text = "*Elective Subject 1"
        ' 
        ' cmbSocial
        ' 
        cmbSocial.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSocial.Font = New Font("Garamond", 14.25F)
        cmbSocial.FormattingEnabled = True
        cmbSocial.Items.AddRange(New Object() {"A1", "B2", "B3", "C4", "C5", "C6", "D7", "E8", "F9"})
        cmbSocial.Location = New Point(23, 1369)
        cmbSocial.Margin = New Padding(3, 4, 3, 4)
        cmbSocial.Name = "cmbSocial"
        cmbSocial.Size = New Size(933, 35)
        cmbSocial.TabIndex = 25
        ' 
        ' cmbScience
        ' 
        cmbScience.DropDownStyle = ComboBoxStyle.DropDownList
        cmbScience.Font = New Font("Garamond", 14.25F)
        cmbScience.FormattingEnabled = True
        cmbScience.Items.AddRange(New Object() {"A1", "B2", "B3", "C4", "C5", "C6", "D7", "E8", "F9"})
        cmbScience.Location = New Point(24, 1268)
        cmbScience.Margin = New Padding(3, 4, 3, 4)
        cmbScience.Name = "cmbScience"
        cmbScience.Size = New Size(933, 35)
        cmbScience.TabIndex = 24
        ' 
        ' cmbMath
        ' 
        cmbMath.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMath.Font = New Font("Garamond", 14.25F)
        cmbMath.FormattingEnabled = True
        cmbMath.Items.AddRange(New Object() {"A1", "B2", "B3", "C4", "C5", "C6", "D7", "E8", "F9"})
        cmbMath.Location = New Point(24, 1157)
        cmbMath.Margin = New Padding(3, 4, 3, 4)
        cmbMath.Name = "cmbMath"
        cmbMath.Size = New Size(933, 35)
        cmbMath.TabIndex = 23
        ' 
        ' cmbEnglish
        ' 
        cmbEnglish.AllowDrop = True
        cmbEnglish.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEnglish.Font = New Font("Garamond", 14.25F)
        cmbEnglish.FormattingEnabled = True
        cmbEnglish.Items.AddRange(New Object() {"A1", "B2", "B3", "C4", "C5", "C6", "D7", "E8", "F9"})
        cmbEnglish.Location = New Point(23, 1035)
        cmbEnglish.Margin = New Padding(3, 4, 3, 4)
        cmbEnglish.Name = "cmbEnglish"
        cmbEnglish.Size = New Size(933, 35)
        cmbEnglish.TabIndex = 22
        ' 
        ' dtpDOB
        ' 
        dtpDOB.Font = New Font("Garamond", 14.25F)
        dtpDOB.Location = New Point(34, 765)
        dtpDOB.Margin = New Padding(3, 4, 3, 4)
        dtpDOB.Name = "dtpDOB"
        dtpDOB.Size = New Size(923, 34)
        dtpDOB.TabIndex = 21
        ' 
        ' lbMaths
        ' 
        lbMaths.AutoSize = True
        lbMaths.Font = New Font("Garamond", 14.25F)
        lbMaths.Location = New Point(24, 1112)
        lbMaths.Name = "lbMaths"
        lbMaths.RightToLeft = RightToLeft.Yes
        lbMaths.Size = New Size(203, 27)
        lbMaths.TabIndex = 19
        lbMaths.Text = "Mathematics  Grade"
        ' 
        ' lbScience
        ' 
        lbScience.AutoSize = True
        lbScience.Font = New Font("Garamond", 14.25F)
        lbScience.Location = New Point(24, 1224)
        lbScience.Name = "lbScience"
        lbScience.RightToLeft = RightToLeft.Yes
        lbScience.Size = New Size(254, 27)
        lbScience.TabIndex = 17
        lbScience.Text = "Intergrated science Grade"
        ' 
        ' lbSocial
        ' 
        lbSocial.AutoSize = True
        lbSocial.Font = New Font("Garamond", 14.25F)
        lbSocial.Location = New Point(23, 1328)
        lbSocial.Name = "lbSocial"
        lbSocial.RightToLeft = RightToLeft.Yes
        lbSocial.Size = New Size(207, 27)
        lbSocial.TabIndex = 15
        lbSocial.Text = "Social Studies Grade"
        ' 
        ' lbEnglish
        ' 
        lbEnglish.AutoSize = True
        lbEnglish.Font = New Font("Garamond", 14.25F)
        lbEnglish.Location = New Point(23, 1003)
        lbEnglish.Name = "lbEnglish"
        lbEnglish.RightToLeft = RightToLeft.Yes
        lbEnglish.Size = New Size(245, 27)
        lbEnglish.TabIndex = 13
        lbEnglish.Text = "English Language Grade"
        ' 
        ' lbGender
        ' 
        lbGender.AutoSize = True
        lbGender.Font = New Font("Garamond", 14.25F)
        lbGender.Location = New Point(34, 828)
        lbGender.Name = "lbGender"
        lbGender.RightToLeft = RightToLeft.Yes
        lbGender.Size = New Size(83, 27)
        lbGender.TabIndex = 11
        lbGender.Text = "Gender"
        ' 
        ' lbDOB
        ' 
        lbDOB.AutoSize = True
        lbDOB.Font = New Font("Garamond", 14.25F)
        lbDOB.Location = New Point(33, 723)
        lbDOB.Name = "lbDOB"
        lbDOB.RightToLeft = RightToLeft.Yes
        lbDOB.Size = New Size(138, 27)
        lbDOB.TabIndex = 10
        lbDOB.Text = "Date of Birth"
        ' 
        ' txtIndexNumber
        ' 
        txtIndexNumber.Font = New Font("Garamond", 14.25F)
        txtIndexNumber.Location = New Point(34, 660)
        txtIndexNumber.Margin = New Padding(3, 4, 3, 4)
        txtIndexNumber.Name = "txtIndexNumber"
        txtIndexNumber.Size = New Size(923, 34)
        txtIndexNumber.TabIndex = 9
        ' 
        ' lbIndexNumber
        ' 
        lbIndexNumber.AutoSize = True
        lbIndexNumber.Font = New Font("Garamond", 14.25F)
        lbIndexNumber.Location = New Point(34, 624)
        lbIndexNumber.Name = "lbIndexNumber"
        lbIndexNumber.RightToLeft = RightToLeft.Yes
        lbIndexNumber.Size = New Size(152, 27)
        lbIndexNumber.TabIndex = 7
        lbIndexNumber.Text = "Index Number"
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Garamond", 14.25F)
        txtPhone.Location = New Point(33, 565)
        txtPhone.Margin = New Padding(3, 4, 3, 4)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(923, 34)
        txtPhone.TabIndex = 6
        ' 
        ' lbPhone
        ' 
        lbPhone.AutoSize = True
        lbPhone.Font = New Font("Garamond", 14.25F)
        lbPhone.Location = New Point(33, 528)
        lbPhone.Name = "lbPhone"
        lbPhone.RightToLeft = RightToLeft.Yes
        lbPhone.Size = New Size(72, 27)
        lbPhone.TabIndex = 5
        lbPhone.Text = "Phone"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.ButtonHighlight
        txtEmail.Font = New Font("Garamond", 14.25F)
        txtEmail.Location = New Point(33, 473)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(923, 34)
        txtEmail.TabIndex = 4
        ' 
        ' lbEmail
        ' 
        lbEmail.AutoSize = True
        lbEmail.Font = New Font("Garamond", 14.25F)
        lbEmail.Location = New Point(33, 432)
        lbEmail.Name = "lbEmail"
        lbEmail.RightToLeft = RightToLeft.Yes
        lbEmail.Size = New Size(69, 27)
        lbEmail.TabIndex = 3
        lbEmail.Text = "Email"
        ' 
        ' lbFullName
        ' 
        lbFullName.AutoSize = True
        lbFullName.Font = New Font("Garamond", 14.25F)
        lbFullName.Location = New Point(33, 339)
        lbFullName.Name = "lbFullName"
        lbFullName.RightToLeft = RightToLeft.Yes
        lbFullName.Size = New Size(114, 27)
        lbFullName.TabIndex = 2
        lbFullName.Text = "Full Name"
        ' 
        ' lbAdmission
        ' 
        lbAdmission.AutoSize = True
        lbAdmission.Font = New Font("Garamond", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbAdmission.ForeColor = Color.SeaGreen
        lbAdmission.Location = New Point(134, 0)
        lbAdmission.Name = "lbAdmission"
        lbAdmission.Size = New Size(610, 56)
        lbAdmission.TabIndex = 1
        lbAdmission.Text = "University Admission Form"
        ' 
        ' txtFullName
        ' 
        txtFullName.BackColor = SystemColors.ButtonHighlight
        txtFullName.Font = New Font("Garamond", 14.25F)
        txtFullName.Location = New Point(33, 380)
        txtFullName.Margin = New Padding(3, 4, 3, 4)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(923, 34)
        txtFullName.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Black
        Panel5.Location = New Point(769, 95)
        Panel5.Margin = New Padding(3, 4, 3, 4)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(187, 239)
        Panel5.TabIndex = 62
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Black
        Panel3.Location = New Point(266, 208)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(830, 3062)
        Panel3.TabIndex = 4
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.SeaGreen
        Panel6.Location = New Point(266, 13)
        Panel6.Margin = New Padding(3, 4, 3, 4)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(106, 126)
        Panel6.TabIndex = 63
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1320, 849)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        CType(picPassport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Protected WithEvents Panel2 As Panel
    Friend WithEvents cmbE4Grade As ComboBox
    Friend WithEvents cmbE3Grade As ComboBox
    Friend WithEvents cmbE2Grade As ComboBox
    Friend WithEvents lbE4Grade As Label
    Friend WithEvents lbE3Grade As Label
    Friend WithEvents lbElective2Grade As Label
    Friend WithEvents lbElective1Grade As Label
    Friend WithEvents cmbE1Grade As ComboBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents cmbElective3 As ComboBox
    Friend WithEvents lbElective2 As Label
    Friend WithEvents cmbElective2 As ComboBox
    Friend WithEvents lbElective3 As Label
    Friend WithEvents cmbElective4 As ComboBox
    Friend WithEvents lbElective4 As Label
    Friend WithEvents cmbElective1 As ComboBox
    Friend WithEvents lbElective1 As Label
    Friend WithEvents cmbSocial As ComboBox
    Friend WithEvents cmbScience As ComboBox
    Friend WithEvents cmbMath As ComboBox
    Friend WithEvents cmbEnglish As ComboBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents lbMaths As Label
    Friend WithEvents lbScience As Label
    Friend WithEvents lbSocial As Label
    Friend WithEvents lbEnglish As Label
    Friend WithEvents lbGender As Label
    Friend WithEvents lbDOB As Label
    Friend WithEvents txtIndexNumber As TextBox
    Friend WithEvents lbIndexNumber As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lbPhone As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lbEmail As Label
    Friend WithEvents lbFullName As Label
    Friend WithEvents lbAdmission As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents cmbChoice3 As ComboBox
    Friend WithEvents cmbChoice2 As ComboBox
    Friend WithEvents lblCollegeProgram As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Protected WithEvents Panel3 As Panel
    Friend WithEvents cmbChoice1 As ComboBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnUploadPhoto As Button
    Friend WithEvents picPassport As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblPhotoPath As Label
    Friend WithEvents btnReload As Button
    Friend WithEvents linklblCheckAdmission As LinkLabel
    Friend WithEvents Panel6 As Panel

End Class
