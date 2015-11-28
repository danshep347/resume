Option Strict On
Imports System.IO
Public Class Form1
    Private strFileName As String = "C:\Users\Daniel\Documents\Test.txt"
    Private Sub btnCreateFile_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateFile.Click
        Dim intnumFriends As Integer = 3
        Dim strFilename, strFriend, strPhone, stroutput As String
        Dim intcount As Integer
        Dim friendFile As StreamWriter
        With SaveFileDialog1
            .FileName = strFilename
            .ShowDialog()
            strFilename = .FileName
        End With





        Try
            'strFilename = InputBox("enter a drive, path, file, extension", "File Name", "C:\Test.txt")

            'FileOpen(1, strFilename, OpenMode.Output)
            'For intcount = 1 To intnumFriends
            '    stroutput = "Bob" & ", " & (intnumFriends.ToString("d6")) 'build the line manually, no quote around numbers
            '    WriteLine(1, stroutput)
            '    WriteLine(1, "Bob", intnumFriends.ToString("d6")) 'quotes around number if formatted to a string
            'Next
            'FileClose(1)

            'This section uses the StreamWriter object as an alternative.  
            'comment the previous 7 lines and try running this section
            If File.Exists(strFilename) Then  'FileIO.FileSystem.FileExists(strFilename)
                friendFile = File.AppendText(strFilename)
            Else
                friendFile = File.CreateText(strFilename)
            End If
            For intcount = 1 To intnumFriends
                strFriend = "Bob" & intcount.ToString()
                strPhone = "151" & intcount.ToString()
                ' concatenate ChrW(9) or vbTab or ControlChars.Tab instead of comma if desired
                stroutput = strFriend & "," & strPhone 'output line has to be built
                friendFile.WriteLine(stroutput)
            Next
            friendFile.Close()

            MessageBox.Show("done")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub



    Private Sub btnRead_Click(sender As System.Object, e As System.EventArgs) Handles btnRead.Click
        Dim strFilename, strFriend, strPhone, stroutput, strnull As String
        Dim intcount As Integer
        Dim friendFile As StreamReader
        strFilename = "C:\Test.txt"
        With OpenFileDialog1
            .FileName = strFilename
            .Filter = "All Files (*.*)|*.*"
            .ShowDialog()
            strFilename = .FileName

        End With

        Try
            '  friendFile = File.OpenText(strFilename)
            'Do While Not friendFile.EndOfStream
            '    'For intcount = 1 To 2
            ' strFriend = friendFile.ReadLine 
            '    ListBox1.Items.Add(strFriend)
            '    'Next
            'Loop
            If File.Exists(strFilename) Then
                FileOpen(1, "C:\Test.txt", OpenMode.Input)
                Do While Not EOF(1)


                    Input(1, strFriend)
                    Input(1, strPhone)
                    ListBox1.Items.Add(strFriend & "  " & strPhone)
                Loop
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        FileClose(1)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnConvert.Click

        Dim strFilename, strvar As String
        Dim intfound, intstart As Integer
        Dim friendFile As StreamReader
        Dim output As StreamWriter
        strFilename = "C:\Test.txt"

        Try
            friendFile = File.OpenText(strFilename)

            output = File.CreateText("C:\Test.txt")

            Do While Not friendFile.EndOfStream

                strvar = friendFile.ReadLine
                intfound = 0
                intstart = 0
                Do While intfound <> -1
                    'MessageBox.Show(Asc(strvar.Substring(4, 1)).ToString)
                    intfound = strvar.IndexOf(Chr(9), intstart, strvar.Length - (intstart + 1))
                    If intfound > -1 Then
                        strvar = strvar.Remove(intfound, 1)
                        strvar = strvar.Insert(intfound, ",")
                        If intstart < strvar.Length - 1 Then
                            intstart = intfound + 1
                        End If
                    End If
                Loop
                'after all replacements are done, write to output fiie
                output.WriteLine(strvar)
            Loop
            friendFile.Close()
            output.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

   
    Private Sub btnOneField_Click(sender As System.Object, e As System.EventArgs) Handles btnOneField.Click

        Dim stroutput, strFilename As String
        Try
            strFilename = InputBox("enter a drive, path, file, extension", "File Name", "C:\Test.txt")

            FileOpen(1, strFilename, OpenMode.Output)
            For intcount = 1 To 4

                stroutput = "Bob" & intcount.ToString
                WriteLine(1, stroutput)
            Next
            FileClose(1)
                Catch ex As Exception
        End Try

    End Sub
End Class
