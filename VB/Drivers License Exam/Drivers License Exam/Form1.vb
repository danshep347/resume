Public Class frmDriversLicenseExam

    Private Sub btnScoreExam_Click(sender As System.Object, e As System.EventArgs) Handles btnScoreExam.Click

        Call proGradeTest()

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Call proClearTest()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
