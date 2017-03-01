using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThanhToanVuotGioDinhMucGiangVienCoHuu : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;
        public rptThanhToanVuotGioDinhMucGiangVienCoHuu()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong, string namhoc, string phongdaotao, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTenTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namhoc;
            pPhongDaoTao.Value = phongdaotao;
            pNguoiLapBieu.Value = nguoilapbieu;
            bindingSourceThanhToan.DataSource = tb;
            xrLabelNgayThangNam.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
        }
        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            xrTableCellSTTKhoa.Text = PMS.Common.Globals.Roman(_sttKhoa, true) + ".";
        }

        private void xrTableCell47_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            xrLabelTienChu.Text = PMS.Common.Globals.DocTien(decimal.Parse(e.Value.ToString())) + ".";
        }

    }
}
