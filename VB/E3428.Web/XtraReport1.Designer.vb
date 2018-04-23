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
Namespace E3428.Web
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.nwindDataSet1 = New NwindDataSet()
            Me.custOrdersDetailTableAdapter = New NwindDataSetTableAdapters.CustOrdersDetailTableAdapter()
			Me.xrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrControlStyle2 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.OrderId = New DevExpress.XtraReports.Parameters.Parameter()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.Detail.EvenStyleName = "xrControlStyle1"
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			Me.Detail.OddStyleName = "xrControlStyle2"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTable1
			' 
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 25F)
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 1R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustOrdersDetail.ProductName")})
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.StylePriority.UseBorders = False
			Me.xrTableCell1.Text = "xrTableCell1"
			Me.xrTableCell1.Weight = 1R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustOrdersDetail.Quantity")})
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.StylePriority.UseBorders = False
			Me.xrTableCell2.Text = "xrTableCell2"
			Me.xrTableCell2.Weight = 1R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustOrdersDetail.UnitPrice")})
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.StylePriority.UseBorders = False
			Me.xrTableCell3.Text = "xrTableCell3"
			Me.xrTableCell3.Weight = 1R
			' 
			' TopMargin
			' 
			Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTable2
			' 
			Me.xrTable2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(0))))))
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 75F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(649.9999F, 25F)
			Me.xrTable2.StylePriority.UseBackColor = False
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Weight = 1R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(0))))))
			Me.xrTableCell4.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.StylePriority.UseBackColor = False
			Me.xrTableCell4.StylePriority.UseBorders = False
			Me.xrTableCell4.Text = "Product Name"
			Me.xrTableCell4.Weight = 1R
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(0))))))
			Me.xrTableCell5.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.StylePriority.UseBackColor = False
			Me.xrTableCell5.StylePriority.UseBorders = False
			Me.xrTableCell5.Text = "Quantity"
			Me.xrTableCell5.Weight = 1R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(0))))))
			Me.xrTableCell6.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.StylePriority.UseBackColor = False
			Me.xrTableCell6.StylePriority.UseBorders = False
			Me.xrTableCell6.Text = "Unit Price"
			Me.xrTableCell6.Weight = 1R
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "NwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' custOrdersDetailTableAdapter
			' 
			Me.custOrdersDetailTableAdapter.ClearBeforeFill = True
			' 
			' xrControlStyle1
			' 
			Me.xrControlStyle1.BackColor = System.Drawing.Color.PapayaWhip
			Me.xrControlStyle1.Name = "xrControlStyle1"
			' 
			' xrControlStyle2
			' 
			Me.xrControlStyle2.BackColor = System.Drawing.Color.PaleGoldenrod
			Me.xrControlStyle2.Name = "xrControlStyle2"
			' 
			' OrderId
			' 
			Me.OrderId.Name = "OrderId"
			Me.OrderId.Type = GetType(Integer)
			Me.OrderId.Value = 0
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
			Me.DataMember = "CustOrdersDetail"
			Me.DataSource = Me.nwindDataSet1
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.OrderId})
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.xrControlStyle1, Me.xrControlStyle2})
			Me.Version = "11.1"
'			Me.DataSourceDemanded += New System.EventHandler(Of System.EventArgs)(Me.XtraReport1_DataSourceDemanded);
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private nwindDataSet1 As NwindDataSet
		Private custOrdersDetailTableAdapter As NwindDataSetTableAdapters.CustOrdersDetailTableAdapter
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
		Private xrControlStyle2 As DevExpress.XtraReports.UI.XRControlStyle
		Private OrderId As DevExpress.XtraReports.Parameters.Parameter
	End Class
End Namespace
