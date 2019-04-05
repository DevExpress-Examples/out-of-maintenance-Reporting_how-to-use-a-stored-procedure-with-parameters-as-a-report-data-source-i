<!-- default file list -->
*Files to look at*:

* [XtraReport1.cs](./CS/E3428.Web/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/E3428.Web/XtraReport1.vb))
* [MainPage.xaml](./CS/E3428/MainPage.xaml) (VB: [MainPage.xaml](./VB/E3428/MainPage.xaml))
* [MainPage.xaml.cs](./CS/E3428/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/E3428/MainPage.xaml.vb))
<!-- default file list end -->
# How to use a stored procedure with parameters as a report data source in Silverlight


<p><strong>This approach is actual prior to version 14.1. Starting with version 14.1, use the approach illustrated in the <a href="https://www.devexpress.com/Support/Center/p/T227424">How to bind a report to a stored procedure provided by the SQL Data Source in a Silverlight application</a></strong><strong> example.</strong><br /><br />In this example, the report is bound to the Northwind database via the <strong>CustOrdersDetail</strong> stored procedure with the OrderId parameter. To pass parameters to DataSet create a DataAdapter via Visual Studio DataSet designer.</p>
<p>In this case, DataAdapter should be filled manually within the <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReportBase_DataSourceDemandedtopic"><u>XtraReportBase.DataSourceDemanded</u></a> event handler. A parameter for a stored procedure is selected by end-users in the Parameters panel and passed to the DataAdapter via the Parameter object (see <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument9997">Parameters Overview</a>). The default parameter's value is set on the client side using the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfPrintingReportPreviewModel_Parameterstopic"><u>ReportPreviewModel.Parameters</u></a> collection.</p>

<br/>


