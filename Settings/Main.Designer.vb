Partial Public Class Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.DXApplication5.SplashScreen1), True, True)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
        Dim GalleryItemGroup2 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
        Dim GalleryItemGroup3 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockingMenuItem1 = New DevExpress.XtraBars.BarDockingMenuItem()
        Me.RibbonGalleryBarItem1 = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem23 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem24 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarButtonItem25 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem26 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem27 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem28 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem29 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem30 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem31 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem32 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem33 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem34 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem35 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem36 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup14 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup12 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup21 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup22 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup25 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup17 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup16 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup24 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup26 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup27 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup28 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage5 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.الموظفين = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup20 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup23 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage6 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage7 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup13 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup18 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup19 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.RibbonPage9 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RadialMenu1 = New DevExpress.XtraBars.Ribbon.RadialMenu(Me.components)
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelLastDate = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.UserTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.PassTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.RadialMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplashScreenManager1
        '
        SplashScreenManager1.ClosingDelay = 50
        '
        'ribbonControl1
        '
        Me.ribbonControl1.Enabled = False
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarDockingMenuItem1, Me.RibbonGalleryBarItem1, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.SkinRibbonGalleryBarItem1, Me.BarButtonItem16, Me.BarButtonItem17, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20, Me.BarButtonItem21, Me.BarButtonItem22, Me.BarButtonItem23, Me.BarButtonItem24, Me.BarStaticItem1, Me.BarEditItem1, Me.BarButtonItem25, Me.BarButtonItem26, Me.BarButtonItem27, Me.BarButtonItem28, Me.BarButtonItem29, Me.BarButtonItem30, Me.BarButtonItem31, Me.BarButtonItem32, Me.BarButtonItem33, Me.BarButtonItem34, Me.BarButtonItem35, Me.BarButtonItem36})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 32
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.RibbonPageCategory1})
        Me.ribbonControl1.PageHeaderItemLinks.Add(Me.BarButtonItem2)
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage4, Me.RibbonPage5, Me.RibbonPage6, Me.RibbonPage7})
        Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl1.Size = New System.Drawing.Size(1208, 149)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "استعلام عن بطاقة"
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "اصدار بطاقة"
        Me.BarButtonItem2.Id = 3
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "عرض كل البطاقات"
        Me.BarButtonItem3.Id = 4
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarDockingMenuItem1
        '
        Me.BarDockingMenuItem1.Caption = "BarDockingMenuItem1"
        Me.BarDockingMenuItem1.Id = 6
        Me.BarDockingMenuItem1.Name = "BarDockingMenuItem1"
        '
        'RibbonGalleryBarItem1
        '
        Me.RibbonGalleryBarItem1.Caption = "RibbonGalleryBarItem1"
        '
        '
        '
        GalleryItemGroup1.Caption = "Group1"
        GalleryItemGroup2.Caption = "Group2"
        GalleryItemGroup3.Caption = "Group3"
        Me.RibbonGalleryBarItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1, GalleryItemGroup2, GalleryItemGroup3})
        Me.RibbonGalleryBarItem1.Id = 8
        Me.RibbonGalleryBarItem1.Name = "RibbonGalleryBarItem1"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "اعدادات الالوان"
        Me.BarButtonItem4.Id = 9
        Me.BarButtonItem4.ImageOptions.Image = CType(resources.GetObject("BarButtonItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem4.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "بحث سريع"
        Me.BarButtonItem5.Id = 10
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "بحث شامل"
        Me.BarButtonItem6.Id = 11
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "تقرير زبون"
        Me.BarButtonItem7.Id = 12
        Me.BarButtonItem7.ImageOptions.Image = CType(resources.GetObject("BarButtonItem7.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem7.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem7.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "استعلام البواقي"
        Me.BarButtonItem8.Id = 13
        Me.BarButtonItem8.ImageOptions.Image = CType(resources.GetObject("BarButtonItem8.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem8.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem8.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "تسجيل الخروج"
        Me.BarButtonItem9.Id = 1
        Me.BarButtonItem9.ImageOptions.Image = CType(resources.GetObject("BarButtonItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem9.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem9.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "سند قبض"
        Me.BarButtonItem10.Id = 2
        Me.BarButtonItem10.ImageOptions.Image = CType(resources.GetObject("BarButtonItem10.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem10.Name = "BarButtonItem10"
        Me.BarButtonItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "BarButtonItem11"
        Me.BarButtonItem11.Id = 3
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "المستخدمين"
        Me.BarButtonItem12.Id = 4
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "حركات المحطات"
        Me.BarButtonItem13.Id = 5
        Me.BarButtonItem13.ImageOptions.Image = CType(resources.GetObject("BarButtonItem13.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem13.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem13.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "تغيير سعر الغسيل لتصنيف"
        Me.BarButtonItem14.Id = 6
        Me.BarButtonItem14.ImageOptions.Image = CType(resources.GetObject("BarButtonItem14.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem14.Name = "BarButtonItem14"
        Me.BarButtonItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "اسعار الهيئة"
        Me.BarButtonItem15.Id = 7
        Me.BarButtonItem15.ImageOptions.Image = CType(resources.GetObject("BarButtonItem15.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem15.Name = "BarButtonItem15"
        Me.BarButtonItem15.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem1.Id = 8
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "استعلام سندات القبض"
        Me.BarButtonItem16.Id = 9
        Me.BarButtonItem16.ImageOptions.Image = CType(resources.GetObject("BarButtonItem16.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem16.Name = "BarButtonItem16"
        Me.BarButtonItem16.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "تدقيق سندات القبض"
        Me.BarButtonItem17.Id = 10
        Me.BarButtonItem17.ImageOptions.Image = CType(resources.GetObject("BarButtonItem17.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem17.Name = "BarButtonItem17"
        Me.BarButtonItem17.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "سند صرف"
        Me.BarButtonItem18.Id = 11
        Me.BarButtonItem18.ImageOptions.Image = CType(resources.GetObject("BarButtonItem18.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem18.Name = "BarButtonItem18"
        Me.BarButtonItem18.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "استعلام سندات صرف"
        Me.BarButtonItem19.Id = 12
        Me.BarButtonItem19.ImageOptions.Image = CType(resources.GetObject("BarButtonItem19.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem19.Name = "BarButtonItem19"
        Me.BarButtonItem19.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "تدقيق سندات الصرف"
        Me.BarButtonItem20.Id = 13
        Me.BarButtonItem20.ImageOptions.Image = CType(resources.GetObject("BarButtonItem20.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem20.Name = "BarButtonItem20"
        Me.BarButtonItem20.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.Caption = "شاشة التحصيل"
        Me.BarButtonItem21.Id = 14
        Me.BarButtonItem21.ImageOptions.Image = CType(resources.GetObject("BarButtonItem21.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem21.Name = "BarButtonItem21"
        Me.BarButtonItem21.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.Caption = "الرئيسية"
        Me.BarButtonItem22.Id = 15
        Me.BarButtonItem22.ImageOptions.Image = CType(resources.GetObject("BarButtonItem22.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem22.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem22.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem22.Name = "BarButtonItem22"
        '
        'BarButtonItem23
        '
        Me.BarButtonItem23.Caption = "سند قبض مركب"
        Me.BarButtonItem23.Id = 16
        Me.BarButtonItem23.ImageOptions.Image = CType(resources.GetObject("BarButtonItem23.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem23.Name = "BarButtonItem23"
        Me.BarButtonItem23.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem24
        '
        Me.BarButtonItem24.Caption = "تدقيق ايداعات البنك"
        Me.BarButtonItem24.Id = 17
        Me.BarButtonItem24.ImageOptions.Image = CType(resources.GetObject("BarButtonItem24.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem24.Name = "BarButtonItem24"
        Me.BarButtonItem24.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "BarStaticItem1"
        Me.BarStaticItem1.Id = 18
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemTextEdit1
        Me.BarEditItem1.Id = 19
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'BarButtonItem25
        '
        Me.BarButtonItem25.Caption = "محفظة الشيكات الراجعة"
        Me.BarButtonItem25.Id = 20
        Me.BarButtonItem25.ImageOptions.Image = CType(resources.GetObject("BarButtonItem25.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem25.Name = "BarButtonItem25"
        Me.BarButtonItem25.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem26
        '
        Me.BarButtonItem26.Caption = "تقرير الهيئات"
        Me.BarButtonItem26.Id = 21
        Me.BarButtonItem26.Name = "BarButtonItem26"
        '
        'BarButtonItem27
        '
        Me.BarButtonItem27.Caption = "حركات الاصناف"
        Me.BarButtonItem27.Id = 22
        Me.BarButtonItem27.Name = "BarButtonItem27"
        '
        'BarButtonItem28
        '
        Me.BarButtonItem28.Caption = "استعلام المهام"
        Me.BarButtonItem28.Id = 23
        Me.BarButtonItem28.ImageOptions.Image = CType(resources.GetObject("BarButtonItem28.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem28.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem28.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem28.Name = "BarButtonItem28"
        Me.BarButtonItem28.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem29
        '
        Me.BarButtonItem29.Caption = "الموظفين"
        Me.BarButtonItem29.Id = 24
        Me.BarButtonItem29.ImageOptions.Image = CType(resources.GetObject("BarButtonItem29.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem29.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem29.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem29.Name = "BarButtonItem29"
        '
        'BarButtonItem30
        '
        Me.BarButtonItem30.Caption = "استعلام الموظفين"
        Me.BarButtonItem30.Id = 25
        Me.BarButtonItem30.ImageOptions.Image = CType(resources.GetObject("BarButtonItem30.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem30.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem30.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem30.Name = "BarButtonItem30"
        '
        'BarButtonItem31
        '
        Me.BarButtonItem31.Caption = "كشف حساب"
        Me.BarButtonItem31.Id = 26
        Me.BarButtonItem31.ImageOptions.Image = CType(resources.GetObject("BarButtonItem31.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem31.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem31.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem31.Name = "BarButtonItem31"
        '
        'BarButtonItem32
        '
        Me.BarButtonItem32.Caption = "ادخال مهام من ملف"
        Me.BarButtonItem32.Id = 27
        Me.BarButtonItem32.ImageOptions.Image = CType(resources.GetObject("BarButtonItem32.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem32.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem32.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem32.Name = "BarButtonItem32"
        '
        'BarButtonItem33
        '
        Me.BarButtonItem33.Caption = "استعلام حسابات حسب تصنيف"
        Me.BarButtonItem33.Id = 28
        Me.BarButtonItem33.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem33.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem33.Name = "BarButtonItem33"
        '
        'BarButtonItem34
        '
        Me.BarButtonItem34.Caption = "بحث تفصيلي"
        Me.BarButtonItem34.Id = 29
        Me.BarButtonItem34.ImageOptions.Image = CType(resources.GetObject("BarButtonItem34.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem34.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem34.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem34.Name = "BarButtonItem34"
        '
        'BarButtonItem35
        '
        Me.BarButtonItem35.Caption = "كشف ارصدة"
        Me.BarButtonItem35.Id = 30
        Me.BarButtonItem35.ImageOptions.Image = CType(resources.GetObject("BarButtonItem35.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem35.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem35.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem35.Name = "BarButtonItem35"
        '
        'BarButtonItem36
        '
        Me.BarButtonItem36.Caption = "كل الشيكات"
        Me.BarButtonItem36.Id = 31
        Me.BarButtonItem36.ImageOptions.Image = CType(resources.GetObject("BarButtonItem36.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem36.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem36.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem36.Name = "BarButtonItem36"
        '
        'RibbonPageCategory1
        '
        Me.RibbonPageCategory1.Name = "RibbonPageCategory1"
        Me.RibbonPageCategory1.Text = "RibbonPageCategory1"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Image = CType(resources.GetObject("ribbonPage1.Image"), System.Drawing.Image)
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "الرئيسية"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup8, Me.RibbonPageGroup9, Me.RibbonPageGroup14, Me.RibbonPageGroup12})
        Me.RibbonPage2.Image = CType(resources.GetObject("RibbonPage2.Image"), System.Drawing.Image)
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "البطاقات"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.ShowCaptionButton = False
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        Me.RibbonPageGroup9.ShowCaptionButton = False
        '
        'RibbonPageGroup14
        '
        Me.RibbonPageGroup14.ItemLinks.Add(Me.BarButtonItem7)
        Me.RibbonPageGroup14.Name = "RibbonPageGroup14"
        '
        'RibbonPageGroup12
        '
        Me.RibbonPageGroup12.Glyph = CType(resources.GetObject("RibbonPageGroup12.Glyph"), System.Drawing.Image)
        Me.RibbonPageGroup12.ImageUri.Uri = "AlignHorizontalBottom"
        Me.RibbonPageGroup12.ItemLinks.Add(Me.BarButtonItem13)
        Me.RibbonPageGroup12.Name = "RibbonPageGroup12"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup21, Me.RibbonPageGroup3, Me.RibbonPageGroup22, Me.RibbonPageGroup25})
        Me.RibbonPage3.Image = CType(resources.GetObject("RibbonPage3.Image"), System.Drawing.Image)
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "نظام المهام"
        '
        'RibbonPageGroup21
        '
        Me.RibbonPageGroup21.ItemLinks.Add(Me.BarButtonItem22)
        Me.RibbonPageGroup21.Name = "RibbonPageGroup21"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.Glyph = CType(resources.GetObject("RibbonPageGroup3.Glyph"), System.Drawing.Image)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem21)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        '
        'RibbonPageGroup22
        '
        Me.RibbonPageGroup22.Glyph = CType(resources.GetObject("RibbonPageGroup22.Glyph"), System.Drawing.Image)
        Me.RibbonPageGroup22.ItemLinks.Add(Me.BarButtonItem28)
        Me.RibbonPageGroup22.Name = "RibbonPageGroup22"
        '
        'RibbonPageGroup25
        '
        Me.RibbonPageGroup25.ItemLinks.Add(Me.BarButtonItem32)
        Me.RibbonPageGroup25.Name = "RibbonPageGroup25"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup17, Me.RibbonPageGroup5, Me.RibbonPageGroup1, Me.RibbonPageGroup4, Me.RibbonPageGroup7, Me.RibbonPageGroup16, Me.RibbonPageGroup24, Me.RibbonPageGroup26, Me.RibbonPageGroup27, Me.RibbonPageGroup28})
        Me.RibbonPage4.Image = CType(resources.GetObject("RibbonPage4.Image"), System.Drawing.Image)
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "المالية"
        '
        'RibbonPageGroup17
        '
        Me.RibbonPageGroup17.ItemLinks.Add(Me.BarButtonItem15)
        Me.RibbonPageGroup17.Name = "RibbonPageGroup17"
        Me.RibbonPageGroup17.Text = "الرئيسية"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem10)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem16)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem17)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem23)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "القبض"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem24)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "البنوك"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem8)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "نظام البواقي"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItem36)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItem25)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.Text = "الشيكات"
        '
        'RibbonPageGroup16
        '
        Me.RibbonPageGroup16.ItemLinks.Add(Me.BarButtonItem26)
        Me.RibbonPageGroup16.ItemLinks.Add(Me.BarButtonItem27)
        Me.RibbonPageGroup16.Name = "RibbonPageGroup16"
        Me.RibbonPageGroup16.Text = "المخزون"
        '
        'RibbonPageGroup24
        '
        Me.RibbonPageGroup24.ItemLinks.Add(Me.BarButtonItem31)
        Me.RibbonPageGroup24.Name = "RibbonPageGroup24"
        '
        'RibbonPageGroup26
        '
        Me.RibbonPageGroup26.ItemLinks.Add(Me.BarButtonItem33)
        Me.RibbonPageGroup26.Name = "RibbonPageGroup26"
        '
        'RibbonPageGroup27
        '
        Me.RibbonPageGroup27.ItemLinks.Add(Me.BarButtonItem34)
        Me.RibbonPageGroup27.Name = "RibbonPageGroup27"
        '
        'RibbonPageGroup28
        '
        Me.RibbonPageGroup28.ItemLinks.Add(Me.BarButtonItem35)
        Me.RibbonPageGroup28.Name = "RibbonPageGroup28"
        '
        'RibbonPage5
        '
        Me.RibbonPage5.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.الموظفين, Me.RibbonPageGroup20, Me.RibbonPageGroup23})
        Me.RibbonPage5.Image = CType(resources.GetObject("RibbonPage5.Image"), System.Drawing.Image)
        Me.RibbonPage5.Name = "RibbonPage5"
        Me.RibbonPage5.Text = "شؤون الموظفين"
        '
        'الموظفين
        '
        Me.الموظفين.Glyph = CType(resources.GetObject("الموظفين.Glyph"), System.Drawing.Image)
        Me.الموظفين.ItemLinks.Add(Me.BarButtonItem29)
        Me.الموظفين.Name = "الموظفين"
        Me.الموظفين.Text = "الموظفين"
        '
        'RibbonPageGroup20
        '
        Me.RibbonPageGroup20.ItemLinks.Add(Me.BarButtonItem30)
        Me.RibbonPageGroup20.Name = "RibbonPageGroup20"
        Me.RibbonPageGroup20.Text = "RibbonPageGroup20"
        '
        'RibbonPageGroup23
        '
        Me.RibbonPageGroup23.Name = "RibbonPageGroup23"
        Me.RibbonPageGroup23.Text = "RibbonPageGroup23"
        '
        'RibbonPage6
        '
        Me.RibbonPage6.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6})
        Me.RibbonPage6.Image = CType(resources.GetObject("RibbonPage6.Image"), System.Drawing.Image)
        Me.RibbonPage6.Name = "RibbonPage6"
        Me.RibbonPage6.Text = "المركبات"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.Glyph = CType(resources.GetObject("RibbonPageGroup6.Glyph"), System.Drawing.Image)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "المركبات"
        '
        'RibbonPage7
        '
        Me.RibbonPage7.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup10, Me.RibbonPageGroup11, Me.RibbonPageGroup13, Me.RibbonPageGroup18, Me.RibbonPageGroup19})
        Me.RibbonPage7.Image = CType(resources.GetObject("RibbonPage7.Image"), System.Drawing.Image)
        Me.RibbonPage7.Name = "RibbonPage7"
        Me.RibbonPage7.Text = "الاعدادات"
        '
        'RibbonPageGroup10
        '
        Me.RibbonPageGroup10.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup10.Name = "RibbonPageGroup10"
        '
        'RibbonPageGroup11
        '
        Me.RibbonPageGroup11.ItemLinks.Add(Me.BarButtonItem9)
        Me.RibbonPageGroup11.Name = "RibbonPageGroup11"
        '
        'RibbonPageGroup13
        '
        Me.RibbonPageGroup13.ItemLinks.Add(Me.BarButtonItem12)
        Me.RibbonPageGroup13.Name = "RibbonPageGroup13"
        '
        'RibbonPageGroup18
        '
        Me.RibbonPageGroup18.Glyph = CType(resources.GetObject("RibbonPageGroup18.Glyph"), System.Drawing.Image)
        Me.RibbonPageGroup18.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.RibbonPageGroup18.Name = "RibbonPageGroup18"
        Me.RibbonPageGroup18.Text = "اعدادات الالوان"
        '
        'RibbonPageGroup19
        '
        Me.RibbonPageGroup19.ItemLinks.Add(Me.BarButtonItem14)
        Me.RibbonPageGroup19.Name = "RibbonPageGroup19"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(102, 48)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.OpenToolStripMenuItem.Text = "open"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.CloseToolStripMenuItem.Text = "close"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        '
        'RibbonPage9
        '
        Me.RibbonPage9.Name = "RibbonPage9"
        Me.RibbonPage9.Text = "RibbonPage9"
        '
        'RadialMenu1
        '
        Me.RadialMenu1.Name = "RadialMenu1"
        Me.RadialMenu1.Ribbon = Me.ribbonControl1
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelControl2.Controls.Add(Me.LabelLastDate)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Controls.Add(Me.PictureBox1)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.UserTextEdit)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.PassTextEdit)
        Me.PanelControl2.Location = New System.Drawing.Point(293, 162)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(621, 501)
        Me.PanelControl2.TabIndex = 5
        '
        'LabelLastDate
        '
        Me.LabelLastDate.Appearance.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LabelLastDate.Appearance.Options.UseForeColor = True
        Me.LabelLastDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelLastDate.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelLastDate.Location = New System.Drawing.Point(29, 374)
        Me.LabelLastDate.Name = "LabelLastDate"
        Me.LabelLastDate.Size = New System.Drawing.Size(548, 33)
        Me.LabelLastDate.TabIndex = 6
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(45, 431)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(182, 36)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "خروج"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(157, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(289, 215)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelControl2.Appearance.Image = CType(resources.GetObject("LabelControl2.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl2.Appearance.Options.UseBorderColor = True
        Me.LabelControl2.Appearance.Options.UseImage = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Left
        Me.LabelControl2.Location = New System.Drawing.Point(452, 304)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(49, 48)
        Me.LabelControl2.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelControl1.Appearance.Image = CType(resources.GetObject("LabelControl1.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl1.Appearance.Options.UseBorderColor = True
        Me.LabelControl1.Appearance.Options.UseImage = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Left
        Me.LabelControl1.LineVisible = True
        Me.LabelControl1.Location = New System.Drawing.Point(452, 258)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 40)
        Me.LabelControl1.TabIndex = 3
        '
        'UserTextEdit
        '
        Me.UserTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UserTextEdit.EditValue = ""
        Me.UserTextEdit.Location = New System.Drawing.Point(157, 253)
        Me.UserTextEdit.Name = "UserTextEdit"
        Me.UserTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.UserTextEdit.Properties.Appearance.Image = CType(resources.GetObject("UserTextEdit.Properties.Appearance.Image"), System.Drawing.Image)
        Me.UserTextEdit.Properties.Appearance.Options.UseFont = True
        Me.UserTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.UserTextEdit.Properties.Appearance.Options.UseImage = True
        Me.UserTextEdit.Properties.AutoHeight = False
        Me.UserTextEdit.Size = New System.Drawing.Size(289, 45)
        Me.UserTextEdit.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Traditional Arabic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.LineVisible = True
        Me.LabelControl3.Location = New System.Drawing.Point(29, 358)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(549, 10)
        Me.LabelControl3.TabIndex = 0
        '
        'PassTextEdit
        '
        Me.PassTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PassTextEdit.EditValue = ""
        Me.PassTextEdit.Location = New System.Drawing.Point(157, 307)
        Me.PassTextEdit.Name = "PassTextEdit"
        Me.PassTextEdit.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.PassTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.PassTextEdit.Properties.Appearance.Image = CType(resources.GetObject("PassTextEdit.Properties.Appearance.Image"), System.Drawing.Image)
        Me.PassTextEdit.Properties.Appearance.Options.UseFont = True
        Me.PassTextEdit.Properties.Appearance.Options.UseForeColor = True
        Me.PassTextEdit.Properties.Appearance.Options.UseImage = True
        Me.PassTextEdit.Properties.AppearanceFocused.Image = CType(resources.GetObject("PassTextEdit.Properties.AppearanceFocused.Image"), System.Drawing.Image)
        Me.PassTextEdit.Properties.AppearanceFocused.Options.UseImage = True
        Me.PassTextEdit.Properties.AutoHeight = False
        Me.PassTextEdit.Properties.ContextImageOptions.AllowChangeAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.PassTextEdit.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.PassTextEdit.Properties.UseSystemPasswordChar = True
        Me.PassTextEdit.Size = New System.Drawing.Size(289, 45)
        Me.PassTextEdit.TabIndex = 2
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 0
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1208, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 680)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1208, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 680)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1208, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 680)
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 703)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IsMdiContainer = True
        Me.Name = "Main"
        Me.Ribbon = Me.ribbonControl1
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "CRM Alhuda Groups"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.RadialMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage5 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents الموظفين As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage6 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarDockingMenuItem1 As DevExpress.XtraBars.BarDockingMenuItem
    Friend WithEvents RibbonPage7 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup13 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonGalleryBarItem1 As DevExpress.XtraBars.RibbonGalleryBarItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup14 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup12 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage9 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RadialMenu1 As DevExpress.XtraBars.Ribbon.RadialMenu
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents RibbonPageCategory1 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelLastDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UserTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PassTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup17 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents RibbonPageGroup18 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup19 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup21 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem23 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem24 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarButtonItem25 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem26 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem27 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup16 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem28 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup22 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem29 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem30 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup20 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup23 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem31 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup24 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem32 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup25 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem33 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup26 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem34 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup27 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem35 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup28 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem36 As DevExpress.XtraBars.BarButtonItem
End Class
