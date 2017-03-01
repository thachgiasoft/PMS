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
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmImportThuLaoHuongDanCuoiKhoa : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnImport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnImport.ShortCut = Shortcut.None;

                btnXoaDotChiTra.Enabled = false;
            }
            else
            {
                btnImport.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoaDotChiTra.Enabled = true;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion
        public frmImportThuLaoHuongDanCuoiKhoa()
        {
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            InitializeComponent();
        }

        private void frmImportThuLaoHuongDanCuoiKhoa_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThuLao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThuLao, new string[] { "MaGiangVienQuanLy", "HoTen", "HuongDanVietBaoCaoTotNghiep", "HuongDanChuyenDeThucTapTotNghiep", "HuongDanKhoaLuanTotNghiep", "PhanBienKhoaLuanTotNghiep", "SoTietQuyDoi", "DonGia", "ThanhTienKhoaLuanChuyenDeTotNghiep", "SoLuongThamGiaHoiDongTotNghiep", "ThanhTienThamGiaHoiDongTotNghiep", "SoTietNoGioChuan", "ThanhTienNoGioChuan", "Thue", "ThucLanh", "NoiDung" }
                    , new string[] { "Mã giảng viên", "họ tên", "Hướng dẫn viết BCTN", "Hướng dẫn chuyên đề TTTN", "Hướng dẫn khoá luận TN", "Phản biện khoá luận TN", "Số tiết quy đổi", "Đơn giá", "Thành tiền", "Tham gia hội đồng TN", "Thành tiền HDTN", "Số tiết nợ giờ chuẩn", "Số tiền nợ giờ chuẩn", "Thuế", "Thực lãnh", "Nội dung" }
                    , new int[] { 90, 150, 150, 150, 150, 150, 100, 80, 90, 150, 150, 150, 150, 100, 120, 150 });
            AppGridView.AlignHeader(gridViewThuLao, new string[] { "MaGiangVienQuanLy", "HoTen", "HuongDanVietBaoCaoTotNghiep", "HuongDanChuyenDeThucTapTotNghiep", "HuongDanKhoaLuanTotNghiep", "PhanBienKhoaLuanTotNghiep", "SoTietQuyDoi", "DonGia", "ThanhTienKhoaLuanChuyenDeTotNghiep", "SoLuongThamGiaHoiDongTotNghiep", "ThanhTienThamGiaHoiDongTotNghiep", "SoTietNoGioChuan", "ThanhTienNoGioChuan", "Thue", "ThucLanh", "NoiDung" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThuLao);
            AppGridView.SummaryField(gridViewThuLao, "MaGiangVienQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThuLao, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLao, "ThanhTienKhoaLuanChuyenDeTotNghiep", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLao, "ThanhTienThamGiaHoiDongTotNghiep", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLao, "ThanhTienNoGioChuan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLao, "Thue", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThuLao, "ThucLanh", DevExpress.Utils.FormatType.Custom, "n0");
            #region InitDotChiTra
            AppGridLookupEdit.InitGridLookUp(cboDotChiTra, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDotChiTra, new string[] { "DotChiTra" }, new string[] { "Đợt chi trả" }, new int[] { 100 });
            cboDotChiTra.Properties.DisplayMember = "DotChiTra";
            cboDotChiTra.Properties.ValueMember = "DotChiTra";
            cboDotChiTra.Properties.NullText = string.Empty;
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
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    cboDotChiTra.DataBindings.Clear();
                    DataTable _tblDotChiTra = new DataTable();
                    IDataReader reader = DataServices.ThuLaoHuongDanCuoiKhoa.GetDotChiTraByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    _tblDotChiTra.Load(reader);
                    bindingSourceDotChiTra.DataSource = _tblDotChiTra;
                    cboDotChiTra.DataBindings.Add("EditValue", bindingSourceDotChiTra, "DotChiTra", true, DataSourceUpdateMode.OnPropertyChanged);
                }
                if (cboDotChiTra.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    DataTable _tblThuLao = new DataTable();
                    IDataReader reader = DataServices.ThuLaoHuongDanCuoiKhoa.GetByNamHocHocKyDotChiTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotChiTra.EditValue.ToString());
                    _tblThuLao.Load(reader);
                    bindingSourceThuLao.DataSource = _tblThuLao;
                }
            }
            catch
            { }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmImportThanhToanThuLao frm = new frmImportThanhToanThuLao(_maTruong, "ThuLaoHuongDanCuoiKhoa"))
            {
                frm.ShowDialog();
            }
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlThuLao.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboDotChiTra.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable _tblThuLao = new DataTable();
                IDataReader reader = DataServices.ThuLaoHuongDanCuoiKhoa.GetByNamHocHocKyDotChiTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotChiTra.EditValue.ToString());
                _tblThuLao.Load(reader);
                bindingSourceThuLao.DataSource = _tblThuLao;
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnXoaDotChiTra_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDotChiTra.Text == "")
                {
                    XtraMessageBox.Show("Bạn chưa chọn đợt chi trả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (XtraMessageBox.Show(string.Format("Bạn muốn xoá dữ liệu thù lao của đợt {0}?", cboDotChiTra.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = 0;
                    
                    DataServices.ThuLaoHuongDanCuoiKhoa.XoaDotChiTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDotChiTra.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Xoá thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Thao tác xoá thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Cursor.Current = Cursors.WaitCursor;
                InitData();
                Cursor.Current = Cursors.Default;
            }
            catch
            {}
          
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    cboDotChiTra.DataBindings.Clear();
                    DataTable _tblDotChiTra = new DataTable();
                    IDataReader reader = DataServices.ThuLaoHuongDanCuoiKhoa.GetDotChiTraByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    _tblDotChiTra.Load(reader);
                    bindingSourceDotChiTra.DataSource = _tblDotChiTra;
                    cboDotChiTra.DataBindings.Add("EditValue", bindingSourceDotChiTra, "DotChiTra", true, DataSourceUpdateMode.OnPropertyChanged);
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
                    cboDotChiTra.DataBindings.Clear();
                    DataTable _tblDotChiTra = new DataTable();
                    IDataReader reader = DataServices.ThuLaoHuongDanCuoiKhoa.GetDotChiTraByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    _tblDotChiTra.Load(reader);
                    bindingSourceDotChiTra.DataSource = _tblDotChiTra;
                    cboDotChiTra.DataBindings.Add("EditValue", bindingSourceDotChiTra, "DotChiTra", true, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
            catch
            { }
        }
    }
}