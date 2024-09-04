Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Modify_employee
    Dim scmd, ucmd, uucmd, dcmd, ddcmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim c As Integer = 0







    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Try
            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            ErrorProvider1.Clear()
            If txtusername.Text = "" Then
                ErrorProvider1.SetError(txtusername, "Enter Username to search")
                txtusername.Focus()
            Else

                scmd.Connection = Module1.con


                scmd = New SqlCommand("select * from tbladdemployee inner join login on tbladdemployee.username=login.username where tbladdemployee.username='" & txtusername.Text & "'", Module1.con)
                dr = scmd.ExecuteReader

                Dim hr As Boolean
                hr = dr.HasRows
                If hr = False Then
                    MsgBox("No such Employee Exists")
                    txtname.Clear()


                    txtpassword.Clear()
                    txtphoneno.Clear()
                    txtusername.Clear()
                    rbfemale.Checked = False
                    rbmale.Checked = False
                    rtxxtaddress.Clear()
                    cmbqualification.SelectedIndex = -1
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

                    Dim s4 As String
                    s4 = Trim(dr("dob"))
                    DateTimePicker1.Text = s4

                    Dim s5 As String
                    s5 = Trim(dr("qualification"))
                    If s5 = "10th" Then
                        cmbqualification.SelectedIndex = 0
                    ElseIf s5 = "12th" Then
                        cmbqualification.SelectedIndex = 1
                    ElseIf s5 = "degree" Then
                        cmbqualification.SelectedIndex = 2
                    End If

                    Dim s6 As String
                    s6 = Trim(dr("password"))
                    txtpassword.Text = s6


                    Dim s7 As String
                    s7 = Trim(dr("phoneno"))
                    txtphoneno.Text = s7


                    Dim s8 As String
                    s8 = Trim(dr("dateofjoining"))
                    txtdateofjoining.Text = s8

                    dr.Close()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

     
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            Dim i, i1 As Integer
            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            ErrorProvider1.Clear()
            If txtusername.Text = "" Then
                ErrorProvider1.SetError(txtusername, "Enter Username to delete")
                txtusername.Focus()
            ElseIf c = 0 Then
                MsgBox("First Search the employee to Update")
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
                ElseIf cmbqualification.SelectedItem = "" Then
                    ErrorProvider1.SetError(cmbqualification, "Select Qualification")
                    cmbqualification.Focus()
                ElseIf txtphoneno.Text = "" Then
                    ErrorProvider1.SetError(txtphoneno, "Enter phone no")
                    txtphoneno.Focus()

                ElseIf txtphoneno.Text.Length <> 10 Then
                    MessageBox.Show("MObile/phone number must be 10 digit...")
                    txtphoneno.Focus()
                ElseIf txtusername.Text = "" Then
                    ErrorProvider1.SetError(txtusername, "Enter Username")
                    txtusername.Focus()


                ElseIf txtpassword.Text = "" Then
                    ErrorProvider1.SetError(txtpassword, "Enter password")
                    txtpassword.Focus()

                ElseIf txtname.Text <> "" Or rtxxtaddress.Text <> "" Or cmbqualification.SelectedItem <> "" Or txtphoneno.Text <> "" Or txtusername.Text <> "" Or txtpassword.Text <> "" Then
                    If rbfemale.Checked = True Or rbmale.Checked = True Then
                        ucmd.Connection = Module1.con
                        uucmd.Connection = Module1.con
                        Dim st As String
                        If rbfemale.Checked = True Then
                            st = rbfemale.Text
                        ElseIf rbmale.Checked = True Then
                            st = rbmale.Text
                        End If

                        scmd = New SqlCommand("select * from tbladdemployee where username='" & txtusername.Text & "'", Module1.con)
                        dr = scmd.ExecuteReader
                        Dim hr As Boolean
                        hr = dr.HasRows
                        If hr = False Then
                            MsgBox("Do not change the username")
                            
                            dr.Close()
                        Else
                            dr.Close()
                            ucmd = New SqlCommand("update tbladdemployee set name='" & txtname.Text & "',phoneno=" & txtphoneno.Text & ",address='" & rtxxtaddress.Text & "',dob='" & DateTimePicker1.Text & "',dateofjoining='" & txtdateofjoining.Text & "',qualification='" & cmbqualification.Text & "',gender='" & st & "' where username='" & txtusername.Text & "' ", Module1.con)
                            uucmd = New SqlCommand("update login set password='" & txtpassword.Text & "' where username='" & txtusername.Text & "' ", Module1.con)

                            i = ucmd.ExecuteNonQuery()
                            i1 = uucmd.ExecuteNonQuery()
                            If i = 1 And i1 = 1 Then
                                MsgBox("Employee updated Succesfully", MsgBoxStyle.Information)
                                c = 0
                                txtname.Clear()


                                txtpassword.Clear()
                                txtphoneno.Clear()
                                txtusername.Clear()
                                rbfemale.Checked = False
                                rbmale.Checked = False
                                rtxxtaddress.Clear()
                                cmbqualification.SelectedIndex = -1

                            Else
                                MsgBox("Employee Addittion failed ", MsgBoxStyle.Information)
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
            If txtusername.Text = "" Then
                ErrorProvider1.SetError(txtusername, "Enter Username to delete")
                txtusername.Focus()
            ElseIf c = 0 Then
                MsgBox("First Search the employee to delete")
            Else
                dcmd.Connection = Module1.con
                ddcmd.Connection = Module1.con
                dcmd = New SqlCommand("delete from tbladdemployee where username='" & txtusername.Text & "'", Module1.con)
                ddcmd = New SqlCommand("delete from login where username='" & txtusername.Text & "'", Module1.con)

                Dim conf, i, i1 As Integer
                conf = MsgBox("Do you Really Want to Delete this Employee", MsgBoxStyle.YesNo)

                If (conf = DialogResult.Yes) Then
                    i = dcmd.ExecuteNonQuery()
                    i1 = ddcmd.ExecuteNonQuery

                End If
                If i = 1 And i1 = 1 Then
                    MsgBox("Employee has been succefully deleted", MsgBoxStyle.Information)
                    c = 0
                    txtdateofjoining.Clear()
                    txtname.Clear()
                    txtpassword.Clear()
                    txtphoneno.Clear()
                    txtusername.Clear()
                    rbfemale.Checked = False
                    rbmale.Checked = False
                    cmbqualification.SelectedIndex = -1

                    rtxxtaddress.Clear()
                Else
                    MsgBox("No Such Employee to delete, Search again to delete")








                End If


            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
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
End Class