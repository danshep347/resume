Public Class frmStructures

    Structure Employee
        Dim strEmpSSN As String
        Dim strEmpFirstName As String
        Dim strEmpLastName As String
    End Structure


    Dim strEmployee() As Employee


    Private Sub frmStructures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'declare the object Empfile as an input file 
        Dim EmpFile As System.IO.StreamReader
        Dim strFileName As String = "employees.txt"

        Dim strEmpRecord As String
        Dim intIndex As Integer
        Dim intCount As Integer

        'the following will determine if file exist. 
        'If does, will open, if does not will put out a message box.
        If System.IO.File.Exists(strFileName) Then
            EmpFile = System.IO.File.OpenText(strFileName)
            'I am now going to populate the list box with the employee data
            Do Until EmpFile.Peek = -1
                'read the record from the employee file
                strEmpRecord = EmpFile.ReadLine()

                'need to Redim (redeclare the array)
                'preserve keeps the previous content in the array
                ReDim Preserve strEmployee(intCount)

                'break the record apart into fields based on the commas
                intIndex = strEmpRecord.IndexOf(",")
                strEmployee(intCount).strEmpSSN = strEmpRecord.Substring(0, intIndex)
                strEmpRecord = strEmpRecord.Remove(0, intIndex + 1)
                intIndex = strEmpRecord.IndexOf(",")
                strEmployee(intCount).strEmpFirstName = strEmpRecord.Substring(0, intIndex)
                strEmployee(intCount).strEmpLastName = strEmpRecord.Remove(0, intIndex + 1)

                'increment count for index
                intCount += 1

            Loop
            'make sure you close the file
            EmpFile.Close()
        Else
            MessageBox.Show("Employee File Does Not Exist")
        End If


    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click

        Dim intIndex As Integer

        For intIndex = 0 To strEmployee.Length - 1

            Me.lstEmployees.Items.Add("SSN: " & vbTab & vbTab & strEmployee(intIndex).strEmpSSN)
            Me.lstEmployees.Items.Add("First Name: " & vbTab & strEmployee(intIndex).strEmpFirstName)
            Me.lstEmployees.Items.Add("Last Name: " & vbTab & strEmployee(intIndex).strEmpLastName)
            Me.lstEmployees.Items.Add("")
        Next

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
