Public Class OrbakSumForSort
    Private Sub OrbakSumForSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class