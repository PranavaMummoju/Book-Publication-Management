Imports MySql.Data.MySqlClient
Public Class frm_book_edit
    Dim d As DateTime = New DateTime(7777, 11, 11)
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        Try
            dtp_end.MinDate = DateTime.Today

            UpdateComboBox()
            txt_name.Text = selectedItems.Item(0)
            ComboBox_Status.Text = selectedItems.Item(1) 'assign to editor, editing, author review, edited, designing, ready to print, printing, published - these are the statuses
            dtp_start.Value = selectedItems.Item(2)

            If selectedItems.Item(3) IsNot DBNull.Value And CheckBox1.Checked = True Then
                'dtp_end.Enabled = True
                dtp_end.Value = selectedItems.Item(3)
                'Else
                'dtp_end.Value = d
            End If
            dtp_modified.Value = selectedItems.Item(4)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            connection()
            Dim query As String
            If CheckBox1.Checked Then
                query = "Update Book set book_name='" & txt_name.Text & "', status= '" & ComboBox_Status.Text & "', start_date= '" & GetDateString(dtp_start.Value) & "', end_date= '" & GetDateString(dtp_end.Value) & "', last_updated='" & GetDateString(DateTime.Today) & "' Where book_id=" & book_id.ToString()
            Else
                query = "Update Book set book_name='" & txt_name.Text & "', status= '" & ComboBox_Status.Text & "', start_date= '" & GetDateString(dtp_start.Value) & "', last_updated='" & GetDateString(DateTime.Today) & "' Where book_id=" & book_id.ToString()
            End If

            cmd = New MySqlCommand(query, cn)
            cn.Open()

            cmd.ExecuteNonQuery()

            MsgBox("Book updated successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Dim Form2 As New frm_editor_dashboard()
            Form2.Show()
            Me.Close()

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            dtp_end.Enabled = True
        Else
            dtp_end.Enabled = False
        End If
    End Sub

    Private Sub UpdateComboBox()
        ComboBox_Status.Items.Add("Assign to Editor")
        ComboBox_Status.Items.Add("Editing")
        ComboBox_Status.Items.Add("Author Review")
        ComboBox_Status.Items.Add("Edited")
        ComboBox_Status.Items.Add("Designing")
        ComboBox_Status.Items.Add("Ready to Print")
        ComboBox_Status.Items.Add("Printing")
        ComboBox_Status.Items.Add("Published")
    End Sub
End Class