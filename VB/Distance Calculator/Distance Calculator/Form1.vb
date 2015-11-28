Option Strict On
Public Class frmDistanceCalculator                                            'Daniel Shepherd Section 01

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Try

            Dim strSpeed As String
            Dim dblSpeed As Double
            Dim strTime As String
            Dim intTime As Integer
            Dim dblDistance As Double
            Dim strOutput As String
            Dim blnGood As Boolean
            Dim intCounter As Integer
            Dim intHourCount As Integer
            Dim strDescription As String

            lstOutput.Items.Clear()

            strSpeed = ""
            strTime = ""
            strOutput = ""
            strDescription = ""

            blnGood = False

            Do
                strSpeed = InputBox("please enter your speed")
                If Not Double.TryParse(strSpeed, dblSpeed) Then
                    MessageBox.Show("please enter a number")
                ElseIf dblSpeed <= 0 Then
                    MessageBox.Show("please enter a speed higher than 0")
                ElseIf dblSpeed > 100000 Then
                    MessageBox.Show("please enter a speed lower than 100,000")
                Else
                    blnGood = True
                End If

            Loop Until blnGood = True

            blnGood = False

            Do
                strTime = InputBox("please enter your time")
                If Not Integer.TryParse(strTime, intTime) Then
                    MessageBox.Show("please enter a number")
                ElseIf intTime < 1 Then
                    MessageBox.Show("please enter a time equal to or greater than 1")
                ElseIf intTime > 72 Then
                    MessageBox.Show("please enter a time equal to or lower than 72 hours.")
                Else
                    blnGood = True
                End If

            Loop Until blnGood = True

            lstOutput.Items.Add("Speed: " & dblSpeed.ToString("n0") & " MPH")
            lstOutput.Items.Add("Time Traveled: " & intTime.ToString("n0") & " Hours")
            strDescription = String.Format("{0,4} {1,17}", "Hours", "Distance")
            lstOutput.Items.Add(strDescription)
            intHourCount = 1

            For intCounter = 1 To intTime

                dblDistance = dblSpeed * intHourCount
                strOutput = String.Format("{0,4} {1,17}", intHourCount, dblDistance)
                lstOutput.Items.Add(strOutput)
                intHourCount += 1

            Next

            lstOutput.Items.Add("Total Distance: " & dblDistance.ToString("n0"))

        Catch ex As Exception
            MessageBox.Show("something with the program didnt work, sorry for the inconvience")
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstOutput.Items.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dblx As Double
        dblx = (40 Mod 12) ^ 2 - 10 + 2
        lstOutput.Items.Add(dblx)
    End Sub
End Class
