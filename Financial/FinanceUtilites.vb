Imports System.Data.SqlClient
Imports DevExpress.DataAccess.Sql

Public Class FinanceUtilites
    Private Sub SortText_EditValueChanged(sender As Object, e As EventArgs) Handles SortText.EditValueChanged

    End Sub
    Sub GetAccounts()
        Dim SQLString As String = " SELECT     [AccountKey],[FullName],[SortGroup] ,[zip]  from Accounts " &
                                  " WHERE SortGroup = " & SortText.Text

        Dim sql As New SQLControl
        sql.WizCountRunQuery(SQLString)
        GridControl1.DataSource = sql.SQLDS.Tables(0)

    End Sub

    Sub GetSortName()
        Try
            If SortText.Text = "" Then MsgBox("خطا: رقم التصنيف فارغ") : SortText.BackColor = Color.Red : Exit Sub
            If CInt(SortText.Text) < 2000 Or CInt(SortText.Text) > 3000 Then MsgBox("خطا: رقم التصنيف غير تابع للزبائن") : Exit Sub
            Dim SQLString As String = " SELECT     SortCodeName  from AccSortNames " &
                                  " WHERE AccSortCode = " & SortText.Text
            Dim i As Integer
            Dim sql As New SQLControl
            sql.WizCountRunQuery(SQLString)
            If CType(sql.SQLDS.Tables(0).Rows(i).Item("SortCodeName"), String) <> "" Then SortNameText.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("SortCodeName"), String)
            If SortNameText.Text <> "" Then SortText.BackColor = DefaultBackColor
            GetAccounts()
            SimpleButton1.Enabled = True
        Catch ex As Exception
            MsgBox("خطأ: لا يوجد تصنيف")
            SortText.BackColor = Color.Red
            GridControl1.DataSource = Nothing
            SortNameText.Text = ""
            SimpleButton1.Enabled = False

        End Try
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If SortText.Text = "" Or SortNameText.Text = "" Then
            Exit Sub
        End If
        If PriceText.Text = "" Then MsgBox("خطأ: سعر الغسيل فارغ") : Exit Sub

        If CInt(PriceText.Text) < 0 Or CInt(PriceText.Text) > 25 Then
            MsgBox("سعر الغسيل خطا")
            Exit Sub
        End If

        Dim SQLString As String = " update accounts set zip=' " & PriceText.Text & "'" &
                                  " WHERE SortGroup = " & SortText.Text

        Dim sql As New SQLControl
        sql.WizCountRunQuery(SQLString)

        GetAccounts()
        MsgBox("تم تعديل السعر")

    End Sub

    Private Sub SortText_Leave(sender As Object, e As EventArgs) Handles SortText.Leave
        GetSortName()
    End Sub

    Private Sub PriceText_EditValueChanged(sender As Object, e As EventArgs) Handles PriceText.EditValueChanged

    End Sub
    Sub CheckPrice()
        If CInt(PriceText.Text) < 0 Or CInt(PriceText.Text) > 25 Then
            MsgBox("سعر الغسيل خطا")
            Exit Sub
        End If
    End Sub
End Class