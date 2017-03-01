using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;

namespace PMS.UserReports
{
    public partial class TongHopKhoiLuongGiangDayThucDayReport : DevExpress.XtraReports.UI.XtraReport
    {
        public TongHopKhoiLuongGiangDayThucDayReport()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string phongDT, string namHoc, string hocKy, VList<ViewKhoiLuongThucDay> vList)
        {
            pTruong.Value = truong;
            pTruongPhongDaoTao.Value = phongDT;
            pNamHoc.Value = namHoc;
            pHocKy.Value = hocKy;
            bindingSourceTongHopKhoiLuong.DataSource = vList;
        }
    }
}