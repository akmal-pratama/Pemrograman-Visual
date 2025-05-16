<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class berhasil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(berhasil))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palace Script MT", 48F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label1.Location = New Point(63, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 60)
        Label1.TabIndex = 25
        Label1.Text = "BarberRand"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(77, 136)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(228, 219)
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label4.Location = New Point(99, 377)
        Label4.Name = "Label4"
        Label4.Size = New Size(170, 23)
        Label4.TabIndex = 33
        Label4.Text = "Pemesanan berhasil!"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(53), CByte(64), CByte(36))
        Button1.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button1.Location = New Point(26, 738)
        Button1.Name = "Button1"
        Button1.Size = New Size(326, 38)
        Button1.TabIndex = 34
        Button1.Text = "Lanjut"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' berhasil
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        ClientSize = New Size(380, 788)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "berhasil"
        StartPosition = FormStartPosition.CenterScreen
        Text = "berhasil"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
