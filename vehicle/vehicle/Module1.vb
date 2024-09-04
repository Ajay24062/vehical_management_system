Imports System.Data.SqlClient

Module Module1
    Public con As SqlConnection
    Public Sub connection()
        con = New SqlConnection("Data Source=use\sqlexpress;Initial Catalog=vehicledb;Integrated Security=True")
    End Sub
End Module
