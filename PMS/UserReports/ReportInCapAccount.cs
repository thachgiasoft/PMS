using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Services;
using PMS.Entities;

namespace PMS.UserReports
{
    public partial class ReportInCapAccount : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportInCapAccount()
        {
            InitializeComponent();
        }
        public void InitData(string tentruong,VList<ViewThongTinGiangVien> vlist)
        {
            this.pTenTruong.Value = tentruong;
            this.bindingSourceViewThongTinGiangVien.DataSource = vlist;
        }
    }
}
