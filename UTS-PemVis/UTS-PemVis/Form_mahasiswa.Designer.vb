<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_mahasiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_mahasiswa))
        Panel1 = New Panel()
        Btn_kembali = New Button()
        Btn_cetak = New Button()
        Combo_prodi = New ComboBox()
        Text_ipk = New TextBox()
        Text_angkatan = New TextBox()
        Text_nim = New TextBox()
        Text_nama = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Controls.Add(Btn_kembali)
        Panel1.Controls.Add(Btn_cetak)
        Panel1.Controls.Add(Combo_prodi)
        Panel1.Controls.Add(Text_ipk)
        Panel1.Controls.Add(Text_angkatan)
        Panel1.Controls.Add(Text_nim)
        Panel1.Controls.Add(Text_nama)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Font = New Font("Microsoft Sans Serif", 8.25F)
        Panel1.Location = New Point(2, 129)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(817, 365)
        Panel1.TabIndex = 0
        ' 
        ' Btn_kembali
        ' 
        Btn_kembali.BackColor = Color.Red
        Btn_kembali.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_kembali.Location = New Point(475, 241)
        Btn_kembali.Name = "Btn_kembali"
        Btn_kembali.Size = New Size(113, 45)
        Btn_kembali.TabIndex = 11
        Btn_kembali.Text = "Kembali"
        Btn_kembali.UseVisualStyleBackColor = False
        ' 
        ' Btn_cetak
        ' 
        Btn_cetak.BackColor = Color.Lime
        Btn_cetak.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_cetak.Location = New Point(296, 241)
        Btn_cetak.Name = "Btn_cetak"
        Btn_cetak.Size = New Size(113, 45)
        Btn_cetak.TabIndex = 10
        Btn_cetak.Text = "Cetak"
        Btn_cetak.UseVisualStyleBackColor = False
        ' 
        ' Combo_prodi
        ' 
        Combo_prodi.FormattingEnabled = True
        Combo_prodi.Items.AddRange(New Object() {"Informatika", "Sistem Informasi"})
        Combo_prodi.Location = New Point(258, 105)
        Combo_prodi.Name = "Combo_prodi"
        Combo_prodi.Size = New Size(151, 25)
        Combo_prodi.TabIndex = 9
        ' 
        ' Text_ipk
        ' 
        Text_ipk.Location = New Point(258, 194)
        Text_ipk.Name = "Text_ipk"
        Text_ipk.Size = New Size(406, 23)
        Text_ipk.TabIndex = 8
        ' 
        ' Text_angkatan
        ' 
        Text_angkatan.Location = New Point(258, 149)
        Text_angkatan.Name = "Text_angkatan"
        Text_angkatan.Size = New Size(406, 23)
        Text_angkatan.TabIndex = 7
        ' 
        ' Text_nim
        ' 
        Text_nim.Location = New Point(258, 66)
        Text_nim.Name = "Text_nim"
        Text_nim.Size = New Size(406, 23)
        Text_nim.TabIndex = 6
        ' 
        ' Text_nama
        ' 
        Text_nama.Location = New Point(258, 27)
        Text_nama.Name = "Text_nama"
        Text_nama.Size = New Size(406, 23)
        Text_nama.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(43, 194)
        Label9.Name = "Label9"
        Label9.Size = New Size(35, 23)
        Label9.TabIndex = 4
        Label9.Text = "IPK"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(43, 149)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 23)
        Label8.TabIndex = 3
        Label8.Text = "Angkatan"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(43, 107)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 23)
        Label7.TabIndex = 2
        Label7.Text = "Program Studi"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(43, 66)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 23)
        Label6.TabIndex = 1
        Label6.Text = "NIM"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(43, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 23)
        Label5.TabIndex = 0
        Label5.Text = "Nama Lengkap"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(2, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 23)
        Label1.TabIndex = 1
        Label1.Text = "DATA MAHASISWA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(439, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(349, 25)
        Label2.TabIndex = 2
        Label2.Text = "UNIVERSITAS MULAWARMAN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(605, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(183, 25)
        Label3.TabIndex = 3
        Label3.Text = "INFORMATIKA"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(728, 62)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 25)
        Label4.TabIndex = 4
        Label4.Text = "2026"
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Form_mahasiswa
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "Form_mahasiswa"
        Text = "Form_mahasiswa"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn_kembali As Button
    Friend WithEvents Btn_cetak As Button
    Friend WithEvents Combo_prodi As ComboBox
    Friend WithEvents Text_ipk As TextBox
    Friend WithEvents Text_angkatan As TextBox
    Friend WithEvents Text_nim As TextBox
    Friend WithEvents Text_nama As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
