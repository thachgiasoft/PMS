using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace ReportManager.GV
{
    public partial class rptBangThongKeGioCoiThiRaDeChamBai : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangThongKeGioCoiThiRaDeChamBai()
        {
            InitializeComponent();
        }

        public void InitData(string tenTruong, string namHoc, string hocKy, string loaigiangvien, string heDaoTao, string phongDaoTao, string nguoiLapBieu, DateTime ngayIn, DataTable data) 
        {
            pTruong.Value = tenTruong.ToUpper();
            pNamHoc.Value = namHoc;
            pHocKy.Value = hocKy;
            pLoaiGiangVien.Value = loaigiangvien;
            pTieuDe.Value = string.Format("{0} - NĂM HỌC {1}", hocKy.ToUpper(), namHoc);
            pPhongDaoTao.Value = phongDaoTao;
            pNguoiLapBieu.Value = nguoiLapBieu;
            pNgayIn.Value = string.Format("Lâm Đồng, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", ngayIn);
            DataSource = data;
        }
    }
}
