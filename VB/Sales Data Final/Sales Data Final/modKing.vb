Module modKing

    Private intEntryNumber As Integer = 1
    Private ARRAY_NAMES(50) As String
    Private ARRAY_SALES(50) As Decimal

    Public Function funGetNumberOfEntries() As Integer
        Return intEntryNumber
    End Function

    Public Sub proWriteDataToArray(ByVal Name As String, ByVal Sales As Decimal, ByVal EntryNumber As Integer)

        ARRAY_NAMES(intEntryNumber) = Name
        ARRAY_SALES(intEntryNumber) = Sales
        intEntryNumber = EntryNumber + 1

    End Sub

    Public Sub proCalculateSalesData()

        Dim decTotalSales As Decimal = 0
        Dim decAverageSales As Decimal = 0
        Dim decHighestSales As Decimal = 0
        Dim decLowestSales As Decimal = 0

        intEntryNumber -= 1

        If intEntryNumber <= 1 Then
            MessageBox.Show("Please enter sales data before you hit calculate.")
        Else
            decTotalSales = funGetTotal()
            decAverageSales = funGetAverage(decTotalSales)
            decHighestSales = funGetMaximum()
            decLowestSales = funGetMinimum()

            frmSales.lblTotal.Text = decTotalSales
            frmSales.lblAverage.Text = decAverageSales
            frmSales.lblHighest.Text = decHighestSales
            frmSales.lblLowest.Text = decLowestSales

        End If

        intEntryNumber += 1

    End Sub

    Private Function funGetTotal() As Decimal

        Dim dectmpTotalSales As Decimal = 0

        For intCounter = 1 To intEntryNumber

            dectmpTotalSales += ARRAY_SALES(intCounter)

        Next

        Return dectmpTotalSales
    End Function

    Private Function funGetAverage(ByVal decTotal As Decimal) As Decimal

        Dim dectmpAverage As Decimal = 0

        dectmpAverage = decTotal / intEntryNumber

        Return dectmpAverage
    End Function

    Private Function funGetMaximum() As Decimal

        Dim ARRAY_TMP(intEntryNumber) As Decimal
        Dim intStartFromZeroCounter As Integer = 0
        Dim decSalesMax As Decimal = 0

        For intCounter = 1 To intEntryNumber

            ARRAY_TMP(intStartFromZeroCounter) = ARRAY_SALES(intCounter)
            intStartFromZeroCounter += 1

        Next

        decSalesMax = ARRAY_TMP.Max()

        Return decSalesMax
    End Function

    Private Function funGetMinimum() As Decimal

        Dim intTempEntryNumber As Decimal = intEntryNumber - 1
        Dim ARRAY_TMP(intTempEntryNumber) As Decimal
        Dim intStartFromZeroCounter As Integer = 0
        Dim decSalesMin As Decimal = 0

        For intCounter = 1 To intEntryNumber

            ARRAY_TMP(intStartFromZeroCounter) = ARRAY_SALES(intCounter)
            intStartFromZeroCounter += 1

        Next

        decSalesMin = ARRAY_TMP.Min()

        Return decSalesMin
    End Function

    Public Sub WriteToDisk(ByVal strFileName As String)

        Dim intCounter As Integer
        Dim strOutput As String
        Dim FileWriter As System.IO.StreamWriter

        intEntryNumber -= 1

        FileWriter = System.IO.File.CreateText(strFileName)

        For intCounter = 1 To intEntryNumber
            strOutput = ""
            strOutput &= ARRAY_NAMES(intCounter)
            strOutput &= ", "

            strOutput &= ARRAY_SALES(intCounter).ToString

            FileWriter.WriteLine(strOutput)

        Next

        FileWriter.Close()

        intEntryNumber += 1

    End Sub

End Module
