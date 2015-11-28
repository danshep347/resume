<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenses
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
        Me.lblIDDays = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtAirfare = New System.Windows.Forms.TextBox()
        Me.lblIDAirfare = New System.Windows.Forms.Label()
        Me.txtRegistration = New System.Windows.Forms.TextBox()
        Me.lblIDRegistration = New System.Windows.Forms.Label()
        Me.txtPOVMiles = New System.Windows.Forms.TextBox()
        Me.lblIDPOVMiles = New System.Windows.Forms.Label()
        Me.txtCarRental = New System.Windows.Forms.TextBox()
        Me.lblIDCarRental = New System.Windows.Forms.Label()
        Me.txtParking = New System.Windows.Forms.TextBox()
        Me.lblIDParking = New System.Windows.Forms.Label()
        Me.txtLodging = New System.Windows.Forms.TextBox()
        Me.lblIDLodging = New System.Windows.Forms.Label()
        Me.lblIDUnallowed = New System.Windows.Forms.Label()
        Me.lblUnallowed = New System.Windows.Forms.Label()
        Me.lblAllowed = New System.Windows.Forms.Label()
        Me.lblIDAllowed = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtTaxi = New System.Windows.Forms.TextBox()
        Me.lblIDTaxi = New System.Windows.Forms.Label()
        Me.txtMeals = New System.Windows.Forms.TextBox()
        Me.lblIDMeals = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblIDDays
        '
        Me.lblIDDays.AutoSize = True
        Me.lblIDDays.Location = New System.Drawing.Point(12, 15)
        Me.lblIDDays.Name = "lblIDDays"
        Me.lblIDDays.Size = New System.Drawing.Size(66, 13)
        Me.lblIDDays.TabIndex = 0
        Me.lblIDDays.Text = "Days on trip:"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(250, 12)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(100, 20)
        Me.txtDays.TabIndex = 1
        '
        'txtAirfare
        '
        Me.txtAirfare.Location = New System.Drawing.Point(250, 38)
        Me.txtAirfare.Name = "txtAirfare"
        Me.txtAirfare.Size = New System.Drawing.Size(100, 20)
        Me.txtAirfare.TabIndex = 3
        '
        'lblIDAirfare
        '
        Me.lblIDAirfare.AutoSize = True
        Me.lblIDAirfare.Location = New System.Drawing.Point(12, 41)
        Me.lblIDAirfare.Name = "lblIDAirfare"
        Me.lblIDAirfare.Size = New System.Drawing.Size(63, 13)
        Me.lblIDAirfare.TabIndex = 2
        Me.lblIDAirfare.Text = "Airfare cost:"
        '
        'txtRegistration
        '
        Me.txtRegistration.Location = New System.Drawing.Point(250, 142)
        Me.txtRegistration.Name = "txtRegistration"
        Me.txtRegistration.Size = New System.Drawing.Size(100, 20)
        Me.txtRegistration.TabIndex = 5
        '
        'lblIDRegistration
        '
        Me.lblIDRegistration.AutoSize = True
        Me.lblIDRegistration.Location = New System.Drawing.Point(12, 145)
        Me.lblIDRegistration.Name = "lblIDRegistration"
        Me.lblIDRegistration.Size = New System.Drawing.Size(89, 13)
        Me.lblIDRegistration.TabIndex = 4
        Me.lblIDRegistration.Text = "Registration fees:"
        '
        'txtPOVMiles
        '
        Me.txtPOVMiles.Location = New System.Drawing.Point(250, 90)
        Me.txtPOVMiles.Name = "txtPOVMiles"
        Me.txtPOVMiles.Size = New System.Drawing.Size(100, 20)
        Me.txtPOVMiles.TabIndex = 7
        '
        'lblIDPOVMiles
        '
        Me.lblIDPOVMiles.AutoSize = True
        Me.lblIDPOVMiles.Location = New System.Drawing.Point(12, 93)
        Me.lblIDPOVMiles.Name = "lblIDPOVMiles"
        Me.lblIDPOVMiles.Size = New System.Drawing.Size(152, 13)
        Me.lblIDPOVMiles.TabIndex = 6
        Me.lblIDPOVMiles.Text = "Miles driven by private vehicle:"
        '
        'txtCarRental
        '
        Me.txtCarRental.Location = New System.Drawing.Point(250, 64)
        Me.txtCarRental.Name = "txtCarRental"
        Me.txtCarRental.Size = New System.Drawing.Size(100, 20)
        Me.txtCarRental.TabIndex = 9
        '
        'lblIDCarRental
        '
        Me.lblIDCarRental.AutoSize = True
        Me.lblIDCarRental.Location = New System.Drawing.Point(12, 67)
        Me.lblIDCarRental.Name = "lblIDCarRental"
        Me.lblIDCarRental.Size = New System.Drawing.Size(78, 13)
        Me.lblIDCarRental.TabIndex = 8
        Me.lblIDCarRental.Text = "Car rental fees:"
        '
        'txtParking
        '
        Me.txtParking.Location = New System.Drawing.Point(250, 116)
        Me.txtParking.Name = "txtParking"
        Me.txtParking.Size = New System.Drawing.Size(100, 20)
        Me.txtParking.TabIndex = 11
        '
        'lblIDParking
        '
        Me.lblIDParking.AutoSize = True
        Me.lblIDParking.Location = New System.Drawing.Point(12, 119)
        Me.lblIDParking.Name = "lblIDParking"
        Me.lblIDParking.Size = New System.Drawing.Size(69, 13)
        Me.lblIDParking.TabIndex = 10
        Me.lblIDParking.Text = "Parking fees:"
        '
        'txtLodging
        '
        Me.txtLodging.Location = New System.Drawing.Point(250, 168)
        Me.txtLodging.Name = "txtLodging"
        Me.txtLodging.Size = New System.Drawing.Size(100, 20)
        Me.txtLodging.TabIndex = 13
        '
        'lblIDLodging
        '
        Me.lblIDLodging.AutoSize = True
        Me.lblIDLodging.Location = New System.Drawing.Point(12, 171)
        Me.lblIDLodging.Name = "lblIDLodging"
        Me.lblIDLodging.Size = New System.Drawing.Size(76, 13)
        Me.lblIDLodging.TabIndex = 12
        Me.lblIDLodging.Text = "Lodging costs:"
        '
        'lblIDUnallowed
        '
        Me.lblIDUnallowed.AutoSize = True
        Me.lblIDUnallowed.Location = New System.Drawing.Point(12, 281)
        Me.lblIDUnallowed.Name = "lblIDUnallowed"
        Me.lblIDUnallowed.Size = New System.Drawing.Size(109, 13)
        Me.lblIDUnallowed.TabIndex = 14
        Me.lblIDUnallowed.Text = "Unallowed Expenses:"
        '
        'lblUnallowed
        '
        Me.lblUnallowed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUnallowed.Location = New System.Drawing.Point(250, 281)
        Me.lblUnallowed.Name = "lblUnallowed"
        Me.lblUnallowed.Size = New System.Drawing.Size(100, 23)
        Me.lblUnallowed.TabIndex = 15
        '
        'lblAllowed
        '
        Me.lblAllowed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAllowed.Location = New System.Drawing.Point(250, 318)
        Me.lblAllowed.Name = "lblAllowed"
        Me.lblAllowed.Size = New System.Drawing.Size(100, 24)
        Me.lblAllowed.TabIndex = 17
        '
        'lblIDAllowed
        '
        Me.lblIDAllowed.AutoSize = True
        Me.lblIDAllowed.Location = New System.Drawing.Point(12, 319)
        Me.lblIDAllowed.Name = "lblIDAllowed"
        Me.lblIDAllowed.Size = New System.Drawing.Size(96, 13)
        Me.lblIDAllowed.TabIndex = 16
        Me.lblIDAllowed.Text = "Allowed Expenses:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 365)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 18
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(143, 365)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(275, 365)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtTaxi
        '
        Me.txtTaxi.Location = New System.Drawing.Point(250, 220)
        Me.txtTaxi.Name = "txtTaxi"
        Me.txtTaxi.Size = New System.Drawing.Size(100, 20)
        Me.txtTaxi.TabIndex = 24
        '
        'lblIDTaxi
        '
        Me.lblIDTaxi.AutoSize = True
        Me.lblIDTaxi.Location = New System.Drawing.Point(12, 223)
        Me.lblIDTaxi.Name = "lblIDTaxi"
        Me.lblIDTaxi.Size = New System.Drawing.Size(71, 13)
        Me.lblIDTaxi.TabIndex = 23
        Me.lblIDTaxi.Text = "Taxi charges:"
        '
        'txtMeals
        '
        Me.txtMeals.Location = New System.Drawing.Point(250, 194)
        Me.txtMeals.Name = "txtMeals"
        Me.txtMeals.Size = New System.Drawing.Size(100, 20)
        Me.txtMeals.TabIndex = 22
        '
        'lblIDMeals
        '
        Me.lblIDMeals.AutoSize = True
        Me.lblIDMeals.Location = New System.Drawing.Point(12, 197)
        Me.lblIDMeals.Name = "lblIDMeals"
        Me.lblIDMeals.Size = New System.Drawing.Size(73, 13)
        Me.lblIDMeals.TabIndex = 21
        Me.lblIDMeals.Text = "Cost of meals:"
        '
        'frmExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 400)
        Me.Controls.Add(Me.txtTaxi)
        Me.Controls.Add(Me.lblIDTaxi)
        Me.Controls.Add(Me.txtMeals)
        Me.Controls.Add(Me.lblIDMeals)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblAllowed)
        Me.Controls.Add(Me.lblIDAllowed)
        Me.Controls.Add(Me.lblUnallowed)
        Me.Controls.Add(Me.lblIDUnallowed)
        Me.Controls.Add(Me.txtLodging)
        Me.Controls.Add(Me.lblIDLodging)
        Me.Controls.Add(Me.txtParking)
        Me.Controls.Add(Me.lblIDParking)
        Me.Controls.Add(Me.txtCarRental)
        Me.Controls.Add(Me.lblIDCarRental)
        Me.Controls.Add(Me.txtPOVMiles)
        Me.Controls.Add(Me.lblIDPOVMiles)
        Me.Controls.Add(Me.txtRegistration)
        Me.Controls.Add(Me.lblIDRegistration)
        Me.Controls.Add(Me.txtAirfare)
        Me.Controls.Add(Me.lblIDAirfare)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.lblIDDays)
        Me.Name = "frmExpenses"
        Me.Text = "Travel Expenses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIDDays As System.Windows.Forms.Label
    Friend WithEvents txtDays As System.Windows.Forms.TextBox
    Friend WithEvents txtAirfare As System.Windows.Forms.TextBox
    Friend WithEvents lblIDAirfare As System.Windows.Forms.Label
    Friend WithEvents txtRegistration As System.Windows.Forms.TextBox
    Friend WithEvents lblIDRegistration As System.Windows.Forms.Label
    Friend WithEvents txtPOVMiles As System.Windows.Forms.TextBox
    Friend WithEvents lblIDPOVMiles As System.Windows.Forms.Label
    Friend WithEvents txtCarRental As System.Windows.Forms.TextBox
    Friend WithEvents lblIDCarRental As System.Windows.Forms.Label
    Friend WithEvents txtParking As System.Windows.Forms.TextBox
    Friend WithEvents lblIDParking As System.Windows.Forms.Label
    Friend WithEvents txtLodging As System.Windows.Forms.TextBox
    Friend WithEvents lblIDLodging As System.Windows.Forms.Label
    Friend WithEvents lblIDUnallowed As System.Windows.Forms.Label
    Friend WithEvents lblUnallowed As System.Windows.Forms.Label
    Friend WithEvents lblAllowed As System.Windows.Forms.Label
    Friend WithEvents lblIDAllowed As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtTaxi As System.Windows.Forms.TextBox
    Friend WithEvents lblIDTaxi As System.Windows.Forms.Label
    Friend WithEvents txtMeals As System.Windows.Forms.TextBox
    Friend WithEvents lblIDMeals As System.Windows.Forms.Label

End Class
