<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VendorManagerDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_empID = New System.Windows.Forms.TextBox()
        Me.txt_dept = New System.Windows.Forms.TextBox()
        Me.txt_desig = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_add_order = New System.Windows.Forms.Button()
        Me.DataGrid_Book_to_print = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView_orders = New System.Windows.Forms.DataGridView()
        Me.btn_update_order = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bndg_Src_Book = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bndg_Src_Orders = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid_Book_to_print, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bndg_Src_Book, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bndg_Src_Orders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_empID)
        Me.GroupBox1.Controls.Add(Me.txt_dept)
        Me.GroupBox1.Controls.Add(Me.txt_desig)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 137)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'txt_empID
        '
        Me.txt_empID.Location = New System.Drawing.Point(85, 104)
        Me.txt_empID.Name = "txt_empID"
        Me.txt_empID.Size = New System.Drawing.Size(100, 20)
        Me.txt_empID.TabIndex = 7
        '
        'txt_dept
        '
        Me.txt_dept.Location = New System.Drawing.Point(85, 71)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.Size = New System.Drawing.Size(100, 20)
        Me.txt_dept.TabIndex = 6
        '
        'txt_desig
        '
        Me.txt_desig.Location = New System.Drawing.Point(85, 43)
        Me.txt_desig.Name = "txt_desig"
        Me.txt_desig.Size = New System.Drawing.Size(100, 20)
        Me.txt_desig.TabIndex = 5
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(85, 16)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "EMP ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Deapartment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Designation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Btn_add_order
        '
        Me.Btn_add_order.Location = New System.Drawing.Point(38, 382)
        Me.Btn_add_order.Name = "Btn_add_order"
        Me.Btn_add_order.Size = New System.Drawing.Size(104, 23)
        Me.Btn_add_order.TabIndex = 7
        Me.Btn_add_order.Text = "Add Printing Order"
        Me.Btn_add_order.UseVisualStyleBackColor = True
        '
        'DataGrid_Book_to_print
        '
        Me.DataGrid_Book_to_print.AllowUserToAddRows = False
        Me.DataGrid_Book_to_print.AllowUserToDeleteRows = False
        Me.DataGrid_Book_to_print.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Book_to_print.Location = New System.Drawing.Point(28, 197)
        Me.DataGrid_Book_to_print.Name = "DataGrid_Book_to_print"
        Me.DataGrid_Book_to_print.ReadOnly = True
        Me.DataGrid_Book_to_print.Size = New System.Drawing.Size(530, 169)
        Me.DataGrid_Book_to_print.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(483, 606)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView_orders
        '
        Me.DataGridView_orders.AllowUserToAddRows = False
        Me.DataGridView_orders.AllowUserToDeleteRows = False
        Me.DataGridView_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_orders.Location = New System.Drawing.Point(28, 422)
        Me.DataGridView_orders.Name = "DataGridView_orders"
        Me.DataGridView_orders.ReadOnly = True
        Me.DataGridView_orders.Size = New System.Drawing.Size(530, 159)
        Me.DataGridView_orders.TabIndex = 10
        '
        'btn_update_order
        '
        Me.btn_update_order.Location = New System.Drawing.Point(38, 597)
        Me.btn_update_order.Name = "btn_update_order"
        Me.btn_update_order.Size = New System.Drawing.Size(104, 23)
        Me.btn_update_order.TabIndex = 11
        Me.btn_update_order.Text = "Update Order"
        Me.btn_update_order.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(441, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "View Vendors"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VendorManagerDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 662)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_update_order)
        Me.Controls.Add(Me.DataGridView_orders)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_add_order)
        Me.Controls.Add(Me.DataGrid_Book_to_print)
        Me.Controls.Add(Me.Button3)
        Me.Name = "VendorManagerDashboard"
        Me.Text = "VendorManagerDashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid_Book_to_print, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_orders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bndg_Src_Book, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bndg_Src_Orders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_empID As TextBox
    Friend WithEvents txt_dept As TextBox
    Friend WithEvents txt_desig As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_add_order As Button
    Friend WithEvents DataGrid_Book_to_print As DataGridView
    Friend WithEvents Bndg_Src_Book As BindingSource
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView_orders As DataGridView
    Friend WithEvents Bndg_Src_Orders As BindingSource
    Friend WithEvents btn_update_order As Button
    Friend WithEvents Button1 As Button
End Class
