using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmKhoiLuongGiangDayImport : DevExpress.XtraEditors.XtraForm
    {

        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnImport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnImport.ShortCut = Shortcut.None;

                btnXoa.Enabled = false;
            }
            else
            {
                btnImport.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Enabled = true;
            }
        }
        #endregion

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        public frmKhoiLuongGiangDayImport()
        {
            InitializeComponent();
        }

        private void frmKhoiLuongGiangDayImport_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewImport, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewImport, new string[] { "MaGiangVien", "HoTen", "TenLoaiGiangVien", "TenHocHam", "TenHocVi", "TenDonVi", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "Nhom", "SoLuong", "LoaiHocPhan", "MaLop", "NgoaiGio", "SoTiet", "TenBacDaoTao", "TenNhomMonHoc", "MaCoSo", "LopHocPhanChuyenNganh" }
                , new string[] { "Mã giảng viên", "Họ tên", "Loại giảng viên", "Học hàm", "học vị", "Đơn vị", "Mã môn học", "Tên môn học", "Mã lớp học phần", "Nhóm", "Số lượng", "Loại học phần", "Mã lớp", "Ngoài giờ", "Số tiết", "Bậc đào tạo", "Nhóm môn học", "Cơ sở", "LHP Chuyên ngành" }
                , new int[]{90, 150, 100, 100, 100, 150, 80, 200, 110, 70, 80, 90, 90, 90, 80, 100, 100, 80, 100 });
            AppGridView.AlignHeader(gridViewImport, new string[] { "MaGiangVien", "HoTen", "TenLoaiGiangVien", "TenHocHam", "TenHocVi", "TenDonVi", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "Nhom", "SoLuong", "LoaiHocPhan", "MaLop", "NgoaiGio", "SoTiet", "TenBacDaoTao", "TenNhomMonHoc", "MaCoSo", "LopHocPhanChuyenNganh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewImport, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);

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


            #region Dot Import
            AppGridLookupEdit.InitGridLookUp(cboDot, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDot, new string[] { "DotImport" }, new string[] { "Đợt import" });
            cboDot.Properties.ValueMember = "DotImport";
            cboDot.Properties.DisplayMember = "DotImport";
            cboDot.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                cboDot.DataBindings.Clear();
                DataTable tblDotImport = new DataTable();
                IDataReader readerDot = DataServices.KhoiLuongGiangDayChiTiet.GetDotImportByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tblDotImport.Load(readerDot);
                bindingSourceDotImport.DataSource = tblDotImport;
                cboDot.DataBindings.Add("EditValue", bindingSourceDotImport, "DotImport", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDot.EditValue!=null)
            {
                DataTable tblImport = new DataTable();
                IDataReader reader = DataServices.KhoiLuongGiangDayChiTiet.GetKhoiLuongImportByNamHocHocKyDot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDot.EditValue.ToString());
                tblImport.Load(reader);
                bindingSourceImport.DataSource = tblImport;
            }
        }
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDot.EditValue != null)
            {
                DataTable tblImport = new DataTable();
                IDataReader reader = DataServices.KhoiLuongGiangDayChiTiet.GetKhoiLuongImportByNamHocHocKyDot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDot.EditValue.ToString());
                tblImport.Load(reader);
                bindingSourceImport.DataSource = tblImport;
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.Text != "" && cboHocKy.Text != "" && cboDot.Text != "")
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn xoá khối lượng giảng dạy import đợt {0} - năm học {1} - {2}", cboDot.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = 0;
                    DataServices.KhoiLuongGiangDayChiTiet.XoaDotImportTheoNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDot.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Xoá thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Xoá thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                XtraMessageBox.Show("Chọn đợt muốn xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmImportKhoiLuongGiangDay frm = new frmImportKhoiLuongGiangDay())
            {
                frm.ShowDialog();
            }
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tblDotImport = new DataTable();
                IDataReader readerDot = DataServices.KhoiLuongGiangDayChiTiet.GetDotImportByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tblDotImport.Load(readerDot);
                bindingSourceDotImport.DataSource = tblDotImport;
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tblDotImport = new DataTable();
                IDataReader readerDot = DataServices.KhoiLuongGiangDayChiTiet.GetDotImportByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tblDotImport.Load(readerDot);
                bindingSourceDotImport.DataSource = tblDotImport;
            }
        }
    }
}