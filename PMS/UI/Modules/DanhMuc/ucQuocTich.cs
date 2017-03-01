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
    public partial class ucQuocTich : XtraUserControl
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

        public ucQuocTich()
        {
            InitializeComponent();
        }

        private void ucQuocTich_Load(object sender, EventArgs e)
        {
            #region Init GridView QuocTich
            AppGridView.InitGridView(gridViewQuocTich, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewQuocTich, new string[] { "MaQuocTich", "TenQuocTich" },
                new string[] { "Mã quốc tịch", "Tên quốc tịch" },
                new int[] { 100, 300 });
            AppGridView.ShowEditor(gridViewQuocTich, NewItemRowPosition.Top);
            #endregion

            #region Init Datasource
            bindingSourceQuocTich.DataSource = DataServices.QuocTich.GetAll();
            //PMS.Common.Globals.LoadLayout(Tag as AppModule, new object[] { gridViewHocHam, barManager1, layoutControl1 });
            #endregion

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuocTich obj = bindingSourceQuocTich.Current as QuocTich;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceQuocTich.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewQuocTich.RefreshData();
            }
        }

        private void gridViewHocHam_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewQuocTich, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewQuocTich.FocusedRowHandle = -1;
            TList<QuocTich> list = bindingSourceQuocTich.DataSource as TList<QuocTich>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceQuocTich.EndEdit();
                            DataServices.QuocTich.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewQuocTich, barManager1, layoutControl1 });
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
            bindingSourceQuocTich.DataSource = DataServices.QuocTich.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewHocHam_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewQuocTich, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            QuocTich obj = target as QuocTich;
            if (obj != null)
            {
                if (((TList<QuocTich>)bindingSourceQuocTich.DataSource).FindAll(p => p.MaQuocTich == obj.MaQuocTich).Count > 1)
                {
                    e.Description = string.Format("Mã quốc tịch {0} hiện tại đã có.", obj.MaQuocTich);
                    return false;
                }
            }
            return true;
        }

        private void gridViewHocHam_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            QuocTich obj = e.Row as QuocTich;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaQuocTich");
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
            AppGridView.DeleteSelectedRows(gridViewQuocTich);
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
                            gridControlQuocTich.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
    }
}