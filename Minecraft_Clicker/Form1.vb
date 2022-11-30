
Imports System.Security.Policy

Public Class Form1
    Dim RedCurrency As Integer
    Dim l As Boolean = False
    Dim r As Boolean = False
    Dim u As Boolean = False
    Dim d As Boolean = False
    Dim s As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Upgrades.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        Buildings.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles RedDepot.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MoneyGenActive()

        If (w = True) Then
            pbHero.Top -= speed
        ElseIf (s = True) Then

            pbHero.Top += speed
        ElseIf (a = True) Then
            pbHero.Left -= speed
        ElseIf (d = True) Then
            pbHero.Left += speed
        End If
    End Sub
    Private Sub MoneyGenActive()
        If RedDepot.Bounds.IntersectsWith(Player.Bounds) Then
            RedCurrency += 1
            CurrencyRed.Text = RedCurrency
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles Player.Click

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.A Then
            l = True
        End If
        If e.KeyCode = Keys.D Then
            r = True
        End If
        If e.KeyCode = Keys.W Then
            u = True
        End If
        If e.KeyCode = Keys.S Then
            d = True
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.A Then
            l = False
        End If
        If e.KeyCode = Keys.D Then
            r = False
        End If
        If e.KeyCode = Keys.W Then
            u = False
        End If
        If e.KeyCode = Keys.S Then
            d = False
        End If
    End Sub

End Class
