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
