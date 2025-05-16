Imports Microsoft.VisualBasic.Logging
Imports MySql.Data.MySqlClient
Public Class Registrasi
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsername.Text = "" Or TextBox2.Text = "" Or txtNoTelp.Text = "" Then
            MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtUsername.Text.ToLower() = "admin" Then
            MessageBox.Show("Ini admin yang punya, tak boleh ygy", "Gagal Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Koneksi()

            ' Cek apakah nama sudah terdaftar di tabel pelanggan
            Dim checkPelangganQuery As String = "SELECT COUNT(*) FROM pelanggan WHERE nama_pelanggan = @nama"
            cmd = New MySqlCommand(checkPelangganQuery, conn)
            cmd.Parameters.AddWithValue("@nama", txtUsername.Text)
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
            cmd.Parameters.AddWithValue("@nama", txtUsername.Text)
            Dim countBarber As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Jika sudah ada di barber
            If countBarber > 0 Then
                MessageBox.Show("Nama sudah terdaftar gunakan nama lain", "Gagal Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                conn.Close()
                Exit Sub
            End If

            ' Jika aman, lakukan insert
            Dim insertQuery As String = "INSERT INTO pelanggan (nama_pelanggan, password, nomor_telepon) VALUES (@nama, @password, @telepon)"
            cmd = New MySqlCommand(insertQuery, conn)
            cmd.Parameters.AddWithValue("@nama", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", TextBox2.Text)
            cmd.Parameters.AddWithValue("@telepon", txtNoTelp.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Registrasi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNoTelp.Clear()
            txtUsername.Clear()
            TextBox2.Clear()

            conn.Close()
            Me.Close()
            Login.Show()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub txtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No Telpon hanya boleh berisi angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class