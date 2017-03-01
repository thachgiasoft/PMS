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
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmNhapCacKhoanChiKhac : DevExpress.XtraEditors.XtraForm
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
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        VList<ViewGiangVien> _listGiangVien;
        TList<KhoanChiKhac> _listKhoanChi;
        #endregion
        public frmNhapCacKhoanChiKhac()
        {
            InitializeComponent();
        }

        private void frmNhapCacKhoanChiKhac_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewKhoanChiKhac, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewKhoanChiKhac, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewKhoanChiKhac, new string[] { "MaQuanLy", "HoTen", "Lop", "Ngay", "NoiDung", "HeSo", "SoTiet", "TienMotTiet", "ThanhTien", "PhiCongTac", "TienGiangNgoaiGio", "TongThanhTien" }
                , new string[] { "Mã giảng viên", "Họ và tên", "Lớp", "Ngày", "Nội dung lên lớp", "Hệ số", "Số tiết", "Tiền một tiết", "Thành tiền", "Công tác phí", "Tiền giảng ngoài giờ", "Tổng cộng" }
                , new int[] { 90, 135, 100, 100, 150, 70, 70, 90, 100, 100, 120, 100 });
            AppGridView.AlignHeader(gridViewKhoanChiKhac, new string[] { "MaQuanLy", "HoTen", "Lop", "Ngay", "NoiDung", "HeSo", "SoTiet", "TienMotTiet", "ThanhTien", "PhiCongTac", "TienGiangNgoaiGio", "TongThanhTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewKhoanChiKhac, new string[] { "HoTen" });
            AppGridView.FormatDataField(gridViewKhoanChiKhac, "TienMotTiet", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoanChiKhac, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoanChiKhac, "PhiCongTac", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoanChiKhac, "TienGiangNgoaiGio", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoanChiKhac, "TongThanhTien", DevExpress.Utils.FormatType.Custom, "n0");

            AppGridView.SummaryField(gridViewKhoanChiKhac, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoanChiKhac, "ThanhTien", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoanChiKhac, "PhiCongTac", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoanChiKhac, "TienGiangNgoaiGio", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoanChiKhac, "TongThanhTien", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.RegisterControlField(gridViewKhoanChiKhac, "MaQuanLy", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewKhoanChiKhac, "NoiDung", repositoryItemGridLookUpEditDanhSachKhoanChiKhac);
            #endregion
            #region InitGiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị" }, new int[] { 90, 140, 170 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 400, 600);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion
            #region Init Danhsach KHoanCHiKhac
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDanhSachKhoanChiKhac, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDanhSachKhoanChiKhac, new string[] { "MaQuanLy", "NoiDung", "MucChi", "GhiChu" }, new string[] { "Mã quản lý", "Nội dung chi", "Mức chi", "Ghi chú" }, new int[] { 90, 160, 100, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditDanhSachKhoanChiKhac, 450, 600);
            repositoryItemGridLookUpEditDanhSachKhoanChiKhac.DisplayMember = "NoiDung";
            repositoryItemGridLookUpEditDanhSachKhoanChiKhac.ValueMember = "NoiDung";
            repositoryItemGridLookUpEditDanhSachKhoanChiKhac.NullText = string.Empty;
            #endregion
            #region Init KyTinhLuong
            AppGridLookupEdit.InitGridLookUp(cboKyTinhLuong, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKyTinhLuong, new string[] { "MaQuanLy", "TuNgay", "DenNgay" }, new string[] { "Kỳ tính lương", "Từ ngày", "Đến ngày" }, new int[] { 110, 100, 100 });
            AppGridLookupEdit.InitPopupFormSize(cboKyTinhLuong, 310, 600);
            cboKyTinhLuong.Properties.DisplayMember = "MaQuanLy";
            cboKyTinhLuong.Properties.ValueMember = "MaQuanLy";
            cboKyTinhLuong.Properties.NullText = string.Empty;
            #endregion
            
            InitData();
        }
        #region InitData
        void InitData()
        {
            cboKyTinhLuong.DataBindings.Clear();
            bindingSourceKyTinhLuong.DataSource = DataServices.KyTinhLuong.GetAll();
            cboKyTinhLuong.DataBindings.Add("EditValue", bindingSourceKyTinhLuong, "MaQuanLy", true, DataSourceUpdateMode.OnPropertyChanged);

            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            _listKhoanChi = DataServices.KhoanChiKhac.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;
            bindingSourceDanhSachCacKhoanChiKhac.DataSource = _listKhoanChi;

            if (cboKyTinhLuong.EditValue != null)
            {
                bindingSourceKhoanChiKhac.DataSource = DataServices.ViewKetQuaCacKhoanChiKhac.GetByNgay(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime);
            }
        }
        #endregion

        private void cboKyTinhLuong_EditValueChanged(object sender, EventArgs e)
        {
            if (cboKyTinhLuong.EditValue != null)
            {
                KyTinhLuong k = bindingSourceKyTinhLuong.Current as KyTinhLuong;
                dateEditTuNgay.DateTime = (DateTime)k.TuNgay;
                dateEditDenNgay.DateTime = (DateTime)k.DenNgay;

                bindingSourceKhoanChiKhac.DataSource = DataServices.ViewKetQuaCacKhoanChiKhac.GetByNgay(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime);
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKhoanChiKhac);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewKhoanChiKhac.FocusedRowHandle = -1;
            VList<ViewKetQuaCacKhoanChiKhac> list = bindingSourceKhoanChiKhac.DataSource as VList<ViewKetQuaCacKhoanChiKhac>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bindingSourceKhoanChiKhac.EndEdit();
                        string xmlData = "";
                        foreach (ViewKetQuaCacKhoanChiKhac v in list)
                        {
                            if (v.Ngay.ToString() == "")
                            {
                                XtraMessageBox.Show("Ngày không được phép bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            xmlData += "<KhoanChiKhac M=\"" + v.MaQuanLy
                                + "\" L=\"" + v.Lop
                                + "\" N=\"" + v.Ngay
                                + "\" Nd=\"" + v.NoiDung
                                + "\" Hs=\"" + v.HeSo
                                + "\" S=\"" + v.SoTiet
                                + "\" T=\"" + v.TienMotTiet
                                + "\" Tt=\"" + v.ThanhTien
                                + "\" P=\"" + v.PhiCongTac
                                + "\" Tg=\"" + v.TienGiangNgoaiGio
                                + "\" Th=\"" + v.TongThanhTien
                                + "\" I=\"" + v.Id
                                + "\" />";
                        }
                        xmlData = String.Format("<Root>{0}</Root>", xmlData);
                        int kq = 0;
                        DataServices.KetQuaCacKhoanChiKhac.Luu(xmlData, dateEditTuNgay.DateTime, dateEditDenNgay.DateTime, ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlKhoanChiKhac.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewKhoanChiKhac_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridColumn col = e.Column;
                if (col.FieldName == "MaQuanLy")
                {
                    int pos = e.RowHandle;
                    ViewKetQuaCacKhoanChiKhac v = gridViewKhoanChiKhac.GetRow(pos) as ViewKetQuaCacKhoanChiKhac;
                    string _hoTen = _listGiangVien.Find(p => p.MaQuanLy == v.MaQuanLy).HoTen;
                    gridViewKhoanChiKhac.SetRowCellValue(pos, "HoTen", _hoTen);
                }
                if (col.FieldName == "NoiDung")
                {
                    int pos = e.RowHandle;
                    ViewKetQuaCacKhoanChiKhac v = gridViewKhoanChiKhac.GetRow(pos) as ViewKetQuaCacKhoanChiKhac;
                    decimal? _tienMotTiet = _listKhoanChi.Find(p => p.NoiDung == v.NoiDung).MucChi;
                    gridViewKhoanChiKhac.SetRowCellValue(pos, "TienMotTiet", _tienMotTiet);
                    gridViewKhoanChiKhac.SetRowCellValue(pos, "HeSo", 1);
                }
                if (col.FieldName == "HeSo" || col.FieldName == "SoTiet" || col.FieldName == "TienMotTiet")
                {
                    int pos = e.RowHandle;
                    ViewKetQuaCacKhoanChiKhac v = gridViewKhoanChiKhac.GetRow(pos) as ViewKetQuaCacKhoanChiKhac;
                    decimal? _thanhTien = v.HeSo * v.SoTiet * v.TienMotTiet;
                    gridViewKhoanChiKhac.SetRowCellValue(pos, "ThanhTien", _thanhTien);
                }
                if (col.FieldName == "ThanhTien" || col.FieldName == "PhiCongTac" || col.FieldName == "TienGiangNgoaiGio")
                {
                    int pos = e.RowHandle;
                    ViewKetQuaCacKhoanChiKhac v = gridViewKhoanChiKhac.GetRow(pos) as ViewKetQuaCacKhoanChiKhac;
                    decimal? _tongThanhTien = IsNull(v.ThanhTien) + IsNull(v.PhiCongTac) + IsNull(v.TienGiangNgoaiGio);
                    gridViewKhoanChiKhac.SetRowCellValue(pos, "TongThanhTien", _tongThanhTien);
                }
                if (col.FieldName == "Ngay")
                {
                    int pos = e.RowHandle;
                    ViewKetQuaCacKhoanChiKhac v = gridViewKhoanChiKhac.GetRow(pos) as ViewKetQuaCacKhoanChiKhac;
                    if (v.Ngay < dateEditTuNgay.DateTime || v.Ngay > dateEditDenNgay.DateTime)
                    {
                        XtraMessageBox.Show(string.Format("Vui lòng nhập ngày trong khoảng từ ngày {0} đến ngày {1}", dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy")), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gridViewKhoanChiKhac.SetRowCellValue(pos, "Ngay", "");
                    }
                }
            }
            catch
            { }
           
        }

        private void gridViewKhoanChiKhac_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKhoanChiKhac, e);
        }
        decimal? IsNull(decimal? O)
        {
            if (O == null)
                O = 0;
            return O;
        }
    }
}