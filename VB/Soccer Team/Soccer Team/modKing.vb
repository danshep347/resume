Module modKing

    Private strTemp As String = ""
    Private strOutput As String = ""
    Private strTotal As Integer = 0
    Private strPlayer As String = ""
    Private strHeader As String = ""
    Private ARRAY_TOTAL(30) As String
    Private intCount As Integer = 1

    Public Sub ArrayLoad(lstOutput As Object, charExtraWork As Char)

        If charExtraWork = "A" Then
            strHeader = "(Name        Total)"
            lstOutput.items.add(strHeader)
        ElseIf charExtraWork = "T" Then
            strHeader = "Name        Total"
            lstOutput.items.add(strHeader)
        End If

        FileOpen(1, "Soccer Team.csv", OpenMode.Input)
        For intRow = 1 To 30
            strOutput = ""  '    Initialize the string for each row
            For intTableCol = 1 To 8
                Input(1, strTemp)
                If IsNumeric(strTemp) Then
                    strTotal += strTemp
                Else
                    strPlayer = strTemp
                End If
                strOutput &= strTemp & " "  '    add each value and a space for each field
            Next
            Call proExtraWork(charExtraWork)
            lstOutput.Items.Add(strOutput)

        Next
        FileClose(1)

    End Sub

    Private Sub proExtraWork(ByVal OptionIndicator As Char)

        Select Case OptionIndicator

            Case "A"
                strOutput = strPlayer & " " & strTotal.ToString
                strTotal = 0
            Case "T"
                'strOutput = strPlayer & " " & strTotal.ToString
                'ARRAY_TOTAL(intCount) = strOutput
                'intCount += 1
                'Array.Sort(ARRAY_TOTAL)
                'Array.Reverse(ARRAY_TOTAL)
                'strTotal = 0
            Case "L"

        End Select

    End Sub


End Module
