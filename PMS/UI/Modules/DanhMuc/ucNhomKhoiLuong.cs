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
    public partial class ucNhomKhoiLuong : XtraUserControl
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

        public ucNhomKhoiLuong()
        {
            InitializeComponent();
        }

        private void ucNhomKhoiLuong_Load(object sender, EventArgs e)
        {
            #region Init GridView Nhom khoi luong
            AppGridView.InitGridView(gridNhomLoaiKhoiLuong, true, true, GridMultiSelectMode.CellSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridNhomLoaiKhoiLuong, new string[] { "MaQuanLy", "TenNhom" },
                new string[] { "Mã nhóm", "Tên nhóm" },
                new int[] { 100, 250 });
            AppGridView.ShowEditor(gridNhomLoaiKhoiLuong, NewItemRowPosition.Top);
            #endregion

            #region Init Datasource
            bindingSourceNhomKhoiLuong.DataSource = DataServices.NhomKhoiLuong.GetAll();
            //PMS.Common.Globals.LoadLayout(Tag as AppModule, new object[] { gridNhomLoaiKhoiLuong, barManager1, layoutControl1 });
            #endregion
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhomKhoiLuong obj = bindingSourceNhomKhoiLuong.Current as NhomKhoiLuong;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceNhomKhoiLuong.Remove(obj);
                else
                    obj.CancelChanges();
                gridNhomLoaiKhoiLuong.RefreshData();
            }
        }

        private void gridViewNhomKhoiLuong_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridNhomLoaiKhoiLuong, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridNhomLoaiKhoiLuong.FocusedRowHandle = -1;
            TList<NhomKhoiLuong> list = bindingSourceNhomKhoiLuong.DataSource as TList<NhomKhoiLuong>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceNhomKhoiLuong.EndEdit();
                            DataServices.NhomKhoiLuong.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridNhomLoaiKhoiLuong, barManager1, layoutControl1 });
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
            bindingSourceNhomKhoiLuong.DataSource = DataServices.NhomKhoiLuong.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewNhomKhoiLuong_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridNhomLoaiKhoiLuong, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            NhomKhoiLuong obj = target as NhomKhoiLuong;
            if (obj != null)
            {
                if (((TList<NhomKhoiLuong>)bindingSourceNhomKhoiLuong.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã nhóm {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewNhomKhoiLuong_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            NhomKhoiLuong obj = e.Row as NhomKhoiLuong;
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

        private void gridViewNhomKhoiLuong_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridNhomLoaiKhoiLuong);
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlNhomKhoiLuong.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}