<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContractManagerInsertBook
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_book_name = New System.Windows.Forms.TextBox()
        Me.ComboBox_status = New System.Windows.Forms.ComboBox()
        Me.dtp_start = New System.Windows.Forms.DateTimePicker()
        Me.dtp_end = New System.Windows.Forms.DateTimePicker()
        Me.dtp_modified = New System.Windows.Forms.DateTimePicker()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Start Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "End Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Last Modified Date"
        '
        'txt_book_name
        '
        Me.txt_book_name.Location = New System.Drawing.Point(189, 64)
        Me.txt_book_name.Name = "txt_book_name"
        Me.txt_book_name.Size = New System.Drawing.Size(239, 20)
        Me.txt_book_name.TabIndex = 5
        '
        'ComboBox_status
        '
        Me.ComboBox_status.FormattingEnabled = True
        Me.ComboBox_status.Location = New System.Drawing.Point(189, 106)
        Me.ComboBox_status.Name = "ComboBox_status"
        Me.ComboBox_status.Size = New System.Drawing.Size(239, 21)
        Me.ComboBox_status.TabIndex = 6
        '
        'dtp_start
        '
        Me.dtp_start.Location = New System.Drawing.Point(189, 158)
        Me.dtp_start.Name = "dtp_start"
        Me.dtp_start.Size = New System.Drawing.Size(239, 20)
        Me.dtp_start.TabIndex = 7
        '
        'dtp_end
        '
        Me.dtp_end.Location = New System.Drawing.Point(189, 214)
        Me.dtp_end.Name = "dtp_end"
        Me.dtp_end.Size = New System.Drawing.Size(239, 20)
        Me.dtp_end.TabIndex = 8
        '
        'dtp_modified
        '
        Me.dtp_modified.Location = New System.Drawing.Point(189, 266)
        Me.dtp_modified.Name = "dtp_modified"
        Me.dtp_modified.Size = New System.Drawing.Size(239, 20)
        Me.dtp_modified.TabIndex = 9
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(62, 323)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(128, 23)
        Me.btn_submit.TabIndex = 10
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(331, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContractManagerInsertBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 374)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.dtp_modified)
        Me.Controls.Add(Me.dtp_end)
        Me.Controls.Add(Me.dtp_start)
        Me.Controls.Add(Me.ComboBox_status)
        Me.Controls.Add(Me.txt_book_name)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ContractManagerInsertBook"
        Me.Text = "ContractManagerInsertBook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_book_name As TextBox
    Friend WithEvents ComboBox_status As ComboBox
    Friend WithEvents dtp_start As DateTimePicker
    Friend WithEvents dtp_end As DateTimePicker
    Friend WithEvents dtp_modified As DateTimePicker
    Friend WithEvents btn_submit As Button
    Friend WithEvents Button1 As Button
End Class
