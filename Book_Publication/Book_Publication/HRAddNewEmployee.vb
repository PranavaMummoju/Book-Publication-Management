Imports MySql.Data.MySqlClient
Public Class HRAddNewEmployee
    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles txt_addr2.TextChanged

    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Try
            'btn_contract.Enabled = False
            connection()
            Dim insertStatement1 As String
            Dim query2 As String = "Select LAST_INSERT_ID()"
            Dim insertStatement2 As String
            insertStatement1 = "Insert into Employee_PersonalDetails(SSN,first_name,last_name,DOB,addr_line_1,addr_line_2,city,state,country,zip_code,email_id,phone)
                values('" & txt_SSN.Text & "','" & txt_fname.Text & "','" & txt_lname.Text & "','" & GetDateString(dtp_dob.Value) & "','" & txt_addr1.Text & "','" & txt_addr2.Text & "','" & txt_city.Text & "','" & txt_state.Text & "','" & txt_country.Text & "','" & txt_zip.Text & "','" & txt_email.Text & "','" & txt_phone.Text & "');"
            cn.Open()
            cmd = New MySqlCommand(insertStatement1, cn)
            cmd.ExecuteNonQuery()
            cmd.CommandText = query2
            emp_id = cmd.ExecuteScalar()
            cn.Close()

            insertStatement2 = "Insert into Employee_OrganizationalDetails(emp_id,DOJ,dept_id,designation,salary) values(" & emp_id & ",'" & GetDateString(dtp_doj.Value) & "','" & Convert.ToInt16(txt_dept.Text) & "','" & txt_desig.Text & "','" & Convert.ToDouble(txt_salary.Text) & "');"
            cn.Open()
            cmd = New MySqlCommand(insertStatement2, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Employee added successfully!")
            'btn_contract.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Dim Form2 As New HRdashboard()
            Form2.Show()
            Me.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form2 As New HRdashboard()
        Form2.Show()
        Me.Close()
    End Sub
End Class