using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptBangThanhToanThuLaoTheoKhoa : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangThanhToanThuLaoTheoKhoa()
        {
            InitializeComponent();
        }
        public void InitData(string tentruong, string namhoc, string hocky, string tenkhoa, string phongdaotao, string nguoilapbieu, DataTable tb)
        { 
            
        }
    }
}
