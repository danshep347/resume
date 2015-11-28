Public Class frmPerdiem

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btnNoChanges.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveChanges.Click

        Dim blnResult As Boolean = False
        Dim tmdecParkingMax As Decimal
        Dim tmdecMealsMax As Decimal
        Dim tmdecTaxiMax As Decimal
        Dim tmdecLodgingMax As Decimal
        Dim tmdecMileageRateMax As Decimal

        If Not InputValidation(txtParking.Text, tmdecParkingMax, 1, 100, "Parking") = True Then
            txtParking.BackColor = Color.Red
        ElseIf Not InputValidation(txtMeals.Text, tmdecMealsMax, 1, 100, "Meals") = True Then
            txtMeals.BackColor = Color.Red
        ElseIf Not InputValidation(txtTaxiFees.Text, tmdecTaxiMax, 1, 100, "Taxi") = True Then
            txtTaxiFees.BackColor = Color.Red
        ElseIf Not InputValidation(txtLodging.Text, tmdecLodgingMax, 1, 500, "Lodging") = True Then
            txtLodging.BackColor = Color.Red
        ElseIf Not InputValidation(txtMilageRate.Text, tmdecMileageRateMax, 0, 100, "Mileage Rate") = True Then
            txtMilageRate.BackColor = Color.Red
        Else
            txtParking.BackColor = Color.White
            txtMeals.BackColor = Color.White
            txtTaxiFees.BackColor = Color.White
            txtLodging.BackColor = Color.White
            txtMilageRate.BackColor = Color.White

            txtParking.Text = tmdecParkingMax
            txtMeals.Text = tmdecMealsMax
            txtTaxiFees.Text = tmdecTaxiMax
            txtLodging.Text = tmdecLodgingMax
            txtMilageRate.Text = tmdecMileageRateMax

            Call SetPerdiem(tmdecParkingMax, tmdecMealsMax, tmdecTaxiMax, tmdecLodgingMax, tmdecMileageRateMax)

            Me.Close()

        End If

    End Sub

    Private Sub frmPerdiem_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtParking.Text = GetParkingPerdiem()
        txtMeals.Text = GetMealsPerdiem()
        txtTaxiFees.Text = GetTaxiPerdiem()
        txtMilageRate.Text = GetMileagePerdiem()
        txtLodging.Text = GetLodgingsPerdiem()
    End Sub
End Class