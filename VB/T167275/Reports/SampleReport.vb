Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting

Namespace T167275.Reports
	Partial Public Class SampleReport
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New(ByVal gridViewPrintable As IPrintable, ByVal pivotGridPrintable As IPrintable)
			InitializeComponent()
			pcGridView.PrintableComponent = gridViewPrintable
			pcPivotGrid.PrintableComponent = pivotGridPrintable
		End Sub

	End Class
End Namespace
