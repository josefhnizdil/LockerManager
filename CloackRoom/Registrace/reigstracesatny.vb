Public Class reigstracesatny
    Dim aktualizace As New Trida
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox5.Enabled = False
            satnastatus1.Text = "Ano"
            satnastatus2.Text = "Ne"
            Button1.Enabled = True
        Else : CheckBox5.Enabled = True
            satnastatus1.Text = ""
            satnastatus2.Text = ""
            Button1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox4.Enabled = False
            satnastatus1.Text = "Ne"
            satnastatus2.Text = "Ano"
            Button1.Enabled = True
        Else : CheckBox4.Enabled = True
            satnastatus1.Text = ""
            satnastatus2.Text = ""
            Button1.Enabled = False
        End If
    End Sub

    Private Sub reigstracesatny_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CisloSatnyTextBox.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(0).Value
       
        'CheckBox1.Checked = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(12).Value

        If CheckBox1.Checked = True Then

            PictureBox1.Image = My.Resources._1368022240_111039

        Else
            PictureBox1.Image = My.Resources._1368022253_103178

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim poloha As Integer = MainForm.PanskeSatny.CurrentRow.Index
        Me.SatnyTableAdapter1.UpdateQuery(JmenoTextBox.Text, PrijmeniTextBox.Text, OsobniCisloTextBoxt.Text, _
                                          TextBox3.Text, TextBox1.Text, satnastatus1.Text, satnastatus2.Text, Nothing, _
                                          MainForm.ToolStripStatusLabel2.Text, Stav.Text, Now, CisloSatnyTextBox.Text)
        MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)
        MainForm.PanskeSatny.Rows(poloha).Selected = True
        aktualizace.AktualizaceHodnotMainForm()
        Me.Close()
        JmenoTextBox.Text = ""
        PrijmeniTextBox.Text = ""
        OsobniCisloTextBoxt.Text = ""
        TextBox1.Text = ""
        TextBox3.Text = ""
        CheckBox4.Checked = False
        CheckBox5.Checked = False

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub registracesatny_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CheckBox1.Checked = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class