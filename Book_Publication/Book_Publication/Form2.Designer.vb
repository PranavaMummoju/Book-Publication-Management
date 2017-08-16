<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editor_dashboard
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
        Me.txt_emp_id = New System.Windows.Forms.TextBox()
        Me.txt_department = New System.Windows.Forms.TextBox()
        Me.txt_designation = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_update_book = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_emp_id)
        Me.GroupBox1.Controls.Add(Me.txt_department)
        Me.GroupBox1.Controls.Add(Me.txt_designation)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 126)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txt_emp_id
        '
        Me.txt_emp_id.Location = New System.Drawing.Point(87, 101)
        Me.txt_emp_id.Name = "txt_emp_id"
        Me.txt_emp_id.ReadOnly = True
        Me.txt_emp_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_emp_id.TabIndex = 7
        '
        'txt_department
        '
        Me.txt_department.Location = New System.Drawing.Point(87, 74)
        Me.txt_department.Name = "txt_department"
        Me.txt_department.ReadOnly = True
        Me.txt_department.Size = New System.Drawing.Size(100, 20)
        Me.txt_department.TabIndex = 6
        '
        'txt_designation
        '
        Me.txt_designation.Location = New System.Drawing.Point(87, 47)
        Me.txt_designation.Name = "txt_designation"
        Me.txt_designation.ReadOnly = True
        Me.txt_designation.Size = New System.Drawing.Size(100, 20)
        Me.txt_designation.TabIndex = 5
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(87, 20)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "EMP ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Department"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Designation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 168)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(644, 218)
        Me.DataGridView1.TabIndex = 1
        '
        'btn_update_book
        '
        Me.btn_update_book.Location = New System.Drawing.Point(566, 448)
        Me.btn_update_book.Name = "btn_update_book"
        Me.btn_update_book.Size = New System.Drawing.Size(75, 23)
        Me.btn_update_book.TabIndex = 2
        Me.btn_update_book.Text = "Update Book"
        Me.btn_update_book.UseVisualStyleBackColor = True
        '
        'frm_editor_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 509)
        Me.Controls.Add(Me.btn_update_book)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_editor_dashboard"
        Me.Text = "Dashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_emp_id As TextBox
    Friend WithEvents txt_department As TextBox
    Friend WithEvents txt_designation As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_update_book As Button
    Friend WithEvents BindingSource1 As BindingSource
End Class
