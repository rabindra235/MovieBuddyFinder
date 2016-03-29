Public Class frmSearchMember


    Private Sub btnTask5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTask5.Click
        Call task5()
    End Sub


    Private Sub Task5()
        'performing the operation as required in task 5
        'declaring and initializing the value with initial values
        lstDisplay.Items.Clear()
        Dim vFileName As String = "C:\temp\Members.txt"
        Dim vstrReadText As String = ""
        Dim vstrFName As String = ""
        Dim vstrLName As String = ""
        Dim vstrGender As String = ""
        Dim vstrNameGender As String = ""
        Dim vintIndexOfFirstComma As Integer = 0
        Dim vintIndexOfSecondComma As Integer = 0
        Dim vintIndexOfThirdComma As Integer = 0
        Dim vintIndexOfWhiteSpace As Integer = 0
        Dim rvSR As New IO.StreamReader(vFileName)
        Do While rvSR.Peek <> -1
            vstrReadText = rvSR.ReadLine()
            vintIndexOfFirstComma = vstrReadText.IndexOf(",") + 1
            vstrGender = vstrReadText.Substring(vintIndexOfFirstComma, 1)
            If (vstrGender = "M") Then
                vstrGender = "Male"
            Else
                vstrGender = "Female"
            End If
            vintIndexOfSecondComma = vstrReadText.IndexOf(",", vstrReadText.IndexOf(",") + 1) + 1
            vstrFName = vstrReadText.Substring(vintIndexOfSecondComma, 1)
            vintIndexOfWhiteSpace = vstrReadText.IndexOf(" ") + 1
            vintIndexOfThirdComma = vstrReadText.IndexOf(",", vstrReadText.IndexOf(",", vstrReadText.IndexOf(",") + 1) + 1)
            vstrLName = vstrReadText.Substring(vintIndexOfWhiteSpace, vintIndexOfThirdComma - vintIndexOfWhiteSpace)
            vstrNameGender = vstrFName & "." & vstrLName & "," & vstrGender & ControlChars.NewLine
            lstDisplay.Items.Add(vstrNameGender)
        Loop


        rvSR.Close()



    End Sub

    Private Sub btnTask6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTask6.Click
        Call Task6()
    End Sub

    Private Sub Task6()
        lstDisplay.Items.Clear()
        Dim vFileName As String = "C:\temp\Members.txt"
        Dim vchrDelimeter() As Char = {","}
        Dim vstrString(-1) As String
        Dim vstrReadText As String = ""
        Dim vstrName As String = ""
        Dim vstrGender As String = ""
        Dim vstrSeeking As String = ""
        Dim vstrDisplayText As String = ""
        Dim rvSR As New IO.StreamReader(vFileName)
        Do While rvSR.Peek <> -1
            vstrReadText = rvSR.ReadLine()
            vstrString = vstrReadText.Split(vchrDelimeter)
            vstrGender = vstrString(1)
            If (vstrGender = "M") Then
                vstrGender = "Male"
            Else
                vstrGender = "Female"
            End If

            vstrName = vstrString(2)
            vstrSeeking = vstrString(5)
            If (vstrSeeking = "M") Then
                vstrSeeking = "Male"
            Else
                vstrSeeking = "Female"
            End If
            vstrDisplayText = vstrName.PadRight(8) & " is a " & vstrGender & " seeking a " & vstrSeeking & ControlChars.NewLine
            lstDisplay.Items.Add(vstrDisplayText)
        Loop

        rvSR.Close()
    End Sub

    Private Sub btnTask7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTask7.Click
        Call Task7()
    End Sub



    Private Sub task7()
        lstDisplay.Items.Clear()
        Dim vFileName As String = "C:\temp\Members.txt"
        Dim vchrDelimeter() As Char = {","}
        Dim vstrString(-1) As String
        Dim vstrReadText As String = ""
        Dim valtMemberList As New ArrayList
        Dim rvSR As New IO.StreamReader(vFileName)
        Do While rvSR.Peek <> -1
            vstrReadText = rvSR.ReadLine()
            vstrString = vstrReadText.Split(vchrDelimeter)
            Dim vclsMember As New Member
            vclsMember.vstrMemberID = vstrString(0)
            vclsMember.vstrName = vstrString(2)
            vclsMember.vstrPhone = vstrString(3)
            vclsMember.vintAge = vstrString(4)
            vclsMember.chrGender = vstrString(1)
            vclsMember.chrSeeksGender = vstrString(5)
            vclsMember.vintSeeksAgeDifference = vstrString(6)
            vclsMember.chrLikesComedy = vstrString(7)
            vclsMember.chrLikesDrama = vstrString(8)
            vclsMember.chrLikesRomance = vstrString(9)
            vclsMember.chrLikesAction = vstrString(10)
            vclsMember.chrLikesHorror = vstrString(11)
            vclsMember.chrLikesFamily = vstrString(12)
            vclsMember.chrLikesSciFi = vstrString(13)
            valtMemberList.Add(vclsMember)
        Loop
        lstDisplay.Items.Add("Name".PadRight(22) & "Phone".PadRight(12) & "Age")

        'looping through the list to display name phone and age of the member

        For vinCount = 0 To valtMemberList.Count - 1
            Dim vclsmember As Member
            vclsmember = valtMemberList.Item(vinCount)

            lstDisplay.Items.Add(vclsmember.vstrName.PadRight(22) & vclsmember.vstrPhone.PadRight(12) & vclsmember.vintAge)
        Next
    End Sub

    Public Class Member
        Public vstrMemberID As String
        Public vstrName As String
        Public vstrPhone As String
        Public vintAge As Integer
        Public chrGender As Char
        Public chrSeeksGender As Char
        Public vintSeeksAgeDifference As Integer
        Public chrLikesComedy As Char
        Public chrLikesDrama As Char
        Public chrLikesRomance As Char
        Public chrLikesAction As Char
        Public chrLikesHorror As Char
        Public chrLikesFamily As Char
        Public chrLikesSciFi As Char

    End Class


End Class