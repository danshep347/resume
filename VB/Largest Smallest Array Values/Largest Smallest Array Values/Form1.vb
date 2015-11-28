Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try

            'declare variables

            Dim dblValues(10) As Double
            Dim intIndex As Integer
            Dim dblLowest As Integer


            'load array

            For intIndex = 1 To 10
                dblValues(intIndex) = CDbl(ListBox1.Items(intIndex))
            Next


            'find lowest and display
            'Label1.Text = "the lowest number is " & dblValues.Min.ToString
            dblLowest = dblValues(1)

            For intIndex = 2 To 10
                If dblValues(intIndex) < dblLowest Then
                    dblLowest = dblValues(intIndex)

                End If
            Next
            Label1.Text = "the lowest number is " & dblLowest.ToString
            'find highest and display
            Label2.Text = "the highest number is " & dblValues.Max.ToString



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
