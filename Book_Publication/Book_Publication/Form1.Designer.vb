<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_userid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_login)
        Me.Panel1.Controls.Add(Me.txt_password)
        Me.Panel1.Controls.Add(Me.txt_userid)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(38, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 165)
        Me.Panel1.TabIndex = 1
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(87, 128)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 23)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(87, 82)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(100, 20)
        Me.txt_password.TabIndex = 3
        '
        'txt_userid
        '
        Me.txt_userid.Location = New System.Drawing.Point(87, 35)
        Me.txt_userid.Name = "txt_userid"
        Me.txt_userid.Size = New System.Drawing.Size(100, 20)
        Me.txt_userid.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(183, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 231)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 467)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_login As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_userid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
