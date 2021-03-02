Public Class OrpakCustomerCards
    Private Sub OrpakCustomerCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WizCountDataSet.Accounts1' table. You can move, or remove it, as needed.


    End Sub

    Private Sub SearchCustomer_EditValueChanged(sender As Object, e As EventArgs) Handles SearchCustomer.EditValueChanged
        GetCards()
    End Sub

    Private Sub SearchCustomer_BeforePopup(sender As Object, e As EventArgs) Handles SearchCustomer.BeforePopup
        Me.Accounts1TableAdapter.Fill(Me.WizCountDataSet.Accounts1)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        GetCards()
    End Sub
    Private Sub GetCards()

        Dim sql_string As String
            sql_string = "SELECT     means.name,   means.plate, means.available_amount, " & vbNewLine &
            " means.month_volume, " & vbNewLine &
            "means.month_money ,  means.month_visits, means.issued_date, means.last_used, CASE WHEN len(means.string) = '16' THEN 'Ring' WHEN len(means.string) = '8' then 'Card' ELSE 'UN' END AS ttype ,  group_rules.Description" & vbNewLine &
            "FROM       means INNER JOIN" & vbNewLine &
            "group_rules ON means.[rule] = group_rules.id INNER JOIN" & vbNewLine &
            "fleets ON means.fleet_id = fleets.id" & vbNewLine &
            " WHERE 1=1 "


            If Not String.IsNullOrEmpty(CStr(Me.SearchCustomer.Text)) Then
                sql_string += " And fleets.code = " & "'" & CStr(Me.SearchCustomer.EditValue) & "'"
            End If

            Select Case CStr(RadioType.EditValue)
                Case "All"
                    sql_string += " and len(means.string) > 0 "
                Case "Card"
                    sql_string += " and len(means.string) = 8 "
                Case "Ring"
                    sql_string += " and len(means.string) = 16 "
            End Select

            Select Case CStr(RadioStatus.EditValue)
                Case "All"
                    sql_string += " and means.status > 0  "
                Case "Active"
                    sql_string += " and means.status = 2 "
                Case "NotActive"
                    sql_string += " and means.status = 1 "
            End Select

            Select Case CStr(RadioSpedometer.EditValue)
                Case "All"
                    sql_string += " and means.opos_prompt_for_odometer >= 0  "
                Case "Active"
                    sql_string += " and means.opos_prompt_for_odometer = 1 "
                Case "NotActive"
                    sql_string += " and means.opos_prompt_for_odometer = 0 "
            End Select

            '  If Me.spedometer <> "" Then sql_string = sql_string + " and   means.opos_prompt_for_odometer='" & Me.spedometer & "'"
            '  If Me.CheckBox1.Value = False Then sql_string = sql_string + " and   group_rules.Description <> 'CAR WASHING'"
            '  If Me.CheckBox2.Value = True Then sql_string = sql_string + " and   means.month_visits <> '0'"
            '  If Me.TextBox8 <> "" Then sql_string = sql_string + " and means.plate like '%" & Me.TextBox8 & "%'"
            sql_string += " order by means.name"

            Dim Sql As New SQLControl
            Sql.RunQuery(sql_string)
            GridControl1.DataSource = Sql.SQLDS.Tables(0)

    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioType.SelectedIndexChanged
        GetCards()
    End Sub

    Private Sub RadioStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioStatus.SelectedIndexChanged
        GetCards()
    End Sub

    Private Sub RadioSpedometer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioSpedometer.SelectedIndexChanged
        GetCards()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GridView1.OptionsSelection.MultiSelect = True
        GridView1.SelectAll()
        GridView1.CopyToClipboard()
        GridView1.OptionsSelection.MultiSelect = False
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        GetCards()
    End Sub
End Class