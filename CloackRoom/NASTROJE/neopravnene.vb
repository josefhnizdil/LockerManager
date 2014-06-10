Public Class neopravnene

    Private Sub neopravnene_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_MyDatabase_1DataSet.satny' table. You can move, or remove it, as needed.
        Me.SatnyTableAdapter.Fill(Me._MyDatabase_1DataSet.satny)
        Dim SCode As String = "Neoprávněná"
        Me.SatnyBindingSource.Filter = " status LIKE '" & SCode & "'"

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class