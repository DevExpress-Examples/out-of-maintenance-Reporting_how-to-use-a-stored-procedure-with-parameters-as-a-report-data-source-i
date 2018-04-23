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
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace E3428.Web
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub XtraReport1_DataSourceDemanded(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataSourceDemanded
			custOrdersDetailTableAdapter.Fill((TryCast(Me.DataSource, NwindDataSet)).CustOrdersDetail, Convert.ToInt32(Parameters("OrderId").Value))
		End Sub

	End Class
End Namespace
