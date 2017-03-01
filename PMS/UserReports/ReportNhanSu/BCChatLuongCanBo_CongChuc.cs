using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.GV
{
    public partial class BCChatLuongCanBo_CongChuc : DevExpress.XtraReports.UI.XtraReport
    {
        public BCChatLuongCanBo_CongChuc()
        {
            InitializeComponent();
        }

        private void xrTable1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
        public void InitData(string tenTruong, DateTime ngayIn, string nam, DataTable tb)
        {
            //pTruong.Value = tenTruong.ToUpper();
            //pNam.Value = nam;
            //bindingSourceThongKe.DataSource = tb;
        }
    }
}
