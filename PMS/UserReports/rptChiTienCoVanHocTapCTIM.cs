using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptChiTienCoVanHocTapCTIM : DevExpress.XtraReports.UI.XtraReport
    {
        public rptChiTienCoVanHocTapCTIM()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong, string namhoc, string hocky, string khoadonvi, DateTime ngayin, DataTable tb)
        {
            pTenTruong.Value = tentruong.ToUpper();
            lblNamHocHocKy.Text = (String.Format("{0} NĂM HỌC {1}", hocky, namhoc)).ToUpper();
            if (khoadonvi.Contains(";"))
            {
                lblKhoaDonVi.Text = "";
                //lblTruongKhoa.Text = "";
            }
            else
                lblKhoaDonVi.Text = khoadonvi.ToUpper();
            lblNgayIn.Text = "TP. Hồ Chí Minh, ngày " + ngayin.ToString("dd") + " tháng " + ngayin.ToString("MM") + " năm " + ngayin.ToString("yyyy");
            bindingSourceThongKe.DataSource = tb;
        }

        private void xrTableCell12_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            lblThanhTien.Text = String.Format("Thành tiền: {0}.", PMS.Common.Globals.DocTien(decimal.Parse(e.Value.ToString())));
        }

    }
}
