Module proOutput
    'This is used to display the output.
    Public Sub DisplayOutput(ByVal decSubTotal As Decimal, ByVal decTaxTotal As Decimal, ByVal decTotal As Decimal)

        frmBrandisBagelHouse.lblPriceSubtotal.Text = decSubTotal.ToString("c2")
        frmBrandisBagelHouse.lblPriceTax.Text = decTaxTotal.ToString("c2")
        frmBrandisBagelHouse.lblPriceTotal.Text = decTotal.ToString("c2")

    End Sub
End Module
