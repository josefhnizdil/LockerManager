Public Class uvolnitsatnu
    Dim aktualizace As New Trida


    Private Sub uvolnitsatnu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CisloSatnyTextBox.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(0).Value
        JmenoTextBox.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(1).Value
        PrijmeniTextBox.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(2).Value
        OsobniCisloTextBoxt.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(3).Value
        TextBox3.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(4).Value
        TextBox1.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(5).Value
        labelklicek.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(6).Value
        labelzamek.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(7).Value
        If labelklicek.Text = "Ano" Then
            CheckBox1.Enabled = True
            CheckBox4.Checked = True
            CheckBox5.Checked = False
            vracenyklicek.Text = "Nevrácen"
        Else : labelklicek.Text = "Ne"
            CheckBox5.Checked = True
            CheckBox4.Checked = False
            CheckBox1.Enabled = False
            vracenyklicek.Text = "Nebyl vydán"

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim poloha As Integer = MainForm.PanskeSatny.CurrentRow.Index
        Dim stav As String = "Uvolněná"
        Dim volna As String = "Volná"
        MainForm.SatnyTableAdapter.UpdateQuery(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
                                               Nothing, Nothing, volna, Nothing, CisloSatnyTextBox.Text)
        MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)
        '----------------------------------------Uložení do hlavní databáze-----------------------------------

        '----------------------------------------Zápis do historie--------------------------------------------

        historienew.HistoriesatenTableAdapter.InsertQueryHistory(CisloSatnyTextBox.Text, JmenoTextBox.Text, _
                                                                 PrijmeniTextBox.Text, OsobniCisloTextBoxt.Text, _
                                                                 TextBox3.Text, MainForm.ToolStripStatusLabel2.Text, vracenyklicek.Text, labelzamek.Text, Now)
        historienew.HistoriesatenTableAdapter.Fill(historienew._MyDatabase_1DataSet2.historiesaten)
        MainForm.PanskeSatny.Rows(poloha).Selected = True
        '-----------------------------------------vymazání polí-------------------------------------
        aktualizace.AktualizaceHodnotMainForm()

        Me.Close()
        JmenoTextBox.Text = ""
        PrijmeniTextBox.Text = ""
        OsobniCisloTextBoxt.Text = ""
        TextBox1.Text = ""
        TextBox3.Text = ""
        CheckBox1.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False





    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Button1.Enabled = True
        Else : CheckBox3.Checked = False
            Button1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            vracenyklicek.Text = "Byl vrácen"
        Else : CheckBox1.Checked = False
            vracenyklicek.Text = "Nevrácen"
        End If

    End Sub
End Class