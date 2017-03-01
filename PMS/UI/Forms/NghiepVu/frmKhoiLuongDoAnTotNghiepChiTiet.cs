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
using PMS.Services;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmKhoiLuongDoAnTotNghiepChiTiet : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        int kiemtra = 0;
        #endregion

        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDongBo.ShortCut = Shortcut.None;

                btnTinh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnTinh.ShortCut = Shortcut.None;
            }
            else
            {
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnTinh.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        public frmKhoiLuongDoAnTotNghiepChiTiet()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        #region Init gridview
        private void InitGrid_CDGTVT()
        {
            AppGridView.InitGridView(gridViewKhoiLuongDoAnTotNghiepChiTiet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongDoAnTotNghiepChiTiet, new string[] { "MaGiangVien", "HoTen", "MaMonHoc", "TenMonHoc", "SoTinChi", "SoLuongHuongDan", "SoLuongDeTai", "HeSoThamGia", "LoaiThamGia", "SoTiet" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Mã môn học", "Tên môn học", "Số tín chỉ", "Số sinh viên", "Số đề tài", "Hệ số", "Vai trò", "Số tiết quy đổi" }
                    , new int[] { 100, 150, 90, 150, 70, 80, 60, 60, 70, 90 });
            AppGridView.AlignHeader(gridViewKhoiLuongDoAnTotNghiepChiTiet, new string[] { "MaGiangVien", "HoTen", "MaMonHoc", "TenMonHoc", "SoTinChi", "SoLuongHuongDan", "SoLuongDeTai", "HeSoThamGia", "LoaiThamGia", "SoTiet" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongDoAnTotNghiepChiTiet, new string[] { "MaGiangVien", "HoTen", "MaMonHoc", "TenMonHoc", "SoTinChi", "SoLuongHuongDan", "HeSoThamGia", "LoaiThamGia", "SoTiet" } );
            AppGridView.SummaryField(gridViewKhoiLuongDoAnTotNghiepChiTiet, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.RegisterControlField(gridViewKhoiLuongDoAnTotNghiepChiTiet, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            
        }

        private void InitGrid_Remain()
        {
            AppGridView.InitGridView(gridViewKhoiLuongDoAnTotNghiepChiTiet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongDoAnTotNghiepChiTiet, new string[] { "MaGiangVien", "HoTen", "MaMonHoc", "TenMonHoc", "SoTinChi", "LopClc", "SoLuongHuongDan", "SoTiet", "HeSoHocKy", "DonGia", "SoTien" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Mã môn học", "Tên môn học", "STC", "Lớp CLC", "Sĩ số", "Số tiết", "Hệ số học kỳ", "Đơn giá", "Số tiền" }
                    , new int[] { 100, 150, 90, 150, 60, 60, 60, 60, 90, 90, 100 });
            AppGridView.AlignHeader(gridViewKhoiLuongDoAnTotNghiepChiTiet, new string[] { "MaGiangVien", "HoTen", "MaMonHoc", "TenMonHoc", "SoTinChi", "SoLuongHuongDan", "SoTiet", "HeSoHocKy" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongDoAnTotNghiepChiTiet, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.RegisterControlField(gridViewKhoiLuongDoAnTotNghiepChiTiet, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.FormatDataField(gridViewKhoiLuongDoAnTotNghiepChiTiet, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongDoAnTotNghiepChiTiet, "SoTien", DevExpress.Utils.FormatType.Custom, "n0");
        }
        #endregion
        
        private void frmKhoiLuongDoAnTotNghiepChiTiet_Load(object sender, EventArgs e)
        {
            #region Init GridView
            switch (_maTruong)
            {
                case "CDGTVT":
                    InitGrid_CDGTVT();
                    break;
                default:
                    InitGrid_Remain();
                    break;
            }
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen" }, new string[] { "Mã giảng viên", "Họ tên" });
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
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

        #region InitData
        void InitData()
        {
            try
            {
                bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetAll();
                bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    bindingSourceKhoiLuong.DataSource = DataServices.KhoiLuongDoAnTotNghiepChiTiet.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            catch
            { }
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
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataServices.ChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DATN", ref kiemtra);
                if (kiemtra == 1)
                {
                    XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép sửa đổi.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (frmXuLyDuLieu frm = new frmXuLyDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DongBoDoAnTotNghiep"))
                {
                    frm.ShowDialog();
                }
                bindingSourceKhoiLuong.DataSource = DataServices.KhoiLuongDoAnTotNghiepChiTiet.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            if (_maTruong.Equals("CDGTVT"))
            {
                AppGridView.HideField(gridViewKhoiLuongDoAnTotNghiepChiTiet, new string[] { "SoTiet" });
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataServices.ChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DATN", ref kiemtra);
                if (kiemtra == 1)
                {
                    XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép sửa đổi.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (_maTruong.Equals("CDGTVT"))
                {
                    AppGridView.ShowField(gridViewKhoiLuongDoAnTotNghiepChiTiet, new string[] { "SoTiet" });
                }
                else
                {
                    TList<KhoiLuongDoAnTotNghiepChiTiet> list = bindingSourceKhoiLuong.DataSource as TList<KhoiLuongDoAnTotNghiepChiTiet>;
                    using (frmXuLyDuLieu frm = new frmXuLyDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), list, "TinhDuLieuDoAnTotNghiep"))
                    {
                        frm.ShowDialog();
                    }
                    bindingSourceKhoiLuong.DataSource = DataServices.KhoiLuongDoAnTotNghiepChiTiet.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    bindingSourceKhoiLuong.DataSource = DataServices.KhoiLuongDoAnTotNghiepChiTiet.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            catch
            { }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    bindingSourceKhoiLuong.DataSource = DataServices.KhoiLuongDoAnTotNghiepChiTiet.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            catch
            { }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlKhoiLuongDoAnTotNghiepChiTiet.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}