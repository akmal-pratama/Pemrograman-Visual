Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class Detail_pemesanan
    Public ID_reservasi As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        notifikasi.Show()
        Me.Hide()
    End Sub

    Private Sub Detail_pemesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim query As String = "SELECT r.waktu_mulai, p.nama_paket, p.harga, c.nama_cabang, c.alamat, " &
                          "b.nama_barber, b.nomor_telepon " &
                          "FROM reservasi r " &
                          "JOIN paket p ON r.ID_paket = p.ID_paket " &
                          "JOIN cabang c ON r.ID_cabang = c.ID_CABANG " &
                          "JOIN barber b ON r.ID_barber = b.ID_barber " &
                          "WHERE r.ID_reservasi = @id"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", ID_reservasi)
        rd = cmd.ExecuteReader()

        If rd.Read Then
            txtCabang.Text = rd("nama_cabang").ToString()
            txtAlamat.Text = rd("alamat").ToString()
            txtBarber.Text = rd("nama_barber").ToString()
            txtNoTelp.Text = rd("nomor_telepon").ToString()
            txtPaket.Text = rd("nama_paket").ToString()
            txtHarga.Text = rd("harga").ToString()
            Dim waktuMulai As DateTime = Convert.ToDateTime(rd("waktu_mulai"))
            txtTanggal.Text = waktuMulai.ToString("dd MMMM yyyy")
            txtWaktu.Text = waktuMulai.ToString("HH:mm")
        Else
            MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        rd.Close()
        conn.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim preview As New PrintPreviewDialog
        preview.Document = printDoc
        preview.ShowDialog()
    End Sub

    Private Sub printDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDoc.PrintPage
        Dim fontHeader As New Font("Arial", 18, FontStyle.Bold)
        Dim fontSubHeader As New Font("Arial", 12, FontStyle.Regular)
        Dim fontLabel As New Font("Arial", 10, FontStyle.Bold)
        Dim fontValue As New Font("Arial", 10, FontStyle.Regular)
        Dim y As Integer = 100
        Dim leftMargin As Integer = 50
        Dim rightMargin As Integer = e.MarginBounds.Right

        ' HEADER
        e.Graphics.DrawString("BARBER RAND", fontHeader, Brushes.Black, leftMargin, y)
        y += 40
        e.Graphics.DrawString("Struk Pemesanan", fontSubHeader, Brushes.Black, leftMargin, y)
        y += 20

        ' Garis pemisah
        e.Graphics.DrawLine(Pens.Black, leftMargin, y, rightMargin, y)
        y += 20

        ' DATA
        PrintRow(e, "Cabang", txtCabang.Text, y, leftMargin, rightMargin)
        PrintRow(e, "Alamat", txtAlamat.Text, y, leftMargin, rightMargin)
        PrintRow(e, "Barber", txtBarber.Text, y, leftMargin, rightMargin)
        PrintRow(e, "No. Telp", txtNoTelp.Text, y, leftMargin, rightMargin)
        PrintRow(e, "Tanggal", txtTanggal.Text, y, leftMargin, rightMargin)
        PrintRow(e, "Jam", txtWaktu.Text, y, leftMargin, rightMargin)
        PrintRow(e, "Paket", txtPaket.Text, y, leftMargin, rightMargin)
        PrintRow(e, "Harga", "Rp " & txtHarga.Text, y, leftMargin, rightMargin)

        y += 30
        e.Graphics.DrawLine(Pens.Black, leftMargin, y, rightMargin, y)
        y += 30

        ' FOOTER
        e.Graphics.DrawString("Terima kasih telah menggunakan layanan kami!", fontSubHeader, Brushes.Black, leftMargin, y)
        y += 20
        e.Graphics.DrawString("www.BarberRand.com", fontValue, Brushes.Gray, leftMargin, y)
    End Sub

    ' Sub untuk mencetak baris dengan label rata kiri dan isi rata kanan
    Private Sub PrintRow(e As PrintPageEventArgs, label As String, value As String, ByRef y As Integer, leftX As Integer, rightX As Integer)
        Dim fontLabel As New Font("Arial", 10, FontStyle.Bold)
        Dim fontValue As New Font("Arial", 10, FontStyle.Regular)

        e.Graphics.DrawString(label, fontLabel, Brushes.Black, leftX, y)
        Dim valueSize As SizeF = e.Graphics.MeasureString(value, fontValue)
        e.Graphics.DrawString(value, fontValue, Brushes.Black, rightX - valueSize.Width, y)

        y += 25
    End Sub
End Class