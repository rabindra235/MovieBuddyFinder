Public Class frmMenu
    Private Sub btnDisplayMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayMember.Click
        Call DisplayMemberForm()
    End Sub

    Private Sub DisplayMemberForm()

        Dim rtvForm As New frmDisplayAllMember
        rtvForm.ShowDialog()
        rtvForm = Nothing
    End Sub


    Private Sub btnAddMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMember.Click
        Call AddMemberForm()
    End Sub

    Private Sub AddMemberForm()
        Dim rtvForm As New frmAddMember
        rtvForm.ShowDialog()
        rtvForm = Nothing

    End Sub

Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchMemberForm()
    End Sub


    Private Sub SearchMemberForm()

        Dim rtvForm As New frmSearchMember
        rtvForm.ShowDialog()
        rtvForm = Nothing

    End Sub

End Class
