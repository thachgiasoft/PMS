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

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucLopHocPhanKhongTinhGioGiang : DevExpress.XtraEditors.XtraUserControl
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

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewLopHocPhan> _listLHP = new VList<ViewLopHocPhan>();
        public ucLopHocPhanKhongTinhGioGiang()
        {
            InitializeComponent();
        }

        private void ucLopHocPhanKhongTinhGioGiang_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewLHPKhongTinhGioGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowEditor(gridViewLHPKhongTinhGioGiang, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewLHPKhongTinhGioGiang, new string[] { "MaLopHocPhan", "MaHocPhan", "TenHocPhan", "SoTinChi", "MaLop", "Nhom", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Mã lớp học phần", "Mã học phần", "Tên học phần", "Số tín chỉ", "Lớp sinh viên", "Nhóm", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 110, 80, 180, 60, 90, 80, 99, 99 });
            AppGridView.AlignHeader(gridViewLHPKhongTinhGioGiang, new string[] { "MaLopHocPhan", "MaHocPhan", "TenHocPhan", "SoTinChi", "MaLop", "Nhom", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewLHPKhongTinhGioGiang, "MaLopHocPhan", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewLHPKhongTinhGioGiang, new string[] { "MaHocPhan", "TenHocPhan", "SoTinChi", "MaLop", "Nhom" });
            AppGridView.HideField(gridViewLHPKhongTinhGioGiang, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.RegisterControlField(gridViewLHPKhongTinhGioGiang, "MaLopHocPhan", repositoryItemGridLookUpEditLopHocPhan);
            
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
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLopHocPhan, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLopHocPhan, new string[] { "MaLopHocPhan", "MaMonHoc", "TenMonHoc", "MaLop", "SoTinChi", "Nhom" }
                    , new string[] { "Lớp học phần", "Mã môn học", "Tên môn học", "Lớp sinh viên", "STC", "Nhóm" }
                    , new int[] { 100, 90, 150, 100, 50, 60 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLopHocPhan, 500, 650);
            repositoryItemGridLookUpEditLopHocPhan.DisplayMember = "MaLopHocPhan";
            repositoryItemGridLookUpEditLopHocPhan.ValueMember = "MaLopHocPhan";
            repositoryItemGridLookUpEditLopHocPhan.NullText = string.Empty;
            #endregion

            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                _listLHP = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bindingSourceLopHocPhan.DataSource = _listLHP;

                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.LopHocPhanKhongTinhGioGiang.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tbl.Load(reader);
                bindingSourceLHPKhongTinhGioGiang.DataSource = tbl;
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
            AppGridView.DeleteSelectedRows(gridViewLHPKhongTinhGioGiang);
        }

        private void gridViewLHPKhongTinhGioGiang_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewLHPKhongTinhGioGiang, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewLHPKhongTinhGioGiang.FocusedRowHandle = -1;
            DataTable list = bindingSourceLHPKhongTinhGioGiang.DataSource as DataTable;
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
                            xmlData += "<Input M=\"" + q["MaLopHocPhan"].ToString()
                                + "\" D=\"" + q["NgayCapNhat"].ToString()
                                + "\" U=\"" + q["NguoiCapNhat"].ToString()
                                + "\" />";
                        }
                        bindingSourceLHPKhongTinhGioGiang.EndEdit();

                        xmlData = "<Root>" + xmlData + "</Root>";
                        DataServices.LopHocPhanKhongTinhGioGiang.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
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
                            gridControlLHPKhongTinhGioGiang.ExportToXls(sf.FileName);
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
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                _listLHP = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bindingSourceLopHocPhan.DataSource = _listLHP;

                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.LopHocPhanKhongTinhGioGiang.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tbl.Load(reader);
                bindingSourceLHPKhongTinhGioGiang.DataSource = tbl;
            }
            gridViewLHPKhongTinhGioGiang.BestFitColumns();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                _listLHP = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bindingSourceLopHocPhan.DataSource = _listLHP;

                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.LopHocPhanKhongTinhGioGiang.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tbl.Load(reader);
                bindingSourceLHPKhongTinhGioGiang.DataSource = tbl;
            }
            gridViewLHPKhongTinhGioGiang.BestFitColumns();
        }

        private void gridViewLHPKhongTinhGioGiang_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaLopHocPhan")
            {
                DataRowView r = gridViewLHPKhongTinhGioGiang.GetRow(e.RowHandle) as DataRowView;
                ViewLopHocPhan _lhp = _listLHP.Find(p => p.MaLopHocPhan == r["MaLopHocPhan"].ToString());

                gridViewLHPKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "MaHocPhan", _lhp.MaMonHoc);
                gridViewLHPKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "TenHocPhan", _lhp.TenMonHoc);
                gridViewLHPKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "SoTinChi", _lhp.SoTinChi);
                gridViewLHPKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "MaLop", _lhp.MaLop);
                gridViewLHPKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "Nhom", _lhp.Nhom);
                gridViewLHPKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewLHPKhongTinhGioGiang.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }
    }
}
