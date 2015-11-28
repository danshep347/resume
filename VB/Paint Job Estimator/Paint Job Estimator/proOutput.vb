Module proOutput
    'This is used to output the data from the loop.
    Public Sub DisplayLoopOutput(ByVal intRoomCounter As Integer, ByVal decUISizeOfRoom As Decimal, ByVal decGallonsOfPaint As Decimal, ByVal decCostOfPaintPerRoom As Decimal, ByVal decLaborTimePerRoom As Decimal, ByVal decLaborCostPerRoom As Decimal)

        Dim strHeader As String
        Dim strOutput As String

        strHeader = String.Format(" {0,5} {1,10} {2,10} {3,10} {4,10} {5,10} ", "Room", "Sq. ft.", "Gallons", "Cost", "Labor Time", "Labor Cost")
        strOutput = String.Format(" {0,5} {1,10} {2,10} {3,10} {4,10} {5,10} ", intRoomCounter.ToString("n0"), decUISizeOfRoom.ToString("n0"), decGallonsOfPaint.ToString("n0"), decCostOfPaintPerRoom.ToString("c2"), decLaborTimePerRoom.ToString("n1"), decLaborCostPerRoom.ToString("c2"))

        frmPaintJobEstimator.lstOutput.Items.Add(strHeader)
        frmPaintJobEstimator.lstOutput.Items.Add(strOutput)

    End Sub
    'This is used to output the footer string containing the total cost of paint and labor.
    Public Sub DisplayFooterOutput(ByVal decTotalCostOfPaint As Decimal, ByVal decTotalLaborCost As Decimal)

        Dim strDivider As String
        Dim strOutput As String

        strDivider = "-----------------------------------------------------------------------------------------------"
        strOutput = "Total Paint cost is " & decTotalCostOfPaint.ToString("c2") & " and the labor cost total is " & decTotalLaborCost.ToString("c2")

        frmPaintJobEstimator.lstOutput.Items.Add(strDivider)
        frmPaintJobEstimator.lstOutput.Items.Add(strOutput)

    End Sub
End Module
