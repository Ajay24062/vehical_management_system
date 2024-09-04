Public Class List_of_employee

    Private Sub List_of_employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VehicledbDataSet.tbladdemployee' table. You can move, or remove it, as needed.
        Me.TbladdemployeeTableAdapter.Fill(Me.VehicledbDataSet.tbladdemployee)

    End Sub
End Class