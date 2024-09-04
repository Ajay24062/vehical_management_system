Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class View_cars
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim ds As New DataSet
    Dim da As SqlDataAdapter



    Private Sub View_cars_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VehicledbDataSet.tblcars' table. You can move, or remove it, as needed.
        Me.TblcarsTableAdapter.Fill(Me.VehicledbDataSet.tblcars)
        Try
            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd = New SqlCommand("select company from company", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cmblistofcompany.Items.Add(dr(0).ToString)
            End While
            dr.Close()
            con.Close()

        Catch ex As Exception
        End Try

    End Sub

    Private Sub cmbselectcompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblistofcompany.SelectedIndexChanged

    End Sub

    Private Sub btnviewavailablecars_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewavailablecars.Click
        Try

            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            ErrorProvider1.Clear()

            ds.Clear()
            DataGridView1.DataSource() = ds


            If cmblistofcompany.Text = "" Then
                ErrorProvider1.SetError(cmblistofcompany, "Select company")
                cmblistofcompany.Focus()
            ElseIf cmbstatus.Text = "" Then
                ErrorProvider1.SetError(cmbstatus, "Select company")
                cmblistofcompany.Focus()
            ElseIf cmbuseas.Text = "" Then
                ErrorProvider1.SetError(cmbuseas, "Select company")
                cmbuseas.Focus()
            Else
                cmd = New SqlCommand("select * from tblcars where company='" & cmblistofcompany.Text & "' and useas='" & cmbuseas.Text & "' and status='" & cmbstatus.Text & "'", con)
               
                da = New SqlDataAdapter(cmd)


                da.Fill(ds, "tblcars")
                DataGridView1.DataSource() = ds.Tables(0)
                con.Close()




            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub btnviewallcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewallcar.Click
        Try

            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            ErrorProvider1.Clear()
            ds.Clear()
            DataGridView1.DataSource() = ds
                cmd = New SqlCommand("select * from tblcars", con)
                da = New SqlDataAdapter(cmd)
                da.Fill(ds, "tblcars")
                DataGridView1.DataSource() = ds.Tables(0)
                con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class