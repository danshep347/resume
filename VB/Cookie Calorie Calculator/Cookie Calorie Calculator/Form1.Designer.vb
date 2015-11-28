<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCookieCalorieCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCookieCalorieCalculator))
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblIDCookies = New System.Windows.Forms.Label()
        Me.lblIDCalories = New System.Windows.Forms.Label()
        Me.txtCookies = New System.Windows.Forms.TextBox()
        Me.lblCalories = New System.Windows.Forms.Label()
        Me.picCookies = New System.Windows.Forms.PictureBox()
        CType(Me.picCookies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(40, 352)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(167, 352)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(286, 352)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblIDCookies
        '
        Me.lblIDCookies.AutoSize = True
        Me.lblIDCookies.Location = New System.Drawing.Point(60, 33)
        Me.lblIDCookies.Name = "lblIDCookies"
        Me.lblIDCookies.Size = New System.Drawing.Size(153, 13)
        Me.lblIDCookies.TabIndex = 0
        Me.lblIDCookies.Text = "&Number of Cookies Consumed:"
        '
        'lblIDCalories
        '
        Me.lblIDCalories.AutoSize = True
        Me.lblIDCalories.Location = New System.Drawing.Point(61, 90)
        Me.lblIDCalories.Name = "lblIDCalories"
        Me.lblIDCalories.Size = New System.Drawing.Size(152, 13)
        Me.lblIDCalories.TabIndex = 2
        Me.lblIDCalories.Text = "Number of Calories Consumed:"
        '
        'txtCookies
        '
        Me.txtCookies.Location = New System.Drawing.Point(219, 30)
        Me.txtCookies.Name = "txtCookies"
        Me.txtCookies.Size = New System.Drawing.Size(100, 20)
        Me.txtCookies.TabIndex = 1
        '
        'lblCalories
        '
        Me.lblCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalories.Location = New System.Drawing.Point(219, 83)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(100, 20)
        Me.lblCalories.TabIndex = 3
        Me.lblCalories.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picCookies
        '
        Me.picCookies.Image = CType(resources.GetObject("picCookies.Image"), System.Drawing.Image)
        Me.picCookies.Location = New System.Drawing.Point(72, 139)
        Me.picCookies.Name = "picCookies"
        Me.picCookies.Size = New System.Drawing.Size(247, 193)
        Me.picCookies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCookies.TabIndex = 7
        Me.picCookies.TabStop = False
        '
        'frmCookieCalorieCalculator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(401, 405)
        Me.Controls.Add(Me.picCookies)
        Me.Controls.Add(Me.lblCalories)
        Me.Controls.Add(Me.txtCookies)
        Me.Controls.Add(Me.lblIDCalories)
        Me.Controls.Add(Me.lblIDCookies)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmCookieCalorieCalculator"
        Me.Text = "Cookie Calories"
        CType(Me.picCookies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblIDCookies As System.Windows.Forms.Label
    Friend WithEvents lblIDCalories As System.Windows.Forms.Label
    Friend WithEvents txtCookies As System.Windows.Forms.TextBox
    Friend WithEvents lblCalories As System.Windows.Forms.Label
    Friend WithEvents picCookies As System.Windows.Forms.PictureBox

End Class
