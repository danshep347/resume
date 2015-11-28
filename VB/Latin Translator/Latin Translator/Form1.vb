Public Class frmLatinTranslator                                                                    'Daniel James Shepherd Section 01

    Private Sub btnSinister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSinister.Click
        lblEnglish.Text = "Left"
        lblEnglish.TextAlign = ContentAlignment.MiddleLeft
    End Sub

    Private Sub btnMedium_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedium.Click
        lblEnglish.Text = "Center"
        lblEnglish.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub btnDexter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDexter.Click
        lblEnglish.Text = "Right"
        lblEnglish.TextAlign = ContentAlignment.MiddleRight
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
