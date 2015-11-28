Option Strict On
Public Class frmFatCalculator                                'Daniel James Shepherd Section 01

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim dblCalories As Double
        Dim dblFat As Double
        Dim dblPCalories As Double

        Try
            If Not Double.TryParse(txtCalories.Text, dblCalories) Then
                MessageBox.Show("please enter a number")
            ElseIf Not dblCalories >= 0 Then
                MessageBox.Show("please enter a number equal to or greater than 0 for calories")
            ElseIf Not dblCalories < 100000 Then
                MessageBox.Show("please enter a number less than 100,000 for calories")
            ElseIf Not Double.TryParse(txtFat.Text, dblFat) Then
                MessageBox.Show("please enter a number")
            ElseIf Not dblFat >= 0 Then
                MessageBox.Show("please enter a number equal to or greater than 0 for grams of fat")
            ElseIf Not dblFat < 100000 Then
                MessageBox.Show("please enter a number less than 100,000 for grams of fat")
            ElseIf dblCalories = 0 Then
                dblPCalories = 0
                lblPCalories.Text = dblPCalories.ToString("p")
                lblMessage.Text = "no calories"
            Else
                dblPCalories = (dblFat * 9) / dblCalories
                If dblPCalories > dblCalories Then
                    MessageBox.Show("please make sure your data is correct")
                ElseIf dblPCalories < 0.3 Then
                    lblPCalories.Text = dblPCalories.ToString("p")
                    lblMessage.Text = "low fat"
                Else
                    lblPCalories.Text = dblPCalories.ToString("p")
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("please recheck that the data you entered is correct, and make sure that it is either equal to or greater than 0")
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtCalories.Clear()
        txtFat.Clear()
        lblPCalories.Text = String.Empty
        lblMessage.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
