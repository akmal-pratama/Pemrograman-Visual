Imports MySql.Data.MySqlClient

Public Class Menu_admin
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Apakah anda ingin logout", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tambah_cabang.Show()
        Me.Close()
    End Sub

    Private Sub FormMenu_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        LoadData()
    End Sub

    Private Sub LoadData(Optional keyword As String = "")
        Panel1.Controls.Clear()
        Dim yPanel As Integer = 5

        Dim query As String = "SELECT * FROM cabang WHERE 1=1"

        If Not String.IsNullOrEmpty(keyword) Then
            query &= " AND (nama_cabang LIKE @keyword OR alamat LIKE @keyword)"
        End If

        query &= " ORDER BY ID_cabang"

        cmd = New MySqlCommand(query, conn)

        If Not String.IsNullOrEmpty(keyword) Then
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        End If

        rd = cmd.ExecuteReader()
        If rd.HasRows Then
            Panel1.Visible = True

            While rd.Read()
                Dim pnl As New Panel()
                pnl.Width = 407
                pnl.Height = 70
                pnl.BackColor = Color.FromArgb(53, 64, 36)
                pnl.Location = New Point(1, yPanel)
                pnl.Tag = rd("ID_cabang").ToString()

                Dim lblCabang As New Label()
                lblCabang.Text = rd("nama_cabang").ToString()
                lblCabang.ForeColor = Color.FromArgb(229, 215, 196)
                lblCabang.Font = New Font("Calibri", 15, FontStyle.Bold)
                lblCabang.Location = New Point(10, 7)
                lblCabang.AutoSize = True
                pnl.Controls.Add(lblCabang)

                Dim lblAlamat As New Label()
                lblAlamat.Text = rd("alamat").ToString()
                lblAlamat.ForeColor = Color.White
                lblAlamat.Font = New Font("Calibri", 11, FontStyle.Bold)
                lblAlamat.Location = New Point(10, 37)
                lblAlamat.AutoSize = True
                pnl.Controls.Add(lblAlamat)

                AddHandler pnl.Click, AddressOf PanelKlik

                Panel1.Controls.Add(pnl)
                yPanel += 76
            End While

            rd.Close()
        Else
            Panel1.Visible = False
        End If

        conn.Close()
    End Sub


    Private Sub PanelKlik(sender As Object, e As EventArgs)
        Dim pnl As Panel = CType(sender, Panel)
        Dim ID_cabang As String = pnl.Tag.ToString()

        Dim fManajemenBarber As New pilihEdit_CabangDanBarber()
        fManajemenBarber.ID_cabang = ID_cabang
        fManajemenBarber.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Koneksi()
        LoadData(TextBox1.Text)
    End Sub
End Class