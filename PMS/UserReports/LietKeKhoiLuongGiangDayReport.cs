using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;

namespace PMS.UserReports
{
    public partial class LietKeKhoiLuongGiangDayReport : DevExpress.XtraReports.UI.XtraReport
    {
        public LietKeKhoiLuongGiangDayReport()
        {
            InitializeComponent();
        }

        public void InitData(string truong, string nguoiLapBieu, string namHoc, string hocKy, string donVi,string tenGiangVien, string hocVi,double soTienNghiaVu,double soTienGiangDay,double soTienDAMH,double soTienThucLanh,string soTienBangChu,int tietnghiavu,VList<ViewChiTietKhoiLuong> vList)
        {
            pTruong.Value = truong;
            pNguoiLapBieu.Value = nguoiLapBieu;
            pNamHoc.Value = namHoc;
            pHocKy.Value = hocKy;
            pTenGV.Value = tenGiangVien;
            pHocVi.Value = hocVi;
            pDonVi.Value = donVi;
            SoTienNghiaVu.Value = soTienNghiaVu;
            SoTienGiangDay.Value = soTienGiangDay;
            SoTienDAMH_LA.Value = soTienDAMH;
            SoTienThucLanh.Value = soTienThucLanh;
            SoTienBangChu.Value = soTienBangChu;
            SoTien.Value = soTienBangChu;
            this.TietNghiaVu.Value = tietnghiavu;
            bindingSourceChiTietKhoiLuong.DataSource = vList;
        }
    }
}
