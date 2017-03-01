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
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Forms.NghiepVu.KhongChinhQuy
{
    public partial class frmKhoiLuongDoAnTotNghiepChiTiet_Kcq : DevExpress.XtraEditors.XtraForm
    {
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

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        TList<KcqHeSoDiaDiem> _listDiaDiem = DataServices.KcqHeSoDiaDiem.GetAll();
        int kiemtra = 0;
        #endregion
        public frmKhoiLuongDoAnTotNghiepChiTiet_Kcq()
        {
            InitializeComponent();
        }

        private void frmKhoiLuongDoAnTotNghiepChiTiet_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewKhoiLuongDoAnTotNghiepChiTiet, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongDoAnTotNghiepChiTiet, new string[] { "MaGiangVien", "HoTen", "MaMonHoc", "TenMonHoc", "SoTinChi", "LopClc", "MaDiaDiem", "TenDiaDiem", "TienXeDiaDiem", "SoLuongHuongDan", "SoTiet", "HeSoHocKy", "DonGia", "SoTien" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Mã môn học", "Tên môn học", "STC", "Lớp CLC", "Mã địa điểm", "Tên địa điểm", "Tiền xe địa điểm", "Sĩ số", "Số tiết", "Hệ số học kỳ", "Đơn giá", "Số tiền" }
                    , new int[] { 100, 150, 90, 150, 60, 60,90,150,90, 60, 60, 90, 90, 100 });
            AppGridView.AlignHeader(gridViewKhoiLuongDoAnTotNghiepChiTiet, new string[] { "MaGiangVien", "HoTen", "MaMonHoc", "TenMonHoc", "SoTinChi", "LopClc", "MaDiaDiem", "TenDiaDiem", "TienXeDiaDiem", "SoLuongHuongDan", "SoTiet", "HeSoHocKy", "DonGia", "SoTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongDoAnTotNghiepChiTiet, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.RegisterControlField(gridViewKhoiLuongDoAnTotNghiepChiTiet, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewKhoiLuongDoAnTotNghiepChiTiet, "MaDiaDiem", repositoryItemGridLookUpEditDiaDiem);
            AppGridView.FormatDataField(gridViewKhoiLuongDoAnTotNghiepChiTiet, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongDoAnTotNghiepChiTiet, "SoTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuongDoAnTotNghiepChiTiet, "TienXeDiaDiem", DevExpress.Utils.FormatType.Custom, "n0");
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen" }, new string[] { "Mã giảng viên", "Họ tên" });
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region MaDiaDiem
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDiaDiem, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditDiaDiem, 360, 600);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDiaDiem, new string[] { "MaQuanLy", "TenDiaDiem", "HeSoDiaDiem", "DonGia", "TienXeDiaDiem" }, new string[] { "Mã địa điểm", "Tên địa điểm", "Hệ số địa điểm", "Đơn giá", "Tiền xe địa điểm" }, new int[] { 100, 150, 80, 80, 90 });
            repositoryItemGridLookUpEditDiaDiem.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditDiaDiem.DisplayMember = "MaQuanLy";
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
                bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetAll();
                bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
                bindingSourceDiaDiem.DataSource = DataServices.KcqHeSoDiaDiem.GetAll();
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    DataTable dt = new DataTable();
                    dt.Load(DataServices.KcqKhoiLuongDoAnTotNghiepChiTiet.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()));
                    bindingSourceKhoiLuong.DataSource = dt;
                }
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
                DataServices.KcqChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DATN", ref kiemtra);
                if (kiemtra == 1)
                {
                    XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép sửa đổi.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (frmXuLyDuLieu_Kcq frm = new frmXuLyDuLieu_Kcq(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DongBoDoAnTotNghiep"))
                {
                    frm.ShowDialog();
                }
                {
                    DataTable dt = new DataTable();
                    dt.Load(DataServices.KcqKhoiLuongDoAnTotNghiepChiTiet.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()));
                    bindingSourceKhoiLuong.DataSource = dt;
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataServices.KcqChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DATN", ref kiemtra);
                if (kiemtra == 1)
                {
                    XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép sửa đổi.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                gridViewKhoiLuongDoAnTotNghiepChiTiet.FocusedRowHandle = -1;
                //string xmlData = "";
                DataTable tb = bindingSourceKhoiLuong.DataSource as DataTable;
                if (tb.Rows.Count > 0)
                {
                    if (XtraMessageBox.Show("Bạn muốn lưu thay đổi thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string xmlData = "";
                        foreach (DataRow row in tb.Rows)
                        {

                            xmlData += "<Input I=\"" + row["Id"].ToString()
                                        + "\" S=\"" + PMS.Common.Globals.IsNull(row["SoLuongHuongDan"].ToString(), "int")
                                        + "\" D=\"" + row["MaDiaDiem"].ToString()
                                        + "\" />";
                        }
                        xmlData = "<Root>" + xmlData + "</Root>";

                        int kq = 0;
                        DataServices.KcqKhoiLuongDoAnTotNghiepChiTiet.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                //TList<KcqKhoiLuongDoAnTotNghiepChiTiet> list = bindingSourceKhoiLuong.DataSource as TList<KcqKhoiLuongDoAnTotNghiepChiTiet>;
                using (frmXuLyDuLieu_Kcq frm = new frmXuLyDuLieu_Kcq(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), tb, "TinhDuLieuDoAnTotNghiep"))
                {
                    frm.ShowDialog();
                }
                {
                    DataTable dt = new DataTable();
                    dt.Load(DataServices.KcqKhoiLuongDoAnTotNghiepChiTiet.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()));
                    bindingSourceKhoiLuong.DataSource = dt;
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
                {
                    DataTable dt = new DataTable();
                    dt.Load(DataServices.KcqKhoiLuongDoAnTotNghiepChiTiet.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()));
                    bindingSourceKhoiLuong.DataSource = dt;
                }
            }
            catch
            { }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    DataTable dt = new DataTable();
                    dt.Load(DataServices.KcqKhoiLuongDoAnTotNghiepChiTiet.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()));
                    bindingSourceKhoiLuong.DataSource = dt;
                }
            }
            catch
            { }
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
                        gridControlKhoiLuongDoAnTotNghiepChiTiet.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void gridViewKhoiLuongDoAnTotNghiepChiTiet_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridColumn col = e.Column;
                int pos = e.RowHandle;
                if (col.FieldName == "MaDiaDiem")
                {
                    DataRowView v = gridViewKhoiLuongDoAnTotNghiepChiTiet.GetRow(pos) as DataRowView;

                    string _tenDiaDiem = _listDiaDiem.Find(p => p.MaQuanLy == v["MaDiaDiem"].ToString()).TenDiaDiem;
                    decimal? _tienxeDiaDiem = _listDiaDiem.Find(p => p.MaQuanLy == v["MaDiaDiem"].ToString()).TienXeDiaDiem;
                    gridViewKhoiLuongDoAnTotNghiepChiTiet.SetRowCellValue(e.RowHandle, "TenDiaDiem", _tenDiaDiem);
                    gridViewKhoiLuongDoAnTotNghiepChiTiet.SetRowCellValue(e.RowHandle, "TienXeDiaDiem", _tienxeDiaDiem);
                    gridViewKhoiLuongDoAnTotNghiepChiTiet.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now);
                }
            }
            catch
            { }

        }
    }
}