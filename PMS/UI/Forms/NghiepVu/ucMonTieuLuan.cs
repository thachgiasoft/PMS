using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class ucMonTieuLuan : DevExpress.XtraEditors.XtraUserControl
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

        #region Bien
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewMonHocKhoa> _listMonHoc;
        string _maTruong;
        #endregion
        public ucMonTieuLuan()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri.ToString();
        }

        private void ucMonTieuLuan_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewMonTieuLuan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewMonTieuLuan, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewMonTieuLuan, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "TenBoMon", "NgayCapNhat", "NguoiCapNhat" }
                        , new string[] { "Mã môn học", "Tên môn học", "Số tín chỉ", "Bộ môn", "Ngày cập nhật", "Người cập nhật" }
                        , new int[] { 100, 250, 100, 150, 99, 99 });
            AppGridView.AlignHeader(gridViewMonTieuLuan, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "TenBoMon", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewMonTieuLuan, "MaMonHoc", repositoryItemGridLookUpEditMonHoc);
            AppGridView.HideField(gridViewMonTieuLuan, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion
            #region MonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 450, 600);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "TenBoMon" }, new string[] { "Mã môn học", "Tên môn học", "STC", "Bộ môn" }, new int[] { 100, 150, 50, 150 });
            repositoryItemGridLookUpEditMonHoc.DisplayMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.ValueMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.NullText = string.Empty;
            #endregion
            InitData();
        }
        #region InitData
        void InitData()
        {
            _listMonHoc = DataServices.ViewMonHocKhoa.GetAll();
            bindingSourceMonHoc.DataSource = _listMonHoc;
            bindingSourceMonTieuLuan.DataSource = DataServices.MonTieuLuan.GetAll();
            
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewMonTieuLuan);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewMonTieuLuan.FocusedRowHandle = -1;
            TList<MonTieuLuan> list = bindingSourceMonTieuLuan.DataSource as TList<MonTieuLuan>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceMonTieuLuan.EndEdit();
                            DataServices.MonTieuLuan.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlMonTieuLuan.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void gridViewMonTieuLuan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaMonHoc")
            {
                int pos = e.RowHandle;
                MonTieuLuan r = gridViewMonTieuLuan.GetRow(pos) as MonTieuLuan;
                ViewMonHocKhoa v = _listMonHoc.Find(p => p.MaMonHoc == r.MaMonHoc);
                gridViewMonTieuLuan.SetRowCellValue(pos, "TenMonHoc", v.TenMonHoc);
                gridViewMonTieuLuan.SetRowCellValue(pos, "SoTinChi", v.SoTinChi);
                gridViewMonTieuLuan.SetRowCellValue(pos, "TenBoMon", v.TenBoMon);
                //gridViewMonTieuLuan.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                gridViewMonTieuLuan.SetRowCellValue(pos, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void gridViewMonTieuLuan_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewMonTieuLuan, e);
        }

    }
}
