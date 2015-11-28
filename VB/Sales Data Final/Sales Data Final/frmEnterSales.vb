Public Class frmEnterSales

    Private Sub btnValidate_Click(sender As System.Object, e As System.EventArgs) Handles btnValidate.Click

        Dim strName As String = ""
        Dim decSales As Decimal = 0
        Dim intEntryNumber As Integer = lblNumberOfEntries.Text

        If txtName.Text = "" Then
            MessageBox.Show("Please enter a valid name")
        ElseIf Not Decimal.TryParse(txtSales.Text, decSales) Then
            MessageBox.Show("Please enter a valid sales amount")
        ElseIf decSales < 0 Then
            MessageBox.Show("please enter a value greater than 0 for sales amount")
        ElseIf decSales > 100000 Then
            MessageBox.Show("please enter a value less than 100000 for sales amount")
        Else
            strName = txtName.Text
            Call proWriteDataToArray(strName, decSales, intEntryNumber)
            Call ReinitializeForm()
        End If

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmEnterSales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblNumberOfEntries.Text = funGetNumberOfEntries()
    End Sub

    Private Sub ReinitializeForm()
        txtName.Text = ""
        txtSales.Text = ""
        lblNumberOfEntries.Text = funGetNumberOfEntries()
    End Sub
End Class