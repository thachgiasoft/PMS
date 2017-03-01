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
    public partial class ucBangKeGioGiang_BUH : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        string _maTruong;
        DateTime _ngayIn;

        DataTable dtData;

        #endregion

        public ucBangKeGioGiang_BUH()
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

        private void ucBangKeGioGiang_BUH_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "TenBoMon", "TietThucDay_01", "TietQuyDoi_01", "SoTietThucHienNckhHk01", "DinhMucGioGiang_01", "DinhMucNCKH_01", "TongDM_01", "GiamDinhMuc_01", "SoTietVuotGio_HK01", "GhiChu_01", "TietThucDay_02", "TietQuyDoi_02", "SoTietThucHienNckhHk02", "DinhMucGioGiang_02", "DinhMucNCKH_02", "TongDM_02", "GiamDinhMuc_02", "SoTietVuotGio_HK02", "GhiChu_02" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", ":", "Tiết thực dạy HK1", "Tiết quy đổi HK01", "Tiết thực hiện NCKH HK01", "ĐM giờ giảng HK01", "ĐM NCKH HK01", "Tổng ĐM HK01", "Giảm ĐM HK01", "Số tiết vượt HK01", "Ghi chú HK01", "Tiết thực dạy HK02", "Tiết quy đổi HK02", "Tiết thực hiện NCKH HK02", "ĐM giờ giảng HK02", "ĐM NCKH HK02", "Tổng ĐM HK02", "Giảm ĐM HK02", "Số tiết vượt HK02", "Ghi chú HK02" }
                    , new int[] { 70, 120, 60, 150, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "TenBoMon", "TietThucDay_01", "TietQuyDoi_01", "SoTietThucHienNckhHk01", "DinhMucGioGiang_01", "DinhMucNCKH_01", "TongDM_01", "GiamDinhMuc_01", "SoTietVuotGio_HK01", "GhiChu_01", "TietThucDay_02", "TietQuyDoi_02", "SoTietThucHienNckhHk02", "DinhMucGioGiang_02", "DinhMucNCKH_02", "TongDM_02", "GiamDinhMuc_02", "SoTietVuotGio_HK02", "GhiChu_02" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewThongKe, new string[] { "MaQuanLy" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 40);
            //AppGridView.FormatDataField(gridViewThongKe, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            //AppGridView.FormatDataField(gridViewThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "ThueTncn", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "SoTienThanhToan", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "TienViet", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "TienPhoTo", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "SoTienDuocNhan", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewThongKe, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");

            gridViewThongKe.Columns["TenBoMon"].GroupIndex = 0;


            #endregion
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
    
            #region _lanChot HK01
            AppGridLookupEdit.InitGridLookUp(cboLanChotHK01, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChotHK01, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChotHK01.Properties.ValueMember = "LanChot";
            cboLanChotHK01.Properties.DisplayMember = "LanChot";
            cboLanChotHK01.Properties.NullText = string.Empty;
            #endregion

            #region _lanChot HK02
            AppGridLookupEdit.InitGridLookUp(cboLanChotHK02, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChotHK02, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChotHK02.Properties.ValueMember = "LanChot";
            cboLanChotHK02.Properties.DisplayMember = "LanChot";
            cboLanChotHK02.Properties.NullText = string.Empty;
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
            InitData();
        }

        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChotHK01();
            InitLanChotHK02();
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null)
            {
                int _lanChotHK01, _lanChotHK02;
                if (cboLanChotHK01.EditValue == null)
                    _lanChotHK01 = 0;
                else _lanChotHK01 = int.Parse(cboLanChotHK01.EditValue.ToString());

                if (cboLanChotHK02.EditValue == null)
                    _lanChotHK02 = 0;
                else _lanChotHK02 = int.Parse(cboLanChotHK02.EditValue.ToString());

                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVien.ThongKeGioGiangBuh(cboNamHoc.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), _lanChotHK01, _lanChotHK02);
                dt.Load(reader);

                bindingSourceThongKe.DataSource = dt;
            }
            gridViewThongKe.ExpandAllGroups();
        }

        void InitLanChotHK01()
        {
            if (cboNamHoc.EditValue != null )
            {
                cboLanChotHK01.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), "HK01", ref lanchot);
                DataTable tblLanChot = new DataTable();
                tblLanChot.Columns.Add("LanChot");
                if (lanchot > 0)
                {
                    for (int i = lanchot; i >= 1; i--)
                    {
                        tblLanChot.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChotHK01.DataSource = tblLanChot;
                cboLanChotHK01.DataBindings.Add("EditValue", bindingSourceLanChotHK01, "LanChot", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        
        void InitLanChotHK02()
        {
            if (cboNamHoc.EditValue != null )
            {
                cboLanChotHK02.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), "HK02", ref lanchot);
                DataTable tblLanChot = new DataTable();
                tblLanChot.Columns.Add("LanChot");
                if (lanchot > 0)
                {
                    for (int i = lanchot; i >= 1; i--)
                    {
                        tblLanChot.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChotHK02.DataSource = tblLanChot;
                cboLanChotHK02.DataBindings.Add("EditValue", bindingSourceLanChotHK02, "LanChot", true, DataSourceUpdateMode.OnPropertyChanged);
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

            Cursor.Current = Cursors.WaitCursor;

            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                _ngayIn = frmChon.NgayIn;
            }

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

            ////string filter = gridViewThongKe.ActiveFilterString;
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

            ////string filter = gridViewHopDongMoiGiangVien.ActiveFilterString;
            ////vListBaoCao = dv.ToTable();
            ////if (vListBaoCao == null)
            //    return;

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InBangKeGioGiangBUH(cboNamHoc.EditValue.ToString(), _ngayIn, vListBaoCao);
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

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null)
            {
                int _lanChotHK01, _lanChotHK02;
                if (cboLanChotHK01.EditValue == null)
                    _lanChotHK01 = 0;
                else _lanChotHK01 = int.Parse(cboLanChotHK01.EditValue.ToString());

                if (cboLanChotHK02.EditValue == null)
                    _lanChotHK02 = 0;
                else _lanChotHK02 = int.Parse(cboLanChotHK02.EditValue.ToString());

                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVien.ThongKeGioGiangBuh(cboNamHoc.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), _lanChotHK01, _lanChotHK02);
                dt.Load(reader);

                bindingSourceThongKe.DataSource = dt;
            }
            gridViewThongKe.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChotHK01();
            InitLanChotHK02();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

 

    }
}
