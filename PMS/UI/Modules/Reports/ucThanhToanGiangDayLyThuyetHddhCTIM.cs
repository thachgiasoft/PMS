using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.BaoCao;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.BLL;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThanhToanGiangDayLyThuyetHddhCTIM : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        DateTime _ngayIn;
        VList<ViewKhoa> _vListKhoaBoMon;
        string groupname = UserInfo.GroupName;
        string _maTruong;
        #endregion

        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
            }
            else
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }

        public ucThanhToanGiangDayLyThuyetHddhCTIM()
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
        }

        private void ucThanhToanGiangDayLyThuyetHddhCTIM_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Chon", "XacNhanChiTra", "MaQuanLy", "HoTen", "ChucDanh", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "MaLop", "SiSo", "TietThucDay", "HeSoLopDong", "HeSoThinhGiangMonChuyenNganh", "HeSoChucDanhChuyenMon", "TietQuyDoi", "DonGia", "TongTien", "Thue", "ThucLinh", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Chọn in", "Khoá thanh toán", "Mã giảng viên", "Họ tên", "Chức danh", "Mã môn học", "Tên môn học", "Mã lớp học phần", "Mã lớp", "Sĩ số", "Số tiết", "Hệ số lớp đông", "Hệ số thỉnh giảng", "Hệ số chức danh", "Số tiết thanh toán", "Đơn giá", "Số tiền thanh toán", "Thuế TNCN", "Số tiền còn lĩnh", "ngày cập nhật", "Người cập nhật" }
                    , new int[] { 60, 60, 90, 140, 140, 90, 150, 110, 100, 60, 60, 110, 110, 110, 110, 100, 120, 100, 120, 90, 90 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Chon", "XacNhanChiTra", "MaQuanLy", "HoTen", "ChucDanh", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "MaLop", "SiSo", "TietThucDay", "HeSoLopDong", "HeSoThinhGiangMonChuyenNganh", "HeSoChucDanhChuyenMon", "TietQuyDoi", "DonGia", "TongTien", "Thue", "ThucLinh", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "ChucDanh", "MaMonHoc", "TenMonHoc", "MaLopHocPhan", "MaLop", "SiSo", "TietThucDay", "HeSoLopDong", "HeSoThinhGiangMonChuyenNganh", "HeSoChucDanhChuyenMon", "TietQuyDoi", "DonGia", "TongTien", "Thue", "ThucLinh", "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.FormatDataField(gridViewThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TongTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "Thue", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThucLinh", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
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

            #region Bac dao tao
            AppGridLookupEdit.InitGridLookUp(cboBacDaoTao, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboBacDaoTao, new string[] { "MaBacDaoTao", "TenBacDaoTao" }, new string[] { "Mã bậc đào tạo", "Tên bậc đào tạo" });
            cboBacDaoTao.Properties.ValueMember = "MaBacDaoTao";
            cboBacDaoTao.Properties.DisplayMember = "TenBacDaoTao";
            cboBacDaoTao.Properties.NullText = string.Empty;
            #endregion

            #region Init Khoa-DonVi
            cboKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoaDonVi.Properties.Items.Clear();

            _vListKhoaBoMon = DataServices.ViewKhoa.GetAll();

            if (_maTruong == "CTIM")
            {
                VList<ViewKhoa> v = _vListKhoaBoMon.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoa>;
                if (v.Count > 0)
                {
                    _vListKhoaBoMon = _vListKhoaBoMon.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoa>;
                }
                else
                    _vListKhoaBoMon = DataServices.ViewKhoa.GetAll();
            }

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoa v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaKhoa, v.TenKhoa, CheckState.Unchecked, true));
            }
            cboKhoaDonVi.Properties.Items.AddRange(_list.ToArray());
            cboKhoaDonVi.Properties.SeparatorChar = ';';
            cboKhoaDonVi.CheckAll();
            #endregion

            InitData();

        }
        #region InitData()
        void InitData()
        {
            cboBacDaoTao.DataBindings.Clear();
            bindingSourceBacDaoTao.DataSource = DataServices.ViewBacDaoTao.GetAll();
            cboBacDaoTao.DataBindings.Add("EditValue", bindingSourceBacDaoTao, "MaBacDaoTao", true, DataSourceUpdateMode.OnPropertyChanged);
            InitKhoaHoc();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboLanChot.EditValue != null && cboBacDaoTao.EditValue != null && cboKhoaHoc.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeTienGiangLyThuyetHopDongDaiHanCtim(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cboBacDaoTao.EditValue.ToString(), cboKhoaHoc.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                dt.Load(reader);
                DataColumn chon = new DataColumn("Chon", typeof(Boolean));
                dt.Columns.Add(chon);
                bindingSourceThongKe.DataSource = dt;
            }
        }

        void InitKhoaHoc()
        {
            if (cboBacDaoTao.EditValue != null)
            {
                cboKhoaHoc.Properties.SelectAllItemCaption = "Tất cả";
                cboKhoaHoc.Properties.TextEditStyle = TextEditStyles.Standard;
                cboKhoaHoc.Properties.Items.Clear();

                VList<ViewKhoaHocBacHe> _vListKHBH = new VList<ViewKhoaHocBacHe>();
                _vListKHBH = DataServices.ViewKhoaHocBacHe.GetByMaBacDaoTao(cboBacDaoTao.EditValue.ToString());
                List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
                foreach (ViewKhoaHocBacHe v in _vListKHBH)
                {
                    _list.Add(new CheckedListBoxItem(v.MaKhoaHoc, v.TenKhoaHoc, CheckState.Unchecked, true));
                }
                _list.Add(new CheckedListBoxItem("-1", "Lớp học phần chưa gắn khoá học", CheckState.Unchecked, true));
                cboKhoaHoc.Properties.Items.AddRange(_list.ToArray());
                cboKhoaHoc.Properties.SeparatorChar = ';';
                cboKhoaHoc.CheckAll();
            }
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

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboLanChot.EditValue != null && cboBacDaoTao.EditValue != null && cboKhoaHoc.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeTienGiangLyThuyetHopDongDaiHanCtim(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cboBacDaoTao.EditValue.ToString(), cboKhoaHoc.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                dt.Load(reader);
                DataColumn chon = new DataColumn("Chon", typeof(Boolean));
                dt.Columns.Add(chon);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["Chon"] = false;
                }
                bindingSourceThongKe.DataSource = dt;
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao;
            try
            {
                vListBaoCao = data.Select("Chon = 1").CopyToDataTable();
            }
            catch
            {
                XtraMessageBox.Show("Vui lòng chọn môn muốn in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                _ngayIn = frmChon.NgayIn;
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
            //    return;
//            int dem = vListBaoCao.Rows.Count;

          
            vListBaoCao.AcceptChanges();
          
            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeThanhToanTienGiangLyThuyetHDDH(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.Text, cboKhoaDonVi.Text
                        , PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.KeToan, PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.NguoiLapbieu
                        , cboKhoaHoc.Text, cboBacDaoTao.Text, PMS.Common.Globals._cauhinh.ChucVuBanGiamHieu, PMS.Common.Globals._cauhinh.ChucVuKeToan, PMS.Common.Globals._cauhinh.ChucVuDaoTao
                        , _ngayIn, vListBaoCao);
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

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            InitLanChot();
        }

        private void cboBacDaoTao_EditValueChanged(object sender, EventArgs e)
        {
            InitKhoaHoc();
        }

        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            DataTable tb = bindingSourceThongKe.DataSource as DataTable;
            if (checkEditChonTatCa.CheckState == CheckState.Checked)
            {
                foreach (DataRow r in tb.Rows)
                {
                    if (!r["XacNhanChiTra"].ToString().ToLower().Equals("true")) r["Chon"] = true;
                }
            }
            else
            {
                foreach (DataRow r in tb.Rows)
                {
                    r["Chon"] = 0;
                }
            }
            bindingSourceThongKe.DataSource = tb;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn lưu xác nhận thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    gridViewThongKe.FocusedRowHandle = -1;
                    DataTable tb = bindingSourceThongKe.DataSource as DataTable;
                    if (tb != null || tb.Rows.Count > 0)
                    {
                        string xmlData = "";
                        foreach (DataRow r in tb.Rows)
                        {
                            if (r.RowState == DataRowState.Modified)
                            {
                                xmlData += String.Format("<Input Id=\"{0}\" X=\"{1}\" D=\"{2}\" U=\"{3}\" />", r["Id"], r["XacNhanChiTra"], DateTime.Now, UserInfo.UserName);
                            }
                        }
                        xmlData = "<Root>" + xmlData + "</Root>";

                        int result = -1;

                        Cursor.Current = Cursors.WaitCursor;
                        DataServices.KetQuaThanhToanThuLao.XacNhanChiTra(xmlData, ref result);
                        Cursor.Current = Cursors.Default;

                        if (result == 0)
                        {
                            XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        btnLocDuLieu.PerformClick();
                    }
                }
                catch
                { }
            }
        }

        private void checkEditChonThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            DataTable tb = bindingSourceThongKe.DataSource as DataTable;
            if (checkEditChonThanhToan.CheckState == CheckState.Checked)
            {
                foreach (DataRow r in tb.Rows)
                {
                    r["XacNhanChiTra"] = 1;
                }
            }
            else
            {
                foreach (DataRow r in tb.Rows)
                {
                    r["XacNhanChiTra"] = 0;
                }
            }
            bindingSourceThongKe.DataSource = tb;
        }

        private void gridViewThongKe_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Chon")
                {
                    DataRowView v = gridViewThongKe.GetRow(e.RowHandle) as DataRowView;
                    if (e.Value.ToString().ToLower() == "true" && v["XacNhanChiTra"].ToString().ToLower() == "true")
                    {
                        XtraMessageBox.Show("Dòng dữ liệu đã khoá thanh toán, không cho phép in lại. Vui lòng liên hệ phòng đào tạo để biết thêm chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DevExpress.XtraGrid.Views.Base.ColumnView view = (DevExpress.XtraGrid.Views.Base.ColumnView)gridControlThongKe.KeyboardFocusView;
                        if (view.IsEditing)
                            view.HideEditor();
                        view.CancelUpdateCurrentRow();
                    }
                }
                else if (e.Column.FieldName == "XacNhanChiTra")
                {
                    DataRowView v = gridViewThongKe.GetRow(e.RowHandle) as DataRowView;
                    if (e.Value.ToString().ToLower() == "true" && v["Chon"].ToString().ToLower() == "true")
                    {
                        DevExpress.XtraGrid.Views.Base.ColumnView view = (DevExpress.XtraGrid.Views.Base.ColumnView)gridControlThongKe.KeyboardFocusView;
                        if (view.IsEditing)
                            view.HideEditor();
                        view.CancelUpdateCurrentRow();
                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }
    }
}
