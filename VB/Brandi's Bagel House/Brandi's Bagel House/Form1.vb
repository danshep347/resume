Option Strict On
'Written by Daniel James Shepherd. This program is used to calculator the bill for brandis bagel house.
Public Class frmBrandisBagelHouse

    Private Sub btnCalculateTotal_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculateTotal.Click

        Dim decBagel As Decimal
        Dim decToppings As Decimal
        Dim decCoffee As Decimal
        Dim decSubTotal As Decimal
        Dim decTaxTotal As Decimal
        Dim decTotal As Decimal
        Dim blnGoodData As Boolean

        Try

            Call BagelInput(decBagel, blnGoodData)

            If blnGoodData = True Then
                Call ToppingsInput(decToppings)
            End If

            If blnGoodData = True Then
                Call CoffeeInput(decCoffee, blnGoodData)
            End If

            If blnGoodData = True Then
                Call Calculate(decBagel, decToppings, decCoffee, decSubTotal, decTaxTotal, decTotal)
                Call DisplayOutput(decSubTotal, decTaxTotal, decTotal)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnResetForm_Click(sender As System.Object, e As System.EventArgs) Handles btnResetForm.Click
        radBagelWhite.Checked = True
        chkToppingsCreamCheese.Checked = False
        chkToppingsButter.Checked = False
        chkToppingsBlueberry.Checked = False
        chkToppingsRaspberry.Checked = False
        chkToppingsPeach.Checked = False
        radCoffeeRegularCoffee.Checked = True
        lblPriceSubtotal.Text = ""
        lblPriceTax.Text = ""
        lblPriceTotal.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
