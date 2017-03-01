using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThanhToanPhuCapGDTC : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThanhToanPhuCapGDTC()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string namhoc, string hocky, string nguoilapbieu, string kiemsoat, DateTime ngayin, DataTable tb)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky.ToUpper();
            pNguoiLapBang.Value = nguoilapbieu;
            pKiemSoat.Value = kiemsoat;
            lblNgayIn.Text = String.Format("TP. Hồ Chí Minh, ngày {0:dd} tháng {1:MM} năm {2:yyyy}", ngayin, ngayin, ngayin);
            DataSource = tb;
        }
    }
}
