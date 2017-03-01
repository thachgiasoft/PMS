using System;
using PMS.Services;

namespace PMS.Common
{
    public class DataService
    {
        private static QuyUocDatTenLopHocPhanService _quyUocDatTenLopHocPhanService;
        public static QuyUocDatTenLopHocPhanService QuyUocDatTenLopHocPhan
        {
            get
            {
                if (_quyUocDatTenLopHocPhanService == null)
                    _quyUocDatTenLopHocPhanService = new QuyUocDatTenLopHocPhanService();
                return _quyUocDatTenLopHocPhanService;
            }
        }

        private static ViewLietKeKhoiLuongGiangDayChiTietUsshService _viewLietKeKhoiLuongGiangDayChiTietUsshService;
        public static ViewLietKeKhoiLuongGiangDayChiTietUsshService ViewLietKeKhoiLuongGiangDayChiTietUSSH
        {
            get
            {
                if (_viewLietKeKhoiLuongGiangDayChiTietUsshService == null)
                    _viewLietKeKhoiLuongGiangDayChiTietUsshService = new ViewLietKeKhoiLuongGiangDayChiTietUsshService();
                return _viewLietKeKhoiLuongGiangDayChiTietUsshService;
            }
        }

        private static BacLuongService _bacLuongService;
        public static BacLuongService BacLuong
        {
            get
            {
                if (_bacLuongService == null)
                    _bacLuongService = new BacLuongService();
                return _bacLuongService;
            }
        }


        private static HuongDanKhoaLuanThucTapService _huongDanKhoaLuanThucTapService;
        public static HuongDanKhoaLuanThucTapService HuongDanKhoaLuanThucTap
        {
            get
            {
                if (_huongDanKhoaLuanThucTapService == null)
                    _huongDanKhoaLuanThucTapService = new HuongDanKhoaLuanThucTapService();
                return _huongDanKhoaLuanThucTapService;
            }
        }

        private static DinhMucHuongDanKhoaLuanThucTapService _dinhMucHuongDanKhoaLuanThucTapService;
        public static DinhMucHuongDanKhoaLuanThucTapService DinhMucHuongDanKhoaLuanThucTap
        {
            get
            {
                if (_dinhMucHuongDanKhoaLuanThucTapService == null)
                    _dinhMucHuongDanKhoaLuanThucTapService = new DinhMucHuongDanKhoaLuanThucTapService();
                return _dinhMucHuongDanKhoaLuanThucTapService;
            }
        }

        private static HinhThucDaoTaoService _hinhThucDaoTaoService;
        public static HinhThucDaoTaoService HinhThucDaoTao
        {
            get
            {
                if (_hinhThucDaoTaoService == null)
                    _hinhThucDaoTaoService = new HinhThucDaoTaoService();
                return _hinhThucDaoTaoService;
            }
        }

        private static ThuLaoHuongDanCuoiKhoaService _thuLaoHuongDanCuoiKhoaService;
        public static ThuLaoHuongDanCuoiKhoaService ThuLaoHuongDanCuoiKhoa
        {
            get
            {
                if (_thuLaoHuongDanCuoiKhoaService == null)
                    _thuLaoHuongDanCuoiKhoaService = new ThuLaoHuongDanCuoiKhoaService();
                return _thuLaoHuongDanCuoiKhoaService;
            }
        }

        private static ThuLaoImportService _thuLaoImportService;
        public static ThuLaoImportService ThuLaoImport
        {
            get
            {
                if (_thuLaoImportService == null)
                    _thuLaoImportService = new ThuLaoImportService();
                return _thuLaoImportService;
            }
        }

        private static MonTieuLuanService _monTieuLuanService;
        public static MonTieuLuanService MonTieuLuan
        {
            get
            {
                if (_monTieuLuanService == null)
                    _monTieuLuanService = new MonTieuLuanService();
                return _monTieuLuanService;
            }
        }


        private static MonHocKhongTinhKhoiLuongService _monHocKhongTinhKhoiLuongService;
        public static MonHocKhongTinhKhoiLuongService MonHocKhongTinhKhoiLuong
        {
            get
            {
                if (_monHocKhongTinhKhoiLuongService == null)
                    _monHocKhongTinhKhoiLuongService = new MonHocKhongTinhKhoiLuongService();
                return _monHocKhongTinhKhoiLuongService;
            }
        }

        private static GiangDaySauDaiHocService _giangDaySauDaiHocService;
        public static GiangDaySauDaiHocService GiangDaySauDaiHoc
        {
            get
            {
                if (_giangDaySauDaiHocService == null)
                    _giangDaySauDaiHocService = new GiangDaySauDaiHocService();
                return _giangDaySauDaiHocService;
            }
        }

        private static HopDongThinhGiangService _hopDongThinhGiangService;
        public static HopDongThinhGiangService HopDongThinhGiang
        {
            get
            {
                if (_hopDongThinhGiangService == null)
                    _hopDongThinhGiangService = new HopDongThinhGiangService();
                return _hopDongThinhGiangService;
            }
        }

        private static ViewHopDongThinhGiangService _viewHopDongThinhGiangService;
        public static ViewHopDongThinhGiangService ViewHopDongThinhGiang
        {
            get
            {
                if (_viewHopDongThinhGiangService == null)
                    _viewHopDongThinhGiangService = new ViewHopDongThinhGiangService();
                return _viewHopDongThinhGiangService;
            }
        }

        private static PhuCapHanhChinhService _phuCapHanhChinhService;
        public static PhuCapHanhChinhService PhuCapHanhChinh
        {
            get
            {
                if (_phuCapHanhChinhService == null)
                    _phuCapHanhChinhService = new PhuCapHanhChinhService();
                return _phuCapHanhChinhService;
            }
        }

        private static ViewPhuCapHanhChinhService _viewPhuCapHanhChinhService;
        public static ViewPhuCapHanhChinhService ViewPhuCapHanhChinh
        {
            get
            {
                if (_viewPhuCapHanhChinhService == null)
                    _viewPhuCapHanhChinhService = new ViewPhuCapHanhChinhService();
                return _viewPhuCapHanhChinhService;
            }
        }

        private static ViewHocPhanMonHocService _viewHocPhanMonHocService;
        public static ViewHocPhanMonHocService ViewHocPhanMonHoc
        {
            get
            {
                if (_viewHocPhanMonHocService == null)
                    _viewHocPhanMonHocService = new ViewHocPhanMonHocService();
                return _viewHocPhanMonHocService;
            }
        }

        private static MonThucTapTotNghiepService _monThucTapTotNghiepService;
        public static MonThucTapTotNghiepService MonThucTapTotNghiep
        {
            get
            {
                if (_monThucTapTotNghiepService == null)
                    _monThucTapTotNghiepService = new MonThucTapTotNghiepService();
                return _monThucTapTotNghiepService;
            }
        }

        private static ViewMonThucTapTotNghiepService _viewMonThucTapTotNghiepService;
        public static ViewMonThucTapTotNghiepService ViewMonThucTapTotNghiep
        {
            get
            {
                if (_viewMonThucTapTotNghiepService == null)
                    _viewMonThucTapTotNghiepService = new ViewMonThucTapTotNghiepService();
                return _viewMonThucTapTotNghiepService;
            }
        }

        private static KetQuaCacKhoanChiKhacService _ketQuaCacKhoanChiKhacService;
        public static KetQuaCacKhoanChiKhacService KetQuaCacKhoanChiKhac
        {
            get
            {
                if (_ketQuaCacKhoanChiKhacService == null)
                    _ketQuaCacKhoanChiKhacService = new KetQuaCacKhoanChiKhacService();
                return _ketQuaCacKhoanChiKhacService;
            }
        }

        private static ViewKetQuaCacKhoanChiKhacService _viewKetQuaCacKhoanChiKhacService;
        public static ViewKetQuaCacKhoanChiKhacService ViewKetQuaCacKhoanChiKhac
        {
            get
            {
                if (_viewKetQuaCacKhoanChiKhacService == null)
                    _viewKetQuaCacKhoanChiKhacService = new ViewKetQuaCacKhoanChiKhacService();
                return _viewKetQuaCacKhoanChiKhacService;
            }
        }

        private static KyTinhLuongService _kyTinhLuongService;
        public static KyTinhLuongService KyTinhLuong
        {
            get
            {
                if (_kyTinhLuongService == null)
                    _kyTinhLuongService = new KyTinhLuongService();
                return _kyTinhLuongService;
            }
        }

        private static KhoanChiKhacService _khoanChiKhacService;
        public static KhoanChiKhacService KhoanChiKhac
        {
            get
            {
                if (_khoanChiKhacService == null)
                    _khoanChiKhacService = new KhoanChiKhacService();
                return _khoanChiKhacService;
            }
        }

        private static ViewDoiTuongDonGiaService _viewDoiTuongDonGiaService;
        public static ViewDoiTuongDonGiaService ViewDoiTuongDonGia
        {
            get
            {
                if (_viewDoiTuongDonGiaService == null)
                    _viewDoiTuongDonGiaService = new ViewDoiTuongDonGiaService();
                return _viewDoiTuongDonGiaService;
            }
        }


        private static TienCongTacPhiService _tienCongTacPhiService;
        public static TienCongTacPhiService TienCongTacPhi
        {
            get
            {
                if (_tienCongTacPhiService == null)
                    _tienCongTacPhiService = new TienCongTacPhiService();
                return _tienCongTacPhiService;
            }
        }

        private static ThangHeService _thangHeService;
        public static ThangHeService ThangHe
        {
            get
            {
                if (_thangHeService == null)
                    _thangHeService = new ThangHeService();
                return _thangHeService;
            }
        }

        private static DonGiaTcbService _donGiaTcbService;
        public static DonGiaTcbService DonGiaTcb
        {
            get
            {
                if (_donGiaTcbService == null)
                    _donGiaTcbService = new DonGiaTcbService();
                return _donGiaTcbService;
            }
        }

        private static TcbKetQuaQuyDoiService _tcbKetQuaQuyDoiService;
        public static TcbKetQuaQuyDoiService TcbKetQuaQuyDoi
        {
            get
            {
                if (_tcbKetQuaQuyDoiService == null)
                    _tcbKetQuaQuyDoiService = new TcbKetQuaQuyDoiService();
                return _tcbKetQuaQuyDoiService;
            }
        }

        private static MonPhanCongNhieuGiangVienService _monPhanCongNhieuGiangVienService;
        public static MonPhanCongNhieuGiangVienService MonPhanCongNhieuGiangVien
        {
            get
            {
                if (_monPhanCongNhieuGiangVienService == null)
                    _monPhanCongNhieuGiangVienService = new MonPhanCongNhieuGiangVienService();
                return _monPhanCongNhieuGiangVienService;
            }
        }


        private static GiangVienPhanHoiService _giangVienPhanHoiService;
        public static GiangVienPhanHoiService GiangVienPhanHoi
        {
            get
            {
                if (_giangVienPhanHoiService == null)
                    _giangVienPhanHoiService = new GiangVienPhanHoiService();
                return _giangVienPhanHoiService;
            }
        }

        private static CauHinhGiangVienPhanHoiService _cauHinhGiangVienPhanHoiService;
        public static CauHinhGiangVienPhanHoiService CauHinhGiangVienPhanHoi
        {
            get
            {
                if (_cauHinhGiangVienPhanHoiService == null)
                    _cauHinhGiangVienPhanHoiService = new CauHinhGiangVienPhanHoiService();
                return _cauHinhGiangVienPhanHoiService;
            }
        }

        private static ViewMonXepLichChuNhatKhongTinhHeSoService _viewMonXepLichChuNhatKhongTinhHeSoService;
        public static ViewMonXepLichChuNhatKhongTinhHeSoService ViewMonXepLichChuNhatKhongTinhHeSo
        {
            get
            {
                if (_viewMonXepLichChuNhatKhongTinhHeSoService == null)
                    _viewMonXepLichChuNhatKhongTinhHeSoService = new ViewMonXepLichChuNhatKhongTinhHeSoService();
                return _viewMonXepLichChuNhatKhongTinhHeSoService;
            }
        }

        private static MonXepLichChuNhatKhongTinhHeSoService _monXepLichChuNhatKhongTinhHeSoService;
        public static MonXepLichChuNhatKhongTinhHeSoService MonXepLichChuNhatKhongTinhHeSo
        {
            get
            {
                if (_monXepLichChuNhatKhongTinhHeSoService == null)
                    _monXepLichChuNhatKhongTinhHeSoService = new MonXepLichChuNhatKhongTinhHeSoService();
                return _monXepLichChuNhatKhongTinhHeSoService;
            }
        }

        private static ViewKetQuaThanhToanThuLaoService _viewKetQuaThanhToanThuLaoService;
        public static ViewKetQuaThanhToanThuLaoService ViewKetQuaThanhToanThuLao
        {
            get
            {
                if (_viewKetQuaThanhToanThuLaoService == null)
                    _viewKetQuaThanhToanThuLaoService = new ViewKetQuaThanhToanThuLaoService();
                return _viewKetQuaThanhToanThuLaoService;
            }
        }

        private static KetQuaThanhToanThuLaoService _ketQuaThanhToanThuLaoService;
        public static KetQuaThanhToanThuLaoService KetQuaThanhToanThuLao
        {
            get
            {
                if (_ketQuaThanhToanThuLaoService == null)
                    _ketQuaThanhToanThuLaoService = new KetQuaThanhToanThuLaoService();
                return _ketQuaThanhToanThuLaoService;
            }
        }

        private static ViewLietKeKhoiLuongGiangDayChiTietService _viewLietKeKhoiLuongGiangDayChiTietService;
        public static ViewLietKeKhoiLuongGiangDayChiTietService ViewLietKeKhoiLuongGiangDayChiTiet
        {
            get
            {
                if (_viewLietKeKhoiLuongGiangDayChiTietService == null)
                    _viewLietKeKhoiLuongGiangDayChiTietService = new ViewLietKeKhoiLuongGiangDayChiTietService();
                return _viewLietKeKhoiLuongGiangDayChiTietService;
            }
        }

        private static ViewTietNghiaVuService _viewTietNghiaVuService;
        public static ViewTietNghiaVuService ViewTietNghiaVu
        {
            get
            {
                if (_viewTietNghiaVuService == null)
                    _viewTietNghiaVuService = new ViewTietNghiaVuService();
                return _viewTietNghiaVuService;
            }
        }

        private static TietNghiaVuService _tietNghiaVuService;
        public static TietNghiaVuService TietNghiaVu
        {
            get
            {
                if (_tietNghiaVuService == null)
                    _tietNghiaVuService = new TietNghiaVuService();
                return _tietNghiaVuService;
            }
        }

        private static ViewDonGiaNgoaiQuyCheService _viewDonGiaNgoaiQuyCheService;
        public static ViewDonGiaNgoaiQuyCheService ViewDonGiaNgoaiQuyChe
        {
            get
            {
                if (_viewDonGiaNgoaiQuyCheService == null)
                    _viewDonGiaNgoaiQuyCheService = new ViewDonGiaNgoaiQuyCheService();
                return _viewDonGiaNgoaiQuyCheService;
            }
        }

        private static DonGiaNgoaiQuyCheService _donGiaNgoaiQuyCheService;
        public static DonGiaNgoaiQuyCheService DonGiaNgoaiQuyChe
        {
            get
            {
                if (_donGiaNgoaiQuyCheService == null)
                    _donGiaNgoaiQuyCheService = new DonGiaNgoaiQuyCheService();
                return _donGiaNgoaiQuyCheService;
            }
        }

        private static ThoiGianGiangDayService _thoiGianGiangDayService;
        public static ThoiGianGiangDayService ThoiGianGiangDay
        {
            get
            {
                if (_thoiGianGiangDayService == null)
                    _thoiGianGiangDayService = new ThoiGianGiangDayService();
                return _thoiGianGiangDayService;
            }
        }

        private static GiangVienThayDoiLoaiGiangVienService _giangVienThayDoiLoaiGiangVienService;
        public static GiangVienThayDoiLoaiGiangVienService GiangVienThayDoiLoaiGiangVien
        {
            get
            {
                if (_giangVienThayDoiLoaiGiangVienService == null)
                    _giangVienThayDoiLoaiGiangVienService = new GiangVienThayDoiLoaiGiangVienService();
                return _giangVienThayDoiLoaiGiangVienService;
            }
        }

        private static ChotKhoiLuongGiangDayService _chotKhoiLuongGiangDayService;
        public static ChotKhoiLuongGiangDayService ChotKhoiLuongGiangDay
        {
            get
            {
                if (_chotKhoiLuongGiangDayService == null)
                    _chotKhoiLuongGiangDayService = new ChotKhoiLuongGiangDayService();
                return _chotKhoiLuongGiangDayService;
            }
        }

        private static PhanBienLuanAnService _phanBienLuanAnService;
        public static PhanBienLuanAnService PhanBienLuanAn
        {
            get
            {
                if (_phanBienLuanAnService == null)
                    _phanBienLuanAnService = new PhanBienLuanAnService();
                return _phanBienLuanAnService;
            }
        }

        private static KhoiLuongDoAnTotNghiepChiTietService _khoiLuongDoAnTotNghiepChiTietService;
        public static KhoiLuongDoAnTotNghiepChiTietService KhoiLuongDoAnTotNghiepChiTiet
        {
            get
            {
                if (_khoiLuongDoAnTotNghiepChiTietService == null)
                    _khoiLuongDoAnTotNghiepChiTietService = new KhoiLuongDoAnTotNghiepChiTietService();
                return _khoiLuongDoAnTotNghiepChiTietService;
            }
        }

        private static KhoiLuongGiangDayDoAnTotNghiepService _khoiLuongGiangDayDoAnTotNghiepService;
        public static KhoiLuongGiangDayDoAnTotNghiepService KhoiLuongGiangDayDoAnTotNghiep
        {
            get
            {
                if (_khoiLuongGiangDayDoAnTotNghiepService == null)
                    _khoiLuongGiangDayDoAnTotNghiepService = new KhoiLuongGiangDayDoAnTotNghiepService();
                return _khoiLuongGiangDayDoAnTotNghiepService;
            }
        }

        private static PhanCongDoAnTotNghiepService _phanCongDoAnTotNghiepService;
        public static PhanCongDoAnTotNghiepService PhanCongDoAnTotNghiep
        {
            get
            {
                if (_phanCongDoAnTotNghiepService == null)
                    _phanCongDoAnTotNghiepService = new PhanCongDoAnTotNghiepService();
                return _phanCongDoAnTotNghiepService;
            }
        }

        private static KhoiLuongGiangDayDoAnService _khoiLuongGiangDayDoAnService;
        public static KhoiLuongGiangDayDoAnService KhoiLuongGiangDayDoAn
        {
            get
            {
                if (_khoiLuongGiangDayDoAnService == null)
                    _khoiLuongGiangDayDoAnService = new KhoiLuongGiangDayDoAnService();
                return _khoiLuongGiangDayDoAnService;
            }
        }
        
        private static UteKhoiLuongKhacService _uteKhoiLuongKhacService;
        public static UteKhoiLuongKhacService UteKhoiLuongKhac
        {
            get
            {
                if (_uteKhoiLuongKhacService == null)
                    _uteKhoiLuongKhacService = new UteKhoiLuongKhacService();
                return _uteKhoiLuongKhacService;
            }
        }
        private static ViewLoaiHocPhanService _viewLoaiHocPhanService;
        public static ViewLoaiHocPhanService ViewLoaiHocPhan
        {
            get
            {
                if (_viewLoaiHocPhanService == null)
                    _viewLoaiHocPhanService = new ViewLoaiHocPhanService();
                return _viewLoaiHocPhanService;
            }
        }
        private static UteThanhToanThuLaoService _uteThanhToanThuLaoService;
        public static UteThanhToanThuLaoService UteThanhToanThuLao
        {
            get
            {
                if (_uteThanhToanThuLaoService == null)
                    _uteThanhToanThuLaoService = new UteThanhToanThuLaoService();
                return _uteThanhToanThuLaoService;
            }
        }

        private static UteKhoiLuongQuyDoiService _uteKhoiLuongQuyDoiService;
        public static UteKhoiLuongQuyDoiService UteKhoiLuongQuyDoi
        {
            get
            {
                if (_uteKhoiLuongQuyDoiService == null)
                    _uteKhoiLuongQuyDoiService = new UteKhoiLuongQuyDoiService();
                return _uteKhoiLuongQuyDoiService;
            }
        }

        private static UteKhoiLuongGiangDayService _uteKhoiLuongGiangDayService;
        public static UteKhoiLuongGiangDayService UteKhoiLuongGiangDay
        {
            get
            {
                if (_uteKhoiLuongGiangDayService == null)
                    _uteKhoiLuongGiangDayService = new UteKhoiLuongGiangDayService();
                return _uteKhoiLuongGiangDayService;
            }
        }

        private static ViewUteKhoiLuongQuyDoiService _viewUteKhoiLuongQuyDoiService;
        public static ViewUteKhoiLuongQuyDoiService ViewUteKhoiLuongQuyDoi
        {
            get
            {
                if (_viewUteKhoiLuongQuyDoiService == null)
                    _viewUteKhoiLuongQuyDoiService = new ViewUteKhoiLuongQuyDoiService();
                return _viewUteKhoiLuongQuyDoiService;
            }
        }

        private static PhanNhomMonHocService _phanNhomMonHocService;
        public static PhanNhomMonHocService PhanNhomMonHoc
        {
            get
            {
                if (_phanNhomMonHocService == null)
                    _phanNhomMonHocService = new PhanNhomMonHocService();
                return _phanNhomMonHocService;
            }
        }


        private static ViewPhanNhomMonHocService _viewPhanNhomMonHocService;
        public static ViewPhanNhomMonHocService ViewPhanNhomMonHoc
        {
            get
            {
                if (_viewPhanNhomMonHocService == null)
                    _viewPhanNhomMonHocService = new ViewPhanNhomMonHocService();
                return _viewPhanNhomMonHocService;
            }
        }

        private static DinhMucNghienCuuKhoaHocService _dinhMucNghienCuuKhoaHocService;
        public static DinhMucNghienCuuKhoaHocService DinhMucNghienCuuKhoaHoc
        {
            get
            {
                if (_dinhMucNghienCuuKhoaHocService == null)
                    _dinhMucNghienCuuKhoaHocService = new DinhMucNghienCuuKhoaHocService();
                return _dinhMucNghienCuuKhoaHocService;
            }
        }

        private static DonGiaService _donGiaService;
        public static DonGiaService DonGia
        {
            get
            {
                if (_donGiaService == null)
                    _donGiaService = new DonGiaService();
                return _donGiaService;
            }
        }

        private static HeSoHocKyService _heSoHocKyService;
        public static HeSoHocKyService HeSoHocKy
        {
            get
            {
                if (_heSoHocKyService == null)
                    _heSoHocKyService = new HeSoHocKyService();
                return _heSoHocKyService;
            }
        }

        private static ViewQuyDoiHoatDongNgoaiGiangDayService _viewQuyDoiHoatDongNgoaiGiangDayService;
        public static ViewQuyDoiHoatDongNgoaiGiangDayService ViewQuyDoiHoatDongNgoaiGiangDay
        {
            get
            {
                if (_viewQuyDoiHoatDongNgoaiGiangDayService == null)
                    _viewQuyDoiHoatDongNgoaiGiangDayService = new ViewQuyDoiHoatDongNgoaiGiangDayService();
                return _viewQuyDoiHoatDongNgoaiGiangDayService;
            }
        }

        private static GiangVienGiangDayGdtcQpService _giangVienGiangDayGdtcQpService;
        public static GiangVienGiangDayGdtcQpService GiangVienGiangDayGdtcQp
        {
            get
            {
                if (_giangVienGiangDayGdtcQpService == null)
                    _giangVienGiangDayGdtcQpService = new GiangVienGiangDayGdtcQpService();
                return _giangVienGiangDayGdtcQpService;
            }
        }

        private static QuyDoiHoatDongNgoaiGiangDayService _quyDoiHoatDongNgoaiGiangDayService;
        public static QuyDoiHoatDongNgoaiGiangDayService QuyDoiHoatDongNgoaiGiangDay
        {
            get
            {
                if (_quyDoiHoatDongNgoaiGiangDayService == null)
                    _quyDoiHoatDongNgoaiGiangDayService = new QuyDoiHoatDongNgoaiGiangDayService();
                return _quyDoiHoatDongNgoaiGiangDayService;
            }
        }

        private static GiangVienHoatDongNgoaiGiangDayService _giangVienHoatDongNgoaiGiangDayService;
        public static GiangVienHoatDongNgoaiGiangDayService GiangVienHoatDongNgoaiGiangDay
        {
            get
            {
                if (_giangVienHoatDongNgoaiGiangDayService == null)
                    _giangVienHoatDongNgoaiGiangDayService = new GiangVienHoatDongNgoaiGiangDayService();
                return _giangVienHoatDongNgoaiGiangDayService;
            }
        }

        private static HoatDongNgoaiGiangDayService _hoatDongNgoaiGiangDayService;
        public static HoatDongNgoaiGiangDayService HoatDongNgoaiGiangDay
        {
            get
            {
                if (_hoatDongNgoaiGiangDayService == null)
                    _hoatDongNgoaiGiangDayService = new HoatDongNgoaiGiangDayService();
                return _hoatDongNgoaiGiangDayService;
            }
        }

        private static GiangVienGiamTruDinhMucService _giangVienGiamTruDinhMucService;
        public static GiangVienGiamTruDinhMucService GiangVienGiamTruDinhMuc
        {
            get
            {
                if (_giangVienGiamTruDinhMucService == null)
                    _giangVienGiamTruDinhMucService = new GiangVienGiamTruDinhMucService();
                return _giangVienGiamTruDinhMucService;
            }
        }

        private static GiamTruDinhMucService _giamTruDinhMucService;
        public static GiamTruDinhMucService GiamTruDinhMuc
        {
            get
            {
                if (_giamTruDinhMucService == null)
                    _giamTruDinhMucService = new GiamTruDinhMucService();
                return _giamTruDinhMucService;
            }
        }

        private static DinhMucGioChuanService _dinhMucGioChuanService;
        public static DinhMucGioChuanService DinhMucGioChuan
        {
            get
            {
                if (_dinhMucGioChuanService == null)
                    _dinhMucGioChuanService = new DinhMucGioChuanService();
                return _dinhMucGioChuanService;
            }
        }

        private static HeSoThoiGianGiangDayService _heSoThoiGianGiangDayService;
        public static HeSoThoiGianGiangDayService HeSoThoiGianGiangDay
        {
            get
            {
                if (_heSoThoiGianGiangDayService == null)
                    _heSoThoiGianGiangDayService = new HeSoThoiGianGiangDayService();
                return _heSoThoiGianGiangDayService;
            }
        }

        private static HeSoChucDanhChuyenMonService _heSoChucDanhChuyenMonService;
        public static HeSoChucDanhChuyenMonService HeSoChucDanhChuyenMon
        {
            get
            {
                if (_heSoChucDanhChuyenMonService == null)
                    _heSoChucDanhChuyenMonService = new HeSoChucDanhChuyenMonService();
                return _heSoChucDanhChuyenMonService;
            }
        }

        private static HeSoLuongService _heSoLuongService;
        public static HeSoLuongService HeSoLuong
        {
            get
            {
                if (_heSoLuongService == null)
                    _heSoLuongService = new HeSoLuongService();
                return _heSoLuongService;
            }
        }
        private static ViewKhoiLuongThucDayService _viewKhoiLuongThucDayService;
        public static ViewKhoiLuongThucDayService ViewKhoiLuongThucDay
        {
            get
            {
                if (_viewKhoiLuongThucDayService == null)
                    _viewKhoiLuongThucDayService = new ViewKhoiLuongThucDayService();
                return _viewKhoiLuongThucDayService;
            }
        }

        private static ViewChiTietKhoiLuongThucDayService _viewChiTietKhoiLuongThucDayService;
        public static ViewChiTietKhoiLuongThucDayService ViewChiTietKhoiLuongThucDay
        {
            get
            {
                if (_viewChiTietKhoiLuongThucDayService == null)
                    _viewChiTietKhoiLuongThucDayService = new ViewChiTietKhoiLuongThucDayService();
                return _viewChiTietKhoiLuongThucDayService;
            }
        }

        private static ViewTongHopQuyDoiService _viewTongHopQuyDoiService;
        public static ViewTongHopQuyDoiService ViewTongHopQuyDoi
        {
            get
            {
                if (_viewTongHopQuyDoiService == null)
                    _viewTongHopQuyDoiService = new ViewTongHopQuyDoiService();
                return _viewTongHopQuyDoiService;
            }
        }

        private static ViewThanhToanThuLaoService _viewThanhToanThuLaoService;
        public static ViewThanhToanThuLaoService ViewThanhToanThuLao
        {
            get
            {
                if (_viewThanhToanThuLaoService == null)
                    _viewThanhToanThuLaoService = new ViewThanhToanThuLaoService();
                return _viewThanhToanThuLaoService;
            }
        }

        private static ViewChiTietQuyDoiService _viewChiTietQuyDoiService;
        public static ViewChiTietQuyDoiService ViewChiTietQuyDoi
        {
            get
            {
                if (_viewChiTietQuyDoiService == null)
                    _viewChiTietQuyDoiService = new ViewChiTietQuyDoiService();
                return _viewChiTietQuyDoiService;
            }
        }

        private static ViewChiTietKhoiLuongService _viewChiTietKhoiLuongService;
        public static ViewChiTietKhoiLuongService ViewChiTietKhoiLuong
        {
            get
            {
                if (_viewChiTietKhoiLuongService == null)
                    _viewChiTietKhoiLuongService = new ViewChiTietKhoiLuongService();
                return _viewChiTietKhoiLuongService;
            }
        }

        private static ChiTietKhoiLuongService _chiTietKhoiLuongService;
        public static ChiTietKhoiLuongService ChiTietKhoiLuong
        {
            get
            {
                if (_chiTietKhoiLuongService == null)
                    _chiTietKhoiLuongService = new ChiTietKhoiLuongService();
                return _chiTietKhoiLuongService;
            }
        }

        private static KhoiLuongKhacService _khoiLuongKhacService;
        public static KhoiLuongKhacService KhoiLuongKhac
        {
            get
            {
                if (_khoiLuongKhacService == null)
                    _khoiLuongKhacService = new KhoiLuongKhacService();
                return _khoiLuongKhacService;
            }
        }
        
        private static ViewXuLyQuyDoiService _viewXuLyQuyDoiService;
        public static ViewXuLyQuyDoiService ViewXuLyQuyDoi
        {
            get
            {
                if (_viewXuLyQuyDoiService == null)
                    _viewXuLyQuyDoiService = new ViewXuLyQuyDoiService();
                return _viewXuLyQuyDoiService;
            }
        }
        
        private static ViewKetQuaTinhService _viewKetQuaTinhService;
        public static ViewKetQuaTinhService ViewKetQuaTinh
        {
            get
            {
                if (_viewKetQuaTinhService == null)
                    _viewKetQuaTinhService = new ViewKetQuaTinhService();
                return _viewKetQuaTinhService;
            }
        }

        private static ViewGiangVienLopHocPhanService _viewGiangVienLopHocPhanService;
        public static ViewGiangVienLopHocPhanService ViewGiangVienLopHocPhan
        {
            get
            {
                if (_viewGiangVienLopHocPhanService == null)
                    _viewGiangVienLopHocPhanService = new ViewGiangVienLopHocPhanService();
                return _viewGiangVienLopHocPhanService;
            }
        }

        private static KhoiLuongGiangDayService _khoiLuongGiangDayService;
        public static KhoiLuongGiangDayService KhoiLuongGiangDay
        {
            get
            {
                if (_khoiLuongGiangDayService == null)
                    _khoiLuongGiangDayService = new KhoiLuongGiangDayService();
                return _khoiLuongGiangDayService;
            }
        }

        private static HeSoNgayService _heSoNgayService;
        public static HeSoNgayService HeSoNgay
        {
            get
            {
                if (_heSoNgayService == null)
                    _heSoNgayService = new HeSoNgayService();
                return _heSoNgayService;
            }
        }

        private static ViewTinhKhoiLuongService _viewTinhKhoiLuongService;
        public static ViewTinhKhoiLuongService ViewTinhKhoiLuong
        {
            get
            {
                if (_viewTinhKhoiLuongService == null)
                    _viewTinhKhoiLuongService = new ViewTinhKhoiLuongService();
                return _viewTinhKhoiLuongService;
            }
        }

        private static KhoanQuyDoiService _khoanQuyDoiService;
        public static KhoanQuyDoiService KhoanQuyDoi
        {
            get
            {
                if (_khoanQuyDoiService == null)
                    _khoanQuyDoiService = new KhoanQuyDoiService();
                return _khoanQuyDoiService;
            }
        }

        private static NhomKhoiLuongService _nhomKhoiLuongService;
        public static NhomKhoiLuongService NhomKhoiLuong
        {
            get
            {
                if (_nhomKhoiLuongService == null)
                    _nhomKhoiLuongService = new NhomKhoiLuongService();
                return _nhomKhoiLuongService;
            }
        }

        private static LoaiKhoiLuongService _loaiKhoiLuongService;
        public static LoaiKhoiLuongService LoaiKhoiLuong
        {
            get
            {
                if (_loaiKhoiLuongService == null)
                    _loaiKhoiLuongService = new LoaiKhoiLuongService();
                return _loaiKhoiLuongService;
            }
        }

        private static ViewTongHopChiTienCoVanService _viewTongHopChiTienCoVanService;
        public static ViewTongHopChiTienCoVanService ViewTongHopChiTienCoVan
        {
            get
            {
                if (_viewTongHopChiTienCoVanService == null)
                    _viewTongHopChiTienCoVanService = new ViewTongHopChiTienCoVanService();
                return _viewTongHopChiTienCoVanService;
            }
        }

        private static ViewPhanCongCoVanService _viewPhanCongCoVanService;
        public static ViewPhanCongCoVanService ViewPhanCongCoVan
        {
            get
            {
                if (_viewPhanCongCoVanService == null)
                    _viewPhanCongCoVanService = new ViewPhanCongCoVanService();
                return _viewPhanCongCoVanService;
            }
        }

        private static ViewChiTienCoVanService _viewChiTienCoVanService;
        public static ViewChiTienCoVanService ViewChiTienCoVan
        {
            get
            {
                if (_viewChiTienCoVanService == null)
                    _viewChiTienCoVanService = new ViewChiTienCoVanService();
                return _viewChiTienCoVanService;
            }
        }

        private static CoVanHocTapService _coVanHocTapService;
        public static CoVanHocTapService CoVanHocTap
        {
            get
            {
                if (_coVanHocTapService == null)
                    _coVanHocTapService = new CoVanHocTapService();
                return _coVanHocTapService;
            }
        }

        private static ViewCoVanHocTapService _viewCoVanHocTapService;
        public static ViewCoVanHocTapService ViewCoVanHocTap
        {
            get
            {
                if (_viewCoVanHocTapService == null)
                    _viewCoVanHocTapService = new ViewCoVanHocTapService();
                return _viewCoVanHocTapService;
            }
        }

        private static NamHocService _namHocService;
        public static NamHocService NamHoc
        {
            get
            {
                if (_namHocService == null)
                    _namHocService = new NamHocService();
                return _namHocService;
            }
        }

        private static GiangVienTamUngService _giangVienTamUngService;
        public static GiangVienTamUngService GiangVienTamUng
        {
            get
            {
                if (_giangVienTamUngService == null)
                    _giangVienTamUngService = new GiangVienTamUngService();
                return _giangVienTamUngService;
            }
        } 

        private static ViewQuyetDinhDoiHocHamHocViService _viewQuyetDinhDoiHocHamHocViService;
        public static ViewQuyetDinhDoiHocHamHocViService ViewQuyetDinhDoiHocHamHocVi
        {
            get
            {
                if (_viewQuyetDinhDoiHocHamHocViService == null)
                    _viewQuyetDinhDoiHocHamHocViService = new ViewQuyetDinhDoiHocHamHocViService();
                return _viewQuyetDinhDoiHocHamHocViService;
            }
        }

        private static ViewDanhSachLopPhanCongGiangDayService _ViewDanhSachLopPhanCongGiangDayService;
        public static ViewDanhSachLopPhanCongGiangDayService ViewDanhSachLopPhanCongGiangDay
        {
            get
            {
                if (_ViewDanhSachLopPhanCongGiangDayService == null)
                    _ViewDanhSachLopPhanCongGiangDayService = new ViewDanhSachLopPhanCongGiangDayService();
                return _ViewDanhSachLopPhanCongGiangDayService;
            }
        }
        private static ViewThongTinGiangVienService _viewThongTinAccountGiangVienService;
        public static ViewThongTinGiangVienService ThongTinAccountGiangVien
        {
            get
            {
                if (_viewThongTinAccountGiangVienService == null)
                    _viewThongTinAccountGiangVienService = new ViewThongTinGiangVienService();
                return _viewThongTinAccountGiangVienService;
            }
        }
        private static ViewThongTinChiTietGiangVienService _viewThongTinChiTietGiangVienService;
        public static ViewThongTinChiTietGiangVienService ViewThongTinChiTietGiangVien
        {
            get
            {
                if (_viewThongTinChiTietGiangVienService == null)
                    _viewThongTinChiTietGiangVienService = new ViewThongTinChiTietGiangVienService();
                return _viewThongTinChiTietGiangVienService;
            }
        }

        private static ViewKhoaHocBacHeService _viewKhoaHocBacHeService;
        public static ViewKhoaHocBacHeService ViewKhoaHocBacHe
        {
            get
            {
                if (_viewKhoaHocBacHeService == null)
                    _viewKhoaHocBacHeService = new ViewKhoaHocBacHeService();
                return _viewKhoaHocBacHeService;
            }
        }
        private static ViewBacDaoTaoService _viewViewBacDaoTaoService;
        public static ViewBacDaoTaoService ViewBacDaoTao
        {
            get
            {
                if (_viewViewBacDaoTaoService == null)
                    _viewViewBacDaoTaoService = new ViewBacDaoTaoService();
                return _viewViewBacDaoTaoService;
            }
        }
        private static ViewHeDaoTaoService _viewViewHeDaoTaoService;
        public static ViewHeDaoTaoService ViewHeDaoTao
        {
            get
            {
                if (_viewViewHeDaoTaoService == null)
                    _viewViewHeDaoTaoService = new ViewHeDaoTaoService();
                return _viewViewHeDaoTaoService;
            }
        }
        private static ViewSinhVienLopHocPhanService _viewSinhVienLopHocPhanService;
        public static ViewSinhVienLopHocPhanService ViewSinhVienLopHocPhan
        {
            get
            {
                if (_viewSinhVienLopHocPhanService == null)
                    _viewSinhVienLopHocPhanService = new ViewSinhVienLopHocPhanService();
                return _viewSinhVienLopHocPhanService;
            }
        }



        private static CauHinhService _cauHinhService;
        public static CauHinhService CauHinh
        {
            get
            {
                if (_cauHinhService == null)
                    _cauHinhService = new CauHinhService();
                return _cauHinhService;
            }
        }


        private static ViewGiangVienKhoaService _viewGiangVienKhoaService;
        public static ViewGiangVienKhoaService ViewGiangVienKhoa
        {
            get
            {
                if (_viewGiangVienKhoaService == null)
                    _viewGiangVienKhoaService = new ViewGiangVienKhoaService();
                return _viewGiangVienKhoaService;
            }
        }

        private static ViewSinhVienLopService _viewSinhVienLopService;
        public static ViewSinhVienLopService ViewSinhVienLop
        {
            get
            {
                if (_viewSinhVienLopService == null)
                    _viewSinhVienLopService = new ViewSinhVienLopService();
                return _viewSinhVienLopService;
            }
        }

        private static ViewKhoaHocService _viewKhoaHocService;
        public static ViewKhoaHocService ViewKhoaHoc
        {
            get
            {
                if (_viewKhoaHocService == null)
                    _viewKhoaHocService = new ViewKhoaHocService();
                return _viewKhoaHocService;
            }
        }


        private static ViewKhoaService _viewKhoaService;
        public static ViewKhoaService ViewKhoa
        {
            get
            {
                if (_viewKhoaService == null)
                    _viewKhoaService = new ViewKhoaService();
                return _viewKhoaService;
            }
        }

        private static ViewKhoaBoMonService _viewKhoaBoMonService;
        public static ViewKhoaBoMonService ViewKhoaBoMon
        {
            get
            {
                if (_viewKhoaBoMonService == null)
                    _viewKhoaBoMonService = new ViewKhoaBoMonService();
                return _viewKhoaBoMonService;
            }
        }

        //private static CoVanHocTapService _coVanHocTapService;
        //public static CoVanHocTapService CoVanHocTap
        //{
        //    get
        //    {
        //        if (_coVanHocTapService == null)
        //            _coVanHocTapService = new CoVanHocTapService();
        //        return _coVanHocTapService;
        //    }
        //}

        private static ViewLopService _viewLopService;
        public static ViewLopService ViewLop
        {
            get
            {
                if (_viewLopService == null)
                    _viewLopService = new ViewLopService();
                return _viewLopService;
            }
        }

        //private static ViewPhanCongCoVanService _viewPhanCongCoVanService;
        //public static ViewPhanCongCoVanService ViewPhanCongCoVan
        //{
        //    get
        //    {
        //        if (_viewPhanCongCoVanService == null)
        //            _viewPhanCongCoVanService = new ViewPhanCongCoVanService();
        //        return _viewPhanCongCoVanService;
        //    }
        //}

        private static ViewPhanCongChuyenMonService _viewPhanCongChuyenMonService;
        public static ViewPhanCongChuyenMonService ViewPhanCongChuyenMon
        {
            get
            {
                if (_viewPhanCongChuyenMonService == null)
                    _viewPhanCongChuyenMonService = new ViewPhanCongChuyenMonService();
                return _viewPhanCongChuyenMonService;
            }
        }

        private static GiangVienChuyenMonService _giangVienChuyenMonService;
        public static GiangVienChuyenMonService GiangVienChuyenMon
        {
            get
            {
                if (_giangVienChuyenMonService == null)
                    _giangVienChuyenMonService = new GiangVienChuyenMonService();
                return _giangVienChuyenMonService;
            }
        }

        private static ViewMonHocKhoaService _viewMonHocKhoaService;
        public static ViewMonHocKhoaService ViewMonHocKhoa
        {
            get
            {
                if (_viewMonHocKhoaService == null)
                    _viewMonHocKhoaService = new ViewMonHocKhoaService();
                return _viewMonHocKhoaService;
            }
        }

        private static ViewCoSoService _viewCoSoService;
        public static ViewCoSoService ViewCoSo
        {
            get
            {
                if (_viewCoSoService == null)
                    _viewCoSoService = new ViewCoSoService();
                return _viewCoSoService;
            }
        }

        private static ViewMonHocService _viewMonHocService;
        public static ViewMonHocService ViewMonHoc
        {
            get
            {
                if (_viewMonHocService == null)
                    _viewMonHocService = new ViewMonHocService();
                return _viewMonHocService;
            }
        }

        private static ViewBacDaoTaoLoaiHinhService _viewBacDaoTaoLoaiHinhService;
        public static ViewBacDaoTaoLoaiHinhService ViewBacDaoTaoLoaiHinh
        {
            get
            {
                if (_viewBacDaoTaoLoaiHinhService == null)
                    _viewBacDaoTaoLoaiHinhService = new ViewBacDaoTaoLoaiHinhService();
                return _viewBacDaoTaoLoaiHinhService;
            }
        }

        private static HeSoCoSoService _heSoCoSoService;
        public static HeSoCoSoService HeSoCoSo
        {
            get
            {
                if (_heSoCoSoService == null)
                    _heSoCoSoService = new HeSoCoSoService();
                return _heSoCoSoService;
            }
        }

        private static KetQuaTinhService _ketQuaTinhService;
        public static KetQuaTinhService KetQuaTinh
        {
            get
            {
                if (_ketQuaTinhService == null)
                    _ketQuaTinhService = new KetQuaTinhService();
                return _ketQuaTinhService;
            }
        }

        private static DonViTinhService _donViTinhService;
        public static DonViTinhService DonViTinh
        {
            get
            {
                if (_donViTinhService == null)
                    _donViTinhService = new DonViTinhService();
                return _donViTinhService;
            }
        }

        //private static HeSoHocKyService _heSoHocKyService;
        //public static HeSoHocKyService HeSoHocKy
        //{
        //    get
        //    {
        //        if (_heSoHocKyService == null)
        //            _heSoHocKyService = new HeSoHocKyService();
        //        return _heSoHocKyService;
        //    }
        //}

        private static QuyDoiGioChuanService _quyDoiGioChuanService;
        public static QuyDoiGioChuanService QuyDoiGioChuan
        {
            get
            {
                if (_quyDoiGioChuanService == null)
                    _quyDoiGioChuanService = new QuyDoiGioChuanService();
                return _quyDoiGioChuanService;
            }
        }


        private static ViewLopHocPhanService _viewLopHocPhanService;
        public static ViewLopHocPhanService ViewLopHocPhan
        {
            get
            {
                if (_viewLopHocPhanService == null)
                    _viewLopHocPhanService = new ViewLopHocPhanService();
                return _viewLopHocPhanService;
            }
        }

        private static GiangVienChucVuService _giangVienChucVuService;
        public static GiangVienChucVuService GiangVienChucVu
        {
            get
            {
                if (_giangVienChucVuService == null)
                    _giangVienChucVuService = new GiangVienChucVuService();
                return _giangVienChucVuService;
            }
        }

        private static GiangVienHoSoService _giangVienHoSoService;
        public static GiangVienHoSoService GiangVienHoSo
        {
            get
            {
                if (_giangVienHoSoService == null)
                    _giangVienHoSoService = new GiangVienHoSoService();
                return _giangVienHoSoService;
            }
        }

        private static GiangVienService _giangVienService;
        public static GiangVienService GiangVien
        {
            get
            {
                if (_giangVienService == null)
                    _giangVienService = new GiangVienService();
                return _giangVienService;
            }
        }

        private static ViewTonGiaoService _viewTonGiaoService;
        public static ViewTonGiaoService ViewTonGiao
        {
            get
            {
                if (_viewTonGiaoService == null)
                    _viewTonGiaoService = new ViewTonGiaoService();
                return _viewTonGiaoService;
            }
        }

        private static ViewDanTocService _viewDanTocService;
        public static ViewDanTocService ViewDanToc
        {
            get
            {
                if (_viewDanTocService == null)
                    _viewDanTocService = new ViewDanTocService();
                return _viewDanTocService;
            }
        }

        private static ViewHocKyService _viewHocKyService;
        public static ViewHocKyService ViewHocKy
        {
            get
            {
                if (_viewHocKyService == null)
                    _viewHocKyService = new ViewHocKyService();
                return _viewHocKyService;
            }
        }

        private static ViewNamHocService _viewNamHocService;
        public static ViewNamHocService ViewNamHoc
        {
            get
            {
                if (_viewNamHocService == null)
                    _viewNamHocService = new ViewNamHocService();
                return _viewNamHocService;
            }
        }

        private static ViewDonViService _viewDonViService;
        public static ViewDonViService ViewDonVi
        {
            get
            {
                if (_viewDonViService == null)
                    _viewDonViService = new ViewDonViService();
                return _viewDonViService;
            }
        }

        private static ChucVuService _chucVuService;
        public static ChucVuService ChucVu
        {
            get
            {
                if (_chucVuService == null)
                    _chucVuService = new ChucVuService();
                return _chucVuService;
            }
        }

        private static HoSoService _hoSoService;
        public static HoSoService HoSo
        {
            get
            {
                if (_hoSoService == null)
                    _hoSoService = new HoSoService();
                return _hoSoService;
            }
        }

        //private static HeSoNgayService _heSoNgayService;
        //public static HeSoNgayService HeSoNgay
        //{
        //    get
        //    {
        //        if (_heSoNgayService == null)
        //            _heSoNgayService = new HeSoNgayService();
        //        return _heSoNgayService;
        //    }
        //}

        private static TinhTrangService _tinhTrangService;
        public static TinhTrangService TinhTrang
        {
            get
            {
                if (_tinhTrangService == null)
                    _tinhTrangService = new TinhTrangService();
                return _tinhTrangService;
            }
        }

        private static LoaiGiangVienService _loaiGiangVienService;
        public static LoaiGiangVienService LoaiGiangVien
        {
            get
            {
                if (_loaiGiangVienService == null)
                    _loaiGiangVienService = new LoaiGiangVienService();
                return _loaiGiangVienService;
            }
        }

        private static HocViService _hocViService;
        public static HocViService HocVi
        {
            get
            {
                if (_hocViService == null)
                    _hocViService = new HocViService();
                return _hocViService;
            }
        }

        private static HocHamService _hocHamService;
        public static HocHamService HocHam
        {
            get
            {
                if (_hocHamService == null)
                    _hocHamService = new HocHamService();
                return _hocHamService;
            }
        }

        private static ReportTemplateService _reportTemplateService;
        public static ReportTemplateService ReportTemplate
        {
            get
            {
                if (_reportTemplateService == null)
                    _reportTemplateService = new ReportTemplateService();
                return _reportTemplateService;
            }
        }

        private static HeThongService _heThongService;
        public static HeThongService HeThong
        {
            get
            {
                if (_heThongService == null)
                    _heThongService = new HeThongService();
                return _heThongService;
            }
        }

        private static ChucNangService _chucNangService;
        public static ChucNangService ChucNang
        {
            get
            {
                if (_chucNangService == null)
                    _chucNangService = new ChucNangService();
                return _chucNangService;
            }
        }

        private static NhomChucNangService _nhomChucNangService;
        public static NhomChucNangService NhomChucNang
        {
            get
            {
                if (_nhomChucNangService == null)
                    _nhomChucNangService = new NhomChucNangService();
                return _nhomChucNangService;
            }
        }

        private static NhomQuyenService _nhomQuyenService;
        public static NhomQuyenService NhomQuyen
        {
            get
            {
                if (_nhomQuyenService == null)
                    _nhomQuyenService = new NhomQuyenService();
                return _nhomQuyenService;
            }
        }

        private static TaiKhoanService _taiKhoanService;
        public static TaiKhoanService TaiKhoan
        {
            get
            {
                if (_taiKhoanService == null)
                    _taiKhoanService = new TaiKhoanService();
                return _taiKhoanService;
            }
        }

        private static HeSoChucDanhTietNghiaVuService _heSoChucDanhTietNghiaVuService;
        public static HeSoChucDanhTietNghiaVuService HeSoChucDanhTietNghiaVu
        {
            get
            {
                if (_heSoChucDanhTietNghiaVuService == null)
                    _heSoChucDanhTietNghiaVuService = new HeSoChucDanhTietNghiaVuService();
                return _heSoChucDanhTietNghiaVuService;
            }
        }

        private static HeSoBacDaoTaoService _heSoBacDaoTaoService;
        public static HeSoBacDaoTaoService HeSoBacDaoTao
        {
            get
            {
                if (_heSoBacDaoTaoService == null)
                    _heSoBacDaoTaoService = new HeSoBacDaoTaoService();
                return _heSoBacDaoTaoService;
            }
        }

        private static NhomMonHocService _nhomMonHocService;
        public static NhomMonHocService NhomMonHoc
        {
            get
            {
                if (_nhomMonHocService == null)
                    _nhomMonHocService = new NhomMonHocService();
                return _nhomMonHocService;
            }
        }

        private static HeSoLopDongService _heSoLopDongService;
        public static HeSoLopDongService HeSoLopDong
        {
            get
            {
                if (_heSoLopDongService == null)
                    _heSoLopDongService = new HeSoLopDongService();
                return _heSoLopDongService;
            }
        }

        private static HeSoCongViecService _heSoCongViecService;
        public static HeSoCongViecService HeSoCongViec
        {
            get
            {
                if (_heSoCongViecService == null)
                    _heSoCongViecService = new HeSoCongViecService();
                return _heSoCongViecService;
            }
        }

        private static HeSoNgonNguService _heSoNgonNguService;
        public static HeSoNgonNguService HeSoNgonNgu
        {
            get
            {
                if (_heSoNgonNguService == null)
                    _heSoNgonNguService = new HeSoNgonNguService();
                return _heSoNgonNguService;
            }
        }

        private static LopHocPhanBacDaoTaoService _lopHocPhanBacDaoTaoService;
        public static LopHocPhanBacDaoTaoService LopHocPhanBacDaoTao
        {
            get
            {
                if (_lopHocPhanBacDaoTaoService == null)
                    _lopHocPhanBacDaoTaoService = new LopHocPhanBacDaoTaoService();
                return _lopHocPhanBacDaoTaoService;
            }
        }

        private static MonKhongTinhService _monKhongTinhService;
        public static MonKhongTinhService MonKhongTinh
        {
            get
            {
                if (_monKhongTinhService == null)
                    _monKhongTinhService = new MonKhongTinhService();
                return _monKhongTinhService;
            }
        }

        private static GiangVienLopHocPhanService _giangVienLopHocPhanService;
        public static GiangVienLopHocPhanService GiangVienLopHocPhan
        {
            get
            {
                if (_giangVienLopHocPhanService == null)
                    _giangVienLopHocPhanService = new GiangVienLopHocPhanService();
                return _giangVienLopHocPhanService;
            }
        }

        private static ThucGiangMonThucTeTuHocService _thucGiangMonThucTeTuHocService;
        public static ThucGiangMonThucTeTuHocService ThucGiangMonThucTeTuHoc
        {
            get
            {
                if (_thucGiangMonThucTeTuHocService == null)
                    _thucGiangMonThucTeTuHocService = new ThucGiangMonThucTeTuHocService();
                return _thucGiangMonThucTeTuHocService;
            }
        }

        private static CauHinhChungService _cauHinhChungService;
        public static CauHinhChungService CauHinhChung
        {
            get
            {
                if (_cauHinhChungService == null)
                    _cauHinhChungService = new CauHinhChungService();
                return _cauHinhChungService;
            }
        }

        private static ViewThongTinLopHocPhanHeSoCongViecService _viewThongTinLopHocPhanHeSoCongViecService;
        public static ViewThongTinLopHocPhanHeSoCongViecService ViewThongTinLopHocPhanHeSoCongViec
        {
            get
            {
                if (_viewThongTinLopHocPhanHeSoCongViecService == null)
                    _viewThongTinLopHocPhanHeSoCongViecService = new ViewThongTinLopHocPhanHeSoCongViecService();
                return _viewThongTinLopHocPhanHeSoCongViecService;
            }
        }

        private static ViewLopHocPhanGiangBangTiengNuocNgoaiService _viewLopHocPhanGiangBangTiengNuocNgoaiService;
        public static ViewLopHocPhanGiangBangTiengNuocNgoaiService ViewLopHocPhanGiangBangTiengNuocNgoai
        {
            get
            {
                if (_viewLopHocPhanGiangBangTiengNuocNgoaiService == null)
                    _viewLopHocPhanGiangBangTiengNuocNgoaiService = new ViewLopHocPhanGiangBangTiengNuocNgoaiService();
                return _viewLopHocPhanGiangBangTiengNuocNgoaiService;
            }
        }

        private static LopHocPhanGiangBangTiengNuocNgoaiService _lopHocPhanGiangBangTiengNuocNgoaiService;
        public static LopHocPhanGiangBangTiengNuocNgoaiService LopHocPhanGiangBangTiengNuocNgoai
        {
            get
            {
                if (_lopHocPhanGiangBangTiengNuocNgoaiService == null)
                    _lopHocPhanGiangBangTiengNuocNgoaiService = new LopHocPhanGiangBangTiengNuocNgoaiService();
                return _lopHocPhanGiangBangTiengNuocNgoaiService;
            }
        }


        private static ViewLopHocPhanClcAufCjlService _viewLopHocPhanClcAufCjlService;
        public static ViewLopHocPhanClcAufCjlService ViewLopHocPhanClcAufCjl
        {
            get
            {
                if (_viewLopHocPhanClcAufCjlService == null)
                    _viewLopHocPhanClcAufCjlService = new ViewLopHocPhanClcAufCjlService();
                return _viewLopHocPhanClcAufCjlService;
            }
        }

        private static LopHocPhanClcAufCjlService _lopHocPhanClcAufCjlService;
        public static LopHocPhanClcAufCjlService LopHocPhanClcAufCjl
        {
            get
            {
                if (_lopHocPhanClcAufCjlService == null)
                    _lopHocPhanClcAufCjlService = new LopHocPhanClcAufCjlService();
                return _lopHocPhanClcAufCjlService;
            }
        }

        private static KhoiLuongGiangDayChiTietService _khoiLuongGiangDayChiTietService;
        public static KhoiLuongGiangDayChiTietService KhoiLuongGiangDayChiTiet
        {
            get
            {
                if (_khoiLuongGiangDayChiTietService == null)
                    _khoiLuongGiangDayChiTietService = new KhoiLuongGiangDayChiTietService();
                return _khoiLuongGiangDayChiTietService;
            }
        }

        private static ViewKhoiLuongGiangDayService _viewKhoiLuongGiangDayService;
        public static ViewKhoiLuongGiangDayService ViewKhoiLuongGiangDay
        {
            get
            {
                if (_viewKhoiLuongGiangDayService == null)
                    _viewKhoiLuongGiangDayService = new ViewKhoiLuongGiangDayService();
                return _viewKhoiLuongGiangDayService;
            }
        }

        private static ViewGiangVienService _viewGiangVienService;
        public static ViewGiangVienService ViewGiangVien
        {
            get
            {
                if (_viewGiangVienService == null)
                    _viewGiangVienService = new ViewGiangVienService();
                return _viewGiangVienService;
            }
        }

        private static KhoiLuongQuyDoiService _khoiLuongQuyDoiService;
        public static KhoiLuongQuyDoiService KhoiLuongQuyDoi
        {
            get
            {
                if (_khoiLuongQuyDoiService == null)
                    _khoiLuongQuyDoiService = new KhoiLuongQuyDoiService();
                return _khoiLuongQuyDoiService;
            }
        }

        private static ViewChiTietPhanCongGiangDayService _viewChiTietPhanCongGiangDayService;
        public static ViewChiTietPhanCongGiangDayService ViewChiTietPhanCongGiangDay
        {
            get
            {
                if (_viewChiTietPhanCongGiangDayService == null)
                    _viewChiTietPhanCongGiangDayService = new ViewChiTietPhanCongGiangDayService();
                return _viewChiTietPhanCongGiangDayService;
            }
        }


        private static ViewGiangVienNghienCuuKhoaHocService _viewGiangVienNghienCuuKhoaHocService;
        public static ViewGiangVienNghienCuuKhoaHocService ViewGiangVienNghienCuuKhoaHoc
        {
            get
            {
                if (_viewGiangVienNghienCuuKhoaHocService == null)
                    _viewGiangVienNghienCuuKhoaHocService = new ViewGiangVienNghienCuuKhoaHocService();
                return _viewGiangVienNghienCuuKhoaHocService;
            }
        }

        private static NghienCuuKhoaHocService _nghienCuuKhoaHocService;
        public static NghienCuuKhoaHocService NghienCuuKhoaHoc
        {
            get
            {
                if (_nghienCuuKhoaHocService == null)
                    _nghienCuuKhoaHocService = new NghienCuuKhoaHocService();
                return _nghienCuuKhoaHocService;
            }
        }

        private static GiangVienThayDoiHocHamService _giangVienThayDoiHocHamService;
        public static GiangVienThayDoiHocHamService GiangVienThayDoiHocHam
        {
            get
            {
                if (_giangVienThayDoiHocHamService == null)
                    _giangVienThayDoiHocHamService = new GiangVienThayDoiHocHamService();
                return _giangVienThayDoiHocHamService;
            }
        }

        private static GiangVienThayDoiHocViService _giangVienThayDoiHocViService;
        public static GiangVienThayDoiHocViService GiangVienThayDoiHocVi
        {
            get
            {
                if (_giangVienThayDoiHocViService == null)
                    _giangVienThayDoiHocViService = new GiangVienThayDoiHocViService();
                return _giangVienThayDoiHocViService;
            }
        }

    }
}