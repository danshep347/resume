Module proCalculate
    'This is used to calculate the output.
    Public Sub Calculate(ByVal decBagel As Decimal, ByVal decToppings As Decimal, ByVal decCoffee As Decimal, ByRef decSubTotal As Decimal, ByRef decTaxTotal As Decimal, ByRef decTotal As Decimal)

        Dim decTaxRate As Decimal = (6.5 / 100)

        decSubTotal = decBagel + decToppings + decCoffee
        decTaxTotal = decSubTotal * decTaxRate
        decTotal = decSubTotal + decTaxTotal

    End Sub
End Module
