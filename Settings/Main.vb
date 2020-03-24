Imports System.ComponentModel
Imports System.Text
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars.Alerter

Partial Public Class Main

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

        If GetSreenAccess("OrpakCardsQuery", GlobalVariables.UserIDString) = False Then Exit Sub
        Dim child As Form = Nothing
            For Each f As Form In MdiChildren
                If TypeOf f Is OrpakCardsQuery Then
                    child = f
                    Exit For
                End If
            Next f
            If child Is Nothing Then
                child = New OrpakCardsQuery()
                child.MdiParent = Me
                child.Show()
            Else
                child.Activate()
            End If


    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick

        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is SettingsTheme Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New SettingsTheme()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If

    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick

        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is OrpakCardsAll Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New OrpakCardsAll()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If

    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick

        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinancialBawaqe Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinancialBawaqe()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadialMenu1.ShowPopup(New Point)

        Timer1.Start()

        ribbonControl1.Enabled = False
        PanelControl2.Visible = True
        Try
            Dim sql As New SQLControl
            Dim i As Integer
            Dim SQLString As String = " SELECT userid   " &
                                      " FROM  users" &
                                      " where userdevice = '" & Environ("computername") & "'"
            sql.CRMRunQuery(SQLString)
            Me.UserTextEdit.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("userid"), String)
        Catch ex As Exception
            ' MsgBox(ex.ToString)
        End Try

        'Dim child As Form = Nothing
        'For Each f As Form In MdiChildren
        '    If TypeOf f Is Login Then
        '        child = f
        '        Exit For
        '    End If
        'Next f
        'If child Is Nothing Then
        '    child = New Login()
        '    child.MdiParent = Me
        '    child.Show()
        'Else
        '    child.Activate()
        'End If

        'Dim child As Form = Nothing
        'For Each f As Form In MdiChildren
        '    If TypeOf f Is DashBoardUser Then
        '        child = f
        '        Exit For
        '    End If
        'Next f
        'If child Is Nothing Then
        '    child = New DashBoardUser()
        '    child.MdiParent = Me
        '    child.Show()
        'Else
        '    child.Activate()
        'End If


        If GlobalVariables.UserIDInteger = CInt("1800013") Then
            RibbonPageGroup31.Visible = True
        End If


    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub BarButtonItem9_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick

        Dim Allchild As Form = Nothing
        For Each fs As Form In MdiChildren
            fs.Close()
        Next fs

        PanelControl2.Show()
        PassTextEdit.Select()
        Me.ribbonControl1.Enabled = False

    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick

        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is OrpakCustomerTrans2 Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New OrpakCustomerTrans2()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinanceReceipt Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinanceReceipt()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Public Sub EnableRibbon()
        Me.ribbonControl1.Enabled = True
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick

    End Sub

    Private Sub UserTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles UserTextEdit.EditValueChanged
        GetPic()
    End Sub

    Private Sub GetPic()
        Try
            Dim sql As New SQLControl
            Dim i As Integer
            Dim SQLString As String = " SELECT employeesdata.Name as name,picture,UserLastlogIn  " &
                                      " FROM    employeesdata,users" &
                                      " where employeesdata.EmpID=users.userid and  empid= '" & Me.UserTextEdit.Text & "'"
            sql.CRMRunQuery(SQLString)
            Dim LastDate As String
            LastDate = CType(sql.SQLDS.Tables(0).Rows(i).Item("UserLastlogIn"), String)
            LabelLastDate.Text = " اهلا " + CType(sql.SQLDS.Tables(0).Rows(i).Item("name"), String) + " اخر تسجيل دخول كان في  " + " " + LastDate

            If sql.SQLDS.Tables(0).Rows(i).Item("picture").ToString <> "" Then
                Dim bytes As [Byte]() = CType(sql.SQLDS.Tables(0).Rows(i).Item("picture"), Byte())
                Dim ms As New MemoryStream(bytes)
                PictureBox1.Image = Image.FromStream(ms)
            End If
            Me.PassTextEdit.Select()
        Catch ex As Exception
            '  MsgBox(ex.ToString)
            PictureBox1.Image = Nothing
            LabelLastDate.Text = ""
        End Try
    End Sub

    Private Sub Password()
        Try
            Dim sql As New SQLControl
            Dim i As Integer
            Dim SQLString As String = " SELECT UserPassword ,ID as UserIDIntg,UserName ,UserID,UserIDWallet " &
                                      " FROM  users" &
                                      " where users.userid = '" & Me.UserTextEdit.Text & "'"
            sql.CRMRunQuery(SQLString)
            Dim PassWord As String
            PassWord = CType(sql.SQLDS.Tables(0).Rows(i).Item("UserPassword"), String)
            GlobalVariables.UserIDInteger = CInt(CType(sql.SQLDS.Tables(0).Rows(i).Item("UserIDIntg"), String))

            If Me.PassTextEdit.Text = PassWord Then
                UpdateLastDate()
                InsertLogs()
                My.Settings.DeviceName = Environ("computername")
                My.Settings.UserName = Me.UserTextEdit.Text
                GlobalVariables.UserNameString = CStr(CType(sql.SQLDS.Tables(0).Rows(i).Item("UserName"), String))
                GlobalVariables.UserIDString = CStr(CType(sql.SQLDS.Tables(0).Rows(i).Item("UserID"), String))
                GlobalVariables.UserIDWallet = CInt(sql.SQLDS.Tables(0).Rows(i).Item("UserIDWallet"))
                My.Forms.Main.EnableRibbon()
                PassTextEdit.Text = ""
                PanelControl2.Hide()
                activeUser()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub UpdateLastDate()
        Dim sql As New SQLControl
        Dim SQLString As String = " Update Users " &
                                      " Set userdevice= '" & Environ("computername") & " ' , UserLastlogIn= CONVERT(DATETIME, '" & Format(Now(), "yyyy-MM-dd hh:mm:ss") & " ', 102)" &
                                      " where users.userid = '" & Me.UserTextEdit.Text & "'"
        sql.CRMRunQuery(SQLString)
    End Sub

    Private Sub InsertLogs()
        Dim sql As New SQLControl
        Dim SQLString2 As String = " insert into UserslogInLogs (userid,lastdate,devicename) values ( "
        SQLString2 = SQLString2 + "'" & Me.UserTextEdit.Text & "', "
        SQLString2 = SQLString2 + " CONVERT(DATETIME, '" & Format(Now(), "yyyy-MM-dd hh:mm:ss") & " ', 102)" & ", "
        SQLString2 = SQLString2 + "'" & Environ("computername") & "'"
        SQLString2 = SQLString2 + ")"
        sql.CRMRunQuery(SQLString2)
    End Sub

    Private Sub PassTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles PassTextEdit.EditValueChanged
        Password()

    End Sub

    Sub activeUser()
        'Dim child As Form = Nothing
        'For Each f As Form In MdiChildren
        '    If TypeOf f Is DashBoardUser Then
        '        child = f
        '        Exit For
        '    End If
        'Next f
        'If child Is Nothing Then
        '    child = New DashBoardUser()
        '    child.MdiParent = Me
        '    child.Show()
        'Else
        '    child.Activate()
        'End If
    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        If My.Settings.UserName <> "1800013" Then
            MsgBox("لا يوجد صلاحية")
        Else
            Dim child As Form = Nothing
            For Each f As Form In MdiChildren
                If TypeOf f Is Users Then
                    child = f
                    Exit For
                End If
            Next f
            If child Is Nothing Then
                child = New Users()
                child.MdiParent = Me
                child.Show()
            Else
                child.Activate()
            End If
        End If

    End Sub

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        'If GetSreenAccess("OrpakTransactions", GlobalVariables.UserIDString) = False Then Exit Sub
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is OrpakTransactions Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New OrpakTransactions()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        If GetSreenAccess("FinanceUtilites", GlobalVariables.UserIDString) = False Then Exit Sub
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinanceUtilites Then
                child = f
                FinanceUtilites.TabPane1.Visible = True
                ' FinanceUtilites.TabPane1.SelectedPage
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinanceUtilites()
            child.MdiParent = Me
            FinanceUtilites.TabPane1.Visible = True
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinanceMainForm Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinanceMainForm()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem22_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        'Dim child As Form = Nothing
        'For Each f As Form In MdiChildren
        '    If TypeOf f Is CRMTasksDashBoard Then
        '        child = f
        '        Exit For
        '    End If
        'Next f
        'If child Is Nothing Then
        '    child = New CRMTasksDashBoard()
        '    child.MdiParent = Me
        '    child.Show()
        'Else
        '    child.Activate()
        'End If
    End Sub

    Private Sub BarButtonItem17_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is ReceiptsAudit Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New ReceiptsAudit()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem21_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is CRMTasks Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New CRMTasks()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem23_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinancialBulkReceipt Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinancialBulkReceipt()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem24_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinancialMatchBankDoc Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinancialMatchBankDoc()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarStaticItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarStaticItem1.ItemClick

    End Sub

    Private Sub BarButtonItem25_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinancialChequesBack Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinancialChequesBack()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem26_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinancialAlhudaWherhouses Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinancialAlhudaWherhouses()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem28_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is CRMQuery Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New CRMQuery()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem16_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick

        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinanceReceiptQuery Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinanceReceiptQuery()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If

    End Sub

    Private Sub BarButtonItem31_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        If GetSreenAccess("FinancialAccountingStatment", GlobalVariables.UserIDString) = False Then Exit Sub
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinancialAccountingStatment Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinancialAccountingStatment()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If

    End Sub

    Private Sub BarButtonItem32_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is CRMTasksFromExcel Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New CRMTasksFromExcel()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If

    End Sub

    Private Sub BarButtonItem33_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem33.ItemClick
        If GetSreenAccess("FinanceAllAccounts", GlobalVariables.UserIDString) = False Then Exit Sub
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinanceAllAccounts Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinanceAllAccounts()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem34_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem34.ItemClick
        If GetSreenAccess("FinancialAccountingRetrieve", GlobalVariables.UserIDString) = False Then Exit Sub
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinancialAccountingRetrieve Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinancialAccountingRetrieve()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem35_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem35.ItemClick
        If GetSreenAccess("FinancialAccountsBalances", GlobalVariables.UserIDString) = False Then Exit Sub
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinancialAccountsBalances Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinancialAccountsBalances()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If


    End Sub

    Private Sub BarButtonItem36_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem36.ItemClick
        If GetSreenAccess("FinanceChequesAllReport", GlobalVariables.UserIDString) = False Then Exit Sub

        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinanceChequesAllReport Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinanceChequesAllReport()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If

    End Sub

    Private Sub ribbonControl1_Click(sender As Object, e As EventArgs) Handles ribbonControl1.Click

    End Sub

    Private Sub BarButtonItem37_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem37.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinancialVouchers Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinancialVouchers()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem27_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick

        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinancialStockProfit Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinancialStockProfit()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If


    End Sub

    Private Sub BarButtonItem38_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem38.ItemClick


        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinancialStockBalances Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinancialStockBalances()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If

    End Sub

    Private Sub BarButtonItem42_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem42.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is CustomersOrders Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New CustomersOrders()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try
            If AlertControl1.AlertFormList.Count > 0 Then Exit Sub



            Dim sql As New SQLControl
            Dim SqlString As String = " select top 5 * from CRMEnents where EventStatus ='True' and EventsToUser = '" & My.Settings.UserName & "' order by [EventID] desc "

            sql.CRMRunQuery(SqlString)
            If sql.SQLDS.Tables.Count = 0 Then Exit Sub
            If sql.SQLDS.Tables(0).Rows.Count = 0 Then Exit Sub
            Dim Owner As String = ""
            For i As Integer = 0 To 4
                If sql.SQLDS.Tables(0).Rows(i).Item("EventsOwner").ToString IsNot Nothing Then Owner = sql.SQLDS.Tables(0).Rows(i).Item("EventsOwner").ToString
                Dim EventsDetails As String = sql.SQLDS.Tables(0).Rows(i).Item("EventsDetails").ToString
                Dim EventsName As String = sql.SQLDS.Tables(0).Rows(i).Item("EventsName").ToString
                Dim EventID As String = sql.SQLDS.Tables(0).Rows(i).Item("EventID").ToString
                Dim EventDate As String = sql.SQLDS.Tables(0).Rows(i).Item("EventDate").ToString
                Dim ImageFalse As Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/content/notes_16x16.png")
                Me.AlertControl1.Show(Me, EventsName, "" & EventsDetails & vbNewLine & "الموظف: " & Owner & vbNewLine & " التاريخ: " & EventDate & vbNewLine, EventID, ImageFalse, EventID)
            Next i
        Catch ex As Exception
            '  MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub AlertControl1_BeforeFormShow(ByVal sender As System.Object,
ByVal e As DevExpress.XtraBars.Alerter.AlertFormEventArgs) Handles AlertControl1.BeforeFormShow
        e.AlertForm.OpacityLevel = 1
    End Sub

    Private Sub AlertControl1_ButtonClick(sender As Object, e As AlertButtonClickEventArgs) Handles AlertControl1.ButtonClick
        If e.ButtonName = "EDITDATE" Then
            Dim sql As New SQLControl
            Dim SqlString As String = "Update CRMEnents set EventStatus = 'False' where EventID=" & GETEventID(sender, e)
            sql.CRMRunQuery(SqlString)
            ' AlertControl1.AlertFormList(0).Hide()
            e.AlertForm.Close()

        End If
        If e.ButtonName = "Tahsel" Then
            MsgBox("تحصيل")
        End If
    End Sub
    ' Handles AlertControl1.AlertClick
    Private Function GETEventID(ByVal sender As System.Object, ByVal e As AlertClickEventArgs) As String
        ' Get and process the data associated with the current alert window.
        Dim CRMEventId As String = CType(e.Info.Tag, String)
        Return CRMEventId
    End Function

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        CRMCardIssue.Show()
    End Sub

    Private Sub BarButtonItem43_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem43.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is PrintingDocs Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New PrintingDocs()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem44_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem44.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is ArchiveInputFromScanner Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New ArchiveInputFromScanner()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem45_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem45.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is ArchiveDocuments Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New ArchiveDocuments()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem46_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem46.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinancialVISA Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinancialVISA()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem47_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem47.ItemClick

        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is ArchiveInputFromFolderPDF Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New ArchiveInputFromFolderPDF()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If


    End Sub

    Private Sub BarButtonItem48_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem48.ItemClick
        If GetSreenAccess("OrpakStationsSales2", GlobalVariables.UserIDString) = False Then Exit Sub
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is OrpakStationsSales2 Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New OrpakStationsSales2()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem49_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem49.ItemClick
        If GetSreenAccess("OrpakStationsSalesByHours", GlobalVariables.UserIDString) = False Then Exit Sub
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is OrpakStationsSalesByHours Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New OrpakStationsSalesByHours()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem51_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem51.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is OrpakStations Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New OrpakStations()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem52_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem52.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is OnlineUploadLogs Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New OnlineUploadLogs()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem53_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem53.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is OnlineEUCoops Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New OnlineEUCoops()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem54_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem54.ItemClick
        If GetSreenAccess("OrpakStationsEmpTrans", GlobalVariables.UserIDString) = False Then Exit Sub
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is OrpakStationsEmpTrans Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New OrpakStationsEmpTrans()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If


    End Sub

    Private Sub BarButtonItem56_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem56.ItemClick
        If GetSreenAccess("OrpakShifts", GlobalVariables.UserIDString) = False Then Exit Sub
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is OrpakShifts Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New OrpakShifts()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        Password()
    End Sub

    Private Sub BarButtonItem57_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem57.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is PrintingAllJobs Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New PrintingAllJobs()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem58_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem58.ItemClick
        If GetSreenAccess("CarsListCards", GlobalVariables.UserIDString) = False Then Exit Sub
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is CarsListCards Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New CarsListCards()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem60_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem60.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is BlackCheques Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New BlackCheques()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem61_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem61.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is CRMCardsIssuedAudit Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New CRMCardsIssuedAudit()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem62_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem62.ItemClick
        My.Forms.CRMSendSMSMessages.Show()
    End Sub

    Private Sub BarButtonItem63_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem63.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is ShiftsAudit Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New ShiftsAudit()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem59_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem59.ItemClick
        With My.Forms.StockManagementLists
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .DocType.EditValue = "SalesDelivery"
            .Text = "ارساليات المبيعات"
            .LookDocStatus.EditValue = "99"
            .CheckPost.Checked = False
            .Show()
        End With

        'StockManagementLists.MdiParent = Me
        'StockManagementLists.Dock = DockStyle.Fill
        'StockManagementLists.Show()

    End Sub

    Private Sub BarButtonItem65_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem65.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is OrpakTransactionsForSort Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New OrpakTransactionsForSort()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem68_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem68.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is StockItemMoves Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New StockItemMoves()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem64_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem64.ItemClick
        With My.Forms.StockManagementLists
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .DocType.EditValue = "PurchaseDelivery"
            .Text = "ارساليات مشتريات"
            .LookDocStatus.EditValue = "99"
            .CheckPost.Checked = False
            .Show()
        End With
    End Sub

    Private Sub BarButtonItem67_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem67.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is StockBalances Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New StockBalances()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem66_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem66.ItemClick
        With My.Forms.StockManagementLists
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .DocType.EditValue = "Transfer"
            .Text = "ارساليات داخلية"
            .LookDocStatus.EditValue = "99"
            .CheckPost.Visible = False
            .Show()
        End With
    End Sub

    Private Sub BarButtonItem69_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem69.ItemClick
        CarsDrivers.Show()
    End Sub

    Private Sub BarButtonItem70_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem70.ItemClick
        With My.Forms.StockManagementLists
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Text = "ترحيل الارساليات"
            .LookDocStatus.EditValue = "1"
            .CheckPost.Checked = True
            .Show()
        End With
    End Sub

    Private Sub BarButtonItem71_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem71.ItemClick
        With My.Forms.StockManagementLists
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .DocType.EditValue = "Jard"
            .Text = "سند تسوية جرد"
            .LookDocStatus.EditValue = "1"
            .Show()
        End With
    End Sub

    Private Sub BarButtonItem72_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem72.ItemClick

    End Sub

    Private Sub BarButtonItem73_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem73.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinancialStockBalances Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinancialStockBalances()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem74_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem74.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinancialStockProfit Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinancialStockProfit()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem75_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem75.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is OrbakSumForSort Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New OrbakSumForSort()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem76_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem76.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is OrpakTransactionsForSort Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New OrpakTransactionsForSort()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem77_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem77.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is OrpakLogReads Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New OrpakLogReads()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem78_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem78.ItemClick
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is LiteEditTrans Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New LiteEditTrans()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem79_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem79.ItemClick
        If GetSreenAccess("OprpakSalesDashForm", GlobalVariables.UserIDString) = False Then Exit Sub
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is OprpakSalesDashForm Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New OprpakSalesDashForm()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub
End Class