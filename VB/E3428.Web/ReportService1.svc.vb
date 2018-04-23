Imports System
Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports DevExpress.Xpf.Printing.Service
Imports DevExpress.XtraReports.Service
Imports DevExpress.XtraReports.UI

' NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReportService1" 
' in code, svc and config file together.
<SilverlightFaultBehavior()>
    Public Class ReportService1
    Inherits DevExpress.XtraReports.Service.ReportService
    ' Un-comment this method if you need to extend the base functionality.
    ' Protected Overrides Sub CreateReportByName(reportName As String) As XtraReport
    '     Return MyBase.CreateReportByName(reportName)
    ' End Sub
End Class
