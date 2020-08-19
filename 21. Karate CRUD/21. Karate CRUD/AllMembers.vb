Public Class AllMembers
    Private Sub AllMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.KarateDataSet.Members)

    End Sub

    Private Sub UpdateDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDatabaseToolStripMenuItem.Click

        Try
            MembersTableAdapter.Update(KarateDataSet.Members)
            MembersTableAdapter.Fill(KarateDataSet.Members)
        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click


        Close()
    End Sub

    Private Sub FindByNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindByNameToolStripMenuItem.Click
        frmFindByName.Show()
    End Sub

    Private Sub AddMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMemberToolStripMenuItem.Click
        frmAddMember.Show()
    End Sub

    Private Sub btnFilterByDate_Click(sender As Object, e As EventArgs) Handles btnFilterByDate.Click
        frmFilterByDate.Show()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Try
            KarateMembersBindingSource.Filter = txtFilter.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
