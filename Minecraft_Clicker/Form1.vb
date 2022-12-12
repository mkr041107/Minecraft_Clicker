

Public Class Form1
    Public RedCurrency As Double
    Public TealCurrency As Double
    Public BlueCurrency As Double
    Public WoodCurrency As Double
    Public CobbleCurrency As Double
    Public IronCurrency As Double
    Public CopperCurrency As Double
    Public GoldCurrency As Double
    Public DiamondCurrency As Double
    Public EmeraldCurrency As Double
    Dim l As Boolean = False
    Dim r As Boolean = False
    Dim u As Boolean = False
    Dim d As Boolean = False
    Public s As Integer = 2
    Dim px, py As Integer
    Dim y As Boolean



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'to make the forms switch between eachother
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
        'teleports player back
        px = Player.Location.X
        py = Player.Location.Y
        'controls player movement
        If (u = True) Then
            Player.Top -= s
        ElseIf (d = True) Then

            Player.Top += s
        ElseIf (l = True) Then
            Player.Left -= s
        ElseIf (r = True) Then
            Player.Left += s
        End If
        'limits player movement to inside the form
        If (Player.Location.Y > Me.ClientSize.Height - Player.Height) Then
            Player.Location = New Point(px, py)
        End If
        If (Player.Location.X > Me.ClientSize.Width - Player.Width) Then
            Player.Location = New Point(px, py)
        End If
        If (Player.Location.X < 0) Then
            Player.Location = New Point(px, py)
        End If
        If Player.Bounds.IntersectsWith(TopStopper.Bounds) Then
            Player.Location = New Point(px, py)
        End If
        'cheat code
        If y = True Then
            BlueCurrency += 100
            RedCurrency += 100
            TealCurrency += 100
            WoodCurrency += 100
            CobbleCurrency += 100
            CopperCurrency += 100
            IronCurrency += 100
            GoldCurrency += 100
            DiamondCurrency += 100
            EmeraldCurrency += 100
        End If
    End Sub
    Private Sub MoneyGenActive()
        'the code that generates the money by coliding with the items
        If RedDepot.Bounds.IntersectsWith(Player.Bounds) Then
            RedCurrency += 1

            Player.Location = New Point(50, 450)
            If Upgrades.FortRed = 1 Then
                RedCurrency += 1
            End If
            CurrencyRed.Text = "Red: " & RedCurrency
        End If
        If BlueDepot.Bounds.IntersectsWith(Player.Bounds) Then
            BlueCurrency += 1

            Player.Location = New Point(300, 450)
            If Upgrades.FortBlue = 1 Then
                BlueCurrency += 1
            End If
            CurrencyBlue.Text = "Blue: " & BlueCurrency
        End If
        If TealDepot.Bounds.IntersectsWith(Player.Bounds) Then
            TealCurrency += 1

            Player.Location = New Point(150, 450)
            If Upgrades.FortTeal = 1 Then
                TealCurrency += 1
            End If
            CurrencyTeal.Text = "Teal: " & TealCurrency
        End If
        If WoodDepot.Bounds.IntersectsWith(Player.Bounds) Then
            WoodCurrency += 1

            Player.Location = New Point(450, 450)
            If Upgrades.FortWood = 1 Then
                WoodCurrency += 1
            End If
            CurrencyWood.Text = "Wood: " & WoodCurrency
        End If
        If CobbleDepot.Bounds.IntersectsWith(Player.Bounds) Then
            CobbleCurrency += 1

            Player.Location = New Point(550, 450)
            If Upgrades.FortCobble = 1 Then
                CobbleCurrency += 1
            End If
            CurrencyCobble.Text = "Cobble: " & CobbleCurrency
        End If
        If CopperDepot.Bounds.IntersectsWith(Player.Bounds) Then
            CopperCurrency += 1

            Player.Location = New Point(700, 450)
            If Upgrades.FortCopper = 1 Then
                CopperCurrency += 1
            End If
            CurrencyCopper.Text = "Copper: " & CopperCurrency
        End If
        If IronDepot.Bounds.IntersectsWith(Player.Bounds) Then
            IronCurrency += 1

            Player.Location = New Point(850, 450)
            If Upgrades.FortIron = 1 Then
                IronCurrency += 1
            End If
            CurrencyIron.Text = "Iron: " & IronCurrency
        End If
        If GoldDepot.Bounds.IntersectsWith(Player.Bounds) Then
            GoldCurrency += 1

            Player.Location = New Point(1000, 450)
            If Upgrades.FortGold = 1 Then
                GoldCurrency += 1
            End If
            CurrencyGold.Text = "Gold: " & GoldCurrency
        End If
        If DiamondDepot.Bounds.IntersectsWith(Player.Bounds) Then
            DiamondCurrency += 1

            Player.Location = New Point(1100, 450)
            If Upgrades.FortDiamond = 1 Then
                DiamondCurrency += 1
            End If
            CurrencyDiamond.Text = "Diamond: " & DiamondCurrency
        End If
        If EmeraldDepot.Bounds.IntersectsWith(Player.Bounds) Then
            EmeraldCurrency += 1

            Player.Location = New Point(1250, 450)
            If Upgrades.FortEmerald = 1 Then
                EmeraldCurrency += 1

            End If
            CurrencyEmerald.Text = "Emerald: " & EmeraldCurrency
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles Player.Click

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'detecting the keystrokes
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
        If e.KeyCode = Keys.F1 Then
            y = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'starts the building timer for cheat button works
        Buildings.Timer1.Start()
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        'detecting the keystrokes
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
        If e.KeyCode = Keys.F1 Then
            y = false
        End If
    End Sub

End Class
