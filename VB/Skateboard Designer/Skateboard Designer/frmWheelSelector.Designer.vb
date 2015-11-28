<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWheels
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
        Me.lblWheelColor = New System.Windows.Forms.Label()
        Me.btnChooseColor = New System.Windows.Forms.Button()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.rad61mm = New System.Windows.Forms.RadioButton()
        Me.rad58mm = New System.Windows.Forms.RadioButton()
        Me.rad55mm = New System.Windows.Forms.RadioButton()
        Me.rad51mm = New System.Windows.Forms.RadioButton()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.mnuDone = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWheels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWheelColor
        '
        Me.lblWheelColor.BackColor = System.Drawing.Color.Black
        Me.lblWheelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWheelColor.Location = New System.Drawing.Point(159, 54)
        Me.lblWheelColor.Name = "lblWheelColor"
        Me.lblWheelColor.Size = New System.Drawing.Size(104, 93)
        Me.lblWheelColor.TabIndex = 4
        '
        'btnChooseColor
        '
        Me.btnChooseColor.Location = New System.Drawing.Point(12, 192)
        Me.btnChooseColor.Name = "btnChooseColor"
        Me.btnChooseColor.Size = New System.Drawing.Size(72, 38)
        Me.btnChooseColor.TabIndex = 5
        Me.btnChooseColor.Text = "&Choose Color"
        Me.btnChooseColor.UseVisualStyleBackColor = True
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(101, 192)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(81, 38)
        Me.btnDefault.TabIndex = 6
        Me.btnDefault.Text = "&Black Wheels (Default)"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDone.Location = New System.Drawing.Point(197, 192)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 38)
        Me.btnDone.TabIndex = 7
        Me.btnDone.Text = "&Done With Wheels"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'rad61mm
        '
        Me.rad61mm.AutoSize = True
        Me.rad61mm.Location = New System.Drawing.Point(23, 148)
        Me.rad61mm.Name = "rad61mm"
        Me.rad61mm.Size = New System.Drawing.Size(83, 17)
        Me.rad61mm.TabIndex = 3
        Me.rad61mm.TabStop = True
        Me.rad61mm.Text = "&61 mm ($28)"
        Me.rad61mm.UseVisualStyleBackColor = True
        '
        'rad58mm
        '
        Me.rad58mm.AutoSize = True
        Me.rad58mm.Location = New System.Drawing.Point(23, 115)
        Me.rad58mm.Name = "rad58mm"
        Me.rad58mm.Size = New System.Drawing.Size(83, 17)
        Me.rad58mm.TabIndex = 2
        Me.rad58mm.TabStop = True
        Me.rad58mm.Text = "5&8 mm ($24)"
        Me.rad58mm.UseVisualStyleBackColor = True
        '
        'rad55mm
        '
        Me.rad55mm.AutoSize = True
        Me.rad55mm.Location = New System.Drawing.Point(23, 86)
        Me.rad55mm.Name = "rad55mm"
        Me.rad55mm.Size = New System.Drawing.Size(83, 17)
        Me.rad55mm.TabIndex = 1
        Me.rad55mm.TabStop = True
        Me.rad55mm.Text = "&55 mm ($22)"
        Me.rad55mm.UseVisualStyleBackColor = True
        '
        'rad51mm
        '
        Me.rad51mm.AutoSize = True
        Me.rad51mm.Location = New System.Drawing.Point(23, 54)
        Me.rad51mm.Name = "rad51mm"
        Me.rad51mm.Size = New System.Drawing.Size(83, 17)
        Me.rad51mm.TabIndex = 0
        Me.rad51mm.TabStop = True
        Me.rad51mm.Text = "5&1 mm ($20)"
        Me.rad51mm.UseVisualStyleBackColor = True
        '
        'MenuBar
        '
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDone, Me.mnuWheels, Me.mnuColor})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(284, 24)
        Me.MenuBar.TabIndex = 8
        Me.MenuBar.Text = "MenuStrip1"
        '
        'mnuDone
        '
        Me.mnuDone.Name = "mnuDone"
        Me.mnuDone.Size = New System.Drawing.Size(47, 20)
        Me.mnuDone.Text = "D&one"
        '
        'mnuWheels
        '
        Me.mnuWheels.Name = "mnuWheels"
        Me.mnuWheels.Size = New System.Drawing.Size(57, 20)
        Me.mnuWheels.Text = "&Wheels"
        '
        'mnuColor
        '
        Me.mnuColor.Name = "mnuColor"
        Me.mnuColor.Size = New System.Drawing.Size(48, 20)
        Me.mnuColor.Text = "Co&lor"
        '
        'frmWheels
        '
        Me.AcceptButton = Me.btnChooseColor
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnDone
        Me.ClientSize = New System.Drawing.Size(284, 245)
        Me.Controls.Add(Me.rad51mm)
        Me.Controls.Add(Me.rad55mm)
        Me.Controls.Add(Me.rad58mm)
        Me.Controls.Add(Me.rad61mm)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.btnChooseColor)
        Me.Controls.Add(Me.lblWheelColor)
        Me.Controls.Add(Me.MenuBar)
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "frmWheels"
        Me.Text = "Wheel Selector"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWheelColor As System.Windows.Forms.Label
    Friend WithEvents btnChooseColor As System.Windows.Forms.Button
    Friend WithEvents btnDefault As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents rad61mm As System.Windows.Forms.RadioButton
    Friend WithEvents rad58mm As System.Windows.Forms.RadioButton
    Friend WithEvents rad55mm As System.Windows.Forms.RadioButton
    Friend WithEvents rad51mm As System.Windows.Forms.RadioButton
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuDone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWheels As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
End Class
