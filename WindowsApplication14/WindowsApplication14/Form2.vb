Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Data
Public Class FrmKayitEkle

    Public Sub YeniKayit()


        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim command1 As New SqlCommand()
        Dim command2 As New SqlCommand()

        Dim vki As Double


        vki = Convert.ToDouble(Convert.ToDouble(tbKilo.Text) * 10000) / (Convert.ToDouble(tbBoy.Text) * Convert.ToDouble(tbBoy.Text))

        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DiyetTakipDB.mdf;Integrated Security=True;Connect Timeout=30")
        command1 = New SqlCommand("insert into Kullanici values ('" & tbTC.Text & "','" & tbAdSoyad.Text & "','" & datetpDogumTarihi.Text & "','" & cmbCinsiyet.Text & "'," & CInt(tbBoy.Text) & "," & CInt(tbKilo.Text) & ",'" & CStr(vki) & "','" & datetpBaslangicTarihi.Text & "','" & tbHastalik.Text & "')", connection)
        command2 = New SqlCommand("insert into Giris values ('" & tbKayit_KullaniciAdi.Text & "','" & tbKayit_Sifre.Text & "')", connection)
        connection.Open()
        command1.ExecuteNonQuery() 'command1'i sqlde çalıştırıp geriye değer döndürür.
        command2.ExecuteNonQuery()
        adapter.InsertCommand = command1
        adapter.InsertCommand = command2

        tbTC.Clear()
        tbKayit_KullaniciAdi.Clear()
        tbKayit_Sifre.Clear()
        tbAdSoyad.Clear()
        tbBoy.Clear()
        tbKilo.Clear()
        tbHastalik.Clear()
        connection.Close()

    End Sub
    Public Sub tckisitlama(sender As Object, e As KeyPressEventArgs) Handles tbTC.KeyPress

        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then

            e.Handled = True

        End If
    End Sub

    Public Sub boykisitlama(sender As Object, e As KeyPressEventArgs) Handles tbBoy.KeyPress

        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Public Sub kilokisitlama(sender As Object, e As KeyPressEventArgs) Handles tbKilo.KeyPress

        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub

    Private Sub btnKayitEkle_Click(sender As Object, e As EventArgs) Handles btnKayitEkle.Click
        YeniKayit()
        Form1.Show()
        ' Me.Hide()
    End Sub
End Class