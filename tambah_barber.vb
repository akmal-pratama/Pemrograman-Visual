Imports MySql.Data.MySqlClient

Public Class tambah_barber
    Public id_cabang As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Menu_admin.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Ambil input dari TextBox
        Dim namaBarber As String = TextBox3.Text.Trim()
        Dim noTelp As String = txtNoTelp.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        ' Validasi input
        If namaBarber = "" OrElse noTelp = "" OrElse password = "" Then
            MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Panggil koneksi dari modul
            Koneksi()

            Dim query As String = "INSERT INTO barber (nama_barber, nomor_telepon, password, id_cabang) VALUES (@nama_barber, @nomor_telepon, @password, @id_cabang)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama_barber", namaBarber)
            cmd.Parameters.AddWithValue("@nomor_telepon", noTelp)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@id_cabang", id_cabang)

            Dim hasil As Integer = cmd.ExecuteNonQuery()

            If hasil > 0 Then
                MessageBox.Show("Data barber berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox3.Clear()
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