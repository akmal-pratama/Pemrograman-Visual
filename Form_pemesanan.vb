Imports MySql.Data.MySqlClient

Public Class Form_pemesanan
    Dim hargaPaketDict As New Dictionary(Of String, Integer)
    Public ID_cabang As String
    Public ID_barber As String
    Public namaBarber As String
    Public jamDipilih As String
    Public TanggalDipilih As String
    Public cabangDipilih As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu_user.Show()
        Me.Hide()
    End Sub

    Private Sub Form_pemesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        tampilPaket()
        cmd = New MySqlCommand("SELECT * FROM cabang WHERE ID_CABANG = @ID_cabang", conn)
        cmd.Parameters.AddWithValue("@ID_cabang", ID_cabang)

        rd = cmd.ExecuteReader
        If rd.Read() Then
            txtCabang.Text = rd("nama_cabang").ToString()
            txtAlamat.Text = rd("alamat").ToString()
        Else
            MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End If
        rd.Close()

        cmd = New MySqlCommand("SELECT * FROM barber WHERE ID_BARBER = @ID_barber", conn)
        cmd.Parameters.AddWithValue("@ID_barber", ID_barber)

        rd = cmd.ExecuteReader
        If rd.Read() Then
            txtBarber.Text = rd("nama_barber").ToString()
            txtNoHP.Text = rd("nomor_telepon").ToString()
        Else
            MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End If
        rd.Close()

        txtTanggal.Text = TanggalDipilih
        txtWaktu.Text = jamDipilih
    End Sub

    Sub tampilPaket()
        cbPaket.Items.Clear()
        hargaPaketDict.Clear()

        cmd = New MySqlCommand("SELECT * FROM paket", conn)
        rd = cmd.ExecuteReader()
        While rd.Read()
            Dim namaPaket As String = rd("nama_paket").ToString()
            Dim harga As Integer = Convert.ToInt32(rd("harga"))

            cbPaket.Items.Add(namaPaket)
            hargaPaketDict(namaPaket) = harga
        End While
        rd.Close()
    End Sub


    Private Sub cbPaket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPaket.SelectedIndexChanged
        Dim namaPaketDipilih As String = cbPaket.SelectedItem.ToString()

        If hargaPaketDict.ContainsKey(namaPaketDipilih) Then
            txtHarga.Text = hargaPaketDict(namaPaketDipilih).ToString()
        Else
            txtHarga.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cbPaket.SelectedItem Is Nothing Then
            MessageBox.Show("Silakan pilih paket terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Koneksi()

            ' Ambil nama paket yang dipilih
            Dim namaPaket As String = cbPaket.SelectedItem.ToString()

            ' Ambil ID paket dari nama paket
            Dim idPaket As String = ""
            cmd = New MySqlCommand("SELECT ID_paket FROM paket WHERE nama_paket = @nama", conn)
            cmd.Parameters.AddWithValue("@nama", namaPaket)
            rd = cmd.ExecuteReader()
            If rd.Read() Then
                idPaket = rd("ID_paket").ToString()
            Else
                MessageBox.Show("Paket tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                rd.Close()
                Return
            End If
            rd.Close()

            ' Gabungkan tanggal dan jam untuk waktu_mulai
            Dim waktuMulai As String = TanggalDipilih & " " & jamDipilih

            ' Simpan ke tabel reservasi
            Dim query As String = "INSERT INTO reservasi (ID_pelanggan, ID_barber, ID_paket, ID_cabang, waktu_mulai) " &
                                  "VALUES (@ID_pelanggan, @ID_barber, @ID_paket, @ID_cabang, @waktu_mulai)"
            cmd = New MySqlCommand(query, conn)

            Dim ID_pelanggan As String = IDPelangganLoggedIn

            cmd.Parameters.AddWithValue("@ID_pelanggan", ID_pelanggan)
            cmd.Parameters.AddWithValue("@ID_barber", ID_barber)
            cmd.Parameters.AddWithValue("@ID_paket", idPaket)
            cmd.Parameters.AddWithValue("@ID_cabang", ID_cabang)
            cmd.Parameters.AddWithValue("@waktu_mulai", waktuMulai)

            cmd.ExecuteNonQuery()

            berhasil.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan reservasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class