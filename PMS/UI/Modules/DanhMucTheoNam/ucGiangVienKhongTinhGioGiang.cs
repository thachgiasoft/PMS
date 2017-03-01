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
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucGiangVienKhongTinhGioGiang : DevExpress.XtraEditors.XtraUserControl
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
        VList<ViewGiangVien> _listGiangVien = new VList<ViewGiangVien>();
        string _maTruong, _cauHinhHeSoTheoNam;
        VList<ViewHocKy> _listHocKy;
        #endregion

        public ucGiangVienKhongTinhGioGiang()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucGiangVienKhongTinhGioGiang_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewGiangVienKhongTinhGioGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowEditor(gridViewGiangVienKhongTinhGioGiang, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewGiangVienKhongTinhGioGiang, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "GhiChu" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Khoa - đơn vị", "Học hàm", "Học vị", "Ghi chú" }
                    , new int[] { 90, 170, 220, 100, 100, 150 });
            AppGridView.AlignHeader(gridViewGiangVienKhongTinhGioGiang, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewGiangVienKhongTinhGioGiang, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewGiangVienKhongTinhGioGiang, new string[] { "HoTen", "TenDonVi", "TenHocHam", "TenHocVi" });
            AppGridView.RegisterControlField(gridViewGiangVienKhongTinhGioGiang, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
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

            #region LopHocPhan
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Khoa - đơn vị", "Học hàm", "Học vị" }
                    , new int[] { 90, 170, 220, 100, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 680, 650);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            LoadDataSource();
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                _listGiangVien = DataServices.ViewGiangVien.GetAll();
                bindingSourceGiangVien.DataSource = _listGiangVien;

                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.GiangVienKhongTinhGioGiang.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tbl.Load(reader);
                foreach (DataColumn col in tbl.Columns)
                    col.ReadOnly = false;
                bindingSourceGiangVienKhongTinhGioGiang.DataSource = tbl;
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiangVienKhongTinhGioGiang);
        }

        private void gridViewLHPKhongTinhGioGiang_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiangVienKhongTinhGioGiang, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewGiangVienKhongTinhGioGiang.FocusedRowHandle = -1;
            DataTable list = bindingSourceGiangVienKhongTinhGioGiang.DataSource as DataTable;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        int kq = -1;
                        foreach (DataRow q in list.Rows)
                        {
                            if (q.RowState != DataRowState.Deleted)
                            {
                                xmlData += "<Input M=\"" + q["MaGiangVien"].ToString()
                                    + "\" G=\"" + q["GhiChu"].ToString()
                                    + "\" />";
                            }
                        }
                        bindingSourceGiangVienKhongTinhGioGiang.EndEdit();

                        xmlData = "<Root>" + xmlData + "</Root>";
                        DataServices.GiangVienKhongTinhGioGiang.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        if (sf.FileName != "")
                        {
                            gridControlGiangVienKhongTinhGioGiang.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
            LoadDataSource();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void gridViewLHPKhongTinhGioGiang_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVien")
            {
                DataRowView r = gridViewGiangVienKhongTinhGioGiang.GetRow(e.RowHandle) as DataRowView;
                ViewGiangVien _gv = _listGiangVien.Find(p => p.MaGiangVien == int.Parse(r["MaGiangVien"].ToString()));

                gridViewGiangVienKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "HoTen", _gv.HoTen);
                gridViewGiangVienKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "TenDonVi", _gv.TenDonVi);
                gridViewGiangVienKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "TenHocHam", _gv.TenHocHam);
                gridViewGiangVienKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "TenHocVi", _gv.TenHocVi);
            }
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (_cauHinhHeSoTheoNam.ToLower() == "true")
            if (cboHocKy.EditValue == null)
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepGiangVienKhongTinhGioGiang"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepGiangVienKhongTinhGioGiang"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }
    }
}
