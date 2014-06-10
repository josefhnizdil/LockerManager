<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class historienew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(historienew))
        Me.HistoriesatenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._MyDatabase_1DataSet2 = New VestiarioMng._MyDatabase_1DataSet2()
        Me.HistoriesatenTableAdapter = New VestiarioMng._MyDatabase_1DataSet2TableAdapters.historiesatenTableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CislosatnyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JmenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrijmeniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcisloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdkartaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatnanaklicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatnanavisacizamekDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumvyklizeniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgenturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        CType(Me.HistoriesatenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._MyDatabase_1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HistoriesatenBindingSource
        '
        Me.HistoriesatenBindingSource.DataMember = "historiesaten"
        Me.HistoriesatenBindingSource.DataSource = Me._MyDatabase_1DataSet2
        '
        '_MyDatabase_1DataSet2
        '
        Me._MyDatabase_1DataSet2.DataSetName = "_MyDatabase_1DataSet2"
        Me._MyDatabase_1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HistoriesatenTableAdapter
        '
        Me.HistoriesatenTableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(701, 319)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(693, 290)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Historie šaten"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(693, 290)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Historie ntb"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CislosatnyDataGridViewTextBoxColumn, Me.JmenoDataGridViewTextBoxColumn, Me.PrijmeniDataGridViewTextBoxColumn, Me.IdcisloDataGridViewTextBoxColumn, Me.IdkartaDataGridViewTextBoxColumn, Me.SatnanaklicDataGridViewTextBoxColumn, Me.SatnanavisacizamekDataGridViewTextBoxColumn, Me.DatumvyklizeniDataGridViewTextBoxColumn, Me.AgenturaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HistoriesatenBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 28)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(687, 259)
        Me.DataGridView1.TabIndex = 3
        '
        'CislosatnyDataGridViewTextBoxColumn
        '
        Me.CislosatnyDataGridViewTextBoxColumn.DataPropertyName = "cislosatny"
        Me.CislosatnyDataGridViewTextBoxColumn.HeaderText = "Číslo šatny"
        Me.CislosatnyDataGridViewTextBoxColumn.Name = "CislosatnyDataGridViewTextBoxColumn"
        Me.CislosatnyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JmenoDataGridViewTextBoxColumn
        '
        Me.JmenoDataGridViewTextBoxColumn.DataPropertyName = "jmeno"
        Me.JmenoDataGridViewTextBoxColumn.HeaderText = "Jméno"
        Me.JmenoDataGridViewTextBoxColumn.Name = "JmenoDataGridViewTextBoxColumn"
        Me.JmenoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrijmeniDataGridViewTextBoxColumn
        '
        Me.PrijmeniDataGridViewTextBoxColumn.DataPropertyName = "prijmeni"
        Me.PrijmeniDataGridViewTextBoxColumn.HeaderText = "Příjmení"
        Me.PrijmeniDataGridViewTextBoxColumn.Name = "PrijmeniDataGridViewTextBoxColumn"
        Me.PrijmeniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdcisloDataGridViewTextBoxColumn
        '
        Me.IdcisloDataGridViewTextBoxColumn.DataPropertyName = "idcislo"
        Me.IdcisloDataGridViewTextBoxColumn.HeaderText = "ID číslo"
        Me.IdcisloDataGridViewTextBoxColumn.Name = "IdcisloDataGridViewTextBoxColumn"
        Me.IdcisloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdkartaDataGridViewTextBoxColumn
        '
        Me.IdkartaDataGridViewTextBoxColumn.DataPropertyName = "idkarta"
        Me.IdkartaDataGridViewTextBoxColumn.HeaderText = "ID karta"
        Me.IdkartaDataGridViewTextBoxColumn.Name = "IdkartaDataGridViewTextBoxColumn"
        Me.IdkartaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdkartaDataGridViewTextBoxColumn.Visible = False
        '
        'SatnanaklicDataGridViewTextBoxColumn
        '
        Me.SatnanaklicDataGridViewTextBoxColumn.DataPropertyName = "satnanaklic"
        Me.SatnanaklicDataGridViewTextBoxColumn.HeaderText = "Šatna na klíč"
        Me.SatnanaklicDataGridViewTextBoxColumn.Name = "SatnanaklicDataGridViewTextBoxColumn"
        Me.SatnanaklicDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SatnanavisacizamekDataGridViewTextBoxColumn
        '
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.DataPropertyName = "satnanavisacizamek"
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.HeaderText = "Šatna na visací zámek"
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.Name = "SatnanavisacizamekDataGridViewTextBoxColumn"
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatumvyklizeniDataGridViewTextBoxColumn
        '
        Me.DatumvyklizeniDataGridViewTextBoxColumn.DataPropertyName = "datumvyklizeni"
        Me.DatumvyklizeniDataGridViewTextBoxColumn.HeaderText = "Datum vyklizení"
        Me.DatumvyklizeniDataGridViewTextBoxColumn.Name = "DatumvyklizeniDataGridViewTextBoxColumn"
        Me.DatumvyklizeniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AgenturaDataGridViewTextBoxColumn
        '
        Me.AgenturaDataGridViewTextBoxColumn.DataPropertyName = "agentura"
        Me.AgenturaDataGridViewTextBoxColumn.HeaderText = "Evidoval/la:"
        Me.AgenturaDataGridViewTextBoxColumn.Name = "AgenturaDataGridViewTextBoxColumn"
        Me.AgenturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.ToolStripTextBox2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(687, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(39, 22)
        Me.ToolStripLabel1.Text = "Šatna:"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel2.Text = "ID číslo:"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 25)
        '
        'historienew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 319)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "historienew"
        Me.Text = "Historie"
        CType(Me.HistoriesatenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._MyDatabase_1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _MyDatabase_1DataSet2 As VestiarioMng._MyDatabase_1DataSet2
    Friend WithEvents HistoriesatenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HistoriesatenTableAdapter As VestiarioMng._MyDatabase_1DataSet2TableAdapters.historiesatenTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CislosatnyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JmenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrijmeniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdcisloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdkartaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatnanaklicDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatnanavisacizamekDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumvyklizeniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgenturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
End Class
