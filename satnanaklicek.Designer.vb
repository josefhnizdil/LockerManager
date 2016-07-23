<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class satnanaklicek
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(satnanaklicek))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SatnyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._MyDatabase_1DataSet = New VestiarioMng._MyDatabase_1DataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CislosatnyDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JmenoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrijmenoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcisloDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdkartaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgenturaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatnanaklicDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatnanavisacizamekDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NeopravnenaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RozbitaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumregistraceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SatnyBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SatnyTableAdapter = New VestiarioMng._MyDatabase_1DataSetTableAdapters.satnyTableAdapter()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SatnyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._MyDatabase_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SatnyBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(517, 373)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 342.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ComboBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(511, 28)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"MA", "MB", "MC", "MD", "ME", "MF", "ZA", "ZB", "ZC", "ZD", "ZE", "ZF"})
        Me.ComboBox1.Location = New System.Drawing.Point(77, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(89, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 28)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Zvolit šatnu:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(511, 333)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(503, 307)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrace"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CislosatnyDataGridViewTextBoxColumn, Me.JmenoDataGridViewTextBoxColumn, Me.PrijmenoDataGridViewTextBoxColumn, Me.IdcisloDataGridViewTextBoxColumn, Me.IdkartaDataGridViewTextBoxColumn, Me.AgenturaDataGridViewTextBoxColumn, Me.SatnanaklicDataGridViewTextBoxColumn, Me.SatnanavisacizamekDataGridViewTextBoxColumn, Me.NeopravnenaDataGridViewTextBoxColumn, Me.RozbitaDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.DatumregistraceDataGridViewTextBoxColumn, Me.DataGridViewCheckBoxColumn2})
        Me.DataGridView1.DataSource = Me.SatnyBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(497, 301)
        Me.DataGridView1.TabIndex = 0
        '
        'CislosatnyDataGridViewTextBoxColumn
        '
        Me.CislosatnyDataGridViewTextBoxColumn.DataPropertyName = "cislosatny"
        Me.CislosatnyDataGridViewTextBoxColumn.HeaderText = "Číslo skříňky"
        Me.CislosatnyDataGridViewTextBoxColumn.Name = "CislosatnyDataGridViewTextBoxColumn"
        '
        'JmenoDataGridViewTextBoxColumn
        '
        Me.JmenoDataGridViewTextBoxColumn.DataPropertyName = "jmeno"
        Me.JmenoDataGridViewTextBoxColumn.HeaderText = "jmeno"
        Me.JmenoDataGridViewTextBoxColumn.Name = "JmenoDataGridViewTextBoxColumn"
        Me.JmenoDataGridViewTextBoxColumn.Visible = False
        '
        'PrijmenoDataGridViewTextBoxColumn
        '
        Me.PrijmenoDataGridViewTextBoxColumn.DataPropertyName = "prijmeno"
        Me.PrijmenoDataGridViewTextBoxColumn.HeaderText = "prijmeno"
        Me.PrijmenoDataGridViewTextBoxColumn.Name = "PrijmenoDataGridViewTextBoxColumn"
        Me.PrijmenoDataGridViewTextBoxColumn.Visible = False
        '
        'IdcisloDataGridViewTextBoxColumn
        '
        Me.IdcisloDataGridViewTextBoxColumn.DataPropertyName = "idcislo"
        Me.IdcisloDataGridViewTextBoxColumn.HeaderText = "idcislo"
        Me.IdcisloDataGridViewTextBoxColumn.Name = "IdcisloDataGridViewTextBoxColumn"
        Me.IdcisloDataGridViewTextBoxColumn.Visible = False
        '
        'IdkartaDataGridViewTextBoxColumn
        '
        Me.IdkartaDataGridViewTextBoxColumn.DataPropertyName = "idkarta"
        Me.IdkartaDataGridViewTextBoxColumn.HeaderText = "idkarta"
        Me.IdkartaDataGridViewTextBoxColumn.Name = "IdkartaDataGridViewTextBoxColumn"
        Me.IdkartaDataGridViewTextBoxColumn.Visible = False
        '
        'AgenturaDataGridViewTextBoxColumn
        '
        Me.AgenturaDataGridViewTextBoxColumn.DataPropertyName = "agentura"
        Me.AgenturaDataGridViewTextBoxColumn.HeaderText = "agentura"
        Me.AgenturaDataGridViewTextBoxColumn.Name = "AgenturaDataGridViewTextBoxColumn"
        Me.AgenturaDataGridViewTextBoxColumn.Visible = False
        '
        'SatnanaklicDataGridViewTextBoxColumn
        '
        Me.SatnanaklicDataGridViewTextBoxColumn.DataPropertyName = "satnanaklic"
        Me.SatnanaklicDataGridViewTextBoxColumn.HeaderText = "satnanaklic"
        Me.SatnanaklicDataGridViewTextBoxColumn.Name = "SatnanaklicDataGridViewTextBoxColumn"
        Me.SatnanaklicDataGridViewTextBoxColumn.Visible = False
        '
        'SatnanavisacizamekDataGridViewTextBoxColumn
        '
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.DataPropertyName = "satnanavisacizamek"
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.HeaderText = "satnanavisacizamek"
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.Name = "SatnanavisacizamekDataGridViewTextBoxColumn"
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.Visible = False
        '
        'NeopravnenaDataGridViewTextBoxColumn
        '
        Me.NeopravnenaDataGridViewTextBoxColumn.DataPropertyName = "neopravnena"
        Me.NeopravnenaDataGridViewTextBoxColumn.HeaderText = "neopravnena"
        Me.NeopravnenaDataGridViewTextBoxColumn.Name = "NeopravnenaDataGridViewTextBoxColumn"
        Me.NeopravnenaDataGridViewTextBoxColumn.Visible = False
        '
        'RozbitaDataGridViewTextBoxColumn
        '
        Me.RozbitaDataGridViewTextBoxColumn.DataPropertyName = "rozbita"
        Me.RozbitaDataGridViewTextBoxColumn.HeaderText = "rozbita"
        Me.RozbitaDataGridViewTextBoxColumn.Name = "RozbitaDataGridViewTextBoxColumn"
        Me.RozbitaDataGridViewTextBoxColumn.Visible = False
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.Visible = False
        '
        'DatumregistraceDataGridViewTextBoxColumn
        '
        Me.DatumregistraceDataGridViewTextBoxColumn.DataPropertyName = "datumregistrace"
        Me.DatumregistraceDataGridViewTextBoxColumn.HeaderText = "datumregistrace"
        Me.DatumregistraceDataGridViewTextBoxColumn.Name = "DatumregistraceDataGridViewTextBoxColumn"
        Me.DatumregistraceDataGridViewTextBoxColumn.Visible = False
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "klicekksatne"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Klíček"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(503, 307)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Již registrované"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CislosatnyDataGridViewTextBoxColumn1, Me.JmenoDataGridViewTextBoxColumn1, Me.PrijmenoDataGridViewTextBoxColumn1, Me.IdcisloDataGridViewTextBoxColumn1, Me.IdkartaDataGridViewTextBoxColumn1, Me.AgenturaDataGridViewTextBoxColumn1, Me.SatnanaklicDataGridViewTextBoxColumn1, Me.SatnanavisacizamekDataGridViewTextBoxColumn1, Me.NeopravnenaDataGridViewTextBoxColumn1, Me.RozbitaDataGridViewTextBoxColumn1, Me.StatusDataGridViewTextBoxColumn1, Me.DatumregistraceDataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn3})
        Me.DataGridView2.DataSource = Me.SatnyBindingSource1
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(497, 301)
        Me.DataGridView2.TabIndex = 9
        '
        'CislosatnyDataGridViewTextBoxColumn1
        '
        Me.CislosatnyDataGridViewTextBoxColumn1.DataPropertyName = "cislosatny"
        Me.CislosatnyDataGridViewTextBoxColumn1.HeaderText = "Číslo skříňky"
        Me.CislosatnyDataGridViewTextBoxColumn1.Name = "CislosatnyDataGridViewTextBoxColumn1"
        '
        'JmenoDataGridViewTextBoxColumn1
        '
        Me.JmenoDataGridViewTextBoxColumn1.DataPropertyName = "jmeno"
        Me.JmenoDataGridViewTextBoxColumn1.HeaderText = "jmeno"
        Me.JmenoDataGridViewTextBoxColumn1.Name = "JmenoDataGridViewTextBoxColumn1"
        Me.JmenoDataGridViewTextBoxColumn1.Visible = False
        '
        'PrijmenoDataGridViewTextBoxColumn1
        '
        Me.PrijmenoDataGridViewTextBoxColumn1.DataPropertyName = "prijmeno"
        Me.PrijmenoDataGridViewTextBoxColumn1.HeaderText = "prijmeno"
        Me.PrijmenoDataGridViewTextBoxColumn1.Name = "PrijmenoDataGridViewTextBoxColumn1"
        Me.PrijmenoDataGridViewTextBoxColumn1.Visible = False
        '
        'IdcisloDataGridViewTextBoxColumn1
        '
        Me.IdcisloDataGridViewTextBoxColumn1.DataPropertyName = "idcislo"
        Me.IdcisloDataGridViewTextBoxColumn1.HeaderText = "idcislo"
        Me.IdcisloDataGridViewTextBoxColumn1.Name = "IdcisloDataGridViewTextBoxColumn1"
        Me.IdcisloDataGridViewTextBoxColumn1.Visible = False
        '
        'IdkartaDataGridViewTextBoxColumn1
        '
        Me.IdkartaDataGridViewTextBoxColumn1.DataPropertyName = "idkarta"
        Me.IdkartaDataGridViewTextBoxColumn1.HeaderText = "idkarta"
        Me.IdkartaDataGridViewTextBoxColumn1.Name = "IdkartaDataGridViewTextBoxColumn1"
        Me.IdkartaDataGridViewTextBoxColumn1.Visible = False
        '
        'AgenturaDataGridViewTextBoxColumn1
        '
        Me.AgenturaDataGridViewTextBoxColumn1.DataPropertyName = "agentura"
        Me.AgenturaDataGridViewTextBoxColumn1.HeaderText = "agentura"
        Me.AgenturaDataGridViewTextBoxColumn1.Name = "AgenturaDataGridViewTextBoxColumn1"
        Me.AgenturaDataGridViewTextBoxColumn1.Visible = False
        '
        'SatnanaklicDataGridViewTextBoxColumn1
        '
        Me.SatnanaklicDataGridViewTextBoxColumn1.DataPropertyName = "satnanaklic"
        Me.SatnanaklicDataGridViewTextBoxColumn1.HeaderText = "satnanaklic"
        Me.SatnanaklicDataGridViewTextBoxColumn1.Name = "SatnanaklicDataGridViewTextBoxColumn1"
        Me.SatnanaklicDataGridViewTextBoxColumn1.Visible = False
        '
        'SatnanavisacizamekDataGridViewTextBoxColumn1
        '
        Me.SatnanavisacizamekDataGridViewTextBoxColumn1.DataPropertyName = "satnanavisacizamek"
        Me.SatnanavisacizamekDataGridViewTextBoxColumn1.HeaderText = "satnanavisacizamek"
        Me.SatnanavisacizamekDataGridViewTextBoxColumn1.Name = "SatnanavisacizamekDataGridViewTextBoxColumn1"
        Me.SatnanavisacizamekDataGridViewTextBoxColumn1.Visible = False
        '
        'NeopravnenaDataGridViewTextBoxColumn1
        '
        Me.NeopravnenaDataGridViewTextBoxColumn1.DataPropertyName = "neopravnena"
        Me.NeopravnenaDataGridViewTextBoxColumn1.HeaderText = "neopravnena"
        Me.NeopravnenaDataGridViewTextBoxColumn1.Name = "NeopravnenaDataGridViewTextBoxColumn1"
        Me.NeopravnenaDataGridViewTextBoxColumn1.Visible = False
        '
        'RozbitaDataGridViewTextBoxColumn1
        '
        Me.RozbitaDataGridViewTextBoxColumn1.DataPropertyName = "rozbita"
        Me.RozbitaDataGridViewTextBoxColumn1.HeaderText = "rozbita"
        Me.RozbitaDataGridViewTextBoxColumn1.Name = "RozbitaDataGridViewTextBoxColumn1"
        Me.RozbitaDataGridViewTextBoxColumn1.Visible = False
        '
        'StatusDataGridViewTextBoxColumn1
        '
        Me.StatusDataGridViewTextBoxColumn1.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn1.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn1.Name = "StatusDataGridViewTextBoxColumn1"
        Me.StatusDataGridViewTextBoxColumn1.Visible = False
        '
        'DatumregistraceDataGridViewTextBoxColumn1
        '
        Me.DatumregistraceDataGridViewTextBoxColumn1.DataPropertyName = "datumregistrace"
        Me.DatumregistraceDataGridViewTextBoxColumn1.HeaderText = "datumregistrace"
        Me.DatumregistraceDataGridViewTextBoxColumn1.Name = "DatumregistraceDataGridViewTextBoxColumn1"
        Me.DatumregistraceDataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "klicekksatne"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Klíček"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'SatnyBindingSource1
        '
        Me.SatnyBindingSource1.DataMember = "satny"
        Me.SatnyBindingSource1.DataSource = Me._MyDatabase_1DataSet
        '
        'SatnyTableAdapter
        '
        Me.SatnyTableAdapter.ClearBeforeFill = True
        '
        'satnanaklicek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 373)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "satnanaklicek"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Šatní skříňka na klíček"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SatnyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._MyDatabase_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SatnyBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents KlicekksatneDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
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
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CislosatnyDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JmenoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrijmenoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdcisloDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdkartaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgenturaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatnanaklicDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatnanavisacizamekDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NeopravnenaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RozbitaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumregistraceDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SatnyBindingSource1 As System.Windows.Forms.BindingSource
End Class
