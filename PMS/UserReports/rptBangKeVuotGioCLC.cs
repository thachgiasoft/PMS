using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.Reports
{
    public partial class rptBangKeVuotGioCLC : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangKeVuotGioCLC()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string namhoc, string hocky, string nguoilapbieu, DateTime ngayin, DataTable tb) 
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pNguoiLapBieu.Value = nguoilapbieu;
            pNgayIn.Value = string.Format("Ngày {0:dd} tháng {0:MM} năm {0:yyyy}", ngayin);
            DataSource = tb;
        }
    }
}
