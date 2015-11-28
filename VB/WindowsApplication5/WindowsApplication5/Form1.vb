Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim strUserInput As String
        'Dim intResult As Integer
        Dim blnBad As Boolean
        Dim intItemcount As Integer
        ListBox1.Items.Clear()
        For intItemcount = 1 To 3 'Step 2    this lets you tell the program by how much to count each time.
            'For intItemCount = 3 To 1 Step -1     this lets you count down
            'Do 
            strUserInput = "dog"
            blnBad = True

            Do While blnBad And strUserInput <> ""

                strUserInput = InputBox("enter data", "input needed", "dog")
                'If strUserInput = "" Then
                'MessageBox.Show("are you sure?", "confirm", MessageBoxButtons.YesNo)
                If strUserInput <> "" Then
                    If IsNumeric(strUserInput) Then
                        MessageBox.Show("please dont type a number")
                    ElseIf strUserInput.length <> 3 Then
                        MessageBox.Show("please enter a 3 letter name")
                    ElseIf strUserInput = "cat" Then
                        MessageBox.Show("no cats")
                    Else
                        'do counter goes from 0 to 2
                        'substring one character
                        'if not greater than a and less than z
                        'loop

                        strUserInput = strUserInput.ToLower()
                        ListBox1.Items.Add(strUserInput)

                        blnBad = False

                    End If
                End If
            Loop

            'intItemcount += 1

            'intResult = MessageBox.Show("continue?", "Add Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            'Loop Until intResult = Windows.Forms.DialogResult.No 'or intResult = 7

            'Loop Until intItemcount = 3 Or strUserInput = ""
        Next
        'Select Case ListBox1.SelectedItem.ToString
        '    Case "dog"

        '    Case "chicago"

        'End Select
    End Sub
End Class
