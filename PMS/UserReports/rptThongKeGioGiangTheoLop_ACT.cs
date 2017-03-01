using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeGioGiangTheoLop_ACT : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeGioGiangTheoLop_ACT()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTruong.Value = tentruong.ToUpper();
            pNguoiLapBieu.Value = nguoilapbieu;
            lblNgayIn.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
            bindingSource1.DataSource = tb;
        }
    }
}
