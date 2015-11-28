<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSkateboardDesigner
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
        Me.grpSkateboardParts = New System.Windows.Forms.GroupBox()
        Me.btnChooseMiscellaneous = New System.Windows.Forms.Button()
        Me.btnChooseWheels = New System.Windows.Forms.Button()
        Me.btnChooseTruckAssembly = New System.Windows.Forms.Button()
        Me.btnChooseDeck = New System.Windows.Forms.Button()
        Me.grpSkateboardCost = New System.Windows.Forms.GroupBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblTaxAmount = New System.Windows.Forms.Label()
        Me.lblIDTotalCost = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblIDTaxAmount = New System.Windows.Forms.Label()
        Me.lblIDSubtotal = New System.Windows.Forms.Label()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.grpDeckColor = New System.Windows.Forms.GroupBox()
        Me.lblDeckColor = New System.Windows.Forms.Label()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.mnuDone = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDecks = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTrucks = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWheels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMiscellaneous = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpExtraButtons = New System.Windows.Forms.GroupBox()
        Me.grpSkateboardParts.SuspendLayout()
        Me.grpSkateboardCost.SuspendLayout()
        Me.grpDeckColor.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.grpExtraButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSkateboardParts
        '
        Me.grpSkateboardParts.Controls.Add(Me.btnChooseMiscellaneous)
        Me.grpSkateboardParts.Controls.Add(Me.btnChooseWheels)
        Me.grpSkateboardParts.Controls.Add(Me.btnChooseTruckAssembly)
        Me.grpSkateboardParts.Controls.Add(Me.btnChooseDeck)
        Me.grpSkateboardParts.Location = New System.Drawing.Point(12, 27)
        Me.grpSkateboardParts.Name = "grpSkateboardParts"
        Me.grpSkateboardParts.Size = New System.Drawing.Size(181, 188)
        Me.grpSkateboardParts.TabIndex = 0
        Me.grpSkateboardParts.TabStop = False
        '
        'btnChooseMiscellaneous
        '
        Me.btnChooseMiscellaneous.Location = New System.Drawing.Point(19, 144)
        Me.btnChooseMiscellaneous.Name = "btnChooseMiscellaneous"
        Me.btnChooseMiscellaneous.Size = New System.Drawing.Size(138, 23)
        Me.btnChooseMiscellaneous.TabIndex = 3
        Me.btnChooseMiscellaneous.Text = "Choose &Miscellaneous"
        Me.btnChooseMiscellaneous.UseVisualStyleBackColor = True
        '
        'btnChooseWheels
        '
        Me.btnChooseWheels.Location = New System.Drawing.Point(19, 106)
        Me.btnChooseWheels.Name = "btnChooseWheels"
        Me.btnChooseWheels.Size = New System.Drawing.Size(138, 23)
        Me.btnChooseWheels.TabIndex = 2
        Me.btnChooseWheels.Text = "Choose &Wheels"
        Me.btnChooseWheels.UseVisualStyleBackColor = True
        '
        'btnChooseTruckAssembly
        '
        Me.btnChooseTruckAssembly.Location = New System.Drawing.Point(19, 68)
        Me.btnChooseTruckAssembly.Name = "btnChooseTruckAssembly"
        Me.btnChooseTruckAssembly.Size = New System.Drawing.Size(138, 23)
        Me.btnChooseTruckAssembly.TabIndex = 1
        Me.btnChooseTruckAssembly.Text = "Choose &Truck Assy"
        Me.btnChooseTruckAssembly.UseVisualStyleBackColor = True
        '
        'btnChooseDeck
        '
        Me.btnChooseDeck.Location = New System.Drawing.Point(19, 30)
        Me.btnChooseDeck.Name = "btnChooseDeck"
        Me.btnChooseDeck.Size = New System.Drawing.Size(138, 23)
        Me.btnChooseDeck.TabIndex = 0
        Me.btnChooseDeck.Text = "Choose &Deck"
        Me.btnChooseDeck.UseVisualStyleBackColor = True
        '
        'grpSkateboardCost
        '
        Me.grpSkateboardCost.Controls.Add(Me.lblTotalCost)
        Me.grpSkateboardCost.Controls.Add(Me.lblTaxAmount)
        Me.grpSkateboardCost.Controls.Add(Me.lblIDTotalCost)
        Me.grpSkateboardCost.Controls.Add(Me.lblSubtotal)
        Me.grpSkateboardCost.Controls.Add(Me.lblIDTaxAmount)
        Me.grpSkateboardCost.Controls.Add(Me.lblIDSubtotal)
        Me.grpSkateboardCost.Location = New System.Drawing.Point(12, 243)
        Me.grpSkateboardCost.Name = "grpSkateboardCost"
        Me.grpSkateboardCost.Size = New System.Drawing.Size(205, 137)
        Me.grpSkateboardCost.TabIndex = 2
        Me.grpSkateboardCost.TabStop = False
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCost.Location = New System.Drawing.Point(118, 97)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(63, 22)
        Me.lblTotalCost.TabIndex = 5
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTaxAmount.Location = New System.Drawing.Point(118, 65)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(63, 22)
        Me.lblTaxAmount.TabIndex = 3
        '
        'lblIDTotalCost
        '
        Me.lblIDTotalCost.AutoSize = True
        Me.lblIDTotalCost.Location = New System.Drawing.Point(16, 98)
        Me.lblIDTotalCost.Name = "lblIDTotalCost"
        Me.lblIDTotalCost.Size = New System.Drawing.Size(58, 13)
        Me.lblIDTotalCost.TabIndex = 4
        Me.lblIDTotalCost.Text = "Total Cost:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.Location = New System.Drawing.Point(118, 32)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(63, 22)
        Me.lblSubtotal.TabIndex = 1
        '
        'lblIDTaxAmount
        '
        Me.lblIDTaxAmount.AutoSize = True
        Me.lblIDTaxAmount.Location = New System.Drawing.Point(16, 66)
        Me.lblIDTaxAmount.Name = "lblIDTaxAmount"
        Me.lblIDTaxAmount.Size = New System.Drawing.Size(67, 13)
        Me.lblIDTaxAmount.TabIndex = 2
        Me.lblIDTaxAmount.Text = "Tax Amount:"
        '
        'lblIDSubtotal
        '
        Me.lblIDSubtotal.AutoSize = True
        Me.lblIDSubtotal.Location = New System.Drawing.Point(16, 33)
        Me.lblIDSubtotal.Name = "lblIDSubtotal"
        Me.lblIDSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.lblIDSubtotal.TabIndex = 0
        Me.lblIDSubtotal.Text = "Subtotal:"
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(267, 42)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(563, 173)
        Me.lstOutput.TabIndex = 1
        '
        'grpDeckColor
        '
        Me.grpDeckColor.Controls.Add(Me.lblDeckColor)
        Me.grpDeckColor.Location = New System.Drawing.Point(267, 246)
        Me.grpDeckColor.Name = "grpDeckColor"
        Me.grpDeckColor.Size = New System.Drawing.Size(131, 134)
        Me.grpDeckColor.TabIndex = 3
        Me.grpDeckColor.TabStop = False
        Me.grpDeckColor.Text = "Deck Color"
        '
        'lblDeckColor
        '
        Me.lblDeckColor.BackColor = System.Drawing.Color.Black
        Me.lblDeckColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDeckColor.Location = New System.Drawing.Point(15, 20)
        Me.lblDeckColor.Name = "lblDeckColor"
        Me.lblDeckColor.Size = New System.Drawing.Size(100, 104)
        Me.lblDeckColor.TabIndex = 0
        '
        'MenuBar
        '
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDone, Me.mnuDecks, Me.mnuTrucks, Me.mnuWheels, Me.mnuMiscellaneous})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(842, 24)
        Me.MenuBar.TabIndex = 5
        Me.MenuBar.Text = "MenuStrip1"
        '
        'mnuDone
        '
        Me.mnuDone.Name = "mnuDone"
        Me.mnuDone.Size = New System.Drawing.Size(47, 20)
        Me.mnuDone.Text = "D&one"
        '
        'mnuDecks
        '
        Me.mnuDecks.Name = "mnuDecks"
        Me.mnuDecks.Size = New System.Drawing.Size(50, 20)
        Me.mnuDecks.Text = "D&ecks"
        '
        'mnuTrucks
        '
        Me.mnuTrucks.Name = "mnuTrucks"
        Me.mnuTrucks.Size = New System.Drawing.Size(54, 20)
        Me.mnuTrucks.Text = "Tr&ucks"
        '
        'mnuWheels
        '
        Me.mnuWheels.Name = "mnuWheels"
        Me.mnuWheels.Size = New System.Drawing.Size(57, 20)
        Me.mnuWheels.Text = "W&heels"
        '
        'mnuMiscellaneous
        '
        Me.mnuMiscellaneous.Name = "mnuMiscellaneous"
        Me.mnuMiscellaneous.Size = New System.Drawing.Size(44, 20)
        Me.mnuMiscellaneous.Text = "M&isc"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(19, 32)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 34)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(19, 81)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 32)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpExtraButtons
        '
        Me.grpExtraButtons.Controls.Add(Me.btnReset)
        Me.grpExtraButtons.Controls.Add(Me.btnExit)
        Me.grpExtraButtons.Location = New System.Drawing.Point(466, 243)
        Me.grpExtraButtons.Name = "grpExtraButtons"
        Me.grpExtraButtons.Size = New System.Drawing.Size(113, 137)
        Me.grpExtraButtons.TabIndex = 4
        Me.grpExtraButtons.TabStop = False
        '
        'frmSkateboardDesigner
        '
        Me.AcceptButton = Me.btnChooseDeck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(842, 402)
        Me.Controls.Add(Me.grpExtraButtons)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.grpDeckColor)
        Me.Controls.Add(Me.grpSkateboardCost)
        Me.Controls.Add(Me.grpSkateboardParts)
        Me.Controls.Add(Me.MenuBar)
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "frmSkateboardDesigner"
        Me.Text = "Skateboard Designer"
        Me.grpSkateboardParts.ResumeLayout(False)
        Me.grpSkateboardCost.ResumeLayout(False)
        Me.grpSkateboardCost.PerformLayout()
        Me.grpDeckColor.ResumeLayout(False)
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.grpExtraButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSkateboardParts As System.Windows.Forms.GroupBox
    Friend WithEvents btnChooseDeck As System.Windows.Forms.Button
    Friend WithEvents grpSkateboardCost As System.Windows.Forms.GroupBox
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents grpDeckColor As System.Windows.Forms.GroupBox
    Friend WithEvents btnChooseMiscellaneous As System.Windows.Forms.Button
    Friend WithEvents btnChooseWheels As System.Windows.Forms.Button
    Friend WithEvents btnChooseTruckAssembly As System.Windows.Forms.Button
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents lblTaxAmount As System.Windows.Forms.Label
    Friend WithEvents lblIDTotalCost As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblIDTaxAmount As System.Windows.Forms.Label
    Friend WithEvents lblIDSubtotal As System.Windows.Forms.Label
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuDone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDecks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTrucks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWheels As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMiscellaneous As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblDeckColor As System.Windows.Forms.Label
    Friend WithEvents grpExtraButtons As System.Windows.Forms.GroupBox

End Class
