Imports MySql.Data.MySqlClient

Public Class notifikasi
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Menu_user.Show()
    End Sub

    Private Sub notifikasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        LoadData()
    End Sub

    Private Sub LoadData()
        Panel1.Controls.Clear()
        Dim yPanel As Integer = 5

        Dim query As String = "Select r.ID_reservasi, r.waktu_mulai, p.nama_paket, c.nama_cabang " &
                              "FROM reservasi r " &
                              "JOIN paket p On r.ID_paket = p.ID_paket " &
                              "JOIN cabang c On r.ID_cabang = c.ID_CABANG " &
                              "WHERE r.ID_pelanggan = @id " &
                              "ORDER BY r.waktu_mulai DESC"

        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", IDPelangganLoggedIn)
        rd = cmd.ExecuteReader()
        If rd.HasRows Then

            Panel1.Visible = True


            While rd.Read()

                ' Panel
                Dim pnl As New Panel()
                pnl.Width = 407
                pnl.Height = 80
                pnl.BackColor = Color.FromArgb(53, 64, 36)
                pnl.Location = New Point(1, yPanel)
                pnl.Tag = rd("ID_reservasi").ToString() ' Simpan id di panel

                ' Label Nama Paket
                Dim lblPaket As New Label()
                lblPaket.Text = rd("nama_paket").ToString()
                lblPaket.ForeColor = Color.White
                lblPaket.Font = New Font("Calibri", 16, FontStyle.Bold)
                lblPaket.Location = New Point(9, 8)
                lblPaket.AutoSize = True
                pnl.Controls.Add(lblPaket)

                ' Label Tanggal
                Dim lblTanggal As New Label()
                lblTanggal.Text = rd("waktu_mulai").ToString()
                lblTanggal.ForeColor = Color.White
                lblTanggal.Font = New Font("Calibri", 10, FontStyle.Regular)
                lblTanggal.Location = New Point(10, 35)
                lblTanggal.AutoSize = True
                pnl.Controls.Add(lblTanggal)

                ' Label Cabang
                Dim lblCabang As New Label()
                lblCabang.Text = rd("nama_cabang").ToString()
                lblCabang.ForeColor = Color.White
                lblCabang.Font = New Font("Calibri", 10, FontStyle.Regular)
                lblCabang.Location = New Point(10, 52)
                lblCabang.AutoSize = True
                pnl.Controls.Add(lblCabang)

                AddHandler pnl.Click, AddressOf PanelKlik

                Panel1.Controls.Add(pnl)
                yPanel += 100

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

        Dim fDetailPemesanan As New Detail_pemesanan()
        fDetailPemesanan.ID_reservasi = ID_reservasi
        fDetailPemesanan.Show()
        Me.Close()
    End Sub
End Class