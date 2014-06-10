<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm1))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LoginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HesloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CteniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZapiscteniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UzivateleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._MyDatabase_1DataSet1 = New VestiarioMng._MyDatabase_1DataSet1()
        Me.UzivateleTableAdapter = New VestiarioMng._MyDatabase_1DataSet1TableAdapters.UzivateleTableAdapter()
        Me.heslo = New System.Windows.Forms.Label()
        Me.cteni = New System.Windows.Forms.Label()
        Me.ctenizapis = New System.Windows.Forms.Label()
        Me.login = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.ComboBox()
        Me.admin = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UživateleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SatnyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UzivateleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._MyDatabase_1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(10, 73)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Uživatelské jméno"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(10, 122)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Heslo"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(13, 148)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(13, 174)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(139, 174)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VestiarioMng.My.Resources.Resources.lista_horni_login
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 70)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoginDataGridViewTextBoxColumn, Me.HesloDataGridViewTextBoxColumn, Me.CteniDataGridViewTextBoxColumn, Me.ZapiscteniDataGridViewTextBoxColumn, Me.AdminDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UzivateleBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 243)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(190, 91)
        Me.DataGridView1.TabIndex = 7
        '
        'LoginDataGridViewTextBoxColumn
        '
        Me.LoginDataGridViewTextBoxColumn.DataPropertyName = "login"
        Me.LoginDataGridViewTextBoxColumn.HeaderText = "login"
        Me.LoginDataGridViewTextBoxColumn.Name = "LoginDataGridViewTextBoxColumn"
        Me.LoginDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HesloDataGridViewTextBoxColumn
        '
        Me.HesloDataGridViewTextBoxColumn.DataPropertyName = "heslo"
        Me.HesloDataGridViewTextBoxColumn.HeaderText = "heslo"
        Me.HesloDataGridViewTextBoxColumn.Name = "HesloDataGridViewTextBoxColumn"
        Me.HesloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CteniDataGridViewTextBoxColumn
        '
        Me.CteniDataGridViewTextBoxColumn.DataPropertyName = "cteni"
        Me.CteniDataGridViewTextBoxColumn.HeaderText = "cteni"
        Me.CteniDataGridViewTextBoxColumn.Name = "CteniDataGridViewTextBoxColumn"
        Me.CteniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ZapiscteniDataGridViewTextBoxColumn
        '
        Me.ZapiscteniDataGridViewTextBoxColumn.DataPropertyName = "zapiscteni"
        Me.ZapiscteniDataGridViewTextBoxColumn.HeaderText = "zapiscteni"
        Me.ZapiscteniDataGridViewTextBoxColumn.Name = "ZapiscteniDataGridViewTextBoxColumn"
        Me.ZapiscteniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdminDataGridViewTextBoxColumn
        '
        Me.AdminDataGridViewTextBoxColumn.DataPropertyName = "admin"
        Me.AdminDataGridViewTextBoxColumn.HeaderText = "admin"
        Me.AdminDataGridViewTextBoxColumn.Name = "AdminDataGridViewTextBoxColumn"
        Me.AdminDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UzivateleBindingSource
        '
        Me.UzivateleBindingSource.DataMember = "Uzivatele"
        Me.UzivateleBindingSource.DataSource = Me._MyDatabase_1DataSet1
        '
        '_MyDatabase_1DataSet1
        '
        Me._MyDatabase_1DataSet1.DataSetName = "_MyDatabase_1DataSet1"
        Me._MyDatabase_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UzivateleTableAdapter
        '
        Me.UzivateleTableAdapter.ClearBeforeFill = True
        '
        'heslo
        '
        Me.heslo.AutoSize = True
        Me.heslo.Location = New System.Drawing.Point(47, 337)
        Me.heslo.Name = "heslo"
        Me.heslo.Size = New System.Drawing.Size(32, 13)
        Me.heslo.TabIndex = 9
        Me.heslo.Text = "heslo"
        '
        'cteni
        '
        Me.cteni.AutoSize = True
        Me.cteni.Location = New System.Drawing.Point(85, 337)
        Me.cteni.Name = "cteni"
        Me.cteni.Size = New System.Drawing.Size(30, 13)
        Me.cteni.TabIndex = 10
        Me.cteni.Text = "cteni"
        '
        'ctenizapis
        '
        Me.ctenizapis.AutoSize = True
        Me.ctenizapis.Location = New System.Drawing.Point(121, 337)
        Me.ctenizapis.Name = "ctenizapis"
        Me.ctenizapis.Size = New System.Drawing.Size(54, 13)
        Me.ctenizapis.TabIndex = 11
        Me.ctenizapis.Text = "ctenizapis"
        '
        'login
        '
        Me.login.AutoSize = True
        Me.login.Location = New System.Drawing.Point(12, 337)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(29, 13)
        Me.login.TabIndex = 12
        Me.login.Text = "login"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataSource = Me._MyDatabase_1DataSet1
        Me.UsernameTextBox.DisplayMember = "Uzivatele.login"
        Me.UsernameTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UsernameTextBox.FormattingEnabled = True
        Me.UsernameTextBox.Location = New System.Drawing.Point(13, 99)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 21)
        Me.UsernameTextBox.TabIndex = 13
        Me.UsernameTextBox.Tag = ""
        '
        'admin
        '
        Me.admin.AutoSize = True
        Me.admin.Location = New System.Drawing.Point(181, 337)
        Me.admin.Name = "admin"
        Me.admin.Size = New System.Drawing.Size(35, 13)
        Me.admin.TabIndex = 15
        Me.admin.Text = "admin"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(393, 122)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(46, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LToolStripMenuItem, Me.UživateleToolStripMenuItem, Me.SatnyToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'LToolStripMenuItem
        '
        Me.LToolStripMenuItem.Name = "LToolStripMenuItem"
        Me.LToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.LToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.LToolStripMenuItem.Text = "l"
        '
        'UživateleToolStripMenuItem
        '
        Me.UživateleToolStripMenuItem.Name = "UživateleToolStripMenuItem"
        Me.UživateleToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UživateleToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.UživateleToolStripMenuItem.Text = "uživatele"
        '
        'SatnyToolStripMenuItem
        '
        Me.SatnyToolStripMenuItem.Name = "SatnyToolStripMenuItem"
        Me.SatnyToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SatnyToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SatnyToolStripMenuItem.Text = "satny"
        '
        'LoginForm1
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(238, 208)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.admin)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.ctenizapis)
        Me.Controls.Add(Me.cteni)
        Me.Controls.Add(Me.heslo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Přihlášení uživatele"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UzivateleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._MyDatabase_1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents _MyDatabase_1DataSet1 As VestiarioMng._MyDatabase_1DataSet1
    Friend WithEvents UzivateleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UzivateleTableAdapter As VestiarioMng._MyDatabase_1DataSet1TableAdapters.UzivateleTableAdapter
    Friend WithEvents heslo As System.Windows.Forms.Label
    Friend WithEvents cteni As System.Windows.Forms.Label
    Friend WithEvents ctenizapis As System.Windows.Forms.Label
    Friend WithEvents login As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents admin As System.Windows.Forms.Label
    Friend WithEvents LoginDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HesloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CteniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZapiscteniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdminDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents LToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UživateleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SatnyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
