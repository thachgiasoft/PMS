using System;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities.Validation;
using DevExpress.XtraGrid.Views.Base;
using PMS.Core;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucQuyDoiGioChuan : XtraUserControl
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

        public ucQuyDoiGioChuan()
        {
            InitializeComponent();
        }

        private void ucQuyDoiGioChuan_Load(object sender, EventArgs e)
        {
            #region Init GridView QuyDoiGioChuan
            AppGridView.InitGridView(gridViewQuyDoiGioChuan, true, true, GridMultiSelectMode.CellSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewQuyDoiGioChuan, new string[] { "ThuTu", "MaQuanLy", "TenQuyDoi", "MaDonVi", "SoLuong", "HeSo", "CongDon", "Khoan" },
                new string[] { "STT", "Mã quy đổi", "Tên quy đổi", "Đơn vị", "Số lượng", "Hệ số", "Cộng dồn", "Khoản" },
                new int[] { 70, 90, 300, 80, 80, 80, 70, 50 });
            AppGridView.ShowEditor(gridViewQuyDoiGioChuan, NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewQuyDoiGioChuan, new string[] { "CongDon", "Khoan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.UnSortField(gridViewQuyDoiGioChuan, new string[] { "CongDon", "Khoan" });
            AppGridView.RegisterControlField(gridViewQuyDoiGioChuan, "Khoan", repositoryItemButtonEditKhoan);
            AppGridView.RegisterControlField(gridViewQuyDoiGioChuan, "SoLuong", repositoryItemSpinEditSoLuong);
            AppGridView.RegisterControlField(gridViewQuyDoiGioChuan, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.RegisterControlField(gridViewQuyDoiGioChuan, "MaDonVi", repositoryItemGridLookUpEditDonVi);
            #endregion

            #region DonVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDonVi, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDonVi, new string[] { "MaQuanLy", "TenDonVi" }, new string[] { "Mã đơn vị", "Tên đơn vị" });
            repositoryItemGridLookUpEditDonVi.DisplayMember = "TenDonVi";
            repositoryItemGridLookUpEditDonVi.ValueMember = "MaDonVi";
            repositoryItemGridLookUpEditDonVi.NullText = string.Empty;
            #endregion

            #region Init Datasource
            bindingSourceQuyDoiGioChuan.DataSource = DataServices.QuyDoiGioChuan.GetAll();
            bindingSourceDonVi.DataSource = DataServices.DonViTinh.GetAll();
            //PMS.Common.Globals.LoadLayout(Tag as AppModule, new object[] { gridViewQuyDoiGioChuan, barManager1, layoutControl1 });
            #endregion
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuyDoiGioChuan obj = bindingSourceQuyDoiGioChuan.Current as QuyDoiGioChuan;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceQuyDoiGioChuan.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewQuyDoiGioChuan.RefreshData();
            }
        }

        private void gridViewQuyDoiGioChuan_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewQuyDoiGioChuan, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewQuyDoiGioChuan.FocusedRowHandle = -1;
            TList<QuyDoiGioChuan> list = bindingSourceQuyDoiGioChuan.DataSource as TList<QuyDoiGioChuan>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceQuyDoiGioChuan.EndEdit();
                            DataServices.QuyDoiGioChuan.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewQuyDoiGioChuan, barManager1, layoutControl1 });
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
            bindingSourceQuyDoiGioChuan.DataSource = DataServices.QuyDoiGioChuan.GetAll();
            bindingSourceDonVi.DataSource = DataServices.DonViTinh.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewQuyDoiGioChuan_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewQuyDoiGioChuan, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            QuyDoiGioChuan obj = target as QuyDoiGioChuan;
            if (obj != null)
            {
                if (((TList<QuyDoiGioChuan>)bindingSourceQuyDoiGioChuan.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã quy đổi {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewQuyDoiGioChuan_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            QuyDoiGioChuan obj = e.Row as QuyDoiGioChuan;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaQuanLy");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void gridViewQuyDoiGioChuan_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewQuyDoiGioChuan);
        }

        private void gridViewQuyDoiGioChuan_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (view.ActiveFilter.IsEmpty)
            {
                if (view.FocusedColumn.FieldName == "Khoan")
                {
                    QuyDoiGioChuan obj = gridViewQuyDoiGioChuan.GetFocusedRow() as QuyDoiGioChuan;
                    if (obj != null)
                    {
                        if (!obj.IsNew)
                        {
                            using (frmKhoanQuyDoi frm = new frmKhoanQuyDoi(obj.MaQuyDoi))
                            {
                                frm.ShowDialog();
                            }
                        }
                        else
                            XtraMessageBox.Show("Bạn chưa lưu lại dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void gridViewQuyDoiGioChuan_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            QuyDoiGioChuan obj = gridViewQuyDoiGioChuan.GetRow(e.RowHandle) as QuyDoiGioChuan;
            if (obj != null)
                obj.CongDon = false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                sf.FileName = "Quy đổi giờ chuẩn";
                if (sf.FileName != "")
                {
                    gridControlQuyDoiGioChuan.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}