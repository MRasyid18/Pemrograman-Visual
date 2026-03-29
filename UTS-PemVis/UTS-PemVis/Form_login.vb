Public Class Form_login

    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        If txtUsername.Text = "rasyid" And txtPassword.Text = "12345678" Then
            Form_mahasiswa.Show()
            Me.Hide()
        Else
            MsgBox("username dan password salah")
        End If
    End Sub

    Private Sub Btn_close_Click(sender As Object, e As EventArgs) Handles Btn_close.Click
        Application.Exit()
    End Sub

End Class