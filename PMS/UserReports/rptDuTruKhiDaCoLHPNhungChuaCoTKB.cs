using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptDuTruKhiDaCoLHPNhungChuaCoTKB : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0, _sttMon = 0;
        public rptDuTruKhiDaCoLHPNhungChuaCoTKB()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string namhoc, string hocky, string nguoiLapBieu, DateTime ngayin, DataTable dt)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pNguoiLapBieu.Value = nguoiLapBieu;
            xrLabel2.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
            bindingSourceThongKe.DataSource = dt;
        }

        private void xrTableCellSTTKhoa_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            _sttMon = 0;
            xrTableCellSTTKhoa.Text = PMS.Common.Globals.Roman(_sttKhoa, true)+".";
        }

        private void xrTableCellSTTMon_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttMon++;
            xrTableCellSTTMon.Text = _sttMon.ToString();
        }

        private void xrTableCell39_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrTableCell39.Text = xrTableCell39.Text.ToUpper();
        }

    }
}
