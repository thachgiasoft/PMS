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
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Modules.Reports
{
    public partial class ucBangThongKeThanhToanTienGiang_BUH : DevExpress.XtraEditors.XtraUserControl
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
        int lanchot = 0;
        string _maTruong;
        DateTime _ngayIn;

        DataTable dtData;
        bool userRole;
        string _groupName = UserInfo.GroupName;
        TList<DotChiTra> _listDotChiTra;

        #endregion

        public ucBangThongKeThanhToanTienGiang_BUH()
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

        private void ucBangThongKeThanhToanTienGiang_BUH_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaGiangVien", "Ho", "Ten", "TenBoMon", "TietQuyDoi", "DonGia", "ThanhTien", "SoTietClc", "DonGiaClc", "TienSauGiangClc", "ThanhTienClc", "TongCong", "SoTietDinhMucPhaiTru", "TienTruDinhMuc", "SoTienThanhToan", "ThueTncn", "TienViet", "SoTienConDuocNhan", "NoDinhMuc", "GhiChu", "LanChot", "IdGiangVien", "MaLoaiGiangVien" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Đơn vị", "Số tiết đại trà", "Đơn giá đại trà", "Thành tiền đại trà", "Số tiết CLC", "Đơn giá CLC", "Ra đề, chấm thi CLC", "Thành tiền CLC", "Tổng cộng", "Số tiết định mức phải trừ", "Tiền trừ định mức", "Số tiền thanh toán", "Tạm thu thuế TNCN", "Tiền viết", "Số tiền còn được nhận", "Nợ định mức", "Ghi chú", "LanChot", "IdGiangVien", "MaLoaiGiangVien" }
                    , new int[] { 90, 100, 50, 150, 70, 70, 80, 70, 70, 70, 80, 90, 90, 90, 80, 80, 80, 90, 90, 90, 99, 99, 99 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaGiangVien", "Ho", "Ten", "TenBoMon", "TietQuyDoi", "DonGia", "ThanhTien", "SoTietClc", "DonGiaClc", "TienSauGiangClc", "ThanhTienClc", "TongCong", "SoTietDinhMucPhaiTru", "TienTruDinhMuc", "SoTienThanhToan", "ThueTncn", "TienViet", "SoTienConDuocNhan", "NoDinhMuc", "GhiChu", "LanChot", "IdGiangVien", "MaLoaiGiangVien" }, DevExpress.Utils.HorzAlignment.Center);
            //AppGridView.AlignField(gridViewThongKe, new string[] { "MaGiangVien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "DonGiaClc", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienSauGiangClc", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThanhTienClc", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TongCong", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienTruDinhMuc", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "SoTienThanhToan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThueTncn", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienViet", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "SoTienConDuocNhan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "NoDinhMuc", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewThongKe, new string[] { "LanChot", "IdGiangVien", "MaLoaiGiangVien" });
            AppGridView.ReadOnlyColumn(gridViewThongKe, new string[] { "MaGiangVien", "Ho", "Ten", "TenBoMon", "TietQuyDoi", "DonGia", "ThanhTien", "SoTietClc", "DonGiaClc", "TienSauGiangClc", "ThanhTienClc", "TongCong", "SoTietDinhMucPhaiTru", "TienTruDinhMuc", "SoTienThanhToan", "TienViet", "SoTienConDuocNhan", "NoDinhMuc", "LanChot", "IdGiangVien" });
            //gridViewThongKe.Columns["TenLoaiGiangVien"].GroupIndex = 0;
            AppGridView.FixedField(gridViewThongKe, new string[] { "MaGiangVien", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 45);
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
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            #region _lanChot
            AppGridLookupEdit.InitGridLookUp(cboLanChot, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChot, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChot.Properties.ValueMember = "LanChot";
            cboLanChot.Properties.DisplayMember = "LanChot";
            cboLanChot.Properties.NullText = string.Empty;
            #endregion
            #region Init Khoa-DonVi
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (_groupName == v.MaBoMon)
                {
                    userRole = true;
                    break;
                }
                else
                    userRole = false;

            }

            if (userRole)
            {
                _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);

            }

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaKhoa, v.TenKhoa, CheckState.Unchecked, true));
            }

            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
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
            #region DotChiTra
            AppGridLookupEdit.InitGridLookUp(cboDotThanhToan, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDotThanhToan, new string[] { "MaDotChiTra", "TenDotChiTra", "ThuTu" }, new string[] { "Mã đợt chi trả", "Tên đợt chi trả", "Thứ tự" });
            cboDotThanhToan.Properties.ValueMember = "Id";
            cboDotThanhToan.Properties.DisplayMember = "TenDotChiTra";
            cboDotThanhToan.Properties.NullText = string.Empty;
            #endregion
            
            InitData();
        }

        #region InitData()
        void InitDotThanhToan()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                cboDotThanhToan.DataBindings.Clear();
                _listDotChiTra = DataServices.DotChiTra.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                _listDotChiTra.Add(new DotChiTra { ThuTu = 0, Id = -1, MaDotChiTra = "All", TenDotChiTra = "[Tất cả]" });
                bindingSourceDotChiTra.DataSource = _listDotChiTra;

                bindingSourceDotChiTra.Sort = "ThuTu";

                cboDotThanhToan.DataBindings.Add("EditValue", bindingSourceDotChiTra, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            InitLanChot();

            InitDotThanhToan();

            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null && cboLanChot.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader=DataServices.KetQuaThanhToanThuLao.ThongKeThanhToanTienGiang(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()), cboDotThanhToan.EditValue.ToString());
                dt.Load(reader);

                dt.Columns["ThueTncn"].ReadOnly = false;
                dt.Columns["SoTienConDuocNhan"].ReadOnly = false;
                dt.Columns["NoDinhMuc"].ReadOnly = false;
                dt.Columns["GhiChu"].ReadOnly = false;

                bindingSourceThongKe.DataSource = dt;
            }
            gridViewThongKe.ExpandAllGroups();
        }

        void InitLanChot()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                cboLanChot.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                DataTable tblLanChot = new DataTable();
                tblLanChot.Columns.Add("LanChot");
                if (lanchot > 0)
                {
                    for (int i = lanchot; i >= 1; i--)
                    {
                        tblLanChot.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChot.DataSource = tblLanChot;
                cboLanChot.DataBindings.Add("EditValue", bindingSourceLanChot, "LanChot", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                _ngayIn = frmChon.NgayIn;
            }
            Cursor.Current = Cursors.WaitCursor;
            gridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongKe);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThongKe.SortedColumns)
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

            //string filter = gridViewThongKe.ActiveFilterString;
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
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongKe);


            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    string _dot = "";
                    if (cboDotThanhToan.EditValue.ToString() == "-1")
                        _dot = "";
                    else
                        _dot = cboDotThanhToan.Text;
                    frm.InThongKeThanhToanTienGiangTheoHocKy_BUH2(PMS.Common.Globals._cauhinh.TenTruong, PMS.Common.Globals._cauhinh.BanGiamHieu, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _dot, UserInfo.FullName, _ngayIn, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
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
                        gridControlThongKe.ExportToXls(sf.FileName);
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
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeThanhToanTienGiang(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()), cboDotThanhToan.EditValue.ToString());
                dt.Load(reader);

                dt.Columns["ThueTncn"].ReadOnly = false;
                dt.Columns["SoTienConDuocNhan"].ReadOnly = false;
                dt.Columns["NoDinhMuc"].ReadOnly = false;
                dt.Columns["GhiChu"].ReadOnly = false;

                bindingSourceThongKe.DataSource = dt;
            }
            gridViewThongKe.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitDotThanhToan();
            Cursor.Current = Cursors.Default;

        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            InitDotThanhToan();
            Cursor.Current = Cursors.Default;

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewThongKe.FocusedRowHandle = -1;
            DataTable tb = bindingSourceThongKe.DataSource as DataTable;
            if (tb != null && tb.Rows.Count > 0)
            {
                if (cboDotThanhToan.EditValue.ToString() != "-1")
                {
                    if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string xmlData = "";
                        int result = -1;
                        foreach (DataRow r in tb.Rows)
                        {
                            if (r.RowState == DataRowState.Modified)
                            {
                                xmlData += String.Format("<Input M=\"{0}\" T=\"{1}\" G=\"{2}\" D=\"{3}\" L=\"{4}\" />", r["IdGiangVien"], r["ThueTncn"], r["GhiChu"], cboDotThanhToan.EditValue.ToString(), r["MaLoaiGiangVien"]);
                            }
                        }

                        xmlData = "<Root>" + xmlData + "</Root>";

                        DataServices.KetQuaThanhToanThuLao.LuuThueTncn(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()), "(01) Thuế TNCN trên bảng thống kê thanh toán tiền giảng", ref result);

                        if (result == 0)
                            XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        btnLocDuLieu.PerformClick();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Chỉ được phép lưu thuế cho từng đợt thanh toán. Vui lòng chọn lại đợt thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboDotThanhToan.Focus();
                }
            }
        }

        private void gridViewThongKe_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "ThueTncn")
            {
                DataRowView r = gridViewThongKe.GetRow(e.RowHandle) as DataRowView;

                decimal b;
                decimal _thue = decimal.TryParse(r["ThueTncn"].ToString(), out b) ? b : 0;
                decimal _SoTienThanhToan = decimal.TryParse(r["SoTienThanhToan"].ToString(), out b) ? b : 0;
                decimal _TienViet = decimal.TryParse(r["TienViet"].ToString(), out b) ? b : 0;
                //decimal _TienPhoTo = decimal.TryParse(r["TienPhoTo"].ToString(), out b) ? b : 0;

                decimal SoTienConDuocNhan = _SoTienThanhToan + _TienViet - _thue;

                gridViewThongKe.SetRowCellValue(e.RowHandle, "SoTienConDuocNhan", SoTienConDuocNhan);

            }
        }
    }
}
