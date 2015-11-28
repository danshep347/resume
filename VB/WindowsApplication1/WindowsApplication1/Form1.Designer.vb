<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFolderTotalCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFolderTotalCalculator))
        Me.lblIDFolders = New System.Windows.Forms.Label()
        Me.lblIDPrice = New System.Windows.Forms.Label()
        Me.lblIDTaxRate = New System.Windows.Forms.Label()
        Me.lblIDTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtFolders = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtTaxRate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIDFolders
        '
        Me.lblIDFolders.AutoSize = True
        Me.lblIDFolders.Location = New System.Drawing.Point(105, 25)
        Me.lblIDFolders.Name = "lblIDFolders"
        Me.lblIDFolders.Size = New System.Drawing.Size(63, 13)
        Me.lblIDFolders.TabIndex = 0
        Me.lblIDFolders.Text = "# of Folders"
        '
        'lblIDPrice
        '
        Me.lblIDPrice.AutoSize = True
        Me.lblIDPrice.Location = New System.Drawing.Point(105, 65)
        Me.lblIDPrice.Name = "lblIDPrice"
        Me.lblIDPrice.Size = New System.Drawing.Size(63, 13)
        Me.lblIDPrice.TabIndex = 1
        Me.lblIDPrice.Text = "Folder Price"
        '
        'lblIDTaxRate
        '
        Me.lblIDTaxRate.AutoSize = True
        Me.lblIDTaxRate.Location = New System.Drawing.Point(105, 101)
        Me.lblIDTaxRate.Name = "lblIDTaxRate"
        Me.lblIDTaxRate.Size = New System.Drawing.Size(51, 13)
        Me.lblIDTaxRate.TabIndex = 2
        Me.lblIDTaxRate.Text = "Tax Rate"
        '
        'lblIDTotal
        '
        Me.lblIDTotal.AutoSize = True
        Me.lblIDTotal.Location = New System.Drawing.Point(105, 149)
        Me.lblIDTotal.Name = "lblIDTotal"
        Me.lblIDTotal.Size = New System.Drawing.Size(54, 13)
        Me.lblIDTotal.TabIndex = 3
        Me.lblIDTotal.Text = "Total Due"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(46, 485)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(338, 485)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtFolders
        '
        Me.txtFolders.Location = New System.Drawing.Point(270, 22)
        Me.txtFolders.Name = "txtFolders"
        Me.txtFolders.Size = New System.Drawing.Size(100, 20)
        Me.txtFolders.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(270, 58)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 7
        '
        'txtTaxRate
        '
        Me.txtTaxRate.Location = New System.Drawing.Point(270, 94)
        Me.txtTaxRate.Name = "txtTaxRate"
        Me.txtTaxRate.Size = New System.Drawing.Size(100, 20)
        Me.txtTaxRate.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 9
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(195, 485)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Location = New System.Drawing.Point(270, 139)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalDue.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(85, 180)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 264)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'frmFolderTotalCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 542)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTaxRate)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtFolders)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblIDTotal)
        Me.Controls.Add(Me.lblIDTaxRate)
        Me.Controls.Add(Me.lblIDPrice)
        Me.Controls.Add(Me.lblIDFolders)
        Me.Name = "frmFolderTotalCalculator"
        Me.Text = "Folder Total Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIDFolders As System.Windows.Forms.Label
    Friend WithEvents lblIDPrice As System.Windows.Forms.Label
    Friend WithEvents lblIDTaxRate As System.Windows.Forms.Label
    Friend WithEvents lblIDTotal As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtFolders As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxRate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblTotalDue As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
