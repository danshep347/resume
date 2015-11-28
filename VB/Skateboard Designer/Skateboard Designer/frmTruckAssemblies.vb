Public Class frmTruckAssemblies
    'This is used to to obtain the users input for Truck Assembly.
    Private Sub btnChooseColor_Click(sender As System.Object, e As System.EventArgs) Handles btnChooseColor.Click
        ColorDialog1.ShowDialog()
        lblTruckColor.BackColor = ColorDialog1.Color
    End Sub

    Private Sub btnDefault_Click(sender As System.Object, e As System.EventArgs) Handles btnDefault.Click
        lblTruckColor.BackColor = Color.Silver
    End Sub

    Private Sub btnDone_Click(sender As System.Object, e As System.EventArgs) Handles btnDone.Click

        Dim strTruckOption As String = ""

        If rad7_75Axle.Checked = True Then
            strTruckOption = "4"
        End If

        If rad8Axle.Checked = True Then
            strTruckOption = "5"
        End If

        If rad8_5Axle.Checked = True Then
            strTruckOption = "6"
        End If

        Call CalculateTruck(strTruckOption)
        Me.Close()

    End Sub

    Private Sub mnuDone_Click(sender As System.Object, e As System.EventArgs) Handles mnuDone.Click
        btnDone.PerformClick()
    End Sub

    Private Sub mnuTruck_Click(sender As System.Object, e As System.EventArgs) Handles mnuTruck.Click
        btnDefault.PerformClick()
    End Sub

    Private Sub mnuColor_Click(sender As System.Object, e As System.EventArgs) Handles mnuColor.Click
        btnChooseColor.PerformClick()
    End Sub
End Class