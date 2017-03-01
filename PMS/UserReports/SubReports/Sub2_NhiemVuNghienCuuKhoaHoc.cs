using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.Reports
{
    public partial class Sub2_NhiemVuNghienCuuKhoaHoc : DevExpress.XtraReports.UI.XtraReport
    {
        public Sub2_NhiemVuNghienCuuKhoaHoc()
        {
            InitializeComponent();
        }

        public void InitData(DataTable tb)
        {
            bindingSourceNCKH.DataSource = tb;
        }
    }
}
