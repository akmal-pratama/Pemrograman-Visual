Imports MySql.Data.MySqlClient

Public Class profil

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Menu_user.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Konfirmasi update
        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin memperbarui profil?", "Konfirmasi Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Validasi admin
        Dim inputNama As String = TextBox3.Text.ToLower()
        If inputNama = "admin" Then
            MessageBox.Show("Ini admin yang punya, tidak boleh digunakan!", "Gagal Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Koneksi()

            ' Cek nama di tabel pelanggan (selain ID sendiri)
            Dim checkPelangganQuery As String = "SELECT COUNT(*) FROM pelanggan WHERE nama_pelanggan = @nama AND ID_pelanggan <> @id"
            cmd = New MySqlCommand(checkPelangganQuery, conn)
            cmd.Parameters.AddWithValue("@nama", TextBox3.Text)
            cmd.Parameters.AddWithValue("@id", IDPelangganLoggedIn)
            Dim countPelanggan As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If countPelanggan > 0 Then
                MessageBox.Show("Nama sudah terdaftar, gunakan nama lain.", "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                conn.Close()
                Exit Sub
            End If

            ' Cek nama di tabel barber
            Dim checkBarberQuery As String = "SELECT COUNT(*) FROM barber WHERE nama_barber = @nama"
            cmd = New MySqlCommand(checkBarberQuery, conn)
            cmd.Parameters.AddWithValue("@nama", TextBox3.Text)
            Dim countBarber As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If countBarber > 0 Then
                MessageBox.Show("Nama sudah digunakan oleh barber, gunakan nama lain.", "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                conn.Close()
                Exit Sub
            End If

            If konfirmasi = DialogResult.Yes Then
                ' Update data
                Dim updateQuery As String = "UPDATE pelanggan SET nama_pelanggan = @nama, nomor_telepon = @telepon WHERE ID_pelanggan = @id"
                cmd = New MySqlCommand(updateQuery, conn)
                cmd.Parameters.AddWithValue("@nama", TextBox3.Text)
                cmd.Parameters.AddWithValue("@telepon", txtNoTelp.Text)
                cmd.Parameters.AddWithValue("@id", IDPelangganLoggedIn)

                Dim result As Integer = cmd.ExecuteNonQuery()
                If result > 0 Then
                    MessageBox.Show("Profil berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Update gagal. Data tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                Me.Close()
                Menu_user.Show()
            Else
                MessageBox.Show("Perubahan dibatalkan.", "Batal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Apakah Anda ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub profil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Koneksi()
            cmd = New MySqlCommand("SELECT * FROM pelanggan WHERE ID_pelanggan = @ID", conn)
            cmd.Parameters.AddWithValue("@ID", IDPelangganLoggedIn)
            rd = cmd.ExecuteReader()

            If rd.Read() Then
                TextBox3.Text = rd("nama_pelanggan").ToString()
                txtNoTelp.Text = rd("nomor_telepon").ToString()
            Else
                MessageBox.Show("Data pelanggan tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

            rd.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat memuat data: " & ex.Message)
        End Try
    End Sub

    Private Sub txtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Nomor telepon hanya boleh berisi angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
