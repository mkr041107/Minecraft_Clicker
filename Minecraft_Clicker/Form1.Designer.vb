<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CurrencyRed = New System.Windows.Forms.Label()
        Me.CurrencyTeal = New System.Windows.Forms.Label()
        Me.CurrencyBlue = New System.Windows.Forms.Label()
        Me.CurrencyWood = New System.Windows.Forms.Label()
        Me.CurrencyCobble = New System.Windows.Forms.Label()
        Me.CurrencyCopper = New System.Windows.Forms.Label()
        Me.CurrencyIron = New System.Windows.Forms.Label()
        Me.CurrencyGold = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.GoldDepot = New System.Windows.Forms.PictureBox()
        Me.IronDepot = New System.Windows.Forms.PictureBox()
        Me.CopperDepot = New System.Windows.Forms.PictureBox()
        Me.CobbleDepot = New System.Windows.Forms.PictureBox()
        Me.WoodDepot = New System.Windows.Forms.PictureBox()
        Me.BlueDepot = New System.Windows.Forms.PictureBox()
        Me.TealDepot = New System.Windows.Forms.PictureBox()
        Me.RedDepot = New System.Windows.Forms.PictureBox()
        Me.DiamondDepot = New System.Windows.Forms.PictureBox()
        Me.EmeraldDepot = New System.Windows.Forms.PictureBox()
        Me.CurrencyDiamond = New System.Windows.Forms.Label()
        Me.CurrencyEmerald = New System.Windows.Forms.Label()
        Me.TopStopper = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GoldDepot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IronDepot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CopperDepot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CobbleDepot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WoodDepot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueDepot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TealDepot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RedDepot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiamondDepot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmeraldDepot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopStopper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1318, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Upgrades"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1318, 204)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Buidlings"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CurrencyRed
        '
        Me.CurrencyRed.AutoSize = True
        Me.CurrencyRed.Location = New System.Drawing.Point(55, 23)
        Me.CurrencyRed.Name = "CurrencyRed"
        Me.CurrencyRed.Size = New System.Drawing.Size(39, 13)
        Me.CurrencyRed.TabIndex = 10
        Me.CurrencyRed.Text = "Red: 0"
        '
        'CurrencyTeal
        '
        Me.CurrencyTeal.AutoSize = True
        Me.CurrencyTeal.Location = New System.Drawing.Point(179, 23)
        Me.CurrencyTeal.Name = "CurrencyTeal"
        Me.CurrencyTeal.Size = New System.Drawing.Size(40, 13)
        Me.CurrencyTeal.TabIndex = 11
        Me.CurrencyTeal.Text = "Teal: 0"
        '
        'CurrencyBlue
        '
        Me.CurrencyBlue.AutoSize = True
        Me.CurrencyBlue.Location = New System.Drawing.Point(327, 22)
        Me.CurrencyBlue.Name = "CurrencyBlue"
        Me.CurrencyBlue.Size = New System.Drawing.Size(40, 13)
        Me.CurrencyBlue.TabIndex = 12
        Me.CurrencyBlue.Text = "Blue: 0"
        '
        'CurrencyWood
        '
        Me.CurrencyWood.AutoSize = True
        Me.CurrencyWood.Location = New System.Drawing.Point(465, 23)
        Me.CurrencyWood.Name = "CurrencyWood"
        Me.CurrencyWood.Size = New System.Drawing.Size(48, 13)
        Me.CurrencyWood.TabIndex = 13
        Me.CurrencyWood.Text = "Wood: 0"
        '
        'CurrencyCobble
        '
        Me.CurrencyCobble.AutoSize = True
        Me.CurrencyCobble.Location = New System.Drawing.Point(601, 23)
        Me.CurrencyCobble.Name = "CurrencyCobble"
        Me.CurrencyCobble.Size = New System.Drawing.Size(52, 13)
        Me.CurrencyCobble.TabIndex = 14
        Me.CurrencyCobble.Text = "Cobble: 0"
        '
        'CurrencyCopper
        '
        Me.CurrencyCopper.AutoSize = True
        Me.CurrencyCopper.Location = New System.Drawing.Point(728, 22)
        Me.CurrencyCopper.Name = "CurrencyCopper"
        Me.CurrencyCopper.Size = New System.Drawing.Size(53, 13)
        Me.CurrencyCopper.TabIndex = 15
        Me.CurrencyCopper.Text = "Copper: 0"
        '
        'CurrencyIron
        '
        Me.CurrencyIron.AutoSize = True
        Me.CurrencyIron.Location = New System.Drawing.Point(841, 22)
        Me.CurrencyIron.Name = "CurrencyIron"
        Me.CurrencyIron.Size = New System.Drawing.Size(37, 13)
        Me.CurrencyIron.TabIndex = 16
        Me.CurrencyIron.Text = "Iron: 0"
        '
        'CurrencyGold
        '
        Me.CurrencyGold.AutoSize = True
        Me.CurrencyGold.Location = New System.Drawing.Point(978, 22)
        Me.CurrencyGold.Name = "CurrencyGold"
        Me.CurrencyGold.Size = New System.Drawing.Size(41, 13)
        Me.CurrencyGold.TabIndex = 17
        Me.CurrencyGold.Text = "Gold: 0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Player
        '
        Me.Player.Image = Global.Minecraft_Clicker.My.Resources.Resources.SsundeePlayer
        Me.Player.Location = New System.Drawing.Point(42, 134)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(41, 79)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Player.TabIndex = 18
        Me.Player.TabStop = False
        '
        'GoldDepot
        '
        Me.GoldDepot.Image = Global.Minecraft_Clicker.My.Resources.Resources.th_1898358042
        Me.GoldDepot.Location = New System.Drawing.Point(950, 60)
        Me.GoldDepot.Name = "GoldDepot"
        Me.GoldDepot.Size = New System.Drawing.Size(100, 50)
        Me.GoldDepot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GoldDepot.TabIndex = 9
        Me.GoldDepot.TabStop = False
        '
        'IronDepot
        '
        Me.IronDepot.Image = Global.Minecraft_Clicker.My.Resources.Resources.latest_3336829218
        Me.IronDepot.Location = New System.Drawing.Point(827, 60)
        Me.IronDepot.Name = "IronDepot"
        Me.IronDepot.Size = New System.Drawing.Size(100, 50)
        Me.IronDepot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IronDepot.TabIndex = 8
        Me.IronDepot.TabStop = False
        '
        'CopperDepot
        '
        Me.CopperDepot.Image = Global.Minecraft_Clicker.My.Resources.Resources.th_4270698680
        Me.CopperDepot.Location = New System.Drawing.Point(700, 60)
        Me.CopperDepot.Name = "CopperDepot"
        Me.CopperDepot.Size = New System.Drawing.Size(100, 50)
        Me.CopperDepot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CopperDepot.TabIndex = 7
        Me.CopperDepot.TabStop = False
        '
        'CobbleDepot
        '
        Me.CobbleDepot.Image = Global.Minecraft_Clicker.My.Resources.Resources.Cobblestone_1478720647__1_
        Me.CobbleDepot.Location = New System.Drawing.Point(570, 60)
        Me.CobbleDepot.Name = "CobbleDepot"
        Me.CobbleDepot.Size = New System.Drawing.Size(100, 50)
        Me.CobbleDepot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CobbleDepot.TabIndex = 6
        Me.CobbleDepot.TabStop = False
        '
        'WoodDepot
        '
        Me.WoodDepot.Image = Global.Minecraft_Clicker.My.Resources.Resources.th_3617487180
        Me.WoodDepot.Location = New System.Drawing.Point(436, 60)
        Me.WoodDepot.Name = "WoodDepot"
        Me.WoodDepot.Size = New System.Drawing.Size(100, 50)
        Me.WoodDepot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.WoodDepot.TabIndex = 5
        Me.WoodDepot.TabStop = False
        '
        'BlueDepot
        '
        Me.BlueDepot.Image = Global.Minecraft_Clicker.My.Resources.Resources.icons8_depot_64
        Me.BlueDepot.Location = New System.Drawing.Point(293, 60)
        Me.BlueDepot.Name = "BlueDepot"
        Me.BlueDepot.Size = New System.Drawing.Size(100, 50)
        Me.BlueDepot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BlueDepot.TabIndex = 4
        Me.BlueDepot.TabStop = False
        '
        'TealDepot
        '
        Me.TealDepot.Image = Global.Minecraft_Clicker.My.Resources.Resources.icons8_depot_64__2_
        Me.TealDepot.Location = New System.Drawing.Point(152, 60)
        Me.TealDepot.Name = "TealDepot"
        Me.TealDepot.Size = New System.Drawing.Size(100, 50)
        Me.TealDepot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TealDepot.TabIndex = 3
        Me.TealDepot.TabStop = False
        '
        'RedDepot
        '
        Me.RedDepot.Image = Global.Minecraft_Clicker.My.Resources.Resources.icons8_depot_64__1_
        Me.RedDepot.InitialImage = CType(resources.GetObject("RedDepot.InitialImage"), System.Drawing.Image)
        Me.RedDepot.Location = New System.Drawing.Point(24, 60)
        Me.RedDepot.Name = "RedDepot"
        Me.RedDepot.Size = New System.Drawing.Size(100, 50)
        Me.RedDepot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RedDepot.TabIndex = 2
        Me.RedDepot.TabStop = False
        '
        'DiamondDepot
        '
        Me.DiamondDepot.Image = Global.Minecraft_Clicker.My.Resources.Resources.th_2354788584
        Me.DiamondDepot.Location = New System.Drawing.Point(1071, 60)
        Me.DiamondDepot.Name = "DiamondDepot"
        Me.DiamondDepot.Size = New System.Drawing.Size(100, 50)
        Me.DiamondDepot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DiamondDepot.TabIndex = 19
        Me.DiamondDepot.TabStop = False
        '
        'EmeraldDepot
        '
        Me.EmeraldDepot.Image = Global.Minecraft_Clicker.My.Resources.Resources.Emerald_2441025227
        Me.EmeraldDepot.Location = New System.Drawing.Point(1193, 60)
        Me.EmeraldDepot.Name = "EmeraldDepot"
        Me.EmeraldDepot.Size = New System.Drawing.Size(100, 50)
        Me.EmeraldDepot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EmeraldDepot.TabIndex = 20
        Me.EmeraldDepot.TabStop = False
        '
        'CurrencyDiamond
        '
        Me.CurrencyDiamond.AutoSize = True
        Me.CurrencyDiamond.Location = New System.Drawing.Point(1088, 23)
        Me.CurrencyDiamond.Name = "CurrencyDiamond"
        Me.CurrencyDiamond.Size = New System.Drawing.Size(61, 13)
        Me.CurrencyDiamond.TabIndex = 21
        Me.CurrencyDiamond.Text = "Diamond: 0"
        '
        'CurrencyEmerald
        '
        Me.CurrencyEmerald.AutoSize = True
        Me.CurrencyEmerald.Location = New System.Drawing.Point(1219, 23)
        Me.CurrencyEmerald.Name = "CurrencyEmerald"
        Me.CurrencyEmerald.Size = New System.Drawing.Size(57, 13)
        Me.CurrencyEmerald.TabIndex = 22
        Me.CurrencyEmerald.Text = "Emerald: 0"
        '
        'TopStopper
        '
        Me.TopStopper.Location = New System.Drawing.Point(1289, 1)
        Me.TopStopper.Name = "TopStopper"
        Me.TopStopper.Size = New System.Drawing.Size(123, 10)
        Me.TopStopper.TabIndex = 23
        Me.TopStopper.TabStop = False
        '
        'Timer2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1414, 530)
        Me.Controls.Add(Me.TopStopper)
        Me.Controls.Add(Me.CurrencyEmerald)
        Me.Controls.Add(Me.CurrencyDiamond)
        Me.Controls.Add(Me.EmeraldDepot)
        Me.Controls.Add(Me.DiamondDepot)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.CurrencyGold)
        Me.Controls.Add(Me.CurrencyIron)
        Me.Controls.Add(Me.CurrencyCopper)
        Me.Controls.Add(Me.CurrencyCobble)
        Me.Controls.Add(Me.CurrencyWood)
        Me.Controls.Add(Me.CurrencyBlue)
        Me.Controls.Add(Me.CurrencyTeal)
        Me.Controls.Add(Me.CurrencyRed)
        Me.Controls.Add(Me.GoldDepot)
        Me.Controls.Add(Me.IronDepot)
        Me.Controls.Add(Me.CopperDepot)
        Me.Controls.Add(Me.CobbleDepot)
        Me.Controls.Add(Me.WoodDepot)
        Me.Controls.Add(Me.BlueDepot)
        Me.Controls.Add(Me.TealDepot)
        Me.Controls.Add(Me.RedDepot)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GoldDepot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IronDepot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CopperDepot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CobbleDepot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WoodDepot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueDepot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TealDepot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RedDepot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiamondDepot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmeraldDepot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopStopper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RedDepot As PictureBox
    Friend WithEvents TealDepot As PictureBox
    Friend WithEvents BlueDepot As PictureBox
    Friend WithEvents WoodDepot As PictureBox
    Friend WithEvents CobbleDepot As PictureBox
    Friend WithEvents CopperDepot As PictureBox
    Friend WithEvents IronDepot As PictureBox
    Friend WithEvents GoldDepot As PictureBox
    Friend WithEvents CurrencyRed As Label
    Friend WithEvents CurrencyTeal As Label
    Friend WithEvents CurrencyBlue As Label
    Friend WithEvents CurrencyWood As Label
    Friend WithEvents CurrencyCobble As Label
    Friend WithEvents CurrencyCopper As Label
    Friend WithEvents CurrencyIron As Label
    Friend WithEvents CurrencyGold As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Player As PictureBox
    Friend WithEvents DiamondDepot As PictureBox
    Friend WithEvents EmeraldDepot As PictureBox
    Friend WithEvents CurrencyDiamond As Label
    Friend WithEvents CurrencyEmerald As Label
    Friend WithEvents TopStopper As PictureBox
    Friend WithEvents Timer2 As Timer
End Class
