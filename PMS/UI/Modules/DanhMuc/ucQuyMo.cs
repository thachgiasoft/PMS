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
    public partial class ucQuyMo : XtraUserControl
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

        public ucQuyMo()
        {
            InitializeComponent();
        }

        private void ucQuyMo_Load(object sender, EventArgs e)
        {
            #region Init GridView HocHam
            AppGridView.InitGridView(gridViewQuyMo, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewQuyMo, new string[] { "MaQuyMo", "TenQuyMo", "GhiChu" },
                new string[] { "Mã quy mô", "Tên quy mô", "Ghi chú" },
                new int[] { 100, 400, 200 });
            AppGridView.ShowEditor(gridViewQuyMo, NewItemRowPosition.Top);
            #endregion

            #region Init Datasource
            bindingSourceQuyMo.DataSource = DataServices.DanhMucQuyMo.GetAll();
            //PMS.Common.Globals.LoadLayout(Tag as AppModule, new object[] { gridViewHocHam, barManager1, layoutControl1 });
            #endregion

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMucQuyMo obj = bindingSourceQuyMo.Current as DanhMucQuyMo;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceQuyMo.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewQuyMo.RefreshData();
            }
        }

        private void gridViewHocHam_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewQuyMo, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewQuyMo.FocusedRowHandle = -1;
            TList<DanhMucQuyMo> list = bindingSourceQuyMo.DataSource as TList<DanhMucQuyMo>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceQuyMo.EndEdit();
                            DataServices.DanhMucQuyMo.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewQuyMo, barManager1, layoutControl1 });
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
            bindingSourceQuyMo.DataSource = DataServices.DanhMucQuyMo.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewHocHam_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewQuyMo, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            DanhMucQuyMo obj = target as DanhMucQuyMo;
            if (obj != null)
            {
                if (((TList<DanhMucQuyMo>)bindingSourceQuyMo.DataSource).FindAll(p => p.MaQuyMo == obj.MaQuyMo).Count > 1)
                {
                    e.Description = string.Format("Mã quy mô {0} hiện tại đã có.", obj.MaQuyMo);
                    return false;
                }
            }
            return true;
        }

        private void gridViewHocHam_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DanhMucQuyMo obj = e.Row as DanhMucQuyMo;
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

        private void gridViewHocHam_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewQuyMo);
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
                            gridControlQuyMo.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
    }
}