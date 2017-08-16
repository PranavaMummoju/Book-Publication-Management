<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContractManagerDashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_desig = New System.Windows.Forms.TextBox()
        Me.txt_dept = New System.Windows.Forms.TextBox()
        Me.txt_empID = New System.Windows.Forms.TextBox()
        Me.DataGrid_Book = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGrid_Author = New System.Windows.Forms.DataGridView()
        Me.btn_inser_book = New System.Windows.Forms.Button()
        Me.btn_insert_author = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGrid_Contract = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_editor = New System.Windows.Forms.Button()
        Me.btn_link = New System.Windows.Forms.Button()
        Me.Bndg_Src_Book = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bndg_Src_Author = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bndg_Src_Contract = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid_Book, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid_Author, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid_Contract, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bndg_Src_Book, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bndg_Src_Author, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bndg_Src_Contract, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(196, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Designation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "EMP ID"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(76, 14)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 4
        '
        'txt_desig
        '
        Me.txt_desig.Location = New System.Drawing.Point(76, 40)
        Me.txt_desig.Name = "txt_desig"
        Me.txt_desig.Size = New System.Drawing.Size(100, 20)
        Me.txt_desig.TabIndex = 5
        '
        'txt_dept
        '
        Me.txt_dept.Location = New System.Drawing.Point(76, 65)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.Size = New System.Drawing.Size(100, 20)
        Me.txt_dept.TabIndex = 6
        '
        'txt_empID
        '
        Me.txt_empID.Location = New System.Drawing.Point(76, 91)
        Me.txt_empID.Name = "txt_empID"
        Me.txt_empID.Size = New System.Drawing.Size(100, 20)
        Me.txt_empID.TabIndex = 7
        '
        'DataGrid_Book
        '
        Me.DataGrid_Book.AllowUserToAddRows = False
        Me.DataGrid_Book.AllowUserToDeleteRows = False
        Me.DataGrid_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Book.Location = New System.Drawing.Point(12, 138)
        Me.DataGrid_Book.Name = "DataGrid_Book"
        Me.DataGrid_Book.ReadOnly = True
        Me.DataGrid_Book.Size = New System.Drawing.Size(583, 131)
        Me.DataGrid_Book.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(103, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Update Author"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGrid_Author
        '
        Me.DataGrid_Author.AllowUserToAddRows = False
        Me.DataGrid_Author.AllowUserToDeleteRows = False
        Me.DataGrid_Author.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Author.Location = New System.Drawing.Point(12, 313)
        Me.DataGrid_Author.Name = "DataGrid_Author"
        Me.DataGrid_Author.ReadOnly = True
        Me.DataGrid_Author.Size = New System.Drawing.Size(582, 130)
        Me.DataGrid_Author.TabIndex = 3
        '
        'btn_inser_book
        '
        Me.btn_inser_book.Location = New System.Drawing.Point(13, 275)
        Me.btn_inser_book.Name = "btn_inser_book"
        Me.btn_inser_book.Size = New System.Drawing.Size(75, 23)
        Me.btn_inser_book.TabIndex = 4
        Me.btn_inser_book.Text = "Insert Book"
        Me.btn_inser_book.UseVisualStyleBackColor = True
        '
        'btn_insert_author
        '
        Me.btn_insert_author.Location = New System.Drawing.Point(13, 449)
        Me.btn_insert_author.Name = "btn_insert_author"
        Me.btn_insert_author.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert_author.TabIndex = 5
        Me.btn_insert_author.Text = "Insert Author"
        Me.btn_insert_author.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 644)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Add Contract"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(94, 449)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Update Author"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGrid_Contract
        '
        Me.DataGrid_Contract.AllowUserToAddRows = False
        Me.DataGrid_Contract.AllowUserToDeleteRows = False
        Me.DataGrid_Contract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Contract.Location = New System.Drawing.Point(11, 487)
        Me.DataGrid_Contract.Name = "DataGrid_Contract"
        Me.DataGrid_Contract.ReadOnly = True
        Me.DataGrid_Contract.Size = New System.Drawing.Size(583, 142)
        Me.DataGrid_Contract.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(112, 644)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Update Contract"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btn_editor
        '
        Me.btn_editor.Location = New System.Drawing.Point(201, 275)
        Me.btn_editor.Name = "btn_editor"
        Me.btn_editor.Size = New System.Drawing.Size(96, 23)
        Me.btn_editor.TabIndex = 10
        Me.btn_editor.Text = "Assign to Editor"
        Me.btn_editor.UseVisualStyleBackColor = True
        '
        'btn_link
        '
        Me.btn_link.Location = New System.Drawing.Point(615, 268)
        Me.btn_link.Name = "btn_link"
        Me.btn_link.Size = New System.Drawing.Size(116, 36)
        Me.btn_link.TabIndex = 11
        Me.btn_link.Text = "Link Book to Author"
        Me.btn_link.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(634, 644)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ContractManagerDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 749)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btn_link)
        Me.Controls.Add(Me.btn_editor)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGrid_Contract)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_insert_author)
        Me.Controls.Add(Me.btn_inser_book)
        Me.Controls.Add(Me.DataGrid_Author)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGrid_Book)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ContractManagerDashboard"
        Me.Text = "ContractManagerDashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid_Book, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid_Author, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid_Contract, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bndg_Src_Book, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bndg_Src_Author, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bndg_Src_Contract, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_empID As TextBox
    Friend WithEvents txt_dept As TextBox
    Friend WithEvents txt_desig As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents DataGrid_Book As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGrid_Author As DataGridView
    Friend WithEvents Bndg_Src_Book As BindingSource
    Friend WithEvents Bndg_Src_Author As BindingSource
    Friend WithEvents btn_inser_book As Button
    Friend WithEvents btn_insert_author As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGrid_Contract As DataGridView
    Friend WithEvents Bndg_Src_Contract As BindingSource
    Friend WithEvents Button4 As Button
    Friend WithEvents btn_editor As Button
    Friend WithEvents btn_link As Button
    Friend WithEvents Button5 As Button
End Class
