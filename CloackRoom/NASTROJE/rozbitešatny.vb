Imports System.IO
Imports Microsoft.ReportingServices.Rendering.ExcelRenderer.Excel

Public Class rozbitešatny

    Private Sub rozbitešatny_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_MyDatabase_1DataSet.satny' table. You can move, or remove it, as needed.
        Me.SatnyTableAdapter.Fill(Me._MyDatabase_1DataSet.satny)
        Dim SCode As String = "Rozbitá"
        Me.SatnyBindingSource.Filter = " status LIKE '" & SCode & "'"

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Tisk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tisk.Click

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ReportViewer1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Export.Click
    End Sub
End Class