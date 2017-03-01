using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptDanhSachThanhToanThuLaoTheoKhoa : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttBoMon = 0;
        string _maQuanLy = "";
        public rptDanhSachThanhToanThuLaoTheoKhoa()
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
            _maQuanLy = "";
        }

        private void GroupHeader3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttBoMon = 0;
        }

        private void xrTableCell34_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (_maQuanLy == xrTableCell19.Text)
            {
                xrTableCell34.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left;
            }
            else
            {
                xrTableCell34.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top;
            }
            _maQuanLy = xrTableCell19.Text;
        }
    }
}
