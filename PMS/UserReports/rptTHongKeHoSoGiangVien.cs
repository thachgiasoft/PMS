using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptTHongKeHoSoGiangVien : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;
        public rptTHongKeHoSoGiangVien()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong, string tenKhoa, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTruong.Value = tentruong.ToUpper();
            bindingSource1.DataSource = tb;
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            xrTableCell11.Text = PMS.Common.Globals.Roman(_sttKhoa, true) + ". ";
        }
    }
}
