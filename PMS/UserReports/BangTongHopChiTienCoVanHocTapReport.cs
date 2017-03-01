using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;

namespace PMS.UserReports
{
    public partial class BangTongHopChiTienCoVanHocTapReport : DevExpress.XtraReports.UI.XtraReport
    {
        public BangTongHopChiTienCoVanHocTapReport()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string keToan, string namHocHocKy, string maTruong, VList<ViewTongHopChiTienCoVan> vList)
        {
            pTruong.Value = truong;
            pKeToan.Value = keToan;
            pNamHocHocKy.Value = namHocHocKy;
            bindingSourceTongHopChiTienCoVan.DataSource = vList;

            if (maTruong == "CTIM")
            {
                xrLabel7.Text = "";
                xrLabel6.Text = "KẾ TOÁN TRƯỞNG";
            }
        }

        string ReplaceDot(string s)
        {
            if (s.Contains(",") == true)
            {
                s = s.Replace(",", ".");
            }
            return s;
        }

        private void xrTableCell9_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((XRTableCell)sender).Text = ReplaceDot(((XRTableCell)sender).Text);
        }

        private void xrTableCell14_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            ((XRTableCell)sender).Text = ReplaceDot(((XRTableCell)sender).Text);
        }
    }
}
