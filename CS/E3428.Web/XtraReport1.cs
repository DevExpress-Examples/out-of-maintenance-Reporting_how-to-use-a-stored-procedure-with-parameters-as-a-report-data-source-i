using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace E3428.Web {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void XtraReport1_DataSourceDemanded(object sender, EventArgs e) {
            custOrdersDetailTableAdapter.Fill((this.DataSource as NwindDataSet).CustOrdersDetail, Convert.ToInt32(Parameters["OrderId"].Value));
        }

    }
}
