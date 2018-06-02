


Imports System.Data.Sql
Imports System.Data.SqlClient





Public Class SQLControl

    Public SqlCon As New SqlConnection With {.ConnectionString = OrbakString}
    Public SqlConWizCount As New SqlConnection With {.ConnectionString = WizCountString}
    Public SqlConCRM As New SqlConnection With {.ConnectionString = CRMString}
    Public SqlConCheuqes As New SqlConnection With {.ConnectionString = CheuqesString}



    ' Public SqlExcel As New SqlConnection With {.ConnectionString = ExcelString}
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

    Public Function WizCountHasConnection() As Boolean
        Try
            SqlCon.Open()
            SqlConWizCount.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
    Public Function CRMHasConnection() As Boolean
        Try
            SqlCon.Open()
            SqlConCRM.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Function CheuqesHasConnection() As Boolean
        Try
            SqlCon.Open()
            SqlConCRM.Close()
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

    Public Sub WizCountRunQuery(query As String)
        Try
            SqlConWizCount.Open()
            SqlCmd = New SqlCommand(query, SqlConWizCount)
            SQLDA = New SqlDataAdapter(SqlCmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)


            SqlConWizCount.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            If SqlConWizCount.State = ConnectionState.Open Then
                SqlConWizCount.Close()
            End If
        End Try
    End Sub
    Public Sub CRMRunQuery(query As String)
        Try
            SqlConWizCount.Open()
            SqlCmd = New SqlCommand(query, SqlConCRM)
            SQLDA = New SqlDataAdapter(SqlCmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)


            SqlConCRM.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            If SqlConCRM.State = ConnectionState.Open Then
                SqlConCRM.Close()
            End If
        End Try
    End Sub
    Public Sub ChuquesRunQuery(query As String)
        Try
            SqlConCheuqes.Open()
            SqlCmd = New SqlCommand(query, SqlConCheuqes)
            SQLDA = New SqlDataAdapter(SqlCmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)


            SqlConCheuqes.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            If SqlConCheuqes.State = ConnectionState.Open Then
                SqlConCheuqes.Close()
            End If
        End Try
    End Sub

End Class



