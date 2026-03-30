Imports System.Drawing.Printing

Public Class Form_mahasiswa

    Dim nama, nim, prodi, angkatan, ipk, predikat As String

    Private Sub Btn_cetak_Click(sender As Object, e As EventArgs) Handles Btn_cetak.Click
        nama = Text_nama.Text
        nim = Text_nim.Text
        prodi = Combo_prodi.Text
        angkatan = Text_angkatan.Text
        ipk = Text_ipk.Text
        If CDbl(ipk) >= 3.5 Then
            predikat = "CUMLAUDE"
        Else
            predikat = "SANGAT MEMUASKAN"
        End If

        AddHandler PrintDocument1.PrintPage, AddressOf PrintDocument1_PrintPage
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        RemoveHandler PrintDocument1.PrintPage, AddressOf PrintDocument1_PrintPage
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim fJudul As Font = New Font("Times New Roman", 16, FontStyle.Bold)
        Dim fIsi As Font = New Font("Times New Roman", 13, FontStyle.Regular)
        Dim fNama As Font = New Font("Times New Roman", 16, FontStyle.Bold Or FontStyle.Underline)
        Dim br As SolidBrush = New SolidBrush(Color.Black)
        Dim p As Pen = New Pen(Color.Black, 3)

        ' Kotak border ijazah — diperbesar mengisi halaman
        e.Graphics.DrawRectangle(p, 50, 50, 700, 550)

        ' Header
        e.Graphics.DrawString("KEMENTERIAN PENDIDIKAN", fJudul, br, 230, 80)
        e.Graphics.DrawString("UNIVERSITAS MULAWARMAN", fJudul, br, 220, 115)
        e.Graphics.DrawString("Dengan ini menyatakan bahwa :", fIsi, br, 250, 175)

        ' Nama & NIM
        e.Graphics.DrawString(nama.ToUpper(), fNama, br, 280, 220)
        e.Graphics.DrawString("NIM : " + nim, fIsi, br, 310, 255)

        ' Keterangan lulus
        e.Graphics.DrawString("Telah menyelesaikan studi dan memenuhi segala syarat", fIsi, br, 160, 310)
        e.Graphics.DrawString("Pendidikan Strata Satu Program Studi " + prodi, fIsi, br, 200, 340)
        e.Graphics.DrawString("Lulus pada tanggal : 10 Maret 2026", fIsi, br, 240, 370)

        ' Gelar
        e.Graphics.DrawString("Oleh sebab itu kepadanya diberikan gelar", fIsi, br, 220, 420)
        e.Graphics.DrawString("SARJANA KOMPUTER (S.KOM)", fJudul, br, 215, 455)
        e.Graphics.DrawString(predikat, fJudul, br, 300, 490)

        ' Footer
        e.Graphics.DrawString("Dengan segala kewajiban melekat pada gelar tersebut", fIsi, br, 165, 545)
    End Sub

    Private Sub Btn_kembali_Click(sender As Object, e As EventArgs) Handles Btn_kembali.Click
        Form_login.Show()
        Me.Hide()
    End Sub

End Class