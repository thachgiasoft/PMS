using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptBangKeGioGiang_BUH : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangKeGioGiang_BUH()
        {
            InitializeComponent();
        }

        public void InitData(string namHoc, DateTime ngayIn, DataTable data)
        {
            pNamHoc.Value = namHoc;
            bindingSourceThongKe.DataSource = data;
        }
    }
}
