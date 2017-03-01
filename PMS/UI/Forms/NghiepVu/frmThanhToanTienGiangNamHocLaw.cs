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

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThanhToanTienGiangNamHocLaw : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        //public void KhongDuocPhepCapNhat(string value)
        //{
        //    if (value.ToLower() == "true")
        //    {
        //        btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        //        btnLuu.ShortCut = Shortcut.None;
        //    }
        //    else
        //    {
        //        btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        //    }
        //}
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        DateTime _ngayIn;
        int lanchot = 0;
        DataTable _tblTamUng;
        VList<ViewKhoaBoMon> _listKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
        string _groupName = UserInfo.GroupName;
        bool _userRole;
        #endregion

        public frmThanhToanTienGiangNamHocLaw()
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

        private void frmThanhToanTienGiangNamHocLaw_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewThanhToan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThanhToan, new string[] { "ChonIn", "MaQuanLy", "HoTen", "TenDonVi", "TenLoaiGiangVien", "ChucDanh", "TenLop", "MaBacDaoTao", "ChuyenNganh", "TenNgonNgu", "TenMonHoc", "LoaiHocPhan"
		                                                                , "SoPhut", "KhuVuc", "TietThucDay", "SiSo", "TietQuyDoi", "DonGia", "MucThanhToan", "ThanhTien", "HocKy" }
                                                         , new string[] { "Chọn in", "Mã giảng viên", "Họ Tên", "Khoa - Bộ môn", "Loại giảng viên", "Chức danh", "Lớp", "Loại lớp", "Chuyên ngành", "Ngôn ngữ", "Môn giảng", "Loại tiết giảng"
                                                                        , "Số phút", "Khu vực", "Số tiết", "Sĩ số lớp", "Số tiết quy đổi", "Đơn giá", "Mức thanh toán (%)", "Thành tiền", "Học kỳ" }
                                                         , new int[] { 60, 90, 160, 120, 100, 150, 100, 80, 100, 100, 140, 90, 70, 100, 80, 70, 90, 90, 90, 120, 80 });
            AppGridView.AlignHeader(gridViewThanhToan, new string[] { "ChonIn", "MaQuanLy", "HoTen", "TenDonVi", "TenLoaiGiangVien", "ChucDanh", "TenLop", "MaBacDaoTao", "ChuyenNganh", "TenNgonNgu", "TenMonHoc", "LoaiHocPhan"
		                                                                , "SoPhut", "KhuVuc", "TietThucDay", "SiSo", "TietQuyDoi", "DonGia", "MucThanhToan", "ThanhTien", "HocKy" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThanhToan, "MaQuanLy", "{0:n0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThanhToan, "TietThucDay", "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToan, "TietQuyDoi", "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThanhToan, "ThanhTien", "{0:n0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewThanhToan, "TietThucDay", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThanhToan, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThanhToan, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThanhToan, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewThanhToan, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenLoaiGiangVien", "ChucDanh", "TenLop", "MaBacDaoTao", "ChuyenNganh", "TenNgonNgu", "TenMonHoc", "LoaiHocPhan"
		                                                                , "SoPhut", "KhuVuc", "TietThucDay", "SiSo", "TietQuyDoi", "DonGia", "MucThanhToan", "ThanhTien", "HocKy" });
            AppGridView.HideField(gridViewThanhToan, new string[] { "MucThanhToan" });
            AppGridView.FixedField(gridViewThanhToan, new string[] { "ChonIn", "MaQuanLy", "HoTen" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            #endregion

            PMS.Common.Globals.WordWrapHeader(gridViewThanhToan, 40);

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _lanChot HK01
            AppGridLookupEdit.InitGridLookUp(cboLanChotHK01, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChotHK01, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChotHK01.Properties.ValueMember = "LanChot";
            cboLanChotHK01.Properties.DisplayMember = "LanChot";
            cboLanChotHK01.Properties.NullText = string.Empty;
            #endregion

            #region _lanChot HK02
            AppGridLookupEdit.InitGridLookUp(cboLanChotHK02, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChotHK02, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChotHK02.Properties.ValueMember = "LanChot";
            cboLanChotHK02.Properties.DisplayMember = "LanChot";
            cboLanChotHK02.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            InitLanChotHK01();
            InitLanChotHK02();

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


        void InitLanChotHK01()
        {
            if (cboNamHoc.EditValue != null)
            {
                cboLanChotHK01.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), "HK01", ref lanchot);
                DataTable tblLanChot = new DataTable();
                tblLanChot.Columns.Add("LanChot");
                if (lanchot > 0)
                {
                    for (int i = lanchot; i >= 1; i--)
                    {
                        tblLanChot.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChotHK01.DataSource = tblLanChot;
                cboLanChotHK01.DataBindings.Add("EditValue", bindingSourceLanChotHK01, "LanChot", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }


        void InitLanChotHK02()
        {
            if (cboNamHoc.EditValue != null)
            {
                cboLanChotHK02.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), "HK02", ref lanchot);
                DataTable tblLanChot = new DataTable();
                tblLanChot.Columns.Add("LanChot");
                if (lanchot > 0)
                {
                    for (int i = lanchot; i >= 1; i--)
                    {
                        tblLanChot.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChotHK02.DataSource = tblLanChot;
                cboLanChotHK02.DataBindings.Add("EditValue", bindingSourceLanChotHK02, "LanChot", true, DataSourceUpdateMode.OnPropertyChanged);
            }
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
            if (cboNamHoc.EditValue != null && cboLanChotHK01.EditValue != null && cboLanChotHK02.EditValue != null && cboBacDaoTao.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.BangKeThanhToanTheoNamLaw(cboNamHoc.EditValue.ToString(), cboLanChotHK01.EditValue.ToString(), cboLanChotHK02.EditValue.ToString(), cboBacDaoTao.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
                tb.Load(reader);
                tb.Columns["ChonIn"].ReadOnly = false;
                bindingSourceThanhToan.DataSource = tb;

                //Lấy dữ liệu tạm ứng
                _tblTamUng = new DataTable();
                IDataReader readerTamUng = DataServices.GiangVienTamUngChiTiet.GetTamUngByNamHoc(cboNamHoc.EditValue.ToString());
                _tblTamUng.Load(readerTamUng);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataTable tb = bindingSourceThanhToan.DataSource as DataTable;
                gridViewThanhToan.FocusedRowHandle = -1;
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
                        foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThanhToan.SortedColumns)
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

                //string filter = gridViewThanhToan.ActiveFilterString;
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
                        frm.InBangKeThanhToanTienGiangNamHoc(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboLanChotHK01.EditValue.ToString(), PMS.Common.Globals._cauhinh.BanGiamHieu, UserInfo.FullName, _ngayIn, vListBaoCao, _tblTamUng);
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
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlTTTU.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
        #endregion

        #region Event CheckEdit
        private void checkEditChonInTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChonInTatCa.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewThanhToan.DataRowCount; i++)
                {
                    gridViewThanhToan.SetRowCellValue(i, "ChonIn", "True");
                }
            }
            if (checkEditChonInTatCa.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewThanhToan.DataRowCount; i++)
                {
                    gridViewThanhToan.SetRowCellValue(i, "ChonIn", "False");
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
                }
            }
            catch
            { }
        }

        private void gridViewThanhToan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "ChonIn")
                {
                    DataRowView v = gridViewThanhToan.GetRow(e.RowHandle) as DataRowView;
                    DataTable tb = bindingSourceThanhToan.DataSource as DataTable;

                    foreach (DataRow r in tb.Rows)
                    {
                        if (r["MaQuanLy"].ToString() == v["MaQuanLy"].ToString())
                        {
                            if (v["ChonIn"].ToString().ToLower() == "true")
                            {
                                r["ChonIn"] = true;
                            }
                            else r["ChonIn"] = false;
                        }
                    }
                }
            }
            catch
            { }
        }   
        #endregion

        private void gridViewThanhToan_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void gridViewThanhToan_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //try
            //{
            //    DataRowView v = gridViewThanhToan.GetRow(e.RowHandle) as DataRowView;
            //    DataTable tb = bindingSourceThanhToan.DataSource as DataTable;

            //    foreach (DataRow r in tb.Rows)
            //    {
            //        string s1 = r["MaQuanLy"].ToString();
            //        string s2 = v["MaQuanLy"].ToString();
            //        string s3 = v["ChonIn"].ToString().ToLower();
            //        if (r["MaQuanLy"].ToString() == v["MaQuanLy"].ToString())
            //        {
            //            r["ChonIn"] = v["ChonIn"];
            //        }
            //    }
            //}
            //catch
            //{ }

            //gridViewThanhToan.FocusedRowHandle = -1;
        }

        private void gridViewThanhToan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            InitLanChotHK01();
            InitLanChotHK02();
        }
    }
}