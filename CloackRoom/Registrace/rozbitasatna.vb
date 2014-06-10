Imports System.Windows.Forms

Public Class rozbitasatna
    Dim aktualuzace As New Trida

    Private Sub rozbitasatna_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CisloSatnyTextBox.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub rozbitasatna_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CisloSatnyTextBox.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub rozbitasatna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CisloSatnyTextBox.Text = MainForm.PanskeSatny.SelectedRows.Item(0).Cells(0).Value
        Dim rozbita As String = CisloSatnyTextBox.Text
        Me.Text = "Rozbitá šatní skříň č. " & rozbita
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim poloha As Integer = MainForm.PanskeSatny.CurrentRow.Index
        Dim rozbitasatna As String = "Rozbitá"
        Dim cislo As String = CisloSatnyTextBox.Text

        MainForm.SatnyTableAdapter.UpdateQuery(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, TextBox1.Text, _
                                               MainForm.ToolStripStatusLabel2.Text, rozbitasatna, Now, CisloSatnyTextBox.Text)
        MainForm.SatnyTableAdapter.Fill(MainForm._MyDatabase_1DataSet.satny)
        MainForm.PanskeSatny.Rows(poloha).Selected = True
        MsgBox("Šatní skříňka " & cislo & " byla uložena jako poškozená", MsgBoxStyle.Information, "Hotovo")
        Me.Close()
        CisloSatnyTextBox.Text = ""
        TextBox1.Text = ""
        aktualuzace.AktualizaceHodnotMainForm()
    End Sub

    Private Sub CisloSatnyTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CisloSatnyTextBox.TextChanged

    End Sub
End Class
