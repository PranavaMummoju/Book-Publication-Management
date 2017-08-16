Imports MySql.Data.MySqlClient
Public Class UpdateEmployee
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Try
            connection()
            Dim query As String

            query = "UPDATE `Employee_Personaldetails` SET `SSN`= " & txt_SSN.Text & ",`first_name`='" & txt_fname.Text & "',`last_name`='" & txt_lname.Text & "',`DOB`='" & GetDateString(dtp_dob.Value) & "',`addr_line_1`='" & txt_addr1.Text & "',`addr_line_2`='" & txt_addr2.Text & "',`city`='" & txt_city.Text & "',`state`= '" & txt_state.Text & "',`country`= '" & txt_country.Text & "',`zip_code`= '" & txt_zip.Text & "',`email_id`= '" & txt_email.Text & "',`phone`= '" & txt_phone.Text & "' WHERE emp_id=" & emp_id & ";"

            cmd = New MySqlCommand(query, cn)
            cn.Open()

            cmd.ExecuteNonQuery()
            cn.Close()

            query = "UPDATE Employee_OrganizationalDetails SET DOJ='" & GetDateString(dtp_doj.Value) & "',`dept_id`=" & Convert.ToInt16(txt_dept.Text) & ",`designation`='" & txt_desig.Text & "',`salary`=" & Convert.ToDouble(txt_salary.Text) & " WHERE emp_id=" & emp_id & ";"

            cmd = New MySqlCommand(query, cn)
            cn.Open()

            cmd.ExecuteNonQuery()

            MsgBox("Employee updated successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Dim Form2 As New HRdashboard()
            Form2.Show()
            Me.Close()

        End Try
    End Sub

    Private Sub UpdateEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txt_SSN.Text = selectedItemsEmployee.Item(0)
            txt_fname.Text = selectedItemsEmployee.Item(1)
            txt_lname.Text = selectedItemsEmployee.Item(2)
            dtp_dob.Value = selectedItemsEmployee.Item(3)
            txt_addr1.Text = selectedItemsEmployee.Item(4)
            If selectedItemsEmployee.Item(5) IsNot DBNull.Value Then
                txt_addr2.Text = selectedItemsEmployee.Item(5)
            End If
            txt_city.Text = selectedItemsEmployee.Item(6)
            txt_state.Text = selectedItemsEmployee.Item(7)
            txt_country.Text = selectedItemsEmployee.Item(8)
            txt_zip.Text = selectedItemsEmployee.Item(9)
            txt_email.Text = selectedItemsEmployee.Item(10)
            txt_phone.Text = selectedItemsEmployee.Item(11)
            dtp_doj.Value = selectedItemsEmployee.Item(12)
            txt_dept.Text = (selectedItemsEmployee.Item(13)).ToString()
            txt_desig.Text = selectedItemsEmployee.Item(14)
            txt_salary.Text = selectedItemsEmployee.Item(15).ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form2 As New HRdashboard()
        Form2.Show()
        Me.Close()
    End Sub
End Class