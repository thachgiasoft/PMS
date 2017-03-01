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
    public partial class frmKhoiLuongGiangDay : DevExpress.XtraEditors.XtraForm
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

        private int _maKetQua;

        public frmKhoiLuongGiangDay(int maKetQua)
        {
            InitializeComponent();
            _maKetQua = maKetQua;
            InitData(_maKetQua);
        }

        public frmKhoiLuongGiangDay()
        {
            InitializeComponent();
        }

        private void frmKhoiLuongGiangDay_Load(object sender, EventArgs e)
        {
            #region Khoi luong giang day
            AppGridView.InitGridView(gridViewKhoiLuongGiangDay, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongGiangDay, new string[] { "LoaiHocPhan", "MaMonHoc", "DienGiai", "SoTiet", "MaLop", "SiSoLop", "TrongGio", "ChatLuongCao", "NgoaiGio", "HeSoThanhPhan", "HeSoLopDong", "TietQuyDoi" },
                new string[] { "Loại HP", "Mã MH", "Tên MH", "Số tiết", "Mã lớp", "Số lượng", "Trong giờ", "CLC", "Ngoài giờ", "HS TP", "HS LĐ", "Tiết QĐ" },
                new int[] { 90, 80, 280, 70, 90, 70, 70, 70, 80, 70, 70, 70 });
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "DienGiai", repositoryItemGridLookUpEditMonHoc);
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "SiSoLop", repositoryItemSpinEditSiSoLop);
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "TrongGio", repositoryItemSpinEditSoTiet);
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "ChatLuongCao", repositoryItemSpinEditChatLuongCao);
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "NgoaiGio", repositoryItemSpinEditNgoaiGio);
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "HeSoThanhPhan", repositoryItemSpinEditHeSoThanhPhan);
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "HeSoLopDong", repositoryItemSpinEditHeSoLopDong);
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "TietQuyDoi", repositoryItemSpinEditTietQuyDoi);
            //AppGridView.ReadOnlyColumn(gridViewKhoiLuongGiangDay, new string[] { "LoaiHocPhan", "MaLop", "MaMonHoc", "DienGiai", "SoTiet" });
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongGiangDay);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "LoaiHocPhan", "Tổng :", DevExpress.Data.SummaryItemType.Custom);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "MaLop", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "TrongGio", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "TietQuyDoi", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "NgoaiGio", "{0}", DevExpress.Data.SummaryItemType.Sum);
            #endregion

            #region MonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 420, 300);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "MaMonHoc", "TenMonHoc" }, new string[] { "Mã MH", "Tên MH" }, new int[] { 100, 300 });
            repositoryItemGridLookUpEditMonHoc.DisplayMember = "TenMonHoc";
            repositoryItemGridLookUpEditMonHoc.ValueMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.NullText = string.Empty;
            #endregion

            bindingSourceMonHoc.DataSource = DataServices.ViewMonHoc.GetAll();
        }

        public void InitData(int maKetQua)
        {
            _maKetQua = maKetQua;
            bindingSourceKhoiLuongGiangDay.DataSource = DataServices.KhoiLuongGiangDay.GetByMaKetQua(_maKetQua);
        }

        private void gridViewKhoiLuongGiangDay_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewKhoiLuongGiangDay, e);
        }

        private void gridViewKhoiLuongGiangDay_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKhoiLuongGiangDay, e);
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData(_maKetQua);
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKhoiLuongGiangDay);
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

        private void gridViewKhoiLuongGiangDay_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            KhoiLuongGiangDay obj = e.Row as KhoiLuongGiangDay;
            if (obj != null)
            {
                if (obj.IsValid)
                    e.Valid = true;
                else
                    e.Valid = false;
            }
        }

        private void gridViewKhoiLuongGiangDay_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
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