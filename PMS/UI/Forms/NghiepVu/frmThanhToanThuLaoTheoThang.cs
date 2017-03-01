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
using PMS.UI.Forms.BaoCao;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThanhToanThuLaoTheoThang : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion
        public frmThanhToanThuLaoTheoThang()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

            TList<CauHinh> cauHinh = DataServices.CauHinh.GetAll();
            if (cauHinh != null)
            {
                foreach (CauHinh ch in cauHinh)
                {
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
                }
            }
        }

        private void frmThanhToanThuLaoTheoThang_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewThanhToanThuLao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThanhToanThuLao, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "MaLop", "NgayDay", "TenMonHoc", "HeSoLopDong", "SoTiet", "DonGia", "ThanhTien", "CongTacPhi", "TienGiangNgoaiGio", "TongThanhTien", "Thue", "TienChiTra" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị", "Lớp", "Ngày", "Nội dung lên lớp", "Hệ số lớp đông", "Số tiết", "Đơn giá", "Thành tiền", "Công tác phí", "Tiền giảng ngoài giờ", "Tổng tiền chi trả qua ATM", "Khấu trừ thuế TNCN", "Số tiền chi trả" }
                    , new int[] { 90, 135, 120, 80, 90, 120, 100, 65, 70, 80, 90, 100, 150, 120, 110 });
            AppGridView.AlignHeader(gridViewThanhToanThuLao, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "MaLop", "NgayDay", "TenMonHoc", "HeSoLopDong", "SoTiet", "DonGia", "ThanhTien", "CongTacPhi", "TienGiangNgoaiGio", "TongThanhTien", "Thue", "TienChiTra" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThanhToanThuLao);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "SoTiet", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "ThanhTien", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "CongTacPhi", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "TienGiangNgoaiGio", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "TongThanhTien", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewThanhToanThuLao, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThanhToanThuLao, "CongTacPhi", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThanhToanThuLao, "TienGiangNgoaiGio", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThanhToanThuLao, "TongThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThanhToanThuLao, "Thue", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThanhToanThuLao, "TienChiTra", DevExpress.Utils.FormatType.Custom, "n0");
            #endregion

            #region Init KyTinhLuong
            AppGridLookupEdit.InitGridLookUp(cboKyTinhLuong, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKyTinhLuong, new string[] { "MaQuanLy", "TuNgay", "DenNgay" }, new string[] { "Kỳ tính lương", "Từ ngày", "Đến ngày" }, new int[] { 120, 100, 100 });
            AppGridLookupEdit.InitPopupFormSize(cboKyTinhLuong, 320, 600);
            cboKyTinhLuong.Properties.DisplayMember = "MaQuanLy";
            cboKyTinhLuong.Properties.ValueMember = "MaQuanLy";
            cboKyTinhLuong.Properties.NullText = string.Empty;
            #endregion

            #region LoaiGiangVien
            AppGridLookupEdit.InitGridLookUp(cboLoaiGiangVien, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiGiangVien, new string[] { "MaQuanLy", "TenLoaiGiangVien" }, new string[] { "Mã loại giảng viên", "Tên loại giảng viên" }, new int[] { 110, 190 });
            AppGridLookupEdit.InitPopupFormSize(cboLoaiGiangVien, 300, 600);
            cboLoaiGiangVien.Properties.DisplayMember = "TenLoaiGiangVien";
            cboLoaiGiangVien.Properties.ValueMember = "MaLoaiGiangVien";
            cboLoaiGiangVien.Properties.NullText = string.Empty;
            #endregion
            InitData();
            InitKhoaDonVi();
            InitGiangVien();
        }
        #region InitData
        void InitData()
        {
            cboKyTinhLuong.DataBindings.Clear();
            bindingSourceKyTinhLuong.DataSource = DataServices.KyTinhLuong.GetAll();
            cboKyTinhLuong.DataBindings.Add("EditValue", bindingSourceKyTinhLuong, "MaQuanLy", true, DataSourceUpdateMode.OnPropertyChanged);
            cboLoaiGiangVien.DataBindings.Clear();
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            cboLoaiGiangVien.DataBindings.Add("EditValue", bindingSourceLoaiGiangVien, "MaLoaiGiangVien", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        void InitKhoaDonVi()
        {
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = new VList<ViewKhoaBoMon>();
            _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaBoMon, string.Format("{0} - {1}", v.MaBoMon, v.TenBoMon), CheckState.Unchecked, true));
            }
            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
        }

        void InitGiangVien()
        {
            if (cboLoaiGiangVien.EditValue != null && cboDonVi.EditValue != null)
            {
                cboGiangVien.Properties.SelectAllItemCaption = "Tất cả";
                cboGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
                cboGiangVien.Properties.Items.Clear();

                VList<ViewGiangVien> _vListGiangVien = new VList<ViewGiangVien>();
                _vListGiangVien = DataServices.ViewGiangVien.GetByMaDonViMaLoaiGiangVien(cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
                List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
                foreach (ViewGiangVien v in _vListGiangVien)
                {
                    _list.Add(new CheckedListBoxItem(v.MaQuanLy, string.Format("{0} - {1}", v.MaQuanLy, v.HoTen), CheckState.Unchecked, true));
                }
                cboGiangVien.Properties.Items.AddRange(_list.ToArray());
                cboGiangVien.Properties.SeparatorChar = ';';
                cboGiangVien.CheckAll();
            }
        }
        #endregion
        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            InitKhoaDonVi();
            InitGiangVien();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboKyTinhLuong.EditValue != null && cboGiangVien.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.TcbKetQuaQuyDoi.GetByMaGiangVienQuanLyNgay(cboGiangVien.EditValue.ToString(), dateEditTuNgay.DateTime, dateEditDenNgay.DateTime);
                tb.Load(reader);
                bindingSourceKetQuaThanhToan.DataSource = tb;
            }
            Cursor.Current = Cursors.Default;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThanhToanThuLao.FocusedRowHandle = -1;
            bindingSourceKetQuaThanhToan.EndEdit();
            DataTable data = bindingSourceKetQuaThanhToan.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThanhToanThuLao, bindingSourceKetQuaThanhToan);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThanhToanThuLao.SortedColumns)
                    {
                        switch (c.SortOrder)
                        {
                            case DevExpress.Data.ColumnSortOrder.Ascending:
                                sort += string.Format("{0} ASC, ", c.FieldName);
                                break;
                            case DevExpress.Data.ColumnSortOrder.Descending:
                                sort += string.Format("{0} DESC, ", c.FieldName);
                                break;
                        }
                    }
                }
                if (sort != "")
                    sort = sort.Substring(0, sort.Length - 2);
            }

            //string filter = gridViewThanhToanThuLao.ActiveFilterString;
            ////if (filter.Contains(".0000m"))
            ////    filter = filter.Replace(".0000m", "");
            ////if (filter.Contains(".000m"))
            ////    filter = filter.Replace(".000m", "");
            ////if (filter.Contains(".00m"))
            ////    filter = filter.Replace(".00m", "");
            ////if (filter.Contains(".0m"))
            ////    filter = filter.Replace(".0m", "");
            ////if (filter.Contains(".m"))
            ////    filter = filter.Replace(".m", "");

            //DataView dv = new DataView(vListBaoCao, filter, sort, DataViewRowState.CurrentRows);
            ////vListBaoCao = dv.ToTable();
            ////if (vListBaoCao == null)
            //    return;

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                if (cboLoaiGiangVien.EditValue.ToString() == "13")
                {
                    using (frmBaoCao frm = new frmBaoCao())
                    {
                        frm.InKetQuaThanhToanThuLaoCuaGiangVienTheoThang(PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.NguoiLapbieu, vListBaoCao);
                        frm.ShowDialog();
                    }
                }
                else
                {
                    using (frmBaoCao frm = new frmBaoCao())
                    {
                        frm.InKetQuaThanhToanThuLaoCuaGiangVienThinhGiangTheoThang(PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.NguoiLapbieu, vListBaoCao);
                        frm.ShowDialog();
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void cboKyTinhLuong_EditValueChanged(object sender, EventArgs e)
        {
            if (cboKyTinhLuong.EditValue != null)
            {
                KyTinhLuong k = bindingSourceKyTinhLuong.Current as KyTinhLuong;
                dateEditTuNgay.DateTime = (DateTime)k.TuNgay;
                dateEditDenNgay.DateTime = (DateTime)k.DenNgay;
            }
        }

        private void cboLoaiGiangVien_EditValueChanged(object sender, EventArgs e)
        {
            InitGiangVien();
            if(cboLoaiGiangVien.EditValue.ToString() ==  "13")
            {
                bindingSourceKetQuaThanhToan.DataSource = null;
                AppGridView.HideField(gridViewThanhToanThuLao, new string[] { "Thue", "TienChiTra" });
            }
            if (cboLoaiGiangVien.EditValue.ToString() != "13")
            {
                gridViewThanhToanThuLao.Columns.Clear();
                bindingSourceKetQuaThanhToan.DataSource = null;
                AppGridView.ShowField(gridViewThanhToanThuLao, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "MaLop", "NgayDay", "TenMonHoc", "HeSoLopDong", "SoTiet", "DonGia", "ThanhTien", "CongTacPhi", "TienGiangNgoaiGio", "TongThanhTien", "Thue", "TienChiTra" }
                   , new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị", "Lớp", "Ngày", "Nội dung lên lớp", "Hệ số lớp đông", "Số tiết", "Đơn giá", "Thành tiền", "Công tác phí", "Tiền giảng ngoài giờ", "Tổng tiền chi trả qua ATM", "Khấu trừ thuế TNCN", "Số tiền chi trả" }
                   , new int[] { 90, 135, 120, 80, 90, 120, 100, 65, 70, 80, 90, 100, 150, 120, 110 });
                AppGridView.AlignHeader(gridViewThanhToanThuLao, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "MaLop", "NgayDay", "TenMonHoc", "HeSoLopDong", "SoTiet", "DonGia", "ThanhTien", "CongTacPhi", "TienGiangNgoaiGio", "TongThanhTien", "Thue", "TienChiTra" }, DevExpress.Utils.HorzAlignment.Center);
                AppGridView.ReadOnlyColumn(gridViewThanhToanThuLao);
                AppGridView.SummaryField(gridViewThanhToanThuLao, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
                AppGridView.SummaryField(gridViewThanhToanThuLao, "SoTiet", "{0}", DevExpress.Data.SummaryItemType.Sum);
                AppGridView.SummaryField(gridViewThanhToanThuLao, "ThanhTien", "{0}", DevExpress.Data.SummaryItemType.Sum);
                AppGridView.SummaryField(gridViewThanhToanThuLao, "CongTacPhi", "{0}", DevExpress.Data.SummaryItemType.Sum);
                AppGridView.SummaryField(gridViewThanhToanThuLao, "TienGiangNgoaiGio", "{0}", DevExpress.Data.SummaryItemType.Sum);
                AppGridView.SummaryField(gridViewThanhToanThuLao, "TongThanhTien", "{0}", DevExpress.Data.SummaryItemType.Sum);
                AppGridView.FormatDataField(gridViewThanhToanThuLao, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FormatDataField(gridViewThanhToanThuLao, "CongTacPhi", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FormatDataField(gridViewThanhToanThuLao, "TienGiangNgoaiGio", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FormatDataField(gridViewThanhToanThuLao, "TongThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FormatDataField(gridViewThanhToanThuLao, "Thue", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FormatDataField(gridViewThanhToanThuLao, "TienChiTra", DevExpress.Utils.FormatType.Custom, "n0");
            }
        }

        private void cboDonVi_EditValueChanged(object sender, EventArgs e)
        {
            InitGiangVien();
        }
    }
}