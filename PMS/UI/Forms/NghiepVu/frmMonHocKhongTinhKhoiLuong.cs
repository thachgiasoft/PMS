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
using PMS.BLL;
using DevExpress.XtraGrid.Columns;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmMonHocKhongTinhKhoiLuong : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ShortCut = Shortcut.None;

                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoa.ShortCut = Shortcut.None;

                barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem1.ShortCut = Shortcut.None;
            }
            else
            {
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Bien
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        //VList<ViewMonHocKhoa> _listMonHoc;
        VList<ViewLopHocPhan> _listLopHocPhan;
        string _maTruong;
        #endregion

        public frmMonHocKhongTinhKhoiLuong()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri.ToString();
        }

        private void frmMonHocKhongTinhKhoiLuong_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewMonKhongTinh, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewMonKhongTinh, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewMonKhongTinh, new string[] { "MaMonHoc", "TenMonHoc", "TenBoMon", "NgayCapNhat", "NguoiCapNhat" }
                        , new string[] { "Mã lớp học phần", "Tên môn học", "Nhóm", "Ngày cập nhật", "Người cập nhật" }
                        , new int[] { 150, 250, 150, 99, 99 });
            AppGridView.AlignHeader(gridViewMonKhongTinh, new string[] { "MaMonHoc", "TenMonHoc", "TenBoMon", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewMonKhongTinh, "MaMonHoc", repositoryItemGridLookUpEditMonHoc);
            AppGridView.HideField(gridViewMonKhongTinh, new string[] { "NgayCapNhat", "NguoiCapNhat" });
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
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            //#region MonHoc
            //AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, TextEditStyles.Standard);
            //AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 450, 600);
            //AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "TenBoMon" }, new string[] { "Mã môn học", "Tên môn học", "STC", "Bộ môn" }, new int[] { 100, 150, 50, 150 });
            //repositoryItemGridLookUpEditMonHoc.DisplayMember = "MaMonHoc";
            //repositoryItemGridLookUpEditMonHoc.ValueMember = "MaMonHoc";
            //repositoryItemGridLookUpEditMonHoc.NullText = string.Empty;
            //#endregion
            #region LopHocPhan
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMonHoc, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditMonHoc, 560, 650);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMonHoc, new string[] { "MaLopHocPhan", "MaMonHoc", "TenMonHoc", "MaLop", "Nhom" }, new string[] { "Mã lớp học phần", "Mã môn học", "Tên môn học", "Mã lớp sinh viên", "Nhóm" }, new int[] { 110, 100, 150, 100, 100 });
            repositoryItemGridLookUpEditMonHoc.DisplayMember = "MaLopHocPhan";
            repositoryItemGridLookUpEditMonHoc.ValueMember = "MaLopHocPhan";
            repositoryItemGridLookUpEditMonHoc.NullText = string.Empty;
            #endregion
            InitData();
        }
        #region InitData
        void InitData()
        {
            //_listMonHoc= DataServices.ViewMonHocKhoa.GetAll();
            
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                _listLopHocPhan = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bindingSourceMonHoc.DataSource = _listLopHocPhan;
                bindingSourceMonKhongTinh.DataSource = DataServices.MonHocKhongTinhKhoiLuong.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
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
            AppGridView.DeleteSelectedRows(gridViewMonKhongTinh);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewMonKhongTinh.FocusedRowHandle = -1;
            TList<MonHocKhongTinhKhoiLuong> list = bindingSourceMonKhongTinh.DataSource as TList<MonHocKhongTinhKhoiLuong>;
            if (list != null)
            {
                foreach (MonHocKhongTinhKhoiLuong d in list)
                {
                    d.NamHoc = cboNamHoc.EditValue.ToString();
                    d.HocKy = cboHocKy.EditValue.ToString();
                }
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceMonKhongTinh.EndEdit();
                            DataServices.MonHocKhongTinhKhoiLuong.Save(list);
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

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepMonKhongTinhKhoiLuong"))
            {
                frm.ShowDialog();
            }
            InitData();
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
                        gridControlMonKhongTinh.ExportToXls(sf.FileName);
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
                _listLopHocPhan = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bindingSourceMonHoc.DataSource = _listLopHocPhan;
                bindingSourceMonKhongTinh.DataSource = DataServices.MonHocKhongTinhKhoiLuong.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                _listLopHocPhan = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bindingSourceMonHoc.DataSource = _listLopHocPhan;
                bindingSourceMonKhongTinh.DataSource = DataServices.MonHocKhongTinhKhoiLuong.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewMonKhongTinh_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaMonHoc")
            {
                int pos = e.RowHandle;
                MonHocKhongTinhKhoiLuong r = gridViewMonKhongTinh.GetRow(pos) as MonHocKhongTinhKhoiLuong;
                ViewLopHocPhan v = _listLopHocPhan.Find(p => p.MaLopHocPhan == r.MaMonHoc);
                gridViewMonKhongTinh.SetRowCellValue(pos, "TenMonHoc", v.TenMonHoc);
                //gridViewMonKhongTinh.SetRowCellValue(pos, "SoTinChi", v.MaLop);
                gridViewMonKhongTinh.SetRowCellValue(pos, "TenBoMon", v.Nhom);
                //gridViewMonKhongTinh.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                gridViewMonKhongTinh.SetRowCellValue(pos, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void gridViewMonKhongTinh_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewMonKhongTinh, e);
        }
    }
}