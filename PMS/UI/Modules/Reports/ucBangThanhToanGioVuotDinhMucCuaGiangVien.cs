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

namespace PMS.UI.Modules.Reports
{
    public partial class ucBangThanhToanGioVuotDinhMucCuaGiangVien : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        DateTime _ngayIn;
        #endregion

        public ucBangThanhToanGioVuotDinhMucCuaGiangVien()
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

        private void ucBangThanhToanGioVuotDinhMucCuaGiangVien_Load(object sender, EventArgs e)
        {

            #region Init GirdView
            AppGridView.InitGridView(gridViewBangThanhToanGioVuotDinhMuc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewBangThanhToanGioVuotDinhMuc, new string[] { "MaQuanLy", "Ho", "Ten", "TenBoMon","TenChucVu", "SoGioChuanDinhMucCuaGv", "SoGioGvThucHienTrongHocKyDo", "SoGioCongTacKhac","SoGioVuotDinhMuc", "HeSoThanhToan", "SoTienThanhToanGioVuotDinhMuc" }
                                                       , new string[] { "Mã giảng viên", "Họ", "Tên", "Khoa - đơn vị", "Chức vụ", "Số giờ chuẩn định mức", "Số giờ giảng viên thực hiện", "Số giờ công tác khác", "Số giờ vượt định mức", "Hệ số thanh toán", "Số tiền thanh toán vượt định mức" }
                                                       , new int[] { 90, 100, 70, 150,120, 130, 130, 130,130, 130, 130 });
            AppGridView.AlignHeader(gridViewBangThanhToanGioVuotDinhMuc, new string[] { "MaQuanLy", "Ho", "Ten", "TenBoMon", "TenChucVu", "SoGioChuanDinhMucCuaGv", "SoGioGvThucHienTrongHocKyDo", "SoGioCongTacKhac", "SoGioVuotDinhMuc", "HeSoThanhToan", "SoTienThanhToanGioVuotDinhMuc" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.SummaryField(gridViewBangThanhToanGioVuotDinhMuc, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);

            AppGridView.FormatDataField(gridViewBangThanhToanGioVuotDinhMuc, "SoGioChuanDinhMucCuaGv", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewBangThanhToanGioVuotDinhMuc, "SoGioGvThucHienTrongHocKyDo", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewBangThanhToanGioVuotDinhMuc, "SoGioVuotDinhMuc", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewBangThanhToanGioVuotDinhMuc, "SoTienThanhToanGioVuotDinhMuc", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewBangThanhToanGioVuotDinhMuc, "SoGioCongTacKhac", DevExpress.Utils.FormatType.Custom, "n2");

            AppGridView.ReadOnlyColumn(gridViewBangThanhToanGioVuotDinhMuc);

            gridViewBangThanhToanGioVuotDinhMuc.GroupPanelText = "Gom nhóm bằng cách kéo tên cột thả vào đây";
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(gridLookUpEditNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(gridLookUpEditNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            gridLookUpEditNamHoc.Properties.ValueMember = "NamHoc";
            gridLookUpEditNamHoc.Properties.DisplayMember = "NamHoc";
            gridLookUpEditNamHoc.Properties.NullText = string.Empty;
            gridLookUpEditNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(gridLookUpEditHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(gridLookUpEditHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            gridLookUpEditHocKy.Properties.ValueMember = "MaHocKy";
            gridLookUpEditHocKy.Properties.DisplayMember = "TenHocKy";
            gridLookUpEditHocKy.Properties.NullText = string.Empty;
            gridLookUpEditHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
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

            TList<LoaiGiangVien> _tListLoaiGiangVien = new TList<LoaiGiangVien>();
            _tListLoaiGiangVien = DataServices.LoaiGiangVien.GetAll();

            List<CheckedListBoxItem> _listLGV = new List<CheckedListBoxItem>();
            foreach (LoaiGiangVien t in _tListLoaiGiangVien)
            {
                _listLGV.Add(new CheckedListBoxItem(t.MaLoaiGiangVien, t.TenLoaiGiangVien, CheckState.Unchecked, true));
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
            if (gridLookUpEditNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(gridLookUpEditNamHoc.EditValue.ToString());

            if (gridLookUpEditNamHoc.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVien.GioDinhMucCuaGiangVien(gridLookUpEditNamHoc.EditValue.ToString(), gridLookUpEditHocKy.EditValue.ToString(),  cboKhoaDonVi.EditValue.ToString(),cboLoaiGiangVien.EditValue.ToString());
                dt.Load(reader);
                bindingSourceBangThanhToan.DataSource = dt;
            }
            gridViewBangThanhToanGioVuotDinhMuc.ExpandAllGroups();
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
            if (gridLookUpEditNamHoc.EditValue != null && gridLookUpEditHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVien.GioDinhMucCuaGiangVien(gridLookUpEditNamHoc.EditValue.ToString(), gridLookUpEditHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
                dt.Load(reader);
                bindingSourceBangThanhToan.DataSource = dt;
            }
            gridViewBangThanhToanGioVuotDinhMuc.ExpandAllGroups();
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
                        gridControlBangThanhToanGioVuotDinhMuc.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                _ngayIn = frmChon.NgayIn;
            }

            Cursor.Current = Cursors.WaitCursor;
            gridViewBangThanhToanGioVuotDinhMuc.FocusedRowHandle = -1;
            bindingSourceBangThanhToan.EndEdit();
            DataTable data = bindingSourceBangThanhToan.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;

            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewBangThanhToanGioVuotDinhMuc, bindingSourceBangThanhToan);

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InBangThanhToanGioVuotDinhMucCuaGiangVien(PMS.Common.Globals._cauhinh.TenTruong, gridLookUpEditNamHoc.EditValue.ToString(), gridLookUpEditHocKy.EditValue.ToString()
                        , PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.NguoiLapbieu, _ngayIn
                        , vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void gridLookUpEditNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (gridLookUpEditNamHoc.EditValue != null)
            bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(gridLookUpEditNamHoc.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void gridLookUpEditHocKy_EditValueChanged(object sender, EventArgs e)
        {
        }
    }
}
