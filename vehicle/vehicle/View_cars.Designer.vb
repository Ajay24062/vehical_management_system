<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_cars
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmblistofcompany = New System.Windows.Forms.ComboBox()
        Me.cmbuseas = New System.Windows.Forms.ComboBox()
        Me.cmbstatus = New System.Windows.Forms.ComboBox()
        Me.btnviewavailablecars = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblcarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicledbDataSet = New vehicle.vehicledbDataSet()
        Me.TblcarsTableAdapter = New vehicle.vehicledbDataSetTableAdapters.tblcarsTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnviewallcar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicledbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Company"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Use as"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 154)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Status"
        '
        'cmblistofcompany
        '
        Me.cmblistofcompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblistofcompany.FormattingEnabled = True
        Me.cmblistofcompany.Location = New System.Drawing.Point(220, 30)
        Me.cmblistofcompany.Margin = New System.Windows.Forms.Padding(4)
        Me.cmblistofcompany.Name = "cmblistofcompany"
        Me.cmblistofcompany.Size = New System.Drawing.Size(160, 24)
        Me.cmblistofcompany.TabIndex = 3
        '
        'cmbuseas
        '
        Me.cmbuseas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbuseas.FormattingEnabled = True
        Me.cmbuseas.Items.AddRange(New Object() {"Taxi", "Induvisual Rent"})
        Me.cmbuseas.Location = New System.Drawing.Point(220, 88)
        Me.cmbuseas.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbuseas.Name = "cmbuseas"
        Me.cmbuseas.Size = New System.Drawing.Size(160, 24)
        Me.cmbuseas.TabIndex = 4
        '
        'cmbstatus
        '
        Me.cmbstatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Items.AddRange(New Object() {"Rented", "Unrenred"})
        Me.cmbstatus.Location = New System.Drawing.Point(220, 151)
        Me.cmbstatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(160, 24)
        Me.cmbstatus.TabIndex = 5
        '
        'btnviewavailablecars
        '
        Me.btnviewavailablecars.Location = New System.Drawing.Point(513, 38)
        Me.btnviewavailablecars.Margin = New System.Windows.Forms.Padding(4)
        Me.btnviewavailablecars.Name = "btnviewavailablecars"
        Me.btnviewavailablecars.Size = New System.Drawing.Size(187, 42)
        Me.btnviewavailablecars.TabIndex = 6
        Me.btnviewavailablecars.Text = "View Available Cars"
        Me.btnviewavailablecars.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 213)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1095, 393)
        Me.DataGridView1.TabIndex = 7
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnviewallcar
        '
        Me.btnviewallcar.Location = New System.Drawing.Point(513, 124)
        Me.btnviewallcar.Name = "btnviewallcar"
        Me.btnviewallcar.Size = New System.Drawing.Size(187, 46)
        Me.btnviewallcar.TabIndex = 8
        Me.btnviewallcar.Text = "View All Cars"
        Me.btnviewallcar.UseVisualStyleBackColor = True
        '
        'View_cars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vehicle.My.Resources.Resources._49ddd7ad_e6ae_4981_bcda_1d7f1c934073_WoodBackground
        Me.ClientSize = New System.Drawing.Size(1127, 639)
        Me.Controls.Add(Me.btnviewallcar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnviewavailablecars)
        Me.Controls.Add(Me.cmbstatus)
        Me.Controls.Add(Me.cmbuseas)
        Me.Controls.Add(Me.cmblistofcompany)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "View_cars"
        Me.Text = "View cars"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicledbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmblistofcompany As System.Windows.Forms.ComboBox
    Friend WithEvents cmbuseas As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnviewavailablecars As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VehicledbDataSet As vehicle.vehicledbDataSet
    Friend WithEvents TblcarsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblcarsTableAdapter As vehicle.vehicledbDataSetTableAdapters.tblcarsTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnviewallcar As System.Windows.Forms.Button
End Class
