Public Class frmMain

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        Dim blnResult As Boolean = False

        Call ValidateInput(txtDays.Text, "D", blnResult)

        If blnResult Then

            Call ValidateInput(txtParking.Text, "P", blnResult)

        ElseIf blnResult Then

            Call ValidateInput(txtMeals.Text, "M", blnResult)

        ElseIf blnResult Then

            Call ValidateInput(txtCarRentalFees.Text, "C", blnResult)

        ElseIf blnResult Then

            Call ValidateInput(txtTaxiFees.Text, "T", blnResult)

        ElseIf blnResult Then

            Call ValidateInput(txtAirFare.Text, "A", blnResult)
        
        ElseIf blnResult Then

            Call Calculate()

            Call DisplayResults()

        End If


    End Sub

    Private Sub btnChange_Click(sender As System.Object, e As System.EventArgs) Handles btnChange.Click
        Dim frmPerdiem As New frmPerdiem
        frmPerdiem.ShowDialog()
    End Sub
 
    Private Sub menuFileCalculateAllowance_Click(sender As System.Object, e As System.EventArgs) Handles menuFileCalculateAllowance.Click
        btnCalculate.PerformClick()
    End Sub

    Private Sub menuFileExit_Click(sender As System.Object, e As System.EventArgs) Handles menuFileExit.Click
        Me.Close()
    End Sub

    Private Sub menuEditChangeDailyRates_Click(sender As System.Object, e As System.EventArgs) Handles menuEditChangeDailyRates.Click
        btnChange.PerformClick()
    End Sub

    Private Sub ChooseColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChooseColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        lblDays.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub ChooseColorToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ChooseColorToolStripMenuItem1.Click
        ColorDialog1.ShowDialog()
        lblDays.ForeColor = ColorDialog1.Color
    End Sub
End Class
