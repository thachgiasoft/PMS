using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeCanBoNhanVienTheoNgay : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeCanBoNhanVienTheoNgay()
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

        private void xrTableCellTieuDe_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (xrTableCellTieuDe.Text == "Tổng số: (I + II)")
            {
                xrTable2.Font = new Font(new FontFamily("Times New Roman"), 11, FontStyle.Bold);
                xrTable2.BackColor = System.Drawing.Color.DarkGray;
                xrTableCellTieuDe.BackColor = System.Drawing.Color.Transparent;
                xrTableCellTieuDe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

            }
            else
            {
                if (xrTableCellTieuDe.Text == "I- Cán bộ nhân viên: " || xrTableCellTieuDe.Text == "II- Giảng viên" || xrTableCellTieuDe.Text == "III-Giảng viên thỉnh giảng")
                {
                    xrTable2.Font = new Font(new FontFamily("Times New Roman"), 11, FontStyle.Bold);
                    xrTable2.BackColor = System.Drawing.Color.DarkGray;
                    xrTableCellTieuDe.BackColor = System.Drawing.Color.Transparent;
                    xrTableCellTieuDe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                }
                else
                {
                    xrTable2.Font = new Font(new FontFamily("Times New Roman"), 10, FontStyle.Regular);
                    xrTable2.BackColor = System.Drawing.Color.Transparent;
                    xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                }
            }
        }

    }
}
