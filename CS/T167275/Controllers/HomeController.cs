using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraReports.UI;
using T167275.Reports;
using DevExpress.XtraPrinting;
using System.IO;

namespace T167275.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartial() {
            var model = Product.GetProducts();
            return PartialView("_GridViewPartial", model);
        }

        [ValidateInput(false)]
        public ActionResult PivotGrid1Partial() {
            var model = Product.GetProducts();
            return PartialView("_PivotGrid1Partial", model);
        }

        public ActionResult Export() {
            var model = Product.GetProducts();
            IBasePrintable gridViewPrintable = GridViewExtension.CreatePrintableObject(ViewsHelper.CreateGridViewSettings(), model);
            IBasePrintable pivotGridPrintable = PivotGridExtension.CreatePrintableObject(ViewsHelper.CreatePivotGridSettings(), model);

            XtraReport report = new SampleReport(gridViewPrintable, pivotGridPrintable);

            MemoryStream stream = new MemoryStream();
            report.ExportToPdf(stream);

            return File(stream.ToArray(), "application/pdf");
        }

        public static class ViewsHelper {
            public static GridViewSettings CreateGridViewSettings() {
                GridViewSettings settings = new GridViewSettings();
                settings.Name = "GridView";
                settings.CallbackRouteValues = new { Controller = "Home", Action = "GridViewPartial" };

                settings.KeyFieldName = "ProductID";

                settings.Columns.Add("ProductID");
                settings.Columns.Add("ProductName");
                settings.Columns.Add("CategoryID");
                settings.Columns.Add("SupplierID");
                settings.Columns.Add("UnitPrice");
                settings.Columns.Add("UnitsInStock");
                settings.Columns.Add("UnitsOnOrder");

                return settings;
            }

            public static PivotGridSettings CreatePivotGridSettings() {
                PivotGridSettings settings = new PivotGridSettings();
                settings.Name = "PivotGrid1";
                settings.CallbackRouteValues = new { Controller = "Home", Action = "PivotGrid1Partial" };

                settings.Fields.Add(field => {
                    field.Area = PivotArea.RowArea;
                    field.FieldName = "SupplierID";
                    field.Caption = "SupplierID";
                });
                settings.Fields.Add(field => {
                    field.Area = PivotArea.ColumnArea;
                    field.FieldName = "CategoryID";
                    field.Caption = "CategoryID";
                });
                settings.Fields.Add(field => {
                    field.Area = PivotArea.DataArea;
                    field.FieldName = "UnitsInStock";
                    field.Caption = "UnitsInStock";
                });
                return settings;
            }
        }
    }
}