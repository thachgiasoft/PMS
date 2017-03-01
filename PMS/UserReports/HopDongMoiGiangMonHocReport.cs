using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;
using System.Data;

namespace PMS.UserReports
{
    public partial class HopDongMoiGiangMonHocReport : DevExpress.XtraReports.UI.XtraReport
    {
        public HopDongMoiGiangMonHocReport()
        {
            InitializeComponent();
        }

        public void InitData(ViewDanhSachHopDongThinhGiang _objHopDong, DateTime _ngayIn, string _nguoiDaiDien, string _tenChucVu, GiangVien _objGiangVien, string _coSo, string _diaChiCoSo, string _tenLop)
        {
            
            pSoHopDong.Value = String.Format("Số: {0}/HĐMG", _objHopDong.SoHopDong);
            pNgayIn.Value = "TP. Hồ Chí Minh, ngày " + _ngayIn.ToString("dd") + " tháng " + _ngayIn.ToString("MM") + " năm " + _ngayIn.ToString("yyyy");
            pNguoiDaiDien.Value = _nguoiDaiDien;
            pChucVu.Value = _tenChucVu;
            pBenB.Value = _objHopDong.HoTen;

            string _hhHv = "";
            if (_objHopDong.MaHocHam != 18 && _objHopDong.MaHocHam != 21)//Khác giáo sư và phó giáo sư
                _hhHv = _objHopDong.TenHocVi;
            else
            {
                if (_objHopDong.TenHocVi != "")
                    _hhHv = String.Format("{0} - {1}", _objHopDong.TenHocHam, _objHopDong.TenHocVi);
                else
                    _hhHv = _objHopDong.TenHocHam;
            }
            pHocHamHocVi.Value = _hhHv;

            pCMND.Value = _objHopDong.SoCmnd;
            pNoiCap.Value = _objGiangVien.NoiCap;
            pNgayCap.Value = _objGiangVien.NgayCap;
            pDiaChi.Value = _objGiangVien.DiaChi;
            pDienThoai.Value = _objGiangVien.DienThoai;
            pDiDong.Value = _objGiangVien.SoDiDong;
            pQuocTich.Value = "Việt Nam";
            pMaSoThue.Value = _objHopDong.MaSoThue;
            pTenMonHoc.Value = _objHopDong.TenMonHoc;
            pDonViMoiGiang.Value = String.Format("{0} - {1}", _objHopDong.TenDonVi, _coSo);
            pLop.Value = _tenLop;
            pSiSo.Value = _objHopDong.SiSo.ToString() + " SV";
            pTietQuyDoi.Value = _objHopDong.TongSoTiet.ToString();
            pTietQuyDoi2.Value = _objHopDong.TongSoTiet.ToString();
            pTietLyThuyet.Value = _objHopDong.SoTietLyThuyet.ToString() + " tiết";
            pTietThucHanh.Value = _objHopDong.SoTietThucHanh.ToString() + " tiết";
            pHeSoThucHanh.Value = _objHopDong.HeSoQuyDoiThucHanh;
            pHeSoLopDong.Value = _objHopDong.HeSoLopDong;
            pTuNgay.Value = ((DateTime)_objHopDong.NgayBatDau).ToString("dd/MM/yyyy");
            pDenNgay.Value = ((DateTime)_objHopDong.NgayKetThuc).ToString("dd/MM/yyyy");
            pMaGiangVien.Value = _objGiangVien.MaQuanLy;
            try
            {
                pDonGia.Value = ((decimal)PMS.Common.Globals.IsNull(_objHopDong.DonGia, "decimal")).ToString("n0");
            }
            catch
            {
                pDonGia.Value = 0;
            }

            try
            {
                pThanhTien.Value = ((decimal)PMS.Common.Globals.IsNull(_objHopDong.TongGiaTriHopDong, "decimal")).ToString("n0");
            }
            catch
            {
                pThanhTien.Value = 0;
            }

            pCoSo.Value = _coSo;

            if (_diaChiCoSo == "")
                pDiaChiCoSo.Value = "12 Nguyễn Văn Bảo, P4, Q GV, TP.HCM";
            else
                pDiaChiCoSo.Value = _diaChiCoSo;
        }

        string ReplaceDot(string s)
        {
            if (s.Contains(",") == true)
            {
                s = s.Replace(",", ".");
            }
            return s;
        }
    }
}
