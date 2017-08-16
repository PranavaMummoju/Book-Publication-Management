Imports MySql.Data.MySqlClient
Public Class AuthorUpdate
    Private Sub AuthorUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txt_fname.Text = selectedItemsAuthor.Item(0)
            txt_lname.Text = selectedItemsAuthor.Item(1)
            txt_addr1.Text = selectedItemsAuthor.Item(2)
            txt_addr2.Text = selectedItemsAuthor.Item(3)
            txt_city.Text = selectedItemsAuthor.Item(4)
            txt_state.Text = selectedItemsAuthor.Item(5)
            txt_country.Text = selectedItemsAuthor.Item(6)
            txt_zip.Text = selectedItemsAuthor.Item(7)
            txt_email.Text = selectedItemsAuthor.Item(8)
            txt_phone.Text = selectedItemsAuthor.Item(9)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Try
            connection()
            Dim query As String

            query = "UPDATE `author_personaldetails` SET `first_name`='" & txt_fname.Text & "',`last_name`='" & txt_lname.Text & "',`addr_line_1`='" & txt_addr1.Text & "',`addr_line_2`='" & txt_addr2.Text & "',`city`='" & txt_city.Text & "',`state`= '" & txt_state.Text & "',`country`= '" & txt_country.Text & "',`zip_code`= '" & txt_zip.Text & "',`email_id`= '" & txt_email.Text & "',`phone`= '" & txt_phone.Text & "' WHERE author_id=" & author_id & ";"

            cmd = New MySqlCommand(query, cn)
            cn.Open()

            cmd.ExecuteNonQuery()

            MsgBox("Author updated successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Dim Form2 As New ContractManagerDashboard()
            Form2.Show()
            Me.Close()

        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form2 As New ContractManagerDashboard()
        Form2.Show()
        Me.Close()
    End Sub

End Class