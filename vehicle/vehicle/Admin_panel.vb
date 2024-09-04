Public Class Admin_panel

    Private Sub AddEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        Modify_employee.Close()
        List_of_employee.Close()
        Drivers_records.Close()
        Customer_records.Close()
        Add_vehicle.Close()
        Add_car_company.Close()
        View_cars.Close()
        Admin_change_password.Close()
        Add_Employee.Show()

    End Sub

    Private Sub ModifyEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyEmployeeToolStripMenuItem.Click
        List_of_employee.Close()
        Drivers_records.Close()
        Customer_records.Close()
        Add_vehicle.Close()
        Add_car_company.Close()
        View_cars.Close()
        Admin_change_password.Close()
        Add_Employee.Close()
        Modify_employee.Show()
    End Sub

    Private Sub DriverRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriverRecordsToolStripMenuItem.Click
        List_of_employee.Close()
        Customer_records.Close()
        Add_vehicle.Close()
        Add_car_company.Close()
        View_cars.Close()
        Admin_change_password.Close()
        Add_Employee.Close()
        Modify_employee.Close()
        Drivers_records.Show()
    End Sub

    Private Sub AddCarCompanyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCarCompanyToolStripMenuItem.Click
        Drivers_records.Close()
        Customer_records.Close()
        Add_Employee.Close()
        Modify_employee.Close()
        List_of_employee.Close()
        Admin_change_password.Close()
        View_cars.Close()
        Add_vehicle.Close()
        Add_car_company.Show()

    End Sub

    Private Sub AddVehicleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddVehicleToolStripMenuItem.Click
        Drivers_records.Close()
        Customer_records.Close()
        Add_car_company.Close()
        Add_Employee.Close()
        Modify_employee.Close()
        List_of_employee.Close()
        Admin_change_password.Close()
        View_cars.Close()
        Add_vehicle.Show()
    End Sub

    Private Sub ViewCarsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCarsToolStripMenuItem.Click
        Drivers_records.Close()
        Customer_records.Close()
        Add_vehicle.Close()
        Add_car_company.Close()
        Add_Employee.Close()
        Modify_employee.Close()
        List_of_employee.Close()
        Admin_change_password.Close()
        View_cars.Show()

    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Drivers_records.Close()
        Customer_records.Close()
        Add_vehicle.Close()
        Add_car_company.Close()
        View_cars.Close()
        Add_Employee.Close()
        Modify_employee.Close()
        List_of_employee.Close()
        Admin_change_password.Show()
    End Sub

    Private Sub ListOfEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfEmployeeToolStripMenuItem.Click
        Drivers_records.Close()
        Customer_records.Close()
        Add_vehicle.Close()
        Add_car_company.Close()
        View_cars.Close()
        Admin_change_password.Close()
        Add_Employee.Close()
        Modify_employee.Close()
        List_of_employee.Show()
    End Sub

    Private Sub CustomerRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerRecordsToolStripMenuItem.Click
        Drivers_records.Close()
        Add_vehicle.Close()
        Add_car_company.Close()
        View_cars.Close()
        Admin_change_password.Close()
        Add_Employee.Close()
        Modify_employee.Close()
        List_of_employee.Close()
        Customer_records.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Drivers_records.Close()
        Add_vehicle.Close()
        Add_car_company.Close()
        View_cars.Close()
        Admin_change_password.Close()
        Add_Employee.Close()
        Modify_employee.Close()
        List_of_employee.Close()
        Customer_records.Close()
        Me.Hide()
        login.Show()
    End Sub

    Private Sub OthersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OthersToolStripMenuItem.Click

    End Sub
End Class