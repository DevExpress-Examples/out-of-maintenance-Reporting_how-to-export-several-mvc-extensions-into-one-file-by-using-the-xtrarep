# How to export several MVC extensions into one file by using the XtraReports Suite


<p>This example demonstrates how to export several MVC extensions that support the export of IPrintable documents (<a href="https://documentation.devexpress.com/AspNet/CustomDocument8998.aspx">GridView</a>, <a href="https://documentation.devexpress.com/AspNet/CustomDocument10690.aspx">PivotGrid</a>, <a href="https://documentation.devexpress.com/AspNet/CustomDocument13766.aspx">TreeList</a>) into one file by using the XtraReports Suite functionality.</p>
<p><br />To accomplish this task, use the <a href="https://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIPrintableComponentContainertopic">PrintableComponentContainer</a> control in your report to insert MVC extensions: at runtime use the extension's <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebMvcGridViewExtension_CreatePrintableObjecttopic">CreatePrintableObject</a> method to get the IPrintable object in the controller's export action and assign it to the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIPrintableComponentContainer_PrintableComponenttopic">PrintableComponentContainer.PrintableComponent</a> property.</p>
<br /><strong>See also:<br /></strong><a href="https://documentation.devexpress.com/#XtraReports/CustomDocument2608/DevExpressControls">Use Third-Party Controls in XtraReports > Print DevExpress Controls</a> <strong><br /></strong>

<br/>


