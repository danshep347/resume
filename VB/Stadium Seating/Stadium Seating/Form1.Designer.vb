<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStadiumSeating
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
        Me.grpTickets = New System.Windows.Forms.GroupBox()
        Me.grpRevenue = New System.Windows.Forms.GroupBox()
        Me.txtClassAT = New System.Windows.Forms.TextBox()
        Me.txtClassBT = New System.Windows.Forms.TextBox()
        Me.txtClassCT = New System.Windows.Forms.TextBox()
        Me.lblIDClassAT = New System.Windows.Forms.Label()
        Me.lblIDClassBT = New System.Windows.Forms.Label()
        Me.lblIDClassCT = New System.Windows.Forms.Label()
        Me.lblIDInstructions = New System.Windows.Forms.Label()
        Me.lblIDClassAR = New System.Windows.Forms.Label()
        Me.lblIDClassBR = New System.Windows.Forms.Label()
        Me.lblIDClassCR = New System.Windows.Forms.Label()
        Me.lblClassAR = New System.Windows.Forms.Label()
        Me.lblIDTotalR = New System.Windows.Forms.Label()
        Me.lblClassBR = New System.Windows.Forms.Label()
        Me.lblClassCR = New System.Windows.Forms.Label()
        Me.lblTotalR = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpTickets.SuspendLayout()
        Me.grpRevenue.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTickets
        '
        Me.grpTickets.Controls.Add(Me.lblIDInstructions)
        Me.grpTickets.Controls.Add(Me.lblIDClassCT)
        Me.grpTickets.Controls.Add(Me.lblIDClassBT)
        Me.grpTickets.Controls.Add(Me.lblIDClassAT)
        Me.grpTickets.Controls.Add(Me.txtClassCT)
        Me.grpTickets.Controls.Add(Me.txtClassBT)
        Me.grpTickets.Controls.Add(Me.txtClassAT)
        Me.grpTickets.Location = New System.Drawing.Point(22, 29)
        Me.grpTickets.Name = "grpTickets"
        Me.grpTickets.Size = New System.Drawing.Size(222, 232)
        Me.grpTickets.TabIndex = 0
        Me.grpTickets.TabStop = False
        Me.grpTickets.Text = "Tickets Sold"
        '
        'grpRevenue
        '
        Me.grpRevenue.Controls.Add(Me.lblTotalR)
        Me.grpRevenue.Controls.Add(Me.lblClassCR)
        Me.grpRevenue.Controls.Add(Me.lblClassBR)
        Me.grpRevenue.Controls.Add(Me.lblIDTotalR)
        Me.grpRevenue.Controls.Add(Me.lblClassAR)
        Me.grpRevenue.Controls.Add(Me.lblIDClassCR)
        Me.grpRevenue.Controls.Add(Me.lblIDClassBR)
        Me.grpRevenue.Controls.Add(Me.lblIDClassAR)
        Me.grpRevenue.Location = New System.Drawing.Point(277, 29)
        Me.grpRevenue.Name = "grpRevenue"
        Me.grpRevenue.Size = New System.Drawing.Size(265, 232)
        Me.grpRevenue.TabIndex = 1
        Me.grpRevenue.TabStop = False
        Me.grpRevenue.Text = "Revenue Generated"
        '
        'txtClassAT
        '
        Me.txtClassAT.Location = New System.Drawing.Point(102, 107)
        Me.txtClassAT.Name = "txtClassAT"
        Me.txtClassAT.Size = New System.Drawing.Size(100, 20)
        Me.txtClassAT.TabIndex = 0
        '
        'txtClassBT
        '
        Me.txtClassBT.Location = New System.Drawing.Point(102, 145)
        Me.txtClassBT.Name = "txtClassBT"
        Me.txtClassBT.Size = New System.Drawing.Size(100, 20)
        Me.txtClassBT.TabIndex = 1
        '
        'txtClassCT
        '
        Me.txtClassCT.Location = New System.Drawing.Point(102, 187)
        Me.txtClassCT.Name = "txtClassCT"
        Me.txtClassCT.Size = New System.Drawing.Size(100, 20)
        Me.txtClassCT.TabIndex = 2
        '
        'lblIDClassAT
        '
        Me.lblIDClassAT.AutoSize = True
        Me.lblIDClassAT.Location = New System.Drawing.Point(25, 107)
        Me.lblIDClassAT.Name = "lblIDClassAT"
        Me.lblIDClassAT.Size = New System.Drawing.Size(45, 13)
        Me.lblIDClassAT.TabIndex = 3
        Me.lblIDClassAT.Text = "Class A:"
        '
        'lblIDClassBT
        '
        Me.lblIDClassBT.AutoSize = True
        Me.lblIDClassBT.Location = New System.Drawing.Point(25, 145)
        Me.lblIDClassBT.Name = "lblIDClassBT"
        Me.lblIDClassBT.Size = New System.Drawing.Size(45, 13)
        Me.lblIDClassBT.TabIndex = 4
        Me.lblIDClassBT.Text = "Class B:"
        '
        'lblIDClassCT
        '
        Me.lblIDClassCT.AutoSize = True
        Me.lblIDClassCT.Location = New System.Drawing.Point(25, 187)
        Me.lblIDClassCT.Name = "lblIDClassCT"
        Me.lblIDClassCT.Size = New System.Drawing.Size(45, 13)
        Me.lblIDClassCT.TabIndex = 5
        Me.lblIDClassCT.Text = "Class C:"
        '
        'lblIDInstructions
        '
        Me.lblIDInstructions.Location = New System.Drawing.Point(25, 32)
        Me.lblIDInstructions.Name = "lblIDInstructions"
        Me.lblIDInstructions.Size = New System.Drawing.Size(177, 47)
        Me.lblIDInstructions.TabIndex = 6
        Me.lblIDInstructions.Text = "Enter the number of tickets sold for each class of seats"
        '
        'lblIDClassAR
        '
        Me.lblIDClassAR.AutoSize = True
        Me.lblIDClassAR.Location = New System.Drawing.Point(43, 43)
        Me.lblIDClassAR.Name = "lblIDClassAR"
        Me.lblIDClassAR.Size = New System.Drawing.Size(45, 13)
        Me.lblIDClassAR.TabIndex = 0
        Me.lblIDClassAR.Text = "Class A:"
        '
        'lblIDClassBR
        '
        Me.lblIDClassBR.AutoSize = True
        Me.lblIDClassBR.Location = New System.Drawing.Point(43, 91)
        Me.lblIDClassBR.Name = "lblIDClassBR"
        Me.lblIDClassBR.Size = New System.Drawing.Size(45, 13)
        Me.lblIDClassBR.TabIndex = 1
        Me.lblIDClassBR.Text = "Class B:"
        '
        'lblIDClassCR
        '
        Me.lblIDClassCR.AutoSize = True
        Me.lblIDClassCR.Location = New System.Drawing.Point(43, 136)
        Me.lblIDClassCR.Name = "lblIDClassCR"
        Me.lblIDClassCR.Size = New System.Drawing.Size(45, 13)
        Me.lblIDClassCR.TabIndex = 2
        Me.lblIDClassCR.Text = "Class C:"
        '
        'lblClassAR
        '
        Me.lblClassAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassAR.Location = New System.Drawing.Point(121, 34)
        Me.lblClassAR.Name = "lblClassAR"
        Me.lblClassAR.Size = New System.Drawing.Size(100, 22)
        Me.lblClassAR.TabIndex = 3
        '
        'lblIDTotalR
        '
        Me.lblIDTotalR.AutoSize = True
        Me.lblIDTotalR.Location = New System.Drawing.Point(22, 178)
        Me.lblIDTotalR.Name = "lblIDTotalR"
        Me.lblIDTotalR.Size = New System.Drawing.Size(81, 13)
        Me.lblIDTotalR.TabIndex = 4
        Me.lblIDTotalR.Text = "Total Revenue:"
        '
        'lblClassBR
        '
        Me.lblClassBR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassBR.Location = New System.Drawing.Point(121, 81)
        Me.lblClassBR.Name = "lblClassBR"
        Me.lblClassBR.Size = New System.Drawing.Size(100, 23)
        Me.lblClassBR.TabIndex = 5
        '
        'lblClassCR
        '
        Me.lblClassCR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassCR.Location = New System.Drawing.Point(121, 126)
        Me.lblClassCR.Name = "lblClassCR"
        Me.lblClassCR.Size = New System.Drawing.Size(100, 23)
        Me.lblClassCR.TabIndex = 6
        '
        'lblTotalR
        '
        Me.lblTotalR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalR.Location = New System.Drawing.Point(121, 168)
        Me.lblTotalR.Name = "lblTotalR"
        Me.lblTotalR.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalR.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(65, 284)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(127, 49)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate Revenue"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(302, 284)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 49)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(432, 284)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 49)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmStadiumSeating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 345)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpRevenue)
        Me.Controls.Add(Me.grpTickets)
        Me.Name = "frmStadiumSeating"
        Me.Text = "Stadium Seating"
        Me.grpTickets.ResumeLayout(False)
        Me.grpTickets.PerformLayout()
        Me.grpRevenue.ResumeLayout(False)
        Me.grpRevenue.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpTickets As System.Windows.Forms.GroupBox
    Friend WithEvents lblIDInstructions As System.Windows.Forms.Label
    Friend WithEvents lblIDClassCT As System.Windows.Forms.Label
    Friend WithEvents lblIDClassBT As System.Windows.Forms.Label
    Friend WithEvents lblIDClassAT As System.Windows.Forms.Label
    Friend WithEvents txtClassCT As System.Windows.Forms.TextBox
    Friend WithEvents txtClassBT As System.Windows.Forms.TextBox
    Friend WithEvents txtClassAT As System.Windows.Forms.TextBox
    Friend WithEvents grpRevenue As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalR As System.Windows.Forms.Label
    Friend WithEvents lblClassCR As System.Windows.Forms.Label
    Friend WithEvents lblClassBR As System.Windows.Forms.Label
    Friend WithEvents lblIDTotalR As System.Windows.Forms.Label
    Friend WithEvents lblClassAR As System.Windows.Forms.Label
    Friend WithEvents lblIDClassCR As System.Windows.Forms.Label
    Friend WithEvents lblIDClassBR As System.Windows.Forms.Label
    Friend WithEvents lblIDClassAR As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
