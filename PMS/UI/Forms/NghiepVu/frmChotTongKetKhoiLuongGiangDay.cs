using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmChotTongKetKhoiLuongGiangDay : XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnChotThanhToan.Enabled = false;
                btnHuyChot.Enabled = false;
            }
            else
            {
                btnChotThanhToan.Enabled = true;
                btnHuyChot.Enabled = true;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        string _maTruong, _dsMaTruong;
        bool _thanhToanTheoDot;

        #endregion

        #region Event Form
        public frmChotTongKetKhoiLuongGiangDay()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            try
            {
                _thanhToanTheoDot = bool.Parse(_cauHinhChung.Find(p => p.TenCauHinh == "Thanh toán giờ giảng theo nhiều đợt trong học kỳ").GiaTri);
            }
            catch
            {
                _thanhToanTheoDot = false;
            }
        }

        private void frmChotTongKetKhoiLuongGiangDay_Load(object sender, EventArgs e)
        {
            if (_thanhToanTheoDot)
            {
                layoutControlItemDotThanhToan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                layoutControlItemDotThanhToan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }

            _dsMaTruong = "USSH;UEL;CTIM;IUH;BUH;VHU;CDGTVT;LAW;HBU;DLU";

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
                case "LAW":
                    InitGridLaw();
                    break;
                case "HBU":
                    InitGridHBU();
                    break;
                case "DLU":
                    InitGridDLU();
                    break;
                default:
                    InitRemaining();
                    break;
            }

            AppGridView.FixedField(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);

            PMS.Common.Globals.WordWrapHeader(gridViewTongKet, 45);

            gridViewTongKet.GroupPanelText = "Gom nhóm bằng cách kéo tên cột thả vào đây";
            //gridViewTongKet.Columns["MaDonVi"].GroupIndex = 0;
            #endregion

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
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            if (_maTruong.Equals("ACT"))
            {
                #region Init Khoa-DonVi
                cboKhoa.Properties.SelectAllItemCaption = "Tất cả";
                cboKhoa.Properties.TextEditStyle = TextEditStyles.Standard;
                cboKhoa.Properties.Items.Clear();

                VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();

                _vListKhoaBoMon.Sort("TenKhoa");
                List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
                foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
                {
                    if (v.MaKhoa == v.MaBoMon)
                        _list.Add(new CheckedListBoxItem(v.MaKhoa, v.MaKhoa + " - " + v.TenKhoa, CheckState.Unchecked, true));
                }

                cboKhoa.Properties.Items.AddRange(_list.ToArray());
                cboKhoa.Properties.SeparatorChar = ';';
                cboKhoa.CheckAll();
                layoutControlItemKhoa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                #endregion
            }

            #region Bậc đào tạo
            cboBacDaoTao.Properties.SelectAllItemCaption = "Tất cả";
            cboBacDaoTao.Properties.TextEditStyle = TextEditStyles.Standard;
            cboBacDaoTao.Properties.Items.Clear();

            VList<ViewBacDaoTao> vListBacDaoTao = DataServices.ViewBacDaoTao.GetAll();
            vListBacDaoTao.Sort("TenBacDaoTao");
            List<CheckedListBoxItem> listBac = new List<CheckedListBoxItem>();
            for (int i = 0; i < vListBacDaoTao.Count; i++)
            {
                listBac.Add(new CheckedListBoxItem(vListBacDaoTao[i].MaBacDaoTao
                    , String.Format("{0} - {1}", vListBacDaoTao[i].MaBacDaoTao, vListBacDaoTao[i].TenBacDaoTao)
                    , CheckState.Unchecked, true));
            }
            cboBacDaoTao.Properties.Items.AddRange(listBac.ToArray());
            cboBacDaoTao.Properties.SeparatorChar = ';';
            cboBacDaoTao.CheckAll();
            #endregion

            #region Hệ đào tạo
            cboLoaiHinhDaoTao.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiHinhDaoTao.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiHinhDaoTao.Properties.Items.Clear();

            VList<ViewLoaiHinhDaoTao> vListLoaiHinhDaoTao = DataServices.ViewLoaiHinhDaoTao.GetAll();
            vListLoaiHinhDaoTao.Sort("TenLoaiHinh");
            List<CheckedListBoxItem> listLoaiHinh = new List<CheckedListBoxItem>();
            for (int i = 0; i < vListLoaiHinhDaoTao.Count; i++)
            {
                listLoaiHinh.Add(new CheckedListBoxItem(vListLoaiHinhDaoTao[i].MaLoaiHinh
                    , String.Format("{0} - {1}", vListLoaiHinhDaoTao[i].MaLoaiHinh, vListLoaiHinhDaoTao[i].TenLoaiHinh)
                    , CheckState.Unchecked, true));
            }
            cboLoaiHinhDaoTao.Properties.Items.AddRange(listLoaiHinh.ToArray());
            cboLoaiHinhDaoTao.Properties.SeparatorChar = ';';
            cboLoaiHinhDaoTao.CheckAll();
            #endregion

            #region DonVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDonVi, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDonVi, new string[] { "TenBoMon" }, new string[] { "Đơn vị" });
            repositoryItemGridLookUpEditDonVi.ValueMember = "MaBoMon";
            repositoryItemGridLookUpEditDonVi.DisplayMember = "TenBoMon";
            repositoryItemGridLookUpEditDonVi.NullText = string.Empty;
            #endregion

            #region HocHam
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocHam, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocHam, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" });
            repositoryItemGridLookUpEditHocHam.ValueMember = "MaHocHam";
            repositoryItemGridLookUpEditHocHam.DisplayMember = "TenHocHam";
            repositoryItemGridLookUpEditHocHam.NullText = string.Empty;
            #endregion

            #region HocVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocVi, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocVi, new string[] { "MaQuanLy", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" });
            repositoryItemGridLookUpEditHocVi.ValueMember = "MaHocVi";
            repositoryItemGridLookUpEditHocVi.DisplayMember = "TenHocVi";
            repositoryItemGridLookUpEditHocVi.NullText = string.Empty;
            #endregion

            #region LoaiGiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLoaiGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLoaiGiangVien, new string[] { "MaQuanLy", "TenLoaiGiangVien" }, new string[] { "Mã loại giảng viên", "Tên loại giảng viên" });
            repositoryItemGridLookUpEditLoaiGiangVien.ValueMember = "MaLoaiGiangVien";
            repositoryItemGridLookUpEditLoaiGiangVien.DisplayMember = "TenLoaiGiangVien";
            repositoryItemGridLookUpEditLoaiGiangVien.NullText = string.Empty;
            #endregion

            #region HinhThucDaoTao
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHinhThucDaoTao, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHinhThucDaoTao, new string[] { "MaHinhThucDaoTao", "TenHinhThucDaoTao" }, new string[] { "Mã hình thức đào tạo", "Tên hình thức đào tạo" });
            repositoryItemGridLookUpEditHinhThucDaoTao.ValueMember = "MaHinhThucDaoTao";
            repositoryItemGridLookUpEditHinhThucDaoTao.DisplayMember = "TenHinhThucDaoTao";
            repositoryItemGridLookUpEditHinhThucDaoTao.NullText = string.Empty;
            #endregion

            if(_maTruong.Equals("DLU"))
            {
                #region cbo Đợt thanh toán
                AppGridLookupEdit.InitGridLookUp(cboCauHinhChotGio, true, TextEditStyles.Standard);
                AppGridLookupEdit.ShowField(cboCauHinhChotGio, new string[] { "MaQuanLy", "TenQuanLy", "TuNgay", "DenNgay" }, new string[] { "Mã đợt", "Tên đợt", "Từ ngày", "Đến ngày" }, new int[] { 80, 100, 100, 100 });
                AppGridLookupEdit.InitPopupFormSize(cboCauHinhChotGio, 380, 650);
                cboCauHinhChotGio.Properties.ValueMember = "MaCauHinhChotGio";
                cboCauHinhChotGio.Properties.DisplayMember = "TenQuanLy";
                cboCauHinhChotGio.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Đợt thanh toán hiện tại").GiaTri;
                cboCauHinhChotGio.Properties.NullText = string.Empty;
                layoutControlItemDotThanhToan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                #endregion
            }

            InitData();
        }
        #endregion

        #region InitGrid()
        void InitGridUSSH()
        {
            AppGridView.InitGridView(gridViewTongKet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "MaLopHocPhan", "MaHinhThucDaoTao", "Nhom", "MaLop", "SiSo", "SoTietMonHoc", "SoTiet", "TenCoSo", "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi", "MaDonVi" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Loại giảng viên", "Mã môn học", "Tên môn học", "Loại học phần", "Mã lớp học phần", "Hình thức đào tạo", "Nhóm", "Mã lớp", "Sĩ số", "Số tiết môn học","Số tiết", "Cơ sở", "Hệ số lớp đông", "Hệ số cơ sở", "Hệ số quy đổi TH sang LT", "Tiết quy đổi", "Đơn vị" }
                    , new int[] { 90, 115, 55, 80, 80, 90, 80, 150, 80, 110, 100, 70, 80, 70,70, 70, 100, 100, 100, 110, 90, 120 });
            AppGridView.AlignHeader(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "MaLopHocPhan", "MaHinhThucDaoTao", "Nhom", "MaLop", "SiSo", "SoTietMonHoc", "SoTiet", "TenCoSo", "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi", "MaDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTongKet, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTongKet);
            AppGridView.FormatDataField(gridViewTongKet, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.RegisterControlField(gridViewTongKet, "MaDonVi", repositoryItemGridLookUpEditDonVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHinhThucDaoTao", repositoryItemGridLookUpEditHinhThucDaoTao);
        }

        void InitGridACT()
        {
            AppGridView.InitGridView(gridViewTongKet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "MaHinhThucDaoTao", "Nhom", "MaLop", "SiSo", "SoTiet", "TenCoSo", "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi", "MaDonVi" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Loại giảng viên", "Mã môn học", "Tên môn học", "Loại học phần", "Hình thức đào tạo", "Nhóm", "Mã lớp", "Sĩ số", "Số tiết", "Cơ sở", "Hệ số lớp đông", "Hệ số cơ sở", "Hệ số quy đổi TH sang LT", "Tiết quy đổi", "Đơn vị" }
                    , new int[] { 90, 115, 55, 80, 80, 90, 80, 150, 80, 100, 70, 80, 70, 70, 100, 100, 100, 110, 90, 120 });
            AppGridView.AlignHeader(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "MaHinhThucDaoTao", "Nhom", "MaLop", "SiSo", "SoTiet", "TenCoSo", "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi", "MaDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTongKet, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTongKet);
            AppGridView.FormatDataField(gridViewTongKet, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.RegisterControlField(gridViewTongKet, "MaDonVi", repositoryItemGridLookUpEditDonVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHinhThucDaoTao", repositoryItemGridLookUpEditHinhThucDaoTao);
        }

        void InitGridUEL()
        {
            AppGridView.InitGridView(gridViewTongKet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "Nhom", "MaLop", "SiSo", "SoTiet", "TenCoSo", "HeSoLopDong", "HeSoCoSo", "HeSoChucDanhChuyenMon", "HeSoClcCntn", "HeSoThinhGiangMonChuyenNganh", "DonGia", "DonGiaQuyDoi", "MaDonVi" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Loại giảng viên", "Mã môn học", "Tên môn học", "Loại học phần", "Nhóm", "Mã lớp", "Sĩ số", "Số tiết", "Cơ sở", "Hệ số lớp đông", "Hệ số địa điểm và ngoài giờ", "Hệ số chức danh chuyên môn", "Hệ số lớp CLC - CNTN", "Hệ số thỉnh giảng môn chuyên ngành", "Đơn giá", "Đơn giá quy đổi", "Đơn vị" }
                    , new int[] { 90, 115, 55, 80, 80, 90, 80, 150, 80, 100, 70, 80, 70, 70, 100, 150, 120, 120, 150, 80, 110, 120 });
            AppGridView.AlignHeader(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "Nhom", "MaLop", "SiSo", "SoTiet", "TenCoSo", "HeSoLopDong", "HeSoCoSo", "HeSoChucDanhChuyenMon", "HeSoClcCntn", "HeSoThinhGiangMonChuyenNganh", "DonGia", "DonGiaQuyDoi", "MaDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTongKet, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTongKet);
            AppGridView.FormatDataField(gridViewTongKet, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "DonGiaQuyDoi", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewTongKet, "MaDonVi", repositoryItemGridLookUpEditDonVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
        }

        void InitGridCTIM()
        {
            AppGridView.InitGridView(gridViewTongKet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc"
                    , "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoChucDanhChuyenMon", "HeSoTroCap"
                    , "HeSoLopDong", "HeSoThinhGiangMonChuyenNganh", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi", "MaDonVi" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Loại giảng viên", "Mã môn học", "Tên môn học"
                            , "Nhóm", "Mã lớp", "Sĩ số", "Số tiết", "Hệ số chức danh", "Hệ số trợ cấp"
                            , "Hệ số lớp đông", "Hệ số thỉnh giảng", "Hệ số thực hành", "Tiết quy đổi", "Đơn vị" }
                    , new int[] { 90, 115, 55, 80, 80, 80, 80, 150, 70, 80, 70, 70, 110, 100, 100, 110, 100, 90, 120 });
            AppGridView.AlignHeader(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien"
                    , "MaMonHoc", "TenMonHoc", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoChucDanhChuyenMon", "HeSoTroCap"
                    , "HeSoLopDong", "HeSoThinhGiangMonChuyenNganh", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi", "MaDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTongKet, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTongKet);
            AppGridView.FormatDataField(gridViewTongKet, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoChucDanhChuyenMon", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoThinhGiangMonChuyenNganh", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoQuyDoiThucHanhSangLyThuyet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.RegisterControlField(gridViewTongKet, "MaDonVi", repositoryItemGridLookUpEditDonVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
        }

        void InitGridIUH()
        {
            AppGridView.InitGridView(gridViewTongKet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoLopDong", "HeSoNgonNgu", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi", "MaDonVi" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Loại giảng viên", "Mã môn học", "Tên môn học", "Loại", "Nhóm", "Mã lớp", "Sĩ số", "Số tiết", "Hệ số lớp đông", "Hệ số ngôn ngữ", "Hệ số thực hành", "Tiết quy đổi", "Đơn vị" }
                    , new int[] { 90, 115, 55, 80, 80, 80, 80, 150, 60, 70, 80, 70, 90, 90, 80, 90, 90, 90 });
            AppGridView.AlignHeader(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoLopDong", "HeSoNgonNgu", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi", "MaDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTongKet, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTongKet);
            AppGridView.FormatDataField(gridViewTongKet, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.RegisterControlField(gridViewTongKet, "MaDonVi", repositoryItemGridLookUpEditDonVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
        }

        void InitGridBUH()
        {
            AppGridView.InitGridView(gridViewTongKet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "LoaiLop", "SiSo", "SoTiet"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "HeSoNgoaiGio", "HeSoLuong", "HeSoMonMoi", "TietQuyDoi", "MaDonVi" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Loại giảng viên", "Mã môn học", "Tên môn học", "Loại", "Nhóm", "Mã lớp", "Loại lớp", "Sĩ số", "Số tiết", "Hệ số chức danh", "Hệ số lớp đông", "Hệ số tỉnh (hs cơ sở)", "Hệ số ngoài giờ", "Hệ số lương", "Hệ số môn mới", "Tiết quy đổi", "Đơn vị" }
                    , new int[] { 90, 115, 55, 80, 80, 80, 80, 150, 60, 70, 80, 80, 70, 70, 90, 90, 80, 90, 90, 90, 90, 90 });
            AppGridView.AlignHeader(gridViewTongKet, new string[] {"MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "LoaiLop", "SiSo", "SoTiet"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "HeSoNgoaiGio", "HeSoLuong", "HeSoMonMoi", "TietQuyDoi", "MaDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTongKet, "MaQuanLy", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewTongKet, "SoTiet", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewTongKet, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewTongKet, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");

            AppGridView.ReadOnlyColumn(gridViewTongKet);

            AppGridView.FormatDataField(gridViewTongKet, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.RegisterControlField(gridViewTongKet, "MaDonVi", repositoryItemGridLookUpEditDonVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
        }

        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewTongKet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "Nhom", "MaLop", "SiSo", "SoTiet"
                                                                        , "HeSoLopDong", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoNgoaiGio", "HeSoCoSo", "HeSoClcCntn", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi", "MaDonVi" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Loại giảng viên", "Mã môn học", "Tên môn học", "Loại", "Nhóm", "Mã lớp", "Sĩ số", "Số tiết"
                                                                        , "HS lớp đông", "HS bậc đào tạo", "HS ngôn ngữ", "HS ngoài giờ", "HS cơ sở", "HS lớp CLC", "HS thực hành, TN, BT", "Tiết quy đổi", "Đơn vị" }
                    , new int[] { 90, 115, 55, 80, 80, 80, 80, 150, 60, 70, 80, 70, 70, 90, 90, 80, 90, 90, 90, 90, 90, 90 });
            AppGridView.AlignHeader(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "Nhom", "MaLop", "SiSo", "SoTiet"
                                                                        , "HeSoLopDong", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoNgoaiGio", "HeSoCoSo", "HeSoClcCntn", "HeSoQuyDoiThucHanhSangLyThuyet", "TietQuyDoi", "MaDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTongKet, "MaQuanLy", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewTongKet, "SoTiet", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewTongKet, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewTongKet, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");

            AppGridView.ReadOnlyColumn(gridViewTongKet);

            AppGridView.FormatDataField(gridViewTongKet, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.RegisterControlField(gridViewTongKet, "MaDonVi", repositoryItemGridLookUpEditDonVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
        }

        void InitGridCDGTVT()
        {
            AppGridView.InitGridView(gridViewTongKet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoBacDaoTao", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoTroCap", "TietQuyDoi", "MaDonVi" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Loại giảng viên", "Mã học phần", "Tên học phần", "Loại", "Nhóm", "Mã lớp", "Sĩ số", "Số tiết", "Hệ số bậc đào tạo", "Hệ số lớp đông", "Hệ số môn thực tập", "Hệ số CVHT", "Tiết quy đổi", "Đơn vị" }
                    , new int[] { 90, 115, 55, 80, 80, 80, 80, 150, 60, 70, 80, 70, 70, 90, 90, 90, 90, 90, 90 });
            AppGridView.AlignHeader(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoBacDaoTao", "HeSoLopDong", "HeSoQuyDoiThucHanhSangLyThuyet", "HeSoTroCap", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTongKet, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTongKet);
            AppGridView.FormatDataField(gridViewTongKet, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoQuyDoiThucHanhSangLyThuyet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoTroCap", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoBacDaoTao", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.RegisterControlField(gridViewTongKet, "MaDonVi", repositoryItemGridLookUpEditDonVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
        }

        void InitGridLaw()
        {
            AppGridView.InitGridView(gridViewTongKet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "LoaiHocPhan", "Nhom", "MaLop", "MaBacDaoTao", "SiSo", "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "SoTiet", "HeSoNienCheTinChi", "HeSoTroCap", "SoTietThucTeQuyDoi", "MucThanhToan", "TietQuyDoi", "MaDonVi" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Loại giảng viên", "Mã môn học", "Tên môn học", "Mã lớp học phần", "Loại", "Nhóm", "Mã lớp", "Bậc đào tạo", "Sĩ số", "Hệ số công việc", "Hệ số bậc đào tạo", "Hệ số ngôn ngữ", "Hệ số chức danh chuyên môn", "Hệ số lớp đông", "Hệ số cơ sở", "Tiết thực dạy", "Hệ số niên chế/tín chỉ", "Hệ số cao học tính thêm", "Tiết thực tế quy đổi", "Mức thanh toán (%)", "Tiết quy đổi", "Đơn vị" }
                    , new int[] { 90, 115, 55, 80, 80, 80, 80, 150, 100, 60, 70, 80, 80, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 80, 90, 80, 150 });
            AppGridView.AlignHeader(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "LoaiHocPhan", "Nhom", "MaLop", "MaBacDaoTao", "SiSo", "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "SoTiet", "HeSoNienCheTinChi", "HeSoTroCap", "SoTietThucTeQuyDoi", "MucThanhToan", "TietQuyDoi", "MaDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTongKet, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTongKet);
            AppGridView.FormatDataField(gridViewTongKet, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoNienCheTinChi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "SoTietThucTeQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoTroCap", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.RegisterControlField(gridViewTongKet, "MaDonVi", repositoryItemGridLookUpEditDonVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
        }

        void InitGridHBU()
        {
            AppGridView.InitGridView(gridViewTongKet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "Nhom", "MaLop", "SiSo", "SoTiet"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoNgoaiGio", "HeSoKhoiNganh", "TietQuyDoi", "MaDonVi" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Loại giảng viên", "Mã môn học", "Tên môn học", "Loại", "Nhóm", "Mã lớp", "Sĩ số", "Số tiết"
                                                                        , "HS chức danh", "HS lớp đông", "HS bậc đào tạo", "HS ngôn ngữ", "HS ngoài giờ", "HS khối ngành", "Tiết quy đổi", "Đơn vị" }
                    , new int[] { 90, 115, 55, 80, 80, 80, 80, 150, 60, 70, 80, 70, 70, 90, 90, 80, 90, 90, 90, 90, 90 });
            AppGridView.AlignHeader(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "Nhom", "MaLop", "SiSo", "SoTiet"
                                                                        , "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoNgoaiGio", "HeSoKhoiNganh", "TietQuyDoi", "MaDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTongKet, "MaQuanLy", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewTongKet, "SoTiet", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewTongKet, "TietQuyDoi", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewTongKet, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");

            AppGridView.ReadOnlyColumn(gridViewTongKet);

            AppGridView.FormatDataField(gridViewTongKet, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.RegisterControlField(gridViewTongKet, "MaDonVi", repositoryItemGridLookUpEditDonVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
        }


        void InitGridDLU()
        {
            AppGridView.InitGridView(gridViewTongKet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoBacDaoTao", "TietQuyDoi", "DonGia", "TongThanhTien", "MaDonVi" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Loại giảng viên", "Mã môn học", "Tên môn học", "Loại", "Nhóm", "Mã lớp", "Sĩ số", "Số tiết", "Hệ số chức danh", "Hệ số lớp đông", "Hệ số Bậc đào tạo", "Tiết quy đổi", "Đơn giá", "Thành tiền", "Đơn vị" }
                    , new int[] { 90, 115, 55, 80, 80, 80, 80, 150, 60, 70, 80, 70, 70, 90, 90, 80, 90, 90, 90, 90 });
            AppGridView.AlignHeader(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoBacDaoTao", "TietQuyDoi", "DonGia", "TongThanhTien", "MaDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTongKet, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTongKet);
            AppGridView.FormatDataField(gridViewTongKet, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoChucDanhChuyenMon", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoBacDaoTao", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "TongThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.RegisterControlField(gridViewTongKet, "MaDonVi", repositoryItemGridLookUpEditDonVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
        }

        void InitRemaining()//UTE
        {
            AppGridView.InitGridView(gridViewTongKet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoLopDong", "HeSoHocKy", "DonGia", "TongThanhTien", "TietQuyDoi", "MaDonVi" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Học hàm", "Học vị", "Loại giảng viên", "Mã môn học", "Tên môn học", "Loại", "Nhóm", "Mã lớp", "Sĩ số", "Số tiết", "Hệ số lớp đông", "Hệ số học kỳ", "Đơn giá", "Thành tiền", "Tiết quy đổi", "Đơn vị" }
                    , new int[] { 90, 115, 55, 80, 80, 80, 80, 150, 60, 70, 80, 70, 70, 90, 90, 80, 90, 90, 90 });
            AppGridView.AlignHeader(gridViewTongKet, new string[] { "MaQuanLy", "Ho", "Ten", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoLopDong", "HeSoHocKy", "DonGia", "TongThanhTien", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTongKet, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTongKet);
            AppGridView.FormatDataField(gridViewTongKet, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "HeSoHocKy", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongKet, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "TongThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongKet, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.RegisterControlField(gridViewTongKet, "MaDonVi", repositoryItemGridLookUpEditDonVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewTongKet, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewTongKet, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            bindingSourceDonVi.DataSource = DataServices.ViewKhoaBoMon.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            bindingSourceHinhThucDaoTao.DataSource = DataServices.HinhThucDaoTao.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceCauHinhChotGio.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            LoadDataSource();
        }

        void LoadDataSource()
        {
            try
            {
                DataTable tb;
                IDataReader reader;

                if (_maTruong.Equals("ACT"))
                {
                    if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoa.EditValue != null)
                    {
                        tb = new DataTable();
                        reader = DataServices.ViewLietKeKhoiLuongGiangDayChiTietUssh.GetByNamHocHocKyKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoa.EditValue.ToString());
                        tb.Load(reader);
                        bindingSourceTongKet.DataSource = tb;
                        DataServices.KetQuaThanhToanThuLao.GetSoLanChotTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoa.EditValue.ToString(), ref lanchot);
                    }
                }
                else if (_thanhToanTheoDot)
                {
                    if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboCauHinhChotGio.EditValue != null)
                    {
                        tb = new DataTable();
                        reader = DataServices.ViewLietKeKhoiLuongGiangDayChiTietUssh.GetByBacLoaiHinhNamHocHocKyDot(cboBacDaoTao.EditValue.ToString(),cboLoaiHinhDaoTao.EditValue.ToString(),cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboCauHinhChotGio.EditValue.ToString()));
                        tb.Load(reader);
                        bindingSourceTongKet.DataSource = tb;
                        DataServices.KetQuaThanhToanThuLao.GetSoLanChotTheoDot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboCauHinhChotGio.EditValue.ToString()), cboBacDaoTao.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString(), ref lanchot);
                    }
                }
                else
                {
                    if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    {
                        //if (_maTruong == "USSH" || _maTruong == "UEL" || _maTruong == "CTIM" || _maTruong == "IUH")
                        if (_dsMaTruong.Contains(_maTruong))
                        {
                            tb = new DataTable();
                            reader = DataServices.ViewLietKeKhoiLuongGiangDayChiTietUssh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                            tb.Load(reader);
                            bindingSourceTongKet.DataSource = tb;
                        }
                        else//UTE
                            bindingSourceTongKet.DataSource = DataServices.ViewLietKeKhoiLuongGiangDayChiTiet.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                        DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                    }
                }
                txtSoLanChot.Text = lanchot.ToString();
                gridViewTongKet.ExpandAllGroups();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceCauHinhChotGio.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            LoadDataSource();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceCauHinhChotGio.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            LoadDataSource();
        }
        #endregion

        #region Ham Chot
        void ChotTheoDot()
        {
            int ktra = 0;
            DataServices.GiangVienTamUng.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboCauHinhChotGio.EditValue.ToString()), ref ktra);
            if (ktra == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} - {2} đã thanh toán. Không thể tiếp tục chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboCauHinhChotGio.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bindingSourceTongKet.Count > 0)
            {
                int kq = 0;
                DataServices.KetQuaThanhToanThuLao.GetSoLanChotTheoDot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboCauHinhChotGio.EditValue.ToString()), cboBacDaoTao.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString(), ref lanchot);
                lanchot++;
                if (XtraMessageBox.Show(string.Format("Chốt khối lượng giảng dạy năm học {0} - {1} - {2} lần thứ {3}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboCauHinhChotGio.Text, lanchot), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        DataServices.KetQuaThanhToanThuLao.ChotThanhToanTheoDot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboCauHinhChotGio.EditValue.ToString()), cboBacDaoTao.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString(), lanchot, ref kq);
                        DataServices.KetQuaThanhToanThuLao.GetSoLanChotTheoDot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboCauHinhChotGio.EditValue.ToString()), cboBacDaoTao.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString(), ref lanchot);
                        txtSoLanChot.Text = lanchot.ToString();
                        if (kq == 0)
                            XtraMessageBox.Show("Chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Cursor.Current = Cursors.Default;
                }
            }
        }

        void ChotTheoNamHocHocKy()
        {
            if (bindingSourceTongKet.Count > 0)
            {
                int kq = 0;
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                lanchot++;
                if (XtraMessageBox.Show(string.Format("Chốt khối lượng giảng dạy năm học {0} - {1} lần thứ {2}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), lanchot), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        DataServices.KetQuaThanhToanThuLao.ChotThanhToan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), lanchot, ref kq);
                        DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                        txtSoLanChot.Text = lanchot.ToString();
                        if (kq == 0)
                            XtraMessageBox.Show("Chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Cursor.Current = Cursors.Default;
                }
            }
        }

        void ChotTheoNamHocHocKyKhoaDonVi()
        {
            if (bindingSourceTongKet.Count > 0)
            {
                int kq = 0;
                DataServices.KetQuaThanhToanThuLao.GetSoLanChotTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoa.EditValue.ToString(), ref lanchot);
                lanchot++;
                if (XtraMessageBox.Show(string.Format("Chốt khối lượng giảng dạy năm học {0} - {1} lần thứ {2} cho đơn vị:\n{3}\n?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), lanchot, cboKhoa.Text), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        DataServices.KetQuaThanhToanThuLao.ChotThanhToanKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoa.EditValue.ToString(), lanchot, ref kq);
                        DataServices.KetQuaThanhToanThuLao.GetSoLanChotTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoa.EditValue.ToString(), ref lanchot);
                        txtSoLanChot.Text = lanchot.ToString();
                        if (kq == 0)
                            XtraMessageBox.Show("Chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình chốt dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }
        private void btnChotThanhToan_Click(object sender, EventArgs e)
        {
            if (_thanhToanTheoDot)
                ChotTheoDot();
            else if (_maTruong.Equals("ACT"))
                ChotTheoNamHocHocKyKhoaDonVi();
            else
                ChotTheoNamHocHocKy();
        }

        private void btnHuyChot_Click(object sender, EventArgs e)
        {
            if (_thanhToanTheoDot)
                HuyChotTheoDot();
            else if (_maTruong.Equals("ACT"))
                HuyChotTheoNamHocHocKyKhoaDonVi();
            else
                HuyChotTheoNamHocHocKy();
        }
        #endregion

        #region HamHuy Chot
        void HuyChotTheoNamHocHocKy()
        {
            if (lanchot > 0)
            {
                using (frmHuyChotThuLao frm = new frmHuyChotThuLao(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), lanchot))
                {
                    frm.ShowDialog();
                }
                InitData();
            }
            else
            {
                XtraMessageBox.Show("Không thể huỷ do chưa chốt lần nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void HuyChotTheoNamHocHocKyKhoaDonVi()
        {
            if (lanchot > 0)
            {
                using (frmHuyChotThuLao frm = new frmHuyChotThuLao(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoa.EditValue.ToString(), lanchot))
                {
                    frm.ShowDialog();
                }
                InitData();
            }
            else
            {
                XtraMessageBox.Show("Không thể huỷ do chưa chốt lần nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void HuyChotTheoDot()
        {
            int kq = 0;
            DataServices.GiangVienTamUng.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboCauHinhChotGio.EditValue.ToString()), ref kq);
            if (kq == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} - {2} đã thanh toán. Không thể huỷ chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboCauHinhChotGio.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lanchot > 0)
            {
                using (frmHuyChotThuLao frm = new frmHuyChotThuLao(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboCauHinhChotGio.EditValue.ToString()), cboCauHinhChotGio.Text, lanchot))
                {
                    frm.ShowDialog();
                }
                InitData();
            }
            else
            {
                XtraMessageBox.Show("Không thể huỷ do chưa chốt lần nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlTongKet.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void gridViewTongKet_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (_maTruong == "LAW")
                {
                    if (e.Column.FieldName == "HeSoNienCheTinChi")
                    {
                        if (Convert.ToDouble(e.Value) == 1.111111)
                            e.DisplayText = "50/45";
                    }
                    if (e.Column.FieldName == "HeSoTroCap")
                    {
                        if (Convert.ToDouble(e.Value) == 1.333333)
                            e.DisplayText = "20/15";
                    }
                }
            }
            catch
            { }
        }

        private void cboCauHinhChotGio_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void cboBacDaoTao_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void cboLoaiHinhDaoTao_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void cboKhoa_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoa.EditValue != null)
            {
                if (!_thanhToanTheoDot || cboCauHinhChotGio.EditValue != null)
                    LoadDataSource();
            }
        }

    }
}
