using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptBangKeThanhToanTienCoVanHocTap_CTIM : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangKeThanhToanTienCoVanHocTap_CTIM()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong, string bacdaotao, string namhoc, string hocky, string khoahoc, string hieutruong, string phongtaivu, string phongCTHSSV, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTenTruong.Value = tentruong.ToUpper();
            pBacDaoTao.Value = bacdaotao.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky.ToUpper();
            pKhoaHoc.Value = khoahoc.ToUpper();
            pHieuTruong.Value = hieutruong;
            pNguoiLapBieu.Value = nguoilapbieu;
            lblNgayIn.Text = "Ngày " + ngayin.ToString("dd") + " tháng " + ngayin.ToString("MM") + " năm " + ngayin.ToString("yyyy");
            bindingSourceThongKe.DataSource = tb;

            if (bacdaotao.ToLower().Contains("trung cấp"))
            {
                lblBacDaoTao.Text = "BAN GIÁO DỤC CHUYÊN NGHIỆP";
                xrLabel11.Text = "Ban Giáo dục chuyên nghiệp";
            }
            else
            {
                lblBacDaoTao.Text = "";
                xrLabel11.Visible = false;
                xrLabel12.Visible = false;
                xrLabel13.LocationF = new PointF(xrLabel13.LocationF.X + 120, xrLabel13.LocationF.Y);
                xrLabel14.LocationF = new PointF(xrLabel14.LocationF.X + 120, xrLabel14.LocationF.Y);
                xrLabel15.LocationF = new PointF(xrLabel15.LocationF.X + 120, xrLabel15.LocationF.Y);
                xrLabel16.LocationF = new PointF(xrLabel16.LocationF.X + 120, xrLabel16.LocationF.Y);
                xrLabel20.LocationF = new PointF(xrLabel20.LocationF.X + 120, xrLabel20.LocationF.Y);
                xrLabel21.LocationF = new PointF(xrLabel21.LocationF.X + 120, xrLabel21.LocationF.Y);
            }
        }

        private void xrTableCell31_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            lblThanhTienBangChu.Text = String.Format("Thành tiền bằng chữ: {0}.", PMS.Common.Globals.DocTien(decimal.Parse(e.Value.ToString())));
        }

        private void xrTableCell23_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((XRTableCell)sender).Text = PMS.Common.Globals.ReplaceDot(((XRTableCell)sender).Text);
        }

        private void xrTableCell31_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            ((XRTableCell)sender).Text = PMS.Common.Globals.ReplaceDot(((XRTableCell)sender).Text);
        }



    }
}
