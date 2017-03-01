using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;

namespace PMS.UserReports
{
    public partial class ChiTietKhoiLuongGiangDayQuyDoiReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ChiTietKhoiLuongGiangDayQuyDoiReport()
        {
            InitializeComponent();
        }

        public void InitData(string truong , string phongDT, string namHoc, string hocKy, VList<ViewChiTietQuyDoi> vList)
        {
            pTruong.Value = truong;
            pPhongDaoTao.Value = phongDT;
            pNamHoc.Value = namHoc;
            pHocKy.Value = hocKy;
            bindingSourceChiTietKhoiLuong.DataSource = vList;
        }
    }
}
