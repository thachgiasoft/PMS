using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptBangThanhToanThuLaoThinhGiangTheoKhoa : DevExpress.XtraReports.UI.XtraReport
    {
        int _stt = 0; string TongTien;
        public rptBangThanhToanThuLaoThinhGiangTheoKhoa()
        {
            InitializeComponent();
        }
        public void InitData(string tentruong, string namhoc, string hocky, string tenkhoa, string phongdaotao, string nguoilapbieu, DataTable tb)
        {
            pTenTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pTenKhoa.Value = tenkhoa.ToUpper();
            pPhongDaoTao.Value = phongdaotao;
            pNguoiLapBieu.Value = nguoilapbieu;
            bindingSourceThongKe.DataSource = tb;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _stt++;
            if (xrTableCell51.Text != "")
                xrTableCell22.Text = _stt.ToString();
        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel7.Text = PMS.Common.Globals.DocTien(decimal.Parse(TongTien));
        }

        private void xrTableCell48_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            TongTien = xrTableCell48.Summary.GetResult().ToString();
        }
    }
}
