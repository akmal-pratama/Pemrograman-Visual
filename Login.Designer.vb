<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palace Script MT", 48F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label1.Location = New Point(72, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 74)
        Label1.TabIndex = 1
        Label1.Text = "BarberRand"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 11.25F)
        Label2.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label2.Location = New Point(27, 216)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 23)
        Label2.TabIndex = 2
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 11.25F)
        Label3.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label3.Location = New Point(27, 301)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 23)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Calibri", 11.25F)
        TextBox1.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        TextBox1.Location = New Point(27, 240)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(372, 30)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Calibri", 11.25F)
        TextBox2.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        TextBox2.Location = New Point(27, 325)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(372, 30)
        TextBox2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(53), CByte(64), CByte(36))
        Button1.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button1.Location = New Point(27, 388)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(373, 51)
        Button1.TabIndex = 6
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(53), CByte(64), CByte(36))
        Button2.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button2.Location = New Point(27, 491)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(373, 51)
        Button2.TabIndex = 7
        Button2.Text = "Registrasi"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 11.25F)
        Label4.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label4.Location = New Point(138, 453)
        Label4.Name = "Label4"
        Label4.Size = New Size(163, 23)
        Label4.TabIndex = 8
        Label4.Text = "Belum punya Akun?"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        ClientSize = New Size(434, 1051)
        Controls.Add(Label4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
End Class
