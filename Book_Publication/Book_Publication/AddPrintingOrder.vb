Imports MySql.Data.MySqlClient

Public Class AddPrintingOrder
    Private Sub AddPrintingOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateComboBox()
        txt_BookID.Text = book_id

    End Sub
    Private Sub UpdateComboBox()
        Cmbx_status.Items.Add("In Progress")
        Cmbx_status.Items.Add("Printed")
    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            connection()
            Dim insertStatement As String
            insertStatement = "Insert into PrintingOrder(vendor_id,book_id,order_date,quantity,order_status) values(" & Convert.ToInt16(txt_vendorID.Text) & "," & Convert.ToInt16(txt_BookID.Text) & ",'" & GetDateString(dtp_order_date.Value) & "'," & Convert.ToInt16(num_pick_quantity.Value) & ",'" & Cmbx_status.Text & "');"
            cn.Open()
            cmd = New MySqlCommand(insertStatement, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Order added successfully!")
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