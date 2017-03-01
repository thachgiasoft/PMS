using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports.ReportThanhTra
{
    public partial class KiemTraGioThucGiang : DevExpress.XtraReports.UI.XtraReport
    {
        public KiemTraGioThucGiang()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string tungay, string denngay, string daynha, DateTime ngayin, DataTable tb)
        {
            pTruong.Value = truong.ToUpper();
            if (tungay == denngay)
                pNgay.Value = "Ngày " + tungay;
            else
                pNgay.Value = String.Format("Từ ngày {0} đến ngày {1}", tungay, denngay);
            pDayNha.Value = "Dãy nhà: " + daynha;

            pNgayIn.Value = String.Format("TP.HCM, ngày {0:dd} tháng {1:MM} năm {2:yyyy}", ngayin, ngayin, ngayin);

            DataSource = tb;
        }
    }
}
