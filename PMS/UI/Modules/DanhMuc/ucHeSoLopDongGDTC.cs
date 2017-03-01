using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using DevExpress.Common.Grid;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoLopDongGDTC : DevExpress.XtraEditors.XtraUserControl
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
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        #endregion

        public ucHeSoLopDongGDTC()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucHeSoLopDongGDTC_Load(object sender, EventArgs e)
        {
            #region Init Gridview
            AppGridView.InitGridView(gridViewHeSo, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSo, new string[] {  "MaNhomMonHoc", "TuKhoan", "DenKhoan", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "Nhóm môn học", "Từ khoản", "Đến khoản", "Hệ số", "Ghi chú", "Ngày cập nhật", "Người cập nhật" },
                        new int[] {  180, 100, 100, 100, 200, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSo, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSo, new string[] {  "MaNhomMonHoc", "TuKhoan", "DenKhoan", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSo, "MaNhomMonHoc", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.RegisterControlField(gridViewHeSo, "TuKhoan", repositoryItemSpinEditTuKhoan);
            AppGridView.RegisterControlField(gridViewHeSo, "DenKhoan", repositoryItemSpinEditDenKhoan);
            AppGridView.RegisterControlField(gridViewHeSo, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.FormatDataField(gridViewHeSo, "HeSo", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.HideField(gridViewHeSo, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion

            #region Init NhomMonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomMonHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditNhomMonHoc, 300, 500);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomMonHoc, new string[] { "MaQuanLy", "TenNhomMon" }, new string[] { "Mã nhóm môn học", "Tên nhóm môn học" }, new int[] { 100, 200 });
            repositoryItemGridLookUpEditNhomMonHoc.DisplayMember = "TenNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.ValueMember = "MaNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceNhomMonHoc.DataSource = DataServices.NhomMonHoc.GetAll();
            bindingSourceHeSo.DataSource = DataServices.HeSoNhomThucHanh.GetAll();
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
            AppGridView.DeleteSelectedRows(gridViewHeSo);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSo.FocusedRowHandle = -1;
            TList<HeSoNhomThucHanh> list = bindingSourceHeSo.DataSource as TList<HeSoNhomThucHanh>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            
                            bindingSourceHeSo.EndEdit();
                            DataServices.HeSoNhomThucHanh.Save(list);
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
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlHeSo.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewHeSo_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "TuKhoan" || col.FieldName == "DenKhoan" || col.FieldName == "HeSo")
            {
                gridViewHeSo.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewHeSo.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void gridViewHeSo_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSo, e);
        }

  
    }
}
