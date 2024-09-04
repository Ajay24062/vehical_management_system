Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Add_Employee
    Dim scmd, cmd, cmd1 As New SqlCommand
    Dim dr As SqlDataReader
    Dim i, i1 As Integer



    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Try
            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            ErrorProvider1.Clear()
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
                    cmd.Connection = Module1.con

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
                    If hr = True Then
                        dr.Read()
                        If dr("username") = txtusername.Text Then
                            MsgBox("The username is Already exist")
                        Else
                          
                        End If

                        dr.Close()
                    Else
                        dr.Close()
                        cmd = New SqlCommand("insert into tbladdemployee(name,phoneno,address,username,dob,dateofjoining,qualification,gender)values('" & txtname.Text & "'," & txtphoneno.Text & ",'" & rtxxtaddress.Text & "','" & txtusername.Text & "','" & DateTimePicker1.Text & "','" & txtdateofjoining.Text & "','" & cmbqualification.Text & "','" & st & "')", Module1.con)
                        cmd1 = New SqlCommand("insert into login(username,password)values('" & txtusername.Text & "','" & txtpassword.Text & "')", Module1.con)
                        i = cmd.ExecuteNonQuery()
                        i1 = cmd1.ExecuteNonQuery()
                        If i = 1 And i1 = 1 Then
                            MsgBox("Employee Added Succesfully", MsgBoxStyle.Information)
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




        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Add_Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtdateofjoining.Text = Date.Today.Date
        txtname.Focus()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

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

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        If Not Regex.Match(txtname.Text, "^[a-zA-Z ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter alpha text only.")
            txtname.Text = ""
            txtname.Focus()
        End If
    End Sub

    Private Sub rbmale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbmale.CheckedChanged

    End Sub

    
End Class