using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptDuTruGioGiangChiTietTruocKhiCoLopHocPhan : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0, _sttLop = 0;
        public rptDuTruGioGiangChiTietTruocKhiCoLopHocPhan()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string namhoc, string hocky, string nguoiLapbieu, DateTime ngayin, DataTable dt)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pNguoiLapBieu.Value = nguoiLapbieu;
            xrLabel2.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
            bindingSourceThongKe.DataSource = dt;
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            _sttLop = 0;
            xrTableCellSTTKhoa.Text = PMS.Common.Globals.Roman(_sttKhoa, true);
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttLop++;
            xrTableCellSTTLop.Text = _sttLop.ToString();
        }

    }
}
