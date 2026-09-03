<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Admissions
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        PanelWithDgv = New Panel()
        dgvApplicants = New DataGridView()
        PanelWithSearch = New Panel()
        Label4 = New Label()
        lblProgramPendingCounts = New Label()
        cc = New Label()
        lblProgramRejectedCounts = New Label()
        Label13 = New Label()
        lblProgramAdmittedCounts = New Label()
        lblProgramName = New Label()
        Label12 = New Label()
        lblDepartmentName = New Label()
        Label7 = New Label()
        Label5 = New Label()
        lblDepartmentQuota = New Label()
        Qu = New Label()
        line1 = New Button()
        line2 = New Button()
        lblProgramTotalApplicantsCounts = New Label()
        Label11 = New Label()
        lblDepartmentSlotsLeftTotal = New Label()
        ll = New Label()
        line3 = New Button()
        lblTotalAllDepartmentApplicantsCounts = New Label()
        Label10 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        lblTotaDepartmentApplicantsPendingCounts = New Label()
        lblTotalDepartmentApplicantsRejectedCounts = New Label()
        Label1 = New Label()
        lblTotalDepartmentApplicantsAdmittedCounts = New Label()
        txtSearch = New TextBox()
        PanelInputBundle = New Panel()
        Label2 = New Label()
        cmbProgram = New ComboBox()
        btnLoad = New Button()
        cmbFilterRank = New ComboBox()
        cmbFilterStatus = New ComboBox()
        LinkLabel2 = New LinkLabel()
        Label6 = New Label()
        lable = New Label()
        Label3 = New Label()
        PanelRedDesign = New Panel()
        PanelWithCrudButtons = New Panel()
        btnExport = New Button()
        btnAdmit = New Button()
        btnReject = New Button()
        Panel1.SuspendLayout()
        PanelWithDgv.SuspendLayout()
        CType(dgvApplicants, ComponentModel.ISupportInitialize).BeginInit()
        PanelWithSearch.SuspendLayout()
        PanelInputBundle.SuspendLayout()
        PanelWithCrudButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(PanelWithDgv)
        Panel1.Controls.Add(PanelInputBundle)
        Panel1.Controls.Add(PanelRedDesign)
        Panel1.Controls.Add(PanelWithCrudButtons)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(2076, 1049)
        Panel1.TabIndex = 3
        ' 
        ' PanelWithDgv
        ' 
        PanelWithDgv.AutoScroll = True
        PanelWithDgv.BackColor = Color.White
        PanelWithDgv.Controls.Add(dgvApplicants)
        PanelWithDgv.Controls.Add(PanelWithSearch)
        PanelWithDgv.Location = New Point(65, 168)
        PanelWithDgv.Margin = New Padding(4, 5, 4, 5)
        PanelWithDgv.Name = "PanelWithDgv"
        PanelWithDgv.Size = New Size(1659, 887)
        PanelWithDgv.TabIndex = 2
        ' 
        ' dgvApplicants
        ' 
        dgvApplicants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvApplicants.BackgroundColor = Color.White
        dgvApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvApplicants.Location = New Point(4, 415)
        dgvApplicants.Margin = New Padding(4, 5, 4, 5)
        dgvApplicants.Name = "dgvApplicants"
        dgvApplicants.RowHeadersWidth = 51
        dgvApplicants.Size = New Size(1620, 876)
        dgvApplicants.TabIndex = 28
        ' 
        ' PanelWithSearch
        ' 
        PanelWithSearch.AutoScroll = True
        PanelWithSearch.AutoSize = True
        PanelWithSearch.BackColor = Color.Gainsboro
        PanelWithSearch.Controls.Add(Label4)
        PanelWithSearch.Controls.Add(lblProgramPendingCounts)
        PanelWithSearch.Controls.Add(cc)
        PanelWithSearch.Controls.Add(lblProgramRejectedCounts)
        PanelWithSearch.Controls.Add(Label13)
        PanelWithSearch.Controls.Add(lblProgramAdmittedCounts)
        PanelWithSearch.Controls.Add(lblProgramName)
        PanelWithSearch.Controls.Add(Label12)
        PanelWithSearch.Controls.Add(lblDepartmentName)
        PanelWithSearch.Controls.Add(Label7)
        PanelWithSearch.Controls.Add(Label5)
        PanelWithSearch.Controls.Add(lblDepartmentQuota)
        PanelWithSearch.Controls.Add(Qu)
        PanelWithSearch.Controls.Add(line1)
        PanelWithSearch.Controls.Add(line2)
        PanelWithSearch.Controls.Add(lblProgramTotalApplicantsCounts)
        PanelWithSearch.Controls.Add(Label11)
        PanelWithSearch.Controls.Add(lblDepartmentSlotsLeftTotal)
        PanelWithSearch.Controls.Add(ll)
        PanelWithSearch.Controls.Add(line3)
        PanelWithSearch.Controls.Add(lblTotalAllDepartmentApplicantsCounts)
        PanelWithSearch.Controls.Add(Label10)
        PanelWithSearch.Controls.Add(Label8)
        PanelWithSearch.Controls.Add(Label9)
        PanelWithSearch.Controls.Add(lblTotaDepartmentApplicantsPendingCounts)
        PanelWithSearch.Controls.Add(lblTotalDepartmentApplicantsRejectedCounts)
        PanelWithSearch.Controls.Add(Label1)
        PanelWithSearch.Controls.Add(lblTotalDepartmentApplicantsAdmittedCounts)
        PanelWithSearch.Controls.Add(txtSearch)
        PanelWithSearch.Location = New Point(0, 5)
        PanelWithSearch.Margin = New Padding(4, 5, 4, 5)
        PanelWithSearch.Name = "PanelWithSearch"
        PanelWithSearch.Size = New Size(1624, 410)
        PanelWithSearch.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Garamond", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(961, 294)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 22)
        Label4.TabIndex = 19
        Label4.Text = "Search"
        ' 
        ' lblProgramPendingCounts
        ' 
        lblProgramPendingCounts.AutoSize = True
        lblProgramPendingCounts.BackColor = Color.Red
        lblProgramPendingCounts.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProgramPendingCounts.ForeColor = Color.White
        lblProgramPendingCounts.Location = New Point(1228, 231)
        lblProgramPendingCounts.Margin = New Padding(4, 0, 4, 0)
        lblProgramPendingCounts.Name = "lblProgramPendingCounts"
        lblProgramPendingCounts.Size = New Size(106, 33)
        lblProgramPendingCounts.TabIndex = 34
        lblProgramPendingCounts.Text = "*Qouta"
        ' 
        ' cc
        ' 
        cc.AutoSize = True
        cc.BackColor = Color.Transparent
        cc.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cc.ForeColor = Color.Black
        cc.Location = New Point(935, 231)
        cc.Margin = New Padding(4, 0, 4, 0)
        cc.Name = "cc"
        cc.Size = New Size(280, 33)
        cc.TabIndex = 18
        cc.Text = "*Applicants Pending:"
        ' 
        ' lblProgramRejectedCounts
        ' 
        lblProgramRejectedCounts.AutoSize = True
        lblProgramRejectedCounts.BackColor = Color.Red
        lblProgramRejectedCounts.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProgramRejectedCounts.ForeColor = Color.White
        lblProgramRejectedCounts.Location = New Point(1228, 175)
        lblProgramRejectedCounts.Margin = New Padding(4, 0, 4, 0)
        lblProgramRejectedCounts.Name = "lblProgramRejectedCounts"
        lblProgramRejectedCounts.Size = New Size(106, 33)
        lblProgramRejectedCounts.TabIndex = 36
        lblProgramRejectedCounts.Text = "*Qouta"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(935, 175)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(285, 33)
        Label13.TabIndex = 19
        Label13.Text = "*Applicants Rejected:"
        ' 
        ' lblProgramAdmittedCounts
        ' 
        lblProgramAdmittedCounts.AutoSize = True
        lblProgramAdmittedCounts.BackColor = Color.Red
        lblProgramAdmittedCounts.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProgramAdmittedCounts.ForeColor = Color.White
        lblProgramAdmittedCounts.Location = New Point(1228, 119)
        lblProgramAdmittedCounts.Margin = New Padding(4, 0, 4, 0)
        lblProgramAdmittedCounts.Name = "lblProgramAdmittedCounts"
        lblProgramAdmittedCounts.Size = New Size(106, 33)
        lblProgramAdmittedCounts.TabIndex = 35
        lblProgramAdmittedCounts.Text = "*Qouta"
        ' 
        ' lblProgramName
        ' 
        lblProgramName.AutoSize = True
        lblProgramName.BackColor = Color.Transparent
        lblProgramName.Font = New Font("Garamond", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblProgramName.ForeColor = Color.Red
        lblProgramName.Location = New Point(1228, 20)
        lblProgramName.Margin = New Padding(4, 0, 4, 0)
        lblProgramName.Name = "lblProgramName"
        lblProgramName.Size = New Size(83, 22)
        lblProgramName.TabIndex = 22
        lblProgramName.Text = "Program"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Garamond", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(949, 20)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(267, 22)
        Label12.TabIndex = 21
        Label12.Text = "*Note: Below is a Statistics for"
        ' 
        ' lblDepartmentName
        ' 
        lblDepartmentName.AutoSize = True
        lblDepartmentName.BackColor = Color.Transparent
        lblDepartmentName.Font = New Font("Garamond", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblDepartmentName.ForeColor = Color.Red
        lblDepartmentName.Location = New Point(299, 14)
        lblDepartmentName.Margin = New Padding(4, 0, 4, 0)
        lblDepartmentName.Name = "lblDepartmentName"
        lblDepartmentName.Size = New Size(111, 22)
        lblDepartmentName.TabIndex = 21
        lblDepartmentName.Text = "Department"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Garamond", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(8, 14)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(267, 22)
        Label7.TabIndex = 20
        Label7.Text = "*Note: Below is a Statistics for"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(935, 119)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(282, 33)
        Label5.TabIndex = 18
        Label5.Text = "*Applicants Admited:"
        ' 
        ' lblDepartmentQuota
        ' 
        lblDepartmentQuota.AutoSize = True
        lblDepartmentQuota.BackColor = Color.Red
        lblDepartmentQuota.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartmentQuota.ForeColor = Color.White
        lblDepartmentQuota.Location = New Point(340, 65)
        lblDepartmentQuota.Margin = New Padding(4, 0, 4, 0)
        lblDepartmentQuota.Name = "lblDepartmentQuota"
        lblDepartmentQuota.Size = New Size(106, 33)
        lblDepartmentQuota.TabIndex = 35
        lblDepartmentQuota.Text = "*Qouta"
        ' 
        ' Qu
        ' 
        Qu.AutoSize = True
        Qu.BackColor = Color.Transparent
        Qu.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Qu.ForeColor = Color.Black
        Qu.Location = New Point(4, 65)
        Qu.Margin = New Padding(4, 0, 4, 0)
        Qu.Name = "Qu"
        Qu.Size = New Size(106, 33)
        Qu.TabIndex = 19
        Qu.Text = "*Quota"
        ' 
        ' line1
        ' 
        line1.BackColor = Color.Transparent
        line1.FlatAppearance.BorderSize = 0
        line1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Bold)
        line1.ForeColor = Color.Transparent
        line1.Location = New Point(668, 29)
        line1.Margin = New Padding(4, 5, 4, 5)
        line1.Name = "line1"
        line1.Size = New Size(14, 225)
        line1.TabIndex = 17
        line1.UseVisualStyleBackColor = False
        ' 
        ' line2
        ' 
        line2.BackColor = Color.Transparent
        line2.FlatAppearance.BorderSize = 0
        line2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Bold)
        line2.ForeColor = Color.Transparent
        line2.Location = New Point(668, 299)
        line2.Margin = New Padding(4, 5, 4, 5)
        line2.Name = "line2"
        line2.Size = New Size(14, 106)
        line2.TabIndex = 16
        line2.Text = "Admit"
        line2.UseVisualStyleBackColor = False
        ' 
        ' lblProgramTotalApplicantsCounts
        ' 
        lblProgramTotalApplicantsCounts.AutoSize = True
        lblProgramTotalApplicantsCounts.BackColor = Color.Red
        lblProgramTotalApplicantsCounts.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProgramTotalApplicantsCounts.ForeColor = Color.White
        lblProgramTotalApplicantsCounts.Location = New Point(1228, 65)
        lblProgramTotalApplicantsCounts.Margin = New Padding(4, 0, 4, 0)
        lblProgramTotalApplicantsCounts.Name = "lblProgramTotalApplicantsCounts"
        lblProgramTotalApplicantsCounts.Size = New Size(106, 33)
        lblProgramTotalApplicantsCounts.TabIndex = 34
        lblProgramTotalApplicantsCounts.Text = "*Qouta"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(4, 341)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(153, 33)
        Label11.TabIndex = 17
        Label11.Text = "*Slots Left:"
        ' 
        ' lblDepartmentSlotsLeftTotal
        ' 
        lblDepartmentSlotsLeftTotal.AutoSize = True
        lblDepartmentSlotsLeftTotal.BackColor = Color.Red
        lblDepartmentSlotsLeftTotal.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartmentSlotsLeftTotal.ForeColor = Color.White
        lblDepartmentSlotsLeftTotal.Location = New Point(340, 346)
        lblDepartmentSlotsLeftTotal.Margin = New Padding(4, 0, 4, 0)
        lblDepartmentSlotsLeftTotal.Name = "lblDepartmentSlotsLeftTotal"
        lblDepartmentSlotsLeftTotal.Size = New Size(106, 33)
        lblDepartmentSlotsLeftTotal.TabIndex = 35
        lblDepartmentSlotsLeftTotal.Text = "*Qouta"
        ' 
        ' ll
        ' 
        ll.AutoSize = True
        ll.BackColor = Color.Transparent
        ll.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ll.ForeColor = Color.Black
        ll.Location = New Point(935, 65)
        ll.Margin = New Padding(4, 0, 4, 0)
        ll.Name = "ll"
        ll.Size = New Size(242, 33)
        ll.TabIndex = 17
        ll.Text = "*Total Applicants:"
        ' 
        ' line3
        ' 
        line3.BackColor = Color.Transparent
        line3.FlatAppearance.BorderSize = 0
        line3.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Bold)
        line3.ForeColor = Color.Transparent
        line3.Location = New Point(1464, 126)
        line3.Margin = New Padding(4, 5, 4, 5)
        line3.Name = "line3"
        line3.Size = New Size(14, 124)
        line3.TabIndex = 15
        line3.Text = "Admit"
        line3.UseVisualStyleBackColor = False
        ' 
        ' lblTotalAllDepartmentApplicantsCounts
        ' 
        lblTotalAllDepartmentApplicantsCounts.AutoSize = True
        lblTotalAllDepartmentApplicantsCounts.BackColor = Color.Red
        lblTotalAllDepartmentApplicantsCounts.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalAllDepartmentApplicantsCounts.ForeColor = Color.White
        lblTotalAllDepartmentApplicantsCounts.Location = New Point(341, 119)
        lblTotalAllDepartmentApplicantsCounts.Margin = New Padding(4, 0, 4, 0)
        lblTotalAllDepartmentApplicantsCounts.Name = "lblTotalAllDepartmentApplicantsCounts"
        lblTotalAllDepartmentApplicantsCounts.Size = New Size(106, 33)
        lblTotalAllDepartmentApplicantsCounts.TabIndex = 34
        lblTotalAllDepartmentApplicantsCounts.Text = "*Qouta"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(4, 119)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(226, 33)
        Label10.TabIndex = 18
        Label10.Text = "*Total Aplicants:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(4, 286)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(280, 33)
        Label8.TabIndex = 16
        Label8.Text = "*Applicants Pending:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(2, 231)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(285, 33)
        Label9.TabIndex = 17
        Label9.Text = "*Applicants Rejected:"
        ' 
        ' lblTotaDepartmentApplicantsPendingCounts
        ' 
        lblTotaDepartmentApplicantsPendingCounts.AutoSize = True
        lblTotaDepartmentApplicantsPendingCounts.BackColor = Color.Red
        lblTotaDepartmentApplicantsPendingCounts.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotaDepartmentApplicantsPendingCounts.ForeColor = Color.White
        lblTotaDepartmentApplicantsPendingCounts.Location = New Point(340, 294)
        lblTotaDepartmentApplicantsPendingCounts.Margin = New Padding(4, 0, 4, 0)
        lblTotaDepartmentApplicantsPendingCounts.Name = "lblTotaDepartmentApplicantsPendingCounts"
        lblTotaDepartmentApplicantsPendingCounts.Size = New Size(106, 33)
        lblTotaDepartmentApplicantsPendingCounts.TabIndex = 33
        lblTotaDepartmentApplicantsPendingCounts.Text = "*Qouta"
        ' 
        ' lblTotalDepartmentApplicantsRejectedCounts
        ' 
        lblTotalDepartmentApplicantsRejectedCounts.AutoSize = True
        lblTotalDepartmentApplicantsRejectedCounts.BackColor = Color.Red
        lblTotalDepartmentApplicantsRejectedCounts.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalDepartmentApplicantsRejectedCounts.ForeColor = Color.White
        lblTotalDepartmentApplicantsRejectedCounts.Location = New Point(338, 236)
        lblTotalDepartmentApplicantsRejectedCounts.Margin = New Padding(4, 0, 4, 0)
        lblTotalDepartmentApplicantsRejectedCounts.Name = "lblTotalDepartmentApplicantsRejectedCounts"
        lblTotalDepartmentApplicantsRejectedCounts.Size = New Size(106, 33)
        lblTotalDepartmentApplicantsRejectedCounts.TabIndex = 33
        lblTotalDepartmentApplicantsRejectedCounts.Text = "*Qouta"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(2, 175)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(282, 33)
        Label1.TabIndex = 15
        Label1.Text = "*Applicants Admited:"
        ' 
        ' lblTotalDepartmentApplicantsAdmittedCounts
        ' 
        lblTotalDepartmentApplicantsAdmittedCounts.AutoSize = True
        lblTotalDepartmentApplicantsAdmittedCounts.BackColor = Color.Red
        lblTotalDepartmentApplicantsAdmittedCounts.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalDepartmentApplicantsAdmittedCounts.ForeColor = Color.White
        lblTotalDepartmentApplicantsAdmittedCounts.Location = New Point(340, 176)
        lblTotalDepartmentApplicantsAdmittedCounts.Margin = New Padding(4, 0, 4, 0)
        lblTotalDepartmentApplicantsAdmittedCounts.Name = "lblTotalDepartmentApplicantsAdmittedCounts"
        lblTotalDepartmentApplicantsAdmittedCounts.Size = New Size(106, 33)
        lblTotalDepartmentApplicantsAdmittedCounts.TabIndex = 32
        lblTotalDepartmentApplicantsAdmittedCounts.Text = "*Qouta"
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = SystemColors.Info
        txtSearch.Font = New Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = SystemColors.ActiveCaptionText
        txtSearch.Location = New Point(1040, 286)
        txtSearch.Margin = New Padding(4, 5, 4, 5)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(338, 39)
        txtSearch.TabIndex = 26
        ' 
        ' PanelInputBundle
        ' 
        PanelInputBundle.BackColor = Color.White
        PanelInputBundle.Controls.Add(Label2)
        PanelInputBundle.Controls.Add(cmbProgram)
        PanelInputBundle.Controls.Add(btnLoad)
        PanelInputBundle.Controls.Add(cmbFilterRank)
        PanelInputBundle.Controls.Add(cmbFilterStatus)
        PanelInputBundle.Controls.Add(LinkLabel2)
        PanelInputBundle.Controls.Add(Label6)
        PanelInputBundle.Controls.Add(lable)
        PanelInputBundle.Controls.Add(Label3)
        PanelInputBundle.Location = New Point(436, 86)
        PanelInputBundle.Margin = New Padding(4, 5, 4, 5)
        PanelInputBundle.Name = "PanelInputBundle"
        PanelInputBundle.Size = New Size(784, 861)
        PanelInputBundle.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(19, 496)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 33)
        Label2.TabIndex = 33
        Label2.Text = "*Program"
        ' 
        ' cmbProgram
        ' 
        cmbProgram.BackColor = SystemColors.Info
        cmbProgram.Font = New Font("Garamond", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbProgram.ForeColor = Color.Red
        cmbProgram.FormattingEnabled = True
        cmbProgram.Location = New Point(19, 545)
        cmbProgram.Margin = New Padding(4, 5, 4, 5)
        cmbProgram.Name = "cmbProgram"
        cmbProgram.Size = New Size(726, 44)
        cmbProgram.TabIndex = 32
        ' 
        ' btnLoad
        ' 
        btnLoad.BackColor = Color.MediumSeaGreen
        btnLoad.FlatAppearance.BorderSize = 0
        btnLoad.Font = New Font("Arial Rounded MT Bold", 12F)
        btnLoad.ForeColor = Color.Transparent
        btnLoad.Location = New Point(19, 724)
        btnLoad.Margin = New Padding(4, 5, 4, 5)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(342, 60)
        btnLoad.TabIndex = 31
        btnLoad.Text = "Load"
        btnLoad.UseVisualStyleBackColor = False
        ' 
        ' cmbFilterRank
        ' 
        cmbFilterRank.BackColor = SystemColors.Info
        cmbFilterRank.Font = New Font("Garamond", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbFilterRank.ForeColor = Color.Red
        cmbFilterRank.FormattingEnabled = True
        cmbFilterRank.Location = New Point(19, 194)
        cmbFilterRank.Margin = New Padding(4, 5, 4, 5)
        cmbFilterRank.Name = "cmbFilterRank"
        cmbFilterRank.Size = New Size(726, 44)
        cmbFilterRank.TabIndex = 30
        cmbFilterRank.Text = "--Select a Choice--"
        ' 
        ' cmbFilterStatus
        ' 
        cmbFilterStatus.BackColor = SystemColors.Info
        cmbFilterStatus.Font = New Font("Garamond", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbFilterStatus.ForeColor = Color.Red
        cmbFilterStatus.FormattingEnabled = True
        cmbFilterStatus.Location = New Point(19, 366)
        cmbFilterStatus.Margin = New Padding(4, 5, 4, 5)
        cmbFilterStatus.Name = "cmbFilterStatus"
        cmbFilterStatus.Size = New Size(726, 44)
        cmbFilterStatus.TabIndex = 26
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Segoe UI", 12F)
        LinkLabel2.Location = New Point(284, 811)
        LinkLabel2.Margin = New Padding(4, 0, 4, 0)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(211, 32)
        LinkLabel2.TabIndex = 25
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "I have a Problem ?"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.MediumSeaGreen
        Label6.Location = New Point(19, 19)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(443, 51)
        Label6.TabIndex = 15
        Label6.Text = "Admissions Control"
        ' 
        ' lable
        ' 
        lable.AutoSize = True
        lable.BackColor = Color.Transparent
        lable.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lable.ForeColor = Color.Black
        lable.Location = New Point(19, 304)
        lable.Margin = New Padding(4, 0, 4, 0)
        lable.Name = "lable"
        lable.Size = New Size(315, 33)
        lable.TabIndex = 16
        lable.Text = "*Admission Status Filter"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(16, 135)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(340, 33)
        Label3.TabIndex = 14
        Label3.Text = "*Choice Rank Filter 1/2/3"
        ' 
        ' PanelRedDesign
        ' 
        PanelRedDesign.BackColor = Color.MediumSeaGreen
        PanelRedDesign.Location = New Point(418, 120)
        PanelRedDesign.Margin = New Padding(4, 5, 4, 5)
        PanelRedDesign.Name = "PanelRedDesign"
        PanelRedDesign.Size = New Size(678, 859)
        PanelRedDesign.TabIndex = 3
        ' 
        ' PanelWithCrudButtons
        ' 
        PanelWithCrudButtons.BackColor = Color.Black
        PanelWithCrudButtons.Controls.Add(btnExport)
        PanelWithCrudButtons.Controls.Add(btnAdmit)
        PanelWithCrudButtons.Controls.Add(btnReject)
        PanelWithCrudButtons.Dock = DockStyle.Top
        PanelWithCrudButtons.Location = New Point(0, 0)
        PanelWithCrudButtons.Margin = New Padding(4, 5, 4, 5)
        PanelWithCrudButtons.Name = "PanelWithCrudButtons"
        PanelWithCrudButtons.Size = New Size(2050, 76)
        PanelWithCrudButtons.TabIndex = 1
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.White
        btnExport.FlatAppearance.BorderSize = 0
        btnExport.Font = New Font("Arial Rounded MT Bold", 12F)
        btnExport.ForeColor = Color.Black
        btnExport.Location = New Point(1218, 11)
        btnExport.Margin = New Padding(4, 5, 4, 5)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(342, 60)
        btnExport.TabIndex = 14
        btnExport.Text = "Export Excel"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' btnAdmit
        ' 
        btnAdmit.BackColor = Color.White
        btnAdmit.FlatAppearance.BorderSize = 0
        btnAdmit.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Bold)
        btnAdmit.ForeColor = Color.Black
        btnAdmit.Location = New Point(291, 11)
        btnAdmit.Margin = New Padding(4, 5, 4, 5)
        btnAdmit.Name = "btnAdmit"
        btnAdmit.Size = New Size(342, 60)
        btnAdmit.TabIndex = 12
        btnAdmit.Text = "Admit"
        btnAdmit.UseVisualStyleBackColor = False
        ' 
        ' btnReject
        ' 
        btnReject.BackColor = Color.White
        btnReject.FlatAppearance.BorderSize = 0
        btnReject.Font = New Font("Arial Rounded MT Bold", 12F)
        btnReject.ForeColor = Color.Black
        btnReject.Location = New Point(751, 6)
        btnReject.Margin = New Padding(4, 5, 4, 5)
        btnReject.Name = "btnReject"
        btnReject.Size = New Size(342, 60)
        btnReject.TabIndex = 13
        btnReject.Text = "Reject"
        btnReject.UseVisualStyleBackColor = False
        ' 
        ' UC_Admissions
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "UC_Admissions"
        Size = New Size(2076, 1049)
        Panel1.ResumeLayout(False)
        PanelWithDgv.ResumeLayout(False)
        PanelWithDgv.PerformLayout()
        CType(dgvApplicants, ComponentModel.ISupportInitialize).EndInit()
        PanelWithSearch.ResumeLayout(False)
        PanelWithSearch.PerformLayout()
        PanelInputBundle.ResumeLayout(False)
        PanelInputBundle.PerformLayout()
        PanelWithCrudButtons.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelInputBundle As Panel
    Friend WithEvents cmbFilterRank As ComboBox
    Friend WithEvents cmbFilterStatus As ComboBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents lable As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelRedDesign As Panel
    Friend WithEvents PanelWithCrudButtons As Panel
    Friend WithEvents btnAdmit As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents PanelWithDgv As Panel
    Friend WithEvents PanelWithSearch As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalDepartmentApplicantsAdmittedCounts As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvApplicants As DataGridView

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents cmbProgram As ComboBox
    Friend WithEvents btnExport As Button
    Friend WithEvents lblTotaDepartmentApplicantsPendingCounts As Label
    Friend WithEvents lblTotalDepartmentApplicantsRejectedCounts As Label
    Friend WithEvents lblTotalAllDepartmentApplicantsCounts As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents line3 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents lblDepartmentSlotsLeftTotal As Label
    Friend WithEvents ll As Label
    Friend WithEvents lblProgramTotalApplicantsCounts As Label
    Friend WithEvents line2 As Button
    Friend WithEvents line1 As Button
    Friend WithEvents Qu As Label
    Friend WithEvents lblDepartmentQuota As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDepartmentName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblProgramName As Label
    Friend WithEvents lblProgramPendingCounts As Label
    Friend WithEvents cc As Label
    Friend WithEvents lblProgramRejectedCounts As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblProgramAdmittedCounts As Label
    Friend WithEvents Label4 As Label
End Class
