using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.Entities;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmChiTietPhanCongDoAnTotNghiep : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        string MaLopHocPhan, TenMonHoc, NamHoc, HocKy;
        int kiemtra = 0;
        #endregion

        #region Event Form
        public frmChiTietPhanCongDoAnTotNghiep()
        {
            InitializeComponent();
        }

        public frmChiTietPhanCongDoAnTotNghiep(string _maLopHocPhan, string _tenMonHoc, string _namHoc, string _hocKy)
        {
            InitializeComponent();
            MaLopHocPhan = _maLopHocPhan;
            TenMonHoc = _tenMonHoc;
            NamHoc = _namHoc;
            HocKy = _hocKy;
        }

        private void frmChiTietPhanCongDoAnTotNghiep_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewChiTietPhanCong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewChiTietPhanCong, new string[] { "MaSinhVien", "HoTen", "GiangVienHuongDan", "GiangVienPhanBien1", "GiangVienPhanBien2", "GhiChu", "NgayCapNhat" }
                    , new string[] { "Mã sinh viên", "Họ tên", "Giảng viên hướng dẫn", "Giảng viên phản biện 1", "Giảng viên phản biện 2", "Ghi chú", "Ngày cập nhật" }
                    , new int[] { 100, 150, 150, 150, 150, 80, 90 });
            AppGridView.HideField(gridViewChiTietPhanCong, new string[] { "NgayCapNhat" });
            AppGridView.AlignHeader(gridViewChiTietPhanCong, new string[] { "MaSinhVien", "HoTen", "GiangVienHuongDan", "GiangVienPhanBien1", "GiangVienPhanBien2", "GhiChu", "NgayCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewChiTietPhanCong, "MaSinhVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.RegisterControlField(gridViewChiTietPhanCong, "GiangVienHuongDan", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewChiTietPhanCong, "GiangVienPhanBien1", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewChiTietPhanCong, "GiangVienPhanBien2", repositoryItemGridLookUpEditGiangVien);
            AppGridView.ReadOnlyColumn(gridViewChiTietPhanCong, new string[] { "MaSinhVien", "HoTen" });
            #endregion
            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien" }, new string[] { "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Loại giảng viên" }, new int[] { 90, 150, 120, 120, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 600, 600);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "HoTen";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion
            InitData();
        }
        #endregion
        #region InitData()
        void InitData()
        {
            bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetAll();
            txtTitle.Text = String.Format("{0} - {1}", MaLopHocPhan, TenMonHoc);
            if (MaLopHocPhan != null || MaLopHocPhan != "")
                bindingSourceChiTietPhanCong.DataSource = DataServices.PhanCongDoAnTotNghiep.GetByMaLopHocPhan(MaLopHocPhan);
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataServices.ChotKhoiLuongGiangDay.KiemTra(NamHoc, HocKy, "DATN", ref kiemtra);
            if (kiemtra == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép sửa đổi.", NamHoc, HocKy), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            gridViewChiTietPhanCong.FocusedRowHandle = -1;
            TList<PhanCongDoAnTotNghiep> list = bindingSourceChiTietPhanCong.DataSource as TList<PhanCongDoAnTotNghiep>;
            if (list != null)
            {
                try
                {
                    //foreach (PhanCongDoAnTotNghiep pc in list)
                    //{ 
                    //    pc.MaLopHocPhan
                    //}
                    bindingSourceChiTietPhanCong.EndEdit();
                    DataServices.PhanCongDoAnTotNghiep.Save(list);
                    XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void gridViewChiTietPhanCong_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "GiangVienHuongDan" || col.FieldName == "GiangVienPhanBien1" || col.FieldName == "GiangVienPhanBien2" || col.FieldName == "GhiChu")
            {
                PhanCongDoAnTotNghiep pc = (PhanCongDoAnTotNghiep)gridViewChiTietPhanCong.GetRow(e.RowHandle);
                gridViewChiTietPhanCong.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
            }
        }

        private void frmChiTietPhanCongDoAnTotNghiep_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (gridViewChiTietPhanCong.EditingValueModified == true)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnLuu.PerformClick();
                    this.Close();
                }
                else
                    this.Close();
                this.Dispose();
            }
        }
    }
}