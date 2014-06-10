Public Class PresunOsoby
    Dim Aktualizace As New Trida

    Private Sub PresunOsoby_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        presundo.Text = Nothing
        Aktualizace.AktualizaceHodnotMainForm()
    End Sub

    Private Sub PresunOsoby_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_MyDatabase_1DataSet.satny' table. You can move, or remove it, as needed.
        Me.SatnyTableAdapter.Fill(Me._MyDatabase_1DataSet.satny)
        CisloSatnyTextBox.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(0).Value
        TextBox2.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(1).Value
        TextBox3.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(2).Value
        TextBox4.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(3).Value
        TextBox1.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(6).Value
        Me.Label8.Text = Nothing
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label8.Text = Me.DataGridView1.SelectedRows.Item(0).Cells(10).Value
    End Sub

    Private Sub Label8_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.TextChanged
        If Label8.Text = "Volná" Then

            Label8.BackColor = Color.Green
            Label8.ForeColor = Color.White

            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True

        ElseIf Label8.Text = "Neoprávněná" Then
            Label8.BackColor = Color.Orange
            Label8.ForeColor = Color.Black
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            MsgBox("Šatní skříňka je neoprvávněně obsazená, nelze přesunout", MsgBoxStyle.Information, "Pozor")
        ElseIf Label8.Text = "Rozbitá" Then
            Label8.BackColor = Color.Red
            Label8.ForeColor = Color.White
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            MsgBox("Šatní skříňka je rozbitá, nelze přesunout", MsgBoxStyle.Information, "Pozor")
        ElseIf Label8.Text = "Obsazená" Then
            Label8.ForeColor = Color.White
            Label8.BackColor = Color.Black
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            MsgBox("Šatní skříňka je již obsazená, nelze přesunout", MsgBoxStyle.Information, "Pozor")
        Else : Label8.Text = ""
            Label8.BackColor = Color.Gray
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True

        Else : CheckBox1.Checked = False
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
        Else : CheckBox2.Checked = False
            CheckBox1.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True

        Else : CheckBox3.Checked = False
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox5.Enabled = False
            Button1.Enabled = True
        Else : CheckBox4.Checked = False
            CheckBox5.Enabled = True
            Button1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox4.Enabled = False
            Button1.Enabled = True
        Else : CheckBox5.Checked = False
            CheckBox4.Enabled = True
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim poloha As Integer = MainForm.PanskeSatny.CurrentRow.Index
        Dim stav_rozbita As String = "Rozbitá"
        Dim stav_neopravnena As String = "Neoprávněná"
        Dim stav_volna As String = "Volná"
        Dim stav_obsazená As String = "Obsazená"
        Dim nova_skrinka_klic As String = "Ano"
        Dim nova_skrinka_kliceN As String = "Ne"
        Dim nova_skrinka_zamek As String = "Ano"
        Dim nova_skrinka_zamekN As String = "Ne"
        Dim ID As String = String.Empty
        Dim idpodminka As Object = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(4).Value

        Dim nic As String = String.Empty
        Dim nicpodminka As Object = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(5).Value
        If nicpodminka Is Nothing Then
            nic = ""
        Else
            nic = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(5).Value
        End If

        If idpodminka Is Nothing Then
            ID = ""
        Else
            ID = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(4).Value
        End If



        'Stara šatna je volná a nová je na klíč nebo na zámek
        If CheckBox1.Checked = True Then
            Me.SatnyTableAdapter.UpdateQuery(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
                                             Nothing, Nothing, MainForm.ToolStripStatusLabel2.Text, stav_volna, Now, CisloSatnyTextBox.Text)
            MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)
            MainForm.PanskeSatny.Rows(poloha).Selected = True
            Aktualizace.AktualizaceHodnotMainForm()
            If CheckBox4.Checked = True Then
                Me.SatnyTableAdapter.UpdateQuery(TextBox2.Text, TextBox3.Text, TextBox4.Text, ID, nic, _
                                                 nova_skrinka_klic, nova_skrinka_zamekN, Nothing, MainForm.ToolStripStatusLabel2.Text, _
                stav_obsazená, Now, presundo.Text)
                MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)
                MainForm.PanskeSatny.Rows(poloha).Selected = True
                Aktualizace.AktualizaceHodnotMainForm()
                MsgBox("Šatní skříňka byla úspěšně změněna.", MsgBoxStyle.Information, "Přesunuto")
                Me.Close()
                'klíček

            ElseIf CheckBox5.Checked = True Then
                Me.SatnyTableAdapter.UpdateQuery(TextBox2.Text, TextBox3.Text, TextBox4.Text, ID, nic, _
                                                 nova_skrinka_kliceN, nova_skrinka_zamek, Nothing, MainForm.ToolStripStatusLabel2.Text, _
                                                 stav_obsazená, Now, presundo.Text)
                MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)
                MainForm.PanskeSatny.Rows(poloha).Selected = True
                Aktualizace.AktualizaceHodnotMainForm()
                MsgBox("Šatní skříňka byla úspěšně změněna.", MsgBoxStyle.Information, "Přesunuto")
                Me.Close()
                'zámek

            End If


            'stará šatna je neoprávněná nová je na klíč nebo na zámek
        ElseIf CheckBox2.Checked = True Then
            Me.SatnyTableAdapter.UpdateQuery(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
                                             Nothing, Nothing, MainForm.ToolStripStatusLabel2.Text, stav_neopravnena, Now, CisloSatnyTextBox.Text)
            MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)
            MainForm.PanskeSatny.Rows(poloha).Selected = True
         Aktualizace.AktualizaceHodnotMainForm()
            If CheckBox4.Checked = True Then
                Me.SatnyTableAdapter.UpdateQuery(TextBox2.Text, TextBox3.Text, TextBox4.Text, ID, nic, _
                                                 nova_skrinka_klic, nova_skrinka_zamekN, Nothing, MainForm.ToolStripStatusLabel2.Text, _
                stav_obsazená, Now, presundo.Text)
                MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)
                MainForm.PanskeSatny.Rows(poloha).Selected = True
                MsgBox("Šatní skříňka byla úspěšně změněna.", MsgBoxStyle.Information, "Přesunuto")
                Me.Close()
                ' nová na klíč
               Aktualizace.AktualizaceHodnotMainForm()
            ElseIf CheckBox5.Checked = True Then
                Me.SatnyTableAdapter.UpdateQuery(TextBox2.Text, TextBox3.Text, TextBox4.Text, ID, nic, _
                                                 nova_skrinka_kliceN, nova_skrinka_zamek, Nothing, MainForm.ToolStripStatusLabel2.Text, _
                                                 stav_obsazená, Now, presundo.Text)
                MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)
                MainForm.PanskeSatny.Rows(poloha).Selected = True
                MsgBox("Šatní skříňka byla úspěšně změněna.", MsgBoxStyle.Information, "Přesunuto")
                Me.Close()
                ' nová na zámek
                Aktualizace.AktualizaceHodnotMainForm()
            End If
        ElseIf CheckBox3.Checked = True Then
            rozbitasatna.ShowDialog()
            If CheckBox4.Checked = True Then
                Me.SatnyTableAdapter.UpdateQuery(TextBox2.Text, TextBox3.Text, TextBox4.Text, ID, nic, _
                                                 nova_skrinka_klic, nova_skrinka_zamekN, Nothing, MainForm.ToolStripStatusLabel2.Text, _
                stav_obsazená, Now, presundo.Text)
                MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)
                MainForm.PanskeSatny.Rows(poloha).Selected = True
             Aktualizace.AktualizaceHodnotMainForm()
                MsgBox("Šatní skříňka byla úspěšně změněna.", MsgBoxStyle.Information, "Přesunuto")
                Me.Close()
                ' nová na klíč
              Aktualizace.AktualizaceHodnotMainForm()

            ElseIf CheckBox5.Checked = True Then
                Me.SatnyTableAdapter.UpdateQuery(TextBox2.Text, TextBox3.Text, TextBox4.Text, ID, nic, _
                                                 nova_skrinka_kliceN, nova_skrinka_zamek, Nothing, MainForm.ToolStripStatusLabel2.Text, _
                                                 stav_obsazená, Now, presundo.Text)
                MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)
                MainForm.PanskeSatny.Rows(poloha).Selected = True
                MsgBox("Šatní skříňka byla úspěšně změněna.", MsgBoxStyle.Information, "Přesunuto")
                Me.Close()
               Aktualizace.AktualizaceHodnotMainForm()
                ' nová na zámek
            End If

        End If










    End Sub

    Private Sub presundo_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles presundo.TextChanged
        Dim SCode As String = "%" + presundo.Text.ToString + "%"
        Me.SatnyBindingSource.Filter = " cislosatny LIKE '" & SCode & "'"
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
End Class