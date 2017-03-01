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
    public partial class ucMucDoHoanThanhNCKH : XtraUserControl
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

        public ucMucDoHoanThanhNCKH()
        {
            InitializeComponent();
        }

        private void ucMucDoHoanThanhNCKH_Load(object sender, EventArgs e)
        {
            #region Init GridView MucDoHoanThanhNckh
            AppGridView.InitGridView(gridViewMucDoHoanThanhNckh, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewMucDoHoanThanhNckh, new string[] { "ThuTu", "MaQuanLy", "TenMucDoHoanThanhNckh" },
                new string[] { "STT", "Mã học hàm", "Tên học hàm" },
                new int[] { 70, 100, 300 });
            AppGridView.ShowEditor(gridViewMucDoHoanThanhNckh, NewItemRowPosition.Top);
            #endregion

            #region Init Datasource
            bindingSourceMucDo.DataSource = DataServices.MucDoHoanThanhNckh.GetAll();
            //PMS.Common.Globals.LoadLayout(Tag as AppModule, new object[] { gridViewMucDoHoanThanhNckh, barManager1, layoutControl1 });
            #endregion

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MucDoHoanThanhNckh obj = bindingSourceMucDo.Current as MucDoHoanThanhNckh;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceMucDo.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewMucDoHoanThanhNckh.RefreshData();
            }
        }

        private void gridViewMucDoHoanThanhNckh_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewMucDoHoanThanhNckh, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewMucDoHoanThanhNckh.FocusedRowHandle = -1;
            TList<MucDoHoanThanhNckh> list = bindingSourceMucDo.DataSource as TList<MucDoHoanThanhNckh>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceMucDo.EndEdit();
                            DataServices.MucDoHoanThanhNckh.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewMucDoHoanThanhNckh, barManager1, layoutControl1 });
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
            bindingSourceMucDo.DataSource = DataServices.MucDoHoanThanhNckh.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewMucDoHoanThanhNckh_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewMucDoHoanThanhNckh, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            MucDoHoanThanhNckh obj = target as MucDoHoanThanhNckh;
            if (obj != null)
            {
                if (((TList<MucDoHoanThanhNckh>)bindingSourceMucDo.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã học hàm {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewMucDoHoanThanhNckh_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            MucDoHoanThanhNckh obj = e.Row as MucDoHoanThanhNckh;
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

        private void gridViewMucDoHoanThanhNckh_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewMucDoHoanThanhNckh);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlMucDoHoanThanhNckh.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
    }
}