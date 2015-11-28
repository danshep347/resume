Module funCalculateMarkupAmount
    'This is used to calculate the markup amount.
    Public Function CalculateMarkupAmount(ByVal decWholesalePrice As Decimal, ByVal decMarkupRate As Decimal) As Decimal

        Try

            Dim decMarkupAmount As Decimal

            decMarkupAmount = (decWholesalePrice * (decMarkupRate / 100))
            decMarkupAmount = Math.Round(decMarkupAmount, 2, MidpointRounding.AwayFromZero)

            Return decMarkupAmount

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function
End Module
