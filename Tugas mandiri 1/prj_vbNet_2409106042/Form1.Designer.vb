<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmcoba
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtnama = New TextBox()
        cbojeniskelamin = New ComboBox()
        cbofakultas = New ComboBox()
        Btntampilkan = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(134, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 23)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(134, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 23)
        Label2.TabIndex = 1
        Label2.Text = "Jenis Kelamin "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(134, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 23)
        Label3.TabIndex = 2
        Label3.Text = "Fakultas"
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(273, 98)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(151, 27)
        txtnama.TabIndex = 3
        ' 
        ' cbojeniskelamin
        ' 
        cbojeniskelamin.FormattingEnabled = True
        cbojeniskelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        cbojeniskelamin.Location = New Point(273, 139)
        cbojeniskelamin.Name = "cbojeniskelamin"
        cbojeniskelamin.Size = New Size(151, 28)
        cbojeniskelamin.TabIndex = 4
        ' 
        ' cbofakultas
        ' 
        cbofakultas.FormattingEnabled = True
        cbofakultas.Items.AddRange(New Object() {"FAI", "FBS", "FIA", "FIK", "FT"})
        cbofakultas.Location = New Point(273, 184)
        cbofakultas.Name = "cbofakultas"
        cbofakultas.Size = New Size(151, 28)
        cbofakultas.TabIndex = 5
        ' 
        ' Btntampilkan
        ' 
        Btntampilkan.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Btntampilkan.ForeColor = SystemColors.ControlText
        Btntampilkan.Location = New Point(446, 184)
        Btntampilkan.Name = "Btntampilkan"
        Btntampilkan.Size = New Size(137, 33)
        Btntampilkan.TabIndex = 6
        Btntampilkan.Text = "Tampilkan Pesan"
        Btntampilkan.UseVisualStyleBackColor = False
        ' 
        ' Frmcoba
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Btntampilkan)
        Controls.Add(cbofakultas)
        Controls.Add(cbojeniskelamin)
        Controls.Add(txtnama)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Frmcoba"
        Text = "Percobaan Form "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents cbojeniskelamin As ComboBox
    Friend WithEvents cbofakultas As ComboBox
    Friend WithEvents Btntampilkan As Button

End Class
