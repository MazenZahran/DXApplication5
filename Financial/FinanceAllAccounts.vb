Imports System.Data.SqlClient
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FinanceAllAccounts
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        LoadData()
    End Sub


    Private Sub LoadData()

        Dim AccountFrom As String = CStr(AccFrom.Text)
        If String.IsNullOrEmpty(AccountFrom) Then AccountFrom = "Null"

        Dim AccountTo As String = CStr(AccTo.Text)
        If String.IsNullOrEmpty(AccountTo) Then AccountTo = "Null"

        Dim AccSortFrom As String = CStr(SortFrom.Text)
        If String.IsNullOrEmpty(AccSortFrom) Then AccSortFrom = "Null"

        Dim AccSortTo As String = CStr(SortTo.Text)
        If String.IsNullOrEmpty(AccSortTo) Then AccSortTo = "Null"

        Dim AccFilter As String = CStr(AccountsFilter.Text)
        If String.IsNullOrEmpty(AccFilter) Then AccFilter = "Null"

        Dim Sql As New SQLControl
        Dim SQlString As String
        SQlString = "  Select [ID], AccountID,[FullName],[SortGroup],AccAudit,[Address],[City],[Zip],[Country],[Phone],[Fax] ,[Filter],[Details],
                              [MaxCredit],[CustomerNote] ,[BankCode],[BranchCode],[BankAccount],[CostCode],[EMail],[SbPhone],[SPhone]
                              ,convert(datetime,'2000-01-01') As AccLastTrans , case when Status=1 then 'InActive' when Status=2 then 'Active' when Status=0 then 'Deleted'  end  as AccStatus
                       From 
	                    (
	                        SELECT  [ALHUDA].[dbo].[Accounts].* ,ISNULL(FinanceAccounts.AccAudit,0) as AccAudit,status,
			                         CONVERT(INT,CASE WHEN IsNumeric(CONVERT(VARCHAR(12), [Accounts].AccountKey)) = 1 THEN CONVERT(VARCHAR(12),[Accounts].AccountKey) ELSE 0 END) as AccountID
	                        FROM [ALHUDA].[dbo].[Accounts]
		                         Left join [CRM].[dbo].[FinanceAccounts]
		                         on [ALHUDA].[dbo].[Accounts].AccountKey=[CRM].[dbo].[FinanceAccounts].AccountKey
		                         left join [ho].[HO_DATA].[dbo].[fleets]
		                         on [ALHUDA].[dbo].[Accounts].AccountKey=[code]
	                             ) a
                       Where AccountID > 0 "

        If CStr(AccountFrom) <> "Null" And CStr(AccountTo) <> "Null" Then
            SQlString = SQlString + " And ( AccountID between " & AccountFrom & " and " & AccountTo & ")    "
        End If

        If CStr(AccSortFrom) <> "Null" And CStr(AccSortTo) <> "Null" Then
            SQlString = SQlString + " And ( SortGroup between " & AccSortFrom & " and " & AccSortTo & ")  "
        End If

        If CStr(AccFilter) <> "Null" Then
            SQlString = SQlString + " And ( Filter = '" & AccFilter & "')  "
        End If

        '   MsgBox(CheckEditAudit.CheckState)
        If CheckEditAudit.CheckState = 1 Then
            SQlString = SQlString + " And AccAudit= 'True' "
        ElseIf CheckEditAudit.CheckState = 0 Then
            SQlString = SQlString + " And AccAudit = 'False' "
        End If

        If CheckEditNewCustAcc.Checked = True Then
            SQlString = SQlString + " And [ID] > 13400  "
        End If

        SQlString = SQlString + " order by AccountID "

        Sql.CRMRunQuery(SQlString)
        GridControl1.DataSource = Sql.SQLDS.Tables(0)

        Dim i As Integer
        Dim SqlCmd As SqlCommand
        Dim SQLDA As SqlDataAdapter
        Dim SQLDS As DataSet
        Dim SqlConWizCount As New SqlConnection With {.ConnectionString = WizCountString}
        SqlConWizCount.Open()
        For i = 0 To Me.GridView1.RowCount - 1
            Try
                Dim LastDate As String
                Dim AccountKey As String = CType(GridView1.GetRowCellValue(i, "AccountID"), String)
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
            SqlConWizCount.Close()
        Next

        GridView1.BestFitColumns()


    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick
        My.Forms.FinanceAccDetails.TextEditAccountKey.Text = CStr(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "AccountID"))
        FinanceAccDetails.Show()
    End Sub

    Private Sub CRMAccountFileAudit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GridControl1.ShowPrintPreview()
    End Sub


    Private Function GetFleetStatus(FleetID As String) As String
        Try
            Dim sql As New SQLControl
            Dim SqlOrbak As String = "Select  case when Status=1 then 'InActive' when Status=2 then 'Active' when Status=0 then 'Deleted'  end as Status from fleets where  code='" & FleetID & "'"
            Dim FleetStatus As String
            sql.RunQuery(SqlOrbak)
            FleetStatus = CType(sql.SQLDS.Tables(0).Rows(0).Item("Status"), String)
            GetFleetStatus = FleetStatus
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Private Function GetLastTransDate(AccountID As String) As String

        Try
            Dim LastDate As String
            Dim query As String = "    select top 1 JVALUEDATE  from [ALHUDA].[dbo].RPHSTRANSRETRIV      
                                       where  JMACCOUNTKEY     ='" & AccountID & "'
                                       order by  jmtransid   desc"

            Dim SqlCmd As SqlCommand
            Dim SQLDA As SqlDataAdapter
            Dim SQLDS As DataSet
            Dim SqlConWizCount As New SqlConnection With {.ConnectionString = WizCountString}
            SqlConWizCount.Open()
            SqlCmd = New SqlCommand(query, SqlConWizCount)
            SQLDA = New SqlDataAdapter(SqlCmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)

            LastDate = SQLDS.Tables(0).Rows(0).Item("JVALUEDATE").ToString


            SqlConWizCount.Close()

            Return LastDate
        Catch ex As Exception
            Return ""
            MsgBox(ex.ToString)
        End Try


    End Function



    Private Sub GridView1_CustomDrawCell(ByVal sender As Object,
ByVal e As RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell
        Dim ImageTrue As Image = My.Resources.TrueIcon
        Dim ImageFalse As Image = My.Resources.FalseIcon
        'Dim ImageDelete As Image = Image.FromFile(Application.StartupPath + "\..\..\" + "Delete.jpg")
        Dim View As GridView = CType(sender, GridView)
        If e.Column.FieldName <> "AccStatus" Then
            Return
        End If
        Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("AccStatus"))
        If category = "InActive" Then
            e.Graphics.DrawImage(ImageFalse, e.Bounds.Location)
            e.DisplayText = "موقوف"
        End If
        If category = "Active" Then
            e.Graphics.DrawImage(ImageTrue, e.Bounds.Location)
            e.DisplayText = "فعال"
        End If
        If category = "Deleted" Then
            '  e.Graphics.DrawImage(ImageDelete, e.Bounds.Location)
            e.DisplayText = "محذوف"
        End If

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridView1_CustomSummaryCalculate(sender As Object, e As CustomSummaryEventArgs) Handles GridView1.CustomSummaryCalculate



        Dim discontinuedProductsCount As Integer
        Dim totalPrice As Double
        Dim view As GridView = TryCast(sender, GridView)
        Dim summaryID As Integer = Convert.ToInt32((TryCast(e.Item, GridSummaryItem)).Tag)

        If e.SummaryProcess = CustomSummaryProcess.Start Then
            discontinuedProductsCount = 0
            totalPrice = 0
        End If

        If e.SummaryProcess = CustomSummaryProcess.Calculate Then

            Select Case summaryID
                Case 1


                    Dim isDiscontinued As Boolean = Convert.ToBoolean(e.FieldValue)
                    If isDiscontinued = True Then
                        discontinuedProductsCount += 1
#Disable Warning BC42019 ' Operands of type Object used for operator
                        e.TotalValue += discontinuedProductsCount

                    End If
                Case 2
                    '  Dim unitsInStock As Integer = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "UnitsInStock"))
                    totalPrice += e.RowHandle
                    e.TotalValue = Format(ColAccAudit.SummaryItem.SummaryValue / totalPrice, "P0")

            End Select
        End If

        If e.SummaryProcess = CustomSummaryProcess.Finalize Then
            Select Case summaryID
                Case 2
                    e.TotalValue = " نسبة المدقق " & e.TotalValue
            End Select
#Enable Warning BC42019 ' Operands of type Object used for operator
        End If
    End Sub
End Class