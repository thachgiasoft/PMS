using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptBangThanhToanGioVuotDinhMucCuaGiangVien : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;
        public rptBangThanhToanGioVuotDinhMucCuaGiangVien()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong, string namhoc, string hocky, string phongdaotao, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTenTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pPhongDaoTao.Value = phongdaotao;
            pNguoiLapBieu.Value = nguoilapbieu;
            bindingSourceBangThanhToan.DataSource = tb;
            xrLabelNgayThangNam.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
            
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            xrTableCellSTTKhoa.Text = PMS.Common.Globals.Roman(_sttKhoa, true) + ".";
            xrTableCell31.Text.ToUpper();
            xrTableCell31.Text.ToUpper();
        }

    }
}
