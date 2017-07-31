Imports System.Data.SqlClient
Public Class DiyetisyenBesinSecimi
    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DiyetTakipDB.mdf;Integrated Security=True;Connect Timeout=30")
    Sub besinsecimi()

        connection.Open()
        Dim sql As String = ("select * from Besinler")
        Dim command3 As New SqlCommand(sql, connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command3)
        Dim datatable As New DataTable()
        adapter.Fill(datatable)
        Dim DR As SqlDataReader
        DR = command3.ExecuteReader()
        If (DR.Read) Then      'DR içinde veri var demektir.Bu kod satırı DR içinde veri olduğu sürece işler. 
            Do While DR.Read = True 'LbD_Besinler içinde veri olduğu sürece döngü dönecektir.
                LbD_Besinler.Items.Add(DR("BesinAdi").ToString) 'LbD_Besinler içine besinler tablosunun BesinAdi içindeki verileri ekler.
            Loop
        End If
        connection.Close()
    End Sub
    Sub ogungoster()

        connection.Open()
        Dim sql As String = ("select * from ogunler")
        Dim command3 As New SqlCommand(sql, connection)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command3)
        Dim datatable As New DataTable()
        adapter.Fill(datatable)
        DgvBesinAtama.DataSource = datatable 'DgvBesinAtama içine verileri göstermek için kullanılır.
        connection.Close()
    End Sub
    Sub ogunsabahkaydet()

        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim command1 As New SqlCommand()

        Dim secilenbesin As String
        secilenbesin = ""

        For i = 0 To LbD_SecilenBesinler.Items.Count - 1  'Döngünün amacı veritabanından verileri çekerken alt alta yazmak yerine : koyarak yan yana yazdırmaktır.

            secilenbesin = secilenbesin & LbD_SecilenBesinler.Items(i).ToString() & ":"

        Next

        connection.Open()
        command1 = New SqlCommand("insert into Ogunler(OgunID,TC,Sabah) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & secilenbesin & "')", connection)


        command1.ExecuteNonQuery() 'command1'i sqlde çalıştırıp geriye değer döndürür.
        adapter.InsertCommand = command1

        connection.Close()

    End Sub
    Sub ogunara1kaydet()

        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim command1 As New SqlCommand()

        Dim secilenbesin As String
        secilenbesin = ""


        For i = 0 To LbD_SecilenBesinler.Items.Count - 1

            secilenbesin = secilenbesin & LbD_SecilenBesinler.Items(i).ToString() & ":"

        Next
        connection.Open()
        'Sabah öğünü eklenmişti.Üzerine ekleme yapmak yerine güncelleyerek ara öğünü getiriyoruz.
        command1 = New SqlCommand("update Ogunler set AraOgun1= '" & secilenbesin & "' where OgunID='" & TextBox1.Text & "'", connection)


        command1.ExecuteNonQuery() 'command1'i sqlde çalıştırıp geriye değer döndürür.
        adapter.InsertCommand = command1

        connection.Close()

    End Sub
    Sub ogunara2kaydet()

        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim command1 As New SqlCommand()

        Dim secilenbesin As String
        secilenbesin = ""


        For i = 0 To LbD_SecilenBesinler.Items.Count - 1

            secilenbesin = secilenbesin & LbD_SecilenBesinler.Items(i).ToString() & ":"

        Next
        connection.Open()
        command1 = New SqlCommand("update Ogunler set AraOgun2= '" & secilenbesin & "' where OgunID='" & TextBox1.Text & "'", connection)


        command1.ExecuteNonQuery() 'command1'i sqlde çalıştırıp geriye değer döndürür.
        adapter.InsertCommand = command1

        connection.Close()

    End Sub
    Sub ogunoglekaydet()

        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim command1 As New SqlCommand()

        Dim secilenbesin As String
        secilenbesin = ""


        For i = 0 To LbD_SecilenBesinler.Items.Count - 1

            secilenbesin = secilenbesin & LbD_SecilenBesinler.Items(i).ToString() & ":"

        Next
        connection.Open()
        command1 = New SqlCommand("update Ogunler set Ogle= '" & secilenbesin & "' where OgunID='" & TextBox1.Text & "'", connection)


        command1.ExecuteNonQuery() 'command1'i sqlde çalıştırıp geriye değer döndürür.
        adapter.InsertCommand = command1

        connection.Close()

    End Sub
    Sub ogunaksamkaydet()

        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim command1 As New SqlCommand()

        Dim secilenbesin As String
        secilenbesin = ""


        For i = 0 To LbD_SecilenBesinler.Items.Count - 1

            secilenbesin = secilenbesin & LbD_SecilenBesinler.Items(i).ToString() & ":"

        Next
        connection.Open()
        command1 = New SqlCommand("update Ogunler set Aksam= '" & secilenbesin & "' where OgunID='" & TextBox1.Text & "'", connection)


        command1.ExecuteNonQuery() 'command1'i sqlde çalıştırıp geriye değer döndürür.
        adapter.InsertCommand = command1

        connection.Close()

    End Sub
    Sub ogunkaydet()

        If ComboBox1.Text = "SABAH" Then
            ogunsabahkaydet()
        End If
        If ComboBox1.Text = "ARA ÖĞÜN 1" Then

            ogunara1kaydet()
        End If
        If ComboBox1.Text = "ÖĞLE" Then

            ogunoglekaydet()
        End If
        If ComboBox1.Text = "ARA ÖĞÜN 2" Then

            ogunara2kaydet()
        End If
        If ComboBox1.Text = "AKŞAM" Then

            ogunaksamkaydet()
        End If
    End Sub


    Private Sub DiyetisyenBesinSecimi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ogungoster()
        besinsecimi()


    End Sub

    Private Sub LbD_Sabah_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbD_Besinler.SelectedIndexChanged

        LbD_SecilenBesinler.Items.Add(LbD_Besinler.SelectedItem) 'Besinlerin kayıtlı olduğu listboxtan seçilen besinleri LBd_SecilenBesinler e eklememizi sağlar.
    End Sub

    Private Sub BtnD_Ekle_Click(sender As Object, e As EventArgs) Handles BtnD_Ekle.Click
        ogunkaydet()
        ogungoster()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        LbD_SecilenBesinler.Items.Clear()
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub tbBesinAra_TextChanged(sender As Object, e As EventArgs) Handles tbBesinAra.TextChanged
        If tbBesinAra.Text <> "" Then


            LbD_Besinler.Items.Clear()
            If tbBesinAra.Text = "" Then

                Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DiyetTakipDB.mdf;Integrated Security=True;Connect Timeout=30")
                connection.Open()
                Dim komut As New SqlCommand("select * from Besinler", connection)
                Dim dataAdapter As New SqlDataAdapter(komut)
                Dim dataset As New DataSet()
                dataAdapter.Fill(dataset)
                LbD_Besinler.DataSource = dataset.Tables(0)
                LbD_Besinler.DisplayMember = "BesinAdi"
                LbD_Besinler.ValueMember = "BesinID"
                connection.Close()
            Else
                LbD_Besinler.Items.Clear()
                Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DiyetTakipDB.mdf;Integrated Security=True")
                connection.Open()
                Dim komut As New SqlCommand("select * from Besinler where BesinAdi like @aranan", connection)
                komut.Parameters.AddWithValue("@aranan", tbBesinAra.Text + "%")
                Dim dr As SqlDataReader
                dr = komut.ExecuteReader
                If (dr.HasRows) Then
                    While dr.Read
                        LbD_Besinler.Items.Add(dr.GetValue(1))
                    End While
                End If
                connection.Close()


            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If LbD_SecilenBesinler.Items.Count > 0 Then
            LbD_SecilenBesinler.Items.Remove(LbD_SecilenBesinler.SelectedItems(0)) 'Listboxtaki seçilen besinleri siler.
        End If
    End Sub

    Private Sub btnD_Sil_Click(sender As Object, e As EventArgs) Handles btnD_Sil.Click

        Dim sql As New String("DELETE FROM Ogunler WHERE OgunID='{0}'   ")

        sql = String.Format(sql, DgvBesinAtama.CurrentRow.Cells(0).Value)
        Dim baglanti As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DiyetTakipDB.mdf;Integrated Security=True;Connect Timeout=30")
        Dim komutnesnesi As New SqlCommand(sql, baglanti)
        Dim sonuc As Integer
        baglanti.Open()
        sonuc = komutnesnesi.ExecuteNonQuery()
        If sonuc = 1 Then
            MsgBox("Listeden Seçmiş Olduğunuz Veri Silinmiştir.", MsgBoxStyle.Exclamation, "Kayıt Uyarı")

        End If
        baglanti.Close()
        ogungoster()

    End Sub
End Class