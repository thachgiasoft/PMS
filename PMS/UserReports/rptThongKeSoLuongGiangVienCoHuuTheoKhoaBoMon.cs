using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeSoLuongGiangVienCoHuuTheoKhoaBoMon : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;
        public rptThongKeSoLuongGiangVienCoHuuTheoKhoaBoMon()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong,string namhoc, string ngaynhanbaocao, DateTime ngayin, DataTable tb)
        {
            pTenTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namhoc;
            pNgayNhanBaoCao.Value = ngaynhanbaocao;
            xrLabelNgayThangNam.Text = "TP.HCM, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
            bindingSourceThongKe.DataSource = tb;
        }

        private void xrTableCellSTTKhoa_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (xrTableCellNoiDung.Text == " Tổng số")
            {
                xrTableCellSTTKhoa.Text = "";
            }
            else
            {
                _sttKhoa++;
                xrTableCellSTTKhoa.Text = _sttKhoa.ToString();
            }
           
        }

        private void xrTableCellNoiDung_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (xrTableCellNoiDung.Text == " Tổng số")
            {
                xrTable2.Font = new Font(new FontFamily("Times New Roman"), 12, FontStyle.Bold);
                //xrTableCellNoiDung.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            }
            else
            {
                xrTable2.Font = new Font(new FontFamily("Times New Roman"), 12, FontStyle.Regular);
                //xrTableCellNoiDung.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            }
        }

    }
}
