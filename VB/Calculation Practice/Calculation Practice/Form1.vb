Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dblX As Double
        dblX = 23 * (79 / 1000) + 10
        MessageBox.Show(dblX.ToString)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dblE As Double
        dblE = 700 * 0.62
        MessageBox.Show(dblE.ToString)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dblY As Double
        dblY = (4987 + 3909 + 5292) / 3
        MessageBox.Show(dblY.ToString)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim dblR As Double
        dblR = (2 * 3) - (5 * 781)
        MessageBox.Show(dblR.ToString)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim dblZ As Double
        dblZ = (11 / 12) * (13 / 14)
        MessageBox.Show(dblZ.ToString)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim dblA As Double
        dblA = (2 / 3) * (1 / 7) + 3.5
        MessageBox.Show(dblA.ToString)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim dblS As Double
        dblS = 2 * (8 ^ (1 / 2))
        MessageBox.Show(dblS.ToString)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim dblBase As Double
        dblBase = (4 / 3) * (((5 ^ 2) + (7 ^ 2)) ^ (1 / 2))
        MessageBox.Show(dblBase.ToString)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim dblI As Double
        dblI = 1200 * ((1 + (0.05 / 12)) ^ 3)
        MessageBox.Show(dblI.ToString)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim dblArea As Double
        dblArea = (((3 + 4 + 5) / 2) * (((3 + 4 + 5 / 2) - 3) * (((3 + 4 + 5) / 2) - 4) * (((3 + 4 + 5) / 2) - 5))) ^ (1 / 2)
        MessageBox.Show(dblArea.ToString)
    End Sub
End Class
