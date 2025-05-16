<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_pemesanan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_pemesanan))
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtCabang = New TextBox()
        Label4 = New Label()
        Button1 = New Button()
        txtBarber = New TextBox()
        txtAlamat = New TextBox()
        Label3 = New Label()
        Label5 = New Label()
        txtNoHP = New TextBox()
        Label6 = New Label()
        txtWaktu = New TextBox()
        txtTanggal = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        txtHarga = New TextBox()
        Label11 = New Label()
        cbPaket = New ComboBox()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(26, 29)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 47)
        Button2.TabIndex = 25
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palace Script MT", 48F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label1.Location = New Point(72, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 74)
        Label1.TabIndex = 24
        Label1.Text = "BarberRand"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label2.Location = New Point(118, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(199, 41)
        Label2.TabIndex = 26
        Label2.Text = "PEMESANAN"
        ' 
        ' txtCabang
        ' 
        txtCabang.BackColor = Color.White
        txtCabang.Font = New Font("Calibri", 11.25F)
        txtCabang.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        txtCabang.Location = New Point(31, 220)
        txtCabang.Margin = New Padding(3, 4, 3, 4)
        txtCabang.Name = "txtCabang"
        txtCabang.ReadOnly = True
        txtCabang.Size = New Size(372, 30)
        txtCabang.TabIndex = 33
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 11.25F)
        Label4.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label4.Location = New Point(31, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 23)
        Label4.TabIndex = 32
        Label4.Text = "Cabang"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(53), CByte(64), CByte(36))
        Button1.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button1.Location = New Point(31, 984)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(373, 51)
        Button1.TabIndex = 31
        Button1.Text = "Konfirmasi"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtBarber
        ' 
        txtBarber.BackColor = Color.White
        txtBarber.Font = New Font("Calibri", 11.25F)
        txtBarber.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        txtBarber.Location = New Point(31, 392)
        txtBarber.Margin = New Padding(3, 4, 3, 4)
        txtBarber.Name = "txtBarber"
        txtBarber.ReadOnly = True
        txtBarber.Size = New Size(372, 30)
        txtBarber.TabIndex = 30
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.White
        txtAlamat.Font = New Font("Calibri", 11.25F)
        txtAlamat.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        txtAlamat.Location = New Point(31, 307)
        txtAlamat.Margin = New Padding(3, 4, 3, 4)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.ReadOnly = True
        txtAlamat.Size = New Size(372, 30)
        txtAlamat.TabIndex = 29
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 11.25F)
        Label3.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label3.Location = New Point(31, 368)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 23)
        Label3.TabIndex = 28
        Label3.Text = "Barber"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 11.25F)
        Label5.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label5.Location = New Point(31, 283)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 23)
        Label5.TabIndex = 27
        Label5.Text = "Alamat"
        ' 
        ' txtNoHP
        ' 
        txtNoHP.BackColor = Color.White
        txtNoHP.Font = New Font("Calibri", 11.25F)
        txtNoHP.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        txtNoHP.Location = New Point(31, 477)
        txtNoHP.Margin = New Padding(3, 4, 3, 4)
        txtNoHP.Name = "txtNoHP"
        txtNoHP.ReadOnly = True
        txtNoHP.Size = New Size(372, 30)
        txtNoHP.TabIndex = 39
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 11.25F)
        Label6.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label6.Location = New Point(31, 453)
        Label6.Name = "Label6"
        Label6.Size = New Size(131, 23)
        Label6.TabIndex = 38
        Label6.Text = "No. Handphone"
        ' 
        ' txtWaktu
        ' 
        txtWaktu.BackColor = Color.White
        txtWaktu.Font = New Font("Calibri", 11.25F)
        txtWaktu.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        txtWaktu.Location = New Point(31, 649)
        txtWaktu.Margin = New Padding(3, 4, 3, 4)
        txtWaktu.Name = "txtWaktu"
        txtWaktu.ReadOnly = True
        txtWaktu.Size = New Size(372, 30)
        txtWaktu.TabIndex = 37
        ' 
        ' txtTanggal
        ' 
        txtTanggal.BackColor = Color.White
        txtTanggal.Font = New Font("Calibri", 11.25F)
        txtTanggal.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        txtTanggal.Location = New Point(31, 564)
        txtTanggal.Margin = New Padding(3, 4, 3, 4)
        txtTanggal.Name = "txtTanggal"
        txtTanggal.ReadOnly = True
        txtTanggal.Size = New Size(372, 30)
        txtTanggal.TabIndex = 36
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Calibri", 11.25F)
        Label7.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label7.Location = New Point(31, 625)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 23)
        Label7.TabIndex = 35
        Label7.Text = "Waktu"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Calibri", 11.25F)
        Label8.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label8.Location = New Point(31, 540)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 23)
        Label8.TabIndex = 34
        Label8.Text = "Tanggal"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Calibri", 11.25F)
        Label9.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label9.Location = New Point(31, 711)
        Label9.Name = "Label9"
        Label9.Size = New Size(52, 23)
        Label9.TabIndex = 44
        Label9.Text = "Paket"
        ' 
        ' txtHarga
        ' 
        txtHarga.BackColor = Color.White
        txtHarga.Font = New Font("Calibri", 11.25F)
        txtHarga.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        txtHarga.Location = New Point(31, 821)
        txtHarga.Margin = New Padding(3, 4, 3, 4)
        txtHarga.Name = "txtHarga"
        txtHarga.ReadOnly = True
        txtHarga.Size = New Size(372, 30)
        txtHarga.TabIndex = 42
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Calibri", 11.25F)
        Label11.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label11.Location = New Point(31, 797)
        Label11.Name = "Label11"
        Label11.Size = New Size(56, 23)
        Label11.TabIndex = 40
        Label11.Text = "Harga"
        ' 
        ' cbPaket
        ' 
        cbPaket.FormattingEnabled = True
        cbPaket.Location = New Point(31, 735)
        cbPaket.Margin = New Padding(3, 4, 3, 4)
        cbPaket.Name = "cbPaket"
        cbPaket.Size = New Size(372, 28)
        cbPaket.TabIndex = 45
        ' 
        ' Form_pemesanan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        ClientSize = New Size(434, 1051)
        Controls.Add(cbPaket)
        Controls.Add(Label9)
        Controls.Add(txtHarga)
        Controls.Add(Label11)
        Controls.Add(txtNoHP)
        Controls.Add(Label6)
        Controls.Add(txtWaktu)
        Controls.Add(txtTanggal)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(txtCabang)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(txtBarber)
        Controls.Add(txtAlamat)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form_pemesanan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form_pemesanan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCabang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBarber As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNoHP As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtWaktu As TextBox
    Friend WithEvents txtTanggal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbPaket As ComboBox
End Class
