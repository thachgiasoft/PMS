using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using PMS.BLL;
//using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using ExcelLibrary;
using DevExpress.Utils;
using PMS.Entities.Validation;
using Yogesh.Extensions;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.UI.Forms.NghiepVu.ChucNangCon;
using DevExpress.XtraBars;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmGiangVien : XtraForm
    {
        #region Variable
        private GiangVien objGiangVien;
        private ViewKhoaBoMon objDonvi;
        private DataSet dsGiangVien;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        private string groupname = UserInfo.GroupName;
        private bool user;
        bool flag;
        string _pwRandom = "";
        bool _khongDuocPhepCapNhat;
        #endregion

        private void khongDuocLuu(bool khongHienThi)
        {
            if (khongHienThi)
            {
                btnLuu.ItemShortcut = BarShortcut.Empty;
            }
            else
            {
                btnLuu.ItemShortcut = new BarShortcut(Shortcut.CtrlS);
            }
            btnLuu.Enabled = !khongHienThi;
        }

        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)  //Gọi bằng MethodInfo trong AppSystem.cs
        {
            _khongDuocPhepCapNhat = bool.Parse(value);
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ItemShortcut = BarShortcut.Empty;
                btnThem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnThem.ItemShortcut = BarShortcut.Empty;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoa.ItemShortcut = BarShortcut.Empty;
                btn_Excel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btn_Excel.ItemShortcut = BarShortcut.Empty;
                btnXoaQuyetDinh.Enabled = false;
                btn_Reset.Enabled = false;
                btnThayDoiLoaiGiangVien.Enabled = false;
                btnDoiHocHam.Enabled = false;
                btnDoiHocVi.Enabled = false;
                btnIncapAccount.Enabled = false;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnLuu.ItemShortcut = new BarShortcut(Shortcut.CtrlS);
                btnThem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnThem.ItemShortcut = new BarShortcut(Shortcut.CtrlN);
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.ItemShortcut = new BarShortcut(Shortcut.Del);
                btn_Excel.Visibility = BarItemVisibility.Always;
                btnXoaQuyetDinh.Enabled = true;
                btn_Reset.Enabled = true;
                btnThayDoiLoaiGiangVien.Enabled = true;
                btnDoiHocHam.Enabled = true;
                btnDoiHocVi.Enabled = true;
                btnIncapAccount.Enabled = true;
            }
        }
        #endregion

        #region KiemTraCapNhatHRM
        void KiemTraCapNhatHRM()
        {
            try
            {
                string _capNhatTuHRM = _cauHinhChung.Find(p => p.TenCauHinh == "Cập nhật thông tin giảng viên từ HRM").GiaTri.ToString();
                if (_capNhatTuHRM.ToLower() == "true")
                {
                    btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnLuu.ShortCut = Shortcut.None;

                    btnThem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnThem.ShortCut = Shortcut.None;

                    btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnXoa.ShortCut = Shortcut.None;

                    btn_Excel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btn_Excel.ShortCut = Shortcut.None;

                    btnXoaQuyetDinh.Enabled = false;
                    btn_Reset.Enabled = false;
                    btnThayDoiLoaiGiangVien.Enabled = false;
                    btnDoiHocHam.Enabled = false;
                    btnDoiHocVi.Enabled = false;
                    btnIncapAccount.Enabled = false;
                }
            }
            catch
            {
                
            }
           
        }
        #endregion

        #region Event Form
        public frmGiangVien()
        {
            InitializeComponent();
            TList<CauHinh> listCauHinh = DataServices.CauHinh.GetAll();
            if (listCauHinh != null)
            {
                foreach (CauHinh ch in listCauHinh)
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
            }
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri.ToString();
            if (_maTruong != "HVHQ")
                txtDangnhap.Properties.ReadOnly = true;
            if (UserInfo.User.ResetPassWordGv != true)
            {
                btn_Reset.Enabled = false;
                btnIncapAccount.Enabled = false;
            }

            if (_maTruong != "CDGTVT")
                xtraTabPageMocTangLuong.PageVisible = false;

            KiemTraCapNhatHRM();
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            xtraTabControl.SelectedTabPage = xtraTabControl.TabPages[0];

            #region khoa - bo mon
            VList<ViewKhoaBoMon> vKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            foreach (ViewKhoaBoMon v in vKhoaBoMon)
            {
                if (groupname == v.MaBoMon)
                {
                    user = true; break;
                }
            }
            #endregion

            if (_maTruong != "UTE") layoutControlItem65.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            #region ChucVu
            AppGridView.InitGridView(gridViewChucVu, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewChucVu, NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewChucVu, new string[] { "MaChucVu", "NgayHieuLuc", "NgayHetHieuLuc" },
                new string[] { "Tên chức vụ", "Ngày hiệu lực ", "Ngày hết hiệu lực" },
                new int[] { 300, 120, 120 });

            AppGridView.AlignHeader(gridViewChucVu, new string[] { "MaChucVu", "NgayHieuLuc", "NgayHetHieuLuc" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewChucVu, "MaChucVu", repositoryItemGridLookUpEditChucVu);

            #region Init Repo ChucVu
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditChucVu, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditChucVu, new string[] { "MaQuanLy", "TenChucVu" }, new string[] { "Mã chức vụ", "Tên chức vụ" }, new int[] { 150, 350 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditChucVu, 500, 700);
            repositoryItemGridLookUpEditChucVu.DisplayMember = "TenChucVu";
            repositoryItemGridLookUpEditChucVu.ValueMember = "MaChucVu";
            repositoryItemGridLookUpEditChucVu.NullText = string.Empty;
            #endregion

            #endregion

            #region Mốc tăng lương
            AppGridView.InitGridView(gridViewMocTangLuong, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewMocTangLuong, NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewMocTangLuong, new string[] { "MocTangLuong", "ThoiGianTangLuong", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }
                , new string[] { "Mốc tăng lương", "Thời gian tăng lương", "Ghi chú", "Ngày cập nhật", "Người cập nhật" }
                , new int[] { 150, 120, 180, 80, 80 });
            AppGridView.AlignHeader(gridViewMocTangLuong, new string[] { "MocTangLuong", "ThoiGianTangLuong", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewMocTangLuong, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion

            #region HoSoGiangVien
            AppGridView.InitGridView(gridViewHoSoGiangVien, true, true, GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewHoSoGiangVien, new string[] { "TenHoSo", "NgayCap", "Chon" },
                new string[] { "Tên hồ sơ", "Ngày cấp", "Chọn" },
                new int[] { 200, 100, 70 });
            AppGridView.ReadOnlyColumn(gridViewHoSoGiangVien, new string[] { "TenHoSo" });
            AppGridView.AlignHeader(gridViewHoSoGiangVien, new string[] { "Chon" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.UnSortField(gridViewHoSoGiangVien, new string[] { "Chon" });
            #endregion

            #region GiangVien
            AppGridView.InitGridView(gridViewGiangVien, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewGiangVien, new string[] { "MaQuanLy", "HoTen", "SoHieuCongChuc" },
                new string[] { "Mã GV", "Họ tên", "Mã công chức" },
                new int[] { 70, 150, 100 });
            AppGridView.ReadOnlyColumn(gridViewGiangVien);
            if (_maTruong != "UTE")
            {
                AppGridView.HideField(gridViewGiangVien, new string[] { "SoHieuCongChuc" });
            }
            AppGridView.SummaryField(gridViewGiangVien, "MaQuanLy", "Tổng = {0}", DevExpress.Data.SummaryItemType.Count);
            #endregion

            #region DonVi - KhoaBoMon
            AppGridLookupEdit.InitGridLookUp(gridLookUpEditDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(gridLookUpEditDonVi, 650, 300);
            AppGridLookupEdit.ShowField(gridLookUpEditDonVi, new string[] { "MaKhoa", "TenKhoa", "MaBoMon", "TenBoMon" }
                                        , new string[] { "Mã khoa", "Tên khoa", "Mã bộ môn", "Tên bộ môn" }
                                        , new int[] { 90, 210, 90, 210 });
            gridLookUpEditDonVi.Properties.DisplayMember = "TenBoMon";
            gridLookUpEditDonVi.Properties.ValueMember = "MaBoMon";
            gridLookUpEditDonVi.Properties.NullText = string.Empty;

            #endregion

            #region Clone DonVi - KhoaBoMon
            AppGridLookupEdit.InitGridLookUp(cboDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboDonVi, 650, 300);
            AppGridLookupEdit.ShowField(cboDonVi, new string[] { "MaKhoa", "TenKhoa", "MaBoMon", "TenBoMon" }, new string[] { "Mã khoa", "Tên khoa", "Mã bộ môn", "Tên bộ môn" }, new int[] { 90, 210, 90, 210 });
            cboDonVi.Properties.DisplayMember = "TenBoMon";
            cboDonVi.Properties.ValueMember = "MaBoMon";
            cboDonVi.Properties.NullText = string.Empty;

            #endregion

            #region Clone DonVi - KhoaBoMon giang day
            AppGridLookupEdit.InitGridLookUp(cboDonViGiangDay, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboDonViGiangDay, 650, 300);
            AppGridLookupEdit.ShowField(cboDonViGiangDay, new string[] { "MaKhoa", "TenKhoa", "MaBoMon", "TenBoMon" }, new string[] { "Mã khoa", "Tên khoa", "Mã bộ môn", "Tên bộ môn" }, new int[] { 90, 210, 90, 210 });
            cboDonViGiangDay.Properties.DisplayMember = "TenBoMon";
            cboDonViGiangDay.Properties.ValueMember = "MaBoMon";
            cboDonViGiangDay.Properties.NullText = string.Empty;

            #endregion

            #region TinhTrang
            AppGridLookupEdit.InitGridLookUp(gridLookUpEditTinhTrang, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(gridLookUpEditTinhTrang, new string[] { "MaQuanLy", "TenTinhTrang" }, new string[] { "Mã tình trạng", "Tình trạng" });
            gridLookUpEditTinhTrang.Properties.DisplayMember = "TenTinhTrang";
            gridLookUpEditTinhTrang.Properties.ValueMember = "MaTinhTrang";
            gridLookUpEditTinhTrang.Properties.NullText = string.Empty;
            #endregion

            #region TinhTrang Clone
            AppGridLookupEdit.InitGridLookUp(cboTinhTrang, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboTinhTrang, new string[] { "MaQuanLy", "TenTinhTrang" }, new string[] { "Mã tình trạng", "Tên tình trạng" });
            cboTinhTrang.Properties.DisplayMember = "TenTinhTrang";
            cboTinhTrang.Properties.ValueMember = "MaTinhTrang";
            cboTinhTrang.Properties.NullText = string.Empty;

            #endregion

            #region DanToc
            AppGridLookupEdit.InitGridLookUp(cboDanToc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDanToc, new string[] { "MaDanToc", "TenDanToc" }, new string[] { "Mã dân tộc", "Tên dân tộc" });
            cboDanToc.Properties.DisplayMember = "TenDanToc";
            cboDanToc.Properties.ValueMember = "MaDanToc";
            cboDanToc.Properties.NullText = string.Empty;
            #endregion

            #region TonGiao
            AppGridLookupEdit.InitGridLookUp(cboTonGiao, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboTonGiao, new string[] { "MaTonGiao", "TenTonGiao" }, new string[] { "Mã tôn giáo", "Tên tôn giáo" });
            cboTonGiao.Properties.DisplayMember = "TenTonGiao";
            cboTonGiao.Properties.ValueMember = "MaTonGiao";
            cboTonGiao.Properties.NullText = string.Empty;
            #endregion

            #region Clone HocHam
            AppGridLookupEdit.InitGridLookUp(gridLookUpEditHocHam, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(gridLookUpEditHocHam, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" });
            gridLookUpEditHocHam.Properties.DisplayMember = "TenHocHam";
            gridLookUpEditHocHam.Properties.ValueMember = "MaHocHam";
            gridLookUpEditHocHam.Properties.NullText = string.Empty;

            #endregion

            #region HocHam
            AppGridLookupEdit.InitGridLookUp(cboHocHam, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocHam, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" });
            cboHocHam.Properties.DisplayMember = "TenHocHam";
            cboHocHam.Properties.ValueMember = "MaHocHam";
            cboHocHam.Properties.NullText = string.Empty;
            #endregion

            #region HocVi
            AppGridLookupEdit.InitGridLookUp(cboHocVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocVi, new string[] { "MaQuanLy", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" });
            cboHocVi.Properties.DisplayMember = "TenHocVi";
            cboHocVi.Properties.ValueMember = "MaHocVi";
            cboHocVi.Properties.NullText = string.Empty;
            #endregion

            #region Clone HocVi
            AppGridLookupEdit.InitGridLookUp(gridLookUpEditHocVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(gridLookUpEditHocVi, new string[] { "MaQuanLy", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" });
            gridLookUpEditHocVi.Properties.DisplayMember = "TenHocVi";
            gridLookUpEditHocVi.Properties.ValueMember = "MaHocVi";
            gridLookUpEditHocVi.Properties.NullText = string.Empty;
            #endregion

            #region LoaiGiangVien
            AppGridLookupEdit.InitGridLookUp(cboLoaiGiangVien, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiGiangVien, new string[] { "MaQuanLy", "TenLoaiGiangVien" }, new string[] { "Mã loại giảng viên", "Tên loại giảng viên" });
            cboLoaiGiangVien.Properties.DisplayMember = "TenLoaiGiangVien";
            cboLoaiGiangVien.Properties.ValueMember = "MaLoaiGiangVien";
            cboLoaiGiangVien.Properties.NullText = string.Empty;
            #endregion

            #region Hesothulao
            //AppGridLookupEdit.InitGridLookUp(gridLookUpEditHesoThuLao, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            //AppGridLookupEdit.InitPopupFormSize(gridLookUpEditHesoThuLao, 300, 100);
            //AppGridLookupEdit.ShowField(gridLookUpEditHesoThuLao, new string[] { "MaThuLao", "HeSoThuLao", "TenHeSoThuLao" }, new string[] { "Mã thù lao", "Hệ số thù lao", "Tên loại thù lao" }, new int[] { 90, 80, 90 });
            //gridLookUpEditHesoThuLao.Properties.DisplayMember = "TenHeSoThuLao";
            //gridLookUpEditHesoThuLao.Properties.ValueMember = "MaThuLao";
            //gridLookUpEditHesoThuLao.Properties.NullText = string.Empty;
            #endregion

            #region BacLuong
            AppGridLookupEdit.InitGridLookUp(txtBacLuong, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(txtBacLuong, 300, 100);
            AppGridLookupEdit.ShowField(txtBacLuong, new string[] { "MaBacLuong", "TenBacLuong" }, new string[] { "Mã bậc lương", "Tên bậc lương" }, new int[] { 100, 100 });
            txtBacLuong.Properties.DisplayMember = "TenBacLuong";
            txtBacLuong.Properties.ValueMember = "MaBacLuong";
            txtBacLuong.Properties.NullText = string.Empty;
            #endregion

            #region Init CauHinh
            TList<CauHinh> listCauHinh = DataServices.CauHinh.GetAll() as TList<CauHinh>;
            if (listCauHinh != null)
            {
                foreach (CauHinh ch in listCauHinh)
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
            }
            #endregion

            #region Danh sach quyet dinh
            AppGridView.InitGridView(gridViewQuyetDinh, true, false, GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewQuyetDinh, new string[] { "LoaiQuyetDinh", "TenCu", "TenMoi", "NgayHieuLuc" }, new string[] { "Loại quyết định", "Vị trí cũ", "Vị trí mới", "Ngày hiệu lực" }, new int[] { 150, 150, 150, 150 });
            AppGridView.AlignHeader(gridViewQuyetDinh, new string[] { "LoaiQuyetDinh", "TenCu", "TenMoi", "NgayHieuLuc" }, HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewQuyetDinh);
            #endregion

            #region LoaiNhanVien
            AppGridLookupEdit.InitGridLookUp(cboLoaiNhanVien, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiNhanVien, new string[] { "MaQuanLy", "TenLoaiNhanVien" }, new string[] { "Mã loại nhân viên", "Tên loại nhân viên" });
            cboLoaiNhanVien.Properties.DisplayMember = "TenLoaiNhanVien";
            cboLoaiNhanVien.Properties.ValueMember = "MaLoaiNhanVien";
            cboLoaiNhanVien.Properties.NullText = string.Empty;
            #endregion

            #region Ngach
            AppGridLookupEdit.InitGridLookUp(cboNgachCongChuc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNgachCongChuc, new string[] { "MaQuanLy", "TenNgach" }, new string[] { "Mã ngạch", "Tên ngạch" });
            cboNgachCongChuc.Properties.DisplayMember = "TenNgach";
            cboNgachCongChuc.Properties.ValueMember = "MaNgachCongChuc";
            cboNgachCongChuc.Properties.NullText = string.Empty;
            #endregion

            #region TrinhDoChinhTri
            AppGridLookupEdit.InitGridLookUp(cboTrinhDoChinhTri, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboTrinhDoChinhTri, new string[] { "MaQuanLy", "TenTrinhDoChinhTri" }, new string[] { "Mã trình độ chính trị", "Tên trình độ chính trị" });
            cboTrinhDoChinhTri.Properties.DisplayMember = "TenTrinhDoChinhTri";
            cboTrinhDoChinhTri.Properties.ValueMember = "MaTrinhDoChinhTri";
            cboTrinhDoChinhTri.Properties.NullText = string.Empty;
            #endregion

            #region TrinhDoQuanLyNhaNuoc
            AppGridLookupEdit.InitGridLookUp(cboTrinhDoQuanLyNhaNuoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboTrinhDoQuanLyNhaNuoc, new string[] { "MaQuanLy", "TenTrinhDoQuanLyNhaNuoc" }, new string[] { "Mã trình độ quản lý nhà nước", "Tên trình độ quản lý nhà nước" });
            cboTrinhDoQuanLyNhaNuoc.Properties.DisplayMember = "TenTrinhDoQuanLyNhaNuoc";
            cboTrinhDoQuanLyNhaNuoc.Properties.ValueMember = "MaTrinhDoQuanLyNhaNuoc";
            cboTrinhDoQuanLyNhaNuoc.Properties.NullText = string.Empty;
            #endregion

            #region TrinhDoTinHoc
            AppGridLookupEdit.InitGridLookUp(cboTrinhDoTinHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboTrinhDoTinHoc, new string[] { "MaQuanLy", "TenTrinhDoTinHoc" }, new string[] { "Mã trình độ tin học", "Tên trình độ tin học" });
            cboTrinhDoTinHoc.Properties.DisplayMember = "TenTrinhDoTinHoc";
            cboTrinhDoTinHoc.Properties.ValueMember = "MaTrinhDoTinHoc";
            cboTrinhDoTinHoc.Properties.NullText = string.Empty;
            #endregion

            #region TrinhDoNgoaiNgu
            AppGridLookupEdit.InitGridLookUp(cboTrinhDoNgoaiNgu, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboTrinhDoNgoaiNgu, new string[] { "MaQuanLy", "TenTrinhDoNgoaiNgu" }, new string[] { "Mã trình độ ngoại ngữ", "Tên trình độ ngoại ngữ" });
            cboTrinhDoNgoaiNgu.Properties.DisplayMember = "TenTrinhDoNgoaiNgu";
            cboTrinhDoNgoaiNgu.Properties.ValueMember = "MaTrinhDoNgoaiNgu";
            cboTrinhDoNgoaiNgu.Properties.NullText = string.Empty;
            #endregion

            #region TrinhDoSuPham
            AppGridLookupEdit.InitGridLookUp(cboTrinhDoSuPham, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboTrinhDoSuPham, new string[] { "MaQuanLy", "TenTrinhDoSuPham" }, new string[] { "Mã trình độ sư phạm", "Tên trình độ sư phạm" });
            cboTrinhDoSuPham.Properties.DisplayMember = "TenTrinhDoSuPham";
            cboTrinhDoSuPham.Properties.ValueMember = "MaTrinhDoSuPham";
            cboTrinhDoSuPham.Properties.NullText = string.Empty;
            #endregion

            #region QuocTich
            AppGridLookupEdit.InitGridLookUp(cboQuocTich, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboQuocTich, new string[] { "MaQuocTich", "TenQuocTich" }, new string[] { "Mã quốc tịch", "Tên quốc tịch" });
            cboQuocTich.Properties.DisplayMember = "TenQuocTich";
            cboQuocTich.Properties.ValueMember = "Id";
            cboQuocTich.Properties.NullText = string.Empty;
            #endregion

            #region InitDataSource
            InitData();
            #endregion

            #region Khối kiến thức giảng dạy
            string[] itemValues = new string[] { "Khối kiến thức đại cương", "Khối kiến thức chuyên nghiệp" };
            foreach (string value in itemValues)
                checkedComboBoxEditKhoiKienThucGiangDay.Properties.Items.Add(value, CheckState.Unchecked, true);
            // Specify the separator character.
            checkedComboBoxEditKhoiKienThucGiangDay.Properties.SeparatorChar = ';';
            #endregion

            #region phân quyền ACT
            if (_maTruong.Equals("ACT"))
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnThem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                if (!_khongDuocPhepCapNhat)
                {
                    btnLuu.ItemShortcut = new BarShortcut(Shortcut.CtrlS);
                    btnThem.ItemShortcut = new BarShortcut(Shortcut.CtrlN);
                }
                btnLuu.Enabled = !_khongDuocPhepCapNhat;
            }
            #endregion
        }
        #endregion

        #region Init data
        private void InitData()
        {
            Cursor.Current = Cursors.WaitCursor;

            VList<ViewKhoaBoMon> vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            if (user == true)
            {
                vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(groupname);
                bindingSourceCloneDonVi.DataSource = vListKhoaBoMon.Copy();
                //vListKhoaBoMon = vListKhoaBoMon.FindAll(p => p.TenKhoa == groupname) as VList<ViewKhoaBoMon>;
            }
            else
            {
                vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
                bindingSourceCloneDonVi.DataSource = vListKhoaBoMon.Copy();
                vListKhoaBoMon.Insert(0, new ViewKhoaBoMon() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]", MaBoMon = "-1", TenBoMon = "[Tất cả]" });
            }
            //vListKhoaBoMon.Insert(0, new ViewKhoaBoMon() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]", MaBoMon = "-1", TenBoMon = "[Tất cả]" });
            bindingSourceDonVi.DataSource = vListKhoaBoMon;
            gridLookUpEditDonVi.Properties.ValueMember = "MaBoMon";
            gridLookUpEditDonVi.Properties.DisplayMember = "TenBoMon";

            AppGridLookupEdit.SetSelectedIndex(gridLookUpEditDonVi, 0);
            //gridLookUpEditDonVi.DataBindings.Clear();
            //gridLookUpEditDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);

            bindingSourceTinhTrang.DataSource = DataServices.TinhTrang.GetAll();

            gridLookUpEditTinhTrang.Properties.ValueMember = "MaTinhTrang";
            gridLookUpEditTinhTrang.Properties.DisplayMember = "TenTinhTrang";

            bindingSourceCloneTinhTrang.DataSource = ((TList<TinhTrang>)bindingSourceTinhTrang.DataSource).Clone();
            TList<TinhTrang> Ttinhtrang = DataServices.TinhTrang.GetAll();
            Ttinhtrang.Insert(0, new TinhTrang() { MaTinhTrang = -1, MaQuanLy = "-1", ThuTu = -1, TenTinhTrang = "[Tất cả]" });
            bindingSourceTinhTrang.DataSource = Ttinhtrang;
            AppGridLookupEdit.SetSelectedIndex(gridLookUpEditTinhTrang, 0);

            bindingSourceDanToc.DataSource = DataServices.ViewDanToc.GetAll();

            bindingSourceTonGiao.DataSource = DataServices.ViewTonGiao.GetAll();

            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();

            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();

            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();

            bindingSourceHoSoGiangVien.DataSource = DataServices.HoSo.GetAll();

            bindingSourceChucVu.DataSource = DataServices.ChucVu.GetAll();

            bindingSourceNhiemVuNCKH.DataSource = DataServices.NghienCuuKhoaHoc.GetAll();

            bindingSourceBacLuong.DataSource = DataServices.BacLuong.GetAll();
            //bindingSourceHeSoThuLao.DataSource = DataServices.ViewHeSoThuLao.GetAll();
            bindingSourceLoaiNhanVien.DataSource = DataServices.LoaiNhanVien.GetAll();
            bindingSourceNgachCongChuc.DataSource = DataServices.NgachCongChuc.GetAll();
            bindingSourceTrinhDoChinhTri.DataSource = DataServices.TrinhDoChinhTri.GetAll();
            bindingSourceTrinhDoQuanLyNhaNuoc.DataSource = DataServices.TrinhDoQuanLyNhaNuoc.GetAll();
            bindingSourceTrinhDoTinHoc.DataSource = DataServices.TrinhDoTinHoc.GetAll();
            bindingSourceTrinhDoNgoaiNgu.DataSource = DataServices.TrinhDoNgoaiNgu.GetAll();
            bindingSourceTrinhDoSuPham.DataSource = DataServices.TrinhDoSuPham.GetAll();

            bindingSourceQuocTich.DataSource = DataServices.QuocTich.GetAll();

            TList<HocHam> TlistHocHam = DataServices.HocHam.GetAll();
            TlistHocHam.Insert(0, new HocHam() { ThuTu = -1, MaHocHam = -1, MaQuanLy = "-1", TenHocHam = "[Tất cả]" });
            bindingSourceCloneHocHam.DataSource = TlistHocHam;
            gridLookUpEditHocHam.Properties.ValueMember = "MaHocHam";
            gridLookUpEditHocHam.Properties.DisplayMember = "TenHocHam";
            AppGridLookupEdit.SetSelectedIndex(gridLookUpEditHocHam, 0);

            TList<HocVi> TlistHocVi = DataServices.HocVi.GetAll();
            TlistHocVi.Insert(0, new HocVi() { ThuTu = -1, MaHocVi = -1, MaQuanLy = "-1", TenHocVi = "[Tất cả]" });
            bindingSourceCloneHocVi.DataSource = TlistHocVi;
            gridLookUpEditHocVi.Properties.ValueMember = "MaHocVi";
            gridLookUpEditHocVi.Properties.DisplayMember = "TenHocVi";
            AppGridLookupEdit.SetSelectedIndex(gridLookUpEditHocVi, 0);

            objGiangVien = new GiangVien();
            objGiangVien.GioiTinh = false;
            objGiangVien.DoanDang = false;
            bindingSourceGiangVien.DataSource = objGiangVien;
            txtTenGV.Text = "";
            
            Cursor.Current = Cursors.Default;
            
        }
        #endregion

        #region Function
        private void ThemMoi()
        {
            //ViewKhoaBoMon objDonvi = bindingSourceDonVi.Current as ViewKhoaBoMon;
            
            if (objDonvi.MaKhoa != "-1")
            {
                TList<GiangVien> list = DataServices.GiangVien.GetByMaDonVi(objDonvi.MaBoMon);
                TList<GiangVien> listGV = list.FindAll(p => PMS.Common.XuLyChuoi.SoSanhChuoi(0, objDonvi.MaKhoa.Length - 1, objDonvi.MaKhoa, p.MaQuanLy));
                //int count = DataServices.GiangVien.GetByMaDonVi(objDonvi.MaBoMon).Count;
                int count = listGV.Count;
                if (listGV.Count > 0)
                {
                    listGV.Sort("MaQuanLy");
                    GiangVien gv = listGV[count - 1];
                    string magv = gv.MaQuanLy;
                    string makhoa = gv.MaDonVi;

                    int sott;
                    try
                    {
                        if (_maTruong == "MTU")
                            sott = int.Parse(magv.Substring(makhoa.Length + 1)) + 1;
                        else
                            sott = int.Parse(magv.Substring(makhoa.Length)) + 1;
                    }
                    catch
                    {
                        sott = 1;
                    }

                    string maNhansu = string.Empty;
                    if (sott < 100) maNhansu = "0";
                    if (sott < 10) maNhansu = "00";
                    if (sott >= 100) maNhansu = "";

                    txtMaNhanSu.Text = objDonvi.MaBoMon.ToString() + maNhansu + (sott).ToString();
                    
                    if(_maTruong == "MTU")
                        txtMaNhanSu.Text = objDonvi.MaBoMon.ToString() + "." + maNhansu + (sott).ToString();
                    PMS.Common.Globals._matkhau = txtMaNhanSu.Text.Trim();
                    txtDangnhap.Text = PMS.Common.Globals._matkhau;

                    objGiangVien = new GiangVien();
                    objGiangVien.MaQuanLy = PMS.Common.Globals._matkhau;
                    objGiangVien.GioiTinh = false;
                    objGiangVien.DoanDang = false;
                    objGiangVien.MaNguoiLap = UserInfo.UserID;
                    objGiangVien.MatKhau = PMS.Common.Globals._matkhau;
                    bindingSourceGiangVien.DataSource = objGiangVien;
                }
                else
                {
                    string maNhansu = "001";
                    if (_maTruong == "MTU") maNhansu = ".001";
                    txtMaNhanSu.Text = objDonvi.MaBoMon.ToString() + maNhansu;

                    PMS.Common.Globals._matkhau = txtMaNhanSu.Text.Trim();
                    txtDangnhap.Text = PMS.Common.Globals._matkhau;

                    objGiangVien = new GiangVien();
                    objGiangVien.MaQuanLy = PMS.Common.Globals._matkhau;
                    objGiangVien.GioiTinh = false;
                    objGiangVien.DoanDang = false;
                    objGiangVien.MaNguoiLap = UserInfo.UserID;
                    objGiangVien.MatKhau = PMS.Common.Globals._matkhau;
                    bindingSourceGiangVien.DataSource = objGiangVien;
                }
                //FormsAuthentication.HashPasswordForStoringInConfigFile("UisStaffID=" + txtMaNhanSu.Text.Trim() + ";UisPassword=" + txtMaNhanSu.Text.Trim(), "MD5");
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn đơn vị cho giảng viên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gridLookUpEditDonVi.Focus();
            }
        }

        private void Luu()
        {
            gridViewHoSoGiangVien.FocusedRowHandle = -1;
            txtDangnhap.Focus();
            txtNgayCapNhat.Text = DateTime.Now.ToString();
            txtNguoiCapNhat.Text = UserInfo.User.TenDangNhap;
            TList<GiangVien> listGiangVien = bindingSourceChiTiet.DataSource as TList<GiangVien>;
            if (listGiangVien == null)
            {
                XtraMessageBox.Show("Vui lòng lọc dữ liệu giảng viên trước khi thêm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (objGiangVien != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bindingSourceGiangVien.EndEdit();
                        if (objGiangVien.IsValid)
                        {
                            if (objGiangVien.IsNew)
                            {

                                
                                int _kiemTraTrungTenCmnd = 0;
                                DataServices.GiangVien.KiemTraTrungTenCmnd(objGiangVien.HoTen, objGiangVien.Cmnd, ref _kiemTraTrungTenCmnd);
                                if (_kiemTraTrungTenCmnd == 1)
                                {
                                    if (XtraMessageBox.Show(string.Format("Trùng số chứng minh nhân dân {0} với giảng viên đã có trong hệ thống. Bạn có muốn tiếp tục lưu không?", objGiangVien.Cmnd), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                                    {
                                        return;
                                    }
                                }
                                if (_kiemTraTrungTenCmnd == 2)
                                {
                                    if (XtraMessageBox.Show(string.Format("Giảng viên {0} đã có tên trong hệ thống trong hệ thống. Bạn có muốn tiếp tục lưu không?", objGiangVien.HoTen), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                                    {
                                        return;
                                    }
                                }

                                if (_kiemTraTrungTenCmnd == 2)
                                {
                                    if (XtraMessageBox.Show(string.Format("Giảng viên {0} đã có tên trong hệ thống trong hệ thống. Bạn có muốn tiếp tục lưu không?", objGiangVien.HoTen), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                                    {
                                        return;
                                    }
                                }

                                if (_maTruong == "BUH" && gridLookUpEditHesoThuLao.Text == "")
                                {
                                    XtraMessageBox.Show("Chưa nhập hệ số lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;

                                }

                                if (objGiangVien.MaQuanLy != null && objGiangVien.MaQuanLy != "")
                                {
                                    if (objGiangVien.MaHocHam != null && objGiangVien.MaHocVi != null)
                                    {
                                        if (objGiangVien.MaLoaiGiangVien != null)
                                        {
                                            if (objGiangVien.MaDonVi != null)
                                            {
                                                GiangVien objktra = listGiangVien.Find(p => p.MaQuanLy.Trim() == objGiangVien.MaQuanLy.Trim());
                                                if (objktra == null)
                                                {
                                                    //objGiangVien.MatKhau = FormsAuthentication.HashPasswordForStoringInConfigFile("UisStaffID=" + PMS.Common.Globals._matkhau + ";UisPassword=" + 'A', "MD5");
                                                    objGiangVien.MatKhau = EncodeMD5(objGiangVien.MaQuanLy, ReturnPassword(objGiangVien.MaQuanLy, objGiangVien.HoTen));
                                                    listGiangVien.Add(objGiangVien);
                                                }
                                                else
                                                {
                                                    XtraMessageBox.Show("Mã giảng viên không được trùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    txtMaNhanSu.Focus();
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                XtraMessageBox.Show("Vui lòng định đơn vị cho giảng viên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                cboDonVi.Focus();
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            XtraMessageBox.Show("Vui lòng định mã loại giảng viên cho giảng viên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            cboLoaiGiangVien.Focus();
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("Vui lòng định học hàm, học vị cho giảng viên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        cboHocHam.Focus();
                                        return;
                                    }

                                    

                                }
                                else
                                {
                                    XtraMessageBox.Show("Mã giảng viên không được rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                            }

                            DataServices.GiangVien.Save(listGiangVien);
                            
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Them moi giang vien

                            objGiangVien = new GiangVien();
                            objGiangVien.GioiTinh = false;

                            bindingSourceGiangVien.DataSource = objGiangVien;
                            txtMaNhanSu.Focus();
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //}
            //else
            //{
            //    XtraMessageBox.Show("Không có dữ liệu để thực hiện thao tác lưu.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }
        private void Xoa()
        {
            TList<GiangVien> listGiangVien = bindingSourceChiTiet.DataSource as TList<GiangVien>;
            if (listGiangVien != null)
            {
                if (objGiangVien != null)
                {
                    if (XtraMessageBox.Show("Bạn muốn xóa giảng viên này? Mọi thông tin về giảng viên sẽ bị xóa. Bạn có chắc không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            listGiangVien.Remove(objGiangVien);
                            //DataServices.GiangVien.DeleteThongTinGiangVien(objGiangVien.MaGiangVien);
                            XtraMessageBox.Show("Bạn đã xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gridViewGiangVien.RefreshData();
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình xóa dữ liệu.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        private void LuuHoSo()
        {
            if (objGiangVien != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gridViewHoSoGiangVien.FocusedRowHandle = -1;
                    TList<HoSo> list = bindingSourceHoSoGiangVien.DataSource as TList<HoSo>;
                    foreach (HoSo d in list)
                    {
                        try
                        {
                            GiangVienHoSo obj = DataServices.GiangVienHoSo.GetByMaHoSoMaGiangVien(d.MaHoSo, objGiangVien.MaGiangVien);
                            if (d.Chon == true)
                            {
                                if (obj == null)
                                {
                                    obj = new GiangVienHoSo();
                                    obj.MaGiangVien = objGiangVien.MaGiangVien;
                                    obj.MaHoSo = d.MaHoSo;
                                }
                                //Cap nhat thong tin ho so.
                                obj.NgayCap = d.NgayCap;
                                DataServices.GiangVienHoSo.Save(obj);
                            }
                            else
                            {
                                if (obj != null)
                                    DataServices.GiangVienHoSo.Delete(obj);
                            }
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Lỗi cập nhật dữ liệu.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void LuuMocTangLuong()
        {
            if (objGiangVien != null)
            {
                gridViewMocTangLuong.FocusedRowHandle = -1;
                TList<GiangVienMocTangLuong> list = bindingSourceMocTangLuong.DataSource as TList<GiangVienMocTangLuong>;
                if (list != null)
                {
                    if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        try
                        {
                            if (list.IsValid)
                            {
                                foreach (GiangVienMocTangLuong g in list)
                                {
                                    g.MaGiangVien = objGiangVien.MaGiangVien;

                                }
                                bindingSourceMocTangLuong.EndEdit();
                                DataServices.GiangVienMocTangLuong.Save(list);
                                XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                XtraMessageBox.Show(string.Format("Có {0} dòng dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
            }
        }

        private void LuuChucVu()
        {
            if (objGiangVien != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gridViewChucVu.FocusedRowHandle = -1;
                    TList<GiangVienChucVu> list = bindingSourceGiangVienChucVu.DataSource as TList<GiangVienChucVu>;
                    string xmlData = "";
                    foreach (GiangVienChucVu cv in list)
                    {
                        string _ngayHieuLuc = "", _ngayHetHieuLuc = "";
                        if (cv.NgayHieuLuc != null)
                            _ngayHieuLuc = ((DateTime)cv.NgayHieuLuc).ToShortDateString();
                        if (cv.NgayHetHieuLuc != null)
                            _ngayHetHieuLuc = ((DateTime)cv.NgayHetHieuLuc).ToShortDateString();
                        xmlData += "<GiangVienChucVu MaQuanLy = \"" + cv.MaQuanLy.ToString()
                                    + "\" MaChucVu = \"" + cv.MaChucVu.ToString()
                                    + "\" NgayHieuLuc = \"" + _ngayHieuLuc
                                    + "\" NgayHetHieuLuc = \"" + _ngayHetHieuLuc
                                    + "\" NgayCapNhat = \"" + DateTime.Now.ToShortDateString()
                                    + "\" NguoiCapNhat = \"" + UserInfo.User.TenDangNhap
                                    + "\" />";
                    }
                    xmlData = "<Root>" + xmlData + "</Root>";
                    int kq = 0;

                    DataServices.GiangVienChucVu.Luu(xmlData, objGiangVien.MaGiangVien, ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Thao tác lưu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //TList<ChucVu> list = bindingSourceChucVu.DataSource as TList<ChucVu>;
                    //foreach (ChucVu d in list)
                    //{
                    //    GiangVienChucVu obj = DataServices.GiangVienChucVu.GetByMaGiangVienMaChucVu(objGiangVien.MaGiangVien, d.MaChucVu);
                    //    if (d.Chon == true)
                    //    {
                    //        try
                    //        {
                    //            if (obj == null)
                    //            {
                    //                obj = new GiangVienChucVu();
                    //                obj.MaGiangVien = objGiangVien.MaGiangVien;
                    //                obj.MaChucVu = d.MaChucVu;
                    //            }
                    //            //Cap nhat thong tin ngay nham chuc.
                    //            //obj.NgayHieuLuc = d.NgayHieuLuc;
                    //            //obj.NgayHetHieuLuc = d.NgayHetHieuLuc;
                    //            DataServices.GiangVienChucVu.Save(obj);
                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            XtraMessageBox.Show("Lỗi lưu dữ liệu.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //            return;
                    //        }
                    //    }
                    //    else
                    //    {
                    //        if (obj != null)
                    //            DataServices.GiangVienChucVu.Delete(obj);
                    //    }
                    //}
                    //XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private bool RuleCheckFormatTypeNgayHieuLuc(object target, ValidationRuleArgs e)
        {
            ChucVu obj = target as ChucVu;
            bool result = true;
            if (obj != null)
            {
                DateTime t;
                string ngayhieuluc = obj.NgayHieuLuc;
                string ngayhethieuluc = obj.NgayHetHieuLuc;

                if (!string.IsNullOrEmpty(obj.NgayHieuLuc))
                {
                    if (DateTime.TryParse(obj.NgayHieuLuc, out  t) == false)
                    {
                        result = false;
                    }
                }
                if (!string.IsNullOrEmpty(obj.NgayHetHieuLuc))
                {
                    if (DateTime.TryParse(obj.NgayHetHieuLuc, out  t) == false)
                    {
                        result = false;
                    }
                }
                if (!string.IsNullOrEmpty(obj.NgayHieuLuc) && !string.IsNullOrEmpty(obj.NgayHetHieuLuc))
                {
                    if (DateTime.TryParse(obj.NgayHetHieuLuc, out  t) == true && DateTime.TryParse(obj.NgayHieuLuc, out  t) == true)
                    {
                        TimeSpan t1 = DateTime.Parse(obj.NgayHetHieuLuc).Date - DateTime.Parse(obj.NgayHieuLuc).Date;
                        if (t1.Days < 0)
                        {
                            result = false;
                        }
                    }
                }

            }
            return result;
        }

        #region EncodeMD5(string userName, string password)
        public string EncodeMD5(string userName, string password)
        {
            string result = string.Empty;
            try
            {
                result = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile("UisStaffID=" + userName.ToUpper() + ";UisPassword=" + password, "MD5");
                string _maTruong = "";
                _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri.ToString();
                if (_maTruong == "BUH")
                    result = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5");
            }
            catch
            {
                result = string.Empty;
            }
            return result.ToLower();
        }
        #endregion

        #region ReturnPassword: trả về mật khẩu mặc định là mã giảng viên + tên viết tắt
        private string ReturnPassword(string _maGiangVien, string _hoTen)
        {
            string result = _maGiangVien;
            if (_maTruong == "UTE" || _maTruong == "CTIM" || _maTruong == "BUH" || _maTruong == "UFM")
            {
                foreach (string s in _hoTen.Split(' '))
                {
                    result += PMS.Common.Globals.ReplaceChar(s.Left(1)).ToLower();
                }
            }
            return result;
        }
        #endregion
        #endregion

        #region Event Button

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //ViewKhoaBoMon objDonvi = bindingSourceDonVi.Current as ViewKhoaBoMon;
            TinhTrang objTinhTrang = AppGridLookupEdit.GetSelectedItem(gridLookUpEditTinhTrang) as TinhTrang; //bindingSourceTinhTrang.Current as TinhTrang;
            HocHam objHocHam = AppGridLookupEdit.GetSelectedItem(gridLookUpEditHocHam) as HocHam; //bindingSourceCloneHocHam.Current as HocHam;
            HocVi objHocVi = AppGridLookupEdit.GetSelectedItem(gridLookUpEditHocVi) as HocVi;

            if (objDonvi != null && objTinhTrang != null && objHocHam != null && objHocVi != null)
            {
                bindingSourceChiTiet.DataSource = DataServices.GiangVien.GetMaDonViMaHocHamMaHocViMaTinhTrang(objDonvi.MaBoMon, objHocHam.MaHocHam, objHocVi.MaHocVi, objTinhTrang.MaTinhTrang.ToString());
                bindingSourceViewThongTinGiangVien.DataSource = DataServices.ViewThongTinChiTietGiangVien.GetByMaDonViMaHocHamMaHocViMaTinhTrang(objDonvi.MaBoMon, objHocHam.MaHocHam, objHocVi.MaHocVi, objTinhTrang.MaTinhTrang.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btn_Xuatfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel file (*.xls)|*.xls", ValidateNames = true })
            //{
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        try
            //        {
            //            gridControlGiangVien.ExportToXls(sfd.FileName);
            //            XtraMessageBox.Show("Bạn đã xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        catch (Exception ex)
            //        {
            //            XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            ////}

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_maTruong.Equals("ACT"))
            {
                khongDuocLuu(false);
            }
            ThemMoi();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xoa();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (xtraTabControl.SelectedTabPage.Name)
            {
                case "xtraTabPageThongTin":
                    Luu();
                    if (_maTruong.Equals("ACT"))
                    {
                        khongDuocLuu(_khongDuocPhepCapNhat);
                    }
                    break;
                case "xtraTabPageChucVu":
                    LuuChucVu();
                    break;
                case "xtraTabPageHoSo":
                    LuuHoSo();
                    break;
                case "xtraTabPageMocTangLuong":
                    LuuMocTangLuong();
                    break;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            GiangVien obj = bindingSourceGiangVien.DataSource as GiangVien;
            if (obj != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn Reset mật khẩu của giảng viên này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //DataServices.GiangVien.UpdatePassWord(obj.MaGiangVien);
                    obj.MatKhau = EncodeMD5(obj.MaQuanLy, obj.MaQuanLy);
                    //string pwUTE = obj.MaQuanLy + GetPassWordUTE(obj.HoTen);

                    //pwUTE = EncodeMD5(obj.MaQuanLy, pwUTE);
                    _pwRandom = GetPasswordRanDom();
                    string pwUTE = EncodeMD5(obj.MaQuanLy, _pwRandom);

                    try
                    {
                        if (_maTruong == "UTE")
                        {
                            DataServices.GiangVien.UpdatePassWord(obj.MaGiangVien, pwUTE);

                            VList<ViewThongTinGiangVien> vlist = DataServices.ViewThongTinGiangVien.GetByMaQuanLy(obj.MaQuanLy);
                            vlist[0].MatKhau = _pwRandom;
                            using (frmHienThiMatKhauSauKhiReset frm = new frmHienThiMatKhauSauKhiReset(vlist))
                            {
                                frm.ShowDialog();
                            }
                        }
                        else
                        {
                            DataServices.GiangVien.UpdatePassWord(obj.MaGiangVien, obj.MatKhau);
                        }
                    }
                    catch
                    {  }
                  
                }
            }
        }

        string GetPassWordUTE(string HoTen)
        {
            string s = "";
            foreach (string str in HoTen.Split(new char[] { ' ' }))
            {
                s += str.Trim().Left(1).ToLower();
            }

            return s;
        }

        string GetPasswordRanDom()
        {
            string s = "";

            //char[] MangKyTu = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', '_', '=', '{', '}', '[', ']', '|', ';', ':', '<', '>', ',', '.', '?', '/' };

            char[] MangKyTu = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

            Random fr = new Random();
            for (int i = 0; i < 16; i++)
            {
                int t = fr.Next(0, MangKyTu.Length);
                s += MangKyTu[t];
            }

            return s;

            //return new Random().Next(111111, 999999).ToString();
        }

        private void btnIncapAccount_Click(object sender, EventArgs e)
        {
            GiangVien gv = bindingSourceGiangVien.Current as GiangVien;
            if (gv != null)
            {
                VList<ViewThongTinGiangVien> vlist = DataServices.ViewThongTinGiangVien.GetByMaQuanLy(gv.MaQuanLy);
                using (PMS.UI.Forms.BaoCao.frmBaoCao frm = new BaoCao.frmBaoCao())
                {
                    if (PMS.Common.Globals._cauhinh != null)
                    {
                        frm.InCapAccount(PMS.Common.Globals._cauhinh.TenTruong.ToUpper(), vlist);
                        frm.ShowDialog();
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn giảng viên trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_ImportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmImportGiangVien frm = new frmImportGiangVien())
            {
                frm.ShowDialog();
            }
        }

        private void btn_ExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            VList<ViewThongTinChiTietGiangVien> listGiangVien = bindingSourceViewThongTinGiangVien.DataSource as VList<ViewThongTinChiTietGiangVien>;
            if (listGiangVien != null)
            {
                DataTable table = new DataTable();
                table.Columns.Add("MaQuanLy", typeof(string));
                table.Columns.Add("Ho", typeof(string));
                table.Columns.Add("TenDem", typeof(string));
                table.Columns.Add("Ten", typeof(string));

                table.Columns.Add("NgaySinh", typeof(string));
                table.Columns.Add("TenGioiTinh", typeof(string));
                table.Columns.Add("NoiSinh", typeof(string));
                table.Columns.Add("Cmnd", typeof(string));
                table.Columns.Add("NgayCap", typeof(string));
                table.Columns.Add("NoiCap", typeof(string));

                table.Columns.Add("DoanDang", typeof(bool));
                table.Columns.Add("NgayVaoDoanDang", typeof(string));
                table.Columns.Add("NgayKyHopDong", typeof(DateTime));
                table.Columns.Add("NgayKetThucHopDong", typeof(DateTime));
                table.Columns.Add("HinhAnh", typeof(string));

                table.Columns.Add("DiaChi", typeof(string));
                table.Columns.Add("ThuongTru", typeof(string));
                table.Columns.Add("NoiLamViec", typeof(string));
                table.Columns.Add("Email", typeof(string));
                table.Columns.Add("DienThoai", typeof(string));
                table.Columns.Add("SoDiDong", typeof(string));

                table.Columns.Add("SoTaiKhoan", typeof(string));
                table.Columns.Add("TenNganHang", typeof(string));
                table.Columns.Add("MaSoThue", typeof(string));
                table.Columns.Add("ChiNhanh", typeof(string));
                table.Columns.Add("SoSoBaoHiem", typeof(string));

                table.Columns.Add("ThoiGianBatDau", typeof(string));
                table.Columns.Add("BacLuong", typeof(decimal));
                table.Columns.Add("NgayHuongLuong", typeof(string));
                table.Columns.Add("NamLamViec", typeof(string));
                table.Columns.Add("ChuyenNganh", typeof(string));
                table.Columns.Add("MaHeSoThuLao", typeof(string));

                table.Columns.Add("MaDanToc", typeof(string));
                table.Columns.Add("TenDanToc", typeof(string));
                table.Columns.Add("MaTonGiao", typeof(string));
                table.Columns.Add("TenTonGiao", typeof(string));

                table.Columns.Add("MaDonVi", typeof(string));
                table.Columns.Add("TenDonVi", typeof(string));
                table.Columns.Add("MaHocHam", typeof(string));
                table.Columns.Add("TenHocHam", typeof(string));
                table.Columns.Add("MaHocVi", typeof(string));
                table.Columns.Add("TenHocVi", typeof(string));

                table.Columns.Add("MaLoaiGiangVien", typeof(string));
                table.Columns.Add("TenLoaiGiangVien", typeof(string));
                table.Columns.Add("MaTinhTrang", typeof(string));
                table.Columns.Add("TenTinhTrang", typeof(string));

                table.Columns.Add("TenDangNhap", typeof(string));
                table.Columns.Add("TenMayTinh", typeof(string));
                table.Columns.Add("MatKhau", typeof(string));
                foreach (ViewThongTinChiTietGiangVien obj in listGiangVien)
                {
            
                  
                    table.Rows.Add(
                        obj.MaQuanLy, obj.Ho, obj.TenDem, obj.Ten,
                        obj.NgaySinh, obj.TenGioiTinh, obj.NoiSinh, obj.Cmnd, obj.NgayCap, obj.NoiCap,
                        obj.DoanDang, obj.NgayVaoDoanDang, obj.NgayKyHopDong, obj.NgayKetThucHopDong, obj.HinhAnh,
                        obj.DiaChi, obj.ThuongTru, obj.NoiLamViec, obj.Email, obj.DienThoai, obj.SoDiDong,
                        obj.SoTaiKhoan, obj.TenNganHang, obj.MaSoThue, obj.ChiNhanh, obj.SoSoBaoHiem,
                        obj.ThoiGianBatDau, obj.BacLuong, obj.NgayHuongLuong, obj.NamLamViec, obj.ChuyenNganh, obj.MaHeSoThuLao,
                        obj.MaDanToc, obj.TenDanToc, obj.MaTonGiao, obj.TenTonGiao,
                        obj.MaDonVi, obj.TenDonVi, obj.MaHocHam, obj.TenHocHam, obj.MaHocVi, obj.TenHocVi,
                        obj.MaLoaiGiangVien, obj.TenLoaiGiangVien, obj.MaTinhTrang, obj.TenTinhTrang,
                        obj.TenDangNhap, obj.TenMayTinh, obj.MatKhau
                       );
                }
                dsGiangVien = new DataSet("DsGiangVien");
                dsGiangVien.Tables.Add(table);
                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "Excel file (*.xls)|*.xls";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        iloveit1208Library k = new iloveit1208Library();//Lib ExcelLibrary
                        k.ExportToExcel(dsGiangVien, f.FileName);
                        XtraMessageBox.Show("Đã xuất danh sách thành công.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Lỗi xuất dữ liệu.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            else
            {
                XtraMessageBox.Show("Chưa lọc danh sách giảng viên.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Cursor.Current = Cursors.Default;

        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            VList<ViewThongTinChiTietGiangVien> listGiangVien = bindingSourceViewThongTinGiangVien.DataSource as VList<ViewThongTinChiTietGiangVien>;
            if (listGiangVien != null)
            {
                using (BaoCao.frmBaoCao frm = new BaoCao.frmBaoCao())
                {
                    if (PMS.Common.Globals._cauhinh != null)
                    {
                        frm.InDanhSachGiangVien(PMS.Common.Globals._cauhinh.TenTruong.ToUpper(), listGiangVien);
                        frm.ShowDialog();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa cấu hình tên trường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa lọc danh sách giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnThayDoiLoaiGiangVien_Click(object sender, EventArgs e)
        {
            if (objGiangVien.MaGiangVien != 0)
            {
                frmDoiLoaiGiangVien frm = new frmDoiLoaiGiangVien(objGiangVien.MaGiangVien);
                frm.ShowDialog();
                bindingSourceQuyetDinh.DataSource = DataServices.ViewQuyetDinhDoiHocHamHocVi.GetByMaGiangVien(objGiangVien.MaGiangVien);
            }
        }

        private void btnDoiHocVi_Click(object sender, EventArgs e)
        {
            if (objGiangVien.MaGiangVien != 0)
            {
                frmDoiHocVi frm = new frmDoiHocVi(objGiangVien.MaGiangVien);
                frm.ShowDialog();
                bindingSourceQuyetDinh.DataSource = DataServices.ViewQuyetDinhDoiHocHamHocVi.GetByMaGiangVien(objGiangVien.MaGiangVien);
            }
        }

        private void btnXoaQuyetDinh_Click(object sender, EventArgs e)
        {
            if (bindingSourceQuyetDinh.DataSource != null)
            {
                ViewQuyetDinhDoiHocHamHocVi qd = bindingSourceQuyetDinh.Current as ViewQuyetDinhDoiHocHamHocVi;
                if (qd != null)
                {
                    if (XtraMessageBox.Show("Bạn thật sự muốn xóa quyết định?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        DataServices.ViewQuyetDinhDoiHocHamHocVi.DeleteByMaGiangVienNgayHieuLucLoaiQuyetDinh((int)qd.MaGiangVien, (DateTime)qd.NgayHieuLuc, qd.LoaiQuyetDinh);
                    XtraMessageBox.Show("Xóa quyết định thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    bindingSourceQuyetDinh.DataSource = DataServices.ViewQuyetDinhDoiHocHamHocVi.GetByMaGiangVien(objGiangVien.MaGiangVien);
                }
            }
        }

        private void btnDoiHocHam_Click(object sender, EventArgs e)
        {
            if (objGiangVien.MaGiangVien != 0)
            {
                frmDoiHocHam frm = new frmDoiHocHam(objGiangVien.MaGiangVien);
                frm.ShowDialog();
                bindingSourceQuyetDinh.DataSource = DataServices.ViewQuyetDinhDoiHocHamHocVi.GetByMaGiangVien(objGiangVien.MaGiangVien);
            }
        }

        //private void btnDoiChucVu_Click(object sender, EventArgs e)
        //{
        //    if (objGiangVien.MaGiangVien != 0)
        //    {
        //        frmDoiChucVu frm = new frmDoiChucVu(objGiangVien.MaGiangVien);
        //        frm.ShowDialog();
        //    }
        //}
        #endregion

        #region Event Grid
        private void gridViewChucVu_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            ChucVu obj = e.Row as ChucVu;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckFormatTypeNgayHieuLuc, "NgayHieuLuc");

                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show("Không đúng định dạng ngày 'dd/MM/yyyy' hoặc \n Ngày hết hiệu lực nhỏ hơn ngày có hiệu lực.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Valid = false;
                }
            }
        }

        private void gridViewHoSoGiangVien_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            HoSo obj = e.Row as HoSo;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckFormatTypeNgayCap, "NgayCap");

                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show("Không đúng định dạng ngày 'dd/MM/yyyy'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Valid = false;
                }
            }
        }

        private bool RuleCheckFormatTypeNgayCap(object target, ValidationRuleArgs e)
        {
            HoSo obj = target as HoSo;
            bool result = true;
            if (obj != null)
            {
                DateTime t;
                if (!string.IsNullOrEmpty(obj.NgayCap))
                {
                    if (DateTime.TryParse(obj.NgayCap, out  t) == false)
                    {
                        result = false;
                    }
                }

            }
            return result;
        }

        private void gridViewChucVu_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewChucVu, e);
        }

        private void gridViewGiangVien_Click(object sender, EventArgs e)
        {
            loadGiangVien();
        }
        #endregion

        #region Orther
        private void txtMaNhanSu_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            PMS.Common.Globals._matkhau = txtMaNhanSu.Text;
            txtDangnhap.Text = PMS.Common.Globals._matkhau;
        }
        #endregion

        #region Event Cbo
        private void cboHocHam_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (objGiangVien.IsNew)
                return;
            if (cboHocHam.Text != "")
            {
                if (XtraMessageBox.Show("Lưu ý, nếu học hàm bị sai thì có thể điều chỉnh tại đây.\n Nếu giảng viên có quyết định nâng học hàm thì phải ra quyết định cho giảng viên.\n Chuyển đến tab ra quyết định?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    flag = true;
                }
            }
        }
        private void cboHocHam_EditValueChanged(object sender, EventArgs e)
        {
            if (objGiangVien.IsNew)
                return;

            if (cboHocHam.Text != "" && flag)
            {
                flag = false;
                xtraTabControl.SelectedTabPage = xtraTabPageQuyetDinh;
            }
        }

        private void cboHocVi_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (objGiangVien.IsNew)
                return;
            if (cboHocVi.Text != "")
            {
                if (XtraMessageBox.Show("Lưu ý, nếu học vị bị sai thì có thể điều chỉnh tại đây.\n Nếu giảng viên có quyết định nâng học vị thì phải ra quyết định cho giảng viên.\n Chuyển đến tab ra quyết định?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    flag = true;
                }
            }
        }

        private void cboHocVi_EditValueChanged(object sender, EventArgs e)
        {
            if (objGiangVien.IsNew)
                return;

            if (cboHocVi.Text != "" && flag)
            {
                flag = false;
                xtraTabControl.SelectedTabPage = xtraTabPageQuyetDinh;
            }
        }

        private void cboLoaiGiangVien_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (objGiangVien.IsNew)
                return;
            if (cboLoaiGiangVien.Text != "")
            {
                if (XtraMessageBox.Show("Lưu ý, nếu loại giảng viên bị sai thì có thể điều chỉnh tại đây.\n Nếu giảng viên có quyết định thay đổi loại giảng viên thì phải ra quyết định cho giảng viên.\n Chuyển đến tab ra quyết định?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    flag = true;
                }
            }
        }

        private void cboLoaiGiangVien_EditValueChanged(object sender, EventArgs e)
        {
            if (objGiangVien.IsNew)
                return;

            if (cboLoaiGiangVien.Text != "" && flag)
            {
                flag = false;
                xtraTabControl.SelectedTabPage = xtraTabPageQuyetDinh;
            }
        }

        #endregion

        private void gridControlMocTangLuong_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewMocTangLuong, e);
        }

        private void gridViewMocTangLuong_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVien" || col.FieldName == "MocTangLuong" || col.FieldName == "ThoiGianTangLuong" || col.FieldName == "GhiChu")
            {
                int pos = e.RowHandle;
                gridViewMocTangLuong.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToString());
                gridViewMocTangLuong.SetRowCellValue(pos, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void txtNgaySinh_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(txtNgaySinh.Text) > DateTime.Now)
                {

                    XtraMessageBox.Show("Nhập năm sinh phải nhỏ hơn năm hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNgaySinh.Text = "";
                }
                
            }
            catch { }
           
        }

        private void gridViewGiangVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            loadGiangVien();
        }

        private void loadGiangVien()
        {
            if (bindingSourceChiTiet.DataSource != null)
            {
                GiangVien obj = bindingSourceChiTiet.Current as GiangVien;
                if (obj != null)
                {
                    txtTenGV.Text = obj.MaQuanLy + " - " + obj.HoTen;
                    objGiangVien = obj;
                    bindingSourceGiangVien.DataSource = obj;
                    txtDangnhap.Text = obj.MatKhau;

                    //Ho so giang vien
                    TList<HoSo> listHoSo = bindingSourceHoSoGiangVien.DataSource as TList<HoSo>;
                    TList<GiangVienHoSo> listHoSoGiangVien = DataServices.GiangVienHoSo.GetByMaGiangVien(obj.MaGiangVien);
                    foreach (HoSo d in listHoSo)
                    {

                        GiangVienHoSo objHoSo = listHoSoGiangVien.Find(p => p.MaHoSo == d.MaHoSo);
                        if (objHoSo != null)
                        {
                            d.NgayCap = objHoSo.NgayCap;
                            d.Chon = true;
                        }
                        else
                        {
                            d.Chon = false;
                            d.NgayCap = null;
                        }
                    }
                    listHoSo.AcceptChanges();
                    gridViewHoSoGiangVien.RefreshData();
                    //Chuc vu giang vien
                    TList<ChucVu> listChucVu = bindingSourceChucVu.DataSource as TList<ChucVu>;
                    TList<GiangVienChucVu> listChucVuGiangVien = DataServices.GiangVienChucVu.GetByMaGiangVien(obj.MaGiangVien);
                    bindingSourceGiangVienChucVu.DataSource = listChucVuGiangVien;

                    TList<GiangVienMocTangLuong> listMocTangLuongGiangVien = DataServices.GiangVienMocTangLuong.GetByMaGiangVien(obj.MaGiangVien);
                    bindingSourceMocTangLuong.DataSource = listMocTangLuongGiangVien;
                    //foreach (ChucVu d in listChucVu)
                    //{
                    //    GiangVienChucVu objChucVu = listChucVuGiangVien.Find(p => p.MaChucVu == d.MaChucVu);
                    //    if (objChucVu != null)
                    //    {
                    //        //d.NgayHieuLuc = objChucVu.NgayHieuLuc;
                    //        //d.NgayHetHieuLuc = objChucVu.NgayHetHieuLuc;
                    //        d.Chon = true;
                    //    }
                    //    else
                    //    {
                    //        d.Chon = false;
                    //        d.NgayHieuLuc = null;
                    //        d.NgayHetHieuLuc = null;
                    //    }
                    //}
                    listChucVu.AcceptChanges();
                    gridViewChucVu.RefreshData();
                    VList<ViewQuyetDinhDoiHocHamHocVi> vQuyetDinh = DataServices.ViewQuyetDinhDoiHocHamHocVi.GetByMaGiangVien(obj.MaGiangVien);
                    bindingSourceQuyetDinh.DataSource = vQuyetDinh;
                    gridViewQuyetDinh.RefreshData();
                }
            }
        }

        private void gridLookUpEditDonVi_EditValueChanged(object sender, EventArgs e)
        {
            objDonvi = bindingSourceDonVi[gridLookUpEditDonVi.Properties.GetIndexByKeyValue(gridLookUpEditDonVi.EditValue.ToString())] as ViewKhoaBoMon;
            //XtraMessageBox.Show(objDonvi.MaKhoa + "; " + objDonvi.MaBoMon);
        }
    }
}

