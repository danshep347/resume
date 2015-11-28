Public Class frmMain                                                                                          'Daniel James Shepherd Section 1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Try
            Dim dblAmountPaid As Double
            Dim dblAmountOwed As Double
            Dim dblChangeDue As Double

            dblAmountPaid = CDbl(txtAmountPaid.Text)
            dblAmountOwed = CDbl(txtAmountOwed.Text)

            dblChangeDue = dblAmountPaid - dblAmountOwed

            lblChangeAmount.Text = dblChangeDue.ToString("c")

        Catch ex As Exception
            MessageBox.Show("Please do not leave blank, and make sure you are entering numbers")
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtAmountPaid.Clear()
        txtAmountOwed.Clear()
        lblChangeAmount.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
