Public Class frmAddMember

    Private Sub AddMember_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId.KeyPress, txtAge.KeyPress, txtAgeDiff.KeyPress, txtPhone.KeyPress

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then

            e.Handled = True

        End If

    End Sub




    Private Sub AddMembers_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If (IsNumeric(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Call Add()
    End Sub

    Private Sub Add()
        Dim vFileName As String = "C:\temp\Members.txt"
        Dim vstrReadText As String
        Dim rvSR As New IO.StreamReader(vFileName)
        Do While rvSR.Peek <> -1
            vstrReadText = rvSR.ReadLine()
            If vstrReadText.Substring(0, 5) = txtId.Text Then
                MessageBox.Show("ID Number is Taken Please try Another one")
                rvSR.Close()
                Exit Sub

            End If

        Loop


        rvSR.Close()


        Dim rvSW As New IO.StreamWriter(vFileName, True)
        Dim vstrGender As String
        Dim vstrSeeking As String
        Dim vintCalculateDigitCheck As Integer
        Dim vstrId As String



        If txtId.Text = String.Empty Then
            MessageBox.Show("Please enter ID")
            rvSW.Close()
            Exit Sub



        ElseIf txtId.TextLength <> 5 Then
            MessageBox.Show("ID's Length should be 5")
            rvSW.Close()
            Exit Sub
        End If

        If txtName.Text = String.Empty Then
            MessageBox.Show("Please enter Name")
            rvSW.Close()
            Exit Sub

        ElseIf txtName.TextLength < 2 Or txtName.TextLength > 30 Then
            MessageBox.Show("Name should have 2 to 30 Characters")
            rvSW.Close()
            Exit Sub

        End If

        If txtPhone.Text = String.Empty Then
            MessageBox.Show("Please enter Phone Number")
            rvSW.Close()
            Exit Sub

        ElseIf txtPhone.TextLength < 8 Or txtPhone.TextLength > 10 Then
            MessageBox.Show("Phone No Entered is not Valid, Should be of 8 to 10 characters")
            rvSW.Close()
            Exit Sub
        End If

        If txtAge.Text = String.Empty Then
            MessageBox.Show("Please enter Age")
            rvSW.Close()
            Exit Sub

        ElseIf txtAge.Text < 18 Or txtAge.Text > 99 Then
            MessageBox.Show("Age should be between 18 to 99")
            rvSW.Close()
            Exit Sub
        End If

        If ((radGenderFemale.Checked = False) And radGenderMale.Checked = False) Then
            MessageBox.Show("Please select the  gender")
            rvSW.Close()
            Exit Sub
        End If

        If ((radSeekingFemale.Checked = False) And radSeekingMale.Checked = False) Then
            MessageBox.Show("Please select  seeking  gender")
            rvSW.Close()
            Exit Sub
        End If

        If txtAgeDiff.Text = String.Empty Then
            MessageBox.Show("Please enter Age Difference")
            rvSW.Close()
            Exit Sub

        ElseIf txtAgeDiff.Text < 0 Or txtAgeDiff.Text > 99 Then
            MessageBox.Show("Age Difference should be between 0 to 99 ")
            rvSW.Close()
            Exit Sub
        End If



        If (radGenderFemale.Checked = True) Then
            vstrGender = "F"

        Else
            vstrGender = "M"

        End If

        If (radSeekingFemale.Checked = True) Then
            vstrSeeking = "F"

        Else
            vstrSeeking = "M"

        End If




        Dim vintcountchkbox As Integer = 0
        Dim vstrchkboxVal As String = ""
        For vintcountchkbox = 0 To clbFavourite.Items.Count - 1

            If (clbFavourite.GetItemChecked(vintcountchkbox)) Then

                vstrchkboxVal += "," & "T"

            Else
                vstrchkboxVal += "," & "F"
            End If


        Next


        vstrId = txtId.Text.Substring(0, 4)
        vintCalculateDigitCheck = CalculateDigitCheck(vstrId)
        If (vintCalculateDigitCheck = txtId.Text.Substring(4, 1)) Then
            MessageBox.Show("Member ID is  valid")
            rvSW.WriteLine()
            rvSW.Write(txtId.Text & "," & vstrGender & "," & txtName.Text & "," & txtPhone.Text & "," & txtAge.Text & "," & vstrSeeking & "," & txtAgeDiff.Text & vstrchkboxVal)
            rvSW.Close()

        Else
            MessageBox.Show("Member ID is not valid")
            Exit Sub

        End If
        rvSR.Close()


    End Sub


    Private Function CalculateDigitCheck(ByVal vstrInputId As String) As Integer
        Dim vintcount As Integer

        Dim vintA As Integer = vstrInputId.Substring(0, 1) * 3
        Dim vintB As Integer = vstrInputId.Substring(2, 1) * 7
        Dim vintC As Integer = vintA + vintB
        Dim vintD As Integer = vintC + vstrInputId.Substring(1, 1) + vstrInputId.Substring(3, 1)
        Do
            Dim vintDigitSum As Integer = 0
            For vintcount = 0 To vintD.ToString.Length - 1
                Dim vintDigitLength As Integer = vintD.ToString.Substring(vintcount, 1)
                vintDigitSum += vintDigitLength
            Next
            vintD = vintDigitSum
        Loop While vintD.ToString.Length > 1

        Return vintD

    End Function


    Private Sub AddMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call DefaultCheck()
    End Sub

    Private Sub DefaultCheck()
        clbFavourite.SetItemCheckState(0, CheckState.Checked)
        clbFavourite.SetItemCheckState(3, CheckState.Checked)
        clbFavourite.SetItemCheckState(4, CheckState.Checked)
        clbFavourite.SetItemCheckState(6, CheckState.Checked)
    End Sub

End Class