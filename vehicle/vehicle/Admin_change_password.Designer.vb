<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_change_password
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
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.txtchangepassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtreenterpassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcurrentpassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(251, 262)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(191, 58)
        Me.btnsubmit.TabIndex = 63
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'txtchangepassword
        '
        Me.txtchangepassword.Location = New System.Drawing.Point(335, 139)
        Me.txtchangepassword.Multiline = True
        Me.txtchangepassword.Name = "txtchangepassword"
        Me.txtchangepassword.Size = New System.Drawing.Size(183, 29)
        Me.txtchangepassword.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Change password"
        '
        'txtreenterpassword
        '
        Me.txtreenterpassword.Location = New System.Drawing.Point(335, 189)
        Me.txtreenterpassword.Multiline = True
        Me.txtreenterpassword.Name = "txtreenterpassword"
        Me.txtreenterpassword.Size = New System.Drawing.Size(183, 31)
        Me.txtreenterpassword.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 16)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Re-Enter password"
        '
        'txtcurrentpassword
        '
        Me.txtcurrentpassword.Location = New System.Drawing.Point(335, 90)
        Me.txtcurrentpassword.Multiline = True
        Me.txtcurrentpassword.Name = "txtcurrentpassword"
        Me.txtcurrentpassword.Size = New System.Drawing.Size(183, 29)
        Me.txtcurrentpassword.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(158, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 16)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Current Password"
        '
        'Admin_change_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vehicle.My.Resources.Resources._49ddd7ad_e6ae_4981_bcda_1d7f1c934073_WoodBackground
        Me.ClientSize = New System.Drawing.Size(689, 418)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtchangepassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtreenterpassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcurrentpassword)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Admin_change_password"
        Me.Text = "Admin_change_password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents txtchangepassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtreenterpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcurrentpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
