using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports.NCKH
{
    public partial class rptThongKeThucHienNCKH : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeThucHienNCKH()
        {
            InitializeComponent();
            GroupField gf = new GroupField("TenKhoa");
            GroupHeader2.GroupFields.Add(gf);
        }

        public void InitData(string tentruong, string namhoc, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTenTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namhoc;
            pNguoiLapBieu.Value = nguoilapbieu;
            bindingSourceThanhToan.DataSource = tb;
            xrLabelNgayThangNam.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
        }

    }
}
