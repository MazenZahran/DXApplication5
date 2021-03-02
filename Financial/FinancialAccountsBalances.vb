Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FinancialAccountsBalances
    Dim AccTable As DataTable
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If FromSortText.Text = "" Or ToSortText.Text = "" Then MsgBox("يرجى اختيار التصنيف") : Exit Sub

        If CInt(FromSortText.EditValue) < 2000 Or CInt(FromSortText.EditValue) > 2700 Then
            MsgBox("لا يوجد صلاحية")
            Exit Sub
        End If

        If CInt(ToSortText.EditValue) < 2000 Or CInt(ToSortText.EditValue) > 2700 Then
            MsgBox("لا يوجد صلاحية")
            Exit Sub
        End If

        SplashScreenManager1.ShowWaitForm()
        Getbalance2()
        SplashScreenManager1.CloseWaitForm()


        Dim SqlCmd As SqlCommand
        Dim SQLDA As SqlDataAdapter
        Dim SQLDS As DataSet
        Dim SqlConWizCount As New SqlConnection With {.ConnectionString = WizCountString}
        SqlConWizCount.Open()

        For i = 0 To GridView1.RowCount - 1
            Dim AccountKey As String = CType(GridView1.GetRowCellValue(i, "AccountID"), String)
            Try
                Dim LastDate As String
                Dim query As String = "    Select top 1 JVALUEDATE  from [ALHUDA].[dbo].RPHSTRANSRETRIV      
                                           Where  JMACCOUNTKEY     ='" & AccountKey & "'
                                           Order by  jmtransid   desc"
                SqlCmd = New SqlCommand(query, SqlConWizCount)
                SQLDA = New SqlDataAdapter(SqlCmd)
                SQLDS = New DataSet
                SQLDA.Fill(SQLDS)
                LastDate = Format(CDate(SQLDS.Tables(0).Rows(0).Item("JVALUEDATE")), "yyyy-MM-dd")
                GridView1.SetRowCellValue(i, ColAccLastTrans, LastDate)

            Catch ex As Exception
                GridView1.SetRowCellValue(i, ColAccLastTrans, "2000-01-01")
                SqlConWizCount.Close()
            End Try


        Next

        SqlConWizCount.Close()

        For i = 0 To GridView1.RowCount - 1
            Dim AccountKey As String = CType(GridView1.GetRowCellValue(i, "AccountID"), String)
            GridView1.SetRowCellValue(i, ColUnAccrualChecks, GetSumCheks(CStr(DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000")), AccountKey))
        Next i
        InsertLog(Me.Name, CStr(FromSortText.EditValue) & " and " & CStr(ToSortText.EditValue))
    End Sub
    Private Function GetSumCheks(FromDate As String, AccNo As String) As Integer

        Try
            Dim sql As New SQLControl
            Dim i As Integer

            Dim SqlString As String = "SELECT Sum(NIS) as NIS2
                                    FROM
                                    (  SELECT  CASE WHEN SuFDlr= 0 THEN SuF else SuFDlr END AS NIS
		                            FROM [ALHUDA].[dbo].[Cheqs]
		                            where AccKey='" & AccNo & "' and ValueDate > '" & FromDate & "' ) as TotalNis"

            sql.WizCountRunQuery(SqlString)
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(i).Item("NIS2")) Then GetSumCheks = CType(sql.SQLDS.Tables(0).Rows(i).Item("NIS2"), Integer)

            Return GetSumCheks
        Catch ex As Exception

        End Try

        Return GetSumCheks

    End Function

    Private Sub Getbalance()

        Try
            GridControl1.DataSource = ""
            Dim sql As New SQLControl
            Dim AccountsSQl As String


            AccountsSQl = " SELECT  DISTINCT (JMACCOUNTKEY)  As AccountID, AFULLNAME , Acountry ,ASORTGROUP ,APHONE,Afilter,AEmail,ACOSTCODE,ASphone,'' As DebitBalance, '' As CreditBalance , '' as AccBalance  
                            From RPHSTRANSRETRIV 
                            WHERE  ASORTGROUP between " & FromSortText.Text & " and " & ToSortText.Text & "  And  ( 
                                  (JVALUEDATE between '" & CStr(Format(DateEditFrom.DateTime, "yyyy-MM-dd")) & "' and  '" & CStr(Format(DateEditTo.DateTime, "yyyy-MM-dd")) & "' ) 
                                   AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 "

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


            AccountsSQl = " SELECT   DISTINCT (JMACCOUNTKEY)  As AccountID, AFULLNAME ,AMAXCREDIT,convert(datetime,'2000-01-01') as AccLastTrans ,
                            convert(decimal(10,2),'0') As UnAccrualChecks, Acountry ,ASORTGROUP,ACSORTCODENAME,APHONE,
                            Afilter,AEmail,ACOSTCODE,ASphone, 0.00 As DebitBalance, 0.00 As CreditBalance ,
                            0.00 as AccBalance" _
            & " from RPHSTRANSRETRIV " _
            & " WHERE  ASORTGROUP between " & CStr(FromSortText.EditValue) & " and " & CStr(ToSortText.EditValue) & "  And  (  " _
            & "   (JVALUEDATE between '" & CStr(Format(DateEditFrom.DateTime, "yyyy-MM-dd")) & "' and  '" & CStr(Format(DateEditTo.DateTime, "yyyy-MM-dd")) & "' ) " _
            & " AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 "

            Dim i As Integer



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

                If CheckShowZeroBalances.Checked = False Then
                    If CInt(AccTable.Rows(i).Item("AccBalance").ToString) = 0 Then AccTable.Rows(i).Delete()
                End If






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
            DebitBalance = " SELECT    cast(  sum( JMSUF ) as decimal(10,2)) As DebitBalance     
                                 From RPHSTRANSRETRIV
                                 WHERE   JMDEBITCREDIT=1 and       ( JMACCOUNTKEY = '" & AccountID & "'
                                 AND  (JVALUEDATE between '" & CStr(Format(DateEditFrom.DateTime, "yyyy-MM-dd")) & "' and  '" & CStr(Format(DateEditTo.DateTime, "yyyy-MM-dd")) & "' ) 
                                 AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 "
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
            CreditBalance = " SELECT  cast(  sum( JMSUF ) as decimal(10,2)) As CreditBalance   
                                from RPHSTRANSRETRIV
                                WHERE   JMDEBITCREDIT=0 and       ( JMACCOUNTKEY = '" & AccountID & "'
                                AND  (JVALUEDATE between '" & CStr(Format(DateEditFrom.DateTime, "yyyy-MM-dd")) & "' and  '" & CStr(Format(DateEditTo.DateTime, "yyyy-MM-dd")) & "' ) 
                                 AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 "
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
        DateEditFrom.DateTime = CDate(DateTime.Now.AddYears(-20).ToString("yyyy-MM-dd 00:00:00.000"))
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
                                            " & "'" & FromSortText.Text & "', " & "
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

    Private Sub RepositoryItemOpen_Click(sender As Object, e As EventArgs) Handles RepositoryItemOpen.Click
        My.Forms.FinanceAccDetails.TextEditAccountKey.Text = CStr(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "AccountID"))
        FinanceAccDetails.Show()
    End Sub

    Private Sub RepositoryAccStatment_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles RepositoryAccStatment.ButtonClick
        'Try
        '    My.Forms.VouchersProccess.YyearText.Text = Format(DateEditFrom.DateTime, "yyyy")
        '    My.Forms.VouchersProccess.MmonthText.Text = Format(DateEditFrom.DateTime, "mm")
        '    My.Forms.VouchersProccess.SearchFleetID.EditValue = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "AccountID")
        '    '  My.Forms.VouchersProccess.TextDiff.Text = CStr(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Diff"))
        '    VouchersProccess.ShowDialog()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try

        My.Forms.FinancialAccountsDet.AccountKeyTextEdit.Text = CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "AccountID"), String)
        My.Forms.FinancialAccountsDet.SqlDataSource1.Queries(0).Parameters(0).Value = CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "AccountID"), String)
        My.Forms.FinancialAccountsDet.SqlDataSource1.Fill()
        My.Forms.FinancialAccountsDet.FullNameTextEdit.Select()
        FinancialAccountsDet.Show()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        GridView1.OptionsSelection.MultiSelect = True
        GridView1.SelectAll()
        GridView1.CopyToClipboard()
        GridView1.OptionsSelection.MultiSelect = False
    End Sub
End Class