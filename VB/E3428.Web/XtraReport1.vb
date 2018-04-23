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
