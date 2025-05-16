Imports MySql.Data.MySqlClient

Public Class Detail_pemesanan_barber
    Public ID_reservasi As String
    Private Sub Detail_pemesanan_barber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        LoadData()
    End Sub

    Private Sub LoadData()

        Dim query As String = "SELECT r.ID_reservasi, r.waktu_mulai, p.nama_paket, p.harga, c.nama_cabang, c.alamat, " &
                              "pel.nama_pelanggan, pel.nomor_telepon " &
                              "FROM reservasi r " &
                              "JOIN paket p ON r.ID_paket = p.ID_paket " &
                              "JOIN cabang c ON r.ID_cabang = c.ID_CABANG " &
                              "JOIN pelanggan pel ON r.ID_pelanggan = pel.ID_pelanggan " &
                              "WHERE r.ID_reservasi = @id"

        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", ID_reservasi)
        rd = cmd.ExecuteReader()

        If rd.Read Then
            txtCabang.Text = rd("nama_cabang").ToString()
            txtAlamat.Text = rd("alamat").ToString()
            txtPelanggan.Text = rd("nama_pelanggan").ToString()
            txtNoTelp.Text = rd("nomor_telepon").ToString()
            Dim waktuMulai As DateTime = Convert.ToDateTime(rd("waktu_mulai"))
            txtTanggal.Text = waktuMulai.ToString("dd MMMM yyyy")
            txtWaktu.Text = waktuMulai.ToString("HH:mm")
            txtPaket.Text = rd("nama_paket").ToString()
            txtHarga.Text = rd("harga").ToString()
        Else
            MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Menu_barber.Show()
    End Sub
End Class