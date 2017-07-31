<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TPBesinSecimi = New System.Windows.Forms.TabPage()
        Me.btnB_Sil = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgvBesinSecim = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbK_Secim = New System.Windows.Forms.ListBox()
        Me.tbB_TC = New System.Windows.Forms.TextBox()
        Me.BtnKaydetBesin = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LbBesin = New System.Windows.Forms.ListBox()
        Me.LblOgunSecimi = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.CmbOgunSecimi = New System.Windows.Forms.ComboBox()
        Me.btnKSistemCikis = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TPSporSecimi = New System.Windows.Forms.TabPage()
        Me.btnS_Sil = New System.Windows.Forms.Button()
        Me.lblKalori = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbSure = New System.Windows.Forms.TextBox()
        Me.tbS_TC = New System.Windows.Forms.TextBox()
        Me.DgvSecilenSpor = New System.Windows.Forms.DataGridView()
        Me.LbSporListesi = New System.Windows.Forms.ListBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelHarcananKalori = New System.Windows.Forms.Label()
        Me.tbHarcananKalori = New System.Windows.Forms.TextBox()
        Me.BtnKaydetSpor = New System.Windows.Forms.Button()
        Me.LabelSporSecimi = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbSporSecimi = New System.Windows.Forms.ListBox()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TPBesinSecimi.SuspendLayout()
        CType(Me.DgvBesinSecim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPSporSecimi.SuspendLayout()
        CType(Me.DgvSecilenSpor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TPBesinSecimi)
        Me.TabControl1.Controls.Add(Me.TPSporSecimi)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(967, 690)
        Me.TabControl1.TabIndex = 3
        '
        'TPBesinSecimi
        '
        Me.TPBesinSecimi.BackColor = System.Drawing.Color.Tan
        Me.TPBesinSecimi.Controls.Add(Me.btnB_Sil)
        Me.TPBesinSecimi.Controls.Add(Me.Label3)
        Me.TPBesinSecimi.Controls.Add(Me.DgvBesinSecim)
        Me.TPBesinSecimi.Controls.Add(Me.Label2)
        Me.TPBesinSecimi.Controls.Add(Me.LbK_Secim)
        Me.TPBesinSecimi.Controls.Add(Me.tbB_TC)
        Me.TPBesinSecimi.Controls.Add(Me.BtnKaydetBesin)
        Me.TPBesinSecimi.Controls.Add(Me.Label6)
        Me.TPBesinSecimi.Controls.Add(Me.LbBesin)
        Me.TPBesinSecimi.Controls.Add(Me.LblOgunSecimi)
        Me.TPBesinSecimi.Controls.Add(Me.MonthCalendar1)
        Me.TPBesinSecimi.Controls.Add(Me.CmbOgunSecimi)
        Me.TPBesinSecimi.Controls.Add(Me.btnKSistemCikis)
        Me.TPBesinSecimi.Controls.Add(Me.TextBox3)
        Me.TPBesinSecimi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TPBesinSecimi.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TPBesinSecimi.Location = New System.Drawing.Point(4, 22)
        Me.TPBesinSecimi.Name = "TPBesinSecimi"
        Me.TPBesinSecimi.Padding = New System.Windows.Forms.Padding(3)
        Me.TPBesinSecimi.Size = New System.Drawing.Size(959, 664)
        Me.TPBesinSecimi.TabIndex = 0
        Me.TPBesinSecimi.Text = "Besin Seçimi"
        '
        'btnB_Sil
        '
        Me.btnB_Sil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnB_Sil.Image = CType(resources.GetObject("btnB_Sil.Image"), System.Drawing.Image)
        Me.btnB_Sil.Location = New System.Drawing.Point(828, 237)
        Me.btnB_Sil.Name = "btnB_Sil"
        Me.btnB_Sil.Size = New System.Drawing.Size(114, 63)
        Me.btnB_Sil.TabIndex = 50
        Me.btnB_Sil.Text = "SİL"
        Me.btnB_Sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnB_Sil.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(642, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 16)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "SİZİN SEÇİMLERİNİZ:"
        '
        'DgvBesinSecim
        '
        Me.DgvBesinSecim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBesinSecim.Location = New System.Drawing.Point(38, 347)
        Me.DgvBesinSecim.Name = "DgvBesinSecim"
        Me.DgvBesinSecim.Size = New System.Drawing.Size(741, 245)
        Me.DgvBesinSecim.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(407, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "TC GİRİNİZ"
        '
        'LbK_Secim
        '
        Me.LbK_Secim.FormattingEnabled = True
        Me.LbK_Secim.ItemHeight = 16
        Me.LbK_Secim.Location = New System.Drawing.Point(645, 104)
        Me.LbK_Secim.Name = "LbK_Secim"
        Me.LbK_Secim.Size = New System.Drawing.Size(120, 196)
        Me.LbK_Secim.TabIndex = 46
        '
        'tbB_TC
        '
        Me.tbB_TC.Location = New System.Drawing.Point(409, 40)
        Me.tbB_TC.MaxLength = 11
        Me.tbB_TC.Name = "tbB_TC"
        Me.tbB_TC.Size = New System.Drawing.Size(100, 22)
        Me.tbB_TC.TabIndex = 45
        '
        'BtnKaydetBesin
        '
        Me.BtnKaydetBesin.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnKaydetBesin.Location = New System.Drawing.Point(828, 380)
        Me.BtnKaydetBesin.Name = "BtnKaydetBesin"
        Me.BtnKaydetBesin.Size = New System.Drawing.Size(114, 68)
        Me.BtnKaydetBesin.TabIndex = 44
        Me.BtnKaydetBesin.Text = "KAYDET"
        Me.BtnKaydetBesin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnKaydetBesin.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightGray
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(407, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 16)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "DİYETİSYENİN SEÇTİKLERİ:"
        '
        'LbBesin
        '
        Me.LbBesin.FormattingEnabled = True
        Me.LbBesin.ItemHeight = 16
        Me.LbBesin.Location = New System.Drawing.Point(410, 104)
        Me.LbBesin.Name = "LbBesin"
        Me.LbBesin.Size = New System.Drawing.Size(119, 196)
        Me.LbBesin.TabIndex = 40
        '
        'LblOgunSecimi
        '
        Me.LblOgunSecimi.AutoSize = True
        Me.LblOgunSecimi.BackColor = System.Drawing.Color.LightGray
        Me.LblOgunSecimi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LblOgunSecimi.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LblOgunSecimi.Location = New System.Drawing.Point(642, 17)
        Me.LblOgunSecimi.Name = "LblOgunSecimi"
        Me.LblOgunSecimi.Size = New System.Drawing.Size(110, 16)
        Me.LblOgunSecimi.TabIndex = 39
        Me.LblOgunSecimi.Text = "ÖĞÜN SEÇİMİ:"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(38, 38)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 37
        '
        'CmbOgunSecimi
        '
        Me.CmbOgunSecimi.FormattingEnabled = True
        Me.CmbOgunSecimi.Items.AddRange(New Object() {"SABAH", "ARA ÖĞÜN 1", "ÖĞLE", "ARA ÖĞÜN 2", "AKŞAM"})
        Me.CmbOgunSecimi.Location = New System.Drawing.Point(645, 38)
        Me.CmbOgunSecimi.Name = "CmbOgunSecimi"
        Me.CmbOgunSecimi.Size = New System.Drawing.Size(107, 24)
        Me.CmbOgunSecimi.TabIndex = 38
        '
        'btnKSistemCikis
        '
        Me.btnKSistemCikis.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKSistemCikis.Location = New System.Drawing.Point(828, 494)
        Me.btnKSistemCikis.Name = "btnKSistemCikis"
        Me.btnKSistemCikis.Size = New System.Drawing.Size(114, 63)
        Me.btnKSistemCikis.TabIndex = 36
        Me.btnKSistemCikis.Text = "ÇIKIŞ"
        Me.btnKSistemCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKSistemCikis.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(262, 168)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(10, 10)
        Me.TextBox3.TabIndex = 35
        '
        'TPSporSecimi
        '
        Me.TPSporSecimi.BackColor = System.Drawing.Color.Tan
        Me.TPSporSecimi.Controls.Add(Me.btnS_Sil)
        Me.TPSporSecimi.Controls.Add(Me.lblKalori)
        Me.TPSporSecimi.Controls.Add(Me.Label4)
        Me.TPSporSecimi.Controls.Add(Me.tbSure)
        Me.TPSporSecimi.Controls.Add(Me.tbS_TC)
        Me.TPSporSecimi.Controls.Add(Me.DgvSecilenSpor)
        Me.TPSporSecimi.Controls.Add(Me.LbSporListesi)
        Me.TPSporSecimi.Controls.Add(Me.PictureBox2)
        Me.TPSporSecimi.Controls.Add(Me.LabelHarcananKalori)
        Me.TPSporSecimi.Controls.Add(Me.tbHarcananKalori)
        Me.TPSporSecimi.Controls.Add(Me.BtnKaydetSpor)
        Me.TPSporSecimi.Controls.Add(Me.LabelSporSecimi)
        Me.TPSporSecimi.Controls.Add(Me.PictureBox1)
        Me.TPSporSecimi.Controls.Add(Me.LbSporSecimi)
        Me.TPSporSecimi.Controls.Add(Me.MonthCalendar2)
        Me.TPSporSecimi.Controls.Add(Me.Label1)
        Me.TPSporSecimi.Location = New System.Drawing.Point(4, 22)
        Me.TPSporSecimi.Name = "TPSporSecimi"
        Me.TPSporSecimi.Padding = New System.Windows.Forms.Padding(3)
        Me.TPSporSecimi.Size = New System.Drawing.Size(959, 664)
        Me.TPSporSecimi.TabIndex = 1
        Me.TPSporSecimi.Text = "Spor Seçimi"
        '
        'btnS_Sil
        '
        Me.btnS_Sil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnS_Sil.Image = CType(resources.GetObject("btnS_Sil.Image"), System.Drawing.Image)
        Me.btnS_Sil.Location = New System.Drawing.Point(784, 235)
        Me.btnS_Sil.Name = "btnS_Sil"
        Me.btnS_Sil.Size = New System.Drawing.Size(124, 63)
        Me.btnS_Sil.TabIndex = 51
        Me.btnS_Sil.Text = "SİL"
        Me.btnS_Sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnS_Sil.UseVisualStyleBackColor = True
        '
        'lblKalori
        '
        Me.lblKalori.AutoSize = True
        Me.lblKalori.BackColor = System.Drawing.Color.LightGray
        Me.lblKalori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKalori.Location = New System.Drawing.Point(41, 58)
        Me.lblKalori.Name = "lblKalori"
        Me.lblKalori.Size = New System.Drawing.Size(108, 16)
        Me.lblKalori.TabIndex = 49
        Me.lblKalori.Text = "SÜRE GİRİNİZ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(41, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "TC GİRİNİZ"
        '
        'tbSure
        '
        Me.tbSure.Location = New System.Drawing.Point(155, 57)
        Me.tbSure.Name = "tbSure"
        Me.tbSure.Size = New System.Drawing.Size(141, 20)
        Me.tbSure.TabIndex = 12
        '
        'tbS_TC
        '
        Me.tbS_TC.Location = New System.Drawing.Point(155, 31)
        Me.tbS_TC.MaxLength = 11
        Me.tbS_TC.Name = "tbS_TC"
        Me.tbS_TC.Size = New System.Drawing.Size(141, 20)
        Me.tbS_TC.TabIndex = 12
        '
        'DgvSecilenSpor
        '
        Me.DgvSecilenSpor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSecilenSpor.Location = New System.Drawing.Point(57, 354)
        Me.DgvSecilenSpor.Name = "DgvSecilenSpor"
        Me.DgvSecilenSpor.Size = New System.Drawing.Size(574, 178)
        Me.DgvSecilenSpor.TabIndex = 11
        '
        'LbSporListesi
        '
        Me.LbSporListesi.FormattingEnabled = True
        Me.LbSporListesi.Location = New System.Drawing.Point(57, 114)
        Me.LbSporListesi.Name = "LbSporListesi"
        Me.LbSporListesi.Size = New System.Drawing.Size(230, 212)
        Me.LbSporListesi.TabIndex = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox2.Image = Global.WindowsApplication14.My.Resources.Resources.water
        Me.PictureBox2.Location = New System.Drawing.Point(784, 315)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(124, 178)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'LabelHarcananKalori
        '
        Me.LabelHarcananKalori.AutoSize = True
        Me.LabelHarcananKalori.BackColor = System.Drawing.Color.LightGray
        Me.LabelHarcananKalori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelHarcananKalori.Location = New System.Drawing.Point(54, 559)
        Me.LabelHarcananKalori.Name = "LabelHarcananKalori"
        Me.LabelHarcananKalori.Size = New System.Drawing.Size(217, 16)
        Me.LabelHarcananKalori.TabIndex = 8
        Me.LabelHarcananKalori.Text = "HARCANAN KALORİ MİKTARI:"
        '
        'tbHarcananKalori
        '
        Me.tbHarcananKalori.Location = New System.Drawing.Point(277, 556)
        Me.tbHarcananKalori.Name = "tbHarcananKalori"
        Me.tbHarcananKalori.Size = New System.Drawing.Size(264, 20)
        Me.tbHarcananKalori.TabIndex = 7
        '
        'BtnKaydetSpor
        '
        Me.BtnKaydetSpor.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnKaydetSpor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnKaydetSpor.Location = New System.Drawing.Point(784, 511)
        Me.BtnKaydetSpor.Name = "BtnKaydetSpor"
        Me.BtnKaydetSpor.Size = New System.Drawing.Size(124, 79)
        Me.BtnKaydetSpor.TabIndex = 5
        Me.BtnKaydetSpor.Text = "KAYDET"
        Me.BtnKaydetSpor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnKaydetSpor.UseVisualStyleBackColor = False
        '
        'LabelSporSecimi
        '
        Me.LabelSporSecimi.AutoSize = True
        Me.LabelSporSecimi.BackColor = System.Drawing.Color.LightGray
        Me.LabelSporSecimi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelSporSecimi.Location = New System.Drawing.Point(351, 95)
        Me.LabelSporSecimi.Name = "LabelSporSecimi"
        Me.LabelSporSecimi.Size = New System.Drawing.Size(104, 16)
        Me.LabelSporSecimi.TabIndex = 4
        Me.LabelSporSecimi.Text = "SPOR SEÇİMİ"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication14.My.Resources.Resources.ünlem_işareti
        Me.PictureBox1.Location = New System.Drawing.Point(583, 538)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 38)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Bu programa uyulduğu takdirde harcanacak tahmini kalori miktaridır.")
        '
        'LbSporSecimi
        '
        Me.LbSporSecimi.FormattingEnabled = True
        Me.LbSporSecimi.Location = New System.Drawing.Point(354, 114)
        Me.LbSporSecimi.Name = "LbSporSecimi"
        Me.LbSporSecimi.Size = New System.Drawing.Size(230, 212)
        Me.LbSporSecimi.TabIndex = 3
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(699, 31)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SPOR LİSTESİ"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 638)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form4"
        Me.Text = "KULLANICI EKRANI "
        Me.TabControl1.ResumeLayout(False)
        Me.TPBesinSecimi.ResumeLayout(False)
        Me.TPBesinSecimi.PerformLayout()
        CType(Me.DgvBesinSecim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPSporSecimi.ResumeLayout(False)
        Me.TPSporSecimi.PerformLayout()
        CType(Me.DgvSecilenSpor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TPBesinSecimi As TabPage
    Friend WithEvents TPSporSecimi As TabPage
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnKaydetSpor As Button
    Friend WithEvents LabelSporSecimi As Label
    Friend WithEvents LbSporSecimi As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LabelHarcananKalori As Label
    Friend WithEvents tbHarcananKalori As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnKSistemCikis As Button
    Friend WithEvents DgvBesinSecim As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents LbK_Secim As ListBox
    Friend WithEvents tbB_TC As TextBox
    Friend WithEvents BtnKaydetBesin As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents LbBesin As ListBox
    Friend WithEvents LblOgunSecimi As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents CmbOgunSecimi As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnB_Sil As Button
    Friend WithEvents DgvSecilenSpor As DataGridView
    Friend WithEvents LbSporListesi As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbS_TC As TextBox
    Friend WithEvents lblKalori As Label
    Friend WithEvents tbSure As TextBox
    Friend WithEvents btnS_Sil As Button
End Class
