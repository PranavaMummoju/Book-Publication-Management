<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateOrder
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
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.Cmbx_status = New System.Windows.Forms.ComboBox()
        Me.dtp_order_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_BookID = New System.Windows.Forms.TextBox()
        Me.num_pick_quantity = New System.Windows.Forms.NumericUpDown()
        Me.txt_vendorID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.num_pick_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(242, 247)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 23
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Submit
        '
        Me.btn_Submit.Location = New System.Drawing.Point(38, 247)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Submit.TabIndex = 22
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'Cmbx_status
        '
        Me.Cmbx_status.FormattingEnabled = True
        Me.Cmbx_status.Location = New System.Drawing.Point(117, 191)
        Me.Cmbx_status.Name = "Cmbx_status"
        Me.Cmbx_status.Size = New System.Drawing.Size(200, 21)
        Me.Cmbx_status.TabIndex = 21
        '
        'dtp_order_date
        '
        Me.dtp_order_date.Location = New System.Drawing.Point(117, 112)
        Me.dtp_order_date.Name = "dtp_order_date"
        Me.dtp_order_date.Size = New System.Drawing.Size(200, 20)
        Me.dtp_order_date.TabIndex = 20
        '
        'txt_BookID
        '
        Me.txt_BookID.Location = New System.Drawing.Point(117, 73)
        Me.txt_BookID.Name = "txt_BookID"
        Me.txt_BookID.Size = New System.Drawing.Size(200, 20)
        Me.txt_BookID.TabIndex = 19
        '
        'num_pick_quantity
        '
        Me.num_pick_quantity.Location = New System.Drawing.Point(117, 152)
        Me.num_pick_quantity.Name = "num_pick_quantity"
        Me.num_pick_quantity.Size = New System.Drawing.Size(200, 20)
        Me.num_pick_quantity.TabIndex = 18
        '
        'txt_vendorID
        '
        Me.txt_vendorID.Location = New System.Drawing.Point(117, 32)
        Me.txt_vendorID.Name = "txt_vendorID"
        Me.txt_vendorID.Size = New System.Drawing.Size(200, 20)
        Me.txt_vendorID.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Order status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Order date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Book ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Vendor ID"
        '
        'UpdateOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 303)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.Cmbx_status)
        Me.Controls.Add(Me.dtp_order_date)
        Me.Controls.Add(Me.txt_BookID)
        Me.Controls.Add(Me.num_pick_quantity)
        Me.Controls.Add(Me.txt_vendorID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateOrder"
        Me.Text = "UpdateOrder"
        CType(Me.num_pick_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Submit As Button
    Friend WithEvents Cmbx_status As ComboBox
    Friend WithEvents dtp_order_date As DateTimePicker
    Friend WithEvents txt_BookID As TextBox
    Friend WithEvents num_pick_quantity As NumericUpDown
    Friend WithEvents txt_vendorID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
