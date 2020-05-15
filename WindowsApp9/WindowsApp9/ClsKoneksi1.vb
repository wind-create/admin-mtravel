Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Public Class ClsKoneksi

    Public tblUser = New DataTable
    Public SQL As String
    Public Cn As MySqlConnection
    Public Cmd As MySqlCommand
    Public Da As MySqlDataAdapter
    Public Ds As DataSet
    Public Dt As DataTable


    Public Function OpenConn() As Boolean
        Cn = New MySqlConnection("server=localhost; user id=root; password=''; database=mtravel")
        Cn.Open()
        If Cn.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub CloseConn()
        If Not IsNothing(Cn) Then
            Cn.Close()
            Cn = Nothing
        End If
    End Sub
    Public Function ExecuteQuery(ByVal Query As String) As DataTable
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Access Failed")
            Return Nothing
            Exit Function
        End If

        Cmd = New MySqlCommand(Query, Cn)
        'Cmd = New OleDb.OleDbCommand(Query, Cn)
        'Da = New OleDb.OleDbDataAdapter
        Da = New MySqlDataAdapter
        Da.SelectCommand = Cmd

        Ds = New Data.DataSet
        Da.Fill(Ds)

        Dt = Ds.Tables(0)

        Return Dt

        Dt = Nothing
        Ds = Nothing
        Da = Nothing
        Cmd = Nothing

        CloseConn()

    End Function
    Public Sub ExecuteNonQuery(ByVal Query As String)
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Access Failed..!!")
            Exit Sub
        End If

        Cmd = New MySqlCommand(Query, Cn)
        Cmd.Connection = Cn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = Query
        Cmd.ExecuteNonQuery()
        Cmd = Nothing
        CloseConn()
    End Sub
End Class