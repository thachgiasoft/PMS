using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThanhToanGiangDayLyThuyetCanBoKiemGiangHddhCTIM : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;
        public rptThanhToanGiangDayLyThuyetCanBoKiemGiangHddhCTIM()
        {
            InitializeComponent();
        }
        public void InitData(string truong, string namhoc, string hocky, string khoabomon, string phongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, string chucvubangiamhieu, string chucvuketoan, string chucvudaotao, DateTime ngayin, DataTable tb)
        { 
            pTruong.Value = truong.ToUpper();
            lblNamHocHocKy.Text = (String.Format("{0}, Năm học {1}", hocky, namhoc)).ToUpper();
            lblKhoa_He.Text = (String.Format("{0} - HỆ: {1}", khoahoc, bacdaotao)).ToUpper();
            if (khoabomon.Contains(";"))
            {
                lblKhoaBanBoMon.Text = "";
                xrLabel11.Visible = false;
                xrLabel12.Visible = false;
            }
            else
            {
                lblKhoaBanBoMon.Text = khoabomon.ToUpper();
                GroupHeader1.Visible = false;
                GroupFooter1.Visible = false;
                xrLabel11.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(khoabomon.ToLower());
            }

            //Nếu bậc trung cấp thì ẩn phòng đào tạo ký
            if (bacdaotao.ToLower() == "trung cấp")
            {
                xrLabel13.Visible = false;
                xrLabel14.Visible = false;
                xrLabel20.Visible = false;
            }

            pPhongDaoTao.Value = phongdaotao;
            pPhongKeToan.Value = phongketoan;
            pHieuTruong.Value = hieutruong;
            pNguoiLapBieu.Value = nguoilapbieu;
            lblNgayIn.Text = "Ngày " + ngayin.ToString("dd") + " tháng " + ngayin.ToString("MM") + " năm " + ngayin.ToString("yyyy");
            pChucVuBanGiamHieu.Value = chucvubangiamhieu;
            pChucVuKeToan.Value = chucvuketoan;
            pChucVuDaoTao.Value = chucvudaotao;

            bindingSourceThongKe.DataSource = tb;

            if (bacdaotao.ToLower().Contains("trung cấp"))
            {
                lblKhoaBanBoMon.Text = "BAN GIÁO DỤC CHUYÊN NGHIỆP";
                xrLabel13.Visible = false;
                xrLabel14.Visible = false;
                xrLabel20.Visible = false;
                xrLabel11.Text = "Ban Giáo dục chuyên nghiệp";

                xrLabel12.LocationF = new PointF(xrLabel12.LocationF.X - 115, xrLabel12.LocationF.Y);
                xrLabel11.LocationF = new PointF(xrLabel11.LocationF.X - 115, xrLabel11.LocationF.Y);
                xrLabel11.Visible = true;
                xrLabel12.Visible = true;
            }
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            xrTableCellSttKhoa.Text = PMS.Common.Globals.Roman(_sttKhoa, true);
        }

        private void xrTableCell46_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            try
            {
                lblThanhTienBangChu.Text = "Thành tiền (bằng chữ): " + PMS.Common.Globals.DocTien(decimal.Parse(e.Value.ToString())) + ".";
            }
            catch
            { }
        }

        private void xrTableCell33_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((XRTableCell)sender).Text = PMS.Common.Globals.ReplaceDot(((XRTableCell)sender).Text);
        }

        private void xrTableCell57_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            ((XRTableCell)sender).Text = PMS.Common.Globals.ReplaceDot(((XRTableCell)sender).Text);
        }

    }
}
