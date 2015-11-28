<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizzaSliceCalculator
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
        Me.lblPizzaDiameter = New System.Windows.Forms.Label()
        Me.cboDiameter = New System.Windows.Forms.ComboBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblPizzaDiameter
        '
        Me.lblPizzaDiameter.AutoSize = True
        Me.lblPizzaDiameter.Location = New System.Drawing.Point(64, 79)
        Me.lblPizzaDiameter.Name = "lblPizzaDiameter"
        Me.lblPizzaDiameter.Size = New System.Drawing.Size(75, 13)
        Me.lblPizzaDiameter.TabIndex = 0
        Me.lblPizzaDiameter.Text = "&Pizza diameter"
        '
        'cboDiameter
        '
        Me.cboDiameter.FormattingEnabled = True
        Me.cboDiameter.Items.AddRange(New Object() {"5", "10", "15", "20", "25"})
        Me.cboDiameter.Location = New System.Drawing.Point(42, 115)
        Me.cboDiameter.Name = "cboDiameter"
        Me.cboDiameter.Size = New System.Drawing.Size(121, 21)
        Me.cboDiameter.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cboDiameter, "Please enter the starting value for pizza diameter")
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 14
        Me.lstOutput.Location = New System.Drawing.Point(200, 25)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(369, 186)
        Me.lstOutput.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.lstOutput, "This is where the answer is displayed")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(42, 251)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(82, 38)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Click on this button to display the answer")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(261, 251)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 38)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Click this button to clear the fields")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(487, 251)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 38)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click this button to exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPizzaSliceCalculator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(615, 321)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.cboDiameter)
        Me.Controls.Add(Me.lblPizzaDiameter)
        Me.Name = "frmPizzaSliceCalculator"
        Me.Text = "Pizza Slice Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPizzaDiameter As System.Windows.Forms.Label
    Friend WithEvents cboDiameter As System.Windows.Forms.ComboBox
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
