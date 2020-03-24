Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports outlook = Microsoft.Office.Interop.Outlook
Public Class CarsEdit
    Private Sub CarsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CarsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)

    End Sub

    Private Sub CarsEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CarsAccidentTableAdapter.Fill(Me.CRMDataSet.CarsAccident)
        Me.ArchiveDocTypesTableAdapter.Fill(Me.CRMDataSet.ArchiveDocTypes)
        Me.ArchiveDocsSortTableAdapter.Fill(Me.CRMDataSet.ArchiveDocsSort)
        Me.CarsInsurancCompaniesTableAdapter.Fill(Me.CRMDataSet.CarsInsurancCompanies)
        Me.KeyPreview = True
        CARNOTextEdit.Select()
    End Sub
    Private Sub Financereceipt_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F3 Then
            EditCarData()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButtonSave_Click(sender As Object, e As EventArgs) Handles SimpleButtonSave.Click
        EditCarData()
    End Sub
    Private Sub EditCarData()

        Try
            Me.Validate()
            Me.CarsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            Me.Validate()
            Me.CarsTarkhesTransBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)
        Catch ex As Exception
            MsgBox("خطا بحفظ بيانات الترخيص")
        End Try

        Try
            Me.Validate()
            Me.CarsInsuranceTransBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)
        Catch ex As Exception
            MsgBox("خطا بحفظ بيانات التأمين")
        End Try

    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        AddNewCar()
    End Sub

    Private Sub FillEmployees()

        Dim EmployeeTable As DataTable
        Dim EmployeeTable2 As DataTable

        Try
            Dim SqlString As String
            Dim sql As New SQLControl
            SqlString = " Select [AccountKey],[FullName] FROM [ALHUDA].[dbo].[Accounts] where SortGroup between 2700 and 2800"
            sql.WizCountRunQuery(SqlString)


            EmployeeTable = sql.SQLDS.Tables(0)

            Dim Sql2 As New SQLControl
            Sql2.CRMRunQuery("select  [AccountKey],[FullName] from [CRM].[dbo].[CarsDrivers] ")
            EmployeeTable2 = Sql2.SQLDS.Tables(0)

            EmployeeTable.Merge(EmployeeTable2)

            'Dim R As DataRow = EmployeeTable.NewRow
            'R("AccountKey") = "181818"
            'R("FullName") = "مازن"
            'EmployeeTable.Rows.Add(R)

            DriverIDTextEdit.Properties.DataSource = EmployeeTable
            DriverIDTextEdit.Properties.DisplayMember = "FullName"
            DriverIDTextEdit.Properties.ValueMember = "AccountKey"

            'DriverIDTextEdit.Properties.DataSource = sql.SQLDS.Tables(0)
            'DriverIDTextEdit.Properties.DisplayMember = "FullName"
            'DriverIDTextEdit.Properties.ValueMember = "AccountKey"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub FillCarsAccount()
        Try
            Dim SqlString As String
            Dim sql As New SQLControl
            SqlString = " Select [AccountKey],[FullName] FROM [ALHUDA].[dbo].[Accounts] where SortGroup = 6105 "
            sql.WizCountRunQuery(SqlString)
            AccountKeyTextEdit.Properties.DataSource = sql.SQLDS.Tables(0)
            AccountKeyTextEdit.Properties.DisplayMember = "FullName"
            AccountKeyTextEdit.Properties.ValueMember = "AccountKey"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub FillOrpakCar()
        Try
            Dim SqlString As String
            Dim sql As New SQLControl
            SqlString = " SELECT        [plate],case when [means].[status]=2 then N'فعالة' else N'موقوفة' end as status
                          FROM [HO_DATA].[dbo].[means]
                          left join ho_data.dbo.fleets on [HO_DATA].[dbo].[means].[fleet_id]=[HO_DATA].[dbo].[fleets].id
                          where [fleets].code='1000'  "
            sql.RunQuery(SqlString)
            OrpakCarTextEdit.Properties.DataSource = sql.SQLDS.Tables(0)
            OrpakCarTextEdit.Properties.DisplayMember = "plate"
            OrpakCarTextEdit.Properties.ValueMember = "plate"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function GetMaxCarNo() As Integer
        Try
            Dim sql As New SQLControl
            Dim Max As Integer
            sql.CRMRunQuery("select max(CarID) as max from cars ")
            Max = CInt(sql.SQLDS.Tables(0).Rows(0).Item("max").ToString)
            Return Max
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub AddNewCar()

        Try
            TextEditCarID.EditValue = -1

            GridControl1.DataSource = ""
            GridControl2.DataSource = ""
            GridControl3.DataSource = ""

            Me.CarsBindingSource.AddNew()
            Me.ArchiveDocsSortBindingSource.AddNew()
            Me.CarsAccidentBindingSource.AddNew()
            Me.CarsNotesBindingSource.AddNew()
            Me.CarsTarkhesTransBindingSource.AddNew()
            Me.CarsInsurancCompaniesBindingSource.AddNew()

            CarIDTextEdit.EditValue = GetMaxCarNo() + 1
            ActiveCheckEdit.Checked = True
            CARNOTextEdit.Select()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub TextEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles TextEditCarID.EditValueChanged
        If CInt(Me.TextEditCarID.Text) > 0 Then
            RefreshData()
            'Else
            '    AddNewCar()
        End If
    End Sub
    Private Sub RefreshData()
        Try
            If CInt(TextEditCarID.Text) > 0 Then
                GridControl1.DataSource = ""
                GridControl2.DataSource = ""
                GridControl3.DataSource = ""

                Me.CarsTableAdapter.FillByCarID(Me.CRMDataSet.cars, CInt(TextEditCarID.Text))

                Me.CarsSortTableAdapter.Fill(Me.CRMDataSet.CarsSort)
                Me.CarsMarkaTableAdapter.Fill(Me.CRMDataSet.CarsMarka)
                Me.CarsModelTableAdapter.Fill(Me.CRMDataSet.CarsModel)


                FillEmployees()
                FillCarsAccount()
                FillArchiveDoc()
                FillOrpakCar()

                Me.CarsTarkhesTransTableAdapter.FillByCarID(Me.CRMDataSet.CarsTarkhesTrans, TextEditCarID.Text)
                Me.CarsInsuranceTransTableAdapter.FillByCarID(Me.CRMDataSet.CarsInsuranceTrans, TextEditCarID.Text)

                GetPlateTrans(OrpakCarTextEdit.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GridView6_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView6.InitNewRow
        Try

            With Me.GridView6
                .SetRowCellValue(e.RowHandle, "TarkhesCost", 0)
                .SetRowCellValue(e.RowHandle, "TarkhesCarID", TextEditCarID.Text)
                '      Dim TarkhesBegDate As String = CType(.GetRowCellValue(.FocusedRowHandle, "TarkhesBegDate"), String)
                ' .SetRowCellValue(e.RowHandle, "TarkhesBegDate", Today)
                ' .SetRowCellValue(e.RowHandle, "TarkhesEndDate", CDate(TarkhesBegDate).AddYears(1))
            End With

        Catch ex As Exception
            '  MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub GridView7_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView7.InitNewRow

        Try
            With Me.GridView7
                .SetRowCellValue(e.RowHandle, "InsuranceBegDate", Today)
                .SetRowCellValue(e.RowHandle, "InsuranceEndDate", CDate(.GetRowCellValue(.FocusedRowHandle, "InsuranceBegDate")).AddYears(1))
                .SetRowCellValue(e.RowHandle, "InsuranceCost", 0)
                .SetRowCellValue(e.RowHandle, "InsuranceCar", TextEditCarID.Text)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AccounStatment(Account As String, FromDate As String, ToDate As String)

        Try
            Dim AccountStatmentss As String

            AccountStatmentss = " SELECT     JVALUEDATE  AS ALIAS6F,    JREFERANCE  AS ALIAS8F,  JREF2  AS ALIAS9F,  JDESCRIPTION  AS ALIAS10F,   CASE JMDEBITCREDIT WHEN 1 THEN  JMSUF  ELSE 0 END AS ALIAS12F_DEB, CASE JMDEBITCREDIT WHEN 0 THEN  JMSUF  ELSE 0 END AS ALIAS12F_CR ," _
                            & "              RPHSTRANSRETRIV. JMID  AS ALIAS2F  from RPHSTRANSRETRIV" _
                            & "  WHERE          ( JMACCOUNTKEY = '" & Account & "'  AND ('" & ToDate & "' >= JVALUEDATE) AND ('" & FromDate & "' <= JVALUEDATE) AND ('12/31/2050' >= JDUEDATE) AND ('01/01/1980' <= JDUEDATE) AND ('12/31/2050' >= JDATF3) AND ('01/01/1980' <= JDATF3) AND (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 " _
                            & "  order by   JVALUEDATE ASC  , JMID ASC   "

            Dim sql As New SQLControl
            sql.WizCountRunQuery(AccountStatmentss)
            GridControl1.DataSource = sql.SQLDS.Tables(0)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub GetPlateTrans(Plate As String)
        Dim GetPlateTrans As String
        GetPlateTrans = " Select    transactions.Date as TransDate , DATENAME(dw, transactions.Date) as theDayName ,
                                    transactions.time, transactions.quantity,transactions.ppv,
                                    transactions.sale,transactions.plate,transactions.product_name,
                                    stations.stn_name,transactions.pump,transactions.mean_name,
                                    fleets.Name As FleetName,transactions.odometer,transactions.tag
                           From     transactions,stations,fleets
                           Where    transactions.fleet_id = fleets.id and  transactions.stn_id = stations.stn_id  
                                    and Transactions.plate = '" & Plate & "' and fleets.code='1000'"

        Dim sql As New SQLControl
        sql.RunQuery(GetPlateTrans)
        GridControl2.DataSource = sql.SQLDS.Tables(0)
    End Sub

    Private Sub TabNavigationPage4_Paint(sender As Object, e As PaintEventArgs) Handles TabNavigationPage4.Paint

    End Sub

    Private Sub FillArchiveDoc()

        Try

            GridControl3.DataSource = ""
            Dim SqlString As String = " SELECT [DocID] ,[DocName],[DocType],[DocAccountCode],[DocDetails],[DocInputDate],
                                             UserName,[DocLocation],DocSort,DocCostCenter,
                                              [ALHUDA].[dbo].[Accounts].FullName As AccountName
                                        FROM [CRM].[dbo].[ArchiveDocs]
                                        left join [ALHUDA].[dbo].[Accounts] on [CRM].[dbo].[ArchiveDocs].DocAccountCode=[ALHUDA].[dbo].[Accounts].AccountKey 
                                        Left Join [CRM].[dbo].[users] on [CRM].[dbo].[ArchiveDocs].DocInputUser  =[CRM].[dbo].[users].[UserID]
                                        where DocAccountCode =  '" & CStr(AccountKeyTextEdit.EditValue) & "'"

            Dim Sql As New SQLControl
            Sql.CRMRunQuery(SqlString)
            If Sql.SQLDS.Tables(0).Rows.Count = 0 Then Exit Sub
            GridControl3.DataSource = Sql.SQLDS.Tables(0)
            GridView11.BestFitColumns()
        Catch ex As Exception
            '  MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub OpenButton_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles OpenButton.ButtonClick
        Try
            Dim FILE_NAME As String = GridView11.GetFocusedRowCellValue("DocLocation").ToString

            If System.IO.File.Exists(FILE_NAME) = True Then
                Process.Start(FILE_NAME)
            Else
                MsgBox("File Does Not Exist")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ItemEmailDoc_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ItemEmailDoc.ButtonClick
        Try
            Dim File As String = CType(Me.GridView11.GetRowCellValue(GridView11.FocusedRowHandle, "DocLocation"), String)
            Dim AttchName As String = CType(Me.GridView11.GetRowCellValue(GridView11.FocusedRowHandle, "DocName"), String)
            Dim DocDetails As String = CType(Me.GridView11.GetRowCellValue(GridView11.FocusedRowHandle, "DocDetails"), String)

            Dim oApp As New outlook.Application()
            Dim oMsg As outlook.MailItem = DirectCast(oApp.CreateItem(outlook.OlItemType.olMailItem), outlook.MailItem)
            oMsg.HTMLBody = DocDetails
            Dim sDisplayName As [String] = AttchName
            '   Dim iPosition As Integer = CInt(oMsg.Body.Length) + 1
            Dim iAttachType As Integer = CInt(outlook.OlAttachmentType.olByValue)
            Dim oAttach As outlook.Attachment = oMsg.Attachments.Add(File, iAttachType, , sDisplayName)
            oMsg.Subject = AttchName
            Dim oRecips As outlook.Recipients = DirectCast(oMsg.Recipients, outlook.Recipients)
            Dim oRecip As outlook.Recipient = DirectCast(oRecips.Add("accounting@alhuda.ps"), outlook.Recipient)
            oRecip.Resolve()
            oMsg.Display()
            oRecip = Nothing
            oRecips = Nothing
            oMsg = Nothing
            oApp = Nothing
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub AccountKeyTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles AccountKeyTextEdit.EditValueChanged

        Try
            AccounStatment(CStr(AccountKeyTextEdit.EditValue), "2010-01-01", "2050-12-12")
            FillArchiveDoc()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ButtEdit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtEdit.ButtonClick


        Try
            Dim DocID As String = GridView11.GetFocusedRowCellValue("DocID").ToString
            Dim DocName As String = GridView11.GetFocusedRowCellValue("DocName").ToString
            Dim DocType As String = GridView11.GetFocusedRowCellValue("DocType").ToString
            Dim DocAccountCode As String = GridView11.GetFocusedRowCellValue("DocAccountCode").ToString
            Dim DocDetails As String = GridView11.GetFocusedRowCellValue("DocDetails").ToString
            Dim CostCenter As String = GridView11.GetFocusedRowCellValue("DocCostCenter").ToString
            Dim DocSort As String = GridView11.GetFocusedRowCellValue("DocSort").ToString

            Dim Ans As DialogResult
            Ans = CType(MsgBox("هل تريد تعديل بيانات وثيقة رقم " & " " & DocID, MsgBoxStyle.YesNo, "تحذير"), DialogResult)

            If Ans = DialogResult.No Then RefreshData() : Exit Sub

            Dim SqlString As String = " Update ArchiveDocs Set 
                                        DocName = " & "'" & DocName & "'
                                        , DocType = " & "'" & DocType & "'
                                        , DocAccountCode = " & "'" & DocAccountCode & "'
                                        , DocDetails = " & "'" & DocDetails & "'
                                        , DocCostCenter = " & "'" & CostCenter & "'
                                        , DocSort = " & "'" & DocSort & "'
                                        where DocID= " & DocID
            Dim sql As New SQLControl
            sql.CRMRunQuery(SqlString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            RefreshData()
        End Try


    End Sub

    Private Sub CarsTarkhesTransGridControl_Click(sender As Object, e As EventArgs) Handles CarsTarkhesTransGridControl.Click

    End Sub
    Private Sub gridControl_ProcessGridKey(ByVal sender As Object, ByVal e As KeyEventArgs) Handles CarsTarkhesTransGridControl.ProcessGridKey

        Dim grid = TryCast(sender, GridControl)
        Dim view = TryCast(grid.FocusedView, GridView)
        If e.KeyData = Keys.Delete Then
            e.Handled = False
            Dim result As DialogResult = XtraMessageBox.Show("هل انت متأكد من حذف السطر؟", "تنبيه", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                view.DeleteSelectedRows()
                XtraMessageBox.Show("تم الحذف")
                e.Handled = True
            Else
                XtraMessageBox.Show("لم يتم الحذف")
            End If
        End If
    End Sub

    Private Sub CarsInsuranceTransGridControl_Click(sender As Object, e As EventArgs) Handles CarsInsuranceTransGridControl.Click

    End Sub

    Private Sub CarsInsuranceTransGridControl_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles CarsInsuranceTransGridControl.ProcessGridKey
        Dim grid = TryCast(sender, GridControl)
        Dim view = TryCast(grid.FocusedView, GridView)
        If e.KeyData = Keys.Delete Then
            e.Handled = False
            Dim result As DialogResult = XtraMessageBox.Show("هل انت متأكد من حذف السطر؟", "تنبيه", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                view.DeleteSelectedRows()
                XtraMessageBox.Show("تم الحذف")
                e.Handled = True
            Else
                XtraMessageBox.Show("لم يتم الحذف")
            End If
        End If
    End Sub

    Private Sub MarkaCarTextEdit_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles MarkaCarTextEdit.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty AndAlso MessageBox.Show(Me, "هل تريد اضافة'" & e.DisplayValue.ToString() & "' الى القائمة؟", "انتباه", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim sql As New SQLControl
            sql.CRMRunQuery("INSERT INTO [CarsMarka]  ([Marka])   VALUES  ('" & CStr(e.DisplayValue.ToString()) & "')")
            e.Handled = True
        End If
    End Sub

    Private Sub ModelCarTextEdit_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles ModelCarTextEdit.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty AndAlso MessageBox.Show(Me, "هل تريد اضافة'" & e.DisplayValue.ToString() & "' الى القائمة؟", "انتباه", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim sql As New SQLControl
            sql.CRMRunQuery("INSERT INTO [CarsModel]  ([Model])   VALUES  ('" & CStr(e.DisplayValue.ToString()) & "')")
            e.Handled = True
        End If
    End Sub

    Private Sub SortCarTextEdit_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles SortCarTextEdit.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty AndAlso MessageBox.Show(Me, "هل تريد اضافة'" & e.DisplayValue.ToString() & "' الى القائمة؟", "انتباه", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim sql As New SQLControl
            sql.CRMRunQuery("INSERT INTO [CarsSort]  ([CarSort])   VALUES  ('" & CStr(e.DisplayValue.ToString()) & "')")
            e.Handled = True
        End If
    End Sub

    Private Sub SortCarTextEdit_QueryPopUp(sender As Object, e As CancelEventArgs) Handles SortCarTextEdit.QueryPopUp
        Me.CarsSortTableAdapter.Fill(Me.CRMDataSet.CarsSort)
    End Sub

    Private Sub MarkaCarTextEdit_Properties_QueryPopUp(sender As Object, e As CancelEventArgs) Handles MarkaCarTextEdit.Properties.QueryPopUp
        Me.CarsMarkaTableAdapter.Fill(Me.CRMDataSet.CarsMarka)
    End Sub

    Private Sub ModelCarTextEdit_QueryPopUp(sender As Object, e As CancelEventArgs) Handles ModelCarTextEdit.QueryPopUp
        Me.CarsModelTableAdapter.Fill(Me.CRMDataSet.CarsModel)
    End Sub

    Private Sub AccountKeyTextEdit_QueryPopUp(sender As Object, e As CancelEventArgs) Handles AccountKeyTextEdit.QueryPopUp
        FillCarsAccount()
    End Sub

    Private Sub ActiveCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles ActiveCheckEdit.CheckedChanged
        If ActiveCheckEdit.Checked = True Then
            ActiveCheckEdit.ResetBackColor()
        Else
            ActiveCheckEdit.BackColor = Color.Red
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        RefreshData()
    End Sub
End Class