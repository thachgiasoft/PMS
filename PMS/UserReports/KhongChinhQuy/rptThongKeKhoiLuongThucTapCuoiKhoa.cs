using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PMS.UserReports.KhongChinhQuy
{
    public partial class rptThongKeKhoiLuongThucTapCuoiKhoa : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeKhoiLuongThucTapCuoiKhoa()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string namHoc, string hocKy, string nguoiLapBieu, DateTime ngayIn, System.Data.DataTable tb)
        {
            pTruong.Value = truong.ToUpper();
            pNamHocHocKy.Value = "Năm học " + namHoc + "  "+ hocKy;
            pNguoiLapBieu.Value = nguoiLapBieu;
            pNgayIn.Value = string.Format("Tp. Hồ Chí Minh, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", ngayIn);
            DataSource = tb;
        }
    }
}
