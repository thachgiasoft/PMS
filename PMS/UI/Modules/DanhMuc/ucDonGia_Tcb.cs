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

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucDonGia_Tcb : DevExpress.XtraEditors.XtraUserControl
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

        VList<ViewDoiTuongDonGia> _listDoiTuongDonGia;

        public ucDonGia_Tcb()
        {
            InitializeComponent();
        }

        private void ucDonGia_Tcb_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewDonGiaTcb, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDonGiaTcb, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDonGiaTcb, new string[] { "MaDonGia", "TenDonGia", "DonGia", "GhiChu" }
                    , new string[] { "Mã quản lý", "Đối tượng", "Mức chi/1 tiết", "Ghi chú" }
                    , new int[] { 80, 200, 120, 150 });
            AppGridView.AlignHeader(gridViewDonGiaTcb, new string[] { "MaDonGia", "TenDonGia", "DonGia", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewDonGiaTcb, new string[] { "TenDonGia" });
            AppGridView.RegisterControlField(gridViewDonGiaTcb, "MaDonGia", repositoryItemGridLookUpEditDoiTuong);
            AppGridView.RegisterControlField(gridViewDonGiaTcb, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.FormatDataField(gridViewDonGiaTcb, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            #endregion

            #region Init DoiTuong
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDoiTuong, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDoiTuong, new string[] { "MaQuanLy", "TenGoi" }, new string[] { "Mã quản lý", "Đối tượng" }, new int[] { 80, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditDoiTuong, 280, 650);
            repositoryItemGridLookUpEditDoiTuong.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditDoiTuong.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditDoiTuong.NullText = string.Empty;
            #endregion
            InitData();
        }
        #region InitData
        void InitData()
        {
            _listDoiTuongDonGia = DataServices.ViewDoiTuongDonGia.GetAll();
            bindingSourceDoiTuongDonGia.DataSource = _listDoiTuongDonGia;
            bindingSourceDonGiaTcb.DataSource = DataServices.DonGiaTcb.GetAll();
        }
        #endregion
        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGiaTcb);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewDonGiaTcb.FocusedRowHandle = -1;
            TList<DonGiaTcb> list = bindingSourceDonGiaTcb.DataSource as TList<DonGiaTcb>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceDonGiaTcb.EndEdit();
                            DataServices.DonGiaTcb.Save(list);
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

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlDonGiaTcb.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }
        #endregion
        #region Event Grid
        private void gridViewDonGiaTcb_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            int pos = e.RowHandle;
            if (col.FieldName == "MaDonGia")
            {
                DonGiaTcb dg = (DonGiaTcb)gridViewDonGiaTcb.GetRow(pos);
                string _tenDonGia = _listDoiTuongDonGia.Find(p => p.MaQuanLy == dg.MaDonGia).TenGoi;
                gridViewDonGiaTcb.SetRowCellValue(pos, "TenDonGia", _tenDonGia);
            }
        }

        private void gridViewDonGiaTcb_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGiaTcb, e);
        }
        #endregion
    }
}
