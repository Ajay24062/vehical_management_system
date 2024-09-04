<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_panel
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
        Me.DriverRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddDriverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfDriversToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnCarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OthersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DriverRecordsToolStripMenuItem, Me.CustomerRecordToolStripMenuItem, Me.VehiclesToolStripMenuItem, Me.OthersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 26)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DriverRecordsToolStripMenuItem
        '
        Me.DriverRecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddDriverToolStripMenuItem, Me.ModifyToolStripMenuItem, Me.ListOfDriversToolStripMenuItem})
        Me.DriverRecordsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DriverRecordsToolStripMenuItem.Name = "DriverRecordsToolStripMenuItem"
        Me.DriverRecordsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.DriverRecordsToolStripMenuItem.Text = "Driver Record's"
        '
        'AddDriverToolStripMenuItem
        '
        Me.AddDriverToolStripMenuItem.Name = "AddDriverToolStripMenuItem"
        Me.AddDriverToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AddDriverToolStripMenuItem.Text = "Add Driver"
        '
        'ModifyToolStripMenuItem
        '
        Me.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem"
        Me.ModifyToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ModifyToolStripMenuItem.Text = "Modify"
        '
        'ListOfDriversToolStripMenuItem
        '
        Me.ListOfDriversToolStripMenuItem.Name = "ListOfDriversToolStripMenuItem"
        Me.ListOfDriversToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ListOfDriversToolStripMenuItem.Text = "List Of Driver's"
        '
        'CustomerRecordToolStripMenuItem
        '
        Me.CustomerRecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCustomersToolStripMenuItem, Me.ModifyToolStripMenuItem1, Me.CustomersToolStripMenuItem})
        Me.CustomerRecordToolStripMenuItem.Name = "CustomerRecordToolStripMenuItem"
        Me.CustomerRecordToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CustomerRecordToolStripMenuItem.Text = "Customer's Record"
        '
        'AddCustomersToolStripMenuItem
        '
        Me.AddCustomersToolStripMenuItem.Name = "AddCustomersToolStripMenuItem"
        Me.AddCustomersToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AddCustomersToolStripMenuItem.Text = "Add Customer"
        '
        'ModifyToolStripMenuItem1
        '
        Me.ModifyToolStripMenuItem1.Name = "ModifyToolStripMenuItem1"
        Me.ModifyToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.ModifyToolStripMenuItem1.Text = "Modify Customer"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CustomersToolStripMenuItem.Text = "List OfCustomer's"
        '
        'VehiclesToolStripMenuItem
        '
        Me.VehiclesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewCarToolStripMenuItem, Me.ReturnCarToolStripMenuItem})
        Me.VehiclesToolStripMenuItem.Name = "VehiclesToolStripMenuItem"
        Me.VehiclesToolStripMenuItem.Size = New System.Drawing.Size(78, 22)
        Me.VehiclesToolStripMenuItem.Text = "Vehicles"
        '
        'ViewCarToolStripMenuItem
        '
        Me.ViewCarToolStripMenuItem.Name = "ViewCarToolStripMenuItem"
        Me.ViewCarToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ViewCarToolStripMenuItem.Text = "View Car"
        '
        'ReturnCarToolStripMenuItem
        '
        Me.ReturnCarToolStripMenuItem.Name = "ReturnCarToolStripMenuItem"
        Me.ReturnCarToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ReturnCarToolStripMenuItem.Text = "Return Car"
        '
        'OthersToolStripMenuItem
        '
        Me.OthersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.OthersToolStripMenuItem.Name = "OthersToolStripMenuItem"
        Me.OthersToolStripMenuItem.Size = New System.Drawing.Size(72, 22)
        Me.OthersToolStripMenuItem.Text = "Other's"
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
        'Employee_panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.vehicle.My.Resources.Resources.iKd4wfO
        Me.ClientSize = New System.Drawing.Size(1350, 688)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Employee_panel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee panel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DriverRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddDriverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfDriversToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiclesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnCarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OthersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
