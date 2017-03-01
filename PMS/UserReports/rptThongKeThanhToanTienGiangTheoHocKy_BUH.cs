using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeThanhToanTienGiangTheoHocKy_BUH : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeThanhToanTienGiangTheoHocKy_BUH()
        {
            InitializeComponent();
        }

        public void InitData(string hieuTruong, string namhoc, string hocky, string nguoilapbieu, DateTime ngayin, DataTable tb) 
        {
            pHieuTruong.Value = hieuTruong;
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pNguoiLapBieu.Value = nguoilapbieu;
            lblNgayIn.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
            bindingSource1.DataSource = tb;
        }
    }
}
