Public Class frmRPS

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Dim intComputer As Integer
        Dim strFirst As String
        Dim strOutputLine, strUserChoice As String
        Dim rand As New Random  'random numbers generator

        'If Not Integer.TryParse(txtComputer.Text, intComputer) Then
        '    MessageBox.Show("enter a number")
        'ElseIf intComputer < 1 Then
        '    MessageBox.Show("enter a number greater than 0")
        'ElseIf intComputer > 3 Then
        '    MessageBox.Show("enter a number less than 4")
        'Else

        strUserChoice = ""
        strFirst = ""
        intComputer = rand.Next(1, 4)


        If radRock.Checked = True Then
            strFirst = "R"
            strUserChoice = "Rock"
        ElseIf radPaper.Checked = True Then
            strFirst = "P"
            strUserChoice = "Paper"
        ElseIf radScissors.Checked = True Then
            strFirst = "S"
            strUserChoice = "Scissors"
        End If


        'strFirst = txtHuman.Text.Substring(0, 1)
        'strFirst = strFirst.ToUpper
        If strFirst = "R" Or strFirst = "P" Or strFirst = "S" Then
            If strFirst = "R" And intComputer = 1 Then
                lblMessage.Text = "Tie"
            ElseIf strFirst = "P" And intComputer = 2 Then
                lblMessage.Text = "Tie"
            ElseIf strFirst = "S" And intComputer = 3 Then
                lblMessage.Text = "Tie"
            ElseIf strFirst = "R" And intComputer = 2 Then
                lblMessage.Text = "you lose"
            ElseIf strFirst = "R" And intComputer = 3 Then
                lblMessage.Text = "you win"
            ElseIf strFirst = "P" And intComputer = 3 Then
                lblMessage.Text = "you lose"
            ElseIf strFirst = "p" And intComputer = 1 Then
                lblMessage.Text = "you win"
            ElseIf strFirst = "S" And intComputer = 1 Then
                lblMessage.Text = "you lose"
            ElseIf strFirst = "S" And intComputer = 2 Then
                lblMessage.Text = "you win"
            End If
        End If

        'End If
        strOutputLine = "computer choice"
        strOutputLine &= String.Format("{0,4}", intComputer)
        strOutputLine &= " you chose "
        strOutputLine &= strUserChoice
        strOutputLine &= "   " & lblMessage.Text
        lstOutput.Items.Add(strOutputLine)



    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtComputer.Clear()
        txtHuman.Clear()
        lblMessage.Text = String.Empty
        lstOutput.Items.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
