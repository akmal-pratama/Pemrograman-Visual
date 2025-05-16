<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_barber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_barber))
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Location = New Point(14, 207)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(407, 840)
        Panel1.TabIndex = 22
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(53), CByte(64), CByte(36))
        TextBox1.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        TextBox1.Location = New Point(14, 127)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(406, 45)
        TextBox1.TabIndex = 21
        TextBox1.Text = "Cari Pelanggan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palace Script MT", 48F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label1.Location = New Point(72, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 74)
        Label1.TabIndex = 20
        Label1.Text = "BarberRand"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Location = New Point(382, 28)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(40, 47)
        Button3.TabIndex = 43
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Menu_barber
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        ClientSize = New Size(434, 1051)
        Controls.Add(Button3)
        Controls.Add(Panel1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Menu_barber"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu_barber"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
End Class
