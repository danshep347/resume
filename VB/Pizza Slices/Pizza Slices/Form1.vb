Public Class frmPizzaSliceCalculator                                           'Daniel Shepherd Section 01

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Try
            Dim intStartDiameter As Integer
            Dim intEndDiameter As Integer = 30
            Dim dblArea As Double
            Dim dblSlices As Double
            Dim dblPi As Double = 3.14159
            Dim intCounter As Integer
            Dim intDiameter As Integer
            Dim strHeader As String
            Dim strOutput As String

            lstOutput.Items.Clear()

            If Not Integer.TryParse(cboDiameter.Text, intStartDiameter) Then
                MessageBox.Show("please enter a whole number into the field")
            ElseIf intStartDiameter < 5 Then
                MessageBox.Show("Please enter a diameter greater than 4")
            ElseIf intStartDiameter > 29 Then
                MessageBox.Show("Please enter a diameter less than 30")
            Else

                'lstOutput.Items.Add("Diameter" & "    " & "Area" & "    " & "Number of slices")
                intDiameter = intStartDiameter
                strHeader = String.Format("{0,4} {1,13} {2,25}", "Diameter", "Area", "Number of Slices")
                lstOutput.Items.Add(strHeader)

                For intCounter = intStartDiameter To intEndDiameter
                    dblArea = dblPi * intDiameter ^ 2
                    dblSlices = dblArea / 14 ^ 2
                    strOutput = String.Format("{0,4} {1,17} {2,18}", intDiameter.ToString("n0"), dblArea.ToString("n0"), dblSlices.ToString("n0"))
                    lstOutput.Items.Add(strOutput)
                    'lstOutput.Items.Add(intDiameter.ToString("n0") & "              " & dblArea.ToString("n0") & "            " & dblSlices.ToString("n0"))
                    intDiameter += 1
                Next
            End If










        Catch ex As Exception
            MessageBox.Show("Something went wrong with the program, please try again.")
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstOutput.Items.Clear()
        cboDiameter.SelectedIndex = -1
        cboDiameter.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
