using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports.KhongChinhQuy
{
    public partial class rptDanhSachThanhToanThuLaoTapSuTheoBoMon_Kcq : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachThanhToanThuLaoTapSuTheoBoMon_Kcq()
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
    }
}
