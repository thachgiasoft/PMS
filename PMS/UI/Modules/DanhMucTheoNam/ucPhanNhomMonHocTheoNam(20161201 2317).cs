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
using PMS.UI.Forms.NghiepVu;
using PMS.Services;
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucPhanNhomMonHocTheoNam : DevExpress.XtraEditors.XtraUserControl
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
        string _maTruong;
        #endregion
        #region Event Form
        public ucPhanNhomMonHocTheoNam()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucPhanNhomMonHocTheoNam_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewPhanNhom, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewPhanNhom, new string[] { "MaMonHoc", "TenMonHoc", "Stc", "TenDonVi", "MaNhomMonHoc" }
                        , new string[] { "Mã môn học", "Tên môn học", "Stc", "Khoa - Bộ môn", "Nhóm môn học" }
                        , new int[] { 100, 350, 50, 200, 200 });
            AppGridView.AlignHeader(gridViewPhanNhom, new string[] { "MaMonHoc", "TenMonHoc", "Stc", "MaNhomMonHoc", "TenDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewPhanNhom, new string[] { "MaMonHoc", "TenMonHoc", "Stc", "TenDonVi" });
            AppGridView.RegisterControlField(gridViewPhanNhom, "MaNhomMonHoc", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.SummaryField(gridViewPhanNhom, "MaMonHoc", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            gridViewPhanNhom.GroupPanelText = "Kéo tên cột vào đây để gom nhóm";
            #endregion

            #region NhomMonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomMonHoc, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomMonHoc, new string[] { "MaQuanLy", "TenNhomMon" }, new string[] { "Mã Nhóm", "Tên nhóm" }, new int[] { 80, 270 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditNhomMonHoc, 350, 400);
            repositoryItemGridLookUpEditNhomMonHoc.ValueMember = "MaNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.DisplayMember = "TenNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.NullText = string.Empty;
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            InitData();

        }
        #endregion
        #region InitData
        void InitData()
        {
            try
            {
                
                bindingSourceNhomMonHoc.DataSource = DataServices.NhomMonHoc.GetAll();
                bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
                if (cboNamHoc.EditValue != null)
                {
                    DataServices.PhanNhomMonHoc.DongBoTheoNamHocCDGTVT(cboNamHoc.EditValue.ToString());
                    DataTable tb = new DataTable();
                    IDataReader reader = DataServices.PhanNhomMonHoc.GetByNamHoc(cboNamHoc.EditValue.ToString());
                    tb.Load(reader);
                    tb.Columns["MaNhomMonHoc"].ReadOnly = false;
                    bindingSourcePhanNhom.DataSource = tb;
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

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewPhanNhom.FocusedRowHandle = -1;
            DataTable list = bindingSourcePhanNhom.DataSource as DataTable;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        int kq = 0;
                        bindingSourcePhanNhom.EndEdit();

                        foreach (DataRow v in list.Rows)
                        {
                            if (v["MaNhomMonHoc"] != null)
                            {
                                xmlData += String.Format("<Input M = \"{0}\" L = \"{1}\" />"
                                            , v["MaMonHoc"].ToString(), PMS.Common.Globals.IsNull(v["MaNhomMonHoc"], "int"));
                            }
                        }
                        xmlData = String.Format("<Root>{0}</Root>", xmlData);
                        DataServices.PhanNhomMonHoc.LuuTheoNam(xmlData, cboNamHoc.EditValue.ToString(), ref kq);
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
            Cursor.Current = Cursors.Default;
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepPhanNhomMonHoc"))
            {
                frm.ShowDialog();
            }
            Cursor.Current = Cursors.Default;
        }

        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
            {
                DataServices.PhanNhomMonHoc.DongBoTheoNamHocCDGTVT(cboNamHoc.EditValue.ToString());
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.PhanNhomMonHoc.GetByNamHoc(cboNamHoc.EditValue.ToString());
                tb.Load(reader);
                tb.Columns["MaNhomMonHoc"].ReadOnly = false;
                bindingSourcePhanNhom.DataSource = tb;
            }
            Cursor.Current = Cursors.Default;
        }

        #endregion

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlPhanNhom.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
    }
}