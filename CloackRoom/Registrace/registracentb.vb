Public Class registracentb

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Záznam byl uložen", MsgBoxStyle.Information, "Hotovo")

        MainForm.NtbTableAdapter.Vlozitzaznam(evcislo.Text, jmenoprijmeni.Text, osobko.Text, znacka.Text, _
                                                            sn.Text, plomba.Text, datumplatnosti.Text, Now, Label8.Text)
        MainForm.NtbTableAdapter.Fill(MainForm.Notebooks.ntb)
        evcislo.Text = Nothing
        jmenoprijmeni.Text = Nothing
        osobko.Text = Nothing
        znacka.Text = Nothing
        sn.Text = Nothing
        plomba.Text = Nothing
        datumplatnosti.Text = Nothing
        Me.Close()
       
     
    End Sub

    Private Sub registracentb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label8.Text = MainForm.ToolStripStatusLabel2.Text
        Dim poslednizaznam As Integer = MainForm.Ntb.RowCount.ToString
        Dim ntb As String = "NTB-"

        If MainForm.Ntb.RowCount = 0 Then
            evcislo.Text = "NTB-1"
        Else
            evcislo.Text = ntb & poslednizaznam + 1

        End If




    End Sub
End Class