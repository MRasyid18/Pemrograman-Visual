<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_output
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
        Panel1 = New Panel()
        Button1 = New Button()
        Label1 = New Label()
        user_name = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(0, 307)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(815, 147)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.FlatAppearance.BorderColor = Color.Red
        Button1.FlatAppearance.BorderSize = 3
        Button1.FlatAppearance.MouseDownBackColor = Color.Red
        Button1.FlatAppearance.MouseOverBackColor = Color.Red
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(33, 49)
        Button1.Name = "Button1"
        Button1.Size = New Size(147, 52)
        Button1.TabIndex = 0
        Button1.Text = "Keluar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(267, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 38)
        Label1.TabIndex = 1
        Label1.Text = "SELAMAT DATANG"
        ' 
        ' user_name
        ' 
        user_name.AutoSize = True
        user_name.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        user_name.Location = New Point(370, 88)
        user_name.Name = "user_name"
        user_name.Size = New Size(0, 28)
        user_name.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(277, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(247, 23)
        Label2.TabIndex = 3
        Label2.Text = "Semoga harinya menyenangkan"
        ' 
        ' Form_output
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(user_name)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "Form_output"
        Text = "Form_output"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents user_name As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
