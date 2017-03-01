using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;

namespace PMS.UserReports
{
    public partial class ChiTietKhoiLuongThucDayReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ChiTietKhoiLuongThucDayReport()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string phongDT, string namHoc, string hocKy, VList<ViewChiTietKhoiLuongThucDay> vList)
        {
            pTruong.Value = truong;
            pPhongDT.Value = phongDT;
            pNamHoc.Value = namHoc;
            pHocKy.Value = hocKy;
            bindingSourceChiTietKhoiLuong.DataSource = vList;
        }
    }
}
