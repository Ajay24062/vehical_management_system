Imports System.Data.SqlClient

Public Class Admin_change_password
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim i As Integer
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
    Private Sub txtcurrentpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcurrentpassword.TextChanged

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub txtreenterpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreenterpassword.TextChanged

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub txtchangepassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtchangepassword.TextChanged

    End Sub
    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If txtcurrentpassword.Text = "" Or txtchangepassword.Text = "" Or txtreenterpassword.Text = "" Then
            MsgBox("Any textbox should not be empty")
        ElseIf txtchangepassword.Text <> txtreenterpassword.Text Then
            MsgBox("Both of the new password should be same")
        ElseIf txtchangepassword.Text = txtreenterpassword.Text Then
            cmd = New SqlCommand("update adminlogin set password='" & txtchangepassword.Text & "'where password='" & txtcurrentpassword.Text & "'", Module1.con)
            i = cmd.ExecuteNonQuery()
            If i = 1 Then
                Me.Hide()
                MsgBox("Password has been changed")
            Else

                MsgBox("current password is not valid")
            End If


        End If
    End Sub
End Class