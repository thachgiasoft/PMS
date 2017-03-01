using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptBangThanhToanThuLaoGiangDayTheoKhoa : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoaBacLoaiHinh = 0;
        public rptBangThanhToanThuLaoGiangDayTheoKhoa()
        {
            InitializeComponent();
        }

        public void InitData(string tentruong, string tenkhoa, string namhoc, string hocky, string phongdaotao, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTenTruong.Value = tentruong.ToUpper();
            if (tenkhoa == "[TẤT CẢ]") pTenKhoa.Value = "TOÀN TRƯỜNG";
            else
                pTenKhoa.Value = tenkhoa;
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pPhongDaoTao.Value = phongdaotao;
            pNguoiLapBieu.Value = nguoilapbieu;
            bindingSourceBangThanhToan.DataSource = tb;
            xrLabelNgayThangNam.Text = "TP. Hồ Chí Minh, ngày " + ngayin.Day.ToString() + " tháng " + ngayin.Month.ToString() + " năm " + ngayin.Year.ToString();
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoaBacLoaiHinh++;
            xrTableCellSTTKhoaBacLoaiHinh.Text = PMS.Common.Globals.Roman(_sttKhoaBacLoaiHinh, true) + ".";

        }

        private void xrTableCellThucNhan_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            xrLabelTienBangChu.Text = PMS.Common.Globals.DocTien(decimal.Parse(e.Value.ToString())) + ".";
        }
    }
}
