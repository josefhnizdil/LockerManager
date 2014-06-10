Public Class LoginForm1

 

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        login.Text = Me.DataGridView1.SelectedRows.Item(0).Cells(0).Value
        heslo.Text = Me.DataGridView1.SelectedRows.Item(0).Cells(1).Value
        cteni.Text = Me.DataGridView1.SelectedRows.Item(0).Cells(2).Value
        ctenizapis.Text = Me.DataGridView1.SelectedRows.Item(0).Cells(3).Value
        admin.Text = Me.DataGridView1.SelectedRows.Item(0).Cells(4).Value

        If login.Text = UsernameTextBox.Text And heslo.Text = PasswordTextBox.Text Then
            MainForm.ToolStripStatusLabel6.Text = heslo.Text
            MainForm.ToolStripStatusLabel2.Text = login.Text
            If cteni.Text = "Ano" Then
                MainForm.Button1.Enabled = False
                MainForm.Button2.Enabled = False
                MainForm.Button3.Enabled = False
                MainForm.Button4.Enabled = False
                MainForm.Button5.Enabled = False
                MainForm.Button6.Enabled = False
                MainForm.LinkLabel1.Enabled = False
                MainForm.LinkLabel3.Enabled = False
                MainForm.LinkLabel2.Enabled = False
                MainForm.LinkLabel6.Enabled = False
                MainForm.LinkLabel8.Enabled = False
                MainForm.LinkLabel9.Enabled = False
                MainForm.LinkLabel10.Enabled = False
                MainForm.LinkLabel11.Enabled = False

                MainForm.ToolStripStatusLabel5.Text = "Viewer"
            End If
            If ctenizapis.Text = "Ano" And admin.Text = "Ne" Then

                MainForm.LinkLabel8.Enabled = False
                MainForm.LinkLabel9.Enabled = False
                MainForm.LinkLabel10.Enabled = False
                MainForm.LinkLabel11.Enabled = False
                MainForm.ToolStripStatusLabel5.Text = "Operator"
            End If
            If admin.Text = "Ano" Then

                MainForm.ToolStripStatusLabel5.Text = "Ano"
            End If
            login.Text = Nothing
            heslo.Text = Nothing
            cteni.Text = Nothing
            ctenizapis.Text = Nothing
            MainForm.Show()
            Me.Hide()
        Else
            MsgBox("Zdali jste špatné heslo!!", MsgBoxStyle.Critical, "Upozornění!")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      


        'TODO: This line of code loads data into the '_MyDatabase_1DataSet1.Uzivatele' table. You can move, or remove it, as needed.
        Me.UzivateleTableAdapter.Fill(Me._MyDatabase_1DataSet1.Uzivatele)
        UsernameTextBox.Text = Nothing


    End Sub
    Private Sub UsernameTextBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.SelectedIndexChanged
        Dim SCode As String = "%" + UsernameTextBox.Text.ToString + "%"
        Me.UzivateleBindingSource.Filter = " login LIKE '" & SCode & "'"
    End Sub
    Private Sub LToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LToolStripMenuItem.Click
        sulog.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub UživateleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UživateleToolStripMenuItem.Click
        users.ShowDialog()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
