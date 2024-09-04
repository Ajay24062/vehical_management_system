Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class Add_vehicle
    Dim scmd, cmd, cmd1 As New SqlCommand
    Dim dr As SqlDataReader
    Dim i, i1 As Integer
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Call Module1.connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            ErrorProvider1.Clear()
            If txtcarmodel.Text = "" Then
                ErrorProvider1.SetError(txtcarmodel, "Enter car model")
                txtcarmodel.Focus()
            ElseIf cmblistofcompany.Text = "" Then
                ErrorProvider1.SetError(cmblistofcompany, "Select Company")
                cmblistofcompany.Focus()
            ElseIf txtcarnumber.Text = "" Then
                ErrorProvider1.SetError(txtcarnumber, "Enter Car no")
                txtcarnumber.Focus()
            ElseIf txtmakeyear.Text = "" Then
                ErrorProvider1.SetError(txtmakeyear, "Enter Make year")
                txtmakeyear.Focus()
            ElseIf txtmakeyear.Text.Length <> 4 Then
                ErrorProvider1.SetError(txtmakeyear, "Enter Make year of 4 digit only")
                txtmakeyear.Focus()
            ElseIf cmbuseas.Text = "" Then
                ErrorProvider1.SetError(cmbuseas, "Select use as type")
                cmbuseas.Focus()
            ElseIf cmbsittingcapacity.Text = "" Then
                ErrorProvider1.SetError(cmbsittingcapacity, "Select Sitting Capacity")
                cmbsittingcapacity.Focus()
            ElseIf txtenginecapacity.Text = "" Then
                ErrorProvider1.SetError(txtenginecapacity, "Enter engine capacity")
                txtenginecapacity.Focus()
            ElseIf cmbtype.Text = "" Then
                ErrorProvider1.SetError(cmbtype, "Select Type")
                cmbtype.Focus()
            ElseIf cmbvarient.Text = "" Then
                ErrorProvider1.SetError(cmbvarient, "Select Varient")
                cmbvarient.Focus()
            ElseIf txtrent.Text = "" Then
                ErrorProvider1.SetError(txtrent, "Enter rent")
                txtrent.Focus()


            Else
                Dim sts As String = "Unrented"
                cmd.Connection = Module1.con
                cmd = New SqlCommand("insert into tblcars(carmodel,company,carnumber,makeyear,useas,sittingcapacity,enginecapacity,type,varient,rent,status)values('" & txtcarmodel.Text & "','" & cmblistofcompany.Text & "','" & txtcarnumber.Text & "'," & txtmakeyear.Text & ",'" & cmbuseas.Text & "','" & cmbsittingcapacity.Text & "'," & txtenginecapacity.Text & ",'" & cmbtype.Text & "','" & cmbvarient.Text & "'," & txtrent.Text & ",'" & sts & "')", Module1.con)
                i = cmd.ExecuteNonQuery()
                If i = 1 Then
                    MsgBox("car Added Succesfully", MsgBoxStyle.Information)
                    txtcarmodel.Clear()
                    txtcarnumber.Clear()
                    txtenginecapacity.Clear()
                    txtmakeyear.Clear()
                    txtrent.Clear()
                    cmblistofcompany.SelectedIndex = -1
                    cmbsittingcapacity.SelectedIndex = -1
                    cmbtype.SelectedIndex = -1
                    cmbvarient.SelectedIndex = -1
                    cmbuseas.SelectedIndex = -1

                Else
                    MsgBox("car Addittion failed ", MsgBoxStyle.Information)

                End If
            End If




        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Add_vehicle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub txtcarmodel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcarmodel.TextChanged
        If Not Regex.Match(txtcarmodel.Text, "^[a-zA-Z ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter alpha text only.")
            txtcarmodel.Text = ""
            txtcarmodel.Focus()
            If txtcarmodel.Text.Length > 8 Then
                MsgBox("You have crossed the limit")
            End If
        End If
    End Sub

    Private Sub txtmakeyear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmakeyear.TextChanged
        If Not Regex.Match(txtmakeyear.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers only.")
            txtmakeyear.Text = ""
            txtmakeyear.Focus()
            If txtcarmodel.Text.Length > 4 Then
                MsgBox("You have Enter 4 digit")
            End If

        End If
    End Sub

    Private Sub txtenginecapacity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtenginecapacity.TextChanged
        If Not Regex.Match(txtenginecapacity.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers only.")
            txtenginecapacity.Text = ""
            txtenginecapacity.Focus()
            If txtcarmodel.Text.Length > 6 Then
                MsgBox("You have crossed the limit")
            End If

        End If
    End Sub

    Private Sub txtrent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrent.TextChanged
        If Not Regex.Match(txtrent.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers only.")
            txtrent.Text = ""
            txtrent.Focus()
            If txtcarmodel.Text.Length > 5 Then
                MsgBox("You have crossed the limit")
            End If

        End If
    End Sub

    Private Sub txtcarnumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcarnumber.TextChanged
        If Not Regex.Match(txtcarnumber.Text, "^[0-9a-zA-z ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers And Alpha only.")
            txtcarnumber.Text = ""
            txtcarnumber.Focus()
            If txtcarnumber.Text.Length > 10 Then
                MsgBox("You have crossed the limit")
            End If

        End If
    End Sub

    
End Class