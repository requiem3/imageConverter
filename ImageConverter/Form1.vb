Public Class imgfrm
    Dim val As Boolean

    Private Sub btnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowse.Click

        Try
            If OFDialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                PictureBox1.Image = Image.FromFile(OFDialog.FileName)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                val = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnconvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconvert.Click
        Try
            If val = True Then
                If cbformats.SelectedItem = "PNG" Then
                    saveDialog.Filter = "PNG|*.png"
                    If savedialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then PictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Png)

                ElseIf cbformats.SelectedItem = "JPEG" Then
                    saveDialog.Filter = "JPEG|*.jpg"
                    If saveDialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then PictureBox1.Image.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                ElseIf cbformats.SelectedItem = "BMP" Then
                    saveDialog.Filter = "BMP|*.bmp"
                    If saveDialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then PictureBox1.Image.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                ElseIf cbformats.SelectedItem = "GIF" Then
                    saveDialog.Filter = "GIF|*.gif"
                    If savedialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then PictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                ElseIf cbformats.SelectedItem = "TIFF" Then
                    savedialog.Filter = "TIFF|*.tif"
                    If savedialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then PictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Tiff)
                ElseIf cbformats.SelectedItem = "EMF" Then
                    savedialog.Filter = "EMF|*.emf"
                    If savedialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then PictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Emf)
                ElseIf cbformats.SelectedItem = "ICO" Then
                    savedialog.Filter = "ICO|*.ico"
                    If savedialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then PictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Icon)


                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Form2.Show()
    End Sub
End Class
