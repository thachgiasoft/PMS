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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using PMS.UI.Forms.NghiepVu;
using PMS.Services;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucTietNghiaVuTheoNamHocHocKy_UTE : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;


                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        #endregion

        public ucTietNghiaVuTheoNamHocHocKy_UTE()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucTietNghiaVuTheoNamHocHocKy_UTE_Load(object sender, EventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }

            #region Init GridView
            AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "MaQuanLy", "SoHieuCongChuc", "HoTen", "TenLoaiGiangVien", "TenHocHamHrm", "TenHocHam", "TenHocViHrm", "TenHocVi", "TenBoMon", "TenKhoa", "TenChucVuHrm", "TenChucVu", "DinhMucToiThieu", "DinhMucCaNam", "DinhMucHocKy", "TenTinhTrangHrm", "TenTinhTrang", "TinhTrangCongViec", "TuNgay", "DenNgay", "TietGioiHan", "MienGiamPhanTramNghiaVu", "DinhMucSauGiamTru", "TietNghiaVuBoSung", "TietNghiaVuThucHien", "GhiChu2", "MaGiangVien", "GhiChu", "MaHocHam", "MaHocVi", "Huong85PhanTram", "TenChucDanh", "TenLoaiNhanSu", "TenNgachLuong", "TenLoaiNhanVien", "TienCanTren", "BiChan", "CoGiangDay" }
                    , new string[] { "Mã giảng viên", "Số hiệu công chức", "Họ và tên", "Loại giảng viên", "Học hàm HRM", "Học hàm", "Học vị HRM", "Học vị", "Bộ môn", "Khoa", "Chức vụ HRM", "Chức vụ", "Phần trăm chức vụ", "Định mức cả năm", "Định mức học kỳ", "Tình trạng HRM", "Tình trạng", "Tình trạng công việc", "Từ ngày", "Đến ngày", "Số tiết giới hạn", "Phần trăm miễn giảm nghĩa vụ", "Tiết nghĩa vụ sau giảm trừ", "Tiết nghĩa vụ bổ sung", "Tiết nghĩa vụ thực hiện", "Ghi chú", "Mã giảng viên", "Cột để tô màu", "MaHocHam", "MaHocVi", "Hưởng 85% lương", "Chức danh HRM", "Loại nhân sự HRM", "Ngạch lương HRM", "Loại nhân sự PMS", "Tiền tối đa", "Bị chặn", "Có giảng dạy" }
                    , new int[] { 90, 80, 140, 90, 90, 90, 90, 90, 120, 120, 90, 90, 80, 80, 80, 80, 90, 90, 90, 90, 80, 80, 90, 90, 90, 100, 99, 99, 99, 99, 90, 90, 90, 90, 90, 90, 50, 60 });
            AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "MaQuanLy", "SoHieuCongChuc", "HoTen", "TenLoaiGiangVien", "TenHocHamHrm", "TenHocHam", "TenHocViHrm", "TenHocVi", "TenBoMon", "TenKhoa", "TenChucVuHrm", "TenChucVu", "DinhMucToiThieu", "DinhMucCaNam", "DinhMucHocKy", "TietGioiHan", "MienGiamPhanTramNghiaVu", "TenTinhTrangHrm", "TenTinhTrang", "TinhTrangCongViec", "TuNgay", "DenNgay", "DinhMucSauGiamTru", "TietNghiaVuBoSung", "TietNghiaVuThucHien", "GhiChu2", "MaHocHam", "MaHocVi", "Huong85PhanTram", "TenChucDanh", "TenLoaiNhanSu", "TenNgachLuong", "TenLoaiNhanVien", "TienCanTren", "BiChan", "CoGiangDay" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTietNghiaVu, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTietNghiaVu, new string[] { "MaQuanLy", "SoHieuCongChuc", "HoTen", "TenLoaiGiangVien", "TenHocHamHrm", "TenHocHam", "TenHocViHrm", "TenHocVi", "TenBoMon", "TenKhoa", "TenChucVuHrm", "TenChucVu", "DinhMucToiThieu", "DinhMucCaNam", "DinhMucHocKy", "DinhMucSauGiamTru", "TenTinhTrangHrm", "TenTinhTrang", "TinhTrangCongViec", "TuNgay", "DenNgay", "TietNghiaVuThucHien", "MaGiangVien", "Huong85PhanTram", "TenChucDanh", "TenLoaiNhanSu", "TenNgachLuong", "TenLoaiNhanVien", "TienCanTren", "CoGiangDay" });
            AppGridView.HideField(gridViewTietNghiaVu, new string[] { "MaGiangVien", "GhiChu", "MaHocHam", "MaHocVi" });
            AppGridView.FormatDataField(gridViewTietNghiaVu, "TienCanTren", DevExpress.Utils.FormatType.Custom, "n0");
            PMS.Common.Globals.WordWrapHeader(gridViewTietNghiaVu, 50);
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

            InitData();
        }

        #region InitData
        void InitData()
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHocKy.Text != "")
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.TietNghiaVu.GetTietNghiaVuUte(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                foreach (DataColumn col in tb.Columns)
                    col.ReadOnly = false;
                bindingSourceTietNghiaVu.DataSource = tb;

            }
            PMS.Common.Globals.GridRowColor(gridViewTietNghiaVu, Color.Silver, "GhiChu", "True");
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewTietNghiaVu.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable list = bindingSourceTietNghiaVu.DataSource as DataTable;
                if (list != null)
                {
                    try
                    { 
                        string xmlData = "";
                        foreach (DataRow kl in list.Rows)
                        {
                            if (kl["MaGiangVien"] != null && (kl["GhiChu"].ToString().ToLower() == "true" || kl["GhiChu2"].ToString().Equals("Thay đổi chặn")))
                            {
                                xmlData += String.Format("<Input M=\"{0}\" Hh=\"{1}\" Hv=\"{2}\" T=\"{3}\" G=\"{4}\" Gh=\"{5}\" G2=\"{6}\" P=\"{7}\" B=\"{8}\" BC=\"{9}\" />"
                                            , kl["MaGiangVien"]
                                            , PMS.Common.Globals.IsNull(kl["MaHocHam"], "decimal")
                                            , PMS.Common.Globals.IsNull(kl["MaHocVi"], "decimal")
                                            , PMS.Common.Globals.IsNull(kl["TietNghiaVuThucHien"], "decimal")
                                            , PMS.Common.Globals.IsNull(kl["GhiChu"], "bool")
                                            , PMS.Common.Globals.IsNull(kl["TietGioiHan"], "decimal")
                                            , kl["GhiChu2"]
                                            , PMS.Common.Globals.IsNull(kl["MienGiamPhanTramNghiaVu"], "decimal")
                                            , PMS.Common.Globals.IsNull(kl["TietNghiaVuBoSung"], "decimal")
                                            , kl["BiChan"] );
                            }
                        }
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);
                        bindingSourceTietNghiaVu.EndEdit();
                        int kq = 0;
                        DataServices.TietNghiaVu.LuuTietNghiaVuUte(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepTietNghiaVu"))
            {
                frm.ShowDialog();
            }
            InitData();
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHocKy.Text != "")
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.TietNghiaVu.GetTietNghiaVuUte(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                foreach (DataColumn col in tb.Columns)
                    col.ReadOnly = false;
                bindingSourceTietNghiaVu.DataSource = tb;

            }
            PMS.Common.Globals.GridRowColor(gridViewTietNghiaVu, Color.Silver, "GhiChu", "True");
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHocKy.Text != "")
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.TietNghiaVu.GetTietNghiaVuUte(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                foreach (DataColumn col in tb.Columns)
                    col.ReadOnly = false;
                bindingSourceTietNghiaVu.DataSource = tb;

            }
            PMS.Common.Globals.GridRowColor(gridViewTietNghiaVu, Color.Silver, "GhiChu", "True");
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void gridViewTietNghiaVu_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridColumn col = e.Column;
                int pos = e.RowHandle;
                DataRowView v = gridViewTietNghiaVu.GetRow(pos) as DataRowView;

                if (col.FieldName == "MienGiamPhanTramNghiaVu")
                {
                    decimal _mienGiamPhanTramNghiaVu = decimal.Parse(PMS.Common.Globals.IsNull(v["MienGiamPhanTramNghiaVu"], "decimal").ToString());
                    if (_mienGiamPhanTramNghiaVu > 1)
                    {
                        XtraMessageBox.Show("Phần trăm miễn giảm nghĩa vụ không được nhập lớn hơn 1 (100%)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DevExpress.XtraGrid.Views.Base.ColumnView view = (DevExpress.XtraGrid.Views.Base.ColumnView)gridControlTietNghiaVu.KeyboardFocusView;
                        if (view.IsEditing)
                            view.HideEditor();
                        view.CancelUpdateCurrentRow();
                        return;
                    }
                }
                if (col.FieldName == "MienGiamPhanTramNghiaVu" || col.FieldName == "TietNghiaVuBoSung")
                {
                    //DinhMucSauGiamTru,TietNghiaVuThucHien
                    decimal _phanTramGiamChucVu;
                    if (v["DinhMucToiThieu"].ToString() == "")
                        _phanTramGiamChucVu = 1;
                    else
                        _phanTramGiamChucVu = decimal.Parse(PMS.Common.Globals.IsNull(v["DinhMucToiThieu"], "decimal").ToString()) / 100;

                    decimal _dinhMucSauGiamTru = decimal.Parse(PMS.Common.Globals.IsNull(v["DinhMucHocKy"], "decimal").ToString())
                           * _phanTramGiamChucVu
                           * (1 - decimal.Parse(PMS.Common.Globals.IsNull(v["MienGiamPhanTramNghiaVu"], "decimal").ToString()));
                    decimal _tietNghiaVuThucHien = _dinhMucSauGiamTru
                            + decimal.Parse(PMS.Common.Globals.IsNull(v["TietNghiaVuBoSung"], "decimal").ToString());
                    gridViewTietNghiaVu.SetRowCellValue(pos, "DinhMucSauGiamTru", _dinhMucSauGiamTru);
                    gridViewTietNghiaVu.SetRowCellValue(pos, "TietNghiaVuThucHien", _tietNghiaVuThucHien);
                }

                if (col.FieldName == "TietNghiaVuThucHien" || col.FieldName == "TietGioiHan")
                {
                    gridViewTietNghiaVu.SetRowCellValue(pos, "GhiChu", 1);
                }
                else if (col.FieldName == "BiChan")
                {
                    gridViewTietNghiaVu.SetRowCellValue(pos, "GhiChu2", "Thay đổi chặn");
                }
            }
            catch
            { }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    sf.ShowDialog();
                    if (sf.FileName != "")
                    {
                        gridControlTietNghiaVu.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }
    }
}
