using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThanhTraCoiThi : DevExpress.XtraReports.UI.XtraReport
    {
        string _ngay;
        public rptThanhTraCoiThi()
        {
            InitializeComponent();
        }
        public void InitData(string truong, string tungay, string denngay, string nguoilapbieu, DataTable data)
        {
            pTruong.Value = truong.ToUpper();
            if (tungay == denngay)
                _ngay = "ngày " + tungay;
            else
                _ngay = "từ ngày " + tungay + " đến ngày " + denngay;
            pNgay.Value = _ngay.ToUpper();
            pNguoiLapBieu.Value = nguoilapbieu;
            bindingSourceThongKe.DataSource = data;
        }
    }
}
