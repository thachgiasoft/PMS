using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Common;
using DevExpress.XtraGrid.Views.Grid;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmQuyDoiGioChuan_ACT : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuuSiSo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuuSiSo.ShortCut = Shortcut.None;

                btnDongbo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDongbo.ShortCut = Shortcut.None;

                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnQuyDoi.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuuSiSo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnDongbo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _dsMaTruong;
        string _groupName;
        bool user = false;
        VList<ViewKhoaBoMon> _listKhoaBoMon;
        #endregion

        #region Event Form
        public frmQuyDoiGioChuan_ACT()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _groupName = UserInfo.GroupName;
        }

        private void frmQuyDoiGioChuan_ACT_Load(object sender, EventArgs e)
        {
            _dsMaTruong = "USSH;ACT;UEL;CTIM;IUH;BUH;VHU;CDGTVT";
            #region Init GridView

            switch (_maTruong)
            {
                case "USSH":
                    InitGridUSSH();
                    break;
                case "ACT":
                    InitGridACT();
                    break;
                case "UEL":
                    InitGridUEL();
                    break;
                case "CTIM":
                    InitGridCTIM();
                    break;
                case "IUH":
                    InitGridIUH();
                    break;
                case "BUH":
                    InitGridBUH();
                    break;
                case "VHU":
                    InitGridVHU();
                    break;
                case "CDGTVT":
                    InitGridCDGTVT();
                    break;
                default:
                    InitRemaining();
                    break;
            }

            #endregion
            WordWrapHeader(gridViewKhoiLuongQuyDoi, 50);
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            #region Khoa-DonVi
            AppGridLookupEdit.InitGridLookUp(cboDonVi, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" });
            cboDonVi.Properties.ValueMember = "MaKhoa";
            cboDonVi.Properties.DisplayMember = "TenKhoa";
            cboDonVi.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion

        #region InitGrid()
        void InitGridACT()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "Chon", "HocKy", "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TenCoSo", "SoLuong"
		                                                                , "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet", "TietThucDay", "TietQuyDoi"  }
                                                         , new string[] { "Chọn", "Học kỳ", "Mã giảng viên", "Họ", "Tên", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Loại học phần", "Bậc đào tạo", "Mã Khóa học", "Cơ sở", "Số SV ĐK"
                                                                        , "Hệ số lớp đông", "Hệ số cơ sở", "Hệ số quy đổi TH sang LT", "Tiết thực dạy", "Tiết quy đổi"}
                                                         , new int[] { 55, 80, 140, 120, 60, 150, 80, 100, 100, 70, 100, 90, 100, 90, 100, 110, 110, 100, 100 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "Chon", "HocKy", "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TenCoSo", "SoLuong"
		                                                                , "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet", "TietThucDay", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoTinChi", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "MaLopHocPhan" });
            AppGridView.HideField(gridViewKhoiLuongQuyDoi, new string[] { "TenCoSo", "HeSoCoSo" });
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "Chon", "HocKy", "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
        }

        void InitGridUSSH()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "HocKy", "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TenCoSo", "SoLuong"
		                                                                , "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet", "TietThucDay", "TietQuyDoi"  }
                                                         , new string[] { "Học kỳ", "Mã giảng viên", "Họ", "Tên", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Loại học phần", "Bậc đào tạo", "Mã Khóa học", "Cơ sở", "Số SV ĐK"
                                                                        , "Hệ số lớp đông", "Hệ số cơ sở", "Hệ số quy đổi TH sang LT", "Tiết thực dạy", "Tiết quy đổi"}
                                                         , new int[] { 80, 140, 120, 60, 150, 80, 100, 100, 70, 100, 90, 100, 90, 100, 110, 110, 100, 100 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "HocKy", "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TenCoSo", "SoLuong"
		                                                                , "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet", "TietThucDay", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoTinChi", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
        }

        void InitGridUEL()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "HocKy", "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TenCoSo", "SoLuong"
		                                                                , "HeSoLopDong", "HeSoCoSo", "HeSoChucDanhChuyenMon", "HeSoClcCntn", "HeSoThinhGiangMonChuyenNganh", "TietThucDay", "TietQuyDoi"  }
                                                         , new string[] { "Học kỳ", "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Loại học phần", "Bậc đào tạo", "Mã Khóa học", "Cơ sở", "Số SV ĐK"
                                                                        , "Hệ số lớp đông", "Hệ số địa điểm và ngoài giờ", "Hệ số chức danh chuyên môn", "Hệ số lớp CLC - CNTN", "Hệ số thỉnh giảng môn chuyên ngành", "Tiết thực dạy", "Tiết quy đổi"}
                                                         , new int[] { 80, 140, 120, 60, 80, 80, 150, 80, 100, 100, 70, 100, 90, 100, 90, 100, 150, 150, 120, 150, 100, 100 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "HocKy", "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TenCoSo", "SoLuong"
		                                                                , "HeSoLopDong", "HeSoCoSo", "HeSoChucDanhChuyenMon", "HeSoClcCntn", "HeSoThinhGiangMonChuyenNganh", "TietThucDay", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoTinChi", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoLopDong", "HeSoCoSo", "HeSoChucDanhChuyenMon", "HeSoClcCntn", "HeSoThinhGiangMonChuyenNganh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
        }

        void InitGridCTIM()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
		                                                                , "HeSoChucDanhChuyenMon", "HeSoTroCap", "HeSoLopDong" , "HeSoThinhGiangMonChuyenNganh", "HeSoQuyDoiThucHanhSangLyThuyet", "TietThucDay", "TietQuyDoi" }
                                                         , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Mã môn học", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Học kỳ", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học"
                                                                        , "Hệ số chức danh","Hệ số trợ cấp", "Hệ số lớp đông", "Hệ số thỉnh giảng", "Hệ số thực hành", "Tiết dạy thực tế", "Tiết quy đổi"}
                                                         , new int[] { 110, 120, 80, 100, 100, 100, 200, 80, 110, 80, 99, 80, 100, 100, 100, 110, 110, 110, 120, 120, 100, 100 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi","HeSoTroCap", "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
		                                                                , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoThinhGiangMonChuyenNganh", "HeSoQuyDoiThucHanhSangLyThuyet", "TietThucDay", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoTroCap", "HeSoThinhGiangMonChuyenNganh", "HeSoQuyDoiThucHanhSangLyThuyet" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
        }

        void InitGridIUH()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
		                                                                , "HeSoLopDong", "HeSoNgonNgu", "HeSoQuyDoiThucHanhSangLyThuyet", "TietThucDay", "TietQuyDoi"  }
                                                         , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "học vị", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Học kỳ", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học"
                                                                        , "Hệ số lớp đông", "Hệ số ngôn ngữ", "Hệ số thực hành", "Tiết dạy thực tế", "Tiết quy đổi"}
                                                         , new int[] { 140, 120, 80, 90, 90, 150, 80, 100, 100, 70, 100, 90, 90, 100, 90, 90, 120, 120, 90 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
		                                                                , "HeSoLopDong", "HeSoNgonNgu", "HeSoQuyDoiThucHanhSangLyThuyet", "TietThucDay", "TietQuyDoi"  }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoNgonNgu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
        }

        void InitGridBUH()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
		                                                                , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "HeSoNgoaiGio", "HeSoLuong", "HeSoMonMoi", "TietQuyDoi"  }
                                                         , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Tên môn học", "STC", "Mã Lớp học phần", "Lớp sinh viên", "Học kỳ", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học", "Tiết thực dạy"
                                                                        , "Hệ số chức danh", "Hệ số lớp đông", "Hệ số tỉnh (hs cơ sở)", "Hệ số ngoài giờ", "Hệ số lương", "Hệ số môn mới", "Tiết quy đổi"}
                                                         , new int[] { 140, 120, 70, 90, 90, 150, 60, 110, 100, 70, 100, 90, 80, 90, 100, 100, 100, 100, 100, 90, 100, 100 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] {"MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
		                                                                , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "HeSoNgoaiGio", "HeSoLuong", "HeSoMonMoi", "TietQuyDoi"   }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoTinChi", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
		                                                                , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "HeSoNgoaiGio", "HeSoLuong", "HeSoMonMoi", "TietQuyDoi"  }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
        }

        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
		                                                                , "HeSoNienCheTinChi", "HeSoNgonNgu", "HeSoNgoaiGio", "HeSoCoSo", "HeSoLopDong", "TietQuyDoi"  }
                                                         , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Tên môn học", "STC", "Mã Lớp học phần", "Lớp sinh viên", "Học kỳ", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học", "Tiết thực dạy"
                                                                        , "HS niên chế/tín chỉ", "Hệ số ngôn ngữ giảng dạy", "Hệ số ngoài giờ", "Hệ số đào tạo tại địa phương", "Hệ số lớp đông", "Tiết quy đổi"}
                                                         , new int[] { 140, 120, 70, 90, 90, 150, 60, 110, 100, 70, 100, 90, 80, 90, 100, 100, 100, 100, 100, 100, 100 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenHocHam", "TenHocVi", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
		                                                                , "HeSoNienCheTinChi", "HeSoNgonNgu", "HeSoNgoaiGio", "HeSoCoSo", "HeSoLopDong", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoTinChi", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc", "TietThucDay"
		                                                                , "HeSoNienCheTinChi", "HeSoLopDong", "HeSoCoSo", "HeSoNgoaiGio", "HeSoNgonNgu", "TietQuyDoi"  }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
        }

        void InitGridCDGTVT()
        {
            //HeSoQuyDoiThucHanhSangLyThuyet: hệ số môn thực tập; HeSoTroCap: hệ số CVHT
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
		                                                               , "HeSoBacDaoTao", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoTroCap", "TietThucDay", "TietQuyDoi"  }
                                                         , new string[] { "Mã giảng viên", "Họ", "Tên", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Học kỳ", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học"
                                                                        , "Hệ số bậc đào tạo", "Hệ số lớp đông", "Hệ số môn thực tập", "Hệ số CVHT", "Tiết dạy thực tế", "Tiết quy đổi" }
                                                         , new int[] { 140, 120, 80, 150, 80, 100, 100, 70, 100, 90, 110, 110, 100, 100, 90, 90, 120, 120, 90 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
		                                                               , "HeSoBacDaoTao", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoTroCap", "TietThucDay", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoBacDaoTao", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoTroCap" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
		                                                                , "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "SoTietThucTeQuyDoi", "TietQuyDoi"  }
                                                         , new string[] { "Mã giảng viên", "Họ", "Tên", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Học kỳ", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học"
                                                                        , "Hệ số công việc", "Hệ số bậc đào tạo", "Hệ số ngôn ngữ", "Hệ số chức danh", "Hệ số lớp đông", "Hệ số cơ sở", "Tiết dạy thực tế", "Tiết thực tế quy đổi", "Tiết quy đổi"}
                                                         , new int[] { 140, 120, 80, 150, 80, 100, 100, 70, 100, 90, 80, 90, 100, 110, 110, 100, 90, 90, 120, 120, 90 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "MaGiangVien", "Ho", "Ten", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "HocKy", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
		                                                                , "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "SoTietThucTeQuyDoi", "TietQuyDoi"  }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaGiangVien", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "SoTietThucTeQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            gridViewKhoiLuongQuyDoi.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
        }
        #endregion
        #region InitData
        void InitData()
        {

            #region Khoa-BoMon
            _listKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            foreach (ViewKhoaBoMon v in _listKhoaBoMon)
            {
                if (v.MaKhoa == _groupName)
                {
                    user = true;
                    break;
                }
            }
            if (user == true)
                _listKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);

            cboDonVi.DataBindings.Clear();
            bindingSourceDonVi.DataSource = _listKhoaBoMon;
            cboDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);
            #endregion


            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.KhoiLuongQuyDoi.GetByNamHocHocKyMaDonVi_Act(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tbl.Load(reader);
                tbl.Columns["SoLuong"].ReadOnly = false;
                tbl.Columns.Add(new DataColumn("Chon", typeof(Boolean)));
                bindingSourceKhoiLuongQuyDoi.DataSource = tbl;
            }
        }

        void WordWrapHeader(GridView grid, int height)
        {
            for (int i = 0; i < grid.Columns.Count; i++)
                grid.Columns[i].AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            AutoHeightHelper a = new AutoHeightHelper(grid, height);
            a.EnableColumnPanelAutoHeight();
        }
        #endregion

        #region Event Button
        private void btnDongbo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue.ToString() == "" || cboHocKy.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn năm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }
            int kiemTraDongBo = 0;
            DataServices.KhoiLuongGiangDayChiTiet.KiemTraDongBoTheoDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), ref kiemTraDongBo);
            if (kiemTraDongBo == 0)
                XtraMessageBox.Show(string.Format("Dữ liệu của năm học {0} - {1} đã được đồng bộ.\nLưu ý: nếu đồng bộ lại toàn bộ dữ liệu cũ của năm học {0} - {1} sẽ bị thay thế.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (XtraMessageBox.Show("Bạn có muốn đồng bộ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    using (frmXuLyDongBoDuLieu frm = new frmXuLyDongBoDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _maTruong, cboDonVi.EditValue.ToString()))
                    {
                        frm.ShowDialog();
                    }
                    InitData();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Đã xãy ra lỗi trong quá trình đồng bộ." + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (_maTruong == "ACT")//Sau khi đồng bộ mặc định chọn tất cả để quy đổi
            {
                DataTable tb = bindingSourceKhoiLuongQuyDoi.DataSource as DataTable;
                foreach (DataRow r in tb.Rows)
                {
                    r["Chon"] = true;
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlKhoiLuongQuyDoi.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
      
        private void btnLuuSiSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewKhoiLuongQuyDoi.FocusedRowHandle = -1;
            Cursor.Current = Cursors.WaitCursor;
            DataTable tb = bindingSourceKhoiLuongQuyDoi.DataSource as DataTable;
            if (tb.Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Bạn muốn lưu thay đổi sĩ số sinh viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string xmlData = "";
                    foreach (DataRow row in tb.Rows)
                    {
                        xmlData += "<Input M=\"" + row["MaGiangVien"].ToString()
                                    + "\" LHP=\"" + row["MaLopHocPhan"].ToString()
                                    + "\" S=\"" + PMS.Common.Globals.IsNull(row["SoLuong"].ToString(), "int")
                                    + "\" B=\"" + row["MaBacDaoTao"].ToString()
                                    + "\" />";
                    }
                    xmlData = "<Root>" + xmlData + "</Root>";

                    int kq = 0;
                    DataServices.KhoiLuongGiangDayChiTiet.CapNhatSiSo(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Lưu thay đổi sĩ số thành công. Lưu ý: thực hiện quy đổi lại để tính lại hệ số lớp đông.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnQuyDoi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Lúc đầu là quy đổi theo Khoa, sau đó yêu cầu chỉ quy đổi từng dòng muốn chọn quy đổi
            //QuyDoiTheoNamHocHocKyKhoa();
            gridViewKhoiLuongQuyDoi.FocusedRowHandle = -1;
            QuyDoiTheoGiangVienLopHocPhan();
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.KhoiLuongQuyDoi.GetByNamHocHocKyMaDonVi_Act(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tbl.Load(reader);
                tbl.Columns["SoLuong"].ReadOnly = false;
                tbl.Columns.Add(new DataColumn("Chon", typeof(Boolean)));
                bindingSourceKhoiLuongQuyDoi.DataSource = tbl;
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.KhoiLuongQuyDoi.GetByNamHocHocKyMaDonVi_Act(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tbl.Load(reader);
                tbl.Columns["SoLuong"].ReadOnly = false;
                tbl.Columns.Add(new DataColumn("Chon", typeof(Boolean)));
                bindingSourceKhoiLuongQuyDoi.DataSource = tbl;
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboDonVi_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.KhoiLuongQuyDoi.GetByNamHocHocKyMaDonVi_Act(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tbl.Load(reader);
                tbl.Columns["SoLuong"].ReadOnly = false;
                tbl.Columns.Add(new DataColumn("Chon", typeof(Boolean)));
                bindingSourceKhoiLuongQuyDoi.DataSource = tbl;
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Ham Quy Doi
        void QuyDoiTheoGiangVienLopHocPhan()
        {
            if (cboNamHoc.EditValue.ToString() == "" || cboHocKy.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn nằm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }

            DataTable tb = bindingSourceKhoiLuongQuyDoi.DataSource as DataTable;
            string xmlData = "";
            foreach (DataRow r in tb.Rows)
            {
                if (r["Chon"].ToString().ToLower() == "true")
                {
                    xmlData += String.Format("<Input M=\"{0}\" L=\"{1}\" HH=\"{2}\" HV=\"{3}\" LGV=\"{4}\" CS=\"{5}\" />"
                            , r["MaGiangVien"].ToString(), r["MaLopHocPhan"].ToString()
                            , PMS.Common.Globals.IsNull(r["MaHocHam"], "int").ToString()
                            , PMS.Common.Globals.IsNull(r["MaHocVi"], "int").ToString()
                            , PMS.Common.Globals.IsNull(r["MaLoaiGiangVien"], "int").ToString()
                            , "");
                }
            }

            if (xmlData == "")
            {
                XtraMessageBox.Show("Vui lòng chọn những dòng muốn quy đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            xmlData = String.Format("<Root>{0}</Root>", xmlData);

            using (frmXuLyQuyDoiGioiChuan frm = new frmXuLyQuyDoiGioiChuan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _maTruong, xmlData, 1))
            {
                frm.ShowDialog();
            }

            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        void QuyDoiTheoNamHocHocKyKhoa()
        {
            if (cboNamHoc.EditValue.ToString() == "" || cboHocKy.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn nằm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }

            using (frmXuLyQuyDoiGioiChuan frm = new frmXuLyQuyDoiGioiChuan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _maTruong, cboDonVi.EditValue.ToString()))
            {
                frm.ShowDialog();
            }

            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChonTatCa.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewKhoiLuongQuyDoi.DataRowCount; i++)
                {
                    gridViewKhoiLuongQuyDoi.SetRowCellValue(i, "Chon", "True");
                }
            }
            if (checkEditChonTatCa.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewKhoiLuongQuyDoi.DataRowCount; i++)
                {
                    gridViewKhoiLuongQuyDoi.SetRowCellValue(i, "Chon", "False");
                }
            }
        }
    }
}