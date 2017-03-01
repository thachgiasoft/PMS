using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using PMS.Services;
using PMS.Entities;
using PMS.Core;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Modules.DanhMuc.KhongChinhQuy
{
    public partial class ucCauHinhChotGio : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btn_Luu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btn_Luu.ShortCut = Shortcut.None;

                btn_Xoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btn_Xoa.ShortCut = Shortcut.None;
            }
            else
            {
                btn_Luu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btn_Xoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        TList<CauHinhChung> cauHinhchung = DataServices.CauHinhChung.GetAll();
        public ucCauHinhChotGio()
        {
            InitializeComponent();
        }

        private void ucCauHinhChotGio_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewCauHinhChotGio, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewCauHinhChotGio, new string[] { "MaQuanLy", "TenQuanLy", "TuNgay", "DenNgay", "IsLocked", "NamHoc", "HocKy" },
                new string[] { "Mã quản lý", "Tên quản lý", "Từ ngày", "Đến ngày", "Đã khóa", "Năm học", "Học kỳ"},
                new int[] { 150, 250, 120, 120,100,100,100 });
            AppGridView.ShowEditor(gridViewCauHinhChotGio, NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewCauHinhChotGio, "TuNgay", repositoryItemDateEdit1);
            AppGridView.RegisterControlField(gridViewCauHinhChotGio, "DenNgay", repositoryItemDateEdit2);
            AppGridView.HideField(gridViewCauHinhChotGio, new string[] { "NamHoc", "HocKy" });

            #region Nam Hoc
            AppGridLookupEdit.InitGridLookUp(cbNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cbNamHoc, 650, 300);
            AppGridLookupEdit.ShowField(cbNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" }, new int[] { 150 });
            cbNamHoc.Properties.DisplayMember = "NamHoc";
            cbNamHoc.Properties.ValueMember = "NamHoc";
            cbNamHoc.Properties.NullText = string.Empty;
            cbNamHoc.EditValue = cauHinhchung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cauHinhchung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri == null)
            {
                cbNamHoc.DataBindings.Clear();
                cbNamHoc.DataBindings.Add("EditValue", bindingSourceNamHoc, "NamHoc", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            #endregion
            
            
            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = cauHinhchung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            ViewNamHoc objNamHoc = bindingSourceNamHoc.Current as ViewNamHoc;
            if (cbNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cbNamHoc.EditValue.ToString());
            }
            if (cauHinhchung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri == null)
            {
                cboHocKy.DataBindings.Clear();
                cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            #endregion
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewCauHinhChotGio.FocusedRowHandle = -1;
            TList<KcqCauHinhChotGio> list = bindingSourceCauHinhChotGio.DataSource as TList<KcqCauHinhChotGio>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceCauHinhChotGio.EndEdit();
                            DataServices.KcqCauHinhChotGio.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewCauHinhChotGio, barManager1, layoutControl1 });
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewCauHinhChotGio);
        }

        private void btn_Phuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KcqCauHinhChotGio obj = bindingSourceCauHinhChotGio.Current as KcqCauHinhChotGio;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceCauHinhChotGio.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewCauHinhChotGio.RefreshData();
            }
        }

        private void btn_Lamtuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cbNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceCauHinhChotGio.DataSource = DataServices.KcqCauHinhChotGio.GetByNamHocHocKy(cbNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void cbNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cbNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cbNamHoc.EditValue.ToString());
            if (cbNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceCauHinhChotGio.DataSource = DataServices.KcqCauHinhChotGio.GetByNamHocHocKy(cbNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void gridViewCauHinhChotGio_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            if (cbNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                gridViewCauHinhChotGio.SetRowCellValue(gridViewCauHinhChotGio.FocusedRowHandle, "NamHoc", cbNamHoc.EditValue.ToString());
                gridViewCauHinhChotGio.SetRowCellValue(gridViewCauHinhChotGio.FocusedRowHandle, "HocKy", cboHocKy.EditValue.ToString());
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cbNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceCauHinhChotGio.DataSource = DataServices.KcqCauHinhChotGio.GetByNamHocHocKy(cbNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }


    }
}
