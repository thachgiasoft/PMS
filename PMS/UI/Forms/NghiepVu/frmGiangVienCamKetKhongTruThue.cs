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
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmGiangVienCamKetKhongTruThue : DevExpress.XtraEditors.XtraForm
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
        private string groupname = UserInfo.GroupName;
        #endregion
        public frmGiangVienCamKetKhongTruThue()
        {
            InitializeComponent();
        }

        private void frmGiangVienCamKetKhongTruThue_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewGVKhongTruThue, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewGVKhongTruThue, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewGVKhongTruThue, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị", "Ghi chú", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 90, 200, 200, 200, 99, 99 });
            AppGridView.AlignHeader(gridViewGVKhongTruThue, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewGVKhongTruThue, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.RegisterControlField(gridViewGVKhongTruThue, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.ReadOnlyColumn(gridViewGVKhongTruThue, new string[] { "HoTen", "TenDonVi" });

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

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" },
                    new string[] { "Mã giảng viên", "Họ tên", "Đơn vị" }, new int[] { 100, 150, 180 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 430, 650);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            InitData();
        }
        #region InitData
        void InitData()
        {
            _listGiangVien = DataServices.ViewGiangVien.GetByNhomQuyen(groupname);
            bindingSourceGiangVien.DataSource = _listGiangVien;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable ();
                IDataReader reader = DataServices.GiangVienCamKetKhongTruThue.GetByNamHocHocKyNhomQuyen(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), groupname);
                tb.Load(reader);
                foreach (DataColumn c in tb.Columns)
                {
                    c.AllowDBNull = true;
                    c.ReadOnly = false;
                }
                bindingSourceGVKhongTruThue.DataSource = tb;
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGVKhongTruThue);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewGVKhongTruThue.FocusedRowHandle = -1;
            bindingSourceGVKhongTruThue.EndEdit();
            DataTable list = bindingSourceGVKhongTruThue.DataSource as DataTable;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        
                        string xmlData = "";

                        foreach (DataRow v in list.Rows)
                        {
                            if (v.RowState != DataRowState.Deleted)
                            {
                                if ((int)PMS.Common.Globals.IsNull(v["MaGiangVien"], "int") != 0)
                                {
                                    xmlData += String.Format("<Input M=\"{0}\" G=\"{1}\" D=\"{2}\" U=\"{3}\" />", v["MaGiangVien"], v["GhiChu"].ToString(), v["NgayCapNhat"].ToString(), v["NguoiCapNhat"].ToString());
                                }
                                else
                                {
                                    XtraMessageBox.Show("Giảng viên không được phép để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                        }
                        xmlData = String.Format("<Root>{0}</Root>", xmlData);

                        int kq = 0;
                        DataServices.GiangVienCamKetKhongTruThue.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), groupname, ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Cursor.Current = Cursors.Default;
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
                        if (sf.FileName != "")
                        {
                            gridControlGVKhongTruThue.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.GiangVienCamKetKhongTruThue.GetByNamHocHocKyNhomQuyen(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), groupname);
                tb.Load(reader);
                foreach (DataColumn c in tb.Columns)
                {
                    c.AllowDBNull = true;
                    c.ReadOnly = false;
                }
                bindingSourceGVKhongTruThue.DataSource = tb;
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.GiangVienCamKetKhongTruThue.GetByNamHocHocKyNhomQuyen(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), groupname);
                tb.Load(reader);
                foreach (DataColumn c in tb.Columns)
                {
                    c.AllowDBNull = true;
                    c.ReadOnly = false;
                }
                bindingSourceGVKhongTruThue.DataSource = tb;
            }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewGVKhongTruThue_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGVKhongTruThue, e);
        }

        private void gridViewGVKhongTruThue_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            try
            {
                if (col.FieldName == "MaGiangVien")
                {
                    DataRowView drow = gridViewGVKhongTruThue.GetRow(e.RowHandle) as DataRowView;
                    ViewGiangVien gv = _listGiangVien.Find(p => p.MaGiangVien == int.Parse(drow["MaGiangVien"].ToString()));
                    gridViewGVKhongTruThue.SetRowCellValue(e.RowHandle, "HoTen", gv.HoTen);
                    gridViewGVKhongTruThue.SetRowCellValue(e.RowHandle, "TenDonVi", gv.TenDonVi);
                }

                if (col.FieldName == "MaGiangVien" || col.FieldName == "GhiChu")
                {
                    gridViewGVKhongTruThue.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    gridViewGVKhongTruThue.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
                    gridViewGVKhongTruThue.RefreshData();
                }
            }
            catch
            { }
        }
    }
}