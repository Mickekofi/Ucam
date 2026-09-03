'=================================================================
' This code snippet demonstrates how to create a fade-in effect for a Windows Forms application.
'=================================================================
' Place this at the top of your form class Or Create Your Own Timer Control with a Name like "fadeTimer" then foget about this code snippet.
Private fadeTimer As New Timer With {.Interval = 20}



Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.Opacity = 0
    fadeTimer.Start()
    AddHandler fadeTimer.Tick, AddressOf FadeIn
End Sub

Private Sub FadeIn(sender As Object, e As EventArgs)
    If Me.Opacity < 1 Then
        Me.Opacity += 0.05
    Else
        fadeTimer.Stop()
        RemoveHandler fadeTimer.Tick, AddressOf FadeIn
    End If
End Sub