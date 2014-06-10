Public Class editacesatny

    Private Sub editacesatny_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CisloSatnyTextBox.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(0).Value
        JmenoTextBox.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(1).Value
        PrijmeniTextBox.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(2).Value
        OsobniCisloTextBoxt.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(3).Value
        TextBox3.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(4).Value
        TextBox1.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(5).Value
        satnanaklic.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(6).Value
        satnanazamek.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(7).Value

        If satnanaklic.Text = "Ano" Then
            CheckBox4.Checked = True
        Else : satnanaklic.Text = "Ne"
            CheckBox4.Checked = False
        End If

        If satnanazamek.Text = "Ano" Then
            CheckBox5.Checked = True
        Else : satnanazamek.Text = "Ne"
            CheckBox5.Checked = False

        End If


    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            satnanazamek.Text = "Ano"
            satnanaklic.Text = "Ne"
            CheckBox4.Checked = False
        Else : CheckBox5.Checked = False
            satnanazamek.Text = "Ne"
            satnanaklic.Text = "Ano"
            CheckBox4.Checked = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            satnanazamek.Text = "Ne"
            satnanaklic.Text = "Ano"
            CheckBox5.Checked = False
        Else : CheckBox4.Checked = False
            satnanazamek.Text = "Ano"
            satnanaklic.Text = "Ne"
            CheckBox5.Checked = True
        End If
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim poloha As Integer = MainForm.PanskeSatny.CurrentRow.Index
        MainForm.SatnyTableAdapter.UpdateQuery(JmenoTextBox.Text, PrijmeniTextBox.Text, OsobniCisloTextBoxt.Text, _
                                            TextBox3.Text, TextBox1.Text, satnanaklic.Text, satnanazamek.Text, _
                                            Nothing, MainForm.ToolStripStatusLabel2.Text, Stav.Text, Now, CisloSatnyTextBox.Text)
        MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)
        MainForm.PanskeSatny.Rows(poloha).Selected = True
        Me.Close()

        CisloSatnyTextBox.Text = ""
        JmenoTextBox.Text = ""
        PrijmeniTextBox.Text = ""
        OsobniCisloTextBoxt.Text = ""
        TextBox1.Text = ""
        TextBox3.Text = ""
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        satnanaklic.Text = ""
        satnanazamek.Text = ""
    End Sub
End Class