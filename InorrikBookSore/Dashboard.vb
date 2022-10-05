Imports System.Data.SqlClient
Imports System.Net


Public Class Dashboard

    Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-CNRTCKGK\SQLEXPRESS01;Initial Catalog=InnorikDB;Integrated Security=True")
    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim BookID As Integer = txtBookID.Text
        Dim BookName As String = txtBookName.Text
        Dim Category As String = txtCategory.Text
        Dim Description As String = txtDescription.Text
        Dim Price As String = txtPrice.Text


        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("Insert Into Books VALUES('" & BookID & "','" & BookName & "','" & Category & "','" & Price & "','" & Description & "')", con)

        If cmd.ExecuteNonQuery() Then
            con.Close()
            MessageBox.Show("Successfully Inserted.")
            txtBookID.Clear()
            txtBookName.Clear()
            txtCategory.Clear()
            txtDescription.Clear()
            txtPrice.Clear()

            LoadDataInGrind()
        End If
    End Sub

    Private Sub btnUPDATE_Click(sender As Object, e As EventArgs) Handles btnUPDATE.Click

        Dim BookID As Integer = txtBookID.Text
        Dim BookName As String = txtBookName.Text
        Dim Category As String = txtCategory.Text
        Dim Description As String = txtDescription.Text
        Dim Price As String = txtPrice.Text


        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("Update Books Set BookName ='" & BookName & "',Category ='" & Category & "',Price ='" & Price & "', Description ='" & Description & "' Where BookID ='" & BookID & "'", con)



        If cmd.ExecuteNonQuery() Then
            con.Close()
            MessageBox.Show("Successfully Updated.")
            txtBookID.Clear()
            txtBookName.Clear()
            txtCategory.Clear()
            txtDescription.Clear()
            txtPrice.Clear()

            LoadDataInGrind()
        End If






    End Sub

    Private Sub btnDELETE_Click(sender As Object, e As EventArgs) Handles btnDELETE.Click
        Dim BookID As Integer = txtBookID.Text


        If MessageBox.Show("Do you want to delete?", "Delete Book", MessageBoxButtons.YesNo) = DialogResult.Yes Then


            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("Delete From Books Where BookID ='" & BookID & "'", con)

            If cmd.ExecuteNonQuery() Then
                con.Close()
                MessageBox.Show("Successfully Deleted.")
                txtBookID.Clear()


                LoadDataInGrind()
            End If

        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim BookID As Integer = txtBookID.Text
        Dim BookName As String = txtBookName.Text

        con.Open()
        Dim cmd As New SqlCommand("Select * From Books Where BookID ='" & BookID & "' And BookName='" & BookName & "'", con)
        Dim source As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        source.Fill(dt)
        dataGrid.DataSource = dt

        con.Close()

    End Sub

    Private Sub LoadDataInGrind()
        Dim cmd As New SqlCommand("Select * From Books", con)
        Dim source As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        source.Fill(dt)
        dataGrid.DataSource = dt

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInGrind()
    End Sub
End Class