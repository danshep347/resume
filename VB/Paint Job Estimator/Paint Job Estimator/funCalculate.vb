Module funCalculate
    'This is used to calculate the amount of gallons of paint and hours of labor.
    Public Function CalculateAmount(ByVal SizeOfRoom As Decimal) As Decimal

        Dim Amount As Decimal

        Const AmountOfSquareFeetThatEqualsOneUnitOfPaintAndLabor As Decimal = 115

        Amount = SizeOfRoom / AmountOfSquareFeetThatEqualsOneUnitOfPaintAndLabor

        Return Amount
    End Function
    'This is used to calculate the cost of paint and labor.
    Public Function CalculateCost(ByVal Amount As Decimal, ByVal CostPerUnit As Decimal, ByRef TotalCost As Decimal) As Decimal

        Dim CostPerRoom As Decimal

        CostPerRoom = Amount * CostPerUnit

        TotalCost += CostPerRoom

        Return CostPerRoom
    End Function

End Module
