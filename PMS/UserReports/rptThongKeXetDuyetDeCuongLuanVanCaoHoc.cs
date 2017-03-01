using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeXetDuyetDeCuongLuanVanCaoHoc : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeXetDuyetDeCuongLuanVanCaoHoc()
        {
            InitializeComponent();
        }
        public void InitData(string truong, string namhoc, string hocky, string hieutruong, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pHieuTruong.Value = hieutruong;
            pNguoiLapBieu.Value = nguoilapbieu;
            lblNgayIn.Text = "TP.Hồ Chí Minh, ngày " + ngayin.ToString("dd") + " tháng " + ngayin.ToString("MM") + " năm " + ngayin.ToString("yyyy");
            bindingSourceThongKe.DataSource = tb;
        }
    }
}
