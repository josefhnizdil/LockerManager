<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editacesatny
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
        Me.Stav = New System.Windows.Forms.Label()
        Me.satnastatus2 = New System.Windows.Forms.Label()
        Me.satnastatus1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OsobniCisloTextBoxt = New System.Windows.Forms.TextBox()
        Me.PrijmeniTextBox = New System.Windows.Forms.TextBox()
        Me.JmenoTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CisloSatnyTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.satnanaklic = New System.Windows.Forms.Label()
        Me.satnanazamek = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Stav
        '
        Me.Stav.AutoSize = True
        Me.Stav.Location = New System.Drawing.Point(64, 370)
        Me.Stav.Name = "Stav"
        Me.Stav.Size = New System.Drawing.Size(55, 13)
        Me.Stav.TabIndex = 28
        Me.Stav.Text = "Obsazená"
        '
        'satnastatus2
        '
        Me.satnastatus2.AutoSize = True
        Me.satnastatus2.Location = New System.Drawing.Point(149, 331)
        Me.satnastatus2.Name = "satnastatus2"
        Me.satnastatus2.Size = New System.Drawing.Size(39, 13)
        Me.satnastatus2.TabIndex = 27
        Me.satnastatus2.Text = "Label8"
        '
        'satnastatus1
        '
        Me.satnastatus1.AutoSize = True
        Me.satnastatus1.Location = New System.Drawing.Point(30, 331)
        Me.satnastatus1.Name = "satnastatus1"
        Me.satnastatus1.Size = New System.Drawing.Size(39, 13)
        Me.satnastatus1.TabIndex = 26
        Me.satnastatus1.Text = "Label6"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(258, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Aktualizovat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox5)
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 42)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Šatní skříň"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(113, 19)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(135, 17)
        Me.CheckBox5.TabIndex = 7
        Me.CheckBox5.Text = "Šatna na visací zámek"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(17, 19)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(90, 17)
        Me.CheckBox4.TabIndex = 6
        Me.CheckBox4.Text = "Šatna na klíč"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.OsobniCisloTextBoxt)
        Me.GroupBox1.Controls.Add(Me.PrijmeniTextBox)
        Me.GroupBox1.Controls.Add(Me.JmenoTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 195)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Přidělit šatnu"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(83, 130)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(165, 59)
        Me.TextBox1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Poznámka:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(83, 104)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(165, 20)
        Me.TextBox3.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(6, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "ID karta:"
        '
        'OsobniCisloTextBoxt
        '
        Me.OsobniCisloTextBoxt.Location = New System.Drawing.Point(83, 78)
        Me.OsobniCisloTextBoxt.Name = "OsobniCisloTextBoxt"
        Me.OsobniCisloTextBoxt.Size = New System.Drawing.Size(165, 20)
        Me.OsobniCisloTextBoxt.TabIndex = 3
        '
        'PrijmeniTextBox
        '
        Me.PrijmeniTextBox.Location = New System.Drawing.Point(83, 52)
        Me.PrijmeniTextBox.Name = "PrijmeniTextBox"
        Me.PrijmeniTextBox.Size = New System.Drawing.Size(165, 20)
        Me.PrijmeniTextBox.TabIndex = 2
        '
        'JmenoTextBox
        '
        Me.JmenoTextBox.Location = New System.Drawing.Point(83, 26)
        Me.JmenoTextBox.Name = "JmenoTextBox"
        Me.JmenoTextBox.Size = New System.Drawing.Size(165, 20)
        Me.JmenoTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Jméno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Příjmení:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Osobní číslo:"
        '
        'CisloSatnyTextBox
        '
        Me.CisloSatnyTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CisloSatnyTextBox.Location = New System.Drawing.Point(115, 8)
        Me.CisloSatnyTextBox.Name = "CisloSatnyTextBox"
        Me.CisloSatnyTextBox.ReadOnly = True
        Me.CisloSatnyTextBox.Size = New System.Drawing.Size(132, 20)
        Me.CisloSatnyTextBox.TabIndex = 23
        Me.CisloSatnyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Šatní skříň č.:"
        '
        'satnanaklic
        '
        Me.satnanaklic.AutoSize = True
        Me.satnanaklic.Location = New System.Drawing.Point(285, 239)
        Me.satnanaklic.Name = "satnanaklic"
        Me.satnanaklic.Size = New System.Drawing.Size(61, 13)
        Me.satnanaklic.TabIndex = 29
        Me.satnanaklic.Text = "satnanaklic"
        '
        'satnanazamek
        '
        Me.satnanazamek.AutoSize = True
        Me.satnanazamek.Location = New System.Drawing.Point(285, 268)
        Me.satnanazamek.Name = "satnanazamek"
        Me.satnanazamek.Size = New System.Drawing.Size(103, 13)
        Me.satnanazamek.TabIndex = 30
        Me.satnanazamek.Text = "satnanavisacizamek"
        '
        'editacesatny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 317)
        Me.Controls.Add(Me.satnanazamek)
        Me.Controls.Add(Me.satnanaklic)
        Me.Controls.Add(Me.Stav)
        Me.Controls.Add(Me.satnastatus2)
        Me.Controls.Add(Me.satnastatus1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CisloSatnyTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "editacesatny"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editování šatny "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Stav As System.Windows.Forms.Label
    Friend WithEvents satnastatus2 As System.Windows.Forms.Label
    Friend WithEvents satnastatus1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OsobniCisloTextBoxt As System.Windows.Forms.TextBox
    Friend WithEvents PrijmeniTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JmenoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CisloSatnyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents satnanaklic As System.Windows.Forms.Label
    Friend WithEvents satnanazamek As System.Windows.Forms.Label
End Class
