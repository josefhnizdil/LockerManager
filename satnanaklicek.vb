Public Class satnanaklicek

    Private Sub satnanaklicek_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_MyDatabase_1DataSet.satny' table. You can move, or remove it, as needed.
        Me.SatnyTableAdapter.Fill(Me._MyDatabase_1DataSet.satny)
        'TODO: This line of code loads data into the '_MyDatabase_1DataSet.satny' table. You can move, or remove it, as needed.
        Me.SatnyTableAdapter.Fill(Me._MyDatabase_1DataSet.satny)

        Dim registrovane As String = "1"
        'TODO: Tento řádek načte data do tabulky '_MyDatabase_1DataSet.satny'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.SatnyTableAdapter.Fill(Me._MyDatabase_1DataSet.satny)

        Me.SatnyBindingSource1.Filter = " klicekksatne = 1"
        Me.SatnyBindingSource.Filter = " klicekksatne = 0"


    End Sub


    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = Nothing Then
            Me.SatnyBindingSource.Filter = Nothing
            Me.SatnyBindingSource1.Filter = Nothing
        Else
            Dim SCode As String = "%" + ComboBox1.Text.ToString + "%"
            Me.SatnyBindingSource.Filter = " cislosatny LIKE '" & SCode & "'"
            Me.SatnyBindingSource1.Filter = " cislosatny LIKE '" & SCode & "'"
        End If
    End Sub

   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)





    End Sub

  

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick


        Dim klicek As String = Me.DataGridView2.SelectedRows.Item(0).Cells(0).Value
        SatnyTableAdapter.UpdateQueryKliceNon(klicek)

        SatnyTableAdapter.Fill(_MyDatabase_1DataSet.satny)

        Me.SatnyBindingSource1.Filter = " klicekksatne = 1"




    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



        Dim klicek As String = Me.DataGridView1.SelectedRows.Item(0).Cells(0).Value

        SatnyTableAdapter.UpdateQueryKlice(klicek)


        SatnyTableAdapter.Fill(_MyDatabase_1DataSet.satny)

        Me.SatnyBindingSource.Filter = " klicekksatne = 0"







    End Sub
End Class