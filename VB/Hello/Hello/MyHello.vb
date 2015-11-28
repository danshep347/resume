Public Class frmHello
    'this declares the variable for all private subs/procedures
    Private intClickCount As Integer

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        'static means that it keeps the count and saves it, but it can be changes. if it was const it wouldnt be able to be changed.
        'Static intClickCount As Integer
        Me.lblGreeting.Visible = True
        'could also use const instead of dim if i wanted it to be locked so it wouldnt change.
        Dim strHandle As String = "Good Buddy"
        'the & symbol means that it adds hello and good buddy together. this is called string concatenation.
        Me.lblGreeting.Text &= strHandle
        intClickCount = intClickCount + 1
        Me.lblCount.Text = intClickCount
        'moves the highlight to exit
        btnExit.Focus()
    End Sub

    Private Sub lblCount_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCount.Click
        'allows clicking the label to increase the count
        intClickCount = intClickCount + 1
        Me.lblCount.Text = intClickCount

    End Sub
End Class
