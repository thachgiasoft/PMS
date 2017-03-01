using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmKhoiLuongGiangDayUTE : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDongBo.ShortCut = Shortcut.None;

                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnQuyDoi.ShortCut = Shortcut.None;
            }
            else
            {
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }

        #endregion
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion
        #region Event Form
        public frmKhoiLuongGiangDayUTE()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmKhoiLuongGiangDayUTE_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewKhoiLuongGiangDay, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongGiangDay, new string[] { "MaGiangVienQuanLy", "HoTen", "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "Nhom", "SiSo", "SoTiet", "SoTietDayChuNhat", "TenLoaiHocPhan", "TenNhomMon", "HeSoLopDongLyThuyet", "HeSoLopDongThTnTt" }
                , new string[]{ "Mã giảng viên", "Họ và tên", "Mã môn học", "Tên môn học", "STC", "Mã lớp học phần", "Mã lớp", "Nhóm", "Sĩ số", "Số tiết", "Số tiết chủ nhật", "Loại học phần", "Nhóm môn học", "Hệ số lớp đông LT", "Hệ số lớp đông TH, TT, TN" }
                    , new int[] { 80, 150, 100, 200, 50, 120, 100, 80, 50, 50, 100, 100, 100, 120, 150 });
            AppGridView.AlignHeader(gridViewKhoiLuongGiangDay, new string[] { "MaGiangVienQuanLy", "HoTen", "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "Nhom", "SiSo", "SoTiet", "SoTietDayChuNhat", "TenLoaiHocPhan", "TenNhomMon", "HeSoLopDongLyThuyet", "HeSoLopDongThTnTt" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "MaGiangVienQuanLy", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            //AppGridView.ReadOnlyColumn(gridViewKhoiLuongGiangDay);
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

            InitData();
        }
        #endregion
        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if(cboNamHoc.EditValue!=null && cboHocKy.EditValue!=null)
                bindingSourceKhoiLuongGiangDay.DataSource = DataServices.ViewUteKhoiLuongQuyDoi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnDongBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int kiemtra = 0;
            DataServices.ChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "LTTH", ref kiemtra);
            if (kiemtra == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép đồng bộ lại.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboNamHoc.EditValue == null && cboHocKy.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn năm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }
            if (XtraMessageBox.Show("Bạn có muốn đồng bộ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    using (frmXuLyDongBoDuLieu frm = new frmXuLyDongBoDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _maTruong))
                    {
                        frm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Đã xãy ra lỗi trong quá trình đồng bộ." + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bindingSourceKhoiLuongGiangDay.DataSource = DataServices.ViewUteKhoiLuongQuyDoi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void btnQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int kiemtra = 0;
            DataServices.ChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "LTTH", ref kiemtra);
            if (kiemtra == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép quy đổi lại.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboNamHoc.EditValue == null && cboHocKy.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn năm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }
            int kt = 0;
            DataServices.UteKhoiLuongGiangDay.KiemTraDongBo(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kt);
            if (kt == 2)
            {
                if (XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã được quy đổi. Quy đổi lại sẽ xoá dữ liệu cũ. Bạn có muốn tiếp tục?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmXuLyQuyDoiGioiChuanUTE frm = new frmXuLyQuyDoiGioiChuanUTE(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    frm.ShowDialog();
                }
            }
            else
            {
                frmXuLyQuyDoiGioiChuanUTE frm = new frmXuLyQuyDoiGioiChuanUTE(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                frm.ShowDialog();
            }
            //Lay lai du lieu sau khi tinh.
            bindingSourceKhoiLuongGiangDay.DataSource = DataServices.ViewUteKhoiLuongQuyDoi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceKhoiLuongGiangDay.DataSource = DataServices.ViewUteKhoiLuongQuyDoi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceKhoiLuongGiangDay.DataSource = DataServices.ViewUteKhoiLuongQuyDoi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlKhoiLuongGiangDay.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}