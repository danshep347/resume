Public Class frmRainfall
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        'check all textboxes and turn the label red for any invalid data.  
        'make the warning label visible if data is invalid for any textbox.
        'initialize controls and variables to good data condition, and change them on error. 

        Try
            Dim dblMon1 As Double
            Dim dblMon2 As Double
            Dim dblMon3 As Double
            Dim dblMon4 As Double
            Dim dblMon5 As Double
            Dim dblMon6 As Double
            Dim dblMon7 As Double
            Dim dblMon8 As Double
            Dim dblMon9 As Double
            Dim dblMon10 As Double
            Dim dblMon11 As Double
            Dim dblMon12 As Double
            Dim dblTotal As Double
            Dim dblAverage As Double
            Dim strErrorMessage As String = ""

            lblTotal.Text = ""
            lblAverage.Text = ""
            lblWarning.Visible = False
            lbl1.ForeColor = Color.Black
            lbl2.ForeColor = Color.Black
            lbl3.ForeColor = Color.Black
            lbl4.ForeColor = Color.Black
            lbl5.ForeColor = Color.Black
            lbl6.ForeColor = Color.Black
            lbl7.ForeColor = Color.Black
            lbl8.ForeColor = Color.Black
            lbl9.ForeColor = Color.Black
            lbl10.ForeColor = Color.Black
            lbl11.ForeColor = Color.Black
            lbl12.ForeColor = Color.Black


            'month 1
            If Not Double.TryParse(txt1.Text, dblMon1) Then
                lbl1.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check January" & ControlChars.CrLf
            ElseIf dblMon1 < 0 Then
                lbl1.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check January" & ControlChars.CrLf
            ElseIf dblMon1 > 1000 Then
                lbl1.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check January" & ControlChars.CrLf
            Else
                dblTotal += dblMon1

            End If

            'month 2
            If Not Double.TryParse(txt2.Text, dblMon2) Then
                lbl2.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check February" & ControlChars.CrLf
            ElseIf dblMon2 < 0 Then
                lbl2.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check February" & ControlChars.CrLf
            ElseIf dblMon2 > 1000 Then
                lbl2.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check February" & ControlChars.CrLf
            Else
                dblTotal += dblMon2

            End If

            'month 3
            If Not Double.TryParse(txt3.Text, dblMon3) Then
                lbl3.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check March" & ControlChars.CrLf
            ElseIf dblMon3 < 0 Then
                lbl3.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check March" & ControlChars.CrLf
            ElseIf dblMon3 > 1000 Then
                lbl3.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check March" & ControlChars.CrLf
            Else
                dblTotal += dblMon3

            End If

            'month 4
            If Not Double.TryParse(txt4.Text, dblMon4) Then
                lbl4.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check April" & ControlChars.CrLf
            ElseIf dblMon4 < 0 Then
                lbl4.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check April" & ControlChars.CrLf
            ElseIf dblMon4 > 1000 Then
                lbl4.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check April" & ControlChars.CrLf
            Else
                dblTotal += dblMon4

            End If

            'month 5
            If Not Double.TryParse(txt5.Text, dblMon5) Then
                lbl5.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check May" & ControlChars.CrLf
            ElseIf dblMon5 < 0 Then
                lbl5.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check May" & ControlChars.CrLf
            ElseIf dblMon5 > 1000 Then
                lbl5.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check May" & ControlChars.CrLf
            Else
                dblTotal += dblMon5

            End If

            'month 6
            If Not Double.TryParse(txt6.Text, dblMon6) Then
                lbl6.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check June" & ControlChars.CrLf
            ElseIf dblMon6 < 0 Then
                lbl6.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check June" & ControlChars.CrLf
            ElseIf dblMon6 > 1000 Then
                lbl6.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check June" & ControlChars.CrLf
            Else
                dblTotal += dblMon6

            End If

            'month 7
            If Not Double.TryParse(txt7.Text, dblMon7) Then
                lbl7.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check July" & ControlChars.CrLf
            ElseIf dblMon7 < 0 Then
                lbl7.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check July" & ControlChars.CrLf
            ElseIf dblMon7 > 1000 Then
                lbl7.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check July" & ControlChars.CrLf
            Else
                dblTotal += dblMon7

            End If

            'month 8
            If Not Double.TryParse(txt8.Text, dblMon8) Then
                lbl8.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check August" & ControlChars.CrLf
            ElseIf dblMon8 < 0 Then
                lbl8.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check August" & ControlChars.CrLf
            ElseIf dblMon8 > 1000 Then
                lbl8.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check August" & ControlChars.CrLf
            Else
                dblTotal += dblMon8

            End If

            'month 9   this month need work still.
            If Not Double.TryParse(txt6.Text, dblMon6) Then
                lbl6.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check June" & ControlChars.CrLf
            ElseIf dblMon6 < 0 Then
                lbl6.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check June" & ControlChars.CrLf
            ElseIf dblMon6 > 1000 Then
                lbl6.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check June" & ControlChars.CrLf
            Else
                dblTotal += dblMon6

            End If

            'month 10   this month need work still.
            If Not Double.TryParse(txt6.Text, dblMon6) Then
                lbl6.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check June" & ControlChars.CrLf
            ElseIf dblMon6 < 0 Then
                lbl6.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check June" & ControlChars.CrLf
            ElseIf dblMon6 > 1000 Then
                lbl6.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check June" & ControlChars.CrLf
            Else
                dblTotal += dblMon6

            End If

            'month 11   this month need work still.
            If Not Double.TryParse(txt6.Text, dblMon6) Then
                lbl6.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check June" & ControlChars.CrLf
            ElseIf dblMon6 < 0 Then
                lbl6.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check June" & ControlChars.CrLf
            ElseIf dblMon6 > 1000 Then
                lbl6.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check June" & ControlChars.CrLf
            Else
                dblTotal += dblMon6

            End If

            'month 12   this month need work still.
            If Not Double.TryParse(txt6.Text, dblMon6) Then
                lbl6.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check June" & ControlChars.CrLf
            ElseIf dblMon6 < 0 Then
                lbl6.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check June" & ControlChars.CrLf
            ElseIf dblMon6 > 1000 Then
                lbl6.ForeColor = Color.Red
                lblWarning.Visible = True
                strErrorMessage &= "Please Check June" & ControlChars.CrLf
            Else
                dblTotal += dblMon6

            End If


            'calculations
            'If Not lblWarning.Visible = True Then      (this works or you can use the line below)
            If strErrorMessage = "" Then
                dblAverage = dblTotal / 3
                lblTotal.Text = dblTotal.ToString()
                lblAverage.Text = dblAverage.ToString("n2")
            Else
                MessageBox.Show(strErrorMessage)
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        ' Clear the form
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()
        txt4.Clear()
        txt5.Clear()
        txt6.Clear()
        txt7.Clear()
        txt8.Clear()
        txt9.Clear()
        txt10.Clear()
        txt11.Clear()
        txt12.Clear()
        lblTotal.Text = String.Empty
        lblAverage.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        ' End the application
        Me.Close()

    End Sub

End Class