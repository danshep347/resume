Module Allowances
    'variables for actual values entered
    Private decDaysActual, decAirFareActual, decCarRentalActual, decParkingActual, decMilesActual, decTaxiActual, decRegistrationActual, decLodgingActual, decMealsActual As Decimal

    'variables for needed for processing requirements
    Private decTotalActual, decTotalAllowable, decTotalExcess, decTotalSavedBelowMax As Decimal

    'variables for output - eg days X allowance 
    Private decMealAllowance, decParkingAllowance, decTaxiAllowance, decLodgingAllowance As Decimal
    Private decMealsExcess, decMealsSaved, decParkingExcess, decParkingSaved, decTaxiExcess, decTaxiSaved, decLodgingExcess, decLodgingSaved As Decimal

    'variables for Maximum values and initialized in anticipation of making them changeable
    Private mdecMealsMax As Decimal = 37D
    Private mdecParkingMax As Decimal = 10D
    Private mdecTaxiMax As Decimal = 20D
    Private mdecLodgingMax As Decimal = 95D

    'Mileage is a flat rate, not a maximum
    Private mdecMileageRate As Decimal = 0.27D

    Public Function GetMealsPerdiem() As String
        Return mdecMealsMax.ToString("n")
    End Function

    Public Function GetParkingPerdiem() As String
        Return mdecParkingMax.ToString("n")
    End Function

    Public Function GetTaxiPerdiem() As String
        Return mdecTaxiMax.ToString("n")
    End Function

    Public Function GetLodgingsPerdiem() As String
        Return mdecLodgingMax.ToString("n")
    End Function

    Public Function GetMileagePerdiem() As String
        Return mdecMileageRate.ToString("n")
    End Function

    Public Sub ValidateInput(ByVal strInput As String, ByVal strField As String, ByRef BlnResult As Boolean)
        Dim decInput As Decimal

        BlnResult = False
        If Not Decimal.TryParse(strInput, decInput) Then
            MessageBox.Show("the input is not a valid numeric")
        ElseIf decInput < 0 Then
            MessageBox.Show("the value may not be negative")
        ElseIf strField = "D" AndAlso CInt(frmMain.txtDays.Text < 1) Then 'make sure it is a whole number > 0"
            MessageBox.Show("Days must be 1 or greater")
            frmMain.txtDays.SelectAll()
        Else
            BlnResult = True

            Select Case strField
                Case "D"
                    decDaysActual = decInput
                Case "P"
                    decParkingActual = decInput
                Case "T"
                    decTaxiActual = decInput
                Case "L"
                    decLodgingActual = decInput
                Case "M"
                    decMealsActual = decInput
                Case "C"
                    decCarRentalActual = decInput
                Case "A"
                    decAirFareActual = decInput
            End Select

        End If

    End Sub

    Public Sub Initilize()

        decParkingExcess = 0
        decParkingSaved = 0
        decMealsExcess = 0
        decMealsSaved = 0
        decLodgingExcess = 0
        decLodgingSaved = 0
        decTaxiExcess = 0
        decTaxiSaved = 0

    End Sub

    Public Sub Calculate()

        Call CalculateSavingsAndExcess(decDaysActual, mdecParkingMax, decParkingActual, decParkingAllowance, decParkingExcess, decTotalExcess, decParkingSaved, decTotalSavedBelowMax)
        Call CalculateSavingsAndExcess(decDaysActual, mdecMealsMax, decMealsActual, decMealAllowance, decMealsExcess, decTotalExcess, decMealsSaved, decTotalSavedBelowMax)
        Call CalculateSavingsAndExcess(decDaysActual, mdecTaxiMax, decTaxiActual, decTaxiAllowance, decTaxiExcess, decTotalExcess, decTaxiSaved, decTotalSavedBelowMax)
        Call CalculateSavingsAndExcess(decDaysActual, mdecLodgingMax, decLodgingActual, decLodgingAllowance, decLodgingExcess, decTotalExcess, decLodgingSaved, decTotalSavedBelowMax)
        'Call CalculateSavingsAndExcess(decDaysActual, mdecMax, decMealsActual, decMealAllowance, decMealsExcess, decTotalExcess, decMealsSaved, decTotalSavedBelowMax)
        'Call CalculateSavingsAndExcess(decDaysActual, mdecMealsMax, decMealsActual, decMealAllowance, decMealsExcess, decTotalExcess, decMealsSaved, decTotalSavedBelowMax)

    End Sub

    Public Sub CalculateSavingsAndExcess(ByVal Days As Decimal, ByVal Max As Decimal, ByVal Actual As Decimal, ByRef Allowance As Decimal, ByRef Excess As Decimal, ByRef TotalExcess As Decimal, ByRef Saved As Decimal, ByRef TotalSavedBelowMax As Decimal)

        If Days * Max < Actual Then
            Allowance = Days * Max
            Excess = Actual - Allowance ' find amount that is over the allowance
            TotalExcess += Excess
        Else
            Allowance = Actual
            Saved = Days * Max - Actual
            TotalSavedBelowMax += Saved
        End If

    End Sub
    Public Sub DisplayResults()

        Dim strOutput As String = ""
        strOutput = " Days     Allow     Actual    Over      Saved"
        frmMain.lstOutput.Items.Add(strOutput)
        strOutput = "         Parking   Parking  Parking   Parking"
        frmMain.lstOutput.Items.Add(strOutput)
        strOutput = String.Format("  {0,5} {1,10} {2,10} {3,10} {4,10}", decDaysActual.ToString("n0"), decParkingAllowance, decParkingActual, decParkingExcess, decParkingSaved)
        frmMain.lstOutput.Items.Add(strOutput)
        strOutput = "Total amount saved is " & decTotalSavedBelowMax & ". "
        frmMain.lstOutput.Items.Add(strOutput)
        strOutput = "Total amount owed is " & decTotalExcess & ". "
        frmMain.lstOutput.Items.Add(strOutput)

    End Sub

    Public Sub SetPerdiem(ByVal tmdecParkingMax As Decimal, ByVal tmdecMealsMax As Decimal, ByVal tmdecTaxiMax As Decimal, ByVal tmdecLodgingMax As Decimal, ByVal tmdecMileageRateMax As Decimal)
        mdecParkingMax = tmdecParkingMax
        mdecMealsMax = tmdecMealsMax
        mdecTaxiMax = tmdecTaxiMax
        mdecLodgingMax = tmdecLodgingMax
        mdecMileageRate = tmdecMileageRateMax
    End Sub
End Module
