Public Class frmDisplayAllMember

    Private Sub btnDisplayAllMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayAllMember.Click
        Call DisplayAllMember()
    End Sub

    Private Sub btnDisplayOnlyMales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayOnlyMales.Click
        Call DisplayOnlyMales()
    End Sub


    Private Sub btnDisplayOnlyFemales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayOnlyFemales.Click
        Call DisplayOnlyFemales()
    End Sub

    Private Sub DisplayAllMember()
        Dim vstrAllMembers As String = "all"
        DisplayPopulation(vstrAllMembers)
    End Sub

    Private Sub DisplayOnlyMales()
        Dim vstrMale As String = "M"
        DisplayPopulation(vstrMale)
    End Sub



    Private Sub DisplayOnlyFemales()
        Dim vstrFemale As String = "F"
        DisplayPopulation(vstrFemale)
    End Sub

    Private Sub DisplayPopulation(ByVal vstrParameter As String)

        lstDetails.Items.Clear()
        Dim vFileName As String = "C:\temp\Members.txt"
        Dim vstrReadText As String
        If System.IO.File.Exists(vFileName) = True Then
            Dim rvSR As New IO.StreamReader(vFileName)
            While rvSR.Peek <> -1
                vstrReadText = rvSR.ReadLine
                If (vstrReadText.IndexOf(vstrParameter) = 6) Then
                    lstDetails.Items.Add(vstrReadText)
                ElseIf (vstrParameter = "all") Then
                    lstDetails.Items.Add(vstrReadText)
                End If

            End While
            rvSR.Close()
        Else

            MessageBox.Show("File does not exist")
        End If


    End Sub

End Class