using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptTongHopThuLaoIUH : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTongHopThuLaoIUH()
        {
            InitializeComponent();
        }

        public void InitData(string tenTruong, string namhoc, string hocky, string nguoiLapBieu, DateTime ngayIn, DataTable tbl)
        {
            pTruong.Value = tenTruong.ToUpper();
            pNamHoc.Value = namhoc.ToUpper();
            pHocKy.Value = hocky.ToUpper();
            pNguoiLapBieu.Value = nguoiLapBieu;
            lblNgayIn.Text = "TP.Hồ Chí Minh, ngày " + ngayIn.ToString("dd") + " tháng " + ngayIn.ToString("MM") + " năm " + ngayIn.ToString("yyyy");

            bindingSourceThongke.DataSource = tbl;
        }
    }
}
