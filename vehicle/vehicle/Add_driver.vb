Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Add_driver
    Dim dr, d2 As SqlDataReader
    Dim cmd, cmd2, scmd, sscmd As New SqlCommand
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter

    Dim i As Integer = 0
    Dim i1 As Integer = 0
    Dim i2 As Integer = 0


    Private Sub Add_driver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VehicledbDataSet.tblcars' table. You can move, or remove it, as needed.
        Me.TblcarsTableAdapter.Fill(Me.VehicledbDataSet.tblcars)

        txtdateofjoining.Text = Date.Today.Date



        Try
            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd2 = New SqlCommand("select max(driverid) from tbladddriver", con)

            Dim id As Integer = Convert.ToString(cmd2.ExecuteScalar)
            txtdriverid.Text = id + 1
            txtdriverid.Enabled = False


            cmd = New SqlCommand("select company from company", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cmblistofcompany.Items.Add(dr(0).ToString)
            End While
            dr.Close()

        Catch ex As Exception
        End Try
        txtcarnumber.Enabled = False

        txtname.Focus()
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

            ElseIf cmbexperience.SelectedItem = "" Then
                ErrorProvider1.SetError(cmbexperience, "Select Qualification")
                cmbexperience.Focus()
            ElseIf i = 0 Then
                MsgBox("First Search Cars")

            ElseIf txtcarnumber.Text = "" Then
                ErrorProvider1.SetError(txtcarnumber, "Select Car No")
                txtcarnumber.Focus()

            ElseIf txtname.Text <> "" Or rtxxtaddress.Text <> "" Or cmbexperience.SelectedItem <> "" Or txtphoneno.Text <> "" Then
                If rbfemale.Checked = True Or rbmale.Checked = True Then
                    cmd.Connection = Module1.con

                    Dim st As String
                    If rbfemale.Checked = True Then
                        st = rbfemale.Text
                    ElseIf rbmale.Checked = True Then
                        st = rbmale.Text
                    End If

                  
                    dr.Close()
                    Dim s As String = "Yes"


                    scmd = New SqlCommand("insert into tbladddriver(name,phoneno,address,dob,dateofjoining,experience,gender)values('" & txtname.Text & "'," & txtphoneno.Text & ",'" & rtxxtaddress.Text & "','" & DateTimePicker1.Text & "','" & txtdateofjoining.Text & "','" & cmbexperience.Text & "','" & st & "')", Module1.con)
                    sscmd = New SqlCommand("update tblcars set driver_id='" & txtdriverid.Text & "',driver='" & s & "' where carnumber='" & txtcarnumber.Text & "'", con)

                    i1 = scmd.ExecuteNonQuery()
                    i2 = sscmd.ExecuteNonQuery

                    If i1 = 1 And i2 = 1 Then
                        MsgBox("Driver Added Succesfully", MsgBoxStyle.Information)
                        txtname.Clear()
                        txtphoneno.Clear()
                        cmbexperience.SelectedIndex = -1
                        rbfemale.Checked = False
                        rbmale.Checked = False
                        rtxxtaddress.Clear()

                    Else
                        MsgBox("Driver Addittion failed ", MsgBoxStyle.Information)
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

    Private Sub txtdriverid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdriverid.TextChanged
        If Not Regex.Match(txtdriverid.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers only.")
            txtdriverid.Text = ""
            txtdriverid.Focus()
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
        End If
    End Sub

    Private Sub txtcarno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcarnumber.TextChanged
        If Not Regex.Match(txtcarnumber.Text, "^[0-9a-zA-z ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers And Alpha only.")
            txtcarnumber.Text = ""
            txtcarnumber.Focus()

        End If
    End Sub

    Private Sub cmbselectcompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblistofcompany.SelectedIndexChanged

    End Sub

    Private Sub btncaravailable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncaravailable.Click
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
            ElseIf cmbseatingcapicity.Text = "" Then
                ErrorProvider1.SetError(cmbseatingcapicity, "Select Seating capacity")
                cmbseatingcapicity.Focus()
            Else
                Dim sw As String = "Taxi"

                cmd = New SqlCommand("select * from tblcars where company='" & cmblistofcompany.Text & "' and sittingcapacity='" & cmbseatingcapicity.Text & "' and useas='" & sw & "'", con)

                da = New SqlDataAdapter(cmd)


                da.Fill(ds, "tblcars")
                DataGridView1.DataSource() = ds.Tables(0)
                i = 1
                con.Close()


                lblshow.Text = "Select Any Cell From a Row in Table To Import CarNo."

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
       
        Dim value As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        If IsDBNull(value) Then
            txtcarnumber.Text = "" ' blank if dbnull values
        Else
            txtcarnumber.Text = value

        End If

    End Sub



End Class