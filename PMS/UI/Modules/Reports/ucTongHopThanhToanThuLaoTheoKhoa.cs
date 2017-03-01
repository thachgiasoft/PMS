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
using PMS.BLL;
using PMS.UI.Forms.BaoCao;
using PMS.Services;

namespace PMS.UI.Modules.Reports
{
    public partial class ucTongHopThanhToanThuLaoTheoKhoa : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        string groupname = UserInfo.GroupName;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        int lanchot = 0;
        #endregion
        public ucTongHopThanhToanThuLaoTheoKhoa()
        {
            InitializeComponent();

            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

            switch (_maTruong)
            {
                case "HBU":
                    btnIn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnInMau2.Caption = "In";
                    break;
                default:
                    break;
            }

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

        #region
        private void initGridView()
        {
            switch (_maTruong)
            {
                case "HBU":
                    AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
                    AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "TenBoMon", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoLopDong", "HeSoBacDaoTao", "HeSoNgoaiGio", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoKhoiNganh", "TietQuyDoi", "DonGia", "TongTien", "ThueTncn", "ThucLanh" }
                            , new string[] { "Mã giảng viên", "Họ", "tên", "Bộ môn", "Học hàm", "Học vị", "Loại giảng viên", "Mã môn học", "Tên môn học", "Loại", "Nhóm", "Mã lớp", "Sĩ số", "Số tiết", "HS lớp đông", "HS bậc đào tạo", "HS ngoài giờ", "HS ngôn ngữ", "HS chức danh", "HS khối ngành", "Tiết quy đổi", "Đơn giá", "Tổng tiền", "Thuế TNCN", "Thực lãnh" }
                            , new int[] { 90, 100, 50, 150, 80, 80, 100, 80, 150, 60, 60, 80, 50, 70, 90, 80, 80, 80, 80, 80, 80, 100, 100, 100, 100 });
                    AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "TenBoMon", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoLopDong", "HeSoBacDaoTao", "HeSoNgoaiGio", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoKhoiNganh", "TietQuyDoi", "DonGia", "TongTien", "ThueTncn", "ThucLanh" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
                    AppGridView.ReadOnlyColumn(gridViewThongKe);
                    AppGridView.FormatDataField(gridViewThongKe, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewThongKe, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewThongKe, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewThongKe, "HeSoBacDaoTao", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewThongKe, "HeSoNgoaiGio", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewThongKe, "HeSoNgonNgu", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewThongKe, "HeSoChucDanhChuyenMon", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewThongKe, "HeSoKhoiNganh", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewThongKe, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewThongKe, "TongTien", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewThongKe, "ThueTncn", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewThongKe, "ThucLanh", DevExpress.Utils.FormatType.Custom, "n0");
                    break;
                case "VHU":
                    AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
                    AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoLopDong", "HeSoHocKy", "TietQuyDoi", "HeSoChucDanhChuyenMon", "DonGia", "ThanhTien" }
                            , new string[] { "Mã giảng viên", "Họ và tên", "Bộ môn", "Học hàm", "Học vị", "Loại giảng viên", "Mã môn học", "Tên môn học", "Loại", "Nhóm", "Mã lớp", "Sĩ số", "Số tiết", "Hệ số lớp đông", "Hệ số học kỳ", "Tiết quy đổi", "Hệ số chức danh", "Đơn giá", "Thành tiền" }
                            , new int[] { 90, 140, 120, 80, 80, 80, 80, 150, 60, 70, 80, 70, 70, 90, 90, 90, 90, 90, 90 });
                    AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoLopDong", "HeSoHocKy", "DonGia", "ThanhTien", "TietQuyDoi", "HeSoChucDanhChuyenMon" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
                    AppGridView.ReadOnlyColumn(gridViewThongKe);
                    AppGridView.FormatDataField(gridViewThongKe, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewThongKe, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewThongKe, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewThongKe, "HeSoHocKy", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewThongKe, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewThongKe, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
                    //gridViewThongKe.Columns["TenDonVi"].GroupIndex = 0;
                    break;
                default:
                    AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
                    AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoLopDong", "HeSoHocKy", "DonGia", "ThanhTien", "TietQuyDoi" }
                            , new string[] { "Mã giảng viên", "Họ và tên", "Bộ môn", "Học hàm", "Học vị", "Loại giảng viên", "Mã môn học", "Tên môn học", "Loại", "Nhóm", "Mã lớp", "Sĩ số", "Số tiết", "Hệ số lớp đông", "Hệ số học kỳ", "Đơn giá", "Thành tiền", "Tiết quy đổi" }
                            , new int[] { 90, 140, 120, 80, 80, 80, 80, 150, 60, 70, 80, 70, 70, 90, 90, 80, 90, 90 });
                    AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "MaMonHoc", "TenMonHoc", "Loai", "Nhom", "MaLop", "SiSo", "SoTiet", "HeSoLopDong", "HeSoHocKy", "DonGia", "ThanhTien", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
                    AppGridView.ReadOnlyColumn(gridViewThongKe);
                    AppGridView.FormatDataField(gridViewThongKe, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewThongKe, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewThongKe, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewThongKe, "HeSoHocKy", DevExpress.Utils.FormatType.Custom, "n2");
                    AppGridView.FormatDataField(gridViewThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewThongKe, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
                    AppGridView.FormatDataField(gridViewThongKe, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
                    //gridViewThongKe.Columns["TenDonVi"].GroupIndex = 0;
                    break;
            }
        }
        #endregion

        private void ucTongHopThanhToanThuLaoTheoKhoa_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            initGridView();
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

            #region _lanChot
            AppGridLookupEdit.InitGridLookUp(cboLanChot, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChot, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChot.Properties.ValueMember = "LanChot";
            cboLanChot.Properties.DisplayMember = "LanChot";
            cboLanChot.Properties.NullText = string.Empty;
            #endregion

            #region Khoa-DonVi
            InitKhoaDonVi();
            #endregion

            #region LoaiGiangVien
            InitLoaiGiangVien();
            #endregion

            InitData();
        }

        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if(cboNamHoc.EditValue!=null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null && cboLanChot.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.ViewKetQuaThanhToanThuLao.GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), cboLanChot.EditValue.ToString());
                dt.Load(reader);
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

        void InitKhoaDonVi()
        {
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = new VList<ViewKhoaBoMon>();
            _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            if (groupname != "Administrator")
            {
                if (_maTruong == "UTE")
                    _vListKhoaBoMon = _vListKhoaBoMon.FindAll(p => p.TenKhoa == groupname) as VList<ViewKhoaBoMon>;
                else
                    _vListKhoaBoMon = _vListKhoaBoMon.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoaBoMon>;
            }

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaBoMon, string.Format("{0} - {1}", v.MaBoMon, v.TenBoMon), CheckState.Unchecked, true));
            }
            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
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
                _listLoaiGV.Add(new CheckedListBoxItem(l.MaLoaiGiangVien, string.Format("{0}", l.TenLoaiGiangVien), CheckState.Unchecked, true));
            }
            cboLoaiGiangVien.Properties.Items.AddRange(_listLoaiGV.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
        }
        #endregion
        #region Event Button
        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboLanChot.EditValue == null)
                XtraMessageBox.Show("Vui lòng chọn lần chốt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            InitData();
            Cursor.Current = Cursors.WaitCursor;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            InitLoaiGiangVien();
            InitKhoaDonVi();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
                    frm.InTongHopThanhToanThuLaoTheoKhoa(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                        , cboLoaiGiangVien.Text, cboLanChot.EditValue.ToString(), PMS.Common.Globals._cauhinh.NguoiLapbieu
                        , PMS.Common.Globals._cauhinh.PhongDaoTao, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnInMau2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
                    switch(_maTruong)
                    {
                        case "HBU":
                            frm.InTongHopThanhToanThuLaoTheoKhoaMau2_HBU(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                                , cboLoaiGiangVien.Text, cboLanChot.EditValue.ToString(), PMS.Common.Globals._cauhinh.NguoiLapbieu
                                , PMS.Common.Globals._cauhinh.PhongDaoTao, vListBaoCao);
                        break;
                        default:
                            frm.InTongHopThanhToanThuLaoTheoKhoaMau2(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                                , cboLoaiGiangVien.Text, cboLanChot.EditValue.ToString(), PMS.Common.Globals._cauhinh.NguoiLapbieu
                                , PMS.Common.Globals._cauhinh.PhongDaoTao, vListBaoCao);
                        break;
                    
                    }
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            Cursor.Current = Cursors.WaitCursor;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            Cursor.Current = Cursors.WaitCursor;
        }
        #endregion

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
                        gridControlThongKe.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }
    }
}
