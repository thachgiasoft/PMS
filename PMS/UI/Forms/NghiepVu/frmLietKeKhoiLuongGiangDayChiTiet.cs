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
    public partial class frmLietKeKhoiLuongGiangDayChiTiet : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion
        #region Event Form
        public frmLietKeKhoiLuongGiangDayChiTiet()
        {
            InitializeComponent();
            TList<CauHinh> listCauHinh = DataServices.CauHinh.GetAll();
            if (listCauHinh != null)
            {
                foreach (CauHinh ch in listCauHinh)
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
            }
        }

        private void frmLietKeKhoiLuongGiangDayChiTiet_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewLietKeKhoiLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewLietKeKhoiLuong, new string[] { "Loai", "MaMonHoc", "TenMonHoc", "Nhom", "MaLop", "SiSo", "SoTiet", "TietChuNhat", "T7", "Hstp", "HeSoLopDong", "DonGia", "TongThanhTien", "TietQuyDoi" }
                    , new string[] { "Loại", "Mã môn học", "Tên môn học", "Nhóm", "Mã lớp", "Sĩ số", "Tiết", "CN + Tối", "T7", "HSTP", "HSLĐ", "Đơn giá", "Số tiền", "Tiết quy đổi" }
                    , new int[] { 50, 90, 150, 50, 90, 60, 60, 70, 50, 50, 50, 80, 100, 80, 80 });
            AppGridView.AlignHeader(gridViewLietKeKhoiLuong, new string[] { "Loai", "MaMonHoc", "TenMonHoc", "Nhom", "MaLop", "SiSo", "SoTiet", "TietChuNhat", "T7", "Hstp", "HeSoLopDong", "DonGia", "TongThanhTien", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewLietKeKhoiLuong, "MaMonHoc", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewLietKeKhoiLuong);
            //gridViewLietKeKhoiLuong.Columns["PhanLoai"].GroupIndex = 0;

            AppGridView.FormatDataField(gridViewLietKeKhoiLuong, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewLietKeKhoiLuong, "TongThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
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

            #region GiangVien
            AppGridLookupEdit.InitGridLookUp(cboGiangVien, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboGiangVien, new string[] { "MaQuanLy", "HoTen" }, new string[] { "Mã giảng viên", "Họ tên" });
            cboGiangVien.Properties.ValueMember = "MaQuanLy";
            cboGiangVien.Properties.DisplayMember = "HoTen";
            cboGiangVien.Properties.NullText = string.Empty;
            #endregion

            dateEditThoiHanPhanHoi.DateTime = DateTime.Now;

            InitData();
        }
        #endregion
        #region InitData
        void InitData()
        {
            bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            bindingSourceLietKeKhoiLuong.DataSource = null;
        }
        #endregion
        #region Event Button
        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboGiangVien.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.UteThanhToanThuLao.LietKeKhoiLuongGiangDay(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboGiangVien.EditValue.ToString());
                tb.Load(reader);
                bindingSourceLietKeKhoiLuong.DataSource = tb;
                gridViewLietKeKhoiLuong.ExpandAllGroups();
                
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewLietKeKhoiLuong.FocusedRowHandle = -1;
            bindingSourceLietKeKhoiLuong.EndEdit();
            //AppType objLoaiBaoCao = bindingSourceDanhSachGiangVien.Current as AppType;
            DataTable data = bindingSourceLietKeKhoiLuong.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewLietKeKhoiLuong, bindingSourceLietKeKhoiLuong);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewLietKeKhoiLuong.SortedColumns)
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

            //string filter = gridViewLietKeKhoiLuong.ActiveFilterString;
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

            #region Tinh cac khoan tien
            decimal _tongTietQuyDoi = 0, _tietGiangDay = 0, _tietDAMHLA = 0, _tietNghiaVu = 0, _donGiaTinh = 0, _soTietThieu = 0, _tienThieuTiet = 0
                , _soTienThucLanh = 0, _tienGiangDayDAMHLA = 0, _tienGiangDayLTTHKLK = 0;
            foreach (DataRow row in vListBaoCao.Rows)
            {
                _tongTietQuyDoi += (decimal)row["TietQuyDoi"];
                if (row["Loai"].ToString() == "LT" || row["Loai"].ToString() == "TH" || row["Loai"].ToString() == "KLK")
                {
                    _tietGiangDay += (decimal)row["TietQuyDoi"];
                    _tienGiangDayLTTHKLK += (decimal)row["TongThanhTien"];
                }
                else
                { 
                    _tietDAMHLA += (decimal)row["TietQuyDoi"];
                    _tienGiangDayDAMHLA += (decimal)row["TongThanhTien"];
                }
            }

            double TietNghiaVu = 0;
            ViewGiangVien gv = bindingSourceGiangVien.Current as ViewGiangVien;
            DataServices.GiangVien.GetSoTietNghiaVuByMaQuanLyNamHocHocKy(gv.MaQuanLy, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref TietNghiaVu);
            _tietNghiaVu = (decimal)TietNghiaVu / 2;
            double DonGia=0;
            //DataServices.DonGia.GetByMaLoaiGiangVienMaHocHamMaHocViHocKy((int)gv.MaLoaiGiangVien, (int)gv.MaHocHam, (int)gv.MaHocVi, cboHocKy.EditValue.ToString(), ref DonGia);
            DataServices.DonGia.GetByMaQuanLyNamHocHocKy(gv.MaQuanLy, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref DonGia);
            _donGiaTinh = (int)DonGia;
            if (_tietNghiaVu > _tietGiangDay)
            {
                _soTietThieu = _tietNghiaVu - _tietGiangDay;
                _tienThieuTiet = _soTietThieu * _donGiaTinh;
                //_soTienThucLanh = _tietDAMHLA * _donGiaTinh;
                _soTienThucLanh = _tienGiangDayDAMHLA;
            }
            else
            {
                _soTietThieu = 0;
                _tienThieuTiet = 0;
                //_soTienThucLanh = ((_tietGiangDay - _tietNghiaVu) + _tietDAMHLA) * _donGiaTinh;
                _soTienThucLanh = (_tienGiangDayLTTHKLK + _tienGiangDayDAMHLA) - (_tietNghiaVu * _donGiaTinh);
            }
            #endregion

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InLietKeKhoiLuongGiangDay(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), PMS.Common.Globals._cauhinh.TenTruong, gv.MaQuanLy, gv.HoTen, gv.MaDonVi, gv.TenDonVi, gv.TenHocHam, gv.TenHocVi, gv.GioiTinh, dateEditThoiHanPhanHoi.Text, _tongTietQuyDoi, _tietGiangDay, _tietDAMHLA, (decimal)_tietNghiaVu, _donGiaTinh, _soTietThieu, _tienThieuTiet, _soTienThucLanh, PMS.Common.Globals._cauhinh.NguoiLapbieu, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion#
    }
}