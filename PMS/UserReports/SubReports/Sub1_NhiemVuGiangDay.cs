using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.Reports
{
    public partial class Sub1_NhiemVuGiangDay : XtraReport
    {
        public Sub1_NhiemVuGiangDay()
        {
            InitializeComponent();
        }
        public void InitData(DataTable tb)
        {
            bindingSourceSub1.DataSource = tb;
        }
    }
}
