<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetailPriceCalculator
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
        Me.lblIDWholesaleCostOf = New System.Windows.Forms.Label()
        Me.lblIDMarkup = New System.Windows.Forms.Label()
        Me.lblIDMarkupAmount = New System.Windows.Forms.Label()
        Me.lblIDRetailPrice = New System.Windows.Forms.Label()
        Me.txtWholesaleCost = New System.Windows.Forms.TextBox()
        Me.txtMarkup = New System.Windows.Forms.TextBox()
        Me.lblMarkupAmount = New System.Windows.Forms.Label()
        Me.lblRetailPrice = New System.Windows.Forms.Label()
        Me.btnGetRetail = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblIDWholesaleCostOf
        '
        Me.lblIDWholesaleCostOf.AutoSize = True
        Me.lblIDWholesaleCostOf.Location = New System.Drawing.Point(28, 47)
        Me.lblIDWholesaleCostOf.Name = "lblIDWholesaleCostOf"
        Me.lblIDWholesaleCostOf.Size = New System.Drawing.Size(93, 13)
        Me.lblIDWholesaleCostOf.TabIndex = 0
        Me.lblIDWholesaleCostOf.Text = "&Wholesale Cost of"
        Me.ToolTip1.SetToolTip(Me.lblIDWholesaleCostOf, "Enter the whole sale cost here")
        '
        'lblIDMarkup
        '
        Me.lblIDMarkup.AutoSize = True
        Me.lblIDMarkup.Location = New System.Drawing.Point(78, 83)
        Me.lblIDMarkup.Name = "lblIDMarkup"
        Me.lblIDMarkup.Size = New System.Drawing.Size(43, 13)
        Me.lblIDMarkup.TabIndex = 2
        Me.lblIDMarkup.Text = "&Markup"
        Me.ToolTip1.SetToolTip(Me.lblIDMarkup, "Enter the markup rate here")
        '
        'lblIDMarkupAmount
        '
        Me.lblIDMarkupAmount.AutoSize = True
        Me.lblIDMarkupAmount.Location = New System.Drawing.Point(39, 118)
        Me.lblIDMarkupAmount.Name = "lblIDMarkupAmount"
        Me.lblIDMarkupAmount.Size = New System.Drawing.Size(81, 13)
        Me.lblIDMarkupAmount.TabIndex = 4
        Me.lblIDMarkupAmount.Text = "Markup amount"
        Me.ToolTip1.SetToolTip(Me.lblIDMarkupAmount, "This is the amount of markup")
        '
        'lblIDRetailPrice
        '
        Me.lblIDRetailPrice.AutoSize = True
        Me.lblIDRetailPrice.Location = New System.Drawing.Point(59, 151)
        Me.lblIDRetailPrice.Name = "lblIDRetailPrice"
        Me.lblIDRetailPrice.Size = New System.Drawing.Size(61, 13)
        Me.lblIDRetailPrice.TabIndex = 6
        Me.lblIDRetailPrice.Text = "Retail Price"
        Me.ToolTip1.SetToolTip(Me.lblIDRetailPrice, "This is the retail price")
        '
        'txtWholesaleCost
        '
        Me.txtWholesaleCost.Location = New System.Drawing.Point(145, 44)
        Me.txtWholesaleCost.Name = "txtWholesaleCost"
        Me.txtWholesaleCost.Size = New System.Drawing.Size(100, 20)
        Me.txtWholesaleCost.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtWholesaleCost, "Range is 1 to 100")
        '
        'txtMarkup
        '
        Me.txtMarkup.Location = New System.Drawing.Point(145, 80)
        Me.txtMarkup.Name = "txtMarkup"
        Me.txtMarkup.Size = New System.Drawing.Size(100, 20)
        Me.txtMarkup.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtMarkup, "Range is 1 to 100")
        '
        'lblMarkupAmount
        '
        Me.lblMarkupAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMarkupAmount.Location = New System.Drawing.Point(145, 117)
        Me.lblMarkupAmount.Name = "lblMarkupAmount"
        Me.lblMarkupAmount.Size = New System.Drawing.Size(100, 20)
        Me.lblMarkupAmount.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.lblMarkupAmount, "This is the amount of markup")
        '
        'lblRetailPrice
        '
        Me.lblRetailPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRetailPrice.Location = New System.Drawing.Point(145, 150)
        Me.lblRetailPrice.Name = "lblRetailPrice"
        Me.lblRetailPrice.Size = New System.Drawing.Size(100, 20)
        Me.lblRetailPrice.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.lblRetailPrice, "This is the retail price")
        '
        'btnGetRetail
        '
        Me.btnGetRetail.Location = New System.Drawing.Point(277, 47)
        Me.btnGetRetail.Name = "btnGetRetail"
        Me.btnGetRetail.Size = New System.Drawing.Size(75, 23)
        Me.btnGetRetail.TabIndex = 8
        Me.btnGetRetail.Text = "Get &Retail"
        Me.ToolTip1.SetToolTip(Me.btnGetRetail, "Click here to get the retail price and markup amount")
        Me.btnGetRetail.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(277, 92)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Click here to erase all data from the fields")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(277, 141)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click here to close the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmRetailPriceCalculator
        '
        Me.AcceptButton = Me.btnGetRetail
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(383, 210)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnGetRetail)
        Me.Controls.Add(Me.lblRetailPrice)
        Me.Controls.Add(Me.lblMarkupAmount)
        Me.Controls.Add(Me.txtMarkup)
        Me.Controls.Add(Me.txtWholesaleCost)
        Me.Controls.Add(Me.lblIDRetailPrice)
        Me.Controls.Add(Me.lblIDMarkupAmount)
        Me.Controls.Add(Me.lblIDMarkup)
        Me.Controls.Add(Me.lblIDWholesaleCostOf)
        Me.Name = "frmRetailPriceCalculator"
        Me.Text = "Retail Price Calculator"
        Me.ToolTip1.SetToolTip(Me, "This program is used to calculate retail price")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIDWholesaleCostOf As System.Windows.Forms.Label
    Friend WithEvents lblIDMarkup As System.Windows.Forms.Label
    Friend WithEvents lblIDMarkupAmount As System.Windows.Forms.Label
    Friend WithEvents lblIDRetailPrice As System.Windows.Forms.Label
    Friend WithEvents txtWholesaleCost As System.Windows.Forms.TextBox
    Friend WithEvents txtMarkup As System.Windows.Forms.TextBox
    Friend WithEvents lblMarkupAmount As System.Windows.Forms.Label
    Friend WithEvents lblRetailPrice As System.Windows.Forms.Label
    Friend WithEvents btnGetRetail As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
