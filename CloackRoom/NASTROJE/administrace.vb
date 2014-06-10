Public Class administrace

    Private Sub administrace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Backups.backupdatabases' table. You can move, or remove it, as needed.
        Me.BackupdatabasesTableAdapter.Fill(Me.Backups.backupdatabases)
        'TODO: This line of code loads data into the '_MyDatabase_1DataSet.satny' table. You can move, or remove it, as needed.
        Me.SatnyTableAdapter.Fill(Me._MyDatabase_1DataSet.satny)

    End Sub
    Private Sub Button4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim vymazani As String
        vymazani = MsgBox("Tabulka ""šatny"" bude vymazána", MsgBoxStyle.YesNo, "Vymazat??")

        If vymazani = vbYes Then
            MainForm.SatnyTableAdapter.DeleteQuery1()
            MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)
            MsgBox("Tabulka byla vymazána", MsgBoxStyle.Information, "Vymazáno")
            MainForm.Button1.Enabled = False
            MainForm.Button2.Enabled = False
            MainForm.Button3.Enabled = False
            MainForm.Button4.Enabled = False
            MainForm.Button5.Enabled = False
            MainForm.Button6.Enabled = False

        End If
        If vymazani = vbNo Then
            MsgBox("Akce byla zrušena uživatelem", MsgBoxStyle.Information, "Zrušeno")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim vymazani As String
        vymazani = MsgBox("Tabulka ""historie"" bude vymazána", MsgBoxStyle.YesNo, "Vymazat??")

        If vymazani = vbYes Then
            historienew.HistoriesatenTableAdapter.DeleteQueryhistorie()
            historienew.HistoriesatenTableAdapter.Fill(historienew._MyDatabase_1DataSet2.historiesaten)
            MsgBox("Tabulka byla vymazána", MsgBoxStyle.Information, "Vymazáno")
        End If
        If vymazani = vbNo Then
            MsgBox("Akce byla zrušena uživatelem", MsgBoxStyle.Information, "Zrušeno")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim vymazani As String
        vymazani = MsgBox("Tabulka ""uživatelé"" bude vymazána", MsgBoxStyle.YesNo, "Vymazat??")

        If vymazani = vbYes Then
            users.UzivateleTableAdapter.DeleteQuery1()
            users.UzivateleTableAdapter.Fill(users._MyDatabase_1DataSet1.Uzivatele)
            MsgBox("Tabulka byla vymazána", MsgBoxStyle.Information, "Vymazáno")
        End If
        If vymazani = vbNo Then
            MsgBox("Akce byla zrušena uživatelem", MsgBoxStyle.Information, "Zrušeno")
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cesta As String = "cesta"
        Me.BackupdatabasesTableAdapter.Insert(Now, cesta)
        Me.BackupdatabasesTableAdapter.Fill(Backups.backupdatabases)
        ComboBox1.Refresh()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.BackupdatabasesTableAdapter.DeleteQuery()
        Me.BackupdatabasesTableAdapter.Fill(Backups.backupdatabases)
        ComboBox1.Refresh()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim vymazani As String
        vymazani = MsgBox("Tabulka ""ntb"" bude vymazána", MsgBoxStyle.YesNo, "Vymazat??")

        If vymazani = vbYes Then
            MainForm.NtbTableAdapter.Vymazat()

            MainForm.NtbTableAdapter.Fill(MainForm.Notebooks.ntb)
            MsgBox("Tabulka byla vymazána", MsgBoxStyle.Information, "Vymazáno")
        End If
        If vymazani = vbNo Then
            MsgBox("Akce byla zrušena uživatelem", MsgBoxStyle.Information, "Zrušeno")
        End If
    End Sub
End Class