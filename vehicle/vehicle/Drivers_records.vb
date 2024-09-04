Public Class Drivers_records

    Private Sub Drivers_records_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VehicledbDataSet2.tbladddriver' table. You can move, or remove it, as needed.
        Me.TbladddriverTableAdapter1.Fill(Me.VehicledbDataSet2.tbladddriver)
     
      

    End Sub
End Class