<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGiris = New System.Windows.Forms.Button()
        Me.btnYeniKayit = New System.Windows.Forms.Button()
        Me.tbKullanici = New System.Windows.Forms.TextBox()
        Me.tbSifre = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kullanıcı Adı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Şifre:"
        '
        'btnGiris
        '
        Me.btnGiris.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGiris.Location = New System.Drawing.Point(95, 264)
        Me.btnGiris.Name = "btnGiris"
        Me.btnGiris.Size = New System.Drawing.Size(96, 47)
        Me.btnGiris.TabIndex = 6
        Me.btnGiris.Text = "GİRİŞ"
        Me.btnGiris.UseVisualStyleBackColor = True
        '
        'btnYeniKayit
        '
        Me.btnYeniKayit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYeniKayit.Location = New System.Drawing.Point(266, 264)
        Me.btnYeniKayit.Name = "btnYeniKayit"
        Me.btnYeniKayit.Size = New System.Drawing.Size(96, 47)
        Me.btnYeniKayit.TabIndex = 7
        Me.btnYeniKayit.Text = "YENİ KAYIT"
        Me.btnYeniKayit.UseVisualStyleBackColor = True
        '
        'tbKullanici
        '
        Me.tbKullanici.Location = New System.Drawing.Point(195, 173)
        Me.tbKullanici.Multiline = True
        Me.tbKullanici.Name = "tbKullanici"
        Me.tbKullanici.Size = New System.Drawing.Size(167, 20)
        Me.tbKullanici.TabIndex = 8
        '
        'tbSifre
        '
        Me.tbSifre.Location = New System.Drawing.Point(195, 219)
        Me.tbSifre.Multiline = True
        Me.tbSifre.Name = "tbSifre"
        Me.tbSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbSifre.Size = New System.Drawing.Size(167, 20)
        Me.tbSifre.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication14.My.Resources.Resources.user_512
        Me.PictureBox1.Location = New System.Drawing.Point(195, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(539, 360)
        Me.Controls.Add(Me.tbSifre)
        Me.Controls.Add(Me.tbKullanici)
        Me.Controls.Add(Me.btnYeniKayit)
        Me.Controls.Add(Me.btnGiris)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Giriş Ekranı "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGiris As Button
    Friend WithEvents btnYeniKayit As Button
    Friend WithEvents tbKullanici As TextBox
    Friend WithEvents tbSifre As TextBox
End Class
