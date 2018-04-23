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
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace E3428 {
    public partial class App : Application {

        public App() {
            this.Startup += this.Application_Startup;
            this.Exit += this.Application_Exit;
            this.UnhandledException += this.Application_UnhandledException;

            InitializeComponent();
        }

        private void Application_Startup(object sender, StartupEventArgs e) {
            this.RootVisual = new MainPage();
        }

        private void Application_Exit(object sender, EventArgs e) {

        }

        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e) {
            // If the app is running outside of the debugger then report the exception using
            // the browser's exception mechanism. On IE this will display it a yellow alert 
            // icon in the status bar and Firefox will display a script error.
            if (!System.Diagnostics.Debugger.IsAttached) {

                // NOTE: This will allow the application to continue running after an exception has been thrown
                // but not handled. 
                // For production applications this error handling should be replaced with something that will 
                // report the error to the website and stop the application.
                e.Handled = true;
                Deployment.Current.Dispatcher.BeginInvoke(delegate { ReportErrorToDOM(e); });
            }
        }

        private void ReportErrorToDOM(ApplicationUnhandledExceptionEventArgs e) {
            try {
                string errorMsg = e.ExceptionObject.Message + e.ExceptionObject.StackTrace;
                errorMsg = errorMsg.Replace('"', '\'').Replace("\r\n", @"\n");

                System.Windows.Browser.HtmlPage.Window.Eval("throw new Error(\"Unhandled Error in Silverlight Application " + errorMsg + "\");");
            } catch (Exception) {
            }
        }
    }
}
