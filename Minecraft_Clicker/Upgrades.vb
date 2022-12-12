Imports System.Windows

Public Class Upgrades
    'vars for fortune = 2x of the color upppgrade you buy
    Public FortBlue As Integer
    Public FortRed As Integer
    Public FortTeal As Integer
    Public FortWood As Integer
    Public FortCobble As Integer
    Public FortCopper As Integer
    Public FortIron As Integer
    Public FortGold As Integer
    Public FortDiamond As Integer
    Public FortEmerald As Integer
    'price for fortune upgrades
    Public FortBluePrice As Integer = 100
    Public FortRedPrice As Integer = 100
    Public FortTealPrice As Integer = 100
    Public FortWoodPrice As Integer = 100
    Public FortCobblePrice As Integer = 100
    Public FortCopperPrice As Integer = 100
    Public FortIronPrice As Integer = 100
    Public FortGoldPrice As Integer = 100
    Public FortDiamondPrice As Integer = 100
    Public FortEmeraldPrice As Integer = 100
    'speed upgrade makes speed increase by 1
    Public SpeeedUpgradeOne As Integer
    Public SpeeedUpgradeTwo As Integer
    Public SpeeedUpgradeThree As Integer
    Public SpeeedUgradeFour As Integer
    Public SpeeedUpgradeFive As Integer
    'prices for speed upgrades
    Public SpeeedUpgradeOnePrice As Integer = 100
    Public SpeeedUpgradeTwoPrice As Integer = 200
    Public SpeeedUpgradeThreePrice As Integer = 300
    Public SpeeedUgradeFourPrice As Integer = 400
    Public SpeeedUpgradeFivePrice As Integer = 500
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'to make the forms switch between eachother
        Me.Visible = False
        Form1.Visible = True
    End Sub
    Private Sub UpgradeFortBlue_Click(sender As Object, e As EventArgs) Handles UpgradeFortBlue.Click
        'Fortune For Blue = 2x When run into blue
        If Form1.BlueCurrency >= FortBluePrice Then
            FortBlue += 1
            Form1.BlueCurrency -= FortBluePrice
            UpgradeFortBlue.Enabled = False
        End If

    End Sub

    Private Sub UpgradeFortRed_Click(sender As Object, e As EventArgs) Handles UpgradeFortRed.Click
        If Form1.RedCurrency >= FortRedPrice Then
            FortRed += 1
            Form1.RedCurrency -= FortRedPrice
            UpgradeFortRed.Enabled = False
        End If
    End Sub

    Private Sub UpgradeFortTeal_Click(sender As Object, e As EventArgs) Handles UpgradeFortTeal.Click
        If Form1.TealCurrency >= FortTealPrice Then
            FortTeal += 1
            Form1.TealCurrency -= FortTealPrice
            UpgradeFortTeal.Enabled = False
        End If
    End Sub

    Private Sub UpgradeFortWood_Click(sender As Object, e As EventArgs) Handles UpgradeFortWood.Click
        If Form1.WoodCurrency >= FortWoodPrice Then
            FortWood += 1
            Form1.WoodCurrency -= FortWoodPrice
            UpgradeFortWood.Enabled = False
        End If
    End Sub

    Private Sub UpgradeFortCobble_Click(sender As Object, e As EventArgs) Handles UpgradeFortCobble.Click
        If Form1.CobbleCurrency >= FortCobblePrice Then
            FortCobble += 1
            Form1.CobbleCurrency -= FortCobblePrice
            UpgradeFortCobble.Enabled = False
        End If
    End Sub

    Private Sub UpgradeFortCopper_Click(sender As Object, e As EventArgs) Handles UpgradeFortCopper.Click
        If Form1.CopperCurrency >= FortCopperPrice Then
            FortCopper += 1
            Form1.RedCurrency -= FortCopperPrice
            UpgradeFortCopper.Enabled = False
        End If
    End Sub

    Private Sub UpgradeFortIron_Click(sender As Object, e As EventArgs) Handles UpgradeFortIron.Click
        If Form1.IronCurrency >= FortIronPrice Then
            FortIron += 1
            Form1.IronCurrency -= FortIronPrice
            UpgradeFortIron.Enabled = False
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles UpgradeFortGold.Click
        If Form1.GoldCurrency >= FortGoldPrice Then
            FortGold += 1
            Form1.GoldCurrency -= FortGoldPrice
            UpgradeFortGold.Enabled = False
        End If
    End Sub

    Private Sub UpgradeFortDiamond_Click(sender As Object, e As EventArgs) Handles UpgradeFortDiamond.Click
        If Form1.DiamondCurrency >= FortDiamondPrice Then
            FortDiamond += 1
            Form1.DiamondCurrency -= FortDiamondPrice
            UpgradeFortDiamond.Enabled = False
        End If
    End Sub

    Private Sub UpgradeFortEmerald_Click(sender As Object, e As EventArgs) Handles UpgradeFortEmerald.Click
        If Form1.EmeraldCurrency >= FortEmeraldPrice Then
            FortEmerald += 1
            Form1.EmeraldCurrency -= FortEmeraldPrice
            UpgradeFortEmerald.Enabled = False
        End If
    End Sub

    Private Sub SpeedUpgradeOne_Click(sender As Object, e As EventArgs) Handles SpeedUpgradeOne.Click
        If Form1.DiamondCurrency >= SpeeedUpgradeOnePrice Then
            Form1.s += 1
            Form1.DiamondCurrency -= SpeeedUpgradeOnePrice
            SpeedUpgradeOne.Enabled = False
        End If
    End Sub

    Private Sub SpeedUpgradeTwo_Click(sender As Object, e As EventArgs) Handles SpeedUpgradeTwo.Click
        If Form1.EmeraldCurrency >= SpeeedUpgradeTwoPrice Then
            Form1.s += 1
            Form1.EmeraldCurrency -= SpeeedUpgradeTwoPrice
            SpeedUpgradeTwo.Enabled = False
        End If
    End Sub

    Private Sub SpeedUpgradeFour_Click(sender As Object, e As EventArgs) Handles SpeedUpgradeFour.Click
        If Form1.GoldCurrency >= SpeeedUpgradeThreePrice Then
            Form1.s += 1
            Form1.GoldCurrency -= SpeeedUpgradeThreePrice
            SpeedUpgradeThree.Enabled = False
        End If
    End Sub

    Private Sub SpeedUpgradeFive_Click(sender As Object, e As EventArgs) Handles SpeedUpgradeFive.Click
        If Form1.TealCurrency >= SpeeedUgradeFourPrice Then
            Form1.s += 1
            Form1.TealCurrency -= SpeeedUgradeFourPrice
            SpeedUpgradeFour.Enabled = False
        End If
    End Sub

    Private Sub SpeedUpgradeThree_Click(sender As Object, e As EventArgs) Handles SpeedUpgradeThree.Click
        If Form1.RedCurrency >= SpeeedUpgradeFivePrice Then
            Form1.s += 1
            Form1.RedCurrency -= SpeeedUpgradeFivePrice
            SpeedUpgradeFive.Enabled = False
        End If
    End Sub
End Class
