<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnterSales
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
        Me.lblIDName = New System.Windows.Forms.Label()
        Me.lblIDSales = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.lblNumberOfEntries = New System.Windows.Forms.Label()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIDName
        '
        Me.lblIDName.AutoSize = True
        Me.lblIDName.Location = New System.Drawing.Point(45, 37)
        Me.lblIDName.Name = "lblIDName"
        Me.lblIDName.Size = New System.Drawing.Size(35, 13)
        Me.lblIDName.TabIndex = 0
        Me.lblIDName.Text = "&Name"
        '
        'lblIDSales
        '
        Me.lblIDSales.AutoSize = True
        Me.lblIDSales.Location = New System.Drawing.Point(45, 89)
        Me.lblIDSales.Name = "lblIDSales"
        Me.lblIDSales.Size = New System.Drawing.Size(33, 13)
        Me.lblIDSales.TabIndex = 1
        Me.lblIDSales.Text = "&Sales"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(135, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 2
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(135, 86)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 20)
        Me.txtSales.TabIndex = 3
        '
        'lblNumberOfEntries
        '
        Me.lblNumberOfEntries.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumberOfEntries.Location = New System.Drawing.Point(86, 145)
        Me.lblNumberOfEntries.Name = "lblNumberOfEntries"
        Me.lblNumberOfEntries.Size = New System.Drawing.Size(100, 23)
        Me.lblNumberOfEntries.TabIndex = 4
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(29, 221)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(75, 23)
        Me.btnValidate.TabIndex = 5
        Me.btnValidate.Text = "&Validate"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(172, 221)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmEnterSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.lblNumberOfEntries)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblIDSales)
        Me.Controls.Add(Me.lblIDName)
        Me.Name = "frmEnterSales"
        Me.Text = "Enter Sales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIDName As System.Windows.Forms.Label
    Friend WithEvents lblIDSales As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtSales As System.Windows.Forms.TextBox
    Friend WithEvents lblNumberOfEntries As System.Windows.Forms.Label
    Friend WithEvents btnValidate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
