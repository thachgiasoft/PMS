using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;
using PMS.UI.Forms.BaoCao;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using DevExpress.XtraEditors.Controls;
using PMS.Entities.Validation;
using DevExpress.XtraGrid.Views.Base;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Forms.NghiepVu.ThanhTra
{
    public partial class frmThanhTraGiangDay_IUH : DevExpress.XtraEditors.XtraForm
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
        #region Event Form
        public frmThanhTraGiangDay_IUH()
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
                btnLamTuoi.Caption = "Cập nhật mới";
        }

        private void frmThanhTraGiangDay_Load(object sender, EventArgs e)
        {
            #region Init GridView
            switch (_maTruong)
            { 
                case "IUH":
                    InitGridIUH();
                    break;
                default :
                    InitRemaining();
                    break;
            }
            #endregion

            #region InitRepository ViPham
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNoiDungViPham, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditNoiDungViPham, 400, 650);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNoiDungViPham, new string[] { "MaViPham", "NoiDungViPham" }, new string[] { "Mã vi phạm", "Nội dung vi phạm" }, new int[] { 70, 260 });
            repositoryItemGridLookUpEditNoiDungViPham.DisplayMember = "NoiDungViPham";
            repositoryItemGridLookUpEditNoiDungViPham.ValueMember = "MaViPham";
            repositoryItemGridLookUpEditNoiDungViPham.NullText = string.Empty;
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
            AppGridView.InitGridView(gridViewThanhTra, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThanhTra, new string[] { "Ngay", "Phong", "MaHocPhan", "TenHocPhan", "LoaiHocPhan", "MaGocLopHocPhan", "MaLop", "MaCanBoGiangDay", "HoTen", "Khoa", "Thu", "Tiet", "SoTiet", "TienDo", "SiSo", "SoTietGhiNhan", "MaViPham", "MaHinhThucViPhamHrm", "ThoiDiemGhiNhan", "LyDo", "GhiChu", "NgayCapNhat", "NguoiCapNhat", "XacNhan", "TrangThai" }
                    , new string[] { "Ngày", "Phòng học", "Mã học phần", "Tên học phần", "Loại học phần", "Mã lớp học phần", "Mã lớp", "Mã CBGD", "Họ tên", "Đơn vị", "Thứ", "Tiết", "Số tiết", "Tiến độ", "Sĩ số", "Số tiết ghi nhận", "Nội dung vi phạm", "Hình thức vi phạm đánh giá ABC", "Thời điểm ghi nhận", "Lý do", "Ghi chú", "NgayCapNhat", "NguoiCapNhat", "Đã ghi nhận", "Trạng thái" }
                    , new int[] { 70, 80, 80, 150, 90, 110, 90, 70, 140, 150, 50, 70, 60, 80, 60, 100, 170, 200, 110, 150, 150, 99, 99, 90, 99 });
            AppGridView.AlignHeader(gridViewThanhTra, new string[] { "Ngay", "Phong", "MaHocPhan", "TenHocPhan", "LoaiHocPhan", "MaGocLopHocPhan", "MaLop", "MaCanBoGiangDay", "HoTen", "Khoa", "Thu", "Tiet", "SoTiet", "SoTietGhiNhan", "TienDo", "SiSo", "MaViPham", "MaHinhThucViPhamHrm", "ThoiDiemGhiNhan", "LyDo", "GhiChu", "NgayCapNhat", "NguoiCapNhat", "XacNhan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThanhTra, "Ngay", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.HideField(gridViewThanhTra, new string[] { "NgayCapNhat", "NguoiCapNhat", "SiSo", "TrangThai" });
            AppGridView.FormatDataField(gridViewThanhTra, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewThanhTra, "MaViPham", repositoryItemGridLookUpEditNoiDungViPham);
            AppGridView.RegisterControlField(gridViewThanhTra, "MaHinhThucViPhamHrm", repositoryItemGridLookUpEditHinhThucViPhamHRM);
            AppGridView.ReadOnlyColumn(gridViewThanhTra, new string[] { "Ngay", "Phong", "MaHocPhan", "TenHocPhan", "LoaiHocPhan", "MaGocLopHocPhan", "MaLop", "MaCanBoGiangDay", "HoTen", "Khoa", "Thu", "Tiet", "SoTiet", "TienDo" });

            if (_maTruong != "UEL")
                AppGridView.HideField(gridViewThanhTra, new string[] { "MaHinhThucViPhamHrm" });
        }

        void InitRemaining()//UEL
        {
            AppGridView.InitGridView(gridViewThanhTra, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThanhTra, new string[] { "Ngay", "Phong", "MaHocPhan", "TenHocPhan", "LoaiHocPhan", "MaGocLopHocPhan", "MaLop", "MaCanBoGiangDay", "HoTen", "Khoa", "Thu", "TietBatDau", "SoTiet", "TienDo", "SiSo", "SoTietGhiNhan", "MaViPham", "MaHinhThucViPhamHrm", "ThoiDiemGhiNhan", "LyDo", "GhiChu", "NgayCapNhat", "NguoiCapNhat", "XacNhan", "TrangThai" }
                    , new string[] { "Ngày", "Phòng học", "Mã học phần", "Tên học phần", "Loại học phần", "Mã lớp học phần", "Mã lớp", "Mã CBGD", "Họ tên", "Đơn vị", "Thứ", "Tiết bắt đầu", "Số tiết", "Tiến độ", "Sĩ số", "Số tiết ghi nhận", "Nội dung vi phạm", "Hình thức vi phạm đánh giá ABC", "Thời điểm ghi nhận", "Lý do", "Ghi chú", "NgayCapNhat", "NguoiCapNhat", "XacNhan", "TrangThai" }
                    , new int[] { 70, 80, 80, 150, 90, 110, 90, 70, 140, 150, 50, 70, 60, 80, 60, 100, 170, 200, 110, 150, 150, 99, 99, 99, 99 });
            AppGridView.AlignHeader(gridViewThanhTra, new string[] { "Ngay", "Phong", "MaHocPhan", "TenHocPhan", "LoaiHocPhan", "MaGocLopHocPhan", "MaLop", "MaCanBoGiangDay", "HoTen", "Khoa", "Thu", "TietBatDau", "SoTiet", "SoTietGhiNhan", "TienDo", "SiSo", "MaViPham", "MaHinhThucViPhamHrm", "ThoiDiemGhiNhan", "LyDo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThanhTra, "Ngay", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.HideField(gridViewThanhTra, new string[] { "NgayCapNhat", "NguoiCapNhat", "SiSo", "XacNhan", "TrangThai" });
            AppGridView.FormatDataField(gridViewThanhTra, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewThanhTra, "MaViPham", repositoryItemGridLookUpEditNoiDungViPham);
            AppGridView.RegisterControlField(gridViewThanhTra, "MaHinhThucViPhamHrm", repositoryItemGridLookUpEditHinhThucViPhamHRM);
            AppGridView.ReadOnlyColumn(gridViewThanhTra, new string[] { "Ngay", "Phong", "MaHocPhan", "TenHocPhan", "LoaiHocPhan", "MaGocLopHocPhan", "MaLop", "MaCanBoGiangDay", "HoTen", "Khoa", "Thu", "TietBatDau", "SoTiet", "TienDo" });

            if (_maTruong != "UEL")
                AppGridView.HideField(gridViewThanhTra, new string[] { "MaHinhThucViPhamHrm" });
        }
        #endregion 

        #region InitData
        void InitData()
        {
            dateEditTuNgay.DateTime = DateTime.Now;
            dateEditDenNgay.DateTime = DateTime.Now;

            InitCoSo();

            InitDayNha();

            bindingSourceNoiDungViPham.DataSource = DataServices.DanhMucViPham.GetAll();
            bindingSourceHinhThucViPhamHRM.DataSource = DataServices.ViewHinhThucViPham.GetAll();
            //if (dateEditTuNgay.EditValue != null && dateEditDenNgay.EditValue != null && cboDayNha.EditValue != null)
            //{
            //    bindingSourceThanhTra.DataSource = DataServices.ViewThanhTraTheoThoiKhoaBieu.GetByNgayCoSoToaNha(dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), cboDayNha.EditValue.ToString());
            //    ToMau(bindingSourceThanhTra.DataSource as VList<ViewThanhTraTheoThoiKhoaBieu>);
            //}
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

        #region Event Button
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
                if (gridViewThanhTra.RowCount > 0)
                    if (gridViewThanhTra.GetSelectedRows().Length > 0)
                    {
                        foreach (int i in gridViewThanhTra.GetSelectedRows())
                        {
                            gridViewThanhTra.SetRowCellValue(i, "SiSo", "");
                            gridViewThanhTra.SetRowCellValue(i, "MaViPham", "");
                            gridViewThanhTra.SetRowCellValue(i, "MaHinhThucViPhamHrm", "");
                            gridViewThanhTra.SetRowCellValue(i, "ThoiDiemGhiNhan", "");
                            gridViewThanhTra.SetRowCellValue(i, "LyDo", "");
                            gridViewThanhTra.SetRowCellValue(i, "GhiChu", "");
                            gridViewThanhTra.SetRowCellValue(i, "SoTietGhiNhan", "");
                        }
                    }
            }
            catch
            { }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string s = PMS.Common.Globals.IsNull(0, "int").ToString();
            gridViewThanhTra.FocusedRowHandle = -1;
            DataTable list = bindingSourceThanhTra.DataSource as DataTable;
            if (list.Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        string xmlData = "";
                        foreach (DataRow v in list.Rows)
                        {
                            if((bool)PMS.Common.Globals.IsNull(v["TrangThai"], "bool"))
                            //if (v.SiSo != null || v.MaViPham != null || v.ThoiDiemGhiNhan != null || v.LyDo != null || v.GhiChu != null || v.NgayCapNhat != null || v.NguoiCapNhat != null || v.MaHinhThucViPhamHrm != null || v.SoTietGhiNhan != null)
                            {
                                if (PMS.Common.Globals.IsNull(v["GhiChu"], "string").ToString().Contains("[Đã đổi lịch]"))
                                    v["GhiChu"] = v["GhiChu"].ToString().Replace("[Đã đổi lịch]", "");//Tránh trường hợp lưu nhiều lần ghi chú [Đã đổi lịch]
                                xmlData += "<Input ML=\"" + v["MaLichHoc"]
                                            + "\" S=\"" + v["SiSo"]
                                            + "\" VP=\"" + v["MaViPham"]
                                            + "\" HR=\"" + v["MaHinhThucViPhamHrm"]
                                            + "\" T=\"" + v["ThoiDiemGhiNhan"]
                                            + "\" L=\"" + v["LyDo"]
                                            + "\" G=\"" + v["GhiChu"]
                                            + "\" N=\"" + v["NgayCapNhat"]
                                            + "\" U=\"" + v["NguoiCapNhat"]
                                            + "\" MH=\"" + v["MaHocPhan"]
                                            + "\" HP=\"" + v["MaGocLopHocPhan"]
                                            + "\" ST=\"" + PMS.Common.Globals.IsNull(v["SoTietGhiNhan"], "int").ToString()
                                            + "\" CB=\"" + v["MaCanBoGiangDay"]
                                            + "\" ND=\"" + v["Ngay"]//((DateTime)v["Ngay"]).ToString("dd/MM/yyyy")
                                            + "\" TBD=\"" + v["TietBatDau"]
                                            + "\" S2=\"" + v["SoTiet"]
                                            + "\" P=\"" + v["Phong"]
                                            + "\" />";

                            }
                        }
                        xmlData = "<Root>" + xmlData + "</Root>";
                        int kq = 0;
                        DataServices.ThanhTraTheoThoiKhoaBieu.Luu(xmlData, ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi. Kiểm tra lại dữ liệu vừa nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //Lấy lại dữ liệu sau khi lưu
                        Cursor.Current = Cursors.WaitCursor;
                        if (dateEditTuNgay.EditValue != null && dateEditDenNgay.EditValue != null && cboDayNha.EditValue != null)
                        {
                            DataTable tb = new DataTable();
                            IDataReader reader = DataServices.ThanhTraTheoThoiKhoaBieu.GetByNgayCoSoToaNha(dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), cboDayNha.EditValue.ToString());
                            tb.Load(reader);
                            tb.Columns["SoTietGhiNhan"].ReadOnly = false;
                            bindingSourceThanhTra.DataSource = tb;
                        }
                        Cursor.Current = Cursors.Default;
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
            using (SaveFileDialog file = new SaveFileDialog())
            {
                file.Filter = "(*.xls)|*.xls";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (file.FileName != "")
                    {
                        gridControlThanhTra.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();

                if (frmChon.NgayIn.ToString("dd/MM/yyyy") == "01/01/0001")
                    return;
                _ngayIn = frmChon.NgayIn;
                
            }
            Cursor.Current = Cursors.WaitCursor;
            gridViewThanhTra.FocusedRowHandle = -1;
            bindingSourceThanhTra.EndEdit();
            DataTable data = bindingSourceThanhTra.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThanhTra, bindingSourceThanhTra);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThanhTra.SortedColumns)
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

            //string filter = gridViewThanhTra.ActiveFilterString;
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
                    frm.InKiemTraGioThucGiang(PMS.Common.Globals._cauhinh.TenTruong, dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), cboDayNha.Text, _ngayIn, vListBaoCao);
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
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ThanhTraTheoThoiKhoaBieu.GetByNgayCoSoToaNha(dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), cboDayNha.EditValue.ToString());
                tb.Load(reader);
                tb.Columns["SoTietGhiNhan"].ReadOnly = false;
                bindingSourceThanhTra.DataSource = tb;
                //ToMau(bindingSourceThanhTra.DataSource as VList<ViewThanhTraTheoThoiKhoaBieu>);
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event GridView
        private void gridViewThanhTra_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "SiSo" || col.FieldName == "MaViPham" || col.FieldName == "ThoiDiemGhiNhan" || col.FieldName == "LyDo" || col.FieldName == "GhiChu" || col.FieldName == "MaHinhThucViPhamHrm" || col.FieldName == "SoTietGhiNhan" || col.FieldName == "XacNhan")
            {
                gridViewThanhTra.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewThanhTra.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
                gridViewThanhTra.SetRowCellValue(e.RowHandle, "TrangThai", "True");
            }

            if (col.FieldName == "SoTietGhiNhan")
            {
                DataRowView v = gridViewThanhTra.GetRow(e.RowHandle) as DataRowView;
                if (_maTruong == "IUH")
                {
                    if (int.Parse(PMS.Common.Globals.IsNull(v["SoTietGhiNhan"], "int").ToString()) > int.Parse(PMS.Common.Globals.IsNull(v["SoTiet"], "int").ToString()))
                    {
                        XtraMessageBox.Show("Số tiết nhập quá giới hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gridViewThanhTra.SetRowCellValue(e.RowHandle, "SoTietGhiNhan", int.Parse(PMS.Common.Globals.IsNull(v["SoTiet"], "int").ToString()));
                    }
                }
                else
                {
                    if (int.Parse(PMS.Common.Globals.IsNull(v["SoTietGhiNhan"], "int").ToString()) > 15)
                    {
                        XtraMessageBox.Show("Số tiết nhập quá giới hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gridViewThanhTra.SetRowCellValue(e.RowHandle, "SoTietGhiNhan", "");
                    }
                }
            }
        }

        private void gridViewThanhTra_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                    if (gridViewThanhTra.RowCount > 0)
                        if (gridViewThanhTra.GetSelectedRows().Length > 0) 
                        {
                            foreach (int i in gridViewThanhTra.GetSelectedRows())
                            {
                                gridViewThanhTra.SetRowCellValue(i, "SiSo", null);
                                gridViewThanhTra.SetRowCellValue(i, "MaViPham", "");
                                gridViewThanhTra.SetRowCellValue(i, "MaHinhThucViPhamHrm", null);
                                gridViewThanhTra.SetRowCellValue(i, "ThoiDiemGhiNhan", "");
                                gridViewThanhTra.SetRowCellValue(i, "LyDo", "");
                                gridViewThanhTra.SetRowCellValue(i, "GhiChu", "");
                                gridViewThanhTra.SetRowCellValue(i, "SoTietGhiNhan", "");
                            }
                        }
            }
            catch
            { }
        }

        private void gridViewThanhTra_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataRowView obj = gridViewThanhTra.GetRow(e.RowHandle) as DataRowView;
            //Kiểm tra quá số ngày cho phép chấm thanh tra
            if (obj != null)
            {
                bool kq = false, trongGioChamGiang = false;
                DataServices.ThanhTraTheoThoiKhoaBieu.KiemTraThoiHanChamThanhTra(obj["Ngay"].ToString(), ref kq);
                if (!kq)
                {
                    XtraMessageBox.Show("Ngoài thời gian chấm giảng. Vui lòng liên hệ với quản trị viên để biết thêm chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ColumnView view = (ColumnView)gridControlThanhTra.KeyboardFocusView;
                    if (view.IsEditing)
                        view.HideEditor();
                    view.CancelUpdateCurrentRow();
                    return;
                }

                //Kiểm tra trong giờ cho phép chấm thanh tra đối với nhân viên thanh tra
                if (_groupUser.ToLower() != "truongthanhtra")
                {
                    DataServices.ThanhTraTheoThoiKhoaBieu.KiemTraGioChamThanhTra(obj["Ngay"].ToString(), ref trongGioChamGiang);
                    if (!trongGioChamGiang)
                    {
                        XtraMessageBox.Show("Ngoài thời gian chấm giảng. Thời gian chấm giảng từ 06h00 đến 18h00 cùng ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ColumnView view = (ColumnView)gridControlThanhTra.KeyboardFocusView;
                        if (view.IsEditing)
                            view.HideEditor();
                        view.CancelUpdateCurrentRow();
                    }
                }
            }
        }
        #endregion

        #region Event Cbo
        private void cboCoSo_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitDayNha();
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region ToMau
        void ToMau(VList<ViewThanhTraTheoThoiKhoaBieu> list)
        {
            try
            {
                if (list.Count > 0)
                {
                    foreach (ViewThanhTraTheoThoiKhoaBieu v in list)
                    {
                        if (v.TienDo == "LB")
                        {
                            AppGridView.ConditionsAdjustment(gridViewThanhTra, "TienDo", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Yellow, v.TienDo);
                        }

                        if (v.TienDo == "LN")
                        {
                            AppGridView.ConditionsAdjustment(gridViewThanhTra, "TienDo", DevExpress.XtraGrid.FormatConditionEnum.Equal, true, Color.Aqua, v.TienDo);
                        }
                    }
                }
            }
            catch
            { }

        }
        #endregion

        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChonTatCa.CheckState == CheckState.Checked)
            {
                for (int i = 0; i <= gridViewThanhTra.DataRowCount; i++)
                    gridViewThanhTra.SetRowCellValue(i, "XacNhan", true);
            }
            else
            {
                for (int i = 0; i <= gridViewThanhTra.DataRowCount; i++)
                    gridViewThanhTra.SetRowCellValue(i, "XacNhan", false);
            }
        }

     
    }
}