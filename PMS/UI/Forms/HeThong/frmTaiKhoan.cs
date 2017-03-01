using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using PMS.Entities.Validation;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Forms.HeThong
{
    public partial class frmTaiKhoan : XtraForm
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewTaiKhoan, true, true, GridMultiSelectMode.CellSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewTaiKhoan, new string[] { "MaNhomQuyen", "HoTen", "TenDangNhap", "MatKhau", "Xem", "TrangThai", "ResetPassWordGv", "PhanQuyen" },
                new string[] { "Nhóm quyền", "Họ tên", "Tên truy cập", "Mật khẩu", "Xem", "Khoá tài khoản", "Reset mật khẩu GV", "Phân quyền chức năng" }, new int[] { 200, 200, 150, 70, 60, 100, 120, 150 });
            AppGridView.ShowEditor(gridViewTaiKhoan, NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewTaiKhoan, new string[] { "MaNhomQuyen", "HoTen", "TenDangNhap", "MatKhau", "Xem", "TrangThai", "ResetPassWordGv", "PhanQuyen" }, DevExpress.Utils.HorzAlignment.Center);
            //Attach Control to GridView
            AppGridView.RegisterControlField(gridViewTaiKhoan, "MaNhomQuyen", repositoryItemGridLookUpEditNhomQuyen);
            AppGridView.RegisterControlField(gridViewTaiKhoan, "MatKhau", repositoryItemTextEditMatKhau);
            AppGridView.RegisterControlField(gridViewTaiKhoan, "Xem", repositoryItemButtonEditXem);
            AppGridView.RegisterControlField(gridViewTaiKhoan, "PhanQuyen", repositoryItemButtonEditPhanQuyenTaiKhoan);
            AppGridView.AlignHeader(gridViewTaiKhoan, new string[] { "Xem", "TrangThai", "PhanQuyen" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.UnSortField(gridViewTaiKhoan, new string[] { "Xem", "TrangThai", "PhanQuyen" });
            AppGridView.HideField(gridViewTaiKhoan, new string[] { "Xem" });
            #endregion

            #region RepositoryItemGridLookUpEdit Nhom Quyen
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomQuyen, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomQuyen, new string[] { "TenNhomQuyen", "GhiChu" }, new string[] { "Tên nhóm quyền", "Ghi chú" });
            repositoryItemGridLookUpEditNhomQuyen.ValueMember = "MaNhomQuyen";
            repositoryItemGridLookUpEditNhomQuyen.DisplayMember = "TenNhomQuyen";
            repositoryItemGridLookUpEditNhomQuyen.NullText = string.Empty;            
            #endregion
            
            #region Init Datasource
            bindingSourceTaiKhoan.DataSource = DataServices.TaiKhoan.GetByNhomQuyenQL((Int32)UserInfo.GroupID); 
            bindingSourceNhomQuyen.DataSource = DataServices.NhomQuyen.GetByNhomQuyenQL((Int32)UserInfo.GroupID); 
            #endregion
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TaiKhoan obj = bindingSourceTaiKhoan.Current as TaiKhoan;
            if (obj != null)
            {
                if (obj.IsNew)
                {
                    bindingSourceNhomQuyen.Remove(obj);
                    gridViewTaiKhoan.RefreshData();
                }
                else
                {
                    obj.CancelChanges();
                    gridViewTaiKhoan.RefreshData();
                }
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceTaiKhoan.DataSource = DataServices.TaiKhoan.GetByNhomQuyenQL((Int32)UserInfo.GroupID); 
            bindingSourceNhomQuyen.DataSource = DataServices.NhomQuyen.GetByNhomQuyenQL((Int32)UserInfo.GroupID); 
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewTaiKhoan.FocusedRowHandle = -1;
            TList<TaiKhoan> listTaiKhoan = bindingSourceTaiKhoan.DataSource as TList<TaiKhoan>;
            if (listTaiKhoan != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (listTaiKhoan.IsValid)
                        {
                            foreach (TaiKhoan tk in listTaiKhoan)
                            {
                                if (!PMS.Common.Globals.IsMD5(tk.MatKhau))
                                { 
                                    tk.MatKhau = PMS.Common.Globals.EncodeMD5(tk.TenDangNhap, tk.MatKhau);   
                                }
                            }
                            bindingSourceTaiKhoan.EndEdit();
                            DataServices.TaiKhoan.Save(listTaiKhoan);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", listTaiKhoan.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gridViewTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewTaiKhoan, e);
        }

        private void gridViewTaiKhoan_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewTaiKhoan, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            TaiKhoan obj = target as TaiKhoan;
            if (obj != null)
            {
                if (((TList<TaiKhoan>)bindingSourceTaiKhoan.DataSource).FindAll(p => p.TenDangNhap == obj.TenDangNhap).Count > 1)
                {
                    e.Description = string.Format("Tên truy cập {0} hiện tại đã có.", obj.TenDangNhap);
                    return false;
                }
            }
            return true;
        }

        private void gridViewTaiKhoan_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            TaiKhoan objTaiKhoan = e.Row as TaiKhoan;
            if (objTaiKhoan != null)
            {
                objTaiKhoan.AddValidationRuleHandler(RuleCheckDuplicate, "TenDangNhap");
                if (objTaiKhoan.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(objTaiKhoan.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void gridViewTaiKhoan_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridViewTaiKhoan_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            TaiKhoan objTaiKhoan = gridViewTaiKhoan.GetRow(e.RowHandle) as TaiKhoan;
            if (objTaiKhoan != null)
            {
                objTaiKhoan.NgayTao = DateTime.Now;
                objTaiKhoan.MatKhau = string.Empty;
                objTaiKhoan.TrangThai = false;
            }
        }

        private void frmTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            repositoryItemGridLookUpEditNhomQuyen.Dispose();
            gridControlTaiKhoan.Dispose();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewTaiKhoan);
        }

        private void gridViewTaiKhoan_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (view.ActiveFilter.IsEmpty)
            {
                if (view.FocusedColumn.FieldName == "Xem")
                {
                    TaiKhoan obj = gridViewTaiKhoan.GetFocusedRow() as TaiKhoan;
                    if (obj != null)
                    {
                        using (frmXemNguoiDung frm = new frmXemNguoiDung(obj.MaTaiKhoan))
                        {
                            frm.ShowDialog();
                        }
                    }
                }

                if (view.FocusedColumn.FieldName == "PhanQuyen")
                {
                    TaiKhoan obj = gridViewTaiKhoan.GetFocusedRow() as TaiKhoan;
                    if (obj != null)
                    {
                        using (frmPhanQuyenTaiKhoan frm = new frmPhanQuyenTaiKhoan(obj.MaTaiKhoan))
                        {
                            frm.ShowDialog();
                        }
                    }
                }
            }
        }
    }
}