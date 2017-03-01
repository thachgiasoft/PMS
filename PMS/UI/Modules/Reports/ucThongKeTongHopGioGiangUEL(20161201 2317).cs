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
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.BLL;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeTongHopGioGiangUEL : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        string _maTruong;
        DateTime _ngayIn;

        string _groupName = UserInfo.GroupName;
        bool _userRole;
        #endregion
        public ucThongKeTongHopGioGiangUEL()
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

        private void ucThongKeTongHopGioGiangUEL_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            switch (_maTruong)
            {
                case "BUH":
                    InitGridBUH();
                    break;
                case "UEL":
                    InitGridUEL();
                    break;
                default:
                    InitRemaining();
                    break;
            }
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
                    _userRole = true;
                    break;
                }
                else
                {
                    _userRole = false;
                }
            }


            if (_userRole)
            {
                _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);
            }
          
            //VList<ViewKhoa> _vListKhoa = new VList<ViewKhoa>();
            //_vListKhoa = DataServices.ViewKhoa.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaBoMon, v.TenBoMon, CheckState.Unchecked, true));
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

            if (_maTruong == "UEL")
                _listLGV.Add(new CheckedListBoxItem("-1", "Trung tâm lý luận chính trị", CheckState.Unchecked, true));

            cboLoaiGiangVien.Properties.Items.AddRange(_listLGV.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
            #endregion
            InitData();
        }
        #region InitGrid
        void InitGridBUH()
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "TenDonVi", "TongTien", "TietChuanGiangDay", "SoTietNghiaVu", "TietNghiaVuDuocGiam", "SoTietDinhMucNCKH", "SoTietThucHienNCKH", "SoTietNckhNamTruocChuyenSang", "NoHocKyTruoc", "SoTietVuotGio", "TienTietChuan", "TienNoGioChuan", "ThuLaoVuotGio", "ThueTamTru", "ThucChuyen", "SoTaiKhoan", "TenNganHang", "TenLoaiGiangVien", "TienViet", "TienPhoto" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Tên khoa - Bộ môn", "Tổng tiền giảng", "Tiết chuẩn giảng dạy", "Tiết chuẩn HK này", "Tiết chuẩn được giảm", "Số tiết định mức NCKH", "Số tiết thực hiện NCKH", "Số tiết NCKH năm trước chuyển sang", "Tiết nợ kỳ trước", "Số tiết vượt giờ", "Tiền tiết chuẩn", "Tiền nợ giờ chuẩn", "Thù lao vượt giờ", "Thuế tạm trừ", "Thực chuyển", "Số tài khoản", "Ngân hàng", "Loại giảng viên", "Tiền viết", "Tiền photo" }
                    , new int[] { 85, 110, 45, 120, 100, 80, 100, 100, 100, 100, 100, 110, 80, 100, 100, 110, 90, 100, 100, 150, 99, 90, 90 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "TenDonVi", "TongTien", "TietChuanGiangDay", "SoTietNghiaVu", "TietNghiaVuDuocGiam", "SoTietDinhMucNCKH", "SoTietThucHienNCKH", "SoTietNckhNamTruocChuyenSang", "NoHocKyTruoc", "SoTietVuotGio", "TienTietChuan", "TienNoGioChuan", "ThuLaoVuotGio", "ThueTamTru", "ThucChuyen", "SoTaiKhoan", "TenNganHang", "TenLoaiGiangVien", "TienViet", "TienPhoto" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, "TongTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienTietChuan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThuLaoVuotGio", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThueTamTru", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThucChuyen", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienViet", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienPhoto", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TietChuanGiangDay", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "SoTietVuotGio", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "TienNoGioChuan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewThongKe, new string[] { "SoTietDinhMucNCKH" });

            gridViewThongKe.Columns["TenLoaiGiangVien"].GroupIndex = 0;

            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 50);
        }

        void InitGridUEL()
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "TenDonVi", "TongTien", "TietChuanGiangDay", "SoTietNghiaVu", "NoHocKyTruoc", "SoTietVuotGio", "TienTietChuan", "TienNoGioChuan", "ThuLaoVuotGio", "ThueTamTru", "ThucChuyen", "SoTaiKhoan", "TenNganHang", "TenLoaiGiangVien" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Tên khoa - Bộ môn", "Tổng tiền giảng", "Tiết chuẩn giảng dạy", "Tiết chuẩn HK này", "Tiết nợ kỳ trước", "Số tiết vượt giờ", "Tiền tiết chuẩn", "Tiền nợ giờ chuẩn", "Thù lao vượt giờ", "Thuế tạm trừ", "Thực chuyển", "Số tài khoản", "Ngân hàng", "Loại giảng viên" }
                    , new int[] { 85, 110, 45, 120, 100, 80, 100, 110, 80, 100, 100, 110, 90, 100, 100, 150, 99 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "TenDonVi", "TongTien", "TietChuanGiangDay", "SoTietNghiaVu", "NoHocKyTruoc", "SoTietVuotGio", "TienTietChuan", "TienNoGioChuan", "ThuLaoVuotGio", "ThueTamTru", "ThucChuyen", "SoTaiKhoan", "TenNganHang", "TenLoaiGiangVien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, "TongTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienTietChuan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThuLaoVuotGio", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThueTamTru", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThucChuyen", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TietChuanGiangDay", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "SoTietVuotGio", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "TienNoGioChuan", DevExpress.Utils.FormatType.Custom, "n0");

            gridViewThongKe.Columns["TenLoaiGiangVien"].GroupIndex = 0;

            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 50);
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "TenDonVi", "TongTien", "TietChuanGiangDay", "SoTietNghiaVu", "SoTietDinhMucNCKH", "SoTietThucHienNCKH", "SoTietNckhNamTruocChuyenSang", "NoHocKyTruoc", "SoTietVuotGio", "TienTietChuan", "TienNoGioChuan", "ThuLaoVuotGio", "ThueTamTru", "ThucChuyen", "SoTaiKhoan", "TenNganHang", "TenLoaiGiangVien", "TienViet", "TienPhoto" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Tên khoa - Bộ môn", "Tổng tiền giảng", "Tiết chuẩn giảng dạy", "Tiết chuẩn HK này", "Số tiết định mức NCKH", "Số tiết thực hiện NCKH", "Số tiết NCKH năm trước chuyển sang", "Tiết nợ kỳ trước", "Số tiết vượt giờ", "Tiền tiết chuẩn", "Tiền nợ giờ chuẩn", "Thù lao vượt giờ", "Thuế tạm trừ", "Thực chuyển", "Số tài khoản", "Ngân hàng", "Loại giảng viên", "Tiền viết", "Tiền photo" }
                    , new int[] { 85, 110, 45, 120, 100, 80, 100, 100, 100, 100, 110, 80, 100, 100, 110, 90, 100, 100, 150, 99, 90, 90 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "TenDonVi", "TongTien", "TietChuanGiangDay", "SoTietNghiaVu", "SoTietDinhMucNCKH", "SoTietThucHienNCKH", "SoTietNckhNamTruocChuyenSang", "NoHocKyTruoc", "SoTietVuotGio", "TienTietChuan", "TienNoGioChuan", "ThuLaoVuotGio", "ThueTamTru", "ThucChuyen", "SoTaiKhoan", "TenNganHang", "TenLoaiGiangVien", "TienViet", "TienPhoto" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, "TongTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienTietChuan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThuLaoVuotGio", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThueTamTru", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThucChuyen", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienViet", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienPhoto", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TietChuanGiangDay", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "SoTietVuotGio", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "TienNoGioChuan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewThongKe, new string[] { "SoTietDinhMucNCKH" });

            gridViewThongKe.Columns["TenLoaiGiangVien"].GroupIndex = 0;

            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 50);
        }
        #endregion
        #region InitData()
        void InitData()
        {
            try
            {
                bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                InitLanChot();
                if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null)
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeTongHopTheoNamHocHocKyDonViLoaiGiangVienLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                        dt.Load(reader);
                        bindingSourceThongKe.DataSource = dt;

                        IDataReader r2 = DataServices.KetQuaThanhToanThuLao.GetNgayChiTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                        DataTable tblNgayChiTra = new DataTable();
                        tblNgayChiTra.Load(r2);
                        dateEditNgayChiTra.Text = tblNgayChiTra.Rows[0]["NgayChiTra"].ToString();
                    }
                    catch 
                    { }
                }
                gridViewThongKe.ExpandAllGroups();
            }
            catch { }
        }

        void InitLanChot()
        {
            try
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
                    else
                    {
                        XtraMessageBox.Show("Chốt khối lượng giảng dạy để thống kê.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    bindingSourceLanChot.DataSource = tblLanChot;
                    cboLanChot.DataBindings.Add("EditValue", bindingSourceLanChot, "LanChot", true, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
            catch
            {

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
            if (vListBaoCao == null)
                return;
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

            string filter = gridViewThongKe.ActiveFilterString;
            //if (_maTruong == "UEL")
            //{
            //    if (filter != "")//Không in ra những người có thực chuyển <= 0
            //        filter += " and ThucChuyen > 0";
            //    else filter = "ThucChuyen > 0";
            //}

            if (filter.Contains(".0000m"))
                filter = filter.Replace(".0000m", "");
            if (filter.Contains(".000m"))
                filter = filter.Replace(".000m", "");
            if (filter.Contains(".00m"))
                filter = filter.Replace(".00m", "");
            if (filter.Contains(".0m"))
                filter = filter.Replace(".0m", "");
            if (filter.Contains(".m"))
                filter = filter.Replace(".m", "");

            DataView dv = new DataView(vListBaoCao, filter, sort, DataViewRowState.CurrentRows);
            vListBaoCao = dv.ToTable();
            if (vListBaoCao == null)
                return;

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    if (_maTruong == "BUH")
                    {
                        if (cboLoaiGiangVien.EditValue.ToString() == "1")
                        {
                            frm.InThongKeTongHopGioGiangCoHuuBUH(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                                , UserInfo.FullName, PMS.Common.Globals._cauhinh.KeToan, PMS.Common.Globals._cauhinh.BanGiamHieu
                                , _ngayIn, vListBaoCao);
                            frm.ShowDialog();
                        }
                        else
                        {
                            frm.InThongKeTongHopGioGiangThinhGiangBUH(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                                , UserInfo.FullName, PMS.Common.Globals._cauhinh.KeToan, PMS.Common.Globals._cauhinh.BanGiamHieu
                                , _ngayIn, cboLoaiGiangVien.Text, vListBaoCao);
                            frm.ShowDialog();
                        }
                    }
                    else//UEL
                    {
                        if (cboLoaiGiangVien.EditValue.ToString() == "1" || cboLoaiGiangVien.EditValue.ToString() == "4" || cboLoaiGiangVien.EditValue.ToString() == "1; 4" || cboLoaiGiangVien.EditValue.ToString() == "4; 1")//Cơ hữu hoặc hợp đồng
                        {
                            frm.InThongKeTongHopGioGiangUEL(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiGiangVien.Text
                                , UserInfo.FullName, PMS.Common.Globals._cauhinh.KeToan, PMS.Common.Globals._cauhinh.BanGiamHieu
                                , _ngayIn, vListBaoCao);
                            frm.ShowDialog();
                        }
                        else
                        {
                            frm.InThongKeTongHopGioGiangThinhGiangUEL(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                                , UserInfo.FullName, PMS.Common.Globals._cauhinh.KeToan, PMS.Common.Globals._cauhinh.BanGiamHieu
                                , _ngayIn, cboLoaiGiangVien.Text, vListBaoCao);
                            frm.ShowDialog();
                        }
                    }
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
                try
                {
                    DataTable dt = new DataTable();
                    IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeTongHopTheoNamHocHocKyDonViLoaiGiangVienLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                    dt.Load(reader);
                    bindingSourceThongKe.DataSource = dt;

                    IDataReader r2 = DataServices.KetQuaThanhToanThuLao.GetNgayChiTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                    DataTable tblNgayChiTra = new DataTable();
                    tblNgayChiTra.Load(r2);
                    dateEditNgayChiTra.Text = tblNgayChiTra.Rows[0]["NgayChiTra"].ToString();
                }
                catch
                { }
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
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuuNgayChiTra_Click(object sender, EventArgs e)
        {
            try
            {
                if (((DataTable)bindingSourceThongKe.DataSource).Rows.Count > 0)
                {
                    if (XtraMessageBox.Show("Lưu ngày chi trả?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int kq = 0;
                        DataServices.KetQuaThanhToanThuLao.LuuNgayChiTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()), dateEditNgayChiTra.Text, ref kq);
                        if (kq == 0)
                        {
                            XtraMessageBox.Show("Lưu ngày chi trả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Lưu ngày chi trả thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng lọc dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                XtraMessageBox.Show("Lưu ngày chi trả thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
