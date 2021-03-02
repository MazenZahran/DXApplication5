Imports DevExpress.XtraCharts
Imports System.Timers



Public Class OrpakStationsSales2
    Dim chartTitle1 As New ChartTitle()
    Dim chartTitle2 As New ChartTitle()
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        CreatChart()
    End Sub

    Private Sub CreatChart()
        Dim DDate As String = Format(DateEdit1.DateTime, "yyyy-MM-dd")

        Dim Item As String = CStr(SearchLookUpEditItems.EditValue)
        If String.IsNullOrEmpty(Item) Then Item = "Null"

        Dim TransType As String = CStr(ComboBoxEditType.Text)
        If String.IsNullOrEmpty(TransType) Then TransType = "Null"
        If ComboBoxEditType.Text = "All" Then TransType = "Null"


        Try

            Dim sql As New SQLControl

            Dim SqlString As String = " SELECT sum([quantity]) as QSum  ,product_name,[stn_name]
                                        FROM [HO_DATA].[dbo].[transactions],[HO_DATA].[dbo].[stations]
                                        Where [transactions].stn_id = [stations].stn_id and date='" & DDate & "'"

            If CInt(SearchLookUpEditItems.EditValue) > 0 Then
                SqlString = SqlString + " and product_code=" & Item
            Else
                SqlString = SqlString + " and ( [product_code] =1 or [product_code]=2 )"
            End If

            If TransType <> "Null" Then
                If TransType <> "ALL" Then SqlString = SqlString + " and type ='" & TransType & "'"
            End If

            SqlString = SqlString + " group by  [product_code]  ,[stn_name],product_name "
            SqlString = SqlString + " order by QSum desc "

            sql.RunQuery(SqlString)
            ChartControl1.DataSource = sql.SQLDS.Tables(0)

            CreateTitle()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub OrpakStationsSales2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.ItemSortNames' table. You can move, or remove it, as needed.
        Me.ItemSortNamesTableAdapter.Fill(Me.WizCountDataSet.ItemSortNames)
        'TODO: This line of code loads data into the 'WizCountDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.WizCountDataSet.Items)
        Me.DateEdit1.DateTime = Today

        Dim Timer1 As System.Timers.Timer = New Timer(60000)
        AddHandler Timer1.Elapsed, AddressOf OnTimedEvent
        Timer1.Enabled = True
        CreatChart()
    End Sub
    Private Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)
        '   ChartControl1.Titles.Clear()
        If CheckEdit1.Checked = True Then CreatChart()
    End Sub

    Private Sub CreateTitle()

        ChartControl1.Titles.Clear()
        ' Define the text for the titles.
        chartTitle1.Text = "تقرير المبيعات اليومية"
        chartTitle2.Text = "اخر تحديث" & ": " & Format(Now, "yyyy-MM-dd HH:mm")

        chartTitle2.WordWrap = True
        chartTitle2.MaxLineCount = 2

        ' Define the alignment of the titles.
        chartTitle1.Alignment = StringAlignment.Center
        chartTitle2.Alignment = StringAlignment.Center

        ' Place the titles where it's required.
        chartTitle1.Dock = ChartTitleDockStyle.Top
        chartTitle2.Dock = ChartTitleDockStyle.Top

        ' Customize a title's appearance.
#Disable Warning BC40000 ' Type or member is obsolete
        chartTitle1.Antialiasing = True
#Enable Warning BC40000 ' Type or member is obsolete
        chartTitle1.Font = New Font("Tahoma", 14, FontStyle.Bold)
        chartTitle1.TextColor = Color.Red
        chartTitle1.Indent = 10

#Disable Warning BC40000 ' Type or member is obsolete
        chartTitle2.Antialiasing = True
#Enable Warning BC40000 ' Type or member is obsolete
        chartTitle2.Font = New Font("Tahoma", 10, FontStyle.Bold)
        chartTitle2.TextColor = Color.Blue
        chartTitle2.Indent = 10

        ' Add the titles to the chart.
        ChartControl1.Titles.AddRange(New ChartTitle() {chartTitle1, chartTitle2})
    End Sub


    Private Sub DateNavigator1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub SearchLookUpEditItems_EditValueChanged(sender As Object, e As EventArgs) Handles SearchLookUpEditItems.EditValueChanged

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            RibbonControl1.Visible = False
        Else
            RibbonControl1.Visible = True
        End If
    End Sub
End Class