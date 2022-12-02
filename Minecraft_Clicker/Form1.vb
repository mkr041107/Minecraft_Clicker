
Imports System.Security.Policy

Public Class Form1
    Dim RedCurrency As Integer
    Dim TealCurrency As Integer
    Dim BlueCurrency As Integer
    Dim WoodCurrency As Integer
    Dim CobbleCurrency As Integer
    Dim IronCurrency As Integer
    Dim CopperCurrency As Integer
    Dim GoldCurrency As Integer
    Dim DiamondCurrency As Integer
    Dim EmeraldCurrency As Integer
    Dim l As Boolean = False
    Dim r As Boolean = False
    Dim u As Boolean = False
    Dim d As Boolean = False
    Dim s As Integer = 5

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
        If (u = True) Then
            Player.Top -= s
        ElseIf (d = True) Then

            Player.Top += s
        ElseIf (l = True) Then
            Player.Left -= s
        ElseIf (r = True) Then
            Player.Left += s
        End If
    End Sub
    Private Sub MoneyGenActive()
        If RedDepot.Bounds.IntersectsWith(Player.Bounds) Then
            RedCurrency += 1
            CurrencyRed.Text = "Red: " & RedCurrency
            Player.Location = New Point(50, 450)
        End If
        If BlueDepot.Bounds.IntersectsWith(Player.Bounds) Then
            BlueCurrency += 1
            CurrencyBlue.Text = "Blue: " & BlueCurrency
            Player.Location = New Point(300, 450)
        End If
        If TealDepot.Bounds.IntersectsWith(Player.Bounds) Then
            TealCurrency += 1
            CurrencyTeal.Text = "Teal: " & TealCurrency
            Player.Location = New Point(150, 450)
        End If
        If WoodDepot.Bounds.IntersectsWith(Player.Bounds) Then
            WoodCurrency += 1
            CurrencyWood.Text = "Wood: " & WoodCurrency
            Player.Location = New Point(400, 450)
        End If
        If CobbleDepot.Bounds.IntersectsWith(Player.Bounds) Then
            CobbleCurrency += 1
            CurrencyCobble.Text = "Cobble: " & CobbleCurrency
            Player.Location = New Point(500, 450)
        End If
        If CopperDepot.Bounds.IntersectsWith(Player.Bounds) Then
            CopperCurrency += 1
            CurrencyCopper.Text = "Copper: " & CopperCurrency
            Player.Location = New Point(150, 450)
        End If
        If IronDepot.Bounds.IntersectsWith(Player.Bounds) Then
            IronCurrency += 1
            CurrencyIron.Text = "Iron: " & IronCurrency
            Player.Location = New Point(150, 450)
        End If
        If GoldDepot.Bounds.IntersectsWith(Player.Bounds) Then
            GoldCurrency += 1
            CurrencyGold.Text = "Gold: " & GoldCurrency
            Player.Location = New Point(150, 450)
        End If
        If TealDepot.Bounds.IntersectsWith(Player.Bounds) Then
            TealCurrency += 1
            CurrencyTeal.Text = "Teal: " & TealCurrency
            Player.Location = New Point(150, 450)
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
