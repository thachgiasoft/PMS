using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using PMS.BLL;
using System.Collections.Generic;
using System.Data;
using ExcelLibrary;
using DevExpress.Utils;
using PMS.Entities.Validation;
using Yogesh.Extensions;
using Yogesh.ExcelXml;
using GemBox.Spreadsheet;
using System.Text;
using System.Runtime.Serialization;
using System.Web.Security;
using System.Xml;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using System.Globalization;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmGiangVienChoDuyetHoSo : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;

                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoa.ShortCut = Shortcut.None;

                btnDuyetHoSo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDuyetHoSo.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnDuyetHoSo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        private GiangVienChoDuyetHoSo objGiangVien;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        int _maLoaiGiangVienThinhGiang;
        private string groupname = UserInfo.GroupName;
        private bool user = false;
        #endregion

        #region Event Form
        public frmGiangVienChoDuyetHoSo()
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
            switch (_maTruong)
            {
                case "IUH": _maLoaiGiangVienThinhGiang = 17; break;
                case "VHU": _maLoaiGiangVienThinhGiang = 15; break;
                default: _maLoaiGiangVienThinhGiang = 1; break;
            }
        
        }

        private void frmGiangVienChoDuyetHoSo_Load(object sender, EventArgs e)
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

            if (user)
            {
                btnDuyetHoSo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else
            {
                btnDuyetHoSo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }

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
            AppGridLookupEdit.ShowField(gridLookUpEditDonVi, new string[] { "MaKhoa", "TenKhoa", "MaBoMon", "TenBoMon" }, new string[] { "Mã khoa", "Tên khoa", "Mã bộ môn", "Tên bộ môn" }, new int[] { 90, 210, 90, 210 });
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
         
            #region InitDataSource
            InitData();
            #endregion

            #region Khối kiến thức giảng dạy
            string[] itemValues = new string[] { "Khối kiến thức đại cương", "Khối kiến thức chuyên nghiệp" };
            foreach (string value in itemValues)
                checkedComboBoxEditKhoiKienThucGiangDay.Properties.Items.Add(value, CheckState.Unchecked, true);
            checkedComboBoxEditKhoiKienThucGiangDay.Properties.SeparatorChar = ';';
            #endregion

            btnLoc.PerformClick();
        }
        #endregion

        #region InitData()
        private void InitData()
        {
            Cursor.Current = Cursors.WaitCursor;

            VList<ViewKhoaBoMon> vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            if (user == true)
            {
                vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(groupname);
            }
            else
            {
                vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
                vListKhoaBoMon.Insert(0, new ViewKhoaBoMon() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]", MaBoMon = "-1", TenBoMon = "[Tất cả]" });
            }

            bindingSourceCloneDonVi.DataSource = vListKhoaBoMon.Copy();

            bindingSourceDonVi.DataSource = vListKhoaBoMon;
            gridLookUpEditDonVi.DataBindings.Clear();
            gridLookUpEditDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);

            bindingSourceTinhTrang.DataSource = DataServices.TinhTrang.GetAll();

            gridLookUpEditTinhTrang.DataBindings.Clear();
            gridLookUpEditTinhTrang.DataBindings.Add("EditValue", bindingSourceTinhTrang, "MaTinhTrang", true, DataSourceUpdateMode.OnPropertyChanged);


            bindingSourceCloneTinhTrang.DataSource = ((TList<TinhTrang>)bindingSourceTinhTrang.DataSource).Clone();
            TList<TinhTrang> Ttinhtrang = DataServices.TinhTrang.GetAll();
            Ttinhtrang.Insert(0, new TinhTrang() { MaTinhTrang = -1, MaQuanLy = "-1", ThuTu = -1, TenTinhTrang = "--Tất cả--" });
            bindingSourceTinhTrang.DataSource = Ttinhtrang;

            bindingSourceDanToc.DataSource = DataServices.ViewDanToc.GetAll();

            bindingSourceTonGiao.DataSource = DataServices.ViewTonGiao.GetAll();

            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();

            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();

            //CHỉ lấy loại gv thỉnh giảng
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetByMaLoaiGiangVien(_maLoaiGiangVienThinhGiang);

            bindingSourceChucVu.DataSource = DataServices.ChucVu.GetAll();
            
            bindingSourceNhiemVuNCKH.DataSource = DataServices.NghienCuuKhoaHoc.GetAll();

            bindingSourceBacLuong.DataSource = DataServices.BacLuong.GetAll();
            bindingSourceLoaiNhanVien.DataSource = DataServices.LoaiNhanVien.GetAll();
            bindingSourceNgachCongChuc.DataSource = DataServices.NgachCongChuc.GetAll();
            bindingSourceTrinhDoChinhTri.DataSource = DataServices.TrinhDoChinhTri.GetAll();
            bindingSourceTrinhDoQuanLyNhaNuoc.DataSource = DataServices.TrinhDoQuanLyNhaNuoc.GetAll();
            bindingSourceTrinhDoTinHoc.DataSource = DataServices.TrinhDoTinHoc.GetAll();
            bindingSourceTrinhDoNgoaiNgu.DataSource = DataServices.TrinhDoNgoaiNgu.GetAll();
            bindingSourceTrinhDoSuPham.DataSource = DataServices.TrinhDoSuPham.GetAll();

            TList<HocHam> TlistHocHam = DataServices.HocHam.GetAll();
            TlistHocHam.Insert(0, new HocHam() { ThuTu = -1, MaHocHam = -1, MaQuanLy = "-1", TenHocHam = "[Tất cả]" });
            bindingSourceCloneHocHam.DataSource = TlistHocHam;
            gridLookUpEditHocHam.DataBindings.Clear();
            gridLookUpEditHocHam.DataBindings.Add("EditValue", bindingSourceCloneHocHam, "MaHocHam", true, DataSourceUpdateMode.OnPropertyChanged);

            TList<HocVi> TlistHocVi = DataServices.HocVi.GetAll();
            TlistHocVi.Insert(0, new HocVi() { ThuTu = -1, MaHocVi = -1, MaQuanLy = "-1", TenHocVi = "[Tất cả]" });
            bindingSourceCloneHocVi.DataSource = TlistHocVi;
            gridLookUpEditHocVi.DataBindings.Clear();
            gridLookUpEditHocVi.DataBindings.Add("EditValue", bindingSourceCloneHocVi, "MaHocVi", true, DataSourceUpdateMode.OnPropertyChanged);

            objGiangVien = new GiangVienChoDuyetHoSo();
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
            ViewKhoaBoMon objdonvi = bindingSourceDonVi.Current as ViewKhoaBoMon;
            
            if (objdonvi.MaKhoa != "-1")
            {

                TList<GiangVienChoDuyetHoSo> list = DataServices.GiangVienChoDuyetHoSo.GetByMaDonVi(objdonvi.MaBoMon);
                TList<GiangVienChoDuyetHoSo> listGV = list.FindAll(p => p.MaQuanLy.Contains(objdonvi.MaBoMon));
                int count = listGV.Count;
                if (listGV.Count > 0)
                {
                    listGV.Sort("MaQuanLy");
                    GiangVienChoDuyetHoSo gv = listGV[count - 1];
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
                    txtMaNhanSu.Text = objdonvi.MaBoMon.ToString() + maNhansu + (sott).ToString();
                    if(_maTruong == "MTU")
                        txtMaNhanSu.Text = objdonvi.MaBoMon.ToString() + "." + maNhansu + (sott).ToString();
                    PMS.Common.Globals._matkhau = txtMaNhanSu.Text.Trim();
                    txtDangnhap.Text = PMS.Common.Globals._matkhau;

                    objGiangVien = new GiangVienChoDuyetHoSo();
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
                    txtMaNhanSu.Text = objdonvi.MaBoMon.ToString() + maNhansu;

                    PMS.Common.Globals._matkhau = txtMaNhanSu.Text.Trim();
                    txtDangnhap.Text = PMS.Common.Globals._matkhau;

                    objGiangVien = new GiangVienChoDuyetHoSo();
                    objGiangVien.MaQuanLy = PMS.Common.Globals._matkhau;
                    objGiangVien.GioiTinh = false;
                    objGiangVien.DoanDang = false;
                    objGiangVien.MaNguoiLap = UserInfo.UserID;
                    objGiangVien.MatKhau = PMS.Common.Globals._matkhau;
                    bindingSourceGiangVien.DataSource = objGiangVien;
                }
                
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn đơn vị cho giảng viên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gridLookUpEditDonVi.Focus();
            }
        }

        private void Luu()
        {
            txtDangnhap.Focus();
            txtNgayCapNhat.Text = DateTime.Now.ToString();
            txtNguoiCapNhat.Text = UserInfo.User.TenDangNhap;
            TList<GiangVienChoDuyetHoSo> listGiangVien = bindingSourceChiTiet.DataSource as TList<GiangVienChoDuyetHoSo>;
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

                                if (_maTruong == "BUH" && gridLookUpEditHesoThuLao.Text == "")
                                {
                                    XtraMessageBox.Show("Chưa nhập hệ số lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;

                                }

                                if (objGiangVien.MaHocHam != null && objGiangVien.MaHocVi != null)
                                {
                                    if (objGiangVien.MaLoaiGiangVien != null)
                                    {
                                        if (objGiangVien.MaDonVi != null)
                                        {

                                            objGiangVien.MatKhau = EncodeMD5(objGiangVien.MaQuanLy, ReturnPassword(objGiangVien.MaQuanLy, objGiangVien.HoTen));
                                            listGiangVien.Add(objGiangVien);

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

                            DataServices.GiangVienChoDuyetHoSo.Save(listGiangVien);

                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Them moi giang vien
                            objGiangVien = new GiangVienChoDuyetHoSo();
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
        }

        private void Xoa()
        {
            TList<GiangVienChoDuyetHoSo> listGiangVien = bindingSourceChiTiet.DataSource as TList<GiangVienChoDuyetHoSo>;
            if (listGiangVien != null)
            {
                if (objGiangVien != null)
                {
                    if (XtraMessageBox.Show("Bạn muốn xóa giảng viên này? Mọi thông tin về giảng viên sẽ bị xóa. Bạn có chắc không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            listGiangVien.Remove(objGiangVien);
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
            return result;
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
            ViewKhoaBoMon objDonVi = bindingSourceDonVi.Current as ViewKhoaBoMon;
            TinhTrang objTinhTrang = bindingSourceTinhTrang.Current as TinhTrang;
            HocHam objHocHam = bindingSourceCloneHocHam.Current as HocHam;
            HocVi objHocVi = bindingSourceCloneHocVi.Current as HocVi;

            if (objDonVi != null && objTinhTrang != null && objHocHam != null && objHocVi != null)
            {
                bindingSourceChiTiet.DataSource = DataServices.GiangVienChoDuyetHoSo.GetMaDonViMaHocHamMaHocViMaTinhTrang(objDonVi.MaBoMon, objHocHam.MaHocHam, objHocVi.MaHocVi, objTinhTrang.MaTinhTrang.ToString());
                bindingSourceViewThongTinGiangVien.DataSource = DataServices.ViewThongTinChiTietGiangVienChoDuyetHoSo.GetByMaDonViMaHocHamMaHocViMaTinhTrang(objDonVi.MaBoMon, objHocHam.MaHocHam, objHocVi.MaHocVi, objTinhTrang.MaTinhTrang.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
                    break;

            }
        }

        private void btnDuyetHoSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (objGiangVien != null)
            {
                if (txtMaNhanSu.Text == "")
                {
                    XtraMessageBox.Show("Chưa cấp mã cho giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNhanSu.Focus();
                    return;
                }
                TList<GiangVien> _kiemTra = DataServices.GiangVien.GetByMaQuanLy(txtMaNhanSu.Text);
                if (_kiemTra.Count > 0)
                {
                    XtraMessageBox.Show(string.Format("Mã giảng viên {0} đã có trong hệ thống, vui lòng nhập mã khác.", txtMaNhanSu.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNhanSu.Text = "";
                    txtMaNhanSu.Focus();
                    return;
                }

                if (XtraMessageBox.Show(string.Format("Xác nhận duyệt hồ sơ giảng viên {0} - {1} ?", txtMaNhanSu.Text, txtHoTen.Text), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string xmlData = String.Format("<Root><Input Id=\"{0}\" M=\"{1}\" D=\"{2:dd/MM/yyyy HH:mm:ss}\" U=\"{3}\" /></Root>", objGiangVien.Id, txtMaNhanSu.Text, DateTime.Now, UserInfo.UserName);
                    int result = -1;
                    DataServices.GiangVienChoDuyetHoSo.DuyetHoSo(xmlData, ref result);
                    if (result == 0)
                        XtraMessageBox.Show("Duyệt hồ sơ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình duyệt hồ sơ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    btnLoc.PerformClick();
                    btnLamTuoi.PerformClick();
                }
            }

            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Grid


        private void gridViewGiangVien_Click(object sender, EventArgs e)
        {
            if (bindingSourceChiTiet.DataSource != null)
            {
                GiangVienChoDuyetHoSo obj = bindingSourceChiTiet.Current as GiangVienChoDuyetHoSo;
                if (obj != null)
                {
                    txtTenGV.Text = obj.MaQuanLy + " - " + obj.HoTen;
                    objGiangVien = obj;
                    bindingSourceGiangVien.DataSource = obj;
                    txtDangnhap.Text = obj.MatKhau;
                }
            }
        }
        #endregion

        #region Orther
        private void txtMaNhanSu_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            PMS.Common.Globals._matkhau = txtMaNhanSu.Text;
            txtDangnhap.Text = PMS.Common.Globals._matkhau;
        }
        #endregion

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

    }
}

