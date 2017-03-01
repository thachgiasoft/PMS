using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports.KhongChinhQuy
{
    public partial class rptDanhSachThanhToanThuLaoTheoKhoa_Kcq : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttBoMon = 0;
        public rptDanhSachThanhToanThuLaoTheoKhoa_Kcq()
        {
            InitializeComponent();
        }
        public void InitData(string tenTruong, string namHoc, string hocKy, string phongToChucCanBo, string phongDaoTao, string nguoiLapBieu, DataTable data)
        {
            pTruong.Value = tenTruong.ToUpper();
            pNamHoc.Value = namHoc;
            pHocKy.Value = hocKy;
            pPhongToChucCanBo.Value = phongToChucCanBo;
            pPhongDaoTao.Value = phongDaoTao;
            pNguoiLapBieu.Value = nguoiLapBieu;
            bindingSourceThongKe.DataSource = data;
        }

        private void GroupHeader3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttBoMon++;
            xrTableCell36.Text = PMS.Common.Globals.Roman(_sttBoMon, true);
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttBoMon = 0;
        }
    }
}
