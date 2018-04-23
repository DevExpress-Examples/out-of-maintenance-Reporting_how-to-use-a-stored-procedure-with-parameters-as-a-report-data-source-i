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

using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using DevExpress.Xpf.Printing.Service;
using DevExpress.XtraReports.Service;
using DevExpress.XtraReports.UI;
using DevExpress.Data.Utils.ServiceModel;

namespace E3428.Web {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReportService1" in code, svc and config file together.
    [SilverlightFaultBehavior]
    public class ReportService1 : DevExpress.XtraReports.Service.ReportService {
        // Un-comment this method if you need to extend the base functionality.
        // protected override XtraReport CreateReportByName(string reportName)
        // {
        //	return base.CreateReportByName(reportName);
        // }
    }
}
