Public Class frmModifyRates

    
    Private Sub btnSaveAndClose_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveAndClose.Click

        Dim tmdecAssessmentRate As Decimal
        Dim tmdecTaxRate As Decimal

        If Not InputValidation(txtAssessmentRate.Text, tmdecAssessmentRate, 0.0, 1.0, "Assessment Rate") = True Then

        ElseIf InputValidation(txtTaxRate.Text, tmdecTaxRate, 0.0, 1.0, "Tax Rate") = True Then

            Call ChangeRates(tmdecAssessmentRate, tmdecTaxRate)
            Me.Close()

        End If

    End Sub

    Private Sub btnCloseWithoutSaving_Click(sender As System.Object, e As System.EventArgs) Handles btnCloseWithoutSaving.Click
        Me.Close()
    End Sub

    Private Sub mnuSaveAndClose_Click(sender As System.Object, e As System.EventArgs) Handles mnuSaveAndClose.Click
        btnSaveAndClose.PerformClick()
    End Sub

    Private Sub mnuCloseWithoutSaving_Click(sender As System.Object, e As System.EventArgs) Handles mnuCloseWithoutSaving.Click
        btnCloseWithoutSaving.PerformClick()
    End Sub

    Private Sub frmModifyRates_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtAssessmentRate.Text = GetAssessmentRate()
        txtTaxRate.Text = GetTaxRate()
    End Sub

End Class