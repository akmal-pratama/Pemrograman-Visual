<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrasi))
        Button1 = New Button()
        TextBox2 = New TextBox()
        txtUsername = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtNoTelp = New TextBox()
        Label4 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(53), CByte(64), CByte(36))
        Button1.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button1.Location = New Point(27, 441)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(373, 51)
        Button1.TabIndex = 14
        Button1.Text = "Registrasi"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Calibri", 11.25F)
        TextBox2.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        TextBox2.Location = New Point(27, 371)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(372, 30)
        TextBox2.TabIndex = 13
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Calibri", 11.25F)
        txtUsername.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        txtUsername.Location = New Point(27, 285)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(372, 30)
        txtUsername.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 11.25F)
        Label3.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label3.Location = New Point(27, 347)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 23)
        Label3.TabIndex = 11
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 11.25F)
        Label2.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label2.Location = New Point(27, 261)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 23)
        Label2.TabIndex = 10
        Label2.Text = "Nama"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palace Script MT", 48F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label1.Location = New Point(72, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 74)
        Label1.TabIndex = 9
        Label1.Text = "BarberRand"
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Font = New Font("Calibri", 11.25F)
        txtNoTelp.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        txtNoTelp.Location = New Point(27, 199)
        txtNoTelp.Margin = New Padding(3, 4, 3, 4)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(372, 30)
        txtNoTelp.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 11.25F)
        Label4.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label4.Location = New Point(27, 175)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 23)
        Label4.TabIndex = 15
        Label4.Text = "No. Handphone"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(26, 44)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 47)
        Button2.TabIndex = 39
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Registrasi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        ClientSize = New Size(434, 1051)
        Controls.Add(Button2)
        Controls.Add(txtNoTelp)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(txtUsername)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Registrasi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registrasi"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
End Class
