using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.GV
{
    public partial class DanhSachCBGV : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;
        public DanhSachCBGV()
        {
            InitializeComponent();
        }

        public void InitData(string tenTruong, DateTime ngayIn, string thoidiem, DataTable tb)
        {
            pTruong.Value = tenTruong.ToUpper();
            pThoiDiem.Value = thoidiem;
            bindingSourceThongKe.DataSource = tb;
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            xrSttKhoa.Text = PMS.Common.Globals.Roman(_sttKhoa, true) + ". ";
        }
    }
}
