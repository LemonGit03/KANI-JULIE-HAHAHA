<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label1 = New Label()
        Generate_btn1 = New Button()
        Button1 = New Button()
        LV1 = New ListView()
        Product_Code = New ColumnHeader()
        Product_Name = New ColumnHeader()
        Product_Price = New ColumnHeader()
        Quantity = New ColumnHeader()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(279, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 24)
        Label1.TabIndex = 1
        Label1.Text = "PRODUCT INVENTORY"
        ' 
        ' Generate_btn1
        ' 
        Generate_btn1.BackColor = Color.White
        Generate_btn1.FlatStyle = FlatStyle.Popup
        Generate_btn1.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Generate_btn1.Location = New Point(58, 69)
        Generate_btn1.Name = "Generate_btn1"
        Generate_btn1.Size = New Size(100, 31)
        Generate_btn1.TabIndex = 3
        Generate_btn1.Text = "GENERATE"
        Generate_btn1.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(618, 371)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 31)
        Button1.TabIndex = 5
        Button1.Text = "BACK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' LV1
        ' 
        LV1.Columns.AddRange(New ColumnHeader() {Product_Code, Product_Name, Product_Price, Quantity})
        LV1.Font = New Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LV1.FullRowSelect = True
        LV1.Location = New Point(58, 106)
        LV1.Name = "LV1"
        LV1.Size = New Size(654, 259)
        LV1.TabIndex = 6
        LV1.UseCompatibleStateImageBehavior = False
        LV1.View = View.Details
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
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        CausesValidation = False
        ClientSize = New Size(772, 450)
        Controls.Add(LV1)
        Controls.Add(Button1)
        Controls.Add(Generate_btn1)
        Controls.Add(Label1)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PRODUCT INVENTORY"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Save_btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Generate_btn1 As Button
    Friend WithEvents LV1 As ListView
    Friend WithEvents Product_Code As ColumnHeader
    Friend WithEvents Product_Name As ColumnHeader
    Friend WithEvents Product_Price As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
End Class
