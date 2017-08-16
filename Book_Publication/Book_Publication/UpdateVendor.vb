Imports MySql.Data.MySqlClient

Public Class UpdateVendor
    Private Sub UpdateVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            txt_lname.Text = selectedItemsVendor.Item(0)
            txt_addr1.Text = selectedItemsVendor.Item(1)
            txt_addr2.Text = selectedItemsVendor.Item(2)
            txt_city.Text = selectedItemsVendor.Item(3)
            txt_state.Text = selectedItemsVendor.Item(4)
            txt_country.Text = selectedItemsVendor.Item(5)
            txt_zip.Text = selectedItemsVendor.Item(6)
            txt_email.Text = selectedItemsVendor.Item(7)
            txt_phone.Text = selectedItemsVendor.Item(8)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Try
            connection()
            Dim query As String

            query = "UPDATE `PrintingVendor` SET `vendor_name`='" & txt_lname.Text & "',`addr_line_1`='" & txt_addr1.Text & "',`addr_line_2`='" & txt_addr2.Text & "',`city`='" & txt_city.Text & "',`state`= '" & txt_state.Text & "',`country`= '" & txt_country.Text & "',`zip_code`= '" & txt_zip.Text & "',`email`= '" & txt_email.Text & "',`contact_number`= '" & txt_phone.Text & "' WHERE vendor_id=" & vendor_id & ";"

            cmd = New MySqlCommand(query, cn)
            cn.Open()

            cmd.ExecuteNonQuery()

            MsgBox("Vendor updated successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Dim Form2 As New VendorManagerDashboard()
            Form2.Show()
            Me.Close()

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form2 As New VendorManagerDashboard()
        Form2.Show()
        Me.Close()
    End Sub
End Class