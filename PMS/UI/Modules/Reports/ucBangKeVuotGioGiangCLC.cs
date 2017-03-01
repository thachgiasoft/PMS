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
using DevExpress.XtraGrid.Columns;
using PMS.UI.Forms.NghiepVu.ChucNangCon;

namespace PMS.UI.Modules.Reports
{
    public partial class ucBangKeVuotGioGiangCLC : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnKeToaXacNhanChiTra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnKeToaXacNhanChiTra.ShortCut = Shortcut.None;

                btnLuuChiTra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuuChiTra.ShortCut = Shortcut.None;
            }
            else
            {
                btnKeToaXacNhanChiTra.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnLuuChiTra.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        string _maTruong;
        DateTime _ngayIn;
        bool userRole;
        DataTable dtData;
        string _groupName = UserInfo.GroupName;
        string _dotChiTra, _ngayChiTra;
        #endregion

        #region Event Form
        public ucBangKeVuotGioGiangCLC()
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

        private void ucBangKeVuotGioGiangCLC_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "DaChiTra", "XacNhanChiTra", "ChonIn", "TenDotChiTra", "MaQuanLy", "HoTen", "HocHamHocVi", "TenMonHoc", "MalopHocPhan", "TietThucDay", "DonGia", "TienSauGiang", "TenLoaiGiangVien", "Id", "DotChiTra" }
                    , new string[] { "Xác nhận thanh toán", "Xác nhận chi trả", "Chọn in", "Đợt chi trả", "Mã giảng viên", "Họ tên", "Học hàm - học vị", "Tên môn học", "Lớp học phần", "Số tiết", "Đơn giá", "Các khâu sau giảng CLC", "Loại giảng viên", "Id", "DotChiTra" }
                    , new int[] { 60, 60, 50, 100, 75, 150, 120, 150, 100, 80, 80, 100, 99, 99, 99 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "DaChiTra", "XacNhanChiTra", "ChonIn", "TenDotChiTra", "MaQuanLy", "HoTen", "HocHamHocVi", "TenMonHoc", "MalopHocPhan", "TietThucDay", "DonGia", "TienSauGiang", "TenLoaiGiangVien", "Id" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienSauGiang", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewThongKe, new string[] { "Id", "DotChiTra" });
            gridViewThongKe.Columns["TenLoaiGiangVien"].GroupIndex = 0;
             
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
                btnLuuChiTra.Enabled = true;
                AppGridView.HideField(gridViewThongKe, new string[] { "XacNhanChiTra" });
                layoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                btnKeToaXacNhanChiTra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else
            {
                //_vListKhoa.Add(new ViewKhoaBoMon() { MaBoMon = "-1", TenBoMon = "[Tất cả]", MaKhoa = "-1", TenKhoa = "[Tất cả]", ThuTu = 0 });
                btnLuuChiTra.Enabled = false;
                layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                AppGridView.HideField(gridViewThongKe, new string[] { "DaChiTra" });
                gridViewThongKe.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
                btnKeToaXacNhanChiTra.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
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

            PMS.Common.Globals.GridRowColor(gridViewThongKe, new Font("Tahoma", 8), Color.Aquamarine, "XacNhanChiTra", "True");

            InitData();
        }
        #endregion

        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            LoadDataSource();
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboLoaiGiangVien.EditValue != null && cboDonVi.EditValue != null && cboLanChot.EditValue != null)
            {
                dtData = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThanhToanTienGiangClc(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                dtData.Load(reader);
                dtData.Columns["DaChiTra"].ReadOnly = false;
                dtData.Columns["ChonIn"].ReadOnly = false;
                dtData.Columns["XacNhanChiTra"].ReadOnly = false;
                bindingSourceThongKe.DataSource = dtData;

                if (!userRole)
                {
                    gridViewThongKe.ActiveFilterString = "[DaChiTra] = True";
                }
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

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                if (frmChon.NgayIn.ToString("dd/MM/yyyy") == "01/01/0001")
                    return;
                _ngayIn = frmChon.NgayIn;
            }
            gridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao;
            try
            {
                vListBaoCao = data.Select("ChonIn = True").CopyToDataTable();
            }
            catch
            {
                XtraMessageBox.Show("Vui lòng chọn môn muốn in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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


            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InBangKeVuotGioGiangCLC(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), UserInfo.FullName, _ngayIn, vListBaoCao);
                    frm.ShowDialog();
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
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuuChiTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewThongKe.FocusedRowHandle = -1;
            DataTable tbl = bindingSourceThongKe.DataSource as DataTable;
            if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string xmlData = "";
                    foreach (DataRow r in tbl.Rows)
                    {
                        if (r.RowState == DataRowState.Modified)
                        {
                            xmlData += String.Format("<Input I=\"{0}\" N=\"{1}\" />", r["Id"], r["DaChiTra"]);
                        }
                    }
                    xmlData = String.Format("<Root>{0}</Root>", xmlData);
                    int kq = 0;
                    DataServices.KetQuaThanhToanThuLao.LuuChiTra(xmlData, ref kq);
                    if (kq == 0)
                    {
                        XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKeToaXacNhanChiTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewThongKe.FocusedRowHandle = -1;
            DataTable tbl = bindingSourceThongKe.DataSource as DataTable;
            //if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
                try
                {
                    using (frmChonDotThanhToan frm = new frmChonDotThanhToan (cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()))
                    {
                        frm.ShowDialog();
                        if (!frm.XacNhan)
                            return;

                        _dotChiTra = frm.IdDot;
                        _ngayChiTra = DateTime.Now.ToShortDateString();
                    }

                    string xmlData = "";
                    foreach (DataRow r in tbl.Rows)
                    {
                            xmlData += String.Format("<Input I=\"{0}\" N=\"{1}\" />", r["Id"], r["XacNhanChiTra"]);
                    }
                    xmlData = String.Format("<Root>{0}</Root>", xmlData);
                    int kq = 0;
                    DataServices.KetQuaThanhToanThuLao.KeToanXacNhanThanhToan(xmlData, _dotChiTra, _ngayChiTra, ref kq);
                    if (kq == 0)
                    {
                        int kq2 = -1;
                        DataServices.TietNoKyTruoc.LuuSauChiTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()), ref kq2);
                        if (kq2 == 0)
                            XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    LoadDataSource();
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            //}
        }
        #endregion

        #region Event Cbo
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
        #endregion


        #region Event CheckEdit
        //Khoa xác nhận
        private void checkEditDaThanhToanTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditDaThanhToanTatCa.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewThongKe.DataRowCount; i++)
                {
                    gridViewThongKe.SetRowCellValue(i, "DaChiTra", "True");
                }
            }
            if (checkEditDaThanhToanTatCa.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewThongKe.DataRowCount; i++)
                {
                    gridViewThongKe.SetRowCellValue(i, "DaChiTra", "False");
                }
            }
        }


        private void checkEditInTatCa_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkEditInTatCa.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewThongKe.DataRowCount; i++)
                {
                    gridViewThongKe.SetRowCellValue(i, "ChonIn", "True");
                }
            }
            if (checkEditInTatCa.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewThongKe.DataRowCount; i++)
                {
                    gridViewThongKe.SetRowCellValue(i, "ChonIn", "False");
                }
            }
        }

        //Kế toán xác nhận
        private void checkEditKeToanXacnhan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditKeToanXacnhan.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewThongKe.DataRowCount; i++)
                {
                    gridViewThongKe.SetRowCellValue(i, "XacNhanChiTra", "True");
                }
            }
            if (checkEditKeToanXacnhan.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewThongKe.DataRowCount; i++)
                {
                    gridViewThongKe.SetRowCellValue(i, "XacNhanChiTra", "False");
                }
            }
        }
        #endregion

        private void gridViewThongKe_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "DaChiTra")
            {
                int _kiemTra = -1;
                DataRowView r = gridViewThongKe.GetRow(e.RowHandle) as DataRowView;
                DataServices.KetQuaThanhToanThuLao.KiemTraTinhTrangKeToanChiTra(int.Parse(r["Id"].ToString()), ref _kiemTra);
                if (_kiemTra != 0)
                {
                    XtraMessageBox.Show("Không thể thay đổi dòng dữ liệu kế toán đã thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadDataSource();
                }
            }
        }

    }
}
