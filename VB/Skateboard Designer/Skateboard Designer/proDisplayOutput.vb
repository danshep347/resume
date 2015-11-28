Module proDisplayOutput
    'This module is used to display the output.
    Public Sub DisplayOutput(ByVal decCost As Decimal, ByVal strName As String, ByVal strType As String)

        Dim strOutput As String = ""

        strOutput = "You selected " & strName & " for " & strType & " that costs " & decCost.ToString("c2")

        frmSkateboardDesigner.lstOutput.Items.Add(strOutput)

    End Sub

    Public Sub DisplayMiscellaneous(ByVal decMiscellaneousTotal As Decimal, ByVal strMiscellaneous As String)

        Dim strOutput As String = ""

        strOutput = "You selected " & strMiscellaneous & "which costs " & decMiscellaneousTotal.ToString("c2")

        frmSkateboardDesigner.lstOutput.Items.Add(strOutput)

    End Sub

    Public Sub DisplayTotal(ByVal decSubtotal As Decimal, ByVal decTaxAmount As Decimal, ByVal decTotalCost As Decimal)

        frmSkateboardDesigner.lblSubtotal.Text = decSubtotal.ToString("c2")
        frmSkateboardDesigner.lblTaxAmount.Text = decTaxAmount.ToString("c2")
        frmSkateboardDesigner.lblTotalCost.Text = decTotalCost.ToString("c2")

        Call Initialize()

    End Sub
End Module
