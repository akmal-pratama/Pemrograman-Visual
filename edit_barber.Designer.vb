<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_barber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_barber))
        txtPassword = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        txtNamaBarber = New TextBox()
        Label4 = New Label()
        txtNoTelp = New TextBox()
        Label5 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Calibri", 11.25F)
        txtPassword.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        txtPassword.Location = New Point(31, 392)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(372, 30)
        txtPassword.TabIndex = 68
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 11.25F)
        Label3.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label3.Location = New Point(31, 368)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 23)
        Label3.TabIndex = 67
        Label3.Text = "Password"
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
        Button1.TabIndex = 66
        Button1.Text = "Update Barber"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtNamaBarber
        ' 
        txtNamaBarber.Font = New Font("Calibri", 11.25F)
        txtNamaBarber.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        txtNamaBarber.Location = New Point(31, 212)
        txtNamaBarber.Margin = New Padding(3, 4, 3, 4)
        txtNamaBarber.Name = "txtNamaBarber"
        txtNamaBarber.Size = New Size(372, 30)
        txtNamaBarber.TabIndex = 65
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Calibri", 11.25F)
        Label4.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label4.Location = New Point(31, 188)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 23)
        Label4.TabIndex = 64
        Label4.Text = "Nama Barber"
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Font = New Font("Calibri", 11.25F)
        txtNoTelp.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        txtNoTelp.Location = New Point(31, 299)
        txtNoTelp.Margin = New Padding(3, 4, 3, 4)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(372, 30)
        txtNoTelp.TabIndex = 63
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 11.25F)
        Label5.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label5.Location = New Point(31, 275)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 23)
        Label5.TabIndex = 62
        Label5.Text = "No. Telpon"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label2.Location = New Point(110, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(201, 41)
        Label2.TabIndex = 61
        Label2.Text = "EDIT BARBER"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(14, 24)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 47)
        Button2.TabIndex = 60
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palace Script MT", 48F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label1.Location = New Point(72, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 74)
        Label1.TabIndex = 59
        Label1.Text = "BarberRand"
        ' 
        ' edit_barber
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        ClientSize = New Size(434, 1051)
        Controls.Add(txtPassword)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(txtNamaBarber)
        Controls.Add(Label4)
        Controls.Add(txtNoTelp)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "edit_barber"
        StartPosition = FormStartPosition.CenterScreen
        Text = "edit_barber"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtNamaBarber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
End Class
