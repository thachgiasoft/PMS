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
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;
using PMS.BLL;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThanhToanThuLaoCoiThi : DevExpress.XtraEditors.XtraUserControl
    {
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        string _maTruong;
        public ucThanhToanThuLaoCoiThi()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucThanhToanThuLaoCoiThi_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaGiangVienQuanLy", "HoTen", "TenDonVi", "MaLop", "LanThi", "TenMonHoc", "SoBaiGiuaKy", "SoBaiQuaTrinh", "SoBaiCuoiKy", "DonGiaCuoiKy", "TienGiuaKy", "TienQuaTrinh", "TienCuoiKy", "TongCong", "TongTienGv" }
                , new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Lớp", "Lần thi", "Môn học", "Số bài giữa kỳ", "Số bài quá trình", "Số bài cuối kỳ", "Đơn giá cuối kỳ", "Tiền giữa kỳ", "Tiền quá trình", "Tiền cuối kỳ", "Cộng", "Tổng cộng" }
                    , new int[] { 90, 150, 150, 80, 60, 150, 100, 100, 100, 100, 100, 100, 100, 100, 100 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaGiangVienQuanLy", "HoTen", "TenDonVi", "MaLop", "LanThi", "TenMonHoc", "SoBaiGiuaKy", "SoBaiQuaTrinh", "SoBaiCuoiKy", "DonGiaCuoiKy", "TienGiuaKy", "TienQuaTrinh", "TienCuoiKy", "TongCong", "TongTienGv" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaGiangVienQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, "DonGiaCuoiKy", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienGiuaKy", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienQuaTrinh", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienCuoiKy", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TongCong", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TongTienGv", DevExpress.Utils.FormatType.Custom, "n0");
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

            #region Init Khoa-DonVi
            cboKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoaDonVi.Properties.Items.Clear();

            VList<ViewKhoa> _vListKhoaBoMon = new VList<ViewKhoa>();
            _vListKhoaBoMon = DataServices.ViewKhoa.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoa v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaKhoa, v.TenKhoa, CheckState.Unchecked, true));
            }
            cboKhoaDonVi.Properties.Items.AddRange(_list.ToArray());
            cboKhoaDonVi.Properties.SeparatorChar = ';';
            cboKhoaDonVi.CheckAll();
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

            #region Dot thanh toan
            AppGridLookupEdit.InitGridLookUp(cboDotThanhToan, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDotThanhToan, new string[] { "MaDot", "TenDot" }, new string[] { "Mã đợt thanh toán", "Tên đợt thanh toán" });
            cboDotThanhToan.Properties.ValueMember = "MaDot";
            cboDotThanhToan.Properties.DisplayMember = "TenDot";
            cboDotThanhToan.Properties.NullText = string.Empty;
            #endregion
            InitData();
        }

        void InitData()
        {
            try
            {
                bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    cboDotThanhToan.DataBindings.Clear();
                    bindingSourceDotThanhToan.DataSource = DataServices.ThuLaoCoiThi.GetDotThanhToanByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    cboDotThanhToan.DataBindings.Add("EditValue", bindingSourceDotThanhToan, "MaDot", true, DataSourceUpdateMode.OnPropertyChanged);
                }
                //if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null && cboDotThanhToan.EditValue != null)
                //{
                //    DataTable tb = new DataTable();
                //    IDataReader reader = DataServices.ThuLaoChamBai.GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), cboDotThanhToan.EditValue.ToString());
                //    tb.Load(reader);
                //    bindingSourceThongKe.DataSource = tb;
                //}
            }
            catch
            { }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null && cboDotThanhToan.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ThuLaoCoiThi.GetByNamHocHocKyKhoaLoaiGiangVienDotThanhToan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), cboDotThanhToan.EditValue.ToString());
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;
            }
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

            //DataView dv;
            //try
            //{
            //    dv = new DataView(vListBaoCao, filter, sort, DataViewRowState.CurrentRows);
            //}
            //catch
            //{
            //    dv = new DataView(vListBaoCao, "", sort, DataViewRowState.CurrentRows);
            //}
            //vListBaoCao = dv.ToTable();
            //if (vListBaoCao == null)
            //    return;

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeThanhToanThuLaoChamBai(PMS.Common.Globals._cauhinh.TenTruong, _maTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                        , cboLoaiGiangVien.EditValue.ToString(), PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.KeToan
                        , "", UserInfo.FullName, _ngayIn, vListBaoCao);
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

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    cboDotThanhToan.DataBindings.Clear();

                    bindingSourceDotThanhToan.DataSource = DataServices.ThuLaoCoiThi.GetDotThanhToanByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    cboDotThanhToan.DataBindings.Add("EditValue", bindingSourceDotThanhToan, "MaDot", true, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
            catch
            { }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    cboDotThanhToan.DataBindings.Clear();
                    bindingSourceDotThanhToan.DataSource = DataServices.ThuLaoCoiThi.GetDotThanhToanByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    cboDotThanhToan.DataBindings.Add("EditValue", bindingSourceDotThanhToan, "MaDot", true, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
            catch
            { }
        }
    }
}
