Public Class updatedatabases

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "MA" Then
            Label1.Text = MainForm.SatnyTableAdapter.Panskesatny_MA_Celkem
        ElseIf ComboBox1.Text = "ZA" Then
            Label1.Text = MainForm.SatnyTableAdapter.Damskesatny_ZA_celkem

        ElseIf ComboBox1.Text = "ZB" Then
            Label1.Text = MainForm.SatnyTableAdapter.Damskesatny_ZB_celkem
        ElseIf ComboBox1.Text = "ZD" Then
            Label1.Text = MainForm.SatnyTableAdapter.Damskesatny_ZD_celkem
        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For pridat As Integer = 1 To Label1.Text
            Dim kombinace As String
            kombinace = ComboBox1.Text & " " & pridat
            MainForm.SatnyTableAdapter.UpdateQueryKliceNon(kombinace)

        Next
    End Sub
End Class