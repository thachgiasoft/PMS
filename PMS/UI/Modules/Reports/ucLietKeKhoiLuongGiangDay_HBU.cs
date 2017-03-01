using System;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities.Validation;
using PMS.UI.Forms.BaoCao;
using System.Data;

namespace PMS.UI.Modules.Reports
{
    public partial class ucLietKeKhoiLuongGiangDay_HBU : XtraUserControl
    {
        #region variables
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion

        public ucLietKeKhoiLuongGiangDay_HBU()
        {
            InitializeComponent();
        }

        private void ucLietKeKhoiLuongGiangDay_HBU_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThanhToanThuLao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThanhToanThuLao, new string[] { "MaDonVi", "TenDonVi", "MaQuanLy", "HoTen", "Loai", "MaMonHoc", "TenMonHoc", "Nhom", "MaLop", "SiSo", "TietThucDay", "HeSoNgoaiGio", "HeSoLopDong", "HeSoChucDanhChuyenMon", "HeSoKhoiNganh", "HeSoBacDaoTao", "HeSoNgonNgu", "TietQuyDoi", "DonGia", "ThanhTien", "Thue", "ThucLanh" }
                    , new string[] { "Mã bộ môn", "Bộ môn", "Mã giảng viên", "Họ và tên", "Loại", "Mã môn học", "Tên môn học", "Nhóm", "Mã lớp", "Sĩ số", "Tiết", "HS đặc biệt", "HS lớp đông", "HS chức danh", "HS khối ngành", "HS bậc đào tạo", "HS ngôn ngữ", "Tiết quy đổi", "Đơn giá", "Số tiền", "Thuế TNCN", "Thực lãnh" }
                    , new int[] { 80, 150, 90, 145, 100, 90, 150, 50, 90, 70, 50, 50, 50, 60, 60, 60, 60, 80, 100, 80, 80, 80, 90 });
            AppGridView.AlignHeader(gridViewThanhToanThuLao, new string[] { "MaDonVi", "TenDonVi", "MaQuanLy", "HoTen", "Loai", "MaMonHoc", "TenMonHoc", "Nhom", "MaLop", "SiSo", "TietThucDay", "HeSoNgoaiGio", "HeSoLopDong", "HeSoChucDanhChuyenMon", "HeSoKhoiNganh", "HeSoBacDaoTao", "HeSoNgonNgu", "TietQuyDoi", "DonGia", "ThanhTien", "Thue", "ThucLanh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "MaMonHoc", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewThanhToanThuLao);
            //gridViewThanhToanThuLao.Columns["TenDonVi"].GroupIndex = 0;
            //gridViewThanhToanThuLao.Columns["HoTen"].GroupIndex = 1;
            PMS.Common.Globals.WordWrapHeader(gridViewThanhToanThuLao, 40);
            AppGridView.FormatDataField(gridViewThanhToanThuLao, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThanhToanThuLao, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThanhToanThuLao, "Thue", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThanhToanThuLao, "ThucLanh", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FixedField(gridViewThanhToanThuLao, new string[] { "MaQuanLy", "HoTen" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            AppGridView.HideField(gridViewThanhToanThuLao, new string[] { "DonGia", "ThanhTien", "Thue", "ThucLanh" });
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            #endregion

            #region Giảng viên
            AppGridLookupEdit.InitGridLookUp(cboGiangVien, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboGiangVien, 700, 500);
            AppGridLookupEdit.ShowField(cboGiangVien, new string[] { "MaQuanLy", "HoTen", "TenKhoa", "TenBoMon" },
                new string[] { "Mã GV", "Họ tên", "Tên khoa", "Tên bộ môn" },
                new int[] { 80, 200, 200, 200 });
            cboGiangVien.Properties.DisplayMember = "HoTen";
            cboGiangVien.Properties.ValueMember = "MaGiangVien";
            cboGiangVien.Properties.NullText = "[Chọn giảng viên]";
            #endregion

            #region Init Data Source
            InitData();
            #endregion

            #region Init CauHinh
            TList<CauHinh> listCauHinh = DataServices.CauHinh.GetAll() as TList<CauHinh>;
            if (listCauHinh != null)
            {
                foreach (CauHinh ch in listCauHinh)
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
            }
            _maTruong = _cauHinhChung.Find(ch => ch.TenCauHinh.Equals("Mã trường")).GiaTri;
            #endregion
        }

        private void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            cboNamHoc.DataBindings.Clear();
            cboNamHoc.DataBindings.Add("EditValue", bindingSourceNamHoc, "NamHoc", true, DataSourceUpdateMode.OnPropertyChanged);

            ViewNamHoc objNamHoc = bindingSourceNamHoc.Current as ViewNamHoc;
            if (objNamHoc != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(objNamHoc.NamHoc);
                //AppGridLookupEdit.InitGridLookUp(
            }

            bindingSourceDonVi.DataSource = DataServices.ViewGiangVienKhoa.GetAll();
            cboGiangVien.DataBindings.Clear();
            cboGiangVien.DataBindings.Add("EditValue", bindingSourceDonVi, "MaGiangVien", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ViewHocKy vHocKy = bindingSourceHocKy.Current as ViewHocKy;
            if (vHocKy == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ViewGiangVienKhoa vDonVi = bindingSourceDonVi.Current as ViewGiangVienKhoa;
            if (vDonVi == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn đơn vị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bindingSourceChiTietKhoiLuong.DataSource = DataServices.ViewChiTietKhoiLuong.GetByNamHocHocKyMaDonViMaGiangVien(vHocKy.NamHoc, vHocKy.MaHocKy, vDonVi.MaBoMon, vDonVi.MaGiangVien);
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                ViewNamHoc objNamHoc = cboNamHoc.Properties.GetRowByKeyValue(e.Value) as ViewNamHoc;
                if (objNamHoc != null)
                {
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(objNamHoc.NamHoc);
                    cboHocKy.DataBindings.Clear();
                    cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                DataTable data = bindingSourceChiTietKhoiLuong.DataSource as DataTable;
                frmBaoCao frm = new frmBaoCao();
                if (PMS.Common.Globals._cauhinh != null)
                {
                    switch (_maTruong)
                    {
                        case "HBU":
                            frm.InBangLietKeKhoiLuongGiangDay_HBU(DateTime.Now, data);
                            break;
                        default:
                            break;
                    }
                    frm.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show("Chưa cấu hình tên trường và các thông tin phòng ban liên quan", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi trong quá trình thống kê. Vui lòng liên hệ người phụ trách\n" +ex.Message, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}