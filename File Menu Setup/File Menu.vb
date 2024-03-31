Imports System.IO
Public Class Form1

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openDialog As New OpenFileDialog With {
            .Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        }
        If openDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openDialog.FileName
            Dim fileContents As String = My.Computer.FileSystem.ReadAllText(filePath)
            TextBox1.Text = fileContents
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim saveDialog As New SaveFileDialog With {
            .Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        }
        If saveDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveDialog.FileName
            File.WriteAllText(filePath, TextBox1.Text)
        End If
    End Sub
End Class
