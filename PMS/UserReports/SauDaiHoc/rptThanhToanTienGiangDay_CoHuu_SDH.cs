using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports.SauDaiHoc
{
    public partial class rptThanhToanTienGiangDay_CoHuu_SDH : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThanhToanTienGiangDay_CoHuu_SDH()
        {
            InitializeComponent();
        }
        public void InitData(string truong, string namHoc, string hocKy, string loaiGiangVien, string khoa, string nganh, string nguoiLapBieu, string phongDaoTao, string banGiamHieu, DateTime _ngayIn, DataTable data)
        {
            pTruong.Value = truong.ToUpper();
            pTieuDe.Value = String.Format("THANH TOÁN TIỀN GIẢNG DẠY, CHẤM BÀI SAU ĐẠI HỌC_{0}/{1} (GV {2})\nNGÀNH: {3}_{4}", hocKy, namHoc, loaiGiangVien, nganh, khoa).ToUpper();
            pNguoiLapBieu.Value = nguoiLapBieu;
            pPhongDaoTao.Value = phongDaoTao;
            pBanGiamHieu.Value = banGiamHieu;
            this.DataSource = data;

            pNgayIn.Value = string.Format("TP. Hồ Chí Minh, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", _ngayIn);
        }
    }
}
