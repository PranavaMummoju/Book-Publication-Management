<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContractManagerAddContract
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_authorID = New System.Windows.Forms.TextBox()
        Me.txt_EmployeeID = New System.Windows.Forms.TextBox()
        Me.dtp_start = New System.Windows.Forms.DateTimePicker()
        Me.dtp_end = New System.Windows.Forms.DateTimePicker()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Author ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Start Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "End Date"
        '
        'txt_authorID
        '
        Me.txt_authorID.Location = New System.Drawing.Point(165, 66)
        Me.txt_authorID.Name = "txt_authorID"
        Me.txt_authorID.Size = New System.Drawing.Size(200, 20)
        Me.txt_authorID.TabIndex = 4
        '
        'txt_EmployeeID
        '
        Me.txt_EmployeeID.Location = New System.Drawing.Point(165, 100)
        Me.txt_EmployeeID.Name = "txt_EmployeeID"
        Me.txt_EmployeeID.Size = New System.Drawing.Size(200, 20)
        Me.txt_EmployeeID.TabIndex = 5
        '
        'dtp_start
        '
        Me.dtp_start.Location = New System.Drawing.Point(165, 136)
        Me.dtp_start.Name = "dtp_start"
        Me.dtp_start.Size = New System.Drawing.Size(200, 20)
        Me.dtp_start.TabIndex = 6
        '
        'dtp_end
        '
        Me.dtp_end.Location = New System.Drawing.Point(165, 172)
        Me.dtp_end.Name = "dtp_end"
        Me.dtp_end.Size = New System.Drawing.Size(200, 20)
        Me.dtp_end.TabIndex = 7
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(49, 223)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(75, 23)
        Me.btn_submit.TabIndex = 8
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(286, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContractManagerAddContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 268)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.dtp_end)
        Me.Controls.Add(Me.dtp_start)
        Me.Controls.Add(Me.txt_EmployeeID)
        Me.Controls.Add(Me.txt_authorID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ContractManagerAddContract"
        Me.Text = "ContractManagerAddContract"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_authorID As TextBox
    Friend WithEvents txt_EmployeeID As TextBox
    Friend WithEvents dtp_start As DateTimePicker
    Friend WithEvents dtp_end As DateTimePicker
    Friend WithEvents btn_submit As Button
    Friend WithEvents Button1 As Button
End Class
