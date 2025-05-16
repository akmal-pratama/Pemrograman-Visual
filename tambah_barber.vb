Imports MySql.Data.MySqlClient

Public Class tambah_barber
    Public id_cabang As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Menu_admin.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Ambil input dari TextBox
        Dim namaBarber As String = txtNamaBarber.Text.Trim()
        Dim noTelp As String = txtNoTelp.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        ' Validasi input
        If namaBarber = "" OrElse noTelp = "" OrElse password = "" Then
            MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtNamaBarber.Text.ToLower() = "admin" Then
            MessageBox.Show("Ini admin yang punya, tak boleh ygy", "Gagal Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Koneksi()

            ' Cek apakah nama sudah terdaftar di tabel pelanggan
            Dim checkPelangganQuery As String = "SELECT COUNT(*) FROM pelanggan WHERE nama_pelanggan = @nama"
            cmd = New MySqlCommand(checkPelangganQuery, conn)
            cmd.Parameters.AddWithValue("@nama", txtNamaBarber.Text)
            Dim countPelanggan As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Jika sudah ada di pelanggan
            If countPelanggan > 0 Then
                MessageBox.Show("Nama sudah terdaftar gunakan nama lain.", "Gagal Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                conn.Close()
                Exit Sub
            End If

            ' Cek apakah nama sudah terdaftar di tabel barber
            Dim checkBarberQuery As String = "SELECT COUNT(*) FROM barber WHERE nama_barber = @nama"
            cmd = New MySqlCommand(checkBarberQuery, conn)
            cmd.Parameters.AddWithValue("@nama", txtNamaBarber.Text)
            Dim countBarber As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Jika sudah ada di barber
            If countBarber > 0 Then
                MessageBox.Show("Nama sudah terdaftar gunakan nama lain", "Gagal Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                conn.Close()
                Exit Sub
            End If

            Dim query As String = "INSERT INTO barber (nama_barber, nomor_telepon, password, id_cabang) VALUES (@nama_barber, @nomor_telepon, @password, @id_cabang)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama_barber", namaBarber)
            cmd.Parameters.AddWithValue("@nomor_telepon", noTelp)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@id_cabang", id_cabang)

            Dim hasil As Integer = cmd.ExecuteNonQuery()

            If hasil > 0 Then
                MessageBox.Show("Data barber berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNamaBarber.Clear()
                txtNoTelp.Clear()
                TextBox2.Clear()
                Menu_admin.Show()
                Me.Close()
            Else
                MessageBox.Show("Gagal menambahkan data barber.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No Tellpon hanya boleh berisi angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class