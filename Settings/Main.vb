Imports System.ComponentModel
Imports System.Text
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.LookAndFeel

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

        ribbonControl1.Enabled = False

        Try
            Dim sql As New SQLControl
            Dim i As Integer
            Dim SQLString As String = " SELECT userid   " &
                                      " FROM  users" &
                                      " where userdevice = '" & Environ("computername") & "'"
            sql.CRMRunQuery(SQLString)
            Me.UserTextEdit.Text = CType(sql.SQLDS.Tables(0).Rows(i).Item("userid"), String)
        Catch ex As Exception
            Exit Sub
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
            If TypeOf f Is OrpakCustomerTrans Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New OrpakCustomerTrans()
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
            PictureBox1.Image = Nothing
            LabelLastDate.Text = ""
            Exit Sub
        End Try
    End Sub

    Private Sub Password()
        Try
            Dim sql As New SQLControl
            Dim i As Integer
            Dim SQLString As String = " SELECT UserPassword ,ID as UserIDIntg  " &
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
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is DashBoardUser Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New DashBoardUser()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
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
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is CRMTasksDashBoard Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New CRMTasksDashBoard()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
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
        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If TypeOf f Is FinancialAccountsSTOPS Then
                child = f
                Exit For
            End If
        Next f
        If child Is Nothing Then
            child = New FinancialAccountsSTOPS()
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If
    End Sub

    Private Sub BarButtonItem34_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem34.ItemClick
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
End Class