Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class profil

    Public ID_pelanggan As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Menu_user.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin memperbarui profil?", "Konfirmasi Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Try
                Koneksi()
                cmd = New MySqlCommand("UPDATE pelanggan SET nama_pelanggan = @nama, nomor_telepon = @telepon WHERE ID_pelanggan = @id", conn)
                cmd.Parameters.AddWithValue("@nama", TextBox3.Text)
                cmd.Parameters.AddWithValue("@telepon", txtNoTelp.Text)
                cmd.Parameters.AddWithValue("@id", IDPelangganLoggedIn)

                Dim result As Integer = cmd.ExecuteNonQuery()
                If result > 0 Then
                    MessageBox.Show("Profil berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Update gagal. Data tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Me.Hide()
            Menu_user.Show()
        Else
            MessageBox.Show("Perubahan dibatalkan.", "Batal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Apakah anda ingin logout", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub profil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        cmd = New MySqlCommand("SELECT * FROM pelanggan WHERE ID_pelanggan = @ID", conn)
        cmd.Parameters.AddWithValue("@ID", IDPelangganLoggedIn)

        rd = cmd.ExecuteReader()
        If rd.Read() Then
            TextBox3.Text = rd("nama_pelanggan").ToString()
            txtNoTelp.Text = rd("nomor_telepon").ToString()
        Else
            Me.Close()
        End If
        rd.Close()
    End Sub

    Private Sub txtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No Tellpon hanya boleh berisi angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class