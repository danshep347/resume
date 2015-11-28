Public Class frmFolderTotalCalculator

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim dblNumberOfFolders As Double
        Dim dblPrice As Double
        Dim dblRate As Double
        Dim dblSubTotal As Double
        Dim dblTax As Double
        Dim dblTotal As Double

        dblNumberOfFolders = txtFolders.Text
        dblPrice = txtPrice.Text
        dblRate = txtTaxRate.Text

        dblSubTotal = dblNumberOfFolders * dblPrice
        dblTax = dblSubTotal * dblRate * 0.01
        dblTotal = dblSubTotal + dblTax

        lblTotalDue.Text = dblTotal

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
