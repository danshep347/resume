<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummervilleTelephoneCompany
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
        Me.lblIDName = New System.Windows.Forms.Label()
        Me.lblIDMinimum = New System.Windows.Forms.Label()
        Me.lblIDMaximum = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cboMinimum = New System.Windows.Forms.ComboBox()
        Me.cboMaximum = New System.Windows.Forms.ComboBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblIDName
        '
        Me.lblIDName.AutoSize = True
        Me.lblIDName.Location = New System.Drawing.Point(41, 39)
        Me.lblIDName.Name = "lblIDName"
        Me.lblIDName.Size = New System.Drawing.Size(38, 13)
        Me.lblIDName.TabIndex = 0
        Me.lblIDName.Text = "&Name:"
        '
        'lblIDMinimum
        '
        Me.lblIDMinimum.AutoSize = True
        Me.lblIDMinimum.Location = New System.Drawing.Point(41, 86)
        Me.lblIDMinimum.Name = "lblIDMinimum"
        Me.lblIDMinimum.Size = New System.Drawing.Size(51, 13)
        Me.lblIDMinimum.TabIndex = 2
        Me.lblIDMinimum.Text = "M&inimum:"
        '
        'lblIDMaximum
        '
        Me.lblIDMaximum.AutoSize = True
        Me.lblIDMaximum.Location = New System.Drawing.Point(41, 131)
        Me.lblIDMaximum.Name = "lblIDMaximum"
        Me.lblIDMaximum.Size = New System.Drawing.Size(54, 13)
        Me.lblIDMaximum.TabIndex = 4
        Me.lblIDMaximum.Text = "M&aximum:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(119, 36)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 20)
        Me.txtName.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtName, "Please enter your name")
        '
        'cboMinimum
        '
        Me.cboMinimum.FormattingEnabled = True
        Me.cboMinimum.Items.AddRange(New Object() {"5", "10", "15", "20"})
        Me.cboMinimum.Location = New System.Drawing.Point(119, 83)
        Me.cboMinimum.Name = "cboMinimum"
        Me.cboMinimum.Size = New System.Drawing.Size(121, 21)
        Me.cboMinimum.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.cboMinimum, "Please enter the minimum number of minutes")
        '
        'cboMaximum
        '
        Me.cboMaximum.FormattingEnabled = True
        Me.cboMaximum.Items.AddRange(New Object() {"25", "35", "45", "55"})
        Me.cboMaximum.Location = New System.Drawing.Point(119, 128)
        Me.cboMaximum.Name = "cboMaximum"
        Me.cboMaximum.Size = New System.Drawing.Size(121, 21)
        Me.cboMaximum.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.cboMaximum, "Please enter a maximum number of minutes")
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(320, 36)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(207, 199)
        Me.lstOutput.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.lstOutput, "This is where the costs will display")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(27, 204)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(68, 35)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Press this button to display the costs of minutes")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(213, 204)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(68, 35)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Press this button to close the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(119, 204)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(68, 35)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Press this button to clear the display")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmSummervilleTelephoneCompany
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(568, 266)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.cboMaximum)
        Me.Controls.Add(Me.cboMinimum)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblIDMaximum)
        Me.Controls.Add(Me.lblIDMinimum)
        Me.Controls.Add(Me.lblIDName)
        Me.Name = "frmSummervilleTelephoneCompany"
        Me.Text = "Summerville Telephone Company"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIDName As System.Windows.Forms.Label
    Friend WithEvents lblIDMinimum As System.Windows.Forms.Label
    Friend WithEvents lblIDMaximum As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents cboMinimum As System.Windows.Forms.ComboBox
    Friend WithEvents cboMaximum As System.Windows.Forms.ComboBox
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
