<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipCalculator
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
        Me.lblIDBill = New System.Windows.Forms.Label()
        Me.lblIDPercent = New System.Windows.Forms.Label()
        Me.txtBill = New System.Windows.Forms.TextBox()
        Me.txtPercent = New System.Windows.Forms.TextBox()
        Me.lblIDTip = New System.Windows.Forms.Label()
        Me.lblTip = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIDBill
        '
        Me.lblIDBill.AutoSize = True
        Me.lblIDBill.Location = New System.Drawing.Point(53, 38)
        Me.lblIDBill.Name = "lblIDBill"
        Me.lblIDBill.Size = New System.Drawing.Size(20, 13)
        Me.lblIDBill.TabIndex = 0
        Me.lblIDBill.Text = "Bill"
        '
        'lblIDPercent
        '
        Me.lblIDPercent.AutoSize = True
        Me.lblIDPercent.Location = New System.Drawing.Point(53, 86)
        Me.lblIDPercent.Name = "lblIDPercent"
        Me.lblIDPercent.Size = New System.Drawing.Size(44, 13)
        Me.lblIDPercent.TabIndex = 1
        Me.lblIDPercent.Text = "Percent"
        '
        'txtBill
        '
        Me.txtBill.Location = New System.Drawing.Point(154, 38)
        Me.txtBill.Name = "txtBill"
        Me.txtBill.Size = New System.Drawing.Size(100, 20)
        Me.txtBill.TabIndex = 2
        '
        'txtPercent
        '
        Me.txtPercent.Location = New System.Drawing.Point(154, 86)
        Me.txtPercent.Name = "txtPercent"
        Me.txtPercent.Size = New System.Drawing.Size(100, 20)
        Me.txtPercent.TabIndex = 3
        '
        'lblIDTip
        '
        Me.lblIDTip.AutoSize = True
        Me.lblIDTip.Location = New System.Drawing.Point(53, 137)
        Me.lblIDTip.Name = "lblIDTip"
        Me.lblIDTip.Size = New System.Drawing.Size(22, 13)
        Me.lblIDTip.TabIndex = 4
        Me.lblIDTip.Text = "Tip"
        '
        'lblTip
        '
        Me.lblTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTip.Location = New System.Drawing.Point(154, 137)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(100, 24)
        Me.lblTip.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(27, 193)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(65, 48)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(223, 193)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 48)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(127, 193)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(59, 48)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmTipCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 265)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.lblIDTip)
        Me.Controls.Add(Me.txtPercent)
        Me.Controls.Add(Me.txtBill)
        Me.Controls.Add(Me.lblIDPercent)
        Me.Controls.Add(Me.lblIDBill)
        Me.Name = "frmTipCalculator"
        Me.Text = "Tip Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIDBill As System.Windows.Forms.Label
    Friend WithEvents lblIDPercent As System.Windows.Forms.Label
    Friend WithEvents txtBill As System.Windows.Forms.TextBox
    Friend WithEvents txtPercent As System.Windows.Forms.TextBox
    Friend WithEvents lblIDTip As System.Windows.Forms.Label
    Friend WithEvents lblTip As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
