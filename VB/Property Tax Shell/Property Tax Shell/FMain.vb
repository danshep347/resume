Option Strict On
Public Class FMain
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Daniel James Shepherd. This procedure calculates and displays assessed value and amount of tax.

        Try
            
            Dim decActualValue As Decimal
            Dim decAssessmentValue As Decimal
            Dim decPropertyTax As Decimal

            'check input.
            If InputValidation(txtActualValue.Text, decActualValue, 0, 1000000, "Actual Value of Property") = True Then

                Call Calculations(decActualValue, decAssessmentValue, decPropertyTax)

                ' Display the figures.
                lblAssessmentValue.Text = decAssessmentValue.ToString("c")
                lblPropertyTax.Text = decPropertyTax.ToString("c")

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        ' This procedure clears the Form's fields.
        txtActualValue.Clear()
        lblAssessmentValue.Text = String.Empty
        lblPropertyTax.Text = String.Empty
        txtActualValue.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        ' End the application.
        Me.Close()
    End Sub

    Private Sub ModifyRatesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles mnuModifyRates.Click
        Dim frmModifyRates As New frmModifyRates
        frmModifyRates.ShowDialog()
    End Sub

    Private Sub mnuCalculate_Click(sender As System.Object, e As System.EventArgs) Handles mnuCalculate.Click
        btnCalculate.PerformClick()
    End Sub

    Private Sub mnuClear_Click(sender As System.Object, e As System.EventArgs) Handles mnuClear.Click
        btnClear.PerformClick()
    End Sub

    Private Sub mnuExit_Click(sender As System.Object, e As System.EventArgs) Handles mnuExit.Click
        btnExit.PerformClick()
    End Sub
End Class
