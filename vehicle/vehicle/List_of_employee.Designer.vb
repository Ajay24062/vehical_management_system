<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_of_employee
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
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhonenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofjoiningDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QualificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbladdemployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicledbDataSet = New vehicle.vehicledbDataSet()
        Me.TbladdemployeeTableAdapter = New vehicle.vehicledbDataSetTableAdapters.tbladdemployeeTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbladdemployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicledbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PhonenoDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.DateofjoiningDataGridViewTextBoxColumn, Me.QualificationDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbladdemployeeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(56, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1089, 421)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'PhonenoDataGridViewTextBoxColumn
        '
        Me.PhonenoDataGridViewTextBoxColumn.DataPropertyName = "phoneno"
        Me.PhonenoDataGridViewTextBoxColumn.HeaderText = "phoneno"
        Me.PhonenoDataGridViewTextBoxColumn.Name = "PhonenoDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        '
        'DateofjoiningDataGridViewTextBoxColumn
        '
        Me.DateofjoiningDataGridViewTextBoxColumn.DataPropertyName = "dateofjoining"
        Me.DateofjoiningDataGridViewTextBoxColumn.HeaderText = "dateofjoining"
        Me.DateofjoiningDataGridViewTextBoxColumn.Name = "DateofjoiningDataGridViewTextBoxColumn"
        '
        'QualificationDataGridViewTextBoxColumn
        '
        Me.QualificationDataGridViewTextBoxColumn.DataPropertyName = "qualification"
        Me.QualificationDataGridViewTextBoxColumn.HeaderText = "qualification"
        Me.QualificationDataGridViewTextBoxColumn.Name = "QualificationDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'TbladdemployeeBindingSource
        '
        Me.TbladdemployeeBindingSource.DataMember = "tbladdemployee"
        Me.TbladdemployeeBindingSource.DataSource = Me.VehicledbDataSet
        '
        'VehicledbDataSet
        '
        Me.VehicledbDataSet.DataSetName = "vehicledbDataSet"
        Me.VehicledbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbladdemployeeTableAdapter
        '
        Me.TbladdemployeeTableAdapter.ClearBeforeFill = True
        '
        'List_of_employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vehicle.My.Resources.Resources._49ddd7ad_e6ae_4981_bcda_1d7f1c934073_WoodBackground
        Me.ClientSize = New System.Drawing.Size(1161, 562)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Georgia", 10.0!)
        Me.Name = "List_of_employee"
        Me.Text = "List Of Employee"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbladdemployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicledbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VehicledbDataSet As vehicle.vehicledbDataSet
    Friend WithEvents TbladdemployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbladdemployeeTableAdapter As vehicle.vehicledbDataSetTableAdapters.tbladdemployeeTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhonenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateofjoiningDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QualificationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
