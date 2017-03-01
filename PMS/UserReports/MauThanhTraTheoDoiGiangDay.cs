using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PMS.UserReports
{
    public partial class MauThanhTraTheoDoiGiangDay : DevExpress.XtraReports.UI.XtraReport
    {
        public MauThanhTraTheoDoiGiangDay()
        {
            InitializeComponent();
        }
        public void InitData(string tentruong)
        {
            pTenTruong.Value = tentruong.ToUpper();
        }
    }
}
