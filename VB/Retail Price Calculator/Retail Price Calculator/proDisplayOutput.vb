Module proDisplayOutput
    'This is used to display output.
    Public Sub DisplayOutput(ByVal decMarkupAmount As Decimal, ByVal decRetailPrice As Decimal)

        Try

            frmRetailPriceCalculator.lblMarkupAmount.Text = decMarkupAmount.ToString("c2")
            frmRetailPriceCalculator.lblRetailPrice.Text = decRetailPrice.ToString("c2")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Module
