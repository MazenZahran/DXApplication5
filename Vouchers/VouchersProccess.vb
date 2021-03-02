Imports DevExpress.XtraGrid.Views.Base

Public Class VouchersProccess
    Private Sub VouchersProccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
        'TODO: This line of code loads data into the 'CRMDataSet.DATA' table. You can move, or remove it, as needed.
        '  Me.DATATableAdapter.Fill(Me.CRMDataSet.DATA)
        Me.DATATableAdapter.FillByFleetMonthYear(Me.CRMDataSet.DATA, CStr(SearchFleetID.EditValue), YyearText.Text, MmonthText.Text)
        GetAccountStatment()
        GetPrices()


    End Sub

    Private Sub DATABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DATABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Validate()
        Me.DATABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)
    End Sub

    Private Sub GridView2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView2.InitNewRow
        Dim MMonth As String = MmonthText.Text
        Dim Yyear As String = YyearText.Text
        Dim FleetID As String = CStr(SearchFleetID.EditValue)
        Dim FleetName As String = CStr(SearchFleetID.Text)


        Try
            With Me.GridView2
                .SetRowCellValue(e.RowHandle, "TransMonth", MMonth)
                .SetRowCellValue(e.RowHandle, "TransYear", Yyear)
                .SetRowCellValue(e.RowHandle, "TransTime", "00:00:00")
                .SetRowCellValue(e.RowHandle, "TransID", "1")
                .SetRowCellValue(e.RowHandle, "SerNo", "1")
                .SetRowCellValue(e.RowHandle, "DeviceName", "1")
                .SetRowCellValue(e.RowHandle, "FleetCode", FleetID)
                .SetRowCellValue(e.RowHandle, "Fleet", FleetName)
                '.SetRowCellValue(e.RowHandle, "Price", _Price)
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GetAccountStatment()
        Dim sql As New SQLControl
        Dim AccountStatmentss As String = " SELECT     JVALUEDATE ,    JREFERANCE  ,  JREF2  ,  JDESCRIPTION  ,   CASE JMDEBITCREDIT WHEN 1 THEN  JMSUF  ELSE 0 END AS ALIAS12F_DEB, CASE JMDEBITCREDIT WHEN 0 THEN  JMSUF  ELSE 0 END AS ALIAS12F_CR 
         , RPHSTRANSRETRIV. JMID  As ALIAS2F  from RPHSTRANSRETRIV
         WHERE          ( JMACCOUNTKEY = '" & CStr(SearchFleetID.EditValue) & "'  AND ( DatePart(MONTH, JVALUEDATE)=" & MmonthText.Text & " and DatePart(Year, JVALUEDATE)=  " & YyearText.Text & " ) AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 
         order by   JVALUEDATE ASC  , JMID ASC   "
        sql.WizCountRunQuery(AccountStatmentss)
        GridControl1.DataSource = sql.SQLDS.Tables(0)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GetAccountStatment()
        Me.DATATableAdapter.FillByFleetMonthYear(Me.CRMDataSet.DATA, CStr(SearchFleetID.EditValue), YyearText.Text, MmonthText.Text)
        Me.TextDiff.EditValue = CInt(colTotalSale.SummaryItem.SummaryValue.ToString) - CInt(ColALIAS12F_DEB.SummaryItem.SummaryValue.ToString)
    End Sub


    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        DATABindingSource.RemoveCurrent()
    End Sub

    Private Sub GetPrices()

        Try
            Dim Sql As New SQLControl
            Dim SqlString As String = "SELECT       [PRICE]
  FROM [WALLET].[dbo].[PRICELIST]
  where  DatePart(month,DATEFROM)=" & MmonthText.Text & " and DATEPART(year,DATEFROM)=" & YyearText.Text & " and (ITEMKEY=1 or ITEMKEY=2) order by ITEMKEY  "
            Sql.WalletRunQuery(SqlString)
            TextDieselPrice.Text = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("PRICE"))
            Text95Price.Text = CStr(Sql.SQLDS.Tables(0).Rows(1).Item("PRICE"))
        Catch ex As Exception

        End Try




    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick

    End Sub

    Private Sub RepositoryPreview_Click(sender As Object, e As EventArgs) Handles RepositoryPreview.Click
        Dim Ref2 As Integer = CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "JREF2"))
        Dim TransDAte As Date = CDate(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "JVALUEDATE"))
        My.Forms.FinancialTransDet.SqlDataSource1.Queries(0).Parameters(0).Value = Ref2
        My.Forms.FinancialTransDet.SqlDataSource1.Queries(0).Parameters(1).Value = TransDAte
        My.Forms.FinancialTransDet.SqlDataSource1.Fill()
        FinancialTransDet.Show()
    End Sub


    Private Sub GridView2_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView2.CellValueChanged

        Try
            Dim _ProductName As String = CStr(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "ProductName"))
            Dim _Price As Decimal = 0
            If _ProductName = "سولار" Then _Price = CDec(TextDieselPrice.EditValue)
            If _ProductName = "بنزين95" Then _Price = CDec(Text95Price.EditValue)

            If e.Column.FieldName = "Quantity" Or e.Column.FieldName = "Price" Then
                Try
                    Dim Quant As Decimal = CDec(Me.GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Quantity"))
                    Dim Pric As Decimal = CDec(Me.GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Price"))
                    Dim Amont As Decimal = CDec((Quant * Pric).ToString("N2"))
                    GridView2.SetRowCellValue(GridView2.FocusedRowHandle, colTotalSale, Amont)
                Catch ex As Exception
                    GridView2.SetRowCellValue(GridView2.FocusedRowHandle, colTotalSale, "0")
                    ' MsgBox(ex.ToString)
                End Try
            End If

            If e.Column.FieldName = "ProductName" Then
                GridView2.SetRowCellValue(GridView2.FocusedRowHandle, colPrice, _Price)
            End If
        Catch ex As Exception
            ' MsgBox(ex.ToString)
        End Try


    End Sub

End Class