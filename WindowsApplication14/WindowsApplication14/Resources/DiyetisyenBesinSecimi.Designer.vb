<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiyetisyenBesinSecimi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiyetisyenBesinSecimi))
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbD_SecilenBesinler = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelD_BesinListesi = New System.Windows.Forms.Label()
        Me.LabelD_OgunSecimi = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BtnD_Ekle = New System.Windows.Forms.Button()
        Me.BtnD_Ara = New System.Windows.Forms.Button()
        Me.DgvBesinAtama = New System.Windows.Forms.DataGridView()
        Me.LbD_Besinler = New System.Windows.Forms.ListBox()
        Me.tbBesinAra = New System.Windows.Forms.TextBox()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnD_Sil = New System.Windows.Forms.Button()
        CType(Me.DgvBesinAtama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 50)
        Me.TextBox2.MaxLength = 11
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Tc Giriniz"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 16)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Yeni Öğün ID giriniz"
        '
        'LbD_SecilenBesinler
        '
        Me.LbD_SecilenBesinler.FormattingEnabled = True
        Me.LbD_SecilenBesinler.Location = New System.Drawing.Point(126, 110)
        Me.LbD_SecilenBesinler.Name = "LbD_SecilenBesinler"
        Me.LbD_SecilenBesinler.Size = New System.Drawing.Size(120, 355)
        Me.LbD_SecilenBesinler.TabIndex = 46
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(312, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 45
        '
        'LabelD_BesinListesi
        '
        Me.LabelD_BesinListesi.AutoSize = True
        Me.LabelD_BesinListesi.BackColor = System.Drawing.Color.LightGray
        Me.LabelD_BesinListesi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelD_BesinListesi.Location = New System.Drawing.Point(336, 85)
        Me.LabelD_BesinListesi.Name = "LabelD_BesinListesi"
        Me.LabelD_BesinListesi.Size = New System.Drawing.Size(147, 16)
        Me.LabelD_BesinListesi.TabIndex = 43
        Me.LabelD_BesinListesi.Text = "Besin Seçim Listesi:"
        '
        'LabelD_OgunSecimi
        '
        Me.LabelD_OgunSecimi.AutoSize = True
        Me.LabelD_OgunSecimi.BackColor = System.Drawing.Color.LightGray
        Me.LabelD_OgunSecimi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelD_OgunSecimi.Location = New System.Drawing.Point(145, 21)
        Me.LabelD_OgunSecimi.Name = "LabelD_OgunSecimi"
        Me.LabelD_OgunSecimi.Size = New System.Drawing.Size(99, 16)
        Me.LabelD_OgunSecimi.TabIndex = 42
        Me.LabelD_OgunSecimi.Text = "Öğün Seçimi:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SABAH", "ARA ÖĞÜN 1", "ÖĞLE", "ARA ÖĞÜN 2", "AKŞAM"})
        Me.ComboBox1.Location = New System.Drawing.Point(148, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 41
        '
        'BtnD_Ekle
        '
        Me.BtnD_Ekle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnD_Ekle.Image = Global.WindowsApplication14.My.Resources.Resources.add_iconum
        Me.BtnD_Ekle.Location = New System.Drawing.Point(252, 242)
        Me.BtnD_Ekle.Name = "BtnD_Ekle"
        Me.BtnD_Ekle.Size = New System.Drawing.Size(81, 51)
        Me.BtnD_Ekle.TabIndex = 40
        Me.BtnD_Ekle.Text = "EKLE"
        Me.BtnD_Ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnD_Ekle.UseVisualStyleBackColor = True
        '
        'BtnD_Ara
        '
        Me.BtnD_Ara.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnD_Ara.Image = Global.WindowsApplication14.My.Resources.Resources.Search_iconum
        Me.BtnD_Ara.Location = New System.Drawing.Point(148, 491)
        Me.BtnD_Ara.Name = "BtnD_Ara"
        Me.BtnD_Ara.Size = New System.Drawing.Size(81, 51)
        Me.BtnD_Ara.TabIndex = 38
        Me.BtnD_Ara.Text = "ARA"
        Me.BtnD_Ara.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnD_Ara.UseVisualStyleBackColor = True
        '
        'DgvBesinAtama
        '
        Me.DgvBesinAtama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBesinAtama.Location = New System.Drawing.Point(339, 112)
        Me.DgvBesinAtama.Name = "DgvBesinAtama"
        Me.DgvBesinAtama.Size = New System.Drawing.Size(651, 353)
        Me.DgvBesinAtama.TabIndex = 37
        '
        'LbD_Besinler
        '
        Me.LbD_Besinler.FormattingEnabled = True
        Me.LbD_Besinler.Location = New System.Drawing.Point(12, 110)
        Me.LbD_Besinler.Name = "LbD_Besinler"
        Me.LbD_Besinler.Size = New System.Drawing.Size(108, 355)
        Me.LbD_Besinler.TabIndex = 36
        '
        'tbBesinAra
        '
        Me.tbBesinAra.Location = New System.Drawing.Point(12, 503)
        Me.tbBesinAra.Name = "tbBesinAra"
        Me.tbBesinAra.Size = New System.Drawing.Size(108, 20)
        Me.tbBesinAra.TabIndex = 51
        '
        'btnSil
        '
        Me.btnSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSil.Image = Global.WindowsApplication14.My.Resources.Resources.Remove_iconum
        Me.btnSil.Location = New System.Drawing.Point(252, 327)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(81, 50)
        Me.btnSil.TabIndex = 52
        Me.btnSil.Text = "SİL"
        Me.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSil.UseVisualStyleBackColor = True
        '
        'btnD_Sil
        '
        Me.btnD_Sil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnD_Sil.Image = CType(resources.GetObject("btnD_Sil.Image"), System.Drawing.Image)
        Me.btnD_Sil.Location = New System.Drawing.Point(909, 491)
        Me.btnD_Sil.Name = "btnD_Sil"
        Me.btnD_Sil.Size = New System.Drawing.Size(81, 50)
        Me.btnD_Sil.TabIndex = 53
        Me.btnD_Sil.Text = "SİL"
        Me.btnD_Sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnD_Sil.UseVisualStyleBackColor = True
        '
        'DiyetisyenBesinSecimi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1002, 560)
        Me.Controls.Add(Me.btnD_Sil)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.tbBesinAra)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbD_SecilenBesinler)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelD_BesinListesi)
        Me.Controls.Add(Me.LabelD_OgunSecimi)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BtnD_Ekle)
        Me.Controls.Add(Me.BtnD_Ara)
        Me.Controls.Add(Me.DgvBesinAtama)
        Me.Controls.Add(Me.LbD_Besinler)
        Me.Name = "DiyetisyenBesinSecimi"
        Me.Text = "DiyetisyenBesinSecimi"
        CType(Me.DgvBesinAtama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LbD_SecilenBesinler As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelD_BesinListesi As Label
    Friend WithEvents LabelD_OgunSecimi As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BtnD_Ekle As Button
    Friend WithEvents BtnD_Ara As Button
    Friend WithEvents DgvBesinAtama As DataGridView
    Friend WithEvents LbD_Besinler As ListBox
    Friend WithEvents tbBesinAra As TextBox
    Friend WithEvents btnSil As Button
    Friend WithEvents btnD_Sil As Button
End Class
