Imports System.Data.SqlClient
Public Class Form4

    Dim diyetisyenbesin As String
    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DiyetTakipDB.mdf;Integrated Security=True;Connect Timeout=30")

    Sub dsabahgoster() 'Diyetisyen ekranındaki TC ye göre atanan sabah öğününün besinlerini LbBesin de gösterir.
        TextBox3.DataBindings.Clear()
        connection.Open()
        Dim sql As String = ("select * from Ogunler where TC='" & tbB_TC.Text & "'")
        Dim command3 As New SqlCommand(sql, connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command3)
        Dim datatable As New DataTable()
        adapter.Fill(datatable)

        TextBox3.DataBindings.Add("Text", datatable, "Sabah") 'DataBindings özelliği ile öğünler tablosundaki sabah alanındaki kayıtları textbox3 ün içine atar.
        diyetisyenbesin = TextBox3.Text

        Dim Dizi() As String
        Dizi = diyetisyenbesin.Split(":") 'öğünler tablosundaki besinleri : göre ayırıp dizi isimli dizinin içine atar. 
        For i = 0 To Dizi.Count - 1  'Dizi dizisinin içindeki tüm elemanları LbBesin in içine atar.
            LbBesin.Items.Add(Dizi(i))
        Next
        connection.Close()

    End Sub
    Sub dara1goster()
        TextBox3.DataBindings.Clear()
        connection.Open()
        Dim sql As String = ("select * from Ogunler where TC='" & tbB_TC.Text & "'")
        Dim command3 As New SqlCommand(sql, connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command3)
        Dim datatable As New DataTable()
        adapter.Fill(datatable)

        TextBox3.DataBindings.Add("Text", datatable, "AraOgun1")


        diyetisyenbesin = TextBox3.Text
        Dim Dizi() As String
        Dizi = diyetisyenbesin.Split(":")
        For i = 0 To Dizi.Count - 1
            LbBesin.Items.Add(Dizi(i))
        Next
        connection.Close()


    End Sub
    Sub dara2goster()
        TextBox3.DataBindings.Clear()
        connection.Open()
        Dim sql As String = ("select * from Ogunler where TC='" & tbB_TC.Text & "'")
        Dim command3 As New SqlCommand(sql, connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command3)
        Dim datatable As New DataTable()
        adapter.Fill(datatable)

        TextBox3.DataBindings.Add("Text", datatable, "AraOgun2")
        diyetisyenbesin = TextBox3.Text
        Dim Dizi() As String
        Dizi = diyetisyenbesin.Split(":")
        For i = 0 To Dizi.Count - 1
            LbBesin.Items.Add(Dizi(i))
        Next
        connection.Close()


    End Sub
    Sub doglegoster()
        TextBox3.DataBindings.Clear()
        connection.Open()
        Dim sql As String = ("select * from Ogunler where TC='" & tbB_TC.Text & "'")
        Dim command3 As New SqlCommand(sql, connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command3)
        Dim datatable As New DataTable()
        adapter.Fill(datatable)

        TextBox3.DataBindings.Add("Text", datatable, "Ogle")

        diyetisyenbesin = TextBox3.Text
        Dim Dizi() As String
        Dizi = diyetisyenbesin.Split(":")
        For i = 0 To Dizi.Count - 1
            LbBesin.Items.Add(Dizi(i))
        Next
        connection.Close()


    End Sub
    Sub daksamgoster()
        TextBox3.DataBindings.Clear()
        connection.Open()
        Dim sql As String = ("select * from Ogunler where TC='" & tbB_TC.Text & "'")
        Dim command3 As New SqlCommand(sql, connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command3)
        Dim datatable As New DataTable()
        adapter.Fill(datatable)

        TextBox3.DataBindings.Add("Text", datatable, "Aksam")


        diyetisyenbesin = TextBox3.Text
        Dim Dizi() As String
        Dizi = diyetisyenbesin.Split(":")
        For i = 0 To Dizi.Count - 1
            LbBesin.Items.Add(Dizi(i))
        Next
        connection.Close()

    End Sub
    Sub kullaniciogungoster()  'LbK_Secim de seçilen besinleri dgvBesinSeciminde göstermeye yarar.

        connection.Open()
        Dim sql As String = ("select * from KullaniciOgunler where TC='" & tbB_TC.Text & "'")
        Dim command3 As New SqlCommand(sql, connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command3)
        Dim datatable As New DataTable()
        adapter.Fill(datatable)
        DgvBesinSecim.DataSource = datatable
        connection.Close()
    End Sub
    Sub kullaniciogunsabahkaydet() 'LbK_Secim de seçilen besinleri KullaniciOgunler tablosuna ekler.

        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim command1 As New SqlCommand()

        Dim secilenbesin As String
        secilenbesin = ""


        For i = 0 To LbK_Secim.Items.Count - 1

            secilenbesin = secilenbesin & LbK_Secim.Items(i).ToString() & ":"

        Next
        connection.Open()
        command1 = New SqlCommand("insert into KullaniciOgunler(tarih,TC,Sabah) values ('" & MonthCalendar1.SelectionRange.Start & "','" & tbB_TC.Text & "','" & secilenbesin & "')", connection)


        command1.ExecuteNonQuery() 'command1'i sqlde çalıştırıp geriye değer döndürür.
        adapter.InsertCommand = command1

        connection.Close()

    End Sub
    Sub kullaniciogunara1kaydet()

        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim command1 As New SqlCommand()

        Dim secilenbesin As String
        secilenbesin = ""


        For i = 0 To LbK_Secim.Items.Count - 1

            secilenbesin = secilenbesin & LbK_Secim.Items(i).ToString() & ":"

        Next
        connection.Open()
        command1 = New SqlCommand("update KullaniciOgunler set AraOgun1= '" & secilenbesin & "' where tarih='" & MonthCalendar1.SelectionRange.Start & "'", connection)


        command1.ExecuteNonQuery() 'command1'i sqlde çalıştırıp geriye değer döndürür.
        adapter.InsertCommand = command1

        connection.Close()

    End Sub
    Sub kullaniciogunara2kaydet()

        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim command1 As New SqlCommand()

        Dim secilenbesin As String
        secilenbesin = ""


        For i = 0 To LbK_Secim.Items.Count - 1

            secilenbesin = secilenbesin & LbK_Secim.Items(i).ToString() & ":"

        Next
        connection.Open()
        command1 = New SqlCommand("update KullaniciOgunler set AraOgun2= '" & secilenbesin & "' where tarih='" & MonthCalendar1.SelectionRange.Start & "'", connection)


        command1.ExecuteNonQuery() 'command1'i sqlde çalıştırıp geriye değer döndürür.
        adapter.InsertCommand = command1

        connection.Close()

    End Sub
    Sub kullaniciogunoglekaydet()

        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim command1 As New SqlCommand()

        Dim secilenbesin As String
        secilenbesin = ""


        For i = 0 To LbK_Secim.Items.Count - 1

            secilenbesin = secilenbesin & LbK_Secim.Items(i).ToString() & ":"

        Next
        connection.Open()
        command1 = New SqlCommand("update KullaniciOgunler set Ogle= '" & secilenbesin & "' where tarih='" & MonthCalendar1.SelectionRange.Start & "'", connection)


        command1.ExecuteNonQuery() 'command1'i sqlde çalıştırıp geriye değer döndürür.
        adapter.InsertCommand = command1

        connection.Close()

    End Sub
    Sub kullaniciogunaksamkaydet()

        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim command1 As New SqlCommand()

        Dim secilenbesin As String
        secilenbesin = ""


        For i = 0 To LbK_Secim.Items.Count - 1

            secilenbesin = secilenbesin & LbK_Secim.Items(i).ToString() & ":"

        Next
        connection.Open()
        command1 = New SqlCommand("update KullaniciOgunler set Aksam= '" & secilenbesin & "' where tarih='" & MonthCalendar1.SelectionRange.Start & "'", connection)


        command1.ExecuteNonQuery() 'command1'i sqlde çalıştırıp geriye değer döndürür.
        adapter.InsertCommand = command1

        connection.Close()

    End Sub
    Sub kullaniciogunkaydet()

        If CmbOgunSecimi.Text = "SABAH" Then
            kullaniciogunsabahkaydet()
        End If
        If CmbOgunSecimi.Text = "ARA ÖĞÜN 1" Then

            kullaniciogunara1kaydet()
        End If
        If CmbOgunSecimi.Text = "ÖĞLE" Then

            kullaniciogunoglekaydet()
        End If
        If CmbOgunSecimi.Text = "ARA ÖĞÜN 2" Then

            kullaniciogunara2kaydet()
        End If
        If CmbOgunSecimi.Text = "AKŞAM" Then

            kullaniciogunaksamkaydet()
        End If
    End Sub





    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbOgunSecimi.SelectedIndexChanged
        If CmbOgunSecimi.Text = "SABAH" Then
            LbBesin.Items.Clear()
            LbK_Secim.Items.Clear()
            dsabahgoster()
        End If
        If CmbOgunSecimi.Text = "ARA ÖĞÜN 1" Then
            LbBesin.Items.Clear()
            LbK_Secim.Items.Clear()
            dara1goster()
        End If
        If CmbOgunSecimi.Text = "ARA ÖĞÜN 2" Then
            LbBesin.Items.Clear()
            LbK_Secim.Items.Clear()
            dara2goster()
        End If
        If CmbOgunSecimi.Text = "ÖĞLE" Then
            LbBesin.Items.Clear()
            LbK_Secim.Items.Clear()
            doglegoster()
        End If
        If CmbOgunSecimi.Text = "AKŞAM" Then
            LbBesin.Items.Clear()
            LbK_Secim.Items.Clear()
            daksamgoster()
        End If

    End Sub





    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        kullaniciogungoster()
        TextBox3.Hide()
        sporsecimi()

    End Sub

    Private Sub BtnKaydetBesin_Click(sender As Object, e As EventArgs) Handles BtnKaydetBesin.Click

        kullaniciogunkaydet()
        kullaniciogungoster()
    End Sub



    Private Sub LbSabah_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbBesin.SelectedIndexChanged
        LbK_Secim.Items.Add(LbBesin.SelectedItem)
    End Sub

    'Sub tablobosalt()
    '    connection.Open()
    '    Dim sql As String = ("select * from KullaniciOgunler")
    '    Dim command3 As New SqlCommand(sql, connection)
    '    Dim adapter As SqlDataAdapter = New SqlDataAdapter(command3)
    '    Dim datatable As New DataTable()

    '    DgvBesinSecim.DataSource = datatable
    '    datatable.Clear()
    '    connection.Close()
    'End Sub


    Private Sub btnKSistemCikis_Click(sender As Object, e As EventArgs) Handles btnKSistemCikis.Click
        Application.Exit()


        '  tablobosalt()
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnB_Sil.Click
        If LbK_Secim.Items.Count > 0 Then
            LbK_Secim.Items.Remove(LbK_Secim.SelectedItems(0))
        End If
    End Sub







    Sub sporsecimi() '

        connection.Open()
        Dim sql As String = ("select * from Spor")
        Dim command3 As New SqlCommand(sql, connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command3)
        Dim datatable As New DataTable()
        adapter.Fill(datatable)
        Dim DR As SqlDataReader
        DR = command3.ExecuteReader() 'bir veya birden fazla veri satırının döneceği durumlarda sorgular 
        If (DR.Read) Then
            Do While DR.Read = True
                LbSporListesi.Items.Add(DR("SporTuru").ToString)
                LbSporListesi.Tag = DR("SporID")
            Loop
        End If
        connection.Close()
    End Sub

    Sub sporkaydet() 'secilen sporları gunlukspor tablosuna ekler

        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim command1 As New SqlCommand()

        Dim secilenspor As String
        secilenspor = ""

        secilenspor = LbSporListesi.Text
        If secilenspor = "İp Atlamak" Then
            tbHarcananKalori.Text = (Convert.ToInt32(tbSure.Text) * 52 * 2).ToString()
        End If
        If secilenspor = "Ağırlık Çalışmak" Then
            tbHarcananKalori.Text = (Convert.ToInt32(tbSure.Text) * 135 * 2).ToString()
        End If
        If secilenspor = "Bisiklete Binmek" Then
            tbHarcananKalori.Text = (Convert.ToInt32(tbSure.Text) * 315 * 2).ToString()
        End If
        If secilenspor = "Aerobik" Then
            tbHarcananKalori.Text = (Convert.ToInt32(tbSure.Text) * 210 * 2).ToString()
        End If

        If secilenspor = "Yürüyüş" Then
            tbHarcananKalori.Text = (Convert.ToInt32(tbSure.Text) * 200 * 2).ToString()
        End If

        connection.Open()
        command1 = New SqlCommand("insert into GunlukSpor(SporTuru,TC,Tarih,YakilanKalori) values ('" & secilenspor & "','" & tbS_TC.Text & "','" & MonthCalendar2.SelectionRange.Start & "','" & tbHarcananKalori.Text & "')", connection)


        command1.ExecuteNonQuery() 'command1'i sqlde çalıştırıp geriye değer döndürür.
        adapter.InsertCommand = command1
        connection.Close()
        DgvSecilenSpor.DataSource = adapter


    End Sub


    Sub sporgoster() 'secilen sporları dgvsecilenspor da gösterir
        connection.Open()
        Dim sql As String = ("select SporTuru,TC,Tarih,YakilanKalori from GunlukSpor where TC='" & tbS_TC.Text & "'")
        Dim command3 As New SqlCommand(sql, connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command3)
        Dim datatable As New DataTable()
        adapter.Fill(datatable)
        DgvSecilenSpor.DataSource = datatable
        connection.Close()
    End Sub

    Private Sub LbSporListesi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbSporListesi.SelectedIndexChanged
        LbSporSecimi.Items.Add(LbSporListesi.SelectedItem)
    End Sub

    Private Sub BtnKaydetSpor_Click(sender As Object, e As EventArgs) Handles BtnKaydetSpor.Click
        sporkaydet()
        sporgoster()
    End Sub

    Private Sub tbS_TC_TextChanged(sender As Object, e As EventArgs) Handles tbS_TC.TextChanged
        sporgoster()
    End Sub

    Private Sub btnS_Sil_Click(sender As Object, e As EventArgs) Handles btnS_Sil.Click
        If LbSporSecimi.Items.Count > 0 Then
            LbSporSecimi.Items.Remove(LbSporSecimi.SelectedItems(0))
        End If
    End Sub




End Class