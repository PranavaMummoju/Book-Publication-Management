Imports MySql.Data.MySqlClient

Public Class ShowVendors
    Private Sub ShowVendors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As DataTable
            dt = New DataTable()
            cn.Open()
            Dim qrstr As String

            qrstr = "Select * from PrintingVendor"

            cmd2 = New MySqlCommand(qrstr, cn)
            dr2 = cmd2.ExecuteReader
            'While dr.Read
            dt.Load(dr2)
            'End While

            Bndg_Src_Vendor.DataSource = dt

            DataGridView_Vendors.DataSource = Bndg_Src_Vendor

            dr2.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView_Vendors_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Vendors.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView_Vendors.Rows(index)
            selectedItemsVendor = New ArrayList(20)
            vendor_id = Convert.ToInt16(selectedRow.Cells(0).Value)
            selectedItemsVendor.Add(selectedRow.Cells(1).Value)
            selectedItemsVendor.Add(selectedRow.Cells(2).Value)
            selectedItemsVendor.Add(selectedRow.Cells(3).Value)
            selectedItemsVendor.Add(selectedRow.Cells(4).Value)
            selectedItemsVendor.Add(selectedRow.Cells(5).Value)
            selectedItemsVendor.Add(selectedRow.Cells(6).Value)
            selectedItemsVendor.Add(selectedRow.Cells(7).Value)
            selectedItemsVendor.Add(selectedRow.Cells(8).Value)
            selectedItemsVendor.Add(selectedRow.Cells(9).Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_add_vendor_Click(sender As Object, e As EventArgs) Handles btn_add_vendor.Click
        Dim Form2 As New AddVendor()
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Dim Form2 As New VendorManagerDashboard()
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim Form2 As New UpdateVendor()
        Form2.Show()
        Me.Close()
    End Sub
End Class