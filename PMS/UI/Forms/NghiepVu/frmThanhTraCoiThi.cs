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
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using DevExpress.XtraGrid.Views.Base;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThanhTraCoiThi : DevExpress.XtraEditors.XtraForm
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
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        string _groupUser = UserInfo.GroupName;
        DateTime _ngayIn;
        #endregion

        #region Event form
        public frmThanhTraCoiThi()
        {
            InitializeComponent();
            TList<CauHinh> cauHinh = DataServices.CauHinh.GetAll();
            if (cauHinh != null)
            {
                foreach (CauHinh ch in cauHinh)
                {
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
                }
            }
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

            if (_maTruong == "IUH")
            {
                btnIn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLamTuoi.Caption = "Cập nhật mới";
            }
            else btnIn_IUH.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            
        }

        private void frmThanhTraCoiThi_Load(object sender, EventArgs e)
        {
            #region Init GridView
            switch (_maTruong)
            {
                case "IUH":
                    InitGridIUH();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion

            #region InitRepository ViPham
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDanhMucViPham, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditDanhMucViPham, 400, 650);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDanhMucViPham, new string[] { "MaViPham", "NoiDungViPham", "CoXepLoai" }, new string[] { "Mã vi phạm", "Nội dung vi phạm", "Có xếp loại" }, new int[] { 70, 260, 70 });
            repositoryItemGridLookUpEditDanhMucViPham.DisplayMember = "NoiDungViPham";
            repositoryItemGridLookUpEditDanhMucViPham.ValueMember = "MaViPham";
            repositoryItemGridLookUpEditDanhMucViPham.NullText = string.Empty;
            #endregion
            #region InitRepository HinhThucViPhamHRM
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHinhThucViPhamHRM, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditHinhThucViPhamHRM, 380, 650);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHinhThucViPhamHRM, new string[] { "MaQuanLy", "TenHinhThucViPham" }, new string[] { "Mã vi phạm", "Nội dung vi phạm" }, new int[] { 80, 300 });
            repositoryItemGridLookUpEditHinhThucViPhamHRM.DisplayMember = "TenHinhThucViPham";
            repositoryItemGridLookUpEditHinhThucViPhamHRM.ValueMember = "Oid";
            repositoryItemGridLookUpEditHinhThucViPhamHRM.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion

        #region InitGrid
        void InitGridIUH()
        {
            AppGridView.InitGridView(gridViewThanhTraCoiThi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThanhTraCoiThi, new string[] { "NgayThi", "MaPhong", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "MaLopSinhVien", "SoLuongSinhVien", "TenKhoaChuQuan", "MaCanBoCoiThi", "HoTen", "TietBatDau", "ThoiGianBatDau", "ThoiGianLamBai", "SiSoThanhTra", "MaViPham", "MaHinhThucViPhamHrm", "ThoiDiemGhiNhan", "LyDo", "GhiChu", "NgayCapNhat", "NguoiCapNhat", "TrangThai", "XacNhan" }
                    , new string[] { "Ngày", "Phòng thi", "Mã học phần", "Tên học phần", "Mã lớp học phần", "Mã lớp", "Số thí sinh", "Khoa", "Mã CBCT", "Họ tên", "Tiết bắt đầu", "TG bắt đầu", "TG làm bài", "Thanh tra sĩ số", "Nội dung vi phạm", "Hình thức vi phạm đánh giá ABC", "Thời điểm ghi nhận", "Lý do", "Ghi chú", "NgayCapNhat", "NguoiCapNhat", "trạng thái", "Xác nhận" }
                    , new int[] { 70, 80, 80, 150, 110, 90, 70, 140, 80, 160, 70, 70, 70, 100, 120, 170, 100, 150, 150, 99, 99, 99, 80 });
            AppGridView.AlignHeader(gridViewThanhTraCoiThi, new string[] { "NgayThi", "MaPhong", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "MaLopSinhVien", "SoLuongSinhVien", "TenKhoaChuQuan", "MaCanBoCoiThi", "HoTen", "TietBatDau", "ThoiGianBatDau", "ThoiGianLamBai", "SiSoThanhTra", "MaViPham", "MaHinhThucViPhamHrm", "ThoiDiemGhiNhan", "LyDo", "GhiChu", "NgayCapNhat", "NguoiCapNhat", "TrangThai", "XacNhan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThanhTraCoiThi, "NgayThi", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.HideField(gridViewThanhTraCoiThi, new string[] { "NgayCapNhat", "NguoiCapNhat", "SiSoThanhTra", "MaHinhThucViPhamHrm", "TrangThai" });
            AppGridView.FormatDataField(gridViewThanhTraCoiThi, "SiSoThanhTra", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewThanhTraCoiThi, "MaViPham", repositoryItemGridLookUpEditDanhMucViPham);
            AppGridView.RegisterControlField(gridViewThanhTraCoiThi, "MaHinhThucViPhamHrm", repositoryItemGridLookUpEditHinhThucViPhamHRM);
            AppGridView.ReadOnlyColumn(gridViewThanhTraCoiThi, new string[] { "NgayThi", "MaPhong", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "MaLopSinhVien", "SoLuongSinhVien", "TenKhoaChuQuan", "MaCanBoCoiThi", "HoTen", "TietBatDau", "ThoiGianBatDau", "ThoiGianLamBai" });
            AppGridView.FixedField(gridViewThanhTraCoiThi, new string[] { "NgayThi", "MaPhong", "MaMonHoc", "TenMonHoc" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            AppGridView.RegisterControlField(gridViewThanhTraCoiThi, "NgayThi", repositoryItemDateEditNgay);
        }

        void InitRemaining()//UEL
        {
            AppGridView.InitGridView(gridViewThanhTraCoiThi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThanhTraCoiThi, new string[] { "NgayThi", "MaPhong", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "MaLopSinhVien", "SoLuongSinhVien", "TenKhoaChuQuan", "MaCanBoCoiThi", "HoTen", "TietBatDau", "ThoiGianBatDau", "ThoiGianLamBai", "SiSoThanhTra", "MaViPham", "MaHinhThucViPhamHrm", "ThoiDiemGhiNhan", "LyDo", "GhiChu", "NgayCapNhat", "NguoiCapNhat", "TrangThai", "XacNhan" }
                    , new string[] { "Ngày", "Phòng thi", "Mã học phần", "Tên học phần", "Mã lớp học phần", "Mã lớp", "Số thí sinh", "Khoa", "Mã CBCT", "Họ tên", "Tiết bắt đầu", "TG bắt đầu", "TG làm bài", "Thanh tra sĩ số", "Nội dung vi phạm", "Hình thức vi phạm đánh giá ABC", "Thời điểm ghi nhận", "Lý do", "Ghi chú", "NgayCapNhat", "NguoiCapNhat", "TrangThai", "Xác nhận" }
                    , new int[] { 70, 80, 80, 150, 110, 90, 70, 140, 80, 160, 70, 70, 70, 100, 120, 170, 100, 150, 150, 99, 99, 99, 99 });
            AppGridView.AlignHeader(gridViewThanhTraCoiThi, new string[] { "NgayThi", "MaPhong", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "MaLopSinhVien", "SoLuongSinhVien", "TenKhoaChuQuan", "MaCanBoCoiThi", "HoTen", "TietBatDau", "ThoiGianBatDau", "ThoiGianLamBai", "SiSoThanhTra", "MaViPham", "MaHinhThucViPhamHrm", "ThoiDiemGhiNhan", "LyDo", "GhiChu", "NgayCapNhat", "NguoiCapNhat", "TrangThai", "XacNhan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThanhTraCoiThi, "NgayThi", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.HideField(gridViewThanhTraCoiThi, new string[] { "NgayCapNhat", "NguoiCapNhat", "SiSoThanhTra", "TrangThai", "XacNhan" });
            AppGridView.FormatDataField(gridViewThanhTraCoiThi, "SiSoThanhTra", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewThanhTraCoiThi, "MaViPham", repositoryItemGridLookUpEditDanhMucViPham);
            AppGridView.RegisterControlField(gridViewThanhTraCoiThi, "MaHinhThucViPhamHrm", repositoryItemGridLookUpEditHinhThucViPhamHRM);
            AppGridView.ReadOnlyColumn(gridViewThanhTraCoiThi, new string[] { "NgayThi", "MaPhong", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "MaLopSinhVien", "SoLuongSinhVien", "TenKhoaChuQuan", "MaCanBoCoiThi", "HoTen", "TietBatDau", "ThoiGianBatDau", "ThoiGianLamBai" });
            AppGridView.FixedField(gridViewThanhTraCoiThi, new string[] { "NgayThi", "MaPhong", "MaMonHoc", "TenMonHoc" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            AppGridView.RegisterControlField(gridViewThanhTraCoiThi, "NgayThi", repositoryItemDateEditNgay);
            if (_maTruong != "UEL")
                AppGridView.HideField(gridViewThanhTraCoiThi, new string[] { "MaHinhThucViPhamHrm" });
        }
        #endregion

        #region InitData
        void InitData()
        {
            dateEditTuNgay.DateTime = DateTime.Now;
            dateEditDenNgay.DateTime = DateTime.Now;

            InitCoSo();

            InitDayNha();

            bindingSourceDanhMucViPham.DataSource = DataServices.DanhMucViPham.GetAll();
            bindingSourceHinhThucViPhamHRM.DataSource = DataServices.ViewHinhThucViPham.GetAll();
        }

        void InitCoSo()
        {
            #region Init Co So
            cboCoSo.Properties.SelectAllItemCaption = "Tất cả";
            cboCoSo.Properties.TextEditStyle = TextEditStyles.Standard;
            cboCoSo.Properties.Items.Clear();

            VList<ViewCoSo> _vListKhoaBoMon = new VList<ViewCoSo>();
            _vListKhoaBoMon = DataServices.ViewCoSo.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewCoSo v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaCoSo, v.TenCoSo, CheckState.Unchecked, true));
            }
            cboCoSo.Properties.Items.AddRange(_list.ToArray());
            cboCoSo.Properties.SeparatorChar = ';';
            cboCoSo.CheckAll();
            #endregion
        }


        void InitDayNha()
        {
            #region Init Day Nha
            if (cboCoSo.EditValue != null)
            {
                cboDayNha.Properties.SelectAllItemCaption = "Tất cả";
                cboDayNha.Properties.TextEditStyle = TextEditStyles.Standard;
                cboDayNha.Properties.Items.Clear();

                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ViewCoSo.GetDayNhaByCoSo(cboCoSo.EditValue.ToString());
                tb.Load(reader);
                List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
                foreach (DataRow v in tb.Rows)
                {
                    _list.Add(new CheckedListBoxItem(v["MaDayNha"].ToString(), v["TenDayNha"].ToString(), CheckState.Unchecked, true));
                }
                cboDayNha.Properties.Items.AddRange(_list.ToArray());
                cboDayNha.Properties.SeparatorChar = ';';
                cboDayNha.CheckAll();
            }
            #endregion
        }
        #endregion

        #region Event button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridViewThanhTraCoiThi.RowCount > 0)
                    if (gridViewThanhTraCoiThi.GetSelectedRows().Length > 0)
                    {
                        foreach (int i in gridViewThanhTraCoiThi.GetSelectedRows())
                        {
                            gridViewThanhTraCoiThi.SetRowCellValue(i, "SiSoThanhTra", "");
                            gridViewThanhTraCoiThi.SetRowCellValue(i, "MaViPham", "");
                            gridViewThanhTraCoiThi.SetRowCellValue(i, "MaHinhThucViPhamHrm", null);
                            gridViewThanhTraCoiThi.SetRowCellValue(i, "ThoiDiemGhiNhan", "");
                            gridViewThanhTraCoiThi.SetRowCellValue(i, "LyDo", "");
                            gridViewThanhTraCoiThi.SetRowCellValue(i, "GhiChu", "");
                        }
                    }
            }
            catch
            { }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewThanhTraCoiThi.FocusedRowHandle = -1;
            VList<ViewThanhTraCoiThi> list = bindingSourceThanhTraCoiThi.DataSource as VList<ViewThanhTraCoiThi>;
            if (list.Count > 0)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        string xmlData = "";
                        foreach (ViewThanhTraCoiThi v in list)
                        {
                            //if (v.MaViPham != null || v.ThoiDiemGhiNhan != null || v.LyDo != null || v.GhiChu != null || v.NgayCapNhat != null || v.NguoiCapNhat != null || v.MaHinhThucViPhamHrm != null || v.SiSoThanhTra != null)
                            if((bool)v.TrangThai)
                            {
                                xmlData += "<Input EX=\"" + v.Examination
                                            + "\" M=\"" + v.MaCanBoCoiThi
                                            + "\" N=\"" + v.NgayThi
                                            + "\" T=\"" + v.ThoiGianBatDau
                                            + "\" P=\"" + v.MaPhong
                                            + "\" LHP=\"" + v.MaLopHocPhan
                                            + "\" MH=\"" + v.MaMonHoc
                                            + "\" TM=\"" + v.TenMonHoc
                                            + "\" TL=\"" + v.ThoiGianLamBai
                                            + "\" TB=\"" + v.TietBatDau
                                            + "\" ML=\"" + v.MaLopSinhVien
                                            + "\" SL=\"" + v.SoLuongSinhVien
                                            + "\" MV=\"" + v.MaViPham
                                            + "\" HRM=\"" + v.MaHinhThucViPhamHrm
                                            + "\" SS=\"" + PMS.Common.Globals.IsNull(v.SiSoThanhTra, "int").ToString()
                                            + "\" TD=\"" + v.ThoiDiemGhiNhan
                                            + "\" LD=\"" + v.LyDo
                                            + "\" GC=\"" + v.GhiChu
                                            + "\" D=\"" + v.NgayCapNhat
                                            + "\" U=\"" + v.NguoiCapNhat
                                            + "\" ST=\"" + v.SoTiet
                                            + "\" MLHP=\"" + v.MaLoaiHocPhan
                                            + "\" />";
                            }
                        }
                        xmlData = String.Format("<Root>{0}</Root>", xmlData);
                        int kq = 0;
                        DataServices.ThanhTraCoiThi.Luu(xmlData, ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi. Kiểm tra lại dữ liệu vừa nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        btnLocDuLieu.PerformClick();
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi. Kiểm tra lại dữ liệu vừa nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog file = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (file.FileName != "")
                    {
                        gridControlThanhTraCoiThi.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThanhTraCoiThi.FocusedRowHandle = -1;
            bindingSourceThanhTraCoiThi.EndEdit();
            VList<ViewThanhTraCoiThi> list = bindingSourceThanhTraCoiThi.DataSource as VList<ViewThanhTraCoiThi>;
            DataTable data = list.ToDataSet(false).Tables[0];

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThanhTraCoiThi, bindingSourceThanhTraCoiThi);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThanhTraCoiThi.SortedColumns)
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

            //string filter = gridViewThanhTraCoiThi.ActiveFilterString;
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
                    frm.InThanhTraCoiThiTheoNgay(PMS.Common.Globals._cauhinh.TenTruong, dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), UserInfo.FullName, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (dateEditTuNgay.EditValue != null && dateEditDenNgay.EditValue != null && cboDayNha.EditValue != null)
            {
                bindingSourceThanhTraCoiThi.DataSource = DataServices.ViewThanhTraCoiThi.GetByNgayCoSoToaNha(dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), cboDayNha.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_IUH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();

                if (frmChon.NgayIn.ToString("dd/MM/yyyy") == "01/01/0001")
                    return;
                _ngayIn = frmChon.NgayIn;

            }

            Cursor.Current = Cursors.WaitCursor;
            gridViewThanhTraCoiThi.FocusedRowHandle = -1;
            bindingSourceThanhTraCoiThi.EndEdit();
            VList<ViewThanhTraCoiThi> list = bindingSourceThanhTraCoiThi.DataSource as VList<ViewThanhTraCoiThi>;
            DataTable data = list.ToDataSet(false).Tables[0];

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThanhTraCoiThi, bindingSourceThanhTraCoiThi);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThanhTraCoiThi.SortedColumns)
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

            //string filter = gridViewThanhTraCoiThi.ActiveFilterString;
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
                    frm.InKiemTraGioCoiThi(PMS.Common.Globals._cauhinh.TenTruong, dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), cboDayNha.Text, _ngayIn, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event grid
        private void gridViewThanhTraCoiThi_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "SiSoThanhTra" || col.FieldName == "MaViPham" || col.FieldName == "ThoiDiemGhiNhan" || col.FieldName == "LyDo" || col.FieldName == "GhiChu" || col.FieldName == "MaHinhThucViPhamHrm" || col.FieldName == "XacNhan")
            {
                gridViewThanhTraCoiThi.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewThanhTraCoiThi.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
                gridViewThanhTraCoiThi.SetRowCellValue(e.RowHandle, "TrangThai", "True");
            }
        }

        private void gridViewThanhTraCoiThi_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                    if (gridViewThanhTraCoiThi.RowCount > 0)
                        if (gridViewThanhTraCoiThi.GetSelectedRows().Length > 0)
                        {
                            foreach (int i in gridViewThanhTraCoiThi.GetSelectedRows())
                            {
                                gridViewThanhTraCoiThi.SetRowCellValue(i, "SiSoThanhTra", "");
                                gridViewThanhTraCoiThi.SetRowCellValue(i, "MaViPham", "");
                                gridViewThanhTraCoiThi.SetRowCellValue(i, "MaHinhThucViPhamHrm", null);
                                gridViewThanhTraCoiThi.SetRowCellValue(i, "ThoiDiemGhiNhan", "");
                                gridViewThanhTraCoiThi.SetRowCellValue(i, "LyDo", "");
                                gridViewThanhTraCoiThi.SetRowCellValue(i, "GhiChu", "");
                            }
                        }
            }
            catch
            { }
        }
        
        private void gridViewThanhTraCoiThi_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ViewThanhTraCoiThi obj = gridViewThanhTraCoiThi.GetRow(e.RowHandle) as ViewThanhTraCoiThi;
            if (obj != null)
            {
                bool kq = false, trongGioChamGiang = false;
                DataServices.ThanhTraTheoThoiKhoaBieu.KiemTraThoiHanChamThanhTra(obj.NgayThi, ref kq);
                if (!kq)
                {
                    XtraMessageBox.Show("Ngoài thời gian chấm giảng. Vui lòng liên hệ với quản trị viên để biết thêm chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ColumnView view = (ColumnView)gridControlThanhTraCoiThi.KeyboardFocusView;
                    if (view.IsEditing)
                        view.HideEditor();
                    view.CancelUpdateCurrentRow();
                    return;
                }

                //Kiểm tra trong giờ cho phép chấm thanh tra đối với nhân viên thanh tra
                if (_groupUser.ToLower() != "truongthanhtra")
                {
                    DataServices.ThanhTraTheoThoiKhoaBieu.KiemTraGioChamThanhTra(obj.NgayThi, ref trongGioChamGiang);
                    if (!trongGioChamGiang)
                    {
                        XtraMessageBox.Show("Ngoài thời gian chấm giảng. Thời gian chấm giảng từ 06h00 đến 18h00 cùng ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ColumnView view = (ColumnView)gridControlThanhTraCoiThi.KeyboardFocusView;
                        if (view.IsEditing)
                            view.HideEditor();
                        view.CancelUpdateCurrentRow();
                    }
                }
            }
        }
        #endregion

        #region Event CBO
        private void cboCoSo_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitDayNha();
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChonTatCa.CheckState == CheckState.Checked)
            {
                for (int i = 0; i <= gridViewThanhTraCoiThi.DataRowCount; i++)
                    gridViewThanhTraCoiThi.SetRowCellValue(i, "XacNhan", true);
            }
            else
            {
                for (int i = 0; i <= gridViewThanhTraCoiThi.DataRowCount; i++)
                    gridViewThanhTraCoiThi.SetRowCellValue(i, "XacNhan", false);
            }
        }

    }
}