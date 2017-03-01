using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;
using PMS.Entities.Validation;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmChiaNhomMonThucHanh : DevExpress.XtraEditors.XtraForm
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

        public frmChiaNhomMonThucHanh()
        {
            InitializeComponent();
        }

        private void frmChiaNhomMonThucHanh_Load(object sender, EventArgs e)
        {
            #region Khoi luong giang day
            AppGridView.InitGridView(gridViewKhoiLuongGiangDay, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongGiangDay, new string[] { "MaMonHoc", "MaLop", "SiSoLop", "SoNhom", "TrongGio", "ChatLuongCao", "NgoaiGio", "HeSoThanhPhan", "HeSoLopDong", "TietQuyDoi" },
                new string[] { "Môn học", "Mã lớp", "Số lượng", "Số nhóm", "Trong giờ", "CLC", "Ngoài giờ", "HS TP", "HS LĐ", "Tiết QĐ" },
                new int[] { 280, 90, 70, 70, 70, 70, 80, 70, 70, 70 });
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "MaMonHoc", repositoryItemGridLookUpEditMonHoc);
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "SiSoLop", repositoryItemSpinEditSiSoLop);
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "TrongGio", repositoryItemSpinEditSoTiet);
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "SoNhom", repositoryItemSpinEditSoNhom);
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "ChatLuongCao", repositoryItemSpinEditChatLuongCao);
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "NgoaiGio", repositoryItemSpinEditNgoaiGio);
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "HeSoThanhPhan", repositoryItemSpinEditHeSoThanhPhan);
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "HeSoLopDong", repositoryItemSpinEditHeSoLopDong);
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "TietQuyDoi", repositoryItemSpinEditTietQuyDoi);
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongGiangDay, new string[] { "MaLop", "MaMonHoc" });
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "MaMonHoc", "Tổng :", DevExpress.Data.SummaryItemType.Custom);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "MaLop", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "TrongGio", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "TietQuyDoi", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "NgoaiGio", "{0}", DevExpress.Data.SummaryItemType.Sum);
            #endregion

            #region MonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 420, 300);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "MaMonHoc", "TenMonHoc" }, new string[] { "Mã MH", "Tên MH" }, new int[] { 100, 300 });
            repositoryItemGridLookUpEditMonHoc.DisplayMember = "TenHienThi";
            repositoryItemGridLookUpEditMonHoc.ValueMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.NullText = string.Empty;
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

            #region Loai khoi luong
            AppGridLookupEdit.InitGridLookUp(cboLoaiKhoiLuong, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiKhoiLuong, new string[] { "MaLoaiKhoiLuong", "TenLoaiKhoiLuong" }, new string[] { "Mã loại", "Tên loại" });
            cboLoaiKhoiLuong.Properties.ValueMember = "MaLoaiKhoiLuong";
            cboLoaiKhoiLuong.Properties.DisplayMember = "TenLoaiKhoiLuong";
            cboLoaiKhoiLuong.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }

        public void InitData()
        {
            bindingSourceMonHoc.DataSource = DataServices.ViewMonHocKhoa.GetAll();

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            cboNamHoc.DataBindings.Clear();
            cboNamHoc.DataBindings.Add("EditValue", bindingSourceNamHoc, "NamHoc", true, DataSourceUpdateMode.OnPropertyChanged);

            ViewNamHoc objNamHoc = bindingSourceNamHoc.Current as ViewNamHoc;
            if (objNamHoc != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(objNamHoc.NamHoc);
                cboHocKy.DataBindings.Clear();
                cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
            }

            ViewHocKy objHocKy = bindingSourceHocKy.Current as ViewHocKy;
            if (objHocKy != null)
                bindingSourceKhoiLuongGiangDay.DataSource = DataServices.ViewTinhKhoiLuong.GetByNamHocHocKy(objHocKy.NamHoc, objHocKy.MaHocKy);

            bindingSourceLoaiKhoiLuong.DataSource = DataServices.LoaiKhoiLuong.GetAll();
            cboLoaiKhoiLuong.DataBindings.Clear();
            cboLoaiKhoiLuong.DataBindings.Add("EditValue", bindingSourceLoaiKhoiLuong, "MaLoaiKhoiLuong", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewKhoiLuongGiangDay.FocusedRowHandle = -1;
            TList<KhoiLuongGiangDay> list = bindingSourceKhoiLuongGiangDay.DataSource as TList<KhoiLuongGiangDay>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceKhoiLuongGiangDay.EndEdit();
                            DataServices.KhoiLuongGiangDay.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoaiKhoiLuong objLoaiKhoiLuong = bindingSourceLoaiKhoiLuong.Current as LoaiKhoiLuong;
            if (objLoaiKhoiLuong == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn loại khối lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiKhoiLuong.Focus();
                return;
            }
            ViewHocKy objHocKy = bindingSourceHocKy.Current as ViewHocKy;
            if (objHocKy == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn nằm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }
            bindingSourceKhoiLuongGiangDay.DataSource = DataServices.KhoiLuongGiangDay.GetByLoaiHocPhanNamHocHocKy(objLoaiKhoiLuong.MaLoaiKhoiLuong, objHocKy.NamHoc, objHocKy.MaHocKy);
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

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhoiLuongGiangDay obj = bindingSourceKhoiLuongGiangDay.Current as KhoiLuongGiangDay;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceKhoiLuongGiangDay.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewKhoiLuongGiangDay.RefreshData();
            }
        }
    }
}