
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click





        If (txtUserName.Text = "") Then
            MsgBox("Enter User Name")
            txtUserName.Focus() 'focus the username textbox'
            Exit Sub
        End If


        If (txtPassword.Text = "") Then
                MsgBox("Enter Password")
                txtUserName.Focus() 'focus the password textbox'
                Exit Sub
            End If

        If (cmbUserType.SelectedItem = "") Then
            MsgBox("Select User Type")
            cmbUserType.Focus() 'focus on combo box'
            Exit Sub
        End If

        Try

            con = New SqlConnection("Data Source=LAPTOP-CNRTCKGK\SQLEXPRESS01;Initial Catalog=InnorikDB;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("Select * From Login Where UserName ='" & txtUserName.Text & "'And Password ='" & txtPassword.Text & "'And UserType ='" & cmbUserType.SelectedItem & "'", con)
            rdr = cmd.ExecuteReader()



            If (rdr.Read()) Then
                Dashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("Incorrect User Name and Password ")
                txtUserName.Text = ""
                txtPassword.Text = ""
                cmbUserType.SelectedItem = ""


            End If
        Catch ex As Exception
        End Try










    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
