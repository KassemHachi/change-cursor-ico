Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles openButton.Click
        OpenImageForm.Filter = "(Image Files)| *.ico"
        OpenImageForm.Multiselect = False
        OpenImageForm.Title = "Select Image"
        If OpenImageForm.ShowDialog = 1 Then
            Me.Cursor = New System.Windows.Forms.Cursor(OpenImageForm.FileName)

        End If
    End Sub
End Class
