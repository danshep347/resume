Module proInput
    'This is used to input what bagel option the user picked.
    Public Sub BagelInput(ByRef decBagel As Decimal, ByRef blnGoodData As Boolean)

        blnGoodData = True

        If frmBrandisBagelHouse.radBagelNone.Checked = True Then
            decBagel = 0
        ElseIf frmBrandisBagelHouse.radBagelWhite.Checked = True Then
            decBagel = 1.25
        ElseIf frmBrandisBagelHouse.radBagelWholeWheat.Checked = True Then
            decBagel = 1.5
        Else
            MessageBox.Show("Please click one of the bagel options")
            blnGoodData = False
        End If

    End Sub
    'This is used to input what toppings option the user picked.
    Public Sub ToppingsInput(ByRef decToppings As Decimal)

        If frmBrandisBagelHouse.chkToppingsCreamCheese.Checked = True Then
            decToppings += 0.5
        End If

        If frmBrandisBagelHouse.chkToppingsButter.Checked = True Then
            decToppings += 0.25
        End If

        If frmBrandisBagelHouse.chkToppingsBlueberry.Checked = True Then
            decToppings += 0.75
        End If

        If frmBrandisBagelHouse.chkToppingsRaspberry.Checked = True Then
            decToppings += 0.75
        End If

        If frmBrandisBagelHouse.chkToppingsPeach.Checked = True Then
            decToppings += 0.75
        End If

    End Sub
    'This is used to input what coffee option the user picked.
    Public Sub CoffeeInput(ByRef decCoffee As Decimal, ByRef blnGoodData As Boolean)

        blnGoodData = True

        If frmBrandisBagelHouse.radCoffeeNone.Checked = True Then
            decCoffee = 0
        ElseIf frmBrandisBagelHouse.radCoffeeRegularCoffee.Checked = True Then
            decCoffee = 1.25
        ElseIf frmBrandisBagelHouse.radCoffeeCappuccino.Checked = True Then
            decCoffee = 2.0
        ElseIf frmBrandisBagelHouse.radCoffeeCafeAuLait.Checked = True Then
            decCoffee = 1.75
        Else
            MessageBox.Show("Please click one of the coffee options")
            blnGoodData = False
        End If

    End Sub
End Module
