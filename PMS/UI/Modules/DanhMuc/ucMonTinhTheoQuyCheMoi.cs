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

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucMonTinhTheoQuyCheMoi : DevExpress.XtraEditors.XtraUserControl
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
        DataTable _listMonHoc = new DataTable();
        #endregion
        public ucMonTinhTheoQuyCheMoi()
        {
            InitializeComponent();
        }

        private void ucMonTinhTheoQuyCheMoi_Load(object sender, EventArgs e)
        {
            #region InitGrid
            AppGridView.InitGridView(gridViewMonHoc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            //AppGridView.ShowEditor(gridViewMonHoc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewMonHoc, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "Chon", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Mã môn học", "Tên môn học", "Số tín chỉ", "Chọn", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 90, 200, 100, 80, 99, 99 });
            AppGridView.AlignHeader(gridViewMonHoc, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "Chon", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewMonHoc, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            //AppGridView.RegisterControlField(gridViewMonHoc, "MaMonHoc", repositoryItemGridLookUpEditMonHoc);
            AppGridView.SummaryField(gridViewMonHoc, "MaMonHoc", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewMonHoc, "Chon", "{0}", DevExpress.Data.SummaryItemType.Sum);
            #endregion

            #region MonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 400, 650);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi" }, new string[] { "Mã môn học", "Tên môn học", "Số tín chỉ" }, new int[] { 100, 200, 100 });
            repositoryItemGridLookUpEditMonHoc.DisplayMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.ValueMember = "MaMonHoc";
            repositoryItemGridLookUpEditMonHoc.NullText = string.Empty;
            #endregion


            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            InitData();
        }
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            if (cboNamHoc != null && cboHocKy.EditValue != null)
            {
                IDataReader reader = DataServices.ViewMonHoc.GetBYNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                _listMonHoc.Load(reader);
                bindingSourceMonHoc.DataSource = _listMonHoc;
                bindingSourceMonHocQuyCheMoi.DataSource = DataServices.ViewMonTinhTheoQuyCheMoi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()); 
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
            AppGridView.DeleteSelectedRows(gridViewMonHoc);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewMonHoc.FocusedRowHandle = -1;
            VList<ViewMonTinhTheoQuyCheMoi> list = bindingSourceMonHocQuyCheMoi.DataSource as VList<ViewMonTinhTheoQuyCheMoi>;
            if (list != null)
            {
                string xmlData = "";
                foreach (ViewMonTinhTheoQuyCheMoi d in list)
                {
                    if (d.Chon == true)
                    {
                        xmlData += "<Input M=\"" + d.MaMonHoc
                             + "\" N=\"" + d.NgayCapNhat
                             + "\" U=\"" + d.NguoiCapNhat
                             + "\" />";
                    }
                }
                xmlData = "<Root>" + xmlData + "</Root>";
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        int kq = 0;
                        bindingSourceMonHocQuyCheMoi.EndEdit();
                        DataServices.MonTinhTheoQuyCheMoi.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
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

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            if (cboNamHoc != null && cboHocKy.EditValue != null)
            {
                IDataReader reader = DataServices.ViewMonHoc.GetBYNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                _listMonHoc.Load(reader);
                bindingSourceMonHoc.DataSource = _listMonHoc;

                bindingSourceMonHocQuyCheMoi.DataSource = DataServices.ViewMonTinhTheoQuyCheMoi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()); 
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc != null && cboHocKy.EditValue != null)
            {
                IDataReader reader = DataServices.ViewMonHoc.GetBYNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                _listMonHoc.Load(reader);
                bindingSourceMonHoc.DataSource = _listMonHoc;

                bindingSourceMonHocQuyCheMoi.DataSource = DataServices.ViewMonTinhTheoQuyCheMoi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()); 
            }
        }

        private void gridViewMonHoc_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaMonHoc")
            {
                ViewMonTinhTheoQuyCheMoi v = gridViewMonHoc.GetRow(e.RowHandle) as ViewMonTinhTheoQuyCheMoi;
                DataRow dr = null;
                try
                {
                    dr = _listMonHoc.Select("MaMonHoc='" + v.MaMonHoc + "'")[0];
                }
                catch
                {
                    XtraMessageBox.Show("Kiểm tra lại mã môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
                gridViewMonHoc.SetRowCellValue(e.RowHandle, "TenMonHoc", dr["TenMonHoc"].ToString());
                gridViewMonHoc.SetRowCellValue(e.RowHandle, "SoTinChi", dr["SoTinChi"].ToString());
                gridViewMonHoc.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewMonHoc.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void gridViewMonHoc_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewMonHoc, e);
        }

        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChonTatCa.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewMonHoc.DataRowCount; i++)
                {
                    gridViewMonHoc.SetRowCellValue(i, "Chon", "True");
                }
            }
            if (checkEditChonTatCa.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewMonHoc.DataRowCount; i++)
                {
                    gridViewMonHoc.SetRowCellValue(i, "Chon", "False");
                }
            }
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepMonTinhTheoQuyCheMoi"))
            {
                frm.ShowDialog();
            }
        }
    }
}
