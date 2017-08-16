<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_book_edit
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
        Me.Lbl_name = New System.Windows.Forms.Label()
        Me.Lbl_status = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.dtp_modified = New System.Windows.Forms.DateTimePicker()
        Me.dtp_end = New System.Windows.Forms.DateTimePicker()
        Me.dtp_start = New System.Windows.Forms.DateTimePicker()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_Status = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.Location = New System.Drawing.Point(19, 38)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_name.TabIndex = 0
        Me.Lbl_name.Text = "Book name: "
        '
        'Lbl_status
        '
        Me.Lbl_status.AutoSize = True
        Me.Lbl_status.Location = New System.Drawing.Point(19, 76)
        Me.Lbl_status.Name = "Lbl_status"
        Me.Lbl_status.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_status.TabIndex = 1
        Me.Lbl_status.Text = "Status:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Status)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_status)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.dtp_modified)
        Me.GroupBox1.Controls.Add(Me.dtp_end)
        Me.GroupBox1.Controls.Add(Me.dtp_start)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Lbl_name)
        Me.GroupBox1.Controls.Add(Me.Lbl_status)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 327)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Details"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(121, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(333, 76)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(200, 20)
        Me.txt_status.TabIndex = 11
        Me.txt_status.Visible = False
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(22, 264)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 10
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'dtp_modified
        '
        Me.dtp_modified.Enabled = False
        Me.dtp_modified.Location = New System.Drawing.Point(121, 210)
        Me.dtp_modified.Name = "dtp_modified"
        Me.dtp_modified.Size = New System.Drawing.Size(200, 20)
        Me.dtp_modified.TabIndex = 9
        '
        'dtp_end
        '
        Me.dtp_end.Enabled = False
        Me.dtp_end.Location = New System.Drawing.Point(121, 169)
        Me.dtp_end.Name = "dtp_end"
        Me.dtp_end.Size = New System.Drawing.Size(200, 20)
        Me.dtp_end.TabIndex = 8
        Me.dtp_end.Value = New Date(2016, 10, 25, 0, 0, 0, 0)
        '
        'dtp_start
        '
        Me.dtp_start.Enabled = False
        Me.dtp_start.Location = New System.Drawing.Point(121, 111)
        Me.dtp_start.Name = "dtp_start"
        Me.dtp_start.Size = New System.Drawing.Size(200, 20)
        Me.dtp_start.TabIndex = 7
        '
        'txt_name
        '
        Me.txt_name.Enabled = False
        Me.txt_name.Location = New System.Drawing.Point(121, 38)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(200, 20)
        Me.txt_name.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last modified date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "End Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Start Date:"
        '
        'ComboBox_Status
        '
        Me.ComboBox_Status.FormattingEnabled = True
        Me.ComboBox_Status.Location = New System.Drawing.Point(121, 76)
        Me.ComboBox_Status.Name = "ComboBox_Status"
        Me.ComboBox_Status.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox_Status.TabIndex = 13
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(22, 145)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(106, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Update end date"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frm_book_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 351)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_book_edit"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbl_name As Label
    Friend WithEvents Lbl_status As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtp_start As DateTimePicker
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_modified As DateTimePicker
    Friend WithEvents dtp_end As DateTimePicker
    Friend WithEvents btn_save As Button
    Friend WithEvents txt_status As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox_Status As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
