using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports.ReportThanhTra
{
    public partial class ThongKeCongViecKhongPhuHopCuaGV : DevExpress.XtraReports.UI.XtraReport
    {
        public ThongKeCongViecKhongPhuHopCuaGV()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string tuNgay, string denNgay, DateTime ngayIn, string nguoiLapBieu, DataTable tb)
        {
            pTruong.Value = truong.ToUpper();
            pNgay.Value = string.Format("Từ ngày {0} đến ngày {1}", tuNgay, denNgay);
            pNguoiLapBieu.Value = nguoiLapBieu;
            pNgayIn.Value = string.Format("TP. HCM ngày {0:dd} tháng {0:MM} năm {0:yyyy}", ngayIn);
            DataSource = tb;
        }
    }
}
