using System;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities.Validation;
using PMS.Core;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoNgay : XtraUserControl
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

        public ucHeSoNgay()
        {
            InitializeComponent();
        }

        private void ucHeSoNgay_Load(object sender, EventArgs e)
        {
            #region Init GridView HeSoNgay
            AppGridView.InitGridView(gridViewHeSoNgay, true, true, GridMultiSelectMode.CellSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoNgay, new string[] { "ThuTu", "MaQuanLy", "TenHeSo", "MaBuoi", "TenBuoi", "TietBatDau", "TietKetThuc", "TrongGio", "HeSo", "TietNghiaVu" },
                new string[] { "STT", "Mã hệ số", "Tên hệ số", "Mã buổi", "Tên buổi", "Từ tiết", "Đến tiết", "Trong giờ", "Hệ số", "Nghĩa vụ" },
                new int[] { 70, 90, 100, 90, 100, 70, 70, 70, 60, 80 });
            AppGridView.RegisterControlField(gridViewHeSoNgay, "TietBatDau", repositoryItemSpinEditTuTiet);
            AppGridView.RegisterControlField(gridViewHeSoNgay, "TietKetThuc", repositoryItemSpinEditDenTiet);
            AppGridView.RegisterControlField(gridViewHeSoNgay, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.UnSortField(gridViewHeSoNgay, new string[] { "TietNghiaVu", "TrongGio" });
            AppGridView.ShowEditor(gridViewHeSoNgay, NewItemRowPosition.Top);
            #endregion

            #region Init Datasource
            bindingSourceHeSoNgay.DataSource = DataServices.HeSoNgay.GetAll();
            PMS.Common.Globals.LoadLayout(Tag as AppModule, new object[] { gridViewHeSoNgay, barManager1, layoutControl1 });
            #endregion
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeSoNgay obj = bindingSourceHeSoNgay.Current as HeSoNgay;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceHeSoNgay.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewHeSoNgay.RefreshData();
            }
        }

        private void gridViewHeSoNgay_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoNgay, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoNgay.FocusedRowHandle = -1;
            TList<HeSoNgay> list = bindingSourceHeSoNgay.DataSource as TList<HeSoNgay>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHeSoNgay.EndEdit();
                            DataServices.HeSoNgay.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewHeSoNgay, barManager1, layoutControl1 });
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
            bindingSourceHeSoNgay.DataSource = DataServices.HeSoNgay.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewHeSoNgay_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHeSoNgay, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            HeSoNgay obj = target as HeSoNgay;
            if (obj != null)
            {
                if (((TList<HeSoNgay>)bindingSourceHeSoNgay.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy && p.MaBuoi == obj.MaBuoi).Count > 1)
                {
                    e.Description = string.Format("Giá trị này hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewHeSoNgay_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            HeSoNgay obj = e.Row as HeSoNgay;
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

        private void gridViewHeSoNgay_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoNgay);
        }

        private void gridViewHeSoNgay_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            HeSoNgay obj = gridViewHeSoNgay.GetRow(e.RowHandle) as HeSoNgay;
            if (obj != null)
            {
                obj.TietNghiaVu = false;
                obj.TrongGio = false;
            }
        }
    }
}