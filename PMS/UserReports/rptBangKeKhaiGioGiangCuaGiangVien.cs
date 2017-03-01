using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptBangKeKhaiGioGiangCuaGiangVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangKeKhaiGioGiangCuaGiangVien()
        {
            InitializeComponent();
        }
        public void InitData(string tentruong, string namhoc, string hocky, string tenkhoa, string hoten, string tendonvi, string hocham, string hocvi, string masothue, string sotaikhoan, string chinhanh, string chucvu, bool giangvientrongtruong, DataTable tb)
        {
            pTruong.Value = tentruong.ToUpper();
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pTenDonVi.Value = tenkhoa;
            pHoTen.Value = hoten;
            pTenDonVi.Value = tendonvi;
            pTenHocHam.Value = hocham;
            pTenHocVi.Value = hocvi;
            pMaSoThue.Value = masothue;
            pSoTaiKhoan.Value = sotaikhoan;
            pChiNhanh.Value = chinhanh;
            pChucVu.Value = chucvu;
            bindingSourceThongKe.DataSource = tb;
            if (giangvientrongtruong)
            {
                pTextTrongNgoaiTruong.Value = "(DÀNH CHO CÁN BỘ GIẢNG DẠY TRONG TRƯỜNG)";
                GroupHeader3.Visible = false;
            }
            else
            {
                pTextTrongNgoaiTruong.Value = "(DÀNH CHO CÁN BỘ GIẢNG DẠY NGOÀI TRƯỜNG)";
                GroupHeader2.Visible = false;
            }
        }
    }
}
