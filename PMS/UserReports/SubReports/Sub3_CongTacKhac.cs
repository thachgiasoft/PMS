using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.Reports
{
    public partial class Sub3_CongTacKhac : DevExpress.XtraReports.UI.XtraReport
    {
        public Sub3_CongTacKhac()
        {
            InitializeComponent();
        }

        public void InitData(DataTable tbl)
        {
            bindingSourceSub3.DataSource = tbl;
        }
    }
}
