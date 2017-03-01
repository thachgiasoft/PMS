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

namespace PMS.UI.Modules.DanhMuc.KhongChinhQuy
{
    public partial class ucPhanNhomLopHocPhan_Kcq : DevExpress.XtraEditors.XtraUserControl
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
        public ucPhanNhomLopHocPhan_Kcq()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucPhanNhomLopHocPhan_Load(object sender, EventArgs e)
        {
            #region Init GridView

            AppGridView.InitGridView(gridViewPhanNhom, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewPhanNhom, new string[] { "CurriculumId", "CurriculumName", "Credits", "NumberOfPeriods", "DepartmentName", "MaNhomMonHoc" }
                        , new string[] { "Mã môn học", "Tên môn học", "STC", "Số tiết", "Khoa", "Nhóm môn học" }
                        , new int[] { 100, 180, 50, 60, 120, 300 });
            AppGridView.AlignHeader(gridViewPhanNhom, new string[] { "CurriculumId", "CurriculumName", "Credits", "NumberOfPeriods", "DepartmentName", "MaNhomMonHoc" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewPhanNhom, new string[] { "CurriculumId", "CurriculumName", "Credits", "NumberOfPeriods", "DepartmentName" });
            AppGridView.RegisterControlField(gridViewPhanNhom, "MaNhomMonHoc", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.SummaryField(gridViewPhanNhom, "CurriculumId", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            gridViewPhanNhom.Columns["DepartmentName"].GroupIndex = 1;

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

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
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
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    bindingSourcePhanNhom.DataSource = DataServices.ViewKcqPhanNhomMonHoc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                gridViewPhanNhom.ExpandAllGroups();
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
            VList<ViewKcqPhanNhomMonHoc> list = bindingSourcePhanNhom.DataSource as VList<ViewKcqPhanNhomMonHoc>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        int kq = 0;
                        bindingSourcePhanNhom.EndEdit();
                        
                        foreach (ViewKcqPhanNhomMonHoc v in list)
                        {
                            if (v.MaNhomMonHoc != null && v.MaNhomMonHoc != 0)
                            {
                                xmlData += String.Format("<KcqPhanNhomMonHoc MaMonHoc = \"{0}\" MaLoaiHocPhan = \"{1}\" MaNhomMonHoc = \"{2}\" />"
                                            , v.CurriculumId, v.StudyUnitTypeId, v.MaNhomMonHoc);
                            }
                        }
                        xmlData = String.Format("<Root>{0}</Root>", xmlData);
                        DataServices.KcqPhanNhomMonHoc.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
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
            using (frmSaoChepPhanNhomMonHoc_Kcq frm = new frmSaoChepPhanNhomMonHoc_Kcq(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()))
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
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourcePhanNhom.DataSource = DataServices.ViewKcqPhanNhomMonHoc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            gridViewPhanNhom.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourcePhanNhom.DataSource = DataServices.ViewKcqPhanNhomMonHoc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            gridViewPhanNhom.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlPhanNhom.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}