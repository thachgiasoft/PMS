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
using PMS.UI.Forms.NghiepVu.FormXuLy;
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Modules.Reports
{
    public partial class ucBangThanhToanThuLaoGiangDayTheoKhoa : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        DateTime _ngayIn;
        VList<ViewKhoaBoMon> _listKhoaBoMon;
        #endregion

        public ucBangThanhToanThuLaoGiangDayTheoKhoa()
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
        }

        private void ucBangThanhToanThuLaoGiangDayTheoKhoa_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewBangThanhToan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            //AppGridView.ShowEditor(gridViewBangThanhToan, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewBangThanhToan, new string[] {"MaQuanLy","HoTen","TenLoaiGiangVien","TenKhoaHoc","TenBacDaoTao","LoaiHinhDaoTao","KhoaBacLoaiHinh","TenMonHoc","MaLop","SoTinChi","SoTiet","SoLuongSv","DonGia","ThanhTien","ThueTncn","ThucNhan","MaSoThue","SoTaiKhoan","TenNganHang", "DaChiTra", "Id", "NgayChiTra", "ChonIn" }
                                                       , new string[] { "Mã giảng viên", "Họ tên giảng viên", "Loại giảng viên", "Khóa học", "Bậc đào tạo", "Loại hình đào tạo", "-", "Tên môn học", "Mã lớp", "Số tín chỉ", "Số tiết", "Sĩ số", "Đơn giá", "Thành tiền", "Thuế TNCN 10%", "Thực nhận", "Mã số thuế", "Số tài khoản", "Ngân hàng - chi nhánh", "Đã chi trả", "Id", "Ngày chi trả", "Chọn in" }
                                                       , new int[] { 70, 130, 90, 100, 80, 90,100, 120, 170, 80, 80, 80, 100, 100, 100, 100, 110, 120, 330, 90, 99, 99, 80 });
            AppGridView.AlignHeader(gridViewBangThanhToan, new string[] { "MaQuanLy", "HoTen", "TenLoaiGiangVien", "TenKhoaHoc", "TenBacDaoTao", "LoaiHinhDaoTao", "KhoaBacLoaiHinh", "TenMonHoc", "MaLop", "SoTinChi", "SoTiet", "SoLuongSv", "DonGia", "ThanhTien", "ThueTncn", "ThucNhan", "MaSoThue", "SoTaiKhoan", "TenNganHang", "DaChiTra", "ChonIn" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewBangThanhToan, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewBangThanhToan, "SoTinChi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewBangThanhToan, "SoTiet", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewBangThanhToan, "SoLuongSv", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewBangThanhToan, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewBangThanhToan, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewBangThanhToan, "ThueTncn", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewBangThanhToan, "ThucNhan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewBangThanhToan, new string[] { "MaQuanLy", "HoTen", "TenLoaiGiangVien", "TenKhoaHoc", "TenBacDaoTao", "LoaiHinhDaoTao", "KhoaBacLoaiHinh", "TenMonHoc", "MaLop", "SoTinChi", "SoTiet", "SoLuongSv", "DonGia", "ThanhTien", "ThueTncn", "ThucNhan", "MaSoThue", "SoTaiKhoan", "TenNganHang" });
            AppGridView.HideField(gridViewBangThanhToan, new string[] { "Id", "NgayChiTra" });
            gridViewBangThanhToan.Columns["KhoaBacLoaiHinh"].GroupIndex = 0;
            gridViewBangThanhToan.GroupPanelText = "Gom nhóm bằng cách kéo tên cột thả vào đây";
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
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã khoa đơn vị", "Tên khoa đơn vị" });
            cboKhoaDonVi.Properties.ValueMember = "MaBoMon";
            cboKhoaDonVi.Properties.DisplayMember = "TenBoMon";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitData()
        void InitData()
        {
            _listKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            _listKhoaBoMon.Insert(0, new ViewKhoaBoMon() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]", MaBoMon = "-1", TenBoMon = "[Tất cả]" });
            cboKhoaDonVi.DataBindings.Clear();
            bindingSourceKhoaDonVi.DataSource = _listKhoaBoMon;
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            #region LoaiGiangVien
            cboLoaiGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiGiangVien.Properties.Items.Clear();

            TList<LoaiGiangVien> _tListLoaiGiangVien = DataServices.LoaiGiangVien.GetAll();

            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();

            foreach (LoaiGiangVien l in _tListLoaiGiangVien)
                list.Add(new CheckedListBoxItem(l.MaLoaiGiangVien, string.Format("{0} - {1}", l.MaQuanLy, l.TenLoaiGiangVien), CheckState.Unchecked, true));
            cboLoaiGiangVien.Properties.Items.AddRange(list.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
            #endregion
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
            try
            {
                using (frmChonNgay frmChon = new frmChonNgay())
                {
                    frmChon.ShowDialog();
                    _ngayIn = frmChon.NgayIn;
                }

                Cursor.Current = Cursors.WaitCursor;
                gridViewBangThanhToan.FocusedRowHandle = -1;
                bindingSourceBangThanhToan.EndEdit();
                DataTable data = bindingSourceBangThanhToan.DataSource as DataTable;

                if (data.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn những giảng viên muốn in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DataTable vListBaoCao = data.Select("ChonIn = 1").CopyToDataTable();
                if (vListBaoCao.Rows.Count == 0)
                    return;
                string sort = "";
                if (vListBaoCao != null)
                {
                    if (vListBaoCao.Rows.Count != 0)
                    {
                        foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewBangThanhToan.SortedColumns)
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

                string filter = gridViewBangThanhToan.ActiveFilterString;
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
                int dem = vListBaoCao.Rows.Count;


                vListBaoCao.AcceptChanges();

                if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
                {
                    using (frmBaoCao frm = new frmBaoCao())
                    {
                        frm.InBangThanhToanThuLaoGiangDayTheoKhoa(PMS.Common.Globals._cauhinh.TenTruong, cboKhoaDonVi.Text.ToUpper(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                            , PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.NguoiLapbieu, _ngayIn
                            , vListBaoCao);
                        frm.ShowDialog();
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch
            { XtraMessageBox.Show("Vui lòng chọn những giảng viên muốn in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            
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
                        gridControlBangThanhToan.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void gridLookUpEditNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThanhToanThuLaoGiangDayTheoKhoa(cboKhoaDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                dt.Load(reader);
                dt.Columns["DaChiTra"].ReadOnly = false;
                dt.Columns["ChonIn"].ReadOnly = false;
                bindingSourceBangThanhToan.DataSource = dt;
            }
            gridViewBangThanhToan.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            Cursor.Current = Cursors.Default;
        }

        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChonTatCa.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewBangThanhToan.DataRowCount; i++)
                {
                    gridViewBangThanhToan.SetRowCellValue(i, "DaChiTra", "True");
                }
            }
            if (checkEditChonTatCa.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewBangThanhToan.DataRowCount; i++)
                {
                    gridViewBangThanhToan.SetRowCellValue(i, "DaChiTra", "False");
                }
            }
        }

        private void btnLuuChiTra_Click(object sender, EventArgs e)
        {
            gridViewBangThanhToan.FocusedRowHandle = -1;
            DataTable tbl = bindingSourceBangThanhToan.DataSource as DataTable;
            if (tbl != null)
            {
                if (XtraMessageBox.Show("Bạn muốn lưu chi trả cho những giảng viên đã chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "", kt="";
                        foreach (DataRow r in tbl.Rows)
                        {
                            if (r.RowState == DataRowState.Modified)
                            {
                                DataServices.KetQuaThanhToanThuLao.KiemTraDaChiTra(int.Parse(r["Id"].ToString()), ref kt);
                                if (kt != "")
                                {
                                    XtraMessageBox.Show(kt, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    btnLocDuLieu.PerformClick();
                                    return;
                                }
                                xmlData += "<Input Id=\"" + r["Id"].ToString()
                                        + "\" C=\"" + r["DaChiTra"].ToString()
                                        + "\" D=\"" + r["NgayChiTra"].ToString()
                                        + "\" />";
                            }
                        }
                        xmlData = "<Root>" + xmlData + "</Root>";

                        int kq = -1;
                        DataServices.KetQuaThanhToanThuLao.LuuGiangVienDaChiTra(xmlData, ref kq);

                        if (kq == 0)
                            XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnLocDuLieu.PerformClick();
                    }
                    catch
                    { XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void gridViewBangThanhToan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "DaChiTra")
            {
                gridViewBangThanhToan.SetRowCellValue(e.RowHandle, "NgayChiTra", DateTime.Now.ToString("dd/MM/yyyy"));
            }
        }

        private void checkEditChonIn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChonIn.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewBangThanhToan.DataRowCount; i++)
                {
                    gridViewBangThanhToan.SetRowCellValue(i, "ChonIn", "True");
                }
            }
            if (checkEditChonIn.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewBangThanhToan.DataRowCount; i++)
                {
                    gridViewBangThanhToan.SetRowCellValue(i, "ChonIn", "False");
                }
            }
        }
    }
}
