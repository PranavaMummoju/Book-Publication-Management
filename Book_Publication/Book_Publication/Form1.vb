Imports MySql.Data.MySqlClient

Public Class frm_login
    'Dim cn As MySqlConnection
    'Dim cmd As MySqlCommand
    'Dim dr As MySqlDataReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            'cn = New MySqlConnection("server=localhost; Uid=root; database=book_publication_system")
            connection()
            cmd = New MySqlCommand("Select * from User where emp_id='" + txt_userid.Text + "' and password ='" + txt_password.Text + "'", cn)
            cn.Open()

            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                ' MsgBox("okkk" & vbCrLf)
                Dim dataTable As DataTable
                dataTable = New DataTable()
                While dr.Read
                    'user_id = Convert.ToInt16(dr.Item("user_id"))
                    emp_id = Convert.ToInt16(dr.Item("emp_id"))
                    dr.Close()
                    cmd = New MySqlCommand("Select * from Employee_Organizationaldetails where emp_id=" & emp_id, cn)
                    dr = cmd.ExecuteReader
                    dataTable.Load(dr)
                    Dim desig As String
                    desig = dataTable.Rows(0).Item(3).ToString()
                    Select Case desig
                        Case "Editor"
                            Dim myForm2 As New frm_editor_dashboard()
                            myForm2.Show()
                            Me.Hide()
                            Exit While

                        Case "Contract Manager"
                            Dim myForm3 As New ContractManagerDashboard()
                            myForm3.Show()
                            Me.Hide()
                            Exit While

                        Case "HR"
                            Dim myForm4 As New HRdashboard()
                            myForm4.Show()
                            Me.Hide()
                            Exit While

                        Case "Vendor Manager"
                            Dim myForm4 As New VendorManagerDashboard()
                            myForm4.Show()
                            Me.Hide()
                            Exit While
                    End Select
                    'Dim myForm2 As New frm_editor_dashboard()
                    'myForm2.Show()
                    'Me.Hide()
                    'dr.Close()
                    'cn.Close()
                End While

            Else
                MsgBox("Mismatch Credentials Try Again!!" & vbCrLf)
                txt_userid.Text = ""
                txt_password.Text = ""
            End If


            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox("Failed to connect" & vbCrLf & ex.Message)
        End Try
    End Sub
End Class
