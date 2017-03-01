using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;
using System.Data;

namespace PMS.UserReports.SauDaiHoc
{
    public partial class rptTongHopThanhToanThuLao_SDH : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTongHopThanhToanThuLao_SDH()
        {
            InitializeComponent();
        }
        public void InitData(string truong, string namHoc, string hocKy, string loaiGiangVien, string lanChot, string nguoiLapBieu, string phongDaoTao, DateTime _ngayIn, DataTable data)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namHoc;
            pHocKy.Value = hocKy;
            pLoaiGiangVien.Value = loaiGiangVien.ToUpper();
            pLanChot.Value = lanChot;
            pNguoiLapBieu.Value = nguoiLapBieu;
            pPhongDaoTao.Value = phongDaoTao;
            bindingSourceBaoCao.DataSource = data;

            lblNgayIn.Text = string.Format("TP. Hồ Chí Minh, ngày {0:dd} tháng {0:MM} năm {0:yyyy}", _ngayIn);
        }
    }
}
