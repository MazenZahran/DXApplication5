Imports DevExpress.XtraEditors

Public Class OrpakEditCard

    Private Sub OrpakEditCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HO_DATADataSet.group_rules' table. You can move, or remove it, as needed.
        Me.Group_rulesTableAdapter.Fill(Me.HO_DATADataSet.group_rules)
        'TODO: This line of code loads data into the 'HO_DATADataSet.means' table. You can move, or remove it, as needed.
        '  Me.MeansTableAdapter.Fill(Me.HO_DATADataSet.means)
        'TODO: This line of code loads data into the 'HO_DATADataSet.fleets' table. You can move, or remove it, as needed.
        Me.FleetsTableAdapter.Fill(Me.HO_DATADataSet.fleets)

        MeansStatus()

        TexOldVlaues.Text = "Car:" & TextPlate.Text & " Card:" & TextCardNo.Text & " Fleet:" & SearchFleet.Text & " Rule:" & TextGroupRules.Text & " Status:" & LookStatus.Text

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If EditCard(CInt(TextID.EditValue)) = True Then
            XtraMessageBox.Show("تم التعديل")
            Me.Dispose()
        Else
            XtraMessageBox.Show("خطا ، لا يمكن تعديل البطاقة")
        End If
    End Sub

    Private Sub SearchCardID_EditValueChanged(sender As Object, e As EventArgs) Handles SearchCardID.EditValueChanged
        If SearchCardID.IsHandleCreated Then
            Me.TextID.EditValue = SearchCardID.EditValue
        End If
    End Sub

    Private Function GetMeansTable() As DataTable
        Dim _Means As New DataTable
        Dim Sql As New SQLControl
        Try
            Sql.RunQuery("Select  means.name,string,means.id,Fleets.name as Fleet From Means left join Fleets on Fleets.id=Means.fleet_id ")
            _Means = Sql.SQLDS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return _Means
    End Function
    Private Sub MeansStatus()
        Dim MeanStatus As New DataTable
        MeanStatus.Columns.Add("ID", GetType(System.Int32))
        MeanStatus.Columns.Add("CardStatus", GetType(System.String))
        MeanStatus.Rows.Add(2, "Active")
        MeanStatus.Rows.Add(1, "Blocked")
        MeanStatus.Rows.Add(0, "Deleted")
        LookStatus.Properties.DataSource = MeanStatus
    End Sub

    Private Sub LookStatus_EditValueChanged(sender As Object, e As EventArgs) Handles LookStatus.EditValueChanged

    End Sub

    Private Function EditCard(CardID As Integer, ActiveOrStop As Integer) As Boolean
        Dim _Result As Boolean
        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = " Update Means set [status] = " & ActiveOrStop & " where [id] = " & CardID
            Sql.RunQuery(SqlString)
            If IssueToStations(CardID, 17) = "Success" Then
                _Result = True
            Else
                _Result = False
            End If
        Catch ex As Exception
            _Result = False
        End Try
        Return _Result
    End Function

    Private Sub Seraching(_SearchCardID As Integer)
        If String.IsNullOrEmpty(CStr(_SearchCardID)) Then Exit Sub
        Try
            Dim Sql As New SQLControl
            Dim SqlString As String = "select M.name as CardNo,M.string,M.id,M.[status],
                                              M.[rule],M.[fleet_id],M.Plate,D.id as DepID
                                        from means M
                                        left join depts D on D.fleet_id=M.fleet_id
                                        where M.id=" & CStr(_SearchCardID)
            Sql.RunQuery(SqlString)
            With Sql.SQLDS.Tables(0).Rows(0)
                TextCardNo.Text = .Item("CardNo").ToString()
                SearchFleet.Text = .Item("fleet_id").ToString()
                TextString.Text = .Item("string").ToString()
                TextID.Text = .Item("id").ToString()
                TextGroupRules.Text = .Item("rule").ToString()
                LookStatus.EditValue = CInt(.Item("status").ToString())
                TextPlate.Text = .Item("Plate").ToString()
                DepID.Text = .Item("DepID").ToString()

            End With

        Catch ex As Exception

        End Try

        Try
            Dim Sql As New SQLControl
            Dim SqlString As String
            SqlString = " Select CardTransDate,TransUser,TransNotes,OldValues from CardsTrans where CardID2= " & CStr(_SearchCardID)
            Sql.CRMRunQuery(SqlString)
            GridControl1.DataSource = Sql.SQLDS.Tables(0)
            GridView3.BestFitColumns()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SearchCardID_BeforePopup(sender As Object, e As EventArgs) Handles SearchCardID.BeforePopup
        SearchCardID.Properties.DataSource = GetMeansTable()
    End Sub


    Private Sub TextID_EditValueChanged(sender As Object, e As EventArgs) Handles TextID.EditValueChanged
        If String.IsNullOrEmpty(TextID.Text) Then Exit Sub
        If TextID.Text = "" Then Exit Sub
        '  If SearchCardID.IsHandleCreated Then
        Seraching(CInt(TextID.Text))
        '  End If
    End Sub
    Private Function EditCard(CardID As Integer) As Boolean
        Dim _Result As Boolean
        Dim _CardName As String = TextCardNo.Text
        Dim _Plate As String = TextPlate.Text
        Dim _CardSerial As String = TextString.Text
        Dim _GroupRule As Integer = CInt(TextGroupRules.EditValue)
        Dim _CardStatus As Integer = CInt(LookStatus.EditValue)
        Dim _Dep As Integer = CInt(DepID.EditValue)
        Dim _FleetID As Integer = CInt(SearchFleet.EditValue)
        If MemoEdit1.text="" Then
            MsgBox("يجب اضافة ملاحظة")
            _Result = False
            Exit Function
        End If
            If String.IsNullOrEmpty(_CardName) Or String.IsNullOrEmpty(_Plate) Or String.IsNullOrEmpty(_CardSerial) _
            Or String.IsNullOrEmpty(CStr(_GroupRule)) Or String.IsNullOrEmpty(CStr(_CardStatus)) _
            Or String.IsNullOrEmpty(CStr(_Dep)) Or String.IsNullOrEmpty(CStr(_FleetID)) Then
            XtraMessageBox.Show("يجب تعبئة كل البيانات المطلوبة")
            _Result = False
        Else
            Try
                Dim Sql As New SQLControl
                Dim SqlString As String
                SqlString = " Update Means set [status] = " & _CardStatus & " , [name]='" & _CardName & "' ,
                                [plate] ='" & _Plate & "', [string]='" & _CardSerial & "',
                                [rule]=" & _GroupRule & " ,fleet_id='" & _FleetID & "' ,dept_id='" & _Dep & "'   where [id] = " & CardID
                Sql.RunQuery(SqlString)
                If IssueToStations(CardID, 17) = "Success" Then
                    _Result = True
                Else
                    _Result = False
                End If
                Seraching(CInt(TextID.Text))
                ' XtraMessageBox.Show("تم التعديل")
            Catch ex As Exception
                _Result = False
            End Try

            Try
                Dim Sql As New SQLControl
                Dim Sqlstring As String
                Sqlstring = " Insert Into CardsTrans
                                (CardID,CardTransDate,CardSerial,[PlateNo],TransNotes,TransUser,OldValues,CardID2)
                                Values (
                                '" & TextCardNo.Text & "',
                                     GETDATE(),
                                '" & TextID.Text & "',
                                '" & TextCardNo.Text & "',
                                '" & MemoEdit1.Text & "',
                                '" & GlobalVariables.UserIDString & "',
                                '" & TexOldVlaues.Text & "',
                                '" & TextID.Text & "'
                                )"
                Sql.CRMRunQuery(Sqlstring)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
        Return _Result
    End Function
    Private Sub TextCardNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextCardNo.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub TextPlate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPlate.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890-/"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextString_EditValueChanged(sender As Object, e As EventArgs) Handles TextString.EditValueChanged

    End Sub

    Private Sub TextString_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextString.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub InsertCardLog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        'Me.Close()
    End Sub

    Private Sub TextCardNo_EditValueChanged(sender As Object, e As EventArgs) Handles TextCardNo.EditValueChanged

    End Sub

    Private Sub SearchFleet_EditValueChanged(sender As Object, e As EventArgs) Handles SearchFleet.EditValueChanged
        If SearchFleet.IsHandleCreated = True Then
            DepID.Text = GetDep(CStr(SearchFleet.EditValue))
        End If

    End Sub
    Private Function GetDep(FleetID As String) As String
        Dim _GetDep As String
        Try
            Dim Sql As New SQLControl
            Sql.RunQuery("  select top (1)  D.id as DepID
  FROM [HO_DATA].[dbo].depts D
  where fleet_id= '" & FleetID & "'")
            _GetDep = CStr(Sql.SQLDS.Tables(0).Rows(0).Item("DepID"))
        Catch ex As Exception
            _GetDep = "0"
        End Try
        Return _GetDep
    End Function

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class