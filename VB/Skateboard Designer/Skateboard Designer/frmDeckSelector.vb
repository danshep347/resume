Public Class frmDeckSelector
    'This is used to to obtain the users input for Deck Selection.
    Private Sub btnChooseColor_Click(sender As System.Object, e As System.EventArgs) Handles btnChooseColor.Click
        ColorDialog1.ShowDialog()
        lblDeckColor.BackColor = ColorDialog1.Color
        frmSkateboardDesigner.lblDeckColor.BackColor = ColorDialog1.Color
    End Sub

    Private Sub btnDefault_Click(sender As System.Object, e As System.EventArgs) Handles btnDefault.Click
        lblDeckColor.BackColor = Color.Black
        frmSkateboardDesigner.lblDeckColor.BackColor = Color.Black
    End Sub

    Private Sub btnDone_Click(sender As System.Object, e As System.EventArgs) Handles btnDone.Click

        Dim strDeckOption As String = ""

        If radTheMasterThrasher.Checked = True Then
            strDeckOption = "1"
        End If

        If radTheDictatorOfGrind.Checked = True Then
            strDeckOption = "2"
        End If

        If radTheStreetKing.Checked = True Then
            strDeckOption = "3"
        End If

        Call CalculateDeck(strDeckOption)
        Me.Close()

    End Sub

    Private Sub mnuDone_Click(sender As System.Object, e As System.EventArgs) Handles mnuDone.Click
        btnDone.PerformClick()
    End Sub

    Private Sub mnuDeck_Click(sender As System.Object, e As System.EventArgs) Handles mnuDeck.Click
        btnDefault.PerformClick()
    End Sub

    Private Sub mnuColor_Click(sender As System.Object, e As System.EventArgs) Handles mnuColor.Click
        btnChooseColor.PerformClick()
    End Sub
End Class