using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.GV
{
    public partial class rptPhieuGhiGioGiang_QNU : XtraReport
    {
        public rptPhieuGhiGioGiang_QNU()
        {
            InitializeComponent();
            this.Landscape = false;
        }

        public void InitData(DataTable tb, DataTable tbSub)
        {
            bindingSourceThongKe.DataSource = tb;
            this.subDanhSachGiangDay1.InitData(tbSub);
            this.xrSubreport1.ReportSource = this.subDanhSachGiangDay1;
        }
    }
}
