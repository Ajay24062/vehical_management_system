Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class Add_customer
  
    Dim dr, d2 As SqlDataReader
    Dim cmd, cmd2, scmd, sscmd As New SqlCommand
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter

    Dim i As Integer = 0
    Dim i1 As Integer = 0
    Dim i2 As Integer = 0
    Dim i3 As Integer = 0


    Private Sub Add_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
        txtbookdate.Text = Date.Today.Date
        Try



            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd2 = New SqlCommand("select max(custid) from tbladdcustomer", con)
            
            Dim id As Integer = cmd2.ExecuteScalar
            txtcustomerid.Text = id + 1
            txtcustomerid.Enabled = False




        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        txtcarnumber.Enabled = False
        txtrentperday.Enabled = False
        txttotalrent.Enabled = False

        txtdriverid.Hide()

        txtname.Focus()
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
      
        txtcarnumber.Enabled = False
        txtrentperday.Enabled = False
        txttotalrent.Enabled = False

        txtdriverid.Hide()

        txtname.Focus()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim value1 As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        If IsDBNull(value1) Then
            txtcarnumber.Text = "" ' blank if dbnull values
        Else
            txtcarnumber.Text = value1
        End If
        Dim value2 As Object = DataGridView1.Rows(e.RowIndex).Cells(11).Value
        If IsDBNull(value2) Then
            txtdriverid.Text = " " ' blank if dbnull values
        Else
            txtdriverid.Text = value2
        End If
        Dim value3 As String = DataGridView1.Rows(e.RowIndex).Cells(10).Value
        If IsDBNull(value3) Then
            txtrentperday.Text = "" ' blank if dbnull values
        Else
            txtrentperday.Text = value3
        End If
       
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
        If Not Regex.Match(txtphoneno.Text, "^[0-9 ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers only.")
            txtphoneno.Text = ""
            txtphoneno.Focus()

        End If
    End Sub

 
   
    Private Sub txtrentingdays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrentingdays.TextChanged
        If Not Regex.Match(txtrentingdays.Text, "^[0-9 ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers only.")
            txtrentingdays.Text = ""
            txtrentingdays.Focus()

        End If
    End Sub

    Private Sub txtrentperday_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrentperday.TextChanged
        If Not Regex.Match(txtrentperday.Text, "^[0-9 ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers only.")
            txtrentperday.Text = ""
            txtrentperday.Focus()

        End If
    End Sub

    Private Sub txttotalrent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotalrent.TextChanged
        If Not Regex.Match(txttotalrent.Text, "^[0-9 ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers only.")
            txttotalrent.Text = ""
            txttotalrent.Focus()

        End If
    End Sub

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
            ElseIf txtphoneno.Text = "" Then
                ErrorProvider1.SetError(txtphoneno, "Enter phone no")
                txtphoneno.Focus()

            ElseIf txtphoneno.Text.Length <> 10 Then
                MessageBox.Show("MObile/phone number must be 10 digit...")
                txtphoneno.Focus()

            ElseIf cmbusaseas.SelectedItem = "" Then
                ErrorProvider1.SetError(cmbusaseas, "Select Useas")
                cmbusaseas.Focus()
            ElseIf i = 0 Then
                MsgBox("First Search Cars")
            ElseIf i3 = 0 Then
                MsgBox("calculate total")
            ElseIf txtcarnumber.Text = "" Then
                ErrorProvider1.SetError(txtcarnumber, "Select Car No")
                txtcarnumber.Focus()

            ElseIf txtname.Text <> "" Or rtxxtaddress.Text <> "" Or cmbusaseas.SelectedItem <> "" Or txtphoneno.Text <> "" Then
                If rbfemale.Checked = True Or rbmale.Checked = True Then
                    cmd.Connection = Module1.con

                    Dim st As String
                    If rbfemale.Checked = True Then
                        st = rbfemale.Text
                    ElseIf rbmale.Checked = True Then
                        st = rbmale.Text
                    End If


                    dr.Close()
                    Dim r As String = "Rented"


                    scmd = New SqlCommand("insert into tbladdcustomer(name,phoneno,address,gender,requirement,driverid,carnumber,rentingdays,totalbill,bdate)values('" & txtname.Text & "'," & txtphoneno.Text & ",'" & rtxxtaddress.Text & "','" & st & "','" & cmblistofcompany.Text & "','" & txtdriverid.Text & "','" & txtcarnumber.Text & "','" & txtrentingdays.Text & "','" & txttotalrent.Text & "','" & txtbookdate.Text & "')", Module1.con)
                    sscmd = New SqlCommand("update tblcars set status='" & r & "' where carnumber='" & txtcarnumber.Text & "'", con)

                    i1 = scmd.ExecuteNonQuery
                    i2 = sscmd.ExecuteNonQuery

                    If i1 = 1 And i2 = 1 Then
                        MsgBox("Customer Added Succesfully", MsgBoxStyle.Information)
                        txtname.Clear()
                        txtphoneno.Clear()
                        cmbusaseas.SelectedIndex = -1
                        rbfemale.Checked = False
                        rbmale.Checked = False
                        rtxxtaddress.Clear()
                        txtcustomerid.Clear()
                        txtrentingdays.Clear()
                        txtrentperday.Clear()
                        txttotalrent.Clear()
                        txtcarnumber.Clear()
                        txtdriverid.Clear()
                        cmblistofcompany.SelectedIndex = -1
                        cmbseatingcapicity.SelectedIndex = -1
                    Else
                        MsgBox("Customer Addittion failed ", MsgBoxStyle.Information)
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

    Private Sub btnavalablecars_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnavalablecars.Click
        Try
            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            ErrorProvider1.Clear()

            ds.Clear()
            DataGridView1.DataSource() = ds

            Dim st As String = "Unrented"
            If cmblistofcompany.Text = "" Then
                ErrorProvider1.SetError(cmblistofcompany, "Select company")
                cmblistofcompany.Focus()
            ElseIf cmbseatingcapicity.Text = "" Then
                ErrorProvider1.SetError(cmbseatingcapicity, "Select Seating capacity")
                cmbseatingcapicity.Focus()
            ElseIf cmbusaseas.Text = "" Then
                ErrorProvider1.SetError(cmbusaseas, "Select Useas")
                cmbusaseas.Focus()
            Else
                cmd = New SqlCommand("select * from tblcars where company='" & cmblistofcompany.Text & "' and sittingcapacity='" & cmbseatingcapicity.Text & "' and useas='" & cmbusaseas.Text & "' and status='" & st & "'", con)

                da = New SqlDataAdapter(cmd)


                da.Fill(ds, "tblcars")
                DataGridView1.DataSource() = ds.Tables(0)
                i = 1
                con.Close()
                lblshow.Text = "Select Any Cell From a Row in Table To Import data."
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub cmbusaseas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusaseas.SelectedIndexChanged
        If cmbusaseas.SelectedIndex = 0 Then
            txtdriverid.Show()
            txtdriverid.Enabled = False
        ElseIf cmbusaseas.SelectedIndex = 1 Then
            txtdriverid.Hide()

        End If
    End Sub

    Private Sub btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click
        If txtrentingdays.Text = "" Then
            ErrorProvider1.SetError(txtrentingdays, "Enter renting days")
            txtrentingdays.Focus()
        ElseIf txtrentperday.Text = "" Then
            ErrorProvider1.SetError(txtrentperday, "fetch the value from table")
            txtrentperday.Focus()
        Else
            txttotalrent.Text = Integer.Parse(txtrentingdays.Text) * Integer.Parse(txtrentperday.Text)
            i3 = 1
        End If
    End Sub
End Class