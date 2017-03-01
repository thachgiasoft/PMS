using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;

namespace PMS.UI.Forms.HeThong
{
    public partial class frmNhatKy : XtraForm
    {
        public frmNhatKy()
        {
            InitializeComponent();
        }

        private void frmNhatKy_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewTaiKhoan, true, true, GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewTaiKhoan, new string[] { "MaNhomQuyen", "HoTen", "TenDangNhap", "TenMayTinh", "PhienBan", "NgayDangNhap" },
                new string[] { "Nhóm quyền", "Họ tên", "Tên truy cập", "Tên máy tính", "Phiên bản", "Ngày đăng nhập" },
                new int[] { 200, 200, 150, 150, 100, 150 });
            //Attach Control to GridView
            AppGridView.RegisterControlField(gridViewTaiKhoan, "MaNhomQuyen", repositoryItemGridLookUpEditNhomQuyen);
            AppGridView.RegisterControlField(gridViewTaiKhoan, "NgayDangNhap", repositoryItemTextEditNgayDangNhap);
            AppGridView.ReadOnlyColumn(gridViewTaiKhoan, new string[] { "MaNhomQuyen", "HoTen", "TenDangNhap", "TenMayTinh", "PhienBan", "NgayDangNhap" });
            #endregion

            #region RepositoryItemGridLookUpEdit Nhom Quyen
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomQuyen, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomQuyen, new string[] { "TenNhomQuyen" }, new string[] { "Tên nhóm quyền" });
            repositoryItemGridLookUpEditNhomQuyen.ValueMember = "MaNhomQuyen";
            repositoryItemGridLookUpEditNhomQuyen.DisplayMember = "TenNhomQuyen";
            repositoryItemGridLookUpEditNhomQuyen.NullText = string.Empty;

            #endregion

            #region Init Datasource
            bindingSourceTaiKhoan.DataSource = DataServices.TaiKhoan.GetAll();
            bindingSourceNhomQuyen.DataSource = DataServices.NhomQuyen.GetAll();
            #endregion
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceTaiKhoan.DataSource = DataServices.TaiKhoan.GetAll();
            bindingSourceNhomQuyen.DataSource = DataServices.NhomQuyen.GetAll();
            Cursor.Current = Cursors.Default;
        }
    }
}