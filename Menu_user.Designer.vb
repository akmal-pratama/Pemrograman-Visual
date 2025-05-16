<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_user
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_user))
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Panel1 = New Panel()
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
        Label1.TabIndex = 10
        Label1.Text = "BarberRand"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(53), CByte(64), CByte(36))
        TextBox1.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        TextBox1.Location = New Point(14, 147)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(313, 45)
        TextBox1.TabIndex = 11
        TextBox1.Text = "Cari Tempat"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(334, 147)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(40, 47)
        Button1.TabIndex = 12
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(381, 147)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 47)
        Button2.TabIndex = 13
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Location = New Point(14, 224)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(407, 827)
        Panel1.TabIndex = 14
        ' 
        ' Menu_user
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        ClientSize = New Size(434, 1051)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Menu_user"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu_user"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
End Class
