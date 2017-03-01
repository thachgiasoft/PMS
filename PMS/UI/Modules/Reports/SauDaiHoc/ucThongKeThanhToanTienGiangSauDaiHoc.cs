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
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Modules.Reports.SauDaiHoc
{
    public partial class ucThongKeThanhToanTienGiangSauDaiHoc : DevExpress.XtraEditors.XtraUserControl
    {

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        DateTime _ngayIn;
        DataTable tblNganh = new DataTable();
        #endregion

        public ucThongKeThanhToanTienGiangSauDaiHoc()
        {
            InitializeComponent();
        }

        private void ucThongKeThanhToanTienGiangSauDaiHoc_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewThongKe, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTenDayDu", "TenMonHoc", "MaNganh", "TietThucDay", "HeSoLopDong", "SiSo", "ThuLaoTrenTiet", "ThanhTien", "TienChamBai", "TongCong", "ThueTncn", "ThucNhan", "MaSoThue", "SoTaiKhoan", "ChiNhanhNganHang" }
                , new string[] { "STT", "Mã giảng viên", "Cán bộ giảng dạy", "Môn học", "Ngành", "Số tiết", "Hệ số", "Số học viên", "Thù lao/tiết", "Thành tiền", "Chấm bài", "Tổng", "10% thuế TNCN", "Thực nhận", "Mã số thuê", "Số tài khoản", "Ngân hàng" }
                , new int[] { 40, 70, 150, 170, 90, 60, 60, 60, 70, 80, 80, 80, 80, 80, 90, 100, 120 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTenDayDu", "TenMonHoc", "MaNganh", "TietThucDay", "HeSoLopDong", "SiSo", "ThuLaoTrenTiet", "ThanhTien", "TienChamBai", "TongCong", "ThueTncn", "ThucNhan", "MaSoThue", "SoTaiKhoan", "ChiNhanhNganHang" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, "ThuLaoTrenTiet", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienChamBai", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TongCong", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThueTncn", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThucNhan", DevExpress.Utils.FormatType.Custom, "n0");
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

            #region LoaiGiangVien
            AppGridLookupEdit.InitGridLookUp(cboLoaiGiangVien, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiGiangVien, new string[] { "MaQuanLy", "TenLoaiGiangVien" }, new string[] { "Mã loại giảng viên", "Tên loại giảng viên" });
            cboLoaiGiangVien.Properties.ValueMember = "MaLoaiGiangVien";
            cboLoaiGiangVien.Properties.DisplayMember = "TenLoaiGiangVien";
            cboLoaiGiangVien.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }

            InitLanChot();

            cboLoaiGiangVien.DataBindings.Clear();
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            cboLoaiGiangVien.DataBindings.Add("EditValue", bindingSourceLoaiGiangVien, "MaLoaiGiangVien", true, DataSourceUpdateMode.OnPropertyChanged);

            InitKhoa();

            InitNganh();
        }

        void InitLanChot()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                lanchot = 0;
                cboLanChot.DataBindings.Clear();
                DataServices.SdhKetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
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

        void InitKhoa()
        {
            try
            {
                cboKhoa.Properties.SelectAllItemCaption = "Tất cả";
                cboKhoa.Properties.TextEditStyle = TextEditStyles.Standard;
                cboKhoa.Properties.Items.Clear();
                VList<ViewKhoaHoc> tblKhoa = DataServices.ViewKhoaHoc.GetByMaBacDaoTao("CH") as VList<ViewKhoaHoc>;
                List<CheckedListBoxItem> _listKhoaHoc = new List<CheckedListBoxItem>();
                foreach (ViewKhoaHoc r in tblKhoa)
                {
                    _listKhoaHoc.Add(new CheckedListBoxItem(r.MaKhoaHoc, r.TenKhoaHoc, CheckState.Unchecked, true));
                }
                cboKhoa.Properties.Items.AddRange(_listKhoaHoc.ToArray());
                cboKhoa.Properties.Items.Add(new CheckedListBoxItem("-1", "Lớp học phần chưa gắn khoá học", CheckState.Unchecked, true));
                cboKhoa.Properties.SeparatorChar = ';';
                cboKhoa.CheckAll();
            }
            catch
            {}
        }

        void InitNganh()
        {
            if (cboKhoa.EditValue != null)
            {
                cboNganh.Properties.SelectAllItemCaption = "Tất cả";
                cboNganh.Properties.TextEditStyle = TextEditStyles.Standard;
                cboNganh.Properties.Items.Clear();
                try
                {
                    IDataReader reader = DataServices.ViewKhoaHoc.GetNganhByMaKhoaHoc(cboKhoa.EditValue.ToString(), "CH");
                    tblNganh.Load(reader);
                    List<CheckedListBoxItem> _listNganh = new List<CheckedListBoxItem>();
                    foreach (DataRow r in tblNganh.Rows)
                    {
                        _listNganh.Add(new CheckedListBoxItem(r["MaNganh"].ToString(), r["TenNganh"].ToString(), CheckState.Unchecked, true));
                    }
                    cboNganh.Properties.Items.AddRange(_listNganh.ToArray());
                }
                catch
                { }
                cboNganh.Properties.Items.Add(new CheckedListBoxItem("-1", "Lớp học phần chưa gắn ngành học", CheckState.Unchecked, true));
                cboNganh.Properties.SeparatorChar = ';';
                cboNganh.CheckAll();
            }

        }
        #endregion

        #region Event button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoa.EditValue != null && cboNganh.EditValue != null && cboLoaiGiangVien.EditValue != null && cboLanChot.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.SdhKetQuaThanhToanThuLao.ThongKeThanhToanChiTietSauDaiHoc(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoa.EditValue.ToString(), cboNganh.EditValue.ToString(), int.Parse(cboLoaiGiangVien.EditValue.ToString()), int.Parse(cboLanChot.EditValue.ToString()));
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;
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


            //string ma
            //foreach (CheckedListBoxItem item in cboNganh.Properties.Items)
            //{ 
            //    if(item.CheckState == CheckState.Checked)
                    
            //}
            DataRow[] tblNganhVietTat = tblNganh.Select(String.Format("MaNganh in ({0})", cboNganh.EditValue.ToString().Replace(";", ",")));
            string _nganhVietTat = "", _khoa = cboKhoa.Text;
            foreach (DataRow r in tblNganhVietTat)
            {
                _nganhVietTat += r["VietTat"] + ", ";    
            }

            _nganhVietTat = _nganhVietTat.Substring(0, _nganhVietTat.Length - 2);

            if (cboKhoa.Text.Substring(cboKhoa.Text.Length - 1) == ";")
                _khoa = cboKhoa.Text.Substring(0, cboKhoa.Text.Length - 1);

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    if (cboLoaiGiangVien.EditValue.ToString() == "13")//Cơ hữu
                    {
                        frm.InThongKeThanhToanThuLaoChiTietGVCoHuu_SDH(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.Text
                            , cboLoaiGiangVien.Text, _khoa, _nganhVietTat, UserInfo.FullName
                            , "", "", _ngayIn, vListBaoCao);
                    }
                    else
                    {
                        frm.InThongKeThanhToanThuLaoChiTietGVThinhGiang_SDH(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.Text
                            , cboLoaiGiangVien.Text, _khoa, _nganhVietTat, UserInfo.FullName
                            , "", "", _ngayIn, vListBaoCao);
                    }
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
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
                            gridControlThongKe.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
        #endregion

        #region Event Cbo
        private void cboLoaiGiangVien_EditValueChanged(object sender, EventArgs e)
        {
            if (cboLoaiGiangVien.EditValue.ToString() == "13")
            {
                AppGridView.HideField(gridViewThongKe, new string[] { "ThueTncn", "ThucNhan", "MaSoThue", "SoTaiKhoan", "ChiNhanhNganHang" });
            }
            else
            {
                foreach (GridColumn col in gridViewThongKe.Columns)
                    col.Visible = true;
            }
        }

        private void cboKhoa_EditValueChanged(object sender, EventArgs e)
        {
            //InitNganh();
        }
        #endregion
    }
}
