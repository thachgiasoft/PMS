using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports.ReportThanhTra
{
    public partial class KiemTraGioCoiThi : DevExpress.XtraReports.UI.XtraReport
    {
        public KiemTraGioCoiThi()
        {
            InitializeComponent();
        }

        public void InitData(string _truong, string _tuNgay, string _denNgay, string _dayNha, DateTime _ngayIn, DataTable tb)
        {
            pTruong.Value = _truong.ToUpper();
            if (_tuNgay == _denNgay)
                pNgay.Value = "Ngày " + _tuNgay;
            else
                pNgay.Value = String.Format("Từ ngày {0} đến ngày {1}", _tuNgay, _denNgay);
            pDayNha.Value = "Dãy nhà: " + _dayNha;

            pNgayIn.Value = String.Format("TP.HCM, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", _ngayIn);

            DataSource = tb;
        }
    }
}
