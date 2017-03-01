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

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucMonHocMoi : DevExpress.XtraEditors.XtraUserControl
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
        string _maTruong;
        VList<ViewLopHocPhan> _listLHP;
        #endregion
        public ucMonHocMoi()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucMonHocMoi_Load(object sender, EventArgs e)
        {
            #region Init Gridview
            AppGridView.InitGridView(gridViewMonHocMoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewMonHocMoi, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewMonHocMoi, new string[] { "MaLopHocPhan", "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopSinhVien", "MaGiangVien", "GhiChu", "NguoiCapNhat", "NgayCapNhat" },
                                                           new string[] { "Mã lớp học phần", "Mã môn học", "Tên môn học", "Số tín chỉ", "Lớp sinh viên", "Mã giảng viên", "Ghi chú", "NgayCapNhat", "NguoiCapNhat" },
                                                           new int[] { 120, 120, 80, 120, 150, 120, 150, 99, 99 });
            AppGridView.AlignHeader(gridViewMonHocMoi, new string[] { "MaLopHocPhan", "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopSinhVien", "MaGiangVien", "GhiChu", "NguoiCapNhat", "NgayCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewMonHocMoi, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopSinhVien" });
            AppGridView.RegisterControlField(gridViewMonHocMoi, "MaLopHocPhan", repositoryItemGridLookUpEditLopHocPhan);
            AppGridView.RegisterControlField(gridViewMonHocMoi, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.HideField(gridViewMonHocMoi, new string[] { "MaGiangVien", "NgayCapNhat", "NguoiCapNhat" });
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

            #region Init LopHocPhan
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLopHocPhan, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLopHocPhan, new string[] { "MaLopHocPhan", "MaMonHoc", "TenMonHoc", "MaLop" }, new string[] { "Mã lớp học phần", "Mã môn học", "Tên môn học", "Mã lớp sinh viên" }, new int[] { 110, 80, 150, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLopHocPhan, 460, 600);
            repositoryItemGridLookUpEditLopHocPhan.ValueMember = "MaLopHocPhan";
            repositoryItemGridLookUpEditLopHocPhan.DisplayMember = "MaLopHocPhan";
            repositoryItemGridLookUpEditLopHocPhan.NullText = string.Empty;
            #endregion

            #region Init GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Khoa - đơn vị" }, new int[] { 90, 170, 180 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 440, 600);
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion
            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                _listLHP = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                bindingSourceLopHocPhan.DataSource = _listLHP;
                bindingSourceMonHocMoi.DataSource = DataServices.ViewMonGiangMoi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
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
            AppGridView.DeleteSelectedRows(gridViewMonHocMoi);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewMonHocMoi.FocusedRowHandle = -1;
            VList<ViewMonGiangMoi> list = bindingSourceMonHocMoi.DataSource as VList<ViewMonGiangMoi>;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string xml = "";
                    foreach (ViewMonGiangMoi d in list)
                    {
                        xml += "<Input MH=\"" + d.MaMonHoc
                              + "\" LHP=\"" + d.MaLopHocPhan
                              + "\" GV=\"" + PMS.Common.Globals.IsNull(d.MaGiangVien, "int").ToString()
                              + "\" N=\"" + d.NgayCapNhat
                              + "\" U=\"" + d.NguoiCapNhat
                              + "\" G=\"" + d.GhiChu
                              + "\" />";
                    }
                    xml = "<Root>" + xml + "</Root>";
                    bindingSourceMonHocMoi.EndEdit();
                    int kq = 0;
                    DataServices.MonGiangMoi.Luu(xml, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Cursor.Current = Cursors.Default;
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
                            gridControlMonHocMoi.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (cboNamHoc.EditValue != null)
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    _listLHP = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    bindingSourceLopHocPhan.DataSource = _listLHP;
                    bindingSourceMonHocMoi.DataSource = DataServices.ViewMonGiangMoi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
                Cursor.Current = Cursors.Default;
            }
            catch
            { }
           
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    _listLHP = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    bindingSourceLopHocPhan.DataSource = _listLHP;
                    bindingSourceMonHocMoi.DataSource = DataServices.ViewMonGiangMoi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
                Cursor.Current = Cursors.Default;
            }
            catch
            { }
        }

        private void gridViewMonHocMoi_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaLopHocPhan" || col.FieldName == "MaMonHoc" || col.FieldName == "MaGiangVien" || col.FieldName == "GhiChu")
            {
                int pos = e.RowHandle;
                gridViewMonHocMoi.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewMonHocMoi.SetRowCellValue(pos, "NguoiCapNhat", UserInfo.UserName);
            }
            
            if (col.FieldName == "MaLopHocPhan")
            {
                int pos = e.RowHandle;
                ViewMonGiangMoi vm = gridViewMonHocMoi.GetRow(pos) as ViewMonGiangMoi;
                ViewLopHocPhan v = _listLHP.Find(p => p.MaLopHocPhan == vm.MaLopHocPhan);
                gridViewMonHocMoi.SetRowCellValue(pos, "MaMonHoc", v.MaMonHoc);
                gridViewMonHocMoi.SetRowCellValue(pos, "TenMonHoc", v.TenMonHoc);
                gridViewMonHocMoi.SetRowCellValue(pos, "SoTinChi", v.SoTinChi);
                gridViewMonHocMoi.SetRowCellValue(pos, "MaLopSinhVien", v.MaLop);
            }
        }

        private void gridViewMonHocMoi_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewMonHocMoi, e);
        }
    }
}
