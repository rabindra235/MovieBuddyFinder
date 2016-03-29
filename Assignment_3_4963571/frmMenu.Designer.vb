<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.lblHeading1 = New System.Windows.Forms.Label()
        Me.lblHeading2 = New System.Windows.Forms.Label()
        Me.btnDisplayMember = New System.Windows.Forms.Button()
        Me.btnAddMember = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeading1
        '
        Me.lblHeading1.AutoSize = True
        Me.lblHeading1.Font = New System.Drawing.Font("Courier New", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading1.Location = New System.Drawing.Point(130, 20)
        Me.lblHeading1.Name = "lblHeading1"
        Me.lblHeading1.Size = New System.Drawing.Size(414, 41)
        Me.lblHeading1.TabIndex = 0
        Me.lblHeading1.Text = "Movie Buddy Finder"
        '
        'lblHeading2
        '
        Me.lblHeading2.AutoSize = True
        Me.lblHeading2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading2.Location = New System.Drawing.Point(186, 61)
        Me.lblHeading2.Name = "lblHeading2"
        Me.lblHeading2.Size = New System.Drawing.Size(280, 16)
        Me.lblHeading2.TabIndex = 1
        Me.lblHeading2.Text = "making dream comes true since 2009"
        '
        'btnDisplayMember
        '
        Me.btnDisplayMember.BackColor = System.Drawing.SystemColors.InfoText
        Me.btnDisplayMember.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayMember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDisplayMember.Location = New System.Drawing.Point(199, 107)
        Me.btnDisplayMember.Name = "btnDisplayMember"
        Me.btnDisplayMember.Size = New System.Drawing.Size(257, 44)
        Me.btnDisplayMember.TabIndex = 2
        Me.btnDisplayMember.Text = "Display Member"
        Me.btnDisplayMember.UseVisualStyleBackColor = False
        '
        'btnAddMember
        '
        Me.btnAddMember.BackColor = System.Drawing.SystemColors.InfoText
        Me.btnAddMember.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddMember.Location = New System.Drawing.Point(199, 157)
        Me.btnAddMember.Name = "btnAddMember"
        Me.btnAddMember.Size = New System.Drawing.Size(257, 41)
        Me.btnAddMember.TabIndex = 3
        Me.btnAddMember.Text = "Add a Member"
        Me.btnAddMember.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.InfoText
        Me.btnSearch.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(199, 204)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(257, 43)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search Members"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.InfoText
        Me.btnExit.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(199, 253)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(257, 41)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(651, 341)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAddMember)
        Me.Controls.Add(Me.btnDisplayMember)
        Me.Controls.Add(Me.lblHeading2)
        Me.Controls.Add(Me.lblHeading1)
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading1 As System.Windows.Forms.Label
    Friend WithEvents lblHeading2 As System.Windows.Forms.Label
    Friend WithEvents btnDisplayMember As System.Windows.Forms.Button
    Friend WithEvents btnAddMember As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
