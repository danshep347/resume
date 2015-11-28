<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkshopSelector
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
        Me.grpWorkshop = New System.Windows.Forms.GroupBox()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.grpCosts = New System.Windows.Forms.GroupBox()
        Me.lblIDTotalCost = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnAddWorkshop = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstWorkshop = New System.Windows.Forms.ListBox()
        Me.lstLocation = New System.Windows.Forms.ListBox()
        Me.lstCosts = New System.Windows.Forms.ListBox()
        Me.grpWorkshop.SuspendLayout()
        Me.grpLocation.SuspendLayout()
        Me.grpCosts.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpWorkshop
        '
        Me.grpWorkshop.Controls.Add(Me.lstWorkshop)
        Me.grpWorkshop.Location = New System.Drawing.Point(12, 28)
        Me.grpWorkshop.Name = "grpWorkshop"
        Me.grpWorkshop.Size = New System.Drawing.Size(187, 206)
        Me.grpWorkshop.TabIndex = 0
        Me.grpWorkshop.TabStop = False
        Me.grpWorkshop.Text = "Pick a &Workshop"
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.lstLocation)
        Me.grpLocation.Location = New System.Drawing.Point(216, 28)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Size = New System.Drawing.Size(187, 206)
        Me.grpLocation.TabIndex = 1
        Me.grpLocation.TabStop = False
        Me.grpLocation.Text = "Pick a &Location"
        '
        'grpCosts
        '
        Me.grpCosts.Controls.Add(Me.lstCosts)
        Me.grpCosts.Location = New System.Drawing.Point(419, 28)
        Me.grpCosts.Name = "grpCosts"
        Me.grpCosts.Size = New System.Drawing.Size(187, 206)
        Me.grpCosts.TabIndex = 2
        Me.grpCosts.TabStop = False
        Me.grpCosts.Text = "List of &Costs"
        '
        'lblIDTotalCost
        '
        Me.lblIDTotalCost.AutoSize = True
        Me.lblIDTotalCost.Location = New System.Drawing.Point(213, 271)
        Me.lblIDTotalCost.Name = "lblIDTotalCost"
        Me.lblIDTotalCost.Size = New System.Drawing.Size(58, 13)
        Me.lblIDTotalCost.TabIndex = 3
        Me.lblIDTotalCost.Text = "Total Cost:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCost.Location = New System.Drawing.Point(303, 270)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalCost.TabIndex = 4
        '
        'btnAddWorkshop
        '
        Me.btnAddWorkshop.Location = New System.Drawing.Point(77, 332)
        Me.btnAddWorkshop.Name = "btnAddWorkshop"
        Me.btnAddWorkshop.Size = New System.Drawing.Size(88, 62)
        Me.btnAddWorkshop.TabIndex = 5
        Me.btnAddWorkshop.Text = "&Add Workshop"
        Me.btnAddWorkshop.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(203, 332)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(88, 62)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate &Total"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(325, 332)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(88, 62)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(446, 332)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 62)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstWorkshop
        '
        Me.lstWorkshop.FormattingEnabled = True
        Me.lstWorkshop.Items.AddRange(New Object() {"Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview"})
        Me.lstWorkshop.Location = New System.Drawing.Point(33, 62)
        Me.lstWorkshop.Name = "lstWorkshop"
        Me.lstWorkshop.Size = New System.Drawing.Size(120, 95)
        Me.lstWorkshop.TabIndex = 0
        '
        'lstLocation
        '
        Me.lstLocation.FormattingEnabled = True
        Me.lstLocation.Items.AddRange(New Object() {"Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh"})
        Me.lstLocation.Location = New System.Drawing.Point(31, 62)
        Me.lstLocation.Name = "lstLocation"
        Me.lstLocation.Size = New System.Drawing.Size(120, 95)
        Me.lstLocation.TabIndex = 0
        '
        'lstCosts
        '
        Me.lstCosts.FormattingEnabled = True
        Me.lstCosts.Location = New System.Drawing.Point(37, 62)
        Me.lstCosts.Name = "lstCosts"
        Me.lstCosts.Size = New System.Drawing.Size(120, 95)
        Me.lstCosts.TabIndex = 0
        '
        'frmWorkshopSelector
        '
        Me.AcceptButton = Me.btnAddWorkshop
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(619, 418)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnAddWorkshop)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblIDTotalCost)
        Me.Controls.Add(Me.grpCosts)
        Me.Controls.Add(Me.grpLocation)
        Me.Controls.Add(Me.grpWorkshop)
        Me.Name = "frmWorkshopSelector"
        Me.Text = "Workshop Selector"
        Me.grpWorkshop.ResumeLayout(False)
        Me.grpLocation.ResumeLayout(False)
        Me.grpCosts.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpWorkshop As System.Windows.Forms.GroupBox
    Friend WithEvents grpLocation As System.Windows.Forms.GroupBox
    Friend WithEvents grpCosts As System.Windows.Forms.GroupBox
    Friend WithEvents lblIDTotalCost As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents btnAddWorkshop As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lstWorkshop As System.Windows.Forms.ListBox
    Friend WithEvents lstLocation As System.Windows.Forms.ListBox
    Friend WithEvents lstCosts As System.Windows.Forms.ListBox

End Class
