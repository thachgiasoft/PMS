using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptTongHopThanhToanVuotGioGVCH : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTongHopThanhToanVuotGioGVCH()
        {
            InitializeComponent();
        }

        public void InitData(string donvilap, string namhoc, string bacdaotao, string khoadonvi, string hieutruong, string ketoan, string daotao, string nguoilap, string chucvubangiamhieu, string chucvuketoan, string chucvudaotao, DateTime ngayin, DataTable tb)
        {
            pDonViLap.Value = donvilap.ToUpper();
            pNamHoc.Value = namhoc;
            pKhoaDonVi.Value = khoadonvi.ToUpper();
            pHieuTruong.Value = hieutruong;
            pPhongKeToan.Value = ketoan;
            pPhongDaoTao.Value = daotao;
            pNguoiLapBieu.Value = nguoilap;
            pBacDaoTao.Value = bacdaotao.ToUpper();
            pChucVuBanGiamHieu.Value = chucvubangiamhieu;
            pChucVuKeToan.Value = chucvuketoan;
            pChucVuDaoTao.Value = chucvudaotao;
            lblNgayIn.Text = "Ngày " + ngayin.ToString("dd") + " tháng " + ngayin.ToString("MM") + " năm " + ngayin.ToString("yyyy");
            bindingSourceThongKe.DataSource = tb;
        }

        private void xrTableCell26_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            lblTienChu.Text = "Thành tiền bằng chữ: " + PMS.Common.Globals.DocTien(decimal.Parse(e.Value.ToString())) + ".";
        }

        private void xrTableCell15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((XRTableCell)sender).Text = PMS.Common.Globals.ReplaceDot(((XRTableCell)sender).Text);
        }

        private void xrTableCell26_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            ((XRTableCell)sender).Text = PMS.Common.Globals.ReplaceDot(((XRTableCell)sender).Text);
        }
    }
}
