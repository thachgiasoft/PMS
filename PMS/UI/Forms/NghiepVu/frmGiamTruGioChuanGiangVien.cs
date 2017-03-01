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
using DevExpress.XtraGrid.Columns;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmGiamTruGioChuanGiangVien : DevExpress.XtraEditors.XtraForm
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
        #endregion
        public frmGiamTruGioChuanGiangVien()
        {
            InitializeComponent();
        }

        private void frmGiamTruGioChuanGiangVien_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewGiamTruGioChuanGiangVien, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewGiamTruGioChuanGiangVien, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewGiamTruGioChuanGiangVien, new string[] { "MaGiangVien", "MaGiamTru", "PhanTramGiamTru" }
                        , new string[] { "Họ và tên", "Lý do giảm trừ", "Phần trăm giảm trừ" }
                        , new int[] { 150, 300, 150 });
            AppGridView.AlignHeader(gridViewGiamTruGioChuanGiangVien, new string[] { "MaGiangVien", "MaGiamTru", "PhanTramGiamTru" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewGiamTruGioChuanGiangVien, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewGiamTruGioChuanGiangVien, "MaGiamTru", repositoryItemGridLookUpEditGiamTruDinhMuc);
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "NgaySinh" },
                    new string[] { "Mã giảng viên", "Họ và tên", "Ngày sinh" }, new int[] { 100, 200, 150 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 450, 400);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "HoTen";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region GiamTruDinhMuc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiamTruDinhMuc, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiamTruDinhMuc, new string[] { "NoiDungGiamTru", "PhanTramGiamTru" },
                    new string[] { "Nội dung giảm trừ", "Phần trăm giảm trừ" }, new int[] { 300, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiamTruDinhMuc, 400, 350);
            repositoryItemGridLookUpEditGiamTruDinhMuc.DisplayMember = "NoiDungGiamTru";
            repositoryItemGridLookUpEditGiamTruDinhMuc.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiamTruDinhMuc.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiamTruDinhMuc.DataSource = DataServices.GiamTruDinhMuc.GetAll();
            bindingSourceGiamTruGioChuanGiangVien.DataSource = DataServices.GiangVienGiamTruDinhMuc.GetByNamHoc(cboNamHoc.EditValue.ToString());
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiamTruGioChuanGiangVien);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewGiamTruGioChuanGiangVien.FocusedRowHandle = -1;
            TList<GiangVienGiamTruDinhMuc> list = bindingSourceGiamTruGioChuanGiangVien.DataSource as TList<GiangVienGiamTruDinhMuc>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thy đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (list.IsValid)
                    {
                        foreach (GiangVienGiamTruDinhMuc i in list)
                        {
                            i.NamHoc = cboNamHoc.EditValue.ToString();
                        }
                        
                        try
                        {
                            bindingSourceGiamTruGioChuanGiangVien.EndEdit();
                            DataServices.GiangVienGiamTruDinhMuc.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void gridViewGiamTruGioChuanGiangVien_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            int pos = e.RowHandle;
            object r = gridViewGiamTruGioChuanGiangVien.GetRow(pos);
            GiangVienGiamTruDinhMuc g = (GiangVienGiamTruDinhMuc)r;
            if (col.FieldName == "MaGiamTru")
            {
                if (g.MaGiamTru != null)
                {
                    GiamTruDinhMuc dm = DataServices.GiamTruDinhMuc.GetByMaQuanLy((int)g.MaGiamTru);
                    if (dm != null)
                    {
                        gridViewGiamTruGioChuanGiangVien.SetRowCellValue(pos, "PhanTramGiamTru", dm.PhanTramGiamTru);
                    }
                }
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceGiamTruGioChuanGiangVien.DataSource = DataServices.GiangVienGiamTruDinhMuc.GetByNamHoc(cboNamHoc.EditValue.ToString());
        }

        private void gridViewGiamTruGioChuanGiangVien_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiamTruGioChuanGiangVien, e);
        }
    }
}
