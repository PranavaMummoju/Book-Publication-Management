Imports MySql.Data.MySqlClient

Public Class ComtractManagerInsertAuthor
    Private Sub ComtractManagerInsertAuthor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            btn_cancel.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Try
            'btn_contract.Enabled = False
            connection()
            Dim insertStatement As String
            insertStatement = "Insert into Author_PersonalDetails(first_name,last_name,addr_line_1,addr_line_2,city,state,country,zip_code,email_id,phone) values('" & txt_fname.Text & "','" & txt_lname.Text & "','" & txt_addr1.Text & "','" & txt_addr2.Text & "','" & txt_city.Text & "','" & txt_state.Text & "','" & txt_country.Text & "','" & txt_zip.Text & "','" & txt_email.Text & "','" & txt_phone.Text & "');"
            cn.Open()
            cmd = New MySqlCommand(insertStatement, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Author added successfully!")
            btn_cancel.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Dim Form2 As New ContractManagerDashboard()
            Form2.Show()
            Me.Close()
        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Dim Form2 As New ContractManagerDashboard()
        Form2.Show()
        Me.Close()
    End Sub
End Class