using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThemTietThucDay : DevExpress.XtraEditors.XtraForm
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

                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnQuyDoi.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }

        #endregion
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        //TList<KhoiLuongGiangDayChiTiet> _listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
        #endregion
        #region Event Form
        public frmThemTietThucDay()
        {
            InitializeComponent();
        }

        private void frmThemTietThucDay_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewTietThucDay, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewTietThucDay, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewTietThucDay, new string[] { "MaGiangVien", "MaMonHoc", "SoTinChi", "MaLopHocPhan", "LoaiHocPhan", "MaLop", "SoLuong", "SoTiet" }
                    , new string[] { "Họ tên GV", "Tên môn học", "STC", "Lớp học phần", "Loại học phần", "Mã lớp", "Số SV đăng ký", "Số tiết" }
                    , new int[] { 150, 150, 60, 120, 90, 90, 110, 100 });

            AppGridView.RegisterControlField(gridViewTietThucDay, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewTietThucDay, "MaMonHoc", repositoryItemGridLookUpEditMonHoc);
            AppGridView.RegisterControlField(gridViewTietThucDay, "MaLopHocPhan", repositoryItemGridLookUpEditLopHocPhan);
            AppGridView.RegisterControlField(gridViewTietThucDay, "SoTiet", repositoryItemSpinEditSoTietThem);

            AppGridView.ReadOnlyColumn(gridViewTietThucDay, new string[] { "SoTinChi", "LoaiHocPhan", "MaLop", "SoLuong" });
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen" }, new string[] { "Mã giảng viên", "Họ tên" }, new int[] { 90, 190 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 280, 450);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "HoTen";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region MonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi" }, new string[] { "Mã môn học", "Tên môn học", "STC" }, new int[] { 100, 150, 50 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 300, 450);
            repositoryItemGridLookUpEditMonHoc.DisplayMember = "TenMonHoc";
            repositoryItemGridLookUpEditMonHoc.ValueMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.NullText = string.Empty;
            #endregion

            #region LopHocPhan
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLopHocPhan, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLopHocPhan, new string[] { "MaLopHocPhan", "LoaiHocPhan", "MaLop" }, new string[] { "Mã lớp học phần", "Loại học phần", "Lớp sinh viên" }, new int[] { 130, 100, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLopHocPhan, 330, 450);
            repositoryItemGridLookUpEditLopHocPhan.DisplayMember = "MaLopHocPhan";
            repositoryItemGridLookUpEditLopHocPhan.ValueMember = "MaLopHocPhan";
            repositoryItemGridLookUpEditLopHocPhan.NullText = string.Empty;
            #endregion
            InitData();
        }
        #endregion
        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null) bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetAll();
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceTietThucDay.DataSource = DataServices.KhoiLuongGiangDayChiTiet.GetSoTietBoSung(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                DataTable tbMonHoc = new DataTable();
                IDataReader reader = DataServices.KhoiLuongGiangDayChiTiet.GetMonHocByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tbMonHoc.Load(reader);
                bindingSourceMonHoc.DataSource = tbMonHoc;

                IDataReader rd = DataServices.KhoiLuongGiangDayChiTiet.GetLopHocPhanByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                DataTable tbLHP = new DataTable();
                tbLHP.Load(rd);
                bindingSourceLopHocPhan.DataSource = tbLHP;
            }
            bindingSourceMonHoc.Filter = null;
            bindingSourceLopHocPhan.Filter = null;
        }
        #endregion

        #region Event Button
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewTietThucDay);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewTietThucDay.FocusedRowHandle = -1;
            TList<KhoiLuongGiangDayChiTiet> list = bindingSourceTietThucDay.DataSource as TList<KhoiLuongGiangDayChiTiet>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                          
                            bindingSourceTietThucDay.EndEdit();
                            DataServices.KhoiLuongGiangDayChiTiet.Save(list);

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

        private void btnQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue.ToString() == "" || cboHocKy.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn nằm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }

            using (frmXuLyQuyDoiGioiChuan frm = new frmXuLyQuyDoiGioiChuan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), true))
            {
                frm.ShowDialog();
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Grid
        private void gridViewTietThucDay_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            int pos = e.RowHandle;
            KhoiLuongGiangDayChiTiet o = (KhoiLuongGiangDayChiTiet)gridViewTietThucDay.GetRow(pos);

            if (col.FieldName == "MaGiangVien")
            {
                if (o.MaGiangVien != null)
                    bindingSourceMonHoc.Filter = String.Format("MaGiangVien = '{0}'", o.MaGiangVien);


            }

            if (col.FieldName == "MaMonHoc")
            {
                if (o.MaMonHoc != null)
                {
                    bindingSourceLopHocPhan.Filter = string.Format("MaMonHoc = '{0}' and MaGiangVien = '{1}'", o.MaMonHoc, o.MaGiangVien);
                    DataTable mh = new DataTable();
                    IDataReader rdMonHoc = DataServices.KhoiLuongGiangDayChiTiet.GetMonHocByMaGiangVienNamHocHocKyMaMonHoc(o.MaGiangVien, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), o.MaMonHoc);
                    mh.Load(rdMonHoc);

                    if (mh.Rows.Count < 1) { o = null; return; }

                    gridViewTietThucDay.SetRowCellValue(pos, "SoTinChi", mh.Rows[0]["SoTinChi"]);
                 
                }
            }

            
            if (col.FieldName == "MaLopHocPhan")
            {
                if (o.MaLopHocPhan != null)
                {
                    TList<KhoiLuongGiangDayChiTiet> _list = DataServices.KhoiLuongGiangDayChiTiet.GetByMaGiangVienMaLopHocPhan(o.MaGiangVien, o.MaLopHocPhan);

                    if (_list == null) { o = null; return; }

                    KhoiLuongGiangDayChiTiet kl = _list[0];
                    gridViewTietThucDay.SetRowCellValue(pos, "LoaiHocPhan", kl.LoaiHocPhan);
                    gridViewTietThucDay.SetRowCellValue(pos, "MaLop", kl.MaLop);
                    gridViewTietThucDay.SetRowCellValue(pos, "SoLuong", kl.SoLuong);

                    o.MaLichHoc = -1;
                    o.NamHoc = kl.NamHoc;
                    o.HocKy = kl.HocKy;
                    o.TenMonHoc = kl.TenMonHoc;
                    o.Nhom = kl.Nhom;
                    o.LyThuyet = kl.LyThuyet;
                    o.ThucHanh = kl.ThucHanh;
                    o.BaiTap = kl.BaiTap;
                    o.BaiTapLon = kl.BaiTapLon;
                    o.DoAn = kl.DoAn;
                    o.LuanAn = kl.LuanAn;
                    o.TieuLuan = kl.TieuLuan;
                    o.ThucTap = kl.ThucTap;
                    o.MaLoaiHocPhan = kl.MaLoaiHocPhan;
                    o.PhanLoai = kl.PhanLoai;
                    o.HeSoThanhPhan = kl.HeSoThanhPhan;
                    o.Nam = kl.Nam;
                    o.Tuan = kl.Tuan;
                    o.DonViTinh = kl.DonViTinh;
                    o.MaBuoiHoc = kl.MaBuoiHoc;
                    o.TietBatDau = kl.TietBatDau;
                    o.TinhTrang = kl.TinhTrang;
                    o.NgayDay = kl.NgayDay;
                    o.Compensate = kl.Compensate;
                    o.MaBacDaoTao = kl.MaBacDaoTao;
                    o.MaKhoa = kl.MaKhoa;
                    o.MaNhomMonHoc = kl.MaNhomMonHoc;
                    o.MaPhongHoc = kl.MaPhongHoc;
                    o.MaKhoaHoc = kl.MaKhoaHoc;
                    o.LoaiHocKy = kl.LoaiHocKy;
                    o.HeSoHocKy = kl.HeSoHocKy;
                }
            }

            //if (col.FieldName == "SoTiet")
            //{
            //    if (o.SoTiet != null)
            //    {
            //        _listKhoiLuong.Add(o);
            //    }
            //}
         
        }
        

        private void gridViewTietThucDay_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            int pos = e.RowHandle;
            KhoiLuongGiangDayChiTiet o = (KhoiLuongGiangDayChiTiet)gridViewTietThucDay.GetRow(pos);
            if (o != null)
            {
                if (col.FieldName == "MaMonHoc")
                {
                    bindingSourceMonHoc.Filter = null;

                }
                if (col.FieldName == "MaLopHocPhan")
                {
                    bindingSourceLopHocPhan.Filter = null;
                }
            }
        }
        #endregion

    }
}