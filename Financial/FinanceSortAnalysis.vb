﻿Imports DevExpress.XtraCharts

Public Class FinanceSortAnalysis
    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill a SqlDataSource asynchronously
        '  SqlDataSource2.FillAsync()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If String.IsNullOrEmpty(TextSortFrom.Text) Or String.IsNullOrEmpty(TextSortTo.Text) Or
            String.IsNullOrEmpty(TextMonth.Text) Or String.IsNullOrEmpty(TextYear.Text) Then
            MsgBox("يجب تعبئة كل البيانات المطلوبة")
            Return
        End If
        Dim SqlString As String = "SELECT  Cast(  sum( JMSUF ) as decimal(10,2)) As DebitBalance , ASORTGROUP  , ACSORTCODENAME  as ACSORTCODENAME  
        From    [ALHUDA].[dbo].RPHSTRANSRETRIV
         WHERE  (ASORTGROUP between '" & TextSortFrom.Text & "' and '" & TextSortTo.Text & "') And JMDEBITCREDIT=1 and    DATEPART(month, JVALUEDATE)=" & TextMonth.Text & " and DATEPART(year, JVALUEDATE)= " & TextYear.Text & " and ( 
         (0 <> JMSUF) )  AND JTYPE<>1 AND JTYPE <>2 AND 
        ((JSTATUS = 1 AND JTYPE<>1) OR (JSTATUS = 0 AND JTYPE=1)) AND ADUMI <> 3 
        group by ASORTGROUP,ACSORTCODENAME 
order by Cast(  sum( JMSUF ) as decimal(10,2)) "
        Dim Sql As New SQLControl
        Sql.WizCountRunQuery(SqlString)
        GridControl1.DataSource = Sql.SQLDS.Tables(0)
        '  ChartControl1.DataSource = Sql.SQLDS.Tables(0)

        With ChartControl1

            .Titles.Add(New ChartTitle() With {.Text = "المبيعات حسب التصنيف"})

            ' Create a pie series.
            Dim series1 As New Series("المبيعات حسب التصنيف", ViewType.Pie)

            ' Bind the series to data.
            series1.DataSource = Sql.SQLDS.Tables(0)
            series1.ArgumentDataMember = "ACSORTCODENAME"
            series1.ValueDataMembers.AddRange(New String() {"DebitBalance"})

            ' Add the series to the chart.
            .Series.Add(series1)

            ' Format the the series labels.
            ' series1.Label.TextPattern = "{n0}"

            '  Format the series legend items.
            series1.LegendTextPattern = "{A}"

            ' Adjust the position of series labels. 
            CType(series1.Label, PieSeriesLabel).Position = PieSeriesLabelPosition.TwoColumns

            ' Detect overlapping of series labels.
            CType(series1.Label, PieSeriesLabel).ResolveOverlappingMode = ResolveOverlappingMode.Default

            ' Access the view-type-specific options of the series.
            Dim myView As PieSeriesView = CType(series1.View, PieSeriesView)

            ' Specify a data filter to explode points.
            'myView.ExplodedPointsFilters.Add(New SeriesPointFilter(SeriesPointKey.Value_1, DataFilterCondition.GreaterThanOrEqual, 10000))
            'myView.ExplodedPointsFilters.Add(New SeriesPointFilter(SeriesPointKey.Argument, DataFilterCondition.NotEqual, "Others"))
            'myView.ExplodeMode = PieExplodeMode.UseFilters
            'myView.ExplodedDistancePercentage = 30
            'myView.RuntimeExploding = True

            ' Customize the legend.
            .Legend.Visibility = DevExpress.Utils.DefaultBoolean.True

            ' Add the chart to the form.
            '   .Dock = DockStyle.Fill
            '  Me.Controls.Add(pieChart)

        End With





    End Sub

    Private Sub FinanceSortAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class