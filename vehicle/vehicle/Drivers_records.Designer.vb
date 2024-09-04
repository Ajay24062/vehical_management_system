<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Drivers_records
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
        Me.DriveridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhonenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExperienceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofjoiningDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbladddriverBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicledbDataSet2 = New vehicle.vehicledbDataSet2()
        Me.TbladddriverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicledbDataSet1 = New vehicle.vehicledbDataSet1()
        Me.VehicledbDataSet = New vehicle.vehicledbDataSet()
        Me.VehicledbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbladdemployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbladdemployeeTableAdapter = New vehicle.vehicledbDataSet1TableAdapters.tbladdemployeeTableAdapter()
        Me.VehicledbDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbladddriverTableAdapter = New vehicle.vehicledbDataSet1TableAdapters.tbladddriverTableAdapter()
        Me.TbladddriverBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbladddriverTableAdapter1 = New vehicle.vehicledbDataSet2TableAdapters.tbladddriverTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbladddriverBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicledbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbladddriverBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicledbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicledbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicledbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbladdemployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicledbDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbladddriverBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DriveridDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhonenoDataGridViewTextBoxColumn, Me.ExperienceDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.DateofjoiningDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbladddriverBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(46, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1099, 506)
        Me.DataGridView1.TabIndex = 0
        '
        'DriveridDataGridViewTextBoxColumn
        '
        Me.DriveridDataGridViewTextBoxColumn.DataPropertyName = "driverid"
        Me.DriveridDataGridViewTextBoxColumn.HeaderText = "driverid"
        Me.DriveridDataGridViewTextBoxColumn.Name = "DriveridDataGridViewTextBoxColumn"
        Me.DriveridDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhonenoDataGridViewTextBoxColumn
        '
        Me.PhonenoDataGridViewTextBoxColumn.DataPropertyName = "phoneno"
        Me.PhonenoDataGridViewTextBoxColumn.HeaderText = "phoneno"
        Me.PhonenoDataGridViewTextBoxColumn.Name = "PhonenoDataGridViewTextBoxColumn"
        Me.PhonenoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExperienceDataGridViewTextBoxColumn
        '
        Me.ExperienceDataGridViewTextBoxColumn.DataPropertyName = "experience"
        Me.ExperienceDataGridViewTextBoxColumn.HeaderText = "experience"
        Me.ExperienceDataGridViewTextBoxColumn.Name = "ExperienceDataGridViewTextBoxColumn"
        Me.ExperienceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        Me.DobDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateofjoiningDataGridViewTextBoxColumn
        '
        Me.DateofjoiningDataGridViewTextBoxColumn.DataPropertyName = "dateofjoining"
        Me.DateofjoiningDataGridViewTextBoxColumn.HeaderText = "dateofjoining"
        Me.DateofjoiningDataGridViewTextBoxColumn.Name = "DateofjoiningDataGridViewTextBoxColumn"
        Me.DateofjoiningDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TbladddriverBindingSource2
        '
        Me.TbladddriverBindingSource2.DataMember = "tbladddriver"
        Me.TbladddriverBindingSource2.DataSource = Me.VehicledbDataSet2
        '
        'VehicledbDataSet2
        '
        Me.VehicledbDataSet2.DataSetName = "vehicledbDataSet2"
        Me.VehicledbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbladddriverBindingSource
        '
        Me.TbladddriverBindingSource.DataMember = "tbladddriver"
        Me.TbladddriverBindingSource.DataSource = Me.VehicledbDataSet1
        '
        'VehicledbDataSet1
        '
        Me.VehicledbDataSet1.DataSetName = "vehicledbDataSet1"
        Me.VehicledbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehicledbDataSet
        '
        Me.VehicledbDataSet.DataSetName = "vehicledbDataSet"
        Me.VehicledbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehicledbDataSetBindingSource
        '
        Me.VehicledbDataSetBindingSource.DataSource = Me.VehicledbDataSet
        Me.VehicledbDataSetBindingSource.Position = 0
        '
        'TbladdemployeeBindingSource
        '
        Me.TbladdemployeeBindingSource.DataMember = "tbladdemployee"
        Me.TbladdemployeeBindingSource.DataSource = Me.VehicledbDataSet1
        '
        'TbladdemployeeTableAdapter
        '
        Me.TbladdemployeeTableAdapter.ClearBeforeFill = True
        '
        'VehicledbDataSetBindingSource1
        '
        Me.VehicledbDataSetBindingSource1.DataSource = Me.VehicledbDataSet
        Me.VehicledbDataSetBindingSource1.Position = 0
        '
        'TbladddriverTableAdapter
        '
        Me.TbladddriverTableAdapter.ClearBeforeFill = True
        '
        'TbladddriverBindingSource1
        '
        Me.TbladddriverBindingSource1.DataMember = "tbladddriver"
        Me.TbladddriverBindingSource1.DataSource = Me.VehicledbDataSet2
        '
        'TbladddriverTableAdapter1
        '
        Me.TbladddriverTableAdapter1.ClearBeforeFill = True
        '
        'Drivers_records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vehicle.My.Resources.Resources._49ddd7ad_e6ae_4981_bcda_1d7f1c934073_WoodBackground
        Me.ClientSize = New System.Drawing.Size(1220, 683)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Drivers_records"
        Me.Text = "All Drivers"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbladddriverBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicledbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbladddriverBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicledbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicledbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicledbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbladdemployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicledbDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbladddriverBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VehicledbDataSet As vehicle.vehicledbDataSet
    Friend WithEvents VehicledbDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehicledbDataSet1 As vehicle.vehicledbDataSet1
    Friend WithEvents TbladdemployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbladdemployeeTableAdapter As vehicle.vehicledbDataSet1TableAdapters.tbladdemployeeTableAdapter
    Friend WithEvents VehicledbDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TbladddriverBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbladddriverTableAdapter As vehicle.vehicledbDataSet1TableAdapters.tbladddriverTableAdapter
    Friend WithEvents VehicledbDataSet2 As vehicle.vehicledbDataSet2
    Friend WithEvents TbladddriverBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TbladddriverTableAdapter1 As vehicle.vehicledbDataSet2TableAdapters.tbladddriverTableAdapter
    Friend WithEvents DriveridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhonenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExperienceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateofjoiningDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TbladddriverBindingSource2 As System.Windows.Forms.BindingSource
End Class
