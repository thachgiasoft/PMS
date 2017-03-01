using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.GV
{
    public partial class TKDoiNguCanBoQuanLy_NVNghiepVuCuaCacTruongChuyenNghiep : DevExpress.XtraReports.UI.XtraReport
    {
        public TKDoiNguCanBoQuanLy_NVNghiepVuCuaCacTruongChuyenNghiep()
        {
            InitializeComponent();
        }
        public void InitData(string tenTruong, DateTime ngayIn, string nam, DataTable tb)
        {
            //pTruong.Value = tenTruong.ToUpper();
            //pNam.Value = nam;
            bindingSourceThongKe.DataSource = tb;
        }
    }
}
