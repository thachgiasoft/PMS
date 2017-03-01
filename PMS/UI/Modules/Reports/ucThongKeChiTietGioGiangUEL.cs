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
    public partial class ucThongKeChiTietGioGiangUEL : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        string _maTruong;
        DateTime _ngayIn;
        bool userRole;
        string _groupName = UserInfo.GroupName;
        #endregion
        public ucThongKeChiTietGioGiangUEL()
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

        private void ucThongKeChiTietGioGiangUEL_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            switch (_maTruong)
            { 
                case "UEL":
                    InitGridUEL();
                    break;
                default:
                    InitGridRemaining();
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
          
            //VList<ViewKhoa> _vListKhoa = new VList<ViewKhoa>();
            //_vListKhoa = DataServices.ViewKhoa.GetAll();

            //List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            //foreach (ViewKhoa v in _vListKhoa)
            //{
            //    _list.Add(new CheckedListBoxItem(v.MaKhoa, v.TenKhoa, CheckState.Unchecked, true));
            //}
            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
            #endregion

            #region Init BacDaoTao
            cboBacDaoTao.Properties.SelectAllItemCaption = "Tất cả";
            cboBacDaoTao.Properties.TextEditStyle = TextEditStyles.Standard;
            cboBacDaoTao.Properties.Items.Clear();

            VList<ViewBacDaoTao> _listBacDaoTao = new VList<ViewBacDaoTao>();
            _listBacDaoTao = DataServices.ViewBacDaoTao.GetAll();

            List<CheckedListBoxItem> _listCbo = new List<CheckedListBoxItem>();
            foreach (ViewBacDaoTao v in _listBacDaoTao)
            {
                _listCbo.Add(new CheckedListBoxItem(v.MaBacDaoTao.ToString(), v.TenBacDaoTao, CheckState.Unchecked, true));
            }

            cboBacDaoTao.Properties.Items.AddRange(_listCbo.ToArray());
            cboBacDaoTao.Properties.SeparatorChar = ';';
            cboBacDaoTao.CheckAll();
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

        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable dt = new DataTable();
                //IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeTheoNamHocHocKyDonViLoaiGiangVienLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeTheoNamHocHocKyBacDaoTaoDonViLoaiGiangVienLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboBacDaoTao.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
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

        void InitGridUEL()
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "ChucDanh", "TenDonVi", "MaMonHoc", "TenMonHoc", "MaBacDaoTao", "MaLopHocPhan", "MaLop", "TietThucDay", "SiSo", "HeSoClcCntn", "HeSoChucDanhChuyenMon", "HeSoCoSo", "HeSoLopDong", "HeSoThinhGiangMonChuyenNganh", "TongHeSo", "DonGia", "DonGiaQuyDoi", "ThanhTien", "ThuLaoVuotGio", "SoTaiKhoan", "TenNganHang", "MaSoThue", "Cmnd", "TenLoaiGiangVien", "GhiChu" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Chức danh", "Tên khoa - Bộ môn", "Mã môn học", "Tên môn học", "Bậc đào tạo", "Mã lớp học phần", "Mã lớp", "Tiết thực dạy", "Sĩ số", "CNTN - CLC", "HS Chức danh", "HS Địa điểm", "HS Lớp đông", "HS thỉnh giảng môn chuyên ngành", "Tổng hệ số", "Đơn giá", "Đơn giá quy đổi", "Thành tiền", "Thù lao vượt giờ", "Số tài khoản", "Ngân hàng", "Mã số thuế", "CMND", "Loại giảng viên", "Ghi chú" }
                    , new int[] { 85, 110, 45, 110, 120, 80, 150, 110, 80, 100, 80, 70, 80, 80, 80, 80, 100, 100, 100, 80, 100, 110, 100, 150, 90, 80, 99, 100 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "ChucDanh", "TenDonVi", "MaMonHoc", "TenMonHoc", "MaBacDaoTao", "MaLopHocPhan", "MaLop", "TietThucDay", "SiSo", "HeSoClcCntn", "HeSoChucDanhChuyenMon", "HeSoCoSo", "HeSoLopDong", "HeSoThinhGiangMonChuyenNganh", "TongHeSo", "DonGia", "DonGiaQuyDoi", "ThanhTien", "ThuLaoVuotGio", "SoTaiKhoan", "TenNganHang", "MaSoThue", "Cmnd", "TenLoaiGiangVien", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "DonGiaQuyDoi", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThuLaoVuotGio", DevExpress.Utils.FormatType.Custom, "n0");
            gridViewThongKe.Columns["TenLoaiGiangVien"].GroupIndex = 0;
        }

        void InitGridRemaining()
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "ChucDanh", "TenDonVi", "MaMonHoc", "TenMonHoc", "MaBacDaoTao", "MaLopHocPhan", "MaLop", "TietThucDay", "SiSo", "HeSoClcCntn", "HeSoChucDanhChuyenMon", "HeSoCoSo", "HeSoLopDong", "HeSoThinhGiangMonChuyenNganh", "TongHeSo", "TietQuyDoi", "DonGia", "ThanhTien", "ThuLaoVuotGio", "TamTruThue", "ThucChuyen", "SoTaiKhoan", "TenNganHang", "MaSoThue", "Cmnd", "TenLoaiGiangVien", "TienViet", "TienPhoto" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Chức danh", "Tên khoa - Bộ môn", "Mã môn học", "Tên môn học", "Bậc đào tạo", "Mã lớp học phần", "Mã lớp", "Tiết thực dạy", "Sĩ số", "CNTN - CLC", "HS Chức danh", "HS Địa điểm", "HS Lớp đông", "HS thỉnh giảng môn chuyên ngành", "Tổng hệ số", "Tiết quy đổi", "Đơn giá", "Thành tiền", "Thù lao vượt giờ", "Tạm trừ thuế", "Thực chuyển", "Số tài khoản", "Ngân hàng", "Mã số thuế", "CMND", "Loại giảng viên", "Tiền viết", "Tiền photo" }
                    , new int[] { 85, 110, 45, 110, 120, 80, 150, 110, 80, 100, 80, 70, 80, 80, 80, 80, 100, 100, 100, 80, 100, 110, 90, 100, 100, 150, 90, 80, 99, 90, 90 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "ChucDanh", "TenDonVi", "MaMonHoc", "TenMonHoc", "MaBacDaoTao", "MaLopHocPhan", "MaLop", "TietThucDay", "SiSo", "HeSoClcCntn", "HeSoChucDanhChuyenMon", "HeSoCoSo", "HeSoLopDong", "HeSoThinhGiangMonChuyenNganh", "TongHeSo", "TietQuyDoi", "DonGia", "ThanhTien", "ThuLaoVuotGio", "TamTruThue", "ThucChuyen", "SoTaiKhoan", "TenNganHang", "MaSoThue", "Cmnd", "TenLoaiGiangVien", "TienViet", "TienPhoto" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThuLaoVuotGio", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TamTruThue", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThucChuyen", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienViet", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienPhoto", DevExpress.Utils.FormatType.Custom, "n0");
            gridViewThongKe.Columns["TenLoaiGiangVien"].GroupIndex = 0;
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
                    if (_maTruong == "UEL")
                    {
                        frm.InThongKeChiTietGioGiangCoHuuUEL(_maTruong, PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                            , cboBacDaoTao.EditValue.ToString()
                            , UserInfo.FullName, PMS.Common.Globals._cauhinh.PhongDaoTao, _ngayIn, cboLoaiGiangVien.Text
                            , vListBaoCao);
                        frm.ShowDialog();
                    }
                    else
                    {
                        frm.InThongKeChiTietGioGiangCoHuuBUH(_maTruong, PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                            , cboBacDaoTao.EditValue.ToString()
                            , UserInfo.FullName, PMS.Common.Globals._cauhinh.PhongDaoTao, _ngayIn, cboLoaiGiangVien.Text
                            , vListBaoCao);
                        frm.ShowDialog();
                    }
                }
            }
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
                //IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeTheoNamHocHocKyDonViLoaiGiangVienLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeTheoNamHocHocKyBacDaoTaoDonViLoaiGiangVienLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboBacDaoTao.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                dt.Load(reader);
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
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            Cursor.Current = Cursors.Default;
        }

    }
}
