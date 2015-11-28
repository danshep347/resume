<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollCalculator
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
        Me.lblIDHourlyPay = New System.Windows.Forms.Label()
        Me.lblIDStateTaxRate = New System.Windows.Forms.Label()
        Me.lblIDFederalTaxRate = New System.Windows.Forms.Label()
        Me.lblIDNumberOfExemptions = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.chkAnnuity = New System.Windows.Forms.CheckBox()
        Me.txtStateTaxRate = New System.Windows.Forms.TextBox()
        Me.txtFederalTaxRate = New System.Windows.Forms.TextBox()
        Me.txtNumberOfExemptions = New System.Windows.Forms.TextBox()
        Me.txtHourlyPay = New System.Windows.Forms.TextBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblIDHourlyPay
        '
        Me.lblIDHourlyPay.AutoSize = True
        Me.lblIDHourlyPay.Location = New System.Drawing.Point(37, 28)
        Me.lblIDHourlyPay.Name = "lblIDHourlyPay"
        Me.lblIDHourlyPay.Size = New System.Drawing.Size(61, 13)
        Me.lblIDHourlyPay.TabIndex = 0
        Me.lblIDHourlyPay.Text = "&Hourly Pay:"
        Me.ToolTip1.SetToolTip(Me.lblIDHourlyPay, "Enter the amount of money you make an hour." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'lblIDStateTaxRate
        '
        Me.lblIDStateTaxRate.AutoSize = True
        Me.lblIDStateTaxRate.Location = New System.Drawing.Point(37, 71)
        Me.lblIDStateTaxRate.Name = "lblIDStateTaxRate"
        Me.lblIDStateTaxRate.Size = New System.Drawing.Size(82, 13)
        Me.lblIDStateTaxRate.TabIndex = 2
        Me.lblIDStateTaxRate.Text = "&State Tax Rate:"
        Me.ToolTip1.SetToolTip(Me.lblIDStateTaxRate, "Enter the percentage your state charges you for taxes.")
        '
        'lblIDFederalTaxRate
        '
        Me.lblIDFederalTaxRate.AutoSize = True
        Me.lblIDFederalTaxRate.Location = New System.Drawing.Point(37, 116)
        Me.lblIDFederalTaxRate.Name = "lblIDFederalTaxRate"
        Me.lblIDFederalTaxRate.Size = New System.Drawing.Size(92, 13)
        Me.lblIDFederalTaxRate.TabIndex = 4
        Me.lblIDFederalTaxRate.Text = "&Federal Tax Rate:"
        Me.ToolTip1.SetToolTip(Me.lblIDFederalTaxRate, "Enter the percentage your country charges you for taxes.")
        '
        'lblIDNumberOfExemptions
        '
        Me.lblIDNumberOfExemptions.AutoSize = True
        Me.lblIDNumberOfExemptions.Location = New System.Drawing.Point(37, 160)
        Me.lblIDNumberOfExemptions.Name = "lblIDNumberOfExemptions"
        Me.lblIDNumberOfExemptions.Size = New System.Drawing.Size(116, 13)
        Me.lblIDNumberOfExemptions.TabIndex = 6
        Me.lblIDNumberOfExemptions.Text = "&Number of Exemptions:"
        Me.ToolTip1.SetToolTip(Me.lblIDNumberOfExemptions, "Enter your number of exemptions.")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(40, 243)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Press this button to activate the program.")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'chkAnnuity
        '
        Me.chkAnnuity.AutoSize = True
        Me.chkAnnuity.Location = New System.Drawing.Point(168, 200)
        Me.chkAnnuity.Name = "chkAnnuity"
        Me.chkAnnuity.Size = New System.Drawing.Size(88, 17)
        Me.chkAnnuity.TabIndex = 8
        Me.chkAnnuity.Text = "$100 &Annuity"
        Me.ToolTip1.SetToolTip(Me.chkAnnuity, "Check this box to show you have the Annuity")
        Me.chkAnnuity.UseVisualStyleBackColor = True
        '
        'txtStateTaxRate
        '
        Me.txtStateTaxRate.Location = New System.Drawing.Point(166, 68)
        Me.txtStateTaxRate.Name = "txtStateTaxRate"
        Me.txtStateTaxRate.Size = New System.Drawing.Size(100, 20)
        Me.txtStateTaxRate.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtStateTaxRate, "Enter a number from 0 to 30.")
        '
        'txtFederalTaxRate
        '
        Me.txtFederalTaxRate.Location = New System.Drawing.Point(166, 113)
        Me.txtFederalTaxRate.Name = "txtFederalTaxRate"
        Me.txtFederalTaxRate.Size = New System.Drawing.Size(100, 20)
        Me.txtFederalTaxRate.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtFederalTaxRate, "Enter a number from 0 to 25.")
        '
        'txtNumberOfExemptions
        '
        Me.txtNumberOfExemptions.Location = New System.Drawing.Point(166, 157)
        Me.txtNumberOfExemptions.Name = "txtNumberOfExemptions"
        Me.txtNumberOfExemptions.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfExemptions.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtNumberOfExemptions, "Enter a number from 0 to 12.")
        '
        'txtHourlyPay
        '
        Me.txtHourlyPay.Location = New System.Drawing.Point(166, 25)
        Me.txtHourlyPay.Name = "txtHourlyPay"
        Me.txtHourlyPay.Size = New System.Drawing.Size(100, 20)
        Me.txtHourlyPay.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtHourlyPay, "Enter a number from 6.55 to 100.")
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(354, 25)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(880, 277)
        Me.lstOutput.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.lstOutput, "This is where all your information is displayed after you run the program.")
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(168, 243)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Press this button to clear out all the fields in which you types.")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(168, 282)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Press this button to exit the program.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPayrollCalculator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1264, 322)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.txtHourlyPay)
        Me.Controls.Add(Me.txtNumberOfExemptions)
        Me.Controls.Add(Me.txtFederalTaxRate)
        Me.Controls.Add(Me.txtStateTaxRate)
        Me.Controls.Add(Me.chkAnnuity)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblIDNumberOfExemptions)
        Me.Controls.Add(Me.lblIDFederalTaxRate)
        Me.Controls.Add(Me.lblIDStateTaxRate)
        Me.Controls.Add(Me.lblIDHourlyPay)
        Me.Name = "frmPayrollCalculator"
        Me.Text = "Payroll Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIDHourlyPay As System.Windows.Forms.Label
    Friend WithEvents lblIDStateTaxRate As System.Windows.Forms.Label
    Friend WithEvents lblIDFederalTaxRate As System.Windows.Forms.Label
    Friend WithEvents lblIDNumberOfExemptions As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents chkAnnuity As System.Windows.Forms.CheckBox
    Friend WithEvents txtStateTaxRate As System.Windows.Forms.TextBox
    Friend WithEvents txtFederalTaxRate As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberOfExemptions As System.Windows.Forms.TextBox
    Friend WithEvents txtHourlyPay As System.Windows.Forms.TextBox
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
