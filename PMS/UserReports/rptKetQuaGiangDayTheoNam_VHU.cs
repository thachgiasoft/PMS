using System;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptKetQuaGiangDayTheoNam_VHU : XtraReport
    {
        int _sttKhoaBacLoaiHinh = 0;
        public rptKetQuaGiangDayTheoNam_VHU()
        {
            InitializeComponent();
        }

        public void InitData(string tenTruong, string namhoc, DateTime ngayin, DataTable tb)
        {
            pNamHoc.Value = namhoc;
            bindingSource1.DataSource = tb;
            GroupHeader1.GroupFields.Add(new GroupField("TenDonVi"));
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoaBacLoaiHinh++;
            xrTableCell15.Text = PMS.Common.Globals.Char(_sttKhoaBacLoaiHinh.ToString(), true);
        }

        private void xrTableCell72_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            //try
            //{
            //    decimal _soTien = (decimal)e.Value;
            //    xrLabelTongTien.Text = _soTien.ToString("n0");
            //    xrLabelTienChu.Text = "(" + PMS.Common.Globals.DocTien(_soTien) + ")";
            //}
            //catch
            //{ }
        }

    }
}
