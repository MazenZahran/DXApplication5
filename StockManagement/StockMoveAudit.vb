Public Class StockMoveAudit
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        FillData()
    End Sub
    Private Sub FillData()
        Try
            Dim SqlString As String
            Dim Sql As New SQLControl
            Dim _DocStatus As String = CStr(LookDocStatus.Text)

            'Try
            '    Select Case DocType
            '        Case "SalesDelivery"
            '            ColCredAcc.Visible = False
            '            ColCreditWhereHouse.Visible = True
            '            ColDebitAcc.Visible = True
            '            ColDebitWhereHouse.Visible = False
            '            ColAmount.Visible = True
            '            Me.Text = "ارسالية مبيعات"
            '        Case "PurchaseDelivery"
            '            ColDebitAcc.Visible = False
            '            ColDebitWhereHouse.Visible = True
            '            ColCredAcc.Visible = True
            '            ColCreditWhereHouse.Visible = False
            '            ColAmount.Visible = True
            '            Me.Text = "ارسالية مشتريات"
            '        Case "Transfer"
            '            ColDebitAcc.Visible = False
            '            ColDebitWhereHouse.Visible = True
            '            ColCredAcc.Visible = False
            '            ColCreditWhereHouse.Visible = True
            '            ColAmount.Visible = False
            '            Me.Text = "ارسالية داخلية"
            '    End Select

            'Catch ex As Exception

            'End Try

            SqlString = " SELECT DISTINCT DocID, DocDate, DocType, DocStatus, DebitAcc, CredAcc,
                                 DebitWhereHouse, CreditWhereHouse, Referance, Sum(Amount) as Amount,Driver,DocSort,DocManualNo,
                                 Sum(Quantity) as Quantity, Count(S.ID) as CountItems, '' as Audit,D.ID as DocSortID,A.IDDocName
                          FROM StockMove S
left join StockMoveDocSort1 D on S.DocSort=D.Book
Left join StockMoveDocuments A on S.DocType=A.DocEnglishName

                          Where   DocID > 0    "
            If DocType.Text <> "" Then SqlString += " and DocType='" & CStr(DocType.EditValue) & "'"
            If SearchDocSort.Text <> "" Then SqlString += " and DocSort='" & CStr(SearchDocSort.EditValue) & "'"
            If _DocStatus <> "" Then SqlString = SqlString + " And DocStatus= '" & CStr(LookDocStatus.EditValue) & "'"
            SqlString += "  Group By DocID, DocDate, DocType, DocStatus, DebitAcc, CredAcc,DebitWhereHouse,
                                   CreditWhereHouse, Referance,Driver,DocSort,DocManualNo,D.ID,IDDocName "
            MsgBox(SqlString)
            Sql.CRMRunQuery(SqlString)
            GridControl1.DataSource = Sql.SQLDS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        GridView1.BestFitColumns()



    End Sub

    Private Sub StockMoveAudit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.StockMoveDocSort1' table. You can move, or remove it, as needed.
        Me.StockMoveDocSort1TableAdapter.Fill(Me.CRMDataSet.StockMoveDocSort1)
        'TODO: This line of code loads data into the 'CRMDataSet.StockMoveDocStatus' table. You can move, or remove it, as needed.
        Me.StockMoveDocStatusTableAdapter.Fill(Me.CRMDataSet.StockMoveDocStatus)
        'TODO: This line of code loads data into the 'CRMDataSet.StockMoveDocuments' table. You can move, or remove it, as needed.
        Me.StockMoveDocumentsTableAdapter.Fill(Me.CRMDataSet.StockMoveDocuments)

    End Sub
End Class