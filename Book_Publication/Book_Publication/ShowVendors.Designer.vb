<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowVendors
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
        Me.DataGridView_Vendors = New System.Windows.Forms.DataGridView()
        Me.btn_add_vendor = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Bndg_Src_Vendor = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView_Vendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bndg_Src_Vendor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_Vendors
        '
        Me.DataGridView_Vendors.AllowUserToAddRows = False
        Me.DataGridView_Vendors.AllowUserToDeleteRows = False
        Me.DataGridView_Vendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Vendors.Location = New System.Drawing.Point(37, 32)
        Me.DataGridView_Vendors.Name = "DataGridView_Vendors"
        Me.DataGridView_Vendors.ReadOnly = True
        Me.DataGridView_Vendors.Size = New System.Drawing.Size(591, 181)
        Me.DataGridView_Vendors.TabIndex = 0
        '
        'btn_add_vendor
        '
        Me.btn_add_vendor.Location = New System.Drawing.Point(37, 243)
        Me.btn_add_vendor.Name = "btn_add_vendor"
        Me.btn_add_vendor.Size = New System.Drawing.Size(96, 23)
        Me.btn_add_vendor.TabIndex = 1
        Me.btn_add_vendor.Text = "Add new vendor"
        Me.btn_add_vendor.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(177, 243)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(91, 23)
        Me.btn_update.TabIndex = 2
        Me.btn_update.Text = "Update vendor"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(553, 242)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'ShowVendors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 299)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add_vendor)
        Me.Controls.Add(Me.DataGridView_Vendors)
        Me.Name = "ShowVendors"
        Me.Text = "ShowVendors"
        CType(Me.DataGridView_Vendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bndg_Src_Vendor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView_Vendors As DataGridView
    Friend WithEvents btn_add_vendor As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Bndg_Src_Vendor As BindingSource
End Class
