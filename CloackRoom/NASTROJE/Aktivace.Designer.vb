<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aktivace
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
        Me.txtRegistrationStatus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtActivationHardwareId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLicenseKey = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtActivationKey = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRegistrationStatus
        '
        Me.txtRegistrationStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtRegistrationStatus.Location = New System.Drawing.Point(64, 6)
        Me.txtRegistrationStatus.Name = "txtRegistrationStatus"
        Me.txtRegistrationStatus.ReadOnly = True
        Me.txtRegistrationStatus.Size = New System.Drawing.Size(102, 20)
        Me.txtRegistrationStatus.TabIndex = 10
        Me.txtRegistrationStatus.Text = "Aktivováno"
        Me.txtRegistrationStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Status:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtActivationHardwareId)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLicenseKey)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtActivationKey)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 111)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrační data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "HW Klíč:"
        '
        'txtActivationHardwareId
        '
        Me.txtActivationHardwareId.Location = New System.Drawing.Point(130, 76)
        Me.txtActivationHardwareId.Name = "txtActivationHardwareId"
        Me.txtActivationHardwareId.ReadOnly = True
        Me.txtActivationHardwareId.Size = New System.Drawing.Size(234, 20)
        Me.txtActivationHardwareId.TabIndex = 7
        Me.txtActivationHardwareId.Text = "Testovací verze"
        Me.txtActivationHardwareId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Aktivační kód:"
        '
        'txtLicenseKey
        '
        Me.txtLicenseKey.Location = New System.Drawing.Point(130, 24)
        Me.txtLicenseKey.Name = "txtLicenseKey"
        Me.txtLicenseKey.ReadOnly = True
        Me.txtLicenseKey.Size = New System.Drawing.Size(234, 20)
        Me.txtLicenseKey.TabIndex = 5
        Me.txtLicenseKey.Text = "Testovací verze"
        Me.txtLicenseKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Licenční kód:"
        '
        'txtActivationKey
        '
        Me.txtActivationKey.Location = New System.Drawing.Point(130, 50)
        Me.txtActivationKey.Name = "txtActivationKey"
        Me.txtActivationKey.ReadOnly = True
        Me.txtActivationKey.Size = New System.Drawing.Size(234, 20)
        Me.txtActivationKey.TabIndex = 6
        Me.txtActivationKey.Text = "Testovací verze"
        Me.txtActivationKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Aktivace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 155)
        Me.Controls.Add(Me.txtRegistrationStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Aktivace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aktivace"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRegistrationStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtActivationHardwareId As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLicenseKey As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtActivationKey As System.Windows.Forms.TextBox
End Class
