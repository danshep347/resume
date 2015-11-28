Public Class frmSales              'Daniel James Shepherd

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Call proCalculateSalesData()
    End Sub

    Private Sub mnuFileEnterSales_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileEnterSales.Click
        Dim frmEnterSales As New frmEnterSales
        frmEnterSales.ShowDialog()
    End Sub

    Private Sub mnuFileSaveToFile_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileSaveToFile.Click

        SaveFileDialog1.InitialDirectory = Application.StartupPath
        SaveFileDialog1.FileName = "Sales.csv"
        SaveFileDialog1.ShowDialog()
        Call WriteToDisk(SaveFileDialog1.FileName)

    End Sub

    Private Sub mnuFileExit_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
