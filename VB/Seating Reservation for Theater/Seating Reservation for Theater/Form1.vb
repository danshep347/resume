Public Class frmSeatingReservationForTheater

    Private chkSeats(,) As System.Windows.Forms.CheckBox
    Private lblSeats() As System.Windows.Forms.Label

    Private Const cintCheckBoxHeight As Integer = 15
    Private Const cintCheckBoxWidth As Integer = 15

    Private Const cintSeats As Integer = 10
    Private Const cintRows As Integer = 25

    Private mintFull As Integer
    Private mintEmpty As Integer

    Private pntCurrent As System.Drawing.Point

    Private Sub ConfigureSeating()

        Dim pintSeatCurrent, pintRowCurrent As Integer

        ReDim chkSeats(cintSeats, cintRows)
        ReDim lblSeats(cintRows)

        mintEmpty = cintSeats * cintRows

        For pintSeatCurrent = 0 To cintSeats - 1
            For pintRowCurrent = 0 To cintRows - 1
                pntCurrent = New Point((pintSeatCurrent + 1) * cintCheckBoxWidth, _
                    (pintRowCurrent + 1) * cintCheckBoxHeight)
                Call CreateCheckBox(pintSeatCurrent, pintRowCurrent, pntCurrent)
            Next
        Next

        For pintSeatCurrent = 0 To cintSeats - 1

            If pintSeatCurrent = 9 Then

                Call CreateLabel(pintSeatCurrent)
                lblSeats(pintSeatCurrent).Left = (pintSeatCurrent + 1) * (cintCheckBoxWidth - 0.3)
                lblSeats(pintSeatCurrent).Top = 0
                lblSeats(pintSeatCurrent).Height = 15
                lblSeats(pintSeatCurrent).Width = 20

            Else

                Call CreateLabel(pintSeatCurrent)
                lblSeats(pintSeatCurrent).Left = (pintSeatCurrent + 1) * cintCheckBoxWidth
                lblSeats(pintSeatCurrent).Top = 0
                lblSeats(pintSeatCurrent).Height = 15
                lblSeats(pintSeatCurrent).Width = 15

            End If

        Next

    End Sub

    Private Sub CreateCheckBox(ByVal pintSeatCurrent As Integer, ByVal pintRowcurrent As Integer, ByVal pnt As Point)

        chkSeats(pintSeatCurrent, pintRowcurrent) = New CheckBox()
        chkSeats(pintSeatCurrent, pintRowcurrent).Visible = True

        chkSeats(pintSeatCurrent, pintRowcurrent).Size = _
            New System.Drawing.Size(cintCheckBoxWidth, cintCheckBoxHeight)

        chkSeats(pintSeatCurrent, pintRowcurrent).Location = pnt

        AddHandler chkSeats(pintSeatCurrent, pintRowcurrent).CheckedChanged, _
            AddressOf chkseats_CheckedChanged

        Me.pnlSeats.Controls.Add(chkSeats(pintSeatCurrent, pintRowcurrent))

    End Sub

    Private Sub CreateLabel(ByVal pintSeatCurrent As Integer)
        lblSeats(pintSeatCurrent) = New Label()
        lblSeats(pintSeatCurrent).Visible = True
        lblSeats(pintSeatCurrent).Text = (pintSeatCurrent + 1).ToString()
        Me.pnlSeats.Controls.Add(lblSeats(pintSeatCurrent))
    End Sub

    Private Sub chkseats_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim chkCurrent As System.Windows.Forms.CheckBox

        chkCurrent = CType(sender, System.Windows.Forms.CheckBox)

        Select Case chkCurrent.Checked
            Case True
                mintFull += 1
                mintEmpty -= 1
            Case False
                mintFull -= 1
                mintEmpty += 1
        End Select

        lblFull.Text = mintFull.ToString()
        lblEmpty.Text = mintEmpty.ToString()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call ConfigureSeating()
    End Sub

    Private Sub mnuFile_Exit_Click(sender As System.Object, e As System.EventArgs) Handles mnuFile_Exit.Click
        Me.Close()
    End Sub

    Private Sub mnuSeats_Clear_Click(sender As System.Object, e As System.EventArgs) Handles mnuSeats_Clear.Click

        Dim ctlCurrent As Control
        Dim chkCurrent As CheckBox

        For Each ctlCurrent In pnlSeats.Controls

            If TypeOf (ctlCurrent) Is System.Windows.Forms.CheckBox Then
                chkCurrent = CType(ctlCurrent, System.Windows.Forms.CheckBox)
                chkCurrent.Checked = False
            End If

        Next

        lblFull.Text = ""
        lblEmpty.Text = ""

    End Sub
End Class
