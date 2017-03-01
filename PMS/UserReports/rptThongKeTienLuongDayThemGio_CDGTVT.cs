using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeTienLuongDayThemGio_CDGTVT : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeTienLuongDayThemGio_CDGTVT()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong, string tenKhoa, string namhoc, string hieutruong, string phongdaotao, string truongkhoa, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namhoc;
            pNguoiLapBieu.Value = nguoilapbieu;
            lblNgayIn.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
            bindingSource1.DataSource = tb;
        }
    }
}
