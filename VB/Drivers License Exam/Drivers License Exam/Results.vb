Public Class frmResults

    Private Sub btnRetakeTest_Click(sender As System.Object, e As System.EventArgs) Handles btnRetakeTest.Click

        Call proClearTest()
        Me.Close()

    End Sub

    Private Sub frmResults_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Dim strOutput As String

        strOutput = funGetOutputMessage()
        lblFinalResult.Text = strOutput

    End Sub
End Class