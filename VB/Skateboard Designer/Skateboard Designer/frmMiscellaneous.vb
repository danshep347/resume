Public Class frmMiscellaneous
    'This is used to to obtain the users input for Miscellaneous items.
    Private Sub btnDone_Click(sender As System.Object, e As System.EventArgs) Handles btnDone.Click

        Dim blnGripTape As Boolean = False
        Dim blnBearings As Boolean = False
        Dim blnRiserPads As Boolean = False
        Dim blnNutsAndBoltsKit As Boolean = False
        Dim blnAssembly As Boolean = False

        If chkGripTape.Checked = True Then
            blnGripTape = True
        End If

        If chkBearings.Checked = True Then
            blnBearings = True
        End If

        If chkRiserPads.Checked = True Then
            blnRiserPads = True
        End If

        If chkNutsAndBoltsKit.Checked = True Then
            blnNutsAndBoltsKit = True
        End If

        If chkAssembly.Checked = True Then
            blnAssembly = True
        End If

        Call CalculateMiscellaneous(blnGripTape, blnBearings, blnRiserPads, blnNutsAndBoltsKit, blnAssembly)

    End Sub

    Private Sub mnuDone_Click(sender As System.Object, e As System.EventArgs) Handles mnuDone.Click
        Call btnDone.PerformClick()
    End Sub
End Class