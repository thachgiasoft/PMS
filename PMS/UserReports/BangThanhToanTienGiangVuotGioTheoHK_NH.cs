using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.Reports
{
    public partial class BangThanhToanTienGiangVuotGioTheoHK_NH : DevExpress.XtraReports.UI.XtraReport
    {
        public BangThanhToanTienGiangVuotGioTheoHK_NH()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string hieuTruong, string namhoc, string hocky, string dot, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTruong.Value = truong.ToUpper();
            pHieuTruong.Value = hieuTruong;
            pNamHocHocKy.Value = hocky + " NĂM HỌC " + namhoc;
            pNguoiLapBieu.Value = nguoilapbieu;
            pNgayIn.Value = string.Format("Tp.Hồ Chí Minh, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", ngayin);
            pDotThanhToan.Value = dot.ToUpper();
            DataSource = tb;
        }
    }
}
