using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptThongKeNghienCuuKhoaHoc : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttLoai = 0, _sttTen = 0;
        public rptThongKeNghienCuuKhoaHoc()
        {
            InitializeComponent();
        }

        public void InitData(string tenTruong, string namHoc, string nguoiLap, DateTime ngayIn, DataTable tb)
        {
            pTruong.Value = tenTruong.ToUpper();
            pNamHoc.Value = namHoc.ToUpper();
            pNguoiLapBieu.Value = nguoiLap;
            pNgayIn.Value = string.Format("TP. Hồ Chí Minh, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", ngayIn);
            this.DataSource = tb;
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttLoai++;
            xrTableCellSttLoaiNCKH.Text = PMS.Common.Globals.Char(_sttLoai.ToString(), true);
            _sttTen = 0;
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttTen++;
            xrTableCellSttTenNCKH.Text = PMS.Common.Globals.Roman(_sttTen, true);
        }
    }
}
