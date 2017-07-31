Imports System.Data.SqlClient

Public Class Form3
    Public Sub kullanicibilgi() 'fonksiyon dgvD_KullaniciBilgileri ne sql sorgusu ile Kullanici tablosundan tüm verileri çekeriz.
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DiyetTakipDB.mdf;Integrated Security=True;Connect Timeout=30")
        connection.Open()
        Dim sql As String = ("select * from Kullanici")
        Dim command3 As New SqlCommand(sql, connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command3)
        Dim datatable As New DataTable()
        adapter.Fill(datatable)
        DgvD_KullaniciBilgileri.DataSource = datatable
        connection.Close()
    End Sub
    Public Sub kullanicikisiselbilgi() 'Rapor Tabında Kullanıcı Ara ile belirttiğimiz textbox ın içine girilen TC ile eşleşen kullanıcıyı dgv içinde görüntülememizi sağlar.
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DiyetTakipDB.mdf;Integrated Security=True;Connect Timeout=30")
        connection.Open()
        Dim sql As String = ("select * from Kullanici where TC='" & TextBox1.Text & "'")
        Dim command3 As New SqlCommand(sql, connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command3)
        Dim datatable As New DataTable()
        adapter.Fill(datatable)
        DgvR_KullaniciBilgileri.DataSource = datatable
        connection.Close()
    End Sub
    Public Sub kullaniciogunbilgi() 'Rapor Tab ında girilen TC ye ait kullanıcının diyetisyenin önerileriyle yaptığı seçimleri KullanıcıÖğünler tablosuna çekerek dgv de gösterir.
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DiyetTakipDB.mdf;Integrated Security=True;Connect Timeout=30")
        connection.Open()
        Dim sql As String = ("select * from KullaniciOgunler where TC='" & TextBox1.Text & "'")
        Dim command3 As New SqlCommand(sql, connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command3)
        Dim datatable As New DataTable()
        adapter.Fill(datatable)
        DgvBesinRapor.DataSource = datatable
        connection.Close()
    End Sub

    Public Sub kullanicisporbilgi() 'Rapor Tabında girilen Tc ye ait kullacının spor bilgilerini GünlükSpor tablosundan çekerek kaydeder.
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DiyetTakipDB.mdf;Integrated Security=True;Connect Timeout=30")
        connection.Open()
        Dim sql As String = ("select * from GunlukSpor where TC='" & TextBox1.Text & "'")
        Dim command3 As New SqlCommand(sql, connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command3)
        Dim datatable As New DataTable()
        adapter.Fill(datatable)
        DgvSporRapor.DataSource = datatable
        connection.Close()
    End Sub

    Private Sub giriskapat(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Form1.Hide()
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kullanicibilgi()
    End Sub

    Private Sub DgvD_KullaniciBilgileri_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvD_KullaniciBilgileri.CellDoubleClick
        DiyetisyenBesinSecimi.Show()
    End Sub


    Private Sub BtnR_Ara_Click(sender As Object, e As EventArgs) Handles BtnR_Ara.Click
        kullanicikisiselbilgi()
        kullaniciogunbilgi()
        kullanicisporbilgi()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSil.Click


        Dim sql As New String("DELETE FROM Kullanici WHERE TC='{0}'   ")
        sql = String.Format(sql, DgvD_KullaniciBilgileri.CurrentRow.Cells(0).Value)
        Dim baglanti As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DiyetTakipDB.mdf;Integrated Security=True;Connect Timeout=30")
        Dim komutnesnesi As New SqlCommand(sql, baglanti)
        Dim sonuc As Integer
        baglanti.Open()
        sonuc = komutnesnesi.ExecuteNonQuery()
        If sonuc = 1 Then
            MsgBox("Listeden Seçmiş Olduğunuz Veri Silinmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

        End If
        baglanti.Close()
        kullanicibilgi()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbAranan.TextChanged



        If tbAranan.Text = "" Then
            Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DiyetTakipDB.mdf;Integrated Security=True;Connect Timeout=30")
            connection.Open()
            Dim komut As New SqlCommand("select * from Kullanici", connection)
            Dim dataAdapter As New SqlDataAdapter(komut)
            Dim dataset As New DataSet()
            dataAdapter.Fill(dataset)
            DgvD_KullaniciBilgileri.DataSource = dataset.Tables(0)
            connection.Close()
        Else
            Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DiyetTakipDB.mdf;Integrated Security=True")
            connection.Open()
            Dim komut As New SqlCommand("select * from Kullanici where TC like '%" + tbAranan.Text + "%'", connection)
            Dim dataAdapter As New SqlDataAdapter(komut)
            Dim dataset As New DataSet()
            dataAdapter.Fill(dataset)
            DgvD_KullaniciBilgileri.DataSource = dataset.Tables(0)
            connection.Close()

        End If

    End Sub

    Public Sub tckisitlama(sender As Object, e As KeyPressEventArgs) Handles tbAranan.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then

            e.Handled = True
        End If
    End Sub

    Private Sub btnSistemCikis_Click(sender As Object, e As EventArgs) Handles btnSistemCikis.Click
        Application.Exit()
    End Sub

End Class









































