using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;

namespace PMS.UserReports
{
    public partial class HopDongThinhGiangReport : DevExpress.XtraReports.UI.XtraReport
    {
        public HopDongThinhGiangReport()
        {
            InitializeComponent();
        }
        //public void InitData(string tentruong, ViewGiangVienLichGiang obj)
        //{
        //    this.Tentruong.Value = tentruong;
        //    bindingSourceChiTiet.DataSource = obj;
        //}
    }
}
