Module proLoop
    'This is used to get the input for area, then loop for the number of rooms.
    Public Sub RoomLoop(ByVal intUINumberOfRooms As Integer, ByVal decUICostOfPaintPerGallon As Decimal)

        Dim strUISizeOfRoom As String
        Dim decSizeOfRoom As Decimal
        Dim decGallonsOfPaint As Decimal
        Dim decCostOfPaintPerRoom As Decimal
        Dim decLaborTimePerRoom As Decimal
        Dim decLaborCostPerRoom As Decimal
        Dim decTotalCostOfPaint As Decimal
        Dim decTotalLaborCost As Decimal
        Dim intRoomCounter As Integer
        Const decLaborCostPerHour As Decimal = 18

        For intRoomCounter = 1 To intUINumberOfRooms

            strUISizeOfRoom = InputBox("Please enter the size of room " & intRoomCounter & " in square feet.")
            If InputValidation(strUISizeOfRoom, decSizeOfRoom, 1, 1000, "the size of the room") = True Then

                decGallonsOfPaint = CalculateAmount(decSizeOfRoom)
                decGallonsOfPaint = Math.Ceiling(decGallonsOfPaint)

                decCostOfPaintPerRoom = CalculateCost(decGallonsOfPaint, decUICostOfPaintPerGallon, decTotalCostOfPaint)
                decCostOfPaintPerRoom = Math.Round(decCostOfPaintPerRoom, 2, MidpointRounding.AwayFromZero)

                decLaborTimePerRoom = CalculateAmount(decSizeOfRoom)
                decLaborTimePerRoom = Math.Round(decLaborTimePerRoom, 1, MidpointRounding.AwayFromZero)

                decLaborCostPerRoom = CalculateCost(decLaborTimePerRoom, decLaborCostPerHour, decTotalLaborCost)
                decLaborCostPerRoom = Math.Round(decLaborCostPerRoom, 2, MidpointRounding.AwayFromZero)

                Call DisplayLoopOutput(intRoomCounter, decSizeOfRoom, decGallonsOfPaint, decCostOfPaintPerRoom, decLaborTimePerRoom, decLaborCostPerRoom)
            Else
                intRoomCounter -= 1
            End If
        Next

        Call DisplayFooterOutput(decTotalCostOfPaint, decTotalLaborCost)
    End Sub
End Module
