using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using PMS.BLL;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.BaoCao;
using DevExpress.Common.Grid;

namespace PMS.UI.Modules.Reports
{
    public partial class ucTongHopGioGiangTheoKhoa_HBU : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        #endregion

        public ucTongHopGioGiangTheoKhoa_HBU()
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            //    return;
//            int dem = vListBaoCao.Rows.Count;

            //DataTable temp = new DataTable();
            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InBangTongHopGioGiangTheoKhoa_HBU(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                        , PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.NguoiLapbieu
                        , DateTime.Now, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void ucTongHopGioGiangTheoKhoa_HBU_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "HocHam", "HocVi", "DinhMucGioChuanGiangDay", "DinhMucNghienCuuKhoaHoc", "DinhMucCacNhiemVuKhac", "TieuChuanMienGiam", "SoGioMienGiam", "SoGioPhaiGiang", "SoGioGiangDay", "SoGioNckh", "SoGioKhac", "TongSoGio", "VuotGio", "GhiChu" }
                    , new string[] { "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Định mức giờ chuẩn giảng dạy", "Định mức nghiên cứu khoa học", "Định mức các nhiệm vụ khác", "Tiêu chuẩn miễn giảm", "Số giờ miễn giảm", "Số giờ phải giảng", "Số giờ giảng dạy", "Số giờ NCKH", "Số giờ hoạt động khác", "Tổng số giờ thực hiện", "Vượt giờ", "Ghi chú" }
                    , new int[] { 70, 150, 100, 100, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 100 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "HocHam", "HocVi", "DinhMucGioChuanGiangDay", "DinhMucNghienCuuKhoaHoc", "DinhMucCacNhiemVuKhac", "TieuChuanMienGiam", "SoGioMienGiam", "SoGioPhaiGiang", "SoGioGiangDay", "SoGioNckh", "SoGioKhac", "TongSoGio", "VuotGio", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, "DinhMucGioChuanGiangDay", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "DinhMucNghienCuuKhoaHoc", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "DinhMucCacNhiemVuKhac", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "SoGioMienGiam", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "SoGioPhaiGiang", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "SoGioGiangDay", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "SoGioNckh", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "SoGioKhac", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "TongSoGio", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewThongKe, "VuotGio", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 50);
            AppGridView.FixedField(gridViewThongKe, new string[] { "MaQuanLy", "HoTen" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
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

            VList<ViewKhoa> _vListKhoaBoMon = new VList<ViewKhoa>();
            _vListKhoaBoMon = DataServices.ViewKhoa.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoa v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaKhoa, v.TenKhoa, CheckState.Unchecked, true));
            }
            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
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

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null)
            {
                try
                {
                    DataTable dt = new DataTable();
                    IDataReader reader = DataServices.KetQuaThanhToanThuLao.BangTongHopGioGiangTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                    dt.Load(reader);
                    bindingSourceThongKe.DataSource = dt;
                }
                catch
                {  }
            }
            gridViewThongKe.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
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
    }
}
