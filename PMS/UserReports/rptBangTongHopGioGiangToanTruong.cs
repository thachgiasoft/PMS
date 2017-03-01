using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.GV
{
    public partial class rptBangTongHopGioGiangToanTruong : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttTrang;
        public rptBangTongHopGioGiangToanTruong()
        {
            InitializeComponent();
        }

        public void InitData(string tenTruong, string namHoc, string hocKy, string tenDot, string phongDaoTao, string nguoiLapBieu, DateTime ngayIn, DataTable data) 
        {
            pTruong.Value = tenTruong.ToUpper();
            pNamHoc.Value = namHoc;
            pHocKy.Value = hocKy.ToUpper();
            pPhongDaoTao.Value = phongDaoTao;
            pNguoiLapBieu.Value = nguoiLapBieu;
            pNgayIn.Value = string.Format("Đà Lạt, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", ngayIn);
            DataSource = data;
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttTrang++;
            lblTrang.Text = _sttTrang.ToString();
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttTrang = 0;
        }
    }
}
