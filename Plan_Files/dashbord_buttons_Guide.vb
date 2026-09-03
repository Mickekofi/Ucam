
       '===========================================================================================================
    'This Function is used to Initialize the Dashboard with Button Clicks and Hover Effects
    '===========================================================================================================
    Private buttonList As List(Of Button)
    Private activeButton As Button


    Private Sub InitializeDashboard(activeBtn As Button)
        ' Lazy-load the button list and wire events only once
        If buttonList Is Nothing Then

            'Just Update or Add Your Target Buttons Here Into the List
            buttonList = New List(Of Button) From {
            btnAdd, btnDelete, btnUpdate
        }

            ' Assign event handlers to each button
            For Each btn In buttonList
                AddHandler btn.Click, Sub(s, e)
                                          InitializeDashboard(CType(s, Button))
                                      End Sub
                AddHandler btn.MouseEnter, AddressOf Button_MouseEnter
                AddHandler btn.MouseLeave, AddressOf Button_MouseLeave
                AddHandler btn.MouseDown, AddressOf Button_MouseDown
            Next
        End If

        ' Set active button
        activeButton = activeBtn

        ' Style reset for all buttons
        For Each btn In buttonList
            With btn
                .BackColor = Color.White
                .ForeColor = Color.Red
                .FlatStyle = FlatStyle.Flat
                .FlatAppearance.BorderSize = 0
                .Cursor = Cursors.Hand
            End With
        Next

        ' Highlight selected
        With activeButton
            .BackColor = Color.Green
            .ForeColor = Color.White
            .FlatAppearance.BorderSize = 3
            .FlatAppearance.BorderColor = Color.White
        End With



    End Sub

    ' Hover effect
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        Dim btn = CType(sender, Button)
        If btn IsNot activeButton Then
            btn.BackColor = Color.SlateBlue
            btn.ForeColor = Color.WhiteSmoke
        End If
    End Sub

    ' Hover leave
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        Dim btn = CType(sender, Button)
        If btn IsNot activeButton Then

            btn.BackColor = Color.White
            btn.ForeColor = Color.Black
        End If
    End Sub

    ' Press visual
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs)
        Dim btn = CType(sender, Button)
        btn.BackColor = Color.Indigo
    End Sub
'End of Function...............................................................................................

'Now you can call this function in your form load or button click event like this:
'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'    InitializeDashboard(btnAdd) ' Pass the active button you want to highlight
'End Sub

'Also add the Function to your form's code file where you have defined the buttons... on click event

'===========================================================================================================
'This code is a part of a Visual Basic application that initializes a dashboard with buttons.   
'It sets up event handlers for button clicks, mouse enter, mouse leave, and mouse down events to provide
'visual feedback and interaction. The buttons are styled dynamically based on their state (active or inactive
') to enhance user experience. The active button is highlighted with a different color and border style,
'while other buttons change color on hover and press events. This approach allows for a clean and   
'responsive user interface, making it easy for users to navigate through the dashboard.
'===========================================================================================================