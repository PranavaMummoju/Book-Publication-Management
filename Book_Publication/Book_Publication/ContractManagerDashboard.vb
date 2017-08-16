Imports MySql.Data.MySqlClient

Public Class ContractManagerDashboard
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ContractManagerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'cn = New MySqlConnection("server=localhost; Uid=root; database=book_publication_system")
            connection()
            FetchEmployeeDetails()
            cn.Open()

            'dr2 = cmd.ExecuteNonQuery()
            cmd.ExecuteNonQuery()
            'If dr2.HasRows = True Then

            'While dr2.Read
            txt_name.Text = cmd.Parameters("@fname").Value.ToString() + " " + cmd.Parameters("@lname").Value.ToString()
            txt_desig.Text = cmd.Parameters("@desig").Value.ToString()
            txt_empID.Text = emp_id.ToString()
            txt_dept.Text = cmd.Parameters("@dept").Value.ToString()

            cn.Close()

            Dim dt As DataTable
            dt = New DataTable()
            cn.Open()
            Dim qrstr As String

            qrstr = "Select * from Book"

            cmd2 = New MySqlCommand(qrstr, cn)
            dr2 = cmd2.ExecuteReader
            'While dr.Read
            dt.Load(dr2)
            'End While

            Bndg_Src_Book.DataSource = dt

            DataGrid_Book.DataSource = Bndg_Src_Book

            dr2.Close()
            cn.Close()

            Dim dt2 As DataTable
            dt2 = New DataTable()

            qrstr = "Select * from Author_PersonalDetails"
            cn.Open()
            cmd2 = New MySqlCommand(qrstr, cn)
            dr2 = cmd2.ExecuteReader
            'While dr.Read
            dt2.Load(dr2)
            'End While

            Bndg_Src_Author.DataSource = dt2

            DataGrid_Author.DataSource = Bndg_Src_Author

            dr2.Close()
            cn.Close()

            Dim dt3 As DataTable
            dt3 = New DataTable()

            qrstr = "Select * from Author_Contract
                    where contract_manager_id=" & emp_id
            cn.Open()
            cmd2 = New MySqlCommand(qrstr, cn)
            dr2 = cmd2.ExecuteReader
            'While dr.Read
            dt3.Load(dr2)
            'End While

            Bndg_Src_Contract.DataSource = dt3

            DataGrid_Contract.DataSource = Bndg_Src_Contract

            dr2.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox("Failed to connect" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btn_inser_book_Click(sender As Object, e As EventArgs) Handles btn_inser_book.Click
        Dim myForm3 As New ContractManagerInsertBook()
        myForm3.Show()
        Me.Close()
    End Sub

    Private Sub btn_insert_author_Click(sender As Object, e As EventArgs) Handles btn_insert_author.Click
        Dim myForm3 As New ComtractManagerInsertAuthor()
        myForm3.Show()
        Me.Close()
    End Sub

    Private Sub DataGrid_Author_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_Author.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGrid_Author.Rows(index)
            selectedItemsAuthor = New ArrayList(20)
            author_id = Convert.ToInt16(selectedRow.Cells(0).Value)
            selectedItemsAuthor.Add(selectedRow.Cells(1).Value)
            selectedItemsAuthor.Add(selectedRow.Cells(2).Value)
            selectedItemsAuthor.Add(selectedRow.Cells(3).Value)
            selectedItemsAuthor.Add(selectedRow.Cells(4).Value)
            selectedItemsAuthor.Add(selectedRow.Cells(5).Value)
            selectedItemsAuthor.Add(selectedRow.Cells(6).Value)
            selectedItemsAuthor.Add(selectedRow.Cells(7).Value)
            selectedItemsAuthor.Add(selectedRow.Cells(8).Value)
            selectedItemsAuthor.Add(selectedRow.Cells(9).Value)
            selectedItemsAuthor.Add(selectedRow.Cells(10).Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myForm3 As New ContractManagerAddContract()
        myForm3.Show()
        Me.Close()
    End Sub

    Private Sub DataGrid_Book_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_Book.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGrid_Book.Rows(index)
            selectedItemsBook = New ArrayList(20)
            book_id = Convert.ToInt16(selectedRow.Cells(0).Value)
            selectedItemsBook.Add(selectedRow.Cells(1).Value)
            selectedItemsBook.Add(selectedRow.Cells(3).Value)
            selectedItemsBook.Add(selectedRow.Cells(4).Value)
            selectedItemsBook.Add(selectedRow.Cells(5).Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_editor_Click(sender As Object, e As EventArgs) Handles btn_editor.Click
        Dim myForm3 As New BookEditor()
        myForm3.Show()
        Me.Close()
    End Sub

    Private Sub btn_link_Click(sender As Object, e As EventArgs) Handles btn_link.Click
        Try
            connection()
            Dim insertStatement As String
            insertStatement = "Insert into Book_Author(book_id,author_id) values(" & book_id & "," & author_id & ");"
            cn.Open()
            cmd = New MySqlCommand(insertStatement, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Select Book and author Linked")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myForm3 As New AuthorUpdate()
        myForm3.Show()
        Me.Close()
    End Sub

    Private Sub DataGrid_Contract_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_Contract.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGrid_Contract.Rows(index)
            selectedItemsContract = New ArrayList(20)
            contract_id = Convert.ToInt16(selectedRow.Cells(0).Value)
            selectedItemsContract.Add(selectedRow.Cells(1).Value)
            selectedItemsContract.Add(selectedRow.Cells(2).Value)
            selectedItemsContract.Add(selectedRow.Cells(3).Value)
            selectedItemsContract.Add(selectedRow.Cells(4).Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim myForm3 As New UpdateContract()
        myForm3.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class