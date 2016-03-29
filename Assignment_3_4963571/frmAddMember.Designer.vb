<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddMember
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeading3 = New System.Windows.Forms.Label()
        Me.lblHeading4 = New System.Windows.Forms.Label()
        Me.lblMemberDetail = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblSeeking = New System.Windows.Forms.Label()
        Me.lblSymbol = New System.Windows.Forms.Label()
        Me.lblAgeDifference = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtAgeDiff = New System.Windows.Forms.TextBox()
        Me.grpbxGender = New System.Windows.Forms.GroupBox()
        Me.radGenderMale = New System.Windows.Forms.RadioButton()
        Me.radGenderFemale = New System.Windows.Forms.RadioButton()
        Me.grpbxSeeking = New System.Windows.Forms.GroupBox()
        Me.radSeekingMale = New System.Windows.Forms.RadioButton()
        Me.radSeekingFemale = New System.Windows.Forms.RadioButton()
        Me.grpbxGenres = New System.Windows.Forms.GroupBox()
        Me.lblFavourite = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.clbFavourite = New System.Windows.Forms.CheckedListBox()
        Me.grpbxGender.SuspendLayout()
        Me.grpbxSeeking.SuspendLayout()
        Me.grpbxGenres.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading3
        '
        Me.lblHeading3.AutoSize = True
        Me.lblHeading3.Font = New System.Drawing.Font("Courier New", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading3.Location = New System.Drawing.Point(150, 22)
        Me.lblHeading3.Name = "lblHeading3"
        Me.lblHeading3.Size = New System.Drawing.Size(414, 41)
        Me.lblHeading3.TabIndex = 1
        Me.lblHeading3.Text = "Movie Buddy Finder"
        '
        'lblHeading4
        '
        Me.lblHeading4.AutoSize = True
        Me.lblHeading4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading4.Location = New System.Drawing.Point(201, 63)
        Me.lblHeading4.Name = "lblHeading4"
        Me.lblHeading4.Size = New System.Drawing.Size(280, 16)
        Me.lblHeading4.TabIndex = 2
        Me.lblHeading4.Text = "making dream comes true since 2009"
        '
        'lblMemberDetail
        '
        Me.lblMemberDetail.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberDetail.Location = New System.Drawing.Point(24, 112)
        Me.lblMemberDetail.Name = "lblMemberDetail"
        Me.lblMemberDetail.Size = New System.Drawing.Size(100, 43)
        Me.lblMemberDetail.TabIndex = 3
        Me.lblMemberDetail.Text = "Member Details"
        '
        'lblId
        '
        Me.lblId.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(176, 164)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(34, 17)
        Me.lblId.TabIndex = 4
        Me.lblId.Text = "ID"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(157, 186)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(48, 18)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name"
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNo.Location = New System.Drawing.Point(110, 212)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(98, 18)
        Me.lblPhoneNo.TabIndex = 6
        Me.lblPhoneNo.Text = "Phone No."
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(167, 234)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(38, 18)
        Me.lblAge.TabIndex = 7
        Me.lblAge.Text = "Age"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(137, 260)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(68, 18)
        Me.lblGender.TabIndex = 8
        Me.lblGender.Text = "Gender"
        '
        'lblSeeking
        '
        Me.lblSeeking.AutoSize = True
        Me.lblSeeking.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeeking.Location = New System.Drawing.Point(125, 314)
        Me.lblSeeking.Name = "lblSeeking"
        Me.lblSeeking.Size = New System.Drawing.Size(78, 18)
        Me.lblSeeking.TabIndex = 9
        Me.lblSeeking.Text = "Seeking"
        '
        'lblSymbol
        '
        Me.lblSymbol.AutoSize = True
        Me.lblSymbol.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSymbol.Location = New System.Drawing.Point(23, 289)
        Me.lblSymbol.Name = "lblSymbol"
        Me.lblSymbol.Size = New System.Drawing.Size(472, 22)
        Me.lblSymbol.TabIndex = 10
        Me.lblSymbol.Text = "------------------------------------------"
        '
        'lblAgeDifference
        '
        Me.lblAgeDifference.AutoSize = True
        Me.lblAgeDifference.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeDifference.Location = New System.Drawing.Point(56, 347)
        Me.lblAgeDifference.Name = "lblAgeDifference"
        Me.lblAgeDifference.Size = New System.Drawing.Size(148, 18)
        Me.lblAgeDifference.TabIndex = 11
        Me.lblAgeDifference.Text = "Age Difference"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(217, 160)
        Me.txtId.MaxLength = 5
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 12
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(217, 184)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 13
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(217, 209)
        Me.txtPhone.MaxLength = 10
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 14
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(217, 233)
        Me.txtAge.MaxLength = 2
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(32, 20)
        Me.txtAge.TabIndex = 15
        '
        'txtAgeDiff
        '
        Me.txtAgeDiff.Location = New System.Drawing.Point(217, 342)
        Me.txtAgeDiff.MaxLength = 2
        Me.txtAgeDiff.Name = "txtAgeDiff"
        Me.txtAgeDiff.Size = New System.Drawing.Size(45, 20)
        Me.txtAgeDiff.TabIndex = 16
        '
        'grpbxGender
        '
        Me.grpbxGender.Controls.Add(Me.radGenderMale)
        Me.grpbxGender.Controls.Add(Me.radGenderFemale)
        Me.grpbxGender.Location = New System.Drawing.Point(214, 252)
        Me.grpbxGender.Name = "grpbxGender"
        Me.grpbxGender.Size = New System.Drawing.Size(163, 30)
        Me.grpbxGender.TabIndex = 17
        Me.grpbxGender.TabStop = False
        '
        'radGenderMale
        '
        Me.radGenderMale.AutoSize = True
        Me.radGenderMale.Location = New System.Drawing.Point(88, 8)
        Me.radGenderMale.Name = "radGenderMale"
        Me.radGenderMale.Size = New System.Drawing.Size(48, 17)
        Me.radGenderMale.TabIndex = 1
        Me.radGenderMale.Text = "Male"
        Me.radGenderMale.UseVisualStyleBackColor = True
        '
        'radGenderFemale
        '
        Me.radGenderFemale.AutoSize = True
        Me.radGenderFemale.Location = New System.Drawing.Point(7, 8)
        Me.radGenderFemale.Name = "radGenderFemale"
        Me.radGenderFemale.Size = New System.Drawing.Size(59, 17)
        Me.radGenderFemale.TabIndex = 0
        Me.radGenderFemale.TabStop = True
        Me.radGenderFemale.Text = "Female"
        Me.radGenderFemale.UseVisualStyleBackColor = True
        '
        'grpbxSeeking
        '
        Me.grpbxSeeking.Controls.Add(Me.radSeekingMale)
        Me.grpbxSeeking.Controls.Add(Me.radSeekingFemale)
        Me.grpbxSeeking.Location = New System.Drawing.Point(212, 303)
        Me.grpbxSeeking.Name = "grpbxSeeking"
        Me.grpbxSeeking.Size = New System.Drawing.Size(163, 30)
        Me.grpbxSeeking.TabIndex = 18
        Me.grpbxSeeking.TabStop = False
        '
        'radSeekingMale
        '
        Me.radSeekingMale.AutoSize = True
        Me.radSeekingMale.Location = New System.Drawing.Point(88, 8)
        Me.radSeekingMale.Name = "radSeekingMale"
        Me.radSeekingMale.Size = New System.Drawing.Size(48, 17)
        Me.radSeekingMale.TabIndex = 1
        Me.radSeekingMale.TabStop = True
        Me.radSeekingMale.Text = "Male"
        Me.radSeekingMale.UseVisualStyleBackColor = True
        '
        'radSeekingFemale
        '
        Me.radSeekingFemale.AutoSize = True
        Me.radSeekingFemale.Location = New System.Drawing.Point(7, 10)
        Me.radSeekingFemale.Name = "radSeekingFemale"
        Me.radSeekingFemale.Size = New System.Drawing.Size(59, 17)
        Me.radSeekingFemale.TabIndex = 0
        Me.radSeekingFemale.Text = "Female"
        Me.radSeekingFemale.UseVisualStyleBackColor = True
        '
        'grpbxGenres
        '
        Me.grpbxGenres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grpbxGenres.Controls.Add(Me.clbFavourite)
        Me.grpbxGenres.Controls.Add(Me.lblFavourite)
        Me.grpbxGenres.Location = New System.Drawing.Point(490, 92)
        Me.grpbxGenres.Name = "grpbxGenres"
        Me.grpbxGenres.Size = New System.Drawing.Size(200, 241)
        Me.grpbxGenres.TabIndex = 19
        Me.grpbxGenres.TabStop = False
        '
        'lblFavourite
        '
        Me.lblFavourite.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavourite.Location = New System.Drawing.Point(6, 16)
        Me.lblFavourite.Name = "lblFavourite"
        Me.lblFavourite.Size = New System.Drawing.Size(98, 47)
        Me.lblFavourite.TabIndex = 4
        Me.lblFavourite.Text = "FavouriteGenres"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.InfoText
        Me.btnAdd.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(442, 426)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 41)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.InfoText
        Me.btnClose.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(561, 426)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(113, 41)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'clbFavourite
        '
        Me.clbFavourite.BackColor = System.Drawing.SystemColors.GrayText
        Me.clbFavourite.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbFavourite.FormattingEnabled = True
        Me.clbFavourite.Items.AddRange(New Object() {"Comedy", "Drama", "Romance", "Action", "Horror", "Family", "SciFi"})
        Me.clbFavourite.Location = New System.Drawing.Point(9, 65)
        Me.clbFavourite.Name = "clbFavourite"
        Me.clbFavourite.Size = New System.Drawing.Size(65, 165)
        Me.clbFavourite.TabIndex = 12
        '
        'AddMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(708, 507)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grpbxGenres)
        Me.Controls.Add(Me.grpbxSeeking)
        Me.Controls.Add(Me.grpbxGender)
        Me.Controls.Add(Me.txtAgeDiff)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblAgeDifference)
        Me.Controls.Add(Me.lblSymbol)
        Me.Controls.Add(Me.lblSeeking)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblPhoneNo)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblMemberDetail)
        Me.Controls.Add(Me.lblHeading4)
        Me.Controls.Add(Me.lblHeading3)
        Me.Name = "AddMember"
        Me.Text = "Form1"
        Me.grpbxGender.ResumeLayout(False)
        Me.grpbxGender.PerformLayout()
        Me.grpbxSeeking.ResumeLayout(False)
        Me.grpbxSeeking.PerformLayout()
        Me.grpbxGenres.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading3 As System.Windows.Forms.Label
    Friend WithEvents lblHeading4 As System.Windows.Forms.Label
    Friend WithEvents lblMemberDetail As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPhoneNo As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblSeeking As System.Windows.Forms.Label
    Friend WithEvents lblSymbol As System.Windows.Forms.Label
    Friend WithEvents lblAgeDifference As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtAgeDiff As System.Windows.Forms.TextBox
    Friend WithEvents grpbxGender As System.Windows.Forms.GroupBox
    Friend WithEvents radGenderMale As System.Windows.Forms.RadioButton
    Friend WithEvents radGenderFemale As System.Windows.Forms.RadioButton
    Friend WithEvents grpbxSeeking As System.Windows.Forms.GroupBox
    Friend WithEvents radSeekingMale As System.Windows.Forms.RadioButton
    Friend WithEvents radSeekingFemale As System.Windows.Forms.RadioButton
    Friend WithEvents grpbxGenres As System.Windows.Forms.GroupBox
    Friend WithEvents lblFavourite As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents clbFavourite As System.Windows.Forms.CheckedListBox
End Class
