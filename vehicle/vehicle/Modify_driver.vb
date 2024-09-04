Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Modify_driver
    Dim scmd, ucmd, uucmd, dcmd, ddcmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim c As Integer = 0

    Private Sub txtdriverid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdriverid.TextChanged
        If Not Regex.Match(txtphoneno.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers only.")
            txtphoneno.Text = ""
            txtphoneno.Focus()
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

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Try
            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            ErrorProvider1.Clear()
            If txtdriverid.Text = "" Then
                ErrorProvider1.SetError(txtdriverid, "Enter Driver id to search")
                txtdriverid.Focus()
            Else

                scmd.Connection = Module1.con


                scmd = New SqlCommand("select * from tbladddriver where driverid='" & txtdriverid.Text & "'", Module1.con)
                dr = scmd.ExecuteReader

                Dim hr As Boolean
                hr = dr.HasRows
                If hr = False Then
                    MsgBox("No such driver Exists")
                    c = 0
                    txtname.Clear()

                    txtdriverid.Text = ""

                    txtphoneno.Clear()

                    rbfemale.Checked = False
                    rbmale.Checked = False
                    rtxxtaddress.Clear()
                    cmbexperience.SelectedIndex = -1
                    txtdriverid.Text = ""

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
                    s5 = Trim(dr("experience"))


                    If s5 = "No Expirience" Then
                        cmbexperience.SelectedIndex = 0
                    ElseIf s5 = "Less Than 1 Year" Then
                        cmbexperience.SelectedIndex = 1
                    ElseIf s5 = "1-2 Year" Then
                        cmbexperience.SelectedIndex = 2
                    ElseIf s5 = "2-3 Year" Then
                        cmbexperience.SelectedIndex = 3
                    ElseIf s5 = "3-4 Year" Then
                        cmbexperience.SelectedIndex = 4
                    ElseIf s5 = "4-5 Year" Then
                        cmbexperience.SelectedIndex = 5
                    ElseIf s5 = "Above 5 Year" Then
                        cmbexperience.SelectedIndex = 6

                    End If



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

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            ErrorProvider1.Clear()
            If txtdriverid.Text = "" Then
                ErrorProvider1.SetError(txtdriverid, "Enter Driver Id to delete")
                txtdriverid.Focus()
            ElseIf c = 0 Then
                MsgBox("First Search the Driver to delete")
            Else
                Dim n As String = ""
                Dim s As String = "No"
                dcmd.Connection = Module1.con
                ddcmd.Connection = Module1.con
                dcmd = New SqlCommand("delete from tbladddriver where driverid='" & txtdriverid.Text & "'", Module1.con)
                ddcmd = New SqlCommand("update tblcars set driver_id='" & n & "',driver='" & s & "' where driver_id='" & txtdriverid.Text & "'", Module1.con)

                Dim conf, i, i1 As Integer
                conf = MsgBox("Do you Really Want to Delete this Driver", MsgBoxStyle.YesNo)

                If (conf = DialogResult.Yes) Then
                    i = dcmd.ExecuteNonQuery()
                    i1 = ddcmd.ExecuteNonQuery

                End If
                If i = 1 And i1 = 1 Then
                    MsgBox("Driver has been succefully deleted", MsgBoxStyle.Information)
                    c = 0

                    txtname.Clear()
                    txtdriverid.Clear()
                    txtphoneno.Clear()

                    rbfemale.Checked = False
                    rbmale.Checked = False
                    cmbexperience.SelectedIndex = -1

                    rtxxtaddress.Clear()
                Else
                    MsgBox("No Such Driver to delete, Search again to delete")

                    txtdriverid.Text = ""






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
            If txtdriverid.Text = "" Then
                ErrorProvider1.SetError(txtdriverid, "Enter driverid to update")
                txtdriverid.Focus()
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
                ElseIf cmbexperience.SelectedItem = "" Then
                    ErrorProvider1.SetError(cmbexperience, "Select Qualification")
                    cmbexperience.Focus()
                ElseIf txtphoneno.Text = "" Then
                    ErrorProvider1.SetError(txtphoneno, "Enter phone no")
                    txtphoneno.Focus()

                ElseIf txtphoneno.Text.Length <> 10 Then
                    MessageBox.Show("MObile/phone number must be 10 digit...")
                    txtphoneno.Focus()
                ElseIf txtdriverid.Text = "" Then
                    ErrorProvider1.SetError(txtdriverid, "Enter driverid")
                    txtdriverid.Focus()



                ElseIf txtname.Text <> "" Or rtxxtaddress.Text <> "" Or cmbexperience.SelectedItem <> "" Or txtphoneno.Text <> "" Or txtdriverid.Text <> "" Then
                    If rbfemale.Checked = True Or rbmale.Checked = True Then
                        ucmd.Connection = Module1.con
                        uucmd.Connection = Module1.con
                        Dim st As String
                        If rbfemale.Checked = True Then
                            st = rbfemale.Text
                        ElseIf rbmale.Checked = True Then
                            st = rbmale.Text
                        End If

                        scmd = New SqlCommand("select * from tbladddriver where driverid='" & txtdriverid.Text & "'", Module1.con)
                        dr = scmd.ExecuteReader
                        Dim hr As Boolean
                        hr = dr.HasRows
                        If hr = False Then
                            MsgBox("Do not change the driverid")

                            dr.Close()
                        Else
                            dr.Close()
                            ucmd = New SqlCommand("update tbladddriver set name='" & txtname.Text & "',phoneno=" & txtphoneno.Text & ",address='" & rtxxtaddress.Text & "',dob='" & DateTimePicker1.Text & "',experience='" & cmbexperience.Text & "',gender='" & st & "' where driverid='" & txtdriverid.Text & "' ", Module1.con)

                            i = ucmd.ExecuteNonQuery()
                            If i = 1 Then
                                MsgBox("Driver updated Succesfully", MsgBoxStyle.Information)
                                c = 0
                                txtname.Clear()


                                txtdriverid.Clear()
                                txtphoneno.Clear()

                                rbfemale.Checked = False
                                rbmale.Checked = False
                                rtxxtaddress.Clear()
                                cmbexperience.SelectedIndex = -1

                            Else
                                MsgBox("driver Addittion failed ", MsgBoxStyle.Information)
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
End Class