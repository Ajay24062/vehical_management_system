<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Return_car
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
        Me.btnsearchbyid = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtcustomer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcarnumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcompany = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtreturndate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbookingdate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btncarreturned = New System.Windows.Forms.Button()
        Me.TbladdcustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicledbDataSet = New vehicle.vehicledbDataSet()
        Me.TblcarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblcarsTableAdapter = New vehicle.vehicledbDataSetTableAdapters.tblcarsTableAdapter()
        Me.TbladdcustomerTableAdapter = New vehicle.vehicledbDataSetTableAdapters.tbladdcustomerTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.TbladdcustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicledbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsearchbyid
        '
        Me.btnsearchbyid.Location = New System.Drawing.Point(345, 37)
        Me.btnsearchbyid.Margin = New System.Windows.Forms.Padding(5)
        Me.btnsearchbyid.Name = "btnsearchbyid"
        Me.btnsearchbyid.Size = New System.Drawing.Size(133, 27)
        Me.btnsearchbyid.TabIndex = 41
        Me.btnsearchbyid.Text = "Search By ID"
        Me.btnsearchbyid.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(185, 90)
        Me.txtname.Margin = New System.Windows.Forms.Padding(5)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(132, 22)
        Me.txtname.TabIndex = 40
        '
        'txtcustomer
        '
        Me.txtcustomer.Location = New System.Drawing.Point(185, 41)
        Me.txtcustomer.Margin = New System.Windows.Forms.Padding(5)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.Size = New System.Drawing.Size(132, 22)
        Me.txtcustomer.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Customer Id"
        '
        'txtcarnumber
        '
        Me.txtcarnumber.Location = New System.Drawing.Point(185, 209)
        Me.txtcarnumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtcarnumber.Name = "txtcarnumber"
        Me.txtcarnumber.Size = New System.Drawing.Size(185, 22)
        Me.txtcarnumber.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 213)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(205, 153)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Car Details"
        '
        'txtcompany
        '
        Me.txtcompany.Location = New System.Drawing.Point(185, 290)
        Me.txtcompany.Margin = New System.Windows.Forms.Padding(5)
        Me.txtcompany.Name = "txtcompany"
        Me.txtcompany.Size = New System.Drawing.Size(185, 22)
        Me.txtcompany.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 290)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Company"
        '
        'txtreturndate
        '
        Me.txtreturndate.Location = New System.Drawing.Point(185, 413)
        Me.txtreturndate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtreturndate.Name = "txtreturndate"
        Me.txtreturndate.Size = New System.Drawing.Size(185, 22)
        Me.txtreturndate.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 417)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Return Date"
        '
        'txtbookingdate
        '
        Me.txtbookingdate.Location = New System.Drawing.Point(185, 349)
        Me.txtbookingdate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtbookingdate.Name = "txtbookingdate"
        Me.txtbookingdate.Size = New System.Drawing.Size(185, 22)
        Me.txtbookingdate.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 358)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 16)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Booking Date"
        '
        'btncarreturned
        '
        Me.btncarreturned.Location = New System.Drawing.Point(232, 469)
        Me.btncarreturned.Margin = New System.Windows.Forms.Padding(5)
        Me.btncarreturned.Name = "btncarreturned"
        Me.btncarreturned.Size = New System.Drawing.Size(123, 39)
        Me.btncarreturned.TabIndex = 54
        Me.btncarreturned.Text = "Car returned"
        Me.btncarreturned.UseVisualStyleBackColor = True
        '
        'TbladdcustomerBindingSource
        '
        Me.TbladdcustomerBindingSource.DataMember = "tbladdcustomer"
        Me.TbladdcustomerBindingSource.DataSource = Me.VehicledbDataSet
        '
        'VehicledbDataSet
        '
        Me.VehicledbDataSet.DataSetName = "vehicledbDataSet"
        Me.VehicledbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblcarsBindingSource
        '
        Me.TblcarsBindingSource.DataMember = "tblcars"
        Me.TblcarsBindingSource.DataSource = Me.VehicledbDataSet
        '
        'TblcarsTableAdapter
        '
        Me.TblcarsTableAdapter.ClearBeforeFill = True
        '
        'TbladdcustomerTableAdapter
        '
        Me.TbladdcustomerTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Return_car
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vehicle.My.Resources.Resources._49ddd7ad_e6ae_4981_bcda_1d7f1c934073_WoodBackground
        Me.ClientSize = New System.Drawing.Size(567, 570)
        Me.Controls.Add(Me.btncarreturned)
        Me.Controls.Add(Me.txtreturndate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbookingdate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcompany)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcarnumber)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnsearchbyid)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtcustomer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Return_car"
        Me.Text = "Return Car"
        CType(Me.TbladdcustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicledbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsearchbyid As System.Windows.Forms.Button
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtcustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcarnumber As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcompany As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtreturndate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtbookingdate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btncarreturned As System.Windows.Forms.Button
    Friend WithEvents VehicledbDataSet As vehicle.vehicledbDataSet
    Friend WithEvents TblcarsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblcarsTableAdapter As vehicle.vehicledbDataSetTableAdapters.tblcarsTableAdapter
    Friend WithEvents TbladdcustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbladdcustomerTableAdapter As vehicle.vehicledbDataSetTableAdapters.tbladdcustomerTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
