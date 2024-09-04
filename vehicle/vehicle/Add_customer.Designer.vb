<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_customer
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
        Me.cmbusaseas = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtphoneno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtrentingdays = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbookdate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmblistofcompany = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbseatingcapicity = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnavalablecars = New System.Windows.Forms.Button()
        Me.txtcarnumber = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtrentperday = New System.Windows.Forms.TextBox()
        Me.txttotalrent = New System.Windows.Forms.TextBox()
        Me.rtxxtaddress = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbfemale = New System.Windows.Forms.RadioButton()
        Me.rbmale = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtcustomerid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblcarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicledbDataSet = New vehicle.vehicledbDataSet()
        Me.TbladdcustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbladdcustomerTableAdapter = New vehicle.vehicledbDataSetTableAdapters.tbladdcustomerTableAdapter()
        Me.TblcarsTableAdapter = New vehicle.vehicledbDataSetTableAdapters.tblcarsTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtdriverid = New System.Windows.Forms.TextBox()
        Me.lblshow = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicledbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbladdcustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbusaseas
        '
        Me.cmbusaseas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbusaseas.FormattingEnabled = True
        Me.cmbusaseas.Items.AddRange(New Object() {"Taxi", "Induvisual Rent"})
        Me.cmbusaseas.Location = New System.Drawing.Point(183, 384)
        Me.cmbusaseas.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.cmbusaseas.Name = "cmbusaseas"
        Me.cmbusaseas.Size = New System.Drawing.Size(164, 24)
        Me.cmbusaseas.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 384)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Usage as"
        '
        'txtphoneno
        '
        Me.txtphoneno.Location = New System.Drawing.Point(183, 321)
        Me.txtphoneno.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.txtphoneno.Name = "txtphoneno"
        Me.txtphoneno.Size = New System.Drawing.Size(164, 22)
        Me.txtphoneno.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 325)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Phone No."
        '
        'txtrentingdays
        '
        Me.txtrentingdays.Location = New System.Drawing.Point(183, 443)
        Me.txtrentingdays.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.txtrentingdays.Name = "txtrentingdays"
        Me.txtrentingdays.Size = New System.Drawing.Size(164, 22)
        Me.txtrentingdays.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 443)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Renting Days"
        '
        'txtbookdate
        '
        Me.txtbookdate.Location = New System.Drawing.Point(183, 501)
        Me.txtbookdate.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.txtbookdate.Name = "txtbookdate"
        Me.txtbookdate.Size = New System.Drawing.Size(164, 22)
        Me.txtbookdate.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 501)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Book Date"
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(144, 581)
        Me.btnsubmit.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(149, 48)
        Me.btnsubmit.TabIndex = 42
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(545, 53)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 16)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Car Company"
        '
        'cmblistofcompany
        '
        Me.cmblistofcompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblistofcompany.FormattingEnabled = True
        Me.cmblistofcompany.Location = New System.Drawing.Point(655, 43)
        Me.cmblistofcompany.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.cmblistofcompany.Name = "cmblistofcompany"
        Me.cmblistofcompany.Size = New System.Drawing.Size(157, 24)
        Me.cmblistofcompany.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(837, 51)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 16)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Sitting Capacity"
        '
        'cmbseatingcapicity
        '
        Me.cmbseatingcapicity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbseatingcapicity.FormattingEnabled = True
        Me.cmbseatingcapicity.Items.AddRange(New Object() {"3 Seater", "5 Seater", "7 Seater", "8 Seater"})
        Me.cmbseatingcapicity.Location = New System.Drawing.Point(944, 48)
        Me.cmbseatingcapicity.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.cmbseatingcapicity.Name = "cmbseatingcapicity"
        Me.cmbseatingcapicity.Size = New System.Drawing.Size(157, 24)
        Me.cmbseatingcapicity.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(545, 105)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 16)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Car Number"
        '
        'btnavalablecars
        '
        Me.btnavalablecars.Location = New System.Drawing.Point(1132, 86)
        Me.btnavalablecars.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.btnavalablecars.Name = "btnavalablecars"
        Me.btnavalablecars.Size = New System.Drawing.Size(111, 54)
        Me.btnavalablecars.TabIndex = 48
        Me.btnavalablecars.Text = "Available cars"
        Me.btnavalablecars.UseVisualStyleBackColor = True
        '
        'txtcarnumber
        '
        Me.txtcarnumber.Location = New System.Drawing.Point(655, 102)
        Me.txtcarnumber.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.txtcarnumber.Name = "txtcarnumber"
        Me.txtcarnumber.Size = New System.Drawing.Size(132, 22)
        Me.txtcarnumber.TabIndex = 49
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(855, 112)
        Me.Label12.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 16)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Driver ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(439, 577)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 16)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Rent Per Day"
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(687, 565)
        Me.btncalculate.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(97, 27)
        Me.btncalculate.TabIndex = 52
        Me.btncalculate.Text = "Calculate"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(857, 577)
        Me.Label14.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 16)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Total Rent(Rs)"
        '
        'txtrentperday
        '
        Me.txtrentperday.Location = New System.Drawing.Point(575, 571)
        Me.txtrentperday.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.txtrentperday.Name = "txtrentperday"
        Me.txtrentperday.Size = New System.Drawing.Size(67, 22)
        Me.txtrentperday.TabIndex = 54
        '
        'txttotalrent
        '
        Me.txttotalrent.Location = New System.Drawing.Point(969, 577)
        Me.txttotalrent.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.txttotalrent.Name = "txttotalrent"
        Me.txttotalrent.Size = New System.Drawing.Size(132, 22)
        Me.txttotalrent.TabIndex = 55
        '
        'rtxxtaddress
        '
        Me.rtxxtaddress.Location = New System.Drawing.Point(183, 187)
        Me.rtxxtaddress.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.rtxxtaddress.Name = "rtxxtaddress"
        Me.rtxxtaddress.Size = New System.Drawing.Size(164, 95)
        Me.rtxxtaddress.TabIndex = 64
        Me.rtxxtaddress.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 192)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Address"
        '
        'rbfemale
        '
        Me.rbfemale.AutoSize = True
        Me.rbfemale.Location = New System.Drawing.Point(271, 139)
        Me.rbfemale.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.rbfemale.Name = "rbfemale"
        Me.rbfemale.Size = New System.Drawing.Size(71, 20)
        Me.rbfemale.TabIndex = 62
        Me.rbfemale.TabStop = True
        Me.rbfemale.Text = "Female"
        Me.rbfemale.UseVisualStyleBackColor = True
        '
        'rbmale
        '
        Me.rbmale.AutoSize = True
        Me.rbmale.Location = New System.Drawing.Point(183, 139)
        Me.rbmale.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.rbmale.Name = "rbmale"
        Me.rbmale.Size = New System.Drawing.Size(56, 20)
        Me.rbmale.TabIndex = 61
        Me.rbmale.TabStop = True
        Me.rbmale.Text = "Male"
        Me.rbmale.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 139)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Gender"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(183, 69)
        Me.txtname.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(164, 22)
        Me.txtname.TabIndex = 59
        '
        'txtcustomerid
        '
        Me.txtcustomerid.Location = New System.Drawing.Point(183, 17)
        Me.txtcustomerid.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.txtcustomerid.Name = "txtcustomerid"
        Me.txtcustomerid.Size = New System.Drawing.Size(164, 22)
        Me.txtcustomerid.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Customer ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(415, 192)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(817, 325)
        Me.DataGridView1.TabIndex = 65
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
        'TbladdcustomerBindingSource
        '
        Me.TbladdcustomerBindingSource.DataMember = "tbladdcustomer"
        Me.TbladdcustomerBindingSource.DataSource = Me.VehicledbDataSet
        '
        'TbladdcustomerTableAdapter
        '
        Me.TbladdcustomerTableAdapter.ClearBeforeFill = True
        '
        'TblcarsTableAdapter
        '
        Me.TblcarsTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtdriverid
        '
        Me.txtdriverid.Location = New System.Drawing.Point(969, 112)
        Me.txtdriverid.Name = "txtdriverid"
        Me.txtdriverid.Size = New System.Drawing.Size(100, 22)
        Me.txtdriverid.TabIndex = 66
        '
        'lblshow
        '
        Me.lblshow.AutoSize = True
        Me.lblshow.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshow.Location = New System.Drawing.Point(753, 157)
        Me.lblshow.Name = "lblshow"
        Me.lblshow.Size = New System.Drawing.Size(0, 14)
        Me.lblshow.TabIndex = 67
        '
        'Add_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vehicle.My.Resources.Resources._49ddd7ad_e6ae_4981_bcda_1d7f1c934073_WoodBackground
        Me.ClientSize = New System.Drawing.Size(1288, 678)
        Me.Controls.Add(Me.lblshow)
        Me.Controls.Add(Me.txtdriverid)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.rtxxtaddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rbfemale)
        Me.Controls.Add(Me.rbmale)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtcustomerid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttotalrent)
        Me.Controls.Add(Me.txtrentperday)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtcarnumber)
        Me.Controls.Add(Me.btnavalablecars)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbseatingcapicity)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmblistofcompany)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtbookdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtrentingdays)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbusaseas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtphoneno)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(1, 5, 1, 5)
        Me.Name = "Add_customer"
        Me.Text = "Add  Customer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicledbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbladdcustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbusaseas As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtphoneno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtrentingdays As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtbookdate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmblistofcompany As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbseatingcapicity As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnavalablecars As System.Windows.Forms.Button
    Friend WithEvents txtcarnumber As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btncalculate As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtrentperday As System.Windows.Forms.TextBox
    Friend WithEvents txttotalrent As System.Windows.Forms.TextBox
    Friend WithEvents rtxxtaddress As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbfemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbmale As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtcustomerid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VehicledbDataSet As vehicle.vehicledbDataSet
    Friend WithEvents TbladdcustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbladdcustomerTableAdapter As vehicle.vehicledbDataSetTableAdapters.tbladdcustomerTableAdapter
    Friend WithEvents TblcarsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblcarsTableAdapter As vehicle.vehicledbDataSetTableAdapters.tblcarsTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtdriverid As System.Windows.Forms.TextBox
    Friend WithEvents lblshow As System.Windows.Forms.Label
End Class
