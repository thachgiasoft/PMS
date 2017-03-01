using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThanhToanThuLaoVuotGioGiangVienCoHuu : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThanhToanThuLaoVuotGioGiangVienCoHuu()
        {
            InitializeComponent();
        }
        public void InitData(string namhoc, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pNguoiLapBieu.Value = nguoilapbieu;
            lblNamHoc.Text = "NĂM HỌC " + namhoc;
            lblNgayIn.Text = "TP. Hồ Chí Minh, ngày " + ngayin.ToString("dd") + " tháng " + ngayin.ToString("MM") + " năm " + ngayin.ToString("yyyy");
            bindingSource1.DataSource = tb;
        }

        private void xrTableCell45_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            try
            {
                lblTienChu.Text = PMS.Common.Globals.DocTien(decimal.Parse(e.Value.ToString())) + "."; 
            }
            catch 
            {}
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblTienChu.Text = "";
        }

        private void xrTableCell22_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((XRTableCell)sender).Text = PMS.Common.Globals.ReplaceDot(((XRTableCell)sender).Text);
        }

        private void xrTableCell40_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            ((XRTableCell)sender).Text = PMS.Common.Globals.ReplaceDot(((XRTableCell)sender).Text);
        }
    }
}
