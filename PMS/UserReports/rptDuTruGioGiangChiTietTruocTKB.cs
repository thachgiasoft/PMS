using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptDuTruGioGiangChiTietTruocTKB : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0, _sttGV = 0;
        public rptDuTruGioGiangChiTietTruocTKB()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string namhoc, string hocky, string nguoiLapBieu, DateTime ngayin, DataTable dt)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pNguoiLapBieu.Value = nguoiLapBieu;
            bindingSourceThongKe.DataSource = dt;

            xrLabel6.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            _sttGV = 0;
            xrTableCellSTTKhoa.Text = PMS.Common.Globals.Roman(_sttKhoa, true);
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttGV++;
            xrTableCellSTTGV.Text = _sttGV.ToString();
        }
    }
}
