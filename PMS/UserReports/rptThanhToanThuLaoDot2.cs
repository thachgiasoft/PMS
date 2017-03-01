using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThanhToanThuLaoDot2 : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;
        public rptThanhToanThuLaoDot2()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string namhoc, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namhoc;
            xrlblNgayIn.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
            bindingSource1.DataSource = tb;
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            xrTableCell28.Text = PMS.Common.Globals.Roman(_sttKhoa, true) + ".";
        }
    }
}
