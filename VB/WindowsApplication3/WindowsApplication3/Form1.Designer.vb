<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPaidCaption = New System.Windows.Forms.Label()
        Me.lblOwedCaption = New System.Windows.Forms.Label()
        Me.lblChangeCaption = New System.Windows.Forms.Label()
        Me.lblChangeAmount = New System.Windows.Forms.Label()
        Me.txtAmountPaid = New System.Windows.Forms.TextBox()
        Me.txtAmountOwed = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 231)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(107, 231)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(205, 231)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPaidCaption
        '
        Me.lblPaidCaption.AutoSize = True
        Me.lblPaidCaption.Location = New System.Drawing.Point(48, 42)
        Me.lblPaidCaption.Name = "lblPaidCaption"
        Me.lblPaidCaption.Size = New System.Drawing.Size(70, 13)
        Me.lblPaidCaption.TabIndex = 0
        Me.lblPaidCaption.Text = "&Amount Paid:"
        '
        'lblOwedCaption
        '
        Me.lblOwedCaption.AutoSize = True
        Me.lblOwedCaption.Location = New System.Drawing.Point(48, 95)
        Me.lblOwedCaption.Name = "lblOwedCaption"
        Me.lblOwedCaption.Size = New System.Drawing.Size(77, 13)
        Me.lblOwedCaption.TabIndex = 2
        Me.lblOwedCaption.Text = "Amount &Owed:"
        '
        'lblChangeCaption
        '
        Me.lblChangeCaption.AutoSize = True
        Me.lblChangeCaption.Location = New System.Drawing.Point(48, 157)
        Me.lblChangeCaption.Name = "lblChangeCaption"
        Me.lblChangeCaption.Size = New System.Drawing.Size(70, 13)
        Me.lblChangeCaption.TabIndex = 4
        Me.lblChangeCaption.Text = "Change Due:"
        '
        'lblChangeAmount
        '
        Me.lblChangeAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChangeAmount.Location = New System.Drawing.Point(158, 156)
        Me.lblChangeAmount.Name = "lblChangeAmount"
        Me.lblChangeAmount.Size = New System.Drawing.Size(100, 23)
        Me.lblChangeAmount.TabIndex = 5
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.Location = New System.Drawing.Point(158, 35)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountPaid.TabIndex = 1
        '
        'txtAmountOwed
        '
        Me.txtAmountOwed.Location = New System.Drawing.Point(158, 88)
        Me.txtAmountOwed.Name = "txtAmountOwed"
        Me.txtAmountOwed.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountOwed.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.txtAmountOwed)
        Me.Controls.Add(Me.txtAmountPaid)
        Me.Controls.Add(Me.lblChangeAmount)
        Me.Controls.Add(Me.lblChangeCaption)
        Me.Controls.Add(Me.lblOwedCaption)
        Me.Controls.Add(Me.lblPaidCaption)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmMain"
        Me.Text = "Change Tutor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblPaidCaption As System.Windows.Forms.Label
    Friend WithEvents lblOwedCaption As System.Windows.Forms.Label
    Friend WithEvents lblChangeCaption As System.Windows.Forms.Label
    Friend WithEvents lblChangeAmount As System.Windows.Forms.Label
    Friend WithEvents txtAmountPaid As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountOwed As System.Windows.Forms.TextBox

End Class
