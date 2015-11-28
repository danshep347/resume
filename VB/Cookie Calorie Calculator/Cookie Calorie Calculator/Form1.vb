Option Strict On
Public Class frmCookieCalorieCalculator                                                                   'Daniel James Shepherd Section 01

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim dblCookies As Double
        Dim dblCaloriesPerCookie As Double = (300 / (40 / 10))
        Dim dblCalories As Double

        Try

            dblCookies = CDbl(txtCookies.Text)

            dblCalories = dblCookies * dblCaloriesPerCookie

            lblCalories.Text = dblCalories.ToString("n0")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtCookies.Clear()
        lblCalories.Text = String.Empty
        txtCookies.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
