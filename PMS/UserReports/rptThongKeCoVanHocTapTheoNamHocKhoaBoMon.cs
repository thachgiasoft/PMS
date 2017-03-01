using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeCoVanHocTapTheoNamHocKhoaBoMon : DevExpress.XtraReports.UI.XtraReport
    {
        int _stt = 0;
        bool _fulControl;
        string TenKhoa;
        public rptThongKeCoVanHocTapTheoNamHocKhoaBoMon()
        {
            InitializeComponent();
        }
        public void InitData(string tentruong, string namhoc, string nguoilapbieu, bool fullControl, string tenkhoa, DataTable tb)
        {
            pTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namhoc;
            pNguoiLapBieu.Value = nguoilapbieu;
            bindingSourceThongKe.DataSource = tb;
            _fulControl = fullControl;
            TenKhoa = tenkhoa.ToUpper();
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _stt++;
            xrTableCell3.Text = PMS.Common.Globals.Roman(_stt, true);
        }

        private void rptThongKeCoVanHocTapTheoNamHocKhoaBoMon_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!_fulControl)
            {
                GroupHeader1.Visible = false;
                GroupFooter1.Visible = false;
                xrLabel6.Text = TenKhoa;
            }
        }
    }
}
