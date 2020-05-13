using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;

namespace T167275.Reports {
    public partial class SampleReport : DevExpress.XtraReports.UI.XtraReport {
        public SampleReport(IBasePrintable gridViewPrintable, IBasePrintable pivotGridPrintable) {
            InitializeComponent();
            pcGridView.PrintableComponent = gridViewPrintable;
            pcPivotGrid.PrintableComponent = pivotGridPrintable;
        }

    }
}
