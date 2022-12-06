Public Class Buildings
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
    Dim GoldPrice As Integer = 1
    Dim CopperPrice As Integer = 1
    Dim CobblestonePrice As Integer = 1
    Dim WoodPrice As Integer = 1
    Dim RedPrice As Integer = 40
    Dim EmeraldPrice As Integer = 1
    Dim IronPrice As Integer = 1
    Dim DiamondPrice As Integer = 1
    Dim TealPrice As Integer = 1
    Dim BluePrice As Integer = 1
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
    Dim Gold2Price As Integer = 1
    Dim Copper2Price As Integer = 1
    Dim Cobblestone2Price As Integer = 1
    Dim Wood2Price As Integer = 1
    Dim Red2Price As Integer = 1
    Dim Emerald2Price As Integer = 1
    Dim Iron2Price As Integer = 1
    Dim Diamond2Price As Integer = 1
    Dim Teal2Price As Integer = 1
    Dim Blue2Price As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub Buildings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildingBlue1Price.Text = "Price: " & BluePrice
        BlueBuilding2Price.Text = "Price: " & Blue2Price
        RedBuilding1Price.Text = "Price: " & RedPrice
        RedBuilding2Price.Text = "Price: " & Red2Price
        TealBuilding1Price.Text = "Price: " & TealPrice
        CobblestoneBuilding1Price.Text = "Price: " & CobblestonePrice
        DiamondBuilding1Price.Text = "Price: " & DiamondPrice '
        CopperBuilding1Price.Text = "Price: " & CopperPrice
        IronBuilding1Price.Text = "Price: " & IronPrice
        GoldBuilding1Price.Text = "Price: " & GoldPrice
        EmeraldBuilding1Price.Text = "Price: " & EmeraldPrice
        WoodBuilding1Price.Text = "Price: " & WoodPrice
        WoodBuilding2Price.Text = "Price: " & Wood2Price
        CobblestoneBuilding2Price.Text = "Price: " & Cobblestone2Price
        GoldBuilding2Price.Text = "Price: " & Gold2Price
        DiamondBuilding2Price.Text = "Price: " & Diamond2Price
        CopperBuilding2Price.Text = "Price: " & Copper2Price
        IronBuilding2Price.Text = "Price: " & Iron2Price
        TealBuilding2Price.Text = "Price: " & Teal2Price
        EmeraldBuilding2Price.Text = "Price: " & Emerald2Price

    End Sub

    Private Sub BuildingBlue1Quantity_Click(sender As Object, e As EventArgs) Handles BuildingBlue1Quantity.Click

    End Sub

    Private Sub IronBuilding2Quantity_Click(sender As Object, e As EventArgs) Handles IronBuilding2Quantity.Click

    End Sub

    Private Sub CobblestoneBuilding1Price_Click(sender As Object, e As EventArgs) Handles CobblestoneBuilding1Price.Click

    End Sub

    Private Sub CopperBuilding1Price_Click(sender As Object, e As EventArgs) Handles CopperBuilding1Price.Click

    End Sub

    Private Sub BuildingBlue2_Click(sender As Object, e As EventArgs) Handles BuildingBlue2.Click
        '1st building
        If Form1.BlueCurrency >= Blue2Price Then
            Form1.BlueCurrency -= Blue2Price
            Blue2Price *= 1.15
            BlueBuilding2Price.Text = "Cost: " & Blue2Price
            Blue2Quantity += 1
            BlueBuilding2Quantity.Text = "Quantity: " & Blue2Quantity
            Form1.CurrencyBlue.Text = "Blue: " & Form1.BlueCurrency
        End If
    End Sub
End Class