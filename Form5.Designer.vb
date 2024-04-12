<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        LV3 = New ListView()
        Product_Code = New ColumnHeader()
        Product_Name = New ColumnHeader()
        Product_Price = New ColumnHeader()
        Quantity = New ColumnHeader()
        Total_Amount = New ColumnHeader()
        Reciept_No = New ColumnHeader()
        Backbtn = New Button()
        Generate_btn2 = New Button()
        Label1 = New Label()
        TB10 = New TextBox()
        Search_btn3 = New Button()
        SuspendLayout()
        ' 
        ' LV3
        ' 
        LV3.CheckBoxes = True
        LV3.Columns.AddRange(New ColumnHeader() {Product_Code, Product_Name, Product_Price, Quantity, Total_Amount, Reciept_No})
        LV3.Font = New Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LV3.FullRowSelect = True
        LV3.Location = New Point(62, 147)
        LV3.Name = "LV3"
        LV3.Size = New Size(904, 259)
        LV3.TabIndex = 9
        LV3.UseCompatibleStateImageBehavior = False
        LV3.View = View.Details
        ' 
        ' Product_Code
        ' 
        Product_Code.Tag = "Product_Code"
        Product_Code.Text = "Product Code"
        Product_Code.Width = 150
        ' 
        ' Product_Name
        ' 
        Product_Name.Tag = "Product_Name"
        Product_Name.Text = "Product Name"
        Product_Name.Width = 250
        ' 
        ' Product_Price
        ' 
        Product_Price.Tag = "Product_Price"
        Product_Price.Text = "Product Price"
        Product_Price.Width = 150
        ' 
        ' Quantity
        ' 
        Quantity.Tag = "Quantity"
        Quantity.Text = "Quantity"
        Quantity.Width = 100
        ' 
        ' Total_Amount
        ' 
        Total_Amount.Tag = "Total_Amount"
        Total_Amount.Text = "Total Amount"
        Total_Amount.Width = 150
        ' 
        ' Reciept_No
        ' 
        Reciept_No.Tag = "Reciept_No"
        Reciept_No.Text = "Reciept_No"
        Reciept_No.Width = 100
        ' 
        ' Backbtn
        ' 
        Backbtn.BackColor = Color.White
        Backbtn.FlatStyle = FlatStyle.Popup
        Backbtn.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Backbtn.Location = New Point(872, 412)
        Backbtn.Name = "Backbtn"
        Backbtn.Size = New Size(94, 31)
        Backbtn.TabIndex = 8
        Backbtn.Text = "BACK"
        Backbtn.UseVisualStyleBackColor = False
        ' 
        ' Generate_btn2
        ' 
        Generate_btn2.BackColor = Color.White
        Generate_btn2.FlatStyle = FlatStyle.Popup
        Generate_btn2.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Generate_btn2.Location = New Point(62, 110)
        Generate_btn2.Name = "Generate_btn2"
        Generate_btn2.Size = New Size(100, 31)
        Generate_btn2.TabIndex = 7
        Generate_btn2.Text = "GENERATE"
        Generate_btn2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(432, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 24)
        Label1.TabIndex = 10
        Label1.Text = "SALES"
        ' 
        ' TB10
        ' 
        TB10.Font = New Font("Times New Roman", 11.25F)
        TB10.Location = New Point(822, 116)
        TB10.Name = "TB10"
        TB10.Size = New Size(144, 25)
        TB10.TabIndex = 12
        TB10.WordWrap = False
        ' 
        ' Search_btn3
        ' 
        Search_btn3.BackColor = Color.White
        Search_btn3.FlatStyle = FlatStyle.Popup
        Search_btn3.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Search_btn3.Location = New Point(737, 116)
        Search_btn3.Name = "Search_btn3"
        Search_btn3.Size = New Size(79, 25)
        Search_btn3.TabIndex = 13
        Search_btn3.Text = "SEARCH"
        Search_btn3.UseVisualStyleBackColor = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(1024, 471)
        Controls.Add(Search_btn3)
        Controls.Add(TB10)
        Controls.Add(Label1)
        Controls.Add(LV3)
        Controls.Add(Backbtn)
        Controls.Add(Generate_btn2)
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LV3 As ListView
    Friend WithEvents Product_Code As ColumnHeader
    Friend WithEvents Product_Name As ColumnHeader
    Friend WithEvents Product_Price As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents Backbtn As Button
    Friend WithEvents Generate_btn2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Total_Amount As ColumnHeader
    Friend WithEvents Date_Purchased As ColumnHeader
    Friend WithEvents Reciept_No As ColumnHeader
    Friend WithEvents TB10 As TextBox
    Friend WithEvents Search_btn3 As Button
End Class
