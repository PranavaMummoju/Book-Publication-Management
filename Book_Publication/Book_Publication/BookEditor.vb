Imports MySql.Data.MySqlClient
Public Class BookEditor
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            connection()
            Dim insertStatement As String
            insertStatement = "Insert into Book_Editor(book_id,editor_id) values(" & Convert.ToInt16(TextBox1.Text) & "," & Convert.ToInt16(TextBox2.Text) & ");"
            cn.Open()
            cmd = New MySqlCommand(insertStatement, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Editor assigned")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Dim Form2 As New ContractManagerDashboard()
            Form2.Show()
            Me.Close()
        End Try
    End Sub

    Private Sub BookEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = book_id.ToString()
        TextBox1.ReadOnly = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form2 As New ContractManagerDashboard()
        Form2.Show()
        Me.Close()
    End Sub
End Class