Public Class sulog

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "890331" Then
            TextBox1.Text = Nothing
            administrace.ShowDialog()
            Me.Close()
        Else
            MsgBox("Bylo zadáno špatné heslo", MsgBoxStyle.Critical, "Varování")
        End If
    End Sub

    Private Sub sulog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class