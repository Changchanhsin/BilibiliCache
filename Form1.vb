Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim i As ListViewItem
        Dim count As Integer
        Dim root As IO.DirectoryInfo
        Dim subRoots() As IO.DirectoryInfo
        Dim subRoot As IO.DirectoryInfo
        Dim folders() As IO.DirectoryInfo
        Dim folder As IO.DirectoryInfo
        Dim filefolders() As IO.DirectoryInfo
        Dim files() As IO.FileInfo

        lvwItems.Items.Clear()
        cboSource.Items.Add(cboSource.Text)

        pgbProgress.Style = ProgressBarStyle.Continuous
        pgbProgress.Visible = True
        lblProgress.Visible = True
        lblProgress.Text = "Finding folders..."
        Application.DoEvents()

        count = 0
        root = New IO.DirectoryInfo(cboSource.Text)
        subRoots = root.GetDirectories()
        pgbProgress.Maximum = subRoots.Count
        pgbProgress.Value = 0
        Application.DoEvents()
        For Each subRoot In subRoots
            folders = subRoot.GetDirectories()
            pgbProgress.Maximum += folders.Count - 1
            For Each folder In folders
                i = lvwItems.Items.Add(folder.FullName)
                i.StateImageIndex = 0
                i.SubItems.Add(GetItemTitle(folder.FullName))
                i.SubItems.Add(folders.Count)
                i.SubItems.Add(GetItemSubTitle(folder.FullName))
                'i.SubItems(3).Text = Replace(i.SubItems(3).Text, i.SubItems(1).Text, "")
                i.SubItems.Add(GetItemType(folder.FullName))
                filefolders = folder.GetDirectories()
                If (filefolders.Count > 0) Then
                    files = filefolders(0).GetFiles("*blv")
                    i.SubItems.Add(files.Count)
                Else
                    i.SubItems.Add("")
                End If
                pgbProgress.Value += 1
                Application.DoEvents()
            Next
        Next

        lvwItems.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        pgbProgress.Visible = False
        lblProgress.Text = "Total " & subRoots.Count & " items, " & pgbProgress.Maximum & " files."
    End Sub

    Private Sub cboSource_GotFocus(sender As Object, e As EventArgs) Handles cboSource.GotFocus
        Me.AcceptButton = btnCheck
    End Sub

    Private Sub cboSource_LostFocus(sender As Object, e As EventArgs) Handles cboSource.LostFocus
        Me.AcceptButton = Me.CancelButton
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim i As ListViewItem
        Dim count As Integer

        count = 0
        pgbProgress.Maximum = lvwItems.Items.Count
        pgbProgress.Style = ProgressBarStyle.Continuous
        pgbProgress.Value = 0
        pgbProgress.Visible = True
        lblProgress.Text = "Creating batch file..."

        lvwItems.Visible = False
        Dim file = New IO.StreamWriter(cboSource.Text & "\run.bat", False, System.Text.Encoding.UTF8)
        file.Write(vbCrLf & "chcp 65001" & vbCrLf & vbCrLf)
        For Each i In lvwItems.Items
            If i.SubItems(4).Text = "blv" Then
                file.Write(ConvertBLV(i.SubItems(0).Text, i.SubItems(3).Text, i.StateImageIndex))
            End If
            If i.SubItems(4).Text = "m4s" Then
                file.Write(ConvertM4S(i.SubItems(0).Text, i.SubItems(3).Text, i.StateImageIndex))
            End If
            pgbProgress.Value = count
            count += 1
            Application.DoEvents()
        Next
        file.Close()
        lvwItems.Visible = True
        pgbProgress.Visible = False
        lblProgress.Text = "Total " & count & " files."
    End Sub

    Function ConvertBLV(sPath As String, sOutputTitle As String, fType As Integer) As String
        Try
            ConvertBLV = ""
            Dim folder As IO.DirectoryInfo
            Dim i As Integer
            Dim j As Integer
            Dim paramCopy As String
            Dim paramToMP3 As String
            If chkCopyStream.Checked = True Then
                paramCopy = "-c copy "
            Else
                paramCopy = ""
            End If
            If chkToMp3.Checked = True Then
                paramToMP3 = ".mp3"
            Else
                paramToMP3 = ".m4a"
            End If

            Dim root = New IO.DirectoryInfo(sPath)
            Dim folders = root.GetDirectories()
            ConvertBLV = ConvertBLV & vbCrLf & "del files.txt" & vbCrLf
            For Each folder In folders
                Dim files = folder.GetFiles("*.blv")
                If files.Count <= 0 Then
                    ConvertBLV = ""
                    Exit Function
                End If
                For i = 0 To files.Count - 1
                    ConvertBLV = ConvertBLV & "echo file '" & folder.FullName & "\" & i & ".blv' >> files.txt" & vbCrLf
                Next
            Next
            Dim iChar As String
            For Each iChar In IO.Path.GetInvalidFileNameChars()
                sOutputTitle = sOutputTitle.Replace(iChar, "_")
            Next
            sOutputTitle = sOutputTitle.Replace("?", "_")
            'If j = 0 Then

            If fType = 0 Then ' VIDEO and VOICE
                ConvertBLV = ConvertBLV & "ffmpeg -f concat -safe 0 -i files.txt " & paramCopy & """" & sOutputTitle & ".mp4""" & vbCrLf
                ConvertBLV = ConvertBLV & "ffmpeg -i """ & sOutputTitle & ".mp4"" -vn -y """ & sOutputTitle & paramToMP3 & """" & vbCrLf
            End If
            If fType = 1 Then ' VIDEO only
                ConvertBLV = ConvertBLV & "ffmpeg -f concat -safe 0 -i files.txt " & paramCopy & """" & sOutputTitle & ".mp4""" & vbCrLf
            End If
            If fType = 2 Then ' VOICE only
                ConvertBLV = ConvertBLV & "ffmpeg -f concat -safe 0 -i files.txt """ & sOutputTitle & paramToMP3 & """ -vn -y " & vbCrLf
            End If
            ConvertBLV &= vbCrLf
        Catch ex As Exception
            ConvertBLV = ""
        End Try
    End Function

    Function ConvertM4S(sPath As String, sOutputTitle As String, fType As Integer) As String
        Try
            ConvertM4S = ""
            Dim folder As IO.DirectoryInfo
            Dim j As Integer
            Dim paramCodec As String
            Dim paramToMP3 As String
            Dim paramAcodec As String
            If chkCopyStream.Checked = True Then
                paramCodec = "-codec copy "
            Else
                paramCodec = ""
            End If
            If chkToMp3.Checked = True Then
                paramToMP3 = ".mp3"
                paramAcodec = ""
            Else
                paramToMP3 = ".m4a"
                paramAcodec = "-acodec copy "
            End If

            Dim root = New IO.DirectoryInfo(sPath)
            Dim folders = root.GetDirectories()
            Dim iChar As String
            For Each iChar In IO.Path.GetInvalidFileNameChars()
                sOutputTitle = sOutputTitle.Replace(iChar, "_")
            Next

            If fType = 0 Then ' VIDEO and VOICE
                For Each folder In folders
                    ConvertM4S = ConvertM4S & "ffmpeg.exe -i """ & folder.FullName & "\video.m4s"" -i """ & folder.FullName & "\audio.m4s"" " & paramCodec & """" & sOutputTitle & ".mp4""" & vbCrLf
                Next
                ConvertM4S = ConvertM4S & "ffmpeg -i """ & sOutputTitle & ".mp4"" -vn -y " & paramAcodec & """" & sOutputTitle & paramToMP3 & """" & vbCrLf
            End If
            If fType = 1 Then ' VIDEO only
                For Each folder In folders
                    ConvertM4S = ConvertM4S & "ffmpeg.exe -i """ & folder.FullName & "\video.m4s"" -i """ & folder.FullName & "\audio.m4s"" " & paramCodec & """" & sOutputTitle & ".mp4""" & vbCrLf
                Next
            End If
            If fType = 2 Then ' VOICE only
                For Each folder In folders
                    ConvertM4S = ConvertM4S & "ffmpeg.exe -i """ & folder.FullName & "\audio.m4s"" " & paramAcodec & """" & sOutputTitle & paramToMP3 & """" & vbCrLf
                Next
            End If

            ConvertM4S &= vbCrLf
        Catch ex As Exception
            ConvertM4S = ""
        End Try
    End Function

    Function GetSubString(sSrc As String, sStart As String, sEnd As String) As String
        GetSubString = ""
        Dim iB = InStr(sSrc, sStart)
        If iB <= 0 Then
            Exit Function
        End If
        Dim iE = InStr(iB + Len(sStart), sSrc, sEnd)
        If iE <= 0 Then
            Exit Function
        End If
        If iE > iB + Len(sStart) Then
            GetSubString = sSrc.Substring(iB + Len(sStart) - 1, iE - iB - Len(sStart))
        End If
    End Function

    Function GetItemTitle(sPath As String) As String
        Try
            Dim file = New IO.StreamReader(sPath & "\entry.json")
            Dim Str = file.ReadToEnd()
            Dim iB = InStr(Str, """title"":""")
            Dim iE = InStr(iB + 9, Str, """")
            If iE > iB + 9 Then
                GetItemTitle = Str.Substring(iB + 8, iE - iB - 9)
            Else
                GetItemTitle = ""
            End If
            file.Close()
        Catch
            GetItemTitle = ""
        End Try
    End Function

    Function GetItemSubTitle(sPath As String) As String
        Try
            Dim file = New IO.StreamReader(sPath & "\entry.json")
            Dim Str = file.ReadToEnd()
            GetItemSubTitle = GetSubString(Str, """download_subtitle"":""", """")
            If GetItemSubTitle = "" Then
                GetItemSubTitle = GetSubString(Str, """title"":""", """") & "-" & GetSubString(Str, """index"":""", """") & "-" & GetSubString(Str, """index_title"":""", """") & "-" & GetSubString(Str, """part"":""", """")
            End If
            file.Close()
        Catch
            GetItemSubTitle = ""
        End Try
    End Function


    Function GetItemType(sPath As String) As String
        Try
            GetItemType = ""
            Dim root = New IO.DirectoryInfo(sPath)
            Dim folders = root.GetDirectories()
            If folders.Count >= 1 Then
                Dim files = folders(0).GetFiles("*.blv")
                If files.Count >= 1 Then
                    GetItemType = "blv"
                End If
                files = folders(0).GetFiles("*.m4s")
                If files.Count >= 1 Then
                    GetItemType = "m4s"
                End If
            End If
        Catch
            GetItemType = ""
        End Try
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSource.Text = Application.StartupPath
    End Sub

    Private Sub lvwItems_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvwItems.MouseDoubleClick
        For Each i In lvwItems.SelectedItems
            i.StateImageIndex = (i.StateImageIndex + 1) Mod 4
        Next
    End Sub
End Class
