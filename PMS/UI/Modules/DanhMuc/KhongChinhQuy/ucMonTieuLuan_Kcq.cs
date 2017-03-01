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
using PMS.Services;
using PMS.Core;

namespace PMS.UI.Modules.DanhMuc.KhongChinhQuy
{
    public partial class ucMonTieuLuan_Kcq : DevExpress.XtraEditors.XtraUserControl
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

        #region Bien
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewMonHocKhoa> _listMonHoc;
        string _maTruong;
        #endregion
        public ucMonTieuLuan_Kcq()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri.ToString();
        }

        private void ucMonTieuLuan_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewMonTieuLuan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewMonTieuLuan, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewMonTieuLuan, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "TenBoMon", "NgayCapNhat", "NguoiCapNhat" }
                        , new string[] { "Mã môn học", "Tên môn học", "Số tín chỉ", "Bộ môn", "Ngày cập nhật", "Người cập nhật" }
                        , new int[] { 100, 250, 100, 150, 99, 99 });
            AppGridView.AlignHeader(gridViewMonTieuLuan, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "TenBoMon", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewMonTieuLuan, "MaMonHoc", repositoryItemGridLookUpEditMonHoc);
            AppGridView.HideField(gridViewMonTieuLuan, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion
            #region MonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 450, 600);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "TenBoMon" }, new string[] { "Mã môn học", "Tên môn học", "STC", "Bộ môn" }, new int[] { 100, 150, 50, 150 });
            repositoryItemGridLookUpEditMonHoc.DisplayMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.ValueMember = "MaMonHoc";
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
            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
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
            _listMonHoc = DataServices.ViewMonHocKhoa.GetAll();

            bindingSourceMonHoc.DataSource = _listMonHoc;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
             if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
             if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
             {
                 bindingSourceMonTieuLuan.DataSource = DataServices.KcqMonTieuLuan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(),cboHocKy.EditValue.ToString());
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
            AppGridView.DeleteSelectedRows(gridViewMonTieuLuan);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewMonTieuLuan.FocusedRowHandle = -1;
            TList<KcqMonTieuLuan> list = bindingSourceMonTieuLuan.DataSource as TList<KcqMonTieuLuan>;
            if (list != null)
            {
               
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (KcqMonTieuLuan d in list)
                            {
                                d.NamHoc = cboNamHoc.EditValue.ToString();
                                d.HocKy = cboHocKy.EditValue.ToString();

                            }     
                            bindingSourceMonTieuLuan.EndEdit();
                            DataServices.KcqMonTieuLuan.Save(list);
                            //PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewMonTieuLuan, barManager1, layoutControl1 });
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlMonTieuLuan.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void gridViewMonTieuLuan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaMonHoc")
            {
                int pos = e.RowHandle;
                KcqMonTieuLuan r = gridViewMonTieuLuan.GetRow(pos) as KcqMonTieuLuan;
                ViewMonHocKhoa v = _listMonHoc.Find(p => p.MaMonHoc == r.MaMonHoc);
                gridViewMonTieuLuan.SetRowCellValue(pos, "TenMonHoc", v.TenMonHoc);
                gridViewMonTieuLuan.SetRowCellValue(pos, "SoTinChi", v.SoTinChi);
                gridViewMonTieuLuan.SetRowCellValue(pos, "TenBoMon", v.TenBoMon);
                //gridViewMonTieuLuan.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                gridViewMonTieuLuan.SetRowCellValue(pos, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void gridViewMonTieuLuan_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewMonTieuLuan, e);
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceMonTieuLuan.DataSource = DataServices.KcqMonTieuLuan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceMonTieuLuan.DataSource = DataServices.KcqMonTieuLuan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
         
            Cursor.Current = Cursors.Default;
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHocHocKy_Kcq frm = new frmSaoChepNamHocHocKy_Kcq(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepKcqMonTieuLuan"))
            {
                frm.ShowDialog();
            }
        }

    }
}
