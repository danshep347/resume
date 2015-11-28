<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrandisBagelHouse
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
        Me.grpPickABagel = New System.Windows.Forms.GroupBox()
        Me.radBagelWholeWheat = New System.Windows.Forms.RadioButton()
        Me.radBagelNone = New System.Windows.Forms.RadioButton()
        Me.radBagelWhite = New System.Windows.Forms.RadioButton()
        Me.grpPickYourToppings = New System.Windows.Forms.GroupBox()
        Me.chkToppingsPeach = New System.Windows.Forms.CheckBox()
        Me.chkToppingsRaspberry = New System.Windows.Forms.CheckBox()
        Me.chkToppingsBlueberry = New System.Windows.Forms.CheckBox()
        Me.chkToppingsButter = New System.Windows.Forms.CheckBox()
        Me.chkToppingsCreamCheese = New System.Windows.Forms.CheckBox()
        Me.grpWantCoffeeWithThat = New System.Windows.Forms.GroupBox()
        Me.radCoffeeCafeAuLait = New System.Windows.Forms.RadioButton()
        Me.radCoffeeCappuccino = New System.Windows.Forms.RadioButton()
        Me.radCoffeeRegularCoffee = New System.Windows.Forms.RadioButton()
        Me.radCoffeeNone = New System.Windows.Forms.RadioButton()
        Me.grpPrice = New System.Windows.Forms.GroupBox()
        Me.lblPriceTotal = New System.Windows.Forms.Label()
        Me.lblPriceTax = New System.Windows.Forms.Label()
        Me.lblPriceSubtotal = New System.Windows.Forms.Label()
        Me.lblIDPriceTotal = New System.Windows.Forms.Label()
        Me.lblIDPriceTax = New System.Windows.Forms.Label()
        Me.lblIDPriceSubtotal = New System.Windows.Forms.Label()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.btnResetForm = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpPickABagel.SuspendLayout()
        Me.grpPickYourToppings.SuspendLayout()
        Me.grpWantCoffeeWithThat.SuspendLayout()
        Me.grpPrice.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPickABagel
        '
        Me.grpPickABagel.Controls.Add(Me.radBagelWholeWheat)
        Me.grpPickABagel.Controls.Add(Me.radBagelNone)
        Me.grpPickABagel.Controls.Add(Me.radBagelWhite)
        Me.grpPickABagel.Location = New System.Drawing.Point(32, 26)
        Me.grpPickABagel.Name = "grpPickABagel"
        Me.grpPickABagel.Size = New System.Drawing.Size(200, 90)
        Me.grpPickABagel.TabIndex = 0
        Me.grpPickABagel.TabStop = False
        Me.grpPickABagel.Text = "Pick a Bagel"
        '
        'radBagelWholeWheat
        '
        Me.radBagelWholeWheat.AutoSize = True
        Me.radBagelWholeWheat.Location = New System.Drawing.Point(25, 65)
        Me.radBagelWholeWheat.Name = "radBagelWholeWheat"
        Me.radBagelWholeWheat.Size = New System.Drawing.Size(127, 17)
        Me.radBagelWholeWheat.TabIndex = 2
        Me.radBagelWholeWheat.TabStop = True
        Me.radBagelWholeWheat.Text = "Whole Wheat ($1.50)"
        Me.ToolTip1.SetToolTip(Me.radBagelWholeWheat, "Click here to choose a whole wheat bagel.")
        Me.radBagelWholeWheat.UseVisualStyleBackColor = True
        '
        'radBagelNone
        '
        Me.radBagelNone.AutoSize = True
        Me.radBagelNone.Location = New System.Drawing.Point(25, 19)
        Me.radBagelNone.Name = "radBagelNone"
        Me.radBagelNone.Size = New System.Drawing.Size(51, 17)
        Me.radBagelNone.TabIndex = 0
        Me.radBagelNone.Text = "None"
        Me.ToolTip1.SetToolTip(Me.radBagelNone, "Click here to choose no bagel.")
        Me.radBagelNone.UseVisualStyleBackColor = True
        '
        'radBagelWhite
        '
        Me.radBagelWhite.AutoSize = True
        Me.radBagelWhite.Checked = True
        Me.radBagelWhite.Location = New System.Drawing.Point(25, 42)
        Me.radBagelWhite.Name = "radBagelWhite"
        Me.radBagelWhite.Size = New System.Drawing.Size(89, 17)
        Me.radBagelWhite.TabIndex = 1
        Me.radBagelWhite.TabStop = True
        Me.radBagelWhite.Text = "White ($1.25)"
        Me.ToolTip1.SetToolTip(Me.radBagelWhite, "Click here to choose a white bagel.")
        Me.radBagelWhite.UseVisualStyleBackColor = True
        '
        'grpPickYourToppings
        '
        Me.grpPickYourToppings.Controls.Add(Me.chkToppingsPeach)
        Me.grpPickYourToppings.Controls.Add(Me.chkToppingsRaspberry)
        Me.grpPickYourToppings.Controls.Add(Me.chkToppingsBlueberry)
        Me.grpPickYourToppings.Controls.Add(Me.chkToppingsButter)
        Me.grpPickYourToppings.Controls.Add(Me.chkToppingsCreamCheese)
        Me.grpPickYourToppings.Location = New System.Drawing.Point(32, 146)
        Me.grpPickYourToppings.Name = "grpPickYourToppings"
        Me.grpPickYourToppings.Size = New System.Drawing.Size(200, 140)
        Me.grpPickYourToppings.TabIndex = 1
        Me.grpPickYourToppings.TabStop = False
        Me.grpPickYourToppings.Text = "Pick Your Toppings"
        '
        'chkToppingsPeach
        '
        Me.chkToppingsPeach.AutoSize = True
        Me.chkToppingsPeach.Location = New System.Drawing.Point(25, 112)
        Me.chkToppingsPeach.Name = "chkToppingsPeach"
        Me.chkToppingsPeach.Size = New System.Drawing.Size(110, 17)
        Me.chkToppingsPeach.TabIndex = 4
        Me.chkToppingsPeach.Text = "Peach Jelly ($.75)"
        Me.ToolTip1.SetToolTip(Me.chkToppingsPeach, "Click here to choose peach jelly.")
        Me.chkToppingsPeach.UseVisualStyleBackColor = True
        '
        'chkToppingsRaspberry
        '
        Me.chkToppingsRaspberry.AutoSize = True
        Me.chkToppingsRaspberry.Location = New System.Drawing.Point(25, 89)
        Me.chkToppingsRaspberry.Name = "chkToppingsRaspberry"
        Me.chkToppingsRaspberry.Size = New System.Drawing.Size(126, 17)
        Me.chkToppingsRaspberry.TabIndex = 3
        Me.chkToppingsRaspberry.Text = "Raspberry Jam ($.75)"
        Me.ToolTip1.SetToolTip(Me.chkToppingsRaspberry, "Click here to choose raspberry jam.")
        Me.chkToppingsRaspberry.UseVisualStyleBackColor = True
        '
        'chkToppingsBlueberry
        '
        Me.chkToppingsBlueberry.AutoSize = True
        Me.chkToppingsBlueberry.Location = New System.Drawing.Point(25, 66)
        Me.chkToppingsBlueberry.Name = "chkToppingsBlueberry"
        Me.chkToppingsBlueberry.Size = New System.Drawing.Size(122, 17)
        Me.chkToppingsBlueberry.TabIndex = 2
        Me.chkToppingsBlueberry.Text = "Blueberry Jam ($.75)"
        Me.ToolTip1.SetToolTip(Me.chkToppingsBlueberry, "Click here to choose blueberry jam.")
        Me.chkToppingsBlueberry.UseVisualStyleBackColor = True
        '
        'chkToppingsButter
        '
        Me.chkToppingsButter.AutoSize = True
        Me.chkToppingsButter.Location = New System.Drawing.Point(25, 43)
        Me.chkToppingsButter.Name = "chkToppingsButter"
        Me.chkToppingsButter.Size = New System.Drawing.Size(84, 17)
        Me.chkToppingsButter.TabIndex = 1
        Me.chkToppingsButter.Text = "Butter ($.25)"
        Me.ToolTip1.SetToolTip(Me.chkToppingsButter, "Click here to choose butter.")
        Me.chkToppingsButter.UseVisualStyleBackColor = True
        '
        'chkToppingsCreamCheese
        '
        Me.chkToppingsCreamCheese.AutoSize = True
        Me.chkToppingsCreamCheese.Location = New System.Drawing.Point(26, 20)
        Me.chkToppingsCreamCheese.Name = "chkToppingsCreamCheese"
        Me.chkToppingsCreamCheese.Size = New System.Drawing.Size(125, 17)
        Me.chkToppingsCreamCheese.TabIndex = 0
        Me.chkToppingsCreamCheese.Text = "Cream Cheese ($.50)"
        Me.ToolTip1.SetToolTip(Me.chkToppingsCreamCheese, "Click here to choose cream cheese.")
        Me.chkToppingsCreamCheese.UseVisualStyleBackColor = True
        '
        'grpWantCoffeeWithThat
        '
        Me.grpWantCoffeeWithThat.Controls.Add(Me.radCoffeeCafeAuLait)
        Me.grpWantCoffeeWithThat.Controls.Add(Me.radCoffeeCappuccino)
        Me.grpWantCoffeeWithThat.Controls.Add(Me.radCoffeeRegularCoffee)
        Me.grpWantCoffeeWithThat.Controls.Add(Me.radCoffeeNone)
        Me.grpWantCoffeeWithThat.Location = New System.Drawing.Point(267, 26)
        Me.grpWantCoffeeWithThat.Name = "grpWantCoffeeWithThat"
        Me.grpWantCoffeeWithThat.Size = New System.Drawing.Size(220, 114)
        Me.grpWantCoffeeWithThat.TabIndex = 2
        Me.grpWantCoffeeWithThat.TabStop = False
        Me.grpWantCoffeeWithThat.Text = "Want Coffee with That?"
        '
        'radCoffeeCafeAuLait
        '
        Me.radCoffeeCafeAuLait.AutoSize = True
        Me.radCoffeeCafeAuLait.Location = New System.Drawing.Point(31, 88)
        Me.radCoffeeCafeAuLait.Name = "radCoffeeCafeAuLait"
        Me.radCoffeeCafeAuLait.Size = New System.Drawing.Size(114, 17)
        Me.radCoffeeCafeAuLait.TabIndex = 3
        Me.radCoffeeCafeAuLait.TabStop = True
        Me.radCoffeeCafeAuLait.Text = "Cafe au lait ($1.75)"
        Me.ToolTip1.SetToolTip(Me.radCoffeeCafeAuLait, "Click here to choose cafe au lait.")
        Me.radCoffeeCafeAuLait.UseVisualStyleBackColor = True
        '
        'radCoffeeCappuccino
        '
        Me.radCoffeeCappuccino.AutoSize = True
        Me.radCoffeeCappuccino.Location = New System.Drawing.Point(31, 65)
        Me.radCoffeeCappuccino.Name = "radCoffeeCappuccino"
        Me.radCoffeeCappuccino.Size = New System.Drawing.Size(118, 17)
        Me.radCoffeeCappuccino.TabIndex = 2
        Me.radCoffeeCappuccino.TabStop = True
        Me.radCoffeeCappuccino.Text = "Cappuccino ($2.00)"
        Me.ToolTip1.SetToolTip(Me.radCoffeeCappuccino, "Click here to choose cappuccino.")
        Me.radCoffeeCappuccino.UseVisualStyleBackColor = True
        '
        'radCoffeeRegularCoffee
        '
        Me.radCoffeeRegularCoffee.AutoSize = True
        Me.radCoffeeRegularCoffee.Checked = True
        Me.radCoffeeRegularCoffee.Location = New System.Drawing.Point(31, 42)
        Me.radCoffeeRegularCoffee.Name = "radCoffeeRegularCoffee"
        Me.radCoffeeRegularCoffee.Size = New System.Drawing.Size(132, 17)
        Me.radCoffeeRegularCoffee.TabIndex = 1
        Me.radCoffeeRegularCoffee.TabStop = True
        Me.radCoffeeRegularCoffee.Text = "Regular Coffee ($1.25)"
        Me.ToolTip1.SetToolTip(Me.radCoffeeRegularCoffee, "Click here to choose regular coffee.")
        Me.radCoffeeRegularCoffee.UseVisualStyleBackColor = True
        '
        'radCoffeeNone
        '
        Me.radCoffeeNone.AutoSize = True
        Me.radCoffeeNone.Location = New System.Drawing.Point(31, 19)
        Me.radCoffeeNone.Name = "radCoffeeNone"
        Me.radCoffeeNone.Size = New System.Drawing.Size(51, 17)
        Me.radCoffeeNone.TabIndex = 0
        Me.radCoffeeNone.TabStop = True
        Me.radCoffeeNone.Text = "None"
        Me.ToolTip1.SetToolTip(Me.radCoffeeNone, "Click here to choose no coffee.")
        Me.radCoffeeNone.UseVisualStyleBackColor = True
        '
        'grpPrice
        '
        Me.grpPrice.Controls.Add(Me.lblPriceTotal)
        Me.grpPrice.Controls.Add(Me.lblPriceTax)
        Me.grpPrice.Controls.Add(Me.lblPriceSubtotal)
        Me.grpPrice.Controls.Add(Me.lblIDPriceTotal)
        Me.grpPrice.Controls.Add(Me.lblIDPriceTax)
        Me.grpPrice.Controls.Add(Me.lblIDPriceSubtotal)
        Me.grpPrice.Location = New System.Drawing.Point(267, 166)
        Me.grpPrice.Name = "grpPrice"
        Me.grpPrice.Size = New System.Drawing.Size(220, 120)
        Me.grpPrice.TabIndex = 3
        Me.grpPrice.TabStop = False
        Me.grpPrice.Text = "Price"
        '
        'lblPriceTotal
        '
        Me.lblPriceTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriceTotal.Location = New System.Drawing.Point(94, 83)
        Me.lblPriceTotal.Name = "lblPriceTotal"
        Me.lblPriceTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblPriceTotal.TabIndex = 5
        '
        'lblPriceTax
        '
        Me.lblPriceTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriceTax.Location = New System.Drawing.Point(94, 52)
        Me.lblPriceTax.Name = "lblPriceTax"
        Me.lblPriceTax.Size = New System.Drawing.Size(100, 23)
        Me.lblPriceTax.TabIndex = 3
        '
        'lblPriceSubtotal
        '
        Me.lblPriceSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriceSubtotal.Location = New System.Drawing.Point(94, 22)
        Me.lblPriceSubtotal.Name = "lblPriceSubtotal"
        Me.lblPriceSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.lblPriceSubtotal.TabIndex = 1
        '
        'lblIDPriceTotal
        '
        Me.lblIDPriceTotal.AutoSize = True
        Me.lblIDPriceTotal.Location = New System.Drawing.Point(28, 84)
        Me.lblIDPriceTotal.Name = "lblIDPriceTotal"
        Me.lblIDPriceTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblIDPriceTotal.TabIndex = 4
        Me.lblIDPriceTotal.Text = "Total"
        '
        'lblIDPriceTax
        '
        Me.lblIDPriceTax.AutoSize = True
        Me.lblIDPriceTax.Location = New System.Drawing.Point(28, 53)
        Me.lblIDPriceTax.Name = "lblIDPriceTax"
        Me.lblIDPriceTax.Size = New System.Drawing.Size(25, 13)
        Me.lblIDPriceTax.TabIndex = 2
        Me.lblIDPriceTax.Text = "Tax"
        '
        'lblIDPriceSubtotal
        '
        Me.lblIDPriceSubtotal.AutoSize = True
        Me.lblIDPriceSubtotal.Location = New System.Drawing.Point(28, 23)
        Me.lblIDPriceSubtotal.Name = "lblIDPriceSubtotal"
        Me.lblIDPriceSubtotal.Size = New System.Drawing.Size(46, 13)
        Me.lblIDPriceSubtotal.TabIndex = 0
        Me.lblIDPriceSubtotal.Text = "Subtotal"
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.Location = New System.Drawing.Point(34, 320)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(112, 32)
        Me.btnCalculateTotal.TabIndex = 4
        Me.btnCalculateTotal.Text = "&Calculate Total"
        Me.ToolTip1.SetToolTip(Me.btnCalculateTotal, "Click here to calculate the total of the order.")
        Me.btnCalculateTotal.UseVisualStyleBackColor = True
        '
        'btnResetForm
        '
        Me.btnResetForm.Location = New System.Drawing.Point(222, 320)
        Me.btnResetForm.Name = "btnResetForm"
        Me.btnResetForm.Size = New System.Drawing.Size(98, 32)
        Me.btnResetForm.TabIndex = 5
        Me.btnResetForm.Text = "&Reset Form"
        Me.ToolTip1.SetToolTip(Me.btnResetForm, "Click here to clear the form and start over.")
        Me.btnResetForm.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(395, 321)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 30)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click here to exit.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmBrandisBagelHouse
        '
        Me.AcceptButton = Me.btnCalculateTotal
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(522, 389)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnResetForm)
        Me.Controls.Add(Me.btnCalculateTotal)
        Me.Controls.Add(Me.grpPrice)
        Me.Controls.Add(Me.grpWantCoffeeWithThat)
        Me.Controls.Add(Me.grpPickYourToppings)
        Me.Controls.Add(Me.grpPickABagel)
        Me.Name = "frmBrandisBagelHouse"
        Me.Text = "Brandi's Bagel House"
        Me.grpPickABagel.ResumeLayout(False)
        Me.grpPickABagel.PerformLayout()
        Me.grpPickYourToppings.ResumeLayout(False)
        Me.grpPickYourToppings.PerformLayout()
        Me.grpWantCoffeeWithThat.ResumeLayout(False)
        Me.grpWantCoffeeWithThat.PerformLayout()
        Me.grpPrice.ResumeLayout(False)
        Me.grpPrice.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpPickABagel As System.Windows.Forms.GroupBox
    Friend WithEvents radBagelWholeWheat As System.Windows.Forms.RadioButton
    Friend WithEvents radBagelNone As System.Windows.Forms.RadioButton
    Friend WithEvents radBagelWhite As System.Windows.Forms.RadioButton
    Friend WithEvents grpPickYourToppings As System.Windows.Forms.GroupBox
    Friend WithEvents chkToppingsRaspberry As System.Windows.Forms.CheckBox
    Friend WithEvents chkToppingsBlueberry As System.Windows.Forms.CheckBox
    Friend WithEvents chkToppingsButter As System.Windows.Forms.CheckBox
    Friend WithEvents chkToppingsCreamCheese As System.Windows.Forms.CheckBox
    Friend WithEvents grpWantCoffeeWithThat As System.Windows.Forms.GroupBox
    Friend WithEvents radCoffeeCafeAuLait As System.Windows.Forms.RadioButton
    Friend WithEvents radCoffeeCappuccino As System.Windows.Forms.RadioButton
    Friend WithEvents radCoffeeRegularCoffee As System.Windows.Forms.RadioButton
    Friend WithEvents radCoffeeNone As System.Windows.Forms.RadioButton
    Friend WithEvents grpPrice As System.Windows.Forms.GroupBox
    Friend WithEvents lblIDPriceTotal As System.Windows.Forms.Label
    Friend WithEvents lblIDPriceTax As System.Windows.Forms.Label
    Friend WithEvents lblIDPriceSubtotal As System.Windows.Forms.Label
    Friend WithEvents btnCalculateTotal As System.Windows.Forms.Button
    Friend WithEvents btnResetForm As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents chkToppingsPeach As System.Windows.Forms.CheckBox
    Friend WithEvents lblPriceTotal As System.Windows.Forms.Label
    Friend WithEvents lblPriceTax As System.Windows.Forms.Label
    Friend WithEvents lblPriceSubtotal As System.Windows.Forms.Label

End Class
