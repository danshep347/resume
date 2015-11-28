Option Strict On
'Written by Daniel James Shepherd. This program is used to design a skateboard.
Public Class frmSkateboardDesigner

    Private Sub btnChooseDeck_Click(sender As System.Object, e As System.EventArgs) Handles btnChooseDeck.Click
        Dim frmDeckSelector As New frmDeckSelector
        frmDeckSelector.ShowDialog()
    End Sub

    Private Sub btnChooseTruckAssembly_Click(sender As System.Object, e As System.EventArgs) Handles btnChooseTruckAssembly.Click
        Dim frmTruckAssemblies As New frmTruckAssemblies
        frmTruckAssemblies.ShowDialog()
    End Sub

    Private Sub btnChooseWheels_Click(sender As System.Object, e As System.EventArgs) Handles btnChooseWheels.Click
        Dim frmWheelSelector As New frmWheels
        frmWheelSelector.ShowDialog()
    End Sub

    Private Sub btnChooseMiscellaneous_Click(sender As System.Object, e As System.EventArgs) Handles btnChooseMiscellaneous.Click
        Dim frmMiscellaneous As New frmMiscellaneous
        frmMiscellaneous.ShowDialog()
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        lstOutput.Items.Clear()
        lblSubtotal.Text = ""
        lblTaxAmount.Text = ""
        lblTotalCost.Text = ""
        Call Initialize()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub mnuDone_Click(sender As System.Object, e As System.EventArgs) Handles mnuDone.Click
        CalculateTotal()
    End Sub

    Private Sub mnuDecks_Click(sender As System.Object, e As System.EventArgs) Handles mnuDecks.Click
        btnChooseDeck.PerformClick()
    End Sub

    Private Sub mnuTrucks_Click(sender As System.Object, e As System.EventArgs) Handles mnuTrucks.Click
        btnChooseTruckAssembly.PerformClick()
    End Sub

    Private Sub mnuWheels_Click(sender As System.Object, e As System.EventArgs) Handles mnuWheels.Click
        btnChooseWheels.PerformClick()
    End Sub

    Private Sub mnuMiscellaneous_Click(sender As System.Object, e As System.EventArgs) Handles mnuMiscellaneous.Click
        btnChooseMiscellaneous.PerformClick()
    End Sub
End Class
