' Developer Express Code Central Example:
' How to use a stored procedure with parameters as a report data source in Silverlight
' 
' In this example, the report is bound to the Northwind database via the
' CustOrdersDetail stored procedure with the OrderId parameter. To pass parameters
' to DataSet create a DataAdapter via Visual Studio DataSet designer.
' 
' In this
' case, DataAdapter should be filled manually within the
' XtraReportBase.DataSourceDemanded
' (ms-help://DevExpress.NETv11.1/DevExpress.XtraReports/DevExpressXtraReportsUIXtraReportBase_DataSourceDemandedtopic.htm)
' event handler. A parameter for a stored procedure is selected by end-users in
' the Parameters panel and passed to the DataAdapter via the Parameter object (See
' the XtraReports Suite Parameters Overview
' (ms-help://DevExpress.NETv11.1/DevExpress.XtraReports/CustomDocument9997.htm)).
' The default parameter's value is set on the client side using the
' ReportPreviewModel.Parameters
' (ms-help://DevExpress.NETv11.1/DevExpress.Silverlight/DevExpressXpfPrintingReportPreviewModel_Parameterstopic.htm)
' collection.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3428

Imports System
Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports DevExpress.Xpf.Printing.Service
Imports DevExpress.XtraReports.Service
Imports DevExpress.XtraReports.UI
Imports DevExpress.Data.Utils.ServiceModel

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
