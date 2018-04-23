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
using DevExpress.Xpf.Printing;

namespace E3428 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            InitializeReport();
        }

        void InitializeReport() {
            ReportPreviewModel model = new ReportPreviewModel("../ReportService1.svc");
            model.ReportName = "E3428.Web.XtraReport1";
            documentPreview1.Model = model;
            
            // set Default Parameter value on the client-side
            model.Parameters["OrderId"].Value = 10248;

            model.CreateDocument();
        }
    }
}
