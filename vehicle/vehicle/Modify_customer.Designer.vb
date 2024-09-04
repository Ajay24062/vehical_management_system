<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modify_customer
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
        Me.btnsearchbyid = New System.Windows.Forms.Button()
        Me.txtphoneno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rtxxtaddress = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbfemale = New System.Windows.Forms.RadioButton()
        Me.rbmale = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtcustomerid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbladdcustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicledbDataSet = New vehicle.vehicledbDataSet()
        Me.TbladdcustomerTableAdapter = New vehicle.vehicledbDataSetTableAdapters.tbladdcustomerTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.TbladdcustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicledbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(81, 419)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(135, 43)
        Me.btnupdate.TabIndex = 33
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(302, 419)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(131, 43)
        Me.btndelete.TabIndex = 34
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsearchbyid
        '
        Me.btnsearchbyid.Location = New System.Drawing.Point(377, 12)
        Me.btnsearchbyid.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsearchbyid.Name = "btnsearchbyid"
        Me.btnsearchbyid.Size = New System.Drawing.Size(132, 28)
        Me.btnsearchbyid.TabIndex = 69
        Me.btnsearchbyid.Text = "Search By ID"
        Me.btnsearchbyid.UseVisualStyleBackColor = True
        '
        'txtphoneno
        '
        Me.txtphoneno.Location = New System.Drawing.Point(160, 320)
        Me.txtphoneno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtphoneno.Name = "txtphoneno"
        Me.txtphoneno.Size = New System.Drawing.Size(176, 22)
        Me.txtphoneno.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 320)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Phone No"
        '
        'rtxxtaddress
        '
        Me.rtxxtaddress.Location = New System.Drawing.Point(160, 191)
        Me.rtxxtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.rtxxtaddress.Name = "rtxxtaddress"
        Me.rtxxtaddress.Size = New System.Drawing.Size(176, 95)
        Me.rtxxtaddress.TabIndex = 66
        Me.rtxxtaddress.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 194)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Address"
        '
        'rbfemale
        '
        Me.rbfemale.AutoSize = True
        Me.rbfemale.Location = New System.Drawing.Point(259, 142)
        Me.rbfemale.Margin = New System.Windows.Forms.Padding(4)
        Me.rbfemale.Name = "rbfemale"
        Me.rbfemale.Size = New System.Drawing.Size(71, 20)
        Me.rbfemale.TabIndex = 64
        Me.rbfemale.TabStop = True
        Me.rbfemale.Text = "Female"
        Me.rbfemale.UseVisualStyleBackColor = True
        '
        'rbmale
        '
        Me.rbmale.AutoSize = True
        Me.rbmale.Location = New System.Drawing.Point(160, 142)
        Me.rbmale.Margin = New System.Windows.Forms.Padding(4)
        Me.rbmale.Name = "rbmale"
        Me.rbmale.Size = New System.Drawing.Size(56, 20)
        Me.rbmale.TabIndex = 63
        Me.rbmale.TabStop = True
        Me.rbmale.Text = "Male"
        Me.rbmale.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Gender"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(160, 70)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(157, 22)
        Me.txtname.TabIndex = 61
        '
        'txtcustomerid
        '
        Me.txtcustomerid.Location = New System.Drawing.Point(160, 21)
        Me.txtcustomerid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcustomerid.Name = "txtcustomerid"
        Me.txtcustomerid.Size = New System.Drawing.Size(157, 22)
        Me.txtcustomerid.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Customer Id"
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
        'TbladdcustomerTableAdapter
        '
        Me.TbladdcustomerTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Modify_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vehicle.My.Resources.Resources._49ddd7ad_e6ae_4981_bcda_1d7f1c934073_WoodBackground
        Me.ClientSize = New System.Drawing.Size(632, 587)
        Me.Controls.Add(Me.btnsearchbyid)
        Me.Controls.Add(Me.txtphoneno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rtxxtaddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rbfemale)
        Me.Controls.Add(Me.rbmale)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtcustomerid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Modify_customer"
        Me.Text = "Modify Customer"
        CType(Me.TbladdcustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicledbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsearchbyid As System.Windows.Forms.Button
    Friend WithEvents txtphoneno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rtxxtaddress As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbfemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbmale As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtcustomerid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VehicledbDataSet As vehicle.vehicledbDataSet
    Friend WithEvents TbladdcustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbladdcustomerTableAdapter As vehicle.vehicledbDataSetTableAdapters.tbladdcustomerTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
