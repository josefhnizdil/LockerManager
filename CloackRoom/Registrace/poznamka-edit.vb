Public Class poznamka_edit

    Private Sub poznamka_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CisloSatnyTextBox.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(0).Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim poloha As Integer = MainForm.PanskeSatny.CurrentRow.Index
        Dim status As String = "Neoprávněná"
        MainForm.SatnyTableAdapter.UpdateQuery(Nothing, Nothing, Nothing, Nothing, TextBox1.Text, Nothing, _
                                                Nothing, Nothing, MainForm.ToolStripStatusLabel2.Text, status, Now, CisloSatnyTextBox.Text)
        MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)
        MainForm.PanskeSatny.Rows(poloha).Selected = True
        MsgBox("Poznámka byla uložena.", MsgBoxStyle.Information, "Uloženo")
        TextBox1.Text = Nothing
        CisloSatnyTextBox.Text = Nothing
        Me.Close()
    End Sub
End Class