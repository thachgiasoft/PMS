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
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;
using PMS.Services;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucMonThucTapTotNghiep : DevExpress.XtraEditors.XtraUserControl
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

                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewHocPhanMonHoc> _listMonHoc;
        #endregion

        public ucMonThucTapTotNghiep()
        {
            InitializeComponent();
        }

        private void ucMonThucTapTotNghiep_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewMonThucTapTotNghiep, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewMonThucTapTotNghiep, new string[] { "MaMonHoc", "TenMonHoc", "Stc", "MaKhoa", "TenKhoa", "SoTuan", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Mã môn", "Tên môn", "STC", "Mã bộ môn", "Tên bộ môn", "Số tuần", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 90, 130, 50, 90, 130, 90, 99, 99 });
            AppGridView.ShowEditor(gridViewMonThucTapTotNghiep, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewMonThucTapTotNghiep, new string[] { "MaMonHoc", "TenMonHoc", "Stc", "MaKhoa", "TenKhoa", "SoTuan", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewMonThucTapTotNghiep, "MaMonHoc", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewMonThucTapTotNghiep, new string[] { "TenMonHoc", "Stc", "MaKhoa", "TenKhoa" });
            AppGridView.RegisterControlField(gridViewMonThucTapTotNghiep, "MaMonHoc", repositoryItemGridLookUpEditMonHoc);
            AppGridView.HideField(gridViewMonThucTapTotNghiep, new string[] { "NgayCapNhat", "NguoiCapNhat" });
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
            #region MonHoc
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 500, 700);
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "CurriculumId", "CurriculumName", "Credits", "DepartmentId", "DepartmentName" }, new string[] { "Mã môn", "Tên môn", "STC", "Mã bộ môn", "Tên bộ môn" }, new int[] { 90, 130, 60, 90, 130 });
            repositoryItemGridLookUpEditMonHoc.ValueMember = "CurriculumId";
            repositoryItemGridLookUpEditMonHoc.DisplayMember = "CurriculumId";
            #endregion
            InitData();
        }
        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                _listMonHoc = DataServices.ViewHocPhanMonHoc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bindingSourceMonHoc.DataSource = _listMonHoc;
                bindingSourceMonThucTapTotNghiep.DataSource = DataServices.ViewMonThucTapTotNghiep.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            gridViewMonThucTapTotNghiep.ExpandAllGroups();
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
            AppGridView.DeleteSelectedRows(gridViewMonThucTapTotNghiep);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewMonThucTapTotNghiep.FocusedRowHandle = -1;
            VList<ViewMonThucTapTotNghiep> list = bindingSourceMonThucTapTotNghiep.DataSource as VList<ViewMonThucTapTotNghiep>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (ViewMonThucTapTotNghiep v in list)
                        {
                            if (v.MaMonHoc == null)
                            {
                                XtraMessageBox.Show("Môn học không được phép bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            v.NamHoc = cboNamHoc.EditValue.ToString();
                            v.HocKy = cboHocKy.EditValue.ToString();

                            xmlData += "<TTTN M=\"" + v.MaMonHoc
                                + "\" S=\"" + v.SoTuan
                                + "\" N=\"" + v.NgayCapNhat
                                + "\" U=\"" + v.NguoiCapNhat
                                + "\" />";
                        }
                        bindingSourceMonThucTapTotNghiep.EndEdit();
                        xmlData = String.Format("<Root>{0}</Root>", xmlData);
                        int kq = 0;
                        DataServices.MonThucTapTotNghiep.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlMonThucTapTotNghiep.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                _listMonHoc = DataServices.ViewHocPhanMonHoc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bindingSourceMonHoc.DataSource = _listMonHoc;
                bindingSourceMonThucTapTotNghiep.DataSource = DataServices.ViewMonThucTapTotNghiep.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            gridViewMonThucTapTotNghiep.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                _listMonHoc = DataServices.ViewHocPhanMonHoc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bindingSourceMonHoc.DataSource = _listMonHoc;
                bindingSourceMonThucTapTotNghiep.DataSource = DataServices.ViewMonThucTapTotNghiep.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            gridViewMonThucTapTotNghiep.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewMonThucTapTotNghiep_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewMonThucTapTotNghiep, e);
        }

        private void gridViewMonThucTapTotNghiep_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            int pos = e.RowHandle;
            if (col.FieldName == "MaMonHoc")
            { 
                ViewMonThucTapTotNghiep v = gridViewMonThucTapTotNghiep.GetRow(pos) as ViewMonThucTapTotNghiep;
                ViewHocPhanMonHoc _monHoc = _listMonHoc.Find(p => p.CurriculumId == v.MaMonHoc);
                gridViewMonThucTapTotNghiep.SetRowCellValue(pos, "TenMonHoc", _monHoc.CurriculumName);
                gridViewMonThucTapTotNghiep.SetRowCellValue(pos, "Stc", _monHoc.Credits);
                gridViewMonThucTapTotNghiep.SetRowCellValue(pos, "MaKhoa", _monHoc.DepartmentId);
                gridViewMonThucTapTotNghiep.SetRowCellValue(pos, "TenKhoa", _monHoc.DepartmentName);
                gridViewMonThucTapTotNghiep.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToShortDateString());
                gridViewMonThucTapTotNghiep.SetRowCellValue(pos, "NguoiCapNhat", UserInfo.User.TenDangNhap);
            }
            if (col.FieldName == "SoTuan")
            {
                gridViewMonThucTapTotNghiep.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToShortDateString());
                gridViewMonThucTapTotNghiep.SetRowCellValue(pos, "NguoiCapNhat", UserInfo.User.TenDangNhap);
            }
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepMonThucTapTotNghiep"))
            {
                frm.ShowDialog();
            }
        }
    }
}
