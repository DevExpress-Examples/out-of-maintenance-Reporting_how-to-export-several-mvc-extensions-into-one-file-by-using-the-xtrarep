<!-- default file list -->
*Files to look at*:

* **[HomeController.cs](./CS/T167275/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/T167275/Controllers/HomeController.vb))**
* [Product.cs](./CS/T167275/Models/Product.cs) (VB: [Product.vb](./VB/T167275/Models/Product.vb))
* [SampleReport.cs](./CS/T167275/Reports/SampleReport.cs) (VB: [SampleReport.vb](./VB/T167275/Reports/SampleReport.vb))
* [_GridViewPartial.cshtml](./CS/T167275/Views/Home/_GridViewPartial.cshtml)
* [_PivotGrid1Partial.cshtml](./CS/T167275/Views/Home/_PivotGrid1Partial.cshtml)
* [Index.cshtml](./CS/T167275/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to export several MVC extensions into one file by using the XtraReports Suite
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t167275/)**
<!-- run online end -->


<p>This example demonstrates how to export several MVC extensions that support the export of IPrintable documents (<a href="https://docs.devexpress.com/AspNet/5823/components/grid-view">GridView</a>, <a href="https://docs.devexpress.com/AspNet/5830/components/pivot-grid">PivotGrid</a>, <a href="https://docs.devexpress.com/AspNet/7928/components/tree-list">TreeList</a>) into one file by using the XtraReports Suite functionality.</p>
<p><br />To accomplish this task, use the <a href="http://docs.devexpress.devx/XtraReports/DevExpress.XtraReports.UI.PrintableComponentContainer">PrintableComponentContainer</a> control in your report to insert MVC extensions: at runtime use the extension's <a href="https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.GridViewExtension.CreatePrintableObject(DevExpress.Web.Mvc.GridViewSettings-System.Object)">CreatePrintableObject</a> method to get the IPrintable object in the controller's export action and assign it to the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.PrintableComponentContainer.PrintableComponent">PrintableComponentContainer.PrintableComponent</a> property.</p>
<br /><strong>See also:<br /></strong><a href="https://docs.devexpress.com/XtraReports/2608/detailed-guide-to-devexpress-reporting/use-report-controls/use-third-party-controls">Use Third-Party Controls in XtraReports > Print DevExpress Controls</a> <strong><br /></strong>

<br/>


