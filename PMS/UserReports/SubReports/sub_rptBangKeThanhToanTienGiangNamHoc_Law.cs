using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports.SubReports
{
    public partial class sub_rptBangKeThanhToanTienGiangNamHoc_Law : DevExpress.XtraReports.UI.XtraReport
    {
        public sub_rptBangKeThanhToanTienGiangNamHoc_Law()
        {
            InitializeComponent();
        }

        public void InitData(string namHoc, DataTable tb)
        {
            DataSource = tb;
            xrTableCell4.Text = "Tổng số tiền giảng năm học " + namHoc + " đã nhận qua các đợt thanh toán:";
        }
    }
}
