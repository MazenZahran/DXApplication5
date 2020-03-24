Public Class CarsListCards
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        RefreshData()
    End Sub

    Private Sub RefreshData()
        Dim SortCar As String = CStr(SearchLookUpEditSort.EditValue)
        Dim CarModel As String = CStr(SearchLookUpEditModel.EditValue)
        Dim MarkaCar As String = CStr(SearchLookUpEditMarka.EditValue)
        Dim CarNo As String = CStr(SearchLookUpEditCar.EditValue)
        FillEmployees()
        Dim SqlString As String
        Dim sql As New SQLControl
        SqlString = "SELECT [ID] ,[CarID] ,[CARNO] ,[ChassiNoCar] ,[MarkaCar] ,[ModelCar] ,[YearCar],
                            [ColorCar] ,[FuelsCar] ,[DriverID] ,[DatePurchase] ,[CostCar] ,[Vender] ,[DateSale],
                            [SaleCar] ,[Customer] ,[Picture] ,[SortCar] ,[active] ,[AccountKey] ,[OrpakCar] ,[BegSpedometaer], CarVolume,RegPerson,TeboGraphDate,CarDetails,NoOnExcel,
                            (SELECT top 1 TarkhesEndDate FROM [CRM].[dbo].[CarsTarkhesTrans]  WHERE     TarkhesCarID=[CarID]     ORDER BY TarkhesEndDate desc) as TarkhesEndDate,
                            (SELECT top 1 [InsuranceEndDate] FROM [CRM].[dbo].[CarsInsuranceTrans] WHERE     InsuranceCar=[CarID] ORDER BY [InsuranceEndDate] desc) as InsuranceEndDate, 
                            (SELECT top 1 [InsuranceCompany] FROM [CRM].[dbo].[CarsInsuranceTrans] WHERE     InsuranceCar=[CarID] ORDER BY [InsuranceEndDate] desc) as InsuranceCompany "
        SqlString = SqlString + "  FROM [CRM].[dbo].[cars] where id > 0   "
        If Not String.IsNullOrEmpty(SortCar) Then SqlString = SqlString + " and SortCar ='" & SortCar & "'"
        If Not String.IsNullOrEmpty(MarkaCar) Then SqlString = SqlString + " and MarkaCar ='" & MarkaCar & "'"
        If Not String.IsNullOrEmpty(CarModel) Then SqlString = SqlString + " and CarModel ='" & CarModel & "'"
        If Not String.IsNullOrEmpty(CarNo) Then SqlString = SqlString + " and CarNo ='" & CarNo & "'"

        Select Case CStr(RadioGroup2.EditValue)
            Case "1"
                SqlString = SqlString + " and [active] = 1 "
            Case "2"
                SqlString = SqlString + " and [active] = 0 "
        End Select

        sql.CRMRunQuery(SqlString)
        GridControl1.DataSource = sql.SQLDS.Tables(0)
        FillOrpakCar()
        FillCarsAccount()
        If CStr(RadioGroup1.EditValue) = "Grid" Then GridControl1.MainView = GridView1
        If CStr(RadioGroup1.EditValue) = "Cards" Then GridControl1.MainView = TileView1
        GridView1.BestFitColumns()
    End Sub

    Private Sub RepositoryOpen_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryOpen.ButtonClick
        Dim CarID As String = CType(Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CarID"), String)
        My.Forms.CarsEdit.TextEditCarID.Text = CarID
        My.Forms.CarsEdit.Show()
    End Sub

    Private Sub CarsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.cars' table. You can move, or remove it, as needed.
        Me.CarsTableAdapter.Fill(Me.CRMDataSet.cars)
        'TODO: This line of code loads data into the 'CRMDataSet.CarsSort' table. You can move, or remove it, as needed.
        Me.CarsSortTableAdapter.Fill(Me.CRMDataSet.CarsSort)
        'TODO: This line of code loads data into the 'CRMDataSet.CarsModel' table. You can move, or remove it, as needed.
        Me.CarsModelTableAdapter.Fill(Me.CRMDataSet.CarsModel)
        'TODO: This line of code loads data into the 'CRMDataSet.CarsMarka' table. You can move, or remove it, as needed.
        Me.CarsMarkaTableAdapter.Fill(Me.CRMDataSet.CarsMarka)
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
        RefreshData()
    End Sub

    Private Sub RepositoryEdit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryEdit.ButtonClick

        Try
            Dim SqlString As String
            Dim sql As New SQLControl
            Dim ChassiNoCar As String = GridView1.GetFocusedRowCellValue("ChassiNoCar").ToString
            Dim MarkaCar As String = GridView1.GetFocusedRowCellValue("MarkaCar").ToString
            Dim ModelCar As String = GridView1.GetFocusedRowCellValue("ModelCar").ToString
            Dim YearCar As String = GridView1.GetFocusedRowCellValue("YearCar").ToString
            Dim ColorCar As String = GridView1.GetFocusedRowCellValue("ColorCar").ToString
            Dim FuelsCar As String = GridView1.GetFocusedRowCellValue("FuelsCar").ToString
            Dim DriverID As String = GridView1.GetFocusedRowCellValue("DriverID").ToString
            Dim DatePurchase As String = GridView1.GetFocusedRowCellValue("DatePurchase").ToString
            Dim CostCar As String = GridView1.GetFocusedRowCellValue("CostCar").ToString
            Dim Vender As String = GridView1.GetFocusedRowCellValue("Vender").ToString
            Dim DateSale As String = GridView1.GetFocusedRowCellValue("DateSale").ToString
            Dim SaleCar As String = GridView1.GetFocusedRowCellValue("SaleCar").ToString
            Dim Customer As String = GridView1.GetFocusedRowCellValue("Customer").ToString
            Dim SortCar As String = GridView1.GetFocusedRowCellValue("SortCar").ToString
            Dim active As String = GridView1.GetFocusedRowCellValue("active").ToString
            Dim AccountKey As String = GridView1.GetFocusedRowCellValue("AccountKey").ToString
            Dim OrpakCar As String = GridView1.GetFocusedRowCellValue("OrpakCar").ToString
            Dim BegSpedometaer As String = GridView1.GetFocusedRowCellValue("BegSpedometaer").ToString
            Dim CarVolume As String = GridView1.GetFocusedRowCellValue("CarVolume").ToString
            Dim RegPerson As String = GridView1.GetFocusedRowCellValue("RegPerson").ToString
            Dim TeboGraphDate As String = GridView1.GetFocusedRowCellValue("TeboGraphDate").ToString
            Dim CarDetails As String = GridView1.GetFocusedRowCellValue("CarDetails").ToString
            Dim NoOnExcel As String = GridView1.GetFocusedRowCellValue("NoOnExcel").ToString

            SqlString = " UPDATE [CRM].[dbo].[cars]
                          SET
                               [ChassiNoCar] = '" & ChassiNoCar & "' 
                              ,[MarkaCar] = '" & MarkaCar & "' 
                              ,[ModelCar] = '" & ModelCar & "'
                              ,[YearCar] = '" & YearCar & "'
                              ,[ColorCar] = '" & ColorCar & "'
                              ,[FuelsCar] = '" & FuelsCar & "'
                              ,[DriverID] = '" & DriverID & "'
                              ,[DatePurchase] = '" & DatePurchase & "'
                              ,[CostCar] = '" & CostCar & "'
                              ,[Vender] = '" & Vender & "'
                              ,[DateSale] = '" & DateSale & "'
                              ,[SaleCar] = '" & SaleCar & "'
                              ,[Customer] = '" & Customer & "'
                              ,[SortCar] = '" & SortCar & "'
                              ,[AccountKey] = '" & AccountKey & "'
                              ,[OrpakCar] = '" & OrpakCar & "'
                              ,[BegSpedometaer] = '" & BegSpedometaer & "'
                              ,[CarVolume] = '" & CarVolume & "'
                              ,[RegPerson] = '" & RegPerson & "'
                              ,[TeboGraphDate] = '" & TeboGraphDate & "'
                              ,[CarDetails] = '" & CarDetails & "' 
                              ,[active] = '" & active & "' 
                              ,[NoOnExcel] = '" & NoOnExcel & "' 
                           WHERE CarID ='" & GridView1.GetFocusedRowCellValue("CarID").ToString & "'"

            sql.CRMRunQuery(SqlString)
            RefreshData()
            MsgBox("تم تعديل بيانات المركبة")
        Catch ex As Exception
            MsgBox(ex.ToString)
            RefreshData()
        End Try


    End Sub

    Private Sub FillOrpakCar()
        Try
            Dim SqlString As String
            Dim sql As New SQLControl
            SqlString = " SELECT        [plate] as OrpakCar ,case when [means].[status]=2 then N'فعالة' else N'موقوفة' end as status
                          FROM [HO_DATA].[dbo].[means]
                          left join ho_data.dbo.fleets on [HO_DATA].[dbo].[means].[fleet_id]=[HO_DATA].[dbo].[fleets].id
                          where [fleets].code='1000'  "
            sql.RunQuery(SqlString)
            RepositoryCarOnOrpak.DataSource = sql.SQLDS.Tables(0)
            RepositoryCarOnOrpak.DisplayMember = "OrpakCar"
            RepositoryCarOnOrpak.ValueMember = "OrpakCar"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RepositoryCarOnOrpak_BeforePopup(sender As Object, e As EventArgs) Handles RepositoryCarOnOrpak.BeforePopup

    End Sub

    Private Sub FillCarsAccount()
        Try
            Dim SqlString As String
            Dim sql As New SQLControl
            SqlString = " Select [AccountKey],[FullName] FROM [ALHUDA].[dbo].[Accounts] where SortGroup = 6105 "
            sql.WizCountRunQuery(SqlString)
            RepositoryRepairAccount.DataSource = sql.SQLDS.Tables(0)
            RepositoryRepairAccount.DisplayMember = "FullName"
            RepositoryRepairAccount.ValueMember = "AccountKey"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        GridControl1.MainView = TileView1
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)
        GridControl1.MainView = GridView1
    End Sub


    Private Sub tileView1_ItemCustomize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs) Handles TileView1.ItemCustomize

        If CBool(TileView1.GetRowCellValue(e.RowHandle, TileViewColumn18)) = False Then
            e.Item.Elements(11).Image = My.Resources.Sold
            e.Item.Elements(11).Text = "مباعة"
        Else
            e.Item.Elements(11).Text = "متوفرة"
        End If
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Dim CarID As String = CType(Me.TileView1.GetRowCellValue(TileView1.FocusedRowHandle, "CarID"), String)
        My.Forms.CarsEdit.TextEditCarID.Text = CarID
        My.Forms.CarsEdit.Show()
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        If CStr(RadioGroup1.EditValue) = "Grid" Then GridControl1.MainView = GridView1
        If CStr(RadioGroup1.EditValue) = "Cards" Then GridControl1.MainView = TileView1
    End Sub

    Private Sub RepositorySort_QueryPopUp(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositorySort.QueryPopUp
        Me.CarsSortTableAdapter.Fill(Me.CRMDataSet.CarsSort)
    End Sub

    Private Sub RepositoryRepairAccount_QueryPopUp(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryRepairAccount.QueryPopUp
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
    End Sub

    Private Sub RepositoryMarka_QueryPopUp(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryMarka.QueryPopUp
        Me.CarsMarkaTableAdapter.Fill(Me.CRMDataSet.CarsMarka)
    End Sub

    Private Sub RepositoryModel_QueryPopUp(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryModel.QueryPopUp
        Me.CarsModelTableAdapter.Fill(Me.CRMDataSet.CarsModel)
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        CarsOtherLists.Show()
    End Sub

    Private Sub RadioGroup2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup2.SelectedIndexChanged
        RefreshData()
    End Sub

    Private Sub GridView1_PrintInitialize(sender As System.Object,
            e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) _
            Handles GridView1.PrintInitialize
        Dim pb As DevExpress.XtraPrinting.PrintingSystemBase = CType(e.PrintingSystem, DevExpress.XtraPrinting.PrintingSystemBase)
        pb.PageSettings.Landscape = True
        pb.PageSettings.LeftMargin = 1
        pb.PageSettings.RightMargin = 1
        pb.PageSettings.TopMargin = 1
        pb.PageSettings.BottomMargin = 1
        pb.Pages.AddRange(pb.Pages)
        pb.ContinuousPageNumbering = True
    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        GridControl1.ShowPrintPreview()
    End Sub

    Private Sub RepositorySearchDriver_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositorySearchDriver.ButtonClick

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

            RepositorySearchDriver.DataSource = EmployeeTable
            RepositorySearchDriver.DisplayMember = "FullName"
            RepositorySearchDriver.ValueMember = "AccountKey"

            'DriverIDTextEdit.Properties.DataSource = sql.SQLDS.Tables(0)
            'DriverIDTextEdit.Properties.DisplayMember = "FullName"
            'DriverIDTextEdit.Properties.ValueMember = "AccountKey"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
End Class