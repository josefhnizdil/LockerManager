Imports System.Data.SqlServerCe
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.Odbc
Imports System.Data.OleDb

Public Class users
   


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        adduser.ShowDialog()

    End Sub

    Private Sub users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.UzivateleTableAdapter.Fill(Me._MyDatabase_1DataSet1.Uzivatele)

      

        


    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
       
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dotaz As String
        Dim uzivatel As String = DataGridView1.SelectedRows.Item(0).Cells(0).Value

        dotaz = MsgBox("Opravdu chcete uživatele " & uzivatel & " odstranit ze systému??", MsgBoxStyle.YesNo, "Dotaz")

        If dotaz = vbYes Then
            UzivateleTableAdapter.DeleteQuery(uzivatel)
            MsgBox("Uživatel " & uzivatel & " byl smazán.", MsgBoxStyle.Information, "Hotovo")
            UzivateleTableAdapter.Fill(_MyDatabase_1DataSet1.Uzivatele)
        End If
        If dotaz = vbNo Then
            MsgBox("Akce byla zrušena uživatelem", MsgBoxStyle.Information, "Zrušeno")
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim heslo As String = DataGridView1.SelectedRows.Item(0).Cells(1).Value
        Dim login As String = DataGridView1.SelectedRows.Item(0).Cells(0).Value
        changepassword.Label5.Text = login
        changepassword.Label4.Text = heslo
        changepassword.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim reset As String
        Dim uzivatel As String = DataGridView1.SelectedRows.Item(0).Cells(0).Value
        Dim stareheslo As String = DataGridView1.SelectedRows.Item(0).Cells(1).Value
        Dim noveheslo As String = "Uzivatel1"

        reset = MsgBox("Chcete provést reset hesla uživatele " & uzivatel & " ??", MsgBoxStyle.YesNo, "Reset hesla")

        If reset = vbYes Then
            MsgBox("Byl proveden reset hesla uživatele " & uzivatel & ". Nové heslo je " & noveheslo & ".", MsgBoxStyle.Information, "Reset hesla")
            UzivateleTableAdapter.UpdateQueryHeslo(noveheslo, uzivatel)
            UzivateleTableAdapter.Fill(_MyDatabase_1DataSet1.Uzivatele)
            LoginForm1.UzivateleTableAdapter.Fill(LoginForm1._MyDatabase_1DataSet1.Uzivatele)


        End If
        If reset = vbNo Then
            MsgBox("Akce byla zrušena uživatelem", MsgBoxStyle.Information, "Akce zrušena")

        End If
    End Sub
End Class