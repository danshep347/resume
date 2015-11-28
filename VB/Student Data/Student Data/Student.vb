Public Class Student

    'member variables

    Private lname As String
    Private fname As String
    Private id As String
    Private testAvg As Single

    'constructor

    Public Sub New()
        fname = ""
        lname = ""
        id = ""
        testAvg = 0.0
    End Sub

    'lastname property procedures

    Public Property LastName() As String
        Get
            Return lname
        End Get
        Set(ByVal value As String)
            lname = value
        End Set
    End Property

    'firstname property procedures

    Public Property FirstName() As String
        Get
            Return fname
        End Get
        Set(ByVal value As String)
            fname = value
        End Set
    End Property

    'ID Number property procedures

    Public Property StudentID() As String
        Get
            Return id
        End Get
        Set(ByVal value As String)
            id = value
        End Set
    End Property

    'TestAvg property procedures

    Public Property TestAverage() As String
        Get
            Return testAvg
        End Get
        Set(ByVal value As String)
            If value >= 0.0 And value <= 100.0 Then
                testAvg = value
            Else
                MessageBox.Show("Invalue test average.", "Error")
            End If
        End Set
    End Property

    'TestGrade property procedure
    ReadOnly Property TestGrade() As Char
        Get
            Dim grade As Char
            Select Case testAvg
                Case 90 To 100
                    grade = "A"
                Case 80 To 90
                    grade = "B"
                Case 70 To 80
                    grade = "C"
                Case 60 To 70
                    grade = "D"
                Case Else
                    grade = "F"
            End Select
            Return grade
        End Get
    End Property

    Public Sub clear()
        fname = ""
        lname = ""
        id = ""
        testAvg = 0.0

    End Sub

    Public Function Determine_Grade() As Char
        Dim grade As Char
        Select Case testAvg
            Case 90 To 100
                grade = "A"
            Case 80 To 90
                grade = "B"
            Case 70 To 80
                grade = "C"
            Case 60 To 70
                grade = "D"
            Case Else
                grade = "F"
        End Select
        Return grade

    End Function
End Class
