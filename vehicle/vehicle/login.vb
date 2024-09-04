Imports System.Data.SqlClient
Public Class login
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click

        If (cmblogintype.SelectedItem = "Admin") Then
            Try
                Call Module1.connection()
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                If txtusername.Text = "" Or txtpassword.Text = "" Then
                    MsgBox("username and password can not be blank")
                Else
                    cmd = New SqlCommand("select * from adminlogin where username='" & txtusername.Text & "' and password='" & txtpassword.Text & "'", con)
                    dr = cmd.ExecuteReader

                    If dr.HasRows = True Then


                        While dr.Read
                            If dr(0).ToString = txtusername.Text And dr(1).ToString = txtpassword.Text Then
                                Admin_panel.Show()
                                Me.Hide()
                                txtpassword.Text = ""
                                txtusername.Text = ""
                                cmblogintype.ResetText()
                            Else
                                MsgBox("Enter valid Username and Password")
                            End If
                        End While
                        dr.Close()
                            else

                        MsgBox("Enter valid Username and Password1")

                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        ElseIf (cmblogintype.SelectedItem = "Employee") Then

            Try
                Call Module1.connection()

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                If txtusername.Text = "" Or txtpassword.Text = "" Then
                    MsgBox("username and password can not be blank")
                Else
                    cmd = New SqlCommand("select * from login where username='" & txtusername.Text & "' and password='" & txtpassword.Text & "'", con)
                    dr = cmd.ExecuteReader
                    If dr.HasRows = True Then
                        While dr.Read
                            If dr(0).ToString = txtusername.Text And dr(1).ToString = txtpassword.Text Then
                                Employee_panel.Show()
                                Me.Hide()
                                txtpassword.Text = ""
                                txtusername.Text = ""
                                cmblogintype.ResetText()
                            End If
                        End While
                        dr.Close()
                    Else
                        MsgBox("Enter valid Username and Password")

                    End If

                    End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        Else
            MsgBox("Invalid Type. please select valid type")
        End If
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Refresh()
        txtpassword.Text = ""
        txtusername.Text = ""
        cmblogintype.Text = ""


    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

        Application.Exit()

    End Sub
End Class