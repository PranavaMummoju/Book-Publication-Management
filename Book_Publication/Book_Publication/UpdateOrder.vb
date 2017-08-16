Imports MySql.Data.MySqlClient

Public Class UpdateOrder
    Private Sub UpdateOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_vendorID.Text = OrderstoPrint.Item(0)
        txt_BookID.Text = OrderstoPrint.Item(1)
        dtp_order_date.Value = OrderstoPrint.Item(2)
        num_pick_quantity.Value = OrderstoPrint.Item(3)
        Cmbx_status.Text = OrderstoPrint.Item(4)

    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            connection()
            Dim updateStatement As String
            updateStatement = "Update PrintingOrder set vendor_id =" & Convert.ToInt16(txt_vendorID.Text) & ",book_id =" & Convert.ToInt16(txt_BookID.Text) & ",order_date = '" & GetDateString(dtp_order_date.Value) & "',quantity=" & Convert.ToInt16(num_pick_quantity.Value) & ",order_status ='" & Cmbx_status.Text & "' where order_id=" & order_id & ";"
            cn.Open()
            cmd = New MySqlCommand(updateStatement, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Order updated successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Dim Form2 As New VendorManagerDashboard()
            Form2.Show()
            Me.Close()
        End Try
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Dim Form2 As New VendorManagerDashboard()
        Form2.Show()
        Me.Close()
    End Sub
End Class