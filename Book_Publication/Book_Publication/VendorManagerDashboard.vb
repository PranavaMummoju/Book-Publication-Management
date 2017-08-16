Imports MySql.Data.MySqlClient

Public Class VendorManagerDashboard
    Private Sub VendorManagerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection()
            'cmd = New MySqlCommand("Select * from Employee_PersonalDetails epd inner join Employee_OrganizationalDetails eod on epd.emp_id = eod.emp_id inner join Department d on eod.dept_id = d.dept_id   where epd.emp_id=" & emp_id, cn)
            FetchEmployeeDetails()
            cn.Open()

            'dr2 = cmd.ExecuteNonQuery()
            cmd.ExecuteNonQuery()
            'If dr2.HasRows = True Then

            'While dr2.Read
            txt_name.Text = cmd.Parameters("@fname").Value.ToString() + " " + cmd.Parameters("@lname").Value.ToString()
            txt_desig.Text = cmd.Parameters("@desig").Value.ToString()
            txt_empID.Text = emp_id.ToString()
            txt_dept.Text = cmd.Parameters("@dept").Value.ToString()

            'End While
            'End If
            'dr2.Close()

            cn.Close()

            Dim dt As DataTable
            dt = New DataTable()
            cn.Open()
            Dim qrstr As String

            qrstr = "Select * from Book where status='Ready to Print'"

            cmd2 = New MySqlCommand(qrstr, cn)
            dr2 = cmd2.ExecuteReader
            'While dr.Read
            dt.Load(dr2)
            'End While

            Bndg_Src_Book.DataSource = dt

            DataGrid_Book_to_print.DataSource = Bndg_Src_Book

            dr2.Close()
            cn.Close()

            Dim dt1 As DataTable
            dt1 = New DataTable()
            cn.Open()


            qrstr = "Select * from PrintingOrder"

            cmd2 = New MySqlCommand(qrstr, cn)
            dr2 = cmd2.ExecuteReader
            'While dr.Read
            dt1.Load(dr2)
            'End While

            Bndg_Src_Orders.DataSource = dt1

            DataGridView_orders.DataSource = Bndg_Src_Orders

            dr2.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox("Failed to connect" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Btn_add_order_Click(sender As Object, e As EventArgs) Handles Btn_add_order.Click
        Dim Form2 As New AddPrintingOrder()
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub DataGrid_Book_to_print_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_Book_to_print.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGrid_Book_to_print.Rows(index)
            'toPrint = New ArrayList(20)
            book_id = Convert.ToInt16(selectedRow.Cells(0).Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView_orders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_orders.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView_orders.Rows(index)
            OrderstoPrint = New ArrayList(20)
            order_id = Convert.ToInt16(selectedRow.Cells(0).Value)
            OrderstoPrint.Add(selectedRow.Cells(1).Value)
            OrderstoPrint.Add(selectedRow.Cells(2).Value)
            OrderstoPrint.Add(selectedRow.Cells(3).Value)
            OrderstoPrint.Add(selectedRow.Cells(4).Value)
            OrderstoPrint.Add(selectedRow.Cells(5).Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_update_order_Click(sender As Object, e As EventArgs) Handles btn_update_order.Click
        Dim Form2 As New UpdateOrder()
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form2 As New ShowVendors()
        Form2.Show()
        Me.Close()
    End Sub
End Class