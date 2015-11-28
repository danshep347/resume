Public Class frmInterestCalculator

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Dim decDeposit As Decimal
        Dim decInterest As Decimal
        Dim strDeposit As String
        Dim strInterest As String
        Dim blnGood As Boolean
        Dim strYears As String
        Dim intYears As Integer
        Dim strFrequency As String
        Dim intCompoundFrequency As Integer
        Dim intNumberOfCompounds As Integer
        Dim decInterestAmount As Decimal
        Dim decAmount As Decimal
        Dim intNumberOfYearsToCompoundCounter As Integer
        Dim decTotalInterestEarned As Decimal
        Dim decAverage As Decimal

        Do


            blnGood = False

            Do
                blnGood = False

                Do
                    strDeposit = InputBox("please enter an amount of money to deposit")
                    If Not Double.TryParse(strDeposit, decDeposit) Then
                        MessageBox.Show("please enter a number")
                    ElseIf decDeposit < 0 Then
                        MessageBox.Show("please enter a number higher than 0")
                    ElseIf decDeposit > 10000 Then
                        MessageBox.Show("please enter a number lower than 10,000")
                    Else
                        blnGood = True
                    End If

                Loop Until blnGood = True


                Do
                    strInterest = InputBox("please enter an annual interest rate")
                    If Not Double.TryParse(strInterest, decInterest) Then
                        MessageBox.Show("please enter a number")
                    ElseIf decInterest < 1 Then
                        MessageBox.Show("please enter a number higher than 1")
                    ElseIf decInterest > 20 Then
                        MessageBox.Show("please enter a number lower than 20")
                    Else
                        blnGood = True
                    End If

                Loop Until blnGood = True


            Loop Until Windows.Forms.DialogResult.No = MessageBox.Show("would you like to change any value", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            blnGood = False

            Do
                strYears = InputBox("please enter the number of years you plan to invest")
                If Not Integer.TryParse(strYears, intYears) Then
                    MessageBox.Show("please enter a number without decimals")
                ElseIf intYears < 1 Then
                    MessageBox.Show("please enter a number higher than 1")
                ElseIf intYears > 30 Then
                    MessageBox.Show("please enter a number lower than 30")
                Else
                    blnGood = True
                End If

            Loop Until blnGood = True

            blnGood = False

            Do

                strFrequency = InputBox("enter compounding frequency as either annual, monthly, or daily by either typing a, m, or d", "frequency", "a").ToLower
                Select Case strFrequency
                    Case "a"
                        intCompoundFrequency = 1
                        blnGood = True
                    Case "m"
                        intCompoundFrequency = 12
                        blnGood = True
                    Case "d"
                        intCompoundFrequency = 365
                        blnGood = True
                    Case Else
                        MessageBox.Show("please enter either a, m, or d")
                End Select

            Loop Until blnGood = True


            decInterest = decInterest / 100 / intCompoundFrequency

            decAmount = decDeposit


            For intNumberOfYearsToCompoundCounter = 1 To intYears
                For intNumberOfCompounds = 1 To intCompoundFrequency
                    decInterestAmount = decAmount * decInterest
                    ListBox1.Items.Add(decAmount.ToString("c") & "     " & decInterestAmount.ToString("c"))
                    decAmount += decInterestAmount

                Next
            Next

            decTotalInterestEarned = decAmount - decDeposit
            ListBox1.Items.Add("starting balance is " & decDeposit.ToString("c"))
            ListBox1.Items.Add("total interest earned is " & decTotalInterestEarned.ToString("c"))
            ListBox1.Items.Add("final balance is " & decAmount.ToString("c"))
            decAverage = decTotalInterestEarned / intYears
            ListBox1.Items.Add("average money earned per year " & decAverage.ToString("c"))

        Loop Until Windows.Forms.DialogResult.No = MessageBox.Show("would you like to redo this program", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    End Sub
End Class
