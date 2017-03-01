using System;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptHopDongMoiGiangDay_VHU : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHopDongMoiGiangDay_VHU()
        {
            InitializeComponent();
        }

        public void InitData(DataTable tb)
        {
            bindingSourceHDMoiGiangDay.DataSource = tb;
        }
    }
}
