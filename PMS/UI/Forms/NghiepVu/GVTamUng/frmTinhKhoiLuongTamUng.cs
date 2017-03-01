using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Common;
using DevExpress.XtraGrid.Views.Grid;

namespace PMS.UI.Forms.NghiepVu.GVTamUng
{
    public partial class frmTinhKhoiLuongTamUng : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnDongbo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDongbo.ShortCut = Shortcut.None;

                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnQuyDoi.ShortCut = Shortcut.None;

                btnChot.Enabled = false;
                btnHuyChot.Enabled = false;
            }
            else
            {
                btnDongbo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnChot.Enabled = true;
                btnHuyChot.Enabled = true;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion

        #region Event Form
        public frmTinhKhoiLuongTamUng()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmTinhKhoiLuongTamUng_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewKhoiLuongQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongQuyDoi, new string[] { "MaQuanLyGv", "HoTen", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
		                                                                , "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "HeSoNienCheTinChi", "HeSoTroCap", "SoTietThucTeQuyDoi", "MucThanhToan", "TietQuyDoi"  }
                                                         , new string[] { "Mã giảng viên", "Họ Tên", "Tên môn học", "Số tín chỉ", "Mã Lớp học phần", "Lớp sinh viên", "Số SV ĐK", "Loại học phần", "Bậc đào tạo", "Mã Khóa học"
                                                                        , "Hệ số công việc", "Hệ số bậc đào tạo", "Hệ số ngôn ngữ", "Hệ số chức danh", "Hệ số lớp đông", "Hệ số cơ sở", "Tiết dạy thực tế", "Hệ số niên chế-tín chỉ", "Hệ số cao học tính thêm", "Tiết thực tế quy đổi", "Mức thanh toán", "Tiết quy đổi"}
                                                         , new int[] { 140, 170, 150, 80, 100, 100, 100, 90, 80, 90, 100, 110, 110, 100, 90, 90, 120, 120, 90, 120, 90, 90 });
            AppGridView.AlignHeader(gridViewKhoiLuongQuyDoi, new string[] { "MaQuanLyGv", "HoTen", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "MaKhoaHoc"
		                                                                , "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietThucDay", "HeSoNienCheTinChi", "HeSoTroCap", "SoTietThucTeQuyDoi", "MucThanhToan", "TietQuyDoi"  }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewKhoiLuongQuyDoi, new string[] { "SoLuong", "LoaiHocPhan", "MaBacDaoTao", "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "HeSoNienCheTinChi", "HeSoTroCap", "MucThanhToan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "MaQuanLyGv", "Tổng: {0:n0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietThucDay", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "SoTietThucTeQuyDoi", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", "Tổng: {0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "HeSoNienCheTinChi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "HeSoTroCap", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewKhoiLuongQuyDoi, "SoTietThucTeQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongQuyDoi);
            AppGridView.FixedField(gridViewKhoiLuongQuyDoi, new string[] { "MaQuanLyGv", "HoTen" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            WordWrapHeader(gridViewKhoiLuongQuyDoi, 40);
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Hoc Ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã hoc kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

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

            InitData();
        }
        #endregion
      
        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }

            LoadDataSource();
        }

        void LoadDataSource()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboLoaiGiangVien.EditValue != null )
                {
                    DataTable dataTable = new DataTable();
                    IDataReader reader = DataServices.KhoiLuongTamUng.GetByNamHocHocKyLoaiGiangVien(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
                    dataTable.Load(reader);
                    bindingSourceKhoiLuongQuyDoi.DataSource = dataTable;
                }
                if (!_maTruong.Equals("LAW"))
                {
                    KiemTraChot();
                }
                Cursor.Current = Cursors.Default;
            }
            catch
            {
            }
        }

        void WordWrapHeader(GridView grid, int height)
        {
            for (int i = 0; i < grid.Columns.Count; i++)
                grid.Columns[i].AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            AutoHeightHelper a = new AutoHeightHelper(grid, height);
            a.EnableColumnPanelAutoHeight();
        }

        void KiemTraChot()
        {
            try
            {
                int _kiemTra = 0;
                DataServices.QuyDoiKhoiLuongTamUng.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref _kiemTra);

                if (_kiemTra == 1)//Đã chốt
                {
                    btnDongbo.Enabled = false;
                    btnQuyDoi.Enabled = false;
                    btnChot.Enabled = false;
                    btnHuyChot.Enabled = true;
                    lblGhiChu.Text = string.Format("Ghi chú: dữ liệu tạm ứng năm học {0} - {1} đã chốt.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
                else
                {
                    btnDongbo.Enabled = true;
                    btnQuyDoi.Enabled = true;
                    btnChot.Enabled = true;
                    btnHuyChot.Enabled = false;
                    lblGhiChu.Text = string.Empty;
                }
            }
            catch
            { }
           
        }
        #endregion

        #region Event Button
        private void btnDongbo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue.ToString() == "" || cboHocKy.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn năm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }
            int kiemTraDongBo = 0;
            DataServices.KhoiLuongTamUng.KiemTraDongBo(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kiemTraDongBo);
            if (kiemTraDongBo == 0)//Đã đồng bộ
                XtraMessageBox.Show(string.Format("Dữ liệu của năm học {0} - {1} đã được đồng bộ.\nLưu ý: nếu đồng bộ lại toàn bộ dữ liệu cũ của năm học {0} - {1} sẽ bị thay thế.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (XtraMessageBox.Show("Bạn có muốn đồng bộ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    using (frmXuLyDongBoDuLieu frm = new frmXuLyDongBoDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _maTruong, true))
                    {
                        frm.ShowDialog();
                    }

                    LoadDataSource();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Đã xãy ra lỗi trong quá trình đồng bộ." + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            gridViewKhoiLuongQuyDoi.FocusedRowHandle = -1;

            if (cboNamHoc.EditValue.ToString() == "" || cboHocKy.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn nằm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }

            using (frmXuLyQuyDoiGioiChuan frm = new frmXuLyQuyDoiGioiChuan(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _maTruong, true))
            {
                frm.ShowDialog();
            }

            LoadDataSource();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
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
                            gridControlKhoiLuongQuyDoi.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void btnChot_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tb = bindingSourceKhoiLuongQuyDoi.DataSource as DataTable;
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && tb.Rows.Count > 0)
                {
                    if (XtraMessageBox.Show(string.Format("Bạn muốn chốt dữ liệu tạm ứng năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int result = -1;
                        DataServices.QuyDoiKhoiLuongTamUng.Chot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref result);

                        if (result == 0)
                            XtraMessageBox.Show("Chốt dữ liệu tạm ứng thành công.");
                        else
                            XtraMessageBox.Show("Đã có lỗi trong quá trình chốt dữ liệu tạm ứng.");
                        if (!_maTruong.Equals("LAW"))
                        {
                            KiemTraChot();
                        }
                    }
                }
            }
            catch 
            { }
        }

        private void btnHuyChot_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tb = bindingSourceKhoiLuongQuyDoi.DataSource as DataTable;
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && tb.Rows.Count > 0)
                {
                    if (XtraMessageBox.Show(string.Format("Bạn muốn chốt dữ liệu tạm ứng năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int result = -1;
                        DataServices.QuyDoiKhoiLuongTamUng.HuyChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref result);

                        if (result == 0)
                            XtraMessageBox.Show("Chốt dữ liệu tạm ứng thành công.");
                        else
                            if (result == 1)
                                XtraMessageBox.Show("Không được phép huỷ chốt vì đã thanh toán tạm ứng cho giảng viên.");
                            else XtraMessageBox.Show("Đã có lỗi trong quá trình chốt dữ liệu tạm ứng.");
                        if (!_maTruong.Equals("LAW"))
                        {
                            KiemTraChot();
                        }
                    }
                }
            }
            catch
            { }
        }
        #endregion

        #region Event Grid
        private void gridViewKhoiLuongQuyDoi_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (_maTruong == "LAW")
                {
                    if (e.Column.FieldName == "HeSoNienCheTinChi")
                    {
                        if (Convert.ToDouble(e.Value) == 1.111111)
                            e.DisplayText = "50/45";
                    }

                    if (e.Column.FieldName == "HeSoTroCap")
                    {
                        if (Convert.ToDouble(e.Value) == 1.333333)
                            e.DisplayText = "20/15";
                    }
                }
            }
            catch
            { }
           
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            LoadDataSource();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void cboLoaiGiangVien_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }
        #endregion

        
    }
}