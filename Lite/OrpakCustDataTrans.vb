Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class OrpakCustDataTrans
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Getdata()
        IssueVouchergetDetails()

    End Sub


    Private Sub Financereceipt_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F11 Then
            EditTrans()
        ElseIf e.KeyCode = Keys.F5 Then
            Getdata()
            IssueVouchergetDetails()
        ElseIf e.KeyCode = Keys.F12 Then
            PrintReport()
        End If
    End Sub
    Private Sub Getdata()

        Select Case cstr(CheckFromOrpak.EditValue)
            Case "True"
                Try
                    Dim SqlString As String
                    Dim sql As New SQLControl
                    SqlString = " select T.[timestamp] , [date] as TransDate,CONVERT(varchar(5), [time], 108) as TransTime,[plate] as Vehicle_Number ," & ProductNameCase() & ",[quantity] as Quantity,CONVERT(DECIMAL(10,2),ppv )as Price,
                         [sale] as TotalSale,stations.stn_name as StationName,receipt_d.receipt_id as Receipt,Odometer
                          From [HO_DATA].[dbo].[transactions] T
                          left join stations  on stations.stn_id = T.stn_id 
                          left join fleets ON T.fleet_id = fleets.id 
                          left join receipt_d ON T.id = receipt_d.transaction_id  AND T.stn_id = receipt_d.stn_id
                          where quantity > 0 and DatePart(year, Date) = " & TextEditYear.Text & " 
                          and DatePart(month, Date) = " & TextEditMonth.Text & " 
                          And fleets.code ='" & CStr(FleetCode.EditValue) & "' "
                    If CheckFilterCars.Checked = True And GlobalVariables.FilteredCars <> "" Then
                        SqlString += " and T.plate In " & GlobalVariables.FilteredCars
                    End If
                    SqlString += "  Order by [timestamp] "
                    Select Case CInt(TextEditYear.Text)
                        Case >= 2020
                            sql.RunQuery(SqlString)
                        Case < 2020
                            sql.OldOrpakRunQuery(SqlString)
                    End Select


                    GridControl1.DataSource = sql.SQLDS.Tables(0)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                Try
                    Dim sql As New SQLControl
                    Dim SqlString As String = "select  sum(quantity) as Quantity, sum(sale) as Amount," & ProductNameCase() & ",CONVERT(DECIMAL(10,2),sum(sale)/ISNULL(sum(quantity), 1)) as Price
                          from [HO_DATA].[dbo].[transactions] 
                          left join fleets ON transactions.fleet_id = fleets.id 
                          where quantity > 0  and DatePart(year, Date) = " & TextEditYear.Text & " and DatePart(month, Date) = " & TextEditMonth.Text & " And fleets.code ='" & CStr(FleetCode.EditValue) & "'"
                    If CheckFilterCars.Checked = True Then
                        SqlString += " and transactions.plate In " & GlobalVariables.FilteredCars
                    End If
                    SqlString += " group by product_name "
                    sql.RunQuery(SqlString)
                    GridControl2.DataSource = sql.SQLDS.Tables(0)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case "False"
                Try
                    Dim SqlString As String
                    Dim sql As New SQLControl
                    SqlString = " select ID,TransDate,CONVERT(varchar(5), [TransTime], 108) as TransTime,Vehicle_Number,ProductName as SotckName ,Quantity,CONVERT(DECIMAL(10,2),TotalSale/Quantity)as Price,
                          TotalSale,StationName,Receipt,Odometer
                          from [CRM].[dbo].[DATA]
                          where Quantity > 0 and TransMonth='" & TextEditMonth.Text & "' 
                          and TransYear = '" & TextEditYear.Text & "' 
                          and FleetCode ='" & CStr(FleetCode.EditValue) & "'"
                    If CheckWithoutWalletTrans.Checked = True Then
                        SqlString += " and StationName <>'Stock' "
                    End If
                    If CheckFilterCars.Checked = True Then
                        SqlString += " and [Vehicle_Number] In " & GlobalVariables.FilteredCars
                    End If
                    SqlString += " Order By TransDate"
                    sql.CRMRunQuery(SqlString)
                    GridControl1.DataSource = sql.SQLDS.Tables(0)

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                Try
                    Dim sql As New SQLControl
                    Dim SqlString As String = "select sum(Quantity) as Quantity, sum(TotalSale) as Amount, ProductName as SotckName ,CONVERT(DECIMAL(10,2),TotalSale/Quantity) as Price
                          from [CRM].[dbo].[DATA]
                          where Quantity > 0 and TransMonth='" & TextEditMonth.Text & "' and TransYear = '" & TextEditYear.Text & "' and FleetCode ='" & CStr(FleetCode.EditValue) & "'"
                    If CheckWithoutWalletTrans.Checked = True Then
                        SqlString += " and StationName <>'Stock' "
                    End If
                    If CheckFilterCars.Checked = True Then
                        SqlString += " and [Vehicle_Number] In " & GlobalVariables.FilteredCars
                    End If
                    SqlString += " group by ProductName,CONVERT(DECIMAL(10,2),TotalSale/Quantity)"

                    sql.CRMRunQuery(SqlString)
                    GridControl2.DataSource = sql.SQLDS.Tables(0)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
        End Select





        'Try
        '    Dim SqlString As String
        '    Dim sql As New SQLControl
        '    SqlString = " select TransDate,CONVERT(varchar(5), [TransTime], 108) as TransTime,Vehicle_Number,ProductName,Quantity,CONVERT(DECIMAL(10,2),TotalSale/Quantity)as Price,
        '                  TotalSale,StationName,Receipt,Odometer
        '                  from [CRM].[dbo].[DATA]
        '                  where Quantity > 0 and TransMonth='" & TextEditMonth.Text & "' and TransYear = '" & TextEditYear.Text & "' and FleetCode ='" & CStr(FleetCode.EditValue) & "' "
        '    sql.CRMRunQuery(SqlString)
        '    GridControl1.DataSource = sql.SQLDS.Tables(0)

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try

        'Try
        '    Dim sql As New SQLControl
        '    Dim SqlString As String = "select sum(Quantity) as Quantity, sum(TotalSale) as TotalSale, ProductName,CONVERT(DECIMAL(10,2),TotalSale/Quantity)as Price
        '                  from [CRM].[dbo].[DATA]
        '                  where Quantity > 0 and TransMonth='" & TextEditMonth.Text & "' and TransYear = '" & TextEditYear.Text & "' and FleetCode ='" & CStr(FleetCode.EditValue) & "' 
        '                  group by ProductName,CONVERT(DECIMAL(10,2),TotalSale/Quantity) "
        '    sql.CRMRunQuery(SqlString)
        '    GridControl2.DataSource = sql.SQLDS.Tables(0)
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try


    End Sub

    Private Sub OrpakCustomerTrans2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
        CheckFilterCars.Checked = False
        LayoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

        If CheckFromForm.Checked = True Then
            Getdata()
            PrintReport()
            Me.Close()
        Else
            Me.TextEditMonth.EditValue = CInt(Format(Today, "MM")) - 1
            If CInt(Format(Today, "MM")) = 1 Then Me.TextEditMonth.EditValue = 12
            Me.TextEditYear.Text = Format(Today, "yyyy")
            If CInt(Format(Today, "MM")) = 1 Then Me.TextEditYear.EditValue = CInt(Format(Today, "yyyy")) - 1
        End If

        RadioGroup1.EditValue = "Print"

        Me.KeyPreview = True
    End Sub

    Private Sub PrintReport()
        If GridView1.RowCount = 0 Or GridView2.RowCount = 0 Then
            Exit Sub
        End If
        Dim report As New LiteCustomerTrans()
        report.PrintableComponentContainer1.PrintableComponent = GridControl1
        report.PrintableComponentContainer2.PrintableComponent = GridControl2
        report.XrLabelMonth.Text = TextEditYear.Text & " / " & TextEditMonth.Text
        report.XrLabelAccID.Text = CStr(FleetCode.EditValue) & " : " & FleetCode.Text

        If CheckEditShowBalance.Checked = True Then
            report.XrLabelRequirdAmount.Visible = True
            report.XrLabelRequirdAmount.Text = "المبلغ المطلوب حتى نهاية " & report.XrLabelMonth.Text & " :  " & CStr(GetAccountBalance(CStr(FleetCode.EditValue), CInt(TextEditYear.Text), CInt(TextEditMonth.Text)))
        End If

        Dim preview As New ReportPrintTool(report)
        Select Case CStr(RadioGroup1.EditValue)
            Case "Print"
                preview.Print()
            Case "Preview"
                preview.ShowRibbonPreview()
            Case "Email"
                EmailDataTrans(CustEmail.Text, report, "تقرير الحركات")
        End Select
    End Sub

    Private Sub CheckEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEnglish.CheckedChanged

        GridControl1.ForceInitialize()
        GridControl2.ForceInitialize()
        If CheckEnglish.Checked = True Then
            ColTransDate.Caption = "Date"
            ColTransTime.Caption = "Time"
            ColPlate.Caption = "Plate"
            Colreceipt_id.Caption = "Receipt No."
            Colstn_name.Caption = "Station"
            ColProduct.Caption = "Product"
            Colquantity.Caption = "Quantity"
            ColPrices.Caption = "Price"
            ColSale.Caption = "Amount"
            Colodometer.Caption = "Odometer"
            Colmean_name.Caption = "Card No."
            Colproduct_name.Caption = "Product"
            ColSumQ.Caption = "Quantity"
            ColPrice.Caption = "Price"
            ColSumSale.Caption = "Sum"
            '  Me.RightToLeft = RightToLeft.No

        Else
            ColTransDate.Caption = "التاريخ"
            ColTransTime.Caption = "الوقت"
            ColPlate.Caption = "المركبة"
            Colreceipt_id.Caption = "رقم الوصل"
            Colstn_name.Caption = "المحطة"
            ColProduct.Caption = "الصنف"
            Colquantity.Caption = "الكمية"
            ColPrices.Caption = "السعر"
            ColSale.Caption = "المبلغ"
            Colodometer.Caption = "العداد"
            Colmean_name.Caption = "رقم الكرت"
            Colproduct_name.Caption = "الصنف"
            ColSumQ.Caption = "المبلغ"
            ColPrice.Caption = "السعر"
            ColSumSale.Caption = "المجموع"
            '  Me.RightToLeft = RightToLeft.Yes
        End If



    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        PrintReport()
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged

        Select Case CStr(RadioGroup1.EditValue)
            Case "Email"
                CustEmail.Text = GetAccData(CStr(FleetCode.EditValue)).email
                LayoutEmail.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
#Disable Warning CA1303 ' Do not pass literals as localized parameters
                SimpleButton2.Text = "Email"
#Enable Warning CA1303 ' Do not pass literals as localized parameters
            Case "Preview"
                SimpleButton2.Text = "معاينة الطباعة"
                LayoutEmail.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Case Else
                LayoutEmail.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
#Disable Warning CA1303 ' Do not pass literals as localized parameters
                SimpleButton2.Text = "طباعة"
#Enable Warning CA1303 ' Do not pass literals as localized parameters
        End Select
    End Sub

    Private Sub TextEditMonth_EditValueChanged(sender As Object, e As EventArgs) Handles TextEditMonth.EditValueChanged
        GetPrices()
    End Sub

    Private Sub IssueVouchergetDetails()
        Try
            Me.VoucherDate.DateTime = New DateTime(CInt(Me.TextEditYear.Text), CInt(Me.TextEditMonth.Text), DateTime.DaysInMonth(CInt(Me.TextEditYear.Text), CInt(Me.TextEditMonth.Text)))

            If CheckIssueVoucher.Checked = True Then
                LayoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                TextOldVouchersAmount.EditValue = GetTotalVoucherForMnthByCustomer(CInt(Me.TextEditMonth.Text), CInt(Me.TextEditYear.Text), CStr(Me.FleetCode.EditValue))
                TextDebitTotal.EditValue = GetDebitBalance(CStr(Me.FleetCode.EditValue), CInt(Me.TextEditYear.Text), CInt(Me.TextEditMonth.Text))

            Else
                LayoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            End If

            CustEmail.Text = GetAccData(CStr(FleetCode.EditValue)).email
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

        If GridView1.RowCount = 0 Or GridView2.RowCount = 0 Then
            MsgBox(" لا يوجد بيانات ")
            Exit Sub
        End If

        Dim Diff As Integer = 0
        Try
            Diff = Math.Abs(CInt(TextDebitTotal.EditValue) - CInt(ColSumSale.SummaryItem.SummaryValue.ToString))
        Catch ex As Exception

        End Try

        Try

            If Diff > 40 And XtraMessageBox.Show(" انتيه يا  " & GlobalVariables.UserNameString & " يوجد فرق " & Diff & " شيكل هل تريد المتابعة؟ ", "تنبيه", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Exit Sub
            Else
                If XtraMessageBox.Show("هل تريد اصدار الفاتورة؟", "تنبيه", MessageBoxButtons.YesNo) <> DialogResult.No Then
                    Dim VoucherCode As String
                    VoucherCode = GetRandomString()
                    Dim AccountID As String = CStr(FleetCode.EditValue)
                    IssueVoucherFromData(CStr(VoucherDate.DateTime), CStr(FleetCode.EditValue), FleetCode.Text, GetAccData(AccountID).SortGroup, GetAccData(AccountID).costcode, GetAccData(AccountID).Addresss,
                    ColSumSale.SummaryItem.SummaryValue.ToString, VoucherCode, TextVoucherNote.Text, CInt(Me.TextEditMonth.Text), CInt(Me.TextEditYear.Text), "Station")
                    XtraMessageBox.Show("تم اصدار الفاتورة", "تاكيد", MessageBoxButtons.OK)
                    TextDebitTotal.EditValue = GetDebitBalance(CStr(Me.FleetCode.EditValue), CInt(Me.TextEditYear.Text), CInt(Me.TextEditMonth.Text))
                End If
            End If
        Catch ex As Exception
            MsgBox("لا يمكن اصدار الفاتورة")
        End Try

    End Sub

    Private Sub CheckIssueVoucher_CheckedChanged(sender As Object, e As EventArgs) Handles CheckIssueVoucher.CheckedChanged


        If CheckIssueVoucher.Checked = True Then
            LayoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            LayoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
        IssueVouchergetDetails()
    End Sub


    Private Sub EditTrans()
        If CheckFromOrpak.Checked = False Then
            LiteEditSingleTrans.ID.Text = CStr(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID"))
            If LiteEditSingleTrans.ShowDialog() = DialogResult.OK Then
                ' Form was closed via OK button or similar, continue normally... '
                MsgBox("ok")
            Else
                ' Form was aborted via Cancel, Close, or some other way; do something '
                ' else like quitting the application... '
                Getdata()
            End If


            'With My.Forms.LiteEditSingleTrans
            '    .ID.Text = CStr(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID"))
            '    .ShowDialog()
            'End With
        End If

    End Sub

    Private Sub CheckFromOrpak_CheckedChanged(sender As Object, e As EventArgs) Handles CheckFromOrpak.CheckedChanged
        'If CheckFromOrpak.Checked = True Then
        '    CheckIssueVoucher.Checked = False
        '    CheckIssueVoucher.Enabled = False
        'Else
        '    CheckIssueVoucher.Enabled = True
        'End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        ' issue sub voucher
        Getdata()

        If IssueVoucherAuthentication() = False Then
            MsgBox("البرنامج تحت الصيانة ، اصبر اشوي يا  " & CStr(GlobalVariables.UserNameString))
            Exit Sub
        End If

        If GridView1.RowCount = 0 Or GridView2.RowCount = 0 Then
            MsgBox(" لا يوجد بيانات ")
            Exit Sub
        End If

        Dim Diff As Integer = 0
        Try
            Diff = Math.Abs(CInt(TextDebitTotal.EditValue) - CInt(ColSumSale.SummaryItem.SummaryValue.ToString))
        Catch ex As Exception

        End Try


        If Diff > 40 And XtraMessageBox.Show(" انتيه يا  " & GlobalVariables.UserNameString & " يوجد فرق " & Diff & " شيكل هل تريد المتابعة؟ ", "تنبيه", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            Exit Sub
        Else
            If XtraMessageBox.Show("هل تريد اصدار الفاتورة؟", "تنبيه", MessageBoxButtons.YesNo) <> DialogResult.No Then

                Dim _VoucherCode As String
                Dim _CustomeID As String
                Dim _Sort As String
                Dim _Area As String
                Dim _Address As String = ""

                _CustomeID = CStr(FleetCode.EditValue)
                _Sort = GetAccData(_CustomeID).SortGroup
                _Area = GetAccData(_CustomeID).costcode
                _Address = GetAccData(_CustomeID).Addresss


                _VoucherCode = GetRandomString()
                Dim TestTable As DataTable = CType(GridControl2.DataSource, DataTable)
                Dim _VoucherDate As String = Format(VoucherDate.DateTime, "yyyy-MM-dd")
                Dim mm = IssueVoucherFromOut(_VoucherDate, _CustomeID, Me.FleetCode.Text, _Sort, _Area, _Address,
                            CDec(ColSumSale.SummaryItem.SummaryValue.ToString),
                            _VoucherCode, TextVoucherNote.Text, CInt(Format(VoucherDate.DateTime, "MM")),
                            CInt(Format(VoucherDate.DateTime, "yyyy")), "Station", "NIS", CType(GridControl2.DataSource, DataTable))


                If XtraMessageBox.Show("تم اصدار فاتورة هل تريد طباعة الكشف", "تنبيه", MessageBoxButtons.YesNo) <> DialogResult.No Then
                    PrintReport()
                End If
                TextDebitTotal.EditValue = GetDebitBalance(CStr(Me.FleetCode.EditValue), CInt(Me.TextEditYear.Text), CInt(Me.TextEditMonth.Text))
            End If
        End If


    End Sub

    Private Sub GetPrices()
        TextDielse.EditValue = 0
        Text95.EditValue = 0
        Try
            If String.IsNullOrEmpty(TextEditYear.Text) Or String.IsNullOrEmpty(TextEditMonth.Text) Then
                Exit Sub
            End If

            If Len(TextEditYear.Text) <> 4 Then
                Exit Sub
            End If

            If Len(TextEditMonth.Text) < 1 Or Len(TextEditMonth.Text) > 2 Then
                Exit Sub
            End If

            TextDielse.EditValue = GetItemPrice("1", TextEditYear.Text & "-" & TextEditMonth.Text & "-" & "01")
            Text95.EditValue = GetItemPrice("2", TextEditYear.Text & "-" & TextEditMonth.Text & "-" & "01")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextEditYear_EditValueChanged(sender As Object, e As EventArgs) Handles TextEditYear.EditValueChanged
        GetPrices()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        Try
            My.Forms.VouchersProccess.YyearText.Text = Me.TextEditYear.Text
            My.Forms.VouchersProccess.MmonthText.Text = Me.TextEditMonth.Text
            My.Forms.VouchersProccess.SearchFleetID.EditValue = FleetCode.EditValue
            ' My.Forms.VouchersProccess.TextDiff.Text = CStr(BandedGridView1.GetRowCellValue(BandedGridView1.FocusedRowHandle, "Diff"))
            VouchersProccess.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckFilterCars_CheckedChanged(sender As Object, e As EventArgs) Handles CheckFilterCars.CheckedChanged
        If IsNothing(FleetCode.EditValue) Then Exit Sub

        If CheckFilterCars.Checked = True Then
                LayoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                If CheckFromOrpak.Checked = True Then
                    Try
                        Dim Sql As New SQLControl
                    Sql.RunQuery("SELECT     distinct  M.[plate]
                                  FROM [HO_DATA].[dbo].[means] M
                                  left join fleets F on F.id=M.fleet_id
                                  left join transactions T on T.mean_id=M.id 
                                  where F.code='" & CStr(Me.FleetCode.EditValue) & "' 
                                  And DatePart(year, T.Date) = " & TextEditYear.Text & "
                                  And DatePart(month, T.Date) = " & TextEditMonth.Text)
                    GridControl3.DataSource = Sql.SQLDS.Tables(0)
                    Catch ex As Exception
                    End Try
                Else
                    Try
                        Dim Sql As New SQLControl
                    Sql.CRMRunQuery(" SELECT  distinct [Vehicle_Number] as plate from [CRM].[dbo].[DATA]
                                      Where FleetCode='" & CStr(Me.FleetCode.EditValue) & "' 
                                      And TransMonth='" & TextEditMonth.Text & "'
                                      And TransYear='" & TextEditYear.Text & "'")
                    GridControl3.DataSource = Sql.SQLDS.Tables(0)
                    Catch ex As Exception
                        End Try
                    End If




            Else
                LayoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            End If


    End Sub

    Private Sub GridControl3_Click(sender As Object, e As EventArgs) Handles GridView3.SelectionChanged
        Dim selectedRowHandles As Integer() = GridView3.GetSelectedRows()
        Dim _Text As String = "(''"
        GlobalVariables.FilteredCars = ""
        For i As Integer = 0 To selectedRowHandles.Length - 1
            Dim value As Object = GridView3.GetRowCellValue(selectedRowHandles(i), "plate")
            _Text += ",'" & CStr(value) & "'"
        Next
        GlobalVariables.FilteredCars = _Text & " )"
        TextVoucherNote.Text = " مركبة " & " " & GlobalVariables.FilteredCars.Replace("'", "")
    End Sub

    Private Sub GridControl3_Click_1(sender As Object, e As EventArgs) Handles GridControl3.Click

    End Sub
End Class