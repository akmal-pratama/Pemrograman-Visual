<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(profil))
        TextBox3 = New TextBox()
        Label4 = New Label()
        txtNoTelp = New TextBox()
        Label5 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        Label1 = New Label()
        Button1 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Calibri", 11.25F)
        TextBox3.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        TextBox3.Location = New Point(31, 216)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(372, 30)
        TextBox3.TabIndex = 40
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Calibri", 11.25F)
        Label4.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label4.Location = New Point(31, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 23)
        Label4.TabIndex = 39
        Label4.Text = "Nama"
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Font = New Font("Calibri", 11.25F)
        txtNoTelp.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        txtNoTelp.Location = New Point(31, 303)
        txtNoTelp.Margin = New Padding(3, 4, 3, 4)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(372, 30)
        txtNoTelp.TabIndex = 38
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 11.25F)
        Label5.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label5.Location = New Point(31, 279)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 23)
        Label5.TabIndex = 37
        Label5.Text = "No. Telpon"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label2.Location = New Point(118, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(192, 41)
        Label2.TabIndex = 36
        Label2.Text = "PROFIL SAYA"
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
        Button2.TabIndex = 35
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
        Label1.TabIndex = 34
        Label1.Text = "BarberRand"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(53), CByte(64), CByte(36))
        Button1.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button1.Location = New Point(31, 969)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(373, 51)
        Button1.TabIndex = 41
        Button1.Text = "Update Profil"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Location = New Point(381, 28)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(40, 47)
        Button3.TabIndex = 42
        Button3.UseVisualStyleBackColor = False
        ' 
        ' profil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        ClientSize = New Size(434, 1051)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(txtNoTelp)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "profil"
        StartPosition = FormStartPosition.CenterScreen
        Text = "profil"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
