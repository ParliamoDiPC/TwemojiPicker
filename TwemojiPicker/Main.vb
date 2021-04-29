Public Class Main

    Private Function _
       GetImageFromURL(ByVal ImageURL As String) As Image

        Dim DownloadedImage As Image = Nothing

        Try
            If Not String.IsNullOrWhiteSpace(ImageURL) Then
                Dim WSRequest As System.Net.WebRequest = System.Net.WebRequest.Create(ImageURL)

                Using Request As System.Net.WebResponse = WSRequest.GetResponse
                    Using Stream As System.IO.Stream = Request.GetResponseStream
                        DownloadedImage = New Bitmap(System.Drawing.Image.FromStream(Stream))
                    End Using
                End Using
            End If

        Catch ex As Exception
            UnicodeError.Show()
        End Try

        Return DownloadedImage

    End Function

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable = False Then
            MsgBox("You have to be connected to the internet to use TwemojiPicker.", MsgBoxStyle.Critical, "TwemojiPicker")
            End
        End If
        UnicodeInput.Text = "example: 1f600"
        UnicodeInput.ForeColor = Color.Gray
        FormatList.SelectedIndex = 0
    End Sub

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(500, 153)
    End Sub

    Private Sub Main_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        Me.Size = New Size(500, 153)
    End Sub

    Private Sub Main_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Me.Size = New Size(500, 153)
    End Sub

    Private Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        UnicodeError.Hide()
        If (DownloadFolder.ShowDialog() = DialogResult.OK) Then
            If FormatList.SelectedIndex = 0 Then
                Try
                    If System.IO.File.Exists(DownloadFolder.SelectedPath + "\" + UnicodeInput.Text + ".svg") Then
                        MsgBox("This emoji already exists in this path.", MsgBoxStyle.Critical, "TwemojiPicker")
                    Else
                        My.Computer.Network.DownloadFile("http://twemoji.maxcdn.com/v/13.0.2/svg/" + UnicodeInput.Text + ".svg", DownloadFolder.SelectedPath + "\" + UnicodeInput.Text + ".svg")
                        MsgBox("Done!", MsgBoxStyle.Information, "TwemojiPicker")
                    End If

                Catch ex As Exception
                    UnicodeError.Show()
                End Try
            Else
                If System.IO.File.Exists(DownloadFolder.SelectedPath + "\" + UnicodeInput.Text + ".png") Then
                    MsgBox("This emoji already exists in this path.", MsgBoxStyle.Critical, "TwemojiPicker")
                Else
                    My.Computer.Network.DownloadFile("http://twemoji.maxcdn.com/v/13.0.2/72x72/" + UnicodeInput.Text + ".png", DownloadFolder.SelectedPath + "\" + UnicodeInput.Text + ".png")
                    MsgBox("Done!", MsgBoxStyle.Information, "TwemojiPicker")
                End If
            End If
        End If
    End Sub

    Private Sub PreviewButton_Click(sender As Object, e As EventArgs) Handles PreviewButton.Click
        UnicodeError.Hide()
        Dim img As Image = GetImageFromURL("https://twemoji.maxcdn.com/v/13.0.2/72x72/" + UnicodeInput.Text + ".png")
        PreviewImage.Image = img
    End Sub

    Private Sub UnicodeInput_TextChanged(sender As Object, e As EventArgs) Handles UnicodeInput.TextChanged
        If UnicodeInput.Text = "example: 1f600" Then
            UnicodeInput.Text = "example: 1f600"
            UnicodeInput.ForeColor = Color.Gray
        Else
            UnicodeInput.ForeColor = Color.Black
        End If
    End Sub

    Private Sub UnicodeInput_Click(sender As Object, e As EventArgs) Handles UnicodeInput.Click
        UnicodeInput.Text = ""
        UnicodeInput.ForeColor = Color.Black
    End Sub

    Private Sub BlobPicker_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BlobPicker.LinkClicked
        Process.Start("https://github.com/ParliamoDiPC/BlobPicker")
    End Sub

    Private Sub GitHub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GitHub.LinkClicked
        Process.Start("https://github.com/ParliamoDiPC/TwemojiPicker")
    End Sub
End Class
