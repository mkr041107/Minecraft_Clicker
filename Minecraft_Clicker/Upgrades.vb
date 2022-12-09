Imports System.Windows

Public Class Upgrades
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
    Public FortBluePrice As Integer = 1
    Public FortRedPrice As Integer
    Public FortTealPrice As Integer
    Public FortWoodPrice As Integer
    Public FortCobblePrice As Integer
    Public FortCopperPrice As Integer
    Public FortIronPrice As Integer
    Public FortGoldPrice As Integer
    Public FortDiamondPrice As Integer
    Public FortEmeraldPrice As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub Upgrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BlueFortUpgradePrice.Text = "Price: " & FortBluePrice
    End Sub
    Private Sub UpgradeFortBlue_Click(sender As Object, e As EventArgs) Handles UpgradeFortBlue.Click
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
End Class
