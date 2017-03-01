using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeNhanXetDanhGiaVuotGioGVCH : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeNhanXetDanhGiaVuotGioGVCH()
        {
            InitializeComponent();
        }

        public void InitData(string khoadonvi, string namhoc, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pKhoaDonVi.Value = khoadonvi.ToUpper();
            pNamHoc.Value = namhoc;
            pNguoiLapBang.Value = nguoilapbieu;
            lblNgayIn.Text = "TP.Hồ Chí Minh, ngày " + ngayin.ToString("dd") + " tháng " + ngayin.ToString("MM") + " năm " + ngayin.ToString("yyyy");
            bindingSourceThongKe.DataSource = tb;
        }
    }
}
