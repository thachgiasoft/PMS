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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmTienDoGiangDay : DevExpress.XtraEditors.XtraForm
    {
        TList<CauHinhChung> _listCauHinhChung = DataServices.CauHinhChung.GetAll();
        public frmTienDoGiangDay()
        {
            InitializeComponent();
        }

        private void frmTienDoGiangDay_Load(object sender, EventArgs e)
        {
            #region GiangVien
            AppGridView.InitGridView(gridViewGiangVien, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewGiangVien, new string[] { "MaQuanLy", "HoTen" },
                new string[] { "Mã GV", "Họ tên"},
                new int[] { 100, 160 });
            AppGridView.ReadOnlyColumn(gridViewGiangVien);
            AppGridView.SummaryField(gridViewGiangVien, "MaQuanLy", "Tổng = {0}", DevExpress.Data.SummaryItemType.Count);
            #endregion

            #region HocHam
            AppGridLookupEdit.InitGridLookUp(cbHocHam, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cbHocHam, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" });
            cbHocHam.Properties.DisplayMember = "TenHocHam";
            cbHocHam.Properties.ValueMember = "MaHocHam";
            cbHocHam.Properties.NullText = string.Empty;
            #endregion

            #region HocVi
            AppGridLookupEdit.InitGridLookUp(cbHocVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cbHocVi, new string[] { "MaQuanLy", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" });
            cbHocVi.Properties.DisplayMember = "TenHocVi";
            cbHocVi.Properties.ValueMember = "MaHocVi";
            cbHocVi.Properties.NullText = string.Empty;
            #endregion

            #region DonVi - KhoaBoMon
            AppGridLookupEdit.InitGridLookUp(cbDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cbDonVi, 650, 300);
            AppGridLookupEdit.ShowField(cbDonVi, new string[] { "MaKhoa", "TenKhoa", "MaBoMon", "TenBoMon" }, new string[] { "Mã khoa", "Tên khoa", "Mã bộ môn", "Tên bộ môn" }, new int[] { 90, 210, 90, 210 });
            cbDonVi.Properties.DisplayMember = "TenBoMon";
            cbDonVi.Properties.ValueMember = "MaBoMon";
            cbDonVi.Properties.NullText = string.Empty;
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cbNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cbNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cbNamHoc.Properties.ValueMember = "NamHoc";
            cbNamHoc.Properties.DisplayMember = "NamHoc";
            cbNamHoc.Properties.NullText = string.Empty;
            cbNamHoc.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cbHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cbHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cbHocKy.Properties.ValueMember = "MaHocKy";
            cbHocKy.Properties.DisplayMember = "TenHocKy";
            cbHocKy.Properties.NullText = string.Empty;
            cbHocKy.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            #region Thoi Khoa Bieu
            AppGridView.InitGridView(gridViewLopHocPhan, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewLopHocPhan, new string[] { "MaLhp", "TenHp","LoaiHp","SoTc","SiSoLop","SiSoDk","MaLop","Tkb","MaCbgd","TenCbgd","ChiTiet" },
                new string[] { "Mã LHP", "Tên môn học","Loại HP","Số tín chỉ","Sĩ số lớp","Sĩ số ĐK","Mã lớp","Lịch giảng","Mã giảng viên","Họ tên","Chi tiết" },
                new int[] { 95, 130, 70, 85, 70, 70, 80, 130, 110, 120, 100 });
            AppGridView.ReadOnlyColumn(gridViewLopHocPhan, new string[] { "MaLhp", "TenHp", "LoaiHp", "SoTc", "SiSoLop", "SiSoDk", "MaLop", "Tkb", "MaCbgd", "TenCbgd", "ChiTiet" });
            AppGridView.RegisterControlField(gridViewLopHocPhan, "ChiTiet", repositoryItemButtonEdit1);
            AppGridView.SummaryField(gridViewLopHocPhan, "MaLhp", "Tổng = {0}", DevExpress.Data.SummaryItemType.Count);
            #endregion
            #region Init data
            InitData();
            #endregion
   
        }
        private void InitData()
        {
            Cursor.Current = Cursors.WaitCursor;
            #region DonVi - KhoaBoMon
            VList<ViewKhoaBoMon> vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            bindingSourceDonVi.DataSource = vListKhoaBoMon.Copy();

            vListKhoaBoMon.Insert(0, new ViewKhoaBoMon() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]", MaBoMon = "-1", TenBoMon = "[Tất cả]" });
            bindingSourceDonVi.DataSource = vListKhoaBoMon;
            cbDonVi.DataBindings.Clear();
            cbDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);
            #endregion
            #region Hoc ham
            TList<HocHam> TlistHocHam = DataServices.HocHam.GetAll();
            TlistHocHam.Insert(0, new HocHam() { ThuTu = -1, MaHocHam = -1, MaQuanLy = "-1", TenHocHam = "[Tất cả]" });
            bindingSourceHocHam.DataSource = TlistHocHam;
            cbHocHam.DataBindings.Clear();
            cbHocHam.DataBindings.Add("EditValue", bindingSourceHocHam, "MaHocHam", true, DataSourceUpdateMode.OnPropertyChanged);
            #endregion
            #region Hoc vi
            TList<HocVi> TlistHocVi = DataServices.HocVi.GetAll();
            TlistHocVi.Insert(0, new HocVi() { ThuTu = -1, MaHocVi = -1, MaQuanLy = "-1", TenHocVi = "[Tất cả]" });
            bindingSourceHocVi.DataSource = TlistHocVi;
            cbHocVi.DataBindings.Clear();
            cbHocVi.DataBindings.Add("EditValue", bindingSourceHocVi, "MaHocVi", true, DataSourceUpdateMode.OnPropertyChanged);
            #endregion
            #region Giang vien
            bindingSourceGiangVien.DataSource = DataServices.GiangVien.GetAll();
            #endregion
            #region Nam hoc - Hoc ky
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
           
            if (cbNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cbNamHoc.EditValue.ToString());
            }
            #endregion
            Cursor.Current = Cursors.Default;
        }
        private void GetListByMaHocHamMaHocViMaDonVi()
        {
            Cursor.Current = Cursors.WaitCursor;
            ViewKhoaBoMon objDonVi = bindingSourceDonVi.Current as ViewKhoaBoMon;
            HocHam objHocHam = bindingSourceHocHam.Current as HocHam;
            HocVi objHocVi = bindingSourceHocVi.Current as HocVi;

            if (objDonVi != null && objHocHam != null && objHocVi != null)
            {
                bindingSourceGiangVien.DataSource = DataServices.GiangVien.GetMaDonViMaHocHamMaHocVi(objDonVi.MaBoMon, objHocHam.MaHocHam, objHocVi.MaHocVi);
            }
            Cursor.Current = Cursors.Default;
        }

        private void cbDonVi_EditValueChanged(object sender, EventArgs e)
        {
            GetListByMaHocHamMaHocViMaDonVi();
        }

        private void cbHocHam_EditValueChanged(object sender, EventArgs e)
        {
            GetListByMaHocHamMaHocViMaDonVi();
        }

        private void cbHocVi_EditValueChanged(object sender, EventArgs e)
        {
            GetListByMaHocHamMaHocViMaDonVi();
        }

        private void cbNamHoc_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                if (cbNamHoc.EditValue != null)
                {
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cbNamHoc.EditValue.ToString());
                }
            }
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            GiangVien objgiangvien = bindingSourceGiangVien.Current as GiangVien;
            if (cbNamHoc.EditValue != null && cbHocKy.EditValue != null && objgiangvien !=null)
            {
                bindingSourceLopHocPhan.DataSource = DataServices.ViewDanhSachLopPhanCongGiangDay.GetByNamHocHocKyMaGiangVien(cbNamHoc.EditValue.ToString(), cbHocKy.EditValue.ToString(), objgiangvien.MaQuanLy);
            }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewLopHocPhan_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (view.FocusedColumn.FieldName == "ChiTiet")
            {
                ViewDanhSachLopPhanCongGiangDay obj = gridViewLopHocPhan.GetFocusedRow() as ViewDanhSachLopPhanCongGiangDay;
                if (obj != null)
                {
                    if (!obj.IsNew)
                    {
                        using (frmTienDoGiangDayChiTiet frm = new frmTienDoGiangDayChiTiet(obj.MaGocLhp, obj.MaLhp, obj.TenHp))
                        {
                            frm.ShowDialog();
                        }
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa lưu lại dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}