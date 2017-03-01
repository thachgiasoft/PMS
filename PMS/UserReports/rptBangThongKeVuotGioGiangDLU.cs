using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.GV
{
    public partial class rptBangThongKeVuotGioGiangDLU : DevExpress.XtraReports.UI.XtraReport
    {
        int _sttKhoa = 0;

        public rptBangThongKeVuotGioGiangDLU()
        {
            InitializeComponent();
            GroupField gf = new GroupField("TenDonVi");
            GroupHeader2.GroupFields.Add(gf);
        }

        public void InitData(string tenTruong, string namHoc, string hocKy, string tenDot, string phongDaoTao, string nguoiLapBieu, DateTime ngayIn, DataTable data) 
        {
            pTruong.Value = tenTruong.ToUpper();
            pTieuDe.Value = string.Format("BẢNG THANH TOÁN GIỜ GIẢNG HỌC KỲ III - NĂM HỌC {0}", namHoc);
            pPhongDaoTao.Value = phongDaoTao;
            pNguoiLapBieu.Value = nguoiLapBieu;
            pNgayIn.Value = string.Format("Đà Lạt, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", ngayIn);
            DataSource = data;
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _sttKhoa++;
            lblSttKhoa.Text = PMS.Common.Globals.Roman(_sttKhoa, true);
        }
    }
}

