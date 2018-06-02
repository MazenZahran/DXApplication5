Module SQLString
    Public OrbakString As String = "Data Source=192.168.0.20;Initial Catalog=HO_DATA;Persist Security Info=True;User ID=sa;Password=Sa123456"
    Public WizCountString As String = "Data Source=WIZCOUNT\WIZSOFT;Initial Catalog=alhuda;Persist Security Info=True;User ID=sa;Password=1234"
    Public CRMString As String = "Data Source=WIZCOUNT\WIZSOFT;Initial Catalog=CRM;Persist Security Info=True;User ID=sa;Password=1234;Max Pool Size=1000"
    Public CheuqesString As String = "Data Source=WIZCOUNT\WIZSOFT;Initial Catalog=ClearingSystem;Persist Security Info=True;User ID=sa;Password=1234"
    Public ExcelString As String = "Microsoft.ACE.OLEDB.12.0;Data Source=c:\myFolder\myExcel2007file.xlsx; Extended Properties=Excel 12.0 Xml;HDR=YES"

    ';Max Pool Size=50000;Pooling=True
    ' Public ExcelString As String = "DBQ=‪Z:\CRLite\DATA.xlsm;HDR=yes;IMEX=1;ReadOnly=False"
    ' Provider=MSDASQL.1;DSN=Excel Files;
    '   Public ServerString As String = "Data Source=MAZENHOME\SQLEXPRESS;Initial Catalog=Employee;Persist Security Info=True;User ID=sa;Password=Sa123456"
    '   Public ServerString As String = "Data Source=213.6.5.92\global;Initial Catalog=Employee;Persist Security Info=True;User ID=sa;Password=123456"
    '   Public ServerString As String = " workstation id=AlhudaEmployee.mssql.somee.com;packet size=4096;user id=mazen_excel_SQLLogin_1;pwd=ug1xoq37yk;data source=AlhudaEmployee.mssql.somee.com;persist security info=False;initial catalog=AlhudaEmployee "
End Module