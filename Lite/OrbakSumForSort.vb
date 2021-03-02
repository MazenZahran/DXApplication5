Public Class OrbakSumForSort
    Private Sub OrbakSumForSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
        'TODO: This line of code loads data into the 'WizCountDataSet.AccSortNames' table. You can move, or remove it, as needed.
        Me.AccSortNamesTableAdapter.Fill(Me.WizCountDataSet.AccSortNames)
        ComboMonth.EditValue = CInt(Format(Today, "MM")) - 1
        ComboYear.EditValue = CInt(Format(Today, "yyyy"))

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GetData(ComboMonth.Text, ComboYear.Text, CStr(SearchSort.EditValue))
    End Sub
    Private Sub GetData(MMonth As String, Yyear As String, Sort As String)
        If String.IsNullOrEmpty(MMonth) Or String.IsNullOrEmpty(Yyear) Or String.IsNullOrEmpty(Sort) Then
            MsgBox("يجب تعبئة كل البيانات المطلوبة")
            Exit Sub
        End If

        Select Case CStr(RadioFromData.EditValue)
            Case "1"
                Try
                    Dim sql As New SQLControl
                    Dim SqlString As String = "   select S.FullName , FleetCode ,  OrpakBalance , S.SortGroup, c.DebitBalance,SPhone,EMail,EmployeeNo, (OrpakBalance - DebitBalance) as Diff from 
                                          (
                                              select A.FullName , FleetCode , SUM(TotalSale) as OrpakBalance , A.SortGroup,A.SPhone,A.EMail , F.EmployeeNo 
                                                     FROM [CRM].[dbo].[DATA] D
                                                     left join ALHUDA.dbo.Accounts  A
                                                     on  A.AccountKey = D.FleetCode 
                                                     left join [CRM].[dbo].[FinanceAccounts] F
                                                     on F.AccountKey  = D.FleetCode 
                                                     where DatePart(MONTH, TransDate)='" & MMonth & "' and DatePart(year, TransDate)='" & Yyear & "' and SortGroup ='" & Sort & "'
                                                     group by FleetCode , FullName ,SortGroup,SPhone,EMail,EmployeeNo
                                          ) S
                                            left join 
                                          (
                                             SELECT    cast(  sum( JMSUF ) as decimal(10,2)) As DebitBalance   , R.JTRANSDEBID  
                                                       From ALHUDA.dbo. RPHSTRANSRETRIV R
                                                       WHERE   JMDEBITCREDIT=1 and       ( ASORTGROUP='" & Sort & "'
                                                               AND  ( DatePart(MONTH, JVALUEDATE)='" & MMonth & "' and DatePart(year, JVALUEDATE)='" & Yyear & "' ) 
                                                               AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3   
                                                       group by JTRANSDEBID 
                                          ) c
                                            on S.FleetCode=c.JTRANSDEBID "
                    sql.CRMRunQuery(SqlString)
                    GridControl1.DataSource = sql.SQLDS.Tables(0)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case "2"
                Try
                    Dim sql As New SQLControl
                    Dim SqlString As String = "select S.FullName , [Code] as FleetCode ,  OrpakBalance , S.SortGroup, c.DebitBalance,SPhone,EMail,EmployeeNo, (OrpakBalance - DebitBalance) as Diff from 
                                          (
                                              select A.FullName , x.Code AS Code , SUM(sale) as OrpakBalance , A.SortGroup,A.SPhone,A.EMail , F.EmployeeNo 
                                                     FROM HO.[HO_DATA].[dbo].[transactions] D
                                                       left join HO.[HO_DATA].[dbo].[fleets] x
                                                        on D.[fleet_id]=x.id
                                                     left join ALHUDA.dbo.Accounts  A
                                                     on  A.AccountKey = x.code 
                                                     left join [CRM].[dbo].[FinanceAccounts] F
                                                     on F.AccountKey  = x.code 
                                                     where DatePart(MONTH, [date])='" & MMonth & "' and DatePart(year, [date])='" & Yyear & "' and SortGroup ='" & Yyear & "'
                                                     group by code , FullName ,SortGroup,SPhone,A.EMail,EmployeeNo
                                          ) S
                                            left join 
                                          (
                                             SELECT    cast(  sum( JMSUF ) as decimal(10,2)) As DebitBalance   , R.JTRANSDEBID  
                                                       From ALHUDA.dbo. RPHSTRANSRETRIV R
                                                       WHERE   JMDEBITCREDIT=1 and       ( ASORTGROUP='" & Sort & "'
                                                               AND  ( DatePart(MONTH, JVALUEDATE)='" & MMonth & "' and DatePart(year, JVALUEDATE)='" & Yyear & "' ) 
                                                               AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3   
                                                       group by JTRANSDEBID 
                                          ) c
                                            on S.Code=c.JTRANSDEBID  "
                    sql.CRMRunQuery(SqlString)
                    GridControl1.DataSource = sql.SQLDS.Tables(0)
                Catch ex As Exception

                End Try
        End Select








    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GridControl1.ShowPrintPreview()
    End Sub

    Private Sub RepositoryOpenAccount_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryOpenAccount.ButtonClick
        My.Forms.FinanceAccDetails.TextEditAccountKey.Text = CStr(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FleetCode"))
        FinanceAccDetails.ShowDialog()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Try

            Dim WalletTable As New DataTable
            Dim ColId As New DataColumn With {
                .DataType = System.Type.GetType("System.Int32"),
                .AutoIncrement = True,
                .AutoIncrementSeed = 1,
                .AutoIncrementStep = 1
            }

            With WalletTable
                .Columns.Add(ColId)
                .Columns.Add("ColAccID", GetType(Integer))
                .Columns.Add("ColCheqNo", GetType(String))
                .Columns.Add("ColCheqAccDate", GetType(String))
                .Columns.Add("ColAmount", GetType(Decimal))
                .Columns.Add("ColCurrName", GetType(String))
                .Columns.Add("ColCurrPrice", GetType(Decimal))
                .Columns.Add("ColAmountNIS", GetType(Decimal))
                .Columns.Add("ColNotes", GetType(String))
            End With

            Dim RowsCount As Integer = GridView1.RowCount
            For i = 0 To RowsCount - 1
                Dim R As DataRow = WalletTable.NewRow
                R("ColAccID") = Me.GridView1.GetRowCellValue(i, "FleetCode").ToString
                R("ColCheqNo") = "0"
                R("ColCheqAccDate") = Format(CDate(JournalDate.DateTime), "yyyy-MM-dd")
                R("ColAmount") = -1 * CDec(Me.GridView1.GetRowCellValue(i, "DebitBalance").ToString)
                R("ColCurrName") = "NIS"
                R("ColCurrPrice") = 1
                R("ColAmountNIS") = -1 * CDec(Me.GridView1.GetRowCellValue(i, "DebitBalance").ToString)
                R("ColNotes") = "دفعة"
                WalletTable.Rows.Add(R)
            Next

            Dim RR As DataRow = WalletTable.NewRow
            RR("ColAccID") = SearchLookUpEdit1.EditValue
            RR("ColCheqNo") = "0"
            RR("ColCheqAccDate") = Format(CDate(JournalDate.DateTime), "yyyy-MM-dd")
            RR("ColAmount") = ColDebitBalance.SummaryItem.SummaryValue
            RR("ColCurrName") = "NIS"
            RR("ColCurrPrice") = 1
            RR("ColAmountNIS") = ColDebitBalance.SummaryItem.SummaryValue
            RR("ColNotes") = "دفعة"
            WalletTable.Rows.Add(RR)

            Dim ClipText As String = String.Empty
            For Each row As DataRow In WalletTable.Rows
                Dim ClipRow As String = String.Empty
                ClipRow = String.Empty

                For Each col As DataColumn In WalletTable.Columns
                    If Not String.IsNullOrEmpty(ClipRow) Then
                        ClipRow += ControlChars.Tab
                    End If

                    ClipRow += row(col.ColumnName).ToString
                Next

                ClipText += ClipRow + ControlChars.NewLine
            Next

            Clipboard.SetText(ClipText)
        Catch ex As Exception
            MsgBox("لا يمكن ترحيل السند")
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RepositoryAccStatment_Click(sender As Object, e As EventArgs) Handles RepositoryAccStatment.Click
        Try
            My.Forms.VouchersProccess.YyearText.Text = ComboYear.Text
            My.Forms.VouchersProccess.MmonthText.Text = ComboMonth.Text
            My.Forms.VouchersProccess.SearchFleetID.EditValue = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FleetCode")
            '  My.Forms.VouchersProccess.TextDiff.Text = CStr(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Diff"))
            VouchersProccess.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        GridView1.OptionsSelection.MultiSelect = True
        GridView1.SelectAll()
        GridView1.CopyToClipboard()
        GridView1.OptionsSelection.MultiSelect = False
    End Sub

    Private Sub SearchSort_EditValueChanged(sender As Object, e As EventArgs) Handles SearchSort.EditValueChanged
        Select Case SearchSort.EditValue
            Case 2007
                SearchLookUpEdit1.EditValue = 3965
            Case 2005
                SearchLookUpEdit1.EditValue = 3838
            Case 2006
                SearchLookUpEdit1.EditValue = 1736
            Case 2012
                SearchLookUpEdit1.EditValue = 4092
            Case 2013
                SearchLookUpEdit1.EditValue = 1037
            Case 2014
                SearchLookUpEdit1.EditValue = 4460
        End Select
    End Sub

    Private Sub ComboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMonth.SelectedIndexChanged
        GetDate()
    End Sub
    Private Sub GetDate()
        Try
            Dim days As Integer = System.DateTime.DaysInMonth(CInt(ComboYear.EditValue), CInt(ComboMonth.EditValue))
            JournalDate.DateTime = CDate(ComboYear.Text & "-" & ComboMonth.Text & "-" & days)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboYear.SelectedIndexChanged
        GetDate()
    End Sub
End Class