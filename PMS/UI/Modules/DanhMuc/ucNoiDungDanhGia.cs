using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.Entities.Validation;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucNoiDungDanhGia : DevExpress.XtraEditors.XtraUserControl
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

        public ucNoiDungDanhGia()
        {
            InitializeComponent();
        }

        private void ucNoiDungDanhGia_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewNoiDungDanhGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewNoiDungDanhGia, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewNoiDungDanhGia, new string[] { "MaQuanLy", "TenNoiDungDanhGia", "VietTat", "SoThuTu", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Mã quản lý", "Nội dung đánh giá", "Viết tắt", "Số thứ tự", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 90, 200, 120, 100, 99, 99 });
            AppGridView.AlignHeader(gridViewNoiDungDanhGia, new string[] { "MaQuanLy", "TenNoiDungDanhGia", "VietTat", "SoThuTu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewNoiDungDanhGia, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.HideField(gridViewNoiDungDanhGia, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            InitData();
        }

        void InitData()
        {
            bindingSourceNoiDungDanhGia.DataSource = DataServices.NoiDungDanhGia.GetAll();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewNoiDungDanhGia);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewNoiDungDanhGia.FocusedRowHandle = -1;
            TList<NoiDungDanhGia> list = bindingSourceNoiDungDanhGia.DataSource as TList<NoiDungDanhGia>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceNoiDungDanhGia.EndEdit();
                            DataServices.NoiDungDanhGia.Save(list);
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

        private void gridViewNoiDungDanhGia_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewNoiDungDanhGia, e);
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlNoiDungDanhGia.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void gridViewNoiDungDanhGia_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaQuanLy" || col.FieldName == "TenNoiDungDanhGia" || col.FieldName == "VietTat" || col.FieldName == "SoThuTu")
            {
                gridViewNoiDungDanhGia.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewNoiDungDanhGia.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            NoiDungDanhGia obj = target as NoiDungDanhGia;
            if (obj != null)
            {
                if (((TList<NoiDungDanhGia>)bindingSourceNoiDungDanhGia.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã quản lý {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewNoiDungDanhGia_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            NoiDungDanhGia obj = e.Row as NoiDungDanhGia;
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
    }
}
