<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_records
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhonenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequirementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DriveridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentingdaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalbillDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbladdcustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicledbDataSet = New vehicle.vehicledbDataSet()
        Me.TbladdcustomerTableAdapter = New vehicle.vehicledbDataSetTableAdapters.tbladdcustomerTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbladdcustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicledbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustidDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhonenoDataGridViewTextBoxColumn, Me.RequirementDataGridViewTextBoxColumn, Me.DriveridDataGridViewTextBoxColumn, Me.CarnumberDataGridViewTextBoxColumn, Me.RentingdaysDataGridViewTextBoxColumn, Me.TotalbillDataGridViewTextBoxColumn, Me.BdateDataGridViewTextBoxColumn, Me.RdateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbladdcustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(75, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1072, 336)
        Me.DataGridView1.TabIndex = 0
        '
        'CustidDataGridViewTextBoxColumn
        '
        Me.CustidDataGridViewTextBoxColumn.DataPropertyName = "cust_id"
        Me.CustidDataGridViewTextBoxColumn.HeaderText = "cust_id"
        Me.CustidDataGridViewTextBoxColumn.Name = "CustidDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'PhonenoDataGridViewTextBoxColumn
        '
        Me.PhonenoDataGridViewTextBoxColumn.DataPropertyName = "phoneno"
        Me.PhonenoDataGridViewTextBoxColumn.HeaderText = "phoneno"
        Me.PhonenoDataGridViewTextBoxColumn.Name = "PhonenoDataGridViewTextBoxColumn"
        '
        'RequirementDataGridViewTextBoxColumn
        '
        Me.RequirementDataGridViewTextBoxColumn.DataPropertyName = "requirement"
        Me.RequirementDataGridViewTextBoxColumn.HeaderText = "requirement"
        Me.RequirementDataGridViewTextBoxColumn.Name = "RequirementDataGridViewTextBoxColumn"
        '
        'DriveridDataGridViewTextBoxColumn
        '
        Me.DriveridDataGridViewTextBoxColumn.DataPropertyName = "driver_id"
        Me.DriveridDataGridViewTextBoxColumn.HeaderText = "driver_id"
        Me.DriveridDataGridViewTextBoxColumn.Name = "DriveridDataGridViewTextBoxColumn"
        '
        'CarnumberDataGridViewTextBoxColumn
        '
        Me.CarnumberDataGridViewTextBoxColumn.DataPropertyName = "carnumber"
        Me.CarnumberDataGridViewTextBoxColumn.HeaderText = "carnumber"
        Me.CarnumberDataGridViewTextBoxColumn.Name = "CarnumberDataGridViewTextBoxColumn"
        '
        'RentingdaysDataGridViewTextBoxColumn
        '
        Me.RentingdaysDataGridViewTextBoxColumn.DataPropertyName = "rentingdays"
        Me.RentingdaysDataGridViewTextBoxColumn.HeaderText = "rentingdays"
        Me.RentingdaysDataGridViewTextBoxColumn.Name = "RentingdaysDataGridViewTextBoxColumn"
        '
        'TotalbillDataGridViewTextBoxColumn
        '
        Me.TotalbillDataGridViewTextBoxColumn.DataPropertyName = "totalbill"
        Me.TotalbillDataGridViewTextBoxColumn.HeaderText = "totalbill"
        Me.TotalbillDataGridViewTextBoxColumn.Name = "TotalbillDataGridViewTextBoxColumn"
        Me.TotalbillDataGridViewTextBoxColumn.Visible = False
        '
        'BdateDataGridViewTextBoxColumn
        '
        Me.BdateDataGridViewTextBoxColumn.DataPropertyName = "bdate"
        Me.BdateDataGridViewTextBoxColumn.HeaderText = "bdate"
        Me.BdateDataGridViewTextBoxColumn.Name = "BdateDataGridViewTextBoxColumn"
        Me.BdateDataGridViewTextBoxColumn.Visible = False
        '
        'RdateDataGridViewTextBoxColumn
        '
        Me.RdateDataGridViewTextBoxColumn.DataPropertyName = "rdate"
        Me.RdateDataGridViewTextBoxColumn.HeaderText = "rdate"
        Me.RdateDataGridViewTextBoxColumn.Name = "RdateDataGridViewTextBoxColumn"
        Me.RdateDataGridViewTextBoxColumn.Visible = False
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
        'Customer_records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vehicle.My.Resources.Resources._49ddd7ad_e6ae_4981_bcda_1d7f1c934073_WoodBackground
        Me.ClientSize = New System.Drawing.Size(1170, 496)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Georgia", 10.0!)
        Me.Name = "Customer_records"
        Me.Text = "All customers"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbladdcustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicledbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VehicledbDataSet As vehicle.vehicledbDataSet
    Friend WithEvents TbladdcustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbladdcustomerTableAdapter As vehicle.vehicledbDataSetTableAdapters.tbladdcustomerTableAdapter
    Friend WithEvents CustidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhonenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequirementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriveridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RentingdaysDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalbillDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
