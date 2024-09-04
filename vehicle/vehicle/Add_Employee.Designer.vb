<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Employee
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
        Me.components = New System.ComponentModel.Container()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbqualification = New System.Windows.Forms.ComboBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdateofjoining = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rtxxtaddress = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbfemale = New System.Windows.Forms.RadioButton()
        Me.rbmale = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtphoneno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 406)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Qualification"
        '
        'cmbqualification
        '
        Me.cmbqualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbqualification.FormattingEnabled = True
        Me.cmbqualification.Items.AddRange(New Object() {"10th", "12th", "degree"})
        Me.cmbqualification.Location = New System.Drawing.Point(156, 395)
        Me.cmbqualification.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbqualification.Name = "cmbqualification"
        Me.cmbqualification.Size = New System.Drawing.Size(160, 24)
        Me.cmbqualification.TabIndex = 12
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(728, 111)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(132, 22)
        Me.txtusername.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(592, 119)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Username"
        '
        'txtdateofjoining
        '
        Me.txtdateofjoining.Location = New System.Drawing.Point(728, 236)
        Me.txtdateofjoining.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdateofjoining.Name = "txtdateofjoining"
        Me.txtdateofjoining.Size = New System.Drawing.Size(132, 22)
        Me.txtdateofjoining.TabIndex = 21
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(728, 187)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(132, 22)
        Me.txtpassword.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(592, 245)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Date Of Joining"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(592, 191)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Password"
        '
        'rtxxtaddress
        '
        Me.rtxxtaddress.Location = New System.Drawing.Point(192, 160)
        Me.rtxxtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.rtxxtaddress.Name = "rtxxtaddress"
        Me.rtxxtaddress.Size = New System.Drawing.Size(176, 95)
        Me.rtxxtaddress.TabIndex = 28
        Me.rtxxtaddress.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 164)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Address"
        '
        'rbfemale
        '
        Me.rbfemale.AutoSize = True
        Me.rbfemale.Location = New System.Drawing.Point(291, 111)
        Me.rbfemale.Margin = New System.Windows.Forms.Padding(4)
        Me.rbfemale.Name = "rbfemale"
        Me.rbfemale.Size = New System.Drawing.Size(71, 20)
        Me.rbfemale.TabIndex = 26
        Me.rbfemale.TabStop = True
        Me.rbfemale.Text = "Female"
        Me.rbfemale.UseVisualStyleBackColor = True
        '
        'rbmale
        '
        Me.rbmale.AutoSize = True
        Me.rbmale.Location = New System.Drawing.Point(192, 111)
        Me.rbmale.Margin = New System.Windows.Forms.Padding(4)
        Me.rbmale.Name = "rbmale"
        Me.rbmale.Size = New System.Drawing.Size(56, 20)
        Me.rbmale.TabIndex = 25
        Me.rbmale.TabStop = True
        Me.rbmale.Text = "Male"
        Me.rbmale.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Gender"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(192, 39)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(132, 22)
        Me.txtname.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(56, 48)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Name"
        '
        'txtphoneno
        '
        Me.txtphoneno.Location = New System.Drawing.Point(728, 63)
        Me.txtphoneno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtphoneno.Name = "txtphoneno"
        Me.txtphoneno.Size = New System.Drawing.Size(132, 22)
        Me.txtphoneno.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(596, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Phone No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 337)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 16)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Date Of Birth"
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(651, 468)
        Me.btnsubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(133, 46)
        Me.btnsubmit.TabIndex = 37
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(173, 330)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.MaxDate = New Date(1999, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1965, 4, 10, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(189, 22)
        Me.DateTimePicker1.TabIndex = 38
        Me.DateTimePicker1.Value = New Date(1999, 12, 31, 0, 0, 0, 0)
        '
        'Add_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vehicle.My.Resources.Resources._49ddd7ad_e6ae_4981_bcda_1d7f1c934073_WoodBackground
        Me.ClientSize = New System.Drawing.Size(1051, 620)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtphoneno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtxxtaddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbfemale)
        Me.Controls.Add(Me.rbmale)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtdateofjoining)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbqualification)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Add_Employee"
        Me.Text = "Add Employee"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbqualification As System.Windows.Forms.ComboBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdateofjoining As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rtxxtaddress As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbfemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbmale As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtphoneno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
