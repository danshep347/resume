<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeatingReservationForTheater
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
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeats = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlSeats = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblIDFull = New System.Windows.Forms.Label()
        Me.lblIDEmpty = New System.Windows.Forms.Label()
        Me.lblFull = New System.Windows.Forms.Label()
        Me.lblEmpty = New System.Windows.Forms.Label()
        Me.mnuFile_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeats_Clear = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuBar
        '
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuSeats})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(443, 24)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile_Exit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuSeats
        '
        Me.mnuSeats.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSeats_Clear})
        Me.mnuSeats.Name = "mnuSeats"
        Me.mnuSeats.Size = New System.Drawing.Size(46, 20)
        Me.mnuSeats.Text = "Seats"
        '
        'pnlSeats
        '
        Me.pnlSeats.AutoScroll = True
        Me.pnlSeats.Location = New System.Drawing.Point(0, 70)
        Me.pnlSeats.Name = "pnlSeats"
        Me.pnlSeats.Size = New System.Drawing.Size(228, 347)
        Me.pnlSeats.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(12, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 338)
        Me.Panel1.TabIndex = 1
        '
        'lblIDFull
        '
        Me.lblIDFull.AutoSize = True
        Me.lblIDFull.Location = New System.Drawing.Point(327, 57)
        Me.lblIDFull.Name = "lblIDFull"
        Me.lblIDFull.Size = New System.Drawing.Size(23, 13)
        Me.lblIDFull.TabIndex = 2
        Me.lblIDFull.Text = "Full"
        '
        'lblIDEmpty
        '
        Me.lblIDEmpty.AutoSize = True
        Me.lblIDEmpty.Location = New System.Drawing.Point(314, 87)
        Me.lblIDEmpty.Name = "lblIDEmpty"
        Me.lblIDEmpty.Size = New System.Drawing.Size(36, 13)
        Me.lblIDEmpty.TabIndex = 3
        Me.lblIDEmpty.Text = "Empty"
        '
        'lblFull
        '
        Me.lblFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFull.Location = New System.Drawing.Point(356, 56)
        Me.lblFull.Name = "lblFull"
        Me.lblFull.Size = New System.Drawing.Size(56, 18)
        Me.lblFull.TabIndex = 4
        '
        'lblEmpty
        '
        Me.lblEmpty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpty.Location = New System.Drawing.Point(356, 86)
        Me.lblEmpty.Name = "lblEmpty"
        Me.lblEmpty.Size = New System.Drawing.Size(56, 18)
        Me.lblEmpty.TabIndex = 5
        '
        'mnuFile_Exit
        '
        Me.mnuFile_Exit.Name = "mnuFile_Exit"
        Me.mnuFile_Exit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFile_Exit.Text = "Exit"
        '
        'mnuSeats_Clear
        '
        Me.mnuSeats_Clear.Name = "mnuSeats_Clear"
        Me.mnuSeats_Clear.Size = New System.Drawing.Size(152, 22)
        Me.mnuSeats_Clear.Text = "Clear"
        '
        'frmSeatingReservationForTheater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 415)
        Me.Controls.Add(Me.lblEmpty)
        Me.Controls.Add(Me.lblFull)
        Me.Controls.Add(Me.lblIDEmpty)
        Me.Controls.Add(Me.lblIDFull)
        Me.Controls.Add(Me.pnlSeats)
        Me.Controls.Add(Me.MenuBar)
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "frmSeatingReservationForTheater"
        Me.Text = "Seating Reservation for Theater"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSeats As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlSeats As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblIDFull As System.Windows.Forms.Label
    Friend WithEvents lblIDEmpty As System.Windows.Forms.Label
    Friend WithEvents lblFull As System.Windows.Forms.Label
    Friend WithEvents lblEmpty As System.Windows.Forms.Label
    Friend WithEvents mnuFile_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSeats_Clear As System.Windows.Forms.ToolStripMenuItem

End Class
