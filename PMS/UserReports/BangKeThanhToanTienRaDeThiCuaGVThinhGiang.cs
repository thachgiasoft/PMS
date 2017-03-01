using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class BangKeThanhToanTienRaDeThiCuaGVThinhGiang : DevExpress.XtraReports.UI.XtraReport
    {
        public BangKeThanhToanTienRaDeThiCuaGVThinhGiang()
        {
            InitializeComponent();
        }

        public void InitData(string namhoc, string hocky, string khoabomon, string phongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, DateTime ngayin, DataTable tb)
        {
            pHocKyNamHoc.Value = (String.Format("{0}, Năm học {1}", hocky, namhoc)).ToUpper();
            pKhoaHe.Value = (String.Format("{0} - HỆ: {1}", khoahoc, bacdaotao)).ToUpper();

            ////Nếu chọn nhiều khoa thì ko hiển thị người ký khoa
            //if (khoabomon.Contains(";"))
            //{
            //    //lblKhoaBanBoMon.Text = "";
            //    //xrLabel11.Visible = false;
            //    xrLabel12.Visible = false;
            //}
            //else
            //{
            //    //lblKhoaBanBoMon.Text = khoabomon.ToUpper();
            //    GroupHeader1.Visible = false;
            //    GroupFooter1.Visible = false;
            //    //xrLabel11.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(khoabomon.ToLower());
            //}

            ////Nếu bậc trung cấp thì ẩn phòng đào tạo ký
            //if (bacdaotao.ToLower() == "trung cấp")
            //{
            //    xrLabel13.Visible = false;
            //    xrLabel14.Visible = false;
            //    //xrLabel20.Visible = false;
            //}

            pDaoTao.Value = phongdaotao;
            pKeToan.Value = phongketoan;
            pHieuTruong.Value = hieutruong;
            pNguoiLap.Value = nguoilapbieu;
            pNgayIn.Value = String.Format("Ngày {0:dd} tháng {0:MM} năm {0:yyyy}", ngayin);

            DataSource = tb;
        }

        private void xrTableCell19_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            try
            {
                lblTienChu.Text = PMS.Common.Globals.DocTien(decimal.Parse(e.Value.ToString()));
            }
            catch
            { }
        }

        private void xrTableCell40_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((XRTableCell)sender).Text = PMS.Common.Globals.ReplaceDot(((XRTableCell)sender).Text);
        }

        private void xrTableCell19_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            ((XRTableCell)sender).Text = PMS.Common.Globals.ReplaceDot(((XRTableCell)sender).Text);
        }

    }
}
