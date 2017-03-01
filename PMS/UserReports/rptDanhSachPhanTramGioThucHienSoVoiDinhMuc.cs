using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptDanhSachPhanTramGioThucHienSoVoiDinhMuc : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachPhanTramGioThucHienSoVoiDinhMuc()
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

        private void xrTableCell40_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void xrTableCell56_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            try
            {
                if (xrTableCell42.Text != null || !xrTableCell42.Text.Equals("0.00"))
                {
                    xrTableCell40.Text = double.Parse(xrTableCell56.Text) * 100 / double.Parse(xrTableCell42.Text) + "%";
                }
            }
            catch (Exception ex)
            {
                Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }
    }
}
