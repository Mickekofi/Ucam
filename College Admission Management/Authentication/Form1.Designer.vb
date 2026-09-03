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
        components = New ComponentModel.Container()
        Timer1 = New Timer(components)
        Panel1 = New Panel()
        lblQuote = New Label()
        lblPercentage = New Label()
        ProgressBar1 = New ProgressBar()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        gifBox = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(gifBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(lblQuote)
        Panel1.Controls.Add(lblPercentage)
        Panel1.Controls.Add(ProgressBar1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(gifBox)
        Panel1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(3))
        Panel1.Location = New Point(9, -33)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1470, 985)
        Panel1.TabIndex = 1
        ' 
        ' lblQuote
        ' 
        lblQuote.AutoSize = True
        lblQuote.Font = New Font("Bahnschrift SemiCondensed", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblQuote.ForeColor = Color.Snow
        lblQuote.Location = New Point(630, 691)
        lblQuote.Name = "lblQuote"
        lblQuote.Size = New Size(293, 30)
        lblQuote.TabIndex = 5
        lblQuote.Text = "UEW LOCAL EDITION 1.0 BETA"
        ' 
        ' lblPercentage
        ' 
        lblPercentage.AutoSize = True
        lblPercentage.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(3))
        lblPercentage.ForeColor = Color.Snow
        lblPercentage.Location = New Point(1017, 749)
        lblPercentage.Name = "lblPercentage"
        lblPercentage.Size = New Size(51, 35)
        lblPercentage.TabIndex = 4
        lblPercentage.Text = "0%"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.ForeColor = Color.Red
        ProgressBar1.Location = New Point(406, 759)
        ProgressBar1.Margin = New Padding(3, 4, 3, 4)
        ProgressBar1.Minimum = 10
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(662, 13)
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.TabIndex = 3
        ProgressBar1.Value = 10
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.greenhat
        PictureBox1.Location = New Point(630, 158)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(305, 336)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.CausesValidation = False
        Label1.Font = New Font("Bahnschrift Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(83, 600)
        Label1.Name = "Label1"
        Label1.Size = New Size(1426, 91)
        Label1.TabIndex = 1
        Label1.Text = "University/College Admission Management System"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' gifBox
        ' 
        gifBox.BackColor = Color.Transparent
        gifBox.Image = My.Resources.Resources.useshape2
        gifBox.Location = New Point(290, 57)
        gifBox.Margin = New Padding(3, 4, 3, 4)
        gifBox.Name = "gifBox"
        gifBox.Size = New Size(893, 550)
        gifBox.SizeMode = PictureBoxSizeMode.StretchImage
        gifBox.TabIndex = 0
        gifBox.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1481, 781)
        ControlBox = False
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(gifBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblQuote As Label
    Friend WithEvents lblPercentage As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gifBox As PictureBox

End Class
