
Imports System.Windows.Documents
Imports DevExpress.LookAndFeel
Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Printing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI



Public Class FinancialAccountingStatment2

    Sub New()
        InitializeComponent()
    End Sub

    Private Sub AccountingStatment2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.WizCountDataSet.Accounts)
        RadioGroup1.EditValue = 2
        RadioGroup1.SelectedIndex = 1
        With YearText.Properties.Items
            Dim i As Integer
            For i = 0 To 5
                .Add(CInt(Format(Today, "yyyy")) - i)
            Next i
        End With
        YearText.EditValue = CInt(Format(Today, "yyyy"))

        CheckBox3.Checked = True

        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)

        DateEditTo.DateTime = CDate(DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000"))
        DateEditFrom.DateTime = CDate(DateTime.Now.AddYears(-1).ToString("yyyy-MM-dd 00:00:00.000"))
        AccountKeyTextEdit.Select()

        DateEdit1.DateTime = CDate(DateTime.Now.AddYears(-1).ToString("yyyy-MM-dd 00:00:00.000"))
        DateEdit2.DateTime = CDate(DateTime.Now.AddYears(+1).ToString("yyyy-MM-dd 00:00:00.000"))
        CheckBox1.Checked = True
    End Sub

    Private Sub GridView2_PrintInitialize(sender As System.Object,
            e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) _
            Handles GridView2.PrintInitialize
        Dim pb As DevExpress.XtraPrinting.PrintingSystemBase = CType(e.PrintingSystem, DevExpress.XtraPrinting.PrintingSystemBase)
        '    pb.PageSettings.Landscape = True
        pb.PageSettings.LeftMargin = 1
        pb.PageSettings.RightMargin = 1
        pb.PageSettings.TopMargin = 1
        pb.PageSettings.BottomMargin = 1
        pb.Pages.AddRange(pb.Pages)
        pb.ContinuousPageNumbering = True
    End Sub

    Private Sub GetDat()
        If AccountKeyTextEdit.Text = String.Empty Or AccountKeyTextEdit.Text = "0" Then Exit Sub
        Me.SqlDataSource1.Queries(0).Parameters(0).Value = AccountKeyTextEdit.Text
        Me.SqlDataSource1.Queries(1).Parameters(0).Value = AccountKeyTextEdit.Text
        SqlDataSource1.Fill()

    End Sub

    Private Sub GetAddData()
        If AccID.Text = String.Empty Or AccID.Text = "0" Then Exit Sub
        Me.SqlDataSource2.Queries(0).Parameters(0).Value = AccID.EditValue
        SqlDataSource2.Fill()
    End Sub

    Private Sub AccounStatment(FromDate As String, ToDate As String)

        If CInt(AccountKeyTextEdit.Text) = 0 Or AccountKeyTextEdit.Text = "" Then Exit Sub

        Try
            If AccountKeyTextEdit.Text = String.Empty Then Exit Sub
            If FromDate = String.Empty Or ToDate = String.Empty Then Exit Sub

            Dim AccountStatmentss As String
            If CheckBox1.Checked = True Then
                AccountStatmentss = " SELECT     JVALUEDATE  AS ALIAS6F,    JREFERANCE  AS ALIAS8F,  JREF2  AS ALIAS9F,  JDESCRIPTION  AS ALIAS10F,   CASE JMDEBITCREDIT WHEN 1 THEN  JMSUF  ELSE 0 END AS ALIAS12F_DEB, CASE JMDEBITCREDIT WHEN 0 THEN  JMSUF  ELSE 0 END AS ALIAS12F_CR " _
                        & " ,  IsNull(SORTING, 999999999) AS SORTING   ,RPHSTRANSRETRIV. JMID  AS ALIAS2F  from RPHSTRANSRETRIV" _
                        & " LEFT JOIN [ALHUDA].[dbo].[ACCMATCHING] ON [ALHUDA].[dbo].  RPHSTRANSRETRIV.JMID = [ALHUDA].[dbo].  [ACCMATCHING] .JMID" _
                        & " WHERE          ( JMACCOUNTKEY = '" & AccountKeyTextEdit.Text & "'  AND ('" & ToDate & "' >= JVALUEDATE) AND ('" & FromDate & "' <= JVALUEDATE) AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 " _
                        & "  order by  ISNULL([ACCMATCHING].SORTING*0,1)   ,ASORTGROUP ASC  , JMACCOUNTKEY ASC  , JVALUEDATE ASC  , RPHSTRANSRETRIV.JMID ASC   "
            Else
                AccountStatmentss = " SELECT     JVALUEDATE  AS ALIAS6F,    JREFERANCE  AS ALIAS8F,  JREF2  AS ALIAS9F,  JDESCRIPTION  AS ALIAS10F,   CASE JMDEBITCREDIT WHEN 1 THEN  JMSUF  ELSE 0 END AS ALIAS12F_DEB, CASE JMDEBITCREDIT WHEN 0 THEN  JMSUF  ELSE 0 END AS ALIAS12F_CR " _
                        & "   ,RPHSTRANSRETRIV. JMID  AS ALIAS2F  from RPHSTRANSRETRIV" _
                        & " WHERE          ( JMACCOUNTKEY = '" & AccountKeyTextEdit.Text & "'  AND ('" & ToDate & "' >= JVALUEDATE) AND ('" & FromDate & "' <= JVALUEDATE) AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 " _
                        & " order by   JVALUEDATE ASC  , JMID ASC   "

            End If
            Dim DebitBalance = " SELECT   cast(  sum( JMSUF ) as decimal(10,2)) as Debit    " _
        & " from RPHSTRANSRETRIV" _
        & " WHERE   JMDEBITCREDIT=1 and       ( JMACCOUNTKEY = '" & AccountKeyTextEdit.Text & "'  AND ('" & FromDate & "' > JVALUEDATE)  AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 "

            Dim CreditBalance = " SELECT   cast(  sum( JMSUF ) as decimal(10,2))  as Credit " _
        & " from RPHSTRANSRETRIV" _
        & " WHERE   JMDEBITCREDIT=0 and       ( JMACCOUNTKEY = '" & AccountKeyTextEdit.Text & "'  AND ('" & FromDate & "' > JVALUEDATE)  AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 "

            Dim i As Integer
            Dim sql As New SQLControl
            sql.WizCountRunQuery(AccountStatmentss)

            GridControl2.DataSource = sql.SQLDS.Tables(0)

            Dim DebitBalanceString As String = "0", CreditBalanceString As String = "0"


            If CheckBox4.Checked = True Then
                sql.WizCountRunQuery(DebitBalance)
                If Not IsDBNull(sql.SQLDS.Tables(0).Rows(i).Item("Debit")) Then DebitBalanceString = CType(sql.SQLDS.Tables(0).Rows(i).Item("Debit"), String)

                sql.WizCountRunQuery(CreditBalance)
                If Not IsDBNull(sql.SQLDS.Tables(0).Rows(i).Item("Credit")) Then CreditBalanceString = CType(sql.SQLDS.Tables(0).Rows(i).Item("Credit"), String)
            End If


            Dim DrBalance, CrBalance As Integer
            DrBalance = 0 : CrBalance = 0
            Dim Balance = CInt(DebitBalanceString) - CInt(CreditBalanceString)
            If Balance >= 0 Then DrBalance = Balance Else CrBalance = -1 * Balance


            GridView2.AddNewRow()
            Dim rowHandle As Integer = GridView2.GetRowHandle(GridView2.DataRowCount)
            If GridView2.IsNewItemRow(rowHandle) Then
                GridView2.SetRowCellValue(rowHandle, GridView2.Columns(0), FromDate)
                GridView2.SetRowCellValue(rowHandle, GridView2.Columns(1), 0)
                GridView2.SetRowCellValue(rowHandle, GridView2.Columns(2), 0)
                GridView2.SetRowCellValue(rowHandle, GridView2.Columns(3), "رصيد مدور")
                GridView2.SetRowCellValue(rowHandle, GridView2.Columns(4), DrBalance)
                GridView2.SetRowCellValue(rowHandle, GridView2.Columns(5), CrBalance)
                GridView2.SetRowCellValue(rowHandle, GridView2.Columns(6), 0)
            End If

            If GridView2.Columns.Count = 9 Then

                'If CheckBox1.Checked = True Then
                '    GridView2.Columns("SORTING").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                'Else
                '    GridView2.Columns("ALIAS6F").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                '    GridView2.Columns("ALIAS9F").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                'End If

                GridView2.UpdateCurrentRow()
            Else

                'If CheckBox1.Checked = True Then
                '    GridView2.Columns("SORTING").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                'Else
                '    GridView2.Columns("ALIAS6F").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                '    GridView2.Columns("ALIAS9F").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                'End If

                GridView2.UpdateCurrentRow()
                OptimizeGrid()
            End If
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Public Sub OptimizeGrid()
        Dim col As DevExpress.XtraGrid.Columns.GridColumn = GridView2.Columns.AddField("colRunningBalance")
        col.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
        col.VisibleIndex = 7
        col.Caption = "الرصيد"
        col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        col.DisplayFormat.FormatString = "{0:#,##0.00}"
        col.Visible = True
        col.MaxWidth = 180
        col.MinWidth = 100
        col.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        col.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

    End Sub

    Private Sub GridView2_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView2.CustomUnboundColumnData

        Try

            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)

            If e.Column.FieldName = "colRunningBalance" Then
                If e.IsGetData Then
                    Dim total As Decimal = 0
                    Dim rHandle As Integer = view.GetRowHandle(e.ListSourceRowIndex)

                    For i As Integer = -1 To (rHandle - 1)
                        total -= Convert.ToDecimal(view.GetRowCellValue(i + 1, "ALIAS12F_DEB"))
                        total += Convert.ToDecimal(view.GetRowCellValue(i + 1, "ALIAS12F_CR"))
                    Next

                    e.Value = total
                End If
            End If

            If CheckBox1.Checked = True Then
                GridView2.Columns("SORTING").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            Else
                GridView2.Columns("ALIAS6F").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AccountKeyTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles AccountKeyTextEdit.EditValueChanged



        GetDat()

        AccounStatment(CStr(Format(DateEditFrom.DateTime, "yyyy-MM-dd")), CStr(Format(DateEditTo.DateTime, "yyyy-MM-dd")))

        GetAddData()

        GetCheks(CStr(Format(DateEdit1.DateTime, "yyyy-MM-dd")), CStr(Format(DateEdit2.DateTime, "yyyy-MM-dd")), AccountKeyTextEdit.Text)


    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        GetCheks(CStr(Format(DateEdit1.DateTime, "yyyy-MM-dd")), CStr(Format(DateEdit2.DateTime, "yyyy-MM-dd")), AccountKeyTextEdit.Text)

    End Sub

    Function productcase() As String
        productcase = "CASE WHEN product_name = 'Unleaded regular' THEN '95' WHEN product_name = 'Unleaded Super' THEN '98'  else product_name  END AS Product"
    End Function

    Private Sub CraetMonthlyChart(fleet As String)

        Try
            If fleet = "0" Or fleet = String.Empty Then Exit Sub
            Dim sql As New SQLControl

            Dim sql_string2 As String = "SELECT   DATEPART(month, date) as Month, "
            If Me.CheckBox3.Checked = False Then sql_string2 = sql_string2 + productcase() & " , "
            sql_string2 = sql_string2 + " SUM(quantity) as Quant , SUM(sale) as Sale from transactions,fleets "
            sql_string2 = sql_string2 + " WHERE   transactions.fleet_id = fleets.id  and (DatePart(Year, Date) = " & Me.YearText.Text & ")  And fleets.code = " & " '" & fleet & "'"

            If Me.CheckBox2.Checked = True Then sql_string2 = sql_string2 + " and (product_code = 1 or product_code = 2 or product_code = 3) "
            sql_string2 = sql_string2 + " GROUP BY DATEPART(month, date) "
            If Me.CheckBox3.Checked = False Then sql_string2 = sql_string2 + ", product_name"

            sql_string2 = sql_string2 + " order by DATEPART(month, date)"
            sql.RunQuery(sql_string2)

            GridControl3.DataSource = sql.SQLDS.Tables(0)

            ChartControl1.DataSource = sql.SQLDS.Tables(0)
            ChartControl1.SeriesDataMember = "Month"
            ChartControl1.SeriesTemplate.ArgumentDataMember = "Month"

            ChartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Sale"})

#Disable Warning BC42018 ' Operands of type Object used for operator
            If RadioGroup1.SelectedIndex = 1 Then ChartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Sale"})
            If RadioGroup1.SelectedIndex = 0 Then ChartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Quant"})
#Enable Warning BC42018 ' Operands of type Object used for operator

            ChartControl1.SeriesTemplate.View = New StackedBarSeriesView()

            ' ChartControl1.SeriesTemplate.View = New SideBySideBarSeriesView()

            ChartControl1.SeriesNameTemplate.BeginText = "Month: "

            Dim label As SideBySideBarSeriesLabel = TryCast(ChartControl1.Series(0).Label, SideBySideBarSeriesLabel)
            If label IsNot Nothing Then
                label.Position = BarSeriesLabelPosition.Top
            End If
        Catch ex As Exception
            MsgBox("لا يوجد بيانات")
        End Try

    End Sub

    Private Sub CraetMonthlyChartWaleet(fleet As String)
        '  Me.RadioGroup1.SelectedIndex = 1
        '  Me.RadioGroup1.EditValue = 1
        ChartControl1.DataSource = Nothing
        '   Try
        If fleet = String.Empty Or fleet = "0" Then Exit Sub
        If Me.YearText.Text = String.Empty Or Me.YearText.Text = "0" Then Exit Sub

        Dim sql As New SQLControl

        Dim DebitBalance = " SELECT   DATEPART(month, JVALUEDATE) as Month, cast(  sum( JMSUF ) as decimal(10,2)) as Sale    " _
& " From   [ALHUDA].[dbo].[RPHSTRANSRETRIV] " _
& " WHERE   JMDEBITCREDIT=1 and   (DatePart(Year, JVALUEDATE) = " & Me.YearText.Text & ") and     ( JMACCOUNTKEY = '" & fleet & "'   AND (0 <> JMSUF) )  " _
& " And JTYPE <> 1 And JTYPE <> 2 And ((JSTATUS = 1 And JTYPE <> 1) Or (JSTATUS = 0 And JTYPE = 1)) And ADUMI <> 3 "
        DebitBalance = DebitBalance + " GROUP BY DATEPART(month, JVALUEDATE) "
        DebitBalance = DebitBalance + " order by DATEPART(month, JVALUEDATE)"

        sql.WizCountRunQuery(DebitBalance)

        GridControl3.DataSource = sql.SQLDS.Tables(0)

        'ChartControl1.DataSource = sql.SQLDS.Tables(0)
        'ChartControl1.SeriesDataMember = "Month"
        'ChartControl1.SeriesTemplate.ArgumentDataMember = "Month"
        'ChartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Sale"})

        'ChartControl1.SeriesTemplate.View = New StackedBarSeriesView()

        'ChartControl1.SeriesNameTemplate.BeginText = "Month: "

        'Dim label As SideBySideBarSeriesLabel = TryCast(ChartControl1.Series(0).Label, SideBySideBarSeriesLabel)
        'If label IsNot Nothing Then
        '    label.Position = BarSeriesLabelPosition.Top
        'End If
        '  Catch ex As Exception
        '   MsgBox("لا يوجد بيانات")
        '   End Try

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        RadioGroup1.SelectedIndex = 0
        GridView3.Columns("Quant").Visible = True
        GridView3.Columns("Product").Visible = True
        CraetMonthlyChart(AccountKeyTextEdit.Text)
        WizCountOrpak.Text = "تقرير اورباك"
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GetDat()
        GetAddData()
        AccounStatment(CStr(Format(DateEditFrom.DateTime, "yyyy-MM-dd")), CStr(Format(DateEditTo.DateTime, "yyyy-MM-dd")))
        GetCheks(CStr(Format(DateEdit1.DateTime, "yyyy-MM-dd")), CStr(Format(DateEdit2.DateTime, "yyyy-MM-dd")), AccountKeyTextEdit.Text)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Try
            Dim RightHeader As String, MiddleHeader As String, LeftHeader As String
            RightHeader = String.Empty
            MiddleHeader = "  كشف حساب  " & " " & " " & Me.TextEdit2.Text & " " & Me.AccountKeyTextEdit.Text
            LeftHeader = WizCountOrpak.Text

            Dim RightFooter As String = "Pages: [Page # of Pages #]"
            Dim MiddleFooter As String = "User: [User Name]"
            Dim LeftFooter As String = "Date: [Date Printed]"




            Dim grids As Control() = New Control() {GridControl2}

            Dim ps As New DevExpress.XtraPrinting.PrintingSystem()
            Dim compositeLink As New DevExpress.XtraPrintingLinks.CompositeLink()
            compositeLink.PrintingSystem = ps

            For Each grid As Control In grids
                Dim link As New DevExpress.XtraPrinting.PrintableComponentLink()
                link.Component = CType(grid, DevExpress.XtraPrinting.IPrintable)
                compositeLink.Links.Add(link)
                link.PrintingSystem.Document.AutoFitToPagesWidth = 1
            Next

            compositeLink.Landscape = False
            compositeLink.Margins.Left = 2
            compositeLink.Margins.Right = 2

            compositeLink.Margins.Bottom = 10
            compositeLink.Margins.Top = 10

            'compositeLink.PrintingSystem.PageMargins.Left = 0
            'compositeLink.PrintingSystem.PageMargins.Right = 0
            'compositeLink.PrintingSystem.PageMargins.Top = 0
            'compositeLink.PrintingSystem.PageMargins.Bottom = 0

            Dim phf As DevExpress.XtraPrinting.PageHeaderFooter =
           TryCast(compositeLink.PageHeaderFooter, DevExpress.XtraPrinting.PageHeaderFooter)
            phf.Header.Content.Clear()
            phf.Header.Content.AddRange(New String() _
            {RightHeader, MiddleHeader, LeftHeader})
            phf.Header.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Far

            phf.Footer.Content.Clear()
            phf.Footer.Content.AddRange(New String() _
            {RightFooter, MiddleFooter, LeftFooter})
            phf.Footer.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Far


            compositeLink.CreateDocument()

            compositeLink.ShowPreview()
        Catch ex As Exception
            MsgBox("لا يوجد بيانات")
        End Try
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        '  GridView3.Columns.ColumnByName

        Try
            Dim RightHeader As String, MiddleHeader As String, LeftHeader As String
            RightHeader = String.Empty
            MiddleHeader = "تقرير شهري لحساب " & " " & Me.AccountKeyTextEdit.Text & " " & Me.TextEdit2.Text & " " & "لسنة " & Me.YearText.Text
            LeftHeader = WizCountOrpak.Text

            ChartControl1.OptionsPrint.SizeMode = PrintSizeMode.Stretch

            Dim grids As Control() = New Control() {GridControl3, ChartControl1}

            Dim ps As New DevExpress.XtraPrinting.PrintingSystem()
            Dim compositeLink As New DevExpress.XtraPrintingLinks.CompositeLink()
            compositeLink.PrintingSystem = ps

            For Each grid As Control In grids
                Dim link As New DevExpress.XtraPrinting.PrintableComponentLink()
                link.Component = CType(grid, DevExpress.XtraPrinting.IPrintable)
                compositeLink.Links.Add(link)
                compositeLink.BreakSpace = 1000
                ' link.PrintingSystem.Document.AutoFitToPagesWidth = 1
            Next
            compositeLink.Landscape = True
            compositeLink.PrintingSystem.PageMargins.Left = 5
            compositeLink.PrintingSystem.PageMargins.Right = 5
            compositeLink.PrintingSystem.PageMargins.Top = 5
            compositeLink.PrintingSystem.PageMargins.Bottom = 5

            Dim phf As DevExpress.XtraPrinting.PageHeaderFooter =
           TryCast(compositeLink.PageHeaderFooter, DevExpress.XtraPrinting.PageHeaderFooter)
            phf.Header.Content.Clear()
            phf.Header.Content.AddRange(New String() _
            {RightHeader, MiddleHeader, LeftHeader})
            phf.Header.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Far

            compositeLink.CreateDocument()

            compositeLink.ShowPreview()
        Catch ex As Exception
            MsgBox("لا يوجد بيانات")
        End Try

    End Sub

    Private Sub GridControl2_DoubleClick(sender As Object, e As EventArgs) Handles GridControl2.DoubleClick
        Dim Ref2 As Integer = CInt(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "ALIAS9F"))
        Dim TransDAte As Date = CDate(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "ALIAS6F"))
        My.Forms.FinancialTransDet.SqlDataSource1.Queries(0).Parameters(0).Value = Ref2
        My.Forms.FinancialTransDet.SqlDataSource1.Queries(0).Parameters(1).Value = TransDAte
        My.Forms.FinancialTransDet.SqlDataSource1.Fill()
        FinancialTransDet.Show()
    End Sub

    Private Sub GridControl2_Click(sender As Object, e As EventArgs) Handles GridControl2.Click

    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs)
        Dim FileName As String = "E:\Grid.xls"
        GridControl2.ExportToXls(FileName)
    End Sub

    Private Sub DateEditTo_EditValueChanged(sender As Object, e As EventArgs) Handles DateEditTo.EditValueChanged
        AccounStatment(CStr(Format(DateEditFrom.DateTime, "yyyy-MM-dd")), CStr(Format(DateEditTo.DateTime, "yyyy-MM-dd")))
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        AccounStatment(CStr(Format(DateEditFrom.DateTime, "yyyy-MM-dd")), CStr(Format(DateEditTo.DateTime, "yyyy-MM-dd")))
    End Sub

    Private Sub DateEditFrom_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles DateEditFrom.EditValueChanging
        AccounStatment(CStr(Format(DateEditFrom.DateTime, "yyyy-MM-dd")), CStr(Format(DateEditTo.DateTime, "yyyy-MM-dd")))
    End Sub

    Private Sub DateEditFrom_EditValueChanged(sender As Object, e As EventArgs) Handles DateEditFrom.EditValueChanged
        AccounStatment(CStr(Format(DateEditFrom.DateTime, "yyyy-MM-dd")), CStr(Format(DateEditTo.DateTime, "yyyy-MM-dd")))
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        '  Me.LayoutControl1.ShowPrintPreview()
        '  GetAccBalance()

        Try
            Dim report As New FinanceAccountDetails()
            report.AccountNo.Value = AccountNo.Text
            report.AccountName.Value = AccountName.Text
            report.Filter.Value = Filter.Text
            report.WashingPrice.Value = WashingPrice.Text
            report.SortID.Value = SortID.Text
            report.SortName.Value = SortName.Text
            report.AreaCode.Value = AreaCode.Text
            report.AreaName.Value = AreaName.Text
            report.Address.Value = Address.Text
            report.City.Value = City.Text
            report.ContectPerson.Value = ContectPerson.Text
            report.Mobile.Value = Mobile.Text
            report.Phone.Value = Phone.Text
            report.Fax.Value = Fax.Text
            report.EmployeeID.Value = EmployeeID.Text
            report.Email.Value = Email.Text
            report.VoucherNote.Value = VoucherNote.Text
            report.Notes.Value = Note.Text
            report.Sponsor.Value = Sponsor.Text
            report.Bank.Value = Bank.Text
            report.BankBranch.Value = BankBranch.Text
            report.BankAccNo.Value = BankAccNo.Text
            report.NoteManager.Value = NoteManager.Text
            report.AccBalance.Value = GetAccBalance(CStr(Format(Today, "yyyy-MM-dd")), AccountNo.Text)
            report.SumCheks.Value = GetSumCheks(CStr(DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000")), AccountNo.Text)
            report.CountCheks.Value = GetCountCheks(CStr(DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000")), AccountNo.Text)
            report.DebitTotal.Value = Val(report.SumCheks.Value) + Val(report.AccBalance.Value)
            report.AccountNo.Visible = False
            report.AccountName.Visible = False
            report.Filter.Visible = False
            report.WashingPrice.Visible = False
            report.SortID.Visible = False
            report.SortName.Visible = False
            report.AreaCode.Visible = False
            report.AreaName.Visible = False
            report.Address.Visible = False
            report.City.Visible = False
            report.ContectPerson.Visible = False
            report.Mobile.Visible = False
            report.Phone.Visible = False
            report.Fax.Visible = False
            report.EmployeeID.Visible = False
            report.Email.Visible = False
            report.VoucherNote.Visible = False
            report.Notes.Visible = False

            report.CreateDocument()
            report.PrintingSystem.ShowMarginsWarning = False
            report.Print()
        Catch ex As Exception
            MsgBox("خطا: لم يتمكن البرنامج من طباعة  تفاصيل الزبون")
        End Try

    End Sub

    Private Function GetAccBalance(ToDate As String, AccNo As String) As Integer

        Try

            Dim sql As New SQLControl
            Dim i As Integer
            Dim DebitBalance = " SELECT   cast(  sum( JMSUF ) as decimal(10,2)) as Debit    " _
            & " from RPHSTRANSRETRIV" _
            & " WHERE   JMDEBITCREDIT=1 and       ( JMACCOUNTKEY = '" & AccNo & "'  AND ('" & ToDate & "' > JVALUEDATE)  AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 "

            Dim CreditBalance = " SELECT   cast(  sum( JMSUF ) as decimal(10,2))  as Credit " _
            & " from RPHSTRANSRETRIV" _
            & " WHERE   JMDEBITCREDIT=0 and       ( JMACCOUNTKEY = '" & AccNo & "'  AND ('" & ToDate & "' > JVALUEDATE)  AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 "

            Dim DebitBalanceString As String = "0", CreditBalanceString As String = "0"
            sql.WizCountRunQuery(DebitBalance)
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(i).Item("Debit")) Then DebitBalanceString = CType(sql.SQLDS.Tables(0).Rows(i).Item("Debit"), String)

            sql.WizCountRunQuery(CreditBalance)
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(i).Item("Credit")) Then CreditBalanceString = CType(sql.SQLDS.Tables(0).Rows(i).Item("Credit"), String)

            GetAccBalance = CInt(DebitBalanceString) - CInt(CreditBalanceString)

            Return GetAccBalance
        Catch ex As Exception

        End Try

        Return GetAccBalance

    End Function

    Private Function GetCheks(FromDate As String, ToDate As String, AccNo As String) As Integer

        Try
            Dim sql As New SQLControl
            Dim SqlString As String = " SELECT  [CheqNumber]      ,[BankNumber]      ,[Branch]      ,[BankAccNum]      ,[ValueDate]      ,[SuF] ,
                                                [Currency]      ,[DepositID]      ,[DepositFlag]      ,CASE WHEN SuFDlr  = 0 THEN SuF   else SuFDlr   END AS NIS,
                                                 CONVERT(nvarchar(6), ValueDate, 112) As ValueMonth 
                                        FROM [ALHUDA].[dbo].[Cheqs]
                                        Where AccKey='" & AccNo & "' and ValueDate between  '" & FromDate & "' and  '" & ToDate & "'  Order By ValueDate"

            sql.WizCountRunQuery(SqlString)
            GridControl1.DataSource = sql.SQLDS.Tables(0)
            Return GetCheks
        Catch ex As Exception

        End Try
        Return GetCheks
    End Function

    Private Sub SimpleButton9_Click_1(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        DateEdit1.DateTime = CDate(DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000"))
        DateEdit2.DateTime = CDate(DateTime.Now.AddYears(+1).ToString("yyyy-MM-dd 00:00:00.000"))
        GetCheks(CStr(Format(DateEdit1.DateTime, "yyyy-MM-dd")), CStr(Format(DateEdit2.DateTime, "yyyy-MM-dd")), AccountKeyTextEdit.Text)
    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles SimpleButton10.Click

        Try
            Dim sql As New SQLControl
            Dim SqlString As String = " SELECT  [CheqNumber]      ,[BankNumber]      ,[Branch]      ,[BankAccNum]      ,[ValueDate]      ,[SuF] ,
                                           [Currency]      ,[DepositID]      ,[DepositFlag]      ,CASE WHEN SuFDlr  = 0 THEN SuF   else SuFDlr   END AS NIS
                                    FROM [ALHUDA].[dbo].[Cheqs]
                                    Where DepositFlag=0 and AccKey='" & AccountKeyTextEdit.Text & "'  Order By ValueDate"

            sql.WizCountRunQuery(SqlString)
            GridControl1.DataSource = sql.SQLDS.Tables(0)
        Catch ex As Exception

        End Try

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

    Private Function GetCountCheks(FromDate As String, AccNo As String) As Integer

        Try
            Dim sql As New SQLControl
            Dim i As Integer

            Dim SqlString As String = "SELECT Count(NIS) as NIS2
                                    FROM
                                    (  SELECT  CASE WHEN SuFDlr= 0 THEN SuF else SuFDlr END AS NIS
		                            FROM [ALHUDA].[dbo].[Cheqs]
		                            where AccKey='" & AccNo & "' and ValueDate > '" & FromDate & "' ) as TotalNis"

            sql.WizCountRunQuery(SqlString)
            If Not IsDBNull(sql.SQLDS.Tables(0).Rows(i).Item("NIS2")) Then GetCountCheks = CType(sql.SQLDS.Tables(0).Rows(i).Item("NIS2"), Integer)
        Catch ex As Exception

        End Try

        Return GetCountCheks

    End Function

    Private Sub NavigationPane1_Click(sender As Object, e As EventArgs) Handles NavigationPane1.Click
        GetAddData()
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        Try
            Dim report As New FinanceAccountDetails()
            report.AccountNo.Value = String.Empty
            report.AccountName.Value = String.Empty
            report.Filter.Value = String.Empty
            report.WashingPrice.Value = String.Empty
            report.SortID.Value = String.Empty
            report.SortName.Value = String.Empty
            report.AreaCode.Value = String.Empty
            report.AreaName.Value = String.Empty
            report.Address.Value = String.Empty
            report.City.Value = String.Empty
            report.ContectPerson.Value = String.Empty
            report.Mobile.Value = String.Empty
            report.Phone.Value = String.Empty
            report.Fax.Value = String.Empty
            report.EmployeeID.Value = String.Empty
            report.Email.Value = String.Empty
            report.VoucherNote.Value = String.Empty
            report.Notes.Value = String.Empty
            report.Sponsor.Value = String.Empty
            report.Bank.Value = String.Empty
            report.BankBranch.Value = String.Empty
            report.BankAccNo.Value = String.Empty
            report.NoteManager.Value = String.Empty
            report.AccBalance.Value = String.Empty
            report.SumCheks.Value = String.Empty
            report.CountCheks.Value = String.Empty

            report.AccountNo.Visible = False
            report.AccountName.Visible = False
            report.Filter.Visible = False
            report.WashingPrice.Visible = False
            report.SortID.Visible = False
            report.SortName.Visible = False
            report.AreaCode.Visible = False
            report.AreaName.Visible = False
            report.Address.Visible = False
            report.City.Visible = False
            report.ContectPerson.Visible = False
            report.Mobile.Visible = False
            report.Phone.Visible = False
            report.Fax.Visible = False
            report.EmployeeID.Visible = False
            report.Email.Visible = False
            report.VoucherNote.Visible = False
            report.Notes.Visible = False

            report.CreateDocument()
            report.PrintingSystem.ShowMarginsWarning = False
            report.Print()
        Catch ex As Exception
            MsgBox("خطا: لم يتمكن البرنامج من طباعة  تفاصيل الزبون")
        End Try
    End Sub

    Private Sub SimpleButton11_Click(sender As Object, e As EventArgs) Handles SimpleButton11.Click
        GetDat()
        GetAddData()
    End Sub

    Private Sub SimpleButton12_Click(sender As Object, e As EventArgs) Handles SimpleButton12.Click


        Try
            Dim RightHeader As String, MiddleHeader As String, LeftHeader As String
            RightHeader = String.Empty
            MiddleHeader = "تقرير الشيكات المدفوعة " & " " & " " & Me.TextEdit2.Text & " " & Me.AccountKeyTextEdit.Text
            LeftHeader = WizCountOrpak.Text

            Dim RightFooter As String = "Pages: [Page # of Pages #]"
            Dim MiddleFooter As String = "User: [User Name]"
            Dim LeftFooter As String = "Date: [Date Printed]"




            Dim grids As Control() = New Control() {GridControl1}

            Dim ps As New DevExpress.XtraPrinting.PrintingSystem()
            Dim compositeLink As New DevExpress.XtraPrintingLinks.CompositeLink()
            compositeLink.PrintingSystem = ps

            For Each grid As Control In grids
                Dim link As New DevExpress.XtraPrinting.PrintableComponentLink()
                link.Component = CType(grid, DevExpress.XtraPrinting.IPrintable)
                compositeLink.Links.Add(link)
                link.PrintingSystem.Document.AutoFitToPagesWidth = 1
            Next

            compositeLink.Landscape = False
            compositeLink.Margins.Left = 2
            compositeLink.Margins.Right = 2

            'compositeLink.PrintingSystem.PageMargins.Left = 0
            'compositeLink.PrintingSystem.PageMargins.Right = 0
            'compositeLink.PrintingSystem.PageMargins.Top = 0
            'compositeLink.PrintingSystem.PageMargins.Bottom = 0

            Dim phf As DevExpress.XtraPrinting.PageHeaderFooter =
           TryCast(compositeLink.PageHeaderFooter, DevExpress.XtraPrinting.PageHeaderFooter)
            phf.Header.Content.Clear()
            phf.Header.Content.AddRange(New String() _
            {RightHeader, MiddleHeader, LeftHeader})
            phf.Header.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Far

            phf.Footer.Content.Clear()
            phf.Footer.Content.AddRange(New String() _
            {RightFooter, MiddleFooter, LeftFooter})
            phf.Footer.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Far


            compositeLink.CreateDocument()

            compositeLink.ShowPreview()
        Catch ex As Exception
            MsgBox("لا يوجد بيانات")
        End Try


    End Sub




    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        RadioGroup1.SelectedIndex = 1
        GridView3.Columns("Quant").Visible = False
        GridView3.Columns("Product").Visible = False
        WizCountOrpak.Text = "تقرير مالي"
        '  RadioGroup1.SelectedIndex = 1
        CraetMonthlyChartWaleet(AccountKeyTextEdit.Text)
    End Sub

    Private Sub SimpleButton13_Click(sender As Object, e As EventArgs) Handles SimpleButton13.Click
        RadioGroup1.SelectedIndex = 0

    End Sub

    Private Sub SimpleButton14_Click(sender As Object, e As EventArgs) Handles SimpleButton14.Click
        RadioGroup1.SelectedIndex = 1
    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick
        'MsgBox("هل تريد طباعة الشيك")

        Try
            Dim CheqNO As String = CType(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CheqNumber"), String)
            Dim CheqAccNo As String = CType(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "BankAccNum"), String)
            Dim SqlString As String = "Select (ID) As ChequeID from Checks where [ACCOUNT_NO]= '" & CheqAccNo & "' and [CHECK_NO] ='" & CheqNO & "'"
            Dim CheuqeID As Integer
            Dim sql As New SQLControl

            sql.ChuquesRunQuery(SqlString)
            If sql.SQLDS.Tables(0).Rows.Count = 0 Then XtraMessageBox.Show("لا يوجد صورة متوفرة للشيك المطلوب") : Exit Sub
            CheuqeID = CInt((sql.SQLDS.Tables(0).Rows(0).Item("ChequeID")))

            Dim report As New ChequesImages()
            report.Parameter1.Value = CheuqeID
            report.Parameter2.Value = AccountName.Text
            report.Parameter1.Visible = False
            report.Parameter2.Visible = False
            report.CreateDocument()
            report.PrintingSystem.ShowMarginsWarning = False
            report.Print()
        Catch ex As Exception
            MsgBox("خطا: لم يتمكن البرنامج من طباعة الشيك")
        End Try


    End Sub

    Private Sub SimpleButton15_Click(sender As Object, e As EventArgs) Handles SimpleButton15.Click
        Dim i As Integer
        Dim CheqNO As String
        Dim CheqAccNo As String
        Dim SqlString As String
        Dim CheuqeID As Integer
        Dim sql As New SQLControl
        Dim ArrCheq(GridView1.RowCount - 1) As Integer
        Dim myList As String = ""
        Dim ChequesCount As Integer = 0


        For i = 0 To GridView1.RowCount - 1
            CheqNO = CType(GridView1.GetRowCellValue(i, "CheqNumber"), String)
            CheqAccNo = CType(GridView1.GetRowCellValue(i, "BankAccNum"), String)
            SqlString = "Select (ID) As ChequeID from Checks where [ACCOUNT_NO]= '" & CheqAccNo & "' and [CHECK_NO] ='" & CheqNO & "'"
            sql.ChuquesRunQuery(SqlString)
            If sql.SQLDS.Tables(0).Rows.Count > 0 Then
                CheuqeID = CInt((sql.SQLDS.Tables(0).Rows(0).Item("ChequeID")))
                ChequesCount = ChequesCount + 1
            End If
        Next i

        Dim result As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("هل تريد طباعة شيكات عدد : " & ChequesCount, "تأكيد", MessageBoxButtons.YesNo)
        If result = System.Windows.Forms.DialogResult.Yes Then


            For i = 0 To GridView1.RowCount - 1
                CheqNO = CType(GridView1.GetRowCellValue(i, "CheqNumber"), String)
                CheqAccNo = CType(GridView1.GetRowCellValue(i, "BankAccNum"), String)
                SqlString = "Select (ID) As ChequeID from Checks where [ACCOUNT_NO]= '" & CheqAccNo & "' and [CHECK_NO] ='" & CheqNO & "'"
                sql.ChuquesRunQuery(SqlString)
                If sql.SQLDS.Tables(0).Rows.Count > 0 Then
                    CheuqeID = CInt((sql.SQLDS.Tables(0).Rows(0).Item("ChequeID")))
                    Try
                        Dim report As New ChequesImages()
                        report.Parameter1.Value = CheuqeID
                        report.Parameter2.Value = AccountName.Text
                        report.Parameter1.Visible = False
                        report.Parameter2.Visible = False
                        report.CreateDocument()
                        report.PrintingSystem.ShowMarginsWarning = False
                        report.Print()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            Next i


        End If

    End Sub

    Private Sub SimpleButton16_Click(sender As Object, e As EventArgs) Handles SimpleButton16.Click
        Dim i As Integer
        Dim CheqNO As String
        Dim CheqAccNo As String
        Dim SqlString As String
        Dim sql As New SQLControl
        Dim ArrCheq(GridView1.RowCount - 1) As Integer
        Dim myList As String = ""
        Dim ChequesCount As Integer = 0
        Dim IDTable As New DataTable






        For i = 0 To GridView1.RowCount - 1
            CheqNO = CType(GridView1.GetRowCellValue(i, "CheqNumber"), String)
            CheqAccNo = CType(GridView1.GetRowCellValue(i, "BankAccNum"), String)
            SqlString = "Select (ID) As ChequeID ,FrontImage,CHECK_NO,ACCOUNT_NO,SORT_ID,IB_BANK_ID  from Checks where [ACCOUNT_NO]= '" & CheqAccNo & "' and [CHECK_NO] ='" & CheqNO & "'"
            sql.ChuquesRunQuery(SqlString)
            If sql.SQLDS.Tables(0).Rows.Count > 0 Then
                IDTable.Merge(sql.SQLDS.Tables(0))
            End If
        Next i




        GridControl4.DataSource = IDTable
    End Sub

    Private Sub SimpleButton17_Click(sender As Object, e As EventArgs) Handles SimpleButton17.Click
        Dim result As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("هل تريد طباعة شيكات عدد : " & GridView3.RowCount, "تأكيد", MessageBoxButtons.YesNo)
        If result = System.Windows.Forms.DialogResult.Yes Then
            GridControl4.ShowPrintPreview()
        End If
    End Sub

    Private Sub AccountKeyTextEdit_DoubleClick(sender As Object, e As EventArgs) Handles AccountKeyTextEdit.DoubleClick
        FinanceSelectAccount.TextEdit1.Text = Me.Name.ToString
        FinanceSelectAccount.Show()
    End Sub


    '  Private Sub SimpleButton15_Click(sender As Object, e As EventArgs) Handles SimpleButton15.Click
    '      Dim View As DevExpress.XtraGrid.Views.Grid.GridView = CType(GridControl1.MainView,
    'DevExpress.XtraGrid.Views.Grid.GridView)
    '      If Not View Is Nothing Then
    '          View.OptionsPrint.ExpandAllDetails = True
    '          View.ExportToPdf("e:\MainViewData.pdf")
    '      End If
    '  End Sub

    Private Sub GridView1_CustomDrawCell(ByVal sender As Object,
ByVal e As RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell

        'Dim ImageSent As Image = My.Resources.Sent
        'Dim ImageFalse As Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/close_16x16.png")


        'Dim View As GridView = CType(sender, GridView)


        'If e.Column.FieldName = "DepositFlag" Then
        '    Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("DepositFlag"))

        '    If category = "1" Then
        '        e.Graphics.DrawImage(ImageSent, e.Bounds.Location)
        '        e.DisplayText = ""
        '    End If

        '    If category = "0" Then
        '        e.Graphics.DrawImage(ImageFalse, e.Bounds.Location)
        '        e.DisplayText = ""
        '    End If


        'End If



    End Sub

End Class