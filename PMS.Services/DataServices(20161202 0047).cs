#region Using directives
using System;
using System.ComponentModel;
using PMS.Entities;
using PMS.Data;
#endregion Using directives

namespace PMS.Services
{
    /// <summary>
    /// An component type implementation of the table. 
    /// </summary>
	public static class DataServices
	{		
    
        #region BangPhuTroiGioDayGiangVienService
        private static BangPhuTroiGioDayGiangVienService _BangPhuTroiGioDayGiangVienService;
        /// <summary>
		/// Initializes a new instance of the BangPhuTroiGioDayGiangVienService class.
		/// </summary>
        public static BangPhuTroiGioDayGiangVienService BangPhuTroiGioDayGiangVien
        {
            get
            {
                if(_BangPhuTroiGioDayGiangVienService == null)
                    _BangPhuTroiGioDayGiangVienService = new BangPhuTroiGioDayGiangVienService();
                return _BangPhuTroiGioDayGiangVienService;
            }
        }
        #endregion        
    
        #region DanhMucGioGiangService
        private static DanhMucGioGiangService _DanhMucGioGiangService;
        /// <summary>
		/// Initializes a new instance of the DanhMucGioGiangService class.
		/// </summary>
        public static DanhMucGioGiangService DanhMucGioGiang
        {
            get
            {
                if(_DanhMucGioGiangService == null)
                    _DanhMucGioGiangService = new DanhMucGioGiangService();
                return _DanhMucGioGiangService;
            }
        }
        #endregion        
    
        #region TcbKetQuaQuyDoiService
        private static TcbKetQuaQuyDoiService _TcbKetQuaQuyDoiService;
        /// <summary>
		/// Initializes a new instance of the TcbKetQuaQuyDoiService class.
		/// </summary>
        public static TcbKetQuaQuyDoiService TcbKetQuaQuyDoi
        {
            get
            {
                if(_TcbKetQuaQuyDoiService == null)
                    _TcbKetQuaQuyDoiService = new TcbKetQuaQuyDoiService();
                return _TcbKetQuaQuyDoiService;
            }
        }
        #endregion        
    
        #region MucDoHoanThanhNckhService
        private static MucDoHoanThanhNckhService _MucDoHoanThanhNckhService;
        /// <summary>
		/// Initializes a new instance of the MucDoHoanThanhNckhService class.
		/// </summary>
        public static MucDoHoanThanhNckhService MucDoHoanThanhNckh
        {
            get
            {
                if(_MucDoHoanThanhNckhService == null)
                    _MucDoHoanThanhNckhService = new MucDoHoanThanhNckhService();
                return _MucDoHoanThanhNckhService;
            }
        }
        #endregion        
    
        #region MonKhongTinhService
        private static MonKhongTinhService _MonKhongTinhService;
        /// <summary>
		/// Initializes a new instance of the MonKhongTinhService class.
		/// </summary>
        public static MonKhongTinhService MonKhongTinh
        {
            get
            {
                if(_MonKhongTinhService == null)
                    _MonKhongTinhService = new MonKhongTinhService();
                return _MonKhongTinhService;
            }
        }
        #endregion        
    
        #region QuyDinhTienCanTrenService
        private static QuyDinhTienCanTrenService _QuyDinhTienCanTrenService;
        /// <summary>
		/// Initializes a new instance of the QuyDinhTienCanTrenService class.
		/// </summary>
        public static QuyDinhTienCanTrenService QuyDinhTienCanTren
        {
            get
            {
                if(_QuyDinhTienCanTrenService == null)
                    _QuyDinhTienCanTrenService = new QuyDinhTienCanTrenService();
                return _QuyDinhTienCanTrenService;
            }
        }
        #endregion        
    
        #region NamHocService
        private static NamHocService _NamHocService;
        /// <summary>
		/// Initializes a new instance of the NamHocService class.
		/// </summary>
        public static NamHocService NamHoc
        {
            get
            {
                if(_NamHocService == null)
                    _NamHocService = new NamHocService();
                return _NamHocService;
            }
        }
        #endregion        
    
        #region NgonNguGiangDayService
        private static NgonNguGiangDayService _NgonNguGiangDayService;
        /// <summary>
		/// Initializes a new instance of the NgonNguGiangDayService class.
		/// </summary>
        public static NgonNguGiangDayService NgonNguGiangDay
        {
            get
            {
                if(_NgonNguGiangDayService == null)
                    _NgonNguGiangDayService = new NgonNguGiangDayService();
                return _NgonNguGiangDayService;
            }
        }
        #endregion        
    
        #region MonHocKhongTinhKhoiLuongService
        private static MonHocKhongTinhKhoiLuongService _MonHocKhongTinhKhoiLuongService;
        /// <summary>
		/// Initializes a new instance of the MonHocKhongTinhKhoiLuongService class.
		/// </summary>
        public static MonHocKhongTinhKhoiLuongService MonHocKhongTinhKhoiLuong
        {
            get
            {
                if(_MonHocKhongTinhKhoiLuongService == null)
                    _MonHocKhongTinhKhoiLuongService = new MonHocKhongTinhKhoiLuongService();
                return _MonHocKhongTinhKhoiLuongService;
            }
        }
        #endregion        
    
        #region NghienCuuKhoaHocService
        private static NghienCuuKhoaHocService _NghienCuuKhoaHocService;
        /// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocService class.
		/// </summary>
        public static NghienCuuKhoaHocService NghienCuuKhoaHoc
        {
            get
            {
                if(_NghienCuuKhoaHocService == null)
                    _NghienCuuKhoaHocService = new NghienCuuKhoaHocService();
                return _NghienCuuKhoaHocService;
            }
        }
        #endregion        
    
        #region PhanLoaiGiangVienService
        private static PhanLoaiGiangVienService _PhanLoaiGiangVienService;
        /// <summary>
		/// Initializes a new instance of the PhanLoaiGiangVienService class.
		/// </summary>
        public static PhanLoaiGiangVienService PhanLoaiGiangVien
        {
            get
            {
                if(_PhanLoaiGiangVienService == null)
                    _PhanLoaiGiangVienService = new PhanLoaiGiangVienService();
                return _PhanLoaiGiangVienService;
            }
        }
        #endregion        
    
        #region NhomChucNangService
        private static NhomChucNangService _NhomChucNangService;
        /// <summary>
		/// Initializes a new instance of the NhomChucNangService class.
		/// </summary>
        public static NhomChucNangService NhomChucNang
        {
            get
            {
                if(_NhomChucNangService == null)
                    _NhomChucNangService = new NhomChucNangService();
                return _NhomChucNangService;
            }
        }
        #endregion        
    
        #region MonHocCoNganHangDeThiService
        private static MonHocCoNganHangDeThiService _MonHocCoNganHangDeThiService;
        /// <summary>
		/// Initializes a new instance of the MonHocCoNganHangDeThiService class.
		/// </summary>
        public static MonHocCoNganHangDeThiService MonHocCoNganHangDeThi
        {
            get
            {
                if(_MonHocCoNganHangDeThiService == null)
                    _MonHocCoNganHangDeThiService = new MonHocCoNganHangDeThiService();
                return _MonHocCoNganHangDeThiService;
            }
        }
        #endregion        
    
        #region NhomKhoiLuongService
        private static NhomKhoiLuongService _NhomKhoiLuongService;
        /// <summary>
		/// Initializes a new instance of the NhomKhoiLuongService class.
		/// </summary>
        public static NhomKhoiLuongService NhomKhoiLuong
        {
            get
            {
                if(_NhomKhoiLuongService == null)
                    _NhomKhoiLuongService = new NhomKhoiLuongService();
                return _NhomKhoiLuongService;
            }
        }
        #endregion        
    
        #region MonThucTapTotNghiepService
        private static MonThucTapTotNghiepService _MonThucTapTotNghiepService;
        /// <summary>
		/// Initializes a new instance of the MonThucTapTotNghiepService class.
		/// </summary>
        public static MonThucTapTotNghiepService MonThucTapTotNghiep
        {
            get
            {
                if(_MonThucTapTotNghiepService == null)
                    _MonThucTapTotNghiepService = new MonThucTapTotNghiepService();
                return _MonThucTapTotNghiepService;
            }
        }
        #endregion        
    
        #region NhomHoatDongNgoaiGiangDayService
        private static NhomHoatDongNgoaiGiangDayService _NhomHoatDongNgoaiGiangDayService;
        /// <summary>
		/// Initializes a new instance of the NhomHoatDongNgoaiGiangDayService class.
		/// </summary>
        public static NhomHoatDongNgoaiGiangDayService NhomHoatDongNgoaiGiangDay
        {
            get
            {
                if(_NhomHoatDongNgoaiGiangDayService == null)
                    _NhomHoatDongNgoaiGiangDayService = new NhomHoatDongNgoaiGiangDayService();
                return _NhomHoatDongNgoaiGiangDayService;
            }
        }
        #endregion        
    
        #region NamHocHienThiThuLaoLenWebService
        private static NamHocHienThiThuLaoLenWebService _NamHocHienThiThuLaoLenWebService;
        /// <summary>
		/// Initializes a new instance of the NamHocHienThiThuLaoLenWebService class.
		/// </summary>
        public static NamHocHienThiThuLaoLenWebService NamHocHienThiThuLaoLenWeb
        {
            get
            {
                if(_NamHocHienThiThuLaoLenWebService == null)
                    _NamHocHienThiThuLaoLenWebService = new NamHocHienThiThuLaoLenWebService();
                return _NamHocHienThiThuLaoLenWebService;
            }
        }
        #endregion        
    
        #region MonXepLichChuNhatKhongTinhHeSoService
        private static MonXepLichChuNhatKhongTinhHeSoService _MonXepLichChuNhatKhongTinhHeSoService;
        /// <summary>
		/// Initializes a new instance of the MonXepLichChuNhatKhongTinhHeSoService class.
		/// </summary>
        public static MonXepLichChuNhatKhongTinhHeSoService MonXepLichChuNhatKhongTinhHeSo
        {
            get
            {
                if(_MonXepLichChuNhatKhongTinhHeSoService == null)
                    _MonXepLichChuNhatKhongTinhHeSoService = new MonXepLichChuNhatKhongTinhHeSoService();
                return _MonXepLichChuNhatKhongTinhHeSoService;
            }
        }
        #endregion        
    
        #region PhuCapHanhChinhService
        private static PhuCapHanhChinhService _PhuCapHanhChinhService;
        /// <summary>
		/// Initializes a new instance of the PhuCapHanhChinhService class.
		/// </summary>
        public static PhuCapHanhChinhService PhuCapHanhChinh
        {
            get
            {
                if(_PhuCapHanhChinhService == null)
                    _PhuCapHanhChinhService = new PhuCapHanhChinhService();
                return _PhuCapHanhChinhService;
            }
        }
        #endregion        
    
        #region PhanCongDoAnTotNghiepService
        private static PhanCongDoAnTotNghiepService _PhanCongDoAnTotNghiepService;
        /// <summary>
		/// Initializes a new instance of the PhanCongDoAnTotNghiepService class.
		/// </summary>
        public static PhanCongDoAnTotNghiepService PhanCongDoAnTotNghiep
        {
            get
            {
                if(_PhanCongDoAnTotNghiepService == null)
                    _PhanCongDoAnTotNghiepService = new PhanCongDoAnTotNghiepService();
                return _PhanCongDoAnTotNghiepService;
            }
        }
        #endregion        
    
        #region NoiDungDanhGiaService
        private static NoiDungDanhGiaService _NoiDungDanhGiaService;
        /// <summary>
		/// Initializes a new instance of the NoiDungDanhGiaService class.
		/// </summary>
        public static NoiDungDanhGiaService NoiDungDanhGia
        {
            get
            {
                if(_NoiDungDanhGiaService == null)
                    _NoiDungDanhGiaService = new NoiDungDanhGiaService();
                return _NoiDungDanhGiaService;
            }
        }
        #endregion        
    
        #region NhomQuyenService
        private static NhomQuyenService _NhomQuyenService;
        /// <summary>
		/// Initializes a new instance of the NhomQuyenService class.
		/// </summary>
        public static NhomQuyenService NhomQuyen
        {
            get
            {
                if(_NhomQuyenService == null)
                    _NhomQuyenService = new NhomQuyenService();
                return _NhomQuyenService;
            }
        }
        #endregion        
    
        #region ThuLaoRaDeThiVhuexService
        private static ThuLaoRaDeThiVhuexService _ThuLaoRaDeThiVhuexService;
        /// <summary>
		/// Initializes a new instance of the ThuLaoRaDeThiVhuexService class.
		/// </summary>
        public static ThuLaoRaDeThiVhuexService ThuLaoRaDeThiVhuex
        {
            get
            {
                if(_ThuLaoRaDeThiVhuexService == null)
                    _ThuLaoRaDeThiVhuexService = new ThuLaoRaDeThiVhuexService();
                return _ThuLaoRaDeThiVhuexService;
            }
        }
        #endregion        
    
        #region TrinhDoChinhTriService
        private static TrinhDoChinhTriService _TrinhDoChinhTriService;
        /// <summary>
		/// Initializes a new instance of the TrinhDoChinhTriService class.
		/// </summary>
        public static TrinhDoChinhTriService TrinhDoChinhTri
        {
            get
            {
                if(_TrinhDoChinhTriService == null)
                    _TrinhDoChinhTriService = new TrinhDoChinhTriService();
                return _TrinhDoChinhTriService;
            }
        }
        #endregion        
    
        #region NhomMonHocService
        private static NhomMonHocService _NhomMonHocService;
        /// <summary>
		/// Initializes a new instance of the NhomMonHocService class.
		/// </summary>
        public static NhomMonHocService NhomMonHoc
        {
            get
            {
                if(_NhomMonHocService == null)
                    _NhomMonHocService = new NhomMonHocService();
                return _NhomMonHocService;
            }
        }
        #endregion        
    
        #region PscUserConfigApplicationService
        private static PscUserConfigApplicationService _PscUserConfigApplicationService;
        /// <summary>
		/// Initializes a new instance of the PscUserConfigApplicationService class.
		/// </summary>
        public static PscUserConfigApplicationService PscUserConfigApplication
        {
            get
            {
                if(_PscUserConfigApplicationService == null)
                    _PscUserConfigApplicationService = new PscUserConfigApplicationService();
                return _PscUserConfigApplicationService;
            }
        }
        #endregion        
    
        #region TrinhDoNgoaiNguService
        private static TrinhDoNgoaiNguService _TrinhDoNgoaiNguService;
        /// <summary>
		/// Initializes a new instance of the TrinhDoNgoaiNguService class.
		/// </summary>
        public static TrinhDoNgoaiNguService TrinhDoNgoaiNgu
        {
            get
            {
                if(_TrinhDoNgoaiNguService == null)
                    _TrinhDoNgoaiNguService = new TrinhDoNgoaiNguService();
                return _TrinhDoNgoaiNguService;
            }
        }
        #endregion        
    
        #region PscDotThanhToanCoiThiChamThiService
        private static PscDotThanhToanCoiThiChamThiService _PscDotThanhToanCoiThiChamThiService;
        /// <summary>
		/// Initializes a new instance of the PscDotThanhToanCoiThiChamThiService class.
		/// </summary>
        public static PscDotThanhToanCoiThiChamThiService PscDotThanhToanCoiThiChamThi
        {
            get
            {
                if(_PscDotThanhToanCoiThiChamThiService == null)
                    _PscDotThanhToanCoiThiChamThiService = new PscDotThanhToanCoiThiChamThiService();
                return _PscDotThanhToanCoiThiChamThiService;
            }
        }
        #endregion        
    
        #region MonHocTinhHeSoKhoiNganhService
        private static MonHocTinhHeSoKhoiNganhService _MonHocTinhHeSoKhoiNganhService;
        /// <summary>
		/// Initializes a new instance of the MonHocTinhHeSoKhoiNganhService class.
		/// </summary>
        public static MonHocTinhHeSoKhoiNganhService MonHocTinhHeSoKhoiNganh
        {
            get
            {
                if(_MonHocTinhHeSoKhoiNganhService == null)
                    _MonHocTinhHeSoKhoiNganhService = new MonHocTinhHeSoKhoiNganhService();
                return _MonHocTinhHeSoKhoiNganhService;
            }
        }
        #endregion        
    
        #region QuocTichService
        private static QuocTichService _QuocTichService;
        /// <summary>
		/// Initializes a new instance of the QuocTichService class.
		/// </summary>
        public static QuocTichService QuocTich
        {
            get
            {
                if(_QuocTichService == null)
                    _QuocTichService = new QuocTichService();
                return _QuocTichService;
            }
        }
        #endregion        
    
        #region PscExBarCodesService
        private static PscExBarCodesService _PscExBarCodesService;
        /// <summary>
		/// Initializes a new instance of the PscExBarCodesService class.
		/// </summary>
        public static PscExBarCodesService PscExBarCodes
        {
            get
            {
                if(_PscExBarCodesService == null)
                    _PscExBarCodesService = new PscExBarCodesService();
                return _PscExBarCodesService;
            }
        }
        #endregion        
    
        #region ThuLaoCoiThiVhuexService
        private static ThuLaoCoiThiVhuexService _ThuLaoCoiThiVhuexService;
        /// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuexService class.
		/// </summary>
        public static ThuLaoCoiThiVhuexService ThuLaoCoiThiVhuex
        {
            get
            {
                if(_ThuLaoCoiThiVhuexService == null)
                    _ThuLaoCoiThiVhuexService = new ThuLaoCoiThiVhuexService();
                return _ThuLaoCoiThiVhuexService;
            }
        }
        #endregion        
    
        #region PhanBienLuanAnService
        private static PhanBienLuanAnService _PhanBienLuanAnService;
        /// <summary>
		/// Initializes a new instance of the PhanBienLuanAnService class.
		/// </summary>
        public static PhanBienLuanAnService PhanBienLuanAn
        {
            get
            {
                if(_PhanBienLuanAnService == null)
                    _PhanBienLuanAnService = new PhanBienLuanAnService();
                return _PhanBienLuanAnService;
            }
        }
        #endregion        
    
        #region PhanNhomMonHocService
        private static PhanNhomMonHocService _PhanNhomMonHocService;
        /// <summary>
		/// Initializes a new instance of the PhanNhomMonHocService class.
		/// </summary>
        public static PhanNhomMonHocService PhanNhomMonHoc
        {
            get
            {
                if(_PhanNhomMonHocService == null)
                    _PhanNhomMonHocService = new PhanNhomMonHocService();
                return _PhanNhomMonHocService;
            }
        }
        #endregion        
    
        #region MonTieuLuanService
        private static MonTieuLuanService _MonTieuLuanService;
        /// <summary>
		/// Initializes a new instance of the MonTieuLuanService class.
		/// </summary>
        public static MonTieuLuanService MonTieuLuan
        {
            get
            {
                if(_MonTieuLuanService == null)
                    _MonTieuLuanService = new MonTieuLuanService();
                return _MonTieuLuanService;
            }
        }
        #endregion        
    
        #region NoiDungCongViecQuanLyService
        private static NoiDungCongViecQuanLyService _NoiDungCongViecQuanLyService;
        /// <summary>
		/// Initializes a new instance of the NoiDungCongViecQuanLyService class.
		/// </summary>
        public static NoiDungCongViecQuanLyService NoiDungCongViecQuanLy
        {
            get
            {
                if(_NoiDungCongViecQuanLyService == null)
                    _NoiDungCongViecQuanLyService = new NoiDungCongViecQuanLyService();
                return _NoiDungCongViecQuanLyService;
            }
        }
        #endregion        
    
        #region KhoiLuongGiangDayChiTietService
        private static KhoiLuongGiangDayChiTietService _KhoiLuongGiangDayChiTietService;
        /// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayChiTietService class.
		/// </summary>
        public static KhoiLuongGiangDayChiTietService KhoiLuongGiangDayChiTiet
        {
            get
            {
                if(_KhoiLuongGiangDayChiTietService == null)
                    _KhoiLuongGiangDayChiTietService = new KhoiLuongGiangDayChiTietService();
                return _KhoiLuongGiangDayChiTietService;
            }
        }
        #endregion        
    
        #region LoaiKhoiLuongService
        private static LoaiKhoiLuongService _LoaiKhoiLuongService;
        /// <summary>
		/// Initializes a new instance of the LoaiKhoiLuongService class.
		/// </summary>
        public static LoaiKhoiLuongService LoaiKhoiLuong
        {
            get
            {
                if(_LoaiKhoiLuongService == null)
                    _LoaiKhoiLuongService = new LoaiKhoiLuongService();
                return _LoaiKhoiLuongService;
            }
        }
        #endregion        
    
        #region MonTinhTheoQuyCheMoiService
        private static MonTinhTheoQuyCheMoiService _MonTinhTheoQuyCheMoiService;
        /// <summary>
		/// Initializes a new instance of the MonTinhTheoQuyCheMoiService class.
		/// </summary>
        public static MonTinhTheoQuyCheMoiService MonTinhTheoQuyCheMoi
        {
            get
            {
                if(_MonTinhTheoQuyCheMoiService == null)
                    _MonTinhTheoQuyCheMoiService = new MonTinhTheoQuyCheMoiService();
                return _MonTinhTheoQuyCheMoiService;
            }
        }
        #endregion        
    
        #region MonGiangMoiService
        private static MonGiangMoiService _MonGiangMoiService;
        /// <summary>
		/// Initializes a new instance of the MonGiangMoiService class.
		/// </summary>
        public static MonGiangMoiService MonGiangMoi
        {
            get
            {
                if(_MonGiangMoiService == null)
                    _MonGiangMoiService = new MonGiangMoiService();
                return _MonGiangMoiService;
            }
        }
        #endregion        
    
        #region KhoiLuongHuongDanThucTapService
        private static KhoiLuongHuongDanThucTapService _KhoiLuongHuongDanThucTapService;
        /// <summary>
		/// Initializes a new instance of the KhoiLuongHuongDanThucTapService class.
		/// </summary>
        public static KhoiLuongHuongDanThucTapService KhoiLuongHuongDanThucTap
        {
            get
            {
                if(_KhoiLuongHuongDanThucTapService == null)
                    _KhoiLuongHuongDanThucTapService = new KhoiLuongHuongDanThucTapService();
                return _KhoiLuongHuongDanThucTapService;
            }
        }
        #endregion        
    
        #region LoaiNghienCuuKhoaHocService
        private static LoaiNghienCuuKhoaHocService _LoaiNghienCuuKhoaHocService;
        /// <summary>
		/// Initializes a new instance of the LoaiNghienCuuKhoaHocService class.
		/// </summary>
        public static LoaiNghienCuuKhoaHocService LoaiNghienCuuKhoaHoc
        {
            get
            {
                if(_LoaiNghienCuuKhoaHocService == null)
                    _LoaiNghienCuuKhoaHocService = new LoaiNghienCuuKhoaHocService();
                return _LoaiNghienCuuKhoaHocService;
            }
        }
        #endregion        
    
        #region KhoiLuongQuyDoiCaoDangService
        private static KhoiLuongQuyDoiCaoDangService _KhoiLuongQuyDoiCaoDangService;
        /// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiCaoDangService class.
		/// </summary>
        public static KhoiLuongQuyDoiCaoDangService KhoiLuongQuyDoiCaoDang
        {
            get
            {
                if(_KhoiLuongQuyDoiCaoDangService == null)
                    _KhoiLuongQuyDoiCaoDangService = new KhoiLuongQuyDoiCaoDangService();
                return _KhoiLuongQuyDoiCaoDangService;
            }
        }
        #endregion        
    
        #region KhoiLuongTamUngService
        private static KhoiLuongTamUngService _KhoiLuongTamUngService;
        /// <summary>
		/// Initializes a new instance of the KhoiLuongTamUngService class.
		/// </summary>
        public static KhoiLuongTamUngService KhoiLuongTamUng
        {
            get
            {
                if(_KhoiLuongTamUngService == null)
                    _KhoiLuongTamUngService = new KhoiLuongTamUngService();
                return _KhoiLuongTamUngService;
            }
        }
        #endregion        
    
        #region KhoiLuongGiangDayTungTuanService
        private static KhoiLuongGiangDayTungTuanService _KhoiLuongGiangDayTungTuanService;
        /// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTungTuanService class.
		/// </summary>
        public static KhoiLuongGiangDayTungTuanService KhoiLuongGiangDayTungTuan
        {
            get
            {
                if(_KhoiLuongGiangDayTungTuanService == null)
                    _KhoiLuongGiangDayTungTuanService = new KhoiLuongGiangDayTungTuanService();
                return _KhoiLuongGiangDayTungTuanService;
            }
        }
        #endregion        
    
        #region KhoiLuongQuyDoiService
        private static KhoiLuongQuyDoiService _KhoiLuongQuyDoiService;
        /// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiService class.
		/// </summary>
        public static KhoiLuongQuyDoiService KhoiLuongQuyDoi
        {
            get
            {
                if(_KhoiLuongQuyDoiService == null)
                    _KhoiLuongQuyDoiService = new KhoiLuongQuyDoiService();
                return _KhoiLuongQuyDoiService;
            }
        }
        #endregion        
    
        #region LopHocPhanChuyenNganhService
        private static LopHocPhanChuyenNganhService _LopHocPhanChuyenNganhService;
        /// <summary>
		/// Initializes a new instance of the LopHocPhanChuyenNganhService class.
		/// </summary>
        public static LopHocPhanChuyenNganhService LopHocPhanChuyenNganh
        {
            get
            {
                if(_LopHocPhanChuyenNganhService == null)
                    _LopHocPhanChuyenNganhService = new LopHocPhanChuyenNganhService();
                return _LopHocPhanChuyenNganhService;
            }
        }
        #endregion        
    
        #region KhoiLuongGiangDayDoAnTotNghiepService
        private static KhoiLuongGiangDayDoAnTotNghiepService _KhoiLuongGiangDayDoAnTotNghiepService;
        /// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnTotNghiepService class.
		/// </summary>
        public static KhoiLuongGiangDayDoAnTotNghiepService KhoiLuongGiangDayDoAnTotNghiep
        {
            get
            {
                if(_KhoiLuongGiangDayDoAnTotNghiepService == null)
                    _KhoiLuongGiangDayDoAnTotNghiepService = new KhoiLuongGiangDayDoAnTotNghiepService();
                return _KhoiLuongGiangDayDoAnTotNghiepService;
            }
        }
        #endregion        
    
        #region ThangHeService
        private static ThangHeService _ThangHeService;
        /// <summary>
		/// Initializes a new instance of the ThangHeService class.
		/// </summary>
        public static ThangHeService ThangHe
        {
            get
            {
                if(_ThangHeService == null)
                    _ThangHeService = new ThangHeService();
                return _ThangHeService;
            }
        }
        #endregion        
    
        #region KyTinhLuongService
        private static KyTinhLuongService _KyTinhLuongService;
        /// <summary>
		/// Initializes a new instance of the KyTinhLuongService class.
		/// </summary>
        public static KyTinhLuongService KyTinhLuong
        {
            get
            {
                if(_KyTinhLuongService == null)
                    _KyTinhLuongService = new KyTinhLuongService();
                return _KyTinhLuongService;
            }
        }
        #endregion        
    
        #region KetQuaDanhGiaVuotGioService
        private static KetQuaDanhGiaVuotGioService _KetQuaDanhGiaVuotGioService;
        /// <summary>
		/// Initializes a new instance of the KetQuaDanhGiaVuotGioService class.
		/// </summary>
        public static KetQuaDanhGiaVuotGioService KetQuaDanhGiaVuotGio
        {
            get
            {
                if(_KetQuaDanhGiaVuotGioService == null)
                    _KetQuaDanhGiaVuotGioService = new KetQuaDanhGiaVuotGioService();
                return _KetQuaDanhGiaVuotGioService;
            }
        }
        #endregion        
    
        #region KhoiLuongDoAnTotNghiepChiTietService
        private static KhoiLuongDoAnTotNghiepChiTietService _KhoiLuongDoAnTotNghiepChiTietService;
        /// <summary>
		/// Initializes a new instance of the KhoiLuongDoAnTotNghiepChiTietService class.
		/// </summary>
        public static KhoiLuongDoAnTotNghiepChiTietService KhoiLuongDoAnTotNghiepChiTiet
        {
            get
            {
                if(_KhoiLuongDoAnTotNghiepChiTietService == null)
                    _KhoiLuongDoAnTotNghiepChiTietService = new KhoiLuongDoAnTotNghiepChiTietService();
                return _KhoiLuongDoAnTotNghiepChiTietService;
            }
        }
        #endregion        
    
        #region MonPhanCongNhieuGiangVienService
        private static MonPhanCongNhieuGiangVienService _MonPhanCongNhieuGiangVienService;
        /// <summary>
		/// Initializes a new instance of the MonPhanCongNhieuGiangVienService class.
		/// </summary>
        public static MonPhanCongNhieuGiangVienService MonPhanCongNhieuGiangVien
        {
            get
            {
                if(_MonPhanCongNhieuGiangVienService == null)
                    _MonPhanCongNhieuGiangVienService = new MonPhanCongNhieuGiangVienService();
                return _MonPhanCongNhieuGiangVienService;
            }
        }
        #endregion        
    
        #region KetQuaTinhTheoTuanService
        private static KetQuaTinhTheoTuanService _KetQuaTinhTheoTuanService;
        /// <summary>
		/// Initializes a new instance of the KetQuaTinhTheoTuanService class.
		/// </summary>
        public static KetQuaTinhTheoTuanService KetQuaTinhTheoTuan
        {
            get
            {
                if(_KetQuaTinhTheoTuanService == null)
                    _KetQuaTinhTheoTuanService = new KetQuaTinhTheoTuanService();
                return _KetQuaTinhTheoTuanService;
            }
        }
        #endregion        
    
        #region LopHocPhanBacDaoTaoService
        private static LopHocPhanBacDaoTaoService _LopHocPhanBacDaoTaoService;
        /// <summary>
		/// Initializes a new instance of the LopHocPhanBacDaoTaoService class.
		/// </summary>
        public static LopHocPhanBacDaoTaoService LopHocPhanBacDaoTao
        {
            get
            {
                if(_LopHocPhanBacDaoTaoService == null)
                    _LopHocPhanBacDaoTaoService = new LopHocPhanBacDaoTaoService();
                return _LopHocPhanBacDaoTaoService;
            }
        }
        #endregion        
    
        #region KyThiService
        private static KyThiService _KyThiService;
        /// <summary>
		/// Initializes a new instance of the KyThiService class.
		/// </summary>
        public static KyThiService KyThi
        {
            get
            {
                if(_KyThiService == null)
                    _KyThiService = new KyThiService();
                return _KyThiService;
            }
        }
        #endregion        
    
        #region LyDoTamNghiService
        private static LyDoTamNghiService _LyDoTamNghiService;
        /// <summary>
		/// Initializes a new instance of the LyDoTamNghiService class.
		/// </summary>
        public static LyDoTamNghiService LyDoTamNghi
        {
            get
            {
                if(_LyDoTamNghiService == null)
                    _LyDoTamNghiService = new LyDoTamNghiService();
                return _LyDoTamNghiService;
            }
        }
        #endregion        
    
        #region LopHocPhanKhongTinhGioGiangService
        private static LopHocPhanKhongTinhGioGiangService _LopHocPhanKhongTinhGioGiangService;
        /// <summary>
		/// Initializes a new instance of the LopHocPhanKhongTinhGioGiangService class.
		/// </summary>
        public static LopHocPhanKhongTinhGioGiangService LopHocPhanKhongTinhGioGiang
        {
            get
            {
                if(_LopHocPhanKhongTinhGioGiangService == null)
                    _LopHocPhanKhongTinhGioGiangService = new LopHocPhanKhongTinhGioGiangService();
                return _LopHocPhanKhongTinhGioGiangService;
            }
        }
        #endregion        
    
        #region LopChatLuongCaoService
        private static LopChatLuongCaoService _LopChatLuongCaoService;
        /// <summary>
		/// Initializes a new instance of the LopChatLuongCaoService class.
		/// </summary>
        public static LopChatLuongCaoService LopChatLuongCao
        {
            get
            {
                if(_LopChatLuongCaoService == null)
                    _LopChatLuongCaoService = new LopChatLuongCaoService();
                return _LopChatLuongCaoService;
            }
        }
        #endregion        
    
        #region KhoiLuongGiangDayCaoDangService
        private static KhoiLuongGiangDayCaoDangService _KhoiLuongGiangDayCaoDangService;
        /// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayCaoDangService class.
		/// </summary>
        public static KhoiLuongGiangDayCaoDangService KhoiLuongGiangDayCaoDang
        {
            get
            {
                if(_KhoiLuongGiangDayCaoDangService == null)
                    _KhoiLuongGiangDayCaoDangService = new KhoiLuongGiangDayCaoDangService();
                return _KhoiLuongGiangDayCaoDangService;
            }
        }
        #endregion        
    
        #region PhanLoaiHocPhanService
        private static PhanLoaiHocPhanService _PhanLoaiHocPhanService;
        /// <summary>
		/// Initializes a new instance of the PhanLoaiHocPhanService class.
		/// </summary>
        public static PhanLoaiHocPhanService PhanLoaiHocPhan
        {
            get
            {
                if(_PhanLoaiHocPhanService == null)
                    _PhanLoaiHocPhanService = new PhanLoaiHocPhanService();
                return _PhanLoaiHocPhanService;
            }
        }
        #endregion        
    
        #region KhoiLuongGiangDayDoAnService
        private static KhoiLuongGiangDayDoAnService _KhoiLuongGiangDayDoAnService;
        /// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnService class.
		/// </summary>
        public static KhoiLuongGiangDayDoAnService KhoiLuongGiangDayDoAn
        {
            get
            {
                if(_KhoiLuongGiangDayDoAnService == null)
                    _KhoiLuongGiangDayDoAnService = new KhoiLuongGiangDayDoAnService();
                return _KhoiLuongGiangDayDoAnService;
            }
        }
        #endregion        
    
        #region LopHocPhanGiangBangTiengNuocNgoaiService
        private static LopHocPhanGiangBangTiengNuocNgoaiService _LopHocPhanGiangBangTiengNuocNgoaiService;
        /// <summary>
		/// Initializes a new instance of the LopHocPhanGiangBangTiengNuocNgoaiService class.
		/// </summary>
        public static LopHocPhanGiangBangTiengNuocNgoaiService LopHocPhanGiangBangTiengNuocNgoai
        {
            get
            {
                if(_LopHocPhanGiangBangTiengNuocNgoaiService == null)
                    _LopHocPhanGiangBangTiengNuocNgoaiService = new LopHocPhanGiangBangTiengNuocNgoaiService();
                return _LopHocPhanGiangBangTiengNuocNgoaiService;
            }
        }
        #endregion        
    
        #region LoaiLopService
        private static LoaiLopService _LoaiLopService;
        /// <summary>
		/// Initializes a new instance of the LoaiLopService class.
		/// </summary>
        public static LoaiLopService LoaiLop
        {
            get
            {
                if(_LoaiLopService == null)
                    _LoaiLopService = new LoaiLopService();
                return _LoaiLopService;
            }
        }
        #endregion        
    
        #region ReportManagermentsService
        private static ReportManagermentsService _ReportManagermentsService;
        /// <summary>
		/// Initializes a new instance of the ReportManagermentsService class.
		/// </summary>
        public static ReportManagermentsService ReportManagerments
        {
            get
            {
                if(_ReportManagermentsService == null)
                    _ReportManagermentsService = new ReportManagermentsService();
                return _ReportManagermentsService;
            }
        }
        #endregion        
    
        #region LopHocPhanGhepThoiKhoaBieuService
        private static LopHocPhanGhepThoiKhoaBieuService _LopHocPhanGhepThoiKhoaBieuService;
        /// <summary>
		/// Initializes a new instance of the LopHocPhanGhepThoiKhoaBieuService class.
		/// </summary>
        public static LopHocPhanGhepThoiKhoaBieuService LopHocPhanGhepThoiKhoaBieu
        {
            get
            {
                if(_LopHocPhanGhepThoiKhoaBieuService == null)
                    _LopHocPhanGhepThoiKhoaBieuService = new LopHocPhanGhepThoiKhoaBieuService();
                return _LopHocPhanGhepThoiKhoaBieuService;
            }
        }
        #endregion        
    
        #region LopHocPhanClcAufCjlService
        private static LopHocPhanClcAufCjlService _LopHocPhanClcAufCjlService;
        /// <summary>
		/// Initializes a new instance of the LopHocPhanClcAufCjlService class.
		/// </summary>
        public static LopHocPhanClcAufCjlService LopHocPhanClcAufCjl
        {
            get
            {
                if(_LopHocPhanClcAufCjlService == null)
                    _LopHocPhanClcAufCjlService = new LopHocPhanClcAufCjlService();
                return _LopHocPhanClcAufCjlService;
            }
        }
        #endregion        
    
        #region QuyUocDatTenLopHocPhanService
        private static QuyUocDatTenLopHocPhanService _QuyUocDatTenLopHocPhanService;
        /// <summary>
		/// Initializes a new instance of the QuyUocDatTenLopHocPhanService class.
		/// </summary>
        public static QuyUocDatTenLopHocPhanService QuyUocDatTenLopHocPhan
        {
            get
            {
                if(_QuyUocDatTenLopHocPhanService == null)
                    _QuyUocDatTenLopHocPhanService = new QuyUocDatTenLopHocPhanService();
                return _QuyUocDatTenLopHocPhanService;
            }
        }
        #endregion        
    
        #region LoaiNhanVienService
        private static LoaiNhanVienService _LoaiNhanVienService;
        /// <summary>
		/// Initializes a new instance of the LoaiNhanVienService class.
		/// </summary>
        public static LoaiNhanVienService LoaiNhanVien
        {
            get
            {
                if(_LoaiNhanVienService == null)
                    _LoaiNhanVienService = new LoaiNhanVienService();
                return _LoaiNhanVienService;
            }
        }
        #endregion        
    
        #region LoaiGiangVienService
        private static LoaiGiangVienService _LoaiGiangVienService;
        /// <summary>
		/// Initializes a new instance of the LoaiGiangVienService class.
		/// </summary>
        public static LoaiGiangVienService LoaiGiangVien
        {
            get
            {
                if(_LoaiGiangVienService == null)
                    _LoaiGiangVienService = new LoaiGiangVienService();
                return _LoaiGiangVienService;
            }
        }
        #endregion        
    
        #region PhanQuyenControlTrenFormService
        private static PhanQuyenControlTrenFormService _PhanQuyenControlTrenFormService;
        /// <summary>
		/// Initializes a new instance of the PhanQuyenControlTrenFormService class.
		/// </summary>
        public static PhanQuyenControlTrenFormService PhanQuyenControlTrenForm
        {
            get
            {
                if(_PhanQuyenControlTrenFormService == null)
                    _PhanQuyenControlTrenFormService = new PhanQuyenControlTrenFormService();
                return _PhanQuyenControlTrenFormService;
            }
        }
        #endregion        
    
        #region QuyDoiGioChuanService
        private static QuyDoiGioChuanService _QuyDoiGioChuanService;
        /// <summary>
		/// Initializes a new instance of the QuyDoiGioChuanService class.
		/// </summary>
        public static QuyDoiGioChuanService QuyDoiGioChuan
        {
            get
            {
                if(_QuyDoiGioChuanService == null)
                    _QuyDoiGioChuanService = new QuyDoiGioChuanService();
                return _QuyDoiGioChuanService;
            }
        }
        #endregion        
    
        #region UteKhoiLuongGiangDayService
        private static UteKhoiLuongGiangDayService _UteKhoiLuongGiangDayService;
        /// <summary>
		/// Initializes a new instance of the UteKhoiLuongGiangDayService class.
		/// </summary>
        public static UteKhoiLuongGiangDayService UteKhoiLuongGiangDay
        {
            get
            {
                if(_UteKhoiLuongGiangDayService == null)
                    _UteKhoiLuongGiangDayService = new UteKhoiLuongGiangDayService();
                return _UteKhoiLuongGiangDayService;
            }
        }
        #endregion        
    
        #region SoTietCoiThiTieuChuanCuaGiangVienService
        private static SoTietCoiThiTieuChuanCuaGiangVienService _SoTietCoiThiTieuChuanCuaGiangVienService;
        /// <summary>
		/// Initializes a new instance of the SoTietCoiThiTieuChuanCuaGiangVienService class.
		/// </summary>
        public static SoTietCoiThiTieuChuanCuaGiangVienService SoTietCoiThiTieuChuanCuaGiangVien
        {
            get
            {
                if(_SoTietCoiThiTieuChuanCuaGiangVienService == null)
                    _SoTietCoiThiTieuChuanCuaGiangVienService = new SoTietCoiThiTieuChuanCuaGiangVienService();
                return _SoTietCoiThiTieuChuanCuaGiangVienService;
            }
        }
        #endregion        
    
        #region ThuLaoCoiThiChamBaiImportService
        private static ThuLaoCoiThiChamBaiImportService _ThuLaoCoiThiChamBaiImportService;
        /// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiChamBaiImportService class.
		/// </summary>
        public static ThuLaoCoiThiChamBaiImportService ThuLaoCoiThiChamBaiImport
        {
            get
            {
                if(_ThuLaoCoiThiChamBaiImportService == null)
                    _ThuLaoCoiThiChamBaiImportService = new ThuLaoCoiThiChamBaiImportService();
                return _ThuLaoCoiThiChamBaiImportService;
            }
        }
        #endregion        
    
        #region TrinhDoQuanLyNhaNuocService
        private static TrinhDoQuanLyNhaNuocService _TrinhDoQuanLyNhaNuocService;
        /// <summary>
		/// Initializes a new instance of the TrinhDoQuanLyNhaNuocService class.
		/// </summary>
        public static TrinhDoQuanLyNhaNuocService TrinhDoQuanLyNhaNuoc
        {
            get
            {
                if(_TrinhDoQuanLyNhaNuocService == null)
                    _TrinhDoQuanLyNhaNuocService = new TrinhDoQuanLyNhaNuocService();
                return _TrinhDoQuanLyNhaNuocService;
            }
        }
        #endregion        
    
        #region QuyDoiKhoiLuongTamUngService
        private static QuyDoiKhoiLuongTamUngService _QuyDoiKhoiLuongTamUngService;
        /// <summary>
		/// Initializes a new instance of the QuyDoiKhoiLuongTamUngService class.
		/// </summary>
        public static QuyDoiKhoiLuongTamUngService QuyDoiKhoiLuongTamUng
        {
            get
            {
                if(_QuyDoiKhoiLuongTamUngService == null)
                    _QuyDoiKhoiLuongTamUngService = new QuyDoiKhoiLuongTamUngService();
                return _QuyDoiKhoiLuongTamUngService;
            }
        }
        #endregion        
    
        #region TinhTrangService
        private static TinhTrangService _TinhTrangService;
        /// <summary>
		/// Initializes a new instance of the TinhTrangService class.
		/// </summary>
        public static TinhTrangService TinhTrang
        {
            get
            {
                if(_TinhTrangService == null)
                    _TinhTrangService = new TinhTrangService();
                return _TinhTrangService;
            }
        }
        #endregion        
    
        #region TrinhDoSuPhamService
        private static TrinhDoSuPhamService _TrinhDoSuPhamService;
        /// <summary>
		/// Initializes a new instance of the TrinhDoSuPhamService class.
		/// </summary>
        public static TrinhDoSuPhamService TrinhDoSuPham
        {
            get
            {
                if(_TrinhDoSuPhamService == null)
                    _TrinhDoSuPhamService = new TrinhDoSuPhamService();
                return _TrinhDoSuPhamService;
            }
        }
        #endregion        
    
        #region ThuLaoCoiThiService
        private static ThuLaoCoiThiService _ThuLaoCoiThiService;
        /// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiService class.
		/// </summary>
        public static ThuLaoCoiThiService ThuLaoCoiThi
        {
            get
            {
                if(_ThuLaoCoiThiService == null)
                    _ThuLaoCoiThiService = new ThuLaoCoiThiService();
                return _ThuLaoCoiThiService;
            }
        }
        #endregion        
    
        #region ThuLaoCoiThiVhuService
        private static ThuLaoCoiThiVhuService _ThuLaoCoiThiVhuService;
        /// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiVhuService class.
		/// </summary>
        public static ThuLaoCoiThiVhuService ThuLaoCoiThiVhu
        {
            get
            {
                if(_ThuLaoCoiThiVhuService == null)
                    _ThuLaoCoiThiVhuService = new ThuLaoCoiThiVhuService();
                return _ThuLaoCoiThiVhuService;
            }
        }
        #endregion        
    
        #region ThuLaoImportService
        private static ThuLaoImportService _ThuLaoImportService;
        /// <summary>
		/// Initializes a new instance of the ThuLaoImportService class.
		/// </summary>
        public static ThuLaoImportService ThuLaoImport
        {
            get
            {
                if(_ThuLaoImportService == null)
                    _ThuLaoImportService = new ThuLaoImportService();
                return _ThuLaoImportService;
            }
        }
        #endregion        
    
        #region ThuMoiGiangHopDongThinhGiangService
        private static ThuMoiGiangHopDongThinhGiangService _ThuMoiGiangHopDongThinhGiangService;
        /// <summary>
		/// Initializes a new instance of the ThuMoiGiangHopDongThinhGiangService class.
		/// </summary>
        public static ThuMoiGiangHopDongThinhGiangService ThuMoiGiangHopDongThinhGiang
        {
            get
            {
                if(_ThuMoiGiangHopDongThinhGiangService == null)
                    _ThuMoiGiangHopDongThinhGiangService = new ThuMoiGiangHopDongThinhGiangService();
                return _ThuMoiGiangHopDongThinhGiangService;
            }
        }
        #endregion        
    
        #region TrinhDoTinHocService
        private static TrinhDoTinHocService _TrinhDoTinHocService;
        /// <summary>
		/// Initializes a new instance of the TrinhDoTinHocService class.
		/// </summary>
        public static TrinhDoTinHocService TrinhDoTinHoc
        {
            get
            {
                if(_TrinhDoTinHocService == null)
                    _TrinhDoTinHocService = new TrinhDoTinHocService();
                return _TrinhDoTinHocService;
            }
        }
        #endregion        
    
        #region ThuLaoRaDeVhuService
        private static ThuLaoRaDeVhuService _ThuLaoRaDeVhuService;
        /// <summary>
		/// Initializes a new instance of the ThuLaoRaDeVhuService class.
		/// </summary>
        public static ThuLaoRaDeVhuService ThuLaoRaDeVhu
        {
            get
            {
                if(_ThuLaoRaDeVhuService == null)
                    _ThuLaoRaDeVhuService = new ThuLaoRaDeVhuService();
                return _ThuLaoRaDeVhuService;
            }
        }
        #endregion        
    
        #region DonViTinhService
        private static DonViTinhService _DonViTinhService;
        /// <summary>
		/// Initializes a new instance of the DonViTinhService class.
		/// </summary>
        public static DonViTinhService DonViTinh
        {
            get
            {
                if(_DonViTinhService == null)
                    _DonViTinhService = new DonViTinhService();
                return _DonViTinhService;
            }
        }
        #endregion        
    
        #region ThuLaoChamThiVhuexService
        private static ThuLaoChamThiVhuexService _ThuLaoChamThiVhuexService;
        /// <summary>
		/// Initializes a new instance of the ThuLaoChamThiVhuexService class.
		/// </summary>
        public static ThuLaoChamThiVhuexService ThuLaoChamThiVhuex
        {
            get
            {
                if(_ThuLaoChamThiVhuexService == null)
                    _ThuLaoChamThiVhuexService = new ThuLaoChamThiVhuexService();
                return _ThuLaoChamThiVhuexService;
            }
        }
        #endregion        
    
        #region ThuLaoHuongDanCuoiKhoaService
        private static ThuLaoHuongDanCuoiKhoaService _ThuLaoHuongDanCuoiKhoaService;
        /// <summary>
		/// Initializes a new instance of the ThuLaoHuongDanCuoiKhoaService class.
		/// </summary>
        public static ThuLaoHuongDanCuoiKhoaService ThuLaoHuongDanCuoiKhoa
        {
            get
            {
                if(_ThuLaoHuongDanCuoiKhoaService == null)
                    _ThuLaoHuongDanCuoiKhoaService = new ThuLaoHuongDanCuoiKhoaService();
                return _ThuLaoHuongDanCuoiKhoaService;
            }
        }
        #endregion        
    
        #region KetQuaTinhService
        private static KetQuaTinhService _KetQuaTinhService;
        /// <summary>
		/// Initializes a new instance of the KetQuaTinhService class.
		/// </summary>
        public static KetQuaTinhService KetQuaTinh
        {
            get
            {
                if(_KetQuaTinhService == null)
                    _KetQuaTinhService = new KetQuaTinhService();
                return _KetQuaTinhService;
            }
        }
        #endregion        
    
        #region TienCongTacPhiService
        private static TienCongTacPhiService _TienCongTacPhiService;
        /// <summary>
		/// Initializes a new instance of the TienCongTacPhiService class.
		/// </summary>
        public static TienCongTacPhiService TienCongTacPhi
        {
            get
            {
                if(_TienCongTacPhiService == null)
                    _TienCongTacPhiService = new TienCongTacPhiService();
                return _TienCongTacPhiService;
            }
        }
        #endregion        
    
        #region ThuLaoGiangDayDaiHocLopClcService
        private static ThuLaoGiangDayDaiHocLopClcService _ThuLaoGiangDayDaiHocLopClcService;
        /// <summary>
		/// Initializes a new instance of the ThuLaoGiangDayDaiHocLopClcService class.
		/// </summary>
        public static ThuLaoGiangDayDaiHocLopClcService ThuLaoGiangDayDaiHocLopClc
        {
            get
            {
                if(_ThuLaoGiangDayDaiHocLopClcService == null)
                    _ThuLaoGiangDayDaiHocLopClcService = new ThuLaoGiangDayDaiHocLopClcService();
                return _ThuLaoGiangDayDaiHocLopClcService;
            }
        }
        #endregion        
    
        #region VaiTroService
        private static VaiTroService _VaiTroService;
        /// <summary>
		/// Initializes a new instance of the VaiTroService class.
		/// </summary>
        public static VaiTroService VaiTro
        {
            get
            {
                if(_VaiTroService == null)
                    _VaiTroService = new VaiTroService();
                return _VaiTroService;
            }
        }
        #endregion        
    
        #region KhoiLuongGiangDayService
        private static KhoiLuongGiangDayService _KhoiLuongGiangDayService;
        /// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayService class.
		/// </summary>
        public static KhoiLuongGiangDayService KhoiLuongGiangDay
        {
            get
            {
                if(_KhoiLuongGiangDayService == null)
                    _KhoiLuongGiangDayService = new KhoiLuongGiangDayService();
                return _KhoiLuongGiangDayService;
            }
        }
        #endregion        
    
        #region KhoiLuongKhacService
        private static KhoiLuongKhacService _KhoiLuongKhacService;
        /// <summary>
		/// Initializes a new instance of the KhoiLuongKhacService class.
		/// </summary>
        public static KhoiLuongKhacService KhoiLuongKhac
        {
            get
            {
                if(_KhoiLuongKhacService == null)
                    _KhoiLuongKhacService = new KhoiLuongKhacService();
                return _KhoiLuongKhacService;
            }
        }
        #endregion        
    
        #region HeSoThuLaoService
        private static HeSoThuLaoService _HeSoThuLaoService;
        /// <summary>
		/// Initializes a new instance of the HeSoThuLaoService class.
		/// </summary>
        public static HeSoThuLaoService HeSoThuLao
        {
            get
            {
                if(_HeSoThuLaoService == null)
                    _HeSoThuLaoService = new HeSoThuLaoService();
                return _HeSoThuLaoService;
            }
        }
        #endregion        
    
        #region HeSoTroCapTheoKhoaService
        private static HeSoTroCapTheoKhoaService _HeSoTroCapTheoKhoaService;
        /// <summary>
		/// Initializes a new instance of the HeSoTroCapTheoKhoaService class.
		/// </summary>
        public static HeSoTroCapTheoKhoaService HeSoTroCapTheoKhoa
        {
            get
            {
                if(_HeSoTroCapTheoKhoaService == null)
                    _HeSoTroCapTheoKhoaService = new HeSoTroCapTheoKhoaService();
                return _HeSoTroCapTheoKhoaService;
            }
        }
        #endregion        
    
        #region TinhTrangTheoNamHocService
        private static TinhTrangTheoNamHocService _TinhTrangTheoNamHocService;
        /// <summary>
		/// Initializes a new instance of the TinhTrangTheoNamHocService class.
		/// </summary>
        public static TinhTrangTheoNamHocService TinhTrangTheoNamHoc
        {
            get
            {
                if(_TinhTrangTheoNamHocService == null)
                    _TinhTrangTheoNamHocService = new TinhTrangTheoNamHocService();
                return _TinhTrangTheoNamHocService;
            }
        }
        #endregion        
    
        #region UteKhoiLuongQuyDoiService
        private static UteKhoiLuongQuyDoiService _UteKhoiLuongQuyDoiService;
        /// <summary>
		/// Initializes a new instance of the UteKhoiLuongQuyDoiService class.
		/// </summary>
        public static UteKhoiLuongQuyDoiService UteKhoiLuongQuyDoi
        {
            get
            {
                if(_UteKhoiLuongQuyDoiService == null)
                    _UteKhoiLuongQuyDoiService = new UteKhoiLuongQuyDoiService();
                return _UteKhoiLuongQuyDoiService;
            }
        }
        #endregion        
    
        #region KhoanChiKhacService
        private static KhoanChiKhacService _KhoanChiKhacService;
        /// <summary>
		/// Initializes a new instance of the KhoanChiKhacService class.
		/// </summary>
        public static KhoanChiKhacService KhoanChiKhac
        {
            get
            {
                if(_KhoanChiKhacService == null)
                    _KhoanChiKhacService = new KhoanChiKhacService();
                return _KhoanChiKhacService;
            }
        }
        #endregion        
    
        #region TietNghiaVuService
        private static TietNghiaVuService _TietNghiaVuService;
        /// <summary>
		/// Initializes a new instance of the TietNghiaVuService class.
		/// </summary>
        public static TietNghiaVuService TietNghiaVu
        {
            get
            {
                if(_TietNghiaVuService == null)
                    _TietNghiaVuService = new TietNghiaVuService();
                return _TietNghiaVuService;
            }
        }
        #endregion        
    
        #region TongTienLuongTrongNamCuaGiangVienService
        private static TongTienLuongTrongNamCuaGiangVienService _TongTienLuongTrongNamCuaGiangVienService;
        /// <summary>
		/// Initializes a new instance of the TongTienLuongTrongNamCuaGiangVienService class.
		/// </summary>
        public static TongTienLuongTrongNamCuaGiangVienService TongTienLuongTrongNamCuaGiangVien
        {
            get
            {
                if(_TongTienLuongTrongNamCuaGiangVienService == null)
                    _TongTienLuongTrongNamCuaGiangVienService = new TongTienLuongTrongNamCuaGiangVienService();
                return _TongTienLuongTrongNamCuaGiangVienService;
            }
        }
        #endregion        
    
        #region UteKhoiLuongKhacService
        private static UteKhoiLuongKhacService _UteKhoiLuongKhacService;
        /// <summary>
		/// Initializes a new instance of the UteKhoiLuongKhacService class.
		/// </summary>
        public static UteKhoiLuongKhacService UteKhoiLuongKhac
        {
            get
            {
                if(_UteKhoiLuongKhacService == null)
                    _UteKhoiLuongKhacService = new UteKhoiLuongKhacService();
                return _UteKhoiLuongKhacService;
            }
        }
        #endregion        
    
        #region KhoiLuongCacCongViecKhacService
        private static KhoiLuongCacCongViecKhacService _KhoiLuongCacCongViecKhacService;
        /// <summary>
		/// Initializes a new instance of the KhoiLuongCacCongViecKhacService class.
		/// </summary>
        public static KhoiLuongCacCongViecKhacService KhoiLuongCacCongViecKhac
        {
            get
            {
                if(_KhoiLuongCacCongViecKhacService == null)
                    _KhoiLuongCacCongViecKhacService = new KhoiLuongCacCongViecKhacService();
                return _KhoiLuongCacCongViecKhacService;
            }
        }
        #endregion        
    
        #region KhoanQuyDoiService
        private static KhoanQuyDoiService _KhoanQuyDoiService;
        /// <summary>
		/// Initializes a new instance of the KhoanQuyDoiService class.
		/// </summary>
        public static KhoanQuyDoiService KhoanQuyDoi
        {
            get
            {
                if(_KhoanQuyDoiService == null)
                    _KhoanQuyDoiService = new KhoanQuyDoiService();
                return _KhoanQuyDoiService;
            }
        }
        #endregion        
    
        #region TietNoKyTruocService
        private static TietNoKyTruocService _TietNoKyTruocService;
        /// <summary>
		/// Initializes a new instance of the TietNoKyTruocService class.
		/// </summary>
        public static TietNoKyTruocService TietNoKyTruoc
        {
            get
            {
                if(_TietNoKyTruocService == null)
                    _TietNoKyTruocService = new TietNoKyTruocService();
                return _TietNoKyTruocService;
            }
        }
        #endregion        
    
        #region QuyDoiHoatDongNgoaiGiangDayService
        private static QuyDoiHoatDongNgoaiGiangDayService _QuyDoiHoatDongNgoaiGiangDayService;
        /// <summary>
		/// Initializes a new instance of the QuyDoiHoatDongNgoaiGiangDayService class.
		/// </summary>
        public static QuyDoiHoatDongNgoaiGiangDayService QuyDoiHoatDongNgoaiGiangDay
        {
            get
            {
                if(_QuyDoiHoatDongNgoaiGiangDayService == null)
                    _QuyDoiHoatDongNgoaiGiangDayService = new QuyDoiHoatDongNgoaiGiangDayService();
                return _QuyDoiHoatDongNgoaiGiangDayService;
            }
        }
        #endregion        
    
        #region ThuLaoChamBaiService
        private static ThuLaoChamBaiService _ThuLaoChamBaiService;
        /// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiService class.
		/// </summary>
        public static ThuLaoChamBaiService ThuLaoChamBai
        {
            get
            {
                if(_ThuLaoChamBaiService == null)
                    _ThuLaoChamBaiService = new ThuLaoChamBaiService();
                return _ThuLaoChamBaiService;
            }
        }
        #endregion        
    
        #region ThucGiangMonThucTeTuHocService
        private static ThucGiangMonThucTeTuHocService _ThucGiangMonThucTeTuHocService;
        /// <summary>
		/// Initializes a new instance of the ThucGiangMonThucTeTuHocService class.
		/// </summary>
        public static ThucGiangMonThucTeTuHocService ThucGiangMonThucTeTuHoc
        {
            get
            {
                if(_ThucGiangMonThucTeTuHocService == null)
                    _ThucGiangMonThucTeTuHocService = new ThucGiangMonThucTeTuHocService();
                return _ThucGiangMonThucTeTuHocService;
            }
        }
        #endregion        
    
        #region ThueThuNhapCaNhanService
        private static ThueThuNhapCaNhanService _ThueThuNhapCaNhanService;
        /// <summary>
		/// Initializes a new instance of the ThueThuNhapCaNhanService class.
		/// </summary>
        public static ThueThuNhapCaNhanService ThueThuNhapCaNhan
        {
            get
            {
                if(_ThueThuNhapCaNhanService == null)
                    _ThueThuNhapCaNhanService = new ThueThuNhapCaNhanService();
                return _ThueThuNhapCaNhanService;
            }
        }
        #endregion        
    
        #region ThongTinGiangDayGiangVienService
        private static ThongTinGiangDayGiangVienService _ThongTinGiangDayGiangVienService;
        /// <summary>
		/// Initializes a new instance of the ThongTinGiangDayGiangVienService class.
		/// </summary>
        public static ThongTinGiangDayGiangVienService ThongTinGiangDayGiangVien
        {
            get
            {
                if(_ThongTinGiangDayGiangVienService == null)
                    _ThongTinGiangDayGiangVienService = new ThongTinGiangDayGiangVienService();
                return _ThongTinGiangDayGiangVienService;
            }
        }
        #endregion        
    
        #region ThuLaoChamBaiVhuService
        private static ThuLaoChamBaiVhuService _ThuLaoChamBaiVhuService;
        /// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiVhuService class.
		/// </summary>
        public static ThuLaoChamBaiVhuService ThuLaoChamBaiVhu
        {
            get
            {
                if(_ThuLaoChamBaiVhuService == null)
                    _ThuLaoChamBaiVhuService = new ThuLaoChamBaiVhuService();
                return _ThuLaoChamBaiVhuService;
            }
        }
        #endregion        
    
        #region SdhPhanNhomMonHocService
        private static SdhPhanNhomMonHocService _SdhPhanNhomMonHocService;
        /// <summary>
		/// Initializes a new instance of the SdhPhanNhomMonHocService class.
		/// </summary>
        public static SdhPhanNhomMonHocService SdhPhanNhomMonHoc
        {
            get
            {
                if(_SdhPhanNhomMonHocService == null)
                    _SdhPhanNhomMonHocService = new SdhPhanNhomMonHocService();
                return _SdhPhanNhomMonHocService;
            }
        }
        #endregion        
    
        #region SdhNhomMonHocService
        private static SdhNhomMonHocService _SdhNhomMonHocService;
        /// <summary>
		/// Initializes a new instance of the SdhNhomMonHocService class.
		/// </summary>
        public static SdhNhomMonHocService SdhNhomMonHoc
        {
            get
            {
                if(_SdhNhomMonHocService == null)
                    _SdhNhomMonHocService = new SdhNhomMonHocService();
                return _SdhNhomMonHocService;
            }
        }
        #endregion        
    
        #region SdhDonGiaService
        private static SdhDonGiaService _SdhDonGiaService;
        /// <summary>
		/// Initializes a new instance of the SdhDonGiaService class.
		/// </summary>
        public static SdhDonGiaService SdhDonGia
        {
            get
            {
                if(_SdhDonGiaService == null)
                    _SdhDonGiaService = new SdhDonGiaService();
                return _SdhDonGiaService;
            }
        }
        #endregion        
    
        #region SdhKetQuaThanhToanThuLaoService
        private static SdhKetQuaThanhToanThuLaoService _SdhKetQuaThanhToanThuLaoService;
        /// <summary>
		/// Initializes a new instance of the SdhKetQuaThanhToanThuLaoService class.
		/// </summary>
        public static SdhKetQuaThanhToanThuLaoService SdhKetQuaThanhToanThuLao
        {
            get
            {
                if(_SdhKetQuaThanhToanThuLaoService == null)
                    _SdhKetQuaThanhToanThuLaoService = new SdhKetQuaThanhToanThuLaoService();
                return _SdhKetQuaThanhToanThuLaoService;
            }
        }
        #endregion        
    
        #region SdhPhanLoaiHocPhanService
        private static SdhPhanLoaiHocPhanService _SdhPhanLoaiHocPhanService;
        /// <summary>
		/// Initializes a new instance of the SdhPhanLoaiHocPhanService class.
		/// </summary>
        public static SdhPhanLoaiHocPhanService SdhPhanLoaiHocPhan
        {
            get
            {
                if(_SdhPhanLoaiHocPhanService == null)
                    _SdhPhanLoaiHocPhanService = new SdhPhanLoaiHocPhanService();
                return _SdhPhanLoaiHocPhanService;
            }
        }
        #endregion        
    
        #region SoTietNckhChuyenSangNamSauService
        private static SoTietNckhChuyenSangNamSauService _SoTietNckhChuyenSangNamSauService;
        /// <summary>
		/// Initializes a new instance of the SoTietNckhChuyenSangNamSauService class.
		/// </summary>
        public static SoTietNckhChuyenSangNamSauService SoTietNckhChuyenSangNamSau
        {
            get
            {
                if(_SoTietNckhChuyenSangNamSauService == null)
                    _SoTietNckhChuyenSangNamSauService = new SoTietNckhChuyenSangNamSauService();
                return _SoTietNckhChuyenSangNamSauService;
            }
        }
        #endregion        
    
        #region SdhMonHocKhongTinhKhoiLuongService
        private static SdhMonHocKhongTinhKhoiLuongService _SdhMonHocKhongTinhKhoiLuongService;
        /// <summary>
		/// Initializes a new instance of the SdhMonHocKhongTinhKhoiLuongService class.
		/// </summary>
        public static SdhMonHocKhongTinhKhoiLuongService SdhMonHocKhongTinhKhoiLuong
        {
            get
            {
                if(_SdhMonHocKhongTinhKhoiLuongService == null)
                    _SdhMonHocKhongTinhKhoiLuongService = new SdhMonHocKhongTinhKhoiLuongService();
                return _SdhMonHocKhongTinhKhoiLuongService;
            }
        }
        #endregion        
    
        #region SdhHeSoDiaDiemService
        private static SdhHeSoDiaDiemService _SdhHeSoDiaDiemService;
        /// <summary>
		/// Initializes a new instance of the SdhHeSoDiaDiemService class.
		/// </summary>
        public static SdhHeSoDiaDiemService SdhHeSoDiaDiem
        {
            get
            {
                if(_SdhHeSoDiaDiemService == null)
                    _SdhHeSoDiaDiemService = new SdhHeSoDiaDiemService();
                return _SdhHeSoDiaDiemService;
            }
        }
        #endregion        
    
        #region SdhChotKhoiLuongGiangDayService
        private static SdhChotKhoiLuongGiangDayService _SdhChotKhoiLuongGiangDayService;
        /// <summary>
		/// Initializes a new instance of the SdhChotKhoiLuongGiangDayService class.
		/// </summary>
        public static SdhChotKhoiLuongGiangDayService SdhChotKhoiLuongGiangDay
        {
            get
            {
                if(_SdhChotKhoiLuongGiangDayService == null)
                    _SdhChotKhoiLuongGiangDayService = new SdhChotKhoiLuongGiangDayService();
                return _SdhChotKhoiLuongGiangDayService;
            }
        }
        #endregion        
    
        #region ThuLaoGiangDayThucHanhService
        private static ThuLaoGiangDayThucHanhService _ThuLaoGiangDayThucHanhService;
        /// <summary>
		/// Initializes a new instance of the ThuLaoGiangDayThucHanhService class.
		/// </summary>
        public static ThuLaoGiangDayThucHanhService ThuLaoGiangDayThucHanh
        {
            get
            {
                if(_ThuLaoGiangDayThucHanhService == null)
                    _ThuLaoGiangDayThucHanhService = new ThuLaoGiangDayThucHanhService();
                return _ThuLaoGiangDayThucHanhService;
            }
        }
        #endregion        
    
        #region ReportTemplateService
        private static ReportTemplateService _ReportTemplateService;
        /// <summary>
		/// Initializes a new instance of the ReportTemplateService class.
		/// </summary>
        public static ReportTemplateService ReportTemplate
        {
            get
            {
                if(_ReportTemplateService == null)
                    _ReportTemplateService = new ReportTemplateService();
                return _ReportTemplateService;
            }
        }
        #endregion        
    
        #region SdhUteKhoiLuongGiangDayService
        private static SdhUteKhoiLuongGiangDayService _SdhUteKhoiLuongGiangDayService;
        /// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongGiangDayService class.
		/// </summary>
        public static SdhUteKhoiLuongGiangDayService SdhUteKhoiLuongGiangDay
        {
            get
            {
                if(_SdhUteKhoiLuongGiangDayService == null)
                    _SdhUteKhoiLuongGiangDayService = new SdhUteKhoiLuongGiangDayService();
                return _SdhUteKhoiLuongGiangDayService;
            }
        }
        #endregion        
    
        #region SdhUteKhoiLuongQuyDoiService
        private static SdhUteKhoiLuongQuyDoiService _SdhUteKhoiLuongQuyDoiService;
        /// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongQuyDoiService class.
		/// </summary>
        public static SdhUteKhoiLuongQuyDoiService SdhUteKhoiLuongQuyDoi
        {
            get
            {
                if(_SdhUteKhoiLuongQuyDoiService == null)
                    _SdhUteKhoiLuongQuyDoiService = new SdhUteKhoiLuongQuyDoiService();
                return _SdhUteKhoiLuongQuyDoiService;
            }
        }
        #endregion        
    
        #region QuyMoKhoaService
        private static QuyMoKhoaService _QuyMoKhoaService;
        /// <summary>
		/// Initializes a new instance of the QuyMoKhoaService class.
		/// </summary>
        public static QuyMoKhoaService QuyMoKhoa
        {
            get
            {
                if(_QuyMoKhoaService == null)
                    _QuyMoKhoaService = new QuyMoKhoaService();
                return _QuyMoKhoaService;
            }
        }
        #endregion        
    
        #region SdhMonPhanCongNhieuGiangVienService
        private static SdhMonPhanCongNhieuGiangVienService _SdhMonPhanCongNhieuGiangVienService;
        /// <summary>
		/// Initializes a new instance of the SdhMonPhanCongNhieuGiangVienService class.
		/// </summary>
        public static SdhMonPhanCongNhieuGiangVienService SdhMonPhanCongNhieuGiangVien
        {
            get
            {
                if(_SdhMonPhanCongNhieuGiangVienService == null)
                    _SdhMonPhanCongNhieuGiangVienService = new SdhMonPhanCongNhieuGiangVienService();
                return _SdhMonPhanCongNhieuGiangVienService;
            }
        }
        #endregion        
    
        #region SdhUteThanhToanThuLaoService
        private static SdhUteThanhToanThuLaoService _SdhUteThanhToanThuLaoService;
        /// <summary>
		/// Initializes a new instance of the SdhUteThanhToanThuLaoService class.
		/// </summary>
        public static SdhUteThanhToanThuLaoService SdhUteThanhToanThuLao
        {
            get
            {
                if(_SdhUteThanhToanThuLaoService == null)
                    _SdhUteThanhToanThuLaoService = new SdhUteThanhToanThuLaoService();
                return _SdhUteThanhToanThuLaoService;
            }
        }
        #endregion        
    
        #region ThanhTraGiangDayService
        private static ThanhTraGiangDayService _ThanhTraGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ThanhTraGiangDayService class.
		/// </summary>
        public static ThanhTraGiangDayService ThanhTraGiangDay
        {
            get
            {
                if(_ThanhTraGiangDayService == null)
                    _ThanhTraGiangDayService = new ThanhTraGiangDayService();
                return _ThanhTraGiangDayService;
            }
        }
        #endregion        
    
        #region ThoiGianGiangDayService
        private static ThoiGianGiangDayService _ThoiGianGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ThoiGianGiangDayService class.
		/// </summary>
        public static ThoiGianGiangDayService ThoiGianGiangDay
        {
            get
            {
                if(_ThoiGianGiangDayService == null)
                    _ThoiGianGiangDayService = new ThoiGianGiangDayService();
                return _ThoiGianGiangDayService;
            }
        }
        #endregion        
    
        #region ThanhTraCoiThiService
        private static ThanhTraCoiThiService _ThanhTraCoiThiService;
        /// <summary>
		/// Initializes a new instance of the ThanhTraCoiThiService class.
		/// </summary>
        public static ThanhTraCoiThiService ThanhTraCoiThi
        {
            get
            {
                if(_ThanhTraCoiThiService == null)
                    _ThanhTraCoiThiService = new ThanhTraCoiThiService();
                return _ThanhTraCoiThiService;
            }
        }
        #endregion        
    
        #region ThanhTraChamGiangTheoKhoaHocService
        private static ThanhTraChamGiangTheoKhoaHocService _ThanhTraChamGiangTheoKhoaHocService;
        /// <summary>
		/// Initializes a new instance of the ThanhTraChamGiangTheoKhoaHocService class.
		/// </summary>
        public static ThanhTraChamGiangTheoKhoaHocService ThanhTraChamGiangTheoKhoaHoc
        {
            get
            {
                if(_ThanhTraChamGiangTheoKhoaHocService == null)
                    _ThanhTraChamGiangTheoKhoaHocService = new ThanhTraChamGiangTheoKhoaHocService();
                return _ThanhTraChamGiangTheoKhoaHocService;
            }
        }
        #endregion        
    
        #region SdhHeSoLopDongService
        private static SdhHeSoLopDongService _SdhHeSoLopDongService;
        /// <summary>
		/// Initializes a new instance of the SdhHeSoLopDongService class.
		/// </summary>
        public static SdhHeSoLopDongService SdhHeSoLopDong
        {
            get
            {
                if(_SdhHeSoLopDongService == null)
                    _SdhHeSoLopDongService = new SdhHeSoLopDongService();
                return _SdhHeSoLopDongService;
            }
        }
        #endregion        
    
        #region TaiKhoanService
        private static TaiKhoanService _TaiKhoanService;
        /// <summary>
		/// Initializes a new instance of the TaiKhoanService class.
		/// </summary>
        public static TaiKhoanService TaiKhoan
        {
            get
            {
                if(_TaiKhoanService == null)
                    _TaiKhoanService = new TaiKhoanService();
                return _TaiKhoanService;
            }
        }
        #endregion        
    
        #region ThoiGianNghiTamThoiCuaGiangVienService
        private static ThoiGianNghiTamThoiCuaGiangVienService _ThoiGianNghiTamThoiCuaGiangVienService;
        /// <summary>
		/// Initializes a new instance of the ThoiGianNghiTamThoiCuaGiangVienService class.
		/// </summary>
        public static ThoiGianNghiTamThoiCuaGiangVienService ThoiGianNghiTamThoiCuaGiangVien
        {
            get
            {
                if(_ThoiGianNghiTamThoiCuaGiangVienService == null)
                    _ThoiGianNghiTamThoiCuaGiangVienService = new ThoiGianNghiTamThoiCuaGiangVienService();
                return _ThoiGianNghiTamThoiCuaGiangVienService;
            }
        }
        #endregion        
    
        #region ThueThanhToanBoSungService
        private static ThueThanhToanBoSungService _ThueThanhToanBoSungService;
        /// <summary>
		/// Initializes a new instance of the ThueThanhToanBoSungService class.
		/// </summary>
        public static ThueThanhToanBoSungService ThueThanhToanBoSung
        {
            get
            {
                if(_ThueThanhToanBoSungService == null)
                    _ThueThanhToanBoSungService = new ThueThanhToanBoSungService();
                return _ThueThanhToanBoSungService;
            }
        }
        #endregion        
    
        #region ThoiGianLamViecCuaNhanVienService
        private static ThoiGianLamViecCuaNhanVienService _ThoiGianLamViecCuaNhanVienService;
        /// <summary>
		/// Initializes a new instance of the ThoiGianLamViecCuaNhanVienService class.
		/// </summary>
        public static ThoiGianLamViecCuaNhanVienService ThoiGianLamViecCuaNhanVien
        {
            get
            {
                if(_ThoiGianLamViecCuaNhanVienService == null)
                    _ThoiGianLamViecCuaNhanVienService = new ThoiGianLamViecCuaNhanVienService();
                return _ThoiGianLamViecCuaNhanVienService;
            }
        }
        #endregion        
    
        #region SiSoLopHocPhanService
        private static SiSoLopHocPhanService _SiSoLopHocPhanService;
        /// <summary>
		/// Initializes a new instance of the SiSoLopHocPhanService class.
		/// </summary>
        public static SiSoLopHocPhanService SiSoLopHocPhan
        {
            get
            {
                if(_SiSoLopHocPhanService == null)
                    _SiSoLopHocPhanService = new SiSoLopHocPhanService();
                return _SiSoLopHocPhanService;
            }
        }
        #endregion        
    
        #region BangPhuTroiNamHocService
        private static BangPhuTroiNamHocService _BangPhuTroiNamHocService;
        /// <summary>
		/// Initializes a new instance of the BangPhuTroiNamHocService class.
		/// </summary>
        public static BangPhuTroiNamHocService BangPhuTroiNamHoc
        {
            get
            {
                if(_BangPhuTroiNamHocService == null)
                    _BangPhuTroiNamHocService = new BangPhuTroiNamHocService();
                return _BangPhuTroiNamHocService;
            }
        }
        #endregion        
    
        #region SdhLoaiKhoiLuongService
        private static SdhLoaiKhoiLuongService _SdhLoaiKhoiLuongService;
        /// <summary>
		/// Initializes a new instance of the SdhLoaiKhoiLuongService class.
		/// </summary>
        public static SdhLoaiKhoiLuongService SdhLoaiKhoiLuong
        {
            get
            {
                if(_SdhLoaiKhoiLuongService == null)
                    _SdhLoaiKhoiLuongService = new SdhLoaiKhoiLuongService();
                return _SdhLoaiKhoiLuongService;
            }
        }
        #endregion        
    
        #region ThanhToanThinhGiangService
        private static ThanhToanThinhGiangService _ThanhToanThinhGiangService;
        /// <summary>
		/// Initializes a new instance of the ThanhToanThinhGiangService class.
		/// </summary>
        public static ThanhToanThinhGiangService ThanhToanThinhGiang
        {
            get
            {
                if(_ThanhToanThinhGiangService == null)
                    _ThanhToanThinhGiangService = new ThanhToanThinhGiangService();
                return _ThanhToanThinhGiangService;
            }
        }
        #endregion        
    
        #region KetQuaCacKhoanChiKhacService
        private static KetQuaCacKhoanChiKhacService _KetQuaCacKhoanChiKhacService;
        /// <summary>
		/// Initializes a new instance of the KetQuaCacKhoanChiKhacService class.
		/// </summary>
        public static KetQuaCacKhoanChiKhacService KetQuaCacKhoanChiKhac
        {
            get
            {
                if(_KetQuaCacKhoanChiKhacService == null)
                    _KetQuaCacKhoanChiKhacService = new KetQuaCacKhoanChiKhacService();
                return _KetQuaCacKhoanChiKhacService;
            }
        }
        #endregion        
    
        #region ThanhTraTheoThoiKhoaBieuService
        private static ThanhTraTheoThoiKhoaBieuService _ThanhTraTheoThoiKhoaBieuService;
        /// <summary>
		/// Initializes a new instance of the ThanhTraTheoThoiKhoaBieuService class.
		/// </summary>
        public static ThanhTraTheoThoiKhoaBieuService ThanhTraTheoThoiKhoaBieu
        {
            get
            {
                if(_ThanhTraTheoThoiKhoaBieuService == null)
                    _ThanhTraTheoThoiKhoaBieuService = new ThanhTraTheoThoiKhoaBieuService();
                return _ThanhTraTheoThoiKhoaBieuService;
            }
        }
        #endregion        
    
        #region KcqUteKhoiLuongGiangDayService
        private static KcqUteKhoiLuongGiangDayService _KcqUteKhoiLuongGiangDayService;
        /// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongGiangDayService class.
		/// </summary>
        public static KcqUteKhoiLuongGiangDayService KcqUteKhoiLuongGiangDay
        {
            get
            {
                if(_KcqUteKhoiLuongGiangDayService == null)
                    _KcqUteKhoiLuongGiangDayService = new KcqUteKhoiLuongGiangDayService();
                return _KcqUteKhoiLuongGiangDayService;
            }
        }
        #endregion        
    
        #region ThamDinhLuanVanThacSyService
        private static ThamDinhLuanVanThacSyService _ThamDinhLuanVanThacSyService;
        /// <summary>
		/// Initializes a new instance of the ThamDinhLuanVanThacSyService class.
		/// </summary>
        public static ThamDinhLuanVanThacSyService ThamDinhLuanVanThacSy
        {
            get
            {
                if(_ThamDinhLuanVanThacSyService == null)
                    _ThamDinhLuanVanThacSyService = new ThamDinhLuanVanThacSyService();
                return _ThamDinhLuanVanThacSyService;
            }
        }
        #endregion        
    
        #region GiangDaySauDaiHocService
        private static GiangDaySauDaiHocService _GiangDaySauDaiHocService;
        /// <summary>
		/// Initializes a new instance of the GiangDaySauDaiHocService class.
		/// </summary>
        public static GiangDaySauDaiHocService GiangDaySauDaiHoc
        {
            get
            {
                if(_GiangDaySauDaiHocService == null)
                    _GiangDaySauDaiHocService = new GiangDaySauDaiHocService();
                return _GiangDaySauDaiHocService;
            }
        }
        #endregion        
    
        #region KcqUteKhoiLuongKhacService
        private static KcqUteKhoiLuongKhacService _KcqUteKhoiLuongKhacService;
        /// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongKhacService class.
		/// </summary>
        public static KcqUteKhoiLuongKhacService KcqUteKhoiLuongKhac
        {
            get
            {
                if(_KcqUteKhoiLuongKhacService == null)
                    _KcqUteKhoiLuongKhacService = new KcqUteKhoiLuongKhacService();
                return _KcqUteKhoiLuongKhacService;
            }
        }
        #endregion        
    
        #region KcqPhanCongDoAnTotNghiepService
        private static KcqPhanCongDoAnTotNghiepService _KcqPhanCongDoAnTotNghiepService;
        /// <summary>
		/// Initializes a new instance of the KcqPhanCongDoAnTotNghiepService class.
		/// </summary>
        public static KcqPhanCongDoAnTotNghiepService KcqPhanCongDoAnTotNghiep
        {
            get
            {
                if(_KcqPhanCongDoAnTotNghiepService == null)
                    _KcqPhanCongDoAnTotNghiepService = new KcqPhanCongDoAnTotNghiepService();
                return _KcqPhanCongDoAnTotNghiepService;
            }
        }
        #endregion        
    
        #region DuTruGioGiangKhiCoLopHocPhanService
        private static DuTruGioGiangKhiCoLopHocPhanService _DuTruGioGiangKhiCoLopHocPhanService;
        /// <summary>
		/// Initializes a new instance of the DuTruGioGiangKhiCoLopHocPhanService class.
		/// </summary>
        public static DuTruGioGiangKhiCoLopHocPhanService DuTruGioGiangKhiCoLopHocPhan
        {
            get
            {
                if(_DuTruGioGiangKhiCoLopHocPhanService == null)
                    _DuTruGioGiangKhiCoLopHocPhanService = new DuTruGioGiangKhiCoLopHocPhanService();
                return _DuTruGioGiangKhiCoLopHocPhanService;
            }
        }
        #endregion        
    
        #region DanhMucHoatDongQuanLyService
        private static DanhMucHoatDongQuanLyService _DanhMucHoatDongQuanLyService;
        /// <summary>
		/// Initializes a new instance of the DanhMucHoatDongQuanLyService class.
		/// </summary>
        public static DanhMucHoatDongQuanLyService DanhMucHoatDongQuanLy
        {
            get
            {
                if(_DanhMucHoatDongQuanLyService == null)
                    _DanhMucHoatDongQuanLyService = new DanhMucHoatDongQuanLyService();
                return _DanhMucHoatDongQuanLyService;
            }
        }
        #endregion        
    
        #region KcqQuyDoiGioChuanService
        private static KcqQuyDoiGioChuanService _KcqQuyDoiGioChuanService;
        /// <summary>
		/// Initializes a new instance of the KcqQuyDoiGioChuanService class.
		/// </summary>
        public static KcqQuyDoiGioChuanService KcqQuyDoiGioChuan
        {
            get
            {
                if(_KcqQuyDoiGioChuanService == null)
                    _KcqQuyDoiGioChuanService = new KcqQuyDoiGioChuanService();
                return _KcqQuyDoiGioChuanService;
            }
        }
        #endregion        
    
        #region HocHamService
        private static HocHamService _HocHamService;
        /// <summary>
		/// Initializes a new instance of the HocHamService class.
		/// </summary>
        public static HocHamService HocHam
        {
            get
            {
                if(_HocHamService == null)
                    _HocHamService = new HocHamService();
                return _HocHamService;
            }
        }
        #endregion        
    
        #region GiangVienChuyenMonService
        private static GiangVienChuyenMonService _GiangVienChuyenMonService;
        /// <summary>
		/// Initializes a new instance of the GiangVienChuyenMonService class.
		/// </summary>
        public static GiangVienChuyenMonService GiangVienChuyenMon
        {
            get
            {
                if(_GiangVienChuyenMonService == null)
                    _GiangVienChuyenMonService = new GiangVienChuyenMonService();
                return _GiangVienChuyenMonService;
            }
        }
        #endregion        
    
        #region GiangVienChucVuService
        private static GiangVienChucVuService _GiangVienChucVuService;
        /// <summary>
		/// Initializes a new instance of the GiangVienChucVuService class.
		/// </summary>
        public static GiangVienChucVuService GiangVienChucVu
        {
            get
            {
                if(_GiangVienChucVuService == null)
                    _GiangVienChucVuService = new GiangVienChucVuService();
                return _GiangVienChucVuService;
            }
        }
        #endregion        
    
        #region GiangVienThanhToanQuaNganHangService
        private static GiangVienThanhToanQuaNganHangService _GiangVienThanhToanQuaNganHangService;
        /// <summary>
		/// Initializes a new instance of the GiangVienThanhToanQuaNganHangService class.
		/// </summary>
        public static GiangVienThanhToanQuaNganHangService GiangVienThanhToanQuaNganHang
        {
            get
            {
                if(_GiangVienThanhToanQuaNganHangService == null)
                    _GiangVienThanhToanQuaNganHangService = new GiangVienThanhToanQuaNganHangService();
                return _GiangVienThanhToanQuaNganHangService;
            }
        }
        #endregion        
    
        #region GiangVienMocTangLuongService
        private static GiangVienMocTangLuongService _GiangVienMocTangLuongService;
        /// <summary>
		/// Initializes a new instance of the GiangVienMocTangLuongService class.
		/// </summary>
        public static GiangVienMocTangLuongService GiangVienMocTangLuong
        {
            get
            {
                if(_GiangVienMocTangLuongService == null)
                    _GiangVienMocTangLuongService = new GiangVienMocTangLuongService();
                return _GiangVienMocTangLuongService;
            }
        }
        #endregion        
    
        #region GiangDayChatLuongCaoService
        private static GiangDayChatLuongCaoService _GiangDayChatLuongCaoService;
        /// <summary>
		/// Initializes a new instance of the GiangDayChatLuongCaoService class.
		/// </summary>
        public static GiangDayChatLuongCaoService GiangDayChatLuongCao
        {
            get
            {
                if(_GiangDayChatLuongCaoService == null)
                    _GiangDayChatLuongCaoService = new GiangDayChatLuongCaoService();
                return _GiangDayChatLuongCaoService;
            }
        }
        #endregion        
    
        #region GiangVienKhongTinhGioGiangService
        private static GiangVienKhongTinhGioGiangService _GiangVienKhongTinhGioGiangService;
        /// <summary>
		/// Initializes a new instance of the GiangVienKhongTinhGioGiangService class.
		/// </summary>
        public static GiangVienKhongTinhGioGiangService GiangVienKhongTinhGioGiang
        {
            get
            {
                if(_GiangVienKhongTinhGioGiangService == null)
                    _GiangVienKhongTinhGioGiangService = new GiangVienKhongTinhGioGiangService();
                return _GiangVienKhongTinhGioGiangService;
            }
        }
        #endregion        
    
        #region GhiChuThanhToanBoSungService
        private static GhiChuThanhToanBoSungService _GhiChuThanhToanBoSungService;
        /// <summary>
		/// Initializes a new instance of the GhiChuThanhToanBoSungService class.
		/// </summary>
        public static GhiChuThanhToanBoSungService GhiChuThanhToanBoSung
        {
            get
            {
                if(_GhiChuThanhToanBoSungService == null)
                    _GhiChuThanhToanBoSungService = new GhiChuThanhToanBoSungService();
                return _GhiChuThanhToanBoSungService;
            }
        }
        #endregion        
    
        #region GiangVienDinhMucKhauTruService
        private static GiangVienDinhMucKhauTruService _GiangVienDinhMucKhauTruService;
        /// <summary>
		/// Initializes a new instance of the GiangVienDinhMucKhauTruService class.
		/// </summary>
        public static GiangVienDinhMucKhauTruService GiangVienDinhMucKhauTru
        {
            get
            {
                if(_GiangVienDinhMucKhauTruService == null)
                    _GiangVienDinhMucKhauTruService = new GiangVienDinhMucKhauTruService();
                return _GiangVienDinhMucKhauTruService;
            }
        }
        #endregion        
    
        #region GiangVienHoatDongNgoaiGiangDayService
        private static GiangVienHoatDongNgoaiGiangDayService _GiangVienHoatDongNgoaiGiangDayService;
        /// <summary>
		/// Initializes a new instance of the GiangVienHoatDongNgoaiGiangDayService class.
		/// </summary>
        public static GiangVienHoatDongNgoaiGiangDayService GiangVienHoatDongNgoaiGiangDay
        {
            get
            {
                if(_GiangVienHoatDongNgoaiGiangDayService == null)
                    _GiangVienHoatDongNgoaiGiangDayService = new GiangVienHoatDongNgoaiGiangDayService();
                return _GiangVienHoatDongNgoaiGiangDayService;
            }
        }
        #endregion        
    
        #region GiamTruDinhMucService
        private static GiamTruDinhMucService _GiamTruDinhMucService;
        /// <summary>
		/// Initializes a new instance of the GiamTruDinhMucService class.
		/// </summary>
        public static GiamTruDinhMucService GiamTruDinhMuc
        {
            get
            {
                if(_GiamTruDinhMucService == null)
                    _GiamTruDinhMucService = new GiamTruDinhMucService();
                return _GiamTruDinhMucService;
            }
        }
        #endregion        
    
        #region GiangVienLopHocPhanService
        private static GiangVienLopHocPhanService _GiangVienLopHocPhanService;
        /// <summary>
		/// Initializes a new instance of the GiangVienLopHocPhanService class.
		/// </summary>
        public static GiangVienLopHocPhanService GiangVienLopHocPhan
        {
            get
            {
                if(_GiangVienLopHocPhanService == null)
                    _GiangVienLopHocPhanService = new GiangVienLopHocPhanService();
                return _GiangVienLopHocPhanService;
            }
        }
        #endregion        
    
        #region GiangVienThayDoiHocHamService
        private static GiangVienThayDoiHocHamService _GiangVienThayDoiHocHamService;
        /// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocHamService class.
		/// </summary>
        public static GiangVienThayDoiHocHamService GiangVienThayDoiHocHam
        {
            get
            {
                if(_GiangVienThayDoiHocHamService == null)
                    _GiangVienThayDoiHocHamService = new GiangVienThayDoiHocHamService();
                return _GiangVienThayDoiHocHamService;
            }
        }
        #endregion        
    
        #region GiangVienChoDuyetHoSoService
        private static GiangVienChoDuyetHoSoService _GiangVienChoDuyetHoSoService;
        /// <summary>
		/// Initializes a new instance of the GiangVienChoDuyetHoSoService class.
		/// </summary>
        public static GiangVienChoDuyetHoSoService GiangVienChoDuyetHoSo
        {
            get
            {
                if(_GiangVienChoDuyetHoSoService == null)
                    _GiangVienChoDuyetHoSoService = new GiangVienChoDuyetHoSoService();
                return _GiangVienChoDuyetHoSoService;
            }
        }
        #endregion        
    
        #region GiangVienBiChanTienService
        private static GiangVienBiChanTienService _GiangVienBiChanTienService;
        /// <summary>
		/// Initializes a new instance of the GiangVienBiChanTienService class.
		/// </summary>
        public static GiangVienBiChanTienService GiangVienBiChanTien
        {
            get
            {
                if(_GiangVienBiChanTienService == null)
                    _GiangVienBiChanTienService = new GiangVienBiChanTienService();
                return _GiangVienBiChanTienService;
            }
        }
        #endregion        
    
        #region GiangVienTinhGioChuanService
        private static GiangVienTinhGioChuanService _GiangVienTinhGioChuanService;
        /// <summary>
		/// Initializes a new instance of the GiangVienTinhGioChuanService class.
		/// </summary>
        public static GiangVienTinhGioChuanService GiangVienTinhGioChuan
        {
            get
            {
                if(_GiangVienTinhGioChuanService == null)
                    _GiangVienTinhGioChuanService = new GiangVienTinhGioChuanService();
                return _GiangVienTinhGioChuanService;
            }
        }
        #endregion        
    
        #region NgachCongChucService
        private static NgachCongChucService _NgachCongChucService;
        /// <summary>
		/// Initializes a new instance of the NgachCongChucService class.
		/// </summary>
        public static NgachCongChucService NgachCongChuc
        {
            get
            {
                if(_NgachCongChucService == null)
                    _NgachCongChucService = new NgachCongChucService();
                return _NgachCongChucService;
            }
        }
        #endregion        
    
        #region DinhMucGioChuanService
        private static DinhMucGioChuanService _DinhMucGioChuanService;
        /// <summary>
		/// Initializes a new instance of the DinhMucGioChuanService class.
		/// </summary>
        public static DinhMucGioChuanService DinhMucGioChuan
        {
            get
            {
                if(_DinhMucGioChuanService == null)
                    _DinhMucGioChuanService = new DinhMucGioChuanService();
                return _DinhMucGioChuanService;
            }
        }
        #endregion        
    
        #region GiangVienTamUngChiTietService
        private static GiangVienTamUngChiTietService _GiangVienTamUngChiTietService;
        /// <summary>
		/// Initializes a new instance of the GiangVienTamUngChiTietService class.
		/// </summary>
        public static GiangVienTamUngChiTietService GiangVienTamUngChiTiet
        {
            get
            {
                if(_GiangVienTamUngChiTietService == null)
                    _GiangVienTamUngChiTietService = new GiangVienTamUngChiTietService();
                return _GiangVienTamUngChiTietService;
            }
        }
        #endregion        
    
        #region HocViService
        private static HocViService _HocViService;
        /// <summary>
		/// Initializes a new instance of the HocViService class.
		/// </summary>
        public static HocViService HocVi
        {
            get
            {
                if(_HocViService == null)
                    _HocViService = new HocViService();
                return _HocViService;
            }
        }
        #endregion        
    
        #region GiangVienThayDoiLoaiGiangVienService
        private static GiangVienThayDoiLoaiGiangVienService _GiangVienThayDoiLoaiGiangVienService;
        /// <summary>
		/// Initializes a new instance of the GiangVienThayDoiLoaiGiangVienService class.
		/// </summary>
        public static GiangVienThayDoiLoaiGiangVienService GiangVienThayDoiLoaiGiangVien
        {
            get
            {
                if(_GiangVienThayDoiLoaiGiangVienService == null)
                    _GiangVienThayDoiLoaiGiangVienService = new GiangVienThayDoiLoaiGiangVienService();
                return _GiangVienThayDoiLoaiGiangVienService;
            }
        }
        #endregion        
    
        #region GiangVienGiamTruDinhMucService
        private static GiangVienGiamTruDinhMucService _GiangVienGiamTruDinhMucService;
        /// <summary>
		/// Initializes a new instance of the GiangVienGiamTruDinhMucService class.
		/// </summary>
        public static GiangVienGiamTruDinhMucService GiangVienGiamTruDinhMuc
        {
            get
            {
                if(_GiangVienGiamTruDinhMucService == null)
                    _GiangVienGiamTruDinhMucService = new GiangVienGiamTruDinhMucService();
                return _GiangVienGiamTruDinhMucService;
            }
        }
        #endregion        
    
        #region GiangVienCamKetKhongTruThueService
        private static GiangVienCamKetKhongTruThueService _GiangVienCamKetKhongTruThueService;
        /// <summary>
		/// Initializes a new instance of the GiangVienCamKetKhongTruThueService class.
		/// </summary>
        public static GiangVienCamKetKhongTruThueService GiangVienCamKetKhongTruThue
        {
            get
            {
                if(_GiangVienCamKetKhongTruThueService == null)
                    _GiangVienCamKetKhongTruThueService = new GiangVienCamKetKhongTruThueService();
                return _GiangVienCamKetKhongTruThueService;
            }
        }
        #endregion        
    
        #region GiangVienPhanHoiService
        private static GiangVienPhanHoiService _GiangVienPhanHoiService;
        /// <summary>
		/// Initializes a new instance of the GiangVienPhanHoiService class.
		/// </summary>
        public static GiangVienPhanHoiService GiangVienPhanHoi
        {
            get
            {
                if(_GiangVienPhanHoiService == null)
                    _GiangVienPhanHoiService = new GiangVienPhanHoiService();
                return _GiangVienPhanHoiService;
            }
        }
        #endregion        
    
        #region DuTruGioGiangTruocLopHocPhanService
        private static DuTruGioGiangTruocLopHocPhanService _DuTruGioGiangTruocLopHocPhanService;
        /// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocLopHocPhanService class.
		/// </summary>
        public static DuTruGioGiangTruocLopHocPhanService DuTruGioGiangTruocLopHocPhan
        {
            get
            {
                if(_DuTruGioGiangTruocLopHocPhanService == null)
                    _DuTruGioGiangTruocLopHocPhanService = new DuTruGioGiangTruocLopHocPhanService();
                return _DuTruGioGiangTruocLopHocPhanService;
            }
        }
        #endregion        
    
        #region GiangVienTinhLuongThinhGiangService
        private static GiangVienTinhLuongThinhGiangService _GiangVienTinhLuongThinhGiangService;
        /// <summary>
		/// Initializes a new instance of the GiangVienTinhLuongThinhGiangService class.
		/// </summary>
        public static GiangVienTinhLuongThinhGiangService GiangVienTinhLuongThinhGiang
        {
            get
            {
                if(_GiangVienTinhLuongThinhGiangService == null)
                    _GiangVienTinhLuongThinhGiangService = new GiangVienTinhLuongThinhGiangService();
                return _GiangVienTinhLuongThinhGiangService;
            }
        }
        #endregion        
    
        #region DinhMucNghienCuuKhoaHocService
        private static DinhMucNghienCuuKhoaHocService _DinhMucNghienCuuKhoaHocService;
        /// <summary>
		/// Initializes a new instance of the DinhMucNghienCuuKhoaHocService class.
		/// </summary>
        public static DinhMucNghienCuuKhoaHocService DinhMucNghienCuuKhoaHoc
        {
            get
            {
                if(_DinhMucNghienCuuKhoaHocService == null)
                    _DinhMucNghienCuuKhoaHocService = new DinhMucNghienCuuKhoaHocService();
                return _DinhMucNghienCuuKhoaHocService;
            }
        }
        #endregion        
    
        #region GiangVienNghienCuuKhService
        private static GiangVienNghienCuuKhService _GiangVienNghienCuuKhService;
        /// <summary>
		/// Initializes a new instance of the GiangVienNghienCuuKhService class.
		/// </summary>
        public static GiangVienNghienCuuKhService GiangVienNghienCuuKh
        {
            get
            {
                if(_GiangVienNghienCuuKhService == null)
                    _GiangVienNghienCuuKhService = new GiangVienNghienCuuKhService();
                return _GiangVienNghienCuuKhService;
            }
        }
        #endregion        
    
        #region GiangVienHoSoService
        private static GiangVienHoSoService _GiangVienHoSoService;
        /// <summary>
		/// Initializes a new instance of the GiangVienHoSoService class.
		/// </summary>
        public static GiangVienHoSoService GiangVienHoSo
        {
            get
            {
                if(_GiangVienHoSoService == null)
                    _GiangVienHoSoService = new GiangVienHoSoService();
                return _GiangVienHoSoService;
            }
        }
        #endregion        
    
        #region GiangVienThayDoiChucVuService
        private static GiangVienThayDoiChucVuService _GiangVienThayDoiChucVuService;
        /// <summary>
		/// Initializes a new instance of the GiangVienThayDoiChucVuService class.
		/// </summary>
        public static GiangVienThayDoiChucVuService GiangVienThayDoiChucVu
        {
            get
            {
                if(_GiangVienThayDoiChucVuService == null)
                    _GiangVienThayDoiChucVuService = new GiangVienThayDoiChucVuService();
                return _GiangVienThayDoiChucVuService;
            }
        }
        #endregion        
    
        #region GiangVienHoatDongQuanLyService
        private static GiangVienHoatDongQuanLyService _GiangVienHoatDongQuanLyService;
        /// <summary>
		/// Initializes a new instance of the GiangVienHoatDongQuanLyService class.
		/// </summary>
        public static GiangVienHoatDongQuanLyService GiangVienHoatDongQuanLy
        {
            get
            {
                if(_GiangVienHoatDongQuanLyService == null)
                    _GiangVienHoatDongQuanLyService = new GiangVienHoatDongQuanLyService();
                return _GiangVienHoatDongQuanLyService;
            }
        }
        #endregion        
    
        #region DinhMucHuongDanKhoaLuanThucTapService
        private static DinhMucHuongDanKhoaLuanThucTapService _DinhMucHuongDanKhoaLuanThucTapService;
        /// <summary>
		/// Initializes a new instance of the DinhMucHuongDanKhoaLuanThucTapService class.
		/// </summary>
        public static DinhMucHuongDanKhoaLuanThucTapService DinhMucHuongDanKhoaLuanThucTap
        {
            get
            {
                if(_DinhMucHuongDanKhoaLuanThucTapService == null)
                    _DinhMucHuongDanKhoaLuanThucTapService = new DinhMucHuongDanKhoaLuanThucTapService();
                return _DinhMucHuongDanKhoaLuanThucTapService;
            }
        }
        #endregion        
    
        #region GiamTruGioChuanService
        private static GiamTruGioChuanService _GiamTruGioChuanService;
        /// <summary>
		/// Initializes a new instance of the GiamTruGioChuanService class.
		/// </summary>
        public static GiamTruGioChuanService GiamTruGioChuan
        {
            get
            {
                if(_GiamTruGioChuanService == null)
                    _GiamTruGioChuanService = new GiamTruGioChuanService();
                return _GiamTruGioChuanService;
            }
        }
        #endregion        
    
        #region ChotCoVanHocTapService
        private static ChotCoVanHocTapService _ChotCoVanHocTapService;
        /// <summary>
		/// Initializes a new instance of the ChotCoVanHocTapService class.
		/// </summary>
        public static ChotCoVanHocTapService ChotCoVanHocTap
        {
            get
            {
                if(_ChotCoVanHocTapService == null)
                    _ChotCoVanHocTapService = new ChotCoVanHocTapService();
                return _ChotCoVanHocTapService;
            }
        }
        #endregion        
    
        #region ChotKhoiLuongGiangDayService
        private static ChotKhoiLuongGiangDayService _ChotKhoiLuongGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ChotKhoiLuongGiangDayService class.
		/// </summary>
        public static ChotKhoiLuongGiangDayService ChotKhoiLuongGiangDay
        {
            get
            {
                if(_ChotKhoiLuongGiangDayService == null)
                    _ChotKhoiLuongGiangDayService = new ChotKhoiLuongGiangDayService();
                return _ChotKhoiLuongGiangDayService;
            }
        }
        #endregion        
    
        #region ChucVuService
        private static ChucVuService _ChucVuService;
        /// <summary>
		/// Initializes a new instance of the ChucVuService class.
		/// </summary>
        public static ChucVuService ChucVu
        {
            get
            {
                if(_ChucVuService == null)
                    _ChucVuService = new ChucVuService();
                return _ChucVuService;
            }
        }
        #endregion        
    
        #region DonGiaService
        private static DonGiaService _DonGiaService;
        /// <summary>
		/// Initializes a new instance of the DonGiaService class.
		/// </summary>
        public static DonGiaService DonGia
        {
            get
            {
                if(_DonGiaService == null)
                    _DonGiaService = new DonGiaService();
                return _DonGiaService;
            }
        }
        #endregion        
    
        #region CoVanHocTapService
        private static CoVanHocTapService _CoVanHocTapService;
        /// <summary>
		/// Initializes a new instance of the CoVanHocTapService class.
		/// </summary>
        public static CoVanHocTapService CoVanHocTap
        {
            get
            {
                if(_CoVanHocTapService == null)
                    _CoVanHocTapService = new CoVanHocTapService();
                return _CoVanHocTapService;
            }
        }
        #endregion        
    
        #region ChiTietKhoiLuongService
        private static ChiTietKhoiLuongService _ChiTietKhoiLuongService;
        /// <summary>
		/// Initializes a new instance of the ChiTietKhoiLuongService class.
		/// </summary>
        public static ChiTietKhoiLuongService ChiTietKhoiLuong
        {
            get
            {
                if(_ChiTietKhoiLuongService == null)
                    _ChiTietKhoiLuongService = new ChiTietKhoiLuongService();
                return _ChiTietKhoiLuongService;
            }
        }
        #endregion        
    
        #region CauHinhChungService
        private static CauHinhChungService _CauHinhChungService;
        /// <summary>
		/// Initializes a new instance of the CauHinhChungService class.
		/// </summary>
        public static CauHinhChungService CauHinhChung
        {
            get
            {
                if(_CauHinhChungService == null)
                    _CauHinhChungService = new CauHinhChungService();
                return _CauHinhChungService;
            }
        }
        #endregion        
    
        #region DanhGiaCoVanHocTapService
        private static DanhGiaCoVanHocTapService _DanhGiaCoVanHocTapService;
        /// <summary>
		/// Initializes a new instance of the DanhGiaCoVanHocTapService class.
		/// </summary>
        public static DanhGiaCoVanHocTapService DanhGiaCoVanHocTap
        {
            get
            {
                if(_DanhGiaCoVanHocTapService == null)
                    _DanhGiaCoVanHocTapService = new DanhGiaCoVanHocTapService();
                return _DanhGiaCoVanHocTapService;
            }
        }
        #endregion        
    
        #region ChucNangService
        private static ChucNangService _ChucNangService;
        /// <summary>
		/// Initializes a new instance of the ChucNangService class.
		/// </summary>
        public static ChucNangService ChucNang
        {
            get
            {
                if(_ChucNangService == null)
                    _ChucNangService = new ChucNangService();
                return _ChucNangService;
            }
        }
        #endregion        
    
        #region NghienCuuKhoaHocTongHopService
        private static NghienCuuKhoaHocTongHopService _NghienCuuKhoaHocTongHopService;
        /// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocTongHopService class.
		/// </summary>
        public static NghienCuuKhoaHocTongHopService NghienCuuKhoaHocTongHop
        {
            get
            {
                if(_NghienCuuKhoaHocTongHopService == null)
                    _NghienCuuKhoaHocTongHopService = new NghienCuuKhoaHocTongHopService();
                return _NghienCuuKhoaHocTongHopService;
            }
        }
        #endregion        
    
        #region CauHinhService
        private static CauHinhService _CauHinhService;
        /// <summary>
		/// Initializes a new instance of the CauHinhService class.
		/// </summary>
        public static CauHinhService CauHinh
        {
            get
            {
                if(_CauHinhService == null)
                    _CauHinhService = new CauHinhService();
                return _CauHinhService;
            }
        }
        #endregion        
    
        #region DonGiaChatLuongCaoService
        private static DonGiaChatLuongCaoService _DonGiaChatLuongCaoService;
        /// <summary>
		/// Initializes a new instance of the DonGiaChatLuongCaoService class.
		/// </summary>
        public static DonGiaChatLuongCaoService DonGiaChatLuongCao
        {
            get
            {
                if(_DonGiaChatLuongCaoService == null)
                    _DonGiaChatLuongCaoService = new DonGiaChatLuongCaoService();
                return _DonGiaChatLuongCaoService;
            }
        }
        #endregion        
    
        #region CauHinhChotGioService
        private static CauHinhChotGioService _CauHinhChotGioService;
        /// <summary>
		/// Initializes a new instance of the CauHinhChotGioService class.
		/// </summary>
        public static CauHinhChotGioService CauHinhChotGio
        {
            get
            {
                if(_CauHinhChotGioService == null)
                    _CauHinhChotGioService = new CauHinhChotGioService();
                return _CauHinhChotGioService;
            }
        }
        #endregion        
    
        #region CauHinhGiangVienPhanHoiService
        private static CauHinhGiangVienPhanHoiService _CauHinhGiangVienPhanHoiService;
        /// <summary>
		/// Initializes a new instance of the CauHinhGiangVienPhanHoiService class.
		/// </summary>
        public static CauHinhGiangVienPhanHoiService CauHinhGiangVienPhanHoi
        {
            get
            {
                if(_CauHinhGiangVienPhanHoiService == null)
                    _CauHinhGiangVienPhanHoiService = new CauHinhGiangVienPhanHoiService();
                return _CauHinhGiangVienPhanHoiService;
            }
        }
        #endregion        
    
        #region BacLuongService
        private static BacLuongService _BacLuongService;
        /// <summary>
		/// Initializes a new instance of the BacLuongService class.
		/// </summary>
        public static BacLuongService BacLuong
        {
            get
            {
                if(_BacLuongService == null)
                    _BacLuongService = new BacLuongService();
                return _BacLuongService;
            }
        }
        #endregion        
    
        #region DonGiaChamBaiService
        private static DonGiaChamBaiService _DonGiaChamBaiService;
        /// <summary>
		/// Initializes a new instance of the DonGiaChamBaiService class.
		/// </summary>
        public static DonGiaChamBaiService DonGiaChamBai
        {
            get
            {
                if(_DonGiaChamBaiService == null)
                    _DonGiaChamBaiService = new DonGiaChamBaiService();
                return _DonGiaChamBaiService;
            }
        }
        #endregion        
    
        #region DanhMucNghienCuuKhoaHocService
        private static DanhMucNghienCuuKhoaHocService _DanhMucNghienCuuKhoaHocService;
        /// <summary>
		/// Initializes a new instance of the DanhMucNghienCuuKhoaHocService class.
		/// </summary>
        public static DanhMucNghienCuuKhoaHocService DanhMucNghienCuuKhoaHoc
        {
            get
            {
                if(_DanhMucNghienCuuKhoaHocService == null)
                    _DanhMucNghienCuuKhoaHocService = new DanhMucNghienCuuKhoaHocService();
                return _DanhMucNghienCuuKhoaHocService;
            }
        }
        #endregion        
    
        #region DonGiaTcbService
        private static DonGiaTcbService _DonGiaTcbService;
        /// <summary>
		/// Initializes a new instance of the DonGiaTcbService class.
		/// </summary>
        public static DonGiaTcbService DonGiaTcb
        {
            get
            {
                if(_DonGiaTcbService == null)
                    _DonGiaTcbService = new DonGiaTcbService();
                return _DonGiaTcbService;
            }
        }
        #endregion        
    
        #region DotChiTraService
        private static DotChiTraService _DotChiTraService;
        /// <summary>
		/// Initializes a new instance of the DotChiTraService class.
		/// </summary>
        public static DotChiTraService DotChiTra
        {
            get
            {
                if(_DotChiTraService == null)
                    _DotChiTraService = new DotChiTraService();
                return _DotChiTraService;
            }
        }
        #endregion        
    
        #region DonGiaMotTietService
        private static DonGiaMotTietService _DonGiaMotTietService;
        /// <summary>
		/// Initializes a new instance of the DonGiaMotTietService class.
		/// </summary>
        public static DonGiaMotTietService DonGiaMotTiet
        {
            get
            {
                if(_DonGiaMotTietService == null)
                    _DonGiaMotTietService = new DonGiaMotTietService();
                return _DonGiaMotTietService;
            }
        }
        #endregion        
    
        #region GiangVienThayDoiHocViService
        private static GiangVienThayDoiHocViService _GiangVienThayDoiHocViService;
        /// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocViService class.
		/// </summary>
        public static GiangVienThayDoiHocViService GiangVienThayDoiHocVi
        {
            get
            {
                if(_GiangVienThayDoiHocViService == null)
                    _GiangVienThayDoiHocViService = new GiangVienThayDoiHocViService();
                return _GiangVienThayDoiHocViService;
            }
        }
        #endregion        
    
        #region DonGiaNgoaiQuyCheService
        private static DonGiaNgoaiQuyCheService _DonGiaNgoaiQuyCheService;
        /// <summary>
		/// Initializes a new instance of the DonGiaNgoaiQuyCheService class.
		/// </summary>
        public static DonGiaNgoaiQuyCheService DonGiaNgoaiQuyChe
        {
            get
            {
                if(_DonGiaNgoaiQuyCheService == null)
                    _DonGiaNgoaiQuyCheService = new DonGiaNgoaiQuyCheService();
                return _DonGiaNgoaiQuyCheService;
            }
        }
        #endregion        
    
        #region DanhSachHopDongThinhGiangService
        private static DanhSachHopDongThinhGiangService _DanhSachHopDongThinhGiangService;
        /// <summary>
		/// Initializes a new instance of the DanhSachHopDongThinhGiangService class.
		/// </summary>
        public static DanhSachHopDongThinhGiangService DanhSachHopDongThinhGiang
        {
            get
            {
                if(_DanhSachHopDongThinhGiangService == null)
                    _DanhSachHopDongThinhGiangService = new DanhSachHopDongThinhGiangService();
                return _DanhSachHopDongThinhGiangService;
            }
        }
        #endregion        
    
        #region GiangVienChuyenDoiGioGiangService
        private static GiangVienChuyenDoiGioGiangService _GiangVienChuyenDoiGioGiangService;
        /// <summary>
		/// Initializes a new instance of the GiangVienChuyenDoiGioGiangService class.
		/// </summary>
        public static GiangVienChuyenDoiGioGiangService GiangVienChuyenDoiGioGiang
        {
            get
            {
                if(_GiangVienChuyenDoiGioGiangService == null)
                    _GiangVienChuyenDoiGioGiangService = new GiangVienChuyenDoiGioGiangService();
                return _GiangVienChuyenDoiGioGiangService;
            }
        }
        #endregion        
    
        #region DanhMucViPhamService
        private static DanhMucViPhamService _DanhMucViPhamService;
        /// <summary>
		/// Initializes a new instance of the DanhMucViPhamService class.
		/// </summary>
        public static DanhMucViPhamService DanhMucViPham
        {
            get
            {
                if(_DanhMucViPhamService == null)
                    _DanhMucViPhamService = new DanhMucViPhamService();
                return _DanhMucViPhamService;
            }
        }
        #endregion        
    
        #region GiangVienTamUngService
        private static GiangVienTamUngService _GiangVienTamUngService;
        /// <summary>
		/// Initializes a new instance of the GiangVienTamUngService class.
		/// </summary>
        public static GiangVienTamUngService GiangVienTamUng
        {
            get
            {
                if(_GiangVienTamUngService == null)
                    _GiangVienTamUngService = new GiangVienTamUngService();
                return _GiangVienTamUngService;
            }
        }
        #endregion        
    
        #region DonGiaCoiThiService
        private static DonGiaCoiThiService _DonGiaCoiThiService;
        /// <summary>
		/// Initializes a new instance of the DonGiaCoiThiService class.
		/// </summary>
        public static DonGiaCoiThiService DonGiaCoiThi
        {
            get
            {
                if(_DonGiaCoiThiService == null)
                    _DonGiaCoiThiService = new DonGiaCoiThiService();
                return _DonGiaCoiThiService;
            }
        }
        #endregion        
    
        #region ChietTinhBoiDuongGiangDayService
        private static ChietTinhBoiDuongGiangDayService _ChietTinhBoiDuongGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ChietTinhBoiDuongGiangDayService class.
		/// </summary>
        public static ChietTinhBoiDuongGiangDayService ChietTinhBoiDuongGiangDay
        {
            get
            {
                if(_ChietTinhBoiDuongGiangDayService == null)
                    _ChietTinhBoiDuongGiangDayService = new ChietTinhBoiDuongGiangDayService();
                return _ChietTinhBoiDuongGiangDayService;
            }
        }
        #endregion        
    
        #region ChiTienThuLaoGiangDayService
        private static ChiTienThuLaoGiangDayService _ChiTienThuLaoGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ChiTienThuLaoGiangDayService class.
		/// </summary>
        public static ChiTienThuLaoGiangDayService ChiTienThuLaoGiangDay
        {
            get
            {
                if(_ChiTienThuLaoGiangDayService == null)
                    _ChiTienThuLaoGiangDayService = new ChiTienThuLaoGiangDayService();
                return _ChiTienThuLaoGiangDayService;
            }
        }
        #endregion        
    
        #region CongThucService
        private static CongThucService _CongThucService;
        /// <summary>
		/// Initializes a new instance of the CongThucService class.
		/// </summary>
        public static CongThucService CongThuc
        {
            get
            {
                if(_CongThucService == null)
                    _CongThucService = new CongThucService();
                return _CongThucService;
            }
        }
        #endregion        
    
        #region KcqUteThanhToanThuLaoService
        private static KcqUteThanhToanThuLaoService _KcqUteThanhToanThuLaoService;
        /// <summary>
		/// Initializes a new instance of the KcqUteThanhToanThuLaoService class.
		/// </summary>
        public static KcqUteThanhToanThuLaoService KcqUteThanhToanThuLao
        {
            get
            {
                if(_KcqUteThanhToanThuLaoService == null)
                    _KcqUteThanhToanThuLaoService = new KcqUteThanhToanThuLaoService();
                return _KcqUteThanhToanThuLaoService;
            }
        }
        #endregion        
    
        #region DuTruGioGiangTruocThoiKhoaBieuService
        private static DuTruGioGiangTruocThoiKhoaBieuService _DuTruGioGiangTruocThoiKhoaBieuService;
        /// <summary>
		/// Initializes a new instance of the DuTruGioGiangTruocThoiKhoaBieuService class.
		/// </summary>
        public static DuTruGioGiangTruocThoiKhoaBieuService DuTruGioGiangTruocThoiKhoaBieu
        {
            get
            {
                if(_DuTruGioGiangTruocThoiKhoaBieuService == null)
                    _DuTruGioGiangTruocThoiKhoaBieuService = new DuTruGioGiangTruocThoiKhoaBieuService();
                return _DuTruGioGiangTruocThoiKhoaBieuService;
            }
        }
        #endregion        
    
        #region DanhMucQuyMoService
        private static DanhMucQuyMoService _DanhMucQuyMoService;
        /// <summary>
		/// Initializes a new instance of the DanhMucQuyMoService class.
		/// </summary>
        public static DanhMucQuyMoService DanhMucQuyMo
        {
            get
            {
                if(_DanhMucQuyMoService == null)
                    _DanhMucQuyMoService = new DanhMucQuyMoService();
                return _DanhMucQuyMoService;
            }
        }
        #endregion        
    
        #region KcqKhoiLuongGiangDayChiTietService
        private static KcqKhoiLuongGiangDayChiTietService _KcqKhoiLuongGiangDayChiTietService;
        /// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayChiTietService class.
		/// </summary>
        public static KcqKhoiLuongGiangDayChiTietService KcqKhoiLuongGiangDayChiTiet
        {
            get
            {
                if(_KcqKhoiLuongGiangDayChiTietService == null)
                    _KcqKhoiLuongGiangDayChiTietService = new KcqKhoiLuongGiangDayChiTietService();
                return _KcqKhoiLuongGiangDayChiTietService;
            }
        }
        #endregion        
    
        #region HeSoChucDanhChuyenMonService
        private static HeSoChucDanhChuyenMonService _HeSoChucDanhChuyenMonService;
        /// <summary>
		/// Initializes a new instance of the HeSoChucDanhChuyenMonService class.
		/// </summary>
        public static HeSoChucDanhChuyenMonService HeSoChucDanhChuyenMon
        {
            get
            {
                if(_HeSoChucDanhChuyenMonService == null)
                    _HeSoChucDanhChuyenMonService = new HeSoChucDanhChuyenMonService();
                return _HeSoChucDanhChuyenMonService;
            }
        }
        #endregion        
    
        #region HeSoCongViecService
        private static HeSoCongViecService _HeSoCongViecService;
        /// <summary>
		/// Initializes a new instance of the HeSoCongViecService class.
		/// </summary>
        public static HeSoCongViecService HeSoCongViec
        {
            get
            {
                if(_HeSoCongViecService == null)
                    _HeSoCongViecService = new HeSoCongViecService();
                return _HeSoCongViecService;
            }
        }
        #endregion        
    
        #region KcqKhoiLuongThucTapCuoiKhoaService
        private static KcqKhoiLuongThucTapCuoiKhoaService _KcqKhoiLuongThucTapCuoiKhoaService;
        /// <summary>
		/// Initializes a new instance of the KcqKhoiLuongThucTapCuoiKhoaService class.
		/// </summary>
        public static KcqKhoiLuongThucTapCuoiKhoaService KcqKhoiLuongThucTapCuoiKhoa
        {
            get
            {
                if(_KcqKhoiLuongThucTapCuoiKhoaService == null)
                    _KcqKhoiLuongThucTapCuoiKhoaService = new KcqKhoiLuongThucTapCuoiKhoaService();
                return _KcqKhoiLuongThucTapCuoiKhoaService;
            }
        }
        #endregion        
    
        #region KcqKhoiLuongDoAnTotNghiepChiTietService
        private static KcqKhoiLuongDoAnTotNghiepChiTietService _KcqKhoiLuongDoAnTotNghiepChiTietService;
        /// <summary>
		/// Initializes a new instance of the KcqKhoiLuongDoAnTotNghiepChiTietService class.
		/// </summary>
        public static KcqKhoiLuongDoAnTotNghiepChiTietService KcqKhoiLuongDoAnTotNghiepChiTiet
        {
            get
            {
                if(_KcqKhoiLuongDoAnTotNghiepChiTietService == null)
                    _KcqKhoiLuongDoAnTotNghiepChiTietService = new KcqKhoiLuongDoAnTotNghiepChiTietService();
                return _KcqKhoiLuongDoAnTotNghiepChiTietService;
            }
        }
        #endregion        
    
        #region KcqKhoiLuongGiangDayDoAnTotNghiepService
        private static KcqKhoiLuongGiangDayDoAnTotNghiepService _KcqKhoiLuongGiangDayDoAnTotNghiepService;
        /// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnTotNghiepService class.
		/// </summary>
        public static KcqKhoiLuongGiangDayDoAnTotNghiepService KcqKhoiLuongGiangDayDoAnTotNghiep
        {
            get
            {
                if(_KcqKhoiLuongGiangDayDoAnTotNghiepService == null)
                    _KcqKhoiLuongGiangDayDoAnTotNghiepService = new KcqKhoiLuongGiangDayDoAnTotNghiepService();
                return _KcqKhoiLuongGiangDayDoAnTotNghiepService;
            }
        }
        #endregion        
    
        #region DinhMucGioChuanToiThieuTheoChucVuService
        private static DinhMucGioChuanToiThieuTheoChucVuService _DinhMucGioChuanToiThieuTheoChucVuService;
        /// <summary>
		/// Initializes a new instance of the DinhMucGioChuanToiThieuTheoChucVuService class.
		/// </summary>
        public static DinhMucGioChuanToiThieuTheoChucVuService DinhMucGioChuanToiThieuTheoChucVu
        {
            get
            {
                if(_DinhMucGioChuanToiThieuTheoChucVuService == null)
                    _DinhMucGioChuanToiThieuTheoChucVuService = new DinhMucGioChuanToiThieuTheoChucVuService();
                return _DinhMucGioChuanToiThieuTheoChucVuService;
            }
        }
        #endregion        
    
        #region KcqKhoanQuyDoiService
        private static KcqKhoanQuyDoiService _KcqKhoanQuyDoiService;
        /// <summary>
		/// Initializes a new instance of the KcqKhoanQuyDoiService class.
		/// </summary>
        public static KcqKhoanQuyDoiService KcqKhoanQuyDoi
        {
            get
            {
                if(_KcqKhoanQuyDoiService == null)
                    _KcqKhoanQuyDoiService = new KcqKhoanQuyDoiService();
                return _KcqKhoanQuyDoiService;
            }
        }
        #endregion        
    
        #region KcqHeSoCoSoService
        private static KcqHeSoCoSoService _KcqHeSoCoSoService;
        /// <summary>
		/// Initializes a new instance of the KcqHeSoCoSoService class.
		/// </summary>
        public static KcqHeSoCoSoService KcqHeSoCoSo
        {
            get
            {
                if(_KcqHeSoCoSoService == null)
                    _KcqHeSoCoSoService = new KcqHeSoCoSoService();
                return _KcqHeSoCoSoService;
            }
        }
        #endregion        
    
        #region KcqMonXepLichChuNhatKhongTinhHeSoService
        private static KcqMonXepLichChuNhatKhongTinhHeSoService _KcqMonXepLichChuNhatKhongTinhHeSoService;
        /// <summary>
		/// Initializes a new instance of the KcqMonXepLichChuNhatKhongTinhHeSoService class.
		/// </summary>
        public static KcqMonXepLichChuNhatKhongTinhHeSoService KcqMonXepLichChuNhatKhongTinhHeSo
        {
            get
            {
                if(_KcqMonXepLichChuNhatKhongTinhHeSoService == null)
                    _KcqMonXepLichChuNhatKhongTinhHeSoService = new KcqMonXepLichChuNhatKhongTinhHeSoService();
                return _KcqMonXepLichChuNhatKhongTinhHeSoService;
            }
        }
        #endregion        
    
        #region KcqKhoiLuongKhacService
        private static KcqKhoiLuongKhacService _KcqKhoiLuongKhacService;
        /// <summary>
		/// Initializes a new instance of the KcqKhoiLuongKhacService class.
		/// </summary>
        public static KcqKhoiLuongKhacService KcqKhoiLuongKhac
        {
            get
            {
                if(_KcqKhoiLuongKhacService == null)
                    _KcqKhoiLuongKhacService = new KcqKhoiLuongKhacService();
                return _KcqKhoiLuongKhacService;
            }
        }
        #endregion        
    
        #region KcqHeSoDiaDiemService
        private static KcqHeSoDiaDiemService _KcqHeSoDiaDiemService;
        /// <summary>
		/// Initializes a new instance of the KcqHeSoDiaDiemService class.
		/// </summary>
        public static KcqHeSoDiaDiemService KcqHeSoDiaDiem
        {
            get
            {
                if(_KcqHeSoDiaDiemService == null)
                    _KcqHeSoDiaDiemService = new KcqHeSoDiaDiemService();
                return _KcqHeSoDiaDiemService;
            }
        }
        #endregion        
    
        #region KcqPhanBienLuanAnService
        private static KcqPhanBienLuanAnService _KcqPhanBienLuanAnService;
        /// <summary>
		/// Initializes a new instance of the KcqPhanBienLuanAnService class.
		/// </summary>
        public static KcqPhanBienLuanAnService KcqPhanBienLuanAn
        {
            get
            {
                if(_KcqPhanBienLuanAnService == null)
                    _KcqPhanBienLuanAnService = new KcqPhanBienLuanAnService();
                return _KcqPhanBienLuanAnService;
            }
        }
        #endregion        
    
        #region KcqDonGiaNgoaiQuyCheService
        private static KcqDonGiaNgoaiQuyCheService _KcqDonGiaNgoaiQuyCheService;
        /// <summary>
		/// Initializes a new instance of the KcqDonGiaNgoaiQuyCheService class.
		/// </summary>
        public static KcqDonGiaNgoaiQuyCheService KcqDonGiaNgoaiQuyChe
        {
            get
            {
                if(_KcqDonGiaNgoaiQuyCheService == null)
                    _KcqDonGiaNgoaiQuyCheService = new KcqDonGiaNgoaiQuyCheService();
                return _KcqDonGiaNgoaiQuyCheService;
            }
        }
        #endregion        
    
        #region KcqChotKhoiLuongGiangDayService
        private static KcqChotKhoiLuongGiangDayService _KcqChotKhoiLuongGiangDayService;
        /// <summary>
		/// Initializes a new instance of the KcqChotKhoiLuongGiangDayService class.
		/// </summary>
        public static KcqChotKhoiLuongGiangDayService KcqChotKhoiLuongGiangDay
        {
            get
            {
                if(_KcqChotKhoiLuongGiangDayService == null)
                    _KcqChotKhoiLuongGiangDayService = new KcqChotKhoiLuongGiangDayService();
                return _KcqChotKhoiLuongGiangDayService;
            }
        }
        #endregion        
    
        #region KcqKhoiLuongGiangDayDoAnService
        private static KcqKhoiLuongGiangDayDoAnService _KcqKhoiLuongGiangDayDoAnService;
        /// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnService class.
		/// </summary>
        public static KcqKhoiLuongGiangDayDoAnService KcqKhoiLuongGiangDayDoAn
        {
            get
            {
                if(_KcqKhoiLuongGiangDayDoAnService == null)
                    _KcqKhoiLuongGiangDayDoAnService = new KcqKhoiLuongGiangDayDoAnService();
                return _KcqKhoiLuongGiangDayDoAnService;
            }
        }
        #endregion        
    
        #region KcqKetQuaThanhToanThuLaoService
        private static KcqKetQuaThanhToanThuLaoService _KcqKetQuaThanhToanThuLaoService;
        /// <summary>
		/// Initializes a new instance of the KcqKetQuaThanhToanThuLaoService class.
		/// </summary>
        public static KcqKetQuaThanhToanThuLaoService KcqKetQuaThanhToanThuLao
        {
            get
            {
                if(_KcqKetQuaThanhToanThuLaoService == null)
                    _KcqKetQuaThanhToanThuLaoService = new KcqKetQuaThanhToanThuLaoService();
                return _KcqKetQuaThanhToanThuLaoService;
            }
        }
        #endregion        
    
        #region HeSoBacDaoTaoService
        private static HeSoBacDaoTaoService _HeSoBacDaoTaoService;
        /// <summary>
		/// Initializes a new instance of the HeSoBacDaoTaoService class.
		/// </summary>
        public static HeSoBacDaoTaoService HeSoBacDaoTao
        {
            get
            {
                if(_HeSoBacDaoTaoService == null)
                    _HeSoBacDaoTaoService = new HeSoBacDaoTaoService();
                return _HeSoBacDaoTaoService;
            }
        }
        #endregion        
    
        #region KcqUteKhoiLuongQuyDoiService
        private static KcqUteKhoiLuongQuyDoiService _KcqUteKhoiLuongQuyDoiService;
        /// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongQuyDoiService class.
		/// </summary>
        public static KcqUteKhoiLuongQuyDoiService KcqUteKhoiLuongQuyDoi
        {
            get
            {
                if(_KcqUteKhoiLuongQuyDoiService == null)
                    _KcqUteKhoiLuongQuyDoiService = new KcqUteKhoiLuongQuyDoiService();
                return _KcqUteKhoiLuongQuyDoiService;
            }
        }
        #endregion        
    
        #region KcqMonPhanCongNhieuGiangVienService
        private static KcqMonPhanCongNhieuGiangVienService _KcqMonPhanCongNhieuGiangVienService;
        /// <summary>
		/// Initializes a new instance of the KcqMonPhanCongNhieuGiangVienService class.
		/// </summary>
        public static KcqMonPhanCongNhieuGiangVienService KcqMonPhanCongNhieuGiangVien
        {
            get
            {
                if(_KcqMonPhanCongNhieuGiangVienService == null)
                    _KcqMonPhanCongNhieuGiangVienService = new KcqMonPhanCongNhieuGiangVienService();
                return _KcqMonPhanCongNhieuGiangVienService;
            }
        }
        #endregion        
    
        #region KcqMonTieuLuanService
        private static KcqMonTieuLuanService _KcqMonTieuLuanService;
        /// <summary>
		/// Initializes a new instance of the KcqMonTieuLuanService class.
		/// </summary>
        public static KcqMonTieuLuanService KcqMonTieuLuan
        {
            get
            {
                if(_KcqMonTieuLuanService == null)
                    _KcqMonTieuLuanService = new KcqMonTieuLuanService();
                return _KcqMonTieuLuanService;
            }
        }
        #endregion        
    
        #region GiangVienService
        private static GiangVienService _GiangVienService;
        /// <summary>
		/// Initializes a new instance of the GiangVienService class.
		/// </summary>
        public static GiangVienService GiangVien
        {
            get
            {
                if(_GiangVienService == null)
                    _GiangVienService = new GiangVienService();
                return _GiangVienService;
            }
        }
        #endregion        
    
        #region KcqPhuCapHanhChinhService
        private static KcqPhuCapHanhChinhService _KcqPhuCapHanhChinhService;
        /// <summary>
		/// Initializes a new instance of the KcqPhuCapHanhChinhService class.
		/// </summary>
        public static KcqPhuCapHanhChinhService KcqPhuCapHanhChinh
        {
            get
            {
                if(_KcqPhuCapHanhChinhService == null)
                    _KcqPhuCapHanhChinhService = new KcqPhuCapHanhChinhService();
                return _KcqPhuCapHanhChinhService;
            }
        }
        #endregion        
    
        #region GiangVienGiangDayGdtcQpService
        private static GiangVienGiangDayGdtcQpService _GiangVienGiangDayGdtcQpService;
        /// <summary>
		/// Initializes a new instance of the GiangVienGiangDayGdtcQpService class.
		/// </summary>
        public static GiangVienGiangDayGdtcQpService GiangVienGiangDayGdtcQp
        {
            get
            {
                if(_GiangVienGiangDayGdtcQpService == null)
                    _GiangVienGiangDayGdtcQpService = new GiangVienGiangDayGdtcQpService();
                return _GiangVienGiangDayGdtcQpService;
            }
        }
        #endregion        
    
        #region KcqHeSoHocKyService
        private static KcqHeSoHocKyService _KcqHeSoHocKyService;
        /// <summary>
		/// Initializes a new instance of the KcqHeSoHocKyService class.
		/// </summary>
        public static KcqHeSoHocKyService KcqHeSoHocKy
        {
            get
            {
                if(_KcqHeSoHocKyService == null)
                    _KcqHeSoHocKyService = new KcqHeSoHocKyService();
                return _KcqHeSoHocKyService;
            }
        }
        #endregion        
    
        #region KcqPhanNhomMonHocService
        private static KcqPhanNhomMonHocService _KcqPhanNhomMonHocService;
        /// <summary>
		/// Initializes a new instance of the KcqPhanNhomMonHocService class.
		/// </summary>
        public static KcqPhanNhomMonHocService KcqPhanNhomMonHoc
        {
            get
            {
                if(_KcqPhanNhomMonHocService == null)
                    _KcqPhanNhomMonHocService = new KcqPhanNhomMonHocService();
                return _KcqPhanNhomMonHocService;
            }
        }
        #endregion        
    
        #region KetQuaThanhToanThuLaoService
        private static KetQuaThanhToanThuLaoService _KetQuaThanhToanThuLaoService;
        /// <summary>
		/// Initializes a new instance of the KetQuaThanhToanThuLaoService class.
		/// </summary>
        public static KetQuaThanhToanThuLaoService KetQuaThanhToanThuLao
        {
            get
            {
                if(_KetQuaThanhToanThuLaoService == null)
                    _KetQuaThanhToanThuLaoService = new KetQuaThanhToanThuLaoService();
                return _KetQuaThanhToanThuLaoService;
            }
        }
        #endregion        
    
        #region KcqNhomMonHocService
        private static KcqNhomMonHocService _KcqNhomMonHocService;
        /// <summary>
		/// Initializes a new instance of the KcqNhomMonHocService class.
		/// </summary>
        public static KcqNhomMonHocService KcqNhomMonHoc
        {
            get
            {
                if(_KcqNhomMonHocService == null)
                    _KcqNhomMonHocService = new KcqNhomMonHocService();
                return _KcqNhomMonHocService;
            }
        }
        #endregion        
    
        #region KcqMonTinhTheoQuyCheMoiService
        private static KcqMonTinhTheoQuyCheMoiService _KcqMonTinhTheoQuyCheMoiService;
        /// <summary>
		/// Initializes a new instance of the KcqMonTinhTheoQuyCheMoiService class.
		/// </summary>
        public static KcqMonTinhTheoQuyCheMoiService KcqMonTinhTheoQuyCheMoi
        {
            get
            {
                if(_KcqMonTinhTheoQuyCheMoiService == null)
                    _KcqMonTinhTheoQuyCheMoiService = new KcqMonTinhTheoQuyCheMoiService();
                return _KcqMonTinhTheoQuyCheMoiService;
            }
        }
        #endregion        
    
        #region KcqCauHinhChotGioService
        private static KcqCauHinhChotGioService _KcqCauHinhChotGioService;
        /// <summary>
		/// Initializes a new instance of the KcqCauHinhChotGioService class.
		/// </summary>
        public static KcqCauHinhChotGioService KcqCauHinhChotGio
        {
            get
            {
                if(_KcqCauHinhChotGioService == null)
                    _KcqCauHinhChotGioService = new KcqCauHinhChotGioService();
                return _KcqCauHinhChotGioService;
            }
        }
        #endregion        
    
        #region KcqPhanLoaiHocPhanService
        private static KcqPhanLoaiHocPhanService _KcqPhanLoaiHocPhanService;
        /// <summary>
		/// Initializes a new instance of the KcqPhanLoaiHocPhanService class.
		/// </summary>
        public static KcqPhanLoaiHocPhanService KcqPhanLoaiHocPhan
        {
            get
            {
                if(_KcqPhanLoaiHocPhanService == null)
                    _KcqPhanLoaiHocPhanService = new KcqPhanLoaiHocPhanService();
                return _KcqPhanLoaiHocPhanService;
            }
        }
        #endregion        
    
        #region KcqMonThucTapTotNghiepService
        private static KcqMonThucTapTotNghiepService _KcqMonThucTapTotNghiepService;
        /// <summary>
		/// Initializes a new instance of the KcqMonThucTapTotNghiepService class.
		/// </summary>
        public static KcqMonThucTapTotNghiepService KcqMonThucTapTotNghiep
        {
            get
            {
                if(_KcqMonThucTapTotNghiepService == null)
                    _KcqMonThucTapTotNghiepService = new KcqMonThucTapTotNghiepService();
                return _KcqMonThucTapTotNghiepService;
            }
        }
        #endregion        
    
        #region KcqMonHocKhongTinhKhoiLuongService
        private static KcqMonHocKhongTinhKhoiLuongService _KcqMonHocKhongTinhKhoiLuongService;
        /// <summary>
		/// Initializes a new instance of the KcqMonHocKhongTinhKhoiLuongService class.
		/// </summary>
        public static KcqMonHocKhongTinhKhoiLuongService KcqMonHocKhongTinhKhoiLuong
        {
            get
            {
                if(_KcqMonHocKhongTinhKhoiLuongService == null)
                    _KcqMonHocKhongTinhKhoiLuongService = new KcqMonHocKhongTinhKhoiLuongService();
                return _KcqMonHocKhongTinhKhoiLuongService;
            }
        }
        #endregion        
    
        #region KcqHeSoQuyDoiTinChiService
        private static KcqHeSoQuyDoiTinChiService _KcqHeSoQuyDoiTinChiService;
        /// <summary>
		/// Initializes a new instance of the KcqHeSoQuyDoiTinChiService class.
		/// </summary>
        public static KcqHeSoQuyDoiTinChiService KcqHeSoQuyDoiTinChi
        {
            get
            {
                if(_KcqHeSoQuyDoiTinChiService == null)
                    _KcqHeSoQuyDoiTinChiService = new KcqHeSoQuyDoiTinChiService();
                return _KcqHeSoQuyDoiTinChiService;
            }
        }
        #endregion        
    
        #region KcqDonGiaService
        private static KcqDonGiaService _KcqDonGiaService;
        /// <summary>
		/// Initializes a new instance of the KcqDonGiaService class.
		/// </summary>
        public static KcqDonGiaService KcqDonGia
        {
            get
            {
                if(_KcqDonGiaService == null)
                    _KcqDonGiaService = new KcqDonGiaService();
                return _KcqDonGiaService;
            }
        }
        #endregion        
    
        #region KcqLoaiKhoiLuongService
        private static KcqLoaiKhoiLuongService _KcqLoaiKhoiLuongService;
        /// <summary>
		/// Initializes a new instance of the KcqLoaiKhoiLuongService class.
		/// </summary>
        public static KcqLoaiKhoiLuongService KcqLoaiKhoiLuong
        {
            get
            {
                if(_KcqLoaiKhoiLuongService == null)
                    _KcqLoaiKhoiLuongService = new KcqLoaiKhoiLuongService();
                return _KcqLoaiKhoiLuongService;
            }
        }
        #endregion        
    
        #region HeSoNhomMonService
        private static HeSoNhomMonService _HeSoNhomMonService;
        /// <summary>
		/// Initializes a new instance of the HeSoNhomMonService class.
		/// </summary>
        public static HeSoNhomMonService HeSoNhomMon
        {
            get
            {
                if(_HeSoNhomMonService == null)
                    _HeSoNhomMonService = new HeSoNhomMonService();
                return _HeSoNhomMonService;
            }
        }
        #endregion        
    
        #region HoatDongNgoaiGiangDayClcService
        private static HoatDongNgoaiGiangDayClcService _HoatDongNgoaiGiangDayClcService;
        /// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayClcService class.
		/// </summary>
        public static HoatDongNgoaiGiangDayClcService HoatDongNgoaiGiangDayClc
        {
            get
            {
                if(_HoatDongNgoaiGiangDayClcService == null)
                    _HoatDongNgoaiGiangDayClcService = new HoatDongNgoaiGiangDayClcService();
                return _HoatDongNgoaiGiangDayClcService;
            }
        }
        #endregion        
    
        #region HeThongService
        private static HeThongService _HeThongService;
        /// <summary>
		/// Initializes a new instance of the HeThongService class.
		/// </summary>
        public static HeThongService HeThong
        {
            get
            {
                if(_HeThongService == null)
                    _HeThongService = new HeThongService();
                return _HeThongService;
            }
        }
        #endregion        
    
        #region HeSoCoSoService
        private static HeSoCoSoService _HeSoCoSoService;
        /// <summary>
		/// Initializes a new instance of the HeSoCoSoService class.
		/// </summary>
        public static HeSoCoSoService HeSoCoSo
        {
            get
            {
                if(_HeSoCoSoService == null)
                    _HeSoCoSoService = new HeSoCoSoService();
                return _HeSoCoSoService;
            }
        }
        #endregion        
    
        #region HeSoNgayService
        private static HeSoNgayService _HeSoNgayService;
        /// <summary>
		/// Initializes a new instance of the HeSoNgayService class.
		/// </summary>
        public static HeSoNgayService HeSoNgay
        {
            get
            {
                if(_HeSoNgayService == null)
                    _HeSoNgayService = new HeSoNgayService();
                return _HeSoNgayService;
            }
        }
        #endregion        
    
        #region HeSoKhoiLuongCongThemService
        private static HeSoKhoiLuongCongThemService _HeSoKhoiLuongCongThemService;
        /// <summary>
		/// Initializes a new instance of the HeSoKhoiLuongCongThemService class.
		/// </summary>
        public static HeSoKhoiLuongCongThemService HeSoKhoiLuongCongThem
        {
            get
            {
                if(_HeSoKhoiLuongCongThemService == null)
                    _HeSoKhoiLuongCongThemService = new HeSoKhoiLuongCongThemService();
                return _HeSoKhoiLuongCongThemService;
            }
        }
        #endregion        
    
        #region HoatDongNgoaiGiangDayService
        private static HoatDongNgoaiGiangDayService _HoatDongNgoaiGiangDayService;
        /// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayService class.
		/// </summary>
        public static HoatDongNgoaiGiangDayService HoatDongNgoaiGiangDay
        {
            get
            {
                if(_HoatDongNgoaiGiangDayService == null)
                    _HoatDongNgoaiGiangDayService = new HoatDongNgoaiGiangDayService();
                return _HoatDongNgoaiGiangDayService;
            }
        }
        #endregion        
    
        #region HeSoLuongService
        private static HeSoLuongService _HeSoLuongService;
        /// <summary>
		/// Initializes a new instance of the HeSoLuongService class.
		/// </summary>
        public static HeSoLuongService HeSoLuong
        {
            get
            {
                if(_HeSoLuongService == null)
                    _HeSoLuongService = new HeSoLuongService();
                return _HeSoLuongService;
            }
        }
        #endregion        
    
        #region HeSoCoVanHocTapService
        private static HeSoCoVanHocTapService _HeSoCoVanHocTapService;
        /// <summary>
		/// Initializes a new instance of the HeSoCoVanHocTapService class.
		/// </summary>
        public static HeSoCoVanHocTapService HeSoCoVanHocTap
        {
            get
            {
                if(_HeSoCoVanHocTapService == null)
                    _HeSoCoVanHocTapService = new HeSoCoVanHocTapService();
                return _HeSoCoVanHocTapService;
            }
        }
        #endregion        
    
        #region HeSoHocKyService
        private static HeSoHocKyService _HeSoHocKyService;
        /// <summary>
		/// Initializes a new instance of the HeSoHocKyService class.
		/// </summary>
        public static HeSoHocKyService HeSoHocKy
        {
            get
            {
                if(_HeSoHocKyService == null)
                    _HeSoHocKyService = new HeSoHocKyService();
                return _HeSoHocKyService;
            }
        }
        #endregion        
    
        #region HeSoNgoaiGioService
        private static HeSoNgoaiGioService _HeSoNgoaiGioService;
        /// <summary>
		/// Initializes a new instance of the HeSoNgoaiGioService class.
		/// </summary>
        public static HeSoNgoaiGioService HeSoNgoaiGio
        {
            get
            {
                if(_HeSoNgoaiGioService == null)
                    _HeSoNgoaiGioService = new HeSoNgoaiGioService();
                return _HeSoNgoaiGioService;
            }
        }
        #endregion        
    
        #region HeSoNhomThucHanhService
        private static HeSoNhomThucHanhService _HeSoNhomThucHanhService;
        /// <summary>
		/// Initializes a new instance of the HeSoNhomThucHanhService class.
		/// </summary>
        public static HeSoNhomThucHanhService HeSoNhomThucHanh
        {
            get
            {
                if(_HeSoNhomThucHanhService == null)
                    _HeSoNhomThucHanhService = new HeSoNhomThucHanhService();
                return _HeSoNhomThucHanhService;
            }
        }
        #endregion        
    
        #region KcqNhomKhoiLuongService
        private static KcqNhomKhoiLuongService _KcqNhomKhoiLuongService;
        /// <summary>
		/// Initializes a new instance of the KcqNhomKhoiLuongService class.
		/// </summary>
        public static KcqNhomKhoiLuongService KcqNhomKhoiLuong
        {
            get
            {
                if(_KcqNhomKhoiLuongService == null)
                    _KcqNhomKhoiLuongService = new KcqNhomKhoiLuongService();
                return _KcqNhomKhoiLuongService;
            }
        }
        #endregion        
    
        #region HeSoChucDanhKhoiLuongKhacService
        private static HeSoChucDanhKhoiLuongKhacService _HeSoChucDanhKhoiLuongKhacService;
        /// <summary>
		/// Initializes a new instance of the HeSoChucDanhKhoiLuongKhacService class.
		/// </summary>
        public static HeSoChucDanhKhoiLuongKhacService HeSoChucDanhKhoiLuongKhac
        {
            get
            {
                if(_HeSoChucDanhKhoiLuongKhacService == null)
                    _HeSoChucDanhKhoiLuongKhacService = new HeSoChucDanhKhoiLuongKhacService();
                return _HeSoChucDanhKhoiLuongKhacService;
            }
        }
        #endregion        
    
        #region HeSoChucDanhTietNghiaVuService
        private static HeSoChucDanhTietNghiaVuService _HeSoChucDanhTietNghiaVuService;
        /// <summary>
		/// Initializes a new instance of the HeSoChucDanhTietNghiaVuService class.
		/// </summary>
        public static HeSoChucDanhTietNghiaVuService HeSoChucDanhTietNghiaVu
        {
            get
            {
                if(_HeSoChucDanhTietNghiaVuService == null)
                    _HeSoChucDanhTietNghiaVuService = new HeSoChucDanhTietNghiaVuService();
                return _HeSoChucDanhTietNghiaVuService;
            }
        }
        #endregion        
    
        #region HeSoKhoiNganhService
        private static HeSoKhoiNganhService _HeSoKhoiNganhService;
        /// <summary>
		/// Initializes a new instance of the HeSoKhoiNganhService class.
		/// </summary>
        public static HeSoKhoiNganhService HeSoKhoiNganh
        {
            get
            {
                if(_HeSoKhoiNganhService == null)
                    _HeSoKhoiNganhService = new HeSoKhoiNganhService();
                return _HeSoKhoiNganhService;
            }
        }
        #endregion        
    
        #region HeSoNgonNguService
        private static HeSoNgonNguService _HeSoNgonNguService;
        /// <summary>
		/// Initializes a new instance of the HeSoNgonNguService class.
		/// </summary>
        public static HeSoNgonNguService HeSoNgonNgu
        {
            get
            {
                if(_HeSoNgonNguService == null)
                    _HeSoNgonNguService = new HeSoNgonNguService();
                return _HeSoNgonNguService;
            }
        }
        #endregion        
    
        #region HoSoService
        private static HoSoService _HoSoService;
        /// <summary>
		/// Initializes a new instance of the HoSoService class.
		/// </summary>
        public static HoSoService HoSo
        {
            get
            {
                if(_HoSoService == null)
                    _HoSoService = new HoSoService();
                return _HoSoService;
            }
        }
        #endregion        
    
        #region HopDongThinhGiangService
        private static HopDongThinhGiangService _HopDongThinhGiangService;
        /// <summary>
		/// Initializes a new instance of the HopDongThinhGiangService class.
		/// </summary>
        public static HopDongThinhGiangService HopDongThinhGiang
        {
            get
            {
                if(_HopDongThinhGiangService == null)
                    _HopDongThinhGiangService = new HopDongThinhGiangService();
                return _HopDongThinhGiangService;
            }
        }
        #endregion        
    
        #region HeSoThamNienService
        private static HeSoThamNienService _HeSoThamNienService;
        /// <summary>
		/// Initializes a new instance of the HeSoThamNienService class.
		/// </summary>
        public static HeSoThamNienService HeSoThamNien
        {
            get
            {
                if(_HeSoThamNienService == null)
                    _HeSoThamNienService = new HeSoThamNienService();
                return _HeSoThamNienService;
            }
        }
        #endregion        
    
        #region HeSoThoiGianGiangDayService
        private static HeSoThoiGianGiangDayService _HeSoThoiGianGiangDayService;
        /// <summary>
		/// Initializes a new instance of the HeSoThoiGianGiangDayService class.
		/// </summary>
        public static HeSoThoiGianGiangDayService HeSoThoiGianGiangDay
        {
            get
            {
                if(_HeSoThoiGianGiangDayService == null)
                    _HeSoThoiGianGiangDayService = new HeSoThoiGianGiangDayService();
                return _HeSoThoiGianGiangDayService;
            }
        }
        #endregion        
    
        #region HuongDanKhoaLuanThucTapService
        private static HuongDanKhoaLuanThucTapService _HuongDanKhoaLuanThucTapService;
        /// <summary>
		/// Initializes a new instance of the HuongDanKhoaLuanThucTapService class.
		/// </summary>
        public static HuongDanKhoaLuanThucTapService HuongDanKhoaLuanThucTap
        {
            get
            {
                if(_HuongDanKhoaLuanThucTapService == null)
                    _HuongDanKhoaLuanThucTapService = new HuongDanKhoaLuanThucTapService();
                return _HuongDanKhoaLuanThucTapService;
            }
        }
        #endregion        
    
        #region HoatDongChuyenMonKhacService
        private static HoatDongChuyenMonKhacService _HoatDongChuyenMonKhacService;
        /// <summary>
		/// Initializes a new instance of the HoatDongChuyenMonKhacService class.
		/// </summary>
        public static HoatDongChuyenMonKhacService HoatDongChuyenMonKhac
        {
            get
            {
                if(_HoatDongChuyenMonKhacService == null)
                    _HoatDongChuyenMonKhacService = new HoatDongChuyenMonKhacService();
                return _HoatDongChuyenMonKhacService;
            }
        }
        #endregion        
    
        #region HeSoLopDongService
        private static HeSoLopDongService _HeSoLopDongService;
        /// <summary>
		/// Initializes a new instance of the HeSoLopDongService class.
		/// </summary>
        public static HeSoLopDongService HeSoLopDong
        {
            get
            {
                if(_HeSoLopDongService == null)
                    _HeSoLopDongService = new HeSoLopDongService();
                return _HeSoLopDongService;
            }
        }
        #endregion        
    
        #region HeSoQuyDoiGioChuanService
        private static HeSoQuyDoiGioChuanService _HeSoQuyDoiGioChuanService;
        /// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioChuanService class.
		/// </summary>
        public static HeSoQuyDoiGioChuanService HeSoQuyDoiGioChuan
        {
            get
            {
                if(_HeSoQuyDoiGioChuanService == null)
                    _HeSoQuyDoiGioChuanService = new HeSoQuyDoiGioChuanService();
                return _HeSoQuyDoiGioChuanService;
            }
        }
        #endregion        
    
        #region HistoryService
        private static HistoryService _HistoryService;
        /// <summary>
		/// Initializes a new instance of the HistoryService class.
		/// </summary>
        public static HistoryService History
        {
            get
            {
                if(_HistoryService == null)
                    _HistoryService = new HistoryService();
                return _HistoryService;
            }
        }
        #endregion        
    
        #region KcqHopDongThinhGiangService
        private static KcqHopDongThinhGiangService _KcqHopDongThinhGiangService;
        /// <summary>
		/// Initializes a new instance of the KcqHopDongThinhGiangService class.
		/// </summary>
        public static KcqHopDongThinhGiangService KcqHopDongThinhGiang
        {
            get
            {
                if(_KcqHopDongThinhGiangService == null)
                    _KcqHopDongThinhGiangService = new KcqHopDongThinhGiangService();
                return _KcqHopDongThinhGiangService;
            }
        }
        #endregion        
    
        #region HeSoTinChiService
        private static HeSoTinChiService _HeSoTinChiService;
        /// <summary>
		/// Initializes a new instance of the HeSoTinChiService class.
		/// </summary>
        public static HeSoTinChiService HeSoTinChi
        {
            get
            {
                if(_HeSoTinChiService == null)
                    _HeSoTinChiService = new HeSoTinChiService();
                return _HeSoTinChiService;
            }
        }
        #endregion        
    
        #region HeSoThucTapService
        private static HeSoThucTapService _HeSoThucTapService;
        /// <summary>
		/// Initializes a new instance of the HeSoThucTapService class.
		/// </summary>
        public static HeSoThucTapService HeSoThucTap
        {
            get
            {
                if(_HeSoThucTapService == null)
                    _HeSoThucTapService = new HeSoThucTapService();
                return _HeSoThucTapService;
            }
        }
        #endregion        
    
        #region XetDuyetDeCuongLuanVanCaoHocService
        private static XetDuyetDeCuongLuanVanCaoHocService _XetDuyetDeCuongLuanVanCaoHocService;
        /// <summary>
		/// Initializes a new instance of the XetDuyetDeCuongLuanVanCaoHocService class.
		/// </summary>
        public static XetDuyetDeCuongLuanVanCaoHocService XetDuyetDeCuongLuanVanCaoHoc
        {
            get
            {
                if(_XetDuyetDeCuongLuanVanCaoHocService == null)
                    _XetDuyetDeCuongLuanVanCaoHocService = new XetDuyetDeCuongLuanVanCaoHocService();
                return _XetDuyetDeCuongLuanVanCaoHocService;
            }
        }
        #endregion        
    
        #region HinhThucDaoTaoService
        private static HinhThucDaoTaoService _HinhThucDaoTaoService;
        /// <summary>
		/// Initializes a new instance of the HinhThucDaoTaoService class.
		/// </summary>
        public static HinhThucDaoTaoService HinhThucDaoTao
        {
            get
            {
                if(_HinhThucDaoTaoService == null)
                    _HinhThucDaoTaoService = new HinhThucDaoTaoService();
                return _HinhThucDaoTaoService;
            }
        }
        #endregion        
    
        #region HeSoThanhToanGioChuanVuotMucService
        private static HeSoThanhToanGioChuanVuotMucService _HeSoThanhToanGioChuanVuotMucService;
        /// <summary>
		/// Initializes a new instance of the HeSoThanhToanGioChuanVuotMucService class.
		/// </summary>
        public static HeSoThanhToanGioChuanVuotMucService HeSoThanhToanGioChuanVuotMuc
        {
            get
            {
                if(_HeSoThanhToanGioChuanVuotMucService == null)
                    _HeSoThanhToanGioChuanVuotMucService = new HeSoThanhToanGioChuanVuotMucService();
                return _HeSoThanhToanGioChuanVuotMucService;
            }
        }
        #endregion        
    
        #region HeSoQuyDoiTinChiService
        private static HeSoQuyDoiTinChiService _HeSoQuyDoiTinChiService;
        /// <summary>
		/// Initializes a new instance of the HeSoQuyDoiTinChiService class.
		/// </summary>
        public static HeSoQuyDoiTinChiService HeSoQuyDoiTinChi
        {
            get
            {
                if(_HeSoQuyDoiTinChiService == null)
                    _HeSoQuyDoiTinChiService = new HeSoQuyDoiTinChiService();
                return _HeSoQuyDoiTinChiService;
            }
        }
        #endregion        
    
        #region ThuLaoThoaThuanService
        private static ThuLaoThoaThuanService _ThuLaoThoaThuanService;
        /// <summary>
		/// Initializes a new instance of the ThuLaoThoaThuanService class.
		/// </summary>
        public static ThuLaoThoaThuanService ThuLaoThoaThuan
        {
            get
            {
                if(_ThuLaoThoaThuanService == null)
                    _ThuLaoThoaThuanService = new ThuLaoThoaThuanService();
                return _ThuLaoThoaThuanService;
            }
        }
        #endregion        
    
        #region UteThanhToanThuLaoService
        private static UteThanhToanThuLaoService _UteThanhToanThuLaoService;
        /// <summary>
		/// Initializes a new instance of the UteThanhToanThuLaoService class.
		/// </summary>
        public static UteThanhToanThuLaoService UteThanhToanThuLao
        {
            get
            {
                if(_UteThanhToanThuLaoService == null)
                    _UteThanhToanThuLaoService = new UteThanhToanThuLaoService();
                return _UteThanhToanThuLaoService;
            }
        }
        #endregion        
    
        #region HeSoQuyDoiGioTroiService
        private static HeSoQuyDoiGioTroiService _HeSoQuyDoiGioTroiService;
        /// <summary>
		/// Initializes a new instance of the HeSoQuyDoiGioTroiService class.
		/// </summary>
        public static HeSoQuyDoiGioTroiService HeSoQuyDoiGioTroi
        {
            get
            {
                if(_HeSoQuyDoiGioTroiService == null)
                    _HeSoQuyDoiGioTroiService = new HeSoQuyDoiGioTroiService();
                return _HeSoQuyDoiGioTroiService;
            }
        }
        #endregion        
    
        #region VChiTietKhoiLuongService
        private static VChiTietKhoiLuongService _VChiTietKhoiLuongService;
        /// <summary>
		/// Initializes a new instance of the VChiTietKhoiLuongService class.
		/// </summary>
        public static VChiTietKhoiLuongService VChiTietKhoiLuong
        {
            get
            {
                if(_VChiTietKhoiLuongService == null)
                    _VChiTietKhoiLuongService = new VChiTietKhoiLuongService();
                return _VChiTietKhoiLuongService;
            }
        }
        #endregion        
    
        #region VChiTietKhoiLuongThucDayService
        private static VChiTietKhoiLuongThucDayService _VChiTietKhoiLuongThucDayService;
        /// <summary>
		/// Initializes a new instance of the VChiTietKhoiLuongThucDayService class.
		/// </summary>
        public static VChiTietKhoiLuongThucDayService VChiTietKhoiLuongThucDay
        {
            get
            {
                if(_VChiTietKhoiLuongThucDayService == null)
                    _VChiTietKhoiLuongThucDayService = new VChiTietKhoiLuongThucDayService();
                return _VChiTietKhoiLuongThucDayService;
            }
        }
        #endregion        
    
        #region VChiTietQuyDoiService
        private static VChiTietQuyDoiService _VChiTietQuyDoiService;
        /// <summary>
		/// Initializes a new instance of the VChiTietQuyDoiService class.
		/// </summary>
        public static VChiTietQuyDoiService VChiTietQuyDoi
        {
            get
            {
                if(_VChiTietQuyDoiService == null)
                    _VChiTietQuyDoiService = new VChiTietQuyDoiService();
                return _VChiTietQuyDoiService;
            }
        }
        #endregion        
    
        #region VGiangVienChucVuService
        private static VGiangVienChucVuService _VGiangVienChucVuService;
        /// <summary>
		/// Initializes a new instance of the VGiangVienChucVuService class.
		/// </summary>
        public static VGiangVienChucVuService VGiangVienChucVu
        {
            get
            {
                if(_VGiangVienChucVuService == null)
                    _VGiangVienChucVuService = new VGiangVienChucVuService();
                return _VGiangVienChucVuService;
            }
        }
        #endregion        
    
        #region VKhoiLuongThucDayService
        private static VKhoiLuongThucDayService _VKhoiLuongThucDayService;
        /// <summary>
		/// Initializes a new instance of the VKhoiLuongThucDayService class.
		/// </summary>
        public static VKhoiLuongThucDayService VKhoiLuongThucDay
        {
            get
            {
                if(_VKhoiLuongThucDayService == null)
                    _VKhoiLuongThucDayService = new VKhoiLuongThucDayService();
                return _VKhoiLuongThucDayService;
            }
        }
        #endregion        
    
        #region VLopHocPhanKhongPhanCongService
        private static VLopHocPhanKhongPhanCongService _VLopHocPhanKhongPhanCongService;
        /// <summary>
		/// Initializes a new instance of the VLopHocPhanKhongPhanCongService class.
		/// </summary>
        public static VLopHocPhanKhongPhanCongService VLopHocPhanKhongPhanCong
        {
            get
            {
                if(_VLopHocPhanKhongPhanCongService == null)
                    _VLopHocPhanKhongPhanCongService = new VLopHocPhanKhongPhanCongService();
                return _VLopHocPhanKhongPhanCongService;
            }
        }
        #endregion        
    
        #region VMonHocTinChiService
        private static VMonHocTinChiService _VMonHocTinChiService;
        /// <summary>
		/// Initializes a new instance of the VMonHocTinChiService class.
		/// </summary>
        public static VMonHocTinChiService VMonHocTinChi
        {
            get
            {
                if(_VMonHocTinChiService == null)
                    _VMonHocTinChiService = new VMonHocTinChiService();
                return _VMonHocTinChiService;
            }
        }
        #endregion        
    
        #region VThanhToanThuLaoService
        private static VThanhToanThuLaoService _VThanhToanThuLaoService;
        /// <summary>
		/// Initializes a new instance of the VThanhToanThuLaoService class.
		/// </summary>
        public static VThanhToanThuLaoService VThanhToanThuLao
        {
            get
            {
                if(_VThanhToanThuLaoService == null)
                    _VThanhToanThuLaoService = new VThanhToanThuLaoService();
                return _VThanhToanThuLaoService;
            }
        }
        #endregion        
    
        #region VTongHopKhoiLuongService
        private static VTongHopKhoiLuongService _VTongHopKhoiLuongService;
        /// <summary>
		/// Initializes a new instance of the VTongHopKhoiLuongService class.
		/// </summary>
        public static VTongHopKhoiLuongService VTongHopKhoiLuong
        {
            get
            {
                if(_VTongHopKhoiLuongService == null)
                    _VTongHopKhoiLuongService = new VTongHopKhoiLuongService();
                return _VTongHopKhoiLuongService;
            }
        }
        #endregion        
    
        #region VTongHopQuyDoiService
        private static VTongHopQuyDoiService _VTongHopQuyDoiService;
        /// <summary>
		/// Initializes a new instance of the VTongHopQuyDoiService class.
		/// </summary>
        public static VTongHopQuyDoiService VTongHopQuyDoi
        {
            get
            {
                if(_VTongHopQuyDoiService == null)
                    _VTongHopQuyDoiService = new VTongHopQuyDoiService();
                return _VTongHopQuyDoiService;
            }
        }
        #endregion        
    
        #region VTongHopThuLaoService
        private static VTongHopThuLaoService _VTongHopThuLaoService;
        /// <summary>
		/// Initializes a new instance of the VTongHopThuLaoService class.
		/// </summary>
        public static VTongHopThuLaoService VTongHopThuLao
        {
            get
            {
                if(_VTongHopThuLaoService == null)
                    _VTongHopThuLaoService = new VTongHopThuLaoService();
                return _VTongHopThuLaoService;
            }
        }
        #endregion        
    
        #region ViewBacDaoTaoService
        private static ViewBacDaoTaoService _ViewBacDaoTaoService;
        /// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoService class.
		/// </summary>
        public static ViewBacDaoTaoService ViewBacDaoTao
        {
            get
            {
                if(_ViewBacDaoTaoService == null)
                    _ViewBacDaoTaoService = new ViewBacDaoTaoService();
                return _ViewBacDaoTaoService;
            }
        }
        #endregion        
    
        #region ViewBacDaoTaoLoaiHinhService
        private static ViewBacDaoTaoLoaiHinhService _ViewBacDaoTaoLoaiHinhService;
        /// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoLoaiHinhService class.
		/// </summary>
        public static ViewBacDaoTaoLoaiHinhService ViewBacDaoTaoLoaiHinh
        {
            get
            {
                if(_ViewBacDaoTaoLoaiHinhService == null)
                    _ViewBacDaoTaoLoaiHinhService = new ViewBacDaoTaoLoaiHinhService();
                return _ViewBacDaoTaoLoaiHinhService;
            }
        }
        #endregion        
    
        #region ViewBangPhuTroiGioDayGiangVienService
        private static ViewBangPhuTroiGioDayGiangVienService _ViewBangPhuTroiGioDayGiangVienService;
        /// <summary>
		/// Initializes a new instance of the ViewBangPhuTroiGioDayGiangVienService class.
		/// </summary>
        public static ViewBangPhuTroiGioDayGiangVienService ViewBangPhuTroiGioDayGiangVien
        {
            get
            {
                if(_ViewBangPhuTroiGioDayGiangVienService == null)
                    _ViewBangPhuTroiGioDayGiangVienService = new ViewBangPhuTroiGioDayGiangVienService();
                return _ViewBangPhuTroiGioDayGiangVienService;
            }
        }
        #endregion        
    
        #region ViewBuoiService
        private static ViewBuoiService _ViewBuoiService;
        /// <summary>
		/// Initializes a new instance of the ViewBuoiService class.
		/// </summary>
        public static ViewBuoiService ViewBuoi
        {
            get
            {
                if(_ViewBuoiService == null)
                    _ViewBuoiService = new ViewBuoiService();
                return _ViewBuoiService;
            }
        }
        #endregion        
    
        #region ViewCauHinhService
        private static ViewCauHinhService _ViewCauHinhService;
        /// <summary>
		/// Initializes a new instance of the ViewCauHinhService class.
		/// </summary>
        public static ViewCauHinhService ViewCauHinh
        {
            get
            {
                if(_ViewCauHinhService == null)
                    _ViewCauHinhService = new ViewCauHinhService();
                return _ViewCauHinhService;
            }
        }
        #endregion        
    
        #region ViewChiTienCoVanService
        private static ViewChiTienCoVanService _ViewChiTienCoVanService;
        /// <summary>
		/// Initializes a new instance of the ViewChiTienCoVanService class.
		/// </summary>
        public static ViewChiTienCoVanService ViewChiTienCoVan
        {
            get
            {
                if(_ViewChiTienCoVanService == null)
                    _ViewChiTienCoVanService = new ViewChiTienCoVanService();
                return _ViewChiTienCoVanService;
            }
        }
        #endregion        
    
        #region ViewChiTietGiangDayService
        private static ViewChiTietGiangDayService _ViewChiTietGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ViewChiTietGiangDayService class.
		/// </summary>
        public static ViewChiTietGiangDayService ViewChiTietGiangDay
        {
            get
            {
                if(_ViewChiTietGiangDayService == null)
                    _ViewChiTietGiangDayService = new ViewChiTietGiangDayService();
                return _ViewChiTietGiangDayService;
            }
        }
        #endregion        
    
        #region ViewChiTietHocPhanService
        private static ViewChiTietHocPhanService _ViewChiTietHocPhanService;
        /// <summary>
		/// Initializes a new instance of the ViewChiTietHocPhanService class.
		/// </summary>
        public static ViewChiTietHocPhanService ViewChiTietHocPhan
        {
            get
            {
                if(_ViewChiTietHocPhanService == null)
                    _ViewChiTietHocPhanService = new ViewChiTietHocPhanService();
                return _ViewChiTietHocPhanService;
            }
        }
        #endregion        
    
        #region ViewChiTietKhoiLuongService
        private static ViewChiTietKhoiLuongService _ViewChiTietKhoiLuongService;
        /// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongService class.
		/// </summary>
        public static ViewChiTietKhoiLuongService ViewChiTietKhoiLuong
        {
            get
            {
                if(_ViewChiTietKhoiLuongService == null)
                    _ViewChiTietKhoiLuongService = new ViewChiTietKhoiLuongService();
                return _ViewChiTietKhoiLuongService;
            }
        }
        #endregion        
    
        #region ViewChiTietKhoiLuongGiangDayService
        private static ViewChiTietKhoiLuongGiangDayService _ViewChiTietKhoiLuongGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongGiangDayService class.
		/// </summary>
        public static ViewChiTietKhoiLuongGiangDayService ViewChiTietKhoiLuongGiangDay
        {
            get
            {
                if(_ViewChiTietKhoiLuongGiangDayService == null)
                    _ViewChiTietKhoiLuongGiangDayService = new ViewChiTietKhoiLuongGiangDayService();
                return _ViewChiTietKhoiLuongGiangDayService;
            }
        }
        #endregion        
    
        #region ViewChiTietKhoiLuongThucDayService
        private static ViewChiTietKhoiLuongThucDayService _ViewChiTietKhoiLuongThucDayService;
        /// <summary>
		/// Initializes a new instance of the ViewChiTietKhoiLuongThucDayService class.
		/// </summary>
        public static ViewChiTietKhoiLuongThucDayService ViewChiTietKhoiLuongThucDay
        {
            get
            {
                if(_ViewChiTietKhoiLuongThucDayService == null)
                    _ViewChiTietKhoiLuongThucDayService = new ViewChiTietKhoiLuongThucDayService();
                return _ViewChiTietKhoiLuongThucDayService;
            }
        }
        #endregion        
    
        #region ViewChiTietPhanCongGiangDayService
        private static ViewChiTietPhanCongGiangDayService _ViewChiTietPhanCongGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ViewChiTietPhanCongGiangDayService class.
		/// </summary>
        public static ViewChiTietPhanCongGiangDayService ViewChiTietPhanCongGiangDay
        {
            get
            {
                if(_ViewChiTietPhanCongGiangDayService == null)
                    _ViewChiTietPhanCongGiangDayService = new ViewChiTietPhanCongGiangDayService();
                return _ViewChiTietPhanCongGiangDayService;
            }
        }
        #endregion        
    
        #region ViewChiTietQuyDoiService
        private static ViewChiTietQuyDoiService _ViewChiTietQuyDoiService;
        /// <summary>
		/// Initializes a new instance of the ViewChiTietQuyDoiService class.
		/// </summary>
        public static ViewChiTietQuyDoiService ViewChiTietQuyDoi
        {
            get
            {
                if(_ViewChiTietQuyDoiService == null)
                    _ViewChiTietQuyDoiService = new ViewChiTietQuyDoiService();
                return _ViewChiTietQuyDoiService;
            }
        }
        #endregion        
    
        #region ViewCoSoService
        private static ViewCoSoService _ViewCoSoService;
        /// <summary>
		/// Initializes a new instance of the ViewCoSoService class.
		/// </summary>
        public static ViewCoSoService ViewCoSo
        {
            get
            {
                if(_ViewCoSoService == null)
                    _ViewCoSoService = new ViewCoSoService();
                return _ViewCoSoService;
            }
        }
        #endregion        
    
        #region ViewCoVanHocTapService
        private static ViewCoVanHocTapService _ViewCoVanHocTapService;
        /// <summary>
		/// Initializes a new instance of the ViewCoVanHocTapService class.
		/// </summary>
        public static ViewCoVanHocTapService ViewCoVanHocTap
        {
            get
            {
                if(_ViewCoVanHocTapService == null)
                    _ViewCoVanHocTapService = new ViewCoVanHocTapService();
                return _ViewCoVanHocTapService;
            }
        }
        #endregion        
    
        #region ViewDanhSachHopDongThinhGiangService
        private static ViewDanhSachHopDongThinhGiangService _ViewDanhSachHopDongThinhGiangService;
        /// <summary>
		/// Initializes a new instance of the ViewDanhSachHopDongThinhGiangService class.
		/// </summary>
        public static ViewDanhSachHopDongThinhGiangService ViewDanhSachHopDongThinhGiang
        {
            get
            {
                if(_ViewDanhSachHopDongThinhGiangService == null)
                    _ViewDanhSachHopDongThinhGiangService = new ViewDanhSachHopDongThinhGiangService();
                return _ViewDanhSachHopDongThinhGiangService;
            }
        }
        #endregion        
    
        #region ViewDanhSachLopPhanCongGiangDayService
        private static ViewDanhSachLopPhanCongGiangDayService _ViewDanhSachLopPhanCongGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ViewDanhSachLopPhanCongGiangDayService class.
		/// </summary>
        public static ViewDanhSachLopPhanCongGiangDayService ViewDanhSachLopPhanCongGiangDay
        {
            get
            {
                if(_ViewDanhSachLopPhanCongGiangDayService == null)
                    _ViewDanhSachLopPhanCongGiangDayService = new ViewDanhSachLopPhanCongGiangDayService();
                return _ViewDanhSachLopPhanCongGiangDayService;
            }
        }
        #endregion        
    
        #region ViewDanTocService
        private static ViewDanTocService _ViewDanTocService;
        /// <summary>
		/// Initializes a new instance of the ViewDanTocService class.
		/// </summary>
        public static ViewDanTocService ViewDanToc
        {
            get
            {
                if(_ViewDanTocService == null)
                    _ViewDanTocService = new ViewDanTocService();
                return _ViewDanTocService;
            }
        }
        #endregion        
    
        #region ViewDoiTuongDonGiaService
        private static ViewDoiTuongDonGiaService _ViewDoiTuongDonGiaService;
        /// <summary>
		/// Initializes a new instance of the ViewDoiTuongDonGiaService class.
		/// </summary>
        public static ViewDoiTuongDonGiaService ViewDoiTuongDonGia
        {
            get
            {
                if(_ViewDoiTuongDonGiaService == null)
                    _ViewDoiTuongDonGiaService = new ViewDoiTuongDonGiaService();
                return _ViewDoiTuongDonGiaService;
            }
        }
        #endregion        
    
        #region ViewDonGiaNgoaiQuyCheService
        private static ViewDonGiaNgoaiQuyCheService _ViewDonGiaNgoaiQuyCheService;
        /// <summary>
		/// Initializes a new instance of the ViewDonGiaNgoaiQuyCheService class.
		/// </summary>
        public static ViewDonGiaNgoaiQuyCheService ViewDonGiaNgoaiQuyChe
        {
            get
            {
                if(_ViewDonGiaNgoaiQuyCheService == null)
                    _ViewDonGiaNgoaiQuyCheService = new ViewDonGiaNgoaiQuyCheService();
                return _ViewDonGiaNgoaiQuyCheService;
            }
        }
        #endregion        
    
        #region ViewDonViService
        private static ViewDonViService _ViewDonViService;
        /// <summary>
		/// Initializes a new instance of the ViewDonViService class.
		/// </summary>
        public static ViewDonViService ViewDonVi
        {
            get
            {
                if(_ViewDonViService == null)
                    _ViewDonViService = new ViewDonViService();
                return _ViewDonViService;
            }
        }
        #endregion        
    
        #region ViewGiamTruGioChuanService
        private static ViewGiamTruGioChuanService _ViewGiamTruGioChuanService;
        /// <summary>
		/// Initializes a new instance of the ViewGiamTruGioChuanService class.
		/// </summary>
        public static ViewGiamTruGioChuanService ViewGiamTruGioChuan
        {
            get
            {
                if(_ViewGiamTruGioChuanService == null)
                    _ViewGiamTruGioChuanService = new ViewGiamTruGioChuanService();
                return _ViewGiamTruGioChuanService;
            }
        }
        #endregion        
    
        #region ViewGiangVienService
        private static ViewGiangVienService _ViewGiangVienService;
        /// <summary>
		/// Initializes a new instance of the ViewGiangVienService class.
		/// </summary>
        public static ViewGiangVienService ViewGiangVien
        {
            get
            {
                if(_ViewGiangVienService == null)
                    _ViewGiangVienService = new ViewGiangVienService();
                return _ViewGiangVienService;
            }
        }
        #endregion        
    
        #region ViewGiangVienKhoaService
        private static ViewGiangVienKhoaService _ViewGiangVienKhoaService;
        /// <summary>
		/// Initializes a new instance of the ViewGiangVienKhoaService class.
		/// </summary>
        public static ViewGiangVienKhoaService ViewGiangVienKhoa
        {
            get
            {
                if(_ViewGiangVienKhoaService == null)
                    _ViewGiangVienKhoaService = new ViewGiangVienKhoaService();
                return _ViewGiangVienKhoaService;
            }
        }
        #endregion        
    
        #region ViewGiangVienLopHocPhanService
        private static ViewGiangVienLopHocPhanService _ViewGiangVienLopHocPhanService;
        /// <summary>
		/// Initializes a new instance of the ViewGiangVienLopHocPhanService class.
		/// </summary>
        public static ViewGiangVienLopHocPhanService ViewGiangVienLopHocPhan
        {
            get
            {
                if(_ViewGiangVienLopHocPhanService == null)
                    _ViewGiangVienLopHocPhanService = new ViewGiangVienLopHocPhanService();
                return _ViewGiangVienLopHocPhanService;
            }
        }
        #endregion        
    
        #region ViewGiangVienNckhService
        private static ViewGiangVienNckhService _ViewGiangVienNckhService;
        /// <summary>
		/// Initializes a new instance of the ViewGiangVienNckhService class.
		/// </summary>
        public static ViewGiangVienNckhService ViewGiangVienNckh
        {
            get
            {
                if(_ViewGiangVienNckhService == null)
                    _ViewGiangVienNckhService = new ViewGiangVienNckhService();
                return _ViewGiangVienNckhService;
            }
        }
        #endregion        
    
        #region ViewGiangVienNghienCuuKhoaHocService
        private static ViewGiangVienNghienCuuKhoaHocService _ViewGiangVienNghienCuuKhoaHocService;
        /// <summary>
		/// Initializes a new instance of the ViewGiangVienNghienCuuKhoaHocService class.
		/// </summary>
        public static ViewGiangVienNghienCuuKhoaHocService ViewGiangVienNghienCuuKhoaHoc
        {
            get
            {
                if(_ViewGiangVienNghienCuuKhoaHocService == null)
                    _ViewGiangVienNghienCuuKhoaHocService = new ViewGiangVienNghienCuuKhoaHocService();
                return _ViewGiangVienNghienCuuKhoaHocService;
            }
        }
        #endregion        
    
        #region ViewHeDaoTaoService
        private static ViewHeDaoTaoService _ViewHeDaoTaoService;
        /// <summary>
		/// Initializes a new instance of the ViewHeDaoTaoService class.
		/// </summary>
        public static ViewHeDaoTaoService ViewHeDaoTao
        {
            get
            {
                if(_ViewHeDaoTaoService == null)
                    _ViewHeDaoTaoService = new ViewHeDaoTaoService();
                return _ViewHeDaoTaoService;
            }
        }
        #endregion        
    
        #region ViewHeSoLopDongHbuService
        private static ViewHeSoLopDongHbuService _ViewHeSoLopDongHbuService;
        /// <summary>
		/// Initializes a new instance of the ViewHeSoLopDongHbuService class.
		/// </summary>
        public static ViewHeSoLopDongHbuService ViewHeSoLopDongHbu
        {
            get
            {
                if(_ViewHeSoLopDongHbuService == null)
                    _ViewHeSoLopDongHbuService = new ViewHeSoLopDongHbuService();
                return _ViewHeSoLopDongHbuService;
            }
        }
        #endregion        
    
        #region ViewHeSoLuongHocHamHocViService
        private static ViewHeSoLuongHocHamHocViService _ViewHeSoLuongHocHamHocViService;
        /// <summary>
		/// Initializes a new instance of the ViewHeSoLuongHocHamHocViService class.
		/// </summary>
        public static ViewHeSoLuongHocHamHocViService ViewHeSoLuongHocHamHocVi
        {
            get
            {
                if(_ViewHeSoLuongHocHamHocViService == null)
                    _ViewHeSoLuongHocHamHocViService = new ViewHeSoLuongHocHamHocViService();
                return _ViewHeSoLuongHocHamHocViService;
            }
        }
        #endregion        
    
        #region ViewHesoThuLaoService
        private static ViewHesoThuLaoService _ViewHesoThuLaoService;
        /// <summary>
		/// Initializes a new instance of the ViewHesoThuLaoService class.
		/// </summary>
        public static ViewHesoThuLaoService ViewHesoThuLao
        {
            get
            {
                if(_ViewHesoThuLaoService == null)
                    _ViewHesoThuLaoService = new ViewHesoThuLaoService();
                return _ViewHesoThuLaoService;
            }
        }
        #endregion        
    
        #region ViewHeSoTinChiService
        private static ViewHeSoTinChiService _ViewHeSoTinChiService;
        /// <summary>
		/// Initializes a new instance of the ViewHeSoTinChiService class.
		/// </summary>
        public static ViewHeSoTinChiService ViewHeSoTinChi
        {
            get
            {
                if(_ViewHeSoTinChiService == null)
                    _ViewHeSoTinChiService = new ViewHeSoTinChiService();
                return _ViewHeSoTinChiService;
            }
        }
        #endregion        
    
        #region ViewHinhThucThiService
        private static ViewHinhThucThiService _ViewHinhThucThiService;
        /// <summary>
		/// Initializes a new instance of the ViewHinhThucThiService class.
		/// </summary>
        public static ViewHinhThucThiService ViewHinhThucThi
        {
            get
            {
                if(_ViewHinhThucThiService == null)
                    _ViewHinhThucThiService = new ViewHinhThucThiService();
                return _ViewHinhThucThiService;
            }
        }
        #endregion        
    
        #region ViewHinhThucViPhamService
        private static ViewHinhThucViPhamService _ViewHinhThucViPhamService;
        /// <summary>
		/// Initializes a new instance of the ViewHinhThucViPhamService class.
		/// </summary>
        public static ViewHinhThucViPhamService ViewHinhThucViPham
        {
            get
            {
                if(_ViewHinhThucViPhamService == null)
                    _ViewHinhThucViPhamService = new ViewHinhThucViPhamService();
                return _ViewHinhThucViPhamService;
            }
        }
        #endregion        
    
        #region ViewHocKyService
        private static ViewHocKyService _ViewHocKyService;
        /// <summary>
		/// Initializes a new instance of the ViewHocKyService class.
		/// </summary>
        public static ViewHocKyService ViewHocKy
        {
            get
            {
                if(_ViewHocKyService == null)
                    _ViewHocKyService = new ViewHocKyService();
                return _ViewHocKyService;
            }
        }
        #endregion        
    
        #region ViewHocPhanMonHocService
        private static ViewHocPhanMonHocService _ViewHocPhanMonHocService;
        /// <summary>
		/// Initializes a new instance of the ViewHocPhanMonHocService class.
		/// </summary>
        public static ViewHocPhanMonHocService ViewHocPhanMonHoc
        {
            get
            {
                if(_ViewHocPhanMonHocService == null)
                    _ViewHocPhanMonHocService = new ViewHocPhanMonHocService();
                return _ViewHocPhanMonHocService;
            }
        }
        #endregion        
    
        #region ViewHopDongThinhGiangService
        private static ViewHopDongThinhGiangService _ViewHopDongThinhGiangService;
        /// <summary>
		/// Initializes a new instance of the ViewHopDongThinhGiangService class.
		/// </summary>
        public static ViewHopDongThinhGiangService ViewHopDongThinhGiang
        {
            get
            {
                if(_ViewHopDongThinhGiangService == null)
                    _ViewHopDongThinhGiangService = new ViewHopDongThinhGiangService();
                return _ViewHopDongThinhGiangService;
            }
        }
        #endregion        
    
        #region ViewKcqDonGiaNgoaiQuyCheService
        private static ViewKcqDonGiaNgoaiQuyCheService _ViewKcqDonGiaNgoaiQuyCheService;
        /// <summary>
		/// Initializes a new instance of the ViewKcqDonGiaNgoaiQuyCheService class.
		/// </summary>
        public static ViewKcqDonGiaNgoaiQuyCheService ViewKcqDonGiaNgoaiQuyChe
        {
            get
            {
                if(_ViewKcqDonGiaNgoaiQuyCheService == null)
                    _ViewKcqDonGiaNgoaiQuyCheService = new ViewKcqDonGiaNgoaiQuyCheService();
                return _ViewKcqDonGiaNgoaiQuyCheService;
            }
        }
        #endregion        
    
        #region ViewKcqHopDongThinhGiangService
        private static ViewKcqHopDongThinhGiangService _ViewKcqHopDongThinhGiangService;
        /// <summary>
		/// Initializes a new instance of the ViewKcqHopDongThinhGiangService class.
		/// </summary>
        public static ViewKcqHopDongThinhGiangService ViewKcqHopDongThinhGiang
        {
            get
            {
                if(_ViewKcqHopDongThinhGiangService == null)
                    _ViewKcqHopDongThinhGiangService = new ViewKcqHopDongThinhGiangService();
                return _ViewKcqHopDongThinhGiangService;
            }
        }
        #endregion        
    
        #region ViewKcqKetQuaThanhToanThuLaoService
        private static ViewKcqKetQuaThanhToanThuLaoService _ViewKcqKetQuaThanhToanThuLaoService;
        /// <summary>
		/// Initializes a new instance of the ViewKcqKetQuaThanhToanThuLaoService class.
		/// </summary>
        public static ViewKcqKetQuaThanhToanThuLaoService ViewKcqKetQuaThanhToanThuLao
        {
            get
            {
                if(_ViewKcqKetQuaThanhToanThuLaoService == null)
                    _ViewKcqKetQuaThanhToanThuLaoService = new ViewKcqKetQuaThanhToanThuLaoService();
                return _ViewKcqKetQuaThanhToanThuLaoService;
            }
        }
        #endregion        
    
        #region ViewKcqLietKeKhoiLuongGiangDayChiTiet2Service
        private static ViewKcqLietKeKhoiLuongGiangDayChiTiet2Service _ViewKcqLietKeKhoiLuongGiangDayChiTiet2Service;
        /// <summary>
		/// Initializes a new instance of the ViewKcqLietKeKhoiLuongGiangDayChiTiet2Service class.
		/// </summary>
        public static ViewKcqLietKeKhoiLuongGiangDayChiTiet2Service ViewKcqLietKeKhoiLuongGiangDayChiTiet2
        {
            get
            {
                if(_ViewKcqLietKeKhoiLuongGiangDayChiTiet2Service == null)
                    _ViewKcqLietKeKhoiLuongGiangDayChiTiet2Service = new ViewKcqLietKeKhoiLuongGiangDayChiTiet2Service();
                return _ViewKcqLietKeKhoiLuongGiangDayChiTiet2Service;
            }
        }
        #endregion        
    
        #region ViewKcqMonThucTapTotNghiepService
        private static ViewKcqMonThucTapTotNghiepService _ViewKcqMonThucTapTotNghiepService;
        /// <summary>
		/// Initializes a new instance of the ViewKcqMonThucTapTotNghiepService class.
		/// </summary>
        public static ViewKcqMonThucTapTotNghiepService ViewKcqMonThucTapTotNghiep
        {
            get
            {
                if(_ViewKcqMonThucTapTotNghiepService == null)
                    _ViewKcqMonThucTapTotNghiepService = new ViewKcqMonThucTapTotNghiepService();
                return _ViewKcqMonThucTapTotNghiepService;
            }
        }
        #endregion        
    
        #region ViewKcqMonTinhTheoQuyCheMoiService
        private static ViewKcqMonTinhTheoQuyCheMoiService _ViewKcqMonTinhTheoQuyCheMoiService;
        /// <summary>
		/// Initializes a new instance of the ViewKcqMonTinhTheoQuyCheMoiService class.
		/// </summary>
        public static ViewKcqMonTinhTheoQuyCheMoiService ViewKcqMonTinhTheoQuyCheMoi
        {
            get
            {
                if(_ViewKcqMonTinhTheoQuyCheMoiService == null)
                    _ViewKcqMonTinhTheoQuyCheMoiService = new ViewKcqMonTinhTheoQuyCheMoiService();
                return _ViewKcqMonTinhTheoQuyCheMoiService;
            }
        }
        #endregion        
    
        #region ViewKcqMonXepLichChuNhatKhongTinhHeSoService
        private static ViewKcqMonXepLichChuNhatKhongTinhHeSoService _ViewKcqMonXepLichChuNhatKhongTinhHeSoService;
        /// <summary>
		/// Initializes a new instance of the ViewKcqMonXepLichChuNhatKhongTinhHeSoService class.
		/// </summary>
        public static ViewKcqMonXepLichChuNhatKhongTinhHeSoService ViewKcqMonXepLichChuNhatKhongTinhHeSo
        {
            get
            {
                if(_ViewKcqMonXepLichChuNhatKhongTinhHeSoService == null)
                    _ViewKcqMonXepLichChuNhatKhongTinhHeSoService = new ViewKcqMonXepLichChuNhatKhongTinhHeSoService();
                return _ViewKcqMonXepLichChuNhatKhongTinhHeSoService;
            }
        }
        #endregion        
    
        #region ViewKcqPhanNhomMonHocService
        private static ViewKcqPhanNhomMonHocService _ViewKcqPhanNhomMonHocService;
        /// <summary>
		/// Initializes a new instance of the ViewKcqPhanNhomMonHocService class.
		/// </summary>
        public static ViewKcqPhanNhomMonHocService ViewKcqPhanNhomMonHoc
        {
            get
            {
                if(_ViewKcqPhanNhomMonHocService == null)
                    _ViewKcqPhanNhomMonHocService = new ViewKcqPhanNhomMonHocService();
                return _ViewKcqPhanNhomMonHocService;
            }
        }
        #endregion        
    
        #region ViewKcqPhanNhomMonHocActService
        private static ViewKcqPhanNhomMonHocActService _ViewKcqPhanNhomMonHocActService;
        /// <summary>
		/// Initializes a new instance of the ViewKcqPhanNhomMonHocActService class.
		/// </summary>
        public static ViewKcqPhanNhomMonHocActService ViewKcqPhanNhomMonHocAct
        {
            get
            {
                if(_ViewKcqPhanNhomMonHocActService == null)
                    _ViewKcqPhanNhomMonHocActService = new ViewKcqPhanNhomMonHocActService();
                return _ViewKcqPhanNhomMonHocActService;
            }
        }
        #endregion        
    
        #region ViewKcqPhuCapHanhChinhService
        private static ViewKcqPhuCapHanhChinhService _ViewKcqPhuCapHanhChinhService;
        /// <summary>
		/// Initializes a new instance of the ViewKcqPhuCapHanhChinhService class.
		/// </summary>
        public static ViewKcqPhuCapHanhChinhService ViewKcqPhuCapHanhChinh
        {
            get
            {
                if(_ViewKcqPhuCapHanhChinhService == null)
                    _ViewKcqPhuCapHanhChinhService = new ViewKcqPhuCapHanhChinhService();
                return _ViewKcqPhuCapHanhChinhService;
            }
        }
        #endregion        
    
        #region ViewKcqUteKhoiLuongGiangDayService
        private static ViewKcqUteKhoiLuongGiangDayService _ViewKcqUteKhoiLuongGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ViewKcqUteKhoiLuongGiangDayService class.
		/// </summary>
        public static ViewKcqUteKhoiLuongGiangDayService ViewKcqUteKhoiLuongGiangDay
        {
            get
            {
                if(_ViewKcqUteKhoiLuongGiangDayService == null)
                    _ViewKcqUteKhoiLuongGiangDayService = new ViewKcqUteKhoiLuongGiangDayService();
                return _ViewKcqUteKhoiLuongGiangDayService;
            }
        }
        #endregion        
    
        #region ViewKcqUteKhoiLuongQuyDoi2Service
        private static ViewKcqUteKhoiLuongQuyDoi2Service _ViewKcqUteKhoiLuongQuyDoi2Service;
        /// <summary>
		/// Initializes a new instance of the ViewKcqUteKhoiLuongQuyDoi2Service class.
		/// </summary>
        public static ViewKcqUteKhoiLuongQuyDoi2Service ViewKcqUteKhoiLuongQuyDoi2
        {
            get
            {
                if(_ViewKcqUteKhoiLuongQuyDoi2Service == null)
                    _ViewKcqUteKhoiLuongQuyDoi2Service = new ViewKcqUteKhoiLuongQuyDoi2Service();
                return _ViewKcqUteKhoiLuongQuyDoi2Service;
            }
        }
        #endregion        
    
        #region ViewKetQuaCacKhoanChiKhacService
        private static ViewKetQuaCacKhoanChiKhacService _ViewKetQuaCacKhoanChiKhacService;
        /// <summary>
		/// Initializes a new instance of the ViewKetQuaCacKhoanChiKhacService class.
		/// </summary>
        public static ViewKetQuaCacKhoanChiKhacService ViewKetQuaCacKhoanChiKhac
        {
            get
            {
                if(_ViewKetQuaCacKhoanChiKhacService == null)
                    _ViewKetQuaCacKhoanChiKhacService = new ViewKetQuaCacKhoanChiKhacService();
                return _ViewKetQuaCacKhoanChiKhacService;
            }
        }
        #endregion        
    
        #region ViewKetQuaThanhToanThuLaoService
        private static ViewKetQuaThanhToanThuLaoService _ViewKetQuaThanhToanThuLaoService;
        /// <summary>
		/// Initializes a new instance of the ViewKetQuaThanhToanThuLaoService class.
		/// </summary>
        public static ViewKetQuaThanhToanThuLaoService ViewKetQuaThanhToanThuLao
        {
            get
            {
                if(_ViewKetQuaThanhToanThuLaoService == null)
                    _ViewKetQuaThanhToanThuLaoService = new ViewKetQuaThanhToanThuLaoService();
                return _ViewKetQuaThanhToanThuLaoService;
            }
        }
        #endregion        
    
        #region ViewKetQuaTinhService
        private static ViewKetQuaTinhService _ViewKetQuaTinhService;
        /// <summary>
		/// Initializes a new instance of the ViewKetQuaTinhService class.
		/// </summary>
        public static ViewKetQuaTinhService ViewKetQuaTinh
        {
            get
            {
                if(_ViewKetQuaTinhService == null)
                    _ViewKetQuaTinhService = new ViewKetQuaTinhService();
                return _ViewKetQuaTinhService;
            }
        }
        #endregion        
    
        #region ViewKhoaService
        private static ViewKhoaService _ViewKhoaService;
        /// <summary>
		/// Initializes a new instance of the ViewKhoaService class.
		/// </summary>
        public static ViewKhoaService ViewKhoa
        {
            get
            {
                if(_ViewKhoaService == null)
                    _ViewKhoaService = new ViewKhoaService();
                return _ViewKhoaService;
            }
        }
        #endregion        
    
        #region ViewKhoaBoMonService
        private static ViewKhoaBoMonService _ViewKhoaBoMonService;
        /// <summary>
		/// Initializes a new instance of the ViewKhoaBoMonService class.
		/// </summary>
        public static ViewKhoaBoMonService ViewKhoaBoMon
        {
            get
            {
                if(_ViewKhoaBoMonService == null)
                    _ViewKhoaBoMonService = new ViewKhoaBoMonService();
                return _ViewKhoaBoMonService;
            }
        }
        #endregion        
    
        #region ViewKhoaHocService
        private static ViewKhoaHocService _ViewKhoaHocService;
        /// <summary>
		/// Initializes a new instance of the ViewKhoaHocService class.
		/// </summary>
        public static ViewKhoaHocService ViewKhoaHoc
        {
            get
            {
                if(_ViewKhoaHocService == null)
                    _ViewKhoaHocService = new ViewKhoaHocService();
                return _ViewKhoaHocService;
            }
        }
        #endregion        
    
        #region ViewKhoaHocBacHeService
        private static ViewKhoaHocBacHeService _ViewKhoaHocBacHeService;
        /// <summary>
		/// Initializes a new instance of the ViewKhoaHocBacHeService class.
		/// </summary>
        public static ViewKhoaHocBacHeService ViewKhoaHocBacHe
        {
            get
            {
                if(_ViewKhoaHocBacHeService == null)
                    _ViewKhoaHocBacHeService = new ViewKhoaHocBacHeService();
                return _ViewKhoaHocBacHeService;
            }
        }
        #endregion        
    
        #region ViewKhoiLuongGiangDayService
        private static ViewKhoiLuongGiangDayService _ViewKhoiLuongGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayService class.
		/// </summary>
        public static ViewKhoiLuongGiangDayService ViewKhoiLuongGiangDay
        {
            get
            {
                if(_ViewKhoiLuongGiangDayService == null)
                    _ViewKhoiLuongGiangDayService = new ViewKhoiLuongGiangDayService();
                return _ViewKhoiLuongGiangDayService;
            }
        }
        #endregion        
    
        #region ViewKhoiLuongGiangDayCanBoService
        private static ViewKhoiLuongGiangDayCanBoService _ViewKhoiLuongGiangDayCanBoService;
        /// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayCanBoService class.
		/// </summary>
        public static ViewKhoiLuongGiangDayCanBoService ViewKhoiLuongGiangDayCanBo
        {
            get
            {
                if(_ViewKhoiLuongGiangDayCanBoService == null)
                    _ViewKhoiLuongGiangDayCanBoService = new ViewKhoiLuongGiangDayCanBoService();
                return _ViewKhoiLuongGiangDayCanBoService;
            }
        }
        #endregion        
    
        #region ViewKhoiLuongThucDayService
        private static ViewKhoiLuongThucDayService _ViewKhoiLuongThucDayService;
        /// <summary>
		/// Initializes a new instance of the ViewKhoiLuongThucDayService class.
		/// </summary>
        public static ViewKhoiLuongThucDayService ViewKhoiLuongThucDay
        {
            get
            {
                if(_ViewKhoiLuongThucDayService == null)
                    _ViewKhoiLuongThucDayService = new ViewKhoiLuongThucDayService();
                return _ViewKhoiLuongThucDayService;
            }
        }
        #endregion        
    
        #region ViewKhoiLuongCacCongViecKhacService
        private static ViewKhoiLuongCacCongViecKhacService _ViewKhoiLuongCacCongViecKhacService;
        /// <summary>
		/// Initializes a new instance of the ViewKhoiLuongCacCongViecKhacService class.
		/// </summary>
        public static ViewKhoiLuongCacCongViecKhacService ViewKhoiLuongCacCongViecKhac
        {
            get
            {
                if(_ViewKhoiLuongCacCongViecKhacService == null)
                    _ViewKhoiLuongCacCongViecKhacService = new ViewKhoiLuongCacCongViecKhacService();
                return _ViewKhoiLuongCacCongViecKhacService;
            }
        }
        #endregion        
    
        #region ViewKyThiService
        private static ViewKyThiService _ViewKyThiService;
        /// <summary>
		/// Initializes a new instance of the ViewKyThiService class.
		/// </summary>
        public static ViewKyThiService ViewKyThi
        {
            get
            {
                if(_ViewKyThiService == null)
                    _ViewKyThiService = new ViewKyThiService();
                return _ViewKyThiService;
            }
        }
        #endregion        
    
        #region ViewLietKeKhoiLuongGiangDayChiTietService
        private static ViewLietKeKhoiLuongGiangDayChiTietService _ViewLietKeKhoiLuongGiangDayChiTietService;
        /// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietService class.
		/// </summary>
        public static ViewLietKeKhoiLuongGiangDayChiTietService ViewLietKeKhoiLuongGiangDayChiTiet
        {
            get
            {
                if(_ViewLietKeKhoiLuongGiangDayChiTietService == null)
                    _ViewLietKeKhoiLuongGiangDayChiTietService = new ViewLietKeKhoiLuongGiangDayChiTietService();
                return _ViewLietKeKhoiLuongGiangDayChiTietService;
            }
        }
        #endregion        
    
        #region ViewLietKeKhoiLuongGiangDayChiTietUsshService
        private static ViewLietKeKhoiLuongGiangDayChiTietUsshService _ViewLietKeKhoiLuongGiangDayChiTietUsshService;
        /// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshService class.
		/// </summary>
        public static ViewLietKeKhoiLuongGiangDayChiTietUsshService ViewLietKeKhoiLuongGiangDayChiTietUssh
        {
            get
            {
                if(_ViewLietKeKhoiLuongGiangDayChiTietUsshService == null)
                    _ViewLietKeKhoiLuongGiangDayChiTietUsshService = new ViewLietKeKhoiLuongGiangDayChiTietUsshService();
                return _ViewLietKeKhoiLuongGiangDayChiTietUsshService;
            }
        }
        #endregion        
    
        #region ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtService
        private static ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtService _ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtService;
        /// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtService class.
		/// </summary>
        public static ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtService ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvt
        {
            get
            {
                if(_ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtService == null)
                    _ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtService = new ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtService();
                return _ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtService;
            }
        }
        #endregion        
    
        #region ViewLietKeKhoiLuongGiangDayChiTiet2Service
        private static ViewLietKeKhoiLuongGiangDayChiTiet2Service _ViewLietKeKhoiLuongGiangDayChiTiet2Service;
        /// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTiet2Service class.
		/// </summary>
        public static ViewLietKeKhoiLuongGiangDayChiTiet2Service ViewLietKeKhoiLuongGiangDayChiTiet2
        {
            get
            {
                if(_ViewLietKeKhoiLuongGiangDayChiTiet2Service == null)
                    _ViewLietKeKhoiLuongGiangDayChiTiet2Service = new ViewLietKeKhoiLuongGiangDayChiTiet2Service();
                return _ViewLietKeKhoiLuongGiangDayChiTiet2Service;
            }
        }
        #endregion        
    
        #region ViewLoaiHinhDaoTaoService
        private static ViewLoaiHinhDaoTaoService _ViewLoaiHinhDaoTaoService;
        /// <summary>
		/// Initializes a new instance of the ViewLoaiHinhDaoTaoService class.
		/// </summary>
        public static ViewLoaiHinhDaoTaoService ViewLoaiHinhDaoTao
        {
            get
            {
                if(_ViewLoaiHinhDaoTaoService == null)
                    _ViewLoaiHinhDaoTaoService = new ViewLoaiHinhDaoTaoService();
                return _ViewLoaiHinhDaoTaoService;
            }
        }
        #endregion        
    
        #region ViewLoaiHocPhanService
        private static ViewLoaiHocPhanService _ViewLoaiHocPhanService;
        /// <summary>
		/// Initializes a new instance of the ViewLoaiHocPhanService class.
		/// </summary>
        public static ViewLoaiHocPhanService ViewLoaiHocPhan
        {
            get
            {
                if(_ViewLoaiHocPhanService == null)
                    _ViewLoaiHocPhanService = new ViewLoaiHocPhanService();
                return _ViewLoaiHocPhanService;
            }
        }
        #endregion        
    
        #region ViewLopService
        private static ViewLopService _ViewLopService;
        /// <summary>
		/// Initializes a new instance of the ViewLopService class.
		/// </summary>
        public static ViewLopService ViewLop
        {
            get
            {
                if(_ViewLopService == null)
                    _ViewLopService = new ViewLopService();
                return _ViewLopService;
            }
        }
        #endregion        
    
        #region ViewLopChatLuongCaoService
        private static ViewLopChatLuongCaoService _ViewLopChatLuongCaoService;
        /// <summary>
		/// Initializes a new instance of the ViewLopChatLuongCaoService class.
		/// </summary>
        public static ViewLopChatLuongCaoService ViewLopChatLuongCao
        {
            get
            {
                if(_ViewLopChatLuongCaoService == null)
                    _ViewLopChatLuongCaoService = new ViewLopChatLuongCaoService();
                return _ViewLopChatLuongCaoService;
            }
        }
        #endregion        
    
        #region ViewLopHocPhanService
        private static ViewLopHocPhanService _ViewLopHocPhanService;
        /// <summary>
		/// Initializes a new instance of the ViewLopHocPhanService class.
		/// </summary>
        public static ViewLopHocPhanService ViewLopHocPhan
        {
            get
            {
                if(_ViewLopHocPhanService == null)
                    _ViewLopHocPhanService = new ViewLopHocPhanService();
                return _ViewLopHocPhanService;
            }
        }
        #endregion        
    
        #region ViewLopHocPhanClcAufCjlService
        private static ViewLopHocPhanClcAufCjlService _ViewLopHocPhanClcAufCjlService;
        /// <summary>
		/// Initializes a new instance of the ViewLopHocPhanClcAufCjlService class.
		/// </summary>
        public static ViewLopHocPhanClcAufCjlService ViewLopHocPhanClcAufCjl
        {
            get
            {
                if(_ViewLopHocPhanClcAufCjlService == null)
                    _ViewLopHocPhanClcAufCjlService = new ViewLopHocPhanClcAufCjlService();
                return _ViewLopHocPhanClcAufCjlService;
            }
        }
        #endregion        
    
        #region ViewLopHocPhanChuyenNganhService
        private static ViewLopHocPhanChuyenNganhService _ViewLopHocPhanChuyenNganhService;
        /// <summary>
		/// Initializes a new instance of the ViewLopHocPhanChuyenNganhService class.
		/// </summary>
        public static ViewLopHocPhanChuyenNganhService ViewLopHocPhanChuyenNganh
        {
            get
            {
                if(_ViewLopHocPhanChuyenNganhService == null)
                    _ViewLopHocPhanChuyenNganhService = new ViewLopHocPhanChuyenNganhService();
                return _ViewLopHocPhanChuyenNganhService;
            }
        }
        #endregion        
    
        #region ViewLopHocPhanGiangBangTiengNuocNgoaiService
        private static ViewLopHocPhanGiangBangTiengNuocNgoaiService _ViewLopHocPhanGiangBangTiengNuocNgoaiService;
        /// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiService class.
		/// </summary>
        public static ViewLopHocPhanGiangBangTiengNuocNgoaiService ViewLopHocPhanGiangBangTiengNuocNgoai
        {
            get
            {
                if(_ViewLopHocPhanGiangBangTiengNuocNgoaiService == null)
                    _ViewLopHocPhanGiangBangTiengNuocNgoaiService = new ViewLopHocPhanGiangBangTiengNuocNgoaiService();
                return _ViewLopHocPhanGiangBangTiengNuocNgoaiService;
            }
        }
        #endregion        
    
        #region ViewLopHocPhanGiangBangTiengNuocNgoaiBuhService
        private static ViewLopHocPhanGiangBangTiengNuocNgoaiBuhService _ViewLopHocPhanGiangBangTiengNuocNgoaiBuhService;
        /// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhService class.
		/// </summary>
        public static ViewLopHocPhanGiangBangTiengNuocNgoaiBuhService ViewLopHocPhanGiangBangTiengNuocNgoaiBuh
        {
            get
            {
                if(_ViewLopHocPhanGiangBangTiengNuocNgoaiBuhService == null)
                    _ViewLopHocPhanGiangBangTiengNuocNgoaiBuhService = new ViewLopHocPhanGiangBangTiengNuocNgoaiBuhService();
                return _ViewLopHocPhanGiangBangTiengNuocNgoaiBuhService;
            }
        }
        #endregion        
    
        #region ViewMonGiangMoiService
        private static ViewMonGiangMoiService _ViewMonGiangMoiService;
        /// <summary>
		/// Initializes a new instance of the ViewMonGiangMoiService class.
		/// </summary>
        public static ViewMonGiangMoiService ViewMonGiangMoi
        {
            get
            {
                if(_ViewMonGiangMoiService == null)
                    _ViewMonGiangMoiService = new ViewMonGiangMoiService();
                return _ViewMonGiangMoiService;
            }
        }
        #endregion        
    
        #region ViewMonHocService
        private static ViewMonHocService _ViewMonHocService;
        /// <summary>
		/// Initializes a new instance of the ViewMonHocService class.
		/// </summary>
        public static ViewMonHocService ViewMonHoc
        {
            get
            {
                if(_ViewMonHocService == null)
                    _ViewMonHocService = new ViewMonHocService();
                return _ViewMonHocService;
            }
        }
        #endregion        
    
        #region ViewMonHocKhoaService
        private static ViewMonHocKhoaService _ViewMonHocKhoaService;
        /// <summary>
		/// Initializes a new instance of the ViewMonHocKhoaService class.
		/// </summary>
        public static ViewMonHocKhoaService ViewMonHocKhoa
        {
            get
            {
                if(_ViewMonHocKhoaService == null)
                    _ViewMonHocKhoaService = new ViewMonHocKhoaService();
                return _ViewMonHocKhoaService;
            }
        }
        #endregion        
    
        #region ViewMonThucTapTotNghiepService
        private static ViewMonThucTapTotNghiepService _ViewMonThucTapTotNghiepService;
        /// <summary>
		/// Initializes a new instance of the ViewMonThucTapTotNghiepService class.
		/// </summary>
        public static ViewMonThucTapTotNghiepService ViewMonThucTapTotNghiep
        {
            get
            {
                if(_ViewMonThucTapTotNghiepService == null)
                    _ViewMonThucTapTotNghiepService = new ViewMonThucTapTotNghiepService();
                return _ViewMonThucTapTotNghiepService;
            }
        }
        #endregion        
    
        #region ViewMonTinhTheoQuyCheMoiService
        private static ViewMonTinhTheoQuyCheMoiService _ViewMonTinhTheoQuyCheMoiService;
        /// <summary>
		/// Initializes a new instance of the ViewMonTinhTheoQuyCheMoiService class.
		/// </summary>
        public static ViewMonTinhTheoQuyCheMoiService ViewMonTinhTheoQuyCheMoi
        {
            get
            {
                if(_ViewMonTinhTheoQuyCheMoiService == null)
                    _ViewMonTinhTheoQuyCheMoiService = new ViewMonTinhTheoQuyCheMoiService();
                return _ViewMonTinhTheoQuyCheMoiService;
            }
        }
        #endregion        
    
        #region ViewMonXepLichChuNhatKhongTinhHeSoService
        private static ViewMonXepLichChuNhatKhongTinhHeSoService _ViewMonXepLichChuNhatKhongTinhHeSoService;
        /// <summary>
		/// Initializes a new instance of the ViewMonXepLichChuNhatKhongTinhHeSoService class.
		/// </summary>
        public static ViewMonXepLichChuNhatKhongTinhHeSoService ViewMonXepLichChuNhatKhongTinhHeSo
        {
            get
            {
                if(_ViewMonXepLichChuNhatKhongTinhHeSoService == null)
                    _ViewMonXepLichChuNhatKhongTinhHeSoService = new ViewMonXepLichChuNhatKhongTinhHeSoService();
                return _ViewMonXepLichChuNhatKhongTinhHeSoService;
            }
        }
        #endregion        
    
        #region ViewNamHocService
        private static ViewNamHocService _ViewNamHocService;
        /// <summary>
		/// Initializes a new instance of the ViewNamHocService class.
		/// </summary>
        public static ViewNamHocService ViewNamHoc
        {
            get
            {
                if(_ViewNamHocService == null)
                    _ViewNamHocService = new ViewNamHocService();
                return _ViewNamHocService;
            }
        }
        #endregion        
    
        #region ViewNgachLuongHrmService
        private static ViewNgachLuongHrmService _ViewNgachLuongHrmService;
        /// <summary>
		/// Initializes a new instance of the ViewNgachLuongHrmService class.
		/// </summary>
        public static ViewNgachLuongHrmService ViewNgachLuongHrm
        {
            get
            {
                if(_ViewNgachLuongHrmService == null)
                    _ViewNgachLuongHrmService = new ViewNgachLuongHrmService();
                return _ViewNgachLuongHrmService;
            }
        }
        #endregion        
    
        #region ViewNgayTrongTuanService
        private static ViewNgayTrongTuanService _ViewNgayTrongTuanService;
        /// <summary>
		/// Initializes a new instance of the ViewNgayTrongTuanService class.
		/// </summary>
        public static ViewNgayTrongTuanService ViewNgayTrongTuan
        {
            get
            {
                if(_ViewNgayTrongTuanService == null)
                    _ViewNgayTrongTuanService = new ViewNgayTrongTuanService();
                return _ViewNgayTrongTuanService;
            }
        }
        #endregion        
    
        #region ViewNhomMonHocService
        private static ViewNhomMonHocService _ViewNhomMonHocService;
        /// <summary>
		/// Initializes a new instance of the ViewNhomMonHocService class.
		/// </summary>
        public static ViewNhomMonHocService ViewNhomMonHoc
        {
            get
            {
                if(_ViewNhomMonHocService == null)
                    _ViewNhomMonHocService = new ViewNhomMonHocService();
                return _ViewNhomMonHocService;
            }
        }
        #endregion        
    
        #region ViewPhanCongChuyenMonService
        private static ViewPhanCongChuyenMonService _ViewPhanCongChuyenMonService;
        /// <summary>
		/// Initializes a new instance of the ViewPhanCongChuyenMonService class.
		/// </summary>
        public static ViewPhanCongChuyenMonService ViewPhanCongChuyenMon
        {
            get
            {
                if(_ViewPhanCongChuyenMonService == null)
                    _ViewPhanCongChuyenMonService = new ViewPhanCongChuyenMonService();
                return _ViewPhanCongChuyenMonService;
            }
        }
        #endregion        
    
        #region ViewPhanCongCoVanService
        private static ViewPhanCongCoVanService _ViewPhanCongCoVanService;
        /// <summary>
		/// Initializes a new instance of the ViewPhanCongCoVanService class.
		/// </summary>
        public static ViewPhanCongCoVanService ViewPhanCongCoVan
        {
            get
            {
                if(_ViewPhanCongCoVanService == null)
                    _ViewPhanCongCoVanService = new ViewPhanCongCoVanService();
                return _ViewPhanCongCoVanService;
            }
        }
        #endregion        
    
        #region ViewPhanCongGiangDayService
        private static ViewPhanCongGiangDayService _ViewPhanCongGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ViewPhanCongGiangDayService class.
		/// </summary>
        public static ViewPhanCongGiangDayService ViewPhanCongGiangDay
        {
            get
            {
                if(_ViewPhanCongGiangDayService == null)
                    _ViewPhanCongGiangDayService = new ViewPhanCongGiangDayService();
                return _ViewPhanCongGiangDayService;
            }
        }
        #endregion        
    
        #region ViewPhanLoaiGiangVienService
        private static ViewPhanLoaiGiangVienService _ViewPhanLoaiGiangVienService;
        /// <summary>
		/// Initializes a new instance of the ViewPhanLoaiGiangVienService class.
		/// </summary>
        public static ViewPhanLoaiGiangVienService ViewPhanLoaiGiangVien
        {
            get
            {
                if(_ViewPhanLoaiGiangVienService == null)
                    _ViewPhanLoaiGiangVienService = new ViewPhanLoaiGiangVienService();
                return _ViewPhanLoaiGiangVienService;
            }
        }
        #endregion        
    
        #region ViewPhanNhomMonHocService
        private static ViewPhanNhomMonHocService _ViewPhanNhomMonHocService;
        /// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocService class.
		/// </summary>
        public static ViewPhanNhomMonHocService ViewPhanNhomMonHoc
        {
            get
            {
                if(_ViewPhanNhomMonHocService == null)
                    _ViewPhanNhomMonHocService = new ViewPhanNhomMonHocService();
                return _ViewPhanNhomMonHocService;
            }
        }
        #endregion        
    
        #region ViewPhanNhomMonHocActService
        private static ViewPhanNhomMonHocActService _ViewPhanNhomMonHocActService;
        /// <summary>
		/// Initializes a new instance of the ViewPhanNhomMonHocActService class.
		/// </summary>
        public static ViewPhanNhomMonHocActService ViewPhanNhomMonHocAct
        {
            get
            {
                if(_ViewPhanNhomMonHocActService == null)
                    _ViewPhanNhomMonHocActService = new ViewPhanNhomMonHocActService();
                return _ViewPhanNhomMonHocActService;
            }
        }
        #endregion        
    
        #region ViewPhuCapHanhChinhService
        private static ViewPhuCapHanhChinhService _ViewPhuCapHanhChinhService;
        /// <summary>
		/// Initializes a new instance of the ViewPhuCapHanhChinhService class.
		/// </summary>
        public static ViewPhuCapHanhChinhService ViewPhuCapHanhChinh
        {
            get
            {
                if(_ViewPhuCapHanhChinhService == null)
                    _ViewPhuCapHanhChinhService = new ViewPhuCapHanhChinhService();
                return _ViewPhuCapHanhChinhService;
            }
        }
        #endregion        
    
        #region ViewQuyDoiHoatDongNgoaiGiangDayService
        private static ViewQuyDoiHoatDongNgoaiGiangDayService _ViewQuyDoiHoatDongNgoaiGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ViewQuyDoiHoatDongNgoaiGiangDayService class.
		/// </summary>
        public static ViewQuyDoiHoatDongNgoaiGiangDayService ViewQuyDoiHoatDongNgoaiGiangDay
        {
            get
            {
                if(_ViewQuyDoiHoatDongNgoaiGiangDayService == null)
                    _ViewQuyDoiHoatDongNgoaiGiangDayService = new ViewQuyDoiHoatDongNgoaiGiangDayService();
                return _ViewQuyDoiHoatDongNgoaiGiangDayService;
            }
        }
        #endregion        
    
        #region ViewQuyetDinhDoiHocHamHocViService
        private static ViewQuyetDinhDoiHocHamHocViService _ViewQuyetDinhDoiHocHamHocViService;
        /// <summary>
		/// Initializes a new instance of the ViewQuyetDinhDoiHocHamHocViService class.
		/// </summary>
        public static ViewQuyetDinhDoiHocHamHocViService ViewQuyetDinhDoiHocHamHocVi
        {
            get
            {
                if(_ViewQuyetDinhDoiHocHamHocViService == null)
                    _ViewQuyetDinhDoiHocHamHocViService = new ViewQuyetDinhDoiHocHamHocViService();
                return _ViewQuyetDinhDoiHocHamHocViService;
            }
        }
        #endregion        
    
        #region ViewSdhLietKeKhoiLuongGiangDayChiTietService
        private static ViewSdhLietKeKhoiLuongGiangDayChiTietService _ViewSdhLietKeKhoiLuongGiangDayChiTietService;
        /// <summary>
		/// Initializes a new instance of the ViewSdhLietKeKhoiLuongGiangDayChiTietService class.
		/// </summary>
        public static ViewSdhLietKeKhoiLuongGiangDayChiTietService ViewSdhLietKeKhoiLuongGiangDayChiTiet
        {
            get
            {
                if(_ViewSdhLietKeKhoiLuongGiangDayChiTietService == null)
                    _ViewSdhLietKeKhoiLuongGiangDayChiTietService = new ViewSdhLietKeKhoiLuongGiangDayChiTietService();
                return _ViewSdhLietKeKhoiLuongGiangDayChiTietService;
            }
        }
        #endregion        
    
        #region ViewSdhUteKhoiLuongQuyDoiService
        private static ViewSdhUteKhoiLuongQuyDoiService _ViewSdhUteKhoiLuongQuyDoiService;
        /// <summary>
		/// Initializes a new instance of the ViewSdhUteKhoiLuongQuyDoiService class.
		/// </summary>
        public static ViewSdhUteKhoiLuongQuyDoiService ViewSdhUteKhoiLuongQuyDoi
        {
            get
            {
                if(_ViewSdhUteKhoiLuongQuyDoiService == null)
                    _ViewSdhUteKhoiLuongQuyDoiService = new ViewSdhUteKhoiLuongQuyDoiService();
                return _ViewSdhUteKhoiLuongQuyDoiService;
            }
        }
        #endregion        
    
        #region ViewSinhVienHocPhanService
        private static ViewSinhVienHocPhanService _ViewSinhVienHocPhanService;
        /// <summary>
		/// Initializes a new instance of the ViewSinhVienHocPhanService class.
		/// </summary>
        public static ViewSinhVienHocPhanService ViewSinhVienHocPhan
        {
            get
            {
                if(_ViewSinhVienHocPhanService == null)
                    _ViewSinhVienHocPhanService = new ViewSinhVienHocPhanService();
                return _ViewSinhVienHocPhanService;
            }
        }
        #endregion        
    
        #region ViewSinhVienLopService
        private static ViewSinhVienLopService _ViewSinhVienLopService;
        /// <summary>
		/// Initializes a new instance of the ViewSinhVienLopService class.
		/// </summary>
        public static ViewSinhVienLopService ViewSinhVienLop
        {
            get
            {
                if(_ViewSinhVienLopService == null)
                    _ViewSinhVienLopService = new ViewSinhVienLopService();
                return _ViewSinhVienLopService;
            }
        }
        #endregion        
    
        #region ViewSinhVienLopHocPhanService
        private static ViewSinhVienLopHocPhanService _ViewSinhVienLopHocPhanService;
        /// <summary>
		/// Initializes a new instance of the ViewSinhVienLopHocPhanService class.
		/// </summary>
        public static ViewSinhVienLopHocPhanService ViewSinhVienLopHocPhan
        {
            get
            {
                if(_ViewSinhVienLopHocPhanService == null)
                    _ViewSinhVienLopHocPhanService = new ViewSinhVienLopHocPhanService();
                return _ViewSinhVienLopHocPhanService;
            }
        }
        #endregion        
    
        #region ViewSinhVienLopHocPhanSgService
        private static ViewSinhVienLopHocPhanSgService _ViewSinhVienLopHocPhanSgService;
        /// <summary>
		/// Initializes a new instance of the ViewSinhVienLopHocPhanSgService class.
		/// </summary>
        public static ViewSinhVienLopHocPhanSgService ViewSinhVienLopHocPhanSg
        {
            get
            {
                if(_ViewSinhVienLopHocPhanSgService == null)
                    _ViewSinhVienLopHocPhanSgService = new ViewSinhVienLopHocPhanSgService();
                return _ViewSinhVienLopHocPhanSgService;
            }
        }
        #endregion        
    
        #region ViewSoTietCoiThiTieuChuanCuaGiangVienService
        private static ViewSoTietCoiThiTieuChuanCuaGiangVienService _ViewSoTietCoiThiTieuChuanCuaGiangVienService;
        /// <summary>
		/// Initializes a new instance of the ViewSoTietCoiThiTieuChuanCuaGiangVienService class.
		/// </summary>
        public static ViewSoTietCoiThiTieuChuanCuaGiangVienService ViewSoTietCoiThiTieuChuanCuaGiangVien
        {
            get
            {
                if(_ViewSoTietCoiThiTieuChuanCuaGiangVienService == null)
                    _ViewSoTietCoiThiTieuChuanCuaGiangVienService = new ViewSoTietCoiThiTieuChuanCuaGiangVienService();
                return _ViewSoTietCoiThiTieuChuanCuaGiangVienService;
            }
        }
        #endregion        
    
        #region ViewThamDinhLuanVanThacSyService
        private static ViewThamDinhLuanVanThacSyService _ViewThamDinhLuanVanThacSyService;
        /// <summary>
		/// Initializes a new instance of the ViewThamDinhLuanVanThacSyService class.
		/// </summary>
        public static ViewThamDinhLuanVanThacSyService ViewThamDinhLuanVanThacSy
        {
            get
            {
                if(_ViewThamDinhLuanVanThacSyService == null)
                    _ViewThamDinhLuanVanThacSyService = new ViewThamDinhLuanVanThacSyService();
                return _ViewThamDinhLuanVanThacSyService;
            }
        }
        #endregion        
    
        #region ViewThanhToanGioDayService
        private static ViewThanhToanGioDayService _ViewThanhToanGioDayService;
        /// <summary>
		/// Initializes a new instance of the ViewThanhToanGioDayService class.
		/// </summary>
        public static ViewThanhToanGioDayService ViewThanhToanGioDay
        {
            get
            {
                if(_ViewThanhToanGioDayService == null)
                    _ViewThanhToanGioDayService = new ViewThanhToanGioDayService();
                return _ViewThanhToanGioDayService;
            }
        }
        #endregion        
    
        #region ViewThanhToanThuLaoService
        private static ViewThanhToanThuLaoService _ViewThanhToanThuLaoService;
        /// <summary>
		/// Initializes a new instance of the ViewThanhToanThuLaoService class.
		/// </summary>
        public static ViewThanhToanThuLaoService ViewThanhToanThuLao
        {
            get
            {
                if(_ViewThanhToanThuLaoService == null)
                    _ViewThanhToanThuLaoService = new ViewThanhToanThuLaoService();
                return _ViewThanhToanThuLaoService;
            }
        }
        #endregion        
    
        #region ViewThanhToanTienGiangService
        private static ViewThanhToanTienGiangService _ViewThanhToanTienGiangService;
        /// <summary>
		/// Initializes a new instance of the ViewThanhToanTienGiangService class.
		/// </summary>
        public static ViewThanhToanTienGiangService ViewThanhToanTienGiang
        {
            get
            {
                if(_ViewThanhToanTienGiangService == null)
                    _ViewThanhToanTienGiangService = new ViewThanhToanTienGiangService();
                return _ViewThanhToanTienGiangService;
            }
        }
        #endregion        
    
        #region ViewThanhTraChamGiangTheoKhoaHocService
        private static ViewThanhTraChamGiangTheoKhoaHocService _ViewThanhTraChamGiangTheoKhoaHocService;
        /// <summary>
		/// Initializes a new instance of the ViewThanhTraChamGiangTheoKhoaHocService class.
		/// </summary>
        public static ViewThanhTraChamGiangTheoKhoaHocService ViewThanhTraChamGiangTheoKhoaHoc
        {
            get
            {
                if(_ViewThanhTraChamGiangTheoKhoaHocService == null)
                    _ViewThanhTraChamGiangTheoKhoaHocService = new ViewThanhTraChamGiangTheoKhoaHocService();
                return _ViewThanhTraChamGiangTheoKhoaHocService;
            }
        }
        #endregion        
    
        #region ViewThanhTraCoiThiService
        private static ViewThanhTraCoiThiService _ViewThanhTraCoiThiService;
        /// <summary>
		/// Initializes a new instance of the ViewThanhTraCoiThiService class.
		/// </summary>
        public static ViewThanhTraCoiThiService ViewThanhTraCoiThi
        {
            get
            {
                if(_ViewThanhTraCoiThiService == null)
                    _ViewThanhTraCoiThiService = new ViewThanhTraCoiThiService();
                return _ViewThanhTraCoiThiService;
            }
        }
        #endregion        
    
        #region ViewThanhTraGiangDayService
        private static ViewThanhTraGiangDayService _ViewThanhTraGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ViewThanhTraGiangDayService class.
		/// </summary>
        public static ViewThanhTraGiangDayService ViewThanhTraGiangDay
        {
            get
            {
                if(_ViewThanhTraGiangDayService == null)
                    _ViewThanhTraGiangDayService = new ViewThanhTraGiangDayService();
                return _ViewThanhTraGiangDayService;
            }
        }
        #endregion        
    
        #region ViewThanhTraTheoThoiKhoaBieuService
        private static ViewThanhTraTheoThoiKhoaBieuService _ViewThanhTraTheoThoiKhoaBieuService;
        /// <summary>
		/// Initializes a new instance of the ViewThanhTraTheoThoiKhoaBieuService class.
		/// </summary>
        public static ViewThanhTraTheoThoiKhoaBieuService ViewThanhTraTheoThoiKhoaBieu
        {
            get
            {
                if(_ViewThanhTraTheoThoiKhoaBieuService == null)
                    _ViewThanhTraTheoThoiKhoaBieuService = new ViewThanhTraTheoThoiKhoaBieuService();
                return _ViewThanhTraTheoThoiKhoaBieuService;
            }
        }
        #endregion        
    
        #region ViewTheoDoiGiangDayService
        private static ViewTheoDoiGiangDayService _ViewTheoDoiGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ViewTheoDoiGiangDayService class.
		/// </summary>
        public static ViewTheoDoiGiangDayService ViewTheoDoiGiangDay
        {
            get
            {
                if(_ViewTheoDoiGiangDayService == null)
                    _ViewTheoDoiGiangDayService = new ViewTheoDoiGiangDayService();
                return _ViewTheoDoiGiangDayService;
            }
        }
        #endregion        
    
        #region ViewThoiGianLamViecCuaNhanVienService
        private static ViewThoiGianLamViecCuaNhanVienService _ViewThoiGianLamViecCuaNhanVienService;
        /// <summary>
		/// Initializes a new instance of the ViewThoiGianLamViecCuaNhanVienService class.
		/// </summary>
        public static ViewThoiGianLamViecCuaNhanVienService ViewThoiGianLamViecCuaNhanVien
        {
            get
            {
                if(_ViewThoiGianLamViecCuaNhanVienService == null)
                    _ViewThoiGianLamViecCuaNhanVienService = new ViewThoiGianLamViecCuaNhanVienService();
                return _ViewThoiGianLamViecCuaNhanVienService;
            }
        }
        #endregion        
    
        #region ViewThoiGianNghiTamThoiCuaGiangVienService
        private static ViewThoiGianNghiTamThoiCuaGiangVienService _ViewThoiGianNghiTamThoiCuaGiangVienService;
        /// <summary>
		/// Initializes a new instance of the ViewThoiGianNghiTamThoiCuaGiangVienService class.
		/// </summary>
        public static ViewThoiGianNghiTamThoiCuaGiangVienService ViewThoiGianNghiTamThoiCuaGiangVien
        {
            get
            {
                if(_ViewThoiGianNghiTamThoiCuaGiangVienService == null)
                    _ViewThoiGianNghiTamThoiCuaGiangVienService = new ViewThoiGianNghiTamThoiCuaGiangVienService();
                return _ViewThoiGianNghiTamThoiCuaGiangVienService;
            }
        }
        #endregion        
    
        #region ViewThoiKhoaBieuService
        private static ViewThoiKhoaBieuService _ViewThoiKhoaBieuService;
        /// <summary>
		/// Initializes a new instance of the ViewThoiKhoaBieuService class.
		/// </summary>
        public static ViewThoiKhoaBieuService ViewThoiKhoaBieu
        {
            get
            {
                if(_ViewThoiKhoaBieuService == null)
                    _ViewThoiKhoaBieuService = new ViewThoiKhoaBieuService();
                return _ViewThoiKhoaBieuService;
            }
        }
        #endregion        
    
        #region ViewThongKeChucVuService
        private static ViewThongKeChucVuService _ViewThongKeChucVuService;
        /// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuService class.
		/// </summary>
        public static ViewThongKeChucVuService ViewThongKeChucVu
        {
            get
            {
                if(_ViewThongKeChucVuService == null)
                    _ViewThongKeChucVuService = new ViewThongKeChucVuService();
                return _ViewThongKeChucVuService;
            }
        }
        #endregion        
    
        #region ViewThongKeHoSoService
        private static ViewThongKeHoSoService _ViewThongKeHoSoService;
        /// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoService class.
		/// </summary>
        public static ViewThongKeHoSoService ViewThongKeHoSo
        {
            get
            {
                if(_ViewThongKeHoSoService == null)
                    _ViewThongKeHoSoService = new ViewThongKeHoSoService();
                return _ViewThongKeHoSoService;
            }
        }
        #endregion        
    
        #region ViewThongKeHoSoChiTietService
        private static ViewThongKeHoSoChiTietService _ViewThongKeHoSoChiTietService;
        /// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoChiTietService class.
		/// </summary>
        public static ViewThongKeHoSoChiTietService ViewThongKeHoSoChiTiet
        {
            get
            {
                if(_ViewThongKeHoSoChiTietService == null)
                    _ViewThongKeHoSoChiTietService = new ViewThongKeHoSoChiTietService();
                return _ViewThongKeHoSoChiTietService;
            }
        }
        #endregion        
    
        #region ViewThongTinChiTietGiangVienService
        private static ViewThongTinChiTietGiangVienService _ViewThongTinChiTietGiangVienService;
        /// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienService class.
		/// </summary>
        public static ViewThongTinChiTietGiangVienService ViewThongTinChiTietGiangVien
        {
            get
            {
                if(_ViewThongTinChiTietGiangVienService == null)
                    _ViewThongTinChiTietGiangVienService = new ViewThongTinChiTietGiangVienService();
                return _ViewThongTinChiTietGiangVienService;
            }
        }
        #endregion        
    
        #region ViewThongTinChiTietGiangVienChoDuyetHoSoService
        private static ViewThongTinChiTietGiangVienChoDuyetHoSoService _ViewThongTinChiTietGiangVienChoDuyetHoSoService;
        /// <summary>
		/// Initializes a new instance of the ViewThongTinChiTietGiangVienChoDuyetHoSoService class.
		/// </summary>
        public static ViewThongTinChiTietGiangVienChoDuyetHoSoService ViewThongTinChiTietGiangVienChoDuyetHoSo
        {
            get
            {
                if(_ViewThongTinChiTietGiangVienChoDuyetHoSoService == null)
                    _ViewThongTinChiTietGiangVienChoDuyetHoSoService = new ViewThongTinChiTietGiangVienChoDuyetHoSoService();
                return _ViewThongTinChiTietGiangVienChoDuyetHoSoService;
            }
        }
        #endregion        
    
        #region ViewThongTinGiangVienService
        private static ViewThongTinGiangVienService _ViewThongTinGiangVienService;
        /// <summary>
		/// Initializes a new instance of the ViewThongTinGiangVienService class.
		/// </summary>
        public static ViewThongTinGiangVienService ViewThongTinGiangVien
        {
            get
            {
                if(_ViewThongTinGiangVienService == null)
                    _ViewThongTinGiangVienService = new ViewThongTinGiangVienService();
                return _ViewThongTinGiangVienService;
            }
        }
        #endregion        
    
        #region ViewThongTinLopHocPhanHeSoCongViecService
        private static ViewThongTinLopHocPhanHeSoCongViecService _ViewThongTinLopHocPhanHeSoCongViecService;
        /// <summary>
		/// Initializes a new instance of the ViewThongTinLopHocPhanHeSoCongViecService class.
		/// </summary>
        public static ViewThongTinLopHocPhanHeSoCongViecService ViewThongTinLopHocPhanHeSoCongViec
        {
            get
            {
                if(_ViewThongTinLopHocPhanHeSoCongViecService == null)
                    _ViewThongTinLopHocPhanHeSoCongViecService = new ViewThongTinLopHocPhanHeSoCongViecService();
                return _ViewThongTinLopHocPhanHeSoCongViecService;
            }
        }
        #endregion        
    
        #region ViewTietGiangDayService
        private static ViewTietGiangDayService _ViewTietGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ViewTietGiangDayService class.
		/// </summary>
        public static ViewTietGiangDayService ViewTietGiangDay
        {
            get
            {
                if(_ViewTietGiangDayService == null)
                    _ViewTietGiangDayService = new ViewTietGiangDayService();
                return _ViewTietGiangDayService;
            }
        }
        #endregion        
    
        #region ViewTietNghiaVuService
        private static ViewTietNghiaVuService _ViewTietNghiaVuService;
        /// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuService class.
		/// </summary>
        public static ViewTietNghiaVuService ViewTietNghiaVu
        {
            get
            {
                if(_ViewTietNghiaVuService == null)
                    _ViewTietNghiaVuService = new ViewTietNghiaVuService();
                return _ViewTietNghiaVuService;
            }
        }
        #endregion        
    
        #region ViewTietNghiaVuTheoNamHocHocKyService
        private static ViewTietNghiaVuTheoNamHocHocKyService _ViewTietNghiaVuTheoNamHocHocKyService;
        /// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuTheoNamHocHocKyService class.
		/// </summary>
        public static ViewTietNghiaVuTheoNamHocHocKyService ViewTietNghiaVuTheoNamHocHocKy
        {
            get
            {
                if(_ViewTietNghiaVuTheoNamHocHocKyService == null)
                    _ViewTietNghiaVuTheoNamHocHocKyService = new ViewTietNghiaVuTheoNamHocHocKyService();
                return _ViewTietNghiaVuTheoNamHocHocKyService;
            }
        }
        #endregion        
    
        #region ViewTietNoKyTruocService
        private static ViewTietNoKyTruocService _ViewTietNoKyTruocService;
        /// <summary>
		/// Initializes a new instance of the ViewTietNoKyTruocService class.
		/// </summary>
        public static ViewTietNoKyTruocService ViewTietNoKyTruoc
        {
            get
            {
                if(_ViewTietNoKyTruocService == null)
                    _ViewTietNoKyTruocService = new ViewTietNoKyTruocService();
                return _ViewTietNoKyTruocService;
            }
        }
        #endregion        
    
        #region ViewTinhKhoiLuongService
        private static ViewTinhKhoiLuongService _ViewTinhKhoiLuongService;
        /// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongService class.
		/// </summary>
        public static ViewTinhKhoiLuongService ViewTinhKhoiLuong
        {
            get
            {
                if(_ViewTinhKhoiLuongService == null)
                    _ViewTinhKhoiLuongService = new ViewTinhKhoiLuongService();
                return _ViewTinhKhoiLuongService;
            }
        }
        #endregion        
    
        #region ViewTinhKhoiLuongTungTuanService
        private static ViewTinhKhoiLuongTungTuanService _ViewTinhKhoiLuongTungTuanService;
        /// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongTungTuanService class.
		/// </summary>
        public static ViewTinhKhoiLuongTungTuanService ViewTinhKhoiLuongTungTuan
        {
            get
            {
                if(_ViewTinhKhoiLuongTungTuanService == null)
                    _ViewTinhKhoiLuongTungTuanService = new ViewTinhKhoiLuongTungTuanService();
                return _ViewTinhKhoiLuongTungTuanService;
            }
        }
        #endregion        
    
        #region ViewTongHopChiTienCoVanService
        private static ViewTongHopChiTienCoVanService _ViewTongHopChiTienCoVanService;
        /// <summary>
		/// Initializes a new instance of the ViewTongHopChiTienCoVanService class.
		/// </summary>
        public static ViewTongHopChiTienCoVanService ViewTongHopChiTienCoVan
        {
            get
            {
                if(_ViewTongHopChiTienCoVanService == null)
                    _ViewTongHopChiTienCoVanService = new ViewTongHopChiTienCoVanService();
                return _ViewTongHopChiTienCoVanService;
            }
        }
        #endregion        
    
        #region ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyService
        private static ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyService _ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyService;
        /// <summary>
		/// Initializes a new instance of the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyService class.
		/// </summary>
        public static ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyService ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy
        {
            get
            {
                if(_ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyService == null)
                    _ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyService = new ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyService();
                return _ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyService;
            }
        }
        #endregion        
    
        #region ViewTongHopQuyDoiService
        private static ViewTongHopQuyDoiService _ViewTongHopQuyDoiService;
        /// <summary>
		/// Initializes a new instance of the ViewTongHopQuyDoiService class.
		/// </summary>
        public static ViewTongHopQuyDoiService ViewTongHopQuyDoi
        {
            get
            {
                if(_ViewTongHopQuyDoiService == null)
                    _ViewTongHopQuyDoiService = new ViewTongHopQuyDoiService();
                return _ViewTongHopQuyDoiService;
            }
        }
        #endregion        
    
        #region ViewTongHopGioDayGiangVienService
        private static ViewTongHopGioDayGiangVienService _ViewTongHopGioDayGiangVienService;
        /// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayGiangVienService class.
		/// </summary>
        public static ViewTongHopGioDayGiangVienService ViewTongHopGioDayGiangVien
        {
            get
            {
                if(_ViewTongHopGioDayGiangVienService == null)
                    _ViewTongHopGioDayGiangVienService = new ViewTongHopGioDayGiangVienService();
                return _ViewTongHopGioDayGiangVienService;
            }
        }
        #endregion        
    
        #region ViewTonGiaoService
        private static ViewTonGiaoService _ViewTonGiaoService;
        /// <summary>
		/// Initializes a new instance of the ViewTonGiaoService class.
		/// </summary>
        public static ViewTonGiaoService ViewTonGiao
        {
            get
            {
                if(_ViewTonGiaoService == null)
                    _ViewTonGiaoService = new ViewTonGiaoService();
                return _ViewTonGiaoService;
            }
        }
        #endregion        
    
        #region ViewUteKhoiLuongGiangDayService
        private static ViewUteKhoiLuongGiangDayService _ViewUteKhoiLuongGiangDayService;
        /// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongGiangDayService class.
		/// </summary>
        public static ViewUteKhoiLuongGiangDayService ViewUteKhoiLuongGiangDay
        {
            get
            {
                if(_ViewUteKhoiLuongGiangDayService == null)
                    _ViewUteKhoiLuongGiangDayService = new ViewUteKhoiLuongGiangDayService();
                return _ViewUteKhoiLuongGiangDayService;
            }
        }
        #endregion        
    
        #region ViewUteKhoiLuongQuyDoiService
        private static ViewUteKhoiLuongQuyDoiService _ViewUteKhoiLuongQuyDoiService;
        /// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongQuyDoiService class.
		/// </summary>
        public static ViewUteKhoiLuongQuyDoiService ViewUteKhoiLuongQuyDoi
        {
            get
            {
                if(_ViewUteKhoiLuongQuyDoiService == null)
                    _ViewUteKhoiLuongQuyDoiService = new ViewUteKhoiLuongQuyDoiService();
                return _ViewUteKhoiLuongQuyDoiService;
            }
        }
        #endregion        
    
        #region ViewUteKhoiLuongQuyDoi2Service
        private static ViewUteKhoiLuongQuyDoi2Service _ViewUteKhoiLuongQuyDoi2Service;
        /// <summary>
		/// Initializes a new instance of the ViewUteKhoiLuongQuyDoi2Service class.
		/// </summary>
        public static ViewUteKhoiLuongQuyDoi2Service ViewUteKhoiLuongQuyDoi2
        {
            get
            {
                if(_ViewUteKhoiLuongQuyDoi2Service == null)
                    _ViewUteKhoiLuongQuyDoi2Service = new ViewUteKhoiLuongQuyDoi2Service();
                return _ViewUteKhoiLuongQuyDoi2Service;
            }
        }
        #endregion        
    
        #region ViewXetDuyetDeCuongLuanVanCaoHocService
        private static ViewXetDuyetDeCuongLuanVanCaoHocService _ViewXetDuyetDeCuongLuanVanCaoHocService;
        /// <summary>
		/// Initializes a new instance of the ViewXetDuyetDeCuongLuanVanCaoHocService class.
		/// </summary>
        public static ViewXetDuyetDeCuongLuanVanCaoHocService ViewXetDuyetDeCuongLuanVanCaoHoc
        {
            get
            {
                if(_ViewXetDuyetDeCuongLuanVanCaoHocService == null)
                    _ViewXetDuyetDeCuongLuanVanCaoHocService = new ViewXetDuyetDeCuongLuanVanCaoHocService();
                return _ViewXetDuyetDeCuongLuanVanCaoHocService;
            }
        }
        #endregion        
    
        #region ViewXuLyQuyDoiService
        private static ViewXuLyQuyDoiService _ViewXuLyQuyDoiService;
        /// <summary>
		/// Initializes a new instance of the ViewXuLyQuyDoiService class.
		/// </summary>
        public static ViewXuLyQuyDoiService ViewXuLyQuyDoi
        {
            get
            {
                if(_ViewXuLyQuyDoiService == null)
                    _ViewXuLyQuyDoiService = new ViewXuLyQuyDoiService();
                return _ViewXuLyQuyDoiService;
            }
        }
        #endregion        
    
        #region ViewXuLyQuyDoiTungTuanService
        private static ViewXuLyQuyDoiTungTuanService _ViewXuLyQuyDoiTungTuanService;
        /// <summary>
		/// Initializes a new instance of the ViewXuLyQuyDoiTungTuanService class.
		/// </summary>
        public static ViewXuLyQuyDoiTungTuanService ViewXuLyQuyDoiTungTuan
        {
            get
            {
                if(_ViewXuLyQuyDoiTungTuanService == null)
                    _ViewXuLyQuyDoiTungTuanService = new ViewXuLyQuyDoiTungTuanService();
                return _ViewXuLyQuyDoiTungTuanService;
            }
        }
        #endregion        
	}	
}
