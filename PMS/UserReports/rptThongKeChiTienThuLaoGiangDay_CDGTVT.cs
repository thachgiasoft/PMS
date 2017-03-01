using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeChiTienThuLaoGiangDay_CDGTVT : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;
        public rptThongKeChiTienThuLaoGiangDay_CDGTVT()
        {
            InitializeComponent();
        }
        public void InitData(string tentruong, string tenKhoa, string namhoc, string hocKy, string hieutruong, string phongdaotao, string truongkhoa, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTruong.Value = tentruong.ToUpper();
            //pKhoa.Value = tenKhoa.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocKy;
            //pHieuTruong.Value = hieutruong;
            //pPhongDaoTao.Value = phongdaotao;
            pNguoiLapBieu.Value = nguoilapbieu;
            xrLabelNgayIn.Text = "Tp. Hồ Chí Minh, ngày " + ngayin.ToString("dd") + " tháng " + ngayin.ToString("MM") + " năm " + ngayin.ToString("yyyy");
            bindingSource1.DataSource = tb;
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            xrTableCellSttKhoa.Text = PMS.Common.Globals.Roman(_sttKhoa, true) + ". ";
        }
    }
}
