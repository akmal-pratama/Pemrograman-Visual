Imports MySql.Data.MySqlClient

Public Class edit_barber

    Public id_barber As String

    Private Sub Formedit_barber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        cmd = New MySqlCommand("SELECT * FROM barber WHERE ID_barber = @id_barber", conn)
        cmd.Parameters.AddWithValue("@id_barber", id_barber)

        rd = cmd.ExecuteReader
        If rd.Read() Then
            txtNamaBarber.Text = rd("nama_barber").ToString()
            txtNoTelp.Text = rd("nomor_telepon").ToString()
            txtPassword.Text = rd("password").ToString()
        Else
            Me.Close()
        End If
        rd.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu_admin.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNamaBarber.Text = "" Or txtNoTelp.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Semua kolom harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Koneksi()
            Dim query As String = "UPDATE barber SET nama_barber = @nama, nomor_telepon = @telp, password = @pass WHERE ID_barber = @id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", txtNamaBarber.Text)
            cmd.Parameters.AddWithValue("@telp", txtNoTelp.Text)
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text)
            cmd.Parameters.AddWithValue("@id", id_barber)

            Dim result As Integer = cmd.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                pilihEdit_CabangDanBarber.Show()
                Me.Close()
            Else
                MessageBox.Show("Gagal memperbarui data.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
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