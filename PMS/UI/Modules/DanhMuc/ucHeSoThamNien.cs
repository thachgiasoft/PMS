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
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoThamNien : DevExpress.XtraEditors.XtraUserControl
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

        public ucHeSoThamNien()
        {
            InitializeComponent();
        }

        private void ucHeSoThamNien_Load(object sender, EventArgs e)
        {
            #region Học hàm
            repositoryItemCheckedComboHocHam.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboHocHam.Items.Clear();
            repositoryItemCheckedComboHocHam.SeparatorChar = ';';
            repositoryItemCheckedComboHocHam.TextEditStyle = TextEditStyles.Standard;
            TList<HocHam> TlistHocHam = DataServices.HocHam.GetAll();
            List<CheckedListBoxItem> listHocHam = new List<CheckedListBoxItem>();
            foreach (HocHam v in TlistHocHam)
            {
                listHocHam.Add(new CheckedListBoxItem(v.MaHocHam, v.TenHocHam, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboHocHam.Items.AddRange(listHocHam.ToArray());
            #endregion

            #region Học vị
            repositoryItemCheckedComboHocVi.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboHocVi.Items.Clear();
            repositoryItemCheckedComboHocVi.SeparatorChar = ';';
            repositoryItemCheckedComboHocVi.TextEditStyle = TextEditStyles.Standard;
            TList<HocVi> TlistHocVi = DataServices.HocVi.GetAll();
            List<CheckedListBoxItem> listHocVi = new List<CheckedListBoxItem>();
            foreach (HocVi v in TlistHocVi)
            {
                listHocHam.Add(new CheckedListBoxItem(v.MaHocVi, v.TenHocVi, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboHocVi.Items.AddRange(listHocHam.ToArray());
            #endregion

            #region Init Grid
            AppGridView.InitGridView(gridViewHeSoThamNien, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewHeSoThamNien, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewHeSoThamNien, new string[] { "MaHocHam", "MaHocVi", "TuNam", "DenNam", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "Học hàm", "Học vị", "Từ năm", "Đến năm", "Hệ số", "Ghi chú", "Ngày cập nhật", "Người cập nhật" }, new int[] { 100, 100, 80, 80, 80, 150, 99, 99 });
            AppGridView.AlignHeader(gridViewHeSoThamNien, new string[] { "MaHocHam", "MaHocVi", "TuNam", "DenNam", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSoThamNien, "MaHocHam", repositoryItemCheckedComboHocHam);
            AppGridView.RegisterControlField(gridViewHeSoThamNien, "MaHocVi", repositoryItemCheckedComboHocVi);
            AppGridView.RegisterControlField(gridViewHeSoThamNien, "TuNam", repositoryItemSpinEditTuNam);
            AppGridView.RegisterControlField(gridViewHeSoThamNien, "DenNam", repositoryItemSpinEditDenNam);
            AppGridView.RegisterControlField(gridViewHeSoThamNien, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.HideField(gridViewHeSoThamNien, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion

            bindingSourceHeSoThamNien.DataSource = DataServices.HeSoThamNien.GetAll();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceHeSoThamNien.DataSource = DataServices.HeSoThamNien.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoThamNien);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewHeSoThamNien.FocusedRowHandle = -1;
            TList<HeSoThamNien> list = bindingSourceHeSoThamNien.DataSource as TList<HeSoThamNien>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHeSoThamNien.EndEdit();
                            DataServices.HeSoThamNien.Save(list);
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
            Cursor.Current = Cursors.Default;
        }

        private void gridViewHeSoThamNien_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "TuNam" || col.FieldName == "DenNam" || col.FieldName == "HeSo" || col.FieldName == "GhiChu")
            {
                gridViewHeSoThamNien.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                gridViewHeSoThamNien.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void gridViewHeSoThamNien_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoThamNien, e);
        }
    }
}
