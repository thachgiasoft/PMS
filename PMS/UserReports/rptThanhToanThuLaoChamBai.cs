using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThanhToanThuLaoChamBai : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThanhToanThuLaoChamBai()
        {
            InitializeComponent();
        }
        public void InitData(string truong, string matruong, string namhoc, string hocky, string loaigiangvien, string hieutruong, string phongkhtc, string phongkhaothi, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            if (matruong == "UEL")
                pTenTruong.Value = truong.ToUpper() + " DHQG.HCM";
            else pTenTruong.Value = truong.ToUpper();
            if (loaigiangvien == "11")
                lblTieuDe.Text = "BẢNG KÊ THANH TOÁN THÙ LAO CHẤM BÀI CHO GIẢNG VIÊN THỈNH GIẢNG";
            else
                lblTieuDe.Text = "BẢNG KÊ THANH TOÁN THÙ LAO CHẤM BÀI CHO GIẢNG VIÊN ĐH KINH TẾ - LUẬT";
            lblNamHocHocKy.Text = "NĂM HỌC " + namhoc + " - " + hocky;
            pHieuTruong.Value = hieutruong;
            pTruongPhongKHTC.Value = phongkhtc;
            pTruongPhongKhaoThi.Value = phongkhaothi;
            pNguoiLapBieu.Value = nguoilapbieu;
            lblNgayIn.Text = "TP.HCM, ngày " + ngayin.ToString("dd") + " tháng " + ngayin.ToString("MM") + " năm " + ngayin.ToString("yyyy");
            bindingSourceThongKe.DataSource = tb;
        }

    }
}
