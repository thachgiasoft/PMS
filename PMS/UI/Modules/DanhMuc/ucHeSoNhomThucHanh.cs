using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using DevExpress.Common.Grid;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoNhomThucHanh : DevExpress.XtraEditors.XtraUserControl
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
        #endregion
        public ucHeSoNhomThucHanh()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucHeSoNhomThucHanh_Load(object sender, EventArgs e)
        {
            #region InitGridView
            switch (_maTruong)
            { 
                case "VHU":
                    InitGridView_VHU();
                    break;
                default:
                    InitGridDefault();
                    break;
            }
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
            
            #region Init NhomMonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomMonHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditNhomMonHoc, 300, 500);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomMonHoc, new string[] { "MaQuanLy", "TenNhomMon" }, new string[] { "Mã nhóm môn học", "Tên nhóm môn học" }, new int[] { 100, 200 });
            repositoryItemGridLookUpEditNhomMonHoc.DisplayMember = "TenNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditNhomMonHoc.NullText = string.Empty;
            #endregion
            #region BacDaoTao
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditBacDaoTao, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditBacDaoTao, new string[] { "MaBacDaoTao", "TenBacDaoTao" }, new string[] { "Mã bậc đào tạo", "Tên bậc đào tạo" }, new int[] { 100, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditBacDaoTao, 300, 400);
            repositoryItemGridLookUpEditBacDaoTao.ValueMember = "MaBacDaoTao";
            repositoryItemGridLookUpEditBacDaoTao.DisplayMember = "TenBacDaoTao";
            repositoryItemGridLookUpEditBacDaoTao.NullText = string.Empty;
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
            bindingSourceNhomMonHoc.DataSource = DataServices.NhomMonHoc.GetAll();
            bindingSourceBacDaoTao.DataSource = DataServices.ViewBacDaoTao.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSo.DataSource = DataServices.HeSoNhomThucHanh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion
        #region Init GridView
        void InitGridView_VHU()
        {
            AppGridView.InitGridView(gridViewHeSo, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSo, new string[] { "TuKhoan", "DenKhoan", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "Từ khoản", "Đến khoản", "Hệ số", "Ghi chú", "Ngày cập nhật", "Người cập nhật" },
                        new int[] { 100, 100, 100, 200, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSo, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSo, new string[] { "TuKhoan", "DenKhoan", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSo, "TuKhoan", repositoryItemSpinEditTuKhoan);
            AppGridView.RegisterControlField(gridViewHeSo, "DenKhoan", repositoryItemSpinEditDenKhoan);
            AppGridView.RegisterControlField(gridViewHeSo, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.HideField(gridViewHeSo, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitGridDefault()
        {
            AppGridView.InitGridView(gridViewHeSo, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSo, new string[] { "MaBacDaoTao", "MaNhomMonHoc", "TuKhoan", "DenKhoan", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "Bậc đào tạo", "Nhóm môn học", "Từ khoản", "Đến khoản", "Hệ số", "Ghi chú", "Ngày cập nhật", "Người cập nhật" },
                        new int[] { 120, 180, 100, 100, 100, 200, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSo, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSo, new string[] { "MaBacDaoTao", "MaNhomMonHoc", "TuKhoan", "DenKhoan", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSo, "MaNhomMonHoc", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.RegisterControlField(gridViewHeSo, "MaBacDaoTao", repositoryItemGridLookUpEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewHeSo, "TuKhoan", repositoryItemSpinEditTuKhoan);
            AppGridView.RegisterControlField(gridViewHeSo, "DenKhoan", repositoryItemSpinEditDenKhoan);
            AppGridView.RegisterControlField(gridViewHeSo, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.FormatDataField(gridViewHeSo, "HeSo", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.HideField(gridViewHeSo, new string[] { "NgayCapNhat", "NguoiCapNhat" });
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
            AppGridView.DeleteSelectedRows(gridViewHeSo);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSo.FocusedRowHandle = -1;
            TList<HeSoNhomThucHanh> list = bindingSourceHeSo.DataSource as TList<HeSoNhomThucHanh>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (HeSoNhomThucHanh d in list)
                            {
                                d.NamHoc = cboNamHoc.EditValue.ToString();
                                d.HocKy = cboHocKy.EditValue.ToString();
                            }
                            bindingSourceHeSo.EndEdit();
                            DataServices.HeSoNhomThucHanh.Save(list);
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

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlHeSo.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewHeSo_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "TuKhoan" || col.FieldName == "DenKhoan" || col.FieldName == "HeSo")
            {
                gridViewHeSo.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewHeSo.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void gridViewHeSo_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSo, e);
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSo.DataSource = DataServices.HeSoNhomThucHanh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceNhomMonHoc.DataSource = DataServices.HeSoNhomThucHanh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepHeSoNhomThucHanh"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepHeSoNhomThucHanh"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }
    }
}
