using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;

namespace PMS.UserReports
{
    public partial class ThongKeHoSoChucVuGiangVienReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ThongKeHoSoChucVuGiangVienReport()
        {
            InitializeComponent();
        }

        //public void InitData(string tentruong, VList<ViewThongKeChucVu> vlist)
        //{
        //    this.pTenTruong.Value = tentruong;
        //    this.bindingSourceHoSoChucVuGiangVien.DataSource = vlist;
        //}
    }
}
