using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.BaoCao;
using PMS.Services;
using PMS.Common;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeChiTietKhoiLuongGiangDay : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion

        public ucThongKeChiTietKhoiLuongGiangDay()
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

        private void ucThongKeChiTietKhoiLuongGiangDay_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewKhoiLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewKhoiLuong, new string[] { "ChonIn", "MaDonVi", "TenDonVi", "MaQuanLy", "HoTen", "SoHieuCongChuc", "Loai", "MaMonHoc", "TenMonHoc", "Nhom", "MaLop", "SiSo", "TietThucDay", "TietChuNhat", "T7", "Hstp", "HeSoLopDong", "TietQuyDoi", "DonGia", "ThanhTien", "TienCanTren" }
                    , new string[] { "Chọn in", "Mã bộ môn", "Bộ môn", "Mã giảng viên", "Họ và tên", "Mã công chức", "Loại", "Mã môn học", "Tên môn học", "Nhóm", "Mã lớp", "Sĩ số", "Tiết", "CN + Tối", "T7", "HSTP", "HSLĐ", "Tiết quy đổi", "Đơn giá", "Số tiền", "Tiền chặn trên" }
                    , new int[] { 70, 80, 150, 90, 145, 90, 100, 90, 150, 50, 90, 60, 60, 70, 50, 50, 50, 80, 100, 80, 80, 80 });
            AppGridView.AlignHeader(gridViewKhoiLuong, new string[] { "MaDonVi", "TenDonVi", "MaQuanLy", "HoTen", "SoHieuCongChuc", "Loai", "MaMonHoc", "TenMonHoc", "Nhom", "MaLop", "SiSo", "TietThucDay", "TietChuNhat", "T7", "Hstp", "HeSoLopDong", "TietQuyDoi", "DonGia", "ThanhTien", "TienCanTren" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewKhoiLuong, new string[] { "TienCanTren" });
            AppGridView.SummaryField(gridViewKhoiLuong, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuong, "MaMonHoc", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewKhoiLuong, new string[] { "ChonIn", "MaDonVi", "TenDonVi", "MaQuanLy", "HoTen", "SoHieuCongChuc", "Loai", "MaMonHoc", "TenMonHoc", "Nhom", "MaLop", "SiSo", "TietThucDay", "TietChuNhat", "T7", "Hstp", "HeSoLopDong", "TietQuyDoi", "DonGia", "ThanhTien", "TienCanTren" });
            AppGridView.FormatDataField(gridViewKhoiLuong, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuong, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuong, "TienCanTren", DevExpress.Utils.FormatType.Custom, "n0");
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                InitHocKy();
            }
            InitKhoaDonVi();
            InitLoaiGiangVien();
            if (cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                InitGiangVien();
            }
            InitDieuKienLoc();
        }

        void InitKhoaDonVi()
        {
            cboKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoaDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = new VList<ViewKhoaBoMon>();
            _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            //if (groupname != "Administrator")
            //{
            //    if (_maTruong == "UTE")
            //        _vListKhoa = _vListKhoa.FindAll(p => p.TenKhoa == groupname) as VList<ViewKhoaBoMon>;
            //    else
            //        _vListKhoa = _vListKhoa.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoaBoMon>;
            //}

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaBoMon, string.Format("{0} - {1}", v.MaBoMon, v.TenBoMon), CheckState.Unchecked, true));
            }
            cboKhoaDonVi.Properties.Items.AddRange(_list.ToArray());
            cboKhoaDonVi.Properties.SeparatorChar = ';';
            cboKhoaDonVi.CheckAll();
        }

        void InitLoaiGiangVien()
        {
            cboLoaiGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiGiangVien.Properties.Items.Clear();
            TList<LoaiGiangVien> _listLoaiGiangVien = DataServices.LoaiGiangVien.GetAll();
            List<CheckedListBoxItem> _listLoaiGV = new List<CheckedListBoxItem>();
            foreach (LoaiGiangVien l in _listLoaiGiangVien)
            {
                _listLoaiGV.Add(new CheckedListBoxItem(l.MaLoaiGiangVien, l.TenLoaiGiangVien, CheckState.Unchecked, true));
            }
            cboLoaiGiangVien.Properties.Items.AddRange(_listLoaiGV.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
        }

        void InitHocKy()
        {
            cboHocKy.Properties.SelectAllItemCaption = "Tất cả";
            cboHocKy.Properties.TextEditStyle = TextEditStyles.Standard;
            cboHocKy.Properties.Items.Clear();
            VList<ViewHocKy> _listHocKy = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            List<CheckedListBoxItem> _listHK = new List<CheckedListBoxItem>();
            foreach (ViewHocKy v in _listHocKy)
            {
                _listHK.Add(new CheckedListBoxItem(v.MaHocKy, v.MaHocKy, CheckState.Unchecked, true));
            }
            cboHocKy.Properties.Items.AddRange(_listHK.ToArray());
            cboHocKy.Properties.SeparatorChar = ';';
            cboHocKy.CheckAll();
        }

        void InitGiangVien()
        {
            cboGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboGiangVien.Properties.Items.Clear();
            VList<ViewGiangVien> _listGiangVien = DataServices.ViewGiangVien.GetByMaDonViMaLoaiGiangVien(cboKhoaDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
            List<CheckedListBoxItem> _listGV = new List<CheckedListBoxItem>();
            foreach (ViewGiangVien v in _listGiangVien)
            {
                _listGV.Add(new CheckedListBoxItem(v.MaQuanLy, string.Format("{0} - {1}", v.MaQuanLy, v.HoTen), CheckState.Unchecked, true));
            }
            cboGiangVien.Properties.Items.AddRange(_listGV.ToArray());
            cboGiangVien.Properties.SeparatorChar = ';';
            cboGiangVien.CheckAll();
        }

        void InitDieuKienLoc()
        {
            TuyChon[] arrStr = new TuyChon[] { new TuyChon("1a)", "Hệ số TH tính theo qui chế mới")
                , new TuyChon("1b)", "Hệ số LT tính theo qui chế mới")
                , new TuyChon("2)", "Các môn Giáo dục thể chất")
                , new TuyChon("3)", "Có hướng dẫn đồ án môn học")
                , new TuyChon("4)", "Có hướng dẫn đồ án tốt nghiệp")
                , new TuyChon("7)", "Môn học tiểu luận tốt nghiệp")
                , new TuyChon("8)", "Môn học thực tập tốt nghiệp")
                , new TuyChon("9)", "Giảng viên có đơn giá ngoài qui chế")
                , new TuyChon("10)", "Giảng viên nghỉ hưu giữa học kỳ")
                , new TuyChon("11)", "Giảng viên thỉnh giảng không có hợp đồng")
                , new TuyChon("12)", "Giảng viên thỉnh giảng chỉ hướng dẫn đồ án")
                , new TuyChon("16)", "Giảng viên vượt tiền cận trên") };
            cboDieuKienLoc.Properties.ValueMember = "GiaTri";
            cboDieuKienLoc.Properties.DisplayMember = "TheHien";
            AppGridLookupEdit.ShowField(cboDieuKienLoc, new String[] { "GiaTri", "TheHien" }, new String[] { "Giá trị", "Tên tùy chọn" }, new int[] { 60, 200 } );
            cboDieuKienLoc.Properties.NullText = "Chọn điều kiện để lọc";
            bindingSourceDieuKienLoc.DataSource = arrStr;
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.WaitCursor;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        AppGridView.HideField(gridViewKhoiLuong, new string[] { "ChonIn" });
                        gridControlKhoiLuong.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AppGridView.ShowField(gridViewKhoiLuong, new string[] { "ChonIn" });
                    }
                }
            }
            catch
            { }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewKhoiLuong.FocusedRowHandle = -1;
            bindingSourceKhoiLuong.EndEdit();

            DataTable data = bindingSourceKhoiLuong.DataSource as DataTable;
            if (data == null)
                return;
            if (data.Rows.Count == 0) return;
            DataRow[] arrDR = data.Select("ChonIn = 'True'");
            if (arrDR == null || arrDR.Length == 0)
            {
                XtraMessageBox.Show("Vui lòng chọn dòng muốn in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable vListBaoCao = arrDR.CopyToDataTable();

            if (dateEditHanPhanHoi.Text == "")
            {
                XtraMessageBox.Show("Vui lòng chọn thời hạn phản hồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateEditHanPhanHoi.Focus();
                return;
            }
            
            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewKhoiLuong.SortedColumns)
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

            //string filter = gridViewKhoiLuong.ActiveFilterString;
            //if (filter.Contains(".0000m"))
            //    filter = filter.Replace(".0000m", "");
            //if (filter.Contains(".000m"))
            //    filter = filter.Replace(".000m", "");
            //if (filter.Contains(".00m"))
            //    filter = filter.Replace(".00m", "");
            //if (filter.Contains(".0m"))
            //    filter = filter.Replace(".0m", "");
            //if (filter.Contains(".m"))
            //    filter = filter.Replace(".m", "");

            //string filter = gridViewHopDongMoiGiangVien.ActiveFilterString;
            //vListBaoCao = dv.ToTable();
            //if (vListBaoCao == null)
            //    return;

            else if (vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InChiTietKhoiLuongGiangDay(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), PMS.Common.Globals._cauhinh.TenTruong, "", "", "", "", "", "", "", dateEditHanPhanHoi.Text, 0, 0, 0, 0, 0, 0, 0, 0, PMS.Common.Globals._cauhinh.NguoiLapbieu, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn năm học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }
            if (cboHocKy.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboHocKy.Focus();
                return;
            }
            if (cboGiangVien.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGiangVien.Focus();
                return;
            }
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboGiangVien.EditValue != null && cboDieuKienLoc.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ViewKetQuaThanhToanThuLao.GetByMaGiangVienNamHocHocKyLocDieuKien(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboGiangVien.EditValue.ToString(), cboDieuKienLoc.EditValue.ToString());
                tb.Load(reader);
                tb.Columns["ChonIn"].ReadOnly = false;
                bindingSourceKhoiLuong.DataSource = tb;
            }
            gridViewKhoiLuong.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                InitHocKy();
            Cursor.Current = Cursors.Default;
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                InitGiangVien();
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboLoaiGiangVien_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                InitGiangVien();
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void ckbInTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbInTatCa.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewKhoiLuong.DataRowCount; i++)
                {
                    gridViewKhoiLuong.SetRowCellValue(i, "ChonIn", "True");
                }
            }
            if (ckbInTatCa.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewKhoiLuong.DataRowCount; i++)
                {
                    gridViewKhoiLuong.SetRowCellValue(i, "ChonIn", "False");
                }
            }
        }

        private void cboDieuKienLoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboDieuKienLoc.EditValue.ToString().Equals("16)"))
            {
                #region Init GirdView
                AppGridView.InitGridView(gridViewKhoiLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
                AppGridView.ShowField(gridViewKhoiLuong, new string[] { "ChonIn", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "MaDonVi", "TenDonVi", "TongThanhTien", "TienCanTren", "TienVuotCanTren" }
                        , new string[] { "Chọn in", "Mã quản lý", "Họ và tên", "Học hàm", "Học vị", "Loại giảng viên", "Mã bộ môn", "Tên bộ môn", "Tổng thành tiền", "Tiền cận trên", "Tiền vượt" }
                        , new int[] { 60, 80, 150, 100, 100, 100, 80, 150, 100, 100, 100 });
                AppGridView.AlignHeader(gridViewKhoiLuong, new string[] { "ChonIn", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "MaDonVi", "TenDonVi", "TongThanhTien", "TienCanTren", "TienVuotCanTren" }, DevExpress.Utils.HorzAlignment.Center);
                AppGridView.SummaryField(gridViewKhoiLuong, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
                AppGridView.SummaryField(gridViewKhoiLuong, "MaMonHoc", "{0}", DevExpress.Data.SummaryItemType.Count);
                AppGridView.ReadOnlyColumn(gridViewKhoiLuong, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "MaDonVi", "TenDonVi", "TongThanhTien", "TienCanTren", "TienVuotCanTren" });
                AppGridView.HideField(gridViewKhoiLuong, new string[] { "MaDonVi" });
                AppGridView.FormatDataField(gridViewKhoiLuong, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FormatDataField(gridViewKhoiLuong, "TongThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FormatDataField(gridViewKhoiLuong, "TienCanTren", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FormatDataField(gridViewKhoiLuong, "TienVuotCanTren", DevExpress.Utils.FormatType.Custom, "n0");
                #endregion
            }
            else
            {
                #region Init GirdView
                AppGridView.InitGridView(gridViewKhoiLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
                AppGridView.ShowField(gridViewKhoiLuong, new string[] { "ChonIn", "MaDonVi", "TenDonVi", "MaQuanLy", "HoTen", "SoHieuCongChuc", "Loai", "MaMonHoc", "TenMonHoc", "Nhom", "MaLop", "SiSo", "TietThucDay", "TietChuNhat", "T7", "Hstp", "HeSoLopDong", "TietQuyDoi", "DonGia", "ThanhTien", "TienCanTren" }
                        , new string[] { "Chọn in", "Mã bộ môn", "Bộ môn", "Mã giảng viên", "Họ và tên", "Mã công chức", "Loại", "Mã môn học", "Tên môn học", "Nhóm", "Mã lớp", "Sĩ số", "Tiết", "CN + Tối", "T7", "HSTP", "HSLĐ", "Tiết quy đổi", "Đơn giá", "Số tiền", "Tiền chặn trên" }
                        , new int[] { 70, 80, 150, 90, 145, 90, 100, 90, 150, 50, 90, 60, 60, 70, 50, 50, 50, 80, 100, 80, 80, 80 });
                AppGridView.AlignHeader(gridViewKhoiLuong, new string[] { "MaDonVi", "TenDonVi", "MaQuanLy", "HoTen", "SoHieuCongChuc", "Loai", "MaMonHoc", "TenMonHoc", "Nhom", "MaLop", "SiSo", "TietThucDay", "TietChuNhat", "T7", "Hstp", "HeSoLopDong", "TietQuyDoi", "DonGia", "ThanhTien", "TienCanTren" }, DevExpress.Utils.HorzAlignment.Center);
                AppGridView.HideField(gridViewKhoiLuong, new string[] { "TienCanTren" });
                AppGridView.SummaryField(gridViewKhoiLuong, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
                AppGridView.SummaryField(gridViewKhoiLuong, "MaMonHoc", "{0}", DevExpress.Data.SummaryItemType.Count);
                AppGridView.ReadOnlyColumn(gridViewKhoiLuong, new string[] { "ChonIn", "MaDonVi", "TenDonVi", "MaQuanLy", "HoTen", "SoHieuCongChuc", "Loai", "MaMonHoc", "TenMonHoc", "Nhom", "MaLop", "SiSo", "TietThucDay", "TietChuNhat", "T7", "Hstp", "HeSoLopDong", "TietQuyDoi", "DonGia", "ThanhTien", "TienCanTren" });
                AppGridView.FormatDataField(gridViewKhoiLuong, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FormatDataField(gridViewKhoiLuong, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
                AppGridView.FormatDataField(gridViewKhoiLuong, "TienCanTren", DevExpress.Utils.FormatType.Custom, "n0");
                #endregion
            }
            bindingSourceKhoiLuong.DataSource = null;
        }

    }
}
