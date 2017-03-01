using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;

namespace PMS.UserReports
{
    public partial class ReportDanhSachGiangVien : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDanhSachGiangVien()
        {
            InitializeComponent();
        }
        public void InitData(string tentruong,VList<ViewThongTinChiTietGiangVien> vlist)
        {
            this.pTenTruong.Value = tentruong;
            this.bindingSourceGiangVien.DataSource = vlist;
        }
    }
}
