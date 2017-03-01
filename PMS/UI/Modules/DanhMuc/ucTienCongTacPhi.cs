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
    public partial class ucTienCongTacPhi : DevExpress.XtraEditors.XtraUserControl
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

        #region Variable
        VList<ViewCoSo> _listCoSo;
        #endregion
        public ucTienCongTacPhi()
        {
            InitializeComponent();
        }

        private void ucTienCongTacPhi_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewTienCongTacPhi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewTienCongTacPhi, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewTienCongTacPhi, new string[] { "MaCoSo", "TenCoSo", "SoTien", "GhiChu" }
                    , new string[] { "Mã cơ sở", "Tên cơ sở", "Mức chi", "Ghi chú" }
                    , new int[] { 80, 200, 120, 150 });
            AppGridView.AlignHeader(gridViewTienCongTacPhi, new string[] { "MaCoSo", "TenCoSo", "SoTien", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewTienCongTacPhi, new string[] { "TenCoSo" });
            AppGridView.RegisterControlField(gridViewTienCongTacPhi, "MaCoSo", repositoryItemGridLookUpEditCoSo);
            AppGridView.RegisterControlField(gridViewTienCongTacPhi, "SoTien", repositoryItemSpinEditSoTien);
            AppGridView.FormatDataField(gridViewTienCongTacPhi, "SoTien", DevExpress.Utils.FormatType.Custom, "n0");
            #endregion

            #region Init DoiTuong
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditCoSo, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditCoSo, new string[] { "MaCoSo", "TenCoSo", "DiaChi" }, new string[] { "Mã cơ sở", "Tên cơ sở", "Địa chỉ" }, new int[] { 80, 160, 260 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditCoSo, 500, 650);
            repositoryItemGridLookUpEditCoSo.DisplayMember = "MaCoSo";
            repositoryItemGridLookUpEditCoSo.ValueMember = "MaCoSo";
            repositoryItemGridLookUpEditCoSo.NullText = string.Empty;
            #endregion
            InitData();
        }
        #region InitData
        void InitData()
        {
            _listCoSo = DataServices.ViewCoSo.GetAll();
            bindingSourceCoSo.DataSource = _listCoSo;
            bindingSourceTienCongTacPhi.DataSource = DataServices.TienCongTacPhi.GetAll();
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
            AppGridView.DeleteSelectedRows(gridViewTienCongTacPhi);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewTienCongTacPhi.FocusedRowHandle = -1;
            TList<TienCongTacPhi> list = bindingSourceTienCongTacPhi.DataSource as TList<TienCongTacPhi>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceTienCongTacPhi.EndEdit();
                            DataServices.TienCongTacPhi.Save(list);
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
                    gridControlTienCongTacPhi.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void gridViewTienCongTacPhi_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            int pos = e.RowHandle;
            if (col.FieldName == "MaCoSo")
            {
                TienCongTacPhi dg = (TienCongTacPhi)gridViewTienCongTacPhi.GetRow(pos);
                string _tenCoSo = _listCoSo.Find(p => p.MaCoSo == dg.MaCoSo).TenCoSo;
                string _diaChi = _listCoSo.Find(p => p.MaCoSo == dg.MaCoSo).DiaChi;
                gridViewTienCongTacPhi.SetRowCellValue(pos, "TenCoSo", _tenCoSo);
                gridViewTienCongTacPhi.SetRowCellValue(pos, "GhiChu", _diaChi);
            }
        }

        private void gridViewTienCongTacPhi_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewTienCongTacPhi, e);
        }
    }
}
