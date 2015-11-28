Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim decActualDays As Decimal
        Dim decActualAirfare As Decimal
        Dim decActualPaidForMeals As Decimal
        Dim decActualCarRentalFees As Decimal
        Dim decActualMilesDriven As Decimal
        Dim decActualParkingFees As Decimal
        Dim decActualTaxiCharges As Decimal
        Dim decActualConferenceRegistrationFees As Decimal
        Dim decActualLodgingCharges As Decimal
        Dim decAllowanceAirfare As Decimal
        Dim decAllowancePaidForMeals As Decimal
        Dim decAllowanceCarRentalFees As Decimal
        Dim decAllowanceMilesDriven As Decimal
        Dim decAllowanceParkingFees As Decimal
        Dim decAllowanceTaxiCharges As Decimal
        Dim decAllowanceConferenceRegistrationFees As Decimal
        Dim decAllowanceLodgingCharges As Decimal
        Dim blnGoodData As Boolean

        Call InputValidation(txtAirfare.text, decActualAirfare, 0, 1000, "Days")
        If blnGoodData = True Then
            Call InputValidation(txtAirfare.text, decActualAirfare, 0, 1000, "Airfare")
        End If
        If blnGoodData = True Then
            Call InputValidation(txtAirfare.text, decActualAirfare, 0, 1000, "Meals")
        End If
        If blnGoodData = True Then
            Call InputValidation(txtAirfare.text, decActualAirfare, 0, 1000, "Rental Fees")
        End If
        If blnGoodData = True Then
            Call InputValidation(txtAirfare.text, decActualAirfare, 0, 1000, "Miles Driven")
        End If
        If blnGoodData = True Then
            Call InputValidation(txtAirfare.text, decActualAirfare, 0, 1000, "Parking Fees")
        End If
        If blnGoodData = True Then
            Call InputValidation(txtAirfare.text, decActualAirfare, 0, 1000, "Taxi Charges")
        End If
        If blnGoodData = True Then
            Call InputValidation(txtAirfare.text, decActualAirfare, 0, 1000, "Conference")
        End If
        If blnGoodData = True Then
            Call InputValidation(txtAirfare.text, decActualAirfare, 0, 1000, "Lodging")
        End If

        If blnGoodData = True Then

        End If

    End Sub
End Class
