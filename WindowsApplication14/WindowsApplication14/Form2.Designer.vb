<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmKayitEkle
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
        Me.tbAdSoyad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbBoy = New System.Windows.Forms.TextBox()
        Me.tbKilo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbKayit_KullaniciAdi = New System.Windows.Forms.TextBox()
        Me.tbKayit_Sifre = New System.Windows.Forms.TextBox()
        Me.datetpDogumTarihi = New System.Windows.Forms.DateTimePicker()
        Me.cmbCinsiyet = New System.Windows.Forms.ComboBox()
        Me.btnKayitEkle = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbTC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.datetpBaslangicTarihi = New System.Windows.Forms.DateTimePicker()
        Me.tbHastalik = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbAdSoyad
        '
        Me.tbAdSoyad.Location = New System.Drawing.Point(121, 173)
        Me.tbAdSoyad.Name = "tbAdSoyad"
        Me.tbAdSoyad.Size = New System.Drawing.Size(127, 20)
        Me.tbAdSoyad.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ad Soyad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Doğum Tarihi:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(287, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cinsiyet:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(287, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Boy(cm):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(287, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Kilo(kg):"
        '
        'tbBoy
        '
        Me.tbBoy.Location = New System.Drawing.Point(364, 99)
        Me.tbBoy.Name = "tbBoy"
        Me.tbBoy.Size = New System.Drawing.Size(127, 20)
        Me.tbBoy.TabIndex = 6
        '
        'tbKilo
        '
        Me.tbKilo.Location = New System.Drawing.Point(364, 138)
        Me.tbKilo.Name = "tbKilo"
        Me.tbKilo.Size = New System.Drawing.Size(127, 20)
        Me.tbKilo.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightGray
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Kullanıcı Adı:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Şifre:"
        '
        'tbKayit_KullaniciAdi
        '
        Me.tbKayit_KullaniciAdi.Location = New System.Drawing.Point(121, 98)
        Me.tbKayit_KullaniciAdi.Name = "tbKayit_KullaniciAdi"
        Me.tbKayit_KullaniciAdi.Size = New System.Drawing.Size(127, 20)
        Me.tbKayit_KullaniciAdi.TabIndex = 1
        '
        'tbKayit_Sifre
        '
        Me.tbKayit_Sifre.Location = New System.Drawing.Point(121, 132)
        Me.tbKayit_Sifre.Name = "tbKayit_Sifre"
        Me.tbKayit_Sifre.Size = New System.Drawing.Size(127, 20)
        Me.tbKayit_Sifre.TabIndex = 2
        '
        'datetpDogumTarihi
        '
        Me.datetpDogumTarihi.Location = New System.Drawing.Point(121, 207)
        Me.datetpDogumTarihi.Name = "datetpDogumTarihi"
        Me.datetpDogumTarihi.Size = New System.Drawing.Size(127, 20)
        Me.datetpDogumTarihi.TabIndex = 4
        '
        'cmbCinsiyet
        '
        Me.cmbCinsiyet.FormattingEnabled = True
        Me.cmbCinsiyet.Items.AddRange(New Object() {"Kadın", "Erkek", "----"})
        Me.cmbCinsiyet.Location = New System.Drawing.Point(364, 55)
        Me.cmbCinsiyet.Name = "cmbCinsiyet"
        Me.cmbCinsiyet.Size = New System.Drawing.Size(127, 21)
        Me.cmbCinsiyet.TabIndex = 5
        '
        'btnKayitEkle
        '
        Me.btnKayitEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKayitEkle.Location = New System.Drawing.Point(202, 268)
        Me.btnKayitEkle.Name = "btnKayitEkle"
        Me.btnKayitEkle.Size = New System.Drawing.Size(113, 41)
        Me.btnKayitEkle.TabIndex = 11
        Me.btnKayitEkle.Text = "KAYIT EKLE"
        Me.btnKayitEkle.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightGray
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(287, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Hastalık:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightGray
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "TC"
        '
        'tbTC
        '
        Me.tbTC.Location = New System.Drawing.Point(121, 55)
        Me.tbTC.MaxLength = 11
        Me.tbTC.Name = "tbTC"
        Me.tbTC.Size = New System.Drawing.Size(127, 20)
        Me.tbTC.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LightGray
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(287, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 30)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Başlangıç" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tarihi"
        '
        'datetpBaslangicTarihi
        '
        Me.datetpBaslangicTarihi.Location = New System.Drawing.Point(364, 176)
        Me.datetpBaslangicTarihi.Name = "datetpBaslangicTarihi"
        Me.datetpBaslangicTarihi.Size = New System.Drawing.Size(127, 20)
        Me.datetpBaslangicTarihi.TabIndex = 8
        '
        'tbHastalik
        '
        Me.tbHastalik.Location = New System.Drawing.Point(364, 215)
        Me.tbHastalik.Name = "tbHastalik"
        Me.tbHastalik.Size = New System.Drawing.Size(127, 20)
        Me.tbHastalik.TabIndex = 22
        '
        'FrmKayitEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(513, 345)
        Me.Controls.Add(Me.tbHastalik)
        Me.Controls.Add(Me.datetpBaslangicTarihi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbTC)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnKayitEkle)
        Me.Controls.Add(Me.cmbCinsiyet)
        Me.Controls.Add(Me.datetpDogumTarihi)
        Me.Controls.Add(Me.tbKayit_Sifre)
        Me.Controls.Add(Me.tbKayit_KullaniciAdi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbKilo)
        Me.Controls.Add(Me.tbBoy)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbAdSoyad)
        Me.Name = "FrmKayitEkle"
        Me.Text = "Kayıt Ekle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbAdSoyad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbBoy As TextBox
    Friend WithEvents tbKilo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbKayit_KullaniciAdi As TextBox
    Friend WithEvents tbKayit_Sifre As TextBox
    Friend WithEvents datetpDogumTarihi As DateTimePicker
    Friend WithEvents cmbCinsiyet As ComboBox
    Friend WithEvents btnKayitEkle As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tbTC As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents datetpBaslangicTarihi As DateTimePicker
    Friend WithEvents tbHastalik As TextBox
End Class
