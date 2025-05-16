Imports MySql.Data.MySqlClient

Public Class edit_cabang

    Public id_cabang As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validasi input
        If txtNamaCabang.Text = "" Then
            MessageBox.Show("Nama cabang tidak boleh kosong.")
            Return
        End If

        Try
            Koneksi()
            Dim query As String = "UPDATE cabang SET nama_cabang = @nama WHERE ID_cabang = @id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", txtNamaCabang.Text)
            cmd.Parameters.AddWithValue("@id", id_cabang)

            Dim hasil As Integer = cmd.ExecuteNonQuery()
            If hasil > 0 Then
                MessageBox.Show("Data berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Menu_admin.Show()
                Me.Close()
            Else
                MessageBox.Show("Data gagal diupdate.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu_admin.Show()
        Me.Hide()
    End Sub

    Private Sub edit_cabang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Dim cmd As New MySqlCommand("SELECT * FROM cabang WHERE ID_CABANG = @id", conn)
        cmd.Parameters.AddWithValue("@id", id_cabang)

        Dim rd As MySqlDataReader = cmd.ExecuteReader()
        If rd.Read() Then
            txtNamaCabang.Text = rd("nama_cabang").ToString()
            txtAlamat.Text = rd("alamat").ToString()
        Else
            MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End If
        rd.Close()
    End Sub
End Class