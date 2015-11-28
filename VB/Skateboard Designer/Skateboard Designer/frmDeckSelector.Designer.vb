<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeckSelector
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
        Me.mnuDeck = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.radTheMasterThrasher = New System.Windows.Forms.RadioButton()
        Me.radTheDictatorOfGrind = New System.Windows.Forms.RadioButton()
        Me.radTheStreetKing = New System.Windows.Forms.RadioButton()
        Me.lblDeckColor = New System.Windows.Forms.Label()
        Me.btnChooseColor = New System.Windows.Forms.Button()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuBar
        '
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDone, Me.mnuDeck, Me.mnuColor})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(370, 24)
        Me.MenuBar.TabIndex = 7
        Me.MenuBar.Text = "MenuStrip1"
        '
        'mnuDone
        '
        Me.mnuDone.Name = "mnuDone"
        Me.mnuDone.Size = New System.Drawing.Size(47, 20)
        Me.mnuDone.Text = "D&one"
        '
        'mnuDeck
        '
        Me.mnuDeck.Name = "mnuDeck"
        Me.mnuDeck.Size = New System.Drawing.Size(45, 20)
        Me.mnuDeck.Text = "D&eck"
        '
        'mnuColor
        '
        Me.mnuColor.Name = "mnuColor"
        Me.mnuColor.Size = New System.Drawing.Size(48, 20)
        Me.mnuColor.Text = "Co&lor"
        '
        'radTheMasterThrasher
        '
        Me.radTheMasterThrasher.AutoSize = True
        Me.radTheMasterThrasher.Location = New System.Drawing.Point(22, 52)
        Me.radTheMasterThrasher.Name = "radTheMasterThrasher"
        Me.radTheMasterThrasher.Size = New System.Drawing.Size(151, 17)
        Me.radTheMasterThrasher.TabIndex = 0
        Me.radTheMasterThrasher.TabStop = True
        Me.radTheMasterThrasher.Text = "The &Master Thrasher ($60)"
        Me.radTheMasterThrasher.UseVisualStyleBackColor = True
        '
        'radTheDictatorOfGrind
        '
        Me.radTheDictatorOfGrind.AutoSize = True
        Me.radTheDictatorOfGrind.Location = New System.Drawing.Point(22, 88)
        Me.radTheDictatorOfGrind.Name = "radTheDictatorOfGrind"
        Me.radTheDictatorOfGrind.Size = New System.Drawing.Size(153, 17)
        Me.radTheDictatorOfGrind.TabIndex = 1
        Me.radTheDictatorOfGrind.TabStop = True
        Me.radTheDictatorOfGrind.Text = "The Dictator Of &Grind ($45)"
        Me.radTheDictatorOfGrind.UseVisualStyleBackColor = True
        '
        'radTheStreetKing
        '
        Me.radTheStreetKing.AutoSize = True
        Me.radTheStreetKing.Location = New System.Drawing.Point(22, 128)
        Me.radTheStreetKing.Name = "radTheStreetKing"
        Me.radTheStreetKing.Size = New System.Drawing.Size(126, 17)
        Me.radTheStreetKing.TabIndex = 2
        Me.radTheStreetKing.TabStop = True
        Me.radTheStreetKing.Text = "The Street &King ($50)"
        Me.radTheStreetKing.UseVisualStyleBackColor = True
        '
        'lblDeckColor
        '
        Me.lblDeckColor.BackColor = System.Drawing.Color.Black
        Me.lblDeckColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDeckColor.Location = New System.Drawing.Point(242, 52)
        Me.lblDeckColor.Name = "lblDeckColor"
        Me.lblDeckColor.Size = New System.Drawing.Size(104, 93)
        Me.lblDeckColor.TabIndex = 3
        '
        'btnChooseColor
        '
        Me.btnChooseColor.Location = New System.Drawing.Point(22, 183)
        Me.btnChooseColor.Name = "btnChooseColor"
        Me.btnChooseColor.Size = New System.Drawing.Size(72, 38)
        Me.btnChooseColor.TabIndex = 4
        Me.btnChooseColor.Text = "Choose &Color"
        Me.btnChooseColor.UseVisualStyleBackColor = True
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(146, 183)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(78, 38)
        Me.btnDefault.TabIndex = 5
        Me.btnDefault.Text = "&Black Deck (Default)"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDone.Location = New System.Drawing.Point(271, 183)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 38)
        Me.btnDone.TabIndex = 6
        Me.btnDone.Text = "&Done With Deck"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'frmDeckSelector
        '
        Me.AcceptButton = Me.btnChooseColor
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnDone
        Me.ClientSize = New System.Drawing.Size(370, 244)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.btnChooseColor)
        Me.Controls.Add(Me.lblDeckColor)
        Me.Controls.Add(Me.radTheStreetKing)
        Me.Controls.Add(Me.radTheDictatorOfGrind)
        Me.Controls.Add(Me.radTheMasterThrasher)
        Me.Controls.Add(Me.MenuBar)
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "frmDeckSelector"
        Me.Text = "Deck Selector"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuDone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDeck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents radTheMasterThrasher As System.Windows.Forms.RadioButton
    Friend WithEvents radTheDictatorOfGrind As System.Windows.Forms.RadioButton
    Friend WithEvents radTheStreetKing As System.Windows.Forms.RadioButton
    Friend WithEvents lblDeckColor As System.Windows.Forms.Label
    Friend WithEvents btnChooseColor As System.Windows.Forms.Button
    Friend WithEvents btnDefault As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
End Class
