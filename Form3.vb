Imports MySql.Data.MySqlClient

Public Class Form3
    Public Sub list_column()
        'ListView2 Column Command
        With LV2
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("Product_Code", 100)
            .Columns.Add("Product_Name", 250)
            .Columns.Add("Product_Price", 100)
            .Columns.Add("Quantity", 100)
            .Columns.Add("SubTotal", 100)
            .Columns.Add("Receipt No.", 100)
        End With
    End Sub

    Public Sub Form3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Display Items in ListView2 Command
        Call list_column()
    End Sub

    'Connection to Receipt Number Command
    Dim connectionString As String = "server=localhost; user id=root; password=; database=productsdb;"
    Dim receiptNo As Integer = 0 ' Variable to hold the current receipt number

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Generate the Initial Receipt Number when the Form 3 Loads
        GenerateReceiptNumber()
    End Sub

    Private Sub GenerateReceiptNumber()
        ' Allows to Retrieve the last Receipt Number from the Database and Increment it by 1
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT IFNULL(MAX(Receipt_No), 0) + 1 FROM productsales"
            Using command As New MySqlCommand(query, connection)
                receiptNo = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
        TB9.Text = receiptNo.ToString("0000") ' Display the receipt number in the TextBox
    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        'Search Items in Product Inventory to be Purchased Command
        Dim connString As String = "server=localhost; user id=root; password=; database=productsdb;"
        Dim sqlQuery As String = "SELECT * FROM `productsdata` WHERE Product_Code = @Product_Code"

        Using sqlConn As New MySqlConnection(connString)
            Using sqlComm As New MySqlCommand(sqlQuery, sqlConn)
                sqlComm.Parameters.AddWithValue("@Product_Code", TB1.Text)
                'Searching Data Command
                Try
                    sqlConn.Open()
                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                    If sqlReader.Read() Then
                        TB2.Text = sqlReader("Product_Name").ToString()
                        TB3.Text = sqlReader("Product_Price").ToString()
                    Else
                        MessageBox.Show("Product Code doesn't exist, Please try again.")
                    End If
                    sqlReader.Close()
                Catch ex As MySqlException
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Function GetAvailableQuantity(productCode As String) As Integer
        'To Check the Product Quantity in our DataBase
        Dim availableQuantity As Integer = 0
        Dim connectionString As String = "server=localhost; user id=root; password=; database=productsdb;"
        Dim query As String = "SELECT Quantity FROM productsdata WHERE Product_Code = @Product_Code"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Product_Code", productCode)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    availableQuantity = Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return availableQuantity
    End Function


    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        'Add Textboxes Data to ListView Command
        If TB1.Text = Nothing Then
            MsgBox("Please Enter Product Code.", MsgBoxStyle.Exclamation, "Product Code Error")
            TB1.Focus()
            Exit Sub
        ElseIf TB2.Text = Nothing Then
            MsgBox("Please enter Product Name.", MsgBoxStyle.Exclamation, "Product Name Error")
            TB2.Focus()
            Exit Sub
        ElseIf TB3.Text = Nothing Then
            MsgBox("Please enter Product Price.", MsgBoxStyle.Exclamation, "Product Price Error")
            TB3.Focus()
            Exit Sub
        ElseIf TB4.Text = Nothing Then
            MsgBox("Please enter Product Quantity.", MsgBoxStyle.Exclamation, "Product Quantity Error")
            TB4.Focus()
            Exit Sub
        End If

        'To Notify if the Product Quantity is Insufficient
        Dim productCode As String = TB1.Text
        Dim requestedQuantity As Integer

        If Integer.TryParse(TB4.Text, requestedQuantity) Then
            Dim availableQuantity As Integer = GetAvailableQuantity(productCode)
            If availableQuantity >= requestedQuantity Then
                Dim temp As Integer
                temp = LV2.Items.Count
                Dim list As New ListViewItem(TB1.Text)
                list.SubItems.Add(TB2.Text)
                list.SubItems.Add(TB3.Text)
                list.SubItems.Add(TB4.Text)
                list.SubItems.Add(TB6.Text)
                list.SubItems.Add(TB9.Text)
                LV2.Items.Add(list)

                TB1.Text = Nothing
                TB2.Text = Nothing
                TB3.Text = Nothing
                TB6.Text = Nothing
            ElseIf requestedQuantity > availableQuantity Then
                MessageBox.Show("Insufficient Quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        TB4.Text = Nothing

        'Get the Total in ListView2 and Display in TB6 TextBox
        Dim sum As Integer = 0
        Dim column4 As Integer = 4

        For Each item As ListViewItem In LV2.Items
            Dim subItemText As String = item.SubItems(4).Text
            Dim value As Integer
            If Not String.IsNullOrEmpty(subItemText) AndAlso Integer.TryParse(subItemText, value) Then
                sum += value
            End If
        Next
        TB6.Text = sum.ToString()
    End Sub

    Private Sub Removebtn_Click(sender As Object, e As EventArgs) Handles Removebtn.Click
        'Remove Items in ListView2 Command
        If LV2.Items.Count = 0 Then
            MsgBox("No items to remove.", MsgBoxStyle.Exclamation, "Remove Error")
            Exit Sub
        Else
            Dim itemCnt, t As Integer
            LV2.FocusedItem.Remove()
            itemCnt = LV2.Items.Count
            t = 1
        End If
    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        For Each lvitem As ListViewItem In LV2.Items
            Dim ProductsCode As String = lvitem.SubItems(0).Text
            Dim Quantity As Integer = Convert.ToInt32(lvitem.SubItems(3).Text)

            Dim conn As New MySqlConnection("server=localhost; user id=root; password=; database=productsdb;")
            Dim cmd As New MySqlCommand("UPDATE productsdata SET Quantity = Quantity - @Quantity WHERE Product_Code = @Product_Code", conn)

            cmd.Parameters.AddWithValue("@Quantity", Quantity)
            cmd.Parameters.AddWithValue("@Product_Code", ProductsCode)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        Next
        'Empty Amount Tendered Command
        If TB7.Text = Nothing Then
            MsgBox("Please Amount Tendered.", MsgBoxStyle.Exclamation, "Product Code Error")
            TB7.Focus()
            Exit Sub
        End If

        'Receipt Number Command
        If LV2.Items.Count > 0 Then
            receiptNo += 1
            TB9.Text = receiptNo.ToString("0000")
        End If

        'Save Transactions Data to Productsales Table Command
        For Each lvitem As ListViewItem In LV2.Items
            Dim conn As New MySqlConnection("server=localhost; user id=root; password=; database=productsdb;")
            Dim cmd As New MySqlCommand("INSERT INTO productsales (Product_Code, ProductName, ProductPrice, Quantity_Sold, Total_Amount, Receipt_No) VALUES (@Product_Code,@ProductName,@ProductPrice,@Quantity_Sold,@Total_Amount,@Receipt_No)", conn)
            cmd.Parameters.AddWithValue("@Product_Code", lvitem.SubItems(0).Text)
            cmd.Parameters.AddWithValue("@ProductName", lvitem.SubItems(1).Text)
            cmd.Parameters.AddWithValue("@ProductPrice", lvitem.SubItems(2).Text)
            cmd.Parameters.AddWithValue("@Quantity_Sold", lvitem.SubItems(3).Text)
            cmd.Parameters.AddWithValue("@Total_Amount", lvitem.SubItems(4).Text)
            cmd.Parameters.AddWithValue("@Receipt_No", lvitem.SubItems(5).Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        Next

        TB6.Text = Nothing
        TB7.Text = Nothing
        TB8.Text = Nothing
        MessageBox.Show("Purchase Record has been Save Successfully")
        LV2.Items.Clear()
    End Sub

    Private Sub LV2_DoubleClick(sender As Object, e As EventArgs) Handles LV2.DoubleClick
        'Allows To Edit The Double Clicked Items In ListView2
        If Me.LV2.SelectedItems.Count > 0 Then
            Dim lv1 As ListViewItem = Me.LV2.SelectedItems(0)
            For Each lvitem As ListViewItem In LV2.Items
                Dim ProductsCode As String = lvitem.SubItems(0).Text
                Dim Quantity As Integer = Convert.ToInt32(lvitem.SubItems(3).Text)

                Dim conn As New MySqlConnection("server=localhost; user id=root; password=; database=productsdb;")
                Dim cmd As New MySqlCommand("UPDATE productsdata SET Quantity = Quantity + @Quantity WHERE Product_Code = @Product_Code", conn)

                cmd.Parameters.AddWithValue("@Quantity", Quantity)
                cmd.Parameters.AddWithValue("@Product_Code", ProductsCode)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            Next
            TB1.Text = lv1.SubItems(0).Text
            TB2.Text = lv1.SubItems(1).Text
            TB3.Text = lv1.SubItems(2).Text
            TB4.Text = lv1.SubItems(3).Text
            TB6.Text = lv1.SubItems(4).Text
            TB9.Text = lv1.SubItems(5).Text
            LV2.FocusedItem.Remove()
        End If

    End Sub

    Private Sub TB4_TextChanged(sender As Object, e As EventArgs) Handles TB4.TextChanged
        'Quantity x Price Command
        TB6.Text = Val(TB4.Text) * Val(TB3.Text)
    End Sub

    Private Sub TB7_TextChanged(sender As Object, e As EventArgs) Handles TB7.TextChanged
        'Amount Tendered - Total Command
        TB8.Text = Val(TB7.Text) - Val(TB6.Text)
    End Sub


End Class