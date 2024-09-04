<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_vehicle
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcarmodel = New System.Windows.Forms.TextBox()
        Me.txtcarnumber = New System.Windows.Forms.TextBox()
        Me.txtmakeyear = New System.Windows.Forms.TextBox()
        Me.cmblistofcompany = New System.Windows.Forms.ComboBox()
        Me.cmbuseas = New System.Windows.Forms.ComboBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbsittingcapacity = New System.Windows.Forms.ComboBox()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        Me.cmbvarient = New System.Windows.Forms.ComboBox()
        Me.txtenginecapacity = New System.Windows.Forms.TextBox()
        Me.txtrent = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car Model"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Company"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 178)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Car Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 228)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Make Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 286)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Use as"
        '
        'txtcarmodel
        '
        Me.txtcarmodel.Location = New System.Drawing.Point(183, 66)
        Me.txtcarmodel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcarmodel.Name = "txtcarmodel"
        Me.txtcarmodel.Size = New System.Drawing.Size(160, 22)
        Me.txtcarmodel.TabIndex = 7
        '
        'txtcarnumber
        '
        Me.txtcarnumber.Location = New System.Drawing.Point(183, 178)
        Me.txtcarnumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcarnumber.Name = "txtcarnumber"
        Me.txtcarnumber.Size = New System.Drawing.Size(160, 22)
        Me.txtcarnumber.TabIndex = 8
        '
        'txtmakeyear
        '
        Me.txtmakeyear.Location = New System.Drawing.Point(183, 226)
        Me.txtmakeyear.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmakeyear.Name = "txtmakeyear"
        Me.txtmakeyear.Size = New System.Drawing.Size(160, 22)
        Me.txtmakeyear.TabIndex = 9
        '
        'cmblistofcompany
        '
        Me.cmblistofcompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblistofcompany.FormattingEnabled = True
        Me.cmblistofcompany.Location = New System.Drawing.Point(183, 126)
        Me.cmblistofcompany.Margin = New System.Windows.Forms.Padding(4)
        Me.cmblistofcompany.Name = "cmblistofcompany"
        Me.cmblistofcompany.Size = New System.Drawing.Size(160, 24)
        Me.cmblistofcompany.TabIndex = 10
        '
        'cmbuseas
        '
        Me.cmbuseas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbuseas.FormattingEnabled = True
        Me.cmbuseas.Items.AddRange(New Object() {"Taxi", "Induvisual Rent"})
        Me.cmbuseas.Location = New System.Drawing.Point(183, 286)
        Me.cmbuseas.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbuseas.Name = "cmbuseas"
        Me.cmbuseas.Size = New System.Drawing.Size(160, 24)
        Me.cmbuseas.TabIndex = 11
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(328, 402)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(113, 43)
        Me.btnsave.TabIndex = 12
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(432, 286)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Rent"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(432, 228)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Varient"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(432, 178)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(432, 126)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Engine Capacity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(432, 66)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Sitting Capacity"
        '
        'cmbsittingcapacity
        '
        Me.cmbsittingcapacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsittingcapacity.FormattingEnabled = True
        Me.cmbsittingcapacity.Items.AddRange(New Object() {"3 Seater", "5 Seater", "7 Seater", "8 Seater"})
        Me.cmbsittingcapacity.Location = New System.Drawing.Point(604, 66)
        Me.cmbsittingcapacity.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbsittingcapacity.Name = "cmbsittingcapacity"
        Me.cmbsittingcapacity.Size = New System.Drawing.Size(160, 24)
        Me.cmbsittingcapacity.TabIndex = 18
        '
        'cmbtype
        '
        Me.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"AC", "Non AC"})
        Me.cmbtype.Location = New System.Drawing.Point(603, 178)
        Me.cmbtype.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(160, 24)
        Me.cmbtype.TabIndex = 19
        '
        'cmbvarient
        '
        Me.cmbvarient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvarient.FormattingEnabled = True
        Me.cmbvarient.Items.AddRange(New Object() {"Base Model", "Economic Model", "Top Model"})
        Me.cmbvarient.Location = New System.Drawing.Point(603, 228)
        Me.cmbvarient.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbvarient.Name = "cmbvarient"
        Me.cmbvarient.Size = New System.Drawing.Size(160, 24)
        Me.cmbvarient.TabIndex = 20
        '
        'txtenginecapacity
        '
        Me.txtenginecapacity.Location = New System.Drawing.Point(604, 127)
        Me.txtenginecapacity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtenginecapacity.Name = "txtenginecapacity"
        Me.txtenginecapacity.Size = New System.Drawing.Size(159, 22)
        Me.txtenginecapacity.TabIndex = 21
        '
        'txtrent
        '
        Me.txtrent.Location = New System.Drawing.Point(604, 287)
        Me.txtrent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtrent.Name = "txtrent"
        Me.txtrent.Size = New System.Drawing.Size(159, 22)
        Me.txtrent.TabIndex = 22
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Add_vehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vehicle.My.Resources.Resources._49ddd7ad_e6ae_4981_bcda_1d7f1c934073_WoodBackground
        Me.ClientSize = New System.Drawing.Size(780, 514)
        Me.Controls.Add(Me.txtrent)
        Me.Controls.Add(Me.txtenginecapacity)
        Me.Controls.Add(Me.cmbvarient)
        Me.Controls.Add(Me.cmbtype)
        Me.Controls.Add(Me.cmbsittingcapacity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cmbuseas)
        Me.Controls.Add(Me.cmblistofcompany)
        Me.Controls.Add(Me.txtmakeyear)
        Me.Controls.Add(Me.txtcarnumber)
        Me.Controls.Add(Me.txtcarmodel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Add_vehicle"
        Me.Text = "Add Vehicle"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcarmodel As System.Windows.Forms.TextBox
    Friend WithEvents txtcarnumber As System.Windows.Forms.TextBox
    Friend WithEvents txtmakeyear As System.Windows.Forms.TextBox
    Friend WithEvents cmblistofcompany As System.Windows.Forms.ComboBox
    Friend WithEvents cmbuseas As System.Windows.Forms.ComboBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbsittingcapacity As System.Windows.Forms.ComboBox
    Friend WithEvents cmbtype As System.Windows.Forms.ComboBox
    Friend WithEvents cmbvarient As System.Windows.Forms.ComboBox
    Friend WithEvents txtenginecapacity As System.Windows.Forms.TextBox
    Friend WithEvents txtrent As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
