Module proCalculate
    'This module is used to calculate the cost of each part of the skateboard and initiate the output.
    Private decSubtotal, decTaxAmount, decTotalCost As Decimal
    Public blnGood1 As Boolean = True
    Public blnGood2 As Boolean = True
    Public blnGood3 As Boolean = True
    Private Const decTaxRate As Decimal = (6.5 / 100)
    Private decDeckCost, decTruckCost, decWheelCost, decMiscellaneousTotal As Decimal
    Private strDeckName As String = ""
    Private strTruckSize As String = ""
    Private strWheelSize As String = ""
    Private strMiscellaneous As String = ""
    
    Public Sub CalculateDeck(ByVal strOptionSelected As String)

        If strOptionSelected = "1" Then
            decDeckCost = 60
            strDeckName = "The Master Thrasher"
        ElseIf strOptionSelected = "2" Then
            decDeckCost = 45
            strDeckName = "The Dictator Of Grind"
        ElseIf strOptionSelected = "3" Then
            decDeckCost = 50
            strDeckName = "The Street King"
        Else
            blnGood1 = False
        End If

        Call DisplayOutput(decDeckCost, strDeckName, "Deck")

        decSubtotal += decDeckCost

    End Sub

    Public Sub CalculateTruck(ByVal strOptionSelected As String)

        If strOptionSelected = "4" Then
            decTruckCost = 35
            strTruckSize = "7.75 Axle"
        ElseIf strOptionSelected = "5" Then
            decTruckCost = 40
            strTruckSize = "8 Axle"
        ElseIf strOptionSelected = "6" Then
            decTruckCost = 45
            strTruckSize = "8.5 Axle"
        Else
            blnGood2 = False
        End If

        Call DisplayOutput(decTruckCost, strTruckSize, "Truck")

        decSubtotal += decTruckCost

    End Sub

    Public Sub CalculateWheel(ByVal strOptionSelected As String)

        If strOptionSelected = "7" Then
            decWheelCost = 20
            strWheelSize = "51 mm"
        ElseIf strOptionSelected = "8" Then
            decWheelCost = 22
            strWheelSize = "55 mm"
        ElseIf strOptionSelected = "9" Then
            decWheelCost = 24
            strWheelSize = "58 mm"
        ElseIf strOptionSelected = "10" Then
            decWheelCost = 28
            strWheelSize = "61 mm"
        Else
            blnGood3 = False
        End If

        Call DisplayOutput(decWheelCost, strWheelSize, "Wheels")

        decSubtotal += decWheelCost

    End Sub

    Public Sub CalculateMiscellaneous(ByVal blnGripTape As Boolean, ByVal blnBearings As Boolean, ByVal blnRiserPads As Boolean, ByVal blnNutsAndBoltsKit As Boolean, ByVal blnAssembly As Boolean)

        If blnGripTape = True Then
            decMiscellaneousTotal += 10
            decSubtotal += 10
            strMiscellaneous += "Grip Tape, "
        End If

        If blnBearings = True Then
            decMiscellaneousTotal += 30
            decSubtotal += 30
            strMiscellaneous += "Bearings, "
        End If

        If blnRiserPads = True Then
            decMiscellaneousTotal += 2
            decSubtotal += 2
            strMiscellaneous += "Riser Pads, "
        End If

        If blnNutsAndBoltsKit = True Then
            decMiscellaneousTotal += 3
            decSubtotal += 3
            strMiscellaneous += "Nuts & Bolts Kit, "
        End If

        If blnAssembly = True Then
            decMiscellaneousTotal += 10
            decSubtotal += 10
            strMiscellaneous += "Assembly, "
        End If

        Call DisplayMiscellaneous(decMiscellaneousTotal, strMiscellaneous)

    End Sub

    Public Sub CalculateTotal()

        If blnGood1 AndAlso blnGood2 AndAlso blnGood3 Then

            decTaxAmount = decSubtotal * decTaxRate
            decTotalCost = decSubtotal + decTaxAmount

            Call DisplayTotal(decSubtotal, decTaxAmount, decTotalCost)

        End If

    End Sub

    Public Sub Initialize()
        decSubtotal = 0
        decTaxAmount = 0
        decTotalCost = 0
        blnGood1 = True
        blnGood2 = True
        blnGood3 = True
        decDeckCost = 0
        decTruckCost = 0
        decWheelCost = 0
        decMiscellaneousTotal = 0
        strMiscellaneous = ""
    End Sub

End Module
