'Written by Daniel James Shepherd. This program is used to calculator the paint and labor cost of a room.
Option Strict On

Public Class frmPaintJobEstimator
    'This is the main form.
    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        Dim intUINumberOfRooms As Integer
        Dim decUICostOfPaintPerGallon As Decimal

        Try

            If Not InputValidationForInteger(txtNumberOfRooms.Text, intUINumberOfRooms, 1, 100, "Number Of Rooms") = True Then
                txtNumberOfRooms.BackColor = Color.Red
            ElseIf Not InputValidation(txtCostOfPaint.Text, decUICostOfPaintPerGallon, 1, 100, "Cost of Paint") = True Then
                txtCostOfPaint.BackColor = Color.Red
            Else
                txtNumberOfRooms.BackColor = Color.White
                txtCostOfPaint.BackColor = Color.White

                Call RoomLoop(intUINumberOfRooms, decUICostOfPaintPerGallon)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'This is used to clear the fields.
    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtNumberOfRooms.Text = ""
        txtCostOfPaint.Text = ""
        lstOutput.Items.Clear()
    End Sub
    'This is used to close the program.
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
