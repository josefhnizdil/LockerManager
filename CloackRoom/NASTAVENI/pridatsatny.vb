Public Class pridatsatny
    Dim zapis As New Trida
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Enabled = False
            TextBox1.Enabled = True
            Button1.Enabled = True
        Else
            CheckBox2.Enabled = True
            TextBox1.Enabled = False
            Button1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Enabled = False
            Label4.Enabled = True
            Label3.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            Button2.Enabled = True
        Else
            CheckBox1.Enabled = True
            Label4.Enabled = False
            Label3.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ProgressBar1.Visible = True
        panske.Start()
        zapis.registracesatenstart()
        


    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            TextBox6.Enabled = True
            Button4.Enabled = True
            CheckBox3.Enabled = False
        Else
            TextBox6.Enabled = False
            Button4.Enabled = False
            CheckBox3.Enabled = True
        End If



    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox4.Enabled = False
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            Button3.Enabled = True
            Label5.Enabled = True
            Label6.Enabled = True

        Else
            CheckBox4.Enabled = True
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            Button3.Enabled = False
            Label5.Enabled = False
            Label6.Enabled = False
        End If
    End Sub
    Private Function Format(ByVal p1 As Integer, ByVal p2 As String) As Integer
        Throw New NotImplementedException
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panske.Tick
        Dim start As Integer = TextBox2.Text
        Dim konec As Integer = TextBox3.Text
       

        For pridat As Integer = start To konec
            ProgressBar1.Increment(1)

            Dim statussatny As String = "Volná"
            Dim kombinace As String
            kombinace = ComboBox1.Text & " " & pridat
            MainForm.SatnyTableAdapter.InsertQuery(kombinace, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, statussatny, Nothing)
        Next
        panske.Stop()
        ProgressBar1.Value = 100
        zapis.registracesatenkonec()
        ProgressBar1.Visible = False
        ProgressBar1.Value = 0
        MsgBox("Zápis byl úspěšný", MsgBoxStyle.Information, "Stav zápisu")
        MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)
        zapis.AktualizaceHodnotMainForm()
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        ComboBox1.Text = Nothing
        If MainForm.Button1.Enabled = False Then
            MainForm.Button1.Enabled = True
            MainForm.Button2.Enabled = True
            MainForm.Button3.Enabled = True
            MainForm.Button4.Enabled = True
            MainForm.Button5.Enabled = True
            MainForm.Button6.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cislosatny As String = ComboBox1.Text
        Dim satna As String = TextBox1.Text
        Dim kombinace As String
        Dim stav As String = "Volná"
        kombinace = cislosatny & " " & satna


        MainForm.SatnyTableAdapter.InsertQuery(kombinace, Nothing, Nothing, Nothing, _
                                               Nothing, Nothing, Nothing, Nothing, Nothing, _
                                               Nothing, stav, Nothing)
        MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)

        MsgBox("Byla přidána šatní skříňka č. " & kombinace & " do databáze", MsgBoxStyle.Information, "Informace")

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ProgressBar2.Visible = True
        damske.Start()
        zapis.registracesatendamske()

    End Sub

    Private Sub damske_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles damske.Tick
        Dim start As Integer = TextBox5.Text
        Dim konec As Integer = TextBox4.Text

        For pridat As Integer = start To konec
            ProgressBar2.Increment(1)
            Dim stavsatny As String = "Volná"
            Dim kombinace As String
            kombinace = ComboBox2.Text & " " & pridat
            MainForm.SatnyTableAdapter.InsertQuery(kombinace, Nothing, Nothing, _
                                                   Nothing, Nothing, Nothing, Nothing, _
                                                   Nothing, Nothing, Nothing, stavsatny, Nothing)
        Next
        damske.Stop()
        MsgBox("Zápis byl úspěšný", MsgBoxStyle.Information, "Stav zápisu")
        MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)
        ProgressBar2.Visible = False
        zapis.AktualizaceHodnotMainForm()
        zapis.registracesatendamskekonec()

        TextBox4.Text = Nothing
        TextBox5.Text = Nothing
        ComboBox2.Text = Nothing
        If MainForm.Button1.Enabled = False Then
            MainForm.Button1.Enabled = True
            MainForm.Button2.Enabled = True
            MainForm.Button3.Enabled = True
            MainForm.Button4.Enabled = True
            MainForm.Button5.Enabled = True
            MainForm.Button6.Enabled = True
        End If
        damske.Stop()


    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cislosatny As String = ComboBox2.Text
        Dim satna As String = TextBox6.Text
        Dim kombinace As String
        Dim stav As String = "Volná"
        kombinace = cislosatny & " " & satna


        MainForm.SatnyTableAdapter.InsertQuery(kombinace, Nothing, Nothing, Nothing, _
                                               Nothing, Nothing, Nothing, Nothing, Nothing, _
                                               Nothing, stav, Nothing)
        MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)

        MsgBox("Byla přidána šatní skříňka č. " & kombinace & " do databáze", MsgBoxStyle.Information, "Informace")
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class