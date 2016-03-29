<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayAllMember
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
        Me.btnDisplayAllMember = New System.Windows.Forms.Button()
        Me.btnDisplayOnlyMales = New System.Windows.Forms.Button()
        Me.btnDisplayOnlyFemales = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstDetails = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDisplayAllMember
        '
        Me.btnDisplayAllMember.BackColor = System.Drawing.SystemColors.InfoText
        Me.btnDisplayAllMember.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayAllMember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDisplayAllMember.Location = New System.Drawing.Point(44, 50)
        Me.btnDisplayAllMember.Name = "btnDisplayAllMember"
        Me.btnDisplayAllMember.Size = New System.Drawing.Size(257, 44)
        Me.btnDisplayAllMember.TabIndex = 3
        Me.btnDisplayAllMember.Text = "Display All Member"
        Me.btnDisplayAllMember.UseVisualStyleBackColor = False
        '
        'btnDisplayOnlyMales
        '
        Me.btnDisplayOnlyMales.BackColor = System.Drawing.SystemColors.InfoText
        Me.btnDisplayOnlyMales.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayOnlyMales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDisplayOnlyMales.Location = New System.Drawing.Point(340, 50)
        Me.btnDisplayOnlyMales.Name = "btnDisplayOnlyMales"
        Me.btnDisplayOnlyMales.Size = New System.Drawing.Size(257, 44)
        Me.btnDisplayOnlyMales.TabIndex = 4
        Me.btnDisplayOnlyMales.Text = "Display Only Males"
        Me.btnDisplayOnlyMales.UseVisualStyleBackColor = False
        '
        'btnDisplayOnlyFemales
        '
        Me.btnDisplayOnlyFemales.BackColor = System.Drawing.SystemColors.InfoText
        Me.btnDisplayOnlyFemales.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayOnlyFemales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDisplayOnlyFemales.Location = New System.Drawing.Point(340, 100)
        Me.btnDisplayOnlyFemales.Name = "btnDisplayOnlyFemales"
        Me.btnDisplayOnlyFemales.Size = New System.Drawing.Size(257, 44)
        Me.btnDisplayOnlyFemales.TabIndex = 5
        Me.btnDisplayOnlyFemales.Text = "Display Only Females"
        Me.btnDisplayOnlyFemales.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.InfoText
        Me.btnClose.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(582, 305)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(136, 44)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lstDetails
        '
        Me.lstDetails.BackColor = System.Drawing.SystemColors.GrayText
        Me.lstDetails.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDetails.ForeColor = System.Drawing.Color.Black
        Me.lstDetails.FormattingEnabled = True
        Me.lstDetails.ItemHeight = 16
        Me.lstDetails.Location = New System.Drawing.Point(44, 158)
        Me.lstDetails.Name = "lstDetails"
        Me.lstDetails.Size = New System.Drawing.Size(504, 164)
        Me.lstDetails.TabIndex = 7
        '
        'DisplayAllMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(730, 361)
        Me.Controls.Add(Me.lstDetails)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDisplayOnlyFemales)
        Me.Controls.Add(Me.btnDisplayOnlyMales)
        Me.Controls.Add(Me.btnDisplayAllMember)
        Me.Name = "DisplayAllMember"
        Me.Text = "DisplayMember"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDisplayAllMember As System.Windows.Forms.Button
    Friend WithEvents btnDisplayOnlyMales As System.Windows.Forms.Button
    Friend WithEvents btnDisplayOnlyFemales As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lstDetails As System.Windows.Forms.ListBox
End Class
