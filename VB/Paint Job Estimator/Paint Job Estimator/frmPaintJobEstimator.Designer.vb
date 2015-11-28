<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaintJobEstimator
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
        Me.lblIDNumberOfRooms = New System.Windows.Forms.Label()
        Me.lblIDCostOfPaint = New System.Windows.Forms.Label()
        Me.txtNumberOfRooms = New System.Windows.Forms.TextBox()
        Me.txtCostOfPaint = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblIDNumberOfRooms
        '
        Me.lblIDNumberOfRooms.AutoSize = True
        Me.lblIDNumberOfRooms.Location = New System.Drawing.Point(19, 31)
        Me.lblIDNumberOfRooms.Name = "lblIDNumberOfRooms"
        Me.lblIDNumberOfRooms.Size = New System.Drawing.Size(90, 13)
        Me.lblIDNumberOfRooms.TabIndex = 0
        Me.lblIDNumberOfRooms.Text = "Number of &rooms:"
        '
        'lblIDCostOfPaint
        '
        Me.lblIDCostOfPaint.AutoSize = True
        Me.lblIDCostOfPaint.Location = New System.Drawing.Point(19, 77)
        Me.lblIDCostOfPaint.Name = "lblIDCostOfPaint"
        Me.lblIDCostOfPaint.Size = New System.Drawing.Size(69, 13)
        Me.lblIDCostOfPaint.TabIndex = 2
        Me.lblIDCostOfPaint.Text = "Cost of &paint:"
        '
        'txtNumberOfRooms
        '
        Me.txtNumberOfRooms.Location = New System.Drawing.Point(159, 28)
        Me.txtNumberOfRooms.Name = "txtNumberOfRooms"
        Me.txtNumberOfRooms.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfRooms.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtNumberOfRooms, "Please enter the number of rooms you wish to paint.")
        '
        'txtCostOfPaint
        '
        Me.txtCostOfPaint.Location = New System.Drawing.Point(159, 74)
        Me.txtCostOfPaint.Name = "txtCostOfPaint"
        Me.txtCostOfPaint.Size = New System.Drawing.Size(100, 20)
        Me.txtCostOfPaint.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtCostOfPaint, "Please enter the cost of paint per gallon.")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(90, 159)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(106, 31)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Click this button to calculate.")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(22, 218)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 32)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Click this button to clear the fields.")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(163, 218)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 32)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click this button to exit the program.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 14
        Me.lstOutput.Location = New System.Drawing.Point(292, 12)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(473, 228)
        Me.lstOutput.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.lstOutput, "This is where the output will be displayed.")
        '
        'frmPaintJobEstimator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(777, 262)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCostOfPaint)
        Me.Controls.Add(Me.txtNumberOfRooms)
        Me.Controls.Add(Me.lblIDCostOfPaint)
        Me.Controls.Add(Me.lblIDNumberOfRooms)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmPaintJobEstimator"
        Me.Text = "Paint Job Estimator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIDNumberOfRooms As System.Windows.Forms.Label
    Friend WithEvents lblIDCostOfPaint As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfRooms As System.Windows.Forms.TextBox
    Friend WithEvents txtCostOfPaint As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
