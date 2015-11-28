Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim intInteger As Integer = 505

        'Call ShowRoot()    'calling a procedure

        uiAnswerLabel.Text = ShowRuut(intInteger)  'calling a function

    End Sub

    'Private Sub ShowRoot() 'this is an example of a procedure
    '    uiAnswerLabel.Text = 505 ^ (1 / 2)

    '    Label1.Text = Math.Sqrt(505)
    'End Sub

    Private Function ShowRuut(intInteger As Integer) As Double 'this is an example of a function

        Return Math.Sqrt(intInteger)

    End Function
    'Question number 3
    Private Function GetCity() As String

        Dim strString As String

        strString = InputBox("Please enter your city followed by your state, seperated by a coma", "City, State")

        If strString.IndexOf(",") = -1 Then
            MessageBox.Show("please seperate the city and state by a comma.")
            strString = ""
        End If

        Return strString

    End Function

    'Question number 7
    Private Sub Check(ByVal uiAge As String, ByVal uiHeight As String, ByVal uiWeight As String, ByRef blnGood As Boolean)

        If IsNumeric(uiAge) Then
            lblAge.BackColor = Color.White
        Else
            lblAge.BackColor = Color.Red
        End If

        If IsNumeric(uiHeight) Then
            lblHeight.BackColor = Color.White
        Else
            lblHeight.BackColor = Color.Red
        End If

        If IsNumeric(uiWeight) Then
            lblWeight.BackColor = Color.White
        Else
            lblWeight.BackColor = Color.Red
        End If

        If IsNumeric(uiAge) And IsNumeric(uiHeight) And IsNumeric(uiWeight) Then
            blnGood = True
        Else
            blnGood = False
        End If
    End Sub

End Class
