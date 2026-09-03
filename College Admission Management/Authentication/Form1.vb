Public Class Form1

    'Array Collections of Quotes pop Ups on loading 
    Dim quotes() As String = {
        "Please Wait .",
        "Please Wait ..",
        "Building ......",
        "Please Wait ....",
        "Launching ......;",
        "Geting Ready ......",
        "University Admission System"
    }

    Dim quoteIndex As Integer = 0


    'Function to Circle a Shape with two Parameters (Control[Name], size)
    Public Sub CircleShape(ctrl As Control, circleness As Single)
        If circleness <= 0 Then Exit Sub

        Dim radius As Integer
        Dim diameter As Integer = Math.Min(ctrl.Width, ctrl.Height)

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
        path.AddArc(ctrl.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90)
        path.AddArc(ctrl.Width - (radius * 2), ctrl.Height - (radius * 2), radius * 2, radius * 2, 0, 90)
        path.AddArc(0, ctrl.Height - (radius * 2), radius * 2, radius * 2, 90, 90)
        path.CloseFigure()

        ctrl.Region = New Region(path)
    End Sub

    'Ended the Circle Function....................................................................................................



    'Main Form Load Event
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Change form bar name
        Me.Text = "College Admission Management System - Loading..."


        'Window State to Maximized
        ' Me.WindowState = FormWindowState.Maximized


        'Apply Circled hat picture
        CircleShape(PictureBox1, 300)


        '''LOADING THE GIF IMAGE FROM THE EMBEDDED RESOURCE
        ''' Step 1: Gets a handle on the current running app
        ''Dim asm = System.Reflection.Assembly.GetExecutingAssembly()
        ''' Step 2: Retrieves the embedded GIF file as a stream
        ''Dim stream = asm.GetManifestResourceStream("College_Admission_Management.noActivityGif.gif")
        ''' Then Step 3: Converts that stream into an image and loads it into a PictureBox
        ''PictureBox1.Image = Image.FromStream(stream)




        'Always Remember that the Speed or progress oft the ProgressBar is always Controlled by the Timer Control, Do it From the UI
        'Mentioned the [Name] ProgressBar and set to start 
        ProgressBar1.Value = 10

        'Assigning ProgressBar motion counts to Lable [Name] called lblPercentage for display progress in percent
        lblPercentage.Text = ProgressBar1.Value.ToString() & "%"
        lblQuote.Text = quotes(quoteIndex)

        Timer1.Start()
    End Sub

    'This Handles the Timer Control Effects on Both the ProgressBar and the Quotes 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Progress increment
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 1
            lblPercentage.Text = ProgressBar1.Value.ToString() & "%"

            ' Change quote every 10%
            If ProgressBar1.Value Mod 10 = 0 Then
                quoteIndex = (quoteIndex + 1) Mod quotes.Length
                lblQuote.Text = quotes(quoteIndex)
            End If

        Else
            Timer1.Stop()
            'Showing the Next Page
            Dim nextForm As New login()
            ' nextForm.WindowState = FormWindowState.Maximized ' or Maximized, as you prefer
            nextForm.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub gifBox_Click(sender As Object, e As EventArgs) Handles gifBox.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lblQuote_Click(sender As Object, e As EventArgs) Handles lblQuote.Click

    End Sub
End Class
