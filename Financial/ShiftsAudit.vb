Imports DevExpress.XtraGrid.Views.Base

Public Class ShiftsAudit
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        RefreshShifts()

    End Sub

    Private Sub RefreshShifts()



        '  Dim i As Integer = GridView1.FocusedRowHandle


        Dim sql As New SQLControl
        Dim Sql1 As New SQLControl
        Dim StationTable As DataTable
        Dim MarketTable As DataTable

        Dim SqlString As String = " SELECT  W.REF3,W.ACCOUNTNAME,W.ACCOUNTKEY ,W.EMPNAME ,W.DETAILS ,W.STN_ID  ,W.SHIFTID ,S.NAME_AR as NAME_AR ,W.REF2 ,w.DATE3,w.DOCDATE ,M.USERID,U.USERNAME,W.DOCTYPEID ,L.[AuditDate] 
                                    From  [WALLET].[dbo].[DOCUMENTS] W
                                    left join [WALLET].[dbo].STATIONS S on W.STN_ID =S.STN_ID 
                                    left join [WALLET].[dbo].[DOCSHIFTMATCH] M  on M.ID = W.REF3  
                                    left join [WALLET].[dbo].USERS U on M.USERID = U.USERID
                                    LEFT JOIN [CRM].dbo.ShiftAuditLogs L ON W.REF3= L.[ShiftID] 
                                    WHERE  W.STN_ID>0 AND W.REF3 <>999999999  and NOT EXISTS
	                                       (SELECT DOCID FROM [CRM].[dbo].[ShiftsAudit] C WHERE W.REF3 = C.DOCID)
                                    Order by DOCID DESC "
        sql.CRMRunQuery(SqlString)
        StationTable = sql.SQLDS.Tables(0)


        Dim SqlString2 As String = " SELECT   W.REF3,W.ACCOUNTNAME,W.ACCOUNTKEY ,W.EMPNAME ,W.DETAILS ,W.STN_ID  ,W.SHIFTID ,z.NAME_AR as NAME_AR  ,W.REF2 ,w.DATE3,w.DOCDATE ,M.USERID,U.USERNAME,W.DOCTYPEID ,L.[AuditDate],z.NAME_AR
From  [WALLET].[dbo].[DOCUMENTS] W
Left join [WALLET].[dbo].[MARKETDOCSHIFTMATCH] M  on M.ID = W.REF3  
Left join [WALLET].[dbo].USERS U on M.USERID = U.USERID
Left join [WALLET].[dbo].MARKETS  z on z.MARKET_ID   = w.STN_ID 
LEFT JOIN [CRM].dbo.ShiftAuditLogs L ON W.REF3= L.[ShiftID] 
        WHERE L.[AuditDate] is not null and W.ACCOUNTKEY =111195 and   W.STN_ID>0 AND W.REF3 <>999999999  and NOT EXISTS
	   (SELECT DOCID  FROM [CRM].[dbo].[ShiftsAudit] C WHERE W.REF3 = C.DOCID and C.ShiftType ='asd' )
order by DOCID DESC "
        Sql1.CRMRunQuery(SqlString2)
        MarketTable = Sql1.SQLDS.Tables(0)

        MarketTable.Merge(StationTable)

        GridShiftList.DataSource = MarketTable


    End Sub

    Private Sub RepositoryGetDetails_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryGetDetails.ButtonClick
        AuditShiftID()
    End Sub
    Private Sub AuditShiftID()

        Try
            Dim DocID As Integer
            DocID = CInt(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "REF3"))
            Dim ACCOUNTKEY As Integer = CInt(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ACCOUNTKEY"))
            Dim ShiftType As String = "Station"
            If ACCOUNTKEY = 111195 Then ShiftType = "ASD"
            Dim sql As New SQLControl
            Dim SqlString As String = "  Insert into [CRM].[dbo].[ShiftsAudit] 
                                        (docid,AuditDate,AuditUser,ShiftType) values
                                        (" & DocID & ", getdate(), '" & GlobalVariables.UserIDString & "', '" & ShiftType & "' )  "

            sql.CRMRunQuery(SqlString)





            GridView1.DeleteRow(GridView1.FocusedRowHandle)
            DocID = CInt(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "REF3"))
            GetDetails(DocID)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GetDetails(DocId As Integer)
        Dim sql As New SQLControl
        Dim SqlString As String = " SELECT  [ID] ,[DOCID],[STATUS],[ACCOUNTKEY] as ACCOUNTKEYDetails,[ACCOUNTNAME],
                                            [REFERENCE],[VALUEDATE],[AMOUNT],[AMOUNTFC],[CURRCODE],[CURRRATE],
                                            [DETAILS] ,[USERID]  
                                    FROM [WALLET].[dbo].[JURNALMATCH]
                                    Where DOCID=" & DocId & "   Order by ID desc"
        sql.CRMRunQuery(SqlString)
        GridJournals.DataSource = sql.SQLDS.Tables(0)
    End Sub
    Private Sub GetMarketDetails(DocId As Integer)
        Dim sql As New SQLControl
        Dim SqlString As String = " SELECT  [ID] ,[DOCID],[STATUS],[ACCOUNTKEY] as ACCOUNTKEYDetails,[ACCOUNTNAME],
                                            [REFERENCE],[VALUEDATE],[AMOUNT],[AMOUNTFC],[CURRCODE],[CURRRATE],
                                            [DETAILS]      ,[USERID] 
                                    FROM [WALLET].[dbo].[MARKETJURNALMATCH]
                                    Where DOCID=" & DocId & "   Order by ID desc"
        sql.CRMRunQuery(SqlString)
        GridJournals.DataSource = sql.SQLDS.Tables(0)
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim DocID As Integer = CInt(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "REF3"))
        Dim ACCOUNTKEY As Integer = CInt(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ACCOUNTKEY"))
        If ACCOUNTKEY = 111195 Then
            GetMarketDetails(DocID)
        Else
            GetDetails(DocID)
        End If
    End Sub

    Private Sub ShiftsAudit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshShifts()
        Me.KeyPreview = True
    End Sub

    Private Sub GridShiftList_Click(sender As Object, e As EventArgs) Handles GridShiftList.Click

    End Sub

    Private Sub GridShiftList_KeyDown(sender As Object, e As KeyEventArgs) Handles GridShiftList.KeyDown
        If e.KeyCode = Keys.F2 Then
            AuditShiftID()
        ElseIf e.KeyCode = Keys.F5 Then
            RefreshShifts()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GridView1.DeleteRow(GridView1.FocusedRowHandle)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim i As Integer
        For i = 0 To 100
            Try
                Dim DocID As Integer
                DocID = CInt(Me.GridView1.GetRowCellValue(i, "REF3"))
                Dim ACCOUNTKEY As Integer = CInt(Me.GridView1.GetRowCellValue(i, "ACCOUNTKEY"))
                Dim ShiftType As String = "Station"
                If ACCOUNTKEY = 111195 Then ShiftType = "ASD"
                Dim sql As New SQLControl
                Dim SqlString As String = "  Insert into [CRM].[dbo].[ShiftsAudit] 
                                        (docid,AuditDate,AuditUser,ShiftType) values
                                        (" & DocID & ", getdate(), '" & GlobalVariables.UserIDString & "', '" & ShiftType & "' )  "

                sql.CRMRunQuery(SqlString)
                'GridView1.DeleteRow(GridView1.FocusedRowHandle)
                'DocID = CInt(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "REF3"))
                'GetDetails(DocID)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Next

    End Sub
End Class