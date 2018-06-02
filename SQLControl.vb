Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQLControl

    Public SqlCon As New SqlConnection With {.ConnectionString = ServerString}
    Public SqlCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDS As DataSet


    Public Function HasConnection() As Boolean
        Try
            SqlCon.Open()
            SqlCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function


    Public Sub RunQuery(query As String)
        Try
            SqlCon.Open()
            SqlCmd = New SqlCommand(query, SqlCon)
            SQLDA = New SqlDataAdapter(SqlCmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)


            SqlCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            If SqlCon.State = ConnectionState.Open Then
                SqlCon.Close()
            End If
        End Try
    End Sub


End Class


