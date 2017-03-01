using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class BangThanhToanVuotGioChuanCuaGVCH : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;
        public BangThanhToanVuotGioChuanCuaGVCH()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string namHoc, string nguoiLapBieu, string banGiamHieu, string keToan, DateTime ngayIn, DataTable tb)
        {
            Truong.Value = truong.ToUpper();
            NamHoc.Value = namHoc;
            pNguoiLapBieu.Value = nguoiLapBieu;
            pBanGiamHieu.Value = banGiamHieu;
            pPhongKHTC.Value = keToan;
            pNgayIn.Value = string.Format("TP.HCM, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", ngayIn);
            DataSource = tb;
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            xrTableCell94.Text = PMS.Common.Globals.Roman(_sttKhoa, true);
        }
    }
}
