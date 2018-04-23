// Developer Express Code Central Example:
// How to use a stored procedure with parameters as a report data source in Silverlight
// 
// In this example, the report is bound to the Northwind database via the
// CustOrdersDetail stored procedure with the OrderId parameter. To pass parameters
// to DataSet create a DataAdapter via Visual Studio DataSet designer.
// 
// In this
// case, DataAdapter should be filled manually within the
// XtraReportBase.DataSourceDemanded
// (ms-help://DevExpress.NETv11.1/DevExpress.XtraReports/DevExpressXtraReportsUIXtraReportBase_DataSourceDemandedtopic.htm)
// event handler. A parameter for a stored procedure is selected by end-users in
// the Parameters panel and passed to the DataAdapter via the Parameter object (See
// the XtraReports Suite Parameters Overview
// (ms-help://DevExpress.NETv11.1/DevExpress.XtraReports/CustomDocument9997.htm)).
// The default parameter's value is set on the client side using the
// ReportPreviewModel.Parameters
// (ms-help://DevExpress.NETv11.1/DevExpress.Silverlight/DevExpressXpfPrintingReportPreviewModel_Parameterstopic.htm)
// collection.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3428

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("E3428")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyProduct("E3428")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2011")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("776efaca-9236-45e4-9a2a-c02a40737405")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
