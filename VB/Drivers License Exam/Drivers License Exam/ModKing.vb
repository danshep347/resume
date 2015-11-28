Module ModKing

    Private CORRECT_ANSWERS() As Char = {"B", "D", "A", "A", "C", "A", "B", "A", "C", "D",
                                         "B", "C", "D", "A", "D", "C", "C", "B", "D", "A"}
    Private USERS_ANSWERS(19) As Char
    Private SELECTED_ANSWERS() As ComboBox = {frmDriversLicenseExam.cmbQuestion1, frmDriversLicenseExam.cmbQuestion2, frmDriversLicenseExam.cmbQuestion3,
                                          frmDriversLicenseExam.cmbQuestion4, frmDriversLicenseExam.cmbQuestion5, frmDriversLicenseExam.cmbQuestion6,
                                          frmDriversLicenseExam.cmbQuestion7, frmDriversLicenseExam.cmbQuestion8, frmDriversLicenseExam.cmbQuestion9,
                                          frmDriversLicenseExam.cmbQuestion10, frmDriversLicenseExam.cmbQuestion11, frmDriversLicenseExam.cmbQuestion12,
                                          frmDriversLicenseExam.cmbQuestion13, frmDriversLicenseExam.cmbQuestion14, frmDriversLicenseExam.cmbQuestion15,
                                          frmDriversLicenseExam.cmbQuestion16, frmDriversLicenseExam.cmbQuestion17, frmDriversLicenseExam.cmbQuestion18,
                                          frmDriversLicenseExam.cmbQuestion19, frmDriversLicenseExam.cmbQuestion20}
    Private strCorrectMessage As String = ". The questions you answered correctly were :"
    Private strWrongMessage As String = ". The questions you answered incorrectly were :"
    Private strFinalGrade As String = ""

    Public Sub proGradeTest()

        Dim frmResults As New frmResults
        Dim intNumberOfCorrectAnswers As Integer = 0
        Dim strInvalidDataMessage As String = "Please select an answer for question"

        If funInputValidation(strInvalidDataMessage) = True Then

            For intCount = 0 To 19

                If SELECTED_ANSWERS(intCount).SelectedItem = CORRECT_ANSWERS(intCount) Then

                    intNumberOfCorrectAnswers += 1
                    strCorrectMessage &= " " & (intCount + 1).ToString

                Else

                    strWrongMessage &= " " & (intCount + 1).ToString

                End If

            Next

            If intNumberOfCorrectAnswers >= 15 Then

                strFinalGrade = "You passed, you answered " & intNumberOfCorrectAnswers.ToString & " out of 20 correctly"

            Else

                strFinalGrade = "You failed, you answered " & intNumberOfCorrectAnswers.ToString & " out of 20 correctly"

            End If

            If intNumberOfCorrectAnswers = 20 Then
                strWrongMessage &= " none."
            End If

            If intNumberOfCorrectAnswers = 0 Then
                strCorrectMessage &= " none"
            End If

            frmResults.ShowDialog()

        Else

            MessageBox.Show(strInvalidDataMessage)

        End If

    End Sub

    Public Sub proClearTest()

        For intCount = 0 To 19

            SELECTED_ANSWERS(intCount).SelectedIndex = -1

        Next

        frmResults.lblFinalResult.Text = ""
        strCorrectMessage = ". The questions you answered correctly were :"
        strWrongMessage = ". The questions you answered incorrectly were :"
        strFinalGrade = ""

    End Sub

    Private Function funInputValidation(ByRef strMessage As String) As Boolean

        Dim blnGoodData As Boolean = True

        For intCount = 0 To 19

            If SELECTED_ANSWERS(intCount).SelectedItem = "" Then
                strMessage &= " " & (intCount + 1).ToString
                blnGoodData = False
            End If

        Next

        Return blnGoodData
    End Function

    Public Function funGetOutputMessage() As String

        Dim strOutput As String

        strOutput = strFinalGrade & strCorrectMessage & strWrongMessage

        Return strOutput
    End Function

End Module
