Public Class Employee_panel

    Private Sub Employee_panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddDriverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDriverToolStripMenuItem.Click
        Modify_driver.Close()
        Drivers_records.Close()
        Add_customer.Close()
        Modify_customer.Close()
        Customer_records.Close()
        View_cars.Close()
        Return_car.Close()
        Change_password.Close()


        Add_driver.Show()


    End Sub

    Private Sub ModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem.Click

        Drivers_records.Close()
        Add_customer.Close()
        Modify_customer.Close()
        Customer_records.Close()
        View_cars.Close()
        Return_car.Close()
        Change_password.Close()


        Add_driver.Close()


        Modify_driver.Show()

    End Sub

    Private Sub ListOfDriversToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfDriversToolStripMenuItem.Click
        Modify_driver.Close()
        Drivers_records.Close()
        Add_customer.Close()
        Modify_customer.Close()
        Customer_records.Close()
        View_cars.Close()
        Return_car.Close()
        Change_password.Close()


        Add_driver.Close()



        Drivers_records.Show()


    End Sub

    Private Sub AddCustomersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCustomersToolStripMenuItem.Click
        Modify_driver.Close()
        Drivers_records.Close()

        Modify_customer.Close()
        Customer_records.Close()
        View_cars.Close()
        Return_car.Close()
        Change_password.Close()


        Add_driver.Close()



        Drivers_records.Close()

        Add_customer.Show()

    End Sub

    Private Sub ModifyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem1.Click
        Modify_driver.Close()
        Drivers_records.Close()
        Add_customer.Close()

        Customer_records.Close()
        View_cars.Close()
        Return_car.Close()
        Change_password.Close()


        Add_driver.Close()



        Drivers_records.Close()

        Modify_customer.Show()

    End Sub

    Private Sub ViewCarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCarToolStripMenuItem.Click
        Modify_driver.Close()
        Drivers_records.Close()
        Add_customer.Close()
        Modify_customer.Close()
        Customer_records.Close()
        View_cars.Close()
        Return_car.Close()
        Change_password.Close()


        Add_driver.Close()



        
        View_cars.Show()

    End Sub

    Private Sub ReturnCarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnCarToolStripMenuItem.Click
        Modify_driver.Close()
        Drivers_records.Close()
        Add_customer.Close()
        Modify_customer.Close()
        Customer_records.Close()
        View_cars.Close()

        Change_password.Close()


        Add_driver.Close()





        Return_car.Show()

    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Modify_driver.Close()
               Add_customer.Close()
        Modify_customer.Close()
        Customer_records.Close()
        View_cars.Close()
        Return_car.Close()



        Add_driver.Close()



        Drivers_records.Close()


        Change_password.Show()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Modify_driver.Close()
        Drivers_records.Close()
        Add_customer.Close()
        Modify_customer.Close()
        Customer_records.Close()

        View_cars.Close()
        Return_car.Close()
        Change_password.Close()


        Add_driver.Close()






        Me.Close()
        login.Show()
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomersToolStripMenuItem.Click
        Modify_driver.Close()

        Add_customer.Close()
        Modify_customer.Close()

        View_cars.Close()
        Return_car.Close()
        Change_password.Close()


        Add_driver.Close()



        Drivers_records.Close()

        Customer_records.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

        Me.Close()




    End Sub


End Class
