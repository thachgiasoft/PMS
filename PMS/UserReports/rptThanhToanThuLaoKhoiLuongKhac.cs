using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThanhToanThuLaoKhoiLuongKhac : DevExpress.XtraReports.UI.XtraReport
    {
        int _stt = 0;
        public rptThanhToanThuLaoKhoiLuongKhac()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string donvi, string loaigiangvien, string namhoc, string hocky, string nguoilapbieu, DataTable tb)
        {
            pTruong.Value = truong.ToUpper();
            pDonVi.Value = donvi.ToUpper();
            pLoaiGiangVien.Value = loaigiangvien.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pNguoiLapBieu.Value = nguoilapbieu;
            bindingSourceThongKe.DataSource = tb;
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _stt++;
            xrTableCell15.Text = _stt.ToString();
        }
    }
}
