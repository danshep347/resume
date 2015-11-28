<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRainfall
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
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.txt2 = New System.Windows.Forms.TextBox
        Me.txt12 = New System.Windows.Forms.TextBox
        Me.txt11 = New System.Windows.Forms.TextBox
        Me.txt10 = New System.Windows.Forms.TextBox
        Me.txt9 = New System.Windows.Forms.TextBox
        Me.txt8 = New System.Windows.Forms.TextBox
        Me.txt7 = New System.Windows.Forms.TextBox
        Me.txt6 = New System.Windows.Forms.TextBox
        Me.txt5 = New System.Windows.Forms.TextBox
        Me.txt4 = New System.Windows.Forms.TextBox
        Me.txt3 = New System.Windows.Forms.TextBox
        Me.lblAverage = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblAverageCaption = New System.Windows.Forms.Label
        Me.lblTotalCaption = New System.Windows.Forms.Label
        Me.lbl12 = New System.Windows.Forms.Label
        Me.lbl11 = New System.Windows.Forms.Label
        Me.lbl10 = New System.Windows.Forms.Label
        Me.lbl9 = New System.Windows.Forms.Label
        Me.lbl8 = New System.Windows.Forms.Label
        Me.lbl7 = New System.Windows.Forms.Label
        Me.lbl6 = New System.Windows.Forms.Label
        Me.lbl5 = New System.Windows.Forms.Label
        Me.lbl4 = New System.Windows.Forms.Label
        Me.lbl3 = New System.Windows.Forms.Label
        Me.lbl2 = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.lblWarning = New System.Windows.Forms.Label
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.CausesValidation = False
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(404, 357)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.CausesValidation = False
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(284, 357)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.Control
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalculate.Location = New System.Drawing.Point(164, 357)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCalculate.Size = New System.Drawing.Size(75, 25)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txt1)
        Me.Frame1.Controls.Add(Me.txt2)
        Me.Frame1.Controls.Add(Me.txt12)
        Me.Frame1.Controls.Add(Me.txt11)
        Me.Frame1.Controls.Add(Me.txt10)
        Me.Frame1.Controls.Add(Me.txt9)
        Me.Frame1.Controls.Add(Me.txt8)
        Me.Frame1.Controls.Add(Me.txt7)
        Me.Frame1.Controls.Add(Me.txt6)
        Me.Frame1.Controls.Add(Me.txt5)
        Me.Frame1.Controls.Add(Me.txt4)
        Me.Frame1.Controls.Add(Me.txt3)
        Me.Frame1.Controls.Add(Me.lblAverage)
        Me.Frame1.Controls.Add(Me.lblTotal)
        Me.Frame1.Controls.Add(Me.lblAverageCaption)
        Me.Frame1.Controls.Add(Me.lblTotalCaption)
        Me.Frame1.Controls.Add(Me.lbl12)
        Me.Frame1.Controls.Add(Me.lbl11)
        Me.Frame1.Controls.Add(Me.lbl10)
        Me.Frame1.Controls.Add(Me.lbl9)
        Me.Frame1.Controls.Add(Me.lbl8)
        Me.Frame1.Controls.Add(Me.lbl7)
        Me.Frame1.Controls.Add(Me.lbl6)
        Me.Frame1.Controls.Add(Me.lbl5)
        Me.Frame1.Controls.Add(Me.lbl4)
        Me.Frame1.Controls.Add(Me.lbl3)
        Me.Frame1.Controls.Add(Me.lbl2)
        Me.Frame1.Controls.Add(Me.lbl1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(129, 77)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(370, 265)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Rainfall Data"
        '
        'txt1
        '
        Me.txt1.AcceptsReturn = True
        Me.txt1.BackColor = System.Drawing.SystemColors.Window
        Me.txt1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt1.Location = New System.Drawing.Point(96, 32)
        Me.txt1.MaxLength = 0
        Me.txt1.Name = "txt1"
        Me.txt1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt1.Size = New System.Drawing.Size(65, 20)
        Me.txt1.TabIndex = 1
        '
        'txt2
        '
        Me.txt2.AcceptsReturn = True
        Me.txt2.BackColor = System.Drawing.SystemColors.Window
        Me.txt2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt2.Location = New System.Drawing.Point(96, 56)
        Me.txt2.MaxLength = 0
        Me.txt2.Name = "txt2"
        Me.txt2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt2.Size = New System.Drawing.Size(65, 20)
        Me.txt2.TabIndex = 3
        '
        'txt12
        '
        Me.txt12.AcceptsReturn = True
        Me.txt12.BackColor = System.Drawing.SystemColors.Window
        Me.txt12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt12.Location = New System.Drawing.Point(280, 152)
        Me.txt12.MaxLength = 0
        Me.txt12.Name = "txt12"
        Me.txt12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt12.Size = New System.Drawing.Size(65, 20)
        Me.txt12.TabIndex = 23
        '
        'txt11
        '
        Me.txt11.AcceptsReturn = True
        Me.txt11.BackColor = System.Drawing.SystemColors.Window
        Me.txt11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt11.Location = New System.Drawing.Point(280, 128)
        Me.txt11.MaxLength = 0
        Me.txt11.Name = "txt11"
        Me.txt11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt11.Size = New System.Drawing.Size(65, 20)
        Me.txt11.TabIndex = 21
        '
        'txt10
        '
        Me.txt10.AcceptsReturn = True
        Me.txt10.BackColor = System.Drawing.SystemColors.Window
        Me.txt10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt10.Location = New System.Drawing.Point(280, 104)
        Me.txt10.MaxLength = 0
        Me.txt10.Name = "txt10"
        Me.txt10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt10.Size = New System.Drawing.Size(65, 20)
        Me.txt10.TabIndex = 19
        '
        'txt9
        '
        Me.txt9.AcceptsReturn = True
        Me.txt9.BackColor = System.Drawing.SystemColors.Window
        Me.txt9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt9.Location = New System.Drawing.Point(280, 80)
        Me.txt9.MaxLength = 0
        Me.txt9.Name = "txt9"
        Me.txt9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt9.Size = New System.Drawing.Size(65, 20)
        Me.txt9.TabIndex = 17
        '
        'txt8
        '
        Me.txt8.AcceptsReturn = True
        Me.txt8.BackColor = System.Drawing.SystemColors.Window
        Me.txt8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt8.Location = New System.Drawing.Point(280, 56)
        Me.txt8.MaxLength = 0
        Me.txt8.Name = "txt8"
        Me.txt8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt8.Size = New System.Drawing.Size(65, 20)
        Me.txt8.TabIndex = 15
        '
        'txt7
        '
        Me.txt7.AcceptsReturn = True
        Me.txt7.BackColor = System.Drawing.SystemColors.Window
        Me.txt7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt7.Location = New System.Drawing.Point(280, 32)
        Me.txt7.MaxLength = 0
        Me.txt7.Name = "txt7"
        Me.txt7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt7.Size = New System.Drawing.Size(65, 20)
        Me.txt7.TabIndex = 13
        '
        'txt6
        '
        Me.txt6.AcceptsReturn = True
        Me.txt6.BackColor = System.Drawing.SystemColors.Window
        Me.txt6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt6.Location = New System.Drawing.Point(96, 152)
        Me.txt6.MaxLength = 0
        Me.txt6.Name = "txt6"
        Me.txt6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt6.Size = New System.Drawing.Size(65, 20)
        Me.txt6.TabIndex = 11
        '
        'txt5
        '
        Me.txt5.AcceptsReturn = True
        Me.txt5.BackColor = System.Drawing.SystemColors.Window
        Me.txt5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt5.Location = New System.Drawing.Point(96, 128)
        Me.txt5.MaxLength = 0
        Me.txt5.Name = "txt5"
        Me.txt5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt5.Size = New System.Drawing.Size(65, 20)
        Me.txt5.TabIndex = 9
        '
        'txt4
        '
        Me.txt4.AcceptsReturn = True
        Me.txt4.BackColor = System.Drawing.SystemColors.Window
        Me.txt4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt4.Location = New System.Drawing.Point(96, 104)
        Me.txt4.MaxLength = 0
        Me.txt4.Name = "txt4"
        Me.txt4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt4.Size = New System.Drawing.Size(65, 20)
        Me.txt4.TabIndex = 7
        '
        'txt3
        '
        Me.txt3.AcceptsReturn = True
        Me.txt3.BackColor = System.Drawing.SystemColors.Window
        Me.txt3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt3.Location = New System.Drawing.Point(96, 80)
        Me.txt3.MaxLength = 0
        Me.txt3.Name = "txt3"
        Me.txt3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt3.Size = New System.Drawing.Size(65, 20)
        Me.txt3.TabIndex = 5
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.SystemColors.Control
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAverage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAverage.Location = New System.Drawing.Point(280, 224)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAverage.Size = New System.Drawing.Size(65, 17)
        Me.lblAverage.TabIndex = 27
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotal.Location = New System.Drawing.Point(280, 200)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotal.Size = New System.Drawing.Size(65, 17)
        Me.lblTotal.TabIndex = 25
        '
        'lblAverageCaption
        '
        Me.lblAverageCaption.BackColor = System.Drawing.SystemColors.Control
        Me.lblAverageCaption.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAverageCaption.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageCaption.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAverageCaption.Location = New System.Drawing.Point(176, 224)
        Me.lblAverageCaption.Name = "lblAverageCaption"
        Me.lblAverageCaption.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAverageCaption.Size = New System.Drawing.Size(88, 17)
        Me.lblAverageCaption.TabIndex = 26
        Me.lblAverageCaption.Text = "Average Rainfall"
        Me.lblAverageCaption.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalCaption
        '
        Me.lblTotalCaption.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalCaption.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalCaption.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCaption.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalCaption.Location = New System.Drawing.Point(192, 200)
        Me.lblTotalCaption.Name = "lblTotalCaption"
        Me.lblTotalCaption.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalCaption.Size = New System.Drawing.Size(73, 17)
        Me.lblTotalCaption.TabIndex = 24
        Me.lblTotalCaption.Text = "Total Rainfall"
        Me.lblTotalCaption.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl12
        '
        Me.lbl12.BackColor = System.Drawing.SystemColors.Control
        Me.lbl12.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl12.Location = New System.Drawing.Point(208, 152)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl12.Size = New System.Drawing.Size(56, 17)
        Me.lbl12.TabIndex = 22
        Me.lbl12.Text = "December"
        Me.lbl12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl11
        '
        Me.lbl11.BackColor = System.Drawing.SystemColors.Control
        Me.lbl11.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl11.Location = New System.Drawing.Point(208, 128)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl11.Size = New System.Drawing.Size(56, 17)
        Me.lbl11.TabIndex = 20
        Me.lbl11.Text = "November"
        Me.lbl11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl10
        '
        Me.lbl10.BackColor = System.Drawing.SystemColors.Control
        Me.lbl10.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl10.Location = New System.Drawing.Point(216, 104)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl10.Size = New System.Drawing.Size(49, 17)
        Me.lbl10.TabIndex = 18
        Me.lbl10.Text = "October"
        Me.lbl10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl9
        '
        Me.lbl9.BackColor = System.Drawing.SystemColors.Control
        Me.lbl9.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl9.Location = New System.Drawing.Point(200, 80)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl9.Size = New System.Drawing.Size(64, 17)
        Me.lbl9.TabIndex = 16
        Me.lbl9.Text = "September"
        Me.lbl9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl8
        '
        Me.lbl8.BackColor = System.Drawing.SystemColors.Control
        Me.lbl8.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl8.Location = New System.Drawing.Point(216, 56)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl8.Size = New System.Drawing.Size(49, 17)
        Me.lbl8.TabIndex = 14
        Me.lbl8.Text = "August"
        Me.lbl8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl7
        '
        Me.lbl7.BackColor = System.Drawing.SystemColors.Control
        Me.lbl7.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl7.Location = New System.Drawing.Point(216, 32)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl7.Size = New System.Drawing.Size(49, 17)
        Me.lbl7.TabIndex = 12
        Me.lbl7.Text = "July"
        Me.lbl7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl6
        '
        Me.lbl6.BackColor = System.Drawing.SystemColors.Control
        Me.lbl6.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl6.Location = New System.Drawing.Point(32, 152)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl6.Size = New System.Drawing.Size(49, 17)
        Me.lbl6.TabIndex = 10
        Me.lbl6.Text = "June"
        Me.lbl6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl5
        '
        Me.lbl5.BackColor = System.Drawing.SystemColors.Control
        Me.lbl5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl5.Location = New System.Drawing.Point(32, 128)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl5.Size = New System.Drawing.Size(49, 17)
        Me.lbl5.TabIndex = 8
        Me.lbl5.Text = "May"
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl4
        '
        Me.lbl4.BackColor = System.Drawing.SystemColors.Control
        Me.lbl4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl4.Location = New System.Drawing.Point(32, 104)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl4.Size = New System.Drawing.Size(49, 17)
        Me.lbl4.TabIndex = 6
        Me.lbl4.Text = "April"
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.SystemColors.Control
        Me.lbl3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl3.Location = New System.Drawing.Point(32, 80)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl3.Size = New System.Drawing.Size(49, 17)
        Me.lbl3.TabIndex = 4
        Me.lbl3.Text = "March"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.SystemColors.Control
        Me.lbl2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl2.Location = New System.Drawing.Point(32, 56)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl2.Size = New System.Drawing.Size(51, 14)
        Me.lbl2.TabIndex = 2
        Me.lbl2.Text = "February"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.SystemColors.Control
        Me.lbl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl1.Location = New System.Drawing.Point(32, 32)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl1.Size = New System.Drawing.Size(49, 17)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "January"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblWarning
        '
        Me.lblWarning.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(192, 49)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(265, 25)
        Me.lblWarning.TabIndex = 8
        Me.lblWarning.Text = "Items in red are invalid"
        Me.lblWarning.Visible = False
        '
        'frmRainfall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 459)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Frame1)
        Me.Name = "frmRainfall"
        Me.Text = "Rainfall Statistics"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents btnClear As System.Windows.Forms.Button
    Public WithEvents btnCalculate As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txt1 As System.Windows.Forms.TextBox
    Public WithEvents txt2 As System.Windows.Forms.TextBox
    Public WithEvents txt12 As System.Windows.Forms.TextBox
    Public WithEvents txt11 As System.Windows.Forms.TextBox
    Public WithEvents txt10 As System.Windows.Forms.TextBox
    Public WithEvents txt9 As System.Windows.Forms.TextBox
    Public WithEvents txt8 As System.Windows.Forms.TextBox
    Public WithEvents txt7 As System.Windows.Forms.TextBox
    Public WithEvents txt6 As System.Windows.Forms.TextBox
    Public WithEvents txt5 As System.Windows.Forms.TextBox
    Public WithEvents txt4 As System.Windows.Forms.TextBox
    Public WithEvents txt3 As System.Windows.Forms.TextBox
    Public WithEvents lblAverage As System.Windows.Forms.Label
    Public WithEvents lblTotal As System.Windows.Forms.Label
    Public WithEvents lblAverageCaption As System.Windows.Forms.Label
    Public WithEvents lblTotalCaption As System.Windows.Forms.Label
    Public WithEvents lbl12 As System.Windows.Forms.Label
    Public WithEvents lbl11 As System.Windows.Forms.Label
    Public WithEvents lbl10 As System.Windows.Forms.Label
    Public WithEvents lbl9 As System.Windows.Forms.Label
    Public WithEvents lbl8 As System.Windows.Forms.Label
    Public WithEvents lbl7 As System.Windows.Forms.Label
    Public WithEvents lbl6 As System.Windows.Forms.Label
    Public WithEvents lbl5 As System.Windows.Forms.Label
    Public WithEvents lbl4 As System.Windows.Forms.Label
    Public WithEvents lbl3 As System.Windows.Forms.Label
    Public WithEvents lbl2 As System.Windows.Forms.Label
    Public WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lblWarning As System.Windows.Forms.Label
End Class
