Public Class Buildings
    'Quantity For 1st Buildings = each building makes 1 or 2 currency per minute
    Dim GoldQuantity As Integer = 0
    Dim IronQuantity As Integer = 0
    Dim CopperQuantity As Integer = 0
    Dim DiamondQuantity As Integer = 0
    Dim EmeraldQuantity As Integer = 0
    Dim BlueQuantity As Integer = 0
    Dim RedQuantity As Integer = 0
    Dim TealQuantity As Integer = 0
    Dim WoodQuantity As Integer = 0
    Dim CobblestoneQuantity As Integer = 0
    'Prices For 1st Buildings
    Dim GoldPrice As Integer = 9
    Dim CopperPrice As Integer = 7
    Dim CobblestonePrice As Integer = 6
    Dim WoodPrice As Integer = 5
    Dim RedPrice As Integer = 3
    Dim EmeraldPrice As Integer = 11
    Dim IronPrice As Integer = 8
    Dim DiamondPrice As Integer = 10
    Dim TealPrice As Integer = 4
    Dim BluePrice As Integer = 2
    'Quantity For 2nd Buildings =  = each building makes 1 or 2 currency per minute
    Dim Gold2Quantity As Integer = 0
    Dim Iron2Quantity As Integer = 0
    Dim Copper2Quantity As Integer = 0
    Dim Diamond2Quantity As Integer = 0
    Dim Emerald2Quantity As Integer = 0
    Dim Blue2Quantity As Integer = 0
    Dim Red2Quantity As Integer = 0
    Dim Teal2Quantity As Integer = 0
    Dim Wood2Quantity As Integer = 0
    Dim Cobblestone2Quantity As Integer = 0
    'Price For 2nd Buildings
    Dim Gold2Price As Integer = 19
    Dim Copper2Price As Integer = 17
    Dim Cobblestone2Price As Integer = 16
    Dim Wood2Price As Integer = 15
    Dim Red2Price As Integer = 13
    Dim Emerald2Price As Integer = 21
    Dim Iron2Price As Integer = 18
    Dim Diamond2Price As Integer = 20
    Dim Teal2Price As Integer = 15
    Dim Blue2Price As Integer = 11
    'Var For Passive Income = makes the cps or currency per minute
    Public BlueS As Double = 0.0
    Public TealS As Double = 0.0
    Public RedS As Double = 0.0
    Public WoodS As Double = 0.0
    Public CobbleS As Double = 0.0
    Public CopperS As Double = 0.0
    Public IronS As Double = 0.0
    Public GoldS As Double = 0.0
    Public DiamondS As Double = 0.0
    Public EmeraldS As Double = 0.0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'to make the forms switch between eachother
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub Buildings_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub BuildingBlue2_Click(sender As Object, e As EventArgs) Handles BuildingBlue2.Click
        '1st building
        If Form1.BlueCurrency >= Blue2Price Then
            Form1.BlueCurrency -= Blue2Price
            Blue2Price *= 1.15
            BlueBuilding2Price.Text = "Price: " & Blue2Price
            Blue2Quantity += 1
            BlueBuilding2Quantity.Text = "Quantity: " & Blue2Quantity
            Form1.CurrencyBlue.Text = "Blue: " & Form1.BlueCurrency
            BlueS += 2
        End If
    End Sub

    Private Sub BuildingBlue1_Click(sender As Object, e As EventArgs) Handles BuildingBlue1.Click
        If Form1.BlueCurrency >= BluePrice Then
            Form1.BlueCurrency -= BluePrice
            BluePrice *= 1.15
            BuildingBlue1Price.Text = "Price: " & BluePrice
            BlueQuantity += 1
            BuildingBlue1Quantity.Text = "Quantity: " & BlueQuantity
            Form1.CurrencyBlue.Text = "Blue: " & Form1.BlueCurrency
            BlueS += 1
        End If
    End Sub

    Private Sub BuildingRed1_Click(sender As Object, e As EventArgs) Handles BuildingRed1.Click
        If Form1.RedCurrency >= RedPrice Then
            Form1.RedCurrency -= RedPrice
            RedPrice *= 1.15
            RedBuilding1Price.Text = "Price: " & RedPrice
            RedQuantity += 1
            RedBuilding1Quantity.Text = "Quantity: " & RedQuantity
            Form1.CurrencyRed.Text = "Red: " & Form1.RedCurrency
            RedS += 2
        End If
    End Sub

    Private Sub BuildingRed2_Click(sender As Object, e As EventArgs) Handles BuildingRed2.Click
        If Form1.RedCurrency >= Red2Price Then
            Form1.RedCurrency -= Red2Price
            Red2Price *= 1.15
            RedBuilding2Price.Text = "Price: " & Red2Price
            Red2Quantity += 1
            RedBuilding2Quantity.Text = "Quantity: " & Red2Quantity
            Form1.CurrencyRed.Text = "Red: " & Form1.RedCurrency
            RedS += 1
        End If
    End Sub

    Private Sub BuildingTeal1_Click(sender As Object, e As EventArgs) Handles BuildingTeal1.Click
        If Form1.TealCurrency >= TealPrice Then
            Form1.TealCurrency -= TealPrice
            TealPrice *= 1.15
            TealBuilding1Price.Text = "Price: " & TealPrice
            TealQuantity += 1
            TealBuilding1Quantity.Text = "Quantity: " & TealQuantity
            Form1.CurrencyTeal.Text = "Teal: " & Form1.TealCurrency
            TealS += 1
        End If
    End Sub

    Private Sub BuildingTeal2_Click(sender As Object, e As EventArgs) Handles BuildingTeal2.Click
        If Form1.TealCurrency >= Teal2Price Then
            Form1.TealCurrency -= Teal2Price
            Teal2Price *= 1.15
            TealBuilding2Price.Text = "Price: " & Teal2Price
            Teal2Quantity += 1
            TealBuilding2Quantity.Text = "Quantity: " & Teal2Quantity
            Form1.CurrencyTeal.Text = "Teal: " & Form1.TealCurrency
            TealS += 2
        End If
    End Sub

    Private Sub BuildingWood1_Click(sender As Object, e As EventArgs) Handles BuildingWood1.Click
        If Form1.WoodCurrency >= WoodPrice Then
            Form1.WoodCurrency -= WoodPrice
            WoodPrice *= 1.15
            WoodBuilding1Price.Text = "Price: " & WoodPrice
            WoodQuantity += 1
            WoodBuilding1Quantity.Text = "Quantity: " & WoodQuantity
            Form1.CurrencyWood.Text = "Wood: " & Form1.WoodCurrency
            WoodS += 2
        End If
    End Sub

    Private Sub BuildingWood2_Click(sender As Object, e As EventArgs) Handles BuildingWood2.Click
        If Form1.WoodCurrency >= Wood2Price Then
            Form1.WoodCurrency -= Wood2Price
            Wood2Price *= 1.15
            WoodBuilding2Price.Text = "Price: " & Wood2Price
            Wood2Quantity += 1
            WoodBuilding2Quantity.Text = "Quantity: " & Wood2Quantity
            Form1.CurrencyWood.Text = "Wood: " & Form1.WoodCurrency
            WoodS += 1
        End If
    End Sub

    Private Sub BuildingStone1_Click(sender As Object, e As EventArgs) Handles BuildingStone1.Click
        If Form1.CobbleCurrency >= CobblestonePrice Then
            Form1.CobbleCurrency -= CobblestonePrice
            CobblestonePrice *= 1.15
            CobblestoneBuilding1Price.Text = "Price: " & CobblestonePrice
            CobblestoneQuantity += 1
            CobblestoneBuilding1Quantity.Text = "Quantity: " & CobblestoneQuantity
            Form1.CurrencyCobble.Text = "Cobblestone: " & Form1.CobbleCurrency
            CobbleS += 1
        End If
    End Sub

    Private Sub BuildingStone2_Click(sender As Object, e As EventArgs) Handles BuildingStone2.Click
        If Form1.CobbleCurrency >= Cobblestone2Price Then
            Form1.CobbleCurrency -= Cobblestone2Price
            Cobblestone2Price *= 1.15
            CobblestoneBuilding2Price.Text = "Price: " & Cobblestone2Price
            Cobblestone2Quantity += 1
            CobblestoneBuilding2Quantity.Text = "Quantity: " & Cobblestone2Quantity
            Form1.CurrencyCobble.Text = "Cobblestone: " & Form1.CobbleCurrency
            CobbleS += 2
        End If
    End Sub

    Private Sub BuildingCopper1_Click(sender As Object, e As EventArgs) Handles BuildingCopper1.Click
        If Form1.CopperCurrency >= CopperPrice Then
            Form1.CopperCurrency -= CopperPrice
            CopperPrice *= 1.15
            CopperBuilding1Price.Text = "Price: " & CopperPrice
            CopperQuantity += 1
            CopperBuilding1Quantity.Text = "Quantity: " & CopperQuantity
            Form1.CurrencyCopper.Text = "Copper: " & Form1.CopperCurrency
            CopperS += 2
        End If

    End Sub

    Private Sub BuildingCopper2_Click(sender As Object, e As EventArgs) Handles BuildingCopper2.Click
        If Form1.CopperCurrency >= Copper2Price Then
            Form1.CopperCurrency -= Copper2Price
            Copper2Price *= 1.15
            CopperBuilding2Price.Text = "Price: " & Copper2Price
            Copper2Quantity += 1
            CopperBuilding2Quantity.Text = "Quantity: " & Copper2Quantity
            Form1.CurrencyCopper.Text = "Copper: " & Form1.CopperCurrency
            CopperS += 1
        End If
    End Sub

    Private Sub BuildingIron1_Click(sender As Object, e As EventArgs) Handles BuildingIron1.Click
        If Form1.IronCurrency >= IronPrice Then
            Form1.IronCurrency -= IronPrice
            IronPrice *= 1.15
            IronBuilding1Price.Text = "Price: " & IronPrice
            IronQuantity += 1
            IronBuilding1Quantity.Text = "Quantity: " & IronQuantity
            Form1.CurrencyIron.Text = "Iron: " & Form1.IronCurrency
            IronS += 1
        End If
    End Sub

    Private Sub BuildingIron2_Click(sender As Object, e As EventArgs) Handles BuildingIron2.Click
        If Form1.IronCurrency >= Iron2Price Then
            Form1.IronCurrency -= Iron2Price
            Iron2Price *= 1.15
            IronBuilding2Price.Text = "Price: " & Iron2Price
            Iron2Quantity += 1
            IronBuilding2Quantity.Text = "Quantity: " & Iron2Quantity
            Form1.CurrencyIron.Text = "Iron: " & Form1.IronCurrency
            IronS += 2
        End If
    End Sub

    Private Sub BuildingGold1_Click(sender As Object, e As EventArgs) Handles BuildingGold1.Click
        If Form1.GoldCurrency >= GoldPrice Then
            Form1.GoldCurrency -= GoldPrice
            GoldPrice *= 1.15
            GoldBuilding1Price.Text = "Price: " & GoldPrice
            GoldQuantity += 1
            GoldBuilding1Quantity.Text = "Quantity: " & GoldQuantity
            Form1.CurrencyGold.Text = "Gold: " & Form1.GoldCurrency
            GoldS += 2
        End If
    End Sub

    Private Sub BuildingGold2_Click(sender As Object, e As EventArgs) Handles BuildingGold2.Click
        If Form1.GoldCurrency >= Gold2Price Then
            Form1.GoldCurrency -= Gold2Price
            Gold2Price *= 1.15
            GoldBuilding2Price.Text = "Price: " & Gold2Price
            Gold2Quantity += 1
            GoldBuilding2Quantity.Text = "Quantity: " & Gold2Quantity
            Form1.CurrencyGold.Text = "Gold: " & Form1.GoldCurrency
            GoldS += 1
        End If
    End Sub

    Private Sub BuildingDiamond1_Click(sender As Object, e As EventArgs) Handles BuildingDiamond1.Click
        If Form1.DiamondCurrency >= DiamondPrice Then
            Form1.DiamondCurrency -= DiamondPrice
            DiamondPrice *= 1.15
            DiamondBuilding1Price.Text = "Price: " & DiamondPrice
            DiamondQuantity += 1
            DiamondBuilding1Quantity.Text = "Quantity: " & DiamondQuantity
            Form1.CurrencyDiamond.Text = "Diamond: " & Form1.DiamondCurrency

            DiamondS += 1
        End If
    End Sub

    Private Sub BuildingDiamond2_Click(sender As Object, e As EventArgs) Handles BuildingDiamond2.Click
        If Form1.DiamondCurrency >= Diamond2Price Then
            Form1.DiamondCurrency -= Diamond2Price
            Diamond2Price *= 1.15
            DiamondBuilding2Price.Text = "Price: " & Diamond2Price
            Diamond2Quantity += 1
            DiamondBuilding2Quantity.Text = "Quantity: " & Diamond2Quantity
            Form1.CurrencyDiamond.Text = "Diamond: " & Form1.DiamondCurrency
            DiamondS += 2
        End If
    End Sub

    Private Sub BuildingEmerald1_Click(sender As Object, e As EventArgs) Handles BuildingEmerald1.Click
        If Form1.EmeraldCurrency >= EmeraldPrice Then
            Form1.EmeraldCurrency -= EmeraldPrice
            EmeraldPrice *= 1.15
            EmeraldBuilding1Price.Text = "Price: " & EmeraldPrice
            EmeraldQuantity += 1
            EmeraldBuilding1Quantity.Text = "Quantity: " & EmeraldQuantity
            Form1.CurrencyEmerald.Text = "Emerald: " & Form1.EmeraldCurrency
            EmeraldS += 2
        End If
    End Sub

    Private Sub BuildingEmerald2_Click(sender As Object, e As EventArgs) Handles BuildingEmerald2.Click
        If Form1.EmeraldCurrency >= Emerald2Price Then
            Form1.EmeraldCurrency -= Emerald2Price
            Emerald2Price *= 1.15
            EmeraldBuilding2Price.Text = "Price: " & Emerald2Price
            Emerald2Quantity += 1
            EmeraldBuilding2Quantity.Text = "Quantity: " & Emerald2Quantity
            Form1.CurrencyEmerald.Text = "Emerald: " & Form1.EmeraldCurrency
            EmeraldS += 1
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'timer for updating all the currency labels so it generates passive income
        Form1.BlueCurrency += BlueS
        Form1.CurrencyBlue.Text = "Blue: " & Form1.BlueCurrency

        Form1.RedCurrency += RedS
        Form1.CurrencyRed.Text = "Red: " & Form1.RedCurrency

        Form1.TealCurrency += TealS
        Form1.CurrencyTeal.Text = "Teal: " & Form1.TealCurrency

        Form1.WoodCurrency += WoodS
        Form1.CurrencyWood.Text = "Wood: " & Form1.WoodCurrency

        Form1.CobbleCurrency += CobbleS
        Form1.CurrencyCobble.Text = "Cobblestone: " & Form1.CobbleCurrency

        Form1.IronCurrency += IronS
        Form1.CurrencyIron.Text = "Iron: " & Form1.IronCurrency

        Form1.GoldCurrency += GoldS
        Form1.CurrencyGold.Text = "Gold: " & Form1.GoldCurrency

        Form1.CopperCurrency += CopperS
        Form1.CurrencyCopper.Text = "Copper: " & Form1.CopperCurrency

        Form1.DiamondCurrency += DiamondS
        Form1.CurrencyDiamond.Text = "Diamond: " & Form1.DiamondCurrency

        Form1.EmeraldCurrency += EmeraldS
        Form1.CurrencyEmerald.Text = "Emerald: " & Form1.EmeraldCurrency

    End Sub
End Class