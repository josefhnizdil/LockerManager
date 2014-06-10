<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresunOsoby
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
        Me.components = New System.ComponentModel.Container()
        Me.CisloSatnyTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CislosatnyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JmenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrijmenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcisloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdkartaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgenturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatnanaklicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatnanavisacizamekDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NeopravnenaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RozbitaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumregistraceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatnyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._MyDatabase_1DataSet = New VestiarioMng._MyDatabase_1DataSet()
        Me.SatnyTableAdapter = New VestiarioMng._MyDatabase_1DataSetTableAdapters.satnyTableAdapter()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.presundo = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SatnyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._MyDatabase_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CisloSatnyTextBox
        '
        Me.CisloSatnyTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CisloSatnyTextBox.Location = New System.Drawing.Point(117, 12)
        Me.CisloSatnyTextBox.Name = "CisloSatnyTextBox"
        Me.CisloSatnyTextBox.ReadOnly = True
        Me.CisloSatnyTextBox.Size = New System.Drawing.Size(132, 20)
        Me.CisloSatnyTextBox.TabIndex = 17
        Me.CisloSatnyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Přesunout z:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Přesunout do:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 124)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Osoba"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(93, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(144, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Skříňka na klíč:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(93, 70)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(144, 20)
        Me.TextBox4.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(93, 44)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(144, 20)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(93, 18)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(144, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Příjmení:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Osobní číslo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jméno:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.ForeColor = System.Drawing.Color.Green
        Me.CheckBox1.Location = New System.Drawing.Point(7, 221)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox1.TabIndex = 21
        Me.CheckBox1.Text = "Volná"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.ForeColor = System.Drawing.Color.Orange
        Me.CheckBox2.Location = New System.Drawing.Point(84, 221)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(91, 17)
        Me.CheckBox2.TabIndex = 22
        Me.CheckBox2.Text = "Neoprávněná"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.ForeColor = System.Drawing.Color.Red
        Me.CheckBox3.Location = New System.Drawing.Point(193, 221)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox3.TabIndex = 23
        Me.CheckBox3.Text = "Rozbitá"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(70, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Původní skříňka zůstala:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(70, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Nová skříňka je:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(163, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Label8"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(7, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(248, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Přesunout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CislosatnyDataGridViewTextBoxColumn, Me.JmenoDataGridViewTextBoxColumn, Me.PrijmenoDataGridViewTextBoxColumn, Me.IdcisloDataGridViewTextBoxColumn, Me.IdkartaDataGridViewTextBoxColumn, Me.AgenturaDataGridViewTextBoxColumn, Me.SatnanaklicDataGridViewTextBoxColumn, Me.SatnanavisacizamekDataGridViewTextBoxColumn, Me.NeopravnenaDataGridViewTextBoxColumn, Me.RozbitaDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.DatumregistraceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SatnyBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(303, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 29
        '
        'CislosatnyDataGridViewTextBoxColumn
        '
        Me.CislosatnyDataGridViewTextBoxColumn.DataPropertyName = "cislosatny"
        Me.CislosatnyDataGridViewTextBoxColumn.HeaderText = "cislosatny"
        Me.CislosatnyDataGridViewTextBoxColumn.Name = "CislosatnyDataGridViewTextBoxColumn"
        Me.CislosatnyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JmenoDataGridViewTextBoxColumn
        '
        Me.JmenoDataGridViewTextBoxColumn.DataPropertyName = "jmeno"
        Me.JmenoDataGridViewTextBoxColumn.HeaderText = "jmeno"
        Me.JmenoDataGridViewTextBoxColumn.Name = "JmenoDataGridViewTextBoxColumn"
        Me.JmenoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrijmenoDataGridViewTextBoxColumn
        '
        Me.PrijmenoDataGridViewTextBoxColumn.DataPropertyName = "prijmeno"
        Me.PrijmenoDataGridViewTextBoxColumn.HeaderText = "prijmeno"
        Me.PrijmenoDataGridViewTextBoxColumn.Name = "PrijmenoDataGridViewTextBoxColumn"
        Me.PrijmenoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdcisloDataGridViewTextBoxColumn
        '
        Me.IdcisloDataGridViewTextBoxColumn.DataPropertyName = "idcislo"
        Me.IdcisloDataGridViewTextBoxColumn.HeaderText = "idcislo"
        Me.IdcisloDataGridViewTextBoxColumn.Name = "IdcisloDataGridViewTextBoxColumn"
        Me.IdcisloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdkartaDataGridViewTextBoxColumn
        '
        Me.IdkartaDataGridViewTextBoxColumn.DataPropertyName = "idkarta"
        Me.IdkartaDataGridViewTextBoxColumn.HeaderText = "idkarta"
        Me.IdkartaDataGridViewTextBoxColumn.Name = "IdkartaDataGridViewTextBoxColumn"
        Me.IdkartaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AgenturaDataGridViewTextBoxColumn
        '
        Me.AgenturaDataGridViewTextBoxColumn.DataPropertyName = "agentura"
        Me.AgenturaDataGridViewTextBoxColumn.HeaderText = "agentura"
        Me.AgenturaDataGridViewTextBoxColumn.Name = "AgenturaDataGridViewTextBoxColumn"
        Me.AgenturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SatnanaklicDataGridViewTextBoxColumn
        '
        Me.SatnanaklicDataGridViewTextBoxColumn.DataPropertyName = "satnanaklic"
        Me.SatnanaklicDataGridViewTextBoxColumn.HeaderText = "satnanaklic"
        Me.SatnanaklicDataGridViewTextBoxColumn.Name = "SatnanaklicDataGridViewTextBoxColumn"
        Me.SatnanaklicDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SatnanavisacizamekDataGridViewTextBoxColumn
        '
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.DataPropertyName = "satnanavisacizamek"
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.HeaderText = "satnanavisacizamek"
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.Name = "SatnanavisacizamekDataGridViewTextBoxColumn"
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NeopravnenaDataGridViewTextBoxColumn
        '
        Me.NeopravnenaDataGridViewTextBoxColumn.DataPropertyName = "neopravnena"
        Me.NeopravnenaDataGridViewTextBoxColumn.HeaderText = "neopravnena"
        Me.NeopravnenaDataGridViewTextBoxColumn.Name = "NeopravnenaDataGridViewTextBoxColumn"
        Me.NeopravnenaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RozbitaDataGridViewTextBoxColumn
        '
        Me.RozbitaDataGridViewTextBoxColumn.DataPropertyName = "rozbita"
        Me.RozbitaDataGridViewTextBoxColumn.HeaderText = "rozbita"
        Me.RozbitaDataGridViewTextBoxColumn.Name = "RozbitaDataGridViewTextBoxColumn"
        Me.RozbitaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatumregistraceDataGridViewTextBoxColumn
        '
        Me.DatumregistraceDataGridViewTextBoxColumn.DataPropertyName = "datumregistrace"
        Me.DatumregistraceDataGridViewTextBoxColumn.HeaderText = "datumregistrace"
        Me.DatumregistraceDataGridViewTextBoxColumn.Name = "DatumregistraceDataGridViewTextBoxColumn"
        Me.DatumregistraceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SatnyBindingSource
        '
        Me.SatnyBindingSource.DataMember = "satny"
        Me.SatnyBindingSource.DataSource = Me._MyDatabase_1DataSet
        '
        '_MyDatabase_1DataSet
        '
        Me._MyDatabase_1DataSet.DataSetName = "_MyDatabase_1DataSet"
        Me._MyDatabase_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SatnyTableAdapter
        '
        Me.SatnyTableAdapter.ClearBeforeFill = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(38, 280)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(61, 17)
        Me.CheckBox4.TabIndex = 31
        Me.CheckBox4.Text = "Na klíč"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(138, 280)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(106, 17)
        Me.CheckBox5.TabIndex = 32
        Me.CheckBox5.Text = "Na visací zámek"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'presundo
        '
        Me.presundo.Location = New System.Drawing.Point(117, 38)
        Me.presundo.Name = "presundo"
        Me.presundo.Size = New System.Drawing.Size(108, 20)
        Me.presundo.TabIndex = 33
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Image = Global.VestiarioMng.My.Resources.Resources._1366845103_refresh
        Me.Button2.Location = New System.Drawing.Point(231, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 24)
        Me.Button2.TabIndex = 30
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PresunOsoby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 339)
        Me.Controls.Add(Me.presundo)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CisloSatnyTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PresunOsoby"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Přesunutí osoby"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SatnyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._MyDatabase_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CisloSatnyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents _MyDatabase_1DataSet As VestiarioMng._MyDatabase_1DataSet
    Friend WithEvents SatnyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SatnyTableAdapter As VestiarioMng._MyDatabase_1DataSetTableAdapters.satnyTableAdapter
    Friend WithEvents CislosatnyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JmenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrijmenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdcisloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdkartaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgenturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatnanaklicDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatnanavisacizamekDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NeopravnenaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RozbitaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumregistraceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents presundo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
