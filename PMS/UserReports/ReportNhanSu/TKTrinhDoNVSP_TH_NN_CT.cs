using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.GV
{
    public partial class TKTrinhDoNVSP_TH_NN_CT : DevExpress.XtraReports.UI.XtraReport
    {
        public TKTrinhDoNVSP_TH_NN_CT()
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
