using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu.GVTamUng
{
    public partial class frmThanhToanTamUng : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        DateTime _ngayIn;
        VList<ViewKhoaBoMon> _listKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
        string _groupName = UserInfo.GroupName;
        bool _userRole;
        #endregion

        public frmThanhToanTamUng()
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

        private void frmThanhToanTamUng_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewThanhToanTamUng, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThanhToanTamUng, new string[] { "DaTamUng", "ChonIn", "MaQuanLyGv", "HoTen", "TenDonVi", "TenLoaiGiangVien", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "SoLuong", "LoaiHocPhan", "MaBacDaoTao"
		                                                                , "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "HeSoNienCheTinChi", "HeSoTroCap", "SoTietThucTeQuyDoi", "MucThanhToanNhomMon", "TietQuyDoi", "DonGia", "MucThanhToan", "ThanhTien", "DotTamUng", "NgayTamUng" }
                                                         , new string[] { "Đã tạm ứng", "Chọn in", "Mã giảng viên", "Họ Tên", "Khoa - Bộ môn", "Loại giảng viên", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Số SV ĐK", "Loại học phần", "Bậc đào tạo"
                                                                        , "Hệ số công việc", "Hệ số bậc đào tạo", "Hệ số ngôn ngữ", "Hệ số chức danh", "Hệ số lớp đông", "Hệ số cơ sở", "Tiết dạy thực tế", "Hệ số niên chế-tín chỉ", "Hệ số cao học tính thêm", "Tiết thực tế quy đổi", "Mức thanh toán(%)", "Tiết quy đổi", "Đơn giá", "Mức tạm ứng(%)", "Thành tiền", "Đợt tạm ứng", "Ngày tạm ứng" }
                                                         , new int[] { 70, 60, 100, 160, 120, 100, 150, 80, 100, 100, 100, 90, 90, 100, 110, 110, 100, 90, 90, 120, 120, 90, 120, 90, 90, 70, 70, 90, 100, 90 });
            AppGridView.AlignHeader(gridViewThanhToanTamUng, new string[] { "DaTamUng", "ChonIn", "MaQuanLyGv", "HoTen", "TenDonVi", "TenLoaiGiangVien", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "SoLuong", "LoaiHocPhan", "MaBacDaoTao"
		                                                                , "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "HeSoNienCheTinChi", "HeSoTroCap", "SoTietThucTeQuyDoi", "MucThanhToanNhomMon", "TietQuyDoi", "DonGia", "MucThanhToan", "ThanhTien", "DotTamUng", "NgayTamUng" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewThanhToanTamUng, new string[] { "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "HeSoNienCheTinChi", "HeSoTroCap", "MucThanhToanNhomMon" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThanhToanTamUng, "MaQuanLyGv", "Tổng: {0:n0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThanhToanTamUng, "TietThucDay", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanTamUng, "SoTietThucTeQuyDoi", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToanTamUng, "TietQuyDoi", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewThanhToanTamUng, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n3");
            AppGridView.FormatDataField(gridViewThanhToanTamUng, "SoTietThucTeQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThanhToanTamUng, "HeSoNienCheTinChi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThanhToanTamUng, "HeSoTroCap", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThanhToanTamUng, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThanhToanTamUng, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewThanhToanTamUng, new string[] { "MaQuanLyGv", "HoTen", "TenDonVi", "TenLoaiGiangVien", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "SoLuong", "LoaiHocPhan", "MaBacDaoTao"
		                                                                , "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "HeSoNienCheTinChi", "HeSoTroCap", "SoTietThucTeQuyDoi", "MucThanhToanNhomMon", "TietQuyDoi", "DonGia", "MucThanhToan", "ThanhTien", "DotTamUng", "NgayTamUng" });
            AppGridView.FixedField(gridViewThanhToanTamUng, new string[] { "DaTamUng", "ChonIn", "MaQuanLyGv", "HoTen" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            #endregion

            PMS.Common.Globals.WordWrapHeader(gridViewThanhToanTamUng, 50);

            PMS.Common.Globals.GridRowColor(gridViewThanhToanTamUng, Color.Aquamarine, "DaTamUng", "True");

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Hoc Ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã hoc kỳ", "Tên học kỳ" });
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
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            #region Init BacDaoTao
            cboBacDaoTao.Properties.SelectAllItemCaption = "Tất cả";
            cboBacDaoTao.Properties.TextEditStyle = TextEditStyles.Standard;
            cboBacDaoTao.Properties.Items.Clear();

            VList<ViewBacDaoTao> _vListBacDaoTao = DataServices.ViewBacDaoTao.GetAll();

            List<CheckedListBoxItem> _listBac = new List<CheckedListBoxItem>();
            foreach (ViewBacDaoTao v in _vListBacDaoTao)
            {
                _listBac.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.TenBacDaoTao, CheckState.Unchecked, true));
            }

            cboBacDaoTao.Properties.Items.AddRange(_listBac.ToArray());
            cboBacDaoTao.Properties.SeparatorChar = ';';
            cboBacDaoTao.CheckAll();
            #endregion

            #region Init LoaiHinhDaoTao
            cboLoaiHinhDaoTao.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiHinhDaoTao.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiHinhDaoTao.Properties.Items.Clear();

            DataTable _vListLoaiHinhDaoTao = new DataTable();
            IDataReader reader = DataServices.ViewLoaiHinhDaoTao.GetMaTen("");
            _vListLoaiHinhDaoTao.Load(reader); 
            List<CheckedListBoxItem> _listLH = new List<CheckedListBoxItem>();
            foreach (DataRow v in _vListLoaiHinhDaoTao.Rows)
            {
                _listLH.Add(new CheckedListBoxItem(v["MaLoaiHinh"].ToString(), v["TenLoaiHinh"].ToString(), CheckState.Unchecked, true));
            }

            cboLoaiHinhDaoTao.Properties.Items.AddRange(_listLH.ToArray());
            cboLoaiHinhDaoTao.Properties.SeparatorChar = ';';
            cboLoaiHinhDaoTao.CheckAll();
            #endregion

            #region Init Khoa-DonVi
            VList<ViewKhoaBoMon> _vListKhoaBoMon = new VList<ViewKhoaBoMon>();
            foreach (ViewKhoaBoMon v in _listKhoaBoMon)
            {
                if (_groupName == v.MaBoMon)
                {
                    _userRole = true;
                    break;
                }
                else
                    _userRole = false;
            }

            if (_userRole)
            {
                _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                checkEditChonTamUngTatCa.Properties.ReadOnly = true;
                
                AppGridView.HideField(gridViewThanhToanTamUng, new string[] { "DaTamUng" });
            }
            else
            {
                _vListKhoaBoMon = _listKhoaBoMon;
            }

            cboKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoaDonVi.Properties.Items.Clear();

            _vListKhoaBoMon.Sort("MaKhoa");
            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaBoMon, v.TenBoMon, CheckState.Unchecked, true));
            }

            cboKhoaDonVi.Properties.Items.AddRange(_list.ToArray());
            cboKhoaDonVi.Properties.SeparatorChar = ';';
            cboKhoaDonVi.CheckAll();
            #endregion

            #region Init LoaiGiangVien
            cboLoaiGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiGiangVien.Properties.Items.Clear();

            TList<LoaiGiangVien> _listLoaiGv = new TList<LoaiGiangVien>();
            _listLoaiGv = DataServices.LoaiGiangVien.GetAll();

            List<CheckedListBoxItem> _listLGV = new List<CheckedListBoxItem>();
            foreach (LoaiGiangVien v in _listLoaiGv)
            {
                _listLGV.Add(new CheckedListBoxItem(v.MaLoaiGiangVien.ToString(), v.TenLoaiGiangVien, CheckState.Unchecked, true));
            }
            cboLoaiGiangVien.Properties.Items.AddRange(_listLGV.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
            #endregion
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboBacDaoTao.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KhoiLuongTamUng.GetDuLieuThanhToanTamUng(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboBacDaoTao.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
                tb.Load(reader);
                tb.Columns["DaTamUng"].ReadOnly = false;
                tb.Columns["ChonIn"].ReadOnly = false;
                bindingSourceThanhToanTamUng.DataSource = tb;
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //int kiemTra = -1;
                //DataServices.QuyDoiKhoiLuongTamUng.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kiemTra);

                //if (kiemTra == 0)//Chưa chốt
                //{
                //    XtraMessageBox.Show(string.Format("Vui lòng thực hiện chốt giờ giảng tạm ứng năm học {0} - {1} trước khi thanh toán tạm ứng.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                DataTable tb = bindingSourceThanhToanTamUng.DataSource as DataTable;
                gridViewThanhToanTamUng.FocusedRowHandle = -1;
                if (tb.Rows.Count > 0)
                {
                    using (frmChonDotTamUng frm = new frmChonDotTamUng())
                    {
                        frm.ShowDialog();

                        if (frm.XacNhan)
                        {
                            string xmlData = "";
                            foreach (DataRow r in tb.Rows)
                            {
                                if (r.RowState == DataRowState.Modified)
                                {
                                    xmlData += "<Input MGV=\"" + r["MaQuanLyGv"]
                                        + "\" MLHP=\"" + r["MaLopHocPhan"]
                                        + "\" TD=\"" + frm.TenDotTamUng
                                        + "\" N=\"" + frm.NgayTamUng.ToString("dd/MM/yyyy")
                                        + "\" X=\"" + r["DaTamUng"]
                                        + "\" />";
                                }
                            }

                            xmlData = "<Root>" + xmlData + "</Root>";

                            int result = -1;
                            DataServices.GiangVienTamUngChiTiet.LuuTamUng(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboBacDaoTao.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), ref result);

                            if (result == 0)
                            {
                                XtraMessageBox.Show("Lưu tạm ứng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                XtraMessageBox.Show("Đã có lỗi trong quá trình lưu tạm ứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            btnLocDuLieu.PerformClick();
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
            catch
            { }
            
        }
        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataTable tb = bindingSourceThanhToanTamUng.DataSource as DataTable;
                gridViewThanhToanTamUng.FocusedRowHandle = -1;

                if (tb.Rows.Count == 0) return;

                DataTable vListBaoCao = tb.Select("ChonIn = 'True'").CopyToDataTable();

                if (vListBaoCao.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn dòng muốn in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (frmChonNgay frmChon = new frmChonNgay())
                {
                    frmChon.ShowDialog();

                    if (frmChon.NgayIn.ToString("dd/MM/yyyy") == "01/01/0001")
                        return;
                    _ngayIn = frmChon.NgayIn;

                }

                string sort = "";
                if (vListBaoCao != null)
                {
                    if (vListBaoCao.Rows.Count != 0)
                    {
                        foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThanhToanTamUng.SortedColumns)
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

                //string filter = gridViewThanhToanTamUng.ActiveFilterString;
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
                    using (frmBaoCao frm = new frmBaoCao())
                    {
                        frm.InBangKeThanhToanTamUng(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), PMS.Common.Globals._cauhinh.BanGiamHieu, UserInfo.FullName, _ngayIn, vListBaoCao);
                        frm.ShowDialog();
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch
            {
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                AppGridView.HideField(gridViewThanhToanTamUng, new string[] { "DaTamUng", "ChonIn" });
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            PMS.Common.Globals.NoWrapHeader(gridViewThanhToanTamUng);
                            AppGridView.SetColumnWidth(gridViewThanhToanTamUng, new string[] { "DaTamUng", "ChonIn", "MaQuanLyGv", "HoTen", "TenDonVi", "TenLoaiGiangVien", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "SoLuong", "LoaiHocPhan", "MaBacDaoTao"
		                                                 , "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "HeSoNienCheTinChi", "HeSoTroCap", "SoTietThucTeQuyDoi", "MucThanhToanNhomMon", "TietQuyDoi", "DonGia", "MucThanhToan", "ThanhTien", "DotTamUng", "NgayTamUng" }
                                                         , new int[] { 70, 60, 100, 160, 120, 100, 150, 80, 100, 100, 100, 90, 90, 100, 110, 110, 100, 90, 90, 120, 120, 90, 120, 90, 90, 70, 70, 90, 100, 90 });
                            gridControlTTTU.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
                AppGridView.ShowField(gridViewThanhToanTamUng, new string[] { "DaTamUng", "ChonIn" });
            }
            catch
            { }
        }
        #endregion

        #region Event CheckEdit
        private void checkEditChonTamUngTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChonTamUngTatCa.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewThanhToanTamUng.DataRowCount; i++)
                {
                    gridViewThanhToanTamUng.SetRowCellValue(i, "DaTamUng", "True");
                }
            }
            if (checkEditChonTamUngTatCa.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewThanhToanTamUng.DataRowCount; i++)
                {
                    gridViewThanhToanTamUng.SetRowCellValue(i, "DaTamUng", "False");
                }
            }
        }

        private void checkEditChonInTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChonInTatCa.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewThanhToanTamUng.DataRowCount; i++)
                {
                    gridViewThanhToanTamUng.SetRowCellValue(i, "ChonIn", "True");
                }
            }
            if (checkEditChonInTatCa.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewThanhToanTamUng.DataRowCount; i++)
                {
                    gridViewThanhToanTamUng.SetRowCellValue(i, "ChonIn", "False");
                }
            }
        }
        #endregion

        #region Event Grid
        private void gridViewThanhToanTamUng_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (_maTruong == "LAW")
                {
                    if (e.Column.FieldName == "HeSoNienCheTinChi")
                    {
                        if (Convert.ToDouble(e.Value) == 1.111111)
                            e.DisplayText = "50/45";
                    }
                    if (e.Column.FieldName == "HeSoTroCap")
                    {
                        if (Convert.ToDouble(e.Value) == 1.333333)
                            e.DisplayText = "20/15";
                    }
                }
            }
            catch
            { }
        }
        #endregion
    }
}