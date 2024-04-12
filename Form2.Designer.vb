<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Product_R = New Label()
        Save_btn = New Button()
        Delete_btn = New Button()
        Search_btn = New Button()
        Back_btn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        productpricetb = New TextBox()
        productnametb = New TextBox()
        quantitytb = New TextBox()
        productcodetb = New TextBox()
        Clear_btn1 = New Button()
        Update_btn = New Button()
        SuspendLayout()
        ' 
        ' Product_R
        ' 
        Product_R.AutoSize = True
        Product_R.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Product_R.Location = New Point(258, 9)
        Product_R.Name = "Product_R"
        Product_R.Size = New Size(274, 24)
        Product_R.TabIndex = 1
        Product_R.Text = "PRODUCT REGISTRATION"
        ' 
        ' Save_btn
        ' 
        Save_btn.BackColor = Color.White
        Save_btn.FlatStyle = FlatStyle.Popup
        Save_btn.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Save_btn.Location = New Point(44, 106)
        Save_btn.Name = "Save_btn"
        Save_btn.Size = New Size(94, 31)
        Save_btn.TabIndex = 2
        Save_btn.Text = "SAVE"
        Save_btn.UseVisualStyleBackColor = False
        ' 
        ' Delete_btn
        ' 
        Delete_btn.BackColor = Color.White
        Delete_btn.FlatStyle = FlatStyle.Popup
        Delete_btn.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Delete_btn.Location = New Point(44, 217)
        Delete_btn.Name = "Delete_btn"
        Delete_btn.Size = New Size(94, 31)
        Delete_btn.TabIndex = 3
        Delete_btn.Text = "DELETE"
        Delete_btn.UseVisualStyleBackColor = False
        ' 
        ' Search_btn
        ' 
        Search_btn.BackColor = Color.White
        Search_btn.FlatStyle = FlatStyle.Popup
        Search_btn.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Search_btn.Location = New Point(44, 180)
        Search_btn.Name = "Search_btn"
        Search_btn.Size = New Size(94, 31)
        Search_btn.TabIndex = 4
        Search_btn.Text = "SEARCH"
        Search_btn.UseVisualStyleBackColor = False
        ' 
        ' Back_btn
        ' 
        Back_btn.BackColor = Color.White
        Back_btn.FlatStyle = FlatStyle.Popup
        Back_btn.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Back_btn.Location = New Point(44, 254)
        Back_btn.Name = "Back_btn"
        Back_btn.Size = New Size(94, 31)
        Back_btn.TabIndex = 6
        Back_btn.Text = "BACK"
        Back_btn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(168, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 19)
        Label1.TabIndex = 7
        Label1.Text = "Product Code:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(168, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 19)
        Label2.TabIndex = 8
        Label2.Text = "Product Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(168, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 19)
        Label3.TabIndex = 9
        Label3.Text = "Product Price:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(168, 229)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 19)
        Label4.TabIndex = 10
        Label4.Text = "Quantity:"
        ' 
        ' productpricetb
        ' 
        productpricetb.Font = New Font("Times New Roman", 11.25F)
        productpricetb.Location = New Point(301, 180)
        productpricetb.Multiline = True
        productpricetb.Name = "productpricetb"
        productpricetb.Size = New Size(181, 31)
        productpricetb.TabIndex = 13
        ' 
        ' productnametb
        ' 
        productnametb.Font = New Font("Times New Roman", 11.25F)
        productnametb.Location = New Point(301, 143)
        productnametb.Multiline = True
        productnametb.Name = "productnametb"
        productnametb.Size = New Size(362, 31)
        productnametb.TabIndex = 12
        ' 
        ' quantitytb
        ' 
        quantitytb.Font = New Font("Times New Roman", 11.25F)
        quantitytb.Location = New Point(301, 217)
        quantitytb.Multiline = True
        quantitytb.Name = "quantitytb"
        quantitytb.Size = New Size(181, 31)
        quantitytb.TabIndex = 14
        ' 
        ' productcodetb
        ' 
        productcodetb.Font = New Font("Times New Roman", 11.25F)
        productcodetb.Location = New Point(301, 106)
        productcodetb.Multiline = True
        productcodetb.Name = "productcodetb"
        productcodetb.Size = New Size(181, 31)
        productcodetb.TabIndex = 11
        ' 
        ' Clear_btn1
        ' 
        Clear_btn1.BackColor = Color.White
        Clear_btn1.FlatStyle = FlatStyle.Popup
        Clear_btn1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Clear_btn1.Location = New Point(301, 254)
        Clear_btn1.Name = "Clear_btn1"
        Clear_btn1.Size = New Size(94, 31)
        Clear_btn1.TabIndex = 15
        Clear_btn1.Text = "CLEAR"
        Clear_btn1.UseVisualStyleBackColor = False
        ' 
        ' Update_btn
        ' 
        Update_btn.BackColor = Color.White
        Update_btn.FlatStyle = FlatStyle.Popup
        Update_btn.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Update_btn.Location = New Point(44, 143)
        Update_btn.Name = "Update_btn"
        Update_btn.Size = New Size(94, 31)
        Update_btn.TabIndex = 16
        Update_btn.Text = "UPDATE"
        Update_btn.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(800, 450)
        Controls.Add(Update_btn)
        Controls.Add(Clear_btn1)
        Controls.Add(quantitytb)
        Controls.Add(productcodetb)
        Controls.Add(productpricetb)
        Controls.Add(productnametb)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Back_btn)
        Controls.Add(Search_btn)
        Controls.Add(Delete_btn)
        Controls.Add(Save_btn)
        Controls.Add(Product_R)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PRODUCT REGISTRATION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Product_R As Label
    Friend WithEvents Save_btn As Button
    Friend WithEvents Delete_btn As Button
    Friend WithEvents Search_btn As Button
    Friend WithEvents Back_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents productpricetb As TextBox
    Friend WithEvents productnametb As TextBox
    Friend WithEvents quantitytb As TextBox
    Friend WithEvents productcodetb As TextBox
    Friend WithEvents Clear_btn1 As Button
    Friend WithEvents Update_btn As Button
End Class
