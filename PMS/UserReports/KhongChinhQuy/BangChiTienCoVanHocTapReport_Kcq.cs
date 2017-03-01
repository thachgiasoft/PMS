using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;
using System.Data;

namespace PMS.UserReports.KhongChinhQuy
{
    public partial class BangChiTienCoVanHocTapReport_Kcq : DevExpress.XtraReports.UI.XtraReport
    {
        public BangChiTienCoVanHocTapReport_Kcq()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string phongKHTC, string nguoilapbang,string tPDaoTao,string tuade, DataTable vList)
        {
            pTruong.Value = truong;
            pPhongKHTC.Value = phongKHTC;
            pNguoiLapBang.Value = nguoilapbang;
            pDaoTao.Value = tPDaoTao;
            pTuaDe.Value = tuade;
            bindingSourceBangChiTienCoVan.DataSource = vList;
        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                //string a = txtTongTien.Summary.GetResult().ToString();
                decimal tien = Convert.ToDecimal(txtTongTien.Summary.GetResult().ToString());
                string tiengbangchu = PMS.Common.Globals.DocTien(tien);
                pTienBangChu.Value = tiengbangchu;
            }
            catch
            {
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

        private void xrTableCell14_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((XRTableCell)sender).Text = ReplaceDot(((XRTableCell)sender).Text);
        }

        private void txtTongTien_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            ((XRTableCell)sender).Text = ReplaceDot(((XRTableCell)sender).Text);
        }
    }
}
