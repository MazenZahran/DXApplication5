Public Class ShiftAuditReports
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        RefreshDetails(Format(DateEdit1.DateTime, "yyyy-MM-dd"), Format(DateEdit2.DateTime, "yyyy-MM-dd"))
    End Sub
    Private Sub RefreshDetails(DateFrom As String, DateTo As String)
        Try
            Dim _Table As DataTable
            Dim _Table2 As DataTable
            Dim Sql As New SQLControl
            Dim Sql2 As New SQLControl
            Dim SqlString As String
            Dim SqlString2 As String
            SqlString = "SELECT  W.REF3,W.ACCOUNTNAME,W.ACCOUNTKEY ,W.EMPNAME ,W.DETAILS ,W.STN_ID  ,
                        W.SHIFTID ,S.NAME_AR as NAME_AR ,W.REF2 ,w.DATE3,w.DOCDATE ,M.USERID,U.USERNAME,W.DOCTYPEID ,
                        L.[AuditDate] ,DATEDIFF(DAY, w.DOCDATE, L.[AuditDate]) AS DateDiff
                        From  [WALLET].[dbo].[DOCUMENTS] W
                        left join [WALLET].[dbo].STATIONS S on W.STN_ID =S.STN_ID 
                         left join [WALLET].[dbo].[DOCSHIFTMATCH] M  on M.ID = W.REF3  
                        left join [WALLET].[dbo].USERS U on M.USERID = U.USERID
                        LEFT JOIN [CRM].dbo.ShiftAuditLogs L ON W.REF3= L.[ShiftID] 
                        WHERE  W.STN_ID>0 AND W.REF3 <>999999999  AND AuditDate BETWEEN '" & DateFrom & " 00:00:00' AND '" & DateTo & " 23:59:59'"
            Sql.WalletRunQuery(SqlString)
            _Table = Sql.SQLDS.Tables(0)


            SqlString2 = " Select  w.REF3,W.ACCOUNTNAME,W.ACCOUNTKEY ,W.EMPNAME ,W.DETAILS ,W.STN_ID  ,
                        W.SHIFTID ,z.NAME_AR as NAME_AR  ,W.REF2 ,w.DATE3,w.DOCDATE ,M.USERID,U.USERNAME,W.DOCTYPEID ,
                        L.[AuditDate],DATEDIFF(DAY, w.DOCDATE, L.[AuditDate]) AS DateDiff
                        From  [WALLET].[dbo].[DOCUMENTS] W
                        Left join [WALLET].[dbo].[MARKETDOCSHIFTMATCH] M  on M.ID = W.REF3  
                        Left join [WALLET].[dbo].USERS U on M.USERID = U.USERID
                        Left join [WALLET].[dbo].MARKETS  z on z.MARKET_ID   = w.STN_ID 
                        LEFT JOIN [CRM].dbo.ShiftAuditLogs L ON W.REF3= L.[ShiftID] 
                        WHERE  W.ACCOUNTKEY =111195 and   W.STN_ID>0 AND W.REF3 <>999999999 AND AuditDate BETWEEN '" & DateFrom & " 00:00:00' AND '" & DateTo & " 23:59:59'"
            Sql2.WalletRunQuery(SqlString2)
            _Table2 = Sql2.SQLDS.Tables(0)

            GridControl1.DataSource = _Table


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub RepositoryGetDetails_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

    End Sub
End Class