<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmissionLists
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        dgvApplicants = New DataGridView()
        Panel2 = New Panel()
        PanelWithDgv = New Panel()
        PanelWithCrudButtons = New Panel()
        Label1 = New Label()
        PanelWithSearch = New Panel()
        cmbProgramShow = New ComboBox()
        txtIndexNumberSearch = New TextBox()
        lblProgramName = New Label()
        Label7 = New Label()
        Qu = New Label()
        Label10 = New Label()
        btnHome = New Button()
        Panel1.SuspendLayout()
        CType(dgvApplicants, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        PanelWithDgv.SuspendLayout()
        PanelWithCrudButtons.SuspendLayout()
        PanelWithSearch.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1751, 745)
        Panel1.TabIndex = 0
        ' 
        ' dgvApplicants
        ' 
        dgvApplicants.BackgroundColor = Color.White
        dgvApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvApplicants.Location = New Point(4, 324)
        dgvApplicants.Margin = New Padding(4, 5, 4, 5)
        dgvApplicants.Name = "dgvApplicants"
        dgvApplicants.RowHeadersWidth = 51
        dgvApplicants.Size = New Size(2269, 711)
        dgvApplicants.TabIndex = 28
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(PanelWithDgv)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1751, 745)
        Panel2.TabIndex = 5
        ' 
        ' PanelWithDgv
        ' 
        PanelWithDgv.AutoScroll = True
        PanelWithDgv.BackColor = Color.White
        PanelWithDgv.Controls.Add(PanelWithCrudButtons)
        PanelWithDgv.Controls.Add(dgvApplicants)
        PanelWithDgv.Controls.Add(PanelWithSearch)
        PanelWithDgv.Dock = DockStyle.Fill
        PanelWithDgv.Location = New Point(0, 0)
        PanelWithDgv.Margin = New Padding(4, 5, 4, 5)
        PanelWithDgv.Name = "PanelWithDgv"
        PanelWithDgv.Size = New Size(1751, 745)
        PanelWithDgv.TabIndex = 2
        ' 
        ' PanelWithCrudButtons
        ' 
        PanelWithCrudButtons.BackColor = Color.MediumSeaGreen
        PanelWithCrudButtons.Controls.Add(btnHome)
        PanelWithCrudButtons.Controls.Add(Label1)
        PanelWithCrudButtons.Dock = DockStyle.Top
        PanelWithCrudButtons.Location = New Point(0, 0)
        PanelWithCrudButtons.Margin = New Padding(4, 5, 4, 5)
        PanelWithCrudButtons.Name = "PanelWithCrudButtons"
        PanelWithCrudButtons.Size = New Size(2273, 76)
        PanelWithCrudButtons.TabIndex = 29
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(170, 9)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1103, 61)
        Label1.TabIndex = 21
        Label1.Text = "UEW ADMISSION LISTINGS FOR 2025 APPLICANTS"
        ' 
        ' PanelWithSearch
        ' 
        PanelWithSearch.BackColor = Color.WhiteSmoke
        PanelWithSearch.Controls.Add(cmbProgramShow)
        PanelWithSearch.Controls.Add(txtIndexNumberSearch)
        PanelWithSearch.Controls.Add(lblProgramName)
        PanelWithSearch.Controls.Add(Label7)
        PanelWithSearch.Controls.Add(Qu)
        PanelWithSearch.Controls.Add(Label10)
        PanelWithSearch.Location = New Point(0, 76)
        PanelWithSearch.Margin = New Padding(4, 5, 4, 5)
        PanelWithSearch.Name = "PanelWithSearch"
        PanelWithSearch.Size = New Size(2272, 238)
        PanelWithSearch.TabIndex = 27
        ' 
        ' cmbProgramShow
        ' 
        cmbProgramShow.BackColor = SystemColors.Info
        cmbProgramShow.Font = New Font("Garamond", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbProgramShow.ForeColor = Color.Red
        cmbProgramShow.FormattingEnabled = True
        cmbProgramShow.Location = New Point(395, 89)
        cmbProgramShow.Margin = New Padding(4, 5, 4, 5)
        cmbProgramShow.Name = "cmbProgramShow"
        cmbProgramShow.Size = New Size(600, 44)
        cmbProgramShow.TabIndex = 27
        cmbProgramShow.Text = "--Select Program--"
        ' 
        ' txtIndexNumberSearch
        ' 
        txtIndexNumberSearch.BackColor = SystemColors.Info
        txtIndexNumberSearch.Font = New Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtIndexNumberSearch.ForeColor = SystemColors.ActiveCaptionText
        txtIndexNumberSearch.Location = New Point(395, 172)
        txtIndexNumberSearch.Margin = New Padding(4, 5, 4, 5)
        txtIndexNumberSearch.Name = "txtIndexNumberSearch"
        txtIndexNumberSearch.Size = New Size(600, 39)
        txtIndexNumberSearch.TabIndex = 27
        ' 
        ' lblProgramName
        ' 
        lblProgramName.AutoSize = True
        lblProgramName.BackColor = Color.Transparent
        lblProgramName.Font = New Font("Garamond", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProgramName.ForeColor = Color.Red
        lblProgramName.Location = New Point(531, 38)
        lblProgramName.Margin = New Padding(4, 0, 4, 0)
        lblProgramName.Name = "lblProgramName"
        lblProgramName.Size = New Size(83, 22)
        lblProgramName.TabIndex = 21
        lblProgramName.Text = "Program"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Garamond", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(52, 38)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(465, 22)
        Label7.TabIndex = 20
        Label7.Text = "*Note: Below is Are Lists All Admitted Applicants in  "
        ' 
        ' Qu
        ' 
        Qu.AutoSize = True
        Qu.BackColor = Color.Transparent
        Qu.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Qu.ForeColor = Color.Black
        Qu.Location = New Point(52, 172)
        Qu.Margin = New Padding(4, 0, 4, 0)
        Qu.Name = "Qu"
        Qu.Size = New Size(329, 33)
        Qu.TabIndex = 19
        Qu.Text = "Search By Index Number"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(52, 94)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(122, 33)
        Label10.TabIndex = 18
        Label10.Text = "Program"
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.Red
        btnHome.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHome.ForeColor = Color.White
        btnHome.Location = New Point(13, 14)
        btnHome.Margin = New Padding(4, 5, 4, 5)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(139, 49)
        btnHome.TabIndex = 36
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' AdmissionLists
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1751, 745)
        Controls.Add(Panel1)
        Name = "AdmissionLists"
        Text = "AdmissionLists"
        Panel1.ResumeLayout(False)
        CType(dgvApplicants, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        PanelWithDgv.ResumeLayout(False)
        PanelWithCrudButtons.ResumeLayout(False)
        PanelWithCrudButtons.PerformLayout()
        PanelWithSearch.ResumeLayout(False)
        PanelWithSearch.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelWithDgv As Panel
    Friend WithEvents PanelWithCrudButtons As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvApplicants As DataGridView
    Friend WithEvents PanelWithSearch As Panel
    Friend WithEvents cmbProgramShow As ComboBox
    Friend WithEvents txtIndexNumberSearch As TextBox
    Friend WithEvents lblProgramName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Qu As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnHome As Button
End Class
