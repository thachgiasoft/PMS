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
    public partial class ucLoaiGiangVien : XtraUserControl
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

        public ucLoaiGiangVien()
        {
            InitializeComponent();
        }

        private void ucLoaiGiangVien_Load(object sender, EventArgs e)
        {
            #region Init GridView LoaiGiangVien
            AppGridView.InitGridView(gridViewLoaiGiangVien, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewLoaiGiangVien, new string[] { "ThuTu", "MaQuanLy", "TenLoaiGiangVien" },
                new string[] { "STT", "Mã loại giảng viên", "Tên loại giảng viên" },
                new int[] { 70, 150, 300 });
            //AppGridView.RegisterControlField(gridViewLoaiGiangVien, "TienThem", repositoryItemSpinEditTienThem);
            AppGridView.ShowEditor(gridViewLoaiGiangVien, NewItemRowPosition.Top);
            #endregion

            #region Init Datasource
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            //PMS.Common.Globals.LoadLayout(Tag as AppModule, new object[] { gridViewLoaiGiangVien, barManager1, layoutControl1 });
            #endregion
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoaiGiangVien obj = bindingSourceLoaiGiangVien.Current as LoaiGiangVien;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceLoaiGiangVien.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewLoaiGiangVien.RefreshData();
            }
        }

        private void gridViewLoaiGiangVien_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewLoaiGiangVien, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewLoaiGiangVien.FocusedRowHandle = -1;
            TList<LoaiGiangVien> list = bindingSourceLoaiGiangVien.DataSource as TList<LoaiGiangVien>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceLoaiGiangVien.EndEdit();
                            DataServices.LoaiGiangVien.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewLoaiGiangVien, barManager1, layoutControl1 });
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
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewLoaiGiangVien_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewLoaiGiangVien, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            LoaiGiangVien obj = target as LoaiGiangVien;
            if (obj != null)
            {
                if (((TList<LoaiGiangVien>)bindingSourceLoaiGiangVien.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã loại giảng viên {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewLoaiGiangVien_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            LoaiGiangVien obj = e.Row as LoaiGiangVien;
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

        private void gridViewLoaiGiangVien_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewLoaiGiangVien);
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
                    gridControlLoaiGiangVien.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}