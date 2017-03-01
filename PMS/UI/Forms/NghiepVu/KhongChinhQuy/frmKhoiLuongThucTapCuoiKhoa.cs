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

namespace PMS.UI.Forms.NghiepVu.KhongChinhQuy
{
    public partial class frmKhoiLuongThucTapCuoiKhoa : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDongBo.ShortCut = Shortcut.None;


                btnLuuQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuuQuyDoi.ShortCut = Shortcut.None;
            }
            else
            {
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnLuuQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        TList<KcqHeSoDiaDiem> _listDiaDiem = DataServices.KcqHeSoDiaDiem.GetAll();
        int kiemtra = 0;
        #endregion

        public frmKhoiLuongThucTapCuoiKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoiLuongThucTapCuoiKhoa_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewKhoiLuongThucTapCuoiKhoa, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongThucTapCuoiKhoa, new string[] { "MaQuanLy", "HoTen", "MaLop", "MaNhom", "SiSo", "Loai", "MaMonHoc", "TenMonHoc", "SoTinChi", "SoTuan", "HeSoHocKy", "HeSoQuyDoi", "TietQuyDoi", "DonGia", "MaDiaDiem", "HeSoDiaDiem", "DonGiaDiaDiem", "DonGiaDiaDiemQuyDoi", "DonGiaTong", "ThanhTienGiangDay", "TienXeDiaDiem", "TongTien", "GhiChu", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "Id" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Mã lớp", "Nhóm", "Sĩ số", "Loại", "Mã môn học", "Tên môn học", "STC", "Số tuần", "Hệ số học kỳ", "Hệ số quy đổi", "Tiết quy đổi", "Đơn giá học vị", "Tên địa điểm", "Hệ số địa điểm", "Đơn giá địa điểm", "Đơn giá ĐĐ x HSĐĐ", "Đơn giá giảng dạy", "Tiền giảng dạy", "Tiền xe địa điểm", "Tổng tiền", "Ghi chú", "Đơn vị", "Học hàm", "Học vị", "Loại giảng viên", "Id" }
                    , new int[] { 80, 150, 90, 60, 60, 60, 80, 150, 50, 60, 70, 70, 70, 70, 120, 60, 70, 70, 70, 80, 80, 80, 80, 150, 100, 100, 100, 99 });
            AppGridView.AlignHeader(gridViewKhoiLuongThucTapCuoiKhoa, new string[] { "MaQuanLy", "HoTen", "MaLop", "MaNhom", "SiSo", "Loai", "MaMonHoc", "TenMonHoc", "SoTinChi", "SoTuan", "HeSoHocKy", "HeSoQuyDoi", "TietQuyDoi", "DonGia", "MaDiaDiem", "HeSoDiaDiem", "DonGiaDiaDiem", "DonGiaDiaDiemQuyDoi", "DonGiaTong", "ThanhTienGiangDay", "TienXeDiaDiem", "TongTien", "GhiChu", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongThucTapCuoiKhoa, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.RegisterControlField(gridViewKhoiLuongThucTapCuoiKhoa, "MaDiaDiem", repositoryItemGridLookUpEditDiaDiem);
            AppGridView.FormatDataField(gridViewKhoiLuongThucTapCuoiKhoa, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongThucTapCuoiKhoa, "DonGiaDiaDiem", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongThucTapCuoiKhoa, "DonGiaDiaDiemQuyDoi", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongThucTapCuoiKhoa, "DonGiaTong", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongThucTapCuoiKhoa, "ThanhTienGiangDay", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongThucTapCuoiKhoa, "TienXeDiaDiem", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongThucTapCuoiKhoa, "TongTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewKhoiLuongThucTapCuoiKhoa, new string[] { "Id" });
            AppGridView.FixedField(gridViewKhoiLuongThucTapCuoiKhoa, new string[] { "MaQuanLy", "HoTen", "MaLop" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            PMS.Common.Globals.WordWrapHeader(gridViewKhoiLuongThucTapCuoiKhoa, 40);
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongThucTapCuoiKhoa, new string[] { "MaQuanLy", "HoTen", "MaLop", "MaNhom", "SiSo", "Loai", "MaMonHoc", "TenMonHoc", "SoTinChi", "SoTuan", "HeSoHocKy", "HeSoQuyDoi", "TietQuyDoi", "DonGia", "HeSoDiaDiem", "DonGiaDiaDiem", "DonGiaDiaDiemQuyDoi", "DonGiaTong", "ThanhTienGiangDay", "TienXeDiaDiem", "TongTien", "GhiChu", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "Id" });
            #endregion

            #region MaDiaDiem
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDiaDiem, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditDiaDiem, 650, 600);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDiaDiem, new string[] { "MaQuanLy", "TenDiaDiem", "HeSoDiaDiem", "DonGia", "TienXeDiaDiem" }, new string[] { "Mã địa điểm", "Tên địa điểm", "Hệ số địa điểm", "Đơn giá", "Tiền xe địa điểm" }, new int[] { 100, 150, 80, 80, 90 });
            repositoryItemGridLookUpEditDiaDiem.ValueMember = "MaHeSo";
            repositoryItemGridLookUpEditDiaDiem.DisplayMember = "TenDiaDiem";
            repositoryItemGridLookUpEditDiaDiem.NullText = string.Empty;
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
                bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
                bindingSourceHeSoDiaDiem.DataSource = _listDiaDiem;
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                LoadDataSource();
            }
            catch
            { }
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable dt = new DataTable();
                dt.Load(DataServices.KcqKhoiLuongThucTapCuoiKhoa.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()));
                bindingSourceKhoiLuongTTCK.DataSource = dt;
            }
        }
        #endregion

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
                //Hàm kiểm tra chưa chạy
                DataServices.KcqChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "TTTN", ref kiemtra);
                if (kiemtra == 1)
                {
                    XtraMessageBox.Show(string.Format("Khối lượng hướng dẫn thực tập năm học {0} - {1} đã chốt, không được phép sửa đổi.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (frmXuLyDuLieu_Kcq frm = new frmXuLyDuLieu_Kcq(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DongBoThucTapTotNghiep"))
                {
                    frm.ShowDialog();
                }

                LoadDataSource();
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLuuQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataServices.KcqChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "TTTN", ref kiemtra);
                if (kiemtra == 1)
                {
                    XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép sửa đổi.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                gridViewKhoiLuongThucTapCuoiKhoa.FocusedRowHandle = -1;
                //string xmlData = "";
                DataTable tb = bindingSourceKhoiLuongTTCK.DataSource as DataTable;
                if (tb.Rows.Count > 0)
                {
                    if (XtraMessageBox.Show("Bạn muốn lưu và tính quy đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string xmlData = "";
                        foreach (DataRow row in tb.Rows)
                        {

                            xmlData += "<Input I=\"" + row["Id"].ToString()
                                        + "\" D=\"" + row["MaDiaDiem"].ToString()
                                        + "\" />";
                        }
                        xmlData = "<Root>" + xmlData + "</Root>";

                        int kq = 0;
                        DataServices.KcqKhoiLuongThucTapCuoiKhoa.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Lưu quy đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu quy đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                //using (frmXuLyDuLieu_Kcq frm = new frmXuLyDuLieu_Kcq(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), tb, "TinhDuLieuDoAnTotNghiep"))
                //{
                //    frm.ShowDialog();
                //}
                LoadDataSource();
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    sf.ShowDialog();
                    if (sf.FileName != "")
                    {
                        gridControlKLTTCK.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void gridViewKhoiLuongThucTapCuoiKhoa_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "MaDiaDiem")
                {
                    DataRowView r = gridViewKhoiLuongThucTapCuoiKhoa.GetRow(e.RowHandle) as DataRowView;
                    KcqHeSoDiaDiem hs = _listDiaDiem.Find(p => p.MaHeSo == int.Parse(r["MaDiaDiem"].ToString()));
                    gridViewKhoiLuongThucTapCuoiKhoa.SetRowCellValue(e.RowHandle, "HeSoDiaDiem", hs.HeSoDiaDiem);
                    gridViewKhoiLuongThucTapCuoiKhoa.SetRowCellValue(e.RowHandle, "DonGiaDiaDiem", hs.DonGia);
                    gridViewKhoiLuongThucTapCuoiKhoa.SetRowCellValue(e.RowHandle, "TienXeDiaDiem", hs.TienXeDiaDiem);
                    gridViewKhoiLuongThucTapCuoiKhoa.SetRowCellValue(e.RowHandle, "DonGiaDiaDiemQuyDoi", hs.HeSoDiaDiem * hs.DonGia);
                }
            }
            catch 
            {  } 
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            LoadDataSource();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

    }
}