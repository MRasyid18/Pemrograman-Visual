<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_login
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
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Btn_login = New Button()
        Btn_close = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(129, 157)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 23)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(129, 225)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 23)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(265, 157)
        txtUsername.MaxLength = 20
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(380, 27)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(265, 222)
        txtPassword.MaxLength = 20
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(380, 27)
        txtPassword.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(148, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(508, 36)
        Label3.TabIndex = 4
        Label3.Text = "UNIVERSITAS MULAWARMAN"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(129, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(157, 28)
        Label4.TabIndex = 5
        Label4.Text = "Data Mahasiswa"
        ' 
        ' Btn_login
        ' 
        Btn_login.BackColor = Color.Lime
        Btn_login.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_login.Location = New Point(537, 291)
        Btn_login.Name = "Btn_login"
        Btn_login.Size = New Size(108, 40)
        Btn_login.TabIndex = 6
        Btn_login.Text = "Login"
        Btn_login.UseVisualStyleBackColor = False
        ' 
        ' Btn_close
        ' 
        Btn_close.BackColor = Color.Red
        Btn_close.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_close.Location = New Point(685, 394)
        Btn_close.Name = "Btn_close"
        Btn_close.Size = New Size(103, 44)
        Btn_close.TabIndex = 7
        Btn_close.Text = "Close"
        Btn_close.UseVisualStyleBackColor = False
        ' 
        ' Form_login
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_close)
        Controls.Add(Btn_login)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form_login"
        Text = "Form Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_login As Button
    Friend WithEvents Btn_close As Button

End Class
