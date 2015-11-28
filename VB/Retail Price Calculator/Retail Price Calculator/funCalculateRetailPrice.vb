Module funCalculateRetailPrice
    'This is used to calculate retail price.
    Public Function CalculateRetailPrice(ByVal decWholesalePrice As Decimal, ByVal decMarkupAmount As Decimal) As Decimal

        Try

            Dim decRetailPrice As Decimal

            decRetailPrice = decWholesalePrice + decMarkupAmount
            decRetailPrice = Math.Round(decRetailPrice, 2, MidpointRounding.AwayFromZero)

            Return decRetailPrice

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function
End Module
