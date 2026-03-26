<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_input
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_input))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Text_nama = New TextBox()
        Text_no_hp = New TextBox()
        CheckBox2 = New CheckBox()
        Combo_jurusan = New ComboBox()
        Button1 = New Button()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(448, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(294, 23)
        Label1.TabIndex = 0
        Label1.Text = "UNIVERSITAS MULAWARMAN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(591, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 23)
        Label2.TabIndex = 1
        Label2.Text = "INFORMATIKA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(667, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 35)
        Label3.TabIndex = 2
        Label3.Text = "2024"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(310, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(188, 23)
        Label4.TabIndex = 3
        Label4.Text = "DATA MAHASISWA"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaptionText
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(62, 185)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 20)
        Label5.TabIndex = 4
        Label5.Text = "Nama Lengkap"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ActiveCaptionText
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(62, 232)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 20)
        Label6.TabIndex = 5
        Label6.Text = "Program Studi"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ActiveCaptionText
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(62, 278)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 20)
        Label7.TabIndex = 6
        Label7.Text = "Nomor HP"
        ' 
        ' Text_nama
        ' 
        Text_nama.Location = New Point(225, 185)
        Text_nama.MaxLength = 15
        Text_nama.Name = "Text_nama"
        Text_nama.Size = New Size(399, 27)
        Text_nama.TabIndex = 7
        ' 
        ' Text_no_hp
        ' 
        Text_no_hp.Location = New Point(225, 278)
        Text_no_hp.MaxLength = 13
        Text_no_hp.Name = "Text_no_hp"
        Text_no_hp.Size = New Size(399, 27)
        Text_no_hp.TabIndex = 9
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.ForeColor = SystemColors.ControlLightLight
        CheckBox2.Location = New Point(62, 339)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(478, 24)
        CheckBox2.TabIndex = 10
        CheckBox2.Text = "Saya setuju dan menyatakan bahwa data yang saya isi adalah benar"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Combo_jurusan
        ' 
        Combo_jurusan.FormattingEnabled = True
        Combo_jurusan.Items.AddRange(New Object() {"Teknik Informatika", "", "Sistem Informasi", "", "Teknik Geologi", "Teknik Lingkungan", "Teknik Elektro", "Teknik Kimia", "Arsitektur", "Teknik Pertambangan", "Teknik Industri"})
        Combo_jurusan.Location = New Point(225, 232)
        Combo_jurusan.Name = "Combo_jurusan"
        Combo_jurusan.Size = New Size(158, 28)
        Combo_jurusan.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Enabled = False
        Button1.Font = New Font("Elephant", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(609, 376)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 38)
        Button1.TabIndex = 12
        Button1.Text = "Cetak"
        Button1.UseVisualStyleBackColor = False
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
        ' Form_input
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(Combo_jurusan)
        Controls.Add(CheckBox2)
        Controls.Add(Text_no_hp)
        Controls.Add(Text_nama)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form_input"
        Text = "Form_input"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Text_nama As TextBox
    Friend WithEvents Text_no_hp As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Combo_jurusan As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument

End Class
