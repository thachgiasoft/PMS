using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmGiamTruGioChuan : DevExpress.XtraEditors.XtraForm
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

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewGiangVien> _listGiangVien = new VList<ViewGiangVien>();
        public frmGiamTruGioChuan()
        {
            InitializeComponent();
        }

        private void frmGiamTruGioChuan_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewGiamTru, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewGiamTru, new string[] { "MaGiangVien", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "GioGiamChatLuongCao", "GioGiamSauDaiHoc", "GioGiamNckh", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Loại giảng viên", "Giờ giảm CLC", "Giờ giảm SĐH", "Giờ giảm NCKH", "Ghi chú", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 90, 140, 100, 100, 100, 100, 100, 100, 150, 99, 99 });
            AppGridView.ShowEditor(gridViewGiamTru, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewGiamTru, new string[] { "MaGiangVien", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "GioGiamChatLuongCao", "GioGiamSauDaiHoc", "GioGiamNckh", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewGiamTru, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewGiamTru, "GioGiamChatLuongCao", repositoryItemSpinEditGiamCLC);
            AppGridView.RegisterControlField(gridViewGiamTru, "GioGiamSauDaiHoc", repositoryItemSpinEditGiamSDH);
            AppGridView.RegisterControlField(gridViewGiamTru, "GioGiamNckh", repositoryItemSpinEditGiamNCKH);
            AppGridView.HideField(gridViewGiamTru, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.ReadOnlyColumn(gridViewGiamTru, new string[] { "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien" });
            #endregion
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            #region Khoa-DonVi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa - đơn vị", "Tên khoa - đơn vị" });
            cboKhoaDonVi.Properties.ValueMember = "MaKhoa";
            cboKhoaDonVi.Properties.DisplayMember = "TenKhoa";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            cboKhoaDonVi.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 530, 650);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien" }, new string[] { "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Loại giảng viên" }, new int[] { 90, 140, 100, 100, 100 });
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion
            InitData();
        }
        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            cboKhoaDonVi.DataBindings.Clear();
            bindingSourceKhoaDonVi.DataSource = DataServices.ViewKhoa.GetAll();
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);
            if (cboKhoaDonVi.EditValue != null)
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
            bindingSourceGiangVien.DataSource = _listGiangVien;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                bindingSourceGiamTru.DataSource = DataServices.ViewGiamTruGioChuan.GetByNamHocHocKyKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());       
            }
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
            AppGridView.DeleteSelectedRows(gridViewGiamTru);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewGiamTru.FocusedRowHandle = -1;
            VList<ViewGiamTruGioChuan> list = bindingSourceGiamTru.DataSource as VList<ViewGiamTruGioChuan>;
            if (list.Count > 0)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        string xmlData = "";
                        foreach (ViewGiamTruGioChuan cv in list)
                        {

                            xmlData += String.Format("<Input M=\"{0}\" CLC=\"{1}\" SDH=\"{2}\" NCKH=\"{3}\" GC=\"{4}\" N=\"{5}\" U=\"{6}\" />", cv.MaGiangVien, cv.GioGiamChatLuongCao, cv.GioGiamSauDaiHoc, cv.GioGiamNckh, cv.GhiChu, cv.NgayCapNhat, cv.NguoiCapNhat);
                        }
                        bindingSourceGiamTru.EndEdit();
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);

                        int kq = 0;
                        DataServices.ViewGiamTruGioChuan.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog file = new SaveFileDialog())
            {
                file.Filter = "(*.xls)|*.xls";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (file.FileName != "")
                    {
                        gridControlGiamTru.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion
        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                bindingSourceGiamTru.DataSource = DataServices.ViewGiamTruGioChuan.GetByNamHocHocKyKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                bindingSourceGiamTru.DataSource = DataServices.ViewGiamTruGioChuan.GetByNamHocHocKyKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboKhoaDonVi.EditValue != null)
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
            bindingSourceGiangVien.DataSource = _listGiangVien;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                bindingSourceGiamTru.DataSource = DataServices.ViewGiamTruGioChuan.GetByNamHocHocKyKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion
        #region Event Grid
        private void gridViewGiamTru_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVien")
            {
                ViewGiamTruGioChuan gt = gridViewGiamTru.GetRow(e.RowHandle) as ViewGiamTruGioChuan;
                ViewGiangVien gv = _listGiangVien.Find(p => p.MaGiangVien == gt.MaGiangVien);
                gridViewGiamTru.SetRowCellValue(e.RowHandle, "HoTen", gv.HoTen);
                gridViewGiamTru.SetRowCellValue(e.RowHandle, "TenHocHam", gv.TenHocHam);
                gridViewGiamTru.SetRowCellValue(e.RowHandle, "TenHocVi", gv.TenHocVi);
                gridViewGiamTru.SetRowCellValue(e.RowHandle, "TenLoaiGiangVien", gv.TenLoaiGiangVien);
            }
            if (col.FieldName == "MaGiangVien" || col.FieldName == "GioGiamChatLuongCao" || col.FieldName == "GioGiamSauDaiHoc" || col.FieldName == "GioGiamNckh" || col.FieldName == "GhiChu")
            {
                gridViewGiamTru.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now);
                gridViewGiamTru.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void gridViewGiamTru_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiamTru, e);
        }
        #endregion
    }
}