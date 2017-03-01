using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports.NCKH
{
    public partial class rptLichSuNghienCuuKhoaHocCuaTungGiangVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptLichSuNghienCuuKhoaHocCuaTungGiangVien()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong, string tungay, string denngay, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTenTruong.Value = tentruong.ToUpper();
            pTuNgay.Value = tungay;
            pDenNgay.Value = denngay;
            pNguoiLapBieu.Value = nguoilapbieu;
            bindingSourceThanhToan.DataSource = tb;
            xrLabelNgayThangNam.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (xrTableCell17.Text == "True")
                xrTableCell17.Text = "X";
            else
                xrTableCell17.Text = "";

            if (xrTableCell18.Text == "True")
                xrTableCell18.Text = "X";
            else
                xrTableCell18.Text = "";
        }

    }
}
