Public Class frmStadiumSeating

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Try

            Dim dblClassAT As Double
            Dim dblClassBT As Double
            Dim dblClassCT As Double
            Dim dblClassAR As Double
            Dim dblClassBR As Double
            Dim dblClassCR As Double
            Dim dblTotalR As Double

            dblClassAT = CDbl(txtClassAT.Text)
            dblClassBT = CDbl(txtClassBT.Text)
            dblClassCT = CDbl(txtClassCT.Text)

            dblClassAR = dblClassAT * 15
            dblClassBR = dblClassBT * 12
            dblClassCR = dblClassCT * 9
            dblTotalR = dblClassAR + dblClassBR + dblClassCR

            lblClassAR.Text = dblClassAR.ToString("c")
            lblClassBR.Text = dblClassBR.ToString("c")
            lblClassCR.Text = dblClassCR.ToString("c")
            lblTotalR.Text = dblTotalR.ToString("c")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtClassAT.Clear()
        txtClassBT.Clear()
        txtClassCT.Clear()
        lblClassAR.Text = String.Empty
        lblClassBR.Text = String.Empty
        lblClassCR.Text = String.Empty
        lblTotalR.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
