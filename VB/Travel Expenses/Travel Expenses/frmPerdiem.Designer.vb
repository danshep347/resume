<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerdiem
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtLodging = New System.Windows.Forms.TextBox()
        Me.lblIDLodging = New System.Windows.Forms.Label()
        Me.txtTaxiFees = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMeals = New System.Windows.Forms.TextBox()
        Me.lblMeals = New System.Windows.Forms.Label()
        Me.txtParking = New System.Windows.Forms.TextBox()
        Me.lblParking = New System.Windows.Forms.Label()
        Me.txtMilageRate = New System.Windows.Forms.TextBox()
        Me.lblAirfare = New System.Windows.Forms.Label()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnNoChanges = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLodging)
        Me.GroupBox1.Controls.Add(Me.lblIDLodging)
        Me.GroupBox1.Controls.Add(Me.txtTaxiFees)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMeals)
        Me.GroupBox1.Controls.Add(Me.lblMeals)
        Me.GroupBox1.Controls.Add(Me.txtParking)
        Me.GroupBox1.Controls.Add(Me.lblParking)
        Me.GroupBox1.Controls.Add(Me.txtMilageRate)
        Me.GroupBox1.Controls.Add(Me.lblAirfare)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 223)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputs"
        '
        'txtLodging
        '
        Me.txtLodging.Location = New System.Drawing.Point(188, 180)
        Me.txtLodging.Name = "txtLodging"
        Me.txtLodging.Size = New System.Drawing.Size(100, 20)
        Me.txtLodging.TabIndex = 9
        Me.txtLodging.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblIDLodging
        '
        Me.lblIDLodging.AutoSize = True
        Me.lblIDLodging.Location = New System.Drawing.Point(26, 183)
        Me.lblIDLodging.Name = "lblIDLodging"
        Me.lblIDLodging.Size = New System.Drawing.Size(45, 13)
        Me.lblIDLodging.TabIndex = 8
        Me.lblIDLodging.Text = "&Lodging"
        '
        'txtTaxiFees
        '
        Me.txtTaxiFees.Location = New System.Drawing.Point(188, 113)
        Me.txtTaxiFees.Name = "txtTaxiFees"
        Me.txtTaxiFees.Size = New System.Drawing.Size(100, 20)
        Me.txtTaxiFees.TabIndex = 5
        Me.txtTaxiFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&Taxi Fees"
        '
        'txtMeals
        '
        Me.txtMeals.Location = New System.Drawing.Point(188, 80)
        Me.txtMeals.Name = "txtMeals"
        Me.txtMeals.Size = New System.Drawing.Size(100, 20)
        Me.txtMeals.TabIndex = 3
        Me.txtMeals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMeals
        '
        Me.lblMeals.AutoSize = True
        Me.lblMeals.Location = New System.Drawing.Point(26, 83)
        Me.lblMeals.Name = "lblMeals"
        Me.lblMeals.Size = New System.Drawing.Size(35, 13)
        Me.lblMeals.TabIndex = 2
        Me.lblMeals.Text = "&Meals"
        '
        'txtParking
        '
        Me.txtParking.Location = New System.Drawing.Point(188, 51)
        Me.txtParking.Name = "txtParking"
        Me.txtParking.Size = New System.Drawing.Size(100, 20)
        Me.txtParking.TabIndex = 1
        Me.txtParking.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblParking
        '
        Me.lblParking.AutoSize = True
        Me.lblParking.Location = New System.Drawing.Point(26, 54)
        Me.lblParking.Name = "lblParking"
        Me.lblParking.Size = New System.Drawing.Size(43, 13)
        Me.lblParking.TabIndex = 0
        Me.lblParking.Text = "&Parking"
        '
        'txtMilageRate
        '
        Me.txtMilageRate.Location = New System.Drawing.Point(188, 145)
        Me.txtMilageRate.Name = "txtMilageRate"
        Me.txtMilageRate.Size = New System.Drawing.Size(100, 20)
        Me.txtMilageRate.TabIndex = 7
        Me.txtMilageRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAirfare
        '
        Me.lblAirfare.AutoSize = True
        Me.lblAirfare.Location = New System.Drawing.Point(26, 148)
        Me.lblAirfare.Name = "lblAirfare"
        Me.lblAirfare.Size = New System.Drawing.Size(64, 13)
        Me.lblAirfare.TabIndex = 6
        Me.lblAirfare.Text = "Milage &Rate"
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(23, 254)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(80, 35)
        Me.btnSaveChanges.TabIndex = 1
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'btnNoChanges
        '
        Me.btnNoChanges.Location = New System.Drawing.Point(221, 254)
        Me.btnNoChanges.Name = "btnNoChanges"
        Me.btnNoChanges.Size = New System.Drawing.Size(80, 35)
        Me.btnNoChanges.TabIndex = 2
        Me.btnNoChanges.Text = "No Changes"
        Me.btnNoChanges.UseVisualStyleBackColor = True
        '
        'frmPerdiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 304)
        Me.Controls.Add(Me.btnNoChanges)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPerdiem"
        Me.Text = "Perdiem"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTaxiFees As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMeals As System.Windows.Forms.TextBox
    Friend WithEvents lblMeals As System.Windows.Forms.Label
    Friend WithEvents txtParking As System.Windows.Forms.TextBox
    Friend WithEvents lblParking As System.Windows.Forms.Label
    Friend WithEvents txtMilageRate As System.Windows.Forms.TextBox
    Friend WithEvents lblAirfare As System.Windows.Forms.Label
    Friend WithEvents txtLodging As System.Windows.Forms.TextBox
    Friend WithEvents lblIDLodging As System.Windows.Forms.Label
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents btnNoChanges As System.Windows.Forms.Button
End Class
