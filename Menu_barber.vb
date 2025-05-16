Imports MySql.Data.MySqlClient

Public Class Menu_barber
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Apakah anda ingin logout", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Menu_barber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        LoadData()
    End Sub

    Private Sub LoadData(Optional keyword As String = "")
        Panel1.Controls.Clear()
        Dim yPanel As Integer = 5

        Dim query As String = "SELECT r.ID_reservasi, r.waktu_mulai, pel.nama_pelanggan " &
                              "FROM reservasi r " &
                              "JOIN paket p ON r.ID_paket = p.ID_paket " &
                              "JOIN pelanggan pel ON r.ID_pelanggan = pel.ID_pelanggan " &
                              "WHERE r.ID_barber = @id"

        ' Jika ada keyword pencarian, tambahkan ke query
        If Not String.IsNullOrEmpty(keyword) Then
            query &= " AND pel.nama_pelanggan LIKE @keyword"
        End If

        query &= " ORDER BY r.waktu_mulai DESC"

        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", IDPelangganLoggedIn)

        If Not String.IsNullOrEmpty(keyword) Then
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        End If

        rd = cmd.ExecuteReader()

        If rd.HasRows Then
            Panel1.Visible = True

            While rd.Read()
                Dim waktuMulai As DateTime = DateTime.Parse(rd("waktu_mulai").ToString())

                Dim pnl As New Panel()
                pnl.Width = 407
                pnl.Height = 80
                pnl.BackColor = Color.FromArgb(53, 64, 36)
                pnl.Location = New Point(1, yPanel)
                pnl.Tag = rd("ID_reservasi").ToString()

                Dim lblPaket As New Label()
                lblPaket.Text = rd("nama_pelanggan").ToString()
                lblPaket.ForeColor = Color.White
                lblPaket.Font = New Font("Calibri", 16, FontStyle.Bold)
                lblPaket.Location = New Point(9, 6)
                lblPaket.AutoSize = True
                pnl.Controls.Add(lblPaket)

                Dim lblTanggal As New Label()
                lblTanggal.Text = waktuMulai.ToString("dd MMMM yyyy")
                lblTanggal.ForeColor = Color.White
                lblTanggal.Font = New Font("Calibri", 10, FontStyle.Regular)
                lblTanggal.Location = New Point(10, 35)
                lblTanggal.AutoSize = True
                pnl.Controls.Add(lblTanggal)

                Dim lblCabang As New Label()
                lblCabang.Text = waktuMulai.ToString("HH:mm")
                lblCabang.ForeColor = Color.White
                lblCabang.Font = New Font("Calibri", 10, FontStyle.Regular)
                lblCabang.Location = New Point(10, 52)
                lblCabang.AutoSize = True
                pnl.Controls.Add(lblCabang)

                Dim btnDel As New Button()
                btnDel.Text = "✓"
                btnDel.Size = New Size(50, 50)
                btnDel.ForeColor = Color.White
                btnDel.Tag = rd("ID_reservasi")
                btnDel.Location = New Point(335, 14)
                AddHandler btnDel.Click, AddressOf konfirmasiPemesanan
                pnl.Controls.Add(btnDel)

                AddHandler pnl.Click, AddressOf PanelKlik

                Panel1.Controls.Add(pnl)
                yPanel += 87
            End While

            rd.Close()
        Else
            Panel1.Visible = False
        End If

        conn.Close()
    End Sub


    Private Sub PanelKlik(sender As Object, e As EventArgs)
        Dim pnl As Panel = CType(sender, Panel)
        Dim ID_reservasi As String = pnl.Tag.ToString()

        Dim fDetailPemesanan As New Detail_pemesanan_barber()
        fDetailPemesanan.ID_reservasi = ID_reservasi
        fDetailPemesanan.Show()
        Me.Close()
    End Sub

    Private Sub konfirmasiPemesanan(sender As Object, e As EventArgs)
        Dim id As String = CType(sender, Button).Tag
        If MessageBox.Show("apakah pesanan ini telah diselesaikan?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Koneksi()
            cmd = New MySqlCommand("DELETE FROM reservasi WHERE ID_reservasi=" & id, conn)
            cmd.ExecuteNonQuery()
            LoadData()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Koneksi()
        LoadData(TextBox1.Text)
    End Sub
End Class