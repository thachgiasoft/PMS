using System;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptDuToanKinhPhiGiangDay_Vhu : XtraReport
    {
        int _sttKhoaBacLoaiHinh = 0;
        public rptDuToanKinhPhiGiangDay_Vhu()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong, string namhoc, string hocky, DateTime ngayin, DataTable tb)
        {
            pTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky.ToUpper();
            bindingSource1.DataSource = tb;
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoaBacLoaiHinh++;
            xrTableCell15.Text = PMS.Common.Globals.Char(_sttKhoaBacLoaiHinh.ToString(), true);
        }

        private void xrTableCell72_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            try
            {
                decimal _soTien = (decimal)e.Value;
                xrLabelTongTien.Text = _soTien.ToString("n0");
                xrLabelTienChu.Text = "(" + PMS.Common.Globals.DocTien(_soTien) + ")";
            }
            catch
            { }
        }

    }
}
