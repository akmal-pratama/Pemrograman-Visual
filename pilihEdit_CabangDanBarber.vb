Imports MySql.Data.MySqlClient

Public Class pilihEdit_CabangDanBarber

    Public ID_cabang As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fTambah As New tambah_barber()
        fTambah.id_cabang = ID_cabang
        fTambah.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu_admin.Show()
        Me.Close()
    End Sub

    Private Sub pilihEdit_CabangDanBarber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()

        cmd = New MySqlCommand("SELECT * FROM cabang WHERE ID_CABANG = @ID_cabang", conn)
        cmd.Parameters.AddWithValue("@ID_cabang", ID_cabang)

        rd = cmd.ExecuteReader
        If rd.Read() Then
            lblCabang.Text = rd("nama_cabang").ToString()
        Else
            MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End If
        rd.Close()
        LoadData()
    End Sub


    Private Sub LoadData()
        Panel1.Controls.Clear()
        Dim yPanel As Integer = 5

        Dim query As String = "SELECT * FROM barber WHERE id_cabang = @ID_cabang"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@ID_cabang", ID_cabang)
        rd = cmd.ExecuteReader()
        If rd.HasRows Then

            Panel1.Visible = True


            While rd.Read()

                ' Panel
                Dim pnl As New Panel()
                pnl.Width = 407
                pnl.Height = 50
                pnl.BackColor = Color.FromArgb(53, 64, 36)
                pnl.Location = New Point(1, yPanel)
                pnl.Tag = rd("ID_barber").ToString() ' Simpan id di panel

                ' Label Nama Barber
                Dim lbl As New Label()
                lbl.Text = rd("nama_barber").ToString()
                lbl.ForeColor = Color.White
                lbl.Font = New Font("Calibri", 15, FontStyle.Bold)
                lbl.Location = New Point(10, 12)
                lbl.AutoSize = True
                pnl.Controls.Add(lbl)

                ' Tombol Edit
                Dim btnEdit As New Button()
                btnEdit.Text = "✎"
                btnEdit.Size = New Size(35, 35)
                btnEdit.ForeColor = Color.FromArgb(230, 211, 122)
                btnEdit.Location = New Point(320, 7)
                btnEdit.Tag = rd("ID_barber").ToString()
                AddHandler btnEdit.Click, AddressOf btnEdit_Click
                pnl.Controls.Add(btnEdit)

                ' Tombol Hapus
                Dim btnDel As New Button()
                btnDel.Text = "🗑"
                btnDel.Size = New Size(35, 35)
                btnDel.ForeColor = Color.FromArgb(234, 92, 120)
                btnDel.Tag = rd("ID_barber")
                btnDel.Location = New Point(360, 7)
                AddHandler btnDel.Click, AddressOf DeleteAkun
                pnl.Controls.Add(btnDel)

                'AddHandler pnl.Click, AddressOf PanelKlik

                Panel1.Controls.Add(pnl)
                yPanel += 57

            End While

            rd.Close()

        Else
            Panel1.Visible = False
        End If

        conn.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim idBarber As String = btn.Tag.ToString()

        Dim fEdit As New edit_barber()
        fEdit.id_barber = idBarber
        fEdit.Show()

        Me.Close()
    End Sub

    Private Sub DeleteAkun(sender As Object, e As EventArgs)
        Dim id As String = CType(sender, Button).Tag
        If MessageBox.Show("Yakin ingin menghapus akun ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Koneksi()
            cmd = New MySqlCommand("DELETE FROM barber WHERE ID_barber= " & id, conn)
            cmd.ExecuteNonQuery()
            LoadData()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fEdit As New edit_cabang()
        fEdit.id_cabang = ID_cabang
        fEdit.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class