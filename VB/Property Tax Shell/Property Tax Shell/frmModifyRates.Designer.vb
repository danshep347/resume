<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifyRates
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
        Me.mnuSaveAndClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCloseWithoutSaving = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblIDAssessmentRate = New System.Windows.Forms.Label()
        Me.lblIDTaxRate = New System.Windows.Forms.Label()
        Me.txtTaxRate = New System.Windows.Forms.TextBox()
        Me.txtAssessmentRate = New System.Windows.Forms.TextBox()
        Me.btnCloseWithoutSaving = New System.Windows.Forms.Button()
        Me.btnSaveAndClose = New System.Windows.Forms.Button()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuBar
        '
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSaveAndClose, Me.mnuCloseWithoutSaving})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(267, 24)
        Me.MenuBar.TabIndex = 6
        Me.MenuBar.Text = "MenuStrip1"
        '
        'mnuSaveAndClose
        '
        Me.mnuSaveAndClose.Name = "mnuSaveAndClose"
        Me.mnuSaveAndClose.Size = New System.Drawing.Size(98, 20)
        Me.mnuSaveAndClose.Text = "Sa&ve and Close"
        '
        'mnuCloseWithoutSaving
        '
        Me.mnuCloseWithoutSaving.Name = "mnuCloseWithoutSaving"
        Me.mnuCloseWithoutSaving.Size = New System.Drawing.Size(130, 20)
        Me.mnuCloseWithoutSaving.Text = "C&lose without Saving"
        '
        'lblIDAssessmentRate
        '
        Me.lblIDAssessmentRate.AutoSize = True
        Me.lblIDAssessmentRate.Location = New System.Drawing.Point(24, 60)
        Me.lblIDAssessmentRate.Name = "lblIDAssessmentRate"
        Me.lblIDAssessmentRate.Size = New System.Drawing.Size(89, 13)
        Me.lblIDAssessmentRate.TabIndex = 0
        Me.lblIDAssessmentRate.Text = "&Assessment Rate"
        '
        'lblIDTaxRate
        '
        Me.lblIDTaxRate.AutoSize = True
        Me.lblIDTaxRate.Location = New System.Drawing.Point(24, 95)
        Me.lblIDTaxRate.Name = "lblIDTaxRate"
        Me.lblIDTaxRate.Size = New System.Drawing.Size(51, 13)
        Me.lblIDTaxRate.TabIndex = 2
        Me.lblIDTaxRate.Text = "&Tax Rate"
        '
        'txtTaxRate
        '
        Me.txtTaxRate.Location = New System.Drawing.Point(139, 92)
        Me.txtTaxRate.Name = "txtTaxRate"
        Me.txtTaxRate.Size = New System.Drawing.Size(100, 20)
        Me.txtTaxRate.TabIndex = 3
        '
        'txtAssessmentRate
        '
        Me.txtAssessmentRate.Location = New System.Drawing.Point(139, 57)
        Me.txtAssessmentRate.Name = "txtAssessmentRate"
        Me.txtAssessmentRate.Size = New System.Drawing.Size(100, 20)
        Me.txtAssessmentRate.TabIndex = 1
        '
        'btnCloseWithoutSaving
        '
        Me.btnCloseWithoutSaving.Location = New System.Drawing.Point(164, 137)
        Me.btnCloseWithoutSaving.Name = "btnCloseWithoutSaving"
        Me.btnCloseWithoutSaving.Size = New System.Drawing.Size(75, 52)
        Me.btnCloseWithoutSaving.TabIndex = 5
        Me.btnCloseWithoutSaving.Text = "&Close without Saving"
        Me.btnCloseWithoutSaving.UseVisualStyleBackColor = True
        '
        'btnSaveAndClose
        '
        Me.btnSaveAndClose.Location = New System.Drawing.Point(27, 137)
        Me.btnSaveAndClose.Name = "btnSaveAndClose"
        Me.btnSaveAndClose.Size = New System.Drawing.Size(74, 52)
        Me.btnSaveAndClose.TabIndex = 4
        Me.btnSaveAndClose.Text = "&Save and Close"
        Me.btnSaveAndClose.UseVisualStyleBackColor = True
        '
        'frmModifyRates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 209)
        Me.Controls.Add(Me.btnSaveAndClose)
        Me.Controls.Add(Me.btnCloseWithoutSaving)
        Me.Controls.Add(Me.txtAssessmentRate)
        Me.Controls.Add(Me.txtTaxRate)
        Me.Controls.Add(Me.lblIDTaxRate)
        Me.Controls.Add(Me.lblIDAssessmentRate)
        Me.Controls.Add(Me.MenuBar)
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "frmModifyRates"
        Me.Text = "frmModifyRates"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents lblIDAssessmentRate As System.Windows.Forms.Label
    Friend WithEvents lblIDTaxRate As System.Windows.Forms.Label
    Friend WithEvents txtTaxRate As System.Windows.Forms.TextBox
    Friend WithEvents txtAssessmentRate As System.Windows.Forms.TextBox
    Friend WithEvents mnuSaveAndClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCloseWithoutSaving As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCloseWithoutSaving As System.Windows.Forms.Button
    Friend WithEvents btnSaveAndClose As System.Windows.Forms.Button
End Class
