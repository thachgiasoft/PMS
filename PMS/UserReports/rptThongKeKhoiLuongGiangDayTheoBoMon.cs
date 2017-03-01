using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeKhoiLuongGiangDayTheoBoMon : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeKhoiLuongGiangDayTheoBoMon()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string namhoc, string hocky, DateTime ngayin, DataTable tbl)
        {
            pTruong.Value = truong.ToUpper();
            pNamHocHocKy.Value = "(" + hocky + " - " + namhoc + ")";
            pNgayIn.Value = string.Format("Tp. HCM, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", ngayin);
            DataSource = tbl;
        }
    }
}
