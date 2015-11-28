<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMiscellaneous
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
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.mnuDone = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkGripTape = New System.Windows.Forms.CheckBox()
        Me.chkBearings = New System.Windows.Forms.CheckBox()
        Me.chkRiserPads = New System.Windows.Forms.CheckBox()
        Me.chkNutsAndBoltsKit = New System.Windows.Forms.CheckBox()
        Me.chkAssembly = New System.Windows.Forms.CheckBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuBar
        '
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDone})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(158, 24)
        Me.MenuBar.TabIndex = 6
        Me.MenuBar.Text = "MenuStrip1"
        '
        'mnuDone
        '
        Me.mnuDone.Name = "mnuDone"
        Me.mnuDone.Size = New System.Drawing.Size(47, 20)
        Me.mnuDone.Text = "D&one"
        '
        'chkGripTape
        '
        Me.chkGripTape.AutoSize = True
        Me.chkGripTape.Location = New System.Drawing.Point(25, 57)
        Me.chkGripTape.Name = "chkGripTape"
        Me.chkGripTape.Size = New System.Drawing.Size(100, 17)
        Me.chkGripTape.TabIndex = 0
        Me.chkGripTape.Text = "&Grip Tape ($10)"
        Me.chkGripTape.UseVisualStyleBackColor = True
        '
        'chkBearings
        '
        Me.chkBearings.AutoSize = True
        Me.chkBearings.Location = New System.Drawing.Point(25, 90)
        Me.chkBearings.Name = "chkBearings"
        Me.chkBearings.Size = New System.Drawing.Size(94, 17)
        Me.chkBearings.TabIndex = 1
        Me.chkBearings.Text = "&Bearings ($30)"
        Me.chkBearings.UseVisualStyleBackColor = True
        '
        'chkRiserPads
        '
        Me.chkRiserPads.AutoSize = True
        Me.chkRiserPads.Location = New System.Drawing.Point(25, 124)
        Me.chkRiserPads.Name = "chkRiserPads"
        Me.chkRiserPads.Size = New System.Drawing.Size(98, 17)
        Me.chkRiserPads.TabIndex = 2
        Me.chkRiserPads.Text = "&Riser Pads ($2)"
        Me.chkRiserPads.UseVisualStyleBackColor = True
        '
        'chkNutsAndBoltsKit
        '
        Me.chkNutsAndBoltsKit.AutoSize = True
        Me.chkNutsAndBoltsKit.Location = New System.Drawing.Point(25, 157)
        Me.chkNutsAndBoltsKit.Name = "chkNutsAndBoltsKit"
        Me.chkNutsAndBoltsKit.Size = New System.Drawing.Size(119, 17)
        Me.chkNutsAndBoltsKit.TabIndex = 3
        Me.chkNutsAndBoltsKit.Text = "&Nuts && Bolts Kit ($3)"
        Me.chkNutsAndBoltsKit.UseVisualStyleBackColor = True
        '
        'chkAssembly
        '
        Me.chkAssembly.AutoSize = True
        Me.chkAssembly.Location = New System.Drawing.Point(25, 191)
        Me.chkAssembly.Name = "chkAssembly"
        Me.chkAssembly.Size = New System.Drawing.Size(97, 17)
        Me.chkAssembly.TabIndex = 4
        Me.chkAssembly.Text = "&Assembly ($10)"
        Me.chkAssembly.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDone.Location = New System.Drawing.Point(44, 236)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 5
        Me.btnDone.Text = "&Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'frmMiscellaneous
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnDone
        Me.ClientSize = New System.Drawing.Size(158, 271)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.chkAssembly)
        Me.Controls.Add(Me.chkNutsAndBoltsKit)
        Me.Controls.Add(Me.chkRiserPads)
        Me.Controls.Add(Me.chkBearings)
        Me.Controls.Add(Me.chkGripTape)
        Me.Controls.Add(Me.MenuBar)
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "frmMiscellaneous"
        Me.Text = "Miscellaneous"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents chkGripTape As System.Windows.Forms.CheckBox
    Friend WithEvents chkBearings As System.Windows.Forms.CheckBox
    Friend WithEvents chkRiserPads As System.Windows.Forms.CheckBox
    Friend WithEvents chkNutsAndBoltsKit As System.Windows.Forms.CheckBox
    Friend WithEvents chkAssembly As System.Windows.Forms.CheckBox
    Friend WithEvents mnuDone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDone As System.Windows.Forms.Button
End Class
