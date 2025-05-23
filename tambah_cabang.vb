﻿Imports MySql.Data.MySqlClient

Public Class tambah_cabang
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu_admin.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim namaCabang As String = TextBox3.Text
        Dim alamat As String = TextBox1.Text

        ' Validasi input
        If namaCabang = "" Or alamat = "" Then
            MessageBox.Show("Mohon isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Koneksi()
            Dim query As String = "INSERT INTO cabang (nama_cabang, alamat) VALUES (@nama_cabang, @alamat)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama_cabang", namaCabang)
            cmd.Parameters.AddWithValue("@alamat", alamat)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data cabang berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset TextBox
            TextBox3.Clear()
            TextBox1.Clear()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub tambah_cabang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class