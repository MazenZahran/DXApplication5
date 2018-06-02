﻿Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FinancialAccountsBalances
    Dim AccTable As DataTable
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If FromSortText.Text = "" Or ToSortText.Text = "" Then MsgBox("يرجى اختيار التصنيف") : Exit Sub
        SplashScreenManager1.ShowWaitForm()
        Getbalance2()
        SplashScreenManager1.CloseWaitForm
    End Sub

    Private Sub Getbalance()

        Try
            GridControl1.DataSource = ""
            Dim sql As New SQLControl
            Dim AccountsSQl As String


            AccountsSQl = " SELECT  DISTINCT (JMACCOUNTKEY)  As AccountID, AFULLNAME , Acountry ,ASORTGROUP ,APHONE,Afilter,AEmail,ACOSTCODE,ASphone,'' As DebitBalance, '' As CreditBalance , '' as AccBalance  " _
            & " from RPHSTRANSRETRIV " _
            & " WHERE  ASORTGROUP between " & FromSortText.Text & " and " & ToSortText.Text & "  And  (  " _
            & "   (JVALUEDATE between '" & CStr(Format(DateEditFrom.DateTime, "yyyy-MM-dd")) & "' and  '" & CStr(Format(DateEditTo.DateTime, "yyyy-MM-dd")) & "' ) " _
            & " AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 "



            sql.WizCountRunQuery(AccountsSQl)
            GridControl1.DataSource = sql.SQLDS.Tables(0)


            Dim Deb As String, Crd As String

            For i = 0 To GridView1.RowCount - 1

                Deb = GetDebitBalance(GridView1.GetRowCellValue(i, "AccountID").ToString)
                Crd = GetCreditBalance(GridView1.GetRowCellValue(i, "AccountID").ToString)

                If IsNumeric(Deb) Then Deb = Deb Else Deb = "0"
                If IsNumeric(Crd) Then Crd = Crd Else Crd = "0"

                GridView1.SetRowCellValue(i, GridView1.Columns("DebitBalance"), Deb)
                GridView1.SetRowCellValue(i, GridView1.Columns("CreditBalance"), Crd)
                GridView1.SetRowCellValue(i, GridView1.Columns("AccBalance"), CDec(Deb) - CDec(Crd))

            Next
        Catch ex As Exception

        End Try






    End Sub


    Private Sub Getbalance2()

        Try
            GridControl1.DataSource = ""

            Dim sql As New SQLControl
            Dim AccountsSQl As String


            AccountsSQl = " SELECT  DISTINCT (JMACCOUNTKEY)  As AccountID, AFULLNAME , Acountry ,ASORTGROUP,ACSORTCODENAME,APHONE,Afilter,AEmail,ACOSTCODE,ASphone, 0.00 As DebitBalance, 0.00 As CreditBalance , 0.00 as AccBalance  " _
            & " from RPHSTRANSRETRIV " _
            & " WHERE  ASORTGROUP between " & CStr(FromSortText.EditValue) & " and " & CStr(ToSortText.EditValue) & "  And  (  " _
            & "   (JVALUEDATE between '" & CStr(Format(DateEditFrom.DateTime, "yyyy-MM-dd")) & "' and  '" & CStr(Format(DateEditTo.DateTime, "yyyy-MM-dd")) & "' ) " _
            & " AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 "



            sql.WizCountRunQuery(AccountsSQl)
            AccTable = sql.SQLDS.Tables(0)


            Dim Deb As String, Crd As String

            For i = 0 To AccTable.Rows.Count - 1

                Deb = GetDebitBalance(AccTable.Rows(i).Item("AccountID").ToString)
                Crd = GetCreditBalance(AccTable.Rows(i).Item("AccountID").ToString)

                If IsNumeric(Deb) Then Deb = Deb Else Deb = "0"
                If IsNumeric(Crd) Then Crd = Crd Else Crd = "0"

                AccTable.Rows(i).Item("DebitBalance") = Deb
                AccTable.Rows(i).Item("CreditBalance") = Crd
                AccTable.Rows(i).Item("AccBalance") = CDec(Deb) - CDec(Crd)

                If CInt(AccTable.Rows(i).Item("AccBalance").ToString) = 0 Then AccTable.Rows(i).Delete()

            Next
            AccTable.AcceptChanges()
            GridControl1.DataSource = AccTable
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try




    End Sub

    Private Function GetDebitBalance(AccountID As String) As String

        Try
            Dim DebitBalance As String
            Dim sql As New SQLControl
            DebitBalance = " SELECT    cast(  sum( JMSUF ) as decimal(10,2)) As DebitBalance     " _
                                & " from RPHSTRANSRETRIV" _
                                & " WHERE   JMDEBITCREDIT=1 and       ( JMACCOUNTKEY = '" & AccountID & "'" _
                                & " AND  (JVALUEDATE between '" & CStr(Format(DateEditFrom.DateTime, "yyyy-MM-dd")) & "' and  '" & CStr(Format(DateEditTo.DateTime, "yyyy-MM-dd")) & "' ) " _
                                & " AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 "
            sql.WizCountRunQuery(DebitBalance)
            GetDebitBalance = sql.SQLDS.Tables(0).Rows(0).Item("DebitBalance").ToString
        Catch ex As Exception
            GetDebitBalance = "0"
        End Try


    End Function

    Private Function GetCreditBalance(AccountID As String) As String

        Try
            Dim CreditBalance As String
            Dim sql As New SQLControl
            CreditBalance = " SELECT  cast(  sum( JMSUF ) as decimal(10,2)) As CreditBalance   " _
                                & " from RPHSTRANSRETRIV" _
                                & " WHERE   JMDEBITCREDIT=0 and       ( JMACCOUNTKEY = '" & AccountID & "'" _
                                & " AND  (JVALUEDATE between '" & CStr(Format(DateEditFrom.DateTime, "yyyy-MM-dd")) & "' and  '" & CStr(Format(DateEditTo.DateTime, "yyyy-MM-dd")) & "' ) " _
                                & " AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 "
            sql.WizCountRunQuery(CreditBalance)
            GetCreditBalance = sql.SQLDS.Tables(0).Rows(0).Item("CreditBalance").ToString
        Catch ex As Exception
            GetCreditBalance = "0"
        End Try


    End Function

    Private Sub FinancialAccountsBalances_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.AccSortNames' table. You can move, or remove it, as needed.
        Me.AccSortNamesTableAdapter.Fill(Me.WizCountDataSet.AccSortNames)
        'TODO: This line of code loads data into the 'CRMDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.CRMDataSet.Users)
        DateEditTo.DateTime = CDate(DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000"))
        DateEditFrom.DateTime = CDate(DateTime.Now.AddYears(-1).ToString("yyyy-MM-dd 00:00:00.000"))
        MonthText.Text = Format(Today.AddMonths(-1), "yyyyMM")
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GridControl1.ShowPrintPreview()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles SimpleButton3.Click

        Try
            If GridView1.RowCount < 0 Then MsgBox("لا يوجد بيانات ") : Exit Sub
            If MonthText.Text = "" Then MsgBox("خانة الشهر فارغة") : Exit Sub
            If ToUserText.Text = "" Then MsgBox("خانة الموظف فارغة") : Exit Sub

            Dim result As DialogResult = XtraMessageBox.Show("هل تريد  تحويل المهام " & " " & ToUserText.Text, "تأكيد", MessageBoxButtons.YesNo)

            If result = System.Windows.Forms.DialogResult.No Then Exit Sub

            Dim sql2 As New SQLControl
            Dim TasksCount As String
            Dim SqlCountLastTasks As String = "SELECT  COUNT(TaskID) As LastCountTasks  FROM   CRMTasks "
            sql2.CRMRunQuery(SqlCountLastTasks)
            TasksCount = sql2.SQLDS.Tables(0).Rows(0).Item("LastCountTasks").ToString


            Dim myconnection As SqlConnection
            Dim mycommand As SqlCommand
            myconnection = New SqlConnection(CRMString)
            myconnection.Open()

            For i = 0 To AccTable.Rows.Count - 1
                If CInt(AccTable.Rows(i).Item("AccBalance").ToString) > 100 Or CInt(AccTable.Rows(i).Item("AccBalance").ToString) < -100 Then

                    Dim SQLInsertTaskLog As String = "insert into  [CRM].[dbo].[CRMTasks] 
                                           ( [InputDate],[InputTime],[User],[CustID] ,[CustomerName],[Person],[Note],[NoteStatus],[ToUser],[AccrualDate],
                                           [TaskType],[AccSort],[Amount],[TaskMonth] ,[Importance],[Mobile] ) values (
                                            " & "'" & Format(Today, "yyyy-MM-dd") & "', " & "
                                            " & "'" & Format(Now, "HH:mm:ss") & "', " & "
                                            " & "'" & "System" & "', " & "
                                            " & "'" & AccTable.Rows(i).Item("AccountID").ToString & "', " & "
                                            " & "'" & AccTable.Rows(i).Item("AFULLNAME").ToString & "', " & "
                                            " & "'" & AccTable.Rows(i).Item("Acountry").ToString & "', " & "
                                            " & "'" & " تحصيل شهر  " & MonthText.Text & " ', " & "
                                            " & "'" & "مفتوحة" & "', " & "
                                            " & "'" & CStr(ToUserText.EditValue) & "', " & "
                                            " & "'" & Format(Today, "yyyy-MM-dd") & "', " & "
                                            " & "'" & "دين" & "', " & "
                                            " & "'" & AccTable.Rows(i).Item("ASORTGROUP").ToString & "', " & "
                                            " & "'" & AccTable.Rows(i).Item("AccBalance").ToString & "', " & "
                                            " & "'" & MonthText.Text & "', " & "
                                            " & "'" & "1" & "', " & "
                                            " & " '" & AccTable.Rows(i).Item("ASphone").ToString & "'
                                            " & "     " & " )"

                    mycommand = New SqlCommand(SQLInsertTaskLog, myconnection)
                    mycommand.ExecuteNonQuery()

                End If
            Next

            myconnection.Close()




            Dim sql3 As New SQLControl
            Dim TasksCount2 As String
            Dim SqlCountLastTasks2 As String = "SELECT  COUNT(TaskID) As LastCountTasks  FROM   CRMTasks "
            sql3.CRMRunQuery(SqlCountLastTasks)
            TasksCount2 = sql3.SQLDS.Tables(0).Rows(0).Item("LastCountTasks").ToString

            Dim NewRecord As Integer = CInt(TasksCount2) - CInt(TasksCount)

            XtraMessageBox.Show(" تم ادخال  " & NewRecord & " حركة جديدة ")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try




    End Sub


    Private Sub GridView1_CustomDrawCell(ByVal sender As Object,
ByVal e As RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell

        Dim ImageSent As Image = My.Resources.Sent
        Dim ImageFalse As Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/close_16x16.png")
        Dim View As GridView = CType(sender, GridView)
        Dim ImageDelete As Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/communication/phone_16x16.png")
        Dim EmptyPhone As Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/info_16x16.png")

        If e.Column.FieldName = "AlertMessage" Then
            Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("AlertMessage"))
            If category = "Message Sent Successfully!" Then
                e.Graphics.DrawImage(ImageSent, e.Bounds.Location)
                e.DisplayText = "تم"
            End If
            If category = "H006|Invalid Recipient Number" Then
                e.Graphics.DrawImage(ImageFalse, e.Bounds.Location)
                e.DisplayText = "خطا بالرقم"
            End If
            If category = "" Then
                ' e.Graphics.DrawImage(ImageDelete, e.Bounds.Location)
                e.DisplayText = ""
            End If
        End If

        If e.Column.FieldName = "ASphone" Then
            Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ASphone"))
            If category <> "" Then
                e.Graphics.DrawImage(ImageDelete, e.Bounds.Location)
            Else
                e.Graphics.DrawImage(EmptyPhone, e.Bounds.Location)
                e.DisplayText = "فارغ"
            End If
        End If

    End Sub

End Class