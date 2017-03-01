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
using PMS.Core;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmKhoiLuongGiangDayKhac : DevExpress.XtraEditors.XtraForm
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

                btnDuLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDuLieu.ShortCut = Shortcut.None;

                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnQuyDoi.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnDuLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        private decimal? DonGia { get; set; }
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion

        public frmKhoiLuongGiangDayKhac()
        {
            InitializeComponent();
        }

        private void frmKhoiLuongGiangDayKhac_Load(object sender, EventArgs e)
        {
            #region Khoi luong giang day khac
            AppGridView.InitGridView(gridViewKhoiLuongKhac, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewKhoiLuongKhac, new string[] { "MaGiangVien", "LoaiHocPhan", "MaLop", "MaNhom", "SoLuong", "SoTiet", "MaMonHoc", "SoTuan", "TietQuyDoi", "DienGiai" },
                new string[] { "Giảng viên", "Loại khối lượng", "Mã lớp", "Nhóm", "Số lượng", "Số tiết", "Môn học", "Số tuần", "Số tiết quy đổi", "Diễn giải" },
                new int[] { 170, 180, 100, 60, 70, 70, 250, 70, 100, 150 });
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "LoaiHocPhan", repositoryItemGridLookUpEditLoaiKhoiLuong);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "SoTuan", repositoryItemSpinEditSoTuan);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "SoTiet", repositoryItemSpinEditSoTiet);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "SoLuong", repositoryItemSpinEditSoLuong);
            AppGridView.RegisterControlField(gridViewKhoiLuongKhac, "MaMonHoc", repositoryItemGridLookUpEditMonHoc);
            AppGridView.SummaryField(gridViewKhoiLuongKhac, "MaGiangVien", "Tổng = {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ShowEditor(gridViewKhoiLuongKhac, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongKhac, new string[] { "TietQuyDoi" });
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
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Giang vien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 400, 300);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen" },
                new string[] { "Mã GV", "Họ tên" },
                new int[] { 100, 270 });
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "HoTen";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region Loai khoi luong
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLoaiKhoiLuong, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLoaiKhoiLuong, new string[] { "MaLoaiKhoiLuong", "TenLoaiKhoiLuong" }, new string[] { "Mã loại", "Tên loại" });
            repositoryItemGridLookUpEditLoaiKhoiLuong.ValueMember = "MaLoaiKhoiLuong";
            repositoryItemGridLookUpEditLoaiKhoiLuong.DisplayMember = "TenLoaiKhoiLuong";
            repositoryItemGridLookUpEditLoaiKhoiLuong.NullText = string.Empty;
            #endregion

            #region Mon hoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 650, 300);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "MaKhoa", "TenKhoa", "MaMonHoc", "TenMonHoc" }, new string[] { "Mã khoa", "Tên khoa", "Mã môn học", "Tên môn học" }, new int[] { 100, 200, 100, 200 });
            repositoryItemGridLookUpEditMonHoc.ValueMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.DisplayMember = "TenHienThi";
            repositoryItemGridLookUpEditMonHoc.NullText = string.Empty;
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
            VList<ViewGiangVien> vListGiangVien = DataServices.ViewGiangVien.GetAll();
            vListGiangVien.Insert(0, new ViewGiangVien() { ThuTu = -1, MaGiangVien = -1, MaQuanLy = "-1", HoTen = "[Tất cả]" });
            bindingSourceGiaoVien.DataSource = vListGiangVien;
            cboGiangVien.DataBindings.Clear();
            cboGiangVien.DataBindings.Add("EditValue", bindingSourceGiaoVien, "MaGiangVien", true, DataSourceUpdateMode.OnPropertyChanged);

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            //cboNamHoc.DataBindings.Clear();
            //cboNamHoc.DataBindings.Add("EditValue", bindingSourceNamHoc, "_namHoc", true, DataSourceUpdateMode.OnPropertyChanged);

            bindingSourceMonHoc.DataSource = DataServices.ViewMonHocKhoa.GetAll();

            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                //cboHocKy.DataBindings.Clear();
                //cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetAll();
            if (cboHocKy.EditValue != null)
                bindingSourceKhoiLuongKhac.DataSource = DataServices.KhoiLuongKhac.GetByNamHocHocKyPhanLoai(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), 2);
            bindingSourceHeSoNgay.DataSource = DataServices.HeSoNgay.GetAll();
            bindingSourceLoaiKhoiLuong.DataSource = DataServices.LoaiKhoiLuong.GetAll();

            //PMS.Common.Globals.LoadLayout(Tag as AppModule, new object[] { gridViewKhoiLuongKhac, barManager1, layoutControl1 });
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboHocKy.EditValue != null && cboGiangVien.EditValue != null)
                bindingSourceKhoiLuongKhac.DataSource = DataServices.KhoiLuongKhac.GetByNamHocHocKyPhanLoaiMaGiangVien(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), 2, (int)cboGiangVien.EditValue);
            Cursor.Current = Cursors.Default;
        }

        private void gridViewKhoiLuongKhac_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKhoiLuongKhac, e);
        }

        private void gridViewKhoiLuongKhac_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewKhoiLuongKhac, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            KhoiLuongKhac obj = target as KhoiLuongKhac;
            if (obj != null)
            {
                if (((TList<KhoiLuongKhac>)bindingSourceKhoiLuongKhac.DataSource).FindAll(p => p.MaGiangVien == obj.MaGiangVien && p.MaLop == obj.MaLop && p.LoaiHocPhan == obj.LoaiHocPhan && p.MaMonHoc == obj.MaMonHoc).Count > 1)
                {
                    e.Description = "Giá trị này hiện tại đã có.";
                    return false;
                }
            }
            return true;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKhoiLuongKhac);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewKhoiLuongKhac.FocusedRowHandle = -1;
            TList<KhoiLuongKhac> list = bindingSourceKhoiLuongKhac.DataSource as TList<KhoiLuongKhac>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceKhoiLuongKhac.EndEdit();
                            DataServices.KhoiLuongKhac.Save(list);
                            //PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewKhoiLuongKhac, barManager1, layoutControl1 });
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

        private void gridViewKhoiLuongKhac_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            KhoiLuongKhac obj = e.Row as KhoiLuongKhac;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaGiangVien");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void gridViewKhoiLuongKhac_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void cboNamHoc_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                ViewNamHoc objNamHoc = cboNamHoc.Properties.GetRowByKeyValue(e.Value) as ViewNamHoc;
                if (objNamHoc != null)
                {
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(objNamHoc.NamHoc);
                    //cboHocKy.DataBindings.Clear();
                    //cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
        }

        private void gridViewKhoiLuongKhac_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            KhoiLuongKhac obj = gridViewKhoiLuongKhac.GetRow(e.RowHandle) as KhoiLuongKhac;
            if (obj != null)
            {
                if (cboNamHoc.EditValue!= null && cboHocKy.EditValue != null)
                {
                    obj.NamHoc = cboNamHoc.EditValue.ToString();
                    obj.HocKy = cboHocKy.EditValue.ToString();
                    obj.PhanLoai = 2;
                    obj.DonGia = this.DonGia;
                }
            }
        }

        private void gridViewKhoiLuongKhac_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            KhoiLuongKhac obj = bindingSourceKhoiLuongKhac.Current as KhoiLuongKhac;
            if (obj != null)
            {
                if (!obj.IsNew)
                {
                    foreach (Form fr in frmMain.Instance.xtraTabbedMdiManager.MdiParent.MdiChildren)
                    {
                        if (fr.Name == "frmChiTietKhoiLuongGiangDayKhac")
                        {
                            frmChiTietKhoiLuongGiangDayKhac frm = fr as frmChiTietKhoiLuongGiangDayKhac;
                            if (frm != null)
                            {
                                frm.Init(obj);
                                frm.Focus();
                            }
                            return;
                        }
                    }
                    frmChiTietKhoiLuongGiangDayKhac frmNew = new frmChiTietKhoiLuongGiangDayKhac(obj) { MdiParent = frmMain.Instance };
                    frmNew.Show();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhoiLuongKhac obj = bindingSourceKhoiLuongKhac.Current as KhoiLuongKhac;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceKhoiLuongKhac.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewKhoiLuongKhac.RefreshData();
            }
        }

        private void btnQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn quy đổi giờ chuẩn không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                
                if (cboHocKy.EditValue == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn nằm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboNamHoc.Focus();
                    return;
                }
              
                if (cboGiangVien.EditValue == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboGiangVien.Focus();
                    return;
                }
                frmXuLyQuyDoiKhoiLuongKhac frm = new frmXuLyQuyDoiKhoiLuongKhac(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), (int)cboGiangVien.EditValue);
                frm.ShowDialog();
                if (cboHocKy.EditValue != null && cboGiangVien.EditValue != null)
                    bindingSourceKhoiLuongKhac.DataSource = DataServices.KhoiLuongKhac.GetByNamHocHocKyPhanLoaiMaGiangVien(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), 2, (int)cboGiangVien.EditValue);
                Cursor.Current = Cursors.Default;
            }
        }

        private void repositoryItemGridLookUpEditGiangVien_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                ViewGiangVien vGiangVien = repositoryItemGridLookUpEditGiangVien.GetRowByKeyValue(e.Value) as ViewGiangVien;
                if (vGiangVien != null)
                    this.DonGia = vGiangVien.DonGia;
            }
        }

        private void btnDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
           
            if (cboHocKy.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn nằm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }
            frmLayDuLieuDoAn frm = new frmLayDuLieuDoAn(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            frm.ShowDialog();
            
            if (cboHocKy.EditValue != null && cboGiangVien.EditValue != null)
                bindingSourceKhoiLuongKhac.DataSource = DataServices.KhoiLuongKhac.GetByNamHocHocKyPhanLoaiMaGiangVien(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), 2, (int)cboGiangVien.EditValue);
            Cursor.Current = Cursors.Default;
        }
    }
}