Module funInputValidation
    'This is used to validate the input that the user entered.
    Public Function InputValidation(ByVal Input As String, ByRef Variable As Decimal, ByVal LowRange As Decimal, ByVal MaxRange As Decimal, ByVal FormName As String) As Boolean

        Dim blnGoodData As Boolean = False

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

        Return blnGoodData
    End Function
    'This is used to validate the input that the user entered.
    Public Function InputValidationForInteger(ByVal Input As String, ByRef Variable As Integer, ByVal LowRange As Integer, ByVal MaxRange As Integer, ByVal FormName As String) As Boolean

        Dim blnGoodData As Boolean = False

        If Not Integer.TryParse(Input, Variable) Then
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

        Return blnGoodData
    End Function
End Module
