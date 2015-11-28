Public Class frmWheels
    'This is used to to obtain the users input for Wheel Size.
    Private Sub btnChooseColor_Click(sender As System.Object, e As System.EventArgs) Handles btnChooseColor.Click
        ColorDialog1.ShowDialog()
        lblWheelColor.BackColor = ColorDialog1.Color
    End Sub

    Private Sub btnDefault_Click(sender As System.Object, e As System.EventArgs) Handles btnDefault.Click
        lblWheelColor.BackColor = Color.Black
    End Sub

    Private Sub btnDone_Click(sender As System.Object, e As System.EventArgs) Handles btnDone.Click

        Dim strWheelOption As String = ""

        If rad51mm.Checked = True Then
            strWheelOption = "7"
        End If

        If rad55mm.Checked = True Then
            strWheelOption = "8"
        End If

        If rad58mm.Checked = True Then
            strWheelOption = "9"
        End If

        If rad61mm.Checked = True Then
            strWheelOption = "10"
        End If

        Call CalculateWheel(strWheelOption)
        Me.Close()

    End Sub

    Private Sub mnuDone_Click(sender As System.Object, e As System.EventArgs) Handles mnuDone.Click
        btnDone.PerformClick()
    End Sub

    Private Sub mnuWheels_Click(sender As System.Object, e As System.EventArgs) Handles mnuWheels.Click
        btnDefault.PerformClick()
    End Sub

    Private Sub mnuColor_Click(sender As System.Object, e As System.EventArgs) Handles mnuColor.Click
        btnChooseColor.PerformClick()
    End Sub
End Class