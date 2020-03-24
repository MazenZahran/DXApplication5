Imports DevExpress.XtraCharts
Imports System.Timers



Public Class OrpakStationsEmpTrans
    Dim chartTitle1 As New ChartTitle()
    Dim chartTitle2 As New ChartTitle()
    Dim Station As String
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        CreatChart()
    End Sub

    Private Sub CreatChart()
        Dim DDate As String = Format(DateEdit1.DateTime, "yyyy-MM-dd HH:mm")

        Dim TDate As String

        If CheckEditAutoTime.Checked = True Then
            TDate = Format(Now, "yyyy-MM-dd HH:mm")
        Else
            TDate = Format(DateEdit2.DateTime, "yyyy-MM-dd HH:mm")
        End If

        Dim Item As String = CStr(SearchLookUpEditItems.EditValue)
        If String.IsNullOrEmpty(Item) Then Item = "Null"

        Station = CStr(ComboBoxStation.EditValue)
        If String.IsNullOrEmpty(Station) Then Station = "Null"
        If ComboBoxStation.Text = "All" Then Station = "Null"


        Try

            Dim sql As New SQLControl

            Dim SqlString As String = " SELECT count([quantity]) as QSum  ,[stn_name],plate
                                        FROM [HO_DATA].[dbo].[transactions],[HO_DATA].[dbo].[stations]
                                        Where [transactions].stn_id = [stations].stn_id and [quantity]>1 and type='ATNDT' 
                                        and (timestamp between '" & DDate & "'" & " And " & "'" & TDate & "'" & ")"

            If CInt(SearchLookUpEditItems.EditValue) > 0 Then
                SqlString = SqlString + " and product_code=" & Item
            Else
                SqlString = SqlString + " and ( [product_code] =1 or [product_code]=2 )"
            End If

            If Station <> "Null" Then
                If Station <> "ALL" Then SqlString = SqlString + " and [stations].stn_id ='" & Station & "'"
            End If

            SqlString = SqlString + " group by  plate,[stn_name] "
            SqlString = SqlString + " order by QSum desc "

            sql.RunQuery(SqlString)
            ChartControl1.DataSource = sql.SQLDS.Tables(0)

            CreateTitle()


            Dim SqlStringCountAll As String = " SELECT count([quantity]) as QSum 
                                        FROM [HO_DATA].[dbo].[transactions]
                                        Where  [quantity]>1 and type='ATNDT' 
                                        and (date between '" & DDate & "'" & " And " & "'" & TDate & "'" & ")"
            sql.RunQuery(SqlStringCountAll)
            For i As Integer = 0 To ChartControl1.AnnotationRepository.Count - 1
                CType(ChartControl1.AnnotationRepository(i), TextAnnotation).Text = " اجمالي الحركات " & sql.SQLDS.Tables(0).Rows(0).Item("QSum").ToString
            Next


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub OrpakStationsSales2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WALLETDataSet.STATIONS' table. You can move, or remove it, as needed.
        Me.STATIONSTableAdapter.Fill(Me.WALLETDataSet.STATIONS)
        'TODO: This line of code loads data into the 'WizCountDataSet.ItemSortNames' table. You can move, or remove it, as needed.
        Me.ItemSortNamesTableAdapter.Fill(Me.WizCountDataSet.ItemSortNames)
        'TODO: This line of code loads data into the 'WizCountDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.WizCountDataSet.Items)
        Me.DateEdit1.DateTime = Today
        Me.DateEdit2.DateTime = Now

        Dim Timer1 As System.Timers.Timer = New Timer(600000 / 10)
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