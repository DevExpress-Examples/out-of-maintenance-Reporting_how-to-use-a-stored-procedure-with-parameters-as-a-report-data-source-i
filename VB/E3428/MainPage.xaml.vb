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

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Printing

Namespace E3428
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			InitializeReport()
		End Sub

		Private Sub InitializeReport()
			Dim model As New ReportPreviewModel("../ReportService1.svc")
			model.ReportName = "E3428.Web.XtraReport1"
			documentPreview1.Model = model

			' set Default Parameter value on the client-side
			model.Parameters("OrderId").Value = 10248

			model.CreateDocument()
		End Sub
	End Class
End Namespace
