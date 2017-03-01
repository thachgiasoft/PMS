using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptBangKeGioGiangTheoNamHoc : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangKeGioGiangTheoNamHoc()
        {
            InitializeComponent();
        }

        public void InitData(DataTable vList)
        {
            DataSource = vList;
        }

    }
}
