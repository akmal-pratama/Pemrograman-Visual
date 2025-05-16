Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Koneksi()
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Silakan isi nama dan password!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Cek Admin
        Dim queryAdmin As String = "SELECT * FROM admin WHERE nama=@nama AND password=@password"
        cmd = New MySqlCommand(queryAdmin, conn)
        cmd.Parameters.AddWithValue("@nama", username)
        cmd.Parameters.AddWithValue("@password", password)
        rd = cmd.ExecuteReader()

        If rd.HasRows Then
            If rd.Read() Then
                IDPelangganLoggedIn = rd("ID_admin").ToString()
            End If
            rd.Close()
            MessageBox.Show("Login sebagai Admin berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Clear()
            TextBox2.Clear()
            Menu_admin.Show()
            Me.Close()
            Exit Sub
        End If
        rd.Close()

        ' Cek Barber
        Dim queryBarber As String = "SELECT * FROM barber WHERE nama_barber=@nama_barber AND password=@password AND status='aktif'"
        cmd = New MySqlCommand(queryBarber, conn)
        cmd.Parameters.AddWithValue("@nama_barber", username)
        cmd.Parameters.AddWithValue("@password", password)
        rd = cmd.ExecuteReader()

        If rd.HasRows Then
            If rd.Read() Then
                IDPelangganLoggedIn = rd("ID_barber").ToString()
            End If
            rd.Close()
            MessageBox.Show("Login sebagai Barber berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Clear()
            TextBox2.Clear()
            Menu_barber.Show()
            Me.Close()
            Exit Sub
        End If
        rd.Close()

        ' Cek Pelanggan
        Dim queryPelanggan As String = "SELECT * FROM pelanggan WHERE nama_pelanggan=@nama_pelanggan AND password=@password"
        cmd = New MySqlCommand(queryPelanggan, conn)
        cmd.Parameters.AddWithValue("@nama_pelanggan", username)
        cmd.Parameters.AddWithValue("@password", password)
        rd = cmd.ExecuteReader()

        If rd.HasRows Then
            If rd.Read() Then
                IDPelangganLoggedIn = rd("ID_pelanggan").ToString()
            End If
            rd.Close()
            MessageBox.Show("Login sebagai Pelanggan berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Clear()
            TextBox2.Clear()
            Menu_user.Show()
            Me.Close()
            Exit Sub
        End If
        rd.Close()

        MessageBox.Show("Login gagal! Nama atau password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Registrasi (bisa arahkan ke form registrasi pelanggan)
        Registrasi.Show()
        Me.Close()
    End Sub
End Class