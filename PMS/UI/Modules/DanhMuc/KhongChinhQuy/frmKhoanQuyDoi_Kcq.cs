﻿using System;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities.Validation;

namespace PMS.UI.Modules.DanhMuc.KhongChinhQuy
{
    public partial class frmKhoanQuyDoi_Kcq : DevExpress.XtraEditors.XtraForm
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

        private int _maQuyDoi;

        public frmKhoanQuyDoi_Kcq(int maQuyDoi)
        {
            InitializeComponent();
            _maQuyDoi = maQuyDoi;
        }

        private void frmKhoanQuyDoi_Load(object sender, EventArgs e)
        {
            #region Init GridView KhoanQuyDoi
            AppGridView.InitGridView(gridViewKhoanQuyDoi, true, true, GridMultiSelectMode.CellSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewKhoanQuyDoi, new string[] { "ThuTu", "TuKhoan", "DenKhoan", "HeSo" },
                new string[] { "STT", "Từ khoản", "Đến khoản", "Hệ số" },
                new int[] { 70, 100, 100, 100 });
            AppGridView.RegisterControlField(gridViewKhoanQuyDoi, "TuKhoan", repositoryItemSpinEditTuKhoan);
            AppGridView.RegisterControlField(gridViewKhoanQuyDoi, "DenKhoan", repositoryItemSpinEditDenKhoan);
            AppGridView.RegisterControlField(gridViewKhoanQuyDoi, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.ShowEditor(gridViewKhoanQuyDoi, NewItemRowPosition.Top);
            #endregion

            #region Init Datasource
            bindingSourceKhoanQuyDoi.DataSource = DataServices.KcqKhoanQuyDoi.GetByMaQuyDoi(_maQuyDoi);
            #endregion
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KcqKhoanQuyDoi obj = bindingSourceKhoanQuyDoi.Current as KcqKhoanQuyDoi;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceKhoanQuyDoi.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewKhoanQuyDoi.RefreshData();
            }
        }

        private void gridViewKhoanQuyDoi_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKhoanQuyDoi, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewKhoanQuyDoi.FocusedRowHandle = -1;
            TList<KcqKhoanQuyDoi> list = bindingSourceKhoanQuyDoi.DataSource as TList<KcqKhoanQuyDoi>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceKhoanQuyDoi.EndEdit();
                            DataServices.KcqKhoanQuyDoi.Save(list);
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

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceKhoanQuyDoi.DataSource = DataServices.KcqKhoanQuyDoi.GetByMaQuyDoi(_maQuyDoi);
            Cursor.Current = Cursors.Default;
        }

        private void gridViewHeKhoanQuyDoi_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewKhoanQuyDoi, e);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKhoanQuyDoi);
        }

        private void gridViewKhoanQuyDoi_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            KcqKhoanQuyDoi obj = gridViewKhoanQuyDoi.GetRow(e.RowHandle) as KcqKhoanQuyDoi;
            if (obj != null)
                obj.MaQuyDoi = _maQuyDoi;

        }
    }
}