<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modify_driver
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
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbexperience = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtphoneno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rtxxtaddress = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbfemale = New System.Windows.Forms.RadioButton()
        Me.rbmale = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtdriverid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(142, 560)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(110, 48)
        Me.btnupdate.TabIndex = 38
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(322, 560)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(113, 48)
        Me.btndelete.TabIndex = 39
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 486)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 16)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Date Of Birth"
        '
        'cmbexperience
        '
        Me.cmbexperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbexperience.FormattingEnabled = True
        Me.cmbexperience.Items.AddRange(New Object() {"No Expirience", "Less Than 1 Year", "1-2 Year", "2-3 Year", "3-4 Year", "4-5 Year", "Above 5 Year"})
        Me.cmbexperience.Location = New System.Drawing.Point(179, 419)
        Me.cmbexperience.Name = "cmbexperience"
        Me.cmbexperience.Size = New System.Drawing.Size(159, 24)
        Me.cmbexperience.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 419)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Experience"
        '
        'txtphoneno
        '
        Me.txtphoneno.Location = New System.Drawing.Point(179, 362)
        Me.txtphoneno.Name = "txtphoneno"
        Me.txtphoneno.Size = New System.Drawing.Size(159, 22)
        Me.txtphoneno.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Phone No"
        '
        'rtxxtaddress
        '
        Me.rtxxtaddress.Location = New System.Drawing.Point(179, 233)
        Me.rtxxtaddress.Name = "rtxxtaddress"
        Me.rtxxtaddress.Size = New System.Drawing.Size(159, 95)
        Me.rtxxtaddress.TabIndex = 48
        Me.rtxxtaddress.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Address"
        '
        'rbfemale
        '
        Me.rbfemale.AutoSize = True
        Me.rbfemale.Location = New System.Drawing.Point(279, 183)
        Me.rbfemale.Name = "rbfemale"
        Me.rbfemale.Size = New System.Drawing.Size(71, 20)
        Me.rbfemale.TabIndex = 46
        Me.rbfemale.TabStop = True
        Me.rbfemale.Text = "Female"
        Me.rbfemale.UseVisualStyleBackColor = True
        '
        'rbmale
        '
        Me.rbmale.AutoSize = True
        Me.rbmale.Location = New System.Drawing.Point(179, 183)
        Me.rbmale.Name = "rbmale"
        Me.rbmale.Size = New System.Drawing.Size(56, 20)
        Me.rbmale.TabIndex = 45
        Me.rbmale.TabStop = True
        Me.rbmale.Text = "Male"
        Me.rbmale.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Gender"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(179, 112)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(157, 22)
        Me.txtname.TabIndex = 43
        '
        'txtdriverid
        '
        Me.txtdriverid.Location = New System.Drawing.Point(179, 63)
        Me.txtdriverid.Name = "txtdriverid"
        Me.txtdriverid.Size = New System.Drawing.Size(157, 22)
        Me.txtdriverid.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Driver ID"
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(393, 63)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(99, 29)
        Me.btnsearch.TabIndex = 57
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(179, 486)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.MaxDate = New Date(1999, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1965, 4, 10, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(157, 22)
        Me.DateTimePicker1.TabIndex = 58
        Me.DateTimePicker1.Value = New Date(1999, 12, 31, 0, 0, 0, 0)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Modify_driver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vehicle.My.Resources.Resources._49ddd7ad_e6ae_4981_bcda_1d7f1c934073_WoodBackground
        Me.ClientSize = New System.Drawing.Size(664, 620)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbexperience)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtphoneno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rtxxtaddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rbfemale)
        Me.Controls.Add(Me.rbmale)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtdriverid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Modify_driver"
        Me.Text = "Modify_driver"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbexperience As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtphoneno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rtxxtaddress As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbfemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbmale As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtdriverid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
