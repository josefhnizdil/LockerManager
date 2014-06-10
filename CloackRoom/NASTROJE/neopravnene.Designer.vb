<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class neopravnene
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(neopravnene))
        Me.SatnyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._MyDatabase_1DataSet = New VestiarioMng._MyDatabase_1DataSet()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CislosatnyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JmenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrijmenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcisloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdkartaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatnanaklicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatnanavisacizamekDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NeopravnenaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgenturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumregistraceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RozbitaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatnyTableAdapter = New VestiarioMng._MyDatabase_1DataSetTableAdapters.satnyTableAdapter()
        CType(Me.SatnyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._MyDatabase_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(557, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '

        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripButton1.Text = "Tisk"
        Me.ToolStripButton1.ToolTipText = "Tisk"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.VestiarioMng.My.Resources.Resources._1365520906_sign_out
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripButton2.Text = "Export"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CislosatnyDataGridViewTextBoxColumn, Me.JmenoDataGridViewTextBoxColumn, Me.PrijmenoDataGridViewTextBoxColumn, Me.IdcisloDataGridViewTextBoxColumn, Me.IdkartaDataGridViewTextBoxColumn, Me.SatnanaklicDataGridViewTextBoxColumn, Me.SatnanavisacizamekDataGridViewTextBoxColumn, Me.NeopravnenaDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.AgenturaDataGridViewTextBoxColumn, Me.DatumregistraceDataGridViewTextBoxColumn, Me.RozbitaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SatnyBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 25)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(557, 401)
        Me.DataGridView1.TabIndex = 1
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
        Me.JmenoDataGridViewTextBoxColumn.HeaderText = "jmeno"
        Me.JmenoDataGridViewTextBoxColumn.Name = "JmenoDataGridViewTextBoxColumn"
        Me.JmenoDataGridViewTextBoxColumn.ReadOnly = True
        Me.JmenoDataGridViewTextBoxColumn.Visible = False
        '
        'PrijmenoDataGridViewTextBoxColumn
        '
        Me.PrijmenoDataGridViewTextBoxColumn.DataPropertyName = "prijmeno"
        Me.PrijmenoDataGridViewTextBoxColumn.HeaderText = "prijmeno"
        Me.PrijmenoDataGridViewTextBoxColumn.Name = "PrijmenoDataGridViewTextBoxColumn"
        Me.PrijmenoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrijmenoDataGridViewTextBoxColumn.Visible = False
        '
        'IdcisloDataGridViewTextBoxColumn
        '
        Me.IdcisloDataGridViewTextBoxColumn.DataPropertyName = "idcislo"
        Me.IdcisloDataGridViewTextBoxColumn.HeaderText = "idcislo"
        Me.IdcisloDataGridViewTextBoxColumn.Name = "IdcisloDataGridViewTextBoxColumn"
        Me.IdcisloDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdcisloDataGridViewTextBoxColumn.Visible = False
        '
        'IdkartaDataGridViewTextBoxColumn
        '
        Me.IdkartaDataGridViewTextBoxColumn.DataPropertyName = "idkarta"
        Me.IdkartaDataGridViewTextBoxColumn.HeaderText = "idkarta"
        Me.IdkartaDataGridViewTextBoxColumn.Name = "IdkartaDataGridViewTextBoxColumn"
        Me.IdkartaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdkartaDataGridViewTextBoxColumn.Visible = False
        '
        'SatnanaklicDataGridViewTextBoxColumn
        '
        Me.SatnanaklicDataGridViewTextBoxColumn.DataPropertyName = "satnanaklic"
        Me.SatnanaklicDataGridViewTextBoxColumn.HeaderText = "satnanaklic"
        Me.SatnanaklicDataGridViewTextBoxColumn.Name = "SatnanaklicDataGridViewTextBoxColumn"
        Me.SatnanaklicDataGridViewTextBoxColumn.ReadOnly = True
        Me.SatnanaklicDataGridViewTextBoxColumn.Visible = False
        '
        'SatnanavisacizamekDataGridViewTextBoxColumn
        '
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.DataPropertyName = "satnanavisacizamek"
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.HeaderText = "satnanavisacizamek"
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.Name = "SatnanavisacizamekDataGridViewTextBoxColumn"
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.ReadOnly = True
        Me.SatnanavisacizamekDataGridViewTextBoxColumn.Visible = False
        '
        'NeopravnenaDataGridViewTextBoxColumn
        '
        Me.NeopravnenaDataGridViewTextBoxColumn.DataPropertyName = "neopravnena"
        Me.NeopravnenaDataGridViewTextBoxColumn.HeaderText = "neopravnena"
        Me.NeopravnenaDataGridViewTextBoxColumn.Name = "NeopravnenaDataGridViewTextBoxColumn"
        Me.NeopravnenaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NeopravnenaDataGridViewTextBoxColumn.Visible = False
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Stav"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AgenturaDataGridViewTextBoxColumn
        '
        Me.AgenturaDataGridViewTextBoxColumn.DataPropertyName = "agentura"
        Me.AgenturaDataGridViewTextBoxColumn.HeaderText = "Poznámka"
        Me.AgenturaDataGridViewTextBoxColumn.Name = "AgenturaDataGridViewTextBoxColumn"
        Me.AgenturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatumregistraceDataGridViewTextBoxColumn
        '
        Me.DatumregistraceDataGridViewTextBoxColumn.DataPropertyName = "datumregistrace"
        Me.DatumregistraceDataGridViewTextBoxColumn.HeaderText = "Datum registrace"
        Me.DatumregistraceDataGridViewTextBoxColumn.Name = "DatumregistraceDataGridViewTextBoxColumn"
        Me.DatumregistraceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RozbitaDataGridViewTextBoxColumn
        '
        Me.RozbitaDataGridViewTextBoxColumn.DataPropertyName = "rozbita"
        Me.RozbitaDataGridViewTextBoxColumn.HeaderText = "Registraci provedl/la"
        Me.RozbitaDataGridViewTextBoxColumn.Name = "RozbitaDataGridViewTextBoxColumn"
        Me.RozbitaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SatnyTableAdapter
        '
        Me.SatnyTableAdapter.ClearBeforeFill = True
        '
        'neopravnene
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 426)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "neopravnene"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Neoprávněně obsazené šatní skříňky"
        CType(Me.SatnyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._MyDatabase_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents _MyDatabase_1DataSet As VestiarioMng._MyDatabase_1DataSet
    Friend WithEvents SatnyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SatnyTableAdapter As VestiarioMng._MyDatabase_1DataSetTableAdapters.satnyTableAdapter
    Friend WithEvents CislosatnyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JmenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrijmenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdcisloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdkartaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatnanaklicDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatnanavisacizamekDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NeopravnenaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgenturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumregistraceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RozbitaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
