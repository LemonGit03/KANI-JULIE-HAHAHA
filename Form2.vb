﻿Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Save_btn_Click(sender As Object, e As EventArgs) Handles Save_btn.Click
        'Save Data to our Database
        Try
            Save("INSERT INTO productsdata (Product_Code, Product_Name, Product_Price, Quantity) VALUES('" & productcodetb.Text & "','" & productnametb.Text & "','" & productpricetb.Text & "', '" & quantitytb.Text & "')")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        productcodetb.Text = Nothing
        productnametb.Text = Nothing
        productpricetb.Text = Nothing
        quantitytb.Text = Nothing
    End Sub

    Private Sub Back_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click
        Me.Hide()
        Form1.Show()
        productcodetb.Text = Nothing
        productnametb.Text = Nothing
        productpricetb.Text = Nothing
        quantitytb.Text = Nothing
    End Sub

    Private Sub Search_btn_Click(sender As Object, e As EventArgs) Handles Search_btn.Click
        ' Search in Database and Display in TextBox
        Dim connString As String = "server=localhost; user id=root; password=; database=productsdb;"
        Dim sqlQuery As String = "SELECT * FROM `productsdata` WHERE Product_Code = @Product_Code"

        Using sqlConn As New MySqlConnection(connString)
            Using sqlComm As New MySqlCommand(sqlQuery, sqlConn)
                sqlComm.Parameters.AddWithValue("@Product_Code", productcodetb.Text)

                Try
                    sqlConn.Open()
                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()

                    If sqlReader.Read() Then
                        productnametb.Text = sqlReader("Product_Name").ToString()
                        productpricetb.Text = sqlReader("Product_Price").ToString()
                        quantitytb.Text = sqlReader("Quantity").ToString()
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

    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click
        'Delete Items in Database
        Try
            Delete("DELETE FROM productsdata WHERE Product_Code = '" & productcodetb.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        productcodetb.Text = Nothing
        productnametb.Text = Nothing
        productpricetb.Text = Nothing
        quantitytb.Text = Nothing
    End Sub

    Private Sub Clear_btn1_Click(sender As Object, e As EventArgs) Handles Clear_btn1.Click
        'Clear Items in Textboxes
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        'Update Data in our Database
        Try
            Updates("UPDATE productsdata SET Product_Name = '" & productnametb.Text & "', Product_Price = '" & productpricetb.Text & "', Quantity = '" & quantitytb.Text & "' WHERE Product_Code = '" & productcodetb.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        productcodetb.Text = Nothing
        productnametb.Text = Nothing
        productpricetb.Text = Nothing
        quantitytb.Text = Nothing
    End Sub
End Class