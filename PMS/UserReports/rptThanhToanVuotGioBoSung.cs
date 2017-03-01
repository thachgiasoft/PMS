using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThanhToanVuotGioBoSung : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;
        public rptThanhToanVuotGioBoSung()
        {
            InitializeComponent();
        }

        public void InitData(string SoTietChuyenSang, string soTietThucHien, string dinhMucNCKH, string tieuDe,string soTietChuyenSangNHSau, DataTable vList)
        {
            xrTableCell35.Text = SoTietChuyenSang;
            xrTableCell19.Text = soTietThucHien;
            xrTableCell4.Text = dinhMucNCKH;
            //xrTableCell52.Text = soTietChuyenSangNHSau;
            xrLabel14.Text = tieuDe;
            DataSource = vList;
        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            xrTableCellKhoa.Text = PMS.Common.Globals.Roman(_sttKhoa, true)+"/";
        }

    }
}
