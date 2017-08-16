Imports MySql.Data.MySqlClient
Public Class UpdateContract
    Private Sub UpdateContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txt_authorID.Text = selectedItemsContract.Item(0)
            txt_EmployeeID.Text = selectedItemsContract.Item(1)
            dtp_start.Text = selectedItemsContract.Item(2)
            dtp_end.Text = selectedItemsContract.Item(3)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Try
            connection()
            Dim query As String

            query = "UPDATE `author_contract` SET `author_id`=" & Convert.ToInt16(txt_authorID.Text) & ",`contract_manager_id`=" & Convert.ToInt16(txt_EmployeeID.Text) & ",`contract_start_date`='" & GetDateString(dtp_start.Value) & "',`contract_end_date`='" & GetDateString(dtp_end.Value) & "' WHERE contract_id=" & contract_id & ";"

            cmd = New MySqlCommand(query, cn)
            cn.Open()

            cmd.ExecuteNonQuery()

            MsgBox("Contract updated successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Dim Form2 As New ContractManagerDashboard()
            Form2.Show()
            Me.Close()

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form2 As New ContractManagerDashboard()
        Form2.Show()
        Me.Close()
    End Sub
End Class