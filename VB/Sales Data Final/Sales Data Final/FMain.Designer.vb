<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Me.lblLowest = New System.Windows.Forms.Label()
        Me.grpSalesData = New System.Windows.Forms.GroupBox()
        Me.lblHighest = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblIDLowestSales = New System.Windows.Forms.Label()
        Me.lblIDHighestSales = New System.Windows.Forms.Label()
        Me.lblIDAverageSales = New System.Windows.Forms.Label()
        Me.lblIDTotalSales = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileEnterSales = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveToFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.grpSalesData.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLowest
        '
        Me.lblLowest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLowest.Location = New System.Drawing.Point(128, 120)
        Me.lblLowest.Name = "lblLowest"
        Me.lblLowest.Size = New System.Drawing.Size(76, 23)
        Me.lblLowest.TabIndex = 16
        Me.lblLowest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpSalesData
        '
        Me.grpSalesData.Controls.Add(Me.lblLowest)
        Me.grpSalesData.Controls.Add(Me.lblHighest)
        Me.grpSalesData.Controls.Add(Me.lblAverage)
        Me.grpSalesData.Controls.Add(Me.lblTotal)
        Me.grpSalesData.Controls.Add(Me.lblIDLowestSales)
        Me.grpSalesData.Controls.Add(Me.lblIDHighestSales)
        Me.grpSalesData.Controls.Add(Me.lblIDAverageSales)
        Me.grpSalesData.Controls.Add(Me.lblIDTotalSales)
        Me.grpSalesData.Location = New System.Drawing.Point(34, 43)
        Me.grpSalesData.Name = "grpSalesData"
        Me.grpSalesData.Size = New System.Drawing.Size(238, 160)
        Me.grpSalesData.TabIndex = 10
        Me.grpSalesData.TabStop = False
        Me.grpSalesData.Text = "Sales Data"
        '
        'lblHighest
        '
        Me.lblHighest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHighest.Location = New System.Drawing.Point(128, 88)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(76, 23)
        Me.lblHighest.TabIndex = 15
        Me.lblHighest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(128, 56)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(76, 23)
        Me.lblAverage.TabIndex = 14
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(128, 24)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(76, 23)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIDLowestSales
        '
        Me.lblIDLowestSales.Location = New System.Drawing.Point(40, 120)
        Me.lblIDLowestSales.Name = "lblIDLowestSales"
        Me.lblIDLowestSales.Size = New System.Drawing.Size(72, 23)
        Me.lblIDLowestSales.TabIndex = 12
        Me.lblIDLowestSales.Text = "Lowest Sales"
        Me.lblIDLowestSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIDHighestSales
        '
        Me.lblIDHighestSales.Location = New System.Drawing.Point(32, 88)
        Me.lblIDHighestSales.Name = "lblIDHighestSales"
        Me.lblIDHighestSales.Size = New System.Drawing.Size(80, 23)
        Me.lblIDHighestSales.TabIndex = 11
        Me.lblIDHighestSales.Text = "Highest Sales"
        Me.lblIDHighestSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIDAverageSales
        '
        Me.lblIDAverageSales.Location = New System.Drawing.Point(32, 56)
        Me.lblIDAverageSales.Name = "lblIDAverageSales"
        Me.lblIDAverageSales.Size = New System.Drawing.Size(80, 23)
        Me.lblIDAverageSales.TabIndex = 10
        Me.lblIDAverageSales.Text = "Average Sales"
        Me.lblIDAverageSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIDTotalSales
        '
        Me.lblIDTotalSales.Location = New System.Drawing.Point(48, 24)
        Me.lblIDTotalSales.Name = "lblIDTotalSales"
        Me.lblIDTotalSales.Size = New System.Drawing.Size(64, 23)
        Me.lblIDTotalSales.TabIndex = 9
        Me.lblIDTotalSales.Text = "Total Sales"
        Me.lblIDTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(180, 214)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(58, 214)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(105, 37)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "&Calculate Sales Data"
        '
        'MenuBar
        '
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(284, 24)
        Me.MenuBar.TabIndex = 12
        Me.MenuBar.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileEnterSales, Me.mnuFileSaveToFile, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileEnterSales
        '
        Me.mnuFileEnterSales.Name = "mnuFileEnterSales"
        Me.mnuFileEnterSales.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileEnterSales.Text = "&Enter Sales"
        '
        'mnuFileSaveToFile
        '
        Me.mnuFileSaveToFile.Name = "mnuFileSaveToFile"
        Me.mnuFileSaveToFile.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileSaveToFile.Text = "&Save to file"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileExit.Text = "Exi&t"
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.grpSalesData)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.MenuBar)
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "frmSales"
        Me.Text = "Sales Summary"
        Me.grpSalesData.ResumeLayout(False)
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLowest As System.Windows.Forms.Label
    Friend WithEvents grpSalesData As System.Windows.Forms.GroupBox
    Friend WithEvents lblHighest As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblIDLowestSales As System.Windows.Forms.Label
    Friend WithEvents lblIDHighestSales As System.Windows.Forms.Label
    Friend WithEvents lblIDAverageSales As System.Windows.Forms.Label
    Friend WithEvents lblIDTotalSales As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileEnterSales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSaveToFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
