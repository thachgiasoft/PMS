using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThanhToanThuLaoCuaGiangVienThinhGiangTheoThang : DevExpress.XtraReports.UI.XtraReport
    {
        string TongTien;
        public rptThanhToanThuLaoCuaGiangVienThinhGiangTheoThang()
        {
            InitializeComponent();
        }
        public void InitData(string phongDaoTao, string nguoiLapBieu, DataTable tb)
        {
            pPhongDaoTao.Value = phongDaoTao;
            pNguoiLapBieu.Value = nguoiLapBieu;
            bindingSourceThongKe.DataSource = tb;
        }

        private void GroupFooter2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel7.Text = decimal.Parse(TongTien).ToString("n0");
            xrLabel8.Text = PMS.Common.Globals.DocTien(decimal.Parse(TongTien));
        }

        private void xrTableCell57_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            TongTien = xrTableCell57.Summary.GetResult().ToString();
        }
    }
}
