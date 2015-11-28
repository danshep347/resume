Public Class frmMPGCalculator

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click


        Dim dblMaxGas As Double
        Dim dblMaxMiles As Double
        Dim dblMPG As Double

        Try

        
            dblMaxGas = CDbl(txtMaxGas.Text)
            dblMaxMiles = CDbl(txtMaxMiles.Text)


        dblMPG = dblMaxMiles / dblMaxGas


        lblMPG.Text = dblMPG.ToString("n")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        txtMaxGas.Clear()
        txtMaxMiles.Clear()
        lblMPG.Text = String.Empty

    End Sub
End Class
