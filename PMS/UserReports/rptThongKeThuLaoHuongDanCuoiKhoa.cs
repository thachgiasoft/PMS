using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeThuLaoHuongDanCuoiKhoa : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeThuLaoHuongDanCuoiKhoa()
        {
            InitializeComponent();
        }

        public void InitData(string matruong, string tentruong, string namHoc, string hocKy, string loaiGiangVien, string hieuTruong, string nguoiLapBieu, DateTime ngayIn, DataTable tb)
        {
            pTenTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namHoc;
            pHocKy.Value = hocKy;
            if (loaiGiangVien == "11")
                lblTieuDe.Text = "DANH SÁCH GIẢNG VIÊN THỈNH GIẢNG";
            else
                lblTieuDe.Text = "DANH SÁCH GIẢNG VIÊN TRƯỜNG ĐẠI HỌC KINH TẾ - LUẬT";
            pHieuTruong.Value = hieuTruong;
            pNguoiLapBieu.Value = nguoiLapBieu;
            lblNgayIn.Text = "TP. Hồ Chí Minh, ngày " + ngayIn.ToString("dd") + " tháng " + ngayIn.ToString("MM") + " năm " + ngayIn.ToString("yyyy");
            bindingSourceThongKe.DataSource = tb;

            if (matruong == "UEL")
                xrLabel1.Text = "ĐẠI HỌC QUỐC GIA TP.HCM";

            if (matruong == "IUH")
                xrLabel1.Text = "BỘ CÔNG THƯƠNG";

        }

        private void xrTableCell45_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            decimal tongTien = decimal.Parse(e.Value.ToString());
            lblTienBangSoVaChu.Text = "Bằng số: " + tongTien.ToString("n0") + " đồng.\t\t " + " Bằng chữ: " + PMS.Common.Globals.DocTien(tongTien) + ".";
        }
    }
}
