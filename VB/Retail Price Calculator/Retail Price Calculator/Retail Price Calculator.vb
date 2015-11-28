'Written by Daniel James Shepherd. This program is used to calculator the retail price of an item.
Option Strict On

Public Class frmRetailPriceCalculator
    'This is the programs main function.
    Private Sub btnGetRetail_Click(sender As System.Object, e As System.EventArgs) Handles btnGetRetail.Click

        Dim decWholesalePrice As Decimal
        Dim decMarkupRate As Decimal
        Dim decMarkupAmount As Decimal
        Dim decRetailPrice As Decimal
        Dim blnGoodData As Boolean

        Try

            Call InputValidation(txtWholesaleCost.Text, decWholesalePrice, 1, 1000, "Wholesale Cost of", blnGoodData)

            If blnGoodData = True Then

                Call InputValidation(txtMarkup.Text, decMarkupRate, 1, 100, "Markup", blnGoodData)

            End If

            If blnGoodData = True Then

                decMarkupAmount = CalculateMarkupAmount(decWholesalePrice, decMarkupRate)
                decRetailPrice = CalculateRetailPrice(decWholesalePrice, decMarkupAmount)

                Call DisplayOutput(decMarkupAmount, decRetailPrice)
                
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'This is to clear all the programs fields.
    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtWholesaleCost.Clear()
        txtMarkup.Clear()
        lblMarkupAmount.Text = ""
        lblRetailPrice.Text = ""
    End Sub
    'This is to close the program.
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
