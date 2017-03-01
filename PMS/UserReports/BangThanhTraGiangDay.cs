using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;

namespace PMS.UserReports
{
    public partial class BangThanhTraGiangDay : DevExpress.XtraReports.UI.XtraReport
    {
        public BangThanhTraGiangDay()
        {
            InitializeComponent();
        }

        public void InitData(string tenTruong, string nguoiLapBieu,string tungay, string denngay, VList<ViewThanhTraGiangDay> tlist)
        {
            this.pTuNgay.Value = tungay;
            this.pDenNgay.Value = denngay;
            pTenTruong.Value = tenTruong.ToUpper();
            pNguoiLapBieu.Value = nguoiLapBieu;
            this.bindingSourceThanhTraGiangDay.DataSource = tlist;
        }
    }
}
