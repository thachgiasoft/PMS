using System;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.Reports
{
    public partial class subDanhSachGiangDay : XtraReport
    {
        public subDanhSachGiangDay()
        {
            InitializeComponent();
        }
        public void InitData(DataTable tb)
        {
            bindingSourceSub1.DataSource = tb;
            this.DataSource = bindingSourceSub1;
        }
    }
}
