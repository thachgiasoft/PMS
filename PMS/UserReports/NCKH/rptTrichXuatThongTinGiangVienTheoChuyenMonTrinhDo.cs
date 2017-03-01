using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports.NCKH
{
    public partial class rptTrichXuatThongTinGiangVienTheoChuyenMonTrinhDo : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTrichXuatThongTinGiangVienTheoChuyenMonTrinhDo()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong, string namhoc, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTenTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namhoc;
            pNguoiLapBieu.Value = nguoilapbieu;
            bindingSourceThanhToan.DataSource = tb;
            xrLabelNgayThangNam.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
        }

    }
}
