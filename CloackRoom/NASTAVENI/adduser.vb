Public Class adduser

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Enabled = False
            ctenizapis.Text = "Ano"
            cteni.Text = "Ne"
            CheckBox3.Enabled = True
            Button1.Enabled = True
        Else : CheckBox2.Enabled = True
            Button1.Enabled = False
            CheckBox3.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Enabled = False
            ctenizapis.Text = "Ne"
            cteni.Text = "Ano"
            Button1.Enabled = True
            CheckBox3.Enabled = False
        Else : CheckBox1.Enabled = True
            Button1.Enabled = False
            CheckBox3.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub adduser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        admin.Text = "Ne"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        users.UzivateleTableAdapter.InsertQuery(TextBox1.Text, TextBox2.Text, cteni.Text, ctenizapis.Text, admin.Text)
        users.UzivateleTableAdapter.Fill(users._MyDatabase_1DataSet1.Uzivatele)
        LoginForm1.UzivateleTableAdapter.Fill(LoginForm1._MyDatabase_1DataSet1.Uzivatele)
        LoginForm1.UsernameTextBox.Refresh()
        MsgBox("Uživatel " & TextBox1.Text & " byl uložen do databáze.", MsgBoxStyle.Information, "Úspěšné uložení")
        Me.Close()
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            admin.Text = "Ano"

        ElseIf CheckBox3.Checked = False Then
            admin.Text = "Ne"
        End If
    End Sub
End Class