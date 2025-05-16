Imports MySql.Data.MySqlClient

Public Class Pilih_barber

    Public ID_cabang As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu_user.Show()
        Me.Close()
    End Sub

    Private Sub FormPilih_barber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        cmd = New MySqlCommand("SELECT * FROM cabang WHERE ID_CABANG = @ID_cabang", conn)
        cmd.Parameters.AddWithValue("@ID_cabang", ID_cabang)

        rd = cmd.ExecuteReader
        If rd.Read() Then
            Label2.Text = rd("nama_cabang").ToString()
            Label3.Text = rd("alamat").ToString()
        Else
            MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'Me.Close()
        End If
        rd.Close()

        Dim cabangId As Integer = ID_cabang
        tanggalDipilih = dtpTanggal.Value.ToString("yyyy-MM-dd")
        LoadBarberDanJamFromDB(ID_cabang, TanggalDipilih)

    End Sub

    Private Function AmbilDaftarBarber(cabangId As Integer) As List(Of Tuple(Of Integer, String))
        Dim daftar As New List(Of Tuple(Of Integer, String))

        Using connection As New MySqlConnection("server=localhost;user id=root;password=;database=barbershop_db;")
            Try
                connection.Open()
                Dim query As String = "SELECT id_barber, nama_barber FROM barber WHERE id_cabang = @id"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@id", cabangId)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim id As Integer = Convert.ToInt32(reader("id_barber"))
                        Dim nama As String = reader("nama_barber").ToString()
                        daftar.Add(New Tuple(Of Integer, String)(id, nama))
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Gagal mengambil data barber: " & ex.Message)
            End Try
        End Using

        Return daftar
    End Function

    Private Function AmbilJamBarber(namaBarber As String, tanggal As String) As List(Of String)
        ' Jam statis, tidak dari database
        Return New List(Of String) From {
        "09:00", "10:30", "12:00", "14:00", "15:30", "17:00", "19:00", "20:30"
    }
    End Function


    Private Sub LoadBarberDanJamFromDB(cabangId As Integer, tanggal As String)
        flpBarber.Controls.Clear()

        Dim daftarBarber = AmbilDaftarBarber(cabangId)

        For Each tupleBarber In daftarBarber
            Dim idBarber As Integer = tupleBarber.Item1
            Dim namaBarber As String = tupleBarber.Item2

            Dim pnlBarber As New Panel With {
            .Width = flpBarber.Width - 25,
            .Height = 120,
            .BackColor = Color.FromArgb(53, 64, 36),
            .Margin = New Padding(10)
        }

            Dim lblNama As New Label With {
            .Text = namaBarber,
            .ForeColor = Color.White,
            .Font = New Font("Calibri", 14, FontStyle.Bold),
            .Location = New Point(10, 10),
            .AutoSize = True
        }
            pnlBarber.Controls.Add(lblNama)

            Dim flpJam As New FlowLayoutPanel With {
            .Location = New Point(10, 40),
            .Width = pnlBarber.Width - 10,
            .Height = 72,
            .BackColor = Color.Transparent
        }

            Dim daftarJam = AmbilJamBarber(namaBarber, tanggal)

            For Each jam As String In daftarJam
                Dim btnJam As New Button With {
                .Text = jam,
                .Width = 60,
                .Height = 30,
                .BackColor = Color.FromArgb(174, 120, 59),
                .ForeColor = Color.FromArgb(229, 215, 196),
                .FlatStyle = FlatStyle.Flat,
                .Tag = $"{idBarber}|{namaBarber}|{jam}"
            }
                AddHandler btnJam.Click, AddressOf JamDiklik
                flpJam.Controls.Add(btnJam)
            Next

            pnlBarber.Controls.Add(flpJam)
            flpBarber.Controls.Add(pnlBarber)
        Next
    End Sub

    Private Sub JamDiklik(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim info As String = btn.Tag.ToString()
        Dim bagian() As String = info.Split("|"c)

        Dim idBarber As String = bagian(0)
        Dim namaBarber As String = bagian(1)
        Dim jam As String = bagian(2)

        ' Kirim ke form pemesanan
        Dim fpemesanan As New Form_pemesanan()
        fpemesanan.ID_cabang = ID_cabang
        fpemesanan.ID_barber = idBarber
        fpemesanan.namaBarber = namaBarber
        fpemesanan.jamDipilih = jam
        fpemesanan.TanggalDipilih = tanggalDipilih
        fpemesanan.cabangDipilih = Label2.Text

        fpemesanan.Show()
        Me.Close()
    End Sub


    Private Sub dtpTanggal_ValueChanged(sender As Object, e As EventArgs) Handles dtpTanggal.ValueChanged
        TanggalDipilih = dtpTanggal.Value.ToString("yyyy-MM-dd")
        LoadBarberDanJamFromDB(ID_cabang, TanggalDipilih)
    End Sub
End Class