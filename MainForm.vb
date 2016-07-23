Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class MainForm
    Private randomizer As New Random
    Private addend1 As Integer
    Private addend2 As Integer
    Private timeleft As Integer
    Dim Aktualizace As New Trida

    Private Sub KonecToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KonecToolStripMenuItem.Click
        End
    End Sub
    Private Sub OProgramuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OProgramuToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
    Private Sub MainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Tento řádek načte data do tabulky 'Notebooks.ntb'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.NtbTableAdapter.Fill(Me.Notebooks.ntb)
        Me.SatnyTableAdapter.Fill(Me._MyDatabase_1DataSet.satny)
        If PanskeSatny.RowCount = Nothing Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            MsgBox("Nemáte v databázi uložené žádné záznamy. Proveďte registraci nových šatních skříněk", MsgBoxStyle.Critical, "Varování")
        Else

        End If

        Timer1.Enabled = True
        Aktualizace.AktualizaceHodnotMainForm()
        PanskeSatny.ReadOnly = True
        timeleft = 30
        Timer1.Interval = 1000
        ObnovitToolStripMenuItem.Text = "30 s. (F5)"
        Timer1.Start()
        If ToolStripStatusLabel5.Text = "Ano" Then
            Dim admin As String = "(Administrátor)"
            LinkLabel7.Text = ToolStripStatusLabel2.Text & " " & admin
        ElseIf ToolStripStatusLabel5.Text = "Viewer" Then
            Dim viewer As String = "(Viewer)"
            LinkLabel7.Text = ToolStripStatusLabel2.Text & " " & viewer

        ElseIf ToolStripStatusLabel5.Text = "Operator" Then

            Dim beznyuzivatel As String = "(Operátor)"
            LinkLabel7.Text = ToolStripStatusLabel2.Text & " " & beznyuzivatel
        End If
        

    End Sub

    Private Sub TextBox3_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub EditaceŠatenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pridatsatny.ShowDialog()
    End Sub

   
    Private Sub OdhlásitSeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        LoginForm1.Show()
        LoginForm1.login.Text = Nothing
        LoginForm1.heslo.Text = Nothing
        LoginForm1.cteni.Text = Nothing
        LoginForm1.ctenizapis.Text = Nothing
        LoginForm1.UsernameTextBox.Text = Nothing
        LoginForm1.PasswordTextBox.Text = Nothing
    End Sub

   



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If timeleft > 0 Then
            timeleft -= 1
            ObnovitToolStripMenuItem.Text = "" & timeleft & " s. (F5)"
        Else
            Aktualizace.AktualizaceHodnotMainForm()
            Me.SatnyTableAdapter.Fill(Me._MyDatabase_1DataSet.satny)
            timeleft = 30
            Timer1.Interval = 1000
            ObnovitToolStripMenuItem.Text = "30 s. (F5)"
            Timer1.Start()
        End If

    End Sub

    Private Sub ObnovitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObnovitToolStripMenuItem.Click
        Me.SatnyTableAdapter.Fill(Me._MyDatabase_1DataSet.satny)
        Aktualizace.AktualizaceHodnotMainForm()


        timeleft = 31
        Timer1.Interval = 1000
        ObnovitToolStripMenuItem.Text = "30 s. (F5)"
        Timer1.Start()
        If timeleft > 0 Then
            timeleft -= 1
            ObnovitToolStripMenuItem.Text = "" & timeleft & " s. (F5)"

        Else

            Me.SatnyTableAdapter.Fill(Me._MyDatabase_1DataSet.satny)
            Aktualizace.AktualizaceHodnotMainForm()
            timeleft = 30
            Timer1.Interval = 1000
            ObnovitToolStripMenuItem.Text = "30 s. (F5)"
            Timer1.Start()
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        satnanaklicek.Show()
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub PanskeSatny_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        If LinkLabel3.Text = "Vypnout aktualizaci" Then
            Timer1.Stop()
            LinkLabel3.Text = "Zapnout aktualizaci"
            LinkLabel3.Image = ImageList1.Images.Item(8)
        Else : LinkLabel3.Text = ("Zapnout aktualizaci")
            Timer1.Start()
            LinkLabel3.Text = "Vypnout aktualizaci"
            LinkLabel3.Image = ImageList1.Images.Item(9)


        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        neopravnene.Show()
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        rozbitešatny.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        historienew.Show()
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked

        If PanskeSatny.RowCount = Nothing Then
            MsgBox("Statistika nemůže být vygenerována. Nemáte záznamy v databázi", MsgBoxStyle.Critical, "Nelze provést")
        Else
            statistikaloading.ShowDialog()
        End If

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub CollapsiblePanel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        changepassword.Label4.Text = ToolStripStatusLabel6.Text
        changepassword.Label5.Text = ToolStripStatusLabel2.Text
        changepassword.ShowDialog()
    End Sub

    Private Sub LinkLabel10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        administrace.ShowDialog()
    End Sub

    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        pridatsatny.ShowDialog()
    End Sub

    Private Sub LinkLabel11_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)


    End Sub

    Private Sub LinkLabel11_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        Dim dotaz As String
        Dim satna As Object = PanskeSatny.SelectedRows.Item(0).Cells(0).Value
        dotaz = MsgBox("Chcete odstranit šatní skříňku č. " & satna & " ?", MsgBoxStyle.YesNo, "Dotaz")

        If dotaz = vbYes Then
            Me.SatnyTableAdapter.DeleteQuery(Me.PanskeSatny.SelectedRows.Item(0).Cells(0).Value)
            Me.SatnyTableAdapter.Fill(Me._MyDatabase_1DataSet.satny)
            MsgBox("Šatna č. " & satna & " byla vymazána.", MsgBoxStyle.Information, "Odstraněno")
        End If
        If dotaz = vbNo Then
            MsgBox("Akce byla zrušena uživatelem.", MsgBoxStyle.Information, "Storno")
        End If
        
    End Sub

    Private Sub AktivaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AktivaceToolStripMenuItem.Click
        Aktivace.ShowDialog()
    End Sub

    Private Sub AktualizaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AktualizaceToolStripMenuItem.Click
        MsgBox("Nejsou dostupné ždáné aktualizace", MsgBoxStyle.Information, "Aktualizace")
    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        users.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim status As String = ToolStripStatusLabel4.Text
        If ToolStripStatusLabel4.Text = "Volná" Then
            reigstracesatny.ShowDialog()
        Else : MsgBox("Nemůžete registrovat šatní skříňku se statusem " & status & "", MsgBoxStyle.Information, "Pozor!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim status As String = ToolStripStatusLabel4.Text
        If ToolStripStatusLabel4.Text = "Obsazená" Then
            uvolnitsatnu.ShowDialog()
        Else : MsgBox("Nemůžete uvolnit šatní skříňku se statusem " & status & "", MsgBoxStyle.Information, "Pozor!")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim status As String = ToolStripStatusLabel4.Text
        Dim statusskrinky As String = "Volná"
        Dim poloha As Integer = PanskeSatny.CurrentRow.Index

        If Button3.Text = "Uvolnění" Then
            Dim cisloskrinky As String = Me.PanskeSatny.SelectedRows.Item(0).Cells(0).Value
            Dim rozhodnuti As String
            rozhodnuti = MsgBox("Opravdu byla šatní skříňka č. " & cisloskrinky & " uvolněna?", MsgBoxStyle.YesNo, "Dotaz")
            If rozhodnuti = vbYes Then
                Me.SatnyTableAdapter.UpdateQuery(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Me.ToolStripStatusLabel2.Text, statusskrinky, Now, cisloskrinky)
                Me.SatnyTableAdapter.Fill(Me._MyDatabase_1DataSet.satny)
                PanskeSatny.Rows(poloha).Selected = True
                MsgBox("Šatní skříňka byla uvolněna", MsgBoxStyle.Information, "Akce")
                Button3.Text = "Neoprávněná"
                Aktualizace.AktualizaceHodnotMainForm()
            End If
            If rozhodnuti = vbNo Then
                MsgBox("Akce zrušena uživatelem.", MsgBoxStyle.Information, "Akce zrušena")
            End If
        Else : Button3.Text = "Uvolnění"
            Dim neopravnena As String = "Neoprávněná"
            Dim cisloskrinky As String = Me.PanskeSatny.SelectedRows.Item(0).Cells(0).Value
            Me.SatnyTableAdapter.UpdateQuery(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Me.ToolStripStatusLabel2.Text, neopravnena, Now, cisloskrinky)
            Me.SatnyTableAdapter.Fill(Me._MyDatabase_1DataSet.satny)
            PanskeSatny.Rows(poloha).Selected = True
            MsgBox("Šatní skříňka č. " & cisloskrinky & " byla zařazena jako neoprávněná", MsgBoxStyle.Information, "Zařazeno")
            Aktualizace.AktualizaceHodnotMainForm()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'zařazení rozbité skříňky
        'proměnné
        Dim poloha As Integer = PanskeSatny.CurrentRow.Index 'Proměná pro nastavení aktuálního řádku po editaci
        Dim status As String = ToolStripStatusLabel4.Text 'přenesení čísla vybrané skříňky na nový dialog
        Dim statusskrinky As String = "Volná" 'nelze otevřít pokud má skříňka status Volná


        If Button4.Text = "Opravená" Then 'podmínka

            Dim cisloskrinky As String
            Dim rozhodnuti As String
            Dim volnaskrinka As String = "Volná"
            cisloskrinky = Me.PanskeSatny.SelectedRows.Item(0).Cells(0).Value
            rozhodnuti = MsgBox("Opravdu byla šatní skříňka č. " & cisloskrinky & " opravena?", MsgBoxStyle.YesNo, "Dotaz")

            If rozhodnuti = vbYes Then
                Me.SatnyTableAdapter.UpdateQuery(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
                                                 Nothing, Nothing, Me.ToolStripStatusLabel2.Text, volnaskrinka, Now, cisloskrinky) 'volání SQL
                Me.SatnyTableAdapter.Fill(Me._MyDatabase_1DataSet.satny) 'refresh databáze
                PanskeSatny.Rows(poloha).Selected = True

                Button4.Text = "Opravená"
                Aktualizace.AktualizaceHodnotMainForm() 'volačka metody v třídě
            End If
            If rozhodnuti = vbNo Then
                MsgBox("Akce zrušena uživatelem", MsgBoxStyle.Information, "Akce")
            End If
        Else : Button4.Text = "Rozbitá"
            rozbitasatna.ShowDialog()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim status As String = ToolStripStatusLabel4.Text
        If ToolStripStatusLabel4.Text = "Obsazená" Then
            editacesatny.ShowDialog()
        ElseIf ToolStripStatusLabel4.Text = "Neoprávněná" Then
            poznamka_edit.ShowDialog()
        Else : MsgBox("Nemůžete editovat šatní skříňku se statusem " & status & "", MsgBoxStyle.Information, "Pozor!")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim status As String = ToolStripStatusLabel4.Text
        If ToolStripStatusLabel4.Text = "Obsazená" Then
            PresunOsoby.ShowDialog()
        Else : MsgBox("Nelze přesunout se statusem " & status & ".", MsgBoxStyle.Information, "Pozor!")
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        TextBox4.Text = Nothing
        If TextBox1.Text = Nothing Then
            Me.SatnyBindingSource.Filter = Nothing
        Else
            Dim SCode As String = "%" + TextBox1.Text.ToString + "%"
            Me.SatnyBindingSource.Filter = " idcislo LIKE '" & SCode & "'"
        End If
    End Sub

    Private Sub TextBox2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox1.Text = Nothing
        TextBox3.Text = Nothing
        TextBox4.Text = Nothing
        If TextBox2.Text = Nothing Then
            Me.SatnyBindingSource.Filter = Nothing
        Else
            Dim SCode As String = "%" + TextBox2.Text.ToString + "%"
            Me.SatnyBindingSource.Filter = " idkarta LIKE '" & SCode & "'"
        End If
    End Sub

    Private Sub TextBox3_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox4.Text = Nothing
        If TextBox3.Text = Nothing Then
            Me.SatnyBindingSource.Filter = Nothing
        Else
            Dim SCode As String = "%" + TextBox3.Text.ToString + "%"
            Me.SatnyBindingSource.Filter = " cislosatny LIKE '" & SCode & "'"
        End If
    End Sub

    Private Sub TextBox4_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        If TextBox4.Text = Nothing Then
            Me.SatnyBindingSource.Filter = Nothing
        Else
            Dim SCode As String = "%" + TextBox4.Text.ToString + "%"
            Me.SatnyBindingSource.Filter = " prijmeno LIKE '" & SCode & "'"
        End If
    End Sub

    Private Sub PanskeSatny_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PanskeSatny.CellContentClick

    End Sub

    Private Sub PanskeSatny_MouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanskeSatny.MouseClick
        If PanskeSatny.RowCount = Nothing Then
            MsgBox("Zaregistrujte šatní skříňky do databáze", MsgBoxStyle.Information, "Vyžadována registrace")

        Else
            ToolStripStatusLabel3.Text = Me.PanskeSatny.SelectedRows.Item(0).Cells(0).Value
            ToolStripStatusLabel4.Text = Me.PanskeSatny.SelectedRows.Item(0).Cells(9).Value
            Dim neopravnena As String = ToolStripStatusLabel4.Text = "Neoprávněná"
            Dim rozbita As String = ToolStripStatusLabel4.Text = "Rozbitá"
            If rozbita Then
                Button4.Text = "Opravená"
            Else : Button4.Text = "Rozbitá"
            End If

            If neopravnena Then
                Button3.Text = "Uvolnění"
            Else : Button3.Text = "Neoprávněná"
            End If
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        registracentb.ShowDialog()
    End Sub

    Private Sub CollapsiblePanelBar1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles CollapsiblePanelBar1.Paint

    End Sub
End Class
