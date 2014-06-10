Public Class historienew

    Private Sub historienew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_MyDatabase_1DataSet2.historiesaten' table. You can move, or remove it, as needed.
        Me.HistoriesatenTableAdapter.Fill(Me._MyDatabase_1DataSet2.historiesaten)
      
    End Sub

    Private Sub DeleteQueryAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.HistoriesatenTableAdapter.DeleteQueryhistorie()
        Me.HistoriesatenTableAdapter.Fill(Me._MyDatabase_1DataSet2.historiesaten)

    End Sub

    Private Sub DeleteQuerySingleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.HistoriesatenTableAdapter.DeleteQueryFirstRow(DataGridView1.SelectedRows.Item(0).Cells(0).Value)
        Me.HistoriesatenTableAdapter.Fill(Me._MyDatabase_1DataSet2.historiesaten)

    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripTextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripTextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If ToolStripTextBox2.Text = Nothing Then
            Me.HistoriesatenBindingSource.Filter = Nothing
        Else
            Dim SCode As String = "%" + ToolStripTextBox2.Text.ToString + "%"
            Me.HistoriesatenBindingSource.Filter = " idcislo LIKE '" & SCode & "'"
        End If
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If ToolStripTextBox1.Text = Nothing Then
            Me.HistoriesatenBindingSource.Filter = Nothing
        Else
            Dim SCode As String = "%" + ToolStripTextBox1.Text.ToString + "%"
            Me.HistoriesatenBindingSource.Filter = " cislosatny LIKE '" & SCode & "'"
        End If
    End Sub
End Class