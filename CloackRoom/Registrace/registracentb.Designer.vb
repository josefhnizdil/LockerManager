<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registracentb
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
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

    'Vyžadováno Návrhářem formulářů
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem formulářů
    'Může být upraveno pomocí Návrháře formulářů.  
    'Neupravovat pomocí editoru kódu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.evcislo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.plomba = New System.Windows.Forms.TextBox()
        Me.osobko = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sn = New System.Windows.Forms.TextBox()
        Me.znacka = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.jmenoprijmeni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.datumplatnosti = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pořadové číslo:"
        '
        'evcislo
        '
        Me.evcislo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.evcislo.HideSelection = False
        Me.evcislo.Location = New System.Drawing.Point(101, 6)
        Me.evcislo.Name = "evcislo"
        Me.evcislo.ReadOnly = True
        Me.evcislo.Size = New System.Drawing.Size(123, 20)
        Me.evcislo.TabIndex = 1
        Me.evcislo.Text = "NTB-"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.plomba)
        Me.GroupBox1.Controls.Add(Me.osobko)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.sn)
        Me.GroupBox1.Controls.Add(Me.znacka)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.jmenoprijmeni)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 154)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrace"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Plomba číslo:"
        '
        'plomba
        '
        Me.plomba.Location = New System.Drawing.Point(105, 120)
        Me.plomba.Name = "plomba"
        Me.plomba.Size = New System.Drawing.Size(172, 20)
        Me.plomba.TabIndex = 7
        '
        'osobko
        '
        Me.osobko.Location = New System.Drawing.Point(105, 42)
        Me.osobko.Name = "osobko"
        Me.osobko.Size = New System.Drawing.Size(172, 20)
        Me.osobko.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Osobní číslo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sériové číslo:"
        '
        'sn
        '
        Me.sn.Location = New System.Drawing.Point(105, 94)
        Me.sn.Name = "sn"
        Me.sn.Size = New System.Drawing.Size(172, 20)
        Me.sn.TabIndex = 4
        '
        'znacka
        '
        Me.znacka.Location = New System.Drawing.Point(105, 68)
        Me.znacka.Name = "znacka"
        Me.znacka.Size = New System.Drawing.Size(172, 20)
        Me.znacka.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Značka NTB:"
        '
        'jmenoprijmeni
        '
        Me.jmenoprijmeni.Location = New System.Drawing.Point(105, 16)
        Me.jmenoprijmeni.Name = "jmenoprijmeni"
        Me.jmenoprijmeni.Size = New System.Drawing.Size(172, 20)
        Me.jmenoprijmeni.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Jméno a příjmení:"
        '
        'datumplatnosti
        '
        Me.datumplatnosti.Location = New System.Drawing.Point(129, 192)
        Me.datumplatnosti.Mask = "00/00/0000"
        Me.datumplatnosti.Name = "datumplatnosti"
        Me.datumplatnosti.Size = New System.Drawing.Size(81, 20)
        Me.datumplatnosti.TabIndex = 3
        Me.datumplatnosti.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Povolení je platné do:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(87, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Uložit a zavřít"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(253, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Label8"
        Me.Label8.Visible = False
        '
        'registracentb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 246)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.datumplatnosti)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.evcislo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "registracentb"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrovat nový NTB"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents evcislo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents plomba As System.Windows.Forms.TextBox
    Friend WithEvents osobko As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents sn As System.Windows.Forms.TextBox
    Friend WithEvents znacka As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents jmenoprijmeni As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents datumplatnosti As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
