Imports MySql.Data.MySqlClient
Public Class ContractManagerAddContract
    Private Sub ContractManagerAddContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txt_authorID.ReadOnly = True
        'txt_authorID.Text = selectedItemsAuthor.Item(0).ToString()
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Try
            connection()
            Dim insertStatement As String
            insertStatement = "Insert into Author_Contract(contract_manager_id,author_id,contract_start_date,contract_end_date) values(" & Convert.ToInt16(txt_EmployeeID.Text) & ",'" & Convert.ToInt16(txt_authorID.Text) & "','" & GetDateString(dtp_start.Value) & "','" & GetDateString(dtp_end.Value) & "');"
            cn.Open()
            cmd = New MySqlCommand(insertStatement, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Contract added successfully!")
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