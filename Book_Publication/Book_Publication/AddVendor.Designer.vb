<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddVendor
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
        Me.txt_addr2 = New System.Windows.Forms.TextBox()
        Me.txt_addr1 = New System.Windows.Forms.TextBox()
        Me.txt_vendor_name = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.txt_zip = New System.Windows.Forms.TextBox()
        Me.txt_country = New System.Windows.Forms.TextBox()
        Me.txt_state = New System.Windows.Forms.TextBox()
        Me.txt_city = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_addr2
        '
        Me.txt_addr2.Location = New System.Drawing.Point(222, 107)
        Me.txt_addr2.Name = "txt_addr2"
        Me.txt_addr2.Size = New System.Drawing.Size(286, 20)
        Me.txt_addr2.TabIndex = 13
        '
        'txt_addr1
        '
        Me.txt_addr1.Location = New System.Drawing.Point(222, 76)
        Me.txt_addr1.Name = "txt_addr1"
        Me.txt_addr1.Size = New System.Drawing.Size(286, 20)
        Me.txt_addr1.TabIndex = 12
        '
        'txt_vendor_name
        '
        Me.txt_vendor_name.Location = New System.Drawing.Point(222, 44)
        Me.txt_vendor_name.Name = "txt_vendor_name"
        Me.txt_vendor_name.Size = New System.Drawing.Size(286, 20)
        Me.txt_vendor_name.TabIndex = 11
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(168, 388)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(113, 23)
        Me.btn_cancel.TabIndex = 5
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(44, 388)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(75, 23)
        Me.btn_submit.TabIndex = 4
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(222, 294)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(286, 20)
        Me.txt_email.TabIndex = 19
        '
        'txt_phone
        '
        Me.txt_phone.Location = New System.Drawing.Point(222, 264)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(286, 20)
        Me.txt_phone.TabIndex = 18
        '
        'txt_zip
        '
        Me.txt_zip.Location = New System.Drawing.Point(222, 233)
        Me.txt_zip.Name = "txt_zip"
        Me.txt_zip.Size = New System.Drawing.Size(286, 20)
        Me.txt_zip.TabIndex = 17
        '
        'txt_country
        '
        Me.txt_country.Location = New System.Drawing.Point(222, 203)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(286, 20)
        Me.txt_country.TabIndex = 16
        '
        'txt_state
        '
        Me.txt_state.Location = New System.Drawing.Point(222, 171)
        Me.txt_state.Name = "txt_state"
        Me.txt_state.Size = New System.Drawing.Size(286, 20)
        Me.txt_state.TabIndex = 15
        '
        'txt_city
        '
        Me.txt_city.Location = New System.Drawing.Point(222, 139)
        Me.txt_city.Name = "txt_city"
        Me.txt_city.Size = New System.Drawing.Size(286, 20)
        Me.txt_city.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(72, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Contact Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Zip code"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(72, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Country"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "State"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "City"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address line 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address line 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vendor Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.txt_phone)
        Me.GroupBox1.Controls.Add(Me.txt_zip)
        Me.GroupBox1.Controls.Add(Me.txt_country)
        Me.GroupBox1.Controls.Add(Me.txt_state)
        Me.GroupBox1.Controls.Add(Me.txt_city)
        Me.GroupBox1.Controls.Add(Me.txt_addr2)
        Me.GroupBox1.Controls.Add(Me.txt_addr1)
        Me.GroupBox1.Controls.Add(Me.txt_vendor_name)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 345)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Details"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(72, 302)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Email "
        '
        'AddVendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 431)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AddVendor"
        Me.Text = "AddVendor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_addr2 As TextBox
    Friend WithEvents txt_addr1 As TextBox
    Friend WithEvents txt_vendor_name As TextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_submit As Button
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents txt_zip As TextBox
    Friend WithEvents txt_country As TextBox
    Friend WithEvents txt_state As TextBox
    Friend WithEvents txt_city As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
End Class
