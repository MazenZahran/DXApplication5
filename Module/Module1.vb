


Imports System.Data.Sql
Imports System.Data.SqlClient





Public Class SQLControl

    Public SqlConOrpak As New SqlConnection With {.ConnectionString = OrbakString}
    Public SqlConWizCount As New SqlConnection With {.ConnectionString = WizCountString}
    Public SqlConCRM As New SqlConnection With {.ConnectionString = CRMString}
    Public SqlConCheuqes As New SqlConnection With {.ConnectionString = CheuqesString}
    Public SqlConWallet As New SqlConnection With {.ConnectionString = WalletString}
    Public SqlConTrueTime As New SqlConnection With {.ConnectionString = TrueTimeString}
    Public SqlConOldOrpak As New SqlConnection With {.ConnectionString = OrbakOldString}

    ' Public SqlExcel As New SqlConnection With {.ConnectionString = ExcelString}
    Public SqlCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDS As DataSet


    Public Function HasConnection() As Boolean
        Try
            SqlConOrpak.Open()
            SqlConOrpak.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Function WizCountHasConnection() As Boolean
        Try
            SqlConWizCount.Open()
            SqlConWizCount.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
    Public Function CRMHasConnection() As Boolean
        Try
            SqlConCRM.Open()
            SqlConCRM.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Function CheuqesHasConnection() As Boolean
        Try
            SqlConCRM.Open()
            SqlConCRM.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
    Public Function TrueTimeHasConnection() As Boolean
        Try
            SqlConTrueTime.Open()
            SqlConTrueTime.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function


    Public Sub RunQuery(query As String)

        Try
            SqlConOrpak.Open()
            SqlCmd = New SqlCommand(query, SqlConOrpak)
            SQLDA = New SqlDataAdapter(SqlCmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)
            SqlConOrpak.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If SqlConOrpak.State = ConnectionState.Open Then
                SqlConOrpak.Close()
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
            '  MsgBox(ex.Message)
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

    Public Sub WalletRunQuery(query As String)
        Try
            SqlConWallet.Open()
            SqlCmd = New SqlCommand(query, SqlConWallet)
            SQLDA = New SqlDataAdapter(SqlCmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)


            SqlConWallet.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            If SqlConWallet.State = ConnectionState.Open Then
                SqlConWallet.Close()
            End If
        End Try
    End Sub


    Public Sub TrueTimeRunQuery(query As String)
        Try
            SqlConTrueTime.Open()
            SqlCmd = New SqlCommand(query, SqlConTrueTime)
            SQLDA = New SqlDataAdapter(SqlCmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)

            SqlConTrueTime.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            If SqlConTrueTime.State = ConnectionState.Open Then
                SqlConTrueTime.Close()
            End If
        End Try
    End Sub

    Public Sub OldOrpakRunQuery(query As String)
        Try
            SqlConOldOrpak.Open()
            SqlCmd = New SqlCommand(query, SqlConOldOrpak)
            SQLDA = New SqlDataAdapter(SqlCmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)

            SqlConOldOrpak.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            If SqlConOldOrpak.State = ConnectionState.Open Then
                SqlConOldOrpak.Close()
            End If
        End Try
    End Sub

End Class



