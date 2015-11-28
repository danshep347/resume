Module modQueenBee

    Private decASSESSMENT_RATE As Decimal = 0.6D
    Private decTAX_PER_100 As Decimal = 0.64D
    Private decMultiplesOf100 As Decimal

    Public Function InputValidation(ByVal Input As String, ByRef Variable As Decimal, ByVal LowRange As Decimal, ByVal MaxRange As Decimal, ByVal FormName As String) As Boolean

        Dim blnGoodData As Boolean = False

        If Not Decimal.TryParse(Input, Variable) Then
            MessageBox.Show("The value you entered for " & FormName & " was not an acceptable number")
            blnGoodData = False
        ElseIf Variable <= LowRange Then
            MessageBox.Show("The value you entered for " & FormName & " was too low, the minimum value that is accepted is " & LowRange & ".")
            blnGoodData = False
        ElseIf Variable > MaxRange Then
            MessageBox.Show("The value you entered for " & FormName & " was too high, the maximum value that is accepted is " & MaxRange & ".")
            blnGoodData = False
        Else
            blnGoodData = True
        End If

        Return blnGoodData
    End Function

    Public Sub Calculations(ByVal decActualValue As Decimal, ByRef decAssessmentValue As Decimal, ByRef decPropertyTax As Decimal)
        decAssessmentValue = decActualValue * decASSESSMENT_RATE
        decMultiplesOf100 = decAssessmentValue / 100
        decPropertyTax = decMultiplesOf100 * decTAX_PER_100
    End Sub

    Public Sub ChangeRates(ByVal decNewAssessmentRate As Decimal, ByVal decNewTaxRate As Decimal)

        decASSESSMENT_RATE = decNewAssessmentRate
        decTAX_PER_100 = decNewTaxRate

    End Sub

    Public Function GetAssessmentRate() As String
        Return decASSESSMENT_RATE.ToString("n")
    End Function
    Public Function GetTaxRate() As String
        Return decTAX_PER_100.ToString("n")
    End Function

End Module
