<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRdashboard
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
        Me.DataGrid_Employee = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bndg_Src_Employee = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid_Employee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bndg_Src_Employee, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(22, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 137)
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
        Me.Label2.Location = New System.Drawing.Point(7, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Designation"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "EMP ID"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(85, 16)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 4
        '
        'txt_desig
        '
        Me.txt_desig.Location = New System.Drawing.Point(85, 43)
        Me.txt_desig.Name = "txt_desig"
        Me.txt_desig.Size = New System.Drawing.Size(100, 20)
        Me.txt_desig.TabIndex = 5
        '
        'txt_dept
        '
        Me.txt_dept.Location = New System.Drawing.Point(85, 71)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.Size = New System.Drawing.Size(100, 20)
        Me.txt_dept.TabIndex = 6
        '
        'txt_empID
        '
        Me.txt_empID.Location = New System.Drawing.Point(85, 104)
        Me.txt_empID.Name = "txt_empID"
        Me.txt_empID.Size = New System.Drawing.Size(100, 20)
        Me.txt_empID.TabIndex = 7
        '
        'DataGrid_Employee
        '
        Me.DataGrid_Employee.AllowUserToAddRows = False
        Me.DataGrid_Employee.AllowUserToDeleteRows = False
        Me.DataGrid_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Employee.Location = New System.Drawing.Point(22, 183)
        Me.DataGrid_Employee.Name = "DataGrid_Employee"
        Me.DataGrid_Employee.ReadOnly = True
        Me.DataGrid_Employee.Size = New System.Drawing.Size(530, 169)
        Me.DataGrid_Employee.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add Employee"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(192, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Update employee"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(410, 368)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'HRdashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 434)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGrid_Employee)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "HRdashboard"
        Me.Text = "HRdashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid_Employee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bndg_Src_Employee, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGrid_Employee As DataGridView
    Friend WithEvents Bndg_Src_Employee As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
