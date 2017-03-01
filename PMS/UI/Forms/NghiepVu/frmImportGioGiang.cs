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
using PMS.UI.Forms.NghiepVu.ChucNangCon;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmImportGioGiang : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;

                btnImportExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnImportExcel.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnImportExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        VList<ViewGiangVien> _listGiangVien;
        VList<ViewMonHocKhoa> _listMonHoc;
        #endregion

        #region Event Form
        public frmImportGioGiang()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmImportGioGiang_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewImport, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewImport, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewImport, new string[] { "MaGiangVienQuanLy", "Ho", "Ten", "TenDonVi", "MaMonHoc", "TenMonHoc", "MaBacDaoTao", "MaLop", "SiSo", "SoTiet", "HeSoChucDanh", "HeSoLopDong", "HeSoBacDaoTao", "HeSoThucHanh", "TietQuyDoi", "NoiDungChi", "Id" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Đơn vị", "Mã môn học", "Tên môn học", "Bậc đào tạo", "Mã lớp", "Sĩ số", "Số tiết", "HS chức danh", "HS lớp đông", "HS bậc đào tạo", "HS thực hành", "Tiết quy đổi", "Ghi chú", "Id" }
                    , new int[] { 90, 110, 60, 180, 90, 180, 80, 70, 60, 60, 80, 80, 80, 80, 80, 100, 99 });
            AppGridView.AlignHeader(gridViewImport, new string[] { "MaGiangVienQuanLy", "Ho", "Ten", "TenDonVi", "MaMonHoc", "TenMonHoc", "MaBacDaoTao", "MaLop", "SiSo", "SoTiet", "HeSoChucDanh", "HeSoLopDong", "HeSoBacDaoTao", "HeSoThucHanh", "TietQuyDoi", "NoiDungChi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.FixedField(gridViewImport, new string[] { "MaGiangVienQuanLy", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            AppGridView.RegisterControlField(gridViewImport, "MaGiangVienQuanLy", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewImport, "MaMonHoc", repositoryItemGridLookUpEditMonHoc);
            AppGridView.RegisterControlField(gridViewImport, "MaBacDaoTao", repositoryItemGridLookUpEditBacDaoTao);
            AppGridView.SummaryField(gridViewImport, "MaGiangVienQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewImport, "TietQuyDoi", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.HideField(gridViewImport, new string[] { "Id" });
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            cboNamHoc.Properties.BestFitMode = BestFitMode.BestFit;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            cboHocKy.Properties.BestFitMode = BestFitMode.BestFit;
            #endregion

            #region LoaiHinhDaoTao
            AppGridLookupEdit.InitGridLookUp(cboLoaiHinhDaoTao, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiHinhDaoTao, new string[] { "MaLoaiHinh", "TenLoaiHinh" }, new string[] { "Mã loại hình đào tạo", "Tên loại hình đào tạo" });
            cboLoaiHinhDaoTao.Properties.ValueMember = "MaLoaiHinh";
            cboLoaiHinhDaoTao.Properties.DisplayMember = "TenLoaiHinh";
            cboLoaiHinhDaoTao.Properties.NullText = string.Empty;
            cboLoaiHinhDaoTao.Properties.BestFitMode = BestFitMode.BestFit;
            #endregion

            #region _dotThanhToan
            AppGridLookupEdit.InitGridLookUp(cboDotThanhToan, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDotThanhToan, new string[] { "MaQuanLy", "TenQuanLy" }, new string[] { "Mã đợt", "Tên đợt" });
            cboDotThanhToan.Properties.ValueMember = "MaCauHinhChotGio";
            cboDotThanhToan.Properties.DisplayMember = "TenQuanLy";
            cboDotThanhToan.Properties.NullText = string.Empty;
            cboDotThanhToan.Properties.BestFitMode = BestFitMode.BestFit;
            #endregion

            #region Repo GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "Ho", "Ten" }, new string[] { "Mã giảng viên", "Họ", "Tên" }, new int[] { 90, 110, 60 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 260, 650);
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            repositoryItemGridLookUpEditGiangVien.BestFitMode = BestFitMode.BestFit;
            #endregion

            #region Repo MonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "TenBoMon" }, new string[] { "Mã môn học", "Tên môn học", "Số tín chỉ", "Khoa - Bộ môn" }, new int[] { 80, 180, 60, 180 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 500, 650);
            repositoryItemGridLookUpEditMonHoc.ValueMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.DisplayMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.NullText = string.Empty;
            repositoryItemGridLookUpEditMonHoc.BestFitMode = BestFitMode.BestFit;
            #endregion

            #region Repo BacDaoTao
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditBacDaoTao, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditBacDaoTao, new string[] { "MaBacDaoTao", "TenBacDaoTao" }, new string[] { "Mã bậc đào tạo", "Tên bậc đào tạo" }, new int[] { 120, 180 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditBacDaoTao, 300, 650);
            repositoryItemGridLookUpEditBacDaoTao.ValueMember = "MaBacDaoTao";
            repositoryItemGridLookUpEditBacDaoTao.DisplayMember = "MaBacDaoTao";
            repositoryItemGridLookUpEditBacDaoTao.NullText = string.Empty;
            repositoryItemGridLookUpEditBacDaoTao.BestFitMode = BestFitMode.BestFit;
            #endregion

            InitData();
        }
        #endregion

        #region Init Data
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            InitHocKy();

            cboLoaiHinhDaoTao.DataBindings.Clear();
            bindingSourceLoaiHinhDaoTao.DataSource = DataServices.ViewLoaiHinhDaoTao.GetAll();
            cboLoaiHinhDaoTao.DataBindings.Add("EditValue", bindingSourceLoaiHinhDaoTao, "MaLoaiHinh", true, DataSourceUpdateMode.OnPropertyChanged);

            InitDotThanhToan();

            _listGiangVien = new VList<ViewGiangVien> ();
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;

            _listMonHoc = new VList<ViewMonHocKhoa>();
            _listMonHoc = DataServices.ViewMonHocKhoa.GetAll();
            bindingSourceMonHoc.DataSource = _listMonHoc;
                        
            bindingSourceBacDaoTao.DataSource = DataServices.ViewBacDaoTao.GetAll();

            LoadDataSource();
        }

        void LoadDataSource()
        {
            try
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboLoaiHinhDaoTao.EditValue != null && cboDotThanhToan.EditValue != null)
                {
                    DataTable tb = new DataTable();
                    IDataReader reader = DataServices.ThuLaoImport.GetByNamHocHocKyLoaiHinhDaoTaoDotThanhToan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString(), int.Parse(cboDotThanhToan.EditValue.ToString()));
                    tb.Load(reader);
                    foreach (DataColumn col in tb.Columns)
                        col.ReadOnly = false;
                    bindingSourceImport.DataSource = tb;
                }
            }
            catch  
            {  } 
        }

        void InitHocKy()
        { 
            if(cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
        }

        void InitDotThanhToan()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                cboDotThanhToan.DataBindings.Clear();
                bindingSourceDotThanhToan.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                cboDotThanhToan.DataBindings.Add("EditValue", bindingSourceDotThanhToan, "MaCauHinhChotGio", true, DataSourceUpdateMode.OnPropertyChanged);
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewImport);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewImport.FocusedRowHandle = -1;
                DataTable tb = bindingSourceImport.DataSource as DataTable;

                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboLoaiHinhDaoTao.EditValue != null && cboDotThanhToan.EditValue != null)
                {
                    if (tb != null)
                    {
                        if (XtraMessageBox.Show("Bạn muốn lưu dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string xmlData = "";
                            foreach (DataRow r in tb.Rows)
                            {
                                if (r.RowState != DataRowState.Deleted)
                                {
                                    if (r["MaGiangVienQuanLy"].ToString() == "" || r["TietQuyDoi"].ToString() == "")
                                    {
                                        XtraMessageBox.Show("Không được phép bỏ trống cột thông tin \"Mã giảng viên\" và \"Tiết quy đổi\"", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }

                                    xmlData += "<Input Id=\"" + PMS.Common.Globals.IsNull(r["Id"], "int")
                                                + "\" M=\"" + r["MaGiangVienQuanLy"].ToString()
                                                + "\" MM=\"" + r["MaMonHoc"].ToString()
                                                + "\" MB=\"" + r["MaBacDaoTao"].ToString()
                                                + "\" ML=\"" + r["MaLop"].ToString()
                                                + "\" SS=\"" + PMS.Common.Globals.IsNull(r["SiSo"], "int")
                                                + "\" ST=\"" + PMS.Common.Globals.IsNull(r["SoTiet"], "decimal")
                                                + "\" HSCD=\"" + PMS.Common.Globals.IsNull(r["HeSoChucDanh"], "decimal")
                                                + "\" HSLD=\"" + PMS.Common.Globals.IsNull(r["HeSoLopDong"], "decimal")
                                                + "\" HSBDT=\"" + PMS.Common.Globals.IsNull(r["HeSoBacDaoTao"], "decimal")
                                                + "\" HSTH=\"" + PMS.Common.Globals.IsNull(r["HeSoThucHanh"], "decimal")
                                                + "\" QD=\"" + PMS.Common.Globals.IsNull(r["TietQuyDoi"], "decimal")
                                                + "\" GC=\"" + r["NoiDungChi"].ToString()
                                                + "\" />";
                                }
                            }

                            xmlData = "<Root>" + xmlData + "</Root>";

                            int result = 0;
                            DataServices.ThuLaoImport.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString(), int.Parse(cboDotThanhToan.EditValue.ToString()), ref result);

                            if (result == 0)
                                XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            LoadDataSource();
                        }
                    }
                }
            }
            catch 
            {  }
        }

        private void btnImportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonDieuKienImport frm = new frmChonDieuKienImport(_maTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString(), int.Parse(cboDotThanhToan.EditValue.ToString())))
            {
                frm.ShowDialog();
            }
            LoadDataSource();
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlImport.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            InitHocKy();

            InitDotThanhToan();

            LoadDataSource();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            InitDotThanhToan();

            LoadDataSource();
        }

        private void cboLoaiHinhDaoTao_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void cboDotThanhToan_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }
        #endregion

        #region Event Grid
        private void gridViewImport_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                DataRowView r = gridViewImport.GetRow(e.RowHandle) as DataRowView;
                if (e.Column.FieldName == "MaGiangVienQuanLy")
                {
                    ViewGiangVien _gv = _listGiangVien.Find(p => p.MaQuanLy == r["MaGiangVienQuanLy"].ToString());
                    gridViewImport.SetRowCellValue(e.RowHandle, "Ho", _gv.Ho);
                    gridViewImport.SetRowCellValue(e.RowHandle, "Ten", _gv.Ten);
                    gridViewImport.SetRowCellValue(e.RowHandle, "TenDonVi", _gv.TenDonVi);
                }

                if (e.Column.FieldName == "MaMonHoc")
                {
                    ViewMonHocKhoa _mh = _listMonHoc.Find(p => p.MaMonHoc == r["MaMonHoc"].ToString());

                    gridViewImport.SetRowCellValue(e.RowHandle, "TenMonHoc", _mh.TenMonHoc);
                }
            }
            catch 
            { } 
        }

        private void gridViewImport_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewImport, e);
        }
        #endregion
    }
}