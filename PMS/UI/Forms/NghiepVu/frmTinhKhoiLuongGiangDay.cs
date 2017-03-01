using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;
using PMS.Entities.Validation;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmTinhKhoiLuongGiangDay : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btn_DongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btn_DongBo.ShortCut = Shortcut.None;

                btnTinh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnTinh.ShortCut = Shortcut.None;
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnQuyDoi.ShortCut = Shortcut.None;
            }
            else
            {
                btn_DongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnTinh.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        public frmTinhKhoiLuongGiangDay()
        {
            InitializeComponent();
        }

        private void frmTinhKhoiLuongGiangDay_Load(object sender, EventArgs e)
        {
            #region Khoi luong giang
            AppGridView.InitGridView(gridViewKhoiLuongGiangDay, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongGiangDay, new string[] { "MaQuanLy", "HoTen", "TietNghiaVu", "TietGioiHan", "TietQuyDoi", "TietDoAn", "NgoaiGio", "TietThieu", "TietVuot" },
                new string[] { "Mã GV", "Họ tên", "Tiết NV", "Tiết GH", "Tiết QĐ", "Tiết ĐA", "Ngoài giờ", "Tiết thiếu", "Tiết vượt" },
                new int[] { 90, 200, 90, 90, 90, 90, 90, 90, 90 });
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongGiangDay);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "MaQuanLy", "Tổng = {0}", DevExpress.Data.SummaryItemType.Count);
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            #endregion

            #region Giang vien
            AppGridLookupEdit.InitGridLookUp(cboGiangVien, true, TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboGiangVien, 350, 300);
            AppGridLookupEdit.ShowField(cboGiangVien, new string[] { "MaQuanLy", "HoTen" }, new string[] { "Mã GV", "Họ tên" }, new int[] { 100, 200 });
            cboGiangVien.Properties.ValueMember = "MaGiangVien";
            cboGiangVien.Properties.DisplayMember = "HoTen";
            cboGiangVien.Properties.NullText = string.Empty;
            #endregion

            #region Init DataSource
            InitData();
            #endregion
        }

        private void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            cboNamHoc.DataBindings.Clear();
            cboNamHoc.DataBindings.Add("EditValue", bindingSourceNamHoc, "NamHoc", true, DataSourceUpdateMode.OnPropertyChanged);

            ViewNamHoc objNamHoc = bindingSourceNamHoc.Current as ViewNamHoc;
            if (objNamHoc != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(objNamHoc.NamHoc);
                cboHocKy.DataBindings.Clear();
                cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
            }

            ViewHocKy objHocKy = bindingSourceHocKy.Current as ViewHocKy;
            if (objHocKy != null)
                bindingSourceKhoiLuongGiangDay.DataSource = DataServices.ViewTinhKhoiLuong.GetByNamHocHocKy(objHocKy.NamHoc, objHocKy.MaHocKy);

            VList<ViewGiangVien> vListGiangVien = DataServices.ViewGiangVien.GetAll();
            vListGiangVien.Insert(0, new ViewGiangVien() { ThuTu = -1, MaGiangVien = -1, MaQuanLy = "-1", HoTen = "[Tất cả]" });
            bindingSourceGiangVien.DataSource = vListGiangVien;
            cboGiangVien.DataBindings.Clear();
            cboGiangVien.DataBindings.Add("EditValue", bindingSourceGiangVien, "MaGiangVien", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LocDuLieu();
        }

        private void LocDuLieu()
        {
            Cursor.Current = Cursors.WaitCursor;
            ViewHocKy objHocKy = bindingSourceHocKy.Current as ViewHocKy;
            ViewGiangVien objGiangVien = bindingSourceGiangVien.Current as ViewGiangVien;
            if (objHocKy != null && objGiangVien != null)
                bindingSourceKhoiLuongGiangDay.DataSource = DataServices.ViewTinhKhoiLuong.GetByNamHocHocKyMaGiangVien(objHocKy.NamHoc, objHocKy.MaHocKy, objGiangVien.MaGiangVien);
            Cursor.Current = Cursors.Default;
        }

        private void gridViewKhoiLuongGiangDay_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewKhoiLuongGiangDay, e);
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                ViewNamHoc objNamHoc = cboNamHoc.Properties.GetRowByKeyValue(e.Value) as ViewNamHoc;
                if (objNamHoc != null)
                {
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(objNamHoc.NamHoc);
                    cboHocKy.DataBindings.Clear();
                    cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
        }

        private void gridViewKhoiLuongGiangDay_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ViewTinhKhoiLuong vTinhKhoiLuong = gridViewKhoiLuongGiangDay.GetFocusedRow() as ViewTinhKhoiLuong;
            if (vTinhKhoiLuong != null)
            {
                foreach (Form fr in frmMain.Instance.xtraTabbedMdiManager.MdiParent.MdiChildren)
                {
                    if (fr.Name == "frmKhoiLuongGiangDay")
                    {
                        frmKhoiLuongGiangDay frm = fr as frmKhoiLuongGiangDay;
                        if (frm != null)
                        {
                            frm.InitData(vTinhKhoiLuong.MaKetQua);
                            frm.Focus();
                        }
                        return;
                    }
                }
                frmKhoiLuongGiangDay frmNew = new frmKhoiLuongGiangDay(vTinhKhoiLuong.MaKetQua) { MdiParent = frmMain.Instance };
                frmNew.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ViewHocKy objHocKy = bindingSourceHocKy.Current as ViewHocKy;
            if (objHocKy == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn nằm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }
            ViewGiangVien objGiangVien = bindingSourceGiangVien.Current as ViewGiangVien;
            if (objGiangVien == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGiangVien.Focus();
                return;
            }
            
            frmXuLyTinhKhoiLuongGiangDay frm = new frmXuLyTinhKhoiLuongGiangDay(objHocKy.NamHoc, objHocKy.MaHocKy, objGiangVien.MaGiangVien);
            frm.ShowDialog();

            //Lay lai du lieu sau khi tinh.
            bindingSourceKhoiLuongGiangDay.DataSource = DataServices.ViewTinhKhoiLuong.GetByNamHocHocKyMaGiangVien(objHocKy.NamHoc, objHocKy.MaHocKy, objGiangVien.MaGiangVien);
            Cursor.Current = Cursors.Default;
        }

        private void btnQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ViewHocKy objHocKy = bindingSourceHocKy.Current as ViewHocKy;
            if (objHocKy == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn nằm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }
            ViewGiangVien objGiangVien = bindingSourceGiangVien.Current as ViewGiangVien;
            if (objGiangVien == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGiangVien.Focus();
                return;
            }
            frmXuLyQuyDoiGioiChuanUTE frm = new frmXuLyQuyDoiGioiChuanUTE(objHocKy.NamHoc, objHocKy.MaHocKy, objGiangVien.MaGiangVien);
            frm.ShowDialog();

            //Lay lai du lieu sau khi tinh.
            bindingSourceKhoiLuongGiangDay.DataSource = DataServices.ViewTinhKhoiLuong.GetByNamHocHocKyMaGiangVien(objHocKy.NamHoc, objHocKy.MaHocKy, objGiangVien.MaGiangVien);
            Cursor.Current = Cursors.Default;
        }

        private void btn_DongBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewHocKy objHocKy = bindingSourceHocKy.Current as ViewHocKy;
            if (objHocKy == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn nằm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }
            if (XtraMessageBox.Show("Bạn có muốn đồng bộ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    using (frmXuLyDongBoDuLieu frm = new frmXuLyDongBoDuLieu(objHocKy.NamHoc, objHocKy.MaHocKy))
                    {
                        frm.ShowDialog();
                    }
                }
                catch(Exception ex)
                {
                    XtraMessageBox.Show("Đã xãy ra lỗi trong quá trình đồng bộ." + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}