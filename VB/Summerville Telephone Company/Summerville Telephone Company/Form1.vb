Option Strict On                                                                      'Daniel Shepherd Section 01
Public Class frmSummervilleTelephoneCompany

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Try

            Dim strName As String
            Dim intMinimum As Integer
            Dim intMaximum As Integer
            Dim strCase As String
            Dim intMinuteCount As Integer
            Dim dblCost As Double
            Dim intMinuteValue As Integer

            strCase = ""
            lstOutput.Items.Clear()

            strName = txtName.Text

            If strName = "" Then
                MessageBox.Show("Please enter your name")
            ElseIf Not Integer.TryParse(cboMinimum.Text, intMinimum) Then
                MessageBox.Show("please enter a number for minimum")
            ElseIf intMinimum <= 0 Then
                MessageBox.Show("please enter a number greater than 0 for the minimum")
            ElseIf intMinimum > 299 Then
                MessageBox.Show("please enter a number lower than or equal to 20 for the minimum")
            ElseIf Not Integer.TryParse(cboMaximum.Text, intMaximum) Then
                MessageBox.Show("please enter a number for maximum")
            ElseIf intMaximum < intMinimum Then
                MessageBox.Show("please enter a number higher than or equal to the minimum for the maximum")
            ElseIf intMaximum > 300 Then
                MessageBox.Show("please enter a number lower than 300 for the maximum")
            Else

                If intMinimum <= 20 And intMaximum <= 20 Then
                    strCase = "a"
                ElseIf intMinimum <= 20 And intMaximum > 20 Then
                    strCase = "b"
                ElseIf intMinimum > 20 And intMaximum > 20 Then
                    strCase = "c"
                End If


                lstOutput.Items.Add("Customers Name: " & strName)
                lstOutput.Items.Add("Minutes" & "     Cost")


                Select Case strCase
                    Case "a"
                        intMinuteValue = intMinimum
                        For intMinuteCount = intMinimum To intMaximum
                            dblCost = intMinuteValue * 0.13
                            lstOutput.Items.Add("   " & intMinuteCount.ToString("n0") & "         " & dblCost.ToString("c"))
                            intMinuteValue += 1
                        Next

                    Case "b"
                        intMinuteValue = intMinimum
                        For intMinuteCount = intMinimum To intMaximum
                            If intMinuteValue <= 20 Then
                                dblCost = intMinuteValue * 0.13
                            Else
                                dblCost = intMinuteValue * 0.1
                                dblCost += 0.6
                            End If
                            lstOutput.Items.Add("   " & intMinuteCount.ToString("n0") & "         " & dblCost.ToString("c"))
                            intMinuteValue += 1
                        Next

                    Case "c"
                        intMinuteValue = intMinimum - 20
                        For intMinuteCount = intMinimum To intMaximum
                            dblCost = intMinuteValue * 0.1 + 2.6
                            lstOutput.Items.Add("   " & intMinuteCount.ToString("n0") & "         " & dblCost.ToString("c"))
                            intMinuteValue += 1
                        Next


                End Select

            End If

        Catch ex As Exception
            MessageBox.Show("something with the program didnt work, sorry for the inconvience")
        End Try

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstOutput.Items.Clear()
        txtName.Clear()
        cboMaximum.SelectedIndex = -1
        cboMaximum.Text = String.Empty
        cboMinimum.SelectedIndex = -1
        cboMinimum.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
