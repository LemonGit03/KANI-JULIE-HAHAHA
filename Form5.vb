Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Data.SqlClient
Public Class Form5

    Dim con As New MySqlConnection("server=localhost; user id=root; password=; database=productsdb;")
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim sql As String
    Dim result As Integer

    Private Sub Generate_btn2_Click(sender As Object, e As EventArgs) Handles Generate_btn2.Click
        'Generate Item In ListView3
        Try
            con.Open()
            sql = "SELECT * FROM productsales"
            cmd = New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
                dr = .ExecuteReader
            End With
            LV3.Items.Clear()
            Do While dr.Read = True
                Dim list = LV3.Items.Add(dr(0))
                list.SubItems.Add(dr.Item(1))
                list.SubItems.Add(dr.Item(2))
                list.SubItems.Add(dr.Item(3))
                list.SubItems.Add(dr.Item(4))
                list.SubItems.Add(dr.Item(5))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Search_btn3_Click(sender As Object, e As EventArgs) Handles Search_btn3.Click
        Dim connectionString As String = "server=localhost; user id=root; password=; database=productsdb"
        Dim connection As New MySqlConnection(connectionString)
        Dim receiptNumber As String = TB10.Text.Trim()

        ' Clear existing data in the listview
        LV3.Items.Clear()

        ' Open connection to the database
        Connection.Open()

        ' Create SQL command to search for receipts
        Dim command As New MySqlCommand("SELECT * FROM productsales WHERE Receipt_No = @Receipt_No", connection)
        command.Parameters.AddWithValue("@Receipt_No", receiptNumber)

        ' Execute the command
        Dim reader As MySqlDataReader = command.ExecuteReader()

        ' Display the results in the listview
        While reader.Read()
            Dim Product_Code As String = reader.GetInt32(0)
            Dim ProductName As String = reader.GetString(1)
            Dim ProductPrice As Decimal = reader.GetDecimal(2)
            Dim Quantity_Sold As Integer = reader.GetInt32(3)
            Dim Total_Amount As Decimal = reader.GetDecimal(4)
            Dim Receipt_No As String = reader.GetString(5)

            Dim row As New ListViewItem(Product_Code.ToString())
            row.SubItems.Add(ProductName)
            row.SubItems.Add(ProductPrice)
            row.SubItems.Add(Quantity_Sold)
            row.SubItems.Add(Total_Amount)
            row.SubItems.Add(Receipt_No)

            LV3.Items.Add(row)
        End While
        reader.Close()
        connection.Close()
    End Sub
End Class