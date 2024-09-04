<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_car_company
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
        Me.btnaddcompany = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmblistofcompany = New System.Windows.Forms.ComboBox()
        Me.txtcompanyname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnaddcompany
        '
        Me.btnaddcompany.Location = New System.Drawing.Point(208, 214)
        Me.btnaddcompany.Margin = New System.Windows.Forms.Padding(5)
        Me.btnaddcompany.Name = "btnaddcompany"
        Me.btnaddcompany.Size = New System.Drawing.Size(129, 43)
        Me.btnaddcompany.TabIndex = 0
        Me.btnaddcompany.Text = "Add Company"
        Me.btnaddcompany.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List Of Added Companies"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 137)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Company Name"
        '
        'cmblistofcompany
        '
        Me.cmblistofcompany.AccessibleDescription = ""
        Me.cmblistofcompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblistofcompany.FormattingEnabled = True
        Me.cmblistofcompany.ItemHeight = 16
        Me.cmblistofcompany.Location = New System.Drawing.Point(233, 69)
        Me.cmblistofcompany.Margin = New System.Windows.Forms.Padding(5)
        Me.cmblistofcompany.Name = "cmblistofcompany"
        Me.cmblistofcompany.Size = New System.Drawing.Size(159, 24)
        Me.cmblistofcompany.Sorted = True
        Me.cmblistofcompany.TabIndex = 3
        '
        'txtcompanyname
        '
        Me.txtcompanyname.Location = New System.Drawing.Point(233, 131)
        Me.txtcompanyname.Margin = New System.Windows.Forms.Padding(5)
        Me.txtcompanyname.Name = "txtcompanyname"
        Me.txtcompanyname.Size = New System.Drawing.Size(159, 22)
        Me.txtcompanyname.TabIndex = 4
        '
        'Add_car_company
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vehicle.My.Resources.Resources._49ddd7ad_e6ae_4981_bcda_1d7f1c934073_WoodBackground
        Me.ClientSize = New System.Drawing.Size(592, 352)
        Me.Controls.Add(Me.txtcompanyname)
        Me.Controls.Add(Me.cmblistofcompany)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnaddcompany)
        Me.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Add_car_company"
        Me.Text = "Add Car Company"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnaddcompany As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmblistofcompany As System.Windows.Forms.ComboBox
    Friend WithEvents txtcompanyname As System.Windows.Forms.TextBox
End Class
