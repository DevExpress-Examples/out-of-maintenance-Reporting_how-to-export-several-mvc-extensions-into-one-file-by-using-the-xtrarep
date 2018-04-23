@Code
    ViewBag.Title = "Home Page"
End Code
@Using Html.BeginForm("Export", "Home")
    @Html.DevExpress().Button(Sub(settings)
                                  settings.Name = "btExport"
                                  settings.Text = "Export to PDF"
                                  settings.UseSubmitBehavior = True
                              End Sub
).GetHtml()

    
    @<h3>
        Products Grid</h3>      
    @Html.Action("GridViewPartial")

    
    @<h3>
        Pivot Grid</h3>
    @Html.Action("PivotGrid1Partial")
End Using
    