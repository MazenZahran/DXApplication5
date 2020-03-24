Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class CustomersOrdersAdd
    Private Sub CRMCustomersOrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CRMCustomersOrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)

    End Sub

    Private Sub CustomersOrdersAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet.CRMCustomersOrders' table. You can move, or remove it, as needed.
        '   Me.CRMCustomersOrdersTableAdapter.Fill(Me.CRMDataSet.CRMCustomersOrders)
        'NewDate()


        'GetMax()

        Me.KeyPreview = True
        CustNameTextBox.Select()
    End Sub

    Private Sub CustomersOrdersAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True 'this will prevent ding sound 

    End Sub


    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        Me.OpenFileDialog1.ShowDialog()
        Me.TextFilePath.Text = OpenFileDialog1.FileName
        'Using myFileDialog As New SaveFileDialog()
        '    myFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '    myFileDialog.FilterIndex = 1
        '    myFileDialog.InitialDirectory = "C:\"
        '    myFileDialog.CheckFileExists = False
        '    Dim result As DialogResult = myFileDialog.ShowDialog()
        '    If result = DialogResult.OK Then
        '        Me.SaveDocument(myFileDialog.FileName, DocumentFormat.PlainText)
        '    End If
        'End Using
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        NewDate()


        GetMax()

    End Sub
    Private Sub GetMax()
        Try
            Dim Sqlstring As String = "Select max(OrderID) as MaxID from [CRMCustomersOrders] "
            Dim sql As New SQLControl
            sql.CRMRunQuery(Sqlstring)
            IDTextBox.Text = CStr(CInt(sql.SQLDS.Tables(0).Rows(0).Item("MaxID").ToString) + 1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NewDate()





        Try
            Me.CRMCustomersOrdersBindingSource.AddNew()

        Catch ex As Exception
            '  XtraMessageBox.Show("خطا")
        End Try

        PdfViewer2.CloseDocument()
        OrderStatusTextBox.Text = "جديد"

        CustNameTextBox.Select()
        RecDateDateEdit.DateTime = CDate(DateTime.Now.ToString("yyyy-MM-dd"))

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click



        Dim Ressult As String = ""

        Try

            AddEvents("تنبيه", "طلب تعبئة جديد ل " & " " & Me.CustNameTextBox.Text, Me.Text, "1800013", My.Settings.UserName, "True")
            AddEvents("تنبيه", "طلب تعبئة جديد ل " & " " & Me.CustNameTextBox.Text, Me.Text, "1800102", My.Settings.UserName, "True")
            AddEvents("تنبيه", "طلب تعبئة جديد ل " & " " & Me.CustNameTextBox.Text, Me.Text, "1800666", My.Settings.UserName, "True")

            Me.Validate()
            Me.CRMCustomersOrdersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CRMDataSet)
            Ressult = Ressult + " تم حفظ البيانات "








            If TextFilePath.Text <> "" Then
                Dim TempOrderId As Integer
                Dim Sqlstring As String = "Select max(OrderID) as MaxID from [CRMCustomersOrders] "
                Dim sql As New SQLControl
                sql.CRMRunQuery(Sqlstring)
                TempOrderId = (CInt(sql.SQLDS.Tables(0).Rows(0).Item("MaxID").ToString))
                TempOrderId = CInt(OrderIDTextBox.Text) ' انا ضفته بتاريخ 22/11/2018 ممكن صح وممكن لا

                Dim file As Byte()
                Using stream = New FileStream(TextFilePath.Text, FileMode.Open, FileAccess.Read)
                    ' Using stream = PdfViewer2.s
                    Using reader = New BinaryReader(stream)
                        file = reader.ReadBytes(CInt(stream.Length))
                    End Using
                End Using
                Dim con As SqlConnection
                Dim cmd As SqlCommand
                Dim row As Integer
                con = New SqlConnection(CRMString)
                con.Open()
                cmd = New SqlCommand("update CRMCustomersOrders  set   CustImage = @File where OrderId = " & TempOrderId, con)
                cmd.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file
                row = cmd.ExecuteNonQuery()
                'If row > 0 Then
                '    MessageBox.Show("the row inserted" & row)
                'End If
                con.Close()
                Ressult = Ressult + " واضافة المرفقات "



            End If

            NewDate()
            GetMax()



            MsgBox(Ressult)

        Catch ex As Exception
            MsgBox(" خطا بحفظ البيانات")
            MsgBox(ex.ToString)
        End Try






    End Sub

    Private Sub FillByIDToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CRMCustomersOrdersTableAdapter.FillByID(Me.CRMDataSet.CRMCustomersOrders, CType(IDTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)




        '  Using varConnection = Locale.sqlConnectOneTime(Locale.sqlDataConnectionDetails)
        '  Using sqlWrite = New SqlCommand("INSERT INTO Raporty (RaportPlik) Values(@File)", varConnection)
        '  sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file
        '  sqlWrite.ExecuteNonQuery()
        '  End Using
        '  End Using

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs)
        Dim memoryStream As MemoryStream = New MemoryStream()


        Dim con As SqlConnection
        Dim cmd As SqlCommand
        Dim row As Integer
        'Dim str As String
        con = New SqlConnection(CRMString)
        con.Open()
        cmd = New SqlCommand(" select CustImage from  CRMCustomersOrders where OrderID=2 ", con)
        row = cmd.ExecuteNonQuery()

        Using sqlQueryResult = cmd.ExecuteReader()

            If sqlQueryResult IsNot Nothing Then
                sqlQueryResult.Read()
#Disable Warning BC42016 ' Implicit conversion
                Dim blob = New Byte((sqlQueryResult.GetBytes(0, 0, Nothing, 0, Integer.MaxValue)) - 1) {}
#Enable Warning BC42016 ' Implicit conversion
                sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length)
                memoryStream.Write(blob, 0, blob.Length)
                PdfViewer1.LoadDocument(memoryStream)
            End If
        End Using

        con.Close()
    End Sub

    Private Sub SimpleButton4_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Try
            TextFilePath.Text = ""
            Me.OpenFileDialog1.ShowDialog()
            Me.TextFilePath.Text = OpenFileDialog1.FileName
            Me.PdfViewer2.LoadDocument(OpenFileDialog1.FileName)
        Catch ex As Exception

        End Try



    End Sub

    Private Sub IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles IDTextBox.TextChanged

        NewDate()

        If IDTextBox.Text = "" Then Exit Sub

        Try
            Me.CRMCustomersOrdersTableAdapter.FillByID(Me.CRMDataSet.CRMCustomersOrders, CType(IDTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        Try
            '    If OrderIDTextBox.Text = "" Then Exit Try
            Dim memoryStream As MemoryStream = New MemoryStream()
            Dim con As SqlConnection
            Dim cmd As SqlCommand
            Dim row As Integer
            'Dim str As String
            con = New SqlConnection(CRMString)
            con.Open()
            cmd = New SqlCommand(" select CustImage from  CRMCustomersOrders where OrderID= " & IDTextBox.Text, con)
            row = cmd.ExecuteNonQuery()

            Using sqlQueryResult = cmd.ExecuteReader()

                If sqlQueryResult IsNot Nothing Then
                    sqlQueryResult.Read()
#Disable Warning BC42016 ' Implicit conversion
                    Dim blob = New Byte((sqlQueryResult.GetBytes(0, 0, Nothing, 0, Integer.MaxValue)) - 1) {}
#Enable Warning BC42016 ' Implicit conversion
                    sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length)
                    memoryStream.Write(blob, 0, blob.Length)
                    PdfViewer2.LoadDocument(memoryStream)
                End If
            End Using
            con.Close()
        Catch ex As Exception
            '   MsgBox(ex.ToString)
            PdfViewer2.CloseDocument()
        End Try

    End Sub

    Private Sub TextFilePath_EditValueChanged(sender As Object, e As EventArgs) Handles TextFilePath.EditValueChanged

    End Sub

    Private Sub IDTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles IDTextBox.TextChanged

    End Sub

    Private Sub SimpleButtonNext_Click(sender As Object, e As EventArgs) Handles SimpleButtonNext.Click

        Try
            IDTextBox.Text = CStr(CInt(IDTextBox.Text) + 1)
            IDTextBox_TextChanged(sender, e)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub SimpleButtonPrevios_Click(sender As Object, e As EventArgs) Handles SimpleButtonPrevios.Click

        Try
            IDTextBox.Text = CStr(CInt(IDTextBox.Text) - 1)
            IDTextBox_TextChanged(sender, e)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Try
            Dim report As New CRMCustomersOrdersReport()
            report.Parameter1.Value = Me.OrderIDTextBox.Text
            report.Parameter1.Visible = False
            report.CreateDocument()
            report.PrintingSystem.ShowMarginsWarning = False
            report.Print()

            PdfViewer2.ShowPrintStatusDialog = False
            PdfViewer2.Print()

        Catch ex As Exception
            MsgBox("خطا: لم يتمكن البرنامج من الطلب")
            ' MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click

        Try
            If ComboBoxEditStatus.Text = "" Then MsgBox("حالة الزبون فارغة") : Exit Sub
            If TextEditAccountID.Text = "" Then MsgBox("رقم حساب الزبون فارغ") : Exit Sub
            Dim sql As New SQLControl
            Dim SqlUpdate As String = "update CRMCustomersOrders  set  
                                         MangerReply = '" & MemoEdit1.Text & "' 
                                        ,OrderStatus ='" & ComboBoxEditStatus.Text & "'
                                        ,AccountID ='" & TextEditAccountID.Text & "'
                                        where OrderId= " & OrderIDTextBox.Text
            sql.CRMRunQuery(SqlUpdate)
            XtraMessageBox.Show("  تم اضافة رد")
            AddEvents("تنبيه", "    حالة الطلب  " & " " & ComboBoxEditStatus.Text & vbNewLine & Me.CustNameTextBox.Text, Me.Text, "1800013", My.Settings.UserName, "True")

            Dim AccountPath As String = "Z:\Archive\" & TextEditAccountID.Text
            If (Not System.IO.Directory.Exists(AccountPath)) Then
                System.IO.Directory.CreateDirectory(AccountPath)
            End If

            Dim sql2 As New SQLControl
            Dim SqlString As String = " Select Max(DocID) As FileName from ArchiveDocs"
            sql2.CRMRunQuery(SqlString)
            Dim FileNameID = CInt(sql2.SQLDS.Tables(0).Rows(0).Item("FileName")) + 1
            Dim TargetFilePath As String = "Z:\Archive\" & TextEditAccountID.Text & "\" & FileNameID & ".pdf"




            Dim report As New CRMCustomersOrdersReport()
            report.Parameter1.Value = Me.OrderIDTextBox.Text
            report.Parameter1.Visible = False
            report.ExportToPdf("Z:\Archive\" & TextEditAccountID.Text & "\" & FileNameID & ".pdf")

            Dim sql4 As New SQLControl
            Dim SQLInsert2 As String = " Insert Into  [ArchiveDocs] 
                                            (  [DocName],DocType,DocAccountCode,DocDetails,DocInputDate,DocInputUser,DocLocation) 
                                            Values (  '" & " طلب التعبئة الالكتروني" & "','" & "طلب تعبئة" & "','" & TextEditAccountID.Text & "','" _
                                            & " " & "','" & Format(Now, "yyyy-MM-dd HH:mm") _
                                            & "','" & My.Settings.UserName & "','" & "Z:\Archive\" & TextEditAccountID.Text & "\" & CInt(FileNameID) & ".pdf" & "')"
            sql4.CRMRunQuery(SQLInsert2)



            If PdfViewer2.DocumentFilePath <> vbNullString Then
                PdfViewer2.SaveDocument("Z:\Archive\" & TextEditAccountID.Text & "\" & FileNameID + 1 & ".pdf")
                Dim sql3 As New SQLControl
                Dim SQLInsert As String = " Insert Into  [ArchiveDocs] 
                                            (  [DocName],DocType,DocAccountCode,DocDetails,DocInputDate,DocInputUser,DocLocation) 
                                            Values (  '" & "مرفقات طلب التعبئة" & "','" & "طلب تعبئة" & "','" & TextEditAccountID.Text & "','" _
                                                & " " & "','" & Format(Now, "yyyy-MM-dd HH:mm") _
                                                & "','" & My.Settings.UserName & "','" & "Z:\Archive\" & TextEditAccountID.Text & "\" & CInt(FileNameID) + 1 & ".pdf" & "')"

                sql3.CRMRunQuery(SQLInsert)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub OrderStatusTextBox_TextChanged(sender As Object, e As EventArgs) Handles OrderStatusTextBox.TextChanged
        ComboBoxEditStatus.Text = OrderStatusTextBox.Text
    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles SimpleButton3.Click

    End Sub

    Private Sub SimpleButton4_Click_2(sender As Object, e As EventArgs)

    End Sub
End Class