Partial Class CRMDataSet
    Partial Public Class transDocDataTable
        Private Sub transDocDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class BawaqeStatusDataTable
        Private Sub BawaqeStatusDataTable_BawaqeStatusRowChanging(sender As Object, e As BawaqeStatusRowChangeEvent) Handles Me.BawaqeStatusRowChanging

        End Sub

    End Class

    Partial Public Class ReceiptDataDataTable
    End Class
End Class

Namespace CRMDataSetTableAdapters
    Partial Public Class PrintingSystemDocsTableAdapter
    End Class

    Partial Public Class ReceiptDataTableAdapter
    End Class

    Partial Public Class EmployeesDataTableAdapter
    End Class
End Namespace
