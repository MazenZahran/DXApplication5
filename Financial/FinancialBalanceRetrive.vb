﻿Public Class FinancialBalanceRetrive
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            Dim sql As New SQLControl
            Dim SqlString As String

            SqlString = "		 (COALESCE( (TQ_WIZCOUNT_I_1004.C0) ,0) * 1)  AS ALIAS6F,  (  ( COALESCE( (TQ_WIZCOUNT_I_1000.C0) ,0)  +  COALESCE( (TQ_WIZCOUNT_I_1001.C0) ,0)  -  COALESCE( (TQ_WIZCOUNT_I_1002.C0) ,0) )  -  ( COALESCE( (TQ_WIZCOUNT_I_1003.C0) ,0)  *  - 1)  +  COALESCE( (TQ_WIZCOUNT_I_1004.C0) ,0) )  AS ALIAS7F, CAST(SORTGROUP/1000 AS INT) AS ALIAS9F,
		  CAST(SORTGROUP/100 AS INT) AS ALIAS11F, CAST(SORTGROUP/10 AS INT) AS ALIAS13F, SORTGROUP AS ALIAS15F,
		  SORTCODENAME AS ALIAS15F_SN_1, SORTGROUP AS ALIAS15F_SN_2
FROM    (((([ALHUDA].[dbo].RPHSMAZ LEFT JOIN [ALHUDA].[dbo].TQ_WIZCOUNT_I_1000 ON (RPHSMAZ.ACCOUNTKEY=TQ_WIZCOUNT_I_1000.C1) )
			 LEFT JOIN [ALHUDA].[dbo].TQ_WIZCOUNT_I_1001 ON (RPHSMAZ.ACCOUNTKEY=TQ_WIZCOUNT_I_1001.C1) ) LEFT JOIN
			[ALHUDA].[dbo].TQ_WIZCOUNT_I_1002 ON (RPHSMAZ.ACCOUNTKEY=TQ_WIZCOUNT_I_1002.C1) ) LEFT JOIN
			[ALHUDA].[dbo].TQ_WIZCOUNT_I_1003 ON (RPHSMAZ.ACCOUNTKEY=TQ_WIZCOUNT_I_1003.C1) ) LEFT JOIN
			[ALHUDA].[dbo].TQ_WIZCOUNT_I_1004 ON (RPHSMAZ.ACCOUNTKEY=TQ_WIZCOUNT_I_1004.C1)  
WHERE 		( (2010 >= SORTGROUP) AND (2010 <= SORTGROUP) AND  1=1  AND  1=1  AND 
			 ( (.0010 <= (  ( COALESCE( (TQ_WIZCOUNT_I_1000.C0) ,0)  +  COALESCE( (TQ_WIZCOUNT_I_1001.C0) ,0)  -  COALESCE( (TQ_WIZCOUNT_I_1002.C0) ,0) )  -  ( COALESCE( (TQ_WIZCOUNT_I_1003.C0) ,0)  *  - 1)  +  COALESCE( (TQ_WIZCOUNT_I_1004.C0) ,0) )) OR (-.0010 >= (  ( COALESCE( (TQ_WIZCOUNT_I_1000.C0) ,0)  +  COALESCE( (TQ_WIZCOUNT_I_1001.C0) ,0)  -  COALESCE( (TQ_WIZCOUNT_I_1002.C0) ,0) )  -  ( COALESCE( (TQ_WIZCOUNT_I_1003.C0) ,0)  *  - 1)  +  COALESCE( (TQ_WIZCOUNT_I_1004.C0) ,0) )) )  )  AND ADUMI <> 3  
ORDER BY    SORTGROUP ASC  , ACCOUNTKEY ASC "

        Catch ex As Exception

        End Try
    End Sub
End Class