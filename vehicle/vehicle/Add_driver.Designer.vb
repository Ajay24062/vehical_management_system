<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_driver
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdriverid = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbmale = New System.Windows.Forms.RadioButton()
        Me.rbfemale = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rtxxtaddress = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtphoneno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbexperience = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdateofjoining = New System.Windows.Forms.TextBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmblistofcompany = New System.Windows.Forms.ComboBox()
        Me.cmbseatingcapicity = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcarnumber = New System.Windows.Forms.TextBox()
        Me.btncaravailable = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblcarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicledbDataSet = New vehicle.vehicledbDataSet()
        Me.TblcarsTableAdapter = New vehicle.vehicledbDataSetTableAdapters.tblcarsTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblshow = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicledbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Driver ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'txtdriverid
        '
        Me.txtdriverid.Location = New System.Drawing.Point(207, 54)
        Me.txtdriverid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdriverid.Name = "txtdriverid"
        Me.txtdriverid.Size = New System.Drawing.Size(157, 22)
        Me.txtdriverid.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(207, 103)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(157, 22)
        Me.txtname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 175)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gender"
        '
        'rbmale
        '
        Me.rbmale.AutoSize = True
        Me.rbmale.Location = New System.Drawing.Point(207, 175)
        Me.rbmale.Margin = New System.Windows.Forms.Padding(4)
        Me.rbmale.Name = "rbmale"
        Me.rbmale.Size = New System.Drawing.Size(56, 20)
        Me.rbmale.TabIndex = 5
        Me.rbmale.TabStop = True
        Me.rbmale.Text = "Male"
        Me.rbmale.UseVisualStyleBackColor = True
        '
        'rbfemale
        '
        Me.rbfemale.AutoSize = True
        Me.rbfemale.Location = New System.Drawing.Point(293, 175)
        Me.rbfemale.Margin = New System.Windows.Forms.Padding(4)
        Me.rbfemale.Name = "rbfemale"
        Me.rbfemale.Size = New System.Drawing.Size(71, 20)
        Me.rbfemale.TabIndex = 6
        Me.rbfemale.TabStop = True
        Me.rbfemale.Text = "Female"
        Me.rbfemale.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 244)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Address"
        '
        'rtxxtaddress
        '
        Me.rtxxtaddress.Location = New System.Drawing.Point(207, 224)
        Me.rtxxtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.rtxxtaddress.Name = "rtxxtaddress"
        Me.rtxxtaddress.Size = New System.Drawing.Size(157, 95)
        Me.rtxxtaddress.TabIndex = 8
        Me.rtxxtaddress.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 356)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Phone No"
        '
        'txtphoneno
        '
        Me.txtphoneno.Location = New System.Drawing.Point(207, 353)
        Me.txtphoneno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtphoneno.Name = "txtphoneno"
        Me.txtphoneno.Size = New System.Drawing.Size(157, 22)
        Me.txtphoneno.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 411)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Experience"
        '
        'cmbexperience
        '
        Me.cmbexperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbexperience.FormattingEnabled = True
        Me.cmbexperience.Items.AddRange(New Object() {"No Expirience", "Less Than 1 Year", "1-2 Year", "2-3 Year", "3-4 Year", "4-5 Year", "Above 5 Year"})
        Me.cmbexperience.Location = New System.Drawing.Point(207, 411)
        Me.cmbexperience.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbexperience.Name = "cmbexperience"
        Me.cmbexperience.Size = New System.Drawing.Size(157, 24)
        Me.cmbexperience.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 478)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Date Of Birth"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(56, 524)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Date Of Joining"
        '
        'txtdateofjoining
        '
        Me.txtdateofjoining.Location = New System.Drawing.Point(207, 524)
        Me.txtdateofjoining.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdateofjoining.Name = "txtdateofjoining"
        Me.txtdateofjoining.Size = New System.Drawing.Size(157, 22)
        Me.txtdateofjoining.TabIndex = 18
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(176, 582)
        Me.btnsubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(116, 41)
        Me.btnsubmit.TabIndex = 19
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(573, 32)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Select Company"
        '
        'cmblistofcompany
        '
        Me.cmblistofcompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblistofcompany.FormattingEnabled = True
        Me.cmblistofcompany.Location = New System.Drawing.Point(725, 29)
        Me.cmblistofcompany.Margin = New System.Windows.Forms.Padding(4)
        Me.cmblistofcompany.Name = "cmblistofcompany"
        Me.cmblistofcompany.Size = New System.Drawing.Size(132, 24)
        Me.cmblistofcompany.TabIndex = 21
        '
        'cmbseatingcapicity
        '
        Me.cmbseatingcapicity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbseatingcapicity.FormattingEnabled = True
        Me.cmbseatingcapicity.Items.AddRange(New Object() {"3 Seater", "5 Seater", "7 Seater", "8 Seater"})
        Me.cmbseatingcapicity.Location = New System.Drawing.Point(1032, 28)
        Me.cmbseatingcapicity.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbseatingcapicity.Name = "cmbseatingcapicity"
        Me.cmbseatingcapicity.Size = New System.Drawing.Size(160, 24)
        Me.cmbseatingcapicity.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(913, 36)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Seating Capicity"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(573, 106)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Car No."
        '
        'txtcarnumber
        '
        Me.txtcarnumber.Location = New System.Drawing.Point(725, 100)
        Me.txtcarnumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcarnumber.Name = "txtcarnumber"
        Me.txtcarnumber.Size = New System.Drawing.Size(132, 22)
        Me.txtcarnumber.TabIndex = 25
        '
        'btncaravailable
        '
        Me.btncaravailable.Location = New System.Drawing.Point(1011, 100)
        Me.btncaravailable.Margin = New System.Windows.Forms.Padding(4)
        Me.btncaravailable.Name = "btncaravailable"
        Me.btncaravailable.Size = New System.Drawing.Size(132, 40)
        Me.btncaravailable.TabIndex = 26
        Me.btncaravailable.Text = "Car Avialable"
        Me.btncaravailable.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(551, 208)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(693, 318)
        Me.DataGridView1.TabIndex = 27
        '
        'TblcarsBindingSource
        '
        Me.TblcarsBindingSource.DataMember = "tblcars"
        Me.TblcarsBindingSource.DataSource = Me.VehicledbDataSet
        '
        'VehicledbDataSet
        '
        Me.VehicledbDataSet.DataSetName = "vehicledbDataSet"
        Me.VehicledbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblcarsTableAdapter
        '
        Me.TblcarsTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(207, 472)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.MaxDate = New Date(1999, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1965, 4, 10, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(157, 22)
        Me.DateTimePicker1.TabIndex = 39
        Me.DateTimePicker1.Value = New Date(1999, 12, 31, 0, 0, 0, 0)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblshow
        '
        Me.lblshow.AutoSize = True
        Me.lblshow.Font = New System.Drawing.Font("Georgia", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshow.Location = New System.Drawing.Point(722, 150)
        Me.lblshow.Name = "lblshow"
        Me.lblshow.Size = New System.Drawing.Size(0, 14)
        Me.lblshow.TabIndex = 40
        '
        'Add_driver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vehicle.My.Resources.Resources._49ddd7ad_e6ae_4981_bcda_1d7f1c934073_WoodBackground
        Me.ClientSize = New System.Drawing.Size(1245, 649)
        Me.Controls.Add(Me.lblshow)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btncaravailable)
        Me.Controls.Add(Me.txtcarnumber)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbseatingcapicity)
        Me.Controls.Add(Me.cmblistofcompany)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtdateofjoining)
        Me.Controls.Add(Me.Label8)
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
        Me.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Add_driver"
        Me.Text = "Add Driver"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicledbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdriverid As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbmale As System.Windows.Forms.RadioButton
    Friend WithEvents rbfemale As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rtxxtaddress As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtphoneno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbexperience As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtdateofjoining As System.Windows.Forms.TextBox
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmblistofcompany As System.Windows.Forms.ComboBox
    Friend WithEvents cmbseatingcapicity As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtcarnumber As System.Windows.Forms.TextBox
    Friend WithEvents btncaravailable As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VehicledbDataSet As vehicle.vehicledbDataSet
    Friend WithEvents TblcarsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblcarsTableAdapter As vehicle.vehicledbDataSetTableAdapters.tblcarsTableAdapter
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblshow As System.Windows.Forms.Label
End Class
