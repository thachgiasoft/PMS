using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PMS.UserReports
{
    public partial class rptInGioChuanNghiaVu_UEL : DevExpress.XtraReports.UI.XtraReport
    {
        public rptInGioChuanNghiaVu_UEL()
        {
            InitializeComponent();
        }

        public void InitData(string truong)
        {
            pTruong.Value = truong;
        }
    }
}
