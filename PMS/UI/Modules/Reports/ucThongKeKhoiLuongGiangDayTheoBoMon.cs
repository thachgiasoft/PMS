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

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeKhoiLuongGiangDayTheoBoMon : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        DateTime _ngayIn;
        #endregion

        #region EventGrid
        public ucThongKeKhoiLuongGiangDayTheoBoMon()
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

        private void ucThongKeKhoiLuongGiangDayTheoBoMon_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewThongKe, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "HoTen", "TenHocVi", "MaQuanLy", "SoTietNghiaVu", "TietQuyDoiDaiTra", "TietQuyDoiClc", "TietThucDayDaiTra", "TietThucDayClc", "TenBoMon", "TenKhoa" }
                            , new string[] { "STT", "Họ tên", "Học vị", "Mã giảng viên", "Tiết nghĩa vụ", "Tiết quy đổi đại trà", "Tiết quy đổi CLC", "Tiết đại trà chưa quy đổi", "Tiết CLC chưa quy đổi", "Bộ môn", "Khoa" }
                            , new int[] { 45, 160, 110, 90, 90, 120, 120, 120, 120, 99, 99 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "HoTen", "TenHocVi", "MaQuanLy", "SoTietNghiaVu", "TietQuyDoiDaiTra", "TietQuyDoiClc", "TietThucDayDaiTra", "TietThucDayClc", "TenBoMon", "TenKhoa" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.SummaryField(gridViewThongKe, "HoTen", "{0}", DevExpress.Data.SummaryItemType.Count);
            gridViewThongKe.Columns["TenKhoa"].GroupIndex = 0;
            gridViewThongKe.Columns["TenBoMon"].GroupIndex = 1;
            //PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 45);
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

            InitData();
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            InitLanChot();

            InitKhoa();

            InitBoMon();
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

        void InitKhoa()
        {
            #region Init Khoa-DonVi
            cboKhoa.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoa.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoa.Properties.Items.Clear();

            DataTable _vListKhoaBoMon = new DataTable();
            IDataReader reader = DataServices.ViewKhoa.GetAllKhoa();
            _vListKhoaBoMon.Load(reader);

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (DataRow v in _vListKhoaBoMon.Rows)
            {
                _list.Add(new CheckedListBoxItem(v["MaKhoa"].ToString(), v["TenKhoa"].ToString(), CheckState.Unchecked, true));
            }
            cboKhoa.Properties.Items.AddRange(_list.ToArray());
            cboKhoa.Properties.SeparatorChar = ';';
            cboKhoa.CheckAll();
            #endregion
        }

        void InitBoMon()
        {
            if (cboKhoa.EditValue != null)
            {
                cboBoMon.Properties.SelectAllItemCaption = "Tất cả";
                cboBoMon.Properties.TextEditStyle = TextEditStyles.Standard;
                cboBoMon.Properties.Items.Clear();

                DataTable _vListKhoaBoMon = new DataTable();
                IDataReader reader = DataServices.ViewKhoa.GetBoMonByKhoa(cboKhoa.EditValue.ToString());
                _vListKhoaBoMon.Load(reader);

                List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
                foreach (DataRow v in _vListKhoaBoMon.Rows)
                {
                    _list.Add(new CheckedListBoxItem(v["MaBoMon"].ToString(), v["TenBoMon"].ToString(), CheckState.Unchecked, true));
                }
                cboBoMon.Properties.Items.AddRange(_list.ToArray());
                cboBoMon.Properties.SeparatorChar = ';';
                cboBoMon.CheckAll();
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

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboBoMon.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeKhoiLuongGiangDayTheoBoMon(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboBoMon.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;
                gridViewThongKe.ExpandAllGroups();
                gridViewThongKe.BestFitColumns();
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

  
            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeKhoiLuongGiangDayTheoBoMon(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                        ,_ngayIn, vListBaoCao);
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
                    sf.ShowDialog();
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

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.EditValue.ToString().ToLower() == "true")
                gridViewThongKe.ActiveFilterString = null;
            else
                gridViewThongKe.ActiveFilterString = "SoTietNghiaVu > 0 or TietThucDayDaiTra > 0 or TietThucDayClc > 0";
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
        }

        private void cboKhoa_EditValueChanged(object sender, EventArgs e)
        {
            InitBoMon();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            InitLanChot();
        }
    }
}
