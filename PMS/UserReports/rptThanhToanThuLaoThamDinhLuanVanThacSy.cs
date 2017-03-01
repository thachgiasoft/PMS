using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThanhToanThuLaoThamDinhLuanVanThacSy : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThanhToanThuLaoThamDinhLuanVanThacSy()
        {
            InitializeComponent();
        }
        public void InitData(string truong, string namhoc, string hocky, string nguoilapbieu, string truongphongsaudaihoc, DateTime ngayin, DataTable tb)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pNguoiLapBieu.Value = nguoilapbieu;
            pPhongSDH.Value = truongphongsaudaihoc;
            lblNgayIn.Text = "TP.Hồ Chí Minh, ngày " + ngayin.ToString("dd") + " tháng " + ngayin.ToString("MM") + " năm " + ngayin.ToString("yyyy");
            bindingSourceThongKe.DataSource = tb;
        }

        private void xrTableCell18_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            lblTienBangChu.Text = "Số tiền bằng chữ: " + PMS.Common.Globals.DocTien(decimal.Parse(e.Value.ToString())) + ".";
        }
    }
}
