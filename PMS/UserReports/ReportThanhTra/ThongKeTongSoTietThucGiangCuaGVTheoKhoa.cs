using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports.ReportThanhTra
{
    public partial class ThongKeTongSoTietThucGiangCuaGVTheoKhoa : DevExpress.XtraReports.UI.XtraReport
    {
        public ThongKeTongSoTietThucGiangCuaGVTheoKhoa()
        {
            InitializeComponent();
        }

        public void InitData(string _truong, string _namHoc, string _hocKy, string _nguoiLapBieu, DateTime _ngayIn, DataTable tb)
        {
            pTruong.Value = _truong.ToUpper();
            pHocKyNamHoc.Value = _hocKy + " (" + _namHoc + ")";
            pNgayIn.Value = String.Format("TP.HCM, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", _ngayIn);
            pNguoiLapBieu.Value = _nguoiLapBieu;
            DataSource = tb;
        }
    }
}
