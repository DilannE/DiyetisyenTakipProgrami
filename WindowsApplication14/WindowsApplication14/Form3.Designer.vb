<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.TPRapor = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgvSporRapor = New System.Windows.Forms.DataGridView()
        Me.DgvBesinRapor = New System.Windows.Forms.DataGridView()
        Me.DgvR_KullaniciBilgileri = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.BtnR_Ara = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelR_Ara = New System.Windows.Forms.Label()
        Me.TPKullaniciBilgileri = New System.Windows.Forms.TabPage()
        Me.btnSistemCikis = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbAranan = New System.Windows.Forms.TextBox()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.DgvD_KullaniciBilgileri = New System.Windows.Forms.DataGridView()
        Me.TabControl14 = New System.Windows.Forms.TabControl()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TPRapor.SuspendLayout()
        CType(Me.DgvSporRapor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvBesinRapor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvR_KullaniciBilgileri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPKullaniciBilgileri.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvD_KullaniciBilgileri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl14.SuspendLayout()
        Me.SuspendLayout()
        '
        'TPRapor
        '
        Me.TPRapor.BackColor = System.Drawing.Color.Tan
        Me.TPRapor.Controls.Add(Me.Label2)
        Me.TPRapor.Controls.Add(Me.Label3)
        Me.TPRapor.Controls.Add(Me.DgvSporRapor)
        Me.TPRapor.Controls.Add(Me.DgvBesinRapor)
        Me.TPRapor.Controls.Add(Me.DgvR_KullaniciBilgileri)
        Me.TPRapor.Controls.Add(Me.Panel1)
        Me.TPRapor.Location = New System.Drawing.Point(4, 22)
        Me.TPRapor.Name = "TPRapor"
        Me.TPRapor.Padding = New System.Windows.Forms.Padding(3)
        Me.TPRapor.Size = New System.Drawing.Size(901, 599)
        Me.TPRapor.TabIndex = 2
        Me.TPRapor.Text = "Rapor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "BESİN RAPOR:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(462, 351)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "SPOR RAPOR:"
        '
        'DgvSporRapor
        '
        Me.DgvSporRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSporRapor.Location = New System.Drawing.Point(465, 378)
        Me.DgvSporRapor.Name = "DgvSporRapor"
        Me.DgvSporRapor.Size = New System.Drawing.Size(386, 209)
        Me.DgvSporRapor.TabIndex = 10
        '
        'DgvBesinRapor
        '
        Me.DgvBesinRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBesinRapor.Location = New System.Drawing.Point(8, 378)
        Me.DgvBesinRapor.Name = "DgvBesinRapor"
        Me.DgvBesinRapor.Size = New System.Drawing.Size(389, 209)
        Me.DgvBesinRapor.TabIndex = 9
        '
        'DgvR_KullaniciBilgileri
        '
        Me.DgvR_KullaniciBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvR_KullaniciBilgileri.Location = New System.Drawing.Point(6, 253)
        Me.DgvR_KullaniciBilgileri.Name = "DgvR_KullaniciBilgileri"
        Me.DgvR_KullaniciBilgileri.Size = New System.Drawing.Size(843, 95)
        Me.DgvR_KullaniciBilgileri.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Wheat
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Controls.Add(Me.BtnR_Ara)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.LabelR_Ara)
        Me.Panel1.Location = New System.Drawing.Point(8, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 226)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(505, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "RAPOR TARİHİ SEÇİNİZ"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication14.My.Resources.Resources.yenfl
        Me.PictureBox1.Location = New System.Drawing.Point(70, 133)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 29)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Arayacağınız kullanıcıyı ""TC Numarası"" girerek arayınız.")
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(508, 44)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 4
        '
        'BtnR_Ara
        '
        Me.BtnR_Ara.BackColor = System.Drawing.Color.LightGray
        Me.BtnR_Ara.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnR_Ara.Location = New System.Drawing.Point(203, 133)
        Me.BtnR_Ara.Name = "BtnR_Ara"
        Me.BtnR_Ara.Size = New System.Drawing.Size(75, 41)
        Me.BtnR_Ara.TabIndex = 3
        Me.BtnR_Ara.Text = "ARA"
        Me.BtnR_Ara.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(70, 76)
        Me.TextBox1.MaxLength = 11
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 20)
        Me.TextBox1.TabIndex = 0
        '
        'LabelR_Ara
        '
        Me.LabelR_Ara.AutoSize = True
        Me.LabelR_Ara.BackColor = System.Drawing.Color.LightGray
        Me.LabelR_Ara.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelR_Ara.Location = New System.Drawing.Point(67, 44)
        Me.LabelR_Ara.Name = "LabelR_Ara"
        Me.LabelR_Ara.Size = New System.Drawing.Size(122, 16)
        Me.LabelR_Ara.TabIndex = 1
        Me.LabelR_Ara.Text = "KULLANICI ARA:"
        '
        'TPKullaniciBilgileri
        '
        Me.TPKullaniciBilgileri.BackColor = System.Drawing.Color.Tan
        Me.TPKullaniciBilgileri.Controls.Add(Me.btnSistemCikis)
        Me.TPKullaniciBilgileri.Controls.Add(Me.PictureBox2)
        Me.TPKullaniciBilgileri.Controls.Add(Me.Label4)
        Me.TPKullaniciBilgileri.Controls.Add(Me.tbAranan)
        Me.TPKullaniciBilgileri.Controls.Add(Me.btnSil)
        Me.TPKullaniciBilgileri.Controls.Add(Me.DgvD_KullaniciBilgileri)
        Me.TPKullaniciBilgileri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TPKullaniciBilgileri.Location = New System.Drawing.Point(4, 22)
        Me.TPKullaniciBilgileri.Name = "TPKullaniciBilgileri"
        Me.TPKullaniciBilgileri.Padding = New System.Windows.Forms.Padding(3)
        Me.TPKullaniciBilgileri.Size = New System.Drawing.Size(901, 599)
        Me.TPKullaniciBilgileri.TabIndex = 0
        Me.TPKullaniciBilgileri.Text = "Kullanıcı Bilgileri"
        '
        'btnSistemCikis
        '
        Me.btnSistemCikis.Location = New System.Drawing.Point(610, 423)
        Me.btnSistemCikis.Name = "btnSistemCikis"
        Me.btnSistemCikis.Size = New System.Drawing.Size(83, 63)
        Me.btnSistemCikis.TabIndex = 9
        Me.btnSistemCikis.Text = "ÇIKIŞ"
        Me.btnSistemCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSistemCikis.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication14.My.Resources.Resources.Search_iconum
        Me.PictureBox2.Location = New System.Drawing.Point(55, 426)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 426)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Aranan Kullanıcının" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TC Numarası:"
        '
        'tbAranan
        '
        Me.tbAranan.Location = New System.Drawing.Point(147, 466)
        Me.tbAranan.Name = "tbAranan"
        Me.tbAranan.Size = New System.Drawing.Size(192, 21)
        Me.tbAranan.TabIndex = 6
        '
        'btnSil
        '
        Me.btnSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSil.Image = CType(resources.GetObject("btnSil.Image"), System.Drawing.Image)
        Me.btnSil.Location = New System.Drawing.Point(443, 426)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(83, 60)
        Me.btnSil.TabIndex = 5
        Me.btnSil.Text = "SİL"
        Me.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSil.UseVisualStyleBackColor = True
        '
        'DgvD_KullaniciBilgileri
        '
        Me.DgvD_KullaniciBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvD_KullaniciBilgileri.Location = New System.Drawing.Point(29, 38)
        Me.DgvD_KullaniciBilgileri.Name = "DgvD_KullaniciBilgileri"
        Me.DgvD_KullaniciBilgileri.Size = New System.Drawing.Size(843, 344)
        Me.DgvD_KullaniciBilgileri.TabIndex = 2
        '
        'TabControl14
        '
        Me.TabControl14.Controls.Add(Me.TPKullaniciBilgileri)
        Me.TabControl14.Controls.Add(Me.TPRapor)
        Me.TabControl14.Location = New System.Drawing.Point(0, 1)
        Me.TabControl14.Name = "TabControl14"
        Me.TabControl14.SelectedIndex = 0
        Me.TabControl14.Size = New System.Drawing.Size(909, 625)
        Me.TabControl14.TabIndex = 0
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 633)
        Me.Controls.Add(Me.TabControl14)
        Me.Name = "Form3"
        Me.Text = "DİYETİSYEN EKRANI "
        Me.TPRapor.ResumeLayout(False)
        Me.TPRapor.PerformLayout()
        CType(Me.DgvSporRapor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvBesinRapor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvR_KullaniciBilgileri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPKullaniciBilgileri.ResumeLayout(False)
        Me.TPKullaniciBilgileri.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvD_KullaniciBilgileri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl14.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TPRapor As TabPage
    Friend WithEvents TPKullaniciBilgileri As TabPage
    Friend WithEvents btnSil As Button
    Friend WithEvents DgvD_KullaniciBilgileri As DataGridView
    Friend WithEvents TabControl14 As TabControl
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents tbAranan As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSistemCikis As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DgvSporRapor As DataGridView
    Friend WithEvents DgvBesinRapor As DataGridView
    Friend WithEvents DgvR_KullaniciBilgileri As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents BtnR_Ara As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelR_Ara As Label
End Class
