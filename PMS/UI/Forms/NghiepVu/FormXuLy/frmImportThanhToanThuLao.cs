using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.Utils;
using PMS.Services;
using PMS.BLL;
using System.Text.RegularExpressions;

namespace PMS.UI.Forms.NghiepVu.FormXuLy
{
    public partial class frmImportThanhToanThuLao : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        DataTable dt = new DataTable();
        string MaTruong;
        string LoaiThuLao;
        string NamHoc, HocKy, MaLoaiHinhDaoTao;
        int DotThanhToan;
        #endregion

        #region Event Form
        public frmImportThanhToanThuLao()
        {
            InitializeComponent();
        }
        public frmImportThanhToanThuLao(string maTruong)
        {
            MaTruong = maTruong;
            InitializeComponent();
        }
        public frmImportThanhToanThuLao(string _maTruong, string _namHoc, string _hocKy, string _maLoaiHinhDaoTao, int _dotThanhToan)
        {
            MaTruong = _maTruong;
            NamHoc = _namHoc;
            HocKy = _hocKy;
            MaLoaiHinhDaoTao = _maLoaiHinhDaoTao;
            DotThanhToan = _dotThanhToan;
            InitializeComponent();
        }

        public frmImportThanhToanThuLao(string maTruong, string loaiThuLao)
        {
            MaTruong = maTruong;
            LoaiThuLao = loaiThuLao;
            InitializeComponent();
        }

        private void frmImportThanhToanThuLao_Load(object sender, EventArgs e)
        {
            switch (MaTruong)
            {
                case "UEL":
                    InitGridUEL();
                    break;
                case "DLU":
                    InitGridDLU();
                    break;
                default:
                    InitRemaining();
                    break;
            }
        }
        #endregion

        #region Init Grid
        void InitGridUEL()
        {
            switch (LoaiThuLao)
            {
                case "ThuLaoGiangDay":
                    GridImportThuLaoGiangDayUEL();
                    break;
                case "ThuLaoHuongDanCuoiKhoa":
                    GridImportThuLaoHuongDanCuoiKhoaUEL();
                    break;
                case "ThuLaoCoiThiChamBai":
                    GridImportThuLaoCoiThiChamBaiUEL();
                    break;
            }
        }

        void InitGridDLU()
        {
            #region Init GridView
            switch (LoaiThuLao)
            {
                case "ThuLaoCoiThiChamBai":
                    AppGridView.InitGridView(gridViewImport, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
                    AppGridView.ShowField(gridViewImport, new string[] { "MaGiangVienQuanLy", "HoTen", "MaMonHoc", "TenMonHoc", "LoaiHinhDaoTao", "BacDaoTao", "GioCoiThi", "GioChamThi", "GioRaDe", "GioToChucThi", "GioNhapDiem", "TongCong" }
                            , new string[] { "Mã giảng viên", "Họ tên", "Mã môn học", "Tên môn học", "Loại hình đào tạo", "Bậc đào tạo", "Coi thi", "Chấm thi", "Ra đề", "Tổ chức thi", "Nhập điểm", "Tổng giờ" }
                            , new int[] { 100, 200, 80, 250, 100, 80, 70, 70, 70, 70, 70, 100 });
                    AppGridView.AlignHeader(gridViewImport, new string[] { "MaGiangVienQuanLy", "HoTen", "MaMonHoc", "TenMonHoc", "LoaiHinhDaoTao", "BacDaoTao", "GioCoiThi", "GioChamThi", "GioRaDe", "GioToChucThi", "GioNhapDiem", "TongCong" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.FormatDataField(gridViewImport, new string[] { "GioCoiThi", "GioChamThi", "GioRaDe", "GioToChucThi", "GioNhapDiem", "TongCong" }, DevExpress.Utils.FormatType.Custom, "{0:n2}");
                    AppGridView.FixedField(gridViewImport, new string[] { "MaGiangVienQuanLy", "HoTen" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
                    AppGridView.SummaryField(gridViewImport, "MaGiangVienQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
                    AppGridView.SummaryField(gridViewImport, "TongCong", "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
                    AppGridView.ReadOnlyColumn(gridViewImport);
                    #region datatable
                    dt.Columns.Add(new DataColumn("MaGiangVienQuanLy"));
                    dt.Columns["MaGiangVienQuanLy"].Caption = "Mã giảng viên";
                    dt.Columns.Add(new DataColumn("HoTen"));
                    dt.Columns["HoTen"].Caption = "Họ tên";
                    dt.Columns.Add(new DataColumn("MaMonHoc"));
                    dt.Columns["MaMonHoc"].Caption = "Mã môn học";
                    dt.Columns.Add(new DataColumn("TenMonHoc"));
                    dt.Columns["TenMonHoc"].Caption = "Tên môn học";
                    dt.Columns.Add(new DataColumn("LoaiHinhDaoTao"));
                    dt.Columns["LoaiHinhDaoTao"].Caption = "Loại hình đào tạo";
                    dt.Columns.Add(new DataColumn("BacDaoTao"));
                    dt.Columns["BacDaoTao"].Caption = "Bậc đào tạo";
                    dt.Columns.Add(new DataColumn("GioCoiThi"));
                    dt.Columns["GioCoiThi"].Caption = "Coi thi";
                    dt.Columns.Add(new DataColumn("GioChamThi"));
                    dt.Columns["GioChamThi"].Caption = "Chấm thi";
                    dt.Columns.Add(new DataColumn("GioRaDe"));
                    dt.Columns["GioRaDe"].Caption = "Ra đề";
                    dt.Columns.Add(new DataColumn("GioToChucThi"));
                    dt.Columns["GioToChucThi"].Caption = "Tổ chức thi";
                    dt.Columns.Add(new DataColumn("GioNhapDiem"));
                    dt.Columns["GioNhapDiem"].Caption = "Nhập điểm";
                    dt.Columns.Add(new DataColumn("TongCong"));
                    dt.Columns["TongCong"].Caption = "Tổng giờ";
                    #endregion
                    break;
                default:
                    AppGridView.InitGridView(gridViewImport, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true, "Nhấn vào đây để thêm dòng mới");
                    AppGridView.ShowEditor(gridViewImport, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
                    AppGridView.ShowField(gridViewImport, new string[] { "MaGiangVienQuanLy", "Ho", "Ten", "MaMonHoc", "TenMonHoc", "MaBacDaoTao", "MaLop", "SiSo", "SoTiet", "HeSoChucDanh", "HeSoLopDong", "HeSoBacDaoTao", "HeSoThucHanh", "TietQuyDoi", "NoiDungChi" }
                            , new string[] { "Mã giảng viên", "Họ", "Tên", "Mã môn học", "Tên môn học", "Bậc đào tạo", "Mã lớp", "Sĩ số", "Số tiết", "HS chức danh", "HS lớp đông", "HS bậc đào tạo", "HS thực hành", "Tiết quy đổi", "Ghi chú" }
                            , new int[] { 90, 110, 60, 90, 180, 80, 70, 60, 60, 80, 80, 80, 80, 80, 100 });
                    AppGridView.AlignHeader(gridViewImport, new string[] { "MaGiangVienQuanLy", "Ho", "Ten", "MaMonHoc", "TenMonHoc", "MaBacDaoTao", "MaLop", "SiSo", "SoTiet", "HeSoChucDanh", "HeSoLopDong", "HeSoBacDaoTao", "HeSoThucHanh", "TietQuyDoi", "NoiDungChi" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.FixedField(gridViewImport, new string[] { "MaGiangVienQuanLy", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
                    AppGridView.SummaryField(gridViewImport, "MaGiangVienQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
                    AppGridView.SummaryField(gridViewImport, "TietQuyDoi", "{0}", DevExpress.Data.SummaryItemType.Sum);
                    AppGridView.ReadOnlyColumn(gridViewImport);
                    #region datatable
                    dt.Columns.Add(new DataColumn("MaGiangVienQuanLy"));
                    dt.Columns["MaGiangVienQuanLy"].Caption = "Mã giảng viên";
                    dt.Columns.Add(new DataColumn("Ho"));
                    dt.Columns["Ho"].Caption = "Họ";
                    dt.Columns.Add(new DataColumn("Ten"));
                    dt.Columns["Ten"].Caption = "Tên";
                    dt.Columns.Add(new DataColumn("MaMonHoc"));
                    dt.Columns["MaMonHoc"].Caption = "Mã môn học";
                    dt.Columns.Add(new DataColumn("TenMonHoc"));
                    dt.Columns["TenMonHoc"].Caption = "Tên môn học";
                    dt.Columns.Add(new DataColumn("MaBacDaoTao"));
                    dt.Columns["MaBacDaoTao"].Caption = "Bậc đào tạo";
                    dt.Columns.Add(new DataColumn("MaLop"));
                    dt.Columns["MaLop"].Caption = "Mã lớp";
                    dt.Columns.Add(new DataColumn("SiSo"));
                    dt.Columns["SiSo"].Caption = "Sĩ số";
                    dt.Columns.Add(new DataColumn("SoTiet"));
                    dt.Columns["SoTiet"].Caption = "Số tiết";
                    dt.Columns.Add(new DataColumn("HeSoChucDanh"));
                    dt.Columns["HeSoChucDanh"].Caption = "HS chức danh";
                    dt.Columns.Add(new DataColumn("HeSoLopDong"));
                    dt.Columns["HeSoLopDong"].Caption = "HS lớp đông";
                    dt.Columns.Add(new DataColumn("HeSoBacDaoTao"));
                    dt.Columns["HeSoBacDaoTao"].Caption = "HS bậc đào tạo";
                    dt.Columns.Add(new DataColumn("HeSoThucHanh"));
                    dt.Columns["HeSoThucHanh"].Caption = "HS thực hành";
                    dt.Columns.Add(new DataColumn("TietQuyDoi"));
                    dt.Columns["TietQuyDoi"].Caption = "Tiết quy đổi";
                    dt.Columns.Add(new DataColumn("NoiDungChi"));
                    dt.Columns["NoiDungChi"].Caption = "Ghi chú";
                    #endregion
                    break;
            }
            #endregion

            bindingSourceImport.DataSource = dt;
        }

        void InitRemaining()
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewImport, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewImport, new string[] { "MaGiangVien", "HoTen", "MaLop", "NgayDay", "TenMonHoc", "HeSoLopDong", "SoTiet", "DonGia", "ThanhTien", "CongTacPhi", "TienGiangNgoaiGio", "TongThanhTien" },
                new string[] { "Mã giảng viên", "Họ và tên", "Lớp", "Ngày", "Nội dung lên lớp", "Hệ số lớp đông", "Số tiết", "Tiền giảng 1 tiết", "Thành tiền", "Công tác phí", "Tiền giảng ngoài giờ", "Tổng số tiền chi trả qua ATM" }
                , new int[] { 90, 140, 80, 80, 170, 110, 80, 110, 110, 100, 120, 150 });
            AppGridView.AlignHeader(gridViewImport, new string[] { "MaGiangVien", "HoTen", "MaLop", "NgayDay", "TenMonHoc", "HeSoLopDong", "SoTiet", "DonGia", "ThanhTien", "CongTacPhi", "TienGiangNgoaiGio", "TongThanhTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewImport);
            #endregion

            #region datatable
            dt.Columns.Add(new DataColumn("MaGiangVien"));
            dt.Columns["MaGiangVien"].Caption = "Mã giảng viên";
            dt.Columns.Add(new DataColumn("HoTen"));
            dt.Columns["HoTen"].Caption = "Họ và tên";
            dt.Columns.Add(new DataColumn("MaLop"));
            dt.Columns["MaLop"].Caption = "Lớp";
            dt.Columns.Add(new DataColumn("NgayDay"));
            dt.Columns["NgayDay"].Caption = "Ngày";
            dt.Columns.Add(new DataColumn("TenMonHoc"));
            dt.Columns["TenMonHoc"].Caption = "Nội dung lên lớp";
            dt.Columns.Add(new DataColumn("HeSoLopDong"));
            dt.Columns["HeSoLopDong"].Caption = "Hệ số lớp đông";
            dt.Columns.Add(new DataColumn("SoTiet"));
            dt.Columns["SoTiet"].Caption = "Số tiết";
            dt.Columns.Add(new DataColumn("DonGia"));
            dt.Columns["DonGia"].Caption = "Tiền giảng 1 tiết";
            dt.Columns.Add(new DataColumn("ThanhTien"));
            dt.Columns["ThanhTien"].Caption = "Thành tiền";
            dt.Columns.Add(new DataColumn("CongTacPhi"));
            dt.Columns["CongTacPhi"].Caption = "Công tác phí";
            dt.Columns.Add(new DataColumn("TienGiangNgoaiGio"));
            dt.Columns["TienGiangNgoaiGio"].Caption = "Tiền giảng ngoài giờ";
            dt.Columns.Add(new DataColumn("TongThanhTien"));
            dt.Columns["TongThanhTien"].Caption = "Tổng số tiền chi trả qua ATM";
            #endregion

            bindingSourceImport.DataSource = dt;
        }

        void GridImportThuLaoGiangDayUEL()
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewImport, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewImport, new string[] { "NamHoc", "HocKy", "DotChiTra", "MaGiangVienQuanLy", "HoTen", "NoiDungChi", "TenMonHoc", "MaLop", "CuNhanTaiNang", "SoTiet", "SiSo", "HeSoChucDanh", "HeSoCoSo", "HeSoLopDong", "HeSoKhac", "TongCongHeSo", "TietGiangGoc", "TietQuyDoi", "ChiPhiDiLai", "DonGia", "ThanhTien", "TongCong", "TietNoKyTruoc", "TietNoKyNay", "TongNoGioChuan", "Thue", "ThucLanh" }
                    , new string[] { "Năm học", "Học kỳ", "Đợt chi trả", "Mã giảng viên", "Họ và tên", "Khoản chi", "Tên môn học", "Lớp", "Cử nhân TN", "Số tiết", "Số lượng SV", "Hệ số chức danh", "Hệ số địa điểm", "Hệ số lớp đông", "Hệ số khác", "Cộng hệ số", "Tiết giảng gốc", "Tiết quy đổi", "Chi phí đi lại", "Đơn giá tiết chuẩn", "Thành tiền", "Tổng cộng", "Nợ giờ HK trước", "Nợ giờ HK này", "Tổng tiền nợ", "Thuế TNCN tạm trừ", "Còn lại thanh toán" }
                    , new int[] { 80, 80, 100, 90, 150, 180, 180, 90, 70, 70, 70, 90, 90, 90, 60, 60, 70, 70, 100, 110, 100, 100, 100, 100, 100, 110, 120 });
            AppGridView.AlignHeader(gridViewImport, new string[] { "NamHoc", "HocKy", "DotChiTra", "MaGiangVienQuanLy", "HoTen", "NoiDungChi", "TenMonHoc", "MaLop", "CuNhanTaiNang", "SoTiet", "SiSo", "HeSoChucDanh", "HeSoCoSo", "HeSoLopDong", "HeSoKhac", "TongCongHeSo", "TietGiangGoc", "TietQuyDoi", "ChiPhiDiLai", "DonGia", "ThanhTien", "TongCong", "TietNoKyTruoc", "TietNoKyNay", "TongNoGioChuan", "Thue", "ThucLanh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewImport);
            #endregion

            #region datatable
            dt.Columns.Add(new DataColumn("NamHoc"));
            dt.Columns["NamHoc"].Caption = "Năm học";
            dt.Columns.Add(new DataColumn("HocKy"));
            dt.Columns["HocKy"].Caption = "Học kỳ";
            dt.Columns.Add(new DataColumn("DotChiTra"));
            dt.Columns["DotChiTra"].Caption = "Đợt chi trả";
            dt.Columns.Add(new DataColumn("MaGiangVienQuanLy"));
            dt.Columns["MaGiangVienQuanLy"].Caption = "Mã giảng viên";
            dt.Columns.Add(new DataColumn("HoTen"));
            dt.Columns["HoTen"].Caption = "Họ và tên";
            dt.Columns.Add(new DataColumn("NoiDungChi"));
            dt.Columns["NoiDungChi"].Caption = "Khoản chi";
            dt.Columns.Add(new DataColumn("TenMonHoc"));
            dt.Columns["TenMonHoc"].Caption = "Tên môn học";
            dt.Columns.Add(new DataColumn("MaLop"));
            dt.Columns["MaLop"].Caption = "Lớp";
            dt.Columns.Add(new DataColumn("CuNhanTaiNang"));
            dt.Columns["CuNhanTaiNang"].Caption = "Cử nhân TN";
            dt.Columns.Add(new DataColumn("SoTiet"));
            dt.Columns["SoTiet"].Caption = "Số tiết";
            dt.Columns.Add(new DataColumn("SiSo"));
            dt.Columns["SiSo"].Caption = "Số lượng SV";
            dt.Columns.Add(new DataColumn("HeSoChucDanh"));
            dt.Columns["HeSoChucDanh"].Caption = "Hệ số chức danh";
            dt.Columns.Add(new DataColumn("HeSoCoSo"));
            dt.Columns["HeSoCoSo"].Caption = "Hệ số địa điểm";
            dt.Columns.Add(new DataColumn("HeSoLopDong"));
            dt.Columns["HeSoLopDong"].Caption = "Hệ số lớp đông";
            dt.Columns.Add(new DataColumn("HeSoKhac"));
            dt.Columns["HeSoKhac"].Caption = "Hệ số khác";
            dt.Columns.Add(new DataColumn("TongCongHeSo"));
            dt.Columns["TongCongHeSo"].Caption = "Cộng hệ số";
            dt.Columns.Add(new DataColumn("TietGiangGoc"));
            dt.Columns["TietGiangGoc"].Caption = "Tiết giảng gốc";
            dt.Columns.Add(new DataColumn("TietQuyDoi"));
            dt.Columns["TietQuyDoi"].Caption = "Tiết quy đổi";
            dt.Columns.Add(new DataColumn("ChiPhiDiLai"));
            dt.Columns["ChiPhiDiLai"].Caption = "Chi phí đi lại";
            dt.Columns.Add(new DataColumn("DonGia"));
            dt.Columns["DonGia"].Caption = "Đơn giá tiết chuẩn";
            dt.Columns.Add(new DataColumn("ThanhTien"));
            dt.Columns["ThanhTien"].Caption = "Thành tiền";
            dt.Columns.Add(new DataColumn("TongCong"));
            dt.Columns["TongCong"].Caption = "Tổng cộng";
            dt.Columns.Add(new DataColumn("TietNoKyTruoc"));
            dt.Columns["TietNoKyTruoc"].Caption = "Nợ giờ HK trước";
            dt.Columns.Add(new DataColumn("TietNoKyNay"));
            dt.Columns["TietNoKyNay"].Caption = "Nợ giờ HK này";
            dt.Columns.Add(new DataColumn("TongNoGioChuan"));
            dt.Columns["TongNoGioChuan"].Caption = "Tổng tiền nợ";
            dt.Columns.Add(new DataColumn("Thue"));
            dt.Columns["Thue"].Caption = "Thuế TNCN tạm trừ";
            dt.Columns.Add(new DataColumn("ThucLanh"));
            dt.Columns["ThucLanh"].Caption = "Còn lại thanh toán";
            #endregion

            bindingSourceImport.DataSource = dt;
        }

        void GridImportThuLaoHuongDanCuoiKhoaUEL()
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewImport, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewImport, new string[] { "NamHoc", "HocKy", "DotChiTra", "MaGiangVienQuanLy", "HoTen", "HuongDanVietBaoCaoTotNghiep", "HuongDanChuyenDeThucTapTotNghiep", "HuongDanKhoaLuanTotNghiep", "PhanBienKhoaLuanTotNghiep", "SoTietQuyDoi", "DonGia", "ThanhTienKhoaLuanChuyenDeTotNghiep", "SoLuongThamGiaHoiDongTotNghiep", "ThanhTienThamGiaHoiDongTotNghiep", "SoTietNoGioChuan", "ThanhTienNoGioChuan", "Thue", "ThucLanh", "NoiDung" }
                    , new string[] { "Năm học", "Học kỳ", "Đợt chi trả", "Mã giảng viên", "họ tên", "Hướng dẫn viết BCTN", "Hướng dẫn chuyên đề TTTN", "Hướng dẫn khoá luận TN", "Phản biện khoá luận TN", "Số tiết quy đổi", "Đơn giá", "Thành tiền", "Tham gia hội đồng TN", "Thành tiền HDTN", "Số tiết nợ giờ chuẩn", "Số tiền nợ giờ chuẩn", "Thuế", "Thực lãnh", "Nội dung" }
                    , new int[] { 80, 80, 100, 90, 150, 150, 150, 150, 150, 100, 80, 90, 150, 150, 150, 150, 100, 120, 150 });
            AppGridView.AlignHeader(gridViewImport, new string[] { "NamHoc", "HocKy", "DotChiTra", "MaGiangVienQuanLy", "HoTen", "HuongDanVietBaoCaoTotNghiep", "HuongDanChuyenDeThucTapTotNghiep", "HuongDanKhoaLuanTotNghiep", "PhanBienKhoaLuanTotNghiep", "SoTietQuyDoi", "DonGia", "ThanhTienKhoaLuanChuyenDeTotNghiep", "SoLuongThamGiaHoiDongTotNghiep", "ThanhTienThamGiaHoiDongTotNghiep", "SoTietNoGioChuan", "ThanhTienNoGioChuan", "Thue", "ThucLanh", "NoiDung" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewImport);
            #endregion

            #region datatable
            dt.Columns.Add(new DataColumn("NamHoc"));
            dt.Columns["NamHoc"].Caption = "Năm học";
            dt.Columns.Add(new DataColumn("HocKy"));
            dt.Columns["HocKy"].Caption = "Học kỳ";
            dt.Columns.Add(new DataColumn("DotChiTra"));
            dt.Columns["DotChiTra"].Caption = "Đợt chi trả";
            dt.Columns.Add(new DataColumn("MaGiangVienQuanLy"));
            dt.Columns["MaGiangVienQuanLy"].Caption = "Mã giảng viên";
            dt.Columns.Add(new DataColumn("HoTen"));
            dt.Columns["HoTen"].Caption = "Họ và tên";
            dt.Columns.Add(new DataColumn("HuongDanVietBaoCaoTotNghiep"));
            dt.Columns["HuongDanVietBaoCaoTotNghiep"].Caption = "Hướng dẫn viết BCTN";
            dt.Columns.Add(new DataColumn("HuongDanChuyenDeThucTapTotNghiep"));
            dt.Columns["HuongDanChuyenDeThucTapTotNghiep"].Caption = "Hướng dẫn chuyên đề TTTN";
            dt.Columns.Add(new DataColumn("HuongDanKhoaLuanTotNghiep"));
            dt.Columns["HuongDanKhoaLuanTotNghiep"].Caption = "Hướng dẫn khoá luận TN";
            dt.Columns.Add(new DataColumn("PhanBienKhoaLuanTotNghiep"));
            dt.Columns["PhanBienKhoaLuanTotNghiep"].Caption = "Phản biện khoá luận TN";
            dt.Columns.Add(new DataColumn("SoTietQuyDoi"));
            dt.Columns["SoTietQuyDoi"].Caption = "Số tiết quy đổi";
            dt.Columns.Add(new DataColumn("DonGia"));
            dt.Columns["DonGia"].Caption = "Đơn giá";
            dt.Columns.Add(new DataColumn("ThanhTienKhoaLuanChuyenDeTotNghiep"));
            dt.Columns["ThanhTienKhoaLuanChuyenDeTotNghiep"].Caption = "Thành tiền";
            dt.Columns.Add(new DataColumn("SoLuongThamGiaHoiDongTotNghiep"));
            dt.Columns["SoLuongThamGiaHoiDongTotNghiep"].Caption = "Tham gia hội đồng TN";
            dt.Columns.Add(new DataColumn("ThanhTienThamGiaHoiDongTotNghiep"));
            dt.Columns["ThanhTienThamGiaHoiDongTotNghiep"].Caption = "Thành tiền HDTN";
            dt.Columns.Add(new DataColumn("SoTietNoGioChuan"));
            dt.Columns["SoTietNoGioChuan"].Caption = "Số tiết nợ giờ chuẩn";
            dt.Columns.Add(new DataColumn("ThanhTienNoGioChuan"));
            dt.Columns["ThanhTienNoGioChuan"].Caption = "Số tiền nợ giờ chuẩn";
            dt.Columns.Add(new DataColumn("Thue"));
            dt.Columns["Thue"].Caption = "Thuế";
            dt.Columns.Add(new DataColumn("ThucLanh"));
            dt.Columns["ThucLanh"].Caption = "Thực lãnh";
            dt.Columns.Add(new DataColumn("NoiDung"));
            dt.Columns["NoiDung"].Caption = "Nội dung";
            #endregion

            bindingSourceImport.DataSource = dt;
        }

        void GridImportThuLaoCoiThiChamBaiUEL()
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewImport, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewImport, new string[] { "NamHoc", "HocKy", "DotChiTra", "MaGiangVienQuanLy", "HoTen", "NoiDungChi", "TenMonHoc", "MaLop", "SoBaiQuaTrinh", "SoBaiGiuaKy", "SoBaiCuoiKy", "DonGiaQuaTrinh", "DonGiaGiuaKy", "DonGiaCuoiKy", "ThanhTien", "SoTienCoiThi" }
                    , new string[] { "Năm học", "Học kỳ", "Đợt chi trả", "Mã giảng viên", "Họ và tên", "Khoản chi", "Tên môn học", "Lớp", "Số bài quá trình", "Số bài giữa kỳ", "Số bài cuối kỳ", "Đơn giá quá trình", "Đơn giá giữa kỳ", "Đơn giá cuối kỳ", "Thành tiền", "Số tiền coi thi" }
                    , new int[] { 80, 80, 100, 90, 150, 180, 180, 90, 70, 70, 70, 90, 90, 90, 100, 100 });
            AppGridView.AlignHeader(gridViewImport, new string[] { "NamHoc", "HocKy", "DotChiTra", "MaGiangVienQuanLy", "HoTen", "NoiDungChi", "TenMonHoc", "MaLop", "SoBaiQuaTrinh", "SoBaiGiuaKy", "SoBaiCuoiKy", "DonGiaQuaTrinh", "DonGiaGiuaKy", "DonGiaCuoiKy", "ThanhTien", "SoTienCoiThi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewImport);
            #endregion

            #region datatable
            dt.Columns.Add(new DataColumn("NamHoc"));
            dt.Columns["NamHoc"].Caption = "Năm học";
            dt.Columns.Add(new DataColumn("HocKy"));
            dt.Columns["HocKy"].Caption = "Học kỳ";
            dt.Columns.Add(new DataColumn("DotChiTra"));
            dt.Columns["DotChiTra"].Caption = "Đợt chi trả";
            dt.Columns.Add(new DataColumn("MaGiangVienQuanLy"));
            dt.Columns["MaGiangVienQuanLy"].Caption = "Mã giảng viên";
            dt.Columns.Add(new DataColumn("HoTen"));
            dt.Columns["HoTen"].Caption = "Họ và tên";
            dt.Columns.Add(new DataColumn("NoiDungChi"));
            dt.Columns["NoiDungChi"].Caption = "Khoản chi";
            dt.Columns.Add(new DataColumn("TenMonHoc"));
            dt.Columns["TenMonHoc"].Caption = "Tên môn học";
            dt.Columns.Add(new DataColumn("MaLop"));
            dt.Columns["MaLop"].Caption = "Lớp";
            dt.Columns.Add(new DataColumn("SoBaiQuaTrinh"));
            dt.Columns["SoBaiQuaTrinh"].Caption = "Số bài quá trình";
            dt.Columns.Add(new DataColumn("SoBaiGiuaKy"));
            dt.Columns["SoBaiGiuaKy"].Caption = "Số bài giữa kỳ";
            dt.Columns.Add(new DataColumn("SoBaiCuoiKy"));
            dt.Columns["SoBaiCuoiKy"].Caption = "Số bài cuối kỳ";
            dt.Columns.Add(new DataColumn("DonGiaQuaTrinh"));
            dt.Columns["DonGiaQuaTrinh"].Caption = "Đơn giá quá trình";
            dt.Columns.Add(new DataColumn("DonGiaGiuaKy"));
            dt.Columns["DonGiaGiuaKy"].Caption = "Đơn giá giữa kỳ";
            dt.Columns.Add(new DataColumn("DonGiaCuoiKy"));
            dt.Columns["DonGiaCuoiKy"].Caption = "Đơn giá cuối kỳ";
            dt.Columns.Add(new DataColumn("ThanhTien"));
            dt.Columns["ThanhTien"].Caption = "Thành tiền";
            dt.Columns.Add(new DataColumn("SoTienCoiThi"));
            dt.Columns["SoTienCoiThi"].Caption = "Số tiền coi thi";
            #endregion

            bindingSourceImport.DataSource = dt;
        }

        string IsNull(string O)
        {
            if (O == "")
                O = "0";
            return O;
        }
        #endregion

        #region Event Button
        private void buttonEditChoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog { Filter = "Excel Workbook (*.xls)|*.xls", Multiselect = false, ValidateNames = true };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                buttonEditChoFile.Text = dialog.FileName;
                DevExpress.Common.SQLHelper.Helper helper =
                    new DevExpress.Common.SQLHelper.Helper(String.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0};Extended Properties={1}Excel 8.0;Imex=2;HDR=yes{1}"
                        , dialog.FileName, Convert.ToChar(34)));
                DataTable data = helper.GetOleDbSchemaTable();
                if (data == null || data.Rows.Count < 1)
                    return;
                frmDinhDangCot frm = new frmDinhDangCot(dt, data, helper);
                frm.ShowDialog();
                DataTable dtcol = frm.dt;
                DataTable table = frm.dtChon;
                if (table == null)
                    return;
                using (WaitDialogForm wait = new WaitDialogForm("Loading data ..."))
                {
                    try
                    {
                        if (table != null)
                        {
                            dt.Rows.Clear();
                            foreach (DataRow dr in table.Rows)
                            {
                                DataRow drdulieu = dt.NewRow();
                                int i = 0;
                                foreach (DataRow drcol in dtcol.Rows)
                                {
                                    if (drcol["Name"].ToString() == " ")
                                        continue;
                                    if (!string.IsNullOrEmpty(drcol["Name"].ToString()))
                                    {
                                        drdulieu[drcol["colDataBase"].ToString()] = dr[drcol["Name"].ToString()].ToString() == string.Empty ? null : dr[drcol["Name"].ToString()].ToString();
                                        i = 1;
                                    }
                                }
                                if (i == 1)
                                {
                                    dt.Rows.Add(drdulieu);
                                }
                            }
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình import dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buttonEditChoFile.Text = string.Empty;
                    }
                    finally
                    {

                        bindingSourceImport.DataSource = dt;
                        gridViewImport.OptionsView.RowAutoHeight = true;
                        wait.Close();
                    }
                }

                Cursor.Current = Cursors.Default;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int result = -1;
            string strXML = "<Root>";

            switch (MaTruong)
            {
                case "UEL":
                    ImportUEL(strXML, ref result);
                    break;
                case "DLU":
                    ImportDLU(strXML, ref result);
                    break;
                default:
                    ImportKetQuaQuyDoiTCB(strXML, ref result);
                    break;
            }
            
            if (result == 0)
            {
                XtraMessageBox.Show("Import thành công, thoát giao diện import.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
                XtraMessageBox.Show("Thao tác thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Cursor.Current = Cursors.Default;
        }

        private void btnXuatCauTruc_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "(*.xls)|*.xls";
            sf.FileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CauTrucImportThuLao.xls";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                if (sf.FileName != "")
                {
                    gridControlImPort.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region Import
        void ImportDLU(string strXML, ref int result)
        {
            switch (LoaiThuLao)
            {
                case "ThuLaoCoiThiChamBai":
                    for (int i = 0; i < gridViewImport.DataRowCount; i++)
                    {
                        DataRow r = gridViewImport.GetDataRow(i);
                
                        decimal _b;

                        decimal _coiThi = decimal.TryParse(r["GioCoiThi"].ToString(), out _b) ? _b : 0;
                        decimal _chamThi = decimal.TryParse(r["GioChamThi"].ToString(), out _b) ? _b : 0;
                        decimal _raDe = decimal.TryParse(r["GioRaDe"].ToString(), out _b) ? _b : 0;
                        decimal _toChucThi = decimal.TryParse(r["GioToChucThi"].ToString(), out _b) ? _b : 0;
                        decimal _nhapDiem = decimal.TryParse(r["GioNhapDiem"].ToString(), out _b) ? _b : 0;
                        decimal _tongCong = decimal.TryParse(r["TongCong"].ToString(), out _b) ? _b : 0;

                        if (r["MaGiangVienQuanLy"].ToString() == "" || r["TongCong"].ToString() == "")
                            continue;//Những dòng ko có mã giảng viên và số tiết quy đổi thì ko import

                        strXML += "<Input Id=\"" + "-1"//Import Id = -1
                                    + "\" MQL=\"" + System.Security.SecurityElement.Escape(r["MaGiangVienQuanLy"].ToString().Trim())
                                    + "\" MMH=\"" + System.Security.SecurityElement.Escape(r["MaMonHoc"].ToString().Trim())
                                    + "\" BDT=\"" + System.Security.SecurityElement.Escape(r["BacDaoTao"].ToString().Trim())
                                    + "\" LHDT=\"" + System.Security.SecurityElement.Escape(r["LoaiHinhDaoTao"].ToString().Trim())
                                    + "\" CT=\"" + _coiThi
                                    + "\" ChT=\"" + _chamThi
                                    + "\" RD=\"" + _raDe
                                    + "\" TCT=\"" + _toChucThi
                                    + "\" ND=\"" + _nhapDiem
                                    + "\" TC=\"" + _tongCong
                                    + "\" />";
                    }
                    strXML += "</Root>";
                    if (strXML == "<Root></Root>")
                    {
                        XtraMessageBox.Show("Danh sách rỗng, kiểm tra lại file excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //strXML = Regex.Replace(strXML, "&", "&amp;");
                    DataServices.ThuLaoCoiThiChamBaiImport.Luu(strXML, NamHoc, HocKy, "CH - CQ", DotThanhToan, ref result);
                    break;
                default:
                    for (int i = 0; i < gridViewImport.DataRowCount; i++)
                    {
                        DataRow r = gridViewImport.GetDataRow(i);
                
                        int _a; decimal _b;
                    
                        decimal _soTiet = decimal.TryParse(r["SoTiet"].ToString(), out _b) ? _b : 0;
                        int _siSo = int.TryParse(r["SiSo"].ToString(), out _a) ? _a : 0;
                        decimal _heSoChucDanh = decimal.TryParse(r["HeSoChucDanh"].ToString(), out _b) ? _b : 0;
                        decimal _heSoBacDaoTao = decimal.TryParse(r["HeSoBacDaoTao"].ToString(), out _b) ? _b : 0;
                        decimal _heSoLopDong = decimal.TryParse(r["HeSoLopDong"].ToString(), out _b) ? _b : 0;
                        decimal _heSoThucHanh = decimal.TryParse(r["HeSoThucHanh"].ToString(), out _b) ? _b : 0;
                        decimal _tietQuyDoi = decimal.TryParse(r["TietQuyDoi"].ToString(), out _b) ? _b : 0;

                        if (r["MaGiangVienQuanLy"].ToString() == "" || r["TietQuyDoi"].ToString() == "")
                            continue;//Những dòng ko có mã giảng viên và số tiết quy đổi thì ko import

                        strXML += "<Input Id=\"" + "-1"//Import Id = -1
                                    + "\" M=\"" + System.Security.SecurityElement.Escape(r["MaGiangVienQuanLy"].ToString().Trim())
                                    + "\" MM=\"" + System.Security.SecurityElement.Escape(r["MaMonHoc"].ToString().Trim())
                                    + "\" MB=\"" + System.Security.SecurityElement.Escape(r["MaBacDaoTao"].ToString().Trim())
                                    + "\" ML=\"" + System.Security.SecurityElement.Escape(r["MaLop"].ToString().Trim())
                                    + "\" SS=\"" + _siSo
                                    + "\" ST=\"" + _soTiet
                                    + "\" HSCD=\"" + _heSoChucDanh
                                    + "\" HSLD=\"" + _heSoLopDong
                                    + "\" HSBDT=\"" + _heSoBacDaoTao
                                    + "\" HSTH=\"" + _heSoThucHanh
                                    + "\" QD=\"" + _tietQuyDoi
                                    + "\" GC=\"" + r["NoiDungChi"].ToString()
                                    + "\" />";
                    }
                    strXML += "</Root>";
                    if (strXML == "<Root></Root>")
                    {
                        XtraMessageBox.Show("Danh sách rỗng, kiểm tra lại file excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //strXML = Regex.Replace(strXML, "&", "&amp;");
                    DataServices.ThuLaoImport.Luu(strXML, NamHoc, HocKy, MaLoaiHinhDaoTao, DotThanhToan, ref result);
                    break;
            }

            
        }
        
        void ImportUEL(string strXML, ref int result)
        {
            switch (LoaiThuLao)
            {
                case "ThuLaoGiangDay":
                    ImportThuLaoGiangDayUEL(strXML, result);
                    break;
                case "ThuLaoHuongDanCuoiKhoa":
                    ImportThuLaoHuongDanCuoiKhoaUEL(strXML, result);
                    break;
                case "ThuLaoCoiThiChamBai":
                    ImportThuLaoCoiThiChamBaiUEL(strXML, result);
                    break;
            }
        }

        void ImportThuLaoGiangDayUEL(string strXML, int result)
        {
            for (int i = 0; i < gridViewImport.DataRowCount; i++)
            {
                DataRow dr = gridViewImport.GetDataRow(i);
                if (dr["MaGiangVienQuanLy"].ToString() != "" || dr["DotChiTra"].ToString() != "")
                {
                    int _a; decimal _b;
                    int _cuNhanTaiNang = int.TryParse(dr["CuNhanTaiNang"].ToString(), out _a) ? _a : 0;
                    decimal _soTiet = decimal.TryParse(dr["SoTiet"].ToString(), out _b) ? _b : 0;
                    int _siSo = int.TryParse(dr["SiSo"].ToString(), out _a) ? _a : 0;
                    decimal _heSoChucDanh = decimal.TryParse(dr["HeSoChucDanh"].ToString(), out _b) ? _b : 0;
                    decimal _heSoCoSo = decimal.TryParse(dr["HeSoCoSo"].ToString(), out _b) ? _b : 0;
                    decimal _heSoLopDong = decimal.TryParse(dr["HeSoLopDong"].ToString(), out _b) ? _b : 0;
                    decimal _heSoKhac = decimal.TryParse(dr["HeSoKhac"].ToString(), out _b) ? _b : 0;
                    decimal _tongCongHeSo = decimal.TryParse(dr["TongCongHeSo"].ToString(), out _b) ? _b : 0;
                    decimal _tietGiangGoc = decimal.TryParse(dr["TietGiangGoc"].ToString(), out _b) ? _b : 0;
                    decimal _tietQuyDoi = decimal.TryParse(dr["TietQuyDoi"].ToString(), out _b) ? _b : 0;
                    decimal _chiPhiDiLai = decimal.TryParse(dr["ChiPhiDiLai"].ToString(), out _b) ? _b : 0;
                    decimal _donGia = decimal.TryParse(dr["DonGia"].ToString(), out _b) ? _b : 0;
                    decimal _thanhTien = decimal.TryParse(dr["ThanhTien"].ToString(), out _b) ? _b : 0;
                    decimal _tongCong = decimal.TryParse(dr["TongCong"].ToString(), out _b) ? _b : 0;
                    decimal _tietNoKyTruoc = decimal.TryParse(dr["TietNoKyTruoc"].ToString(), out _b) ? _b : 0;
                    decimal _tietNoKyNay = decimal.TryParse(dr["TietNoKyNay"].ToString(), out _b) ? _b : 0;
                    decimal _tongNoGioChuan = decimal.TryParse(dr["TongNoGioChuan"].ToString(), out _b) ? _b : 0;
                    decimal _thue = decimal.TryParse(dr["Thue"].ToString(), out _b) ? _b : 0;
                    decimal _thucLanh = decimal.TryParse(dr["ThucLanh"].ToString(), out _b) ? _b : 0;

                    strXML += String.Format("<Input D=\"{0}\" M=\"{1}\" Ht=\"{2}\" Nd=\"{3}\" Mh=\"{4}\" Ml=\"{5}\" Cn=\"{6}\" St=\"{7}\" Ss=\"{8}\" Hscd=\"{9}\" Hscs=\"{10}\" Hsld=\"{11}\" Hsk=\"{12}\" Chs=\"{13}\" Tgg=\"{14}\" Tqd=\"{15}\" Cpdl=\"{16}\" Dg=\"{17}\" Tt=\"{18}\" Tc=\"{19}\" Tnkt=\"{20}\" Tnkn=\"{21}\" Tngc=\"{22}\" Th=\"{23}\" Tl=\"{24}\" Nh=\"{25}\" Hk=\"{26}\" />"
                        , System.Security.SecurityElement.Escape(dr["DotChiTra"].ToString().Trim())
                        , System.Security.SecurityElement.Escape(dr["MaGiangVienQuanLy"].ToString().Trim())
                        , System.Security.SecurityElement.Escape(dr["HoTen"].ToString().Trim())
                        , System.Security.SecurityElement.Escape(dr["NoiDungChi"].ToString().Trim())
                        , System.Security.SecurityElement.Escape(dr["TenMonHoc"].ToString().Trim())
                        , System.Security.SecurityElement.Escape(dr["MaLop"].ToString().Trim())
                        , _cuNhanTaiNang, _soTiet, _siSo, _heSoChucDanh, _heSoCoSo, _heSoLopDong, _heSoKhac, _tongCongHeSo, _tietGiangGoc, _tietQuyDoi
                        , _chiPhiDiLai, _donGia, _thanhTien, _tongCong, _tietNoKyTruoc, _tietNoKyNay, _tongNoGioChuan, _thue, _thucLanh
                        , System.Security.SecurityElement.Escape(dr["NamHoc"].ToString().Trim())
                        , System.Security.SecurityElement.Escape(dr["HocKy"].ToString().Trim()));
                }
            }
            strXML += "</Root>";
            if (strXML == "<Root></Root>")
            {
                XtraMessageBox.Show("Danh sách rỗng, kiểm tra lại file excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //strXML = Regex.Replace(strXML, "&", "&amp;");
            DataServices.ThuLaoImport.Import(strXML, UserInfo.FullName, ref result);
        }

        void ImportThuLaoHuongDanCuoiKhoaUEL(string strXML, int result)
        {
            for (int i = 0; i < gridViewImport.DataRowCount; i++)
            {
                DataRow dr = gridViewImport.GetDataRow(i);
                if (dr["MaGiangVienQuanLy"].ToString() != "" || dr["DotChiTra"].ToString() != "")
                {
                    int _a; decimal _b;
                    int _HuongDanVietBaoCaoTotNghiep = int.TryParse(dr["HuongDanVietBaoCaoTotNghiep"].ToString(), out _a) ? _a : 0;
                    int _HuongDanChuyenDeThucTapTotNghiep = int.TryParse(dr["HuongDanChuyenDeThucTapTotNghiep"].ToString(), out _a) ? _a : 0;
                    int _HuongDanKhoaLuanTotNghiep = int.TryParse(dr["HuongDanKhoaLuanTotNghiep"].ToString(), out _a) ? _a : 0;
                    int _PhanBienKhoaLuanTotNghiep = int.TryParse(dr["PhanBienKhoaLuanTotNghiep"].ToString(), out _a) ? _a : 0;
                    decimal _SoTietQuyDoi = decimal.TryParse(dr["SoTietQuyDoi"].ToString(), out _b) ? _b : 0;
                    decimal _DonGia = decimal.TryParse(dr["DonGia"].ToString(), out _b) ? _b : 0;
                    decimal _ThanhTienKhoaLuanChuyenDeTotNghiep = decimal.TryParse(dr["ThanhTienKhoaLuanChuyenDeTotNghiep"].ToString(), out _b) ? _b : 0;
                    int _SoLuongThamGiaHoiDongTotNghiep = int.TryParse(dr["SoLuongThamGiaHoiDongTotNghiep"].ToString(), out _a) ? _a : 0;
                    decimal _ThanhTienThamGiaHoiDongTotNghiep = decimal.TryParse(dr["ThanhTienThamGiaHoiDongTotNghiep"].ToString(), out _b) ? _b : 0;
                    decimal _SoTietNoGioChuan = decimal.TryParse(dr["SoTietNoGioChuan"].ToString(), out _b) ? _b : 0;
                    decimal _ThanhTienNoGioChuan = decimal.TryParse(dr["ThanhTienNoGioChuan"].ToString(), out _b) ? _b : 0;
                    decimal _Thue = decimal.TryParse(dr["Thue"].ToString(), out _b) ? _b : 0;
                    decimal _ThucLanh = decimal.TryParse(dr["ThucLanh"].ToString(), out _b) ? _b : 0;

                    strXML += "<Input D=\"" + dr["DotChiTra"].ToString().Trim()
                            + "\" M=\"" + dr["MaGiangVienQuanLy"].ToString().Trim()
                            + "\" H1=\"" + _HuongDanVietBaoCaoTotNghiep
                            + "\" H2=\"" + _HuongDanChuyenDeThucTapTotNghiep
                            + "\" H3=\"" + _HuongDanKhoaLuanTotNghiep
                            + "\" Pb=\"" + _PhanBienKhoaLuanTotNghiep
                            + "\" S1=\"" + _SoTietQuyDoi
                            + "\" Dg=\"" + _DonGia
                            + "\" T1=\"" + _ThanhTienKhoaLuanChuyenDeTotNghiep
                            + "\" S2=\"" + _SoLuongThamGiaHoiDongTotNghiep
                            + "\" T2=\"" + _ThanhTienThamGiaHoiDongTotNghiep
                            + "\" S3=\"" + _SoTietNoGioChuan
                            + "\" T3=\"" + _ThanhTienNoGioChuan
                            + "\" T4=\"" + _Thue
                            + "\" T5=\"" + _ThucLanh
                            + "\" Nd=\"" + dr["NoiDung"].ToString().Trim()
                            + "\" Nh=\"" + dr["NamHoc"].ToString().Trim()
                            + "\" Hk=\"" + dr["HocKy"].ToString().Trim()
                            + "\" />";
                    //strXML += String.Format("<Input D=\"{0}\" M=\"{1}\" Ht=\"{2}\" Nd=\"{3}\" Mh=\"{4}\" Ml=\"{5}\" Cn=\"{6}\" St=\"{7}\" Ss=\"{8}\" Hscd=\"{9}\" Hscs=\"{10}\" Hsld=\"{11}\" Hsk=\"{12}\" Chs=\"{13}\" Tgg=\"{14}\" Tqd=\"{15}\" Cpdl=\"{16}\" Dg=\"{17}\" Tt=\"{18}\" Tc=\"{19}\" Tnkt=\"{20}\" Tnkn=\"{21}\" Tngc=\"{22}\" Th=\"{23}\" Tl=\"{24}\" Nh=\"{25}\" Hk=\"{26}\" />", dr["DotChiTra"].ToString().Trim(), dr["MaGiangVienQuanLy"].ToString().Trim(), dr["HoTen"].ToString().Trim(), dr["NoiDungChi"].ToString().Trim(), dr["TenMonHoc"].ToString().Trim(), dr["MaLop"].ToString().Trim(), _cuNhanTaiNang, _soTiet, _siSo, _heSoChucDanh, _heSoCoSo, _heSoLopDong, _heSoKhac, _tongCongHeSo, _tietGiangGoc, _tietQuyDoi, _chiPhiDiLai, _donGia, _thanhTien, _tongCong, _tietNoKyTruoc, _tietNoKyNay, _tongNoGioChuan, _thue, _thucLanh, dr["_namHoc"].ToString().Trim(), dr["_hocKy"].ToString().Trim());
                }
            }
            strXML += "</Root>";
            if (strXML == "<Root></Root>")
            {
                XtraMessageBox.Show("Danh sách rỗng, kiểm tra lại file excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            strXML = Regex.Replace(strXML, "&", "&amp;");
            DataServices.ThuLaoHuongDanCuoiKhoa.Import(strXML, UserInfo.FullName, ref result);
        }

        void ImportThuLaoCoiThiChamBaiUEL(string strXML, int result)
        {
            for (int i = 0; i < gridViewImport.DataRowCount; i++)
            {
                DataRow dr = gridViewImport.GetDataRow(i);
                if (dr["MaGiangVienQuanLy"].ToString() != "" || dr["DotChiTra"].ToString() != "")
                {
                    int _a;
                    int _soBaiQuaTrinh = int.TryParse(dr["SoBaiQuaTrinh"].ToString(), out _a) ? _a : 0;
                    int _soBaiGiuaKy = int.TryParse(dr["SoBaiGiuaKy"].ToString(), out _a) ? _a : 0;
                    int _soBaiCuoiKy = int.TryParse(dr["SoBaiCuoiKy"].ToString(), out _a) ? _a : 0;
                    int _donGiaQuaTrinh = int.TryParse(dr["DonGiaQuaTrinh"].ToString(), out _a) ? _a : 0;
                    int _donGiaGiuaKy = int.TryParse(dr["DonGiaGiuaKy"].ToString(), out _a) ? _a : 0;
                    int _donGiaCuoiKy = int.TryParse(dr["DonGiaCuoiKy"].ToString(), out _a) ? _a : 0;
                    int _thanhTien = int.TryParse(dr["ThanhTien"].ToString(), out _a) ? _a : 0;
                    int _soTienCoiThi = int.TryParse(dr["SoTienCoiThi"].ToString(), out _a) ? _a : 0;
                    

                    strXML += String.Format("<Input D=\"{0}\" M=\"{1}\" Ht=\"{2}\" Nd=\"{3}\" Mh=\"{4}\" Ml=\"{5}\" BQT=\"{6}\" BGK=\"{7}\" BCK=\"{8}\" DGQT=\"{9}\" DGGK=\"{10}\" DGCK=\"{11}\" TT=\"{12}\" STCT=\"{13}\" Nh=\"{14}\" Hk=\"{15}\" />"
                        , System.Security.SecurityElement.Escape(dr["DotChiTra"].ToString().Trim())
                        , System.Security.SecurityElement.Escape(dr["MaGiangVienQuanLy"].ToString().Trim())
                        , System.Security.SecurityElement.Escape(dr["HoTen"].ToString().Trim())
                        , System.Security.SecurityElement.Escape(dr["NoiDungChi"].ToString().Trim())
                        , System.Security.SecurityElement.Escape(dr["TenMonHoc"].ToString().Trim())
                        , System.Security.SecurityElement.Escape(dr["MaLop"].ToString().Trim())
                        , _soBaiQuaTrinh, _soBaiGiuaKy, _soBaiCuoiKy, _donGiaQuaTrinh, _donGiaGiuaKy, _donGiaCuoiKy, _thanhTien, _soTienCoiThi
                        , System.Security.SecurityElement.Escape(dr["NamHoc"].ToString().Trim())
                        , System.Security.SecurityElement.Escape(dr["HocKy"].ToString().Trim()));
                }
            }
            strXML += "</Root>";
            if (strXML == "<Root></Root>")
            {
                XtraMessageBox.Show("Danh sách rỗng, kiểm tra lại file excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //strXML = Regex.Replace(strXML, "&", "&amp;");
            DataServices.ThuLaoCoiThiChamBaiImport.Import(strXML, UserInfo.FullName, ref result);
        }

        void ImportKetQuaQuyDoiTCB(string strXML, ref int result)
        {
            for (int i = 0; i < gridViewImport.DataRowCount; i++)
            {
                DataRow dr = gridViewImport.GetDataRow(i);
                if (dr["MaGiangVien"].ToString() != "")
                {
                    strXML += "<GV M=\"" + dr["MaGiangVien"].ToString().Trim()
                                + "\" Ml=\"" + dr["MaLop"].ToString().Trim()
                                + "\" Nd=\"" + dr["NgayDay"].ToString().Trim()
                                + "\" Tmh=\"" + dr["TenMonHoc"].ToString().Trim()
                                + "\" Hsld=\"" + IsNull(dr["HeSoLopDong"].ToString()).Trim()
                                + "\" St=\"" + IsNull(dr["SoTiet"].ToString()).Trim()
                                + "\" Dg=\"" + IsNull(dr["DonGia"].ToString()).Trim()
                                + "\" Tt=\"" + IsNull(dr["ThanhTien"].ToString()).Trim()
                                + "\" Ctp=\"" + IsNull(dr["CongTacPhi"].ToString()).Trim()
                                + "\" Tgng=\"" + IsNull(dr["TienGiangNgoaiGio"].ToString()).Trim()
                                + "\" Ttt=\"" + IsNull(dr["TongThanhTien"].ToString()).Trim()
                                + "\"/>";
                }
            }
            strXML += "</Root>";
            if (strXML == "<Root></Root>")
            {
                XtraMessageBox.Show("Danh sách rỗng, kiểm tra lại file excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataServices.TcbKetQuaQuyDoi.Import(strXML, ref result);
        }
        #endregion
    }
}