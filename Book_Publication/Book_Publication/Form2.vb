Imports MySql.Data.MySqlClient
Public Class frm_editor_dashboard


    Private Sub frm_editor_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'cn = New MySqlConnection("server=localhost; Uid=root; database=book_publication_system")
            connection()
            FetchEmployeeDetails()
            cn.Open()

            'dr2 = cmd.ExecuteNonQuery()
            cmd.ExecuteNonQuery()
            'If dr2.HasRows = True Then

            'While dr2.Read
            txt_name.Text = cmd.Parameters("@fname").Value.ToString() + " " + cmd.Parameters("@lname").Value.ToString()
            txt_designation.Text = cmd.Parameters("@desig").Value.ToString()
            txt_emp_id.Text = emp_id.ToString()
            txt_department.Text = cmd.Parameters("@dept").Value.ToString()

            cn.Close()

            Dim dt As DataTable
                dt = New DataTable()
            cn.Open()
            Dim qrstr As String

            qrstr = "Select * from Book b inner join Book_Editor be on b.book_id=be.book_id where be.editor_id=" & emp_id

            cmd2 = New MySqlCommand(qrstr, cn)
            dr2 = cmd2.ExecuteReader
            'While dr.Read
            dt.Load(dr2)
            'End While

            BindingSource1.DataSource = dt

            DataGridView1.DataSource = BindingSource1

            dr2.Close()
        Catch ex As Exception
            MsgBox("Failed to connect" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btn_update_book_Click(sender As Object, e As EventArgs) Handles btn_update_book.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim myForm3 As New frm_book_edit()
            myForm3.Show()
            Me.Close()
        Else
            MsgBox("Please select a row")

        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            selectedItems = New ArrayList(20)
            book_id = Convert.ToInt16(selectedRow.Cells(0).Value)
            selectedItems.Add(selectedRow.Cells(1).Value)
            selectedItems.Add(selectedRow.Cells(2).Value)
            selectedItems.Add(selectedRow.Cells(3).Value)
            selectedItems.Add(selectedRow.Cells(4).Value)
            selectedItems.Add(selectedRow.Cells(5).Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class