Public Class frmTipCalculator

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim dblBill As Double
        Dim dblPercent As Double
        Dim dblTip As Double

        Try

            dblBill = CDbl(txtBill.Text)
            dblPercent = CDbl(txtPercent.Text)

            dblTip = dblBill * (dblPercent / 100)

            lblTip.Text = dblTip.ToString("c")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        txtBill.Clear()
        txtPercent.Clear()
        lblTip.Text = String.Empty

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub
End Class
