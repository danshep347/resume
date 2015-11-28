<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTruckAssemblies
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
        Me.rad7_75Axle = New System.Windows.Forms.RadioButton()
        Me.rad8Axle = New System.Windows.Forms.RadioButton()
        Me.rad8_5Axle = New System.Windows.Forms.RadioButton()
        Me.lblTruckColor = New System.Windows.Forms.Label()
        Me.btnChooseColor = New System.Windows.Forms.Button()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.mnuDone = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTruck = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'rad7_75Axle
        '
        Me.rad7_75Axle.AutoSize = True
        Me.rad7_75Axle.Location = New System.Drawing.Point(22, 52)
        Me.rad7_75Axle.Name = "rad7_75Axle"
        Me.rad7_75Axle.Size = New System.Drawing.Size(95, 17)
        Me.rad7_75Axle.TabIndex = 0
        Me.rad7_75Axle.TabStop = True
        Me.rad7_75Axle.Text = "7.75 &axle ($35)"
        Me.rad7_75Axle.UseVisualStyleBackColor = True
        '
        'rad8Axle
        '
        Me.rad8Axle.AutoSize = True
        Me.rad8Axle.Location = New System.Drawing.Point(22, 86)
        Me.rad8Axle.Name = "rad8Axle"
        Me.rad8Axle.Size = New System.Drawing.Size(80, 17)
        Me.rad8Axle.TabIndex = 1
        Me.rad8Axle.TabStop = True
        Me.rad8Axle.Text = "8 a&xle ($40)"
        Me.rad8Axle.UseVisualStyleBackColor = True
        '
        'rad8_5Axle
        '
        Me.rad8_5Axle.AutoSize = True
        Me.rad8_5Axle.Location = New System.Drawing.Point(22, 120)
        Me.rad8_5Axle.Name = "rad8_5Axle"
        Me.rad8_5Axle.Size = New System.Drawing.Size(89, 17)
        Me.rad8_5Axle.TabIndex = 2
        Me.rad8_5Axle.TabStop = True
        Me.rad8_5Axle.Text = "8.5 ax&le ($45)"
        Me.rad8_5Axle.UseVisualStyleBackColor = True
        '
        'lblTruckColor
        '
        Me.lblTruckColor.BackColor = System.Drawing.Color.Silver
        Me.lblTruckColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTruckColor.Location = New System.Drawing.Point(158, 52)
        Me.lblTruckColor.Name = "lblTruckColor"
        Me.lblTruckColor.Size = New System.Drawing.Size(104, 93)
        Me.lblTruckColor.TabIndex = 3
        '
        'btnChooseColor
        '
        Me.btnChooseColor.Location = New System.Drawing.Point(12, 179)
        Me.btnChooseColor.Name = "btnChooseColor"
        Me.btnChooseColor.Size = New System.Drawing.Size(72, 38)
        Me.btnChooseColor.TabIndex = 4
        Me.btnChooseColor.Text = "Choose &Color"
        Me.btnChooseColor.UseVisualStyleBackColor = True
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(100, 179)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(78, 38)
        Me.btnDefault.TabIndex = 5
        Me.btnDefault.Text = "&Silver Truck (Default)"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDone.Location = New System.Drawing.Point(197, 179)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 38)
        Me.btnDone.TabIndex = 6
        Me.btnDone.Text = "&Done With Truck"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'MenuBar
        '
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDone, Me.mnuTruck, Me.mnuColor})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(284, 24)
        Me.MenuBar.TabIndex = 7
        Me.MenuBar.Text = "MenuStrip1"
        '
        'mnuDone
        '
        Me.mnuDone.Name = "mnuDone"
        Me.mnuDone.Size = New System.Drawing.Size(47, 20)
        Me.mnuDone.Text = "D&one"
        '
        'mnuTruck
        '
        Me.mnuTruck.Name = "mnuTruck"
        Me.mnuTruck.Size = New System.Drawing.Size(49, 20)
        Me.mnuTruck.Text = "T&ruck"
        '
        'mnuColor
        '
        Me.mnuColor.Name = "mnuColor"
        Me.mnuColor.Size = New System.Drawing.Size(48, 20)
        Me.mnuColor.Text = "Co&lor"
        '
        'frmTruckAssemblies
        '
        Me.AcceptButton = Me.btnChooseColor
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnDone
        Me.ClientSize = New System.Drawing.Size(284, 234)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.btnChooseColor)
        Me.Controls.Add(Me.lblTruckColor)
        Me.Controls.Add(Me.rad8_5Axle)
        Me.Controls.Add(Me.rad8Axle)
        Me.Controls.Add(Me.rad7_75Axle)
        Me.Controls.Add(Me.MenuBar)
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "frmTruckAssemblies"
        Me.Text = "Truck Assemblies"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rad7_75Axle As System.Windows.Forms.RadioButton
    Friend WithEvents rad8Axle As System.Windows.Forms.RadioButton
    Friend WithEvents rad8_5Axle As System.Windows.Forms.RadioButton
    Friend WithEvents lblTruckColor As System.Windows.Forms.Label
    Friend WithEvents btnChooseColor As System.Windows.Forms.Button
    Friend WithEvents btnDefault As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuDone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTruck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
End Class
