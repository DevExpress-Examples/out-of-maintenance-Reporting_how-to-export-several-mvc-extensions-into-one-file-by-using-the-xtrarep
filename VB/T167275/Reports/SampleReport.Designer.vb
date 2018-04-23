Namespace T167275.Reports
	Partial Public Class SampleReport
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
			Me.lbText = New DevExpress.XtraReports.UI.XRLabel()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.pcGridView = New DevExpress.XtraReports.UI.PrintableComponentContainer()
			Me.xrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.pcPivotGrid = New DevExpress.XtraReports.UI.PrintableComponentContainer()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' lbText
			' 
			Me.lbText.Font = New System.Drawing.Font("Times New Roman", 48F)
			Me.lbText.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.lbText.Name = "lbText"
			Me.lbText.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbText.SizeF = New System.Drawing.SizeF(880F, 79.99999F)
			Me.lbText.StylePriority.UseFont = False
			Me.lbText.StylePriority.UseTextAlignment = False
			Me.lbText.Text = "Products Report"
			Me.lbText.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 100F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.pcPivotGrid, Me.xrLabel2, Me.xrPageBreak1, Me.pcGridView, Me.xrLabel1, Me.lbText})
			Me.Detail.HeightF = 322F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 100F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageFooter
			' 
			Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1})
			Me.PageFooter.HeightF = 23F
			Me.PageFooter.Name = "PageFooter"
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.Top
			Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(10.00004F, 0F)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(879.9999F, 23F)
			Me.xrPageInfo1.StylePriority.UseBorders = False
			Me.xrPageInfo1.StylePriority.UseTextAlignment = False
			Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00004F, 89.99999F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(880F, 36F)
			Me.xrLabel1.StylePriority.UseBorders = False
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UseTextAlignment = False
			Me.xrLabel1.Text = "Products Grid"
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
			' 
			' pcGridView
			' 
			Me.pcGridView.LocationFloat = New DevExpress.Utils.PointFloat(10.00004F, 130F)
			Me.pcGridView.Name = "pcGridView"
			Me.pcGridView.SizeF = New System.Drawing.SizeF(879.9999F, 75F)
			' 
			' xrPageBreak1
			' 
			Me.xrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 205F)
			Me.xrPageBreak1.Name = "xrPageBreak1"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00004F, 207F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(880F, 36F)
			Me.xrLabel2.StylePriority.UseBorders = False
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.StylePriority.UseTextAlignment = False
			Me.xrLabel2.Text = "Pivot Grid"
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
			' 
			' pcPivotGrid
			' 
			Me.pcPivotGrid.LocationFloat = New DevExpress.Utils.PointFloat(10.00007F, 247F)
			Me.pcPivotGrid.Name = "pcPivotGrid"
			Me.pcPivotGrid.SizeF = New System.Drawing.SizeF(879.9999F, 75F)
			' 
			' SampleReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter})
			Me.Landscape = True
			Me.PageHeight = 850
			Me.PageWidth = 1100
			Me.Version = "14.1"
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private lbText As DevExpress.XtraReports.UI.XRLabel
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private pcPivotGrid As DevExpress.XtraReports.UI.PrintableComponentContainer
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
		Private pcGridView As DevExpress.XtraReports.UI.PrintableComponentContainer
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

	End Class
End Namespace
