Module funInputValidation
    'This is used to validate the input that the user entered.
    Public Sub InputValidation(ByVal Input As String, ByRef Variable As Decimal, ByVal LowRange As Decimal, ByVal MaxRange As Decimal, ByVal FormName As String, ByRef blnGoodData As Boolean)

        Try

            blnGoodData = False

            If Not Decimal.TryParse(Input, Variable) Then
                MessageBox.Show("The value you entered for " & FormName & " was not an acceptable number")
            ElseIf Variable < LowRange Then
                MessageBox.Show("The value you entered for " & FormName & " was too low, the minimum value that is accepted is " & LowRange & ".")
            ElseIf Variable > MaxRange Then
                MessageBox.Show("The value you entered for " & FormName & " was too high, the maximum value that is accepted is " & MaxRange & ".")
            Else
                blnGoodData = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Module
