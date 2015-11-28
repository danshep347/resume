Public Class frmExpenses


    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click

        Dim decActualDays As Decimal
        Dim decActualAirfare As Decimal
        Dim decActualPaidForMeals As Decimal
        Dim decActualCarRentalFees As Decimal
        Dim decActualMilesDriven As Decimal
        Dim decActualParkingFees As Decimal
        Dim decActualTaxiCharges As Decimal
        Dim decActualConferenceRegistrationFees As Decimal
        Dim decActualLodgingCharges As Decimal

        Try


            If Acceptable(txtAirfare.Text, 0, 1250, "airfare", decActualAirfare) AndAlso Acceptable(txtCarRental.Text, 0, 100, "car rental", decActualCarRentalFees) AndAlso Acceptable(txtDays.Text, 1, 31, "days", decActualDays) AndAlso Acceptable(txtLodging.Text, 1, 300, "Lodging costs", decActualLodgingCharges) AndAlso Acceptable(txtParking.Text, 1, 50, "Parking Fees", decActualParkingFees) Then

                lblAllowed.Text = Allowed().ToString("c")
                lblUnallowed.Text = Unallowed().ToString("c")

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtAirfare.Clear()
        txtCarRental.Clear()
        txtDays.Clear()
        txtLodging.Clear()
        txtParking.Clear()
        txtPOVMiles.Clear()
        txtRegistration.Clear()
        lblAllowed.Text = ""
        lblUnallowed.Text = ""
    End Sub
End Class
