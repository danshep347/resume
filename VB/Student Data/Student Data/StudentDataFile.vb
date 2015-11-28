Public Class StudentDataFile

    Private lname As String
    Private fname As String
    Private id As String
    Private testAvg As Single

    Public Sub New()
        fname = ""
        lname = ""
        id = ""
        testAvg = 0.0
    End Sub

    'lastname property procedures

    WriteOnly Property LastName() As String

        Set(ByVal value As String)
            lname = value
        End Set
    End Property

    'firstname property procedures

    WriteOnly Property FirstName() As String

        Set(ByVal value As String)
            fname = value
        End Set
    End Property


    'lastname ID procedures

    WriteOnly Property StudentID() As String

        Set(ByVal value As String)
            id = value
        End Set
    End Property

    'firstname TestAvg procedures

    WriteOnly Property TestAverage() As String

        Set(ByVal value As String)
            testAvg = value
        End Set
    End Property

    Sub WriteRecord()
        Dim objWriter As IO.StreamWriter

        Try
            objWriter = IO.File.AppendText("student.txt")
            objWriter.Write(lname & ",")
            objWriter.Write(fname & ",")
            objWriter.Write(id & ",")
            objWriter.WriteLine(testAvg & ",")

            objWriter.Close()

        Catch ex As Exception
            MessageBox.Show("No device available - program aborted", "error")
            Application.Exit()

        End Try


    End Sub


End Class
