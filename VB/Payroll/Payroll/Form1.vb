'Written by Daniel James Shepherd. This program is used to calculator your tax information.
Public Class frmPayrollCalculator
    'This is the programs main function.
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim decHourlyPay As Decimal
        Dim decStateTaxRate As Decimal
        Dim decFederalTaxRate As Decimal
        Dim decNumberOfExemptions As Decimal
        Dim dblRandomNumberForHoursWorked As Double
        Dim rand As New Random
        Dim decOverTimePay As Decimal
        Dim decGrossEarnings As Decimal
        Dim decStateTaxAmount As Decimal
        Dim decFederalTaxAmount As Decimal
        Dim decFicaAmount As Decimal
        Dim decAnnuityAmount As Decimal
        Dim decNetTakeHomePay As Decimal
        Dim decFicaRate As Decimal = 0.0765
        Dim decExemptionsAmount As Decimal
        Dim blnGoodData As Boolean = True
        Dim strOutput As String = ""
        Dim intCount As Integer = 1

        Try

            Call InputValidation(txtHourlyPay.Text, decHourlyPay, 6.55, 100, "Hourly Pay", blnGoodData)

            If blnGoodData = True Then

                Call InputValidation(txtStateTaxRate.Text, decStateTaxRate, 0, 30, "State Tax Rate", blnGoodData)

            End If

            If blnGoodData = True Then

                Call InputValidation(txtFederalTaxRate.Text, decFederalTaxRate, 0, 25, "Federal Tax Rate", blnGoodData)

            End If

            If blnGoodData = True Then

                Call InputValidation(txtNumberOfExemptions.Text, decNumberOfExemptions, 0, 12, "Number of Exemptions", blnGoodData)

            End If

            lstOutput.Items.Add("Hours          Pay          Exemptions          Gross          State Tax          Fed Tax          FICA          Annuity          Net")

            For intCount = 1 To 100

                If blnGoodData = True Then

                    Call GrossEarningsCalculations(dblRandomNumberForHoursWorked, rand, decHourlyPay, decOverTimePay, decGrossEarnings)

                    Call AnnuityCalculations(decAnnuityAmount)

                    Call FicaCalculations(decFicaAmount, decGrossEarnings, decFicaRate)

                    Call ExemptionsCalculations(decExemptionsAmount, decNumberOfExemptions)

                    Call FederalTaxCalculations(decGrossEarnings, decAnnuityAmount, decExemptionsAmount, decFederalTaxAmount, decFederalTaxRate)

                    Call StateTaxCalculations(decStateTaxAmount, decGrossEarnings, decExemptionsAmount, decStateTaxRate)

                    Call NetTakeHomePayCalculations(decNetTakeHomePay, decGrossEarnings, decFicaAmount, decAnnuityAmount, decFederalTaxAmount, decStateTaxAmount)

                    Call DisplayOutput(dblRandomNumberForHoursWorked, decHourlyPay, decNumberOfExemptions, decGrossEarnings, decStateTaxAmount, decFederalTaxAmount, decFicaAmount, decAnnuityAmount, decNetTakeHomePay, strOutput)

                End If

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'This is used to validate the input that the user entered.
    Private Sub InputValidation(ByVal Input, ByRef Variable, ByVal LowRange, ByVal MaxRange, ByVal FormName, ByRef blnGoodData)

        Try

            blnGoodData = False

            If Not Decimal.TryParse(Input, Variable) Then
                MessageBox.Show("The value you entered for " & FormName & " was not an acceptable number")
                blnGoodData = False
            ElseIf Variable < LowRange Then
                MessageBox.Show("The value you entered for " & FormName & " was too low, the minimum value that is accepted is " & LowRange & ".")
                blnGoodData = False
            ElseIf Variable > MaxRange Then
                MessageBox.Show("The value you entered for " & FormName & " was too high, the maximum value that is accepted is " & MaxRange & ".")
                blnGoodData = False
            Else
                blnGoodData = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'This is used to calculate Gross Earnings.
    Private Sub GrossEarningsCalculations(ByRef dblRandomNumberForHoursWorked, ByRef rand, ByVal decHourlyPay, ByRef decOverTimePay, ByRef decGrossEarnings)

        Try

            dblRandomNumberForHoursWorked = rand.Next(21) + 30

        If dblRandomNumberForHoursWorked > 40 Then
            decOverTimePay = ((dblRandomNumberForHoursWorked - 40) * 0.5) * decHourlyPay
        Else
            decOverTimePay = 0
        End If

        decGrossEarnings = decHourlyPay * dblRandomNumberForHoursWorked
        decGrossEarnings += decOverTimePay

            dblRandomNumberForHoursWorked = Math.Round(dblRandomNumberForHoursWorked, 2, MidpointRounding.AwayFromZero)
            decHourlyPay = Math.Round(decHourlyPay, 2, MidpointRounding.AwayFromZero)
            decGrossEarnings = Math.Round(decGrossEarnings, 2, MidpointRounding.AwayFromZero)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'This is used to calculate Annuity.
    Private Sub AnnuityCalculations(ByRef decAnnuityAmount)

        Try

            If chkAnnuity.Checked = True Then
                decAnnuityAmount = 100
            Else
                decAnnuityAmount = 0
            End If

            decAnnuityAmount = Math.Round(decAnnuityAmount, 2, MidpointRounding.AwayFromZero)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'This is used to calculate FICA Total.
    Private Sub FicaCalculations(ByRef decFicaAmount, ByVal decGrossEarnings, ByVal decFicaRate)

        Try

            decFicaAmount = decGrossEarnings * decFicaRate

            decFicaAmount = Math.Round(decFicaAmount, 2, MidpointRounding.AwayFromZero)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'This is used to calculate Exemptions Total.
    Private Sub ExemptionsCalculations(ByRef decExemptionsAmount, ByVal decNumberOfExemptions)

        Try

            decExemptionsAmount = (decNumberOfExemptions * 5800) / 52

            decExemptionsAmount = Math.Round(decExemptionsAmount, 2, MidpointRounding.AwayFromZero)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'This is used to calculate Federal Tax Total.
    Private Sub FederalTaxCalculations(ByVal decGrossEarnings, ByVal decAnnuityAmount, ByVal decExemptionsAmount, ByRef decFederalTaxAmount, ByVal decFederalTaxRate)

        Try

            If ((decGrossEarnings - decAnnuityAmount) - decExemptionsAmount) > 0 Then
                decFederalTaxAmount = ((decGrossEarnings - decAnnuityAmount) - decExemptionsAmount)
                decFederalTaxAmount *= (decFederalTaxRate / 100)
            Else
                decFederalTaxAmount = 0
            End If

            decFederalTaxAmount = Math.Round(decFederalTaxAmount, 2, MidpointRounding.AwayFromZero)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'This is used to calculate State Tax Total.
    Private Sub StateTaxCalculations(ByRef decStateTaxAmount, ByVal decGrossEarnings, ByVal decExemptionsAmount, ByVal decStateTaxRate)

        Try

            If decGrossEarnings > decExemptionsAmount Then

                decStateTaxAmount = (decGrossEarnings - decExemptionsAmount)
                decStateTaxAmount *= (decStateTaxRate / 100)

                decStateTaxAmount = Math.Round(decStateTaxAmount, 2, MidpointRounding.AwayFromZero)

            Else

                decStateTaxAmount = 0

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'This is used to calculate Net Earnings.
    Private Sub NetTakeHomePayCalculations(ByRef decNetTakeHomePay, ByVal decGrossEarnings, ByVal decFicaAmount, ByVal decAnnuityAmount, ByVal decFederalTaxAmount, ByVal decStateTaxAmount)

        Try

            decNetTakeHomePay = decGrossEarnings - decFicaAmount - decAnnuityAmount - decFederalTaxAmount - decStateTaxAmount

            decNetTakeHomePay = Math.Round(decNetTakeHomePay, 2, MidpointRounding.AwayFromZero)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'This is used to display the output into the listbox.
    Private Sub DisplayOutput(ByRef dblRandomNumberForHoursWorked As Double, ByRef decHourlyPay As Decimal, ByRef decNumberOfExemptions As Decimal, ByRef decGrossEarnings As Decimal, ByRef decStateTaxAmount As Decimal, ByRef decFederalTaxAmount As Decimal, ByRef decFicaAmount As Decimal, ByRef decAnnuityAmount As Decimal, ByRef decNetTakeHomePay As Decimal, ByRef strOutput As String)

        Try

            strOutput = "    "
            strOutput = dblRandomNumberForHoursWorked & "              "
            strOutput += decHourlyPay & "                "
            strOutput += decNumberOfExemptions & "                  "
            strOutput += decGrossEarnings & "           "
            strOutput += decStateTaxAmount & "                "
            strOutput += decFederalTaxAmount & "            "
            strOutput += decFicaAmount & "            "
            strOutput += decAnnuityAmount & "            "
            strOutput += decNetTakeHomePay & ""

            strOutput = String.Format(" {0,5} {1,10} {2,10} {3,10} {4,10} {5,10} {6,10} {7,10} {8,10}", dblRandomNumberForHoursWorked.ToString("n1"), decHourlyPay.ToString("n2"), decNumberOfExemptions.ToString, decGrossEarnings.ToString("c2"), decStateTaxAmount.ToString("n2"), decFederalTaxAmount.ToString("n2"), decFicaAmount.ToString("n2"), decAnnuityAmount.ToString("c2"), decNetTakeHomePay.ToString("c2"))
            'lstOutput.Items.Add("Hours          Pay          Exemptions          Gross          State Tax          Fed Tax          FICA          Annuity          Net")
            lstOutput.Items.Add(strOutput)



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'This is to clear all the programs fields.
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtHourlyPay.Clear()
        txtStateTaxRate.Clear()
        txtFederalTaxRate.Clear()
        txtNumberOfExemptions.Clear()
        chkAnnuity.Checked = False
        lstOutput.Items.Clear()
    End Sub
    'This is to close the program.
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
