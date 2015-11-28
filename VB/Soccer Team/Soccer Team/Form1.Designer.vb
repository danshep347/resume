<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoccerTeam
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
        Me.lstListMembersAndTotals = New System.Windows.Forms.ListBox()
        Me.lstSortedByTotalPoints = New System.Windows.Forms.ListBox()
        Me.lstLoadTeam = New System.Windows.Forms.ListBox()
        Me.btnListMembersAndTotals = New System.Windows.Forms.Button()
        Me.btnSortedByTotalPoints = New System.Windows.Forms.Button()
        Me.btnLoadTeam = New System.Windows.Forms.Button()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAction = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuActionListMembersAndTotals = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuActionSortedByTotalPoints = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuActionLoadTeam = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstListMembersAndTotals
        '
        Me.lstListMembersAndTotals.FormattingEnabled = True
        Me.lstListMembersAndTotals.Location = New System.Drawing.Point(12, 40)
        Me.lstListMembersAndTotals.Name = "lstListMembersAndTotals"
        Me.lstListMembersAndTotals.Size = New System.Drawing.Size(198, 368)
        Me.lstListMembersAndTotals.Sorted = True
        Me.lstListMembersAndTotals.TabIndex = 0
        '
        'lstSortedByTotalPoints
        '
        Me.lstSortedByTotalPoints.FormattingEnabled = True
        Me.lstSortedByTotalPoints.Location = New System.Drawing.Point(240, 40)
        Me.lstSortedByTotalPoints.Name = "lstSortedByTotalPoints"
        Me.lstSortedByTotalPoints.Size = New System.Drawing.Size(198, 368)
        Me.lstSortedByTotalPoints.TabIndex = 1
        '
        'lstLoadTeam
        '
        Me.lstLoadTeam.FormattingEnabled = True
        Me.lstLoadTeam.Location = New System.Drawing.Point(465, 40)
        Me.lstLoadTeam.Name = "lstLoadTeam"
        Me.lstLoadTeam.Size = New System.Drawing.Size(198, 368)
        Me.lstLoadTeam.TabIndex = 2
        '
        'btnListMembersAndTotals
        '
        Me.btnListMembersAndTotals.Location = New System.Drawing.Point(59, 429)
        Me.btnListMembersAndTotals.Name = "btnListMembersAndTotals"
        Me.btnListMembersAndTotals.Size = New System.Drawing.Size(94, 38)
        Me.btnListMembersAndTotals.TabIndex = 3
        Me.btnListMembersAndTotals.Text = "L&ist Members and Totals"
        Me.btnListMembersAndTotals.UseVisualStyleBackColor = True
        '
        'btnSortedByTotalPoints
        '
        Me.btnSortedByTotalPoints.Location = New System.Drawing.Point(297, 429)
        Me.btnSortedByTotalPoints.Name = "btnSortedByTotalPoints"
        Me.btnSortedByTotalPoints.Size = New System.Drawing.Size(94, 38)
        Me.btnSortedByTotalPoints.TabIndex = 4
        Me.btnSortedByTotalPoints.Text = "&Sorted by Total points"
        Me.btnSortedByTotalPoints.UseVisualStyleBackColor = True
        '
        'btnLoadTeam
        '
        Me.btnLoadTeam.Location = New System.Drawing.Point(521, 429)
        Me.btnLoadTeam.Name = "btnLoadTeam"
        Me.btnLoadTeam.Size = New System.Drawing.Size(94, 38)
        Me.btnLoadTeam.TabIndex = 5
        Me.btnLoadTeam.Text = "&Load Team"
        Me.btnLoadTeam.UseVisualStyleBackColor = True
        '
        'MenuBar
        '
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuAction})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(675, 24)
        Me.MenuBar.TabIndex = 6
        Me.MenuBar.Text = "MenuBar"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileClose
        '
        Me.mnuFileClose.Name = "mnuFileClose"
        Me.mnuFileClose.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileClose.Text = "&Close"
        '
        'mnuAction
        '
        Me.mnuAction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuActionListMembersAndTotals, Me.mnuActionSortedByTotalPoints, Me.mnuActionLoadTeam})
        Me.mnuAction.Name = "mnuAction"
        Me.mnuAction.Size = New System.Drawing.Size(54, 20)
        Me.mnuAction.Text = "&Action"
        '
        'mnuActionListMembersAndTotals
        '
        Me.mnuActionListMembersAndTotals.Name = "mnuActionListMembersAndTotals"
        Me.mnuActionListMembersAndTotals.Size = New System.Drawing.Size(203, 22)
        Me.mnuActionListMembersAndTotals.Text = "L&ist Members and Totals"
        '
        'mnuActionSortedByTotalPoints
        '
        Me.mnuActionSortedByTotalPoints.Name = "mnuActionSortedByTotalPoints"
        Me.mnuActionSortedByTotalPoints.Size = New System.Drawing.Size(203, 22)
        Me.mnuActionSortedByTotalPoints.Text = "&Sorted by Total points"
        '
        'mnuActionLoadTeam
        '
        Me.mnuActionLoadTeam.Name = "mnuActionLoadTeam"
        Me.mnuActionLoadTeam.Size = New System.Drawing.Size(203, 22)
        Me.mnuActionLoadTeam.Text = "&Load Team"
        '
        'frmSoccerTeam
        '
        Me.AcceptButton = Me.btnLoadTeam
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 480)
        Me.Controls.Add(Me.btnLoadTeam)
        Me.Controls.Add(Me.btnSortedByTotalPoints)
        Me.Controls.Add(Me.btnListMembersAndTotals)
        Me.Controls.Add(Me.lstLoadTeam)
        Me.Controls.Add(Me.lstSortedByTotalPoints)
        Me.Controls.Add(Me.lstListMembersAndTotals)
        Me.Controls.Add(Me.MenuBar)
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "frmSoccerTeam"
        Me.Text = "Soccer Team"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstListMembersAndTotals As System.Windows.Forms.ListBox
    Friend WithEvents lstSortedByTotalPoints As System.Windows.Forms.ListBox
    Friend WithEvents lstLoadTeam As System.Windows.Forms.ListBox
    Friend WithEvents btnListMembersAndTotals As System.Windows.Forms.Button
    Friend WithEvents btnSortedByTotalPoints As System.Windows.Forms.Button
    Friend WithEvents btnLoadTeam As System.Windows.Forms.Button
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuActionListMembersAndTotals As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuActionSortedByTotalPoints As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuActionLoadTeam As System.Windows.Forms.ToolStripMenuItem

End Class
