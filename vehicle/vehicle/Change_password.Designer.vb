<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_password
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
        Me.txtreenterpassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcurrentpassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtchangepassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtreenterpassword
        '
        Me.txtreenterpassword.Location = New System.Drawing.Point(328, 262)
        Me.txtreenterpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtreenterpassword.Name = "txtreenterpassword"
        Me.txtreenterpassword.Size = New System.Drawing.Size(184, 23)
        Me.txtreenterpassword.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(161, 262)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 17)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Re-Enter password"
        '
        'txtcurrentpassword
        '
        Me.txtcurrentpassword.Location = New System.Drawing.Point(328, 162)
        Me.txtcurrentpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcurrentpassword.Name = "txtcurrentpassword"
        Me.txtcurrentpassword.Size = New System.Drawing.Size(184, 23)
        Me.txtcurrentpassword.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(161, 162)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 17)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Current Password"
        '
        'txtchangepassword
        '
        Me.txtchangepassword.Location = New System.Drawing.Point(328, 209)
        Me.txtchangepassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtchangepassword.Name = "txtchangepassword"
        Me.txtchangepassword.Size = New System.Drawing.Size(184, 23)
        Me.txtchangepassword.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 209)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Change password"
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(256, 342)
        Me.btnsubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(204, 64)
        Me.btnsubmit.TabIndex = 56
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'Change_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vehicle.My.Resources.Resources._49ddd7ad_e6ae_4981_bcda_1d7f1c934073_WoodBackground
        Me.ClientSize = New System.Drawing.Size(779, 528)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtchangepassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtreenterpassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcurrentpassword)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Change_password"
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtreenterpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcurrentpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtchangepassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
End Class
