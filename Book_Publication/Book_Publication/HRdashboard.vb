Imports MySql.Data.MySqlClient

Public Class HRdashboard
    Private Sub HRdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            qrstr = "Select * from Employee_PersonalDetails ep inner join Employee_OrganizationalDetails eo on ep.emp_id=eo.emp_id"

            cmd2 = New MySqlCommand(qrstr, cn)
            dr2 = cmd2.ExecuteReader
            'While dr.Read
            dt.Load(dr2)
            'End While

            Bndg_Src_Employee.DataSource = dt

            DataGrid_Employee.DataSource = Bndg_Src_Employee

            dr2.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox("Failed to connect" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myForm3 As New HRAddNewEmployee()
        myForm3.Show()
        Me.Close()
    End Sub

    Private Sub DataGrid_Employee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_Employee.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGrid_Employee.Rows(index)
            selectedItemsEmployee = New ArrayList(20)
            emp_id = Convert.ToInt16(selectedRow.Cells(0).Value)
            selectedItemsEmployee.Add(selectedRow.Cells(1).Value)
            selectedItemsEmployee.Add(selectedRow.Cells(2).Value)
            selectedItemsEmployee.Add(selectedRow.Cells(3).Value)
            selectedItemsEmployee.Add(selectedRow.Cells(4).Value)
            selectedItemsEmployee.Add(selectedRow.Cells(5).Value)
            selectedItemsEmployee.Add(selectedRow.Cells(6).Value)
            selectedItemsEmployee.Add(selectedRow.Cells(7).Value)
            selectedItemsEmployee.Add(selectedRow.Cells(8).Value)
            selectedItemsEmployee.Add(selectedRow.Cells(9).Value)
            selectedItemsEmployee.Add(selectedRow.Cells(10).Value)
            selectedItemsEmployee.Add(selectedRow.Cells(11).Value)
            selectedItemsEmployee.Add(selectedRow.Cells(12).Value)
            selectedItemsEmployee.Add(selectedRow.Cells(14).Value)
            selectedItemsEmployee.Add(selectedRow.Cells(15).Value)
            selectedItemsEmployee.Add(selectedRow.Cells(16).Value)
            selectedItemsEmployee.Add(selectedRow.Cells(17).Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myForm3 As New UpdateEmployee()
        myForm3.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class