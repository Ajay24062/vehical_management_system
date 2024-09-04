Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Return_car
    Dim scmd, ucmd, uucmd, dcmd, ddcmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim c As Integer = 0
    Dim i As Integer = 0
    Dim i1 As Integer = 0
    Private Sub Return_car_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtname.Enabled = False

        txtcarnumber.Enabled = False

        txtcompany.Enabled = False
        txtbookingdate.Enabled = False
        txtreturndate.Text = Date.Today.Date


    End Sub

    Private Sub txtcustomer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcustomer.TextChanged
        If Not Regex.Match(txtcustomer.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers only.")
            txtcustomer.Text = ""
            txtcustomer.Focus()
        End If
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        If Not Regex.Match(txtname.Text, "^[a-zA-Z ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter alpha text only.")
            txtname.Text = ""
            txtname.Focus()
        End If
    End Sub

    Private Sub txtnumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcarnumber.TextChanged
        If Not Regex.Match(txtcarnumber.Text, "^[0-9a-zA-z ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers And Alpha only.")
            txtcarnumber.Text = ""
            txtcarnumber.Focus()
            If txtcarnumber.Text.Length > 10 Then
                MsgBox("You have crossed the limit")
            End If

        End If
    End Sub

    Private Sub btncarreturned_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncarreturned.Click
        Try
            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            ErrorProvider1.Clear()
            If txtcustomer.Text = "" Then
                ErrorProvider1.SetError(txtcustomer, "Enter Customer Id to return")
                txtcustomer.Focus()
            ElseIf c = 0 Then
                MsgBox("First Search to return")
            Else
                Dim n As String = ""
                Dim s As String = "Unrented"
                dcmd.Connection = Module1.con
                ddcmd.Connection = Module1.con
                dcmd = New SqlCommand("delete from tbladdcustomer where custid='" & txtcustomer.Text & "'", Module1.con)
                ddcmd = New SqlCommand("update tblcars set status='" & s & "'where carnumber='" & txtcarnumber.Text & "'", Module1.con)

                
                    i = dcmd.ExecuteNonQuery()
                i1 = ddcmd.ExecuteNonQuery


                If i = 1 And i1 = 1 Then
                    '  If i = 1 Then
                    MsgBox("Car has been succefully returned", MsgBoxStyle.Information)
                    c = 0
                    txtcustomer.Clear()
                    txtname.Clear()


                    txtcarnumber.Clear()

                    txtcompany.Clear()
                    txtbookingdate.Clear()
                Else
                    MsgBox("No Such Car to return, Search again to return")




                End If


            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnsearchbyid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchbyid.Click
        Try
            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            ErrorProvider1.Clear()
            If txtcustomer.Text = "" Then
                ErrorProvider1.SetError(txtcustomer, "Enter Customer id to search")
                txtcustomer.Focus()
            Else

                scmd.Connection = Module1.con


                scmd = New SqlCommand("select * from tbladdcustomer where custid='" & txtcustomer.Text & "'", Module1.con)

                dr = scmd.ExecuteReader

                Dim hr As Boolean
                hr = dr.HasRows
                If hr = False Then
                    MsgBox("No such Customer Exists")
                    c = 0
                    txtcustomer.Clear()
                    txtname.Clear()


                    txtcarnumber.Clear()

                    txtcompany.Clear()
                    txtbookingdate.Clear()

                Else

                    dr.Read()

                    c = 1
                    Dim s1 As String
                    s1 = Trim(dr("name"))
                    txtname.Text = s1

                    txtcompany.Text = dr("requirement")
                    txtcarnumber.Text = dr("carnumber")
                    txtbookingdate.Text = dr("bdate")











                    dr.Close()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class