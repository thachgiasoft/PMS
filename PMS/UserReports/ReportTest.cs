using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PMS.UserReports
{
    public partial class ReportTest : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportTest()
        {
            InitializeComponent();
        }
        public void InitData()
        {
            XRTable table1 = new XRTable();
            table1.Width = 196;
            XRTableRow row1 = new XRTableRow();
            row1.WidthF = 50;
            table1.Rows.Add(row1);

            table1.Rows.Clear();
            int[] nCellWidths = new int[] { 50, 50, 50,50 };
            for (int i = 0; i < 4; i++)
            {
                XRTableCell cell = new XRTableCell();
                cell.Width = nCellWidths[i];
                cell.Borders = DevExpress.XtraPrinting.BorderSide.All;
                row1.Cells.Add(cell);
            }
            table1.Rows.Add(row1);

            this.Detail.Controls.Add(table1);
        }

    }
}
