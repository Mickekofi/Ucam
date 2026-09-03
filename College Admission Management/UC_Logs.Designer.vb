<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Logs
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
        lblRecentActivity = New Label()
        PanelWithDgv = New Panel()
        PanelWithDgv2 = New Panel()
        dvgAuditTrial = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Panel = New Panel()
        btnSearch2 = New Button()
        TextBox2 = New TextBox()
        Panel4 = New Panel()
        btnSearch = New Button()
        TextBox1 = New TextBox()
        dvgFlowsLogs = New DataGridView()
        Testing1 = New DataGridViewTextBoxColumn()
        Testing2 = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        Email = New DataGridViewTextBoxColumn()
        Year = New DataGridViewTextBoxColumn()
        nothing1 = New Panel()
        cmbLogYear = New ComboBox()
        cmbLogType = New ComboBox()
        btnLoadLogs = New Button()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        PanelWithDgv.SuspendLayout()
        PanelWithDgv2.SuspendLayout()
        CType(dvgAuditTrial, ComponentModel.ISupportInitialize).BeginInit()
        Panel.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dvgFlowsLogs, ComponentModel.ISupportInitialize).BeginInit()
        nothing1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Azure
        Panel1.Controls.Add(PanelWithDgv)
        Panel1.Controls.Add(nothing1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblRecentActivity)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1021, 557)
        Panel1.TabIndex = 2
        ' 
        ' lblRecentActivity
        ' 
        lblRecentActivity.AllowDrop = True
        lblRecentActivity.AutoEllipsis = True
        lblRecentActivity.AutoSize = True
        lblRecentActivity.Font = New Font("Garamond", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRecentActivity.ForeColor = Color.Teal
        lblRecentActivity.Location = New Point(400, 384)
        lblRecentActivity.Name = "lblRecentActivity"
        lblRecentActivity.Size = New Size(237, 30)
        lblRecentActivity.TabIndex = 4
        lblRecentActivity.Text = "No Choosen Activity"
        ' 
        ' PanelWithDgv
        ' 
        PanelWithDgv.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelWithDgv.BackColor = Color.Crimson
        PanelWithDgv.Controls.Add(PanelWithDgv2)
        PanelWithDgv.Controls.Add(Panel4)
        PanelWithDgv.Controls.Add(dvgFlowsLogs)
        PanelWithDgv.Location = New Point(0, 53)
        PanelWithDgv.Name = "PanelWithDgv"
        PanelWithDgv.Size = New Size(1957, 998)
        PanelWithDgv.TabIndex = 2
        ' 
        ' PanelWithDgv2
        ' 
        PanelWithDgv2.BackColor = Color.RoyalBlue
        PanelWithDgv2.Controls.Add(dvgAuditTrial)
        PanelWithDgv2.Controls.Add(Panel)
        PanelWithDgv2.Location = New Point(0, 3)
        PanelWithDgv2.Name = "PanelWithDgv2"
        PanelWithDgv2.Size = New Size(1985, 968)
        PanelWithDgv2.TabIndex = 28
        ' 
        ' dvgAuditTrial
        ' 
        dvgAuditTrial.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        dvgAuditTrial.BackgroundColor = Color.Gold
        dvgAuditTrial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dvgAuditTrial.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        dvgAuditTrial.Location = New Point(0, 44)
        dvgAuditTrial.Name = "dvgAuditTrial"
        dvgAuditTrial.ReadOnly = True
        dvgAuditTrial.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dvgAuditTrial.Size = New Size(1136, 2290)
        dvgAuditTrial.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Column1"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Column2"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Column3"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Column4"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Column5"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Column6"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Panel
        ' 
        Panel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel.BackColor = Color.Transparent
        Panel.Controls.Add(btnSearch2)
        Panel.Controls.Add(TextBox2)
        Panel.Location = New Point(0, 0)
        Panel.Name = "Panel"
        Panel.Size = New Size(4678, 42)
        Panel.TabIndex = 27
        ' 
        ' btnSearch2
        ' 
        btnSearch2.BackColor = Color.MediumSeaGreen
        btnSearch2.FlatAppearance.BorderSize = 0
        btnSearch2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Bold)
        btnSearch2.ForeColor = Color.Transparent
        btnSearch2.Location = New Point(772, 5)
        btnSearch2.Name = "btnSearch2"
        btnSearch2.Size = New Size(205, 36)
        btnSearch2.TabIndex = 15
        btnSearch2.Text = "Go search"
        btnSearch2.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.Info
        TextBox2.Font = New Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = SystemColors.ActiveCaptionText
        TextBox2.Location = New Point(318, 10)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(424, 28)
        TextBox2.TabIndex = 26
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(btnSearch)
        Panel4.Controls.Add(TextBox1)
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(2893, 42)
        Panel4.TabIndex = 27
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.MediumSeaGreen
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Bold)
        btnSearch.ForeColor = Color.Transparent
        btnSearch.Location = New Point(772, 5)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(205, 36)
        btnSearch.TabIndex = 15
        btnSearch.Text = "Go search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Info
        TextBox1.Font = New Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.ActiveCaptionText
        TextBox1.Location = New Point(318, 10)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(424, 28)
        TextBox1.TabIndex = 26
        ' 
        ' dvgFlowsLogs
        ' 
        dvgFlowsLogs.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        dvgFlowsLogs.BackgroundColor = Color.Black
        dvgFlowsLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dvgFlowsLogs.Columns.AddRange(New DataGridViewColumn() {Testing1, Testing2, colName, Email, Year})
        dvgFlowsLogs.Location = New Point(0, 45)
        dvgFlowsLogs.Name = "dvgFlowsLogs"
        dvgFlowsLogs.ReadOnly = True
        dvgFlowsLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dvgFlowsLogs.Size = New Size(1136, 1408)
        dvgFlowsLogs.TabIndex = 0
        ' 
        ' Testing1
        ' 
        Testing1.HeaderText = "Column1"
        Testing1.Name = "Testing1"
        Testing1.ReadOnly = True
        ' 
        ' Testing2
        ' 
        Testing2.HeaderText = "Column1"
        Testing2.Name = "Testing2"
        Testing2.ReadOnly = True
        ' 
        ' colName
        ' 
        colName.HeaderText = "Column1"
        colName.Name = "colName"
        colName.ReadOnly = True
        ' 
        ' Email
        ' 
        Email.HeaderText = "Column1"
        Email.Name = "Email"
        Email.ReadOnly = True
        ' 
        ' Year
        ' 
        Year.HeaderText = "Column1"
        Year.Name = "Year"
        Year.ReadOnly = True
        ' 
        ' nothing1
        ' 
        nothing1.BackColor = Color.MediumSeaGreen
        nothing1.Controls.Add(cmbLogYear)
        nothing1.Controls.Add(cmbLogType)
        nothing1.Controls.Add(btnLoadLogs)
        nothing1.Dock = DockStyle.Top
        nothing1.Location = New Point(0, 0)
        nothing1.Name = "nothing1"
        nothing1.Size = New Size(1021, 53)
        nothing1.TabIndex = 1
        ' 
        ' cmbLogYear
        ' 
        cmbLogYear.BackColor = SystemColors.Info
        cmbLogYear.Font = New Font("Garamond", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbLogYear.ForeColor = Color.Red
        cmbLogYear.FormattingEnabled = True
        cmbLogYear.Items.AddRange(New Object() {"ICT (Infoctecs) Department ", "Mathematics (AMES) Department", "Physics Department", "Biology Department"})
        cmbLogYear.Location = New Point(428, 7)
        cmbLogYear.Name = "cmbLogYear"
        cmbLogYear.Size = New Size(249, 32)
        cmbLogYear.TabIndex = 40
        cmbLogYear.Text = "--Select Year--"
        ' 
        ' cmbLogType
        ' 
        cmbLogType.BackColor = SystemColors.Info
        cmbLogType.Font = New Font("Garamond", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbLogType.ForeColor = Color.Red
        cmbLogType.FormattingEnabled = True
        cmbLogType.Items.AddRange(New Object() {"Admission Monitoring", "Admin Monitoring"})
        cmbLogType.Location = New Point(96, 7)
        cmbLogType.Name = "cmbLogType"
        cmbLogType.Size = New Size(265, 32)
        cmbLogType.TabIndex = 39
        cmbLogType.Text = "--Select Monitoring Type--"
        ' 
        ' btnLoadLogs
        ' 
        btnLoadLogs.BackColor = Color.MediumSeaGreen
        btnLoadLogs.FlatAppearance.BorderSize = 0
        btnLoadLogs.Font = New Font("Arial Rounded MT Bold", 12F)
        btnLoadLogs.ForeColor = Color.Transparent
        btnLoadLogs.Location = New Point(764, 3)
        btnLoadLogs.Name = "btnLoadLogs"
        btnLoadLogs.Size = New Size(240, 36)
        btnLoadLogs.TabIndex = 14
        btnLoadLogs.Text = "Load"
        btnLoadLogs.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(223, 84)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(620, 470)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' UC_Logs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "UC_Logs"
        Size = New Size(1021, 557)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        PanelWithDgv.ResumeLayout(False)
        PanelWithDgv2.ResumeLayout(False)
        CType(dvgAuditTrial, ComponentModel.ISupportInitialize).EndInit()
        Panel.ResumeLayout(False)
        Panel.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dvgFlowsLogs, ComponentModel.ISupportInitialize).EndInit()
        nothing1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelWithDgv As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dvgFlowsLogs As DataGridView
    Friend WithEvents nothing1 As Panel
    Friend WithEvents btnLoadLogs As Button
    Friend WithEvents cmbLogYear As ComboBox
    Friend WithEvents cmbLogType As ComboBox
    Friend WithEvents PanelWithDgv2 As Panel
    Friend WithEvents Panel As Panel
    Friend WithEvents btnSearch2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents dvgAuditTrial As DataGridView
    Friend WithEvents Testing1 As DataGridViewTextBoxColumn
    Friend WithEvents Testing2 As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Year As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblRecentActivity As Label

End Class
