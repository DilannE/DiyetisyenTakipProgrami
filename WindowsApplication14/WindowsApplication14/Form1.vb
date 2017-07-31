Imports System.Data.SqlClient
Imports System.Data
Public Class Form1
    Public Sub KullaniciGiris()

        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL12.SQLEXPRESS\MSSQL\DATA\DIYETTAKIPDB.MDF;Integrated Security=True;Connect Timeout=30")
        connection.Open()
        Dim sql As String = ("select * from Giris where KullaniciAdi='" & tbKullanici.Text & "' And Sifre='" & tbSifre.Text & "'")
        Dim command3 As New SqlCommand(sql, connection)
        Dim datatable As New DataTable()
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command3)
        adapter.Fill(datatable)


        If datatable.Rows.Count > 0 And tbKullanici.Text = "Diyetisyen" And tbSifre.Text = "dgsdgs" Then
            Form3.ShowDialog()
        End If
        If datatable.Rows.Count > 0 And tbKullanici.Text <> "Diyetisyen" And tbSifre.Text <> "dgsdgs" Then
            Form4.ShowDialog()
        End If
        If datatable.Rows.Count <= 0 Then
            MessageBox.Show("yanlış")
        End If
        connection.Close()
    End Sub

    Private Sub btnYeniKayit_Click(sender As Object, e As EventArgs) Handles btnYeniKayit.Click
        FrmKayitEkle.Show()
    End Sub

    Private Sub kapa(sender As Object, e As EventArgs)
        FrmKayitEkle.Hide()
    End Sub

    Private Sub btnGiris_Click(sender As Object, e As EventArgs) Handles btnGiris.Click
        KullaniciGiris()
    End Sub

    Private Sub kapat(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        FrmKayitEkle.Hide()
    End Sub

End Class
