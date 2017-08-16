Imports MySql.Data.MySqlClient
Module Module1

    Public user_id, emp_id, book_id, author_id, contract_id, order_id, vendor_id As Int16
    Public cn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public cmd2 As MySqlCommand
    Public dr2 As MySqlDataReader
    Public dr3 As MySqlDataReader

    Public selectedItems As ArrayList
    Public selectedItemsAuthor As ArrayList
    Public selectedItemsBook As ArrayList
    Public selectedItemsContract As ArrayList
    Public selectedItemsEmployee As ArrayList
    Public OrderstoPrint As ArrayList
    Public selectedItemsVendor As ArrayList

    Public Sub connection()
        cn = New MySqlConnection("server=localhost; Uid=root; database=book_publication_system_1")
    End Sub

    Public Function GetDateString(d As DateTime) As String
        Return d.Year.ToString() & "-" & d.Month.ToString() & "-" & d.Day.ToString()

    End Function

    Public Sub FetchEmployeeDetails()
        cmd = New MySqlCommand("get_employee_details", cn)
        cmd.CommandType = System.Data.CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@employee_id", emp_id)
        cmd.Parameters("@employee_id").Direction = ParameterDirection.Input

        cmd.Parameters.Add("@fname", MySqlDbType.VarChar)
        cmd.Parameters("@fname").Direction = ParameterDirection.Output

        cmd.Parameters.Add("@lname", MySqlDbType.VarChar)
        cmd.Parameters("@lname").Direction = ParameterDirection.Output

        cmd.Parameters.Add("@desig", MySqlDbType.Enum)
        cmd.Parameters("@desig").Direction = ParameterDirection.Output

        cmd.Parameters.Add("@dept", MySqlDbType.VarChar)
        cmd.Parameters("@dept").Direction = ParameterDirection.Output

    End Sub

End Module
