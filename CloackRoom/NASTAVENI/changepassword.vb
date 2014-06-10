Public Class changepassword

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = Label4.Text Then
            Label1.ForeColor = Color.Green

        Else
            Label1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = TextBox2.Text Then
            Label2.ForeColor = Color.Green
            Label3.ForeColor = Color.Green

        Else
            Label2.ForeColor = Color.Red
            Label3.ForeColor = Color.Red
        End If
    End Sub

    Private Sub changepassword_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        Label4.Text = Nothing
        Label5.Text = Nothing
    End Sub

    Private Sub changepassword_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        Label4.Text = Nothing
        Label5.Text = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = Label4.Text And Label1.ForeColor = Color.Green Then
            If TextBox2.Text = TextBox3.Text And Label2.ForeColor = Color.Green And Label3.ForeColor = Color.Green Then
                Dim noveheslo As String = TextBox3.Text
                Label4.Text = noveheslo

                users.UzivateleTableAdapter.UpdateQueryHeslo(Label4.Text, Label5.Text)
                users.UzivateleTableAdapter.Fill(users._MyDatabase_1DataSet1.Uzivatele)
                LoginForm1.UzivateleTableAdapter.Fill(LoginForm1._MyDatabase_1DataSet1.Uzivatele)

                MsgBox("Vaše nové heslo bylo úspěšně změněno. Změna se projeví při dalším přihlášení.", MsgBoxStyle.Information, "Uspěšná změna hesla")
                Me.Close()
            Else
                MsgBox("Nová hesla se neshodují!!!", MsgBoxStyle.Critical, "Varování!")

            End If
        Else
            MsgBox("Původní heslo nebylo správně zadáno!!!", MsgBoxStyle.Critical, "Varování!")

        End If
    End Sub
End Class