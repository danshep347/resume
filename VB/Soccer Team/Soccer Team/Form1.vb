Public Class frmSoccerTeam

    Private Sub btnListMembersAndTotals_Click(sender As System.Object, e As System.EventArgs) Handles btnListMembersAndTotals.Click
        Call ArrayLoad(lstListMembersAndTotals, "A")
    End Sub

    Private Sub btnSortedByTotalPoints_Click(sender As System.Object, e As System.EventArgs) Handles btnSortedByTotalPoints.Click
        Call ArrayLoad(lstSortedByTotalPoints, "T")
    End Sub

    Private Sub btnLoadTeam_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadTeam.Click
        Call ArrayLoad(lstLoadTeam, "L")
    End Sub

    Private Sub mnuFileClose_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub

    Private Sub mnuActionListMembersAndTotals_Click(sender As System.Object, e As System.EventArgs) Handles mnuActionListMembersAndTotals.Click
        btnListMembersAndTotals.PerformClick()
    End Sub

    Private Sub mnuActionSortedByTotalPoints_Click(sender As System.Object, e As System.EventArgs) Handles mnuActionSortedByTotalPoints.Click
        btnSortedByTotalPoints.PerformClick()
    End Sub

    Private Sub mnuActionLoadTeam_Click(sender As System.Object, e As System.EventArgs) Handles mnuActionLoadTeam.Click
        btnLoadTeam.PerformClick()
    End Sub

End Class
