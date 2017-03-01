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
    public partial class ucTinhTrangGiangDay : XtraUserControl
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

        public ucTinhTrangGiangDay()
        {
            InitializeComponent();
        }

        private void ucTinhTrangGiangDay_Load(object sender, EventArgs e)
        {
            #region Init GridView TinhTrangGiangDay
            AppGridView.InitGridView(gridViewTinhTrangGiangDay, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewTinhTrangGiangDay, new string[] { "ThuTu", "MaQuanLy", "TenTinhTrang" },
                new string[] { "STT", "Mã tình trạng", "Tên tình trạng" },
                new int[] { 70, 100, 300 });
            AppGridView.ShowEditor(gridViewTinhTrangGiangDay, NewItemRowPosition.Top);
            #endregion

            #region Init Datasource
            bindingSourceTinhTrangGiangDay.DataSource = DataServices.TinhTrang.GetAll();
            //PMS.Common.Globals.LoadLayout(Tag as AppModule, new object[] { gridViewTinhTrangGiangDay, barManager1, layoutControl1 });
            #endregion
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TinhTrang obj = bindingSourceTinhTrangGiangDay.Current as TinhTrang;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceTinhTrangGiangDay.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewTinhTrangGiangDay.RefreshData();
            }
        }

        private void gridViewTinhTrangGiangDay_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewTinhTrangGiangDay, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewTinhTrangGiangDay.FocusedRowHandle = -1;
            TList<TinhTrang> list = bindingSourceTinhTrangGiangDay.DataSource as TList<TinhTrang>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceTinhTrangGiangDay.EndEdit();
                            DataServices.TinhTrang.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewTinhTrangGiangDay, barManager1, layoutControl1 });
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Dòng dữ liệu này đang được sử dụng, không được phép xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceTinhTrangGiangDay.DataSource = DataServices.TinhTrang.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewTinhTrangGiangDay_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewTinhTrangGiangDay, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            TinhTrang obj = target as TinhTrang;
            if (obj != null)
            {
                if (((TList<TinhTrang>)bindingSourceTinhTrangGiangDay.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã tình trạng {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewTinhTrangGiangDay_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            TinhTrang obj = e.Row as TinhTrang;
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

        private void gridViewTinhTrangGiangDay_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewTinhTrangGiangDay);
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlTinhTrangGiangDay.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}