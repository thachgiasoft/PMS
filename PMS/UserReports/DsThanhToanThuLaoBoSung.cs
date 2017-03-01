using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class DsThanhToanThuLaoBoSung : DevExpress.XtraReports.UI.XtraReport
    {
        public DsThanhToanThuLaoBoSung()
        {
            InitializeComponent();
        }

        public void InitData(string tenTruong, string namHoc, string hocKy, string loaiGiangVien, string banGiamHieu, string phongKHTC, 
            string phongToChucCanBo, string phongDaoTao, string nguoiLapBieu, DataTable vList, DateTime ngayIn)
        {
            pTruong.Value = tenTruong;
            pNamHoc_HocKy.Value = hocKy + " - Năm học " + namHoc;
            pBanGiamHieu.Value = banGiamHieu;
            pPhongKHTC.Value = phongKHTC;
            pPhongTCCB.Value = phongToChucCanBo;
            pNguoiLapBieu.Value = nguoiLapBieu;
            pPhongDT.Value = phongDaoTao;
            pLoaiGiangVien.Value = "CBGD " + loaiGiangVien;
            this.DataSource = vList;
            pNgayIn.Value = String.Format("Ngày {0:dd} tháng {0:MM} năm {0:yyyy}", ngayIn);
        }
    }
}
