<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblDays = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtLodging = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCarRentalFees = New System.Windows.Forms.TextBox()
        Me.txtTaxiFees = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMeals = New System.Windows.Forms.TextBox()
        Me.lblMeals = New System.Windows.Forms.Label()
        Me.txtParking = New System.Windows.Forms.TextBox()
        Me.lblParking = New System.Windows.Forms.Label()
        Me.txtAirFare = New System.Windows.Forms.TextBox()
        Me.lblAirfare = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileCalculateAllowance = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditChangeDailyRates = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsChooseColor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ChooseColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChooseColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AllBlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.cmsChooseColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.ContextMenuStrip = Me.cmsChooseColor
        Me.lblDays.Location = New System.Drawing.Point(26, 22)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(83, 13)
        Me.lblDays.TabIndex = 0
        Me.lblDays.Text = "Number of &Days"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(188, 19)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(100, 20)
        Me.txtDays.TabIndex = 1
        Me.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLodging)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCarRentalFees)
        Me.GroupBox1.Controls.Add(Me.txtTaxiFees)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMeals)
        Me.GroupBox1.Controls.Add(Me.lblMeals)
        Me.GroupBox1.Controls.Add(Me.txtParking)
        Me.GroupBox1.Controls.Add(Me.lblParking)
        Me.GroupBox1.Controls.Add(Me.txtAirFare)
        Me.GroupBox1.Controls.Add(Me.lblAirfare)
        Me.GroupBox1.Controls.Add(Me.txtDays)
        Me.GroupBox1.Controls.Add(Me.lblDays)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 296)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputs"
        '
        'txtLodging
        '
        Me.txtLodging.Location = New System.Drawing.Point(188, 214)
        Me.txtLodging.Name = "txtLodging"
        Me.txtLodging.Size = New System.Drawing.Size(100, 20)
        Me.txtLodging.TabIndex = 13
        Me.txtLodging.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ContextMenuStrip = Me.cmsChooseColor
        Me.Label3.Location = New System.Drawing.Point(26, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "&Lodging"
        '
        'txtCarRentalFees
        '
        Me.txtCarRentalFees.Location = New System.Drawing.Point(188, 112)
        Me.txtCarRentalFees.Name = "txtCarRentalFees"
        Me.txtCarRentalFees.Size = New System.Drawing.Size(100, 20)
        Me.txtCarRentalFees.TabIndex = 7
        Me.txtCarRentalFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTaxiFees
        '
        Me.txtTaxiFees.Location = New System.Drawing.Point(188, 145)
        Me.txtTaxiFees.Name = "txtTaxiFees"
        Me.txtTaxiFees.Size = New System.Drawing.Size(100, 20)
        Me.txtTaxiFees.TabIndex = 9
        Me.txtTaxiFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ContextMenuStrip = Me.cmsChooseColor
        Me.Label2.Location = New System.Drawing.Point(26, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "&Taxi Fees"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ContextMenuStrip = Me.cmsChooseColor
        Me.Label1.Location = New System.Drawing.Point(26, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "&Car Rentel Fees"
        '
        'txtMeals
        '
        Me.txtMeals.Location = New System.Drawing.Point(188, 80)
        Me.txtMeals.Name = "txtMeals"
        Me.txtMeals.Size = New System.Drawing.Size(100, 20)
        Me.txtMeals.TabIndex = 5
        Me.txtMeals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMeals
        '
        Me.lblMeals.AutoSize = True
        Me.lblMeals.ContextMenuStrip = Me.cmsChooseColor
        Me.lblMeals.Location = New System.Drawing.Point(26, 83)
        Me.lblMeals.Name = "lblMeals"
        Me.lblMeals.Size = New System.Drawing.Size(35, 13)
        Me.lblMeals.TabIndex = 4
        Me.lblMeals.Text = "&Meals"
        '
        'txtParking
        '
        Me.txtParking.Location = New System.Drawing.Point(188, 51)
        Me.txtParking.Name = "txtParking"
        Me.txtParking.Size = New System.Drawing.Size(100, 20)
        Me.txtParking.TabIndex = 3
        Me.txtParking.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblParking
        '
        Me.lblParking.AutoSize = True
        Me.lblParking.ContextMenuStrip = Me.cmsChooseColor
        Me.lblParking.Location = New System.Drawing.Point(26, 54)
        Me.lblParking.Name = "lblParking"
        Me.lblParking.Size = New System.Drawing.Size(43, 13)
        Me.lblParking.TabIndex = 2
        Me.lblParking.Text = "&Parking"
        '
        'txtAirFare
        '
        Me.txtAirFare.Location = New System.Drawing.Point(188, 183)
        Me.txtAirFare.Name = "txtAirFare"
        Me.txtAirFare.Size = New System.Drawing.Size(100, 20)
        Me.txtAirFare.TabIndex = 11
        Me.txtAirFare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAirfare
        '
        Me.lblAirfare.AutoSize = True
        Me.lblAirfare.ContextMenuStrip = Me.cmsChooseColor
        Me.lblAirfare.Location = New System.Drawing.Point(26, 186)
        Me.lblAirfare.Name = "lblAirfare"
        Me.lblAirfare.Size = New System.Drawing.Size(37, 13)
        Me.lblAirfare.TabIndex = 10
        Me.lblAirfare.Text = "&Airfare"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(226, 363)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 42)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate Allowance"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 15
        Me.lstOutput.Location = New System.Drawing.Point(363, 50)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(569, 244)
        Me.lstOutput.TabIndex = 3
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(57, 363)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(80, 42)
        Me.btnChange.TabIndex = 1
        Me.btnChange.Text = "Change Daily Rates"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ChooseColorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(959, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFileCalculateAllowance, Me.ToolStripMenuItem1, Me.menuFileExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'menuFileCalculateAllowance
        '
        Me.menuFileCalculateAllowance.Name = "menuFileCalculateAllowance"
        Me.menuFileCalculateAllowance.Size = New System.Drawing.Size(181, 22)
        Me.menuFileCalculateAllowance.Text = "&Calculate Allowance"
        '
        'menuFileExit
        '
        Me.menuFileExit.Name = "menuFileExit"
        Me.menuFileExit.Size = New System.Drawing.Size(181, 22)
        Me.menuFileExit.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEditChangeDailyRates})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'menuEditChangeDailyRates
        '
        Me.menuEditChangeDailyRates.Name = "menuEditChangeDailyRates"
        Me.menuEditChangeDailyRates.Size = New System.Drawing.Size(175, 22)
        Me.menuEditChangeDailyRates.Text = "&Change Daily Rates"
        '
        'cmsChooseColor
        '
        Me.cmsChooseColor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChooseColorToolStripMenuItem1})
        Me.cmsChooseColor.Name = "cmsChooseColor"
        Me.cmsChooseColor.Size = New System.Drawing.Size(147, 26)
        '
        'ChooseColorToolStripMenuItem
        '
        Me.ChooseColorToolStripMenuItem.Name = "ChooseColorToolStripMenuItem"
        Me.ChooseColorToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.ChooseColorToolStripMenuItem.Text = "&Choose Color"
        '
        'ChooseColorToolStripMenuItem1
        '
        Me.ChooseColorToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllBlackToolStripMenuItem, Me.AllRedToolStripMenuItem, Me.CustomToolStripMenuItem})
        Me.ChooseColorToolStripMenuItem1.Name = "ChooseColorToolStripMenuItem1"
        Me.ChooseColorToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.ChooseColorToolStripMenuItem1.Text = "Choose Color"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 6)
        '
        'AllBlackToolStripMenuItem
        '
        Me.AllBlackToolStripMenuItem.Name = "AllBlackToolStripMenuItem"
        Me.AllBlackToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AllBlackToolStripMenuItem.Text = "All Black"
        '
        'AllRedToolStripMenuItem
        '
        Me.AllRedToolStripMenuItem.Name = "AllRedToolStripMenuItem"
        Me.AllRedToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AllRedToolStripMenuItem.Text = "All Red"
        '
        'CustomToolStripMenuItem
        '
        Me.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem"
        Me.CustomToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CustomToolStripMenuItem.Text = "Custom"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 417)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Travel Expenses"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.cmsChooseColor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDays As System.Windows.Forms.Label
    Friend WithEvents txtDays As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtParking As System.Windows.Forms.TextBox
    Friend WithEvents lblParking As System.Windows.Forms.Label
    Friend WithEvents txtAirFare As System.Windows.Forms.TextBox
    Friend WithEvents lblAirfare As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents txtMeals As System.Windows.Forms.TextBox
    Friend WithEvents lblMeals As System.Windows.Forms.Label
    Friend WithEvents txtCarRentalFees As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxiFees As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLodging As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFileCalculateAllowance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEditChangeDailyRates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChooseColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsChooseColor As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ChooseColorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllBlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllRedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator

End Class
