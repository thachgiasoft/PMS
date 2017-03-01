using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptThongKeDuTruGioGiangTruocLHP : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;
        public rptThongKeDuTruGioGiangTruocLHP()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string namhoc, string nguoilapbieu, DateTime ngayin, DataTable dt)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namhoc;
            pNguoiLapBieu.Value = nguoilapbieu;
            xrLabel5.Text = "Thành phố Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
            bindingSourceThongKe.DataSource = dt;
        }

        private void xrTableCellSTTKhoa_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            xrTableCellSTTKhoa.Text = _sttKhoa.ToString();
        }

    }
}
