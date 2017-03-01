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
using DevExpress.XtraGrid.Columns;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmMonPhanCongNhieuGiangVien : DevExpress.XtraEditors.XtraForm
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
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }

        #endregion
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewGiangVien> _listGiangVien;
        VList<ViewMonHocKhoa> _listMonHoc;
        VList<ViewLopHocPhan> _listLopHocPhan;
        #endregion
        #region Event Form
        public frmMonPhanCongNhieuGiangVien()
        {
            InitializeComponent();
        }

        private void frmMonPhanCongNhieuGiangVien_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewPhanCong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewPhanCong, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "MaGiangVienQuanLy", "MaLopHocPhan", "MaLop", "Nhom", "SiSo", "LopClc", "MaLoaiHocPhan", "SoTiet", "SoTietDayChuNhat", "NhomMonHoc", "MaLoaiGiangVien", "MaHocHam", "MaHocVi", "NgayCapNhat" }
                , new string[] { "Mã môn học", "Tên môn học", "STC", "Họ tên GV", "Mã lớp học phần", "Mã lớp", "Nhóm", "Sĩ số", "Lớp CLC", "Loại học phần", "Số tiết", "Số tiết dạy CN", "Nhóm môn học", "Loại giảng viên", "Học hàm", "Học vị", "Ngày cập nhật" }
                , new int[] { 70, 150, 50, 130, 110, 80, 70, 70, 60, 70, 90, 100, 99, 99, 99, 99, 99 });
            AppGridView.ShowEditor(gridViewPhanCong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewPhanCong, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "MaGiangVienQuanLy", "MaLopHocPhan", "MaLop", "Nhom", "SiSo", "LopClc", "SoTietDayChuNhat", "MaLoaiHocPhan", "SoTiet" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewPhanCong, new string[] { "TenMonHoc", "SoTinChi", "MaLop", "Nhom", "SiSo", "MaLoaiHocPhan", "LopClc" });
            AppGridView.HideField(gridViewPhanCong, new string[] { "NhomMonHoc", "MaLoaiGiangVien", "MaHocHam", "MaHocVi", "NgayCapNhat" });
            AppGridView.RegisterControlField(gridViewPhanCong, "MaGiangVienQuanLy", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewPhanCong, "MaMonHoc", repositoryItemGridLookUpEditMonHoc);
            AppGridView.RegisterControlField(gridViewPhanCong, "MaLoaiHocPhan", repositoryItemGridLookUpEditLoaiHocPhan);
            AppGridView.RegisterControlField(gridViewPhanCong, "MaLopHocPhan", repositoryItemGridLookUpEditLopHocPhan);
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
            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Đơn vị" }, new int[] { 90, 150, 180 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 420, 600);
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "HoTen";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region MonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "TenKhoa", "TenBoMon" }, new string[] { "Mã môn học", "Tên môn học", "STC", "Khoa", "Bộ môn" }, new int[] { 90, 150, 50, 120, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 530, 600);
            repositoryItemGridLookUpEditMonHoc.ValueMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.DisplayMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.NullText = string.Empty;
            #endregion

            #region LoaiHocPhan
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLoaiHocPhan, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLoaiHocPhan, new string[] { "MaLoaiHocPhan", "TenLoaiHocPhan", "VietTat" }, new string[] { "Mã loại học phần", "Tên loại học phần", "Viết tắt" }, new int[] { 100, 120, 80 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLoaiHocPhan, 300, 600);
            repositoryItemGridLookUpEditLoaiHocPhan.ValueMember = "MaLoaiHocPhan";
            repositoryItemGridLookUpEditLoaiHocPhan.DisplayMember = "TenLoaiHocPhan";
            repositoryItemGridLookUpEditLoaiHocPhan.NullText = string.Empty;
            #endregion
            #region LopHocPhan
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLopHocPhan, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLopHocPhan, new string[] { "MaLopHocPhan", "TenLopHocPhan", "MaMonHoc", "TenMonHoc", "MaLop" }, new string[] { "Mã lớp học phần", "Tên lớp học phần", "Mã môn học", "Tên môn học", "Lớp" }, new int[] { 110, 110, 90, 150, 80 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLopHocPhan, 540, 600);
            repositoryItemGridLookUpEditLopHocPhan.ValueMember = "MaLopHocPhan";
            repositoryItemGridLookUpEditLopHocPhan.DisplayMember = "MaLopHocPhan";
            repositoryItemGridLookUpEditLopHocPhan.NullText = string.Empty;
            #endregion
            InitData();
        }
        #endregion
        #region InitData()
        void InitData()
        {
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            _listMonHoc = DataServices.ViewMonHocKhoa.GetAll();
            
            bindingSourceGiangVien.DataSource = _listGiangVien;
            bindingSourceMonHoc.DataSource = _listMonHoc;
            bindingSourceLoaiHocPhan.DataSource = DataServices.ViewLoaiHocPhan.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                _listLopHocPhan = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bindingSourceLopHocPhan.DataSource = _listLopHocPhan;
                bindingSourcePhanCong.DataSource = DataServices.MonPhanCongNhieuGiangVien.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
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
            AppGridView.DeleteSelectedRows(gridViewPhanCong);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewPhanCong.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TList<MonPhanCongNhieuGiangVien> list = bindingSourcePhanCong.DataSource as TList<MonPhanCongNhieuGiangVien>;
                try
                {
                    foreach (MonPhanCongNhieuGiangVien kl in list)
                    {
                        kl.NamHoc = cboNamHoc.EditValue.ToString();
                        kl.HocKy = cboHocKy.EditValue.ToString();
                    }
                    bindingSourcePhanCong.EndEdit();
                    int kq = 0;
                    DataServices.MonPhanCongNhieuGiangVien.Save(list);
                    if (kq == 0)
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlPhanCong.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
        #endregion

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    _listLopHocPhan = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    bindingSourceLopHocPhan.DataSource = _listLopHocPhan;
                    bindingSourcePhanCong.DataSource = DataServices.MonPhanCongNhieuGiangVien.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
            }
            catch { }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    _listLopHocPhan = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    bindingSourceLopHocPhan.DataSource = _listLopHocPhan;
                    bindingSourcePhanCong.DataSource = DataServices.MonPhanCongNhieuGiangVien.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewPhanCong_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridColumn col = e.Column;
                int pos = e.RowHandle;
                if (col.FieldName == "MaMonHoc")
                {
                    MonPhanCongNhieuGiangVien v = (MonPhanCongNhieuGiangVien)gridViewPhanCong.GetRow(pos);
                    string _tenMonHoc = _listMonHoc.Find(p => p.MaMonHoc == v.MaMonHoc).TenMonHoc;
                    decimal _sTC = _listMonHoc.Find(p => p.MaMonHoc == v.MaMonHoc).SoTinChi;
                    string _nhomMonHoc = _listMonHoc.Find(p => p.MaMonHoc == v.MaMonHoc).NhomMonHoc;
                    gridViewPhanCong.SetRowCellValue(pos, "TenMonHoc", _tenMonHoc);
                    gridViewPhanCong.SetRowCellValue(pos, "SoTinChi", _sTC);
                    gridViewPhanCong.SetRowCellValue(pos, "NhomMonHoc", _nhomMonHoc);
                    gridViewPhanCong.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now);
                    
                    repositoryItemGridLookUpEditLopHocPhan.View.ActiveFilterString = string.Format("MaMonHoc = '{0}'", v.MaMonHoc.ToString());
                }
                if (col.FieldName == "MaLopHocPhan")
                {
                    MonPhanCongNhieuGiangVien v = (MonPhanCongNhieuGiangVien)gridViewPhanCong.GetRow(pos);
                    string _maLop = _listLopHocPhan.Find(p => p.MaLopHocPhan == v.MaLopHocPhan).MaLop;
                    int? _siSo = _listLopHocPhan.Find(p => p.MaLopHocPhan == v.MaLopHocPhan).SiSo;
                    int _maLoaiHocPhan = _listLopHocPhan.Find(p => p.MaLopHocPhan == v.MaLopHocPhan).MaLoaiHocPhan;
                    string _nhom = _listLopHocPhan.Find(p => p.MaLopHocPhan == v.MaLopHocPhan).Nhom;
                    gridViewPhanCong.SetRowCellValue(pos, "MaLop", _maLop);
                    gridViewPhanCong.SetRowCellValue(pos, "SiSo", _siSo);
                    gridViewPhanCong.SetRowCellValue(pos, "LopClc", KiemTraLopCLC(_maLop));
                    gridViewPhanCong.SetRowCellValue(pos, "MaLoaiHocPhan", _maLoaiHocPhan);
                    gridViewPhanCong.SetRowCellValue(pos, "Nhom", _nhom);
                    gridViewPhanCong.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now);

                    repositoryItemGridLookUpEditLopHocPhan.View.ActiveFilterString = "";
                }
                if (col.FieldName == "MaGiangVienQuanLy")
                {
                    MonPhanCongNhieuGiangVien v = (MonPhanCongNhieuGiangVien)gridViewPhanCong.GetRow(pos);
                    int? _maLoaiGiangVien = _listGiangVien.Find(p => p.MaQuanLy == v.MaGiangVienQuanLy).MaLoaiGiangVien;
                    int? _maHocHam = _listGiangVien.Find(p => p.MaQuanLy == v.MaGiangVienQuanLy).MaHocHam;
                    int? _maHocVi = _listGiangVien.Find(p => p.MaQuanLy == v.MaGiangVienQuanLy).MaHocVi;
                    gridViewPhanCong.SetRowCellValue(pos, "MaLoaiGiangVien", _maLoaiGiangVien);
                    gridViewPhanCong.SetRowCellValue(pos, "MaHocHam", _maHocHam);
                    gridViewPhanCong.SetRowCellValue(pos, "MaHocVi", _maHocVi);
                    gridViewPhanCong.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now);
                }
            }
            catch
            {  }
        }

        bool KiemTraLopCLC(string maLop)
        {
            if (maLop.ToUpper().Contains("CL") && !maLop.ToUpper().Contains("HOC"))
                return true;
            else
                return false;
        }

        private void gridViewPhanCong_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewPhanCong, e);
        }
    }
}