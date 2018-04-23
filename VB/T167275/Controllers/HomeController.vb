Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraReports.UI
Imports T167275.Reports
Imports DevExpress.XtraPrinting
Imports System.IO

Namespace T167275.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function

		<ValidateInput(False)>
		Public Function GridViewPartial() As ActionResult
			Dim model = Product.GetProducts()
			Return PartialView("_GridViewPartial", model)
		End Function

		<ValidateInput(False)>
		Public Function PivotGrid1Partial() As ActionResult
			Dim model = Product.GetProducts()
			Return PartialView("_PivotGrid1Partial", model)
		End Function

		Public Function Export() As ActionResult
			Dim model = Product.GetProducts()
			Dim gridViewPrintable As IPrintable = GridViewExtension.CreatePrintableObject(ViewsHelper.CreateGridViewSettings(), model)
			Dim pivotGridPrintable As IPrintable = PivotGridExtension.CreatePrintableObject(ViewsHelper.CreatePivotGridSettings(), model)

			Dim report As XtraReport = New SampleReport(gridViewPrintable, pivotGridPrintable)

			Dim stream As New MemoryStream()
			report.ExportToPdf(stream)

			Return File(stream.ToArray(), "application/pdf")
		End Function

		Public NotInheritable Class ViewsHelper

			Private Sub New()
			End Sub

			Public Shared Function CreateGridViewSettings() As GridViewSettings
				Dim settings As New GridViewSettings()
				settings.Name = "GridView"
				settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "GridViewPartial"}

				settings.KeyFieldName = "ProductID"

				settings.Columns.Add("ProductID")
				settings.Columns.Add("ProductName")
				settings.Columns.Add("CategoryID")
				settings.Columns.Add("SupplierID")
				settings.Columns.Add("UnitPrice")
				settings.Columns.Add("UnitsInStock")
				settings.Columns.Add("UnitsOnOrder")

				Return settings
			End Function

			Public Shared Function CreatePivotGridSettings() As PivotGridSettings
				Dim settings As New PivotGridSettings()
				settings.Name = "PivotGrid1"
				settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "PivotGrid1Partial"}

				settings.Fields.Add(Sub(field)
					field.Area = PivotArea.RowArea
					field.FieldName = "SupplierID"
					field.Caption = "SupplierID"
				End Sub)
				settings.Fields.Add(Sub(field)
					field.Area = PivotArea.ColumnArea
					field.FieldName = "CategoryID"
					field.Caption = "CategoryID"
				End Sub)
				settings.Fields.Add(Sub(field)
					field.Area = PivotArea.DataArea
					field.FieldName = "UnitsInStock"
					field.Caption = "UnitsInStock"
				End Sub)
				Return settings
			End Function
		End Class
	End Class
End Namespace