using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;

namespace PMS.UserReports
{
    public partial class TongHopKhoiLuongGiangDayQuyDoiReport : DevExpress.XtraReports.UI.XtraReport
    {
        public TongHopKhoiLuongGiangDayQuyDoiReport()
        {
            InitializeComponent();
        }

        public void InitData(string namHoc, string hocKy,string truong,string phongDaotao, VList<ViewTongHopQuyDoi> vList)
        {
            pNamHoc.Value = namHoc;
            pHocKy.Value = hocKy;
            pTruong.Value = truong;
            pPhongDaoTao.Value = phongDaotao;
            bindingSourceTongHop.DataSource = vList;
        }
    }
}
