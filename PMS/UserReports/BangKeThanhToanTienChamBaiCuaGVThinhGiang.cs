using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class BangKeThanhToanTienChamBaiCuaGVThinhGiang : DevExpress.XtraReports.UI.XtraReport
    {
        public BangKeThanhToanTienChamBaiCuaGVThinhGiang()
        {
            InitializeComponent();
        }

        public void InitData(string namhoc, string hocky, string khoabomon, string phongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, DateTime ngayin, DataTable tb)
        {
            pHocKyNamHoc.Value = (String.Format("{0}, Năm học {1}", hocky, namhoc)).ToUpper();
            pKhoaHe.Value = (String.Format("{0} - HỆ: {1}", khoahoc, bacdaotao)).ToUpper();
            pDaoTao.Value = phongdaotao;
            pKeToan.Value = phongketoan;
            pHieuTruong.Value = hieutruong;
            pNguoiLap.Value = nguoilapbieu;
            this.pNgayIn.Value = String.Format("Ngày {0:dd} tháng {0:MM} năm {0:yyyy}", ngayin);
            //Parameters[0].Value = (String.Format("{0} - HỆ: {1}", khoahoc, bacdaotao)).ToUpper();
            //Parameters[1].Value = (String.Format("{0}, Năm học {1}", hocky, namhoc)).ToUpper();
            //Parameters[2].Value = hieutruong;
            //Parameters[3].Value = phongketoan;
            //Parameters[4].Value = phongdaotao;
            //Parameters[5].Value = khoabomon;
            //Parameters[6].Value = nguoilapbieu;
            //Parameters[7].Value = String.Format("Ngày {0:dd} tháng {0:MM} năm {0:yyyy}", ngayin);
            DataSource = tb;
        }

        private void xrTableCell21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //((XRTableCell)sender).Text = PMS.Common.Globals.ReplaceDot(((XRTableCell)sender).Text);
        }

        private void xrTableCell49_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            //((XRTableCell)sender).Text = PMS.Common.Globals.ReplaceDot(((XRTableCell)sender).Text);
        }

        private void xrTableCell51_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblTienChu.Text = PMS.Common.Globals.DocTien(decimal.Parse(xrTableCell51.Text));
        }

        private void xrTableCell51_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            lblTienChu.Text = PMS.Common.Globals.DocTien(decimal.Parse(e.Value.ToString()));
        }
    }
}
