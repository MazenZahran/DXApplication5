Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraCharts
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraEditors

Public Class OrpakCardsQuery
    ReadOnly cn As New SqlConnection(OrbakString)
    ReadOnly cmd As New SqlCommand
    ReadOnly da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim i As Integer
    Dim SQlText As String
    Dim sql As New SQLControl
    Dim sql2 As New SQLControl

    Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub SearchCards(FCard As String, FPlate As String, FPlatePart As String, FCardCode As String, FActive As Boolean)



        Try
            If Card.Text = "" And Plate.Text = "" And PlatePart.Text = "" And CardCode.Text = "" Then Exit Sub

            Dim SQLString As String = " SELECT means.id, means.name ,  means.string,  means.status, means.plate,fleets.name as FleetName  " &
                                       " FROM      means,fleets" &
                                       " where means.fleet_id = fleets.id order by means.id desc "

            If FCard <> "" Then SQLString = SQLString + " and means.name = " & "'" & FCard & "'"
            If FPlate <> "" Then SQLString = SQLString + " and means.plate = " & "'" & FPlate & "'"
            If FPlatePart <> "" Then SQLString = SQLString + " and means.plate like " & "'%" & FPlatePart & "%'"
            If FCardCode <> "" Then SQLString = SQLString + " and means.string = " & "'" & FCardCode & "'"
            If FActive = True Then SQLString = SQLString + " and means.status=2 "

            sql.RunQuery(SQLString)
        Catch ex As Exception

        End Try




    End Sub

    Private Sub SearchCardsByID(CardID As Integer)

        Try
            Dim SQLString As String = " SELECT  means.ID, means.name ,  means.string, means.type, means.status, means.[rule], means.plate, means.fleet_id, means.available_amount as CardAmount," &
                           " means.update_timestamp,means.opos_prompt_for_odometer, means.day_volume, means.week_volume, means.month_volume, means.day_money, " &
                           " means.week_money,means.month_money , means.day_visits, means.week_visits, means.month_visits, means.issued_date, means.last_used, " &
                           " fleets.code, group_rules.Description,fleets.name as FleetName,fleets.status as Fstatus,fleets.available_amount,fleets.acctyp" &
                           " FROM      means,group_rules,fleets" &
                           " where means.[rule] = group_rules.id" &
                           " and means.fleet_id = fleets.id"

            If CardID.ToString <> "" Then SQLString = SQLString + " and means.id = " & CardID

            sql.RunQuery(SQLString)
        Catch ex As Exception

        End Try




    End Sub

    Private Sub SearchFleetsLogs()
        Dim Table1 As New DataTable
        Dim Table2 As New DataTable
        Dim AllData As New DataTable

        Try
            Dim SQLString As String = " SELECT [date],field1,field2,field6,field7,field8 " &
                                      " FROM      history_log_t where [field5] = '" & TextFleetID.Text & "' order by [date] desc"

            ' MsgBox(SQLString)

            sql2.RunQuery(SQLString)

            Dim s As New DataSet()
            Dim Table As New DataTable
            Table1 = sql2.SQLDS.Tables(0)
            AllData.Merge(Table1)
        Catch ex As Exception

        End Try

        If CheckEditOldData.Checked = True Then
            Try
                Dim SQLString As String = " SELECT [date],field1,field2,field6,field7,field8 " &
                                          " FROM      history_log_t where [field5] = '" & TextFleetID.Text & "' order by [date] desc"

                sql2.OldOrpakRunQuery(SQLString)

                Dim s As New DataSet()
                Dim Table As New DataTable
                Table2 = sql2.SQLDS.Tables(0)
                AllData.Merge(Table2)
            Catch ex As Exception

            End Try
        End If



        GridControl4.DataSource = AllData

    End Sub

    Private Sub AccounStatment(FromDate As String, ToDate As String)

        Try
            Dim AccountStatmentss = " SELECT       JVALUEDATE  AS ALIAS6F,    JREFERANCE  AS ALIAS8F,  JREF2  AS ALIAS9F,  JDESCRIPTION  AS ALIAS10F,   CASE JMDEBITCREDIT WHEN 1 THEN  JMSUF  ELSE 0 END AS ALIAS12F_DEB, CASE JMDEBITCREDIT WHEN 0 THEN  JMSUF  ELSE 0 END AS ALIAS12F_CR " _
                            & " from RPHSTRANSRETRIV" _
                            & " WHERE          ( JMACCOUNTKEY = '" & TextFleetID.Text & "'  AND ('" & ToDate & "' >= JVALUEDATE) AND ('" & FromDate & "' <= JVALUEDATE) AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 " _
                            & " ORDER BY                JMACCOUNTKEY ASC  , JVALUEDATE ASC  , JMID ASC "

            Dim DebitBalance = " SELECT   cast(  sum( JMSUF ) as decimal(10,2)) as Debit    " _
            & " from RPHSTRANSRETRIV" _
            & " WHERE   JMDEBITCREDIT=1 and       ( JMACCOUNTKEY = '" & TextFleetID.Text & "'  AND ('" & FromDate & "' > JVALUEDATE)  AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 "

            Dim CreditBalance = " SELECT   cast(  sum( JMSUF ) as decimal(10,2))  as Credit " _
            & " from RPHSTRANSRETRIV" _
            & " WHERE   JMDEBITCREDIT=0 and       ( JMACCOUNTKEY = '" & TextFleetID.Text & "'  AND ('" & FromDate & "' > JVALUEDATE)  AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 "

            sql.WizCountRunQuery(AccountStatmentss)

            GridControl13.DataSource = sql.SQLDS.Tables(0)
            '    TryCast(GridControl13.MainView, GridView).Columns(0).Caption = "التاريخ"
            '   TryCast(GridControl13.MainView, GridView).Columns(1).Caption = "سند 1"
            '   TryCast(GridControl13.MainView, GridView).Columns(2).Caption = "سند 2"
            '  TryCast(GridControl13.MainView, GridView).Columns(3).Caption = "البيان"
            '  TryCast(GridControl13.MainView, GridView).Columns(4).Caption = "مدين"
            ' TryCast(GridControl13.MainView, GridView).Columns(5).Caption = "دائن"

            Dim DebitBalanceString As String = "0", CreditBalanceString As String = "0"
            sql.WizCountRunQuery(DebitBalance)
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(i).Item("Debit")) Then DebitBalanceString = CType(sql.SQLDS.Tables(0).Rows(i).Item("Debit"), String)

            sql.WizCountRunQuery(CreditBalance)
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(i).Item("Credit")) Then CreditBalanceString = CType(sql.SQLDS.Tables(0).Rows(i).Item("Credit"), String)

            Dim DrBalance, CrBalance As Integer
            DrBalance = 0 : CrBalance = 0
            Dim Balance = CInt(DebitBalanceString) - CInt(CreditBalanceString)
            If Balance >= 0 Then DrBalance = Balance Else CrBalance = -1 * Balance

            GridView3.AddNewRow()
            Dim rowHandle As Integer = GridView3.GetRowHandle(GridView3.DataRowCount)
            If GridView3.IsNewItemRow(rowHandle) Then
                GridView3.SetRowCellValue(rowHandle, GridView3.Columns(0), FromDate)
                GridView3.SetRowCellValue(rowHandle, GridView3.Columns(1), 0)
                GridView3.SetRowCellValue(rowHandle, GridView3.Columns(2), 0)
                GridView3.SetRowCellValue(rowHandle, GridView3.Columns(3), "رصيد مدور")
                GridView3.SetRowCellValue(rowHandle, GridView3.Columns(4), DrBalance)
                GridView3.SetRowCellValue(rowHandle, GridView3.Columns(5), CrBalance)
            End If

            If GridView3.Columns.Count = 7 Then
                GridView3.Columns("ALIAS6F").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                GridView3.UpdateCurrentRow()
            Else
                GridView3.Columns("ALIAS6F").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                GridView3.UpdateCurrentRow()
                OptimizeGrid()
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Checks()

        Try
            Dim SQLString As String = "select top 100 * FROM  [WALLET].[dbo].[CHEQUES] where  [CHEQNUMBER] is not null  "
            If TextFleetName.Text <> "" Then SQLString = SQLString + " and  [CHEQUES].[DETAILS] = '" & TextFleetName.Text & "'"
            SQLString = SQLString + "order by [VALUEDATE] DESC "
            sql.WizCountRunQuery(SQLString)
            GridControl1.DataSource = sql.SQLDS.Tables(0)
        Catch ex As Exception

        End Try



    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs)
        GridControl11.ShowPrintPreview()

    End Sub

    Private Sub CraetMonthlyChart(CardID As Integer)

        Try
            Dim SQLString As String = " SELECT   SUM(SALE),SUM(quantity) AS Quant , DATEPART(month, date) as Month  FROM transactions" &
                                  " WHERE (DatePart(Year, Date) = " & TextYear.Text & ")  And mean_id = " & " '" & CardID & "'" & " " & " GROUP BY DATEPART(month, date) order by DATEPART(month, date)"
            sql.RunQuery(SQLString)
            If sql.SQLDS.Tables.Count = 0 Then Exit Sub
            GridControl2.DataSource = sql.SQLDS.Tables(0)

            ChartControl1.DataSource = sql.SQLDS.Tables(0)
            ChartControl1.SeriesDataMember = "Month"
            ChartControl1.SeriesTemplate.ArgumentDataMember = "Month"
            ChartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Quant"})

            ' Specify the template's series view.
            ChartControl1.SeriesTemplate.View = New StackedBarSeriesView()
            ' Specify the template's name prefix.
            ChartControl1.SeriesNameTemplate.BeginText = "Month: "
            '  series1.Points.Add(New SeriesPoint("EmpID", i.Item("EmpID")))
            'series1.Points.Add(New SeriesPoint("Name", i.Item("Name")))
            'Set series members names for the X And Y values
            'ChartControl1.Series["Series 1"].XValueMember = "Name"
            'ChartControl1.Series["Series 1"].YValueMembers = "Sales"
            ' ChartControl1.Series.Add("Nameofthedata")
        Catch ex As Exception

        End Try



    End Sub

    Private Sub CardsQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HO_DATADataSet.group_rules' table. You can move, or remove it, as needed.
        '   Me.Group_rulesTableAdapter.Fill(Me.HO_DATADataSet.group_rules)
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        '     Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
        'TODO: This line of code loads data into the 'ALHUDADataSet.Accounts' table. You can move, or remove it, as needed.
        '  Me.AccountsTableAdapter.Fill(Me.ALHUDADataSet.Accounts)
        'TODO: This line of code loads data into the 'ALHUDADataSet.Accounts' table. You can move, or remove it, as needed.
        'Me.AccountsTableAdapter.Fill(Me.ALHUDADataSet.Accounts)
        'TODO: This line of code loads data into the 'ALHUDADataSet.Accounts' table. You can move, or remove it, as needed.
        'Me.AccountsTableAdapter.Fill(Me.ALHUDADataSet.Accounts)
        'TODO: This line of code loads data into the 'ALHUDADataSet.Accounts' table. You can move, or remove it, as needed.
        '   Me.AccountsTableAdapter.Fill(Me.ALHUDADataSet.Accounts)

        Try
            CheckEdit2.Checked = True
            Dim CurrYear = DateTime.Now.ToString("yyyy")
            TextYear.Properties.Items.Add(CurrYear)
            Dim IntYear = CInt(CurrYear)
            TextYear.Properties.Items.Add(IntYear - 1)
            TextYear.Properties.Items.Add(IntYear - 2)
            TextYear.Properties.Items.Add(IntYear - 3)
            TextYear.Properties.Items.Add(IntYear - 4)
            TextYear.Text = CurrYear

            DateEditTo.DateTime = CDate(DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000"))
            DateEditFrom.DateTime = CDate(DateTime.Now.AddYears(-1).ToString("yyyy-MM-dd 00:00:00.000"))

            DateEdit2.DateTime = CDate(DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000"))
            DateEdit1.DateTime = CDate(DateTime.Now.AddYears(-1).ToString("yyyy-MM-dd 00:00:00.000"))
        Catch ex As Exception

        End Try

        FleetCode.Properties.DataSource = GetFleets()

    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub Search()

        If String.IsNullOrEmpty(Card.Text) And String.IsNullOrEmpty(Plate.Text) And
            String.IsNullOrEmpty(PlatePart.Text) And String.IsNullOrEmpty(CardCode.Text) And String.IsNullOrEmpty(FleetCode.Text) Then
            Exit Sub
        End If

        Try

            Dim query As String = "select  means.name,means.plate,fleets.name as fleets_name,means.id,means.string,means.issued_date," &
                        " group_rules.description,means.last_used,means.month_money,fleets.code,month_money,month_volume, CASE means.status WHEN 2 THEN  'Active'  ELSE 'Not Active' END AS status " &
                        " from means,fleets,group_rules" &
                        " where fleets.id = means.fleet_id And means.[rule] = group_rules.id and means.[rule]=group_rules.[id] "
            If Card.Text <> "" Then query = query + " And means.name = " & "'" & Card.Text & "'"
            If Plate.Text <> "" Then query = query + " and means.plate = " & "'" & Plate.Text & "'"
            If PlatePart.Text <> "" Then query = query + " and means.plate like " & "'%" & PlatePart.Text & "%'"
            If CardCode.Text <> "" Then query = query + " and means.string = " & "'" & CardCode.Text & "'"
            If FleetCode.Text <> "" Then query = query + " and fleets.code = " & "'" & CInt(FleetCode.EditValue) & "'"
            If CheckActive.Checked = True Then query = query + " and means.status=2   "
            query = query + " order by means. last_used desc "
            sql.RunQuery(query)
            LayoutView1.CardCaptionFormat = "{2}  {4} "
            '   LayoutView1.CardCaptionFormat = "{3}:{7} "
            GridControl3.DataSource = sql.SQLDS.Tables(0)
            '   GroupControl1.Text = "بيانات البحث ... عدد البطاقات   " + " " + LayoutView1.RowCount.ToString
        Catch ex As Exception

        End Try



    End Sub


    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)
        Search()
        'Dim row As Object = Me.SearchLookUpEdit1.Properties.View.GetFocusedRowCellValue("MarketId")
        'Dim aa As String = TryCast(row, DataRowView)("userid").ToString()
        'If aa = "" Then MsgBox("الرجاء اختيار الموظف") : Exit Sub
        'SqlDataSource1.Queries(0).Parameters(0).Value = aa
        '  SqlDataSource1.Fill()
    End Sub

    Private Sub CardsQuery_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F3 Then
            Search()
        End If
    End Sub

    Private Sub TextCstatus_EditValueChanged(sender As Object, e As EventArgs) Handles TextCstatus.EditValueChanged
        With TextCstatus
            If .Text = "2" Then .BackColor = DefaultBackColor : .Text = "فعالة"
            If .Text = "1" Then .BackColor = Color.Red : .Text = "موقوفة" : ListBoxControl1.Items.Add("البطاقة موقوفة ")
            If .Text = "0" Then .BackColor = Color.DarkRed : .Text = "محذوفة" : ListBoxControl1.Items.Add("البطاقة محذوفة ")
        End With
    End Sub

    Private Sub TextFleetStatus_EditValueChanged(sender As Object, e As EventArgs) Handles TextFleetStatus.EditValueChanged
        With TextFleetStatus
            If .Text = "2" Then .BackColor = DefaultBackColor : .Text = "فعال"
            If .Text = "1" Then .BackColor = Color.Red : .Text = "موقوف" : ListBoxControl1.Items.Add("الزبون موقوف ")
            If .Text = "0" Then .BackColor = Color.DarkRed : .Text = "محذوف" : ListBoxControl1.Items.Add("الزبون محذوف ")
        End With
    End Sub

    Private Sub TextFleetType_EditValueChanged(sender As Object, e As EventArgs) Handles TextFleetType.EditValueChanged, FleetIDText.EditValueChanged
        With TextFleetType
            If .Text = "0" Then .BackColor = DefaultBackColor : .Text = "زبون ذمم"
            If .Text = "1" Then .BackColor = Color.Red : .Text = "زبون دفع مسبق"
        End With
    End Sub

    Private Sub TextAvailableFleet_EditValueChanged(sender As Object, e As EventArgs) Handles TextAvailableFleet.EditValueChanged
        With TextAvailableFleet
            If .Text >= "10" Then .BackColor = DefaultBackColor
            If .Text < "10" And TextFleetType.Text = "زبون دفع مسبق" Then .BackColor = Color.Red : ListBoxControl1.Items.Add("الزبون منتهي رصيده")
        End With
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)

        GridControl1.ShowPrintPreview()
    End Sub

    Private Sub CheckButton1_CheckedChanged(sender As Object, e As EventArgs)
        If CheckButton1.Checked = True Then GridView4.ActiveFilterString = "([VALUEDATE] >= #" & Now() & "# ) "
        If CheckButton1.Checked = True Then GridView4.ActiveFilterString = "([colValueDate] >= #" & Now() & "# ) "
        If CheckButton1.Checked = True Then GridView4.ActiveFilterString = "([تاريخ الاستحقاق] >= #" & Now() & "# ) "
        If CheckButton1.Checked = True Then GridView4.ActiveFilterString = "([VALUEDATE] >= #15/10/2017# ) "
        If CheckButton1.Checked = True Then GridView4.ActiveFilterString = "([colValueDate] >= #15/10/2017# ) "
        If CheckButton1.Checked = True Then GridView4.ActiveFilterString = "([تاريخ الاستحقاق] >= #15/10/2017# ) "
        '   If CheckButton1.Checked = False Then GridView4.ActiveFilter.Clear()
        ' GridView4.ActiveFilterString = String.Format("[VALUEDATE = #{0}#", DateTime.Today.Date)
        ' GridView4.ActiveFilterString = "[colValueDate] >= #" & Now() & "#"
    End Sub

    Public Sub OptimizeGrid()
        Dim col As DevExpress.XtraGrid.Columns.GridColumn = GridView3.Columns.AddField("colRunningBalance")
        col.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
        col.VisibleIndex = 7
        col.Caption = "الرصيد"
        col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        col.DisplayFormat.FormatString = "{0:#,##0.00}"
        col.Visible = True
    End Sub

    Private Sub GridView3_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView3.CustomUnboundColumnData

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)

        If e.Column.FieldName = "colRunningBalance" Then
            If e.IsGetData Then
                Dim total As Decimal = 0
                Dim rHandle As Integer = view.GetRowHandle(e.ListSourceRowIndex)

                For i As Integer = -1 To (rHandle - 1)
                    total += Convert.ToDecimal(view.GetRowCellValue(i + 1, "ALIAS12F_DEB"))
                    total -= Convert.ToDecimal(view.GetRowCellValue(i + 1, "ALIAS12F_CR"))
                Next

                e.Value = total
            End If
        End If

        GridView3.Columns("ALIAS6F").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

    End Sub

    Private Sub SimpleButton5_Click_1(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        AccounStatment(CStr(Format(DateEditFrom.DateTime, "yyyy-MM-dd")), CStr(Format(DateEditTo.DateTime, "yyyy-MM-dd")))

        '  GridView3.Columns("colRunningBalance").Summary.Add(DevExpress.Data.SummaryItemType.Average, "ALIAS12F_DEB", "Avg={0:n2}")
        '  GridView3.Columns("colRunningBalance").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "ALIAS12F_DEB", "Sum={0}")
        '  Dim item As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Max, "ALIAS12F_DEB", "Max={0}")
        '  GridView3.Columns("colRunningBalance").Summary.Add(item)
    End Sub

    Private Sub CheckActive_CheckedChanged(sender As Object, e As EventArgs) Handles CheckActive.CheckedChanged
        Search()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs)
        '  GridControl3.ShowPrintPreview()
        'SqlDataSource2.Queries(0).Parameters(0).Value = TextID.Text
        'SqlDataSource2.Fill()
    End Sub

    Private Sub LabelControl2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TextYear_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles TextYear.SelectedIndexChanged

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

#Disable Warning CA2000 ' Dispose objects before losing scope
        Dim link As New PrintableComponentLink(New PrintingSystem) With {
            .Component = GridControl11,
            .Landscape = True
        }
#Enable Warning CA2000 ' Dispose objects before losing scope
        link.Margins.Left = 10
        link.Margins.Right = 10
        link.Margins.Top = 20
        link.Margins.Bottom = 20
        link.PageHeaderFooter = "hjg"
        link.ShowPreview()

        '   GridControl11.ShowPrintPreview()
    End Sub

    Private Sub GridControl13_Click(sender As Object, e As EventArgs) Handles GridControl13.Click

    End Sub

    Private Sub GridView3_ColumnUnboundExpressionChanged(sender As Object, e As ColumnEventArgs) Handles GridView3.ColumnUnboundExpressionChanged

    End Sub

    Private Sub GridView3_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView3.CellValueChanged

    End Sub

    Private Sub TextCardType_EditValueChanged(sender As Object, e As EventArgs) Handles TextCardType.EditValueChanged
        With TextCardType
            If Len(TextString.Text) = 8 Then .Text = "بطاقة"
            If Len(TextString.Text) = 16 Then .Text = "حلقة"
        End With
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        CraetMonthlyChart(CInt(LayoutView1.GetRowCellValue(LayoutView1.FocusedRowHandle, "id")))
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        GridControl13.ShowPrintPreview()
    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles SimpleButton10.Click
        SqlDataSource4.Queries(0).Parameters(0).Value = TextFleetID.Text
        SqlDataSource4.Queries(0).Parameters(1).Value = CStr(Format(DateEdit1.DateTime, "yyyy-MM-dd"))
        SqlDataSource4.Queries(0).Parameters(2).Value = CStr(Format(DateEdit2.DateTime, "yyyy-MM-dd"))
        SqlDataSource4.Fill()
    End Sub

    Private Sub CheckButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckButton1.CheckedChanged

        SqlDataSource4.Queries(0).Parameters(0).Value = TextFleetID.Text
        SqlDataSource4.Queries(0).Parameters(1).Value = CDate(DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000"))
        SqlDataSource4.Queries(0).Parameters(2).Value = CDate(DateTime.Now.AddYears(+1000).ToString("yyyy-MM-dd 00:00:00.000"))
        SqlDataSource4.Fill()
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GridControl1.ShowPrintPreview()
    End Sub

    Private Sub FleetCode_EditValueChanged(sender As Object, e As EventArgs) Handles FleetCode.EditValueChanged
        Search()
    End Sub

    Private Sub FleetCode_DoubleClick(sender As Object, e As EventArgs) Handles FleetCode.DoubleClick

        ' FinanceSelectAccount.Text = Me.Text
        FinanceSelectAccount.TextEdit1.Text = Me.Name.ToString
        FinanceSelectAccount.Show()

    End Sub

    Private Sub TextString_EditValueChanged(sender As Object, e As EventArgs) Handles TextString.EditValueChanged
        With TextString
            If Len(.Text) = 8 Then TextCardType.Text = "بطاقة"
            If Len(.Text) = 16 Then TextCardType.Text = "حلقة"
        End With
    End Sub

    Private Sub TextOdometer_EditValueChanged(sender As Object, e As EventArgs) Handles TextOdometer.EditValueChanged
        With TextOdometer
            If .Text = "0" Then .Text = "غير فعال"
            If .Text = "1" Then .Text = "فعال"

        End With
    End Sub

    Private Sub LabelControl44_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub GetTrans()
        Dim _OldDataTable As New DataTable
        Dim _DataTable As New DataTable


        Try
            Dim SqlString As String = ""
            If Card.Text = "" And Plate.Text = "" And PlatePart.Text = "" And CardCode.Text = "" And FleetCode.Text = "" Then Exit Sub


            SqlString = " select    transactions.Date as TransDate , DATENAME(dw, transactions.Date) as theDayName ,
                                        transactions.time,       transactions.quantity,       transactions.ppv,
                                        transactions.sale,       transactions.plate,       transactions.product_name,
                                        stations.stn_name,       transactions.pump,     transactions.mean_name, fleets.Name As FleetName,transactions.odometer,transactions.tag
                              from transactions,stations,fleets
                              where transactions.fleet_id = fleets.id and  transactions.stn_id = stations.stn_id and "
            If RadioButton1.Checked = True Then
                SqlString = SqlString + " (transactions.mean_id = " & CInt(TextID.Text) & ")"
            ElseIf RadioButton2.Checked = True Then
                SqlString = SqlString + " (transactions.plate = '" & CStr(TextPlate.Text) & "')"
            ElseIf RadioButton3.Checked = True Then
                SqlString = SqlString + " (transactions.mean_name = '" & CStr(TextName.Text) & "')"
            ElseIf RadioButton4.Checked = True Then
                SqlString = SqlString + " (transactions.tag = '" & CStr(TextString.Text) & "')"
            Else
                SqlString = SqlString + " (transactions.mean_id = " & CInt(TextID.Text) & ")"
            End If

            SqlString = SqlString + " order by transactions.Date desc"
            sql.RunQuery(SqlString)
            _DataTable = sql.SQLDS.Tables(0)

        Catch ex As Exception

        End Try


        If CheckEditOldData.Checked = True Then
            Try
                Dim SqlString As String = ""
                If Card.Text = "" And Plate.Text = "" And PlatePart.Text = "" And CardCode.Text = "" And FleetCode.Text = "" Then Exit Sub

                If LayoutView1.RowCount > 0 Then
                    SqlString = " select    transactions.Date as TransDate , DATENAME(dw, transactions.Date) as theDayName ,
                                        transactions.time,       transactions.quantity,       transactions.ppv,
                                        transactions.sale,       transactions.plate,       transactions.product_name,
                                        stations.stn_name,       transactions.pump,     transactions.mean_name, fleets.Name As FleetName,transactions.odometer,transactions.tag
                              from transactions,stations,fleets
                              where transactions.fleet_id = fleets.id and  transactions.stn_id = stations.stn_id and "
                    If RadioButton1.Checked = True Then
                        SqlString = SqlString + " (transactions.mean_id = " & CInt(LayoutView1.GetRowCellValue(LayoutView1.FocusedRowHandle, "id")) & ")"
                    ElseIf RadioButton2.Checked = True Then
                        SqlString = SqlString + " (transactions.plate = '" & CStr(LayoutView1.GetRowCellValue(LayoutView1.FocusedRowHandle, "plate")) & "')"
                    ElseIf RadioButton3.Checked = True Then
                        SqlString = SqlString + " (transactions.mean_name = '" & CStr(LayoutView1.GetRowCellValue(LayoutView1.FocusedRowHandle, "name")) & "')"
                    ElseIf RadioButton4.Checked = True Then
                        SqlString = SqlString + " (transactions.tag = '" & CStr(LayoutView1.GetRowCellValue(LayoutView1.FocusedRowHandle, "string")) & "')"
                    Else
                        SqlString = SqlString + " (transactions.plate = '" & CStr(LayoutView1.GetRowCellValue(LayoutView1.FocusedRowHandle, "plate")) & "')"
                        SqlString = SqlString + "And  (transactions.mean_name = '" & CStr(LayoutView1.GetRowCellValue(LayoutView1.FocusedRowHandle, "name")) & "')"
                    End If

                    SqlString = SqlString + " order by transactions.Date desc"
                    sql.OldOrpakRunQuery(SqlString)
                    _OldDataTable = sql.SQLDS.Tables(0)
                End If
            Catch ex As Exception

            End Try
        End If

        _DataTable.Merge(_OldDataTable)
        GridControl11.DataSource = _DataTable
        Me.GridView2.BestFitColumns()

    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        GetTrans()
    End Sub

    Private Sub GridControl3_DoubleClick(sender As Object, e As EventArgs) Handles GridControl3.DoubleClick

        ShowEditForm()

    End Sub

    Private Sub GridControl3_Click_1(sender As Object, e As EventArgs) Handles GridControl3.Click, GridView6.Click

        '   SplashScreenManager1.ShowWaitForm()


        GetCardDetails()


        '  SplashScreenManager1.CloseWaitForm()
    End Sub
    Private Sub GetCardDetails()
        Try
            '  If sql.SQLDS.Tables(0).Rows.Count = 0 Then Exit Sub
            Me.GridControl11.DataSource = ""
            ListBoxControl1.Items.Clear()

            Dim CardID As Integer = 0
            If CheckEditViewAsList.Checked = False Then
                CardID = CInt(LayoutView1.GetRowCellValue(LayoutView1.FocusedRowHandle, "id"))
            Else
                CardID = CInt(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "id"))
            End If

            '  SearchCardsByID(CardID)


            Dim SQLString As String = " SELECT  means.ID, means.name ,  means.string, means.type, means.status, means.[rule], means.plate, means.fleet_id, means.available_amount as CardAmount," &
                           " means.update_timestamp,means.opos_prompt_for_odometer, means.day_volume, means.week_volume, means.month_volume, means.day_money, " &
                           " means.week_money,means.month_money , means.day_visits, means.week_visits, means.month_visits, means.issued_date, means.last_used, " &
                           " fleets.code, group_rules.Description,fleets.name as FleetName,fleets.status as Fstatus,fleets.available_amount,fleets.acctyp" &
                           " FROM      means,group_rules,fleets" &
                           " where means.[rule] = group_rules.id" &
                           " and means.fleet_id = fleets.id"
            If CStr(CardID) <> "" Then SQLString = SQLString + " and means.id = " & CardID
            Dim sql As New SQLControl
            sql.RunQuery(SQLString)
            TextName.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("name"), String)
            TextPlate.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("plate"), String)
            TextID.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("ID"), String)
            TextString.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("string"), String)
            TextCardType.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("type"), String)
            TextCstatus.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("status"), String)
            TextOdometer.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("opos_prompt_for_odometer"), String)
            TextLastUsed.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("last_used"), String)
            TextLastEdit.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("update_timestamp"), String)
            TextIssueDate.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("issued_date"), String)
            TextAvailableCard.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("CardAmount"), String)
            TextMonthNIS.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("month_money"), String)
            TextMonthLIT.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("month_volume"), String)
            TextRule.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("Description"), String)
            TextRule.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("Description"), String)
            WeekMony.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("week_money"), String)
            WeekLIT.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("week_volume"), String)
            TextDayMony.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("day_money"), String)
            TextDayLit.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("day_volume"), String)
            TextFleetID.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("code"), String)
            TextFleetName.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("FleetName"), String)
            TextFleetType.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("acctyp"), String)
            TextAvailableFleet.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("available_amount"), String)
            TextFleetStatus.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("Fstatus"), String)
            TextFleetID2.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("code"), String)
            TextFleetName2.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("FleetName"), String)
            FleetIDText.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("fleet_id"), String)
            GetTrans()

            If CheckEdit2.Checked = False Then
                SearchFleetsLogs()
                TextFleetName.Text = GetAccData(Me.TextFleetID.Text).FullNamee
                TextِAddress.Text = GetAccData(Me.TextFleetID.Text).Addresss
                TextSort.Text = GetAccData(Me.TextFleetID.Text).SortGroup
                TextCountry.Text = GetAccData(Me.TextFleetID.Text).Country
                TextPhone.Text = GetAccData(Me.TextFleetID.Text).PHONE
                TextPhax.Text = GetAccData(Me.TextFleetID.Text).Fax
                TextFilter.Text = GetAccData(Me.TextFleetID.Text).Filter
                TextSphone.Text = GetAccData(Me.TextFleetID.Text).sphone
                TextEmail.Text = GetAccData(Me.TextFleetID.Text).email
                TextNote.Text = GetAccData(Me.TextFleetID.Text).Details
                TextArea.Text = GetAccData(Me.TextFleetID.Text).costcode
                AccounStatment(DateTime.Now.AddYears(-1).ToString("yyyy-MM-dd 00:00:00.000"), DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000"))
                'Checks()
                SqlDataSource4.Queries(0).Parameters(0).Value = TextFleetID.Text
                SqlDataSource4.Queries(0).Parameters(1).Value = CStr(Format(DateEdit1.DateTime, "yyyy-MM-dd"))
                SqlDataSource4.Queries(0).Parameters(2).Value = CStr(Format(DateEdit2.DateTime, "yyyy-MM-dd"))
                SqlDataSource4.Fill()
                CraetMonthlyChart(CInt(LayoutView1.GetRowCellValue(LayoutView1.FocusedRowHandle, "id")))
                GridView3.Columns("ALIAS6F").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then GetTrans()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then GetTrans()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then GetTrans()
    End Sub

    Private Sub NavigationPane1_Click(sender As Object, e As EventArgs) Handles NavigationPane1.Click

    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        SearchFleetsLogs()
    End Sub

    Private Sub SimpleButton11_Click(sender As Object, e As EventArgs) Handles SimpleButton11.Click
        GridControl4.ShowRibbonPrintPreview()
    End Sub

    Private Sub Card_EditValueChanged(sender As Object, e As EventArgs) Handles Card.EditValueChanged
        Search()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then GetTrans()
    End Sub

    Private Sub RepositoryEdit_Click(sender As Object, e As EventArgs) Handles RepositoryEditActive.Click, RepositoryStopActive.Click
        ShowEditForm()
    End Sub
    Private Sub ShowEditForm()
        Dim CardId As Integer
        CardId = CInt(LayoutView1.GetRowCellValue(LayoutView1.FocusedRowHandle, "id"))
        My.Forms.OrpakEditCard.TextID.EditValue = CardId
        ''OrpakEditCard.ShowDialog()

        '' FrmNewContact.ShowDialog()
        'If OrpakEditCard.ShowDialog() = DialogResult.OK Then
        '    MsgBox("ok")

        'End If

        If OrpakEditCard.ShowDialog() = DialogResult.OK Then
            ' Form was closed via OK button or similar, continue normally... '
            MsgBox("ok")
        Else
            ' Form was aborted via Cancel, Close, or some other way; do something '
            ' else like quitting the application... '
            Search()
        End If

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditViewAsList.CheckedChanged
        If CheckEditViewAsList.Checked = False Then
            GridControl3.MainView = LayoutView1
            DockPanel2.Width = 300
        Else
            GridControl3.MainView = GridView6
            DockPanel2.Width = 350
        End If

    End Sub

    Private Sub SimpleButton12_Click(sender As Object, e As EventArgs) Handles SimpleButton12.Click
        Search()
    End Sub

    Private Sub SimpleButton13_Click(sender As Object, e As EventArgs) Handles SimpleButton13.Click
        GridControl3.ShowPrintPreview()
    End Sub

    Private Sub RepositoryStopActive_Click(sender As Object, e As EventArgs) Handles RepositoryStopActive.Click
        '  My.Forms.OrpakEditCard.TextEditID.EditValue = CInt(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "id"))
        '  My.Forms.OrpakEditCard.ShowDialog()
    End Sub

    Private Sub StopActiveCard()



        Dim CardID As Integer = 0
        Dim CardStatus As String = ""
        If CheckEditViewAsList.Checked = False Then
            CardID = CInt(LayoutView1.GetRowCellValue(LayoutView1.FocusedRowHandle, "id"))
            CardStatus = CStr(LayoutView1.GetRowCellValue(LayoutView1.FocusedRowHandle, "status"))
        Else
            CardID = CInt(LayoutView1.GetRowCellValue(GridView6.FocusedRowHandle, "id"))
            CardStatus = CStr(LayoutView1.GetRowCellValue(GridView6.FocusedRowHandle, "status"))
        End If

        If CardID = 0 Or String.IsNullOrEmpty(CStr(CardID)) Or String.IsNullOrEmpty(CStr(CardStatus)) Then
            XtraMessageBox.Show("لا يمكن تفعيل/الغاء البطاقة")
            Exit Sub
        End If

        Dim Mess As String = ""
        If CardStatus = "Active" Then
            Mess = " هل تريد ايقاف البطاقة ؟ "
        ElseIf CardStatus = "Not Active" Then
            Mess = " هل تريد تفعيل البطاقة ؟ "
        End If


        If XtraMessageBox.Show(Mess, "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.No Then
            If CardStatus = "Active" Then
                StopCard(CardID, 1)
                XtraMessageBox.Show("تم ايقاف البطاقة")
            End If
            If CardStatus = "Not Active" Then
                StopCard(CardID, 2)
                XtraMessageBox.Show("تم تفعيل البطاقة")
            End If
        End If

        Search()

    End Sub

    Private Sub Plate_EditValueChanged(sender As Object, e As EventArgs) Handles Plate.EditValueChanged
        Search()
    End Sub

    Private Sub PlatePart_EditValueChanged(sender As Object, e As EventArgs) Handles PlatePart.EditValueChanged
        Search()
    End Sub

    Private Sub CardCode_EditValueChanged(sender As Object, e As EventArgs) Handles CardCode.EditValueChanged
        Search()
    End Sub
    Private Function GetFleets() As DataTable
        Dim FleetTable As New DataTable
        Try
            Dim SqlString As String
            Dim sql As New SQLControl
            SqlString = "Select AccountKey,FullName from   [WIZCOUNT].[ALHUDA].[dbo].[Accounts] A
					 Right join fleets F
					 On A.AccountKey=CONVERT(nvarchar, CONVERT(VARCHAR(12), F.code))
                     where F.status <> 0 order by AccountKey desc ,SortGroup"
            sql.RunQuery(SqlString)
            FleetTable = sql.SQLDS.Tables(0)
        Catch ex As Exception
            Return FleetTable
        End Try
        Return FleetTable

    End Function

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        Search()
    End Sub

    Private Sub CheckEditOldData_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditOldData.CheckedChanged
        Search()
    End Sub

    Private Sub DockPanel2_Click(sender As Object, e As EventArgs) Handles DockPanel2.Click

    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton3_Click_2(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        GridView2.OptionsSelection.MultiSelect = True
        GridView2.SelectAll()
        GridView2.CopyToClipboard()
        '  GridView2.OptionsSelection.MultiSelect = False
    End Sub
End Class