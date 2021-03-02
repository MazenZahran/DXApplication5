Imports System.Data.SqlClient

Public Class VouchersForTax
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        FillData()

    End Sub

    Private Sub FillData()
        Dim Sql As New SQLControl
        Dim TaxDate As String = Format(DateEdit1.DateTime, "yyyy-MM-dd")
        Dim SqlString As String = "   select A.Amount,A.VouchDate,A.CustName,CustID,A.VouchNo,isnull(D.QuantDiesle,0) as QuantDiesle, isnull(DieslePrice,0) as DieslePrice,ISNULL(AmountDiesle,0) as AmountDiesle,isnull(Quant95,0) as Quant95 ,isnull(Benz95Price,0) as Benz95Price ,ISNULL(Amount95,0) as Amount95,isnull(Quant98,0) as Quant98 ,isnull(Benz98Price,0) as Benz98Price,isnull(Amount98,0) as Amount98 ,isnull(AmountGaz,0) as AmountGaz,
A.Amount-isnull(AmountDiesle,0) -isnull(Amount95,0) -isnull(Amount98,0)-isnull(AmountGaz,0) as Oil from 
  ( select CustName,CustID, VouchDate, VouchNo,Amount from  [CRM].[dbo].VouchersHeader where VouchDate <='" & TaxDate & "' and VoucherStatus is null and VoucherTaxPeriod IS NULL ) A
  left join
  ( select h.CustName, h.VouchDate, h.VouchNo,h.Amount,SUM(Quantity) As QuantDiesle ,SUM(d.Amount) as AmountDiesle,AVG(Price) as DieslePrice from [CRM].[dbo].[VouchersDetails] D left join [CRM].[dbo].VouchersHeader H on   H.VouchNo=D.VouchNo where  SotckName='سولار' and VouchDate <='" & TaxDate & "' And VoucherStatus is null  group by h.vouchNo,CustName,VouchDate,h.Amount ) D
  on A.VouchNo=D.VouchNo
  left join
  ( select h.CustName, h.VouchDate, h.VouchNo,h.Amount,SUM(Quantity) As Quant95 ,SUM(d.Amount) as Amount95,AVG(Price) as Benz95Price from [CRM].[dbo].[VouchersDetails] D left join [CRM].[dbo].VouchersHeader H on   H.VouchNo=D.VouchNo where  (SotckName='95' or SotckName='بنزين95') and VouchDate <='" & TaxDate & "' And VoucherStatus is null  group by h.vouchNo,CustName,VouchDate,h.Amount ) B
on A.VouchNo = B.VouchNo 
  left join
  ( select h.CustName, h.VouchDate, h.VouchNo,h.Amount,SUM(Quantity) As Quant98 ,SUM(d.Amount) as Amount98,AVG(Price) as Benz98Price from [CRM].[dbo].[VouchersDetails] D left join [CRM].[dbo].VouchersHeader H on   H.VouchNo=D.VouchNo where  (SotckName='98' or SotckName='بنزين98') and VouchDate <='" & TaxDate & "' And VoucherStatus is null group by h.vouchNo,CustName,VouchDate,h.Amount ) C
on A.VouchNo = C.VouchNo
left join
  ( select h.CustName, h.VouchDate, h.VouchNo,h.Amount,SUM(Quantity) As QuantGaz ,SUM(d.Amount) as AmountGaz,AVG(Price) as GazPrice from [CRM].[dbo].[VouchersDetails] D left join [CRM].[dbo].VouchersHeader H on   H.VouchNo=D.VouchNo where  (SotckName='غاز' ) and VouchDate <='" & TaxDate & "' group by h.vouchNo,CustName,VouchDate,h.Amount ) G
on A.VouchNo = G.VouchNo "
        Sql.CRMRunQuery(SqlString)
        GridControl1.DataSource = Sql.SQLDS.Tables(0)

        UpdateStockName()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GridControl1.ShowPrintPreview()
        'g


    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        'Dim i As Integer
        'For i = 0 To GridView1.RowCount - 1
        '    PrintVoucher(False, CInt(GridView1.GetRowCellValue(i, "VouchNo")), False)
        'Next
    End Sub
    Private Sub UpdateStatus(VoucherNo As Integer)
        Dim Sql As New SQLControl
        Dim SqlString As String
        SqlString = " Update  VoucherNo  "
    End Sub

    Private Sub UpdateStockName()
        Dim Sql As New SQLControl
        Sql.CRMRunQuery(" update [CRM].[dbo].[VouchersDetails]
  set SotckName='95' WHERE (SotckName = N'بنزين95')")
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim i As Integer
        Dim TaxDate As String = Format(DateEdit1.DateTime, "yyyy-MM-dd")
        Dim cmd As SqlCommand
            Dim con As SqlConnection
            Dim row As Integer
        con = New SqlConnection(CRMString)
        con.Open()
        For i = 0 To GridView1.RowCount - 1
            Dim VouchNo As String = CStr(GridView1.GetRowCellValue(i, "VouchNo"))
            cmd = New SqlCommand("update [CRM].[dbo].[VouchersHeader]   set VoucherTaxPeriod = '" & TaxDate & "' where VouchNo=" & VouchNo, con)
            row = cmd.ExecuteNonQuery()
        Next
        con.Close()


        GridView1.OptionsSelection.MultiSelect = True
        GridView1.SelectAll()
        GridView1.CopyToClipboard()
        GridView1.OptionsSelection.MultiSelect = False



    End Sub




End Class