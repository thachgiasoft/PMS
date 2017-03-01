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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMuc.KhongChinhQuy
{
    public partial class ucHeSoQuyDoiTinChi_Kcq : DevExpress.XtraEditors.XtraUserControl
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

        public ucHeSoQuyDoiTinChi_Kcq()
        {
            InitializeComponent();
        }

        private void ucHeSoQuyDoiTinChi_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewHeSoQuyDoiTinChi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoQuyDoiTinChi, new string[] { "LoaiHocPhan", "SoTinChi", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }
                , new string[] { "Loại học phần", "Số tín chỉ", "Hệ số", "Ghi chú", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 150, 90, 90, 200, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSoQuyDoiTinChi, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoQuyDoiTinChi, new string[] { "LoaiHocPhan", "SoTinChi", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewHeSoQuyDoiTinChi, "LoaiHocPhan", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.HideField(gridViewHeSoQuyDoiTinChi, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.RegisterControlField(gridViewHeSoQuyDoiTinChi, "LoaiHocPhan", repositoryItemCheckedComboBoxEditLoaiHocPhan);
            AppGridView.RegisterControlField(gridViewHeSoQuyDoiTinChi, "SoTinChi", repositoryItemSpinEditSTC);
            AppGridView.RegisterControlField(gridViewHeSoQuyDoiTinChi, "HeSo", repositoryItemSpinEditHeSo);
            #endregion

            InitData();
        }

        void InitData()
        {
            bindingSourceHeSo.DataSource = DataServices.KcqHeSoQuyDoiTinChi.GetAll();
            TList<LoaiKhoiLuong> _listLoaiKhoiLuong = DataServices.LoaiKhoiLuong.GetAll();
            repositoryItemCheckedComboBoxEditLoaiHocPhan.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditLoaiHocPhan.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditLoaiHocPhan.Items.Clear();
            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (LoaiKhoiLuong l in _listLoaiKhoiLuong)
                _list.Add(new CheckedListBoxItem(l.MaLoaiKhoiLuong, l.TenLoaiKhoiLuong, CheckState.Unchecked, true));
            repositoryItemCheckedComboBoxEditLoaiHocPhan.Items.AddRange(_list.ToArray());
            repositoryItemCheckedComboBoxEditLoaiHocPhan.SeparatorChar = ';';
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoQuyDoiTinChi);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoQuyDoiTinChi.FocusedRowHandle = -1;
            TList<KcqHeSoQuyDoiTinChi> list = bindingSourceHeSo.DataSource as TList<KcqHeSoQuyDoiTinChi>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHeSo.EndEdit();
                            DataServices.KcqHeSoQuyDoiTinChi.Save(list);
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
                        gridControlHeSoQuyDoiTinChi.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void gridViewHeSoQuyDoiTinChi_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "LoaiHocPhan" || col.FieldName == "SoTinChi" || col.FieldName == "HeSo" || col.FieldName == "GhiChu")
            {
                gridViewHeSoQuyDoiTinChi.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewHeSoQuyDoiTinChi.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void gridViewHeSoQuyDoiTinChi_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoQuyDoiTinChi, e);
        }
    }
}
