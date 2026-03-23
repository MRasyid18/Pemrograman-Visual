Public Class Frmcoba
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btntampilkan_Click(sender As Object, e As EventArgs) Handles Btntampilkan.Click
        MessageBox.Show(txtnama.Text & vbCrLf & cbojeniskelamin.Text & vbCrLf & cbofakultas.Text, "hasil pengisian", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
