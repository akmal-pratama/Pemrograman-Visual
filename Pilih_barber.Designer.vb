<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pilih_barber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pilih_barber))
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button2 = New Button()
        flpBarber = New FlowLayoutPanel()
        dtpTanggal = New DateTimePicker()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(53), CByte(64), CByte(36))
        TextBox1.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        TextBox1.Location = New Point(14, 131)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(406, 45)
        TextBox1.TabIndex = 16
        TextBox1.Text = "Cari Barber"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palace Script MT", 48F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label1.Location = New Point(72, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 74)
        Label1.TabIndex = 15
        Label1.Text = "BarberRand"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label2.Location = New Point(107, 193)
        Label2.Name = "Label2"
        Label2.Size = New Size(214, 41)
        Label2.TabIndex = 21
        Label2.Text = "Nama Cabang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label3.Location = New Point(125, 251)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 20)
        Label3.TabIndex = 22
        Label3.Text = "Alamat"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(14, 28)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 47)
        Button2.TabIndex = 23
        Button2.UseVisualStyleBackColor = False
        ' 
        ' flpBarber
        ' 
        flpBarber.Location = New Point(-1, 387)
        flpBarber.Margin = New Padding(3, 4, 3, 4)
        flpBarber.Name = "flpBarber"
        flpBarber.Size = New Size(437, 664)
        flpBarber.TabIndex = 24
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.CalendarFont = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpTanggal.Location = New Point(34, 312)
        dtpTanggal.Margin = New Padding(3, 4, 3, 4)
        dtpTanggal.MinDate = New Date(2025, 5, 13, 0, 0, 0, 0)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(359, 27)
        dtpTanggal.TabIndex = 25
        ' 
        ' Pilih_barber
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        ClientSize = New Size(434, 1051)
        Controls.Add(dtpTanggal)
        Controls.Add(flpBarber)
        Controls.Add(Button2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Pilih_barber"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pilih_barber"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents flpBarber As FlowLayoutPanel
    Friend WithEvents dtpTanggal As DateTimePicker
End Class
