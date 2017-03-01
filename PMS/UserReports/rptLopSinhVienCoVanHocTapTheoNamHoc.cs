using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptLopSinhVienCoVanHocTapTheoNamHoc : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;
        public rptLopSinhVienCoVanHocTapTheoNamHoc()
        {
            InitializeComponent();
        }
        public void InitData(string truong, string namHoc, string hocKy, string khoa, string nguoiLapBieu, DataTable data)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namHoc;
            pHocKy.Value = hocKy;
            pKhoa.Value = khoa.ToUpper();
            pNguoiLapBieu.Value = nguoiLapBieu;
            bindingSourceThongke.DataSource = data;
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            xrTableCell40.Text = PMS.Common.Globals.Roman(_sttKhoa, true);
        }

        private void rptLopSinhVienCoVanHocTapTheoNamHoc_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (pKhoa.Value.ToString().Contains(";") == false && pKhoa.Value.ToString() != ("Toàn trường").ToUpper())
            {
                GroupHeader1.Visible = false;
                GroupFooter1.Visible = false;
            }
            if (pKhoa.Value.ToString() == ("Toàn trường").ToUpper())
            {
                xrLabel6.Visible = false;
            }
        }
    }
}
