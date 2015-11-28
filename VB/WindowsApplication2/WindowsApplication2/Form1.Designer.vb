<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMPGCalculator
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
        Me.lblIDMaxGas = New System.Windows.Forms.Label()
        Me.lblIDMaxMiles = New System.Windows.Forms.Label()
        Me.lblIDMPG = New System.Windows.Forms.Label()
        Me.txtMaxGas = New System.Windows.Forms.TextBox()
        Me.txtMaxMiles = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblIDMaxGas
        '
        Me.lblIDMaxGas.AutoSize = True
        Me.lblIDMaxGas.Location = New System.Drawing.Point(12, 28)
        Me.lblIDMaxGas.Name = "lblIDMaxGas"
        Me.lblIDMaxGas.Size = New System.Drawing.Size(157, 13)
        Me.lblIDMaxGas.TabIndex = 0
        Me.lblIDMaxGas.Text = "&Gallons of gas the car can hold:"
        '
        'lblIDMaxMiles
        '
        Me.lblIDMaxMiles.AutoSize = True
        Me.lblIDMaxMiles.Location = New System.Drawing.Point(12, 91)
        Me.lblIDMaxMiles.Name = "lblIDMaxMiles"
        Me.lblIDMaxMiles.Size = New System.Drawing.Size(225, 13)
        Me.lblIDMaxMiles.TabIndex = 1
        Me.lblIDMaxMiles.Text = "&Number of miles it can be driven on a full tank:"
        '
        'lblIDMPG
        '
        Me.lblIDMPG.AutoSize = True
        Me.lblIDMPG.Location = New System.Drawing.Point(12, 152)
        Me.lblIDMPG.Name = "lblIDMPG"
        Me.lblIDMPG.Size = New System.Drawing.Size(83, 13)
        Me.lblIDMPG.TabIndex = 2
        Me.lblIDMPG.Text = "&Miles per gallon:"
        '
        'txtMaxGas
        '
        Me.txtMaxGas.Location = New System.Drawing.Point(272, 25)
        Me.txtMaxGas.Name = "txtMaxGas"
        Me.txtMaxGas.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxGas.TabIndex = 3
        '
        'txtMaxMiles
        '
        Me.txtMaxMiles.Location = New System.Drawing.Point(272, 91)
        Me.txtMaxMiles.Name = "txtMaxMiles"
        Me.txtMaxMiles.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxMiles.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(15, 252)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(80, 45)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate MPG"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(162, 252)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 45)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(297, 252)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 45)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMPG
        '
        Me.lblMPG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMPG.Location = New System.Drawing.Point(272, 152)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(100, 23)
        Me.lblMPG.TabIndex = 9
        '
        'frmMPGCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 320)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtMaxMiles)
        Me.Controls.Add(Me.txtMaxGas)
        Me.Controls.Add(Me.lblIDMPG)
        Me.Controls.Add(Me.lblIDMaxMiles)
        Me.Controls.Add(Me.lblIDMaxGas)
        Me.Name = "frmMPGCalculator"
        Me.Text = "Miles Per Gallon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIDMaxGas As System.Windows.Forms.Label
    Friend WithEvents lblIDMaxMiles As System.Windows.Forms.Label
    Friend WithEvents lblIDMPG As System.Windows.Forms.Label
    Friend WithEvents txtMaxGas As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxMiles As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblMPG As System.Windows.Forms.Label

End Class
