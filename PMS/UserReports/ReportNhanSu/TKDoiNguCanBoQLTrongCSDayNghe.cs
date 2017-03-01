using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.Reports
{
    public partial class TKDoiNguCanBoQLTrongCSDayNghe : DevExpress.XtraReports.UI.XtraReport
    {
        public TKDoiNguCanBoQLTrongCSDayNghe()
        {
            InitializeComponent();
        }

        private void xrTableCell31_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }
        public void InitData(string tenTruong, DateTime ngayIn, string nam, DataTable tb)
        {
            //pTruong.Value = tenTruong.ToUpper();
            //pNam.Value = nam;
            //bindingSourceThongKe.DataSource = tb;
        }
    }
}
