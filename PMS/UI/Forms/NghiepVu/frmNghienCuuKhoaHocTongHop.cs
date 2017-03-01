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
using DevExpress.XtraGrid.Views.Base;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmNghienCuuKhoaHocTongHop : DevExpress.XtraEditors.XtraForm
    { 
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;

                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoa.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewGiangVien> _listGiangVien;
        DataTable _tblDinhMucGioChuan = new DataTable();
        #endregion

        public frmNghienCuuKhoaHocTongHop()
        {
            InitializeComponent();
        }

        private void frmNghienCuuKhoaHocTongHop_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewNCKH, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewNCKH, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewNCKH, new string[] { "MaGiangVien", "HoTen", "DinhMucNckh", "SoTietKyTruocChuyenSang", "SoTietThucHien", "Tong", "SoTietDuocTru", "SoTietChuyenSangKySau", "GhiChu" }
                                              , new string[] { "Mả giảng viên", "Họ tên", "Định mức NCKH", "Số tiết kỳ trước chuyển sang", "Số tiết thực hiện", "Tổng", "Số tiết được trừ", "Số tiết chuyển qua kỳ sau", "Ghi chú" }
                                              , new int[] { 80, 150, 80, 110, 80, 80, 80, 110, 100 });
            AppGridView.AlignHeader(gridViewNCKH, new string[] { "MaGiangVien", "HoTen", "DinhMucNckh", "SoTietKyTruocChuyenSang", "SoTietThucHien", "Tong", "SoTietDuocTru", "SoTietChuyenSangKySau", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewNCKH, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            PMS.Common.Globals.WordWrapHeader(gridViewNCKH, 40);
            #endregion
            
            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            #region Học kỳ
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Khoa bộ môn
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã bộ môn", "Tên bộ môn" });
            cboKhoaDonVi.Properties.DisplayMember = "TenBoMon";
            cboKhoaDonVi.Properties.ValueMember = "MaBoMon";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị" }
                        , new int[] { 100, 180, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 400, 500);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            #region _namHoc-_hocKy
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            #endregion
          
            #region _khoaDonVi
            cboKhoaDonVi.DataBindings.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();

            _vListKhoaBoMon.Add(new ViewKhoaBoMon() { ThuTu = 0, MaBoMon = "-1", TenBoMon = "[Tất cả]" });

            _vListKhoaBoMon.Sort("ThuTu, TenBoMon");
            bindingSourceKhoaDonVi.DataSource = _vListKhoaBoMon;

            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);
            #endregion
            InitDinhMuc();
            #region GiangVien
            InitGiangVien();
            #endregion

            LoadDataSource();
        }

        void InitDinhMuc()
        {
            #region Lấy định mức giờ chuẩn lên để gắn định mức NCKH vào lưới
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                _tblDinhMucGioChuan = new DataTable();
                IDataReader readerDM = DataServices.TietNghiaVu.GetTietNghiaVuBuh(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                _tblDinhMucGioChuan.Load(readerDM);
            }
            #endregion
        }
        void InitGiangVien()
        {
            if (cboKhoaDonVi.EditValue != null)
            {
                _listGiangVien = new VList<ViewGiangVien>();
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
                bindingSourceGiangVien.DataSource = _listGiangVien;
            }
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                try
                {
                    DataTable tb = new DataTable();
                    IDataReader reader = DataServices.NghienCuuKhoaHocTongHop.GetByNamHocHocKyKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                    tb.Load(reader);
                    foreach (DataColumn col in tb.Columns)
                    {
                        col.ReadOnly = false;
                    }
                    bindingSourceNCKH.DataSource = tb;
                }
                catch
                {  }
               
            }
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            InitDinhMuc();
            LoadDataSource();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            InitDinhMuc();
            LoadDataSource();
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            InitGiangVien();
            LoadDataSource();
        }
        #endregion
        #region Event Grid
        private void gridViewNCKH_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "MaGiangVien")
                {
                    DataRowView r = gridViewNCKH.GetRow(e.RowHandle) as DataRowView;
                    ViewGiangVien gv = _listGiangVien.Find(p => p.MaGiangVien == int.Parse(r["MaGiangVien"].ToString()));

                    double _tietKyTruocChuyenSang = 0;
                    DataServices.NghienCuuKhoaHocTongHop.GetSoTietKyTruocChuyenSang(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(r["MaGiangVien"].ToString()), ref _tietKyTruocChuyenSang);

                    DataRow rowDM = null;
                    try
                    {
                        rowDM = _tblDinhMucGioChuan.Select("MaGiangVien = " + r["MaGiangVien"].ToString())[0];
                    }
                    catch
                    {
                        XtraMessageBox.Show(String.Format("Lưu ý: Giảng viên {0} không có định mức giờ chuẩn trong học kỳ này.", gv.HoTen), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ColumnView view = (ColumnView)gridControlNCKH.KeyboardFocusView;
                        if (view.IsEditing)
                            view.HideEditor();
                        view.CancelUpdateCurrentRow();
                        //AppGridView.CancelUpdateCurrentRow(gridControlNCKH);
                    }
                    
                    decimal _DinhMucNckh = 0;
                    if (rowDM != null)
                    {
                        _DinhMucNckh = (decimal)PMS.Common.Globals.IsNull(rowDM["TietNghiaVuNckhSauGiam"], "decimal");
                    }

                    gridViewNCKH.SetRowCellValue(e.RowHandle, "HoTen", gv.HoTen);
                    gridViewNCKH.SetRowCellValue(e.RowHandle, "DinhMucNckh", _DinhMucNckh);
                    gridViewNCKH.SetRowCellValue(e.RowHandle, "SoTietKyTruocChuyenSang", _tietKyTruocChuyenSang);
                }

                if (e.Column.FieldName == "DinhMucNckh" || e.Column.FieldName == "SoTietKyTruocChuyenSang" || e.Column.FieldName == "SoTietThucHien")
                {
                    DataRowView r = gridViewNCKH.GetRow(e.RowHandle) as DataRowView;

                    decimal _DinhMucNckh = (decimal)PMS.Common.Globals.IsNull(r["DinhMucNckh"], "decimal");
                    decimal _SoTietKyTruocChuyenSang = (decimal)PMS.Common.Globals.IsNull(r["SoTietKyTruocChuyenSang"], "decimal");
                    decimal _SoTietThucHien = (decimal)PMS.Common.Globals.IsNull(r["SoTietThucHien"], "decimal");
                    decimal _Tong = _SoTietKyTruocChuyenSang + _SoTietThucHien;
                    decimal _SoTietDuocTru, _SoTietChuyenSangKySau;

                    if (_Tong > _DinhMucNckh)
                    {
                        _SoTietDuocTru = _DinhMucNckh;
                        _SoTietChuyenSangKySau = _Tong - _DinhMucNckh;
                    }
                    else
                    {
                        _SoTietDuocTru = _Tong; 
                        _SoTietChuyenSangKySau = 0;
                        _SoTietDuocTru = Math.Max(_Tong, 0);
                        _SoTietChuyenSangKySau = Math.Min(_Tong, 0);
                    }

                    gridViewNCKH.SetRowCellValue(e.RowHandle, "Tong", _Tong);
                    gridViewNCKH.SetRowCellValue(e.RowHandle, "SoTietDuocTru", _SoTietDuocTru);
                    gridViewNCKH.SetRowCellValue(e.RowHandle, "SoTietChuyenSangKySau", _SoTietChuyenSangKySau);
                }
            }
            catch 
            {}
          
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewNCKH);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewNCKH.FocusedRowHandle = -1;
            DataTable tb = bindingSourceNCKH.DataSource as DataTable;
            if (tb != null)
            {
                if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        int result = -1;
                        foreach (DataRow row in tb.Rows)
                        {
                            if (row.RowState != DataRowState.Deleted)
                            {
                                if (row["MaGiangVien"].ToString() != "")
                                {
                                    xmlData += "<Input M=\"" + row["MaGiangVien"]
                                            + "\" KT=\"" + PMS.Common.Globals.IsNull(row["SoTietKyTruocChuyenSang"], "decimal")
                                            + "\" TH=\"" + PMS.Common.Globals.IsNull(row["SoTietThucHien"], "decimal")
                                            + "\" T=\"" + PMS.Common.Globals.IsNull(row["Tong"], "decimal")
                                            + "\" DT=\"" + PMS.Common.Globals.IsNull(row["SoTietDuocTru"], "decimal")
                                            + "\" KS=\"" + PMS.Common.Globals.IsNull(row["SoTietChuyenSangKySau"], "decimal")
                                            + "\" G=\"" + row["GhiChu"]
                                            + "\" />";
                                }
                                else
                                {
                                    XtraMessageBox.Show("Vui lòng chọn mã giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }

                        xmlData = "<Root>" + xmlData + "</Root>";

                        DataServices.NghienCuuKhoaHocTongHop.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref result);

                        if (result == 0)
                            XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        LoadDataSource();
                    }
                    catch
                    { }

                }
            }
        }

        private void btnExcwl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlNCKH.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
        #endregion

        private void btnImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmImportNghienCuuKhoaHocTongHop frm = new frmImportNghienCuuKhoaHocTongHop())
            {
                frm.ShowDialog();
            }

            InitData();
        }
    }
}
