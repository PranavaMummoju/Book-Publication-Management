Imports MySql.Data.MySqlClient

Public Class ContractManagerInsertBook
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub UpdateComboBox()
        ComboBox_status.Items.Add("Assign to Editor")
        ComboBox_status.Items.Add("Editor")
        ComboBox_status.Items.Add("Author Review")
        ComboBox_status.Items.Add("Edited")
        ComboBox_status.Items.Add("Designing")
        ComboBox_status.Items.Add("Ready to Print")
        ComboBox_status.Items.Add("Printing")
        ComboBox_status.Items.Add("Published")
    End Sub

    Private Sub ContractManagerInsertBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            UpdateComboBox()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Try
            connection()
            Dim insertStatement As String
            insertStatement = "Insert into Book(book_name,status,start_date,end_date,last_updated) values('" & txt_book_name.Text & "','" & ComboBox_status.Text & "','" & GetDateString(dtp_start.Value) & "','" & GetDateString(dtp_end.Value) & "','" & GetDateString(dtp_modified.Value) & "');"
            cn.Open()
            cmd = New MySqlCommand(insertStatement, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Book inserted successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Dim Form2 As New ContractManagerDashboard()
            Form2.Show()
            Me.Close()
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form2 As New ContractManagerDashboard()
        Form2.Show()
        Me.Close()
    End Sub
End Class