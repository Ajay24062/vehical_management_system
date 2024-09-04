Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class Add_car_company
    Dim icmd, cmd As New SqlCommand
    Dim dr As SqlDataReader

    Private Sub txtcompanyname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcompanyname.TextChanged
        If Not Regex.Match(txtcompanyname.Text, "^[a-zA-Z ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter alpha text only.")
            txtcompanyname.Text = ""
            txtcompanyname.Focus()
        End If
    End Sub

    Private Sub Add_car_company_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnaddcompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddcompany.Click
        Try
            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim s As Integer

            If txtcompanyname.Text = "" Then
                MsgBox("enter the Company Name")
            ElseIf txtcompanyname.Text <> "" Then

                cmd = New SqlCommand("select company from company", con)
                dr = cmd.ExecuteReader()
                While dr.Read
                    If dr(0).ToString = txtcompanyname.Text Then
                        MsgBox("This company has been alredy added")
                        txtcompanyname.Text = ""
                        s = 1
                    End If
                End While
                If s = 0 Then
                    dr.Close()

                    Dim i As Integer
                    icmd = New SqlCommand("insert into company(company)values('" & txtcompanyname.Text & "')", con)
                    i = icmd.ExecuteNonQuery()
                    If i = 1 Then
                        MsgBox("company added succefully")
                        txtcompanyname.Text = ""
                        cmblistofcompany.Items.Clear()

                        cmd = New SqlCommand("select company from company", con)
                        dr = cmd.ExecuteReader
                        While dr.Read
                            cmblistofcompany.Items.Add(dr(0).ToString)
                        End While
                        dr.Close()

                    Else
                        MsgBox("company addition is failed")

                    End If

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class