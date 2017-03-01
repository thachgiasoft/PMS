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
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Modules.DanhMuc.SauDaiHoc
{
    public partial class ucPhanNhomMonHoc_SDH : DevExpress.XtraEditors.XtraUserControl
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
        string _maTruong, _cauHinhHeSoTheoNam;
        DataTable _listMonHoc = new DataTable();
        #endregion

        public ucPhanNhomMonHoc_SDH()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri; 
        }

        private void ucPhanNhomMonHoc_SDH_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewPhanNhomMonHoc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewPhanNhomMonHoc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewPhanNhomMonHoc, new string[] { "MaMonHoc", "TenMonHoc", "Credits", "MaNhomMonHoc" }
                        , new string[] { "Mã môn học", "Tên môn học", "STC", "Nhóm môn học" }
                        , new int[] { 100, 180, 50, 300 });
            AppGridView.AlignHeader(gridViewPhanNhomMonHoc, new string[] { "MaMonHoc", "TenMonHoc", "Credits", "MaNhomMonHoc" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewPhanNhomMonHoc, new string[] { "TenMonHoc", "Credits" });
            AppGridView.RegisterControlField(gridViewPhanNhomMonHoc, "MaNhomMonHoc", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.RegisterControlField(gridViewPhanNhomMonHoc, "MaMonHoc", repositoryItemGridLookUpEditMonHoc);
            AppGridView.SummaryField(gridViewPhanNhomMonHoc, "MaMonHoc", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            #endregion

            #region NhomMonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomMonHoc, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomMonHoc, new string[] { "MaQuanLy", "TenNhomMon" }, new string[] { "Mã Nhóm", "Tên nhóm" }, new int[] { 80, 270 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditNhomMonHoc, 350, 400);
            repositoryItemGridLookUpEditNhomMonHoc.ValueMember = "MaNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.DisplayMember = "TenNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.NullText = string.Empty;
            #endregion

            #region MonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi" }, new string[] { "Mã môn học", "Tên môn học", "Số tín chỉ" }, new int[] { 80, 270, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 450, 600);
            repositoryItemGridLookUpEditMonHoc.ValueMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.DisplayMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.NullText = string.Empty;
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
            InitData();
        }

        #region InitData
        void InitData()
        {
            try
            {
                bindingSourceNhomMonHoc.DataSource = DataServices.SdhNhomMonHoc.GetAll();
                bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    DataTable tblPhanNhomMonHoc = new DataTable();
                    IDataReader readerPNMH = DataServices.SdhPhanNhomMonHoc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    tblPhanNhomMonHoc.Load(readerPNMH);
                    foreach (DataColumn col in tblPhanNhomMonHoc.Columns)
                    {
                        col.ReadOnly = false;
                    }
                    bindingSourcePhanNhomMonHoc.DataSource = tblPhanNhomMonHoc;
                    IDataReader reader = DataServices.ViewMonHoc.GetByNamHocHocKyBacDaoTao(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "CH");//Chỉ lấy ra những môn học có tổ chức trong học kỳ đó
                    _listMonHoc.Clear();
                    _listMonHoc.Load(reader);
                    bindingSourceMonHoc.DataSource = _listMonHoc;
                }
            }
            catch
            { }

        }
        #endregion

        #region Evnet button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tblPhanNhomMonHoc = new DataTable();
                IDataReader readerPNMH = DataServices.SdhPhanNhomMonHoc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tblPhanNhomMonHoc.Load(readerPNMH);
                foreach (DataColumn col in tblPhanNhomMonHoc.Columns)
                {
                    col.ReadOnly = false;
                }
                bindingSourcePhanNhomMonHoc.DataSource = tblPhanNhomMonHoc;
                IDataReader reader = DataServices.ViewMonHoc.GetByNamHocHocKyBacDaoTao(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "CH");//Chỉ lấy ra những môn học có tổ chức trong học kỳ đó
                _listMonHoc.Clear();
                _listMonHoc.Load(reader);
                bindingSourceMonHoc.DataSource = _listMonHoc;
            }
            gridViewPhanNhomMonHoc.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewPhanNhomMonHoc.FocusedRowHandle = -1;
            DataTable list = bindingSourcePhanNhomMonHoc.DataSource as DataTable;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        int kq = 0;
                        bindingSourcePhanNhomMonHoc.EndEdit();

                        foreach (DataRow v in list.Rows)
                        {
                            if (v.RowState != DataRowState.Deleted)
                            {
                                xmlData += String.Format("<PhanNhomMonHoc MaMonHoc = \"{0}\" MaNhomMonHoc = \"{1}\" />"
                                            , v["MaMonHoc"], v["MaNhomMonHoc"]);
                            }
                        }
                        xmlData = String.Format("<Root>{0}</Root>", xmlData);
                        DataServices.SdhPhanNhomMonHoc.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    btnLamTuoi.PerformClick();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepPhanNhomMonHocSdh"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepPhanNhomMonHocSdh"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewPhanNhomMonHoc);
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
                            gridControlPhanNhom.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
        #endregion

        private void gridViewPhanNhomMonHoc_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewPhanNhomMonHoc, e);
        }
        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tblPhanNhomMonHoc = new DataTable();
                IDataReader readerPNMH = DataServices.SdhPhanNhomMonHoc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tblPhanNhomMonHoc.Load(readerPNMH);
                foreach (DataColumn col in tblPhanNhomMonHoc.Columns)
                {
                    col.ReadOnly = false;
                }
                bindingSourcePhanNhomMonHoc.DataSource = tblPhanNhomMonHoc;
                IDataReader reader = DataServices.ViewMonHoc.GetByNamHocHocKyBacDaoTao(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "CH");//Chỉ lấy ra những môn học có tổ chức trong học kỳ đó
                _listMonHoc.Clear();
                _listMonHoc.Load(reader);
                bindingSourceMonHoc.DataSource = _listMonHoc;
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tblPhanNhomMonHoc = new DataTable();
                IDataReader readerPNMH = DataServices.SdhPhanNhomMonHoc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tblPhanNhomMonHoc.Load(readerPNMH);
                foreach (DataColumn col in tblPhanNhomMonHoc.Columns)
                {
                    col.ReadOnly = false;
                }
                bindingSourcePhanNhomMonHoc.DataSource = tblPhanNhomMonHoc;
                IDataReader reader = DataServices.ViewMonHoc.GetByNamHocHocKyBacDaoTao(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "CH");//Chỉ lấy ra những môn học có tổ chức trong học kỳ đó
                _listMonHoc.Clear();
                _listMonHoc.Load(reader);
                bindingSourceMonHoc.DataSource = _listMonHoc;
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void gridViewPhanNhomMonHoc_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaMonHoc")
            {
                DataRowView v = gridViewPhanNhomMonHoc.GetRow(e.RowHandle) as DataRowView;
                foreach (DataRow dr in _listMonHoc.Rows)
                    if (dr["MaMonHoc"].ToString() == v["MaMonHoc"].ToString())
                    {
                        gridViewPhanNhomMonHoc.SetRowCellValue(e.RowHandle, "TenMonHoc", dr["TenMonHoc"].ToString());
                        gridViewPhanNhomMonHoc.SetRowCellValue(e.RowHandle, "Credits", dr["SoTinChi"].ToString());
                    }
            }
        }

    }
}
