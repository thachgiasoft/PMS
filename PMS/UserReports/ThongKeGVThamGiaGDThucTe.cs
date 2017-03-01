using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.GV
{
    public partial class ThongKeGVThamGiaGDThucTe : DevExpress.XtraReports.UI.XtraReport
    {
        public ThongKeGVThamGiaGDThucTe()
        {
            InitializeComponent();
        }

        public void InitData(string truong, DateTime ngay, DateTime ngayIn, DataTable tb)
        {
            pTruong.Value = truong.ToUpper();
            pNgay.Value = ngay.ToString("dd/MM/yyyy");
            pNgayIn.Value = string.Format("Tp. Hồ Chí Minh, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", ngayIn);
            DataSource = tb;
        }
    }
}
