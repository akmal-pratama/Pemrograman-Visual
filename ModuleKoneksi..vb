Imports MySql.Data.MySqlClient

Module ModuleKoneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader

    Public Sub Koneksi()
        Dim connectionString As String = "server=localhost;userid=root;password=;database=barbershop_db"
        conn = New MySqlConnection(connectionString)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi gagal: " & ex.Message)
        End Try
    End Sub
End Module

Module GlobalData
    Public IDPelangganLoggedIn As String
End Module

Module pemesanan
    Public namaBarberDipilih As String
    Public jamDipilih As String
    Public tanggalDipilih As String
    Public cabangDipilih As String
End Module
