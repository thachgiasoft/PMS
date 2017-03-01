using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptThongKeSoLuongGiangVienTheoKhoaBoMon : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;
        public rptThongKeSoLuongGiangVienTheoKhoaBoMon()
        {
            InitializeComponent();
        }

        public void InitData(string namhoc, string ngaynhanbaocao, string maTruong, DateTime ngayin, DataTable tb)
        {
            pNamHoc.Value = namhoc;
            pNgayNhanBaoCao.Value = ngaynhanbaocao;
            xrLabelNgayThangNam.Text = "Ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
            bindingSourceThongKe.DataSource = tb;

            if (maTruong == "VHU")
            {
                xrLabel1.Visible = false;
                xrLabel2.Visible = false;
                xrLabel5.Visible = false;
            }
        }

        private void xrTableCellSTT_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (xrTableCell7.Text == " Tổng số")
            {
                xrTableCellSTT.Text = "";
            }
            else
            {
                _sttKhoa++;
                xrTableCellSTT.Text = _sttKhoa + ".";
            }


         
        }

        private void xrTableCell7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //xrTableCell7.Row[0].BackColor = Color.Brown;
            if (xrTableCell7.Text == " Tổng số")
            {
                xrTable2.Font = new Font(new FontFamily("Times New Roman"), 11, FontStyle.Bold);
                xrTable2.BackColor = System.Drawing.Color.DarkGray;
                xrTableCell7.BackColor = System.Drawing.Color.Transparent;
                xrTableCellSTT.BackColor = System.Drawing.Color.Transparent;
                xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            }
            else
            {
                xrTable2.Font = new Font(new FontFamily("Times New Roman"), 10, FontStyle.Regular);
                xrTable2.BackColor = System.Drawing.Color.Transparent;
                xrTableCell7.BackColor = System.Drawing.Color.Transparent;
                xrTableCellSTT.BackColor = System.Drawing.Color.Transparent;
                xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            }
        }

        private void xrTable2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

    }
}
