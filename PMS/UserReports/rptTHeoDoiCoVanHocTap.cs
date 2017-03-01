using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptTHeoDoiCoVanHocTap : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;
        public rptTHeoDoiCoVanHocTap()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string namhoc, string hocky, string nguoiLapBieu, DateTime ngayin, DataTable dt)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pNguoiLapBieu.Value = nguoiLapBieu;
            lblNgayIn.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
            bindingSource1.DataSource = dt;
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            lblSttKhoa.Text = PMS.Common.Globals.Roman(_sttKhoa, true) + ". ";
        }
    }
}
