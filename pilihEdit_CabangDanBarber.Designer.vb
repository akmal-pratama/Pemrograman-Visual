<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pilihEdit_CabangDanBarber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pilihEdit_CabangDanBarber))
        lblCabang = New Label()
        Button2 = New Button()
        Label1 = New Label()
        Button1 = New Button()
        Button3 = New Button()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' lblCabang
        ' 
        lblCabang.AutoSize = True
        lblCabang.Font = New Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCabang.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        lblCabang.Location = New Point(91, 117)
        lblCabang.Name = "lblCabang"
        lblCabang.Size = New Size(201, 41)
        lblCabang.TabIndex = 51
        lblCabang.Text = "nama cabang"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(22, 24)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 47)
        Button2.TabIndex = 50
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palace Script MT", 48F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label1.Location = New Point(80, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 74)
        Label1.TabIndex = 49
        Label1.Text = "BarberRand"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(381, 117)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(40, 47)
        Button1.TabIndex = 52
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(53), CByte(64), CByte(36))
        Button3.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button3.Location = New Point(14, 212)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(407, 85)
        Button3.TabIndex = 54
        Button3.Text = "TAMBAH BARBER + "
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(14, 305)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(407, 747)
        Panel1.TabIndex = 53
        ' 
        ' pilihEdit_CabangDanBarber
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        ClientSize = New Size(434, 1051)
        Controls.Add(Button3)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(lblCabang)
        Controls.Add(Button2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "pilihEdit_CabangDanBarber"
        StartPosition = FormStartPosition.CenterScreen
        Text = "pilihEdit_CabangDanBarber"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCabang As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
End Class
