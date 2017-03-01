using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports.SauDaiHoc
{
    public partial class rpnTongHopThanhToanThuLaoMau2_SDH : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0, _sttBoMon = 0;
        public rpnTongHopThanhToanThuLaoMau2_SDH()
        {
            InitializeComponent();
        }
        public void InitData(string truong, string namHoc, string hocKy, string loaiGiangVien, string lanChot, string nguoiLapBieu, string phongDaoTao, DateTime _ngayIn, DataTable data)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namHoc;
            pHocKy.Value = hocKy;
            pLoaiGiangVien.Value = loaiGiangVien.ToUpper();
            pLanChot.Value = lanChot;
            pNguoiLapBieu.Value = nguoiLapBieu;
            pPhongDaoTao.Value = phongDaoTao;
            bindingSourceBaoCao.DataSource = data;

            lblNgayIn.Text = string.Format("TP. Hồ Chí Minh, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", _ngayIn);
        }

        private void xrTableCell19_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            _sttBoMon = 0;
            xrTableCell19.Text = PMS.Common.Globals.Roman(_sttKhoa, true) + " - ";
        }

        private void xrTableCell31_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttBoMon++;
            xrTableCell31.Text = PMS.Common.Globals.Char(_sttBoMon.ToString(), true) + ". ";
        }
    }
}
