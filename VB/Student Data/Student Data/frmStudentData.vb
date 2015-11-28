Public Class frmStudentData

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim objStudentRecord As New Student

        GetData(objStudentRecord)

        lblGrade.Text = objStudentRecord.TestGrade

        SaveRecord(objStudentRecord)



    End Sub

    Private Sub Getdata(ByVal student As Student)
        student.FirstName = Me.txtFirstName.Text
        student.LastName = Me.txtLastName.Text
        student.StudentID = Me.txtIDNumber.Text
        student.TestAverage = Me.txtTestAverage.Text


    End Sub
    Private Sub Saverecord(ByVal student As Student)
        Dim objStudentData As New StudentDataFile

        objStudentData.FirstName = student.FirstName
        objStudentData.LastName = student.LastName
        objStudentData.StudentID = student.StudentID
        objStudentData.TestAverage = student.TestAverage

        objStudentData.WriteRecord()




    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
