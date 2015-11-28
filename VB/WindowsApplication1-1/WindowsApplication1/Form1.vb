Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim intCount As Integer
        Dim decMonthlyBudget As Decimal
        Dim decExpenses As Decimal = 0
        Dim intNumExpenses As Integer
        Dim decTotal As Decimal
        Dim strInput As String

        Try

            Call ResetForm()

            If Not Decimal.TryParse(txtMonthlyBudget.Text, decMonthlyBudget) Then
                MessageBox.Show("bad budget")
            ElseIf decMonthlyBudget <= 0 Then
                MessageBox.Show("bad budget too small")
            ElseIf decMonthlyBudget >= 40000 Then
                MessageBox.Show("bad budget too big")
            Else

                strInput = InputBox("How many different expenses will you have this month?")

                If Not Integer.TryParse(strInput, intNumExpenses) Then
                    MessageBox.Show("bad count of expenses")
                ElseIf intNumExpenses < 0 Then
                    MessageBox.Show("bad count of expenses")
                ElseIf intNumExpenses > 200 Then
                    MessageBox.Show("bad count of expenses")
                Else

                    lstOutput.Items.Add("Total monthly budget amount " & decMonthlyBudget.ToString("c"))

                    For intCount = 1 To intNumExpenses

                        strInput = InputBox("Enter the amount of your (" & intCount.ToString & ") expenses here ")

                        If Not Decimal.TryParse(strInput, decExpenses) Then
                            MessageBox.Show("Enter a numeric value.")
                            intCount -= 1   'this is incase its bad data it resets the loop back instead of ending the loop early.
                        ElseIf decExpenses <= 0 Then
                            MessageBox.Show("please enter a number greater than 0")
                            intCount -= 1
                        ElseIf decExpenses > 1000000 Then
                            MessageBox.Show("please enter a realistic value")
                            intCount -= 1
                        Else
                            Call DisplayExpenses(intCount, decExpenses, decTotal, strInput)
                        End If

                    Next

                    decTotal = decMonthlyBudget - decTotal
                    lblOutput.Text = decTotal.ToString("c")

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("something messed up " & ex.Message)
        End Try

    End Sub

    Private Sub DisplayExpenses(ByVal intCount As Integer, ByVal decExpenses As Decimal, ByRef decTotal As Decimal, ByVal strInput As String) 'byval gives you just the value, it cant be changed. byref gives you the location or "keys", it will be changed
        decExpenses = CDec(strInput)
        lstOutput.Items.Add("Expense number " & intCount.ToString & "    " & decExpenses.ToString("c"))
        decTotal += decExpenses
        lstOutput.Items.Add("The total expenses so far " & decTotal.ToString("c"))
    End Sub

    Private Sub ResetForm()
        lstOutput.Items.Clear()
        lblOutput.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
End Class
