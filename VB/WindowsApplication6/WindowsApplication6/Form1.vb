Public Class frmWorkshopSelector

    Private Sub btnAddWorkshop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddWorkshop.Click
        Dim decRegistration As Decimal
        Dim decLodging As Decimal
        Dim decTotalCost As Decimal
        Dim intNumberDays As Integer
        Dim strWorkshop As String
        Dim strLocation As String



        'If lstWorkshop.SelectedIndex = -1 Then
        '    MessageBox.Show("please select a workshop")
        'ElseIf lstWorkshop.SelectedIndex = 0 Then
        '    decRegistration = 595
        '    intNumberDays = 3
        'ElseIf lstWorkshop.SelectedIndex = 1 Then
        '    decRegistration = 695
        '    intNumberDays = 3
        'ElseIf lstWorkshop.SelectedIndex = 2 Then
        '    decRegistration = 995
        '    intNumberDays = 3
        'ElseIf lstWorkshop.SelectedIndex = 3 Then
        '    decRegistration = 1295
        '    intNumberDays = 5
        'ElseIf lstWorkshop.SelectedIndex = 4 Then
        '    decRegistration = 395
        '    intNumberDays = 1
        'End If

        strWorkshop = lstWorkshop.Items(lstWorkshop.SelectedIndex).ToString()

        Select Case strworkshop
            Case Is = "Handling Stress"
                decRegistration = 595
                intNumberDays = 3
            Case Is = "Time Management"
                decRegistration = 695
                intNumberDays = 3
            Case Is = "Supervision Skills"
                decRegistration = 995
                intNumberDays = 3
            Case Is = "Negotiation"
                decRegistration = 1295
                intNumberDays = 5
            Case Is = "How to Interview"
                decRegistration = 395
                intNumberDays = 1
        End Select

        strLocation = lstLocation.Items(lstLocation.SelectedIndex).ToString()

        Select Case strLocation
            Case Is = "Austin"
                decLodging = 95
            Case Is = "Chicago"
                decLodging = 125
            Case Is = "Dallas"
                decLodging = 110
            Case Is = "Orlando"
                decLodging = 100
            Case Is = "Phoenix"
                decLodging = 92
            Case Is = "Raleigh"
                decLodging = 90
        End Select

        decTotalCost = decRegistration + (decLodging * intNumberDays)

        lstCosts.Items.Add(decTotalCost)


    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
