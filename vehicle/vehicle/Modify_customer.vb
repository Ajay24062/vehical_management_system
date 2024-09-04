Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Modify_customer
    Dim scmd, ucmd, uucmd, dcmd, ddcmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim c As Integer = 0
    Private Sub btnsearchbyname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Modify_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnsearchbyid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchbyid.Click
        Try
            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            ErrorProvider1.Clear()
            If txtcustomerid.Text = "" Then
                ErrorProvider1.SetError(txtcustomerid, "Enter Customer id to search")
                txtcustomerid.Focus()
            Else

                scmd.Connection = Module1.con


                scmd = New SqlCommand("select * from tbladdcustomer where custid='" & txtcustomerid.Text & "'", Module1.con)
                dr = scmd.ExecuteReader

                Dim hr As Boolean
                hr = dr.HasRows
                If hr = False Then
                    c = 0
                    MsgBox("No such customer Exists")
                    c = 0
                    txtname.Clear()

                    txtcustomerid.Text = ""

                    txtphoneno.Clear()

                    rbfemale.Checked = False
                    rbmale.Checked = False
                    rtxxtaddress.Clear()

                    txtcustomerid.Text = ""

                Else

                    dr.Read()

                    c = 1
                    Dim s1 As String
                    s1 = Trim(dr("name"))
                    txtname.Text = s1

                    Dim s2 As String
                    s2 = Trim(dr("gender"))

                    If s2 = "Male" Then
                        rbmale.Checked = True
                    ElseIf s2 = "Female" Then
                        rbfemale.Checked = True

                    End If

                    Dim s3 As String
                    s3 = Trim(dr("address"))
                    rtxxtaddress.Text = s3


                    Dim s7 As String
                    s7 = Trim(dr("phoneno"))
                    txtphoneno.Text = s7



                    dr.Close()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtcustomerid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcustomerid.TextChanged
        If Not Regex.Match(txtcustomerid.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers only.")
            txtcustomerid.Text = ""
            txtcustomerid.Focus()
        End If
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        If Not Regex.Match(txtname.Text, "^[a-zA-Z ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter alpha text only.")
            txtname.Text = ""
            txtname.Focus()
        End If
    End Sub

    Private Sub txtphoneno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtphoneno.TextChanged
        If Not Regex.Match(txtphoneno.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers only.")
            txtphoneno.Text = ""
            txtphoneno.Focus()
        ElseIf txtphoneno.Text.Length > 10 Then
            MsgBox("Only 10 digits")
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            Dim i, i1 As Integer
            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            ErrorProvider1.Clear()
            If txtcustomerid.Text = "" Then
                ErrorProvider1.SetError(txtcustomerid, "Enter Customerid to update")
                txtcustomerid.Focus()
            ElseIf c = 0 Then
                MsgBox("First Search the username to Update")
            Else

                If txtname.Text = "" Then
                    ErrorProvider1.SetError(txtname, "enter name")
                    txtname.Focus()

                ElseIf rbfemale.Checked = False And rbmale.Checked = False Then
                    ErrorProvider1.SetError(rbfemale, "Select Gender")

                ElseIf rtxxtaddress.Text = "" Then
                    ErrorProvider1.SetError(rtxxtaddress, "Enter the address")
                    rtxxtaddress.Focus()


                ElseIf rtxxtaddress.Text.Length <= 20 Then
                    MessageBox.Show("The Adress Should be  More than 20 letters")
                    rtxxtaddress.Focus()

                ElseIf txtphoneno.Text = "" Then
                    ErrorProvider1.SetError(txtphoneno, "Enter phone no")
                    txtphoneno.Focus()

                ElseIf txtphoneno.Text.Length <> 10 Then
                    MessageBox.Show("MObile/phone number must be 10 digit...")
                    txtphoneno.Focus()
                ElseIf txtcustomerid.Text = "" Then
                    ErrorProvider1.SetError(txtcustomerid, "Enter customerid")
                    txtcustomerid.Focus()



                ElseIf txtname.Text <> "" Or rtxxtaddress.Text <> "" Or txtphoneno.Text <> "" Or txtcustomerid.Text <> "" Then
                    If rbfemale.Checked = True Or rbmale.Checked = True Then
                        ucmd.Connection = Module1.con
                        uucmd.Connection = Module1.con
                        Dim st As String
                        If rbfemale.Checked = True Then
                            st = rbfemale.Text
                        ElseIf rbmale.Checked = True Then
                            st = rbmale.Text
                        End If

                        scmd = New SqlCommand("select * from tbladdcustomer where custid='" & txtcustomerid.Text & "'", Module1.con)
                        dr = scmd.ExecuteReader
                        Dim hr As Boolean
                        hr = dr.HasRows
                        If hr = False Then
                            MsgBox("Do not change the Customerid")

                            dr.Close()
                        Else
                            dr.Close()
                            ucmd = New SqlCommand("update tbladdcustomer set name='" & txtname.Text & "',phoneno=" & txtphoneno.Text & ",address='" & rtxxtaddress.Text & "',gender='" & st & "' where custid='" & txtcustomerid.Text & "' ", Module1.con)

                            i = ucmd.ExecuteNonQuery()
                            If i = 1 Then
                                MsgBox("customer updated Succesfully", MsgBoxStyle.Information)
                                c = 0
                                txtname.Clear()


                                txtcustomerid.Clear()
                                txtphoneno.Clear()

                                rbfemale.Checked = False
                                rbmale.Checked = False
                                rtxxtaddress.Clear()


                            Else
                                MsgBox("Customer Addittion failed ", MsgBoxStyle.Information)
                            End If
                        End If





                    Else
                        MsgBox("Select the Gender")
                    End If
                Else
                    MsgBox("Fill All the fields")

                End If




            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            ErrorProvider1.Clear()
            If txtcustomerid.Text = "" Then
                ErrorProvider1.SetError(txtcustomerid, "Enter Customer Id to delete")
                txtcustomerid.Focus()
            ElseIf c = 0 Then
                MsgBox("First Search the Customer to delete")
            Else
                Dim n As String = ""
                Dim s As String = "Unrented"
                dcmd.Connection = Module1.con
                ddcmd.Connection = Module1.con
                dcmd = New SqlCommand("delete from tbladdcustomer where custid='" & txtcustomerid.Text & "'", Module1.con)
                '    ddcmd = New SqlCommand("update tblcars set status='" & s & "'where carnumber'" & txt", Module1.con)

                Dim conf, i, i1 As Integer
                conf = MsgBox("Do you Really Want to Delete this Customer", MsgBoxStyle.YesNo)

                If (conf = DialogResult.Yes) Then
                    i = dcmd.ExecuteNonQuery()
                    '  i1 = ddcmd.ExecuteNonQuery

                End If
                ' If i = 1 And i1 = 1 Then
                If i = 1 Then
                    MsgBox("Customer has been succefully deleted", MsgBoxStyle.Information)
                    c = 0

                    txtname.Clear()
                    txtcustomerid.Clear()
                    txtphoneno.Clear()

                    rbfemale.Checked = False
                    rbmale.Checked = False


                    rtxxtaddress.Clear()
                Else
                    MsgBox("No Such Customer to delete, Search again to delete")

                    txtname.Clear()

                    txtcustomerid.Text = ""

                    txtphoneno.Clear()

                    rbfemale.Checked = False
                    rbmale.Checked = False
                    rtxxtaddress.Clear()

                    txtcustomerid.Text = ""



                End If


            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class