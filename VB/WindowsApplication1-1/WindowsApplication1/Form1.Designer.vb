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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtMonthlyBudget = New System.Windows.Forms.TextBox()
        Me.lblIDOutput = New System.Windows.Forms.Label()
        Me.lblMonthlyBudget = New System.Windows.Forms.Label()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(41, 207)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Location = New System.Drawing.Point(159, 126)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblOutput.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(159, 207)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtMonthlyBudget
        '
        Me.txtMonthlyBudget.Location = New System.Drawing.Point(159, 49)
        Me.txtMonthlyBudget.Name = "txtMonthlyBudget"
        Me.txtMonthlyBudget.Size = New System.Drawing.Size(100, 20)
        Me.txtMonthlyBudget.TabIndex = 3
        '
        'lblIDOutput
        '
        Me.lblIDOutput.AutoSize = True
        Me.lblIDOutput.Location = New System.Drawing.Point(38, 136)
        Me.lblIDOutput.Name = "lblIDOutput"
        Me.lblIDOutput.Size = New System.Drawing.Size(60, 13)
        Me.lblIDOutput.TabIndex = 4
        Me.lblIDOutput.Text = "Amount left"
        '
        'lblMonthlyBudget
        '
        Me.lblMonthlyBudget.AutoSize = True
        Me.lblMonthlyBudget.Location = New System.Drawing.Point(38, 52)
        Me.lblMonthlyBudget.Name = "lblMonthlyBudget"
        Me.lblMonthlyBudget.Size = New System.Drawing.Size(81, 13)
        Me.lblMonthlyBudget.TabIndex = 5
        Me.lblMonthlyBudget.Text = "Monthly Budget"
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(332, 34)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(220, 199)
        Me.lstOutput.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 262)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.lblMonthlyBudget)
        Me.Controls.Add(Me.lblIDOutput)
        Me.Controls.Add(Me.txtMonthlyBudget)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtMonthlyBudget As System.Windows.Forms.TextBox
    Friend WithEvents lblIDOutput As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyBudget As System.Windows.Forms.Label
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox

End Class
