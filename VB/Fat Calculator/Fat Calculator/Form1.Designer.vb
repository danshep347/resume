<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatCalculator
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblIDCalories = New System.Windows.Forms.Label()
        Me.txtCalories = New System.Windows.Forms.TextBox()
        Me.lblIDFat = New System.Windows.Forms.Label()
        Me.lblIDPCalories = New System.Windows.Forms.Label()
        Me.lblPCalories = New System.Windows.Forms.Label()
        Me.txtFat = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(35, 281)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblIDCalories
        '
        Me.lblIDCalories.AutoSize = True
        Me.lblIDCalories.Location = New System.Drawing.Point(61, 54)
        Me.lblIDCalories.Name = "lblIDCalories"
        Me.lblIDCalories.Size = New System.Drawing.Size(195, 13)
        Me.lblIDCalories.TabIndex = 0
        Me.lblIDCalories.Text = "Enter the &number of calories in the food:"
        '
        'txtCalories
        '
        Me.txtCalories.Location = New System.Drawing.Point(341, 51)
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.Size = New System.Drawing.Size(100, 20)
        Me.txtCalories.TabIndex = 1
        '
        'lblIDFat
        '
        Me.lblIDFat.AutoSize = True
        Me.lblIDFat.Location = New System.Drawing.Point(61, 117)
        Me.lblIDFat.Name = "lblIDFat"
        Me.lblIDFat.Size = New System.Drawing.Size(202, 13)
        Me.lblIDFat.TabIndex = 2
        Me.lblIDFat.Text = "Enter the number of &fat grams in the food:"
        '
        'lblIDPCalories
        '
        Me.lblIDPCalories.AutoSize = True
        Me.lblIDPCalories.Location = New System.Drawing.Point(61, 193)
        Me.lblIDPCalories.Name = "lblIDPCalories"
        Me.lblIDPCalories.Size = New System.Drawing.Size(204, 13)
        Me.lblIDPCalories.TabIndex = 4
        Me.lblIDPCalories.Text = "Percentage of calories that come from fat:"
        '
        'lblPCalories
        '
        Me.lblPCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPCalories.Location = New System.Drawing.Point(341, 192)
        Me.lblPCalories.Name = "lblPCalories"
        Me.lblPCalories.Size = New System.Drawing.Size(100, 20)
        Me.lblPCalories.TabIndex = 5
        '
        'txtFat
        '
        Me.txtFat.Location = New System.Drawing.Point(341, 114)
        Me.txtFat.Name = "txtFat"
        Me.txtFat.Size = New System.Drawing.Size(100, 20)
        Me.txtFat.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(247, 281)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(137, 281)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(370, 281)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(71, 23)
        Me.lblMessage.TabIndex = 9
        '
        'frmFatCalculator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(484, 335)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtFat)
        Me.Controls.Add(Me.lblPCalories)
        Me.Controls.Add(Me.lblIDPCalories)
        Me.Controls.Add(Me.lblIDFat)
        Me.Controls.Add(Me.txtCalories)
        Me.Controls.Add(Me.lblIDCalories)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmFatCalculator"
        Me.Text = "Fat Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblIDCalories As System.Windows.Forms.Label
    Friend WithEvents txtCalories As System.Windows.Forms.TextBox
    Friend WithEvents lblIDFat As System.Windows.Forms.Label
    Friend WithEvents lblIDPCalories As System.Windows.Forms.Label
    Friend WithEvents lblPCalories As System.Windows.Forms.Label
    Friend WithEvents txtFat As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class
