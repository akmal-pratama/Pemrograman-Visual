<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notifikasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(notifikasi))
        Label2 = New Label()
        Button2 = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label2.Location = New Point(136, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 41)
        Label2.TabIndex = 39
        Label2.Text = "NOTIFIKASI"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(24, 28)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 47)
        Button2.TabIndex = 38
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palace Script MT", 48F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(76), CByte(61), CByte(25))
        Label1.Location = New Point(82, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 74)
        Label1.TabIndex = 37
        Label1.Text = "BarberRand"
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(24, 208)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(385, 843)
        Panel1.TabIndex = 40
        ' 
        ' notifikasi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(229), CByte(215), CByte(196))
        ClientSize = New Size(434, 1051)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "notifikasi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "notifikasi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
