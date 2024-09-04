<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_panel
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DriverRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCarCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddVehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OthersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PowderBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeToolStripMenuItem, Me.ViewRecordsToolStripMenuItem, Me.VehicleToolStripMenuItem, Me.OthersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 26)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmployeeToolStripMenuItem, Me.ModifyEmployeeToolStripMenuItem, Me.ListOfEmployeeToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(90, 22)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'AddEmployeeToolStripMenuItem
        '
        Me.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        Me.AddEmployeeToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AddEmployeeToolStripMenuItem.Text = "Add Employee"
        '
        'ModifyEmployeeToolStripMenuItem
        '
        Me.ModifyEmployeeToolStripMenuItem.Name = "ModifyEmployeeToolStripMenuItem"
        Me.ModifyEmployeeToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ModifyEmployeeToolStripMenuItem.Text = "Modify Employee"
        '
        'ListOfEmployeeToolStripMenuItem
        '
        Me.ListOfEmployeeToolStripMenuItem.Name = "ListOfEmployeeToolStripMenuItem"
        Me.ListOfEmployeeToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ListOfEmployeeToolStripMenuItem.Text = "List Of Employee"
        '
        'ViewRecordsToolStripMenuItem
        '
        Me.ViewRecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DriverRecordsToolStripMenuItem, Me.CustomerRecordsToolStripMenuItem})
        Me.ViewRecordsToolStripMenuItem.Name = "ViewRecordsToolStripMenuItem"
        Me.ViewRecordsToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ViewRecordsToolStripMenuItem.Text = "View record's"
        '
        'DriverRecordsToolStripMenuItem
        '
        Me.DriverRecordsToolStripMenuItem.Name = "DriverRecordsToolStripMenuItem"
        Me.DriverRecordsToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.DriverRecordsToolStripMenuItem.Text = "Driver Record's"
        '
        'CustomerRecordsToolStripMenuItem
        '
        Me.CustomerRecordsToolStripMenuItem.Name = "CustomerRecordsToolStripMenuItem"
        Me.CustomerRecordsToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CustomerRecordsToolStripMenuItem.Text = "Customer Records"
        '
        'VehicleToolStripMenuItem
        '
        Me.VehicleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCarCompanyToolStripMenuItem, Me.AddVehicleToolStripMenuItem, Me.ViewCarsToolStripMenuItem})
        Me.VehicleToolStripMenuItem.Name = "VehicleToolStripMenuItem"
        Me.VehicleToolStripMenuItem.Size = New System.Drawing.Size(71, 22)
        Me.VehicleToolStripMenuItem.Text = "Vehicle"
        '
        'AddCarCompanyToolStripMenuItem
        '
        Me.AddCarCompanyToolStripMenuItem.Name = "AddCarCompanyToolStripMenuItem"
        Me.AddCarCompanyToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.AddCarCompanyToolStripMenuItem.Text = "Add Car Company"
        '
        'AddVehicleToolStripMenuItem
        '
        Me.AddVehicleToolStripMenuItem.Name = "AddVehicleToolStripMenuItem"
        Me.AddVehicleToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.AddVehicleToolStripMenuItem.Text = "Add Vehicle"
        '
        'ViewCarsToolStripMenuItem
        '
        Me.ViewCarsToolStripMenuItem.Name = "ViewCarsToolStripMenuItem"
        Me.ViewCarsToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ViewCarsToolStripMenuItem.Text = "View Car's"
        '
        'OthersToolStripMenuItem
        '
        Me.OthersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.OthersToolStripMenuItem.Name = "OthersToolStripMenuItem"
        Me.OthersToolStripMenuItem.Size = New System.Drawing.Size(69, 22)
        Me.OthersToolStripMenuItem.Text = "Others"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Admin_panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vehicle.My.Resources.Resources.hd_car_background2
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Admin_panel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Admin Panel"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DriverRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehicleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCarCompanyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddVehicleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCarsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OthersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
